Imports System.ComponentModel
Imports System.IO
Imports ShareClass.Net
Imports ShareClass.ChaoSub
Imports System.Threading
Imports System.Drawing.Drawing2D

Public Class FormMain

    Delegate Sub DelegateSetStatus(ByVal state As String, ByVal msg As String)
    Delegate Sub OnTaskSetStatus(ByVal result As Boolean, ByVal fanhao As String)
    Delegate Sub OnTaskPrint(ByVal str As String)
    Delegate Sub OnThreadCancel()

    Sub ThreadCanel()
        DownLoadList.Clear()
        DownLoadedList.Clear()
        Label6.Text = "0/0"
        ProgressBar1.Value = 0
        Label4.Text = "任务全部取消"
        IsThreadRunning = False
    End Sub

    Sub TaskPrint(ByVal str As String)
        RichTextBox1.Text = str & vbCrLf & RichTextBox1.Text
    End Sub

    Sub SetStatus(ByVal state As String, ByVal msg As String)
        Chao_StatusIndicator1.Status = state
        Label4.Text = msg
        Label6.Text = Split(Label6.Text, "/")(0) & "/" & DownLoadList.Count
    End Sub

    Sub TaskSetStatus(ByVal result As Boolean, ByVal fanhao As String)
        Label6.Text = DownLoadedList.Count & "/" & DownLoadList.Count
        ProgressBar1.Value = Int(DownLoadedList.Count / DownLoadList.Count * 100)
        For Each item As ListViewItem In ListView1.Items
            If item.SubItems(0).Text = fanhao Then
                item.SubItems(1).Text = IIf(result, "完成！", "未完全下载")
                item.BackColor = IIf(result, Color.LightGreen, Color.LightYellow)
                ListView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
                Exit For
            End If
        Next
    End Sub
    Private Sub SetPicB_Click(sender As Object, e As EventArgs) Handles SetPicB.Click
        FormSetup.Show()
    End Sub



    Private Sub FormDownLoader_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForFile()
        LoadSetupInfomation() '载入软件设置
        CheckForPic() '删除无用图片



    End Sub

    Private DelPicList As New List(Of String)
    Sub CheckForPic()

        DelPicList.Clear()
        Dim SearchPath = Application.StartupPath & "\Pic"
        Try
            GetAllFile(SearchPath)
        Catch ex As Exception
        End Try

        For Each FilePath In DelPicList
            Try
                File.Delete(FilePath)
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub GetAllFile(path As String)
        Dim mySearchPattern = New String() {"*.jpg"}
        If IsDirectoryScanable(path) Then
            Dim myfi As DirectoryInfo = New DirectoryInfo(path)
            Dim myIReadOnlyCollection As IReadOnlyCollection(Of String) = My.Computer.FileSystem.GetFiles(path, FileIO.SearchOption.SearchTopLevelOnly, mySearchPattern)
            For Each foundfile As String In myIReadOnlyCollection
                Dim FI As FileInfo = New FileInfo(foundfile)
                If FI.Length <= 4000 Then
                    DelPicList.Add(foundfile)
                End If
                Application.DoEvents()
            Next

            Dim FileInfo As String() = Directory.GetDirectories(path)
            For Each f In FileInfo
                If IsDirectoryScanable(f) Then
                    GetAllFile(f)
                End If
                Application.DoEvents()
            Next
        End If

    End Sub

    Public Function IsDirectoryScanable(dir As String) As Boolean
        Dim FileInfo As DirectoryInfo
        If My.Computer.FileSystem.DirectoryExists(dir) Then '是否存在
            If Len(dir) <= 3 Then '磁盘根目录
                Return True
            End If
            FileInfo = My.Computer.FileSystem.GetDirectoryInfo(dir)
            'Debug.Print(FileInfo.Attributes.ToString)
            If InStr(FileInfo.Attributes.ToString, "System") > 0 Or (InStr(FileInfo.Attributes.ToString, "System") And InStr(FileInfo.Attributes.ToString, "Hidden")) Then
                '如果文件夹属性时system或者system | hidden 则返回false
                Return False
            Else
                '试试看能不能获得所有子目录
                Try
                    Dim Fi As String() = Directory.GetDirectories(dir)
                Catch ex As Exception '不能获得子目录说明无权访问
                    Debug.Print(ex.Message)
                    Return False
                End Try
                Return True
            End If
        Else
            Debug.Print("不存在")
            Return False
        End If
    End Function

    Sub LoadSetupInfomation()


        '代理
        'SetProxy()

        '保存地址
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

        ListView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize)
        ListView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize)

    End Sub


    Private Sub CheckForFile()
        If Not IO.File.Exists(Application.StartupPath & "\Data\Qibing.txt") Then MsgBox("缺失数据文件",, "提示") : Me.Close()
        If Not File.Exists(Application.StartupPath & "\Data\DBFCIndex.txt") Then File.Create(Application.StartupPath & "\Data\DBFCIndex.txt")
        If Not File.Exists(Application.StartupPath & "\Data\BusIndex.txt") Then File.Create(Application.StartupPath & "\Data\BusIndex.txt")
        Directory.CreateDirectory(Application.StartupPath & "\Download")
    End Sub



    Private Sub Label3_MouseMove(sender As Object, e As MouseEventArgs) Handles Label3.MouseMove, Label2.MouseMove, Label1.MouseMove, Label5.MouseMove
        sender.backcolor = Color.FromArgb(50, 0, 0, 0)
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave, Label2.MouseLeave, Label1.MouseLeave, Label5.MouseLeave
        sender.backcolor = Color.Transparent
    End Sub



    Function IsDataBaseExist() As Boolean
        '检查数据库
        If Not IO.File.Exists(Application.StartupPath & "\mdb\MainDatabase.mdb") Then
            Return False
        Else
            con_ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\mdb\MainDatabase.mdb"
            Return True
        End If
    End Function




    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs)
        Dim columnsort As New ShareClass.ColumnSort(e.Column)
        columnsort.bAscending = (sender.Sorting = SortOrder.Ascending)
        If columnsort.bAscending Then
            sender.Sorting = SortOrder.Descending
        Else
            sender.Sorting = SortOrder.Ascending
        End If
        sender.ListViewItemSorter = columnsort
        sender.ListViewItemSorter = Nothing
    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        FormSingleDownload.Show()
        FormSingleDownload.BringToFront()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        FormSpecialDownLoad.Show()
        FormSpecialDownLoad.BringToFront()
    End Sub

    Sub ReadDataBase()
        If DownLoadThread IsNot Nothing Then
            If IsThreadRunning Then
                MsgBox("请等待本次下载完成",, "提示") : Exit Sub
            End If

        Else
            '设置参数不可变
            Dim SkipCondition = Settings.SkipCondition
            Dim CreateFanhaoFile = Settings.CreateFanhaoFile
            Dim DownLoadToDatabase = Settings.DownLoadToDatabase
            Dim DownLoadToNFO = Settings.DownLoadToNFO
            Dim DownLoadFanart = Settings.DownLoadFanart
            CheckForPic()
            Me.Invoke(New DelegateSetStatus(AddressOf SetStatus), "Running", "加载中……")
            Dim db As New ShareClass.DataBase("select * from Main")
            Dim vediolist = db.GetAllVedioInfo()
            For Each item In vediolist
                '三个条件
                '0-数据库中的信息不为空
                '1-大小图都存在
                '2-至少存在一张预览图
                '3- 不跳过
                Select Case SkipCondition
                    Case 0
                        If item.mingcheng <> "" And Not DownLoadList.Contains(item.fanhao) Then DownLoadList.Add(item.fanhao)
                    Case 1
                        Dim PicP1, PicP2 As String
                        If CreateFanhaoFile Then
                            PicP1 = Application.StartupPath & "\DownLoad\" & item.fanhao & "\" & item.fanhao & "_s.jpg"
                            PicP2 = Application.StartupPath & "\DownLoad\" & item.fanhao & "\" & item.fanhao & "_b.jpg"
                        Else
                            PicP1 = Application.StartupPath & "\Pic\SmallPic\" & item.fanhao & ".jpg"
                            PicP2 = Application.StartupPath & "\Pic\BigPic\" & item.fanhao & ".jpg"
                        End If
                        If Not IO.File.Exists(PicP1) And Not IO.File.Exists(PicP2) And Not DownLoadList.Contains(item.fanhao) Then DownLoadList.Add(item.fanhao)
                    Case 2
                        Dim PicP3 As String
                        If CreateFanhaoFile Then
                            PicP3 = Application.StartupPath & "\DownLoad\" & item.fanhao & "\"
                        Else
                            PicP3 = Application.StartupPath & "\Pic\Extra\" & item.fanhao & "\"
                        End If
                        If Not IsAtLeastOneExtraPic(PicP3, item.fanhao) And Not DownLoadList.Contains(item.fanhao) Then DownLoadList.Add(item.fanhao)
                    Case 3
                        If Not DownLoadList.Contains(item.fanhao) Then DownLoadList.Add(item.fanhao)
                    Case Else

                End Select

            Next
            Me.Invoke(New DelegateSetStatus(AddressOf SetStatus), "Success", "加载完成，请点击开始或继续加载")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If IsDataBaseExist() Then
            Task.Run(AddressOf ReadDataBase)
        Else
            MsgBox("数据库不存在！",, "提示")
        End If




    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub




    Private Sub FormDownLoader_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        NotifyIcon1.Visible = False
        If Settings.CloseToTaskbar Then
            If Me.Visible Then
                e.Cancel = True
                Me.Hide()
                NotifyIcon1.Visible = True
            Else
            End If
        Else

            If DownLoadThread IsNot Nothing Then
                DownLoadThread.Abort()
                DownLoadThread.Join()
            End If
        End If
    End Sub

    Private Sub FormDownLoader_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        Me.Close()
    End Sub

    Private Sub 打开下载器ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开下载器ToolStripMenuItem.Click
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub DownloadTimer_Tick(sender As Object, e As EventArgs) Handles DownloadTimer.Tick
        If DownLoadNum > 0 Then
            Chao_StatusIndicator1.Status = "Running"
            If DownLoadNum >= MaxDownLoadNum Then
                ' 下载总量超过5就暂停线程
                PauseDownload = True
            Else
                PauseDownload = False
            End If
        Else
            Chao_StatusIndicator1.Status = "Success"
        End If


        Dim total As String = ""

        Dim newl As New List(Of String)
        For Each item In DownLoadMsg
            newl.Add(item)
        Next
        DownLoadMsg.Clear()

        For Each item In newl
            RichTextBox1.AppendText(item & vbCrLf)
            If Strings.Left(item, 2) = "失败" Then
                RichTextBox1.SelectionStart = Len(RichTextBox1.Text) - Len(item) - 1
                RichTextBox1.SelectionLength = 2
                RichTextBox1.SelectionBackColor = Color.Red
            End If

        Next

        If DownLoadingList.Count > 0 Then
            Label6.Text = DownLoadedList.Count & "/" & DownLoadingList.Count
            Dim progress As Single = CType(DownLoadedList.Count / DownLoadingList.Count * ProgressBar1.Maximum, Single)
            If progress > ProgressBar1.Maximum Then
                ProgressBar1.Value = ProgressBar1.Maximum
            Else
                ProgressBar1.Value = progress
            End If

            If DownLoadedList.Count = DownLoadingList.Count Then
                '下载完成
                '写入log
                Dim FileP As String = Application.StartupPath & "\Log\DownLoad.log"
                If Not IO.File.Exists(FileP) Then IO.File.Create(FileP)
                If Not IsFileInUse(FileP) Then
                    Using FS As FileStream = New FileStream(FileP, FileMode.Append, FileAccess.Write)
                        FS.Lock(0, FS.Length)
                        Dim SW = New StreamWriter(FS)
                        SW.WriteLine("----------------------------" & vbCrLf & Now.ToString & vbCrLf & "----------------------------" & vbCrLf & RichTextBox1.Text)
                        FS.Unlock(0, FS.Length)
                        SW.Flush()
                    End Using
                End If

                DownLoadedList.Clear()
                DownLoadingList.Clear()
            End If
        End If


    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        DownLoadMsg.Clear()
        RichTextBox1.ResetText()
    End Sub

    Sub StartDownLoad()
        '逐个下载
        IsThreadRunning = True
        Dim fanhao As String = ""
        Dim ID As Double = 0
        Dim result As Boolean = False
        Dim BusDownLoadList As New List(Of String)
        Dim FCDownLoadList As New List(Of String)
        Dim FC2StartIndex As Integer = 0
        Dim BusStartIndex As Integer = 0
        For Each item In DownLoadList
            If InStr(item, "FC2") > 0 Then
                FCDownLoadList.Add(item)
            Else
                BusDownLoadList.Add(item)
            End If
        Next

        'FC2
        Task.Run(Async Sub()
                     FC2Running = True
                     Dim Max As Integer = FCDownLoadList.Count - 1
                     Dim FC2result As Boolean = False
                     For i = 0 To Max Step 1
                         If DownLoadThreadCancel Then FC2Running = False : FC2StartIndex = i : Exit For
                         FC2result = Await DownLoadBus(FCDownLoadList(i))
                         Console.WriteLine("FC2下载第{0}/{1}个:{2}", i, Max, FCDownLoadList(i))
                         Thread.Sleep(2000)
                     Next
                     FC2Running = False
                     Console.WriteLine("IsThreadRunning={0},FC2Running={1},BusRunning={2}", IsThreadRunning, FC2Running, BusRunning)
                 End Sub)

        'Bus
        Task.Run(Async Sub()
                     BusRunning = True
                     Dim Max As Integer = BusDownLoadList.Count - 1
                     Dim busresult As Boolean = False
                     For i = 0 To Max Step 1
                         If DownLoadThreadCancel Then BusRunning = False : BusStartIndex = i : Exit For
                         busresult = Await DownLoadBus(BusDownLoadList(i))
                         Console.WriteLine("Bus下载第{0}/{1}个:{2}", i, Max, BusDownLoadList(i))
                         Thread.Sleep(3000)
                     Next
                     BusRunning = False
                     Console.WriteLine("IsThreadRunning={0},FC2Running={1},BusRunning={2}", IsThreadRunning, FC2Running, BusRunning)
                 End Sub)
    End Sub


    Async Function DownLoadBus(Fanhao As String) As Task(Of Boolean)
        Dim result As Boolean = False

        '获得视频信息
        Dim vedio As New ShareClass.Variable.Vedio
        If InStr(Fanhao, "FC2") > 0 Then
            Dim FC2 = New ShareClass.Javdb(Fanhao, Settings.DBWebSite, DownLoadProxy, False)
            Me.Invoke(New OnTaskPrint(AddressOf TaskPrint), "从" & Settings.DBWebSite & "请求" & Fanhao)
            vedio = Await FC2.Parse()
        Else
            Dim Bus = New ShareClass.Bus(Fanhao, Settings.BusWebSite, DownLoadProxy, False)
            Me.Invoke(New OnTaskPrint(AddressOf TaskPrint), "从" & Settings.BusWebSite & "请求" & Fanhao)
            vedio = Await Bus.Parse()
        End If



        If vedio.num = "" Then
            DownLoadedList.Add(Fanhao)
            Me.Invoke(New OnTaskPrint(AddressOf TaskPrint), "失败：" & Fanhao)
            Return False
        End If
        result = True
        '保存到nfo
        If Settings.DownLoadToNFO Then
            Dim nfopath As String = ""
            If Settings.CreateFanhaoFile Then
                nfopath = Application.StartupPath & "\DownLoad\" & Fanhao & "\"
            Else
                nfopath = Application.StartupPath & "\DownLoad\NFO\"
            End If
            Directory.CreateDirectory(nfopath)
            SaveToNFO(vedio, nfopath & Fanhao & ".nfo")
        End If


        '保存到数据库
        If Settings.DownLoadToDatabase Then
            SaveToDataBase(vedio)
        End If

        '下载小图、大图、演员
        Dim Picpath As String = ""
        Dim PicP1, PicP2, PicP3 As String
        If Settings.CreateFanhaoFile Then
            PicP1 = Application.StartupPath & "\DownLoad\" & Fanhao & "\"
            PicP2 = PicP1
            PicP3 = PicP1
        Else
            PicP1 = Application.StartupPath & "\Pic\SmallPic\"
            PicP2 = Application.StartupPath & "\Pic\BigPic\"
            PicP3 = Application.StartupPath & "\Pic\Extra\" & Fanhao & "\"
        End If
        Directory.CreateDirectory(PicP1)
        Directory.CreateDirectory(PicP2)
        Directory.CreateDirectory(PicP3)

        If DownLoadThreadCancel Then Return False
        Me.Invoke(New OnTaskPrint(AddressOf TaskPrint), "开始下载小图：" & vedio.Pic_S)
        result = result And Await DownLoadPic(PicP1 & Fanhao & IIf(Settings.CreateFanhaoFile, "_s.jpg", ".jpg"), vedio.Pic_S, Proxy:=DownLoadProxy)
        Me.Invoke(New OnTaskPrint(AddressOf TaskPrint), "开始下载大图：" & vedio.Pic_B)
        result = result And Await DownLoadPic(PicP2 & Fanhao & IIf(Settings.CreateFanhaoFile, "_b.jpg", ".jpg"), vedio.Pic_B, Proxy:=DownLoadProxy)
        If Settings.DownLoadFanart Then
            Dim FAL = Split(vedio.fanart, " ")
            For i = 0 To FAL.Count - 1 Step 1
                If DownLoadThreadCancel Then Return False
                Dim item = FAL(i)
                If Len(item) > 0 And item <> "" Then
                    Me.Invoke(New OnTaskPrint(AddressOf TaskPrint), "开始下载预览图：" & i + 1 & "/" & FAL.Count - 1 & "：" & item)

                    result = result And Await DownLoadPic(PicP3 & Split(item, "/")(Split(item, "/").Count - 1), item, Proxy:=DownLoadProxy)
                End If

            Next
        End If

        DownLoadedList.Add(Fanhao)

        If Me.IsHandleCreated Then Me.Invoke(New OnTaskSetStatus(AddressOf TaskSetStatus), result, Fanhao)

        Return result
    End Function

    Public Sub Chao_Button1_Click(sender As Object, e As EventArgs) Handles Chao_Button1.Click
        If DownLoadList.Count <= 0 Then
            Label4.Text = "请添加任务!"
            Exit Sub
        End If

        ListView1.Items.Clear()
        RichTextBox1.Text = ""

        For Each item In DownLoadList
            ListView1.BeginUpdate()
            ListView1.Items.Add(New ListViewItem({item, "未下载"}))
            ListView1.EndUpdate()
        Next
        If ListView1.Items.Count > 0 Then
            ListView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent)
            ListView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)

        Else
            ListView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize)
            ListView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize)
        End If


        IsThreadRunning = FC2Running Or BusRunning
        If IsThreadRunning Then
            MsgBox("任务正在进行！请等待或停止！",, "提示")
        Else
            CheckForPic()

            DownLoadThreadCancel = False
            DownLoadThread = New System.Threading.Thread(AddressOf StartDownLoad)
            DownLoadThread.Start()
        End If



    End Sub

    Private Sub Chao_Button2_Click(sender As Object, e As EventArgs) Handles Chao_Button2.Click
        If DownLoadList.Count = 0 Then Exit Sub

        If MsgBox("停止并清空所有任务？", vbYesNo, "停止并清空所有任务？") = vbYes Then
            Label4.Text = "正在停止任务……"
            Task.Run(Sub()
                         DownLoadThreadCancel = True
                         Do
                             Thread.Sleep(200)
                         Loop Until (FC2Running Or BusRunning) = False
                         Console.WriteLine("任务全部取消")
                     End Sub).ContinueWith(Sub()
                                               Me.Invoke(New OnThreadCancel(AddressOf ThreadCanel))
                                           End Sub)
        End If
    End Sub

    Private Sub Chao_StatusIndicator1_Load(sender As Object, e As EventArgs) Handles Chao_StatusIndicator1.Load

    End Sub

    Private Sub NotifyIcon1_MouseDown(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDown
        If e.Button = MouseButtons.Right Then
            Chao_ContextStripMenu1.Show(MousePosition)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim BS As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(33, 147, 176), Color.FromArgb(109, 213, 237), LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(BS, Me.ClientRectangle)
    End Sub
End Class
