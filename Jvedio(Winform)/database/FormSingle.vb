Imports System.Data.OleDb
Imports ShareClass.ChaoSub
Imports ShareClass.ChaoFile
Imports ShareClass.Identify


Public Class FormSingle


    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub






    Private Sub Chao_Button1_Click(sender As Object, e As EventArgs) Handles Chao_Button1.Click
        If TextBox2.Text = "" Then MsgBox("识别码不能为空！",, "识别码不能为空") : Exit Sub



        '保存
        Dim VI As VedioInfo
        VI.weizhi = FormatDataBaseInfo(TextBox11.Text, 1)
        VI.fanhao = FormatDataBaseInfo(TextBox2.Text, 1)
        VI.wenjiandaxiao = My.Computer.FileSystem.GetFileInfo(VI.weizhi).Length
        VI.mingcheng = FormatDataBaseInfo(TextBox3.Text)
        VI.changdu = IIf(IsNumeric(TextBox6.Text), TextBox6.Text, 0)
        VI.zhizuoshang = FormatDataBaseInfo(TextBox7.Text)
        VI.faxingshang = FormatDataBaseInfo(TextBox8.Text)
        VI.daoyan = FormatDataBaseInfo(TextBox1.Text)
        VI.leibie = FormatDataBaseInfo(TextBox4.Text)
        VI.yanyuan = FormatDataBaseInfo(TextBox5.Text)
        VI.xilie = FormatDataBaseInfo(TextBox9.Text)
        VI.biaoqian = FormatDataBaseInfo(TextBox10.Text)
        VI.shipinleixing = ComboBox1.SelectedIndex
        VI.faxingriqi = DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day
        VI.love = ComboBox2.SelectedIndex
        VI.daorushijian = Now.ToString("yyyyMMddHHmmss")
        VI.fangwencishu = 0

        Dim FileP As String = New ShareClass.DataBase("select * from Main where ID=" & VI.fanhao).GetInfo("weizhi")
        If FileP <> "" Then
            If IO.File.Exists(FileP) Then
                MsgBox("数据库已存在！",, "数据库已存在！")
                Exit Sub
            End If
        Else
            '数据库不存在信息
            Dim con As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim myDataAdapter As New OleDbDataAdapter()
            Try

                con.ConnectionString = con_ConnectionString
                con.Open()
                cmd.Connection = con '初始化OLEDB命令的连接属性为con
                Dim sql As String
                sql = "insert into Main (fanhao,mingcheng,changdu,weizhi,wenjiandaxiao,shipinleixing,daorushijian,love,zhizuoshang,faxingshang,daoyan,xilie,leibie,yanyuan,biaoqian,faxingriqi,fangwencishu) values('" &
                    VI.fanhao & "','" & VI.mingcheng & "'," & VI.changdu & ",'" & VI.weizhi & "'," & VI.wenjiandaxiao & "," & VI.shipinleixing &
                    ",'" & VI.daorushijian & "'," & VI.love & ",'" & VI.zhizuoshang & "','" & VI.faxingshang & "','" & VI.daoyan & "','" & VI.xilie & "','" & VI.leibie & "','" & VI.yanyuan & "','" & VI.biaoqian & "','" & VI.faxingriqi & "',0)"
                Console.WriteLine(sql)
                cmd.CommandText = sql
                myDataAdapter.UpdateCommand = cmd
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("导入成功！",, "保存成功")
                Me.Close()
            Catch ex As Exception
            Finally
                If con IsNot Nothing Then con.Close()
            End Try
        End If






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
                Label16.Text = getFileSize(My.Computer.FileSystem.GetFileInfo(TextBox11.Text).Length)
                ComboBox1.SelectedIndex = GetVedioType(TextBox2.Text)
                ComboBox2.SelectedIndex = 0
                TextBox6.Text = 0
            End If
        End If
    End Sub
End Class