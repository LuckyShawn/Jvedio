Public Class FormImportInfo
    Private Sub Daoruxiangqing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        For Each s In ChongFuFanhaoList
            ListBox1.Items.Add(s.SubItems(0).Text)
        Next
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MsgBox("【导入】选项会覆盖数据库中原有的内容", , "提示")
    End Sub
End Class