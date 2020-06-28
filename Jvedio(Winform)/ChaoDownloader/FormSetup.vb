Imports ShareClass.Net
Public Class FormSetup
    Private Sub FormSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Top = 80
        Chao_TextBox1.Text = Settings.BusWebSite
        Chao_TextBox2.Text = Settings.DBWebSite
        Chao_TextBox3.Text = Settings.FCWebSite

        Chao_RadioButton1.Checked = Not Settings.CreateFanhaoFile
        Chao_RadioButton2.Checked = Settings.CreateFanhaoFile
        Chao_CheckBox1.Checked = Settings.DownLoadFanart
        Chao_CheckBox2.Checked = Settings.DownLoadToNFO
        Chao_CheckBox3.Checked = Settings.DownLoadToDatabase
        Chao_CheckBox4.Checked = Settings.CloseToTaskbar
        ComboBox1.SelectedIndex = Settings.SkipCondition


        Chao_StatusIndicator1.Status = "StandBy"
        Chao_StatusIndicator2.Status = "StandBy"
        Chao_StatusIndicator3.Status = "StandBy"
    End Sub

    Private Sub Chao_Button4_Click(sender As Object, e As EventArgs) Handles Chao_Button4.Click
        Chao_TextBox1.Text = "http://www.baidu.com"
        Chao_TextBox2.Text = "http://www.baidu.com"
        Chao_TextBox3.Text = "http://www.baidu.com"

        Chao_RadioButton1.Checked = True
        Chao_RadioButton2.Checked = False

        Chao_CheckBox1.Checked = False
        Chao_CheckBox2.Checked = False
        Chao_CheckBox3.Checked = False
        Chao_CheckBox4.Checked = True

        ComboBox1.SelectedIndex = 0

        MsgBox("还原默认设置成功~请保存",, "提示")
    End Sub

    Private Sub Chao_Button5_Click(sender As Object, e As EventArgs) Handles Chao_Button5.Click
        Settings.BusWebSite = Chao_TextBox1.Text
        Settings.DBWebSite = Chao_TextBox2.Text
        Settings.FCWebSite = Chao_TextBox3.Text
        Settings.CreateFanhaoFile = Not Chao_RadioButton1.Checked

        Settings.DownLoadFanart = Chao_CheckBox1.Checked
        Settings.DownLoadToNFO = Chao_CheckBox2.Checked
        Settings.DownLoadToDatabase = Chao_CheckBox3.Checked
        Settings.CloseToTaskbar = Chao_CheckBox4.Checked


        Settings.SkipCondition = ComboBox1.SelectedIndex

        If Settings.CreateFanhaoFile Then
            SmallPicSavePath = Application.StartupPath & "\Download\"
            BigPicSavePath = SmallPicSavePath
            ExtraPicSavePath = SmallPicSavePath
            ActressesPicSavePath = SmallPicSavePath
        Else
            SmallPicSavePath = Application.StartupPath & "\Pic\SmallPic\"
            BigPicSavePath = Application.StartupPath & "\Pic\BigPic\"
            ExtraPicSavePath = Application.StartupPath & "\Pic\ExtraPicSavePath\"
            ActressesPicSavePath = Application.StartupPath & "\Pic\Actresses\"
        End If
        CreateDir()

        Settings.Save()
        MsgBox("保存成功！重启后生效",, "提示")
    End Sub

    Private Async Sub Chao_Button1_Click(sender As Object, e As EventArgs) Handles Chao_Button1.Click
        Chao_StatusIndicator1.Status = "Running"
        Dim result = Await TestUrl(Chao_TextBox1.Text)
        If result Then
            Chao_StatusIndicator1.Status = "Success"
        Else
            Chao_StatusIndicator1.Status = "Failed"
        End If
    End Sub

    Private Async Sub Chao_Button2_Click(sender As Object, e As EventArgs) Handles Chao_Button2.Click
        Chao_StatusIndicator2.Status = "Running"
        Dim result = Await TestUrl(Chao_TextBox2.Text)
        If result Then
            Chao_StatusIndicator2.Status = "Success"
        Else
            Chao_StatusIndicator2.Status = "Failed"
        End If
    End Sub

    Private Async Sub Chao_Button3_Click(sender As Object, e As EventArgs) Handles Chao_Button3.Click
        Chao_StatusIndicator3.Status = "Running"
        Dim myTask = TestUrl(Chao_TextBox3.Text)
        Dim result = Await myTask
        If result Then
            Chao_StatusIndicator3.Status = "Success"
        Else
            Chao_StatusIndicator3.Status = "Failed"
        End If
    End Sub
End Class