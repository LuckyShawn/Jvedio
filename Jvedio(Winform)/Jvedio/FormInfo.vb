Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO
Imports ShareClass.ChaoFile
Imports ShareClass.ChaoSub

Public Class FormInfo
    Public ExtraPicPath As String

    Declare Auto Function ReleaseCapture Lib "user32.dll" Alias "ReleaseCapture" () As Boolean
    'API ReleaseCapture函数是用来释放鼠标捕获的
    Declare Auto Function SendMessage Lib "user32.dll" Alias "SendMessage" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    '向windows发送消息
    Public Const WM_SYSCOMMAND As Integer = &H112&
    Public Const SC_MOVE As Integer = &HF010&
    Public Const HTCAPTION As Integer = &H2&

    Delegate Sub OnFanhaoComplete()

    Sub LoadBackImage()
        Dim PicPath As String
        PicPath = BigPicSavePath & GlobalFanhao & ".jpg"
        If IO.File.Exists(PicPath) Then
            If My.Computer.FileSystem.GetFileInfo(PicPath).Length > 50000 Then '如果图片错误会显示内存不足
                If Not IsFileInUse(PicPath) Then
                    Try
                        Dim FS As New FileStream(PicPath, FileMode.Open, FileAccess.Read)
                        Dim PicSize As Size = Image.FromStream(FS).Size
                        Dim Rate As Single = PicSize.Height / PicSize.Width
                        Dim ScreenSize As Size = Screen.PrimaryScreen.WorkingArea.Size

                        If PicSize.Width > ScreenSize.Width * 0.8 Or PicSize.Height > ScreenSize.Height * 0.8 Then
                            Me.Width = ScreenSize.Width * 0.8
                            Me.Height = Rate * Me.Width
                        ElseIf PicSize.Width <= ScreenSize.Width * 0.8 And PicSize.Width >= ScreenSize.Width * 0.5 And PicSize.Height >= 800 Then
                            Me.Size = PicSize
                        ElseIf PicSize.Height < 800 Then
                            Me.Width = 1200
                            Me.Height = 800
                        Else
                            Me.Width = PicSize.Width * 1.5
                            Me.Height = Rate * Me.Width
                        End If

                        Me.Left = (ScreenSize.Width - Me.Width) / 2
                        Me.Top = (ScreenSize.Height - Me.Height) / 2
                        If PicSize.Height < 800 Then
                            Me.BackgroundImage = Image.FromStream(FS)
                            Me.BackgroundImageLayout = ImageLayout.Zoom
                        Else
                            Me.BackgroundImage = Image.FromStream(FS)
                            Me.BackgroundImageLayout = ImageLayout.Stretch
                        End If


                        FS.Close()
                        FS.Dispose()
                        Application.DoEvents()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End If
            End If
        Else
            Me.Width = 1200
            Me.Height = 800
            Me.BackgroundImage = My.Resources.Resource_FormInfo.BigPicNotFound
            Me.BackgroundImageLayout = ImageLayout.Stretch
        End If

    End Sub




    Private Sub Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = FormMain.Icon
        '设置BackgroundImage并设置窗口大小

    End Sub

    Private Sub FormInfo_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadInfo()
    End Sub


    Sub LoadInfo()
        FormMain.CheckForPic()


        LoadBackImage()
        LoadPicFromFile(SmallPicSavePath & GlobalFanhao & ".jpg", PictureBox2)


        Dim TranColor As Color = Color.FromArgb(150, 0, 0, 0)
        Dim PicBC As Color = Color.LightSkyBlue


        '设置信息
        Dim VI = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).GetVedioInfo()
        SomeInfo_label.Text = VI.faxingriqi & "    " & VI.changdu & "分钟"
        zhizuoshang_label.Text = "制作商：" & VI.zhizuoshang
        faxingshang_label.Text = "发行商：" & VI.faxingshang
        daoyan_label.Text = "导演：" & VI.daoyan
        xilie_label.Text = "系列：" & VI.xilie
        Label_ID.Text = GlobalID

        '设置字体大小直到不超过界面
        Dim TempS = Replace(VI.mingcheng, "(", "")
        TempS = Replace(TempS, ")", "")
        TempS = Replace(TempS, VI.fanhao, "")
        Me.Text = GlobalFanhao
        Title_label.Text = UCase(TempS)
        Dim h As Integer = GetCharHeight(Title_label)
        Title_label.Height = GetLabelSize(Title_label).Height * h


        'Chao_FlowLayoutPanel3.BackColor = TranColor
        Chao_FlowLayoutPanel3.Controls.Clear()
        'Chao_FlowLayoutPanel3.Visible = False
        '加载类别
        For Each s In Split(VI.leibie, " ")
            Dim myLabel As New Label
            myLabel.Text = s
            myLabel.AutoSize = True
            myLabel.Cursor = Windows.Forms.Cursors.Hand
            myLabel.ForeColor = Color.White
            myLabel.Font = SomeInfo_label.Font
            myLabel.BackColor = Color.Transparent
            AddHandler myLabel.Click, AddressOf myLabel_Leibie_Click
            myLabel.Margin = New Padding(3, 3, 3, 0)
            Chao_FlowLayoutPanel3.Controls.Add(myLabel)
            Application.DoEvents()
        Next

        '加载喜爱
        If VI.love > 0 Then
            PictureBox4.Image = My.Resources.Resource_FormInfo.喜爱填充
            PictureBox4.Name = VI.love & "LovePicbox_Love_" & GlobalFanhao
        Else
            PictureBox4.Image = My.Resources.Resource_FormInfo.喜爱
            PictureBox4.Name = VI.love & "LovePicbox_NotLove_" & GlobalFanhao
        End If
        For Each item In love_ContextMenuStrip.Items
            If Mid(item.text, 1, 1) = VI.love.ToString Then
                item.checked = True
            End If
        Next

        '加载演员
        Chao_FlowLayoutPanel2.Controls.Clear()
        For Each s In Split(VI.yanyuan, " ")
            Dim YYLabel As New Label
            With YYLabel
                .Text = s
                .AutoSize = True
                .Cursor = Windows.Forms.Cursors.Hand
                .ForeColor = Color.White
                .Font = SomeInfo_label.Font
                .BackColor = Color.Transparent
                AddHandler .Click, AddressOf YYLabel_Leibie_Click
                AddHandler .MouseEnter, AddressOf YYLabel_MouseEnter
                AddHandler .MouseLeave, AddressOf YYLabel_MouseLeave
                .Margin = New Padding(3, 3, 3, 0)
                Chao_FlowLayoutPanel2.Controls.Add(YYLabel)
            End With
        Next


        '访问次数+1
        Dim SetFangwencishu = New ShareClass.DataBase("")
        SetFangwencishu.UpdateCommand("update Main set fangwencishu=" & Int(VI.fangwencishu) + 1 & " where fanhao='" & VI.fanhao & "'")
        SetFangwencishu.Dispose()


        '加载额外图片
        With Chao_Panel1
            .Controls.Clear()
            .BackColor = Color.FromArgb(150, 0, 0, 0)
        End With

        LoadExtraPic()



        Application.DoEvents()


        '------------------开启下载线程------------------
        FormMain.CheckForPic()
        StartThread()
        '------------------开启下载线程------------------


    End Sub

    Sub StartThread()
        Task.Run(Sub()
                     If DownLoadThread IsNot Nothing Then
                         '立即停止当前任务，重新开始新的任务
                         If IsThreadRunning Then
                             DownLoadThreadCancel = True
                             DownLoadThread.Join()
                             DownLoadThread.Abort()
                             Do
                                 Threading.Thread.Sleep(100)
                             Loop Until IsThreadRunning = False
                             DownLoadThreadCancel = False
                             DownLoadThread = New System.Threading.Thread(AddressOf StartDownLoad)
                             DownLoadThread.Start()
                         Else
                             DownLoadThreadCancel = False
                             DownLoadThread = New System.Threading.Thread(AddressOf StartDownLoad)
                             DownLoadThread.Start()
                         End If
                     Else
                         DownLoadThreadCancel = False
                         DownLoadThread = New System.Threading.Thread(AddressOf StartDownLoad)
                         DownLoadThread.Start()
                     End If
                 End Sub)


    End Sub


    Async Sub StartDownLoad()
        IsThreadRunning = True
        Dim fanhao As String = ""
        Dim ID As Double = 0
        Dim result As Boolean = False

        fanhao = GlobalFanhao
        If DownLoadThreadCancel Then
            Console.WriteLine("线程被取消")
            IsThreadRunning = False
            Exit Sub
        ElseIf DownLoadThreadPause Then
            Do
                Threading.Thread.Sleep(100)
            Loop Until DownLoadThreadCancel Or Not DownLoadThreadPause
        Else
            Dim DL As New DownLoader(fanhao, 1, DownLoadProxy)
            Dim vedio = Await DL.GetVedio()
            '下载大图
            result = Await DL.Download(vedio.Pic_B)
            If result Then
                '回调
                If Me.IsHandleCreated Then
                    Me.Invoke(New OnFanhaoComplete(Sub()
                                                       If GlobalFanhao = fanhao Then
                                                           Me.LoadBackImage()
                                                       End If
                                                   End Sub))
                End If

            End If

            '下载预览图
            DL = New DownLoader(fanhao, 2, DownLoadProxy)
            For Each item In Split(vedio.fanart, " ")

                If DownLoadThreadCancel Then
                    Console.WriteLine("线程被取消")
                    Exit For
                Else
                    If Len(item) > 0 And item <> "" Then
                        result = Await DL.Download(item)
                        If result Then
                            '回调
                            If Me.IsHandleCreated Then
                                Me.Invoke(New OnFanhaoComplete(Sub()
                                                                   If GlobalFanhao = fanhao Then
                                                                       Me.LoadExtraPic()
                                                                   End If
                                                               End Sub))
                            End If
                            Threading.Thread.Sleep(ExtraPicFrequency)
                        End If
                    End If
                End If
            Next
            Threading.Thread.Sleep(DownloadThreadFrequency)
        End If
        IsThreadRunning = False
    End Sub

    Sub LoadExtraPic()

        Dim existList As New List(Of String)
        For Each item In Chao_Panel1.Controls
            If Not existList.Contains(item.name) Then
                existList.Add(item.name)
            End If
        Next

        Dim PicSize As Size
        Dim PicPath = ExtraPicSavePath & GlobalFanhao
        If System.IO.Directory.Exists(PicPath) = True Then
            Dim foundFile2 As String() = My.Computer.FileSystem.GetFiles(PicPath, FileIO.SearchOption.SearchAllSubDirectories, {"*.jpg", "*.bmp", "*.gif"}).ToArray
            For Each foundFile In foundFile2
                Application.DoEvents()
                If File.Exists(foundFile) Then
                    If New FileInfo(foundFile).Length > 4000 Then '如果图片错误会显示内存不足
                        If Not existList.Contains(GetFileName(foundFile)) Then
                            If Not IsFileInUse(foundFile) Then
                                Try
                                    Dim pFileStream As New FileStream(foundFile, FileMode.Open, FileAccess.Read)
                                    PicSize = Image.FromStream(pFileStream).Size
                                    Dim PicB As New PictureBox
                                    With PicB
                                        .Name = GetFileName(foundFile)
                                        .SizeMode = PictureBoxSizeMode.StretchImage
                                        .Height = 180
                                        .Width = .Height * PicSize.Width / PicSize.Height
                                        .Image = Image.FromStream(pFileStream)
                                        .Top = 0
                                        If Chao_Panel1.Controls.Count = 0 Then
                                            .Left = 0
                                        Else
                                            .Left = Chao_Panel1.Controls.Item(Chao_Panel1.Controls.Count - 1).Left + Chao_Panel1.Controls.Item(Chao_Panel1.Controls.Count - 1).Width + 10
                                        End If
                                        Chao_Panel1.Controls.Add(PicB)
                                        pFileStream.Close()
                                        pFileStream.Dispose()
                                        AddHandler .MouseDown, AddressOf ExtraPicB_MouseDown
                                        AddHandler .MouseEnter, AddressOf ExtraPicB_MouseEnter
                                        AddHandler .MouseLeave, AddressOf ExtraPicB_MouseLeave
                                        AddHandler .MouseWheel, AddressOf ExtraPicB_MouseWheel
                                    End With

                                Catch ex As Exception
                                    Console.WriteLine(ex.Message)
                                    Continue For
                                End Try
                            End If
                        End If
                        End If
                End If
            Next
        End If
    End Sub

    Sub ExtraPicB_MouseLeave(sender As Object, e As EventArgs)
        '这里因为继承地ChaoForm 地invalidate 导致窗口所有控件重画失败
        Dim PicB As PictureBox = sender
        Dim PicPath As String = ExtraPicSavePath & GlobalFanhao & "\" & PicB.Name
        If File.Exists(PicPath) Then
            If Not IsFileInUse(PicPath) Then
                PicB.Image = Nothing
                Dim FS As New FileStream(PicPath, FileMode.Open, FileAccess.Read)
                PicB.Image = Image.FromStream(FS)
                FS.Dispose()
                FS.Close()
            End If
        End If


    End Sub

    Sub ExtraPicB_MouseEnter(sender As Object, e As EventArgs)
        Dim PicB As PictureBox = sender
        Dim bmp As Bitmap = New Bitmap(PicB.ClientSize.Width, PicB.ClientSize.Height)
        Dim PicPath As String = ExtraPicSavePath & GlobalFanhao & "\" & PicB.Name
        Dim img As Image
        If File.Exists(PicPath) Then
            If Not IsFileInUse(PicPath) Then
                Dim FS As New FileStream(PicPath, FileMode.Open, FileAccess.Read)
                img = Image.FromStream(FS)
                Dim g As Graphics = Graphics.FromImage(bmp)
                g.Clear(PicB.BackColor)
                g.DrawImage(img, New RectangleF(-15, -15, PicB.Width + 15, PicB.Height + 15), New RectangleF(0, 0, img.Width - 30, img.Height - 30), GraphicsUnit.Pixel)
                g.Dispose()
                PicB.Image = bmp
                FS.Dispose()
                FS.Close()
            End If
        End If
        Me.ActiveControl = PicB 'For MouseWheel

    End Sub

    Sub ExtraPicB_MouseWheel(sender As Object, e As MouseEventArgs)
        If e.Delta > 0 Then
            Console.WriteLine(e.Delta)
            Label3_MouseDown(sender, e)
        ElseIf e.Delta < 0 Then
            Console.WriteLine(e.Delta)
            Label4_MouseDown(sender, e)
        End If
    End Sub

    Sub ExtraPicB_MouseDown(sender As Object, e As MouseEventArgs)
        Dim PicPath As String = ExtraPicSavePath & GlobalFanhao & "\" & sender.name
        Dim PicB As PictureBox = sender
        If e.Button = MouseButtons.Left Then
            '显示图片
            With FormViewPicture
                .Size = Me.Size
                .PictureBox1.Name = PicB.Name
                .PictureBox1.Size = .Size
                .PictureBox1.Location = New Point(0, 0)
                If File.Exists(PicPath) Then
                    If Not IsFileInUse(PicPath) Then
                        Dim FS As New FileStream(PicPath, FileMode.Open, FileAccess.Read)
                        .PictureBox1.Image = Image.FromStream(FS)
                        FS.Dispose()
                        FS.Close()
                    End If
                End If
                .PictureBox1.BackColor = Color.FromArgb(150, 0, 0, 0)
                .PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                .Show()
                .BringToFront()
            End With

        ElseIf e.Button = MouseButtons.Right Then
            ExtraPicPath = PicPath
            PicB.ContextMenuStrip = ContextMenuStrip1
        End If


    End Sub

    Sub PicB_Click(sender As Object, e As EventArgs)
        sender.visible = False
    End Sub

    Sub YYLabel_MouseLeave()
        PicBYY.Visible = False
    End Sub

    Sub YYLabel_MouseEnter(sender As Object, e As EventArgs)
        Dim Label As Label = sender
        With PicBYY
            .Size = New Size(145, 145)
            .SizeMode = PictureBoxSizeMode.CenterImage
            .BackColor = Color.White
            .Cursor = Windows.Forms.Cursors.Hand
            .Left = MousePosition.X - Me.Left
            .Top = MousePosition.Y - Me.Top + Label.Height
            LoadPicFromFile(ActressesPicSavePath & "\" & Label.Text & ".jpg", PicBYY)
            .Visible = True
            .BringToFront()
        End With

    End Sub



    Private Sub myPic_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub YYLabel_Leibie_Click(sender As Object, e As EventArgs)
        '点击演员
        Clickindex = 11
        myYanyuan = Jencode(sender.text)
        mysql = getPaixuSql("where yanyuan like '%" & myYanyuan & "%'", "Main")
        FormMain.SelectFromDatabase(mysql, 1)
        FormMain.Label2.Text = sender.text
        Me.Close()
        FormMain.Activate()
    End Sub

    Private Sub myLabel_Leibie_Click(sender As Object, e As EventArgs)
        '点击类别
        Clickindex = 10
        myLeibie = Jencode(sender.text)
        mysql = getPaixuSql("where leibie like '%" & myLeibie & "%'", "Main")
        FormMain.SelectFromDatabase(mysql, 1)
        FormMain.Label2.Text = sender.text
        Me.Close()
        FormMain.Activate()
    End Sub


    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles Chao_Panel2.MouseMove, Chao_FlowLayoutPanel3.MouseMove, Chao_FlowLayoutPanel2.MouseMove, Chao_FlowLayoutPanel1.MouseMove, Chao_Panel1.MouseMove, PictureBox2.MouseMove
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
        End If
    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim weizhi = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).GetInfo("weizhi")
        If IO.File.Exists(weizhi) Then
            Try
                Process.Start(weizhi)
            Catch ex As Exception
                MsgBox("打开失败，杀毒软件组织！",, "提示")
            End Try

        Else
            MsgBox("文件不存在",, "文件不存在")
        End If
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove, PictureBox4.MouseMove, PictureBox5.MouseMove, PictureBox8.MouseMove
        Dim PB As PictureBox = sender
        PB.BackColor = GetRelativeColor(PB.BackColor, 20)
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave, PictureBox4.MouseLeave, PictureBox5.MouseLeave, PictureBox8.MouseLeave
        Dim PB As PictureBox = sender
        PB.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Info_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        'Me.Close()

    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub



    Private Sub PictureBox5_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox5.Paint

    End Sub



    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox7_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        LovePicBTemp = sender
        Dim p As Point
        p.X = LovePicBTemp.Left + Me.Left
        p.Y = LovePicBTemp.height + LovePicBTemp.top + Me.Top
        love_ContextMenuStrip.Show(p)

        For Each item In love_ContextMenuStrip.Items
            If Int(item.text) = Strings.Left(sender.name, 1) Then
                item.checked = True
            Else
                item.checked = False
            End If
        Next
    End Sub

    Sub SaveLove(index As Integer)
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim myDataAdapter As New OleDbDataAdapter()
        Try
            con.ConnectionString = con_ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "update Main set love=" & index & " where ID=" & GlobalID
            myDataAdapter.UpdateCommand = cmd
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
        Finally
            If con IsNot Nothing Then con.Close()
        End Try
        '加载喜爱
        PictureBox4.Image = Nothing
        PictureBox4.Refresh()
        For Each item In love_ContextMenuStrip.Items
            If item.GetType.ToString <> "System.Windows.Forms.ToolStripSeparator" Then
                If Mid(item.text, 1, 1) = index.ToString Then
                    item.checked = True
                Else
                    item.checked = False
                End If
            End If
        Next

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click, ToolStripMenuItem2.Click, ToolStripMenuItem3.Click, ToolStripMenuItem4.Click, ToolStripMenuItem5.Click, ToolStripMenuItem6.Click
        LovePicBTemp.Name = Replace(LovePicBTemp.Name, "LovePicbox_Love_", "LovePicbox_NotLove_")
        SetLove(sender.text)
    End Sub

    Sub SetLove(index As Integer)
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim myDataAdapter As New OleDbDataAdapter()
        Try
            con.ConnectionString = con_ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "update Main set love=" & index & " where ID=" & GlobalID
            myDataAdapter.UpdateCommand = cmd
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
        Finally
            If con IsNot Nothing Then con.Close()
        End Try

        LovePicBTemp.Image = Nothing
        LovePicBTemp.Refresh()
        LovePicBTemp.name = index & Strings.Mid(LovePicBTemp.name, 2)
        If index > 0 Then
            LovePicBTemp.Image = My.Resources.Resource_FormInfo.喜爱填充
        Else
            LovePicBTemp.Image = My.Resources.Resource_FormInfo.喜爱
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If MsgBox("删除文件到回收站并从数据库删除？", vbYesNo, "删除文件") = vbYes Then
            Dim Path = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).GetInfo("weizhi")
            If IO.File.Exists(Path) Then
                '删除文件file的方法1:删除到回收站里面。
                My.Computer.FileSystem.DeleteFile(Path, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                '删除文件file的方法2:直接从硬盘上删除。
                'IO.File.Delete(fpath)
                Dim DL As New List(Of Double)
                DL.Add(GlobalID)

                Dim DeleteClass = New ShareClass.DataBase("")
                For Each item In DL
                    DeleteClass.UpdateCommand("delete from Main where ID=" & item)
                Next
                DeleteClass.Dispose()


            Else
                MsgBox(Path & "【文件不存在】")
            End If
        End If
    End Sub

    Private Sub Zhizuoshang_label_Click(sender As Object, e As EventArgs) Handles zhizuoshang_label.Click
        Clickindex = 14
        myZhizuoshang = Jencode(Mid(sender.text, 5))
        If myZhizuoshang = "" Then Exit Sub
        mysql = getPaixuSql("where zhizuoshang like '%" & myZhizuoshang & "%'", "Main")   '获得排序类型
        FormMain.SelectFromDatabase(mysql, 1)
        FormMain.Label2.Text = sender.text
        Me.Close()
        FormMain.Activate()
    End Sub

    Private Sub Faxingshang_label_Click(sender As Object, e As EventArgs) Handles faxingshang_label.Click
        Clickindex = 13
        myFaxingshang = Jencode(Mid(sender.text, 5))
        If myFaxingshang = "" Then Exit Sub
        mysql = getPaixuSql("where faxingshang like '%" & myFaxingshang & "%'", "Main")   '获得排序类型
        FormMain.SelectFromDatabase(mysql, 1)
        FormMain.Label2.Text = sender.text
        Me.Close()
        FormMain.Activate()
    End Sub

    Private Sub Daoyan_label_Click(sender As Object, e As EventArgs) Handles daoyan_label.Click
        Clickindex = 15
        myDaoyan = Jencode(Mid(sender.text, 4))
        If myDaoyan = "" Then Exit Sub
        mysql = getPaixuSql("where daoyan like '%" & myDaoyan & "%'", "Main")   '获得排序类型
        FormMain.SelectFromDatabase(mysql, 1)
        FormMain.Label2.Text = sender.text
        Me.Close()
        FormMain.Activate()
    End Sub

    Private Sub Xilie_label_Click(sender As Object, e As EventArgs) Handles xilie_label.Click
        Clickindex = 15
        myXilie = Jencode(Mid(sender.text, 4))
        If myXilie = "" Then Exit Sub
        mysql = getPaixuSql("where xilie like '%" & myXilie & "%'", "Main")   '获得排序类型
        FormMain.SelectFromDatabase(mysql, 1)
        FormMain.Label2.Text = sender.text
        Me.Close()
        FormMain.Activate()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        GlobalID = Label_ID.Text
        GlobalFanhao = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).GetInfo("fanhao")

        If FormEdit.Visible Then
            FormEdit.Close()
        End If
        FormEdit.Show()
        FormEdit.BringToFront()
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        If Chao_Panel1.Controls.Count <= 1 Then Exit Sub

        If Chao_Panel1.Controls.Item(Chao_Panel1.Controls.Count - 1).Left < 0 Then
            Chao_Panel1.Controls.Item(Chao_Panel1.Controls.Count - 1).Left = 0
            For i = Chao_Panel1.Controls.Count - 2 To 0 Step -1
                Chao_Panel1.Controls.Item(i).Left = Chao_Panel1.Controls.Item(i + 1).Left - Chao_Panel1.Controls.Item(i).Width - 10
            Next
        ElseIf chao_panel1.Controls.Item(chao_panel1.Controls.Count - 1).Left - 200 >= 0 Then
            For Each item In Chao_Panel1.Controls
                item.left -= 200
            Next
        Else

        End If
    End Sub


    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs) Handles Label3.MouseDown
        If Chao_Panel1.Controls.Count <= 1 Then Exit Sub
        If Chao_Panel1.Controls.Item(0).Left > 0 Then
            Chao_Panel1.Controls.Item(0).Left = 0
            For i = 1 To Chao_Panel1.Controls.Count - 1
                Chao_Panel1.Controls.Item(i).Left = Chao_Panel1.Controls.Item(i - 1).Left + Chao_Panel1.Controls.Item(i - 1).Width + 10
            Next
        ElseIf chao_panel1.Controls.Item(0).Left + 200 <= 0 Then

            For Each item In Chao_Panel1.Controls
                item.left += 200
            Next
        Else
            Chao_Panel1.Controls.Item(0).Left = 0
            For i = 1 To Chao_Panel1.Controls.Count - 1
                Chao_Panel1.Controls.Item(i).Left = Chao_Panel1.Controls.Item(i - 1).Left + Chao_Panel1.Controls.Item(i - 1).Width + 10
            Next
        End If

    End Sub

    Private Sub Label4_MouseMove(sender As Object, e As MouseEventArgs) Handles Label4.MouseMove, Label3.MouseMove
        sender.backcolor = GetRelativeColor(Color.DarkGray, 20)
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave, Label3.MouseLeave
        sender.backcolor = Color.DarkGray
    End Sub


    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim index As Integer = 0
        For i = 0 To InfoIDList.Count - 1 Step 1
            If InfoIDList.Item(i) = GlobalID Then
                index = i
                Exit For
            End If
        Next
        index += 1
        If index > InfoIDList.Count - 1 Then index = 0
        GlobalID = InfoIDList.Item(index)
        GlobalFanhao = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).GetInfo("fanhao")
        LoadInfo()
    End Sub

    Private Sub PictureBox7_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseMove
        PictureBox7.Image = My.Resources.Resource_FormInfo.右2
    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave
        PictureBox7.Image = My.Resources.Resource_FormInfo.右1
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim index As Integer = 0
        For i = 0 To InfoIDList.Count - 1 Step 1
            If InfoIDList.Item(i) = GlobalID Then
                index = i
                Exit For
            End If
        Next
        index -= 1
        If index < 0 Then index = InfoIDList.Count - 1
        GlobalID = InfoIDList.Item(index)
        GlobalFanhao = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).GetInfo("fanhao")
        LoadInfo()
    End Sub

    Private Sub PictureBox9_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseMove
        PictureBox9.Image = My.Resources.Resource_FormInfo.左2
    End Sub

    Private Sub PictureBox9_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox9.MouseLeave
        PictureBox9.Image = My.Resources.Resource_FormInfo.左1
    End Sub

    Private Sub FormInfo_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin

    End Sub

    Private Sub PictureBox6_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseMove
        PictureBox6.Image = My.Resources.Resource_FormInfo.返回2
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.Image = My.Resources.Resource_FormInfo.返回1
    End Sub

    Private Sub 打开位置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开位置ToolStripMenuItem.Click
        If IO.File.Exists(ExtraPicPath) Then
            OpenFilePath(ExtraPicPath)

        End If

    End Sub
    Private Sub 删除文件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除文件ToolStripMenuItem.Click
        Try
            File.Delete(ExtraPicPath)
        Catch ex As Exception

        End Try

        For i = 0 To Chao_Panel1.Controls.Count - 1 Step 1
            Dim PicB As PictureBox = Chao_Panel1.Controls.Item(i)
            If PicB.Name = GetFileName(ExtraPicPath) Then
                Chao_Panel1.Controls.RemoveAt(i)
                Exit For
            End If
        Next

        '调整顺序
        If Chao_Panel1.Controls.Count > 0 Then
            For i = 0 To Chao_Panel1.Controls.Count - 1 Step 1
                Dim PicB As PictureBox = Chao_Panel1.Controls.Item(i)
                If i = 0 Then
                    PicB.Left = 0
                Else
                    PicB.Left = Chao_Panel1.Controls.Item(i - 1).Left + Chao_Panel1.Controls.Item(i - 1).Width + 10
                End If
            Next
        End If


    End Sub






    Private Sub DownLoadCompleteTimer_Tick(sender As Object, e As EventArgs) Handles BigPicCompleteTimer.Tick
        Dim Fanhao = Me.Text
        Dim PicPath = BigPicSavePath & "\" & Fanhao & ".jpg"
        If IO.File.Exists(PicPath) Then
            If New FileInfo(PicPath).Length >= 50000 Then
                If Not IsFileInUse(PicPath) Then
                    Dim FS As New FileStream(PicPath, FileMode.Open, FileAccess.Read)
                    Me.BackgroundImage = Image.FromStream(FS)
                    FS.Close()
                End If
            End If
        End If
        BigPicCompleteTimer.Stop()
        BigPicDownloadCompleted = False
    End Sub

    Private Sub DownLoadTimer_Tick(sender As Object, e As EventArgs) Handles DownLoadTimer.Tick
        If BigPicDownloadCompleted Then
            BigPicCompleteTimer.Enabled = True
        Else
            BigPicCompleteTimer.Enabled = False
        End If

        If ExtrapicDownloadComplete Then
            ExtraPicCompleteTimer.Enabled = True
        Else
            ExtraPicCompleteTimer.Enabled = False
        End If
    End Sub

    Private Sub Chao_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Chao_Panel1.Paint

    End Sub

    Private Sub ExtraPicCompleteTimer_Tick(sender As Object, e As EventArgs) Handles ExtraPicCompleteTimer.Tick
        If Settings.ShowDefaultInfo Then
            LoadExtraPic()
        Else
            FormBus.LoadExtraPic()
        End If

        ExtraPicCompleteTimer.Stop()
        ExtrapicDownloadComplete = False
    End Sub

    Private Sub Chao_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Chao_Panel2.Paint

    End Sub

    Private Sub FormInfo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Task.Run(Sub()
                     If DownLoadThread IsNot Nothing Then
                         '立即停止当前任务
                         DownLoadThreadCancel = True
                             DownLoadThread.Join()
                             DownLoadThread.Abort()
                         Do
                             Threading.Thread.Sleep(100)
                         Loop Until IsThreadRunning = False
                         IsClosingFromInfo = True
                     End If
                 End Sub)
    End Sub
End Class