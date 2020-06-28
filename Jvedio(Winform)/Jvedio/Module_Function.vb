Imports System.Text.RegularExpressions
Imports System.IO
Imports ShareClass.ChaoSub


Module Module_Function

    Public Function GetImage(PicPath) As Image
        Dim result As Image = Nothing
        If IO.File.Exists(PicPath) Then
            '未解决部分照片大小大于0
            Dim FPLength = New FileInfo(PicPath).Length
            If FPLength > 10 Then '如果图片错误会显示内存不足
                If Not IsFileInUse(PicPath) Then
                    Try
                        Dim FS As New FileStream(PicPath, FileMode.Open, FileAccess.Read)
                        result = Image.FromStream(FS)
                        FS.Close()
                        FS.Dispose()
                    Catch ex As Exception
                        If Settings.FormMainShowBigPic Then
                            result = My.Resources.Resource_FormInfo.BigPicNotFound
                        Else
                            result = My.Resources.Resource_Image.SmallPicNotFound
                        End If
                    End Try
                End If
            Else
                '默认图片
                If Settings.FormMainShowBigPic Then
                    result = My.Resources.Resource_FormInfo.BigPicNotFound
                Else
                    result = My.Resources.Resource_Image.SmallPicNotFound
                End If
            End If
        Else
            '默认图片
            If Settings.FormMainShowBigPic Then
                result = My.Resources.Resource_FormInfo.BigPicNotFound

            Else
                result = My.Resources.Resource_Image.SmallPicNotFound
            End If
        End If
        Return result
    End Function

    Public Function GetIDFromPanel(sender As Object) As Double
        Dim result As Double
        Dim Panel As Panel = sender
        For Each item In Panel.Controls
            If item.GetType.ToString = "System.Windows.Forms.FlowLayoutPanel" Then
                result = CType(Split(item.Name, ";")(1), Double)
                Exit For
            End If
        Next
        Return result
    End Function

    Public Function GetIDFromPicBox(sender As Object) As Double
        Dim result As Double
        Dim Panel As Panel = sender.parent
        For Each item In Panel.Controls
            If item.GetType.ToString = "System.Windows.Forms.FlowLayoutPanel" Then
                result = CType(Split(item.Name, ";")(1), Double)
                Exit For
            End If
        Next
        Return result
    End Function


    Public Function GetRandomList() As List(Of Integer)
        Dim total As Double = New ShareClass.DataBase("select count(*) from Main").GetTotalCount() - 2
        If total > 0 Then
            Dim rand = New Random((Int(Strings.Right(DateTime.Now.Ticks.ToString, 6))))
            Dim RandomList As New List(Of Integer)
            Dim num As Integer = 0
            Do
                num = rand.Next(0, total)
                If Not RandomList.Contains(num) Then
                    RandomList.Add(num)
                End If
            Loop Until RandomList.Count = Settings.LayoutNumber
            Return RandomList
        Else
            Return Nothing
        End If
    End Function

    Public Sub SetProxy()
        If Settings.EnableProxy Then
            Try
                Dim proxy As New System.Net.WebProxy
                Dim s = Split(Settings.ProxyContent, "[Split]")
                With proxy
                    .Address = New Uri(s(0))
                    .Credentials = New System.Net.NetworkCredential(s(1), s(2))
                    .UseDefaultCredentials = False
                    .BypassProxyOnLocal = False
                End With
                DownLoadProxy = proxy
            Catch ex As Exception
                DownLoadProxy = Nothing
            End Try
        Else
            DownLoadProxy = Nothing
        End If
    End Sub



    Public Function GetLabelSize(ByRef L As Label) As SizeF
        Return L.CreateGraphics.MeasureString(L.Text, L.Font)
    End Function


    Public Function GetCharHeight(ByRef Label As Label) As Integer
        Dim TextB As New TextBox With {.Multiline = True, .Width = Label.Width, .Font = Label.Font, .Text = Label.Text}
        If TextB.GetLineFromCharIndex(TextB.TextLength) + 1 > 3 Then
            Return 3
        Else
            Return TextB.GetLineFromCharIndex(TextB.TextLength) + 1
        End If
    End Function






    Public Function ColorToString(myColor As Color) As String
        ColorToString = myColor.A.ToString & " " & myColor.R.ToString & " " & myColor.G.ToString & " " & myColor.B.ToString & " "
    End Function

    Public Function StringToColor(myString As String) As Color
        Dim str1() As String
        str1 = Split(myString, " ")

        StringToColor = Color.FromArgb(str1(0), str1(1), str1(2), str1(3))
    End Function





    Public Function GetTextBoxHeight(Content As String, Font As Font) As Single
        Dim Label As New Label With {.AutoSize = True, .Text = Content, .Font = Font}
        Dim g As Graphics = Label.CreateGraphics
        Dim TextSize As SizeF = g.MeasureString(Content, Font)
        g.Dispose()
        Return TextSize.Height
    End Function

    Public Sub LoadPicFromFile(path As String, picb As PictureBox)
        If IO.File.Exists(path) Then
            If My.Computer.FileSystem.GetFileInfo(path).Length > 0 Then '如果图片错误会显示内存不足
                If Not IsFileInUse(path) Then
                    Try
                        Dim pFileStream As New FileStream(path, FileMode.Open, FileAccess.Read)
                        picb.Image = Image.FromStream(pFileStream)
                        pFileStream.Close()
                        pFileStream.Dispose()
                        Application.DoEvents()
                    Catch ex As Exception
                        'MsgBox(ex.Message)
                    End Try
                End If
            End If
        Else
            picb.Image = My.Resources.Resource_FormInfo.ActressesNotFound
        End If
    End Sub



    Public Function getPaixuSql(str As String, database As String) As String

        Dim PaixuSql As String = ""
        Select Case FormMain.Label12.Text
            Case "识别码"
                PaixuSql = "select * from " & database & " " & str & " order by fanhao" & IIf(Settings.SortDesc, " desc", "")
            Case "影片名称名称"
                PaixuSql = "select * from " & database & " " & str & " order by mingcheng" & IIf(Settings.SortDesc, " desc", "")
            Case "访问次数"
                PaixuSql = "select * from " & database & " " & str & " order by fangwencishu" & IIf(Settings.SortDesc, " desc", "")
            Case "文件大小"
                PaixuSql = "select * from " & database & " " & str & " order by wenjiandaxiao" & IIf(Settings.SortDesc, " desc", "")
            Case "发行日期"
                PaixuSql = "select * from " & database & " " & str & " order by faxingriqi" & IIf(Settings.SortDesc, " desc", "")
            Case "导入时间"
                PaixuSql = "select * from " & database & " " & str & " order by daorushijian" & IIf(Settings.SortDesc, " desc", "")
            Case "喜爱程度"
                PaixuSql = "select * from " & database & " " & str & " order by love" & IIf(Settings.SortDesc, " desc", "")
            Case Else
                PaixuSql = "select * from  " & database
        End Select
        Return PaixuSql
    End Function

End Module
