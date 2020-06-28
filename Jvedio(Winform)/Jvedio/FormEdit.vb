Imports System.Data.OleDb
Imports ShareClass.Identify
Imports ShareClass.ChaoFile
Imports ShareClass.ChaoSub

Public Class FormEdit


    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormDataBase()
        SetSkin()
    End Sub

    Public Sub SetSkin()
        Dim SC = New ShareClass.Skin(Settings.SkinStyle)
        Me.BackColor = SC.BC2
        TitlePanel.BackColor = SC.BC1
        FormTextLabel.ForeColor = SC.FC1
        For Each item In Me.Controls
            If item.GetType.ToString = "System.Windows.Forms.TextBox" Then
                Dim Tb As TextBox = item
                Tb.BackColor = SC.BC2
                Tb.ForeColor = SC.FC2
                Tb.BorderStyle = BorderStyle.FixedSingle
            ElseIf item.GetType.ToString = "System.Windows.Forms.Label" Then
                Dim Label As Label = item
                Label.BackColor = SC.BC2
                Label.ForeColor = SC.FC2
            End If
        Next

        ComboBox1.BackColor = SC.BC2
        ComboBox1.ForeColor = SC.FC2

        ComboBox2.BackColor = SC.BC2
        ComboBox2.ForeColor = SC.FC2



    End Sub

    Private Sub LoadFormDataBase()
        Dim VI As New ShareClass.Variable.VedioInfo
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Try
            con.ConnectionString = con_ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select * from Main where ID=" & GlobalID
            dr = cmd.ExecuteReader


            While (dr.Read)
                VI.ID = CType(dr.Item("ID").ToString, Double)
                VI.fanhao = dr.Item("fanhao").ToString
                VI.mingcheng = Juncode(dr.Item("mingcheng").ToString)
                VI.shipinleixing = CType(dr.Item("shipinleixing").ToString, Integer)
                VI.wenjiandaxiao = CType(dr.Item("wenjiandaxiao").ToString, Double)
                VI.weizhi = dr.Item("weizhi").ToString
                VI.daorushijian = dr.Item("daorushijian").ToString
                If dr.Item("fangwencishu").ToString = "" Then
                    VI.fangwencishu = 0
                Else
                    VI.fangwencishu = Int(dr.Item("fangwencishu"))
                End If
                VI.faxingriqi = dr.Item("faxingriqi").ToString
                If dr.Item("changdu").ToString = "" Then
                    VI.changdu = 0
                Else
                    VI.changdu = Int(dr.Item("changdu"))
                End If
                VI.zhizuoshang = Juncode(dr.Item("zhizuoshang").ToString)
                VI.faxingshang = Juncode(dr.Item("faxingshang").ToString)
                VI.daoyan = Juncode(dr.Item("daoyan").ToString)
                VI.leibie = Juncode(dr.Item("leibie").ToString)
                VI.yanyuan = Juncode(dr.Item("yanyuan").ToString)
                VI.xilie = Juncode(dr.Item("xilie").ToString)
                If dr.Item("love").ToString = "" Then
                    VI.love = 0
                Else
                    VI.love = Int(dr.Item("love"))
                End If
                VI.biaoqian = Juncode(dr.Item("biaoqian").ToString)
                VI.weizhi = dr.Item("weizhi").ToString
                VI.wenjiandaxiao = CType(dr.Item("wenjiandaxiao").ToString, Double)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception

        Finally
            If con IsNot Nothing Then con.Close()
        End Try


        Label16.Text = VI.ID
        TextBox2.Text = VI.fanhao
        TextBox3.Text = VI.mingcheng
        TextBox6.Text = VI.changdu
        TextBox7.Text = VI.zhizuoshang
        TextBox8.Text = VI.faxingshang
        TextBox1.Text = VI.daoyan
        TextBox4.Text = VI.leibie
        TextBox5.Text = VI.yanyuan
        TextBox9.Text = VI.xilie
        TextBox10.Text = VI.biaoqian
        TextBox11.Text = VI.weizhi
        Label18.Text = getFileSize(VI.wenjiandaxiao)
        ComboBox1.SelectedIndex = VI.shipinleixing

        If VI.faxingriqi <> "" Then
            Try
                Dim t = Split(VI.faxingriqi, "-")
                DateTimePicker1.Value = New DateTime(t(0), t(1), t(2))
            Catch ex As Exception

            End Try
        End If
        ComboBox2.SelectedIndex = VI.love
    End Sub





    Private Sub Chao_Button1_Click(sender As Object, e As EventArgs) Handles Chao_Button1.Click
        If TextBox2.Text = "" Then MsgBox("识别码不能为空！",, "提示") : Exit Sub

        '保存
        Dim VI As ShareClass.Variable.VedioInfo
        VI.ID = Label16.Text
        VI.fanhao = ShareClass.ChaoSub.FormatDataBaseInfo(TextBox2.Text, 1)
        VI.mingcheng = ShareClass.ChaoSub.FormatDataBaseInfo(TextBox3.Text)
        VI.changdu = IIf(IsNumeric(TextBox6.Text), TextBox6.Text, 0)
        VI.zhizuoshang = ShareClass.ChaoSub.FormatDataBaseInfo(TextBox7.Text)
        VI.faxingshang = ShareClass.ChaoSub.FormatDataBaseInfo(TextBox8.Text)
        VI.daoyan = ShareClass.ChaoSub.FormatDataBaseInfo(TextBox1.Text)
        VI.leibie = ShareClass.ChaoSub.FormatDataBaseInfo(TextBox4.Text)
        VI.yanyuan = ShareClass.ChaoSub.FormatDataBaseInfo(TextBox5.Text)
        VI.xilie = ShareClass.ChaoSub.FormatDataBaseInfo(TextBox9.Text)
        VI.biaoqian = ShareClass.ChaoSub.FormatDataBaseInfo(TextBox10.Text)
        VI.shipinleixing = ComboBox1.SelectedIndex
        VI.faxingriqi = DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day
        VI.love = ComboBox2.SelectedIndex
        VI.weizhi = TextBox11.Text
        If IO.File.Exists(VI.weizhi) Then
            VI.wenjiandaxiao = My.Computer.FileSystem.GetFileInfo(VI.weizhi).Length
        Else
            VI.wenjiandaxiao = 0
        End If
        'Try
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim myDataAdapter As New OleDbDataAdapter()
        con.ConnectionString = con_ConnectionString
            con.Open()
            cmd.Connection = con
            Dim sql As String = "update Main set fanhao = '" & VI.fanhao & "', mingcheng = '" & VI.mingcheng & "', changdu = " & VI.changdu &
            ", zhizuoshang = '" & VI.zhizuoshang & "', faxingshang = '" & VI.faxingshang & "', daoyan = '" &
             VI.daoyan & "', xilie = '" & VI.xilie & "', leibie = '" & VI.leibie & "', yanyuan = '" & VI.yanyuan & "',biaoqian='" & VI.biaoqian &
            "',shipinleixing=" & VI.shipinleixing & ",faxingriqi='" & VI.faxingriqi & "',love=" & VI.love & ",weizhi='" & VI.weizhi & "',wenjiandaxiao=" & VI.wenjiandaxiao
            cmd.CommandText = sql & " where ID = " & VI.ID
            myDataAdapter.UpdateCommand = cmd
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("成功！",, "保存成功")
            Me.Close()


    End Sub

    Private Sub Chao_Button2_Click(sender As Object, e As EventArgs) Handles Chao_Button2.Click
        Me.Close()
    End Sub

    Private Sub SetPicB_Click(sender As Object, e As EventArgs) Handles SetPicB.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "选择一个视频"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "常见视频文件(*.avi, *.mp4, *.mkv, *.mpg, *.rmvb)| *.avi; *.mp4; *.mkv; *.mpg; *.rmvb|其它视频文件((*.rm, *.mov, *.mpeg, *.flv, *.wmv, *.m4v)| *.rm; *.mov; *.mpeg; *.flv; *.wmv; *.m4v|所有文件 (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Debug.Print(OpenFileDialog1.FileName)
            If OpenFileDialog1.FileName <> "" Then
                TextBox11.Text = OpenFileDialog1.FileName
                TextBox2.Text = GetFanhao(TextBox11.Text)
                Label18.Text = getFileSize(My.Computer.FileSystem.GetFileInfo(TextBox11.Text).Length)
            End If
        End If
    End Sub

    Private Sub FormEdit_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        '消除周围白线
        e.Graphics.Clear(Me.BackColor)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(34, 37, 42), 2), 0, 0, Me.Width, 0)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), Me.Width, 0, Me.Width, Me.Height)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), Me.Width, Me.Height, 0, Me.Height)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), 0, Me.Height, 0, 0)
    End Sub
End Class