Imports System.ComponentModel
Imports ShareClass.ChaoFile
Imports ShareClass.ChaoSub
Imports System.IO
Public Class FormBus

    Public YingpianWeizhi As String
    Public ExtraPicPath As String

    Delegate Sub OnFanhaoComplete()

    Private Sub myLabel_Leibie_Click(sender As Object, e As EventArgs)
        '点击类别
        Me.Visible = False
        Clickindex = 10
        myLeibie = Jencode(sender.text)
        mysql = getPaixuSql("where leibie like '%" & myLeibie & "%'", "Main")
        FormMain.SelectFromDatabase(mysql, 1)
        FormMain.Label2.Text = Juncode(myLeibie)
        FormMain.Activate()
        Me.Close()
    End Sub

    Private Sub myLabel_Yanyuan_Click(sender As Object, e As EventArgs)
        '点击演员
        Me.Visible = False
        Clickindex = 11
        myYanyuan = Jencode(sender.text)
        mysql = getPaixuSql("where yanyuan like '%" & myYanyuan & "%'", "Main")
        FormMain.SelectFromDatabase(mysql, 1)
        FormMain.Label2.Text = Juncode(myYanyuan)
        FormMain.Activate()
        Me.Close()
    End Sub

    Private Sub myLabel_Biaoqian_Click(sender As Object, e As EventArgs)
        '点击标签
        Me.Visible = False
        Clickindex = 12
        myBiaoqian = Jencode(sender.text)
        mysql = getPaixuSql("where biaoqian like '%" & myBiaoqian & "%'", "Main")
        FormMain.SelectFromDatabase(mysql, 1)
        FormMain.Label2.Text = Juncode(myBiaoqian)
        FormMain.Activate()
        Me.Close()

    End Sub


    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        '点击导演
        Me.Visible = False
        Clickindex = 15
        myDaoyan = Jencode(sender.text)
        mysql = getPaixuSql("where daoyan like '%" & myDaoyan & "%'", "Main")   '获得排序类型
        FormMain.SelectFromDatabase(mysql, 1)
        FormMain.Label2.Text = Juncode(myDaoyan)
        FormMain.Activate()
        Me.Close()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        '点击制作商
        Me.Visible = False
        Clickindex = 14
        myZhizuoshang = Jencode(sender.text)
        mysql = getPaixuSql("where zhizuoshang like '%" & myZhizuoshang & "%'", "Main")   '获得排序类型
        FormMain.SelectFromDatabase(mysql, 1)
        FormMain.Label2.Text = Juncode(myZhizuoshang)
        FormMain.Activate()
        Me.Close()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        '点击发行商
        Me.Visible = False
        Clickindex = 13
        myFaxingshang = Jencode(sender.text)
        mysql = getPaixuSql("where faxingshang like '%" & myFaxingshang & "%'", "Main")   '获得排序类型
        FormMain.SelectFromDatabase(mysql, 1)
        FormMain.Label2.Text = Juncode(myFaxingshang)
        FormMain.Activate()
        Me.Close()
    End Sub



    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        '点击系列
        Me.Visible = False
        Clickindex = 16
        myXilie = Jencode(sender.text)
        mysql = getPaixuSql("where xilie like '%" & myXilie & "%'", "Main")   '获得排序类型
        FormMain.SelectFromDatabase(mysql, 1)
        FormMain.Label2.Text = Juncode(myXilie)
        FormMain.Activate()
        Me.Close()
    End Sub


    Sub PlayButton_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim weizhi = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).
                GetInfo("weizhi")
            If IO.File.Exists(weizhi) Then
                Try
                    Process.Start(weizhi)
                Catch ex As Exception
                    MsgBox("打开失败，杀毒软件组织！",, "提示")
                End Try

            Else
                MsgBox("文件不存在",, "文件不存在")
            End If
        End If
    End Sub
    Sub YanYuan_MouseLeave()
        PicBYY.Visible = False
    End Sub

    Sub YanYuan_MouseEnter(sender As Object, e As EventArgs)
        Dim Label As Label = sender
        With PicBYY
            .Size = New Size(200, 200)
            .SizeMode = PictureBoxSizeMode.StretchImage
            .BackColor = Color.White
            .Cursor = Windows.Forms.Cursors.Hand
            .Left = MousePosition.X - Me.Left + 50
            .Top = MousePosition.Y - Me.Top - .Height
            LoadPicFromFile(ActressesPicSavePath & "\" & Label.Text & ".jpg", PicBYY)
            .BringToFront()
            .Visible = True
        End With
    End Sub

    Sub LoadExtraPic()
        Dim existList As New List(Of String)
        For Each item In FlowLayoutPanel4.Controls
            If Not existList.Contains(item.name) Then
                existList.Add(item.name)
            End If
        Next


        Dim PicImage As Image
        Dim PicPath As String = ExtraPicSavePath & "\" & GlobalFanhao
        If Directory.Exists(PicPath) = True Then
            Dim foundFile2 As String() = My.Computer.FileSystem.GetFiles(PicPath, FileIO.SearchOption.SearchAllSubDirectories, {"*.jpg", "*.bmp", "*.gif"}).ToArray
            For Each foundFile In foundFile2
                Application.DoEvents()
                If File.Exists(foundFile) Then
                    If My.Computer.FileSystem.GetFileInfo(foundFile).Length > 0 Then '如果图片错误会显示内存不足
                        If Not existList.Contains(GetFileName(foundFile)) Then
                            If Not IsFileInUse(foundFile) Then


                                Try
                                    Dim FS As New FileStream(foundFile, FileMode.Open, FileAccess.Read)
                                    PicImage = Image.FromStream(FS)
                                    FS.Close()
                                    FS.Dispose()
                                    Dim PicB As New PictureBox
                                    With PicB
                                        .Name = GetFileName(foundFile)
                                        .Cursor = Windows.Forms.Cursors.Hand
                                        .Height = 200
                                        .Width = 200 * PicImage.Width / PicImage.Height
                                        .Image = PicImage
                                        .SizeMode = PictureBoxSizeMode.StretchImage
                                        FlowLayoutPanel4.Controls.Add(PicB)
                                        AddHandler .MouseDown, AddressOf myPicBox_MouseDown
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

    Sub LoadBigPic()
        Dim PicPath As String
        PicPath = BigPicSavePath & "\" & GlobalFanhao & ".jpg"
        If IO.File.Exists(PicPath) Then
            If My.Computer.FileSystem.GetFileInfo(PicPath).Length > 0 Then '如果图片错误会显示内存不足
                If Not IsFileInUse(PicPath) Then


                    Try
                        Dim pFileStream As New FileStream(PicPath, FileMode.Open, FileAccess.Read)
                        PictureBox1.Image = Image.FromStream(pFileStream)
                        pFileStream.Close()
                        pFileStream.Dispose()
                        Application.DoEvents()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End If
            End If
        Else
            PictureBox1.Image = My.Resources.Resource_FormInfo.BigPicNotFound
        End If
    End Sub

    Private Sub LoadInfo()
        FormMain.CheckForPic()
        Dim VI = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).GetVedioInfo()
        Me.Text = VI.fanhao
        Label14.Text = UCase(VI.mingcheng)
        Label15.Text = VI.faxingriqi
        Label16.Text = VI.changdu & "分钟"
        Label17.Text = VI.daoyan
        Label18.Text = VI.zhizuoshang
        Label19.Text = VI.faxingshang
        Label21.Text = VI.xilie


        '加载大图
        LoadBigPic()

        '加载额外图片
        FlowLayoutPanel4.Controls.Clear()
        LoadExtraPic()

        '播放
        Dim PlayPicB As New PictureBox
        With PlayPicB
            .Parent = PictureBox1
            .Image = My.Resources.Resource_Image.播放_64
            .Size = New Size(64, 64)
            .SizeMode = PictureBoxSizeMode.Zoom
            .Cursor = Windows.Forms.Cursors.Hand
            .BackColor = Color.Transparent
            .Left = (PictureBox1.Width - .Width) / 2
            .Top = (PictureBox1.Height - .Height) / 2
            .BringToFront()
            .Visible = True
            AddHandler .Click, AddressOf PlayButton_MouseDown
        End With

        '加载类别
        FlowLayoutPanel3.Controls.Clear()
        For Each s In Split(VI.leibie, " ")
            Dim Label As New Label
            With Label
                .Text = Juncode(s)
                .AutoSize = True
                .Cursor = Windows.Forms.Cursors.Hand
                .Font = Label14.Font
                .Margin = New Padding(3, 3, 3, 0)
                AddHandler .Click, AddressOf myLabel_Leibie_Click
                FlowLayoutPanel3.Controls.Add(Label)
            End With
            Application.DoEvents()
        Next

        '加载演员
        FlowLayoutPanel6.Controls.Clear()
        For Each s In Split(VI.yanyuan, " ")
            Dim Label As New Label
            With Label
                .Text = Juncode(s)
                .AutoSize = True
                .Cursor = Windows.Forms.Cursors.Hand
                .Font = Label14.Font
                .Margin = New Padding(3, 3, 3, 0)
                AddHandler .Click, AddressOf myLabel_Yanyuan_Click
                AddHandler .MouseEnter, AddressOf YanYuan_MouseEnter
                AddHandler .MouseLeave, AddressOf YanYuan_MouseLeave
                FlowLayoutPanel6.Controls.Add(Label)
                Application.DoEvents()
            End With

        Next

        '加载标签
        FlowLayoutPanel5.Controls.Clear()
        '标签增加号
        Dim JiaLabel As New Label
        With JiaLabel
            .AutoSize = True
            .Text = "+"
            .Cursor = Windows.Forms.Cursors.Hand
            .Font = Label14.Font
            FlowLayoutPanel5.Controls.Add(JiaLabel)
            AddHandler .Click, AddressOf JiaLabel_Click
        End With

        For Each s In Split(VI.biaoqian, " ")
            Dim Label As New Label
            With Label
                .Text = Juncode(s)
                .AutoSize = True
                .Cursor = Windows.Forms.Cursors.Hand
                .Font = Label14.Font
                .Margin = New Padding(3, 0, 3, 0)
                AddHandler .Click, AddressOf myLabel_Biaoqian_Click
                FlowLayoutPanel5.Controls.Add(Label)
                Application.DoEvents()
            End With
        Next





        '访问次数+1
        Dim SetFangwencishu = New ShareClass.DataBase("")
        SetFangwencishu.UpdateCommand("update Main set fangwencishu=" & Int(VI.fangwencishu) + 1 & " where fanhao='" & VI.fanhao & "'")
        SetFangwencishu.Dispose()



        ExtraPanel.Height = 200
        ExtraPanel.Width = FlowLayoutPanel1.Width - 40
        ExtraPanel.BackColor = Color.Transparent
        PicBYY.Visible = False

        FlowLayoutPanel1.Focus()

        SetSkin()

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
            result = Await DL.Download(vedio.Pic_B)
            If result Then
                '回调
                If Me.IsHandleCreated Then
                    Me.Invoke(New OnFanhaoComplete(Sub()
                                                       If GlobalFanhao = fanhao Then
                                                           Me.LoadBigPic()
                                                       End If
                                                   End Sub))
                End If

            End If

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



    Private Sub JiaLabel_Click()
        Dim NewTag = InputBox("新的标签")
        If NewTag = "" Then Exit Sub
        If InStr(NewTag, " ") > 0 Then MsgBox("不允许有空格！",, "不允许有空格") : Exit Sub
        Dim BQ = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).
                GetInfo("biaoqian")
        If InStr(BQ, NewTag) > 0 Then MsgBox("不允许重复！",, "不允许重复") : Exit Sub

        '整合标签
        Dim Total As String = ""
        For Each item In Split(BQ, " ")
            If Len(item) > 0 Then
                Total = Total & item & " "
            End If
        Next
        Total = Total & NewTag

        '更新数据库
        Dim UpdateInfoToDataBase = New ShareClass.DataBase("")
        UpdateInfoToDataBase.UpdateCommand("update Main set  biaoqian='" & ShareClass.ChaoSub.FormatDataBaseInfo(Total) & "' where fanhao='" & GlobalFanhao & "'")
        UpdateInfoToDataBase.Dispose()

        '载入标签
        FlowLayoutPanel5.Controls.Clear()
        Dim JiaLabel As New Label
        With JiaLabel
            .AutoSize = True
            .Text = "+"
            .Cursor = Windows.Forms.Cursors.Hand
            .BackColor = Color.Transparent
            .Font = New System.Drawing.Font("Times New Roman", 12)
            FlowLayoutPanel5.Controls.Add(JiaLabel)
            AddHandler .Click, AddressOf JiaLabel_Click
        End With

        For Each item In Split(Total, " ")
            Dim Label As New Label
            With Label
                .Text = Juncode(item)
                .AutoSize = True
                .Cursor = Windows.Forms.Cursors.Hand
                .Font = Label14.Font
                .Margin = New Padding(3, 0, 3, 0)
                AddHandler .Click, AddressOf myLabel_Biaoqian_Click
                FlowLayoutPanel5.Controls.Add(Label)
            End With
        Next

    End Sub

    Private Sub myPicBox_MouseDown(sender As Object, e As MouseEventArgs)
        'ExtraPic
        Dim PicB As PictureBox = sender
        Dim PicPath As String = ExtraPicSavePath & "\" & GlobalFanhao & "\" & sender.name
        If e.Button = MouseButtons.Left Then
            '显示图片
            With FormViewPicture
                .Size = Me.Size
                .PictureBox1.Name = PicB.Name
                .PictureBox1.Size = .Size
                .PictureBox1.Location = New Point(0, 0)
                .PictureBox1.Image = PicB.Image
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

    Private Sub BigPic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '设置主题

        SetSkin()
    End Sub

    Public Sub SetSkin()


        Dim SC = New ShareClass.Skin(Settings.SkinStyle)

        Me.Icon = FormMain.Icon


        TitlePanel.BackColor = SC.BC1
        Me.BackColor = SC.BC2
        FlowLayoutPanel1.BackColor = SC.BC2
        FormTextLabel.ForeColor = SC.FC2
        For Each item In FlowLayoutPanel2.Controls
            If item.GetType.ToString = "System.Windows.Forms.Label" Then
                Dim Label As Label = item
                Label.BackColor = SC.BC2
                Label.ForeColor = SC.FC2
            End If
        Next

        FlowLayoutPanel3.BackColor = SC.BC2
        For Each item As Label In FlowLayoutPanel3.Controls
            item.BackColor = SC.BC2
            item.ForeColor = SC.FC2
        Next

        FlowLayoutPanel6.BackColor = SC.BC2
        For Each item As Label In FlowLayoutPanel6.Controls
            item.BackColor = SC.BC2
            item.ForeColor = SC.FC2
        Next

        FlowLayoutPanel5.BackColor = SC.BC2
        For Each item As Label In FlowLayoutPanel5.Controls
            item.BackColor = SC.BC2
            item.ForeColor = SC.FC2
        Next

    End Sub

    Private Sub FormBus_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadInfo()
    End Sub


    Private Sub BigPic_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, FlowLayoutPanel1.KeyDown, PictureBox1.KeyDown
        If e.KeyCode = Keys.F5 Then
            LoadInfo()
            Debug.Print("刷新")
        End If
    End Sub


    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Dim PicPath As String = ExtraPicSavePath & "\" & GlobalFanhao & "\" & sender.name
        If e.Button = MouseButtons.Left Then
            '显示图片
            Dim PicB As PictureBox = sender
            With FormViewPicture
                .Size = Me.Size
                .TransparencyKey = Color.Black
                .BackColor = Color.Black
                .PictureBox1.Name = PicB.Name
                .PictureBox1.Size = .Size
                .PictureBox1.Location = New Point(0, 0)
                .PictureBox1.Image = PicB.Image
                .PictureBox1.BackColor = Color.FromArgb(150, 0, 0, 0)
                .PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                .Label3.Visible = False
                .Label4.Visible = False
                .Show()
                .BringToFront()
            End With
        ElseIf e.Button = MouseButtons.Right Then

        End If
    End Sub

    Private Sub 打开影片位置ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 打开影片位置ToolStripMenuItem.Click

        Dim Path As String = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).
            GetInfo("weizhi")
        If IO.File.Exists(Path) Then
            OpenFilePath(Path)

        Else
            MsgBox(GlobalFanhao & "【不存在】",, "不存在")
        End If
    End Sub

    Private Sub 打开照片位置ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 打开照片位置ToolStripMenuItem.Click
        Dim Path As String = Application.StartupPath & "\Pic\BigPic\" & GlobalFanhao & ".jpg"
        If IO.File.Exists(Path) Then
            OpenFilePath(Path)

        Else
            MsgBox(GlobalFanhao & "【不存在】",, "不存在")
        End If
    End Sub

    Private Sub 复制ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复制ToolStripMenuItem.Click
        Dim Path As String = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).
            GetInfo("weizhi")
        Dim FileList = New Specialized.StringCollection
        If IO.File.Exists(Path) Then
            FileList.Add(Path)
        Else
            MsgBox(GlobalFanhao & "【不存在】",, "不存在")
        End If
        If FileList.Count > 0 Then
            My.Computer.Clipboard.SetFileDropList(FileList)
        End If
    End Sub

    Private Sub 打开其网址ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 打开其网址ToolStripMenuItem.Click
        Try
            Process.Start(Settings.BusWebSite & "/" & GlobalFanhao)
        Catch ex As Win32Exception
            MsgBox("网址有问题",, "网址有问题")
        End Try
    End Sub

    Private Sub EditInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditInfoToolStripMenuItem.Click
        FormEdit.Close()
        FormEdit.Show()
        FormEdit.BringToFront()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove, FlowLayoutPanel2.MouseMove, FlowLayoutPanel1.MouseMove
        FlowLayoutPanel1.Focus()
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

        For Each item In FlowLayoutPanel4.Controls
            Dim PicB As PictureBox = item
            If PicB.Name = GetFileName(ExtraPicPath) Then
                FlowLayoutPanel4.Controls.Remove(PicB)
                Exit For
            End If
        Next

    End Sub

    Private Sub FormBus_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Task.Run(Sub()
                     If DownLoadThread IsNot Nothing Then
                         '立即停止当前任务
                         If IsThreadRunning Then
                             DownLoadThreadCancel = True
                             DownLoadThread.Join()
                             DownLoadThread.Abort()
                             Do
                                 Threading.Thread.Sleep(100)
                             Loop Until IsThreadRunning = False
                             IsClosingFromInfo = True
                         End If
                     End If
                 End Sub)
    End Sub

    Private Sub FormBus_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        '消除周围白线
        e.Graphics.Clear(Me.BackColor)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(34, 37, 42), 2), 0, 0, Me.Width, 0)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), Me.Width, 0, Me.Width, Me.Height)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), Me.Width, Me.Height, 0, Me.Height)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), 0, Me.Height, 0, 0)
    End Sub
End Class