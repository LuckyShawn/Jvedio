Imports System.ComponentModel
Imports System.Data.OleDb
Imports ShareClass.ChaoSub
Public Class FormQuickEdit


    Private Sub Chao_Button2_Click(sender As Object, e As EventArgs) Handles Chao_Button2.Click
        Me.Close()
    End Sub

    Private Sub FormQuickEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Location = New Point(12, 71)
        SetSkin()
    End Sub

    Public Sub SetSkin()
        Dim SC = New ShareClass.Skin(Settings.SkinStyle)
        Me.BackColor = SC.BC2
        TitlePanel.BackColor = SC.BC1
        FormTextLabel.ForeColor = SC.FC2
        Panel1.BackColor = SC.BC2

        ComboBox1.BackColor = SC.BC2
        ComboBox1.ForeColor = SC.FC2

        ComboBox2.BackColor = SC.BC2
        ComboBox2.ForeColor = SC.FC2

        Label1.BackColor = SC.BC2
        Label1.ForeColor = SC.FC2

        TextBox1.BackColor = SC.BC2
        TextBox1.ForeColor = SC.FC2


        Chao_CheckBox1.BackColor = SC.BC2
        Chao_CheckBox1.CheckTextColor = SC.FC2

        Chao_CheckBox2.BackColor = SC.BC2
        Chao_CheckBox2.CheckTextColor = SC.FC2

        Chao_CheckBox3.BackColor = SC.BC2
        Chao_CheckBox3.CheckTextColor = SC.FC2

    End Sub

    Private Sub Chao_Button1_Click(sender As Object, e As EventArgs) Handles Chao_Button1.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim myDataAdapter As New OleDbDataAdapter()
        Dim shipinleixing As Integer = ComboBox1.SelectedIndex
        Dim love As Integer = ComboBox2.SelectedIndex
        Dim biaoqian As String = TextBox1.Text
        Try
            con.ConnectionString = con_ConnectionString
            con.Open()
            cmd.Connection = con
            Dim sql As String = ""
            Dim fanhao As String = ""
            For Each item In EditList
                fanhao = New ShareClass.DataBase("select * from Main where ID=" & item).GetInfo("fanhao")
                If Chao_CheckBox1.Checked Then
                    sql = "update Main set shipinleixing = '" & shipinleixing & "' where fanhao = '" & fanhao & "'"
                    cmd.CommandText = sql
                    myDataAdapter.UpdateCommand = cmd
                    cmd.ExecuteNonQuery()
                End If

                If Chao_CheckBox3.Checked Then
                    sql = "update Main set  biaoqian = '" & ShareClass.ChaoSub.FormatDataBaseInfo(biaoqian) & "' where fanhao = '" & fanhao & "'"
                    cmd.CommandText = sql
                    myDataAdapter.UpdateCommand = cmd
                    cmd.ExecuteNonQuery()
                End If

                If Chao_CheckBox2.Checked Then
                    sql = "update Main set love='" & love & "' where fanhao = '" & fanhao & "'"
                    cmd.CommandText = sql
                    myDataAdapter.UpdateCommand = cmd
                    cmd.ExecuteNonQuery()
                End If

            Next
            con.Close()
            MsgBox("成功！",, "保存成功")
            Me.Close()
        Catch ex As Exception
            ShareClass.ChaoSub.WriteLog(ex)
        Finally
            If con IsNot Nothing Then con.Close()
        End Try
    End Sub

    Private Sub Chao_CheckBox1_CheckedChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles Chao_CheckBox1.CheckedChanged
        ComboBox1.Enabled = Chao_CheckBox1.Checked
    End Sub

    Private Sub Chao_CheckBox2_CheckedChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles Chao_CheckBox2.CheckedChanged
        ComboBox2.Enabled = Chao_CheckBox2.Checked
    End Sub

    Private Sub Chao_CheckBox3_CheckedChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles Chao_CheckBox3.CheckedChanged
        TextBox1.Enabled = Chao_CheckBox3.Checked
    End Sub



    Private Sub FormQuickEdit_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Settings.EditSPLX = Chao_CheckBox1.Checked
        Settings.EditLove = Chao_CheckBox2.Checked
        Settings.EditBiaoqian = Chao_CheckBox3.Checked
        Settings.Save()
    End Sub

    Private Async Sub FormQuickEdit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '标签为含所有标签的集合
        Panel1.Visible = True
        Chao_CheckBox1.Checked = Settings.EditSPLX
        Chao_CheckBox2.Checked = Settings.EditLove
        Chao_CheckBox3.Checked = Settings.EditBiaoqian

        Dim DicSPLX As New Dictionary(Of String, Integer)
        Dim DicLove As New Dictionary(Of String, Integer)
        Dim bq As String = ""
        Dim BqList As New List(Of String)
        Await Task.Run(Sub()
                           '视频类型与喜爱程度默认为个数最多的
                           For Each item In EditList
                               Dim SPLX As String = New ShareClass.DataBase("select * from Main where ID=" & item).GetInfo("shipinleixing")
                               Dim love As String = New ShareClass.DataBase("select * from Main where ID=" & item).GetInfo("love")
                               Dim biaoqian As String() = Split(New ShareClass.DataBase("select * from Main where ID=" & item).GetInfo("biaoqian"), " ")
                               If DicSPLX.ContainsKey(SPLX) Then DicSPLX(SPLX) += 1 Else DicSPLX.Add(SPLX, 1)
                               If DicLove.ContainsKey(love) Then DicLove(love) += 1 Else DicLove.Add(love, 1)

                               For Each it In biaoqian
                                   it = Juncode(it)
                                   If InStr(it, " ") <= 0 And Len(it) > 0 Then
                                       If Not BqList.Contains(it) Then
                                           BqList.Add(it)
                                       End If
                                   End If
                               Next


                           Next
                           Sort(DicSPLX)
                           Sort(DicLove)
                           '标签加载全部
                       End Sub)

        For Each it In BqList
            If InStr(it, " ") <= 0 And Len(it) > 0 Then bq = bq & it & " "
        Next

        ComboBox1.SelectedIndex = Int(DicSPLX.ElementAt(0).Key)
        ComboBox2.SelectedIndex = Int(DicLove.ElementAt(0).Key)
        If Len(bq) > 0 Then TextBox1.Text = Mid(bq, 1, Len(bq) - 1) Else TextBox1.Text = ""

        Panel1.Visible = False
    End Sub

    Private Sub FormQuickEdit_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        '消除周围白线
        e.Graphics.Clear(Me.BackColor)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(34, 37, 42), 2), 0, 0, Me.Width, 0)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), Me.Width, 0, Me.Width, Me.Height)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), Me.Width, Me.Height, 0, Me.Height)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), 0, Me.Height, 0, 0)
    End Sub
End Class


