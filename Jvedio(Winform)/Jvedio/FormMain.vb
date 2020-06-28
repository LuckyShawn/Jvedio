Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO
Imports ShareClass.Access
Imports ShareClass.ChaoSub
Imports System.Threading

Public Class FormMain
    Public SideBarTimer As New System.Windows.Forms.Timer With {.Interval = 1000}    '收放侧边栏
    Public TimerMove As New System.Windows.Forms.Timer With {.Interval = 1}  '展开更多动画

    Delegate Sub OnThreadCancel(obj As Object)
    Delegate Sub OnThreadComplete(obj As Object)
    Delegate Sub OnFanhaoComplete()
    Delegate Sub OnThreadPause(obj As Object)
    Delegate Sub OnThreadRuning(obj As Object)

    '获得要显示的影片的总数目
    Function GetTotalNum(sql As String) As Int16
        If sql = "" Then Return 0

        Dim num As Int16 = 0
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Try
            con.ConnectionString = con_ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = sql
            dr = cmd.ExecuteReader()
            Dim PicPath As String = ""
            While (dr.Read)
                If Settings.ShowPlay Then
                    Dim weizhi As String = dr.Item("weizhi").ToString
                    If IO.File.Exists(weizhi) Then
                        num += 1
                    End If
                Else
                    num = num + 1
                End If
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            ShareClass.ChaoSub.WriteLog(ex)
            Return 0
        Finally
            If con IsNot Nothing Then con.Close()
        End Try
        Return num
    End Function

    Private Function ReadfromDatebase(sql As String, Page As Integer, MaxNum As Integer) As List(Of ShareClass.Variable.VedioInfo)
        Dim result As New List(Of ShareClass.Variable.VedioInfo)
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim num As Integer = 1
        con.ConnectionString = con_ConnectionString_read
        con.Open()
        cmd.Connection = con
        cmd.CommandText = sql
        dr = cmd.ExecuteReader() '执行OLEDB命令以ExecuteReader()方式，并返回一个OLEDBReader，赋值给dr
        While (dr.Read)
            If num = Page * MaxNum + 1 Then Exit While

            If num >= (Page - 1) * MaxNum + 1 And num <= TotalNum Then
                Dim VI As New ShareClass.Variable.VedioInfo
                With VI
                    .ID = CType(dr.Item("ID").ToString, Double)
                    .mingcheng = Juncode(dr.Item("mingcheng").ToString)
                    If dr.Item("love").GetType.ToString = "System.DBNull" Then .love = 0 Else .love = Int(dr.Item("love").ToString)
                    .faxingriqi = dr.Item("faxingriqi").ToString
                    .fanhao = dr.Item("fanhao").ToString
                    .weizhi = dr.Item("weizhi").ToString
                End With
                If Settings.ShowPlay Then
                    If File.Exists(VI.weizhi) Then
                        result.Add(VI)
                        num = num + 1
                    End If
                Else
                    result.Add(VI)
                    num = num + 1
                End If

            Else
                num += 1

            End If

        End While
        dr.Close()
        con.Close()
        Return result
    End Function



    ''' <summary>
    ''' 从数据库里读取并显示在Flowlayoutpanel中
    ''' </summary>
    ''' <param name="sql">sql的select语句</param>
    ''' <param name="Page">第几页</param>
    Public Sub SelectFromDatabase(sql As String, Page As Integer)
        EditList.Clear()
        DownLoadList.Clear()
        InfoIDList.Clear()

        If IsSelectFromDatabase Then MsgBox("加载中！",, "提示") : Exit Sub
        IsSelectFromDatabase = True

        '----------------------载入开始------------------
        CheckForPic()
        Me.Cursor = Cursors.WaitCursor
        GC.Collect()       '释放资源
        Panel2.Visible = False
        RefreshCMS.Enabled = True
        Chao_Panel3.Enabled = False
        Chao_FlowLayoutPanel1.Controls.Clear()
        '----------------------载入开始------------------

        '----------------------载入中------------------
        TotalNum = GetTotalNum(sql) '获得要载入的数目
        If TotalNum <> 0 Then

            Dim SowBP As Boolean = Settings.FormMainShowBigPic

            For Each VI As ShareClass.Variable.VedioInfo In ReadfromDatebase(sql, Page, Settings.LayoutNumber)
                If Not InfoIDList.Contains(VI.ID) Then InfoIDList.Add(VI.ID)
                '只有名称为空、图片不存在才会下载
                Dim InfoPanel As New InfoPanel(VI, LoveCMS)
                Chao_FlowLayoutPanel1.Controls.Add(InfoPanel.Panel)
                Dim PicPath As String = IIf(SowBP, BigPicSavePath & "\" & VI.fanhao & ".jpg", SmallPicSavePath & "\" & VI.fanhao & ".jpg")
                If (VI.mingcheng = "" Or Not IO.File.Exists(PicPath)) Then
                    If Not DownLoadList.Contains(InfoPanel.Panel) Then DownLoadList.Add(InfoPanel.Panel)
                End If
                Application.DoEvents()
            Next
        End If


        ShowScanPanel()
        Chao_FlowLayoutPanel1.Focus()
        Label1.Text = "/" & Math.Ceiling(TotalNum / Settings.LayoutNumber) & " 页"
        LabelStatus.Text = "本页有 " & Chao_FlowLayoutPanel1.Controls.Count & " 个，总计有 " & TotalNum & " 个"
        '----------------------载入中------------------

        '----------------------载入完成------------------
        Chao_TextBox1.Text = Page
        Chao_Panel3.Enabled = True
        Label12.Enabled = True
        Label13.Enabled = True
        PictureBox5.Enabled = True
        Chao_Button1.Enabled = True
        Chao_Button3.Enabled = True
        Chao_TextBox1.Enabled = True
        Label1.Enabled = True



        Me.Cursor = Cursors.Arrow
        Chao_FlowLayoutPanel1.Focus()
        SideBarTimer.Start()
        IsSelectFromDatabase = False
        SetSkin()
        '----------------------载入完成------------------

        '------------------开启下载线程------------------
        FC2StartIndex = 0
        BusStartIndex = 0

        StartThread()
        '------------------开启下载线程------------------

        GC.Collect()       '释放资源
    End Sub

    Sub StartThread()
        Task.Run(Sub()
                     If DownLoadThread IsNot Nothing Then
                         '立即停止当前任务，重新开始新的任务
                         DownLoadThreadCancel = True
                         DownLoadThread.Join()
                         DownLoadThread.Abort()
                         Do
                             Thread.Sleep(100)
                         Loop Until IsThreadRunning = False
                         DownLoadThreadCancel = False
                         DownLoadThread = New System.Threading.Thread(AddressOf StartDownLoad)
                         DownLoadThread.Start()
                     Else
                         DownLoadThreadCancel = False
                         DownLoadThread = New System.Threading.Thread(AddressOf StartDownLoad)
                         DownLoadThread.Start()
                     End If
                 End Sub)



    End Sub

    Sub StartDownLoad()
        IsThreadRunning = True
        Dim DB As ShareClass.DataBase
        Dim fanhao As String = ""
        Dim ID As Double = 0
        Dim result As Boolean = False
        Dim BusDownLoadList As New List(Of Panel)
        Dim FCDownLoadList As New List(Of Panel)
        Dim DL = DownLoadList.ToArray
        For Each item In DL
            ID = GetIDFromPanel(item)
            DB = New ShareClass.DataBase("select * from Main where ID=" & ID)
            fanhao = DB.GetInfo("fanhao")
            If InStr(fanhao, "FC2") > 0 Then
                FCDownLoadList.Add(item)
            Else
                BusDownLoadList.Add(item)
            End If
        Next

        'FC2
        Task.Run(Sub()
                     FC2Running = True
                     Dim Max As Integer = FCDownLoadList.Count - 1
                     For i = FC2StartIndex To Max Step 2
                         If DownLoadThreadCancel Then FC2Running = False : FC2StartIndex = i : Exit For
                         'FC2  同时下载2个，每个间隔为 2s 
                         If i <= Max Then DownLoadBus(FCDownLoadList(i))
                         Console.WriteLine("FC2下载第{0}/{1}个", i, Max)
                         Thread.Sleep(2000)
                         If i + 1 <= Max Then DownLoadBus(FCDownLoadList(i + 1))
                         Console.WriteLine("FC2下载第{0}/{1}个", i + 1, Max)
                         Thread.Sleep(2000)
                     Next
                     FC2Running = False
                 End Sub).ContinueWith(AddressOf IsAllComplete)

        'Bus
        Task.Run(Sub()
                     BusRunning = True
                     Dim Max As Integer = BusDownLoadList.Count - 1
                     For i = BusStartIndex To Max Step 4
                         If DownLoadThreadCancel Then BusRunning = False : BusStartIndex = i : Exit For
                         If Settings.FormMainShowBigPic Then
                             ' Bus 大图  同时下载4个，时间间隔为 5s 
                             If i <= Max Then DownLoadBus(BusDownLoadList(i))
                             Console.WriteLine("Bus下载第{0}/{1}个", i, Max)
                             If i + 1 <= Max Then DownLoadBus(BusDownLoadList(i + 1))
                             Console.WriteLine("Bus下载第{0}/{1}个", i + 1, Max)
                             Thread.Sleep(2500)
                             If i + 2 <= Max Then DownLoadBus(BusDownLoadList(i + 2))
                             Console.WriteLine("Bus下载第{0}/{1}个", i + 2, Max)
                             If i + 3 <= Max Then DownLoadBus(BusDownLoadList(i + 3))
                             Console.WriteLine("Bus下载第{0}/{1}个", i + 3, Max)
                             Thread.Sleep(2500)
                         Else
                             ' Bus 小图  同时下载4个，时间间隔为 2.5s 
                             If i <= Max Then DownLoadBus(BusDownLoadList(i))
                             Console.WriteLine("Bus下载第{0}/{1}个", i, Max)
                             If i + 1 <= Max Then DownLoadBus(BusDownLoadList(i + 1))
                             Console.WriteLine("Bus下载第{0}/{1}个", i + 1, Max)
                             If i + 2 <= Max Then DownLoadBus(BusDownLoadList(i + 2))
                             Console.WriteLine("Bus下载第{0}/{1}个", i + 2, Max)
                             If i + 3 <= Max Then DownLoadBus(BusDownLoadList(i + 3))
                             Console.WriteLine("Bus下载第{0}/{1}个", i + 3, Max)
                         End If
                         Thread.Sleep(2500)
                     Next
                     BusRunning = False
                 End Sub).ContinueWith(AddressOf IsAllComplete)
    End Sub

    Sub IsAllComplete()
        '只能说明线程结束了，但不能说明Task执行的任务完成
        IsThreadRunning = BusRunning Or FC2Running
    End Sub

    Async Sub DownLoadBus(Panel As Panel)
        Dim ID As Double = GetIDFromPanel(Panel)
        Dim DB = New ShareClass.DataBase("select * from Main where ID=" & ID)
        Dim fanhao = DB.GetInfo("fanhao")
        Dim result As Boolean = False
        If Settings.FormMainShowBigPic Then
            Dim DL As New DownLoader(fanhao, 1, DownLoadProxy)
            Dim vedio = Await DL.GetVedio
            result = Await DL.Download(vedio.Pic_B)

        Else
            Dim DL As New DownLoader(fanhao, 0, DownLoadProxy)
            Dim vedio = Await DL.GetVedio
            result = Await DL.Download(vedio.Pic_S)
        End If


        '下载完成，回调
        If Me.IsHandleCreated Then
            Me.Invoke(New OnFanhaoComplete(Sub()
                                               '设置图片与信息显示
                                               If Panel Is Nothing Then Exit Sub
                                               Dim FlowP As FlowLayoutPanel = Panel.Controls.Item(1)
                                               Dim PicB As PictureBox = Panel.Controls.Item(2)
                                               PicB.Image = GetImage(IIf(Settings.FormMainShowBigPic, BigPicSavePath & "\" & fanhao & ".jpg", SmallPicSavePath & "\" & fanhao & ".jpg"))
                                               DB = New ShareClass.DataBase("select * from Main where ID=" & ID)
                                               Dim VI = DB.GetVedioInfo

                                               FlowP.Height = 10
                                               For Each TB As TextBox In FlowP.Controls
                                                   With TB
                                                       If InStr(.Name, "Mingcheng") > 0 Then
                                                           .Text = VI.mingcheng
                                                           .Height = GetTextBoxHeight(.Text, .Font) * (.GetLineFromCharIndex(.TextLength) + 1)
                                                       ElseIf InStr(.Name, "Riqi") > 0 Then
                                                           .Text = VI.faxingriqi
                                                           .Height = GetTextBoxHeight(.Text, .Font) * (.GetLineFromCharIndex(.TextLength) + 1)
                                                       ElseIf InStr(.Name, "Fanhao") > 0 Then
                                                           .Text = VI.fanhao
                                                           .Height = GetTextBoxHeight(.Text, .Font) * (.GetLineFromCharIndex(.TextLength) + 1)
                                                       End If
                                                   End With
                                                   FlowP.Height += TB.Height
                                               Next
                                               Panel.Height = FlowP.Height + PicB.Height + 20
                                               Application.DoEvents()
                                           End Sub))
        End If
    End Sub

    Sub LoadSetupInfomation()

        '骑兵
        'Dim sr As IO.StreamReader = New IO.StreamReader(Application.StartupPath & "\Data\Qibing.txt")
        'Dim tempqibing = Split(Replace(sr.ReadToEnd, "，", ","), ",")
        'sr.Close()
        'For Each item In tempqibing
        '    If item <> "" Then
        '        Qibing.Add(item)
        '    End If
        'Next

        ''步兵
        'Dim tempbubing = Split(Replace(BubingFanhao, "，", ","), ",")
        'For Each item In tempbubing
        '    If item <> "" Then
        '        Bubing.Add(item)
        '    End If
        'Next

        '视频后缀
        Dim temp = Split(Scan_Shipinleixing, ",")
        ReDim SearchPattern(temp.Count - 1)
        For i = 0 To temp.Count - 1 Step 1
            SearchPattern(i) = "*." & temp(i)
        Next



        Label12.Text = Settings.SortType
        Label13.Text = IIf(Settings.SortDesc, "↓", "↑")

        global_Backcolor = New Color() {Color.FromArgb(57, 61, 64), Color.FromArgb(80, 80, 80)}
        global_Forecolor = New Color() {Color.FromArgb(148, 149, 153), Color.FromArgb(160, 160, 160)}

        EditMode = Chao_CheckBox1.Checked
        Chao_CheckBox2.Checked = Settings.ShowPlay
        '代理
        SetProxy()

    End Sub


    Public Sub SetStatusBar(b As Boolean)
        If b Then
            Chao_Panel1.Height = Me.Height - 64 - (Me.Height - Chao_Panel2.Top) - 5
            Chao_Panel2.Visible = True
        Else
            Chao_Panel1.Height = Me.Height - 64 - 5
            Chao_Panel2.Visible = False
        End If
        Chao_FlowLayoutPanel1.Height = Me.Height - Chao_FlowLayoutPanel1.Top - (Me.Height - Chao_Panel2.Top) * Int(Settings.FixStatusBar) - 10

    End Sub

    Public Sub SetFunctionBar(b As Boolean)
        If b Then
            Chao_FlowLayoutPanel1.Top = 145
        Else
            Chao_FlowLayoutPanel1.Top = 74
        End If
        Chao_FlowLayoutPanel1.Height = Me.Height - Chao_FlowLayoutPanel1.Top - (Me.Height - Chao_Panel2.Top) * Int(Settings.FixStatusBar) - 10

    End Sub


    Sub SetControlSizeAndPosition()
        Chao_FlowLayoutPanel1.Width = Me.Width - Chao_Panel1.Width - 20

        '状态栏
        Chao_Panel3.Visible = Settings.FunctionBar

        SetStatusBar(Settings.FixStatusBar)
        SetFunctionBar(Settings.FunctionBar)
        SetSideBar()

        AddHandler TimerMove.Tick, AddressOf TimerMove_Tick '更多展开动画
        AddHandler SideBarTimer.Tick, AddressOf SideBarTimer_Tick
        '更多按钮 位置
        If Settings.SideBarExpand Then
            Label3.Text = Replace(Label3.Text, "+", "-")
            Label_2.Top = Label3.Top + Label3.Height
            Label_3.Top = Label_2.Top + Label_2.Height
            Label_4.Top = Label_3.Top + Label_3.Height

        Else
            Label3.Text = Replace(Label3.Text, "-", "+")
            Label_2.Top = Label3.Top
            Label_3.Top = Label3.Top
            Label_4.Top = Label3.Top
        End If

        '显示侧边栏的按钮图片位置
        ArrowPicb.Top = (Me.Height - ArrowPicb.Height) / 2



    End Sub

    Sub SetSideBar()
        Chao_Panel1.BringToFront()
        If Settings.FixSideBar Then
            Chao_Panel1.Visible = True
            ArrowPicb.Visible = False
            Chao_Panel3.Left = Chao_Panel1.Width + 10
            Chao_Panel3.Width = Me.Width - 20 - Chao_Panel1.Width
            Chao_FlowLayoutPanel1.Left = Chao_Panel1.Width + 10
            Chao_FlowLayoutPanel1.Width = Me.Width - Chao_Panel1.Width - 20
        Else
            ArrowPicb.Visible = True
            Chao_Panel1.Visible = False
            Chao_Panel3.Width = Me.Width - 20 - 51
            Chao_Panel3.Left = 51
            Chao_FlowLayoutPanel1.Left = 51
            Chao_FlowLayoutPanel1.Width = Me.Width - 51 - 20
        End If
    End Sub


    Sub CheckForDataBase()
        DataBaseSavePath = Application.StartupPath & "\mdb"
        '检查数据库
        If File.Exists(DataBaseSavePath & "\Javbus.mdb") Then
            '重命名
            My.Computer.FileSystem.RenameFile(DataBaseSavePath & "\Javbus.mdb", "MainDatabase.mdb")
        Else
            If Not File.Exists(DataBaseSavePath & "\MainDatabase.mdb") Then
                If Not Directory.Exists(Application.StartupPath & "\mdb") Then
                    Directory.CreateDirectory(Application.StartupPath & "\mdb")
                End If
                DataBaseSavePath = Application.StartupPath & "\mdb"
                '创建一个mdb文件
                If Not File.Exists(DataBaseSavePath & "\MainDatabase.mdb") Then

                    CreateAccessMdb()
                    CreateAccessTable("Main")


                End If
            End If
        End If

        '是否存在PicUrl表
        If Not New ShareClass.DataBase("").IsTableExist("PicUrl") Then CreateAccessTable("PicUrl", True)

        '检查图片存放位置
        If Not IO.Directory.Exists(Application.StartupPath & "\Pic") Then
            Directory.CreateDirectory(Application.StartupPath & "\Pic")
        End If

        BigPicSavePath = Application.StartupPath & "\Pic\BigPic\"
        SmallPicSavePath = Application.StartupPath & "\Pic\SmallPic\"
        ExtraPicSavePath = Application.StartupPath & "\Pic\Extra\"
        ActressesPicSavePath = Application.StartupPath & "\Pic\Actresses\"

        If Not IO.Directory.Exists(BigPicSavePath) Then
            Directory.CreateDirectory(BigPicSavePath)
        End If

        If Not IO.Directory.Exists(SmallPicSavePath) Then
            Directory.CreateDirectory(SmallPicSavePath)
        End If

        If Not IO.Directory.Exists(ExtraPicSavePath) Then
            Directory.CreateDirectory(ExtraPicSavePath)
        End If

        If Not IO.Directory.Exists(ActressesPicSavePath) Then
            Directory.CreateDirectory(ActressesPicSavePath)
        End If

        con_ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DataBaseSavePath & "\MainDatabase.mdb"
        con_ConnectionString_read = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DataBaseSavePath & "\MainDatabase.mdb;Mode=Read"

    End Sub

    Private Sub CheckForFile()
        If Not IO.File.Exists(Application.StartupPath & "\Data\Qibing.txt") Then MsgBox("缺失数据文件",, "提示") : Me.Close()
        If Not File.Exists(Application.StartupPath & "\Data\DBFCIndex.txt") Then File.Create(Application.StartupPath & "\Data\DBFCIndex.txt")
        If Not File.Exists(Application.StartupPath & "\Data\BusIndex.txt") Then File.Create(Application.StartupPath & "\Data\BusIndex.txt")

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' 下载FC2速度过慢

        ' 影片分集导入
        ' 片子太多了， 速度卡
        ' 图片过大问题
        ' FC2index
        ' 排序sql 语句问题
        ' 数据库优化问题 ??

        ' ChaoForm Resize 事件

        ' UI
        '  左侧颜色连接

        ' * ChaoForm 左上角调整大小、启动后MinimumSize
        ' * NFO
        ' * 导入单个视频
        '* 随机显示
        '* 优化文件下载
        '* FC2
        '* 优化FormBus
        '* 优化FormInfo
        '* javbus.mdb
        '* 详情页添加左右按钮
        '* vob视频格式
        '* 大图被覆盖在下面， 无法看
        '* 额外图片滚动浏览
        '* 类别系列旁边加上数目
        '* 自定义标签


        CheckForFile()
        LoadSetupInfomation() '载入软件设置
        CheckForDataBase() '检测数据库
        CheckForPic() '删除无用图片
        SetControlSizeAndPosition() '设置控件位置和大小
        SetSkin()


    End Sub

    Private DelPicList As New List(Of String)
    Public Sub CheckForPic()
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

    Private Sub FormMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        If Settings.Opacity / 100 <= 0.5 Then Me.Opacity = 1 Else Me.Opacity = Settings.Opacity / 100

        '启动后随即展示
        If Settings.RandomLoad Then
            Label12.Enabled = False
            Label13.Enabled = False
            PictureBox5.Enabled = False
            Chao_Button1.Enabled = False
            Chao_Button3.Enabled = False
            Chao_TextBox1.Enabled = False
            Label1.Enabled = False

            Chao_FlowLayoutPanel1.Controls.Clear()
            Dim ShowList = GetRandomList()
            If ShowList IsNot Nothing Then
                RefreshCMS.Enabled = False
                Dim ShowIDList = New ShareClass.DataBase("select * from Main").GetIDList(ShowList)
                Dim SowBP As Boolean = Settings.FormMainShowBigPic
                For Each item In ShowIDList
                    Dim VI = New ShareClass.DataBase("select * from Main where ID=" & item).GetVedioInfo()

                    If Not InfoIDList.Contains(VI.ID) Then InfoIDList.Add(VI.ID)
                    '只有名称为空、图片不存在才会下载
                    Dim InfoPanel As New InfoPanel(VI, LoveCMS)
                    Chao_FlowLayoutPanel1.Controls.Add(InfoPanel.Panel)
                    Dim PicPath As String = IIf(SowBP, BigPicSavePath & "\" & VI.fanhao & ".jpg", SmallPicSavePath & "\" & VI.fanhao & ".jpg")
                    If (VI.mingcheng = "" Or Not IO.File.Exists(PicPath)) Then
                        If Not DownLoadList.Contains(InfoPanel.Panel) Then DownLoadList.Add(InfoPanel.Panel)
                    End If
                    Application.DoEvents()
                Next
            End If
        End If

    End Sub

    Sub ShowScanPanel()
        If Chao_FlowLayoutPanel1.Controls.Count = 0 Then
            With Panel2
                .Left = (Me.Width - .Width) / 2
                .Top = (Me.Height - .Height) / 2
                .Visible = True
                .BringToFront()
            End With
        Else
            Panel2.Visible = False
        End If
    End Sub


    Private Sub Chao_FlowLayoutPanel1_Click(sender As Object, e As EventArgs)
        Chao_FlowLayoutPanel1.Focus()
        If Not Settings.FixSideBar Then Chao_Panel1.Visible = False
    End Sub


    Private Sub 打开照片位置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开照片位置ToolStripMenuItem.Click
        '判断文件夹是否存在

        Dim Path As String = ""
        Dim PicP As String = ""
        If Settings.FormMainShowBigPic Then
            PicP = BigPicSavePath
        Else
            PicP = SmallPicSavePath
        End If
        Dim ErrorStr As String = ""
        Dim Result As New List(Of String)

        For Each item In EditList
            Dim Fanhao As String = New ShareClass.DataBase("select * from Main where ID=" & item).GetInfo("fanhao")
            Path = PicP & Fanhao & ".jpg"
            If IO.File.Exists(Path) Then
                Result.Add(Path)
            Else
                ErrorStr = ErrorStr & Path & vbCrLf
            End If
        Next

        If ErrorStr <> "" Then MsgBox(ErrorStr & "【不存在】",, "不存在")

        For Each item In Result
            OpenFilePath(item)
        Next




    End Sub

    Private Sub 打开影片位置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开影片位置ToolStripMenuItem.Click

        Dim Path As String = ""
        Dim ErrorStr As String = ""
        Dim Result As New List(Of String)
        For Each item In EditList
            Dim Fanhao As String = New ShareClass.DataBase("select * from Main where ID=" & item).GetInfo("fanhao")
            Path = New ShareClass.DataBase("select * from Main where ID=" & item).GetInfo("weizhi")
            If IO.File.Exists(Path) Then
                Result.Add(Path)
            Else
                ErrorStr = ErrorStr & Path & vbCrLf
            End If
        Next

        If ErrorStr <> "" Then MsgBox(ErrorStr & "【不存在】",, "不存在")

        For Each item In Result
            OpenFilePath(item)

        Next

    End Sub

    Private Sub 打开其网址ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开其网址ToolStripMenuItem.Click
        Try
            For Each item In EditList
                Dim Fanhao As String = New ShareClass.DataBase("select * from Main where ID=" & item).GetInfo("fanhao")
                Try
                    Process.Start(Settings.BusWebSite & "/" & Fanhao)
                Catch ex As Exception
                    Continue For
                End Try

            Next
        Catch ex As Win32Exception
            MsgBox("网址有问题",, "网址有问题")
        End Try
    End Sub


    Private Sub 删除该番号ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除该番号ToolStripMenuItem.Click
        If EditMode Then
            If EditList.Count = 0 Then MsgBox("请单机左键后在执行",, "提示") : Exit Sub
        End If
        If MsgBox("确认删除这些番号？（不删除文件） ？", vbYesNo) = vbYes Then
            Dim DeleteClass = New ShareClass.DataBase("")
            For Each item In EditList
                DeleteClass.UpdateCommand("delete from Main where ID=" & item)
            Next
            DeleteClass.Dispose()

            DeleteFromPanel(EditList)
            EditList.Clear()
        End If
    End Sub


    '从FP中删除指定的Panel
    Private Sub DeleteFromPanel(ID As List(Of Double))
        For Each item In Chao_FlowLayoutPanel1.Controls
            Dim Panel As Panel = item
            For Each item1 In Panel.Controls
                If item1.GetType.ToString = "System.Windows.Forms.FlowLayoutPanel" Then
                    If ID.Contains(Split(item1.name, ";")(1)) Then
                        Panel.Visible = False
                    End If
                End If
            Next

        Next
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing


        If Not Settings.CloseRightNow Then
            If Me.Visible Then
                For index = Application.OpenForms.Count - 1 To 0 Step -1
                    If Application.OpenForms(index).Name <> "FormMain" Then
                        Application.OpenForms(index).Close()
                    End If
                Next
                e.Cancel = -1
                Me.Hide()
                NotifyIcon1.Visible = True
            Else
                NotifyIcon1.Visible = False
            End If
        Else '直接退出
            '结束
            CheckForPic()
            NotifyIcon1.Visible = False
            If DownloadForm IsNot Nothing Then DownloadForm.NotifyIcon1.Visible = False
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        Me.Close()
    End Sub

    Private Sub 打开主窗体ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开主窗体ToolStripMenuItem.Click
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub


    Public Sub RefreshFlowlayoutPanel()
        'ReadingDataBase = True
        If Chao_FlowLayoutPanel1.Controls.Count = 0 Then Exit Sub
        Dim Page As Integer = IIf(Chao_TextBox1.Text <> "", Int(Chao_TextBox1.Text), 1)
        SelectFromDatabase(mysql, Page)
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click, ToolStripMenuItem5.Click, ToolStripMenuItem4.Click, ToolStripMenuItem3.Click, ToolStripMenuItem2.Click, ToolStripMenuItem1.Click
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
            'WriteLog(ex)
        Finally
            If con IsNot Nothing Then con.Close()
        End Try
        LovePicBTemp.Image = Nothing
        LovePicBTemp.Refresh()
        LovePicBTemp.name = index & Strings.Mid(LovePicBTemp.name, 2)
        If index > 0 Then
            LovePicBTemp.Image = My.Resources.Resource_Image._Like
        Else
            LovePicBTemp.Image = My.Resources.Resource_Image.UnLike
        End If
    End Sub


    Private Sub 复制ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复制ToolStripMenuItem.Click

        Dim Path As String = ""
        Dim FileList = New Specialized.StringCollection
        Dim ErrorStr As String = ""

        For Each item In EditList
            Path = New ShareClass.DataBase("select * from Main where ID=" & item).GetInfo("weizhi")
            If IO.File.Exists(Path) Then
                FileList.Add(Path)
            Else
                ErrorStr = ErrorStr & Path & vbCrLf
            End If
        Next

        If ErrorStr <> "" Then MsgBox(ErrorStr & "【复制不成功】")

        If FileList.Count > 0 Then
            My.Computer.Clipboard.SetFileDropList(FileList)
        End If

    End Sub


    Private Sub 删除该文件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除该文件ToolStripMenuItem.Click
        If MsgBox("删除文件到回收站？", vbYesNo, "删除文件") = vbYes Then
            Dim Path As String = ""
            Dim FileList = New Specialized.StringCollection
            Dim ErrorStr As String = ""

            For Each item In EditList
                Path = New ShareClass.DataBase("select * from Main where ID=" & item).GetInfo("weizhi")
                If IO.File.Exists(Path) Then
                    FileList.Add(Path)
                Else
                    ErrorStr = ErrorStr & Path & vbCrLf
                End If
            Next

            If ErrorStr <> "" Then MsgBox(ErrorStr & "【文件不存在】")

            If FileList.Count > 0 Then

                For Each item In FileList
                    '删除文件file的方法1:删除到回收站里面。
                    My.Computer.FileSystem.DeleteFile(item, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                    '删除文件file的方法2:直接从硬盘上删除。
                    'IO.File.Delete(fpath)



                Next

            End If
            DeleteFromPanel(EditList)  '删除该panel
            Dim DeleteClass = New ShareClass.DataBase("")
            For Each item In EditList
                DeleteClass.UpdateCommand("delete from Main where ID=" & item)
            Next
            DeleteClass.Dispose()

            EditList.Clear()
        End If

    End Sub


    Private Sub LabelMouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove, Label4.MouseMove, Label3.MouseMove, Label11.MouseMove, Label_5.MouseMove, Label_4.MouseMove, Label_3.MouseMove, Label_2.MouseMove, Label_1.MouseMove, Label_0.MouseMove
        If Strings.Right(sender.name, 1) <> Clickindex Then
            sender.BackColor = GetRelativeColor(Chao_Panel1.BackColor, 20)
        End If

    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave, Label4.MouseLeave, Label3.MouseLeave, Label11.MouseLeave, Label_5.MouseLeave, Label_4.MouseLeave, Label_3.MouseLeave, Label_2.MouseLeave, Label_1.MouseLeave, Label_0.MouseLeave
        If Strings.Right(sender.name, 1) <> Clickindex Then
            sender.BackColor = Chao_Panel1.BackColor
        End If

    End Sub

    Private Sub DrawClickIndex(index As Integer)
        Dim BC As Color = Me.BackColor
        For Each item In Chao_Panel1.Controls
            If item.GetType.ToString = "System.Windows.Forms.Label" Then
                item.backcolor = Chao_Panel1.BackColor
            End If
        Next

        Select Case index
            Case 0
                Label_0.BackColor = BC
            Case 1
                Label_1.BackColor = BC
            Case 2
                Label_2.BackColor = BC
            Case 3
                Label_3.BackColor = BC
            Case 4
                Label_4.BackColor = BC
            Case 5
                Label_5.BackColor = BC
        End Select


    End Sub

    '所有视频
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label_0.Click
        mysql = getPaixuSql("", "Main")   '获得排序类型
        SelectFromDatabase(mysql, 1)
        Label2.Text = sender.text
        Clickindex = 0
        DrawClickIndex(Clickindex)

    End Sub

    '我的喜爱
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label_1.Click
        mysql = getPaixuSql("where love>0", "Main")
        SelectFromDatabase(mysql, 1)
        Clickindex = 1
        Label2.Text = sender.text
        DrawClickIndex(Clickindex)
    End Sub

    '骑兵
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label_2.Click
        mysql = getPaixuSql("where shipinleixing=2", "Main")
        SelectFromDatabase(mysql, 1)
        Clickindex = 2
        Label2.Text = sender.text
        DrawClickIndex(Clickindex)
    End Sub

    '步兵
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label_3.Click
        mysql = getPaixuSql("where shipinleixing=1", "Main")
        SelectFromDatabase(mysql, 1)
        Clickindex = 3
        Label2.Text = sender.text
        DrawClickIndex(Clickindex)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label_4.Click
        mysql = getPaixuSql("where shipinleixing=3", "Main")
        SelectFromDatabase(mysql, 1)
        Clickindex = 4
        Label2.Text = sender.text
        DrawClickIndex(Clickindex)
    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label_5.Click
        mysql = getPaixuSql("where shipinleixing=0", "Main")
        SelectFromDatabase(mysql, 1)
        Clickindex = 5
        Label2.Text = sender.text
        DrawClickIndex(Clickindex)
    End Sub



    'PopUp the SortMenu
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click, Label13.Click, Label12.Click
        Dim x As Single = Me.Left + Chao_Panel3.Left + Label12.Left
        Dim y As Single = Me.Top + Chao_Panel3.Top + Chao_Panel3.Height
        Sort_CMS.Show(New Point(x, y))
    End Sub


    Private Sub EditInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditInfoToolStripMenuItem.Click
        FormEdit.Close()

        If Not EditMode Then
            FormEdit.ShowDialog()
        Else
            Chao_Button2_Click(sender, e)
        End If

    End Sub


    Private Sub 刷新ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 刷新ToolStripMenuItem1.Click
        ShowScanPanel()
        RefreshFlowlayoutPanel()

    End Sub

    Private Sub SortMenuItem_Click(sender As Object, e As EventArgs) Handles 访问次数ToolStripMenuItem2.Click, 番号ToolStripMenuItem.Click, 文件大小ToolStripMenuItem1.Click, 导入时间ToolStripMenuItem1.Click, 喜爱程度ToolStripMenuItem1.Click, 名称ToolStripMenuItem.Click, 发行日期ToolStripMenuItem2.Click
        If Chao_FlowLayoutPanel1.Controls.Count = 0 Then Exit Sub
        Label12.Text = sender.text

        Settings.SortDesc = Not Settings.SortDesc
        Settings.Save()

        Label13.Text = IIf(Settings.SortDesc, "↓", "↑")
        Settings.SortType = Label12.Text
        Chao_FlowLayoutPanel1.Focus()



        mysql = mysql.Replace(" desc", "")
        Dim replacestr As String
        replacestr = Mid(mysql, InStr(mysql, "by") + 3)
        Select Case Label12.Text
            Case "识别码"
                mysql = mysql.Replace(replacestr, "fanhao")
            Case "影片名称"
                mysql = mysql.Replace(replacestr, "mingcheng")
            Case "访问次数"
                mysql = mysql.Replace(replacestr, "fangwencishu")
            Case "文件大小"
                mysql = mysql.Replace(replacestr, "wenjiandaxiao")
            Case "发行日期"
                mysql = mysql.Replace(replacestr, "faxingriqi")
            Case "导入时间"
                mysql = mysql.Replace(replacestr, "daorushijian")
            Case "喜爱程度"
                mysql = mysql.Replace(replacestr, "love")
        End Select
        If Settings.SortDesc Then
            mysql = mysql & " desc"
        End If
        SelectFromDatabase(mysql, Chao_TextBox1.Text)


    End Sub



    Private Sub 设置ToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub


    Private Sub Chao_TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Chao_TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Page = sender.Text
            If Not IsNumeric(Page) Then
                Page = 1
            Else
                If Page <= 0 Then
                    Page = 1
                ElseIf Page > Math.Ceiling(TotalNum / Settings.LayoutNumber) Then
                    Page = 1
                End If
            End If
            SelectFromDatabase(mysql, Page)
        End If
    End Sub

    Private Sub Chao_Button1_Click(sender As Object, e As EventArgs) Handles Chao_Button1.Click
        Dim Page = Chao_TextBox1.Text
        If Not IsNumeric(Page) Then
            'MsgBox("页数错误")
            Exit Sub
        Else
            If Page > Math.Ceiling(TotalNum / Settings.LayoutNumber) Then
                'MsgBox("页数错误")
                Exit Sub
            ElseIf Page <= 1 Then
                Page = Math.Ceiling(TotalNum / Settings.LayoutNumber)
            Else
                Page += -1
            End If
        End If
        SelectFromDatabase(mysql, Page)
        Chao_TextBox1.Text = Page
    End Sub

    Private Sub Chao_Button3_Click(sender As Object, e As EventArgs) Handles Chao_Button3.Click
        Dim Page = Chao_TextBox1.Text
        If Not IsNumeric(Page) Then
            Debug.Print("页数错误")
            Exit Sub
        Else
            If Page <= 0 Then
                Debug.Print("页数错误")
                Exit Sub
            ElseIf Page >= Math.Ceiling(TotalNum / Settings.LayoutNumber) Then
                Page = 1
            Else
                Page += 1
            End If
        End If
        SelectFromDatabase(mysql, Page)
        Chao_TextBox1.Text = Page
    End Sub

    'Search
    Private Sub Chao_SearchBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Chao_SearchBox1.KeyDown
        Dim SearchText As String = sender.text
        If e.KeyCode = Keys.Enter Then
            If SearchText <> "" Then
                Try
                    Clickindex = 20
                    mySearch = Jencode(SearchText)
                    mysql = getPaixuSql("where fanhao like '%" & mySearch & "%' or mingcheng like '%" & mySearch & "%' ", "Main")
                    SelectFromDatabase(mysql, 1)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                mysql = getPaixuSql("", "Main")   '获得排序类型
                SelectFromDatabase(mysql, 1)
                LabelStatus.Text = sender.text
            End If

        End If
    End Sub



    'EditMode
    Private Sub Chao_CheckBox1_CheckedChanged(sender As Object, e As PropertyChangedEventArgs) Handles Chao_CheckBox1.CheckedChanged
        EditMode = sender.checked
        EditList.Clear()
        If EditMode Then
            'EditInfoToolStripMenuItem.Enabled = False

            For Each item In Chao_Panel3.Controls
                If InStr(item.GetType.ToString, "Check") <= 0 And InStr(item.name, "Chao_Button2") <= 0 Then
                    item.enabled = False
                End If
            Next

            For Each item In Chao_FlowLayoutPanel1.Controls
                Dim p As Panel = item
                p.CreateGraphics.Clear(p.BackColor)
                For Each it In p.Controls
                    If it.GetType.ToString = "System.Windows.Forms.TextBox" Then
                        it.enabled = False
                    End If
                Next
            Next
        Else

            For Each item In Chao_Panel3.Controls
                item.enabled = True
            Next

            'EditInfoToolStripMenuItem.Enabled = True
            For Each item In Chao_FlowLayoutPanel1.Controls
                Dim p As Panel = item
                p.CreateGraphics.Clear(p.BackColor)
                For Each it In p.Controls
                    If it.GetType.ToString = "System.Windows.Forms.TextBox" Then
                        it.enabled = True
                    End If
                Next
            Next
        End If

    End Sub


    Private Sub Chao_Button2_Click(sender As Object, e As EventArgs) Handles Chao_Button2.Click
        If EditMode And EditList.Count > 0 Then
            FormQuickEdit.ShowDialog()
        End If

    End Sub



    Private Sub FormMain_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        System.Environment.Exit(0)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Settings.SideBarExpand Then
            Label3.Text = Replace(Label3.Text, "-", "+")
        Else
            Label3.Text = Replace(Label3.Text, "+", "-")
        End If
        TimerMove.Enabled = True
    End Sub

    Sub SideBarTimer_Tick()
        If Not Settings.FixSideBar Then Chao_Panel1.Visible = False
        SideBarTimer.Stop()
    End Sub

    Sub TimerMove_Tick()
        If Settings.SideBarExpand Then
            '收起
            Label_2.Top -= 4
            Label_3.Top -= 8
            Label_4.Top -= 12

            If Label_2.Top <= Label3.Top Then Label_2.Top = Label3.Top
            If Label_3.Top <= Label3.Top Then Label_3.Top = Label3.Top
            If Label_4.Top <= Label3.Top Then Label_4.Top = Label3.Top
            If Label_2.Top <= Label3.Top And Label_3.Top <= Label3.Top And Label_4.Top <= Label3.Top Then
                TimerMove.Enabled = False
                Settings.SideBarExpand = False
                Settings.Save()
            End If


        Else
            '展开
            Label_2.Top += 4
            Label_3.Top += 8
            Label_4.Top += 12

            If Label_2.Top >= Label3.Top + 1 * Label3.Height Then Label_2.Top = Label3.Top + 1 * Label3.Height
            If Label_3.Top >= Label3.Top + 2 * Label3.Height Then Label_3.Top = Label3.Top + 2 * Label3.Height
            If Label_4.Top >= Label3.Top + 3 * Label3.Height Then Label_4.Top = Label3.Top + 3 * Label3.Height
            If Label_2.Top >= Label3.Top + 1 * Label3.Height And
                Label_3.Top >= Label3.Top + 2 * Label3.Height And
                Label_4.Top >= Label3.Top + 3 * Label3.Height Then

                TimerMove.Enabled = False
                Settings.SideBarExpand = True
                Settings.Save()
            End If
        End If

    End Sub

    Private Sub 关于本软件ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        About.Show()
    End Sub

    Sub LinkLabel_Click(sender As Object, e As EventArgs)
        sender.linkvisited = True
        Try
            Process.Start("iexplore.exe", "http://www.hitchao.cn/Jvedio")
        Catch ex As Exception
            MsgBox("打开失败，杀毒软件阻止",, "提示")
        End Try

    End Sub

    Sub LinkLabel2_Click(sender As Object, e As EventArgs)
        sender.linkvisited = True
        Try
            Process.Start("iexplore.exe", "https://github.com/hitchao/Jvedio")
        Catch ex As Exception
            MsgBox("打开失败，杀毒软件阻止",, "提示")
        End Try

    End Sub

    Public Sub 赞助ToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        FormLeibie.Show()
        FormLeibie.BringToFront()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        FormYanyuan.Show()
        FormYanyuan.BringToFront()
    End Sub



    Private Sub 检查更新ToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub



    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        With FormBiaoqian
            .Top = Me.Top + Label11.Top + 64 - 420
            .Left = Me.Left + 110
            .Show()
            .BringToFront()

        End With

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Chao_Panel1.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.Clear(Me.BackColor)
        Dim BC As Color = sender.backcolor
        e.Graphics.FillPath(New SolidBrush(BC), GetRoundRectangle(sender.clientrectangle, 20))
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles DownLoadingTimer.Tick
        If DownLoadThread IsNot Nothing Then
            If IsThreadRunning Then
                Chao_StatusIndicator1.Status = "Running"
            Else
                Chao_StatusIndicator1.Status = "Success"
            End If

        End If



    End Sub



    Private Sub FlowLayoutPanel1_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            RefreshCMS.Show(MousePosition)
        End If
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, Label14.Click
        Chao_Button4_Click(sender, e)
    End Sub

    Private Sub FlowLayoutPanel1_KeyDown(sender As Object, e As KeyEventArgs)
        If EditMode And Chao_FlowLayoutPanel1.Controls.Count > 0 Then
            If e.Control AndAlso e.KeyCode = Keys.A Then
                For Each item As Panel In Chao_FlowLayoutPanel1.Controls
                    Dim ID = GetIDFromPanel(item)
                    'console.WriteLine(fanhao)
                    If EditList.Contains(ID) Then
                        EditList.Remove(ID)
                    Else
                        EditList.Add(ID)
                    End If
                    item.Invalidate()
                Next
            End If
        End If

    End Sub

    Private Sub ArrowPicb_Click(sender As Object, e As EventArgs) Handles ArrowPicb.Click
        Chao_Panel1.Visible = True
        Chao_Panel1.Focus()
    End Sub

    Private Sub Panel1_LostFocus(sender As Object, e As EventArgs) Handles Chao_Panel1.LostFocus

    End Sub

    Dim LastWindowState As FormWindowState = FormWindowState.Minimized
    Private Sub FormMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ArrowPicb.Top = (Me.Height - ArrowPicb.Height) / 2
        Me.Invalidate()

        If Panel2.Visible Then
            Panel2.Left = (Me.Width - Panel2.Width) / 2 + Chao_Panel1.Width
            Panel2.Top = (Me.Height - Panel2.Height) / 2 + Chao_Panel3.Top + Chao_Panel3.Height

        End If

        If Me.WindowState <> LastWindowState Then
            LastWindowState = WindowState

            If WindowState = FormWindowState.Maximized Then
                Chao_FlowLayoutPanel1.AnimationChanged()
                ' Maximized!
            End If

            If WindowState = FormWindowState.Normal Then
                Chao_FlowLayoutPanel1.AnimationChanged()
                ' Restored!
            End If
        End If

    End Sub

    Private Sub FormMain_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        '消除周围白线
        e.Graphics.Clear(Me.BackColor)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(34, 37, 42), 2), 0, 0, Me.Width, 0)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), Me.Width, 0, Me.Width, Me.Height)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(34, 37, 42), 2), Me.Width, Me.Height, 0, Me.Height)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(50, 54, 57), 2), 0, Me.Height, 0, 0)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Chao_Panel3.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.Clear(sender.backcolor)
        Dim SkinColor As New ShareClass.Skin(Settings.SkinStyle)

        Dim BC As Color = GetRelativeColor(SkinColor.BC1, 10)
        e.Graphics.FillPath(New SolidBrush(BC), GetRoundRectangle(sender.clientrectangle))
    End Sub

    Private Sub StatusPanel_Paint(sender As Object, e As PaintEventArgs) Handles Chao_Panel2.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.Clear(Me.BackColor)
        Dim BC As Color = sender.backcolor
        e.Graphics.FillPath(New SolidBrush(BC), GetRoundRectangle(sender.clientrectangle))
    End Sub

    Private Sub Chao_Panel1_Resize(sender As Object, e As EventArgs) Handles Chao_Panel1.Resize
        sender.invalidate
    End Sub

    Private Sub Chao_Panel2_Resize(sender As Object, e As EventArgs) Handles Chao_Panel2.Resize
        sender.invalidate
    End Sub

    Private Sub Chao_Panel3_Resize(sender As Object, e As EventArgs) Handles Chao_Panel3.Resize
        sender.invalidate
    End Sub

    Private Sub Chao_FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DownLoadList.Clear()
        DownLoadThreadCancel = True
        DownLoadThread.Join()
    End Sub




    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs)
        Dim picb As PictureBox = sender
        picb.CreateGraphics.FillRectangle(Brushes.Red, picb.ClientRectangle)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs)
        Dim picb As PictureBox = sender
        picb.Invalidate()
    End Sub

    Private Sub Chao_FlowLayoutPanel1_MouseMove(sender As Object, e As MouseEventArgs)
        Panel_PicboxMouseEnter = False


        If IsClosingFromInfo Then
            StartThread()
            IsClosingFromInfo = False
        End If
    End Sub

    Private Sub Chao_FlowLayoutPanel1_GotFocus(sender As Object, e As EventArgs)

    End Sub

    Private ImportForm As Import.FormScan
    Private DatabaseForm As database.FormMain
    Private DownloadForm As ChaoDownloader.FormMain
    Private Sub Chao_Button4_Click(sender As Object, e As EventArgs) Handles Chao_Button4.Click
        If ImportForm IsNot Nothing Then
            If ImportForm.IsDisposed Then ImportForm = New Import.FormScan
        Else
            ImportForm = New Import.FormScan
        End If
        ImportForm.Show()
        ImportForm.BringToFront()
    End Sub

    Private Sub Chao_Button9_Click(sender As Object, e As EventArgs) Handles Chao_Button9.Click
        If DatabaseForm IsNot Nothing Then
            If DatabaseForm.IsDisposed Then DatabaseForm = New database.FormMain
        Else
            DatabaseForm = New database.FormMain
        End If


        DatabaseForm.Show()
        DatabaseForm.BringToFront()

    End Sub

    Private Sub Chao_Button5_Click(sender As Object, e As EventArgs) Handles Chao_Button5.Click
        If DownloadForm IsNot Nothing Then
            If DownloadForm.IsDisposed Then DownloadForm = New ChaoDownloader.FormMain
        Else
            DownloadForm = New ChaoDownloader.FormMain
        End If

        DownloadForm.Show()
        DownloadForm.BringToFront()
    End Sub

    Private Sub Setup_CMS_Opening(sender As Object, e As CancelEventArgs)

    End Sub

    Private Sub Chao_Button10_Click(sender As Object, e As EventArgs) Handles Chao_Button10.Click
        FormSetup.Show()
        FormSetup.BringToFront()
    End Sub

    Private Sub Chao_Button6_Click(sender As Object, e As EventArgs) Handles Chao_Button6.Click
        About.Show()
    End Sub


    Private Sub Chao_Button7_Click(sender As Object, e As EventArgs) Handles Chao_Button7.Click
        FormUpdate.ShowDialog()
    End Sub

    Private Sub FormMain_BindingContextChanged(sender As Object, e As EventArgs) Handles MyBase.BindingContextChanged

    End Sub

    Private Sub NotifyIcon1_MouseDown(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDown
        If e.Button = MouseButtons.Right Then
            MIN_CMS.Show(MousePosition)
        End If
    End Sub

    Private Sub SkinPicB_Click(sender As Object, e As EventArgs) Handles SkinPicB.Click
        If Settings.SkinStyle = "White" Then
            Settings.SkinStyle = "Black"
        ElseIf Settings.SkinStyle = "Black" Then
            Settings.SkinStyle = "Blue"
        ElseIf Settings.SkinStyle = "Blue" Then
            Settings.SkinStyle = "White"
        End If
        Settings.Save()
        SetSkin()
        FormBus.SetSkin()
        FormLeibie.SetSkin()
        FormYanyuan.SetSkin()

    End Sub
    Sub SetSkin()
        '设置皮肤
        Dim SkinColor As New ShareClass.Skin(Settings.SkinStyle)
        Me.BackColor = SkinColor.BC2
        TitlePanel.BackColor = SkinColor.BC1
        FormTextLabel.ForeColor = SkinColor.FC2


        For Each item In Chao_FlowLayoutPanel2.Controls
            If item.GetType.ToString = "ChaoControls.Chao_Button" Then
                Dim btn As ChaoControls.Chao_Button = item
                btn.ButtonBackColor = SkinColor.BC1
                btn.ButtonColor = SkinColor.BC1
                btn.TextColor = SkinColor.FC2
            End If
        Next



        For Each Panel As Panel In Chao_FlowLayoutPanel1.Controls
            Panel.BackColor = GetRelativeColor(SkinColor.BC1, 15)
            For Each item In Panel.Controls
                If item.GetType.ToString = "System.Windows.Forms.FlowLayoutPanel" Then
                    For Each TB As TextBox In item.controls
                        TB.BackColor = GetRelativeColor(SkinColor.BC1, 15)
                        TB.ForeColor = SkinColor.FC2
                    Next
                End If
            Next


        Next

        For Each item In Chao_Panel3.Controls
            If item.GetType.ToString = "System.Windows.Forms.Label" Then
                Dim label As Label = item
                label.BackColor = GetRelativeColor(SkinColor.BC1, 10)
                label.ForeColor = SkinColor.FC2
            ElseIf item.GetType.ToString = "System.Windows.Forms.PictureBox" Then
                Dim Picb As PictureBox = item
                Picb.BackColor = GetRelativeColor(SkinColor.BC1, 10)
                Picb.ForeColor = SkinColor.FC2
            End If
        Next

        Chao_TextBox1.TextBackColor = GetRelativeColor(SkinColor.BC1, 10)
        Chao_CheckBox1.BackColor = GetRelativeColor(SkinColor.BC1, 10)
        Chao_CheckBox1.CheckTextColor = SkinColor.FC2

        Chao_CheckBox2.BackColor = GetRelativeColor(SkinColor.BC1, 10)
        Chao_CheckBox2.CheckTextColor = SkinColor.FC2

        Chao_Button2.ButtonBackColor = GetRelativeColor(SkinColor.BC1, 10)
        Chao_Button2.ButtonColor = GetRelativeColor(SkinColor.BC1, 10)
        Chao_Button2.TextColor = SkinColor.FC2

        Chao_Panel1.BackColor = GetRelativeColor(SkinColor.BC1, 20)

        With Chao_SearchBox1
            .BackColor = GetRelativeColor(SkinColor.BC1, 20)
            .SearchBoxColor = GetRelativeColor(SkinColor.BC1, 30)
            .SearchBoxMouseMoveColor = SkinColor.FC1
            .SearchIconColor = SkinColor.FC1
            .SearchTextForeColor = SkinColor.FC2
        End With

        For Each item In Chao_Panel1.Controls
            If item.GetType.ToString = "System.Windows.Forms.Label" Then
                Dim label As Label = item
                label.BackColor = GetRelativeColor(SkinColor.BC1, 20)
                label.ForeColor = SkinColor.FC2
            End If
        Next

        Chao_Panel2.BackColor = GetRelativeColor(SkinColor.BC1, 10)


        DrawClickIndex(Clickindex)



    End Sub

    Private Sub Chao_CheckBox2_CheckedChanged(sender As Object, e As PropertyChangedEventArgs) Handles Chao_CheckBox2.CheckedChanged
        Settings.ShowPlay = Chao_CheckBox2.Checked
        Console.WriteLine(Settings.ShowPlay)
        Settings.Save()
    End Sub


    Private Sub FormMain_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Chao_FlowLayoutPanel1.AnimationChanged()
    End Sub

    Private Sub Chao_SearchBox1_Click(sender As Object, e As EventArgs) Handles Chao_SearchBox1.Click
        'Dim content As New ToolStripMenuItem With {.Text = "删除所有历史纪录"}
        'Search_CMS.Items.Add(content)


        'Dim x, y As Single
        'x = Chao_SearchBox1.Left
        'y = Chao_SearchBox1.Top + Chao_SearchBox1.Height + 5
        'Search_CMS.Show(x, y)
        'Console.WriteLine("Show")


    End Sub
End Class







