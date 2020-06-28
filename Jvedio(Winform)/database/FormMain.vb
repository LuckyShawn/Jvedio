Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports ShareClass.Access
Imports ShareClass.ChaoSub
Imports System.Drawing.Drawing2D
Public Class FormMain


    Private Sub MyDatabaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        If Not IO.File.Exists(Application.StartupPath & "\Data\Qibing.txt") Or Not IO.File.Exists(Application.StartupPath & "\Data\Qibing_extra.txt") Then
            MsgBox("缺失Qibing.txt、Qibing_extra.txt",, "提示")
            Me.Close()
        End If

        CheckForDataBase() '检测数据库

        '读入骑兵番号
        Dim tempqibing As String()
        Using sr As StreamReader = New StreamReader(Application.StartupPath & "\Data\Qibing.txt")
            tempqibing = Split(Replace(sr.ReadToEnd, "，", ","), ",")
        End Using
        For Each item In tempqibing
            If item <> "" Then
                Qibing.Add(item)
            End If
        Next

        Using sr As StreamReader = New StreamReader(Application.StartupPath & "\Data\Qibing_extra.txt")
            tempqibing = Split(Replace(sr.ReadToEnd, "，", ","), ",")
        End Using
        For Each item In tempqibing
            If item <> "" Then
                Qibing_extra.Add(item)
            End If
        Next


        '读入步兵番号
        Dim tempbubing As String() = Split(Replace(BubingFanhao, "，", ","), ",")
        For Each item In tempbubing
            If item <> "" Then
                Bubing.Add(item)
            End If
        Next
    End Sub

    Sub CheckForDataBase()
        DataBaseSavePath = Application.StartupPath & "\mdb"
        '检查数据库
        If IO.File.Exists(DataBaseSavePath & "\Javbus.mdb") Then
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
        con_ConnectionString_read = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DataBaseSavePath & "\MainDatabase.mdb;Mode=Read"

    End Sub


    Private Sub LoadDataBase()
        Label7.Text = "加载中……"
        Application.DoEvents()
        ListView1.Items.Clear()
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Try
            con.ConnectionString = con_ConnectionString
            con.Open()
            cmd.Connection = con '初始化OLEDB命令的连接属性为con
            cmd.CommandText = "select * from  Main"
            dr = cmd.ExecuteReader() '执行OLEDB命令以ExecuteReader()方式，并返回一个OLEDBReader，赋值给dr
            Dim myListViewItem As ListViewItem
            ListView1.BeginUpdate()
            While (dr.Read)
                'Application.DoEvents()
                myListViewItem = New ListViewItem({dr.Item("ID").ToString, dr.Item("fanhao").ToString, Juncode(dr.Item("mingcheng").ToString), Juncode(dr.Item("biaoqian").ToString), Juncode(dr.Item("faxingshang").ToString), Juncode(dr.Item("zhizuoshang").ToString), Juncode(dr.Item("leibie").ToString), Juncode(dr.Item("xilie").ToString), Juncode(dr.Item("daoyan").ToString), Juncode(dr.Item("yanyuan").ToString)})
                ListView1.Items.Add(myListViewItem)
            End While
            ListView1.EndUpdate()
            dr.Close()
            con.Close()

        Catch ex As Exception
            WriteLog(ex)
        Finally
            If dr IsNot Nothing Then dr.Close()
            If con IsNot Nothing Then con.Close()
        End Try

        '只要有一个内容为空则为headersize
        Me.Cursor = Cursors.Arrow
        ResizeColumn()
        Label7.Text = "总共有" & ListView1.Items.Count & "个视频"

    End Sub

    Sub ResizeColumn()
        If ListView1.Items.Count = 0 Then
            For i = 0 To 9
                ListView1.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize)
            Next i
        Else
            Dim isMingchengNull As Boolean = True
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items.Item(i).SubItems(2).Text <> "" Then
                    isMingchengNull = False
                    Exit For
                End If
            Next
            If isMingchengNull Then
                ListView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent)
                ListView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
                For i = 2 To 9
                    ListView1.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize)
                Next i
            Else
                For i = 0 To 9
                    ListView1.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent)
                Next i
            End If

        End If

    End Sub

    '按下排序
    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
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



    Private Sub 删除ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If ListView1.Items.Count = 0 Then Exit Sub
        If ListView1.SelectedItems.Count = 0 Then Exit Sub

        If MsgBox("确认删除选中项？", vbYesNo, "删除选中项") = vbYes Then
            Dim count As Integer = ListView1.SelectedIndices.Count
            Dim DeleteList As New List(Of String)
            For i As Integer = ListView1.SelectedIndices.Count - 1 To 0 Step -1
                DeleteList.Add(ListView1.SelectedItems.Item(i).Text)
                ListView1.Items.RemoveAt(ListView1.SelectedIndices(i))
            Next

            Dim con As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim myDataAdapter As New OleDbDataAdapter
            Try
                con.ConnectionString = con_ConnectionString
                con.Open()

                cmd.Connection = con '初始化OLEDB命令的连接属性为con
                For Each item In DeleteList
                    cmd.CommandText = "delete from Main where ID=" & item
                    myDataAdapter.UpdateCommand = cmd
                    cmd.ExecuteNonQuery()
                    'Debug.Print(item)
                Next
                con.Close()
            Catch ex As Exception
                WriteLog(ex)
            Finally
                If con IsNot Nothing Then con.Close()
            End Try
            Label7.Text = "删除" & count & "个视频"
        End If
    End Sub


    Private Sub 去除重复项ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 去除重复项ToolStripMenuItem.Click
        '待优化、修改
        If ListView1.Items.Count = 0 Then Exit Sub
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim myfanhao(0) As String
        Dim myID(0) As Integer
        Try
            con.ConnectionString = con_ConnectionString
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        cmd.Connection = con '初始化OLEDB命令的连接属性为con
        PaixuSql = "select * from Main"
        cmd.CommandText = PaixuSql
        dr = cmd.ExecuteReader() '执行OLEDB命令以ExecuteReader()方式，并返回一个OLEDBReader，赋值给dr
        Dim i As Int16
        i = 0
        myfanhao(0) = ""
        myID(0) = 0
        While (dr.Read)
            i = i + 1
            ReDim Preserve myfanhao(i)
            ReDim Preserve myID(i)
            myfanhao(i) = dr.Item("fanhao").ToString
            myID(i) = Int(dr.Item("ID").ToString)
        End While
        dr.Close()
        con.Close()
        '将重复的项的ID记录到另一个数组
        Dim chongfu(0) As String
        chongfu(0) = ""
        Dim num As Integer
        num = 0
        For i = 1 To UBound(myfanhao) - 1
            For j = i + 1 To UBound(myfanhao)
                If myfanhao(i) = myfanhao(j) Then
                    num = num + 1
                    ReDim Preserve chongfu(num)
                    chongfu(num) = myID(j)
                End If
            Next
        Next

        Dim myDataAdapter As New OleDbDataAdapter()
        con.ConnectionString = con_ConnectionString
        con.Open()
        cmd.Connection = con '初始化OLEDB命令的连接属性为con
        For i = 1 To UBound(chongfu)
            cmd.CommandText = "delete from Main where ID=" & chongfu(i)
            myDataAdapter.UpdateCommand = cmd
            cmd.ExecuteNonQuery()
        Next
        con.Close()
        ListView1.Items.Clear()
        LoadDataBase()
        Label7.Text = ("成功去除" & UBound(chongfu) & "个重复项")
    End Sub

    Private Sub 清除所有名称ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 清除所有名称ToolStripMenuItem.Click
        If ListView1.Items.Count = 0 Then Exit Sub
        If MsgBox("确认删除所有名称？", vbYesNo, "删除所有名称") = vbYes Then
            Dim i As Integer
            Dim con As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim myDataAdapter As New OleDbDataAdapter()
            Try
                con.ConnectionString = con_ConnectionString
                con.Open()
                cmd.Connection = con
                For i = 0 To ListView1.Items.Count - 1
                    ListView1.Items(i).SubItems(2).Text = ""
                    cmd.CommandText = "update Main set mingcheng = '' where ID = " & ListView1.Items(i).SubItems(0).Text
                    myDataAdapter.UpdateCommand = cmd
                    cmd.ExecuteNonQuery()
                Next
                con.Close()
                ListView1.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize)
            Catch ex As Exception
                WriteLog(ex)
            Finally
                if con IsNot nothing Then con.close
            End Try
        End If
    End Sub

    Private Sub 清除所有下载信息ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 清除所有下载信息ToolStripMenuItem.Click
        If ListView1.Items.Count = 0 Then Exit Sub
        If MsgBox("确认删除所有信息？", vbYesNo, "删除所有信息") = vbYes Then
            Dim i, j As Integer
            For i = 0 To ListView1.Items.Count - 1
                ListView1.Items(i).SubItems(2).Text = ""
            Next
            For j = 4 To 9
                For i = 0 To ListView1.Items.Count - 1
                    ListView1.Items(i).SubItems(j).Text = ""
                Next
            Next j

            Dim con As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim myDataAdapter As New OleDbDataAdapter()
            Dim sql As String
            Try
                con.ConnectionString = con_ConnectionString
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            cmd.Connection = con '初始化OLEDB命令的连接属性为con
            For i = 0 To ListView1.Items.Count - 1
                sql = "update Main set mingcheng = '' , daoyan= '' , xilie= '' , leibie= '' , faxingshang= '' , zhizuoshang= '' , yanyuan= ''"
                cmd.CommandText = sql & " where ID = " & ListView1.Items(i).SubItems(0).Text
                myDataAdapter.UpdateCommand = cmd
                cmd.ExecuteNonQuery()
            Next
            con.Close()

            For i = 2 To 9
                ListView1.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize)
            Next i
            Label7.Text = "成功清除所有信息！"
        End If
    End Sub

    Private Sub 重置数据库ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重置数据库ToolStripMenuItem.Click
        '待优化
        If ListView1.Items.Count = 0 Then Exit Sub
        If MsgBox("清空数据不可逆，是否确认清空？", vbYesNo, "清空数据") = vbYes Then
            Dim con As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim myDataAdapter As New OleDbDataAdapter
            Try
                con.ConnectionString = con_ConnectionString
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            cmd.Connection = con '初始化OLEDB命令的连接属性为con
            For i = 0 To ListView1.Items.Count - 1
                cmd.CommandText = "delete from Main where ID=" & ListView1.Items(i).SubItems(0).Text
                myDataAdapter.UpdateCommand = cmd
                cmd.ExecuteNonQuery()
            Next
            con.Close()
            ListView1.Items.Clear()
            Label7.Text = ("成功清空数据！")
        End If
    End Sub



    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If ListView1.Items.Count = 0 Then Exit Sub
        If ListView1.SelectedItems.Count = 0 Then Exit Sub
        GlobalFanhaoID = ListView1.SelectedItems.Item(0).Text
        FormEdit.ShowDialog()
    End Sub



    Private Sub myDatabaseForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '窗体控件加载完成后才载入数据库
        Timer2.Enabled = True
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Cursor = Cursors.WaitCursor
        LoadDataBase()
        Timer2.Enabled = False
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        'Ctrl + A 全选
        If ListView1.Items.Count = 0 Then Exit Sub
        If e.Control AndAlso e.KeyCode = Keys.A Then
            For i = 0 To ListView1.Items.Count - 1
                ListView1.Items(i).Selected = True
            Next
        End If
    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        LoadDataBase()        '刷新
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove, Label3.MouseMove, Label4.MouseMove, Label5.MouseMove, Label6.MouseMove, Label8.MouseMove, Label1.MouseMove, Label9.MouseMove
        sender.backcolor = GetRelativeColor(Panel2.BackColor, 20)
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave, Label5.MouseLeave, Label4.MouseLeave, Label3.MouseLeave, Label2.MouseLeave, Label8.MouseLeave, Label1.MouseLeave, Label9.MouseLeave
        sender.backcolor = Color.Transparent
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        去除重复项ToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        清除所有下载信息ToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        重置数据库ToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If MsgBox("确认去除不存在的视频？", vbYesNo, "去除不存在的视频") = vbYes Then
            Dim con As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim dr As OleDbDataReader
            Dim weizhi As New List(Of String)
            Dim ID As New List(Of String)
            Try
                con.ConnectionString = con_ConnectionString
                con.Open()
                cmd.Connection = con '初始化OLEDB命令的连接属性为con
                cmd.CommandText = "select * from Main"
                dr = cmd.ExecuteReader() '执行OLEDB命令以ExecuteReader()方式，并返回一个OLEDBReader，赋值给dr
                While (dr.Read)
                    weizhi.Add(dr.Item("weizhi").ToString)
                    ID.Add(Int(dr.Item("ID").ToString))
                End While
                dr.Close()
                con.Close()

            Catch ex As Exception
                WriteLog(ex)
                Exit Sub
            Finally
                If dr IsNot Nothing Then dr.Close()
                If con IsNot Nothing Then con.Close()
            End Try

            '将无效项的ID记录到另一个数组
            Dim wuxiao As New List(Of String)
            For i = 0 To weizhi.Count - 1
                If Not System.IO.File.Exists(weizhi(i)) Then
                    wuxiao.Add(ID(i))
                End If
            Next
            Debug.Print("无效个数：" & wuxiao.Count)

            Try
                Dim myDataAdapter As New OleDbDataAdapter()
                con.ConnectionString = con_ConnectionString
                con.Open()
                cmd.Connection = con '初始化OLEDB命令的连接属性为con
                For Each item In wuxiao
                    cmd.CommandText = "delete from Main where ID=" & item
                    myDataAdapter.UpdateCommand = cmd
                    cmd.ExecuteNonQuery()
                Next
                con.Close()
                ListView1.Items.Clear()
                LoadDataBase()
                Label7.Text = ("成功删除" & wuxiao.Count & "个无效项")
            Catch ex As Exception
                WriteLog(ex)
            Finally
                If con IsNot Nothing Then con.Close()
            End Try
        End If
    End Sub

    Private Sub 打开视频所在位置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开视频所在位置ToolStripMenuItem.Click
        If ListView1.Items.Count = 0 Then Exit Sub
        If ListView1.SelectedItems.Count = 0 Then Exit Sub
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim weizhi As String = ""

        Try
            con.ConnectionString = con_ConnectionString
            con.Open()
            cmd.Connection = con '初始化OLEDB命令的连接属性为con
            Dim sql As String = "select * from Main where ID=" & ListView1.SelectedItems.Item(0).SubItems(0).Text
            cmd.CommandText = sql
            dr = cmd.ExecuteReader() '执行OLEDB命令以ExecuteReader()方式，并返回一个OLEDBReader，赋值给dr
            While (dr.Read)
                weizhi = dr.Item("weizhi").ToString
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            WriteLog(ex)
        Finally
            If dr IsNot Nothing Then dr.Close()
            If con IsNot Nothing Then con.Close()
        End Try

        If System.IO.File.Exists(weizhi) Then
            Try
                Process.Start("Explorer.exe", "/select, """ & weizhi & """")
            Catch ex As Exception

            End Try

        Else
            MsgBox("文件不存在",, "文件不存在")
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        FormStatistical.Show()
    End Sub

    Private Sub Chao_SearchBox1_ChaoSearchBoxKeyDown(sender As Object, e As KeyEventArgs) Handles Chao_SearchBox1.KeyDown
        '搜索
        If ListView1.Items.Count = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            For i = 0 To ListView1.Items.Count - 1
                ListView1.Items(i).Selected = False
            Next
            For i = 0 To ListView1.Items.Count - 1
                If InStr(ListView1.Items.Item(i).SubItems(1).Text, sender.Text, CompareMethod.Text) > 0 Then
                    'Debug.Print(ListView3.Items.Item(i).Text)
                    ListView1.Items(i).Selected = True
                    ListView1.Items(i).EnsureVisible()
                    ListView1.Focus()
                End If
            Next
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        FormSingle.Show()
        FormSingle.BringToFront()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        FormNFO.Show()
        FormNFO.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim VI As New VedioInfo
        Dim content As String = New StreamReader("C:\Users\chao\Documents\Tencent Files\3150659291\FileRecv\再来一层\emby添加媒体库\【武藤あやか せいの彩葉 小谷みく 黒宮えいみ】HAR-007\HAR-007 犯されてイキまくる母を見た娘が媚薬発情！親子同時に責められ絶頂を迎える美人母娘-cd1.nfo").ReadToEnd
        Dim XR As New XMLReader(content)
        VI.mingcheng = XR.SelectSingle("movie", "title")
        VI.daoyan = XR.SelectSingle("movie", "director")
        VI.faxingriqi = IIf(XR.SelectSingle("movie", "release") <> "", XR.SelectSingle("movie", "release"), XR.SelectSingle("movie", "releasedate"))
        VI.faxingshang = XR.SelectSingle("movie", "studio")
        VI.fanhao = IIf(XR.SelectSingle("movie", "id") <> "", XR.SelectSingle("movie", "id"), XR.SelectSingle("movie", "imdbid"))
        VI.leibie = XR.SelectNodes("movie", "genre")
        If XR.SelectSingle("movie", "runtime") = "" Then
            VI.changdu = 0
        Else
            If IsNumeric(XR.SelectSingle("movie", "runtime")) Then
                VI.changdu = Int(XR.SelectSingle("movie", "runtime"))
            Else
                VI.changdu = 0
            End If
        End If
        VI.yanyuan = XR.SelectNodes("movie", "actor/name")
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Dim BS As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(33, 147, 176), Color.FromArgb(109, 213, 237), LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(BS, Me.ClientRectangle)
    End Sub
End Class

