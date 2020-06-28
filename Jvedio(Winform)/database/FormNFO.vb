Imports System.ComponentModel
Imports System.IO
Imports System.Data.OleDb
Imports ShareClass.ChaoSub
Imports ShareClass.Identify
Public Class FormNFO


    Private NFOList As New List(Of VedioInfo)

    Public ImportListViewItemCollection As IEnumerable(Of ListViewItem)
    Public FoundFilePathList As New List(Of String)

    Public mySearchPattern As String() = New String() {"*.nfo"}
    Public SearchPath As String = ""
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
        Chao_StatusIndicator1.Status = "Success"
    End Sub

    Private Sub CompleteSearch(ByVal str As String)
        Label2.Text = str
        Chao_StatusIndicator1.Status = "Success"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath

        End If
    End Sub

    Function CheckForScan() As Boolean
        If ScanThread IsNot Nothing Then
            If ScanThread.IsAlive = True Then
                MsgBox("正在扫描！",, "提示")
                Return False
            End If
        End If
        If ImportThread IsNot Nothing Then
            If ImportThread.IsAlive = True Then
                MsgBox("数据库正在导入！请等待",, "提示")
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub Chao_Button1_Click(sender As Object, e As EventArgs) Handles Chao_Button1.Click
        SearchPath = TextBox1.Text
        If Not IO.Directory.Exists(SearchPath) Then MsgBox("文件夹不存在！",, "文件夹不存在") ： Exit Sub

        '判断是否在扫描和导入
        If Not CheckForScan() Then Exit Sub
        Chao_StatusIndicator1.Status = "Running"
        FoundFilePathList.Clear()
        '启动扫描
        ScanThread = New System.Threading.Thread(AddressOf SearchFile)
        ScanThread.Start()
    End Sub

    Private Sub SearchFile()

        '递归算法
        Try
            GetAllFile(SearchPath)
        Catch ex As Exception
            WriteLog(ex)
        End Try

        '回调
        Me.BeginInvoke(New ScanCallBackDelegate(AddressOf CompleteSearch), "扫描出" & FoundFilePathList.Count & "个NFO文件")

    End Sub


    Private Function IsDirectoryScanable(dir As String) As Boolean
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

    Private Sub GetAllFile(path As String)
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

    Private Sub FormNFO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chao_StatusIndicator1.Status = "StandBy"
        Chao_CheckBox1.Checked = Settings.NfoCover
    End Sub

    Private Sub FormNFO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '退出前结束线程
        If ScanThread IsNot Nothing Then
            ScanThread.Abort()
            ScanThread.Join()
        End If

        If ImportThread IsNot Nothing Then
            ImportThread.Abort()
            ImportThread.Join()
        End If

        Settings.NfoCover = Chao_CheckBox1.Checked
        Settings.Save()
    End Sub

    Private Sub Chao_Button2_Click(sender As Object, e As EventArgs) Handles Chao_Button2.Click

        Settings.NfoCover = Chao_CheckBox1.Checked
        Settings.Save()

        '-----判断能否导入-------------------------------------
        If Not CheckForScan() Then Exit Sub
        If FoundFilePathList.Count = 0 Then MsgBox("没有NFO可以导入",, "提示") : Exit Sub

        Chao_StatusIndicator1.Status = "Running"


        ImportThread = New System.Threading.Thread(AddressOf ImportIntoDatabase)
        ImportThread.Start()
    End Sub

    Private Function ReadNfo() As List(Of VedioInfo)
        Dim result As New List(Of VedioInfo)
        For Each item In FoundFilePathList
            Using SR As StreamReader = New StreamReader(item)
                Dim content As String = SR.ReadToEnd
                result.Add(GetInfoFromNFO(content, item))
            End Using
        Next
        Return result
    End Function

    Private Function GetInfoFromNFO(content As String, path As String) As VedioInfo
        Dim VI As New VedioInfo
        Dim XR As New XMLReader(content)
        VI.weizhi = path
        VI.mingcheng = XR.SelectSingle("movie", "title")
        VI.daoyan = XR.SelectSingle("movie", "director")
        VI.faxingriqi = IIf(XR.SelectSingle("movie", "release") <> "", XR.SelectSingle("movie", "release"), XR.SelectSingle("movie", "releasedate"))
        VI.faxingshang = XR.SelectSingle("movie", "studio")
        VI.fanhao = IIf(XR.SelectSingle("movie", "id") <> "", XR.SelectSingle("movie", "id"), XR.SelectSingle("movie", "imdbid"))
        VI.leibie = XR.SelectNodes("movie", "genre")
        VI.yanyuan = XR.SelectNodes("movie", "actor/name")
        If XR.SelectSingle("movie", "runtime") = "" Then
            VI.changdu = 0
        Else
            If IsNumeric(XR.SelectSingle("movie", "runtime")) Then
                VI.changdu = Int(XR.SelectSingle("movie", "runtime"))
            Else
                VI.changdu = 0
            End If
        End If

        Return VI
    End Function

    Private Sub ImportIntoDatabase()

        NFOList = ReadNfo()
        If NFOList.Count <= 0 Then Exit Sub

        Dim WrongList As New List(Of String)
        Dim ExistList As New List(Of String)
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim myDataAdapter As New OleDbDataAdapter
        Dim sql As String
        Try
            con.ConnectionString = con_ConnectionString
            con.Open()
            cmd.Connection = con '初始化OLEDB命令的连接属性为con
            For Each item In NFOList
                If item.fanhao = "" Then
                    '错误信息，无法写入
                    WrongList.Add(item.weizhi)
                Else
                    '判断是否存在番号
                    Dim fanhao As String = New ShareClass.DataBase("select * from Main where ID=" & item.fanhao).GetInfo("fanhao")
                    If fanhao = "" Then
                        '导入数据库
                        sql = "insert into Main (fanhao,shipinleixing,daorushijian,love,mingcheng,daoyan,faxingriqi,faxingshang,leibie,yanyuan,changdu,fangwencishu) values('" & item.fanhao & "'," &
                        GetVedioType(item.fanhao) & ",'" & Now.ToString("yyyyMMddHHmmss") & "'," & 0 & ",'" & FormatDataBaseInfo(item.mingcheng) &
                        "','" & FormatDataBaseInfo(item.daoyan) & "','" & item.faxingriqi & "','" & FormatDataBaseInfo(item.faxingshang) & "','" &
                        FormatDataBaseInfo(item.leibie) & "','" & FormatDataBaseInfo(item.yanyuan) & "'," & FormatDataBaseInfo(item.changdu, 1) & ",0)"
                        cmd.CommandText = sql
                        myDataAdapter.UpdateCommand = cmd
                        cmd.ExecuteNonQuery()
                    Else
                        If Settings.NfoCover Then
                            '覆盖更新
                            sql = "update Main set mingcheng = '" & FormatDataBaseInfo(item.mingcheng) &
                "', changdu = " & FormatDataBaseInfo(item.changdu, 1) & ", faxingshang = '" & FormatDataBaseInfo(item.faxingshang) & "', daoyan = '" &
                FormatDataBaseInfo(item.daoyan) & "', leibie = '" & FormatDataBaseInfo(item.leibie) & "', yanyuan = '" & FormatDataBaseInfo(item.yanyuan) &
                "',faxingriqi='" & FormatDataBaseInfo(item.faxingriqi) & "'" & " where fanhao = '" & item.fanhao & "'"
                            cmd.CommandText = sql
                            myDataAdapter.UpdateCommand = cmd
                            cmd.ExecuteNonQuery()
                        Else
                            ExistList.Add(item.weizhi)
                        End If
                    End If
                End If
            Next
            con.Close()
        Catch ex As Exception

        Finally
            con.Close()

        End Try
        WriteNfoListToLog(WrongList, ExistList)
        '回调
        Me.BeginInvoke(New ImportCallBackDelegate(AddressOf CompleteImport), "总计导入 " & NFOList.Count - WrongList.Count - ExistList.Count &
                       " 个，其中有 " & WrongList.Count & " 个导入失败，有" & ExistList.Count & "个数据库已存在 | 详见 NFO.Log 文件")

    End Sub

    Sub WriteNfoListToLog(L1 As List(Of String), L2 As List(Of String))
        Try
            Using FS As FileStream = New FileStream(Application.StartupPath & "\Log\NFO.Log", FileMode.Append, FileAccess.Write)
                'FS.Lock(0, FS.Length)
                Dim SW = New StreamWriter(FS)
                SW.WriteLine("---------------------------------------------------------------------------------")
                SW.WriteLine("扫描日期：" & Format(DateTime.Now, "yyyy/MM/dd hh:mm:ss"))
                SW.WriteLine("---------------------------导入失败-------------------------------------")
                For Each item In L1
                    SW.WriteLine(item)
                Next
                SW.WriteLine("---------------------------------------------------------------------------------")
                SW.WriteLine("----------------------------已存在------------------------------------------")
                For Each item In L2
                    SW.WriteLine(item)
                Next
                SW.WriteLine("---------------------------------------------------------------------------------")
                'FS.Unlock(0, FS.Length)
                SW.Flush()
            End Using
        Catch ex As Exception
            WriteLog(ex)
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MsgBox("NFO规则具体详见" & vbCrLf & Application.StartupPath & "\Sample.nfo",, "提示")
    End Sub
End Class