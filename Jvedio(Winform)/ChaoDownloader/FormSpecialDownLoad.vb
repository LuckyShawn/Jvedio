Imports ShareClass.Net
Public Class FormSpecialDownLoad

    Delegate Sub DelegateSetStatus(ByVal state As String, ByVal msg As String)

    Sub SetStatus(ByVal state As String, ByVal msg As String)
        Chao_StatusIndicator1.Status = state
        FormMain.Label4.Text = msg
        FormMain.Label6.Text = Split(FormMain.Label6.Text, "/")(0) & "/" & DownLoadList.Count
    End Sub
    Private Sub Chao_TextBox1_TextChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles Chao_TextBox1.TextChanged
        Chao_TextBox2.Text = UCase(Chao_TextBox1.Text)
    End Sub

    Private Async Sub DownLoad()
        Dim fanhaoList As List(Of String) = GetMultiFanhao(Chao_TextBox2.Text, NumericUpDown1.Text, NumericUpDown2.Text, NumericUpDown3.Text)
        '先判断第一个能否http通，否则取消
        Dim fanhao As String = fanhaoList(0)
        Dim url As String = Settings.BusWebSite & "/" & fanhao
        Dim result = Await TestUrl(url)
        If result Then
            '继续
            For Each item In fanhaoList
                fanhao = item
                While PauseDownload
                    'Console.WriteLine("暂停")
                    Threading.Thread.Sleep(500)
                End While
                'If InStr(fanhao, "FC2") > 0 Then
                '    Dim FC As New FCDownLoader(fanhao)
                'Else
                '    Dim Bus As New BusDownLoader(fanhao)
                'End If

            Next
        Else
            '没法下载

        End If
    End Sub
    Private Async Sub BeforeAddToList()
        If Chao_TextBox1.Text = "" Or Chao_TextBox2.Text = "" Or NumericUpDown1.Text = "" Or NumericUpDown2.Text = "" Or NumericUpDown3.Text = "" Then Exit Sub
        IsThreadRunning = FC2Running Or BusRunning
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
            FormMain.CheckForPic()
            Me.Invoke(New DelegateSetStatus(AddressOf SetStatus), "Running", "加载中……")
            Dim fanhaoList As List(Of String) = GetMultiFanhao(Chao_TextBox2.Text, NumericUpDown1.Text, NumericUpDown2.Text, NumericUpDown3.Text)
            Dim fanhao As String = fanhaoList(0)
            Dim url As String = Settings.BusWebSite & "/" & fanhao
            Dim result = Await TestUrl(url)
            If result Then
                For Each item In fanhaoList
                    '三个条件
                    '0-数据库中的信息不为空
                    '1-大小图都存在
                    '2-至少存在一张预览图
                    '3- 不跳过
                    Select Case SkipCondition
                        Case 0
                            Dim db = New ShareClass.DataBase("select * from Main where fanhao='" & item & "'")
                            Dim Mingcheng As String = db.GetInfo("Mingcheng")
                            If Mingcheng <> "" And Not DownLoadList.Contains(item) Then DownLoadList.Add(item)
                        Case 1
                            Dim PicP1, PicP2 As String
                            If CreateFanhaoFile Then
                                PicP1 = Application.StartupPath & "\DownLoad\" & item & "\" & item & "_s.jpg"
                                PicP2 = Application.StartupPath & "\DownLoad\" & item & "\" & item & "_b.jpg"
                            Else
                                PicP1 = Application.StartupPath & "\Pic\SmallPic\" & item & ".jpg"
                                PicP2 = Application.StartupPath & "\Pic\BigPic\" & item & ".jpg"
                            End If
                            If Not IO.File.Exists(PicP1) And Not IO.File.Exists(PicP2) And Not DownLoadList.Contains(item) Then DownLoadList.Add(item)
                        Case 2
                            Dim PicP3 As String
                            If CreateFanhaoFile Then
                                PicP3 = Application.StartupPath & "\DownLoad\" & item & "\"
                            Else
                                PicP3 = Application.StartupPath & "\Pic\Extra\" & item & "\"
                            End If
                            If Not IsAtLeastOneExtraPic(PicP3, item) And Not DownLoadList.Contains(item) Then DownLoadList.Add(item)
                        Case 3
                            If Not DownLoadList.Contains(item) Then DownLoadList.Add(item)
                        Case Else

                    End Select



                Next
                Me.Invoke(New DelegateSetStatus(AddressOf SetStatus), "Success", "加载完成，请点击开始或继续加载")
            Else
                Me.Invoke(New DelegateSetStatus(AddressOf SetStatus), "Success", "添加失败！")
                MsgBox(fanhao & "无法下载，因此后续任务全部取消",, "提示")
            End If
        End If
    End Sub



    Private Sub Chao_Button2_Click(sender As Object, e As EventArgs) Handles Chao_Button2.Click
        Task.Run(AddressOf BeforeAddToList)
    End Sub
    Function GetMultiFanhao(fanhao As String, num As Integer, BeginNum As Integer, EndNum As Integer) As List(Of String)
        Dim result As New List(Of String)
        For i = BeginNum To EndNum Step 1
            result.Add(fanhao & "-" & GetNum(num, i))
        Next
        Return result
    End Function

    Function GetNum(n1 As Integer, n2 As String) As String
        'If Len(n2) > n1 Then Return n2
        While (Len(n2) < n1)
            n2 = "0" & n2
        End While
        Return n2
    End Function

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged, NumericUpDown3.ValueChanged
        If Int(NumericUpDown2.Text) >= Int(NumericUpDown3.Text) Then
            NumericUpDown3.Text = Int(NumericUpDown2.Text) + 5
        End If
    End Sub

    Private Sub Chao_TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Chao_TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Chao_Button2_Click(Me, New EventArgs)
        End If
    End Sub

    Private Sub FormSpecialDownLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class