Imports ShareClass.ChaoFile
Public Class FormSetup



    Private Sub Chao_Button1_Click(sender As Object, e As EventArgs) Handles Chao_Button1.Click
        Settings.EnableExtra = Chao_CheckBox1.Checked
        Settings.ScanNFO = Chao_CheckBox2.Checked
        Settings.Save()
        MsgBox("保存成功！",, "保存成功！")
    End Sub

    Private Sub Chao_Button2_Click(sender As Object, e As EventArgs) Handles Chao_Button2.Click
        Chao_CheckBox1.Checked = False
        Chao_CheckBox2.Checked = True


    End Sub



    Private Sub Chao_Button4_Click(sender As Object, e As EventArgs) Handles Chao_Button4.Click
        Try
            Dim txtPath = Application.StartupPath & "\Data"
            If IO.Directory.Exists(txtPath) Then
                Try
                    ' Console.WriteLine(path)
                    Process.Start("Explorer.exe", GetFilePath(txtPath))
                Catch ex As Exception
                    MsgBox("打开" & txtPath & "权限不够",, "权限不够")
                End Try
            Else
                MsgBox(txtPath & "不存在",, "不存在")
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub FormSetup_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Chao_CheckBox1.Checked = Settings.EnableExtra
        Chao_CheckBox2.Checked = Settings.ScanNFO


    End Sub

    Private Sub FormSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("具体详见启动目录下Sample.nfo",, "提示")
    End Sub
End Class