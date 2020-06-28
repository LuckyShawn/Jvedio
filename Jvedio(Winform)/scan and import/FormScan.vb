Imports System.Data.OleDb
Imports System.ComponentModel
Imports System.IO
Imports ShareClass.Access
Imports ShareClass.Identify
Imports ShareClass.ChaoFile




Public Class FormScan

    Public ImportListViewItemCollection As IEnumerable(Of ListViewItem)
    Public SearchPathList As New List(Of String)
    Public FoundFilePathList As New List(Of String)
    Public ListViewItemCollection As New List(Of ListViewItem)

    Public ScanThread As System.Threading.Thread
    Delegate Sub ScanCallBackDelegate(ByVal str As String)
    Delegate Sub SetLabelTextDelegate(ByVal str As String)

    Public ImportThread As System.Threading.Thread
    Delegate Sub ImportCallBackDelegate(ByVal str As String)

    Sub SetLabelText(ByVal str As String)
        Label2.Text = str
    End Sub

    Private Sub CompleteImport(ByVal str As String)
        Label2.Text = str
        Chao_ProgressIndicators1.Visible = False
        ListView3.Items.Clear()
    End Sub

    Private Sub CompleteSearch(ByVal str As String)
        Label2.Text = str
        Dim lvt As ListViewItem
        ListView3.BeginUpdate()   '数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速
        For Each item In ListViewItemCollection
            lvt = New ListViewItem({item.SubItems(0).Text, item.SubItems(1).Text, FormatFileSize(item.SubItems(2).Text), item.SubItems(3).Text}) With
                {.ImageIndex = 1}
            ListView3.Items.Add(lvt)
        Next
        ListView3.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView3.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize)
        ListView3.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView3.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView3.EndUpdate()
        Chao_ProgressIndicators1.Visible = False

    End Sub


    Private Sub SearchFile()
        '递归算法
        Try
            For Each SearchPath In SearchPathList
                GetAllFile(SearchPath)
            Next
        Catch ex As Exception
            ShareClass.ChaoSub.WriteLog(ex)
        End Try

        '将扫描到的路径提取番号并显示
        Dim myListViewItem As ListViewItem
        Dim FileSize As String
        Dim mySearchPath As String()

        For Each FilePath In FoundFilePathList
            mySearchPath = Split(FilePath, "\")
            'FileSize = FormatFileSize(CType(My.Computer.FileSystem.GetFileInfo(FilePath).Length, Double))
            FileSize = (CType(My.Computer.FileSystem.GetFileInfo(FilePath).Length, Double))
            myListViewItem = New ListViewItem({getFanhao(mySearchPath(UBound(mySearchPath))),
                                              GetVedioType(getFanhao(mySearchPath(UBound(mySearchPath)))),
                                              FileSize, FilePath}) With {.ImageIndex = 1}
            ListViewItemCollection.Add(myListViewItem)
        Next

        '回调
        Me.BeginInvoke(New ScanCallBackDelegate(AddressOf CompleteSearch), "扫描出" & ListViewItemCollection.Count & "个")

    End Sub

    Function CheckForScan() As Boolean
        If ListView1.Items.Count = 0 Then Return False
        If ScanThread IsNot Nothing Then
            If ScanThread.IsAlive = True Then
                MsgBox("请等待本次扫描停止或取消扫描！",, "提示")
                Return False
            End If
        End If
        If ImportThread IsNot Nothing Then
            If ImportThread.IsAlive = True Then
                MsgBox("数据库正在导入！请等待",, "提示")
                Return False
            End If
        End If

        If ListViewItemCollection.Count > 0 Then
            If MsgBox("扫描将清空上次结果，是否继续？", vbYesNo, "提示") = vbNo Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub Chao_Button1_Click(sender As Object, e As EventArgs) Handles Chao_Button1.Click
        '扫描文件夹

        '判断是否在扫描和导入
        If Not CheckForScan() Then Exit Sub

        '初始化
        Chao_ProgressIndicators1.Visible = True

        ListView3.Items.Clear()
        ListView2.Items.Clear()
        ListView4.Items.Clear()

        '将要扫描的文件夹添加到List里
        SearchPathList.Clear()
        For Each item In ListView1.Items
            SearchPathList.Add(item.text)
        Next
        '扫描结果List清空
        FoundFilePathList.Clear()
        ListViewItemCollection.Clear()
        '启动扫描
        ScanThread = New System.Threading.Thread(AddressOf SearchFile)
        ScanThread.Start()


    End Sub

    Private Sub MyScanForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        For Each item In Me.Controls
            item.visible = True
        Next
        Chao_ProgressIndicators1.Visible = False
    End Sub

    Private Sub MyScanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '判断文件是否存在

        If Not IO.File.Exists(Application.StartupPath & "\Data\Qibing.txt") Or Not IO.File.Exists(Application.StartupPath & "\Data\Qibing_extra.txt") Then
            MsgBox("缺失Qibing.txt、Qibing_extra.txt",, "提示")
            Me.Close()
        End If


        '载入软件设置，固定为软件启动目录
        DataBaseSavePath = Application.StartupPath & "\mdb"

        CheckForDataBase() '检查数据库是否存在

        '定义全局数据库连接字符串
        con_ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DataBaseSavePath & "\MainDatabase.mdb"


        '设置搜索时过滤的视频类型
        Dim temp As String() = Split(Scan_Shipinleixing, ",")
        ReDim mySearchPattern(temp.Count - 1)
        For i = 0 To temp.Count - 1
            mySearchPattern(i) = "*." & temp(i)
        Next

        '读入骑兵番号
        Dim tempqibing As String()
        Using sr As StreamReader = New StreamReader(Application.StartupPath & "\Data\Qibing.txt")
            tempqibing = Split(Replace(sr.ReadToEnd, "，", ","), ",")
        End Using
        For Each item In tempqibing
            If item <> "" Then
                Qibing.Add(item)
                'Console.WriteLine(item)
            End If
        Next

        If Settings.EnableExtra Then
            Using sr As StreamReader = New StreamReader(Application.StartupPath & "\Data\Qibing_extra.txt")
                tempqibing = Split(Replace(sr.ReadToEnd, "，", ","), ",")
            End Using
            For Each item In tempqibing
                If item <> "" Then
                    Qibing_extra.Add(item)
                End If
            Next
        End If

        '读入步兵番号
        Dim tempbubing As String() = Split(Replace(BubingFanhao, "，", ","), ",")
        For Each item In tempbubing
            If item <> "" Then
                Bubing.Add(item)
                'Console.WriteLine(item)
            End If
        Next

        '设置距离
        With TabControl1
            .Left = 0
            .Top = Chao_TabSelectorBar1.Top + Chao_TabSelectorBar1.Height - 30
            .Width = Me.Width
            .Height = Me.Height - 60 - Label2.Height - Chao_TabSelectorBar1.Height + 30
        End With

        '错误界面的布局
        ListView4.Height = (Me.Height - 64 - Chao_TabSelectorBar1.Height - 15 - Chao_Button3.Height - Label2.Height - 20) / 2
        Label6.Height = ListView4.Height
        ListView2.Top = ListView4.Top + ListView4.Height + 5
        ListView2.Height = ListView4.Height
        Label7.Top = ListView2.Top
        Label7.Height = ListView2.Height


        '三个选项的地址
        ListView1.SmallImageList = ImageList1
        Label2.Text = "欢迎使用扫描导入工具"

        '设置不可见后才能画边框
        For Each item In Me.Controls
            item.visible = False
        Next

        '设置ListView显示
        For i = 0 To 3
            ListView2.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize)
            ListView3.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize)
            ListView4.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize)
        Next

    End Sub


    Sub CheckForDataBase()
        Try
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
            con_ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DataBaseSavePath & "\MainDatabase.mdb"
        Catch ex As Exception
            ShareClass.ChaoSub.WriteLog(ex)
        End Try
    End Sub










    Private Sub MyScanForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '退出前结束线程
        If ScanThread IsNot Nothing Then
            ScanThread.Abort()
            ScanThread.Join()
        End If

        If ImportThread IsNot Nothing Then
            ImportThread.Abort()
            ImportThread.Join()
        End If

    End Sub

    Private Sub ListView1_DragDrop(sender As Object, e As DragEventArgs) Handles ListView1.DragDrop
        '将文件夹拖动到列表里
        For Each s As String In e.Data.GetData(DataFormats.FileDrop) '循环枚举数据
            If System.IO.Directory.Exists(s) = True Then
                ListView1.Items.Add(s) '添加到表
                ListView1.Items.Item(ListView1.Items.Count - 1).ImageIndex = 0
            End If
        Next
    End Sub

    Private Sub 删除ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除ToolStripMenuItem.Click
        For i = ListView3.SelectedIndices.Count - 1 To 0 Step -1
            'Debug.Print(ListView3.SelectedItems.Item(i).SubItems(0).Text)
            ListViewItemCollection.RemoveAt(ListView3.SelectedItems.Item(i).Index)
            ListView3.Items.RemoveAt(ListView3.SelectedItems.Item(i).Index)
        Next
    End Sub


    Private Sub ListView1_DragEnter(sender As Object, e As DragEventArgs) Handles ListView1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub




    Private Sub 打开文件夹ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开文件夹ToolStripMenuItem.Click
        Dim path As String
        For i = ListView3.SelectedIndices.Count - 1 To 0 Step -1
            path = ListView3.Items(i).SubItems(3).Text
            If IO.File.Exists(path) Then
                Try
                    ' Console.WriteLine(path)
                    Process.Start("Explorer.exe", GetFilePath(path))
                Catch ex As Exception
                    MsgBox("权限不够",, "权限不够")
                End Try
            Else
                MsgBox(path & "不存在",, "不存在")
            End If
        Next
    End Sub

    Public Sub GetAllFile(path As String)
        Me.BeginInvoke(New SetLabelTextDelegate(AddressOf SetLabelText), path)
        If IsDirectoryScanable(path) Then
            Dim myfi As DirectoryInfo = New DirectoryInfo(path)
            Dim myIReadOnlyCollection As IReadOnlyCollection(Of String) = My.Computer.FileSystem.GetFiles(path, FileIO.SearchOption.SearchTopLevelOnly, mySearchPattern)
            For Each foundfile As String In myIReadOnlyCollection
                FoundFilePathList.Add(foundfile)
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

    Private Sub PictureBox2_Click_2(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MsgBox("扫描采用【递归扫描】" & vbCrLf & "如果你添加了
类似于【C:\】或者【D:\】，则扫描速度会很慢 
推荐添加的文件夹类似于：【D:\电影】",, "提示")
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

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If MsgBox("是否确定清空？", vbYesNo, "提示") = vbYes Then
            ListView1.Clear()
        End If
    End Sub


    Private Sub PictureBox7_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseMove
        sender.Image = My.Resources.Picture.清空删除2
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        For i As Integer = ListView1.SelectedIndices.Count - 1 To 0 Step -1
            ListView1.Items.RemoveAt(ListView1.SelectedIndices(i))
        Next
    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave
        sender.Image = My.Resources.Picture.清空删除1
    End Sub

    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox8.MouseLeave
        sender.Image = My.Resources.Picture.删除1
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click, PictureBox3.Click, Label1.Click
        If FolderBrowserDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            '判断文件夹是否有交集
            Dim IsBelongToSomeDir As Boolean = False
            Dim IsContainSomeDir As Boolean = False
            For Each item In ListView1.Items
                If InStr(FolderBrowserDialog1.SelectedPath, item.text) > 0 Then
                    IsBelongToSomeDir = True
                End If
            Next
            For Each item In ListView1.Items
                If InStr(item.text, FolderBrowserDialog1.SelectedPath) > 0 Then
                    IsContainSomeDir = True
                End If
            Next
            If IsBelongToSomeDir Or IsContainSomeDir Then
                MsgBox("冲突：文件夹有交集！",, "提示")
            Else
                ListView1.Items.Add(FolderBrowserDialog1.SelectedPath)
                For Each item As ListViewItem In ListView1.Items
                    item.ImageIndex = 0
                Next
            End If
        End If
    End Sub

    Private Sub PictureBox8_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseMove
        sender.Image = My.Resources.Picture.删除2
    End Sub

    Private Sub PictureBox9_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseMove
        sender.Image = My.Resources.Picture.文件夹2
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If MsgBox("取消扫描将清除当前扫描结果，是否继续？", vbYesNo, "取消扫描") = vbYes Then
            If ScanThread IsNot Nothing Then
                ScanThread.Abort()
                ScanThread.Join()
                Chao_ProgressIndicators1.Visible = False
                Label2.Text = "扫描已终止！"
            End If
            ListView3.Items.Clear()
        End If
    End Sub


    Private Sub PictureBox9_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox9.MouseLeave
        sender.Image = My.Resources.Picture.文件夹1
    End Sub


    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs)
        If sender.text = "" Then
            sender.text = "查找"
        End If
    End Sub





    Private Function CheckForImport() As Boolean
        If ScanThread IsNot Nothing Then
            If ScanThread.IsAlive = True Then
                MsgBox("请等待本次扫描停止或取消扫描！",, "提示")
                Return False
            End If
        End If
        If ImportThread IsNot Nothing Then
            If ImportThread.IsAlive = True Then
                MsgBox("数据库正在导入！请等待",, "提示")
                Return False
            End If
        End If

        If ListView3.Items.Count = 0 Then
            MsgBox("请先扫描~",, "提示")
            Return False
        End If

        If Qibing.Count = 0 Then
            MsgBox("番号数据不存在，请设置后重试！",, "提示")
            Return False
        End If

        Return True
    End Function


    Function GetChongfuFanhaoFormDataBase(ByVal mylist As IEnumerable(Of ListViewItem)) As IEnumerable(Of ListViewItem)
        Dim fanhao As New List(Of ListViewItem)
        For Each s In mylist
            fanhao.Add(s)
            ' Debug.Print(s.SubItems(0).Text)
        Next
        Dim result As New List(Of ListViewItem)
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader = Nothing
        Dim myDataAdapter As New OleDbDataAdapter
        Dim sql As String
        Try
            con.ConnectionString = con_ConnectionString
            con.Open()
            cmd.Connection = con
            sql = "select * from Main "
            cmd.CommandText = sql
            dr = cmd.ExecuteReader() '执行OLEDB命令以ExecuteReader()方式，并返回一个OLEDBReader，赋值给dr
            While (dr.Read)
                result.Add(New ListViewItem({dr.Item("fanhao").ToString, Int(dr.Item("shipinleixing")), CType(dr.Item("wenjiandaxiao").ToString, Double), dr.Item("weizhi").ToString}))
            End While
        Catch ex As Exception
            ShareClass.ChaoSub.WriteLog(ex)
            Return Nothing
        Finally
            If dr IsNot Nothing Then dr.Close()
            If con IsNot Nothing Then con.Close()
        End Try

        Return result.Intersect(fanhao, New ShareClass.ListViewItemComparer)
    End Function


    Private Async Sub Chao_Button2_Click(sender As Object, e As EventArgs) Handles Chao_Button2.Click

        '-----判断能否导入-------------------------------------
        If Not CheckForImport() Then Exit Sub
        Chao_ProgressIndicators1.Visible = True

        '-----删除空翻号-------------------------------------
        For i = ListViewItemCollection.Count - 1 To 0 Step -1
            If ListViewItemCollection.Item(i).SubItems(0).Text = "" Then
                ListView4.Items.Add(ListViewItemCollection.Item(i))  '空番号
                ListViewItemCollection.RemoveAt(i)
                ListView3.Items.RemoveAt(i)
            End If
        Next

        ListView4.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize)
        ListView4.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize)
        ListView4.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize)
        ListView4.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent)

        '删除重复项，原则：文件较大的优先保留
        '------------------------------------------------------
        '方法一：重写接口ICompare（未写）
        'Dim newList = ListViewItemCollection.Distinct(New ListViewItemComparer).ToList
        '------------------------------------------------------
        '方法二：Group
        Dim newList = From r In ListViewItemCollection
                      Group r By r.SubItems(0).Text Into g = Group Select g.OrderByDescending(Function(x) x.SubItems(2).Text).First()
        '------------------------------------------------------


        '重复番号加入错误统计中
        ListView2.Items.Clear()
        Dim ChongFuListViewItem = ListViewItemCollection.Except(newList)
        Dim lvt As ListViewItem
        For Each s In ChongFuListViewItem
            'Debug.Print("重复项的路径为" & s.SubItems(3).Text)
            lvt = New ListViewItem({s.SubItems(0).Text, s.SubItems(1).Text, FormatFileSize(s.SubItems(2).Text), s.SubItems(3).Text})
            ListView2.Items.Add(lvt)
        Next

        ListView2.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView2.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize)
        ListView2.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView2.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent)


        Label2.Text = "检测数据库重复"
        '检测数据库重复-------------------------------------

        ChongFuFanhaoList = GetChongfuFanhaoFormDataBase(newList)

        ImportListViewItemCollection = newList
        Dim myDialogResult As DialogResult = DialogResult.No
        If ChongFuFanhaoList IsNot Nothing Then
            If ChongFuFanhaoList.Count > 0 Then
                myDialogResult = FormImportInfo.ShowDialog()
                If myDialogResult = DialogResult.Yes Then
                    '对于重复番号，无论如何，更新位置和大小
                    ImportListViewItemCollection = newList.Except(ChongFuFanhaoList, New ShareClass.ListViewItemComparer)

                    Await Task.Run(Sub()
                                       Dim sql As String
                                       Dim path As String
                                       Dim FileSize As Long
                                       Dim NowTime As String
                                       Dim mylove As Integer = 0
                                       Dim splx As Integer = 0
                                       Dim fanhao As String = ""
                                       Dim con As New OleDbConnection
                                       Dim cmd As New OleDbCommand
                                       Dim myDataAdapter As New OleDbDataAdapter
                                       Try
                                           con.ConnectionString = con_ConnectionString
                                           con.Open()
                                           cmd.Connection = con '初始化OLEDB命令的连接属性为con

                                           For Each item In ChongFuFanhaoList
                                               '插入

                                               fanhao = item.SubItems(0).Text
                                               splx = Int(item.SubItems(1).Text)
                                               FileSize = item.SubItems(2).Text
                                               path = Replace(item.SubItems(3).Text, "'", "’")
                                               NowTime = Now.ToString("yyyyMMddHHmmss")
                                               sql = "update Main set weizhi='" & path & "',wenjiandaxiao=" & FileSize & ",shipinleixing=" & splx & ",daorushijian='" & NowTime & "' where fanhao='" & fanhao & "'"
                                               cmd.CommandText = sql
                                               myDataAdapter.UpdateCommand = cmd
                                               cmd.ExecuteNonQuery()

                                               Application.DoEvents()
                                           Next
                                           con.Close()
                                       Catch ex As Exception
                                       Finally
                                           If con IsNot Nothing Then con.Close()
                                       End Try

                                       '回调
                                       Me.BeginInvoke(New ImportCallBackDelegate(AddressOf CompleteImport), "总计更新" & ChongFuFanhaoList.Count & "个")

                                   End Sub)


                ElseIf myDialogResult = DialogResult.No Then
                    '不导入
                    ImportListViewItemCollection = newList.Except(ChongFuFanhaoList, New ShareClass.ListViewItemComparer)
                    For Each item In ChongFuFanhaoList
                        ListView2.Items.Add(item)
                    Next
                    ListView2.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent)
                    ListView2.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize)
                    ListView2.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent)
                    ListView2.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent)
                Else
                    '返回修改
                    Chao_ProgressIndicators1.Visible = False
                    Exit Sub
                End If
            End If
        End If

        If ImportListViewItemCollection.Count = 0 And Not myDialogResult = DialogResult.Yes Then
            ListView3.Items.Clear()
            Chao_ProgressIndicators1.Visible = False
            Label2.Text = "无视频导入"
            Exit Sub
        End If

        If ListView4.Items.Count = 0 Then
            For i = 0 To 3
                ListView4.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize)
            Next
        End If

        If ListView2.Items.Count = 0 Then
            For i = 0 To 3
                ListView2.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize)
            Next
        End If


        '启动导入线程
        If ImportListViewItemCollection.Count > 0 Then
            ImportThread = New System.Threading.Thread(AddressOf ImportIntoDatabase)
            ImportThread.Start()
        End If


    End Sub

    Private Sub ImportIntoDatabase()
        '导入数据库

        Dim sql As String
        Dim path As String
        Dim FileSize As Long
        Dim NowTime As String
        Dim mylove As Integer = 0
        Dim splx As Integer = 0
        Dim fanhao As String = ""
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim myDataAdapter As New OleDbDataAdapter
        Try
            con.ConnectionString = con_ConnectionString
            con.Open()
            cmd.Connection = con '初始化OLEDB命令的连接属性为con

            For Each item In ImportListViewItemCollection
                '插入
                fanhao = item.SubItems(0).Text
                splx = Int(item.SubItems(1).Text)
                FileSize = item.SubItems(2).Text
                path = Replace(item.SubItems(3).Text, "'", "’")
                NowTime = Now.ToString("yyyyMMddHHmmss")
                sql = "insert into Main (fanhao,weizhi,wenjiandaxiao,shipinleixing,daorushijian,love,fangwencishu) values('" & fanhao & "','" & path & "','" & FileSize & "','" & splx & "','" & NowTime & "','" & mylove & "',0)"
                cmd.CommandText = sql
                myDataAdapter.UpdateCommand = cmd
                cmd.ExecuteNonQuery()

                '更新
            Next
            con.Close()
        Catch ex As Exception
        Finally
            If con IsNot Nothing Then con.Close()
        End Try

        '回调
        Me.BeginInvoke(New ImportCallBackDelegate(AddressOf CompleteImport), "总计导入" & ImportListViewItemCollection.Count & "个")

    End Sub


    Private Sub Chao_TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Chao_TextBox1.KeyDown
        'Debug.Print(e.KeyCode)
        If e.KeyCode = Keys.Enter Then
            For i = 0 To ListView3.Items.Count - 1
                ListView3.Items(i).Selected = False
            Next
            For i = 0 To ListView3.Items.Count - 1
                If InStr(ListView3.Items.Item(i).Text, sender.Text, CompareMethod.Text) > 0 Then
                    'Debug.Print(ListView3.Items.Item(i).Text)
                    ListView3.Items(i).Selected = True
                    ListView3.Items(i).EnsureVisible() '滚动到此
                    ListView3.Focus()
                End If
            Next
        End If
    End Sub


    Private Sub Chao_Button3_Click(sender As Object, e As EventArgs) Handles Chao_Button3.Click
        '生成报告
        If ListView4.Items.Count = 0 And ListView2.Items.Count = 0 Then
            Exit Sub
        End If
        Dim myLogPath As String = Application.StartupPath & "\ScanLog"
        Dim txtPath As String = myLogPath & "\" & Format(DateTime.Now, "yyyy年MM月dd日 HH：mm：ss") & ".txt"

        If Not IO.File.Exists(myLogPath) Then

            My.Computer.FileSystem.CreateDirectory(myLogPath)
        End If
        Dim sw As System.IO.StreamWriter = Nothing
        If Not System.IO.File.Exists(txtPath) Then
            sw = System.IO.File.CreateText(txtPath)
        End If
        Try
            sw.Write("扫描日期：" & Format(DateTime.Now, "yyyy/MM/dd hh:mm:ss"))
            sw.WriteLine()
            sw.Write("--------------------------------")
            sw.WriteLine()
            sw.Write("未识别的视频：")
            sw.WriteLine()
            sw.Write("--------------------------------")
            sw.WriteLine()
            For i = 0 To ListView4.Items.Count - 1
                sw.Write(ListView4.Items.Item(i).SubItems(3).Text)
                sw.WriteLine()
            Next
            sw.Write("--------------------------------")
            sw.WriteLine()
            sw.Write("重复的视频：")
            sw.WriteLine()
            sw.Write("--------------------------------")
            sw.WriteLine()
            For i = 0 To ListView2.Items.Count - 1
                sw.Write(ListView2.Items.Item(i).SubItems(3).Text)
                sw.WriteLine()
            Next
            sw.Write("--------------------------------")
        Catch ex As Exception
            ShareClass.ChaoSub.WriteLog(ex)
        Finally
            If sw IsNot Nothing Then sw.Close()
        End Try
        If sw IsNot Nothing Then sw.Close()

        Label2.Text = "成功生成报告"
        If System.IO.File.Exists(txtPath) = True Then
            If IO.File.Exists(txtPath) Then
                Try
                    ' Console.WriteLine(path)
                    Process.Start("Explorer.exe", GetFilePath(txtPath))
                Catch ex As Exception
                    MsgBox("打开" & txtPath & "权限不够",, "权限不够")
                End Try
            Else
                MsgBox(txtPath & "不存在",, "不存在")
            End If
        End If
    End Sub



    Private Sub ListView3_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView3.KeyDown
        '全选
        If e.Control AndAlso e.KeyCode = Keys.A Then
            For i = 0 To ListView3.Items.Count - 1
                ListView3.Items(i).Selected = True
            Next
        End If
    End Sub


    Private Sub 其它ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 其它ToolStripMenuItem.Click, 步兵ToolStripMenuItem.Click, 骑兵ToolStripMenuItem.Click
        Dim splx As Integer = 0
        Select Case sender.text
            Case "0-其它"
                splx = 0
            Case "1-步兵"
                splx = 1
            Case "2-骑兵"
                splx = 2
        End Select
        For i = 0 To ListView3.SelectedIndices.Count - 1 Step 1
            ListView3.Items.Item(ListView3.SelectedItems.Item(i).Index).SubItems(1).Text = splx
            ListViewItemCollection.Item(ListView3.SelectedItems.Item(i).Index).SubItems(1).Text = splx
        Next
    End Sub

    Private Sub ListView3_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView2.ColumnClick, ListView3.ColumnClick, ListView4.ColumnClick
        '点击标签排序
        Dim columnsort As New ShareClass.ColumnSort(e.Column) With {.bAscending = (sender.Sorting = SortOrder.Ascending)}
        If columnsort.bAscending Then
            sender.Sorting = SortOrder.Descending
        Else
            sender.Sorting = SortOrder.Ascending
        End If
        sender.ListViewItemSorter = columnsort
        sender.ListViewItemSorter = Nothing
    End Sub

    Private Sub ListView3_AfterLabelEdit(sender As Object, e As LabelEditEventArgs) Handles ListView3.AfterLabelEdit
        '保存用户标签
        ListViewItemCollection.Item(ListView3.SelectedItems(0).Index).SubItems(0).Text = e.Label
    End Sub

    Private Sub 刷新ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 刷新ToolStripMenuItem.Click
        ListView3.Items.Clear()
        Dim lvt As ListViewItem
        ListView3.BeginUpdate()   '数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速
        For Each item In ListViewItemCollection
            lvt = New ListViewItem({item.SubItems(0).Text, item.SubItems(1).Text, FormatFileSize(item.SubItems(2).Text), item.SubItems(3).Text}) With
            {.ImageIndex = 1}
            ListView3.Items.Add(lvt)
        Next
        If ListView3.Items.Count > 0 Then
            ListView3.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent)
            ListView3.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize)
            ListView3.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent)
            ListView3.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent)
        Else
            For i = 0 To 3
                ListView3.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize)
            Next
        End If
        ListView3.EndUpdate()
    End Sub

    Private Sub FormScan_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        '对半分
        ListView4.Height = (Me.Height - 64 - Chao_TabSelectorBar1.Height - 15 - Chao_Button3.Height - Label2.Height - 20) / 2
        Label6.Height = ListView4.Height
        ListView2.Top = ListView4.Top + ListView4.Height + 5
        ListView2.Height = ListView4.Height
        Label7.Top = ListView2.Top
        Label7.Height = ListView2.Height

        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = ListView1.Top + (ListView1.Height - Panel1.Height) / 2
    End Sub

    Private Sub SetPicB_Click(sender As Object, e As EventArgs) Handles SetPicB.Click
        FormSetup.ShowDialog()
    End Sub

    Private Sub 打开文件夹ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 打开文件夹ToolStripMenuItem1.Click

        Dim Path As String = OpenPath
        If IO.File.Exists(Path) Then
            Try
                'Console.WriteLine(Path)
                Process.Start("Explorer.exe", GetFilePath(Path))
            Catch ex As Exception
                MsgBox("权限不够",, "权限不够")
            End Try

        Else
            MsgBox(Path & "不存在",, "不存在")
        End If

    End Sub

    Private Sub ListView4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView4.SelectedIndexChanged
        If ListView4.SelectedItems.Count > 0 Then
            OpenPath = ListView4.Items.Item(ListView4.SelectedIndices(0)).SubItems(3).Text
        End If
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count > 0 Then
            OpenPath = ListView2.Items.Item(ListView2.SelectedIndices(0)).SubItems(3).Text
        End If
    End Sub

    Private Sub Chao_ProgressIndicators1_Load(sender As Object, e As EventArgs) Handles Chao_ProgressIndicators1.Load

    End Sub
End Class

