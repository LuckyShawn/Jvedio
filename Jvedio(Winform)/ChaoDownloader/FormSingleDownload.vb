Imports ShareClass.Identify

Public Class FormSingleDownload
    Private Sub Chao_Button1_Click(sender As Object, e As EventArgs) Handles Chao_Button1.Click
        OpenFileDialog1.Title = "选择一个视频"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "视频文件(*.avi, *.mp4, *.mkv, *.mpg, *.rmvb, *.rm, *.mov, *.mpeg, *.flv, *.wmv, *.m4v)|*.avi; *.mp4; *.mkv; *.mpg; *.rmvb; *.rm; *.mov; *.mpeg; *.flv; *.wmv; *.m4v|All files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Debug.Print(OpenFileDialog1.FileName)
            If OpenFileDialog1.FileName <> "" Then
                Chao_TextBox1.Text = OpenFileDialog1.FileName
                'Chao_TextBox2.Text = GetFanhao(Chao_TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub Chao_TextBox1_TextChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles Chao_TextBox1.TextChanged
        Chao_TextBox2.Text = GetFanhao(Chao_TextBox1.Text)
    End Sub

    Private Sub Chao_Button2_Click(sender As Object, e As EventArgs) Handles Chao_Button2.Click
        If Chao_TextBox2.Text = "" Then MsgBox("识别码不能为空！",, "提示") : Exit Sub
        If DownLoadingList.Count > 0 Then MsgBox("等待本次下载完成",, "提示") : Exit Sub
        If Not DownLoadList.Contains(Chao_TextBox2.Text) Then
            DownLoadList.Add(Chao_TextBox2.Text)
            FormMain.Label6.Text = Split(FormMain.Label6.Text, "/")(0) & "/" & DownLoadList.Count
            FormMain.Label4.Text = "添加成功，请点击开始下载"
        End If
    End Sub


    Sub Download()


    End Sub

    Private Sub Chao_TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Chao_TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Chao_Button2_Click(Me, New EventArgs)
        End If
    End Sub

    Private Sub FormSingleDownload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Chao_TextBox1.Text = "IPX-450"
    End Sub
End Class