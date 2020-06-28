Imports ShareClass.Net
Imports ShareClass.ChaoSub
Public Class FormSetup
    Private Sub FormSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With TabControl1
            .Left = 0
            .Top = 85
            .Width = Me.Width
            .Height = Chao_Button3.Top - Chao_Button3.Height - 40
        End With


        '设置属性
        Chao_CheckBox1.Checked = Not Settings.CloseRightNow
        Chao_CheckBox2.Checked = Settings.MainFormPicAutoSize
        Chao_CheckBox3.Checked = Settings.MainFormPicClickShowBIgPic
        Chao_CheckBox4.Checked = Settings.ShowFanhao
        Chao_CheckBox5.Checked = Settings.ShowMingCheng
        Chao_CheckBox6.Checked = Settings.ShowDate
        Chao_CheckBox7.Checked = Settings.FixSideBar
        Chao_CheckBox8.Checked = Settings.MainFormShowPicExistOnly
        Chao_CheckBox9.Checked = Settings.FixStatusBar
        Chao_CheckBox10.Checked = Settings.FallLayout
        Chao_CheckBox11.Checked = Settings.FunctionBar
        Chao_CheckBox12.Checked = Settings.ShowDefaultInfo
        Chao_CheckBox13.Checked = Settings.LeibieShowNum
        Chao_CheckBox14.Checked = Settings.YanyuanShowNum
        Chao_CheckBox15.Checked = Settings.RandomLoad
        Chao_CheckBox16.Checked = Settings.FormMainShowBigPic

        Chao_CheckBox17.Checked = Settings.ShowStamp


        ProxyCheckBox.Checked = Settings.EnableProxy


        Chao_TextBoxNum.Text = Settings.LayoutNumber

        '网站
        Chao_TextBox1.Text = Settings.BusWebSite
        Chao_TextBox2.Text = Settings.DBWebSite
        Chao_TextBox3.Text = Settings.FCWebSite
        Chao_TextBox4.Text = Settings.LibWebSite

        '代理
        Try
            ProxyWeb.Text = Split(Settings.ProxyContent, "[Split]")(0)
            ProxyUsername.Text = Split(Settings.ProxyContent, "[Split]")(1)
            ProxyPassword.Text = Split(Settings.ProxyContent, "[Split]")(2)
        Catch ex As Exception

        End Try


        Chao_StatusIndicator1.Status = "StandBy"
        Chao_StatusIndicator2.Status = "StandBy"
        Chao_StatusIndicator3.Status = "StandBy"
        Chao_StatusIndicator4.Status = "StandBy"
        ProxyStatusIndicator.Status = "StandBy"

        Chao_Sliders1.Value = (Settings.Opacity * 100)

        'SetSkin()
    End Sub

    Sub SetSkin()
        For Each item As TabPage In TabControl1.Controls
            item.BackColor = New ShareClass.Skin(Settings.SkinStyle).BC1
        Next
    End Sub

    Private Sub Chao_Button3_Click(sender As Object, e As EventArgs) Handles Chao_Button3.Click
        Settings.CloseRightNow = Not Chao_CheckBox1.Checked
        Settings.MainFormPicAutoSize = Chao_CheckBox2.Checked
        Settings.MainFormPicClickShowBIgPic = Chao_CheckBox3.Checked
        Settings.ShowFanhao = Chao_CheckBox4.Checked
        Settings.ShowMingCheng = Chao_CheckBox5.Checked
        Settings.ShowDate = Chao_CheckBox6.Checked
        Settings.FixSideBar = Chao_CheckBox7.Checked
        Settings.MainFormShowPicExistOnly = Chao_CheckBox8.Checked
        Settings.FixStatusBar = Chao_CheckBox9.Checked
        Settings.FallLayout = Chao_CheckBox10.Checked
        Settings.FunctionBar = Chao_CheckBox11.Checked
        Settings.ShowDefaultInfo = Chao_CheckBox12.Checked
        Settings.LeibieShowNum = Chao_CheckBox13.Checked
        Settings.YanyuanShowNum = Chao_CheckBox14.Checked
        Settings.RandomLoad = Chao_CheckBox15.Checked
        Settings.FormMainShowBigPic = Chao_CheckBox16.Checked
        Settings.ShowStamp = Chao_CheckBox17.Checked
        Settings.EnableProxy = ProxyCheckBox.Checked

        If IsNumeric(Chao_TextBoxNum.Text) Then
            If Chao_TextBoxNum.Text > 50 Then
                Settings.LayoutNumber = 50
            ElseIf Chao_TextBoxNum.Text < 5 Then
                Settings.LayoutNumber = 10
            Else
                Settings.LayoutNumber = Int(Chao_TextBoxNum.Text)
            End If
        Else
            Settings.LayoutNumber = 20
        End If
        Chao_TextBoxNum.Text = Settings.LayoutNumber

        '网站

        Settings.BusWebSite = Chao_TextBox1.Text
        Settings.DBWebSite = Chao_TextBox2.Text
        If Strings.Right(Settings.BusWebSite, 1) = "/" Then Settings.BusWebSite = Strings.Left(Settings.BusWebSite, Len(Settings.BusWebSite) - 1)
        If Strings.Right(Settings.DBWebSite, 1) = "/" Then Settings.DBWebSite = Strings.Left(Settings.DBWebSite, Len(Settings.DBWebSite) - 1)


        Settings.FCWebSite = Chao_TextBox3.Text
        Settings.LibWebSite = Chao_TextBox4.Text

        Settings.Opacity = Int(Chao_Sliders1.Value)

        '代理
        Settings.ProxyContent = ProxyWeb.Text & "[Split]" & ProxyUsername.Text & "[Split]" & ProxyPassword.Text
        SetProxy()

        Settings.Save()
        MsgBox("保存成功！",, "提示")

        FormMain.SetStatusBar(Settings.FixStatusBar)
        FormMain.SetFunctionBar(Settings.FunctionBar)
        FormMain.SetSideBar()
        FormMain.Chao_Panel3.Visible = Settings.FunctionBar
    End Sub

    Private Sub Chao_Button2_Click(sender As Object, e As EventArgs) Handles Chao_Button2.Click
        Chao_CheckBox1.Checked = False
        Chao_CheckBox2.Checked = False
        Chao_CheckBox3.Checked = False
        Chao_CheckBox4.Checked = True
        Chao_CheckBox5.Checked = True
        Chao_CheckBox6.Checked = True
        Chao_CheckBox7.Checked = True
        Chao_CheckBox8.Checked = False
        Chao_CheckBox9.Checked = False
        Chao_CheckBox10.Checked = False
        Chao_CheckBox11.Checked = True
        Chao_CheckBox12.Checked = True
        Chao_CheckBox13.Checked = True
        Chao_CheckBox14.Checked = True
        Chao_CheckBox15.Checked = True
        Chao_CheckBox16.Checked = False
        Chao_CheckBox17.Checked = True
        ProxyCheckBox.Checked = False

        Chao_TextBoxNum.Text = 20

        '代理
        ProxyWeb.Text = "http://www.baidu.com"
        ProxyUsername.Text = "username"
        ProxyPassword.Text = "123456"

        '网站
        Chao_TextBox1.Text = "http://www.baidu.com"
        Chao_TextBox2.Text = "http://www.baidu.com"
        Chao_TextBox3.Text = "http://www.baidu.com"
        Chao_TextBox4.Text = "http://www.baidu.com"
        Chao_Sliders1.Value = 100
        MsgBox("还原默认设置成功，请保存~",, "提示")
    End Sub

    Private Async Sub Chao_Button4_Click(sender As Object, e As EventArgs) Handles Chao_Button4.Click
        Chao_StatusIndicator1.Status = "Running"
        Dim result = Await TestUrl(Chao_TextBox1.Text)
        If result Then Chao_StatusIndicator1.Status = "Success" Else Chao_StatusIndicator1.Status = "Failed"
    End Sub

    Private Async Sub Chao_Button5_Click(sender As Object, e As EventArgs) Handles Chao_Button5.Click
        Chao_StatusIndicator2.Status = "Running"
        Dim result = Await TestUrl(Chao_TextBox2.Text)
        If result Then Chao_StatusIndicator2.Status = "Success" Else Chao_StatusIndicator2.Status = "Failed"

    End Sub

    Private Async Sub Chao_Button6_Click(sender As Object, e As EventArgs) Handles Chao_Button6.Click
        Chao_StatusIndicator3.Status = "Running"
        Dim result = Await TestUrl(Chao_TextBox3.Text)
        If result Then Chao_StatusIndicator3.Status = "Success" Else Chao_StatusIndicator3.Status = "Failed"

    End Sub

    Private Async Sub Chao_Button1_Click(sender As Object, e As EventArgs) Handles Chao_Button1.Click
        Chao_StatusIndicator4.Status = "Running"
        Dim result = Await TestUrl(Chao_TextBox4.Text)
        If result Then Chao_StatusIndicator4.Status = "Success" Else Chao_StatusIndicator4.Status = "Failed"

    End Sub

    Private Sub ProxyCheckBox_CheckedChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles ProxyCheckBox.CheckedChanged
        Panel1.Enabled = sender.checked
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        If ProxyPassword.PasswordChar = "*" Then
            ProxyPassword.PasswordChar = ""
        Else
            ProxyPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Chao_Button7_Click(sender As Object, e As EventArgs) Handles Chao_Button7.Click
        ProxyStatusIndicator.Status = "Running"
        Dim proxy As New System.Net.WebProxy
        Dim s = Split(Settings.ProxyContent, "[Split]")
        Try
            With proxy
                .Address = New Uri(s(0))
                .Credentials = New System.Net.NetworkCredential(s(1), s(2))
                .UseDefaultCredentials = False
                .BypassProxyOnLocal = False
            End With
        Catch ex As Exception

        End Try

        '判断能否下载，如果成功下载，则测试通过
        Dim url As String = "https://pics.dmm.co.jp/digital/video/118abp00628/118abp00628jp-6.jpg"
        If HandlePicExist(Application.StartupPath & "\Pic\BigPic\TestProxy.jpg") Then
            Using WebClient As New System.Net.WebClient
                WebClient.Proxy = proxy
                'WebClient.Proxy = Nothing
                AddHandler WebClient.DownloadFileCompleted, AddressOf WebClient_DownloadFileCompleted
                WebClient.DownloadFileAsync(New Uri(url), Application.StartupPath & "\Pic\BigPic\TestProxy.jpg")
            End Using
        End If
    End Sub

    Sub WebClient_DownloadFileCompleted()
        Dim PicP As String = Application.StartupPath & "\Pic\BigPic\TestProxy.jpg"
        If IO.File.Exists(PicP) Then
            Dim FI As New IO.FileInfo(PicP)
            If FI.Length > 30 Then
                ProxyStatusIndicator.Status = "Success"
            Else
                ProxyStatusIndicator.Status = "Failed"
            End If
            Try
                IO.File.Delete(PicP)
            Catch ex As Exception
            End Try
        Else
            ProxyStatusIndicator.Status = "Failed"
        End If
    End Sub

    Private Sub Chao_Sliders1_ValueChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles Chao_Sliders1.ValueChanged
        FormMain.Opacity = Int(Chao_Sliders1.Value) / 100
        Settings.Opacity = Int(Chao_Sliders1.Value)
    End Sub
End Class