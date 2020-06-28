
Imports System.IO
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.Drawing
Public Class ChaoSub




    Public Shared Function StringToRGB(str As String) As Color()
        Dim s As String()
        s = Split(str, " ")
        Dim p As String()
        Dim result As Color()
        result = Nothing
        Dim i As Integer
        For i = 0 To UBound(s) - LBound(s)
            p = Split(s(i), ",")
            ReDim Preserve result(i)
            result(i) = Color.FromArgb(Val(p(0)), Val(p(1)), Val(p(2)))
        Next i
        Return result

    End Function

    Public Shared Function GetRoundRectangle(Rectangle As Rectangle, Optional r As Single = 0) As System.Drawing.Drawing2D.GraphicsPath
        If r <= 0 Then r = Math.Min(Rectangle.Height, Rectangle.Width) / 3
        If r > Math.Min(Rectangle.Height, Rectangle.Width) / 2 Then r = Math.Min(Rectangle.Height, Rectangle.Width) / 3
        Dim result As New System.Drawing.Drawing2D.GraphicsPath
        With result
            .AddArc(0, 0, 2 * r, 2 * r, 180, 90)
            .AddArc(Rectangle.Width - 2 * r, 0, 2 * r, 2 * r, 270, 90)
            .AddArc(Rectangle.Width - 2 * r, Rectangle.Height - 2 * r, 2 * r, 2 * r, 0, 90)
            .AddArc(0, Rectangle.Height - 2 * r, 2 * r, 2 * r, 90, 90)
            .CloseFigure()
        End With
        Return result
    End Function



    ''' <summary>
    ''' 获得相对颜色，RGB整体加减一个值
    ''' </summary>
    ''' <param name="Mycolor">要修改的颜色</param>
    ''' <param name="CV">改变的大小</param>
    ''' <param name="A">是否设置透明色，默认不透明</param>
    ''' <returns></returns>
    Public Shared Function GetRelativeColor(Mycolor As Color, CV As Integer, Optional A As Integer = 255) As Color
        Dim ChangeValue As Integer = CV
        Dim aVal As Integer = Mycolor.A
        Dim rVal As Integer = Mycolor.R
        Dim gVal As Integer = Mycolor.G
        Dim bVal As Integer = Mycolor.B
        If rVal + ChangeValue <= 255 And rVal + ChangeValue >= 0 Then
            rVal += ChangeValue
        End If
        If gVal + ChangeValue <= 255 And gVal + ChangeValue >= 0 Then
            gVal += ChangeValue
        End If
        If bVal + ChangeValue <= 255 And bVal + ChangeValue >= 0 Then
            bVal += ChangeValue
        End If
        Return Color.FromArgb(A, rVal, gVal, bVal)
    End Function

    Public Shared Sub OpenFilePath(filename As String)
        Try
            Process.Start("Explorer.exe", "/select, """ & filename & """")
        Catch ex As Exception
            MsgBox("被杀毒软件拦截！",, "提示")
        End Try
    End Sub


    Public Shared Sub SaveToDataBase(vedio As Vedio)
        vedio = FormatDataBaseVedio(vedio)
        Dim db = New ShareClass.DataBase("")
        Dim Sql = "update Main set faxingriqi = '" & vedio.release & "', changdu = " & vedio.runtime & ", mingcheng = '" & vedio.title & "', daoyan = '" & vedio.director & "', zhizuoshang = '" & vedio.studio & "', faxingshang = '" & vedio.studio &
                    "', xilie = '" & vedio.tag & "', leibie = '" & vedio.genre & "', yanyuan = '" & vedio.actor & "'" & " where fanhao = '" & vedio.id & "'"
        db.UpdateCommand(Sql)
        db.Dispose()
    End Sub

    Public Shared Sub SaveToNFO(vedio As Vedio, NfoPath As String)
        Dim nfo As New NFO(NfoPath, "movie")
        'nfo.SetNodeText("source", Settings.BusWebSite)
        nfo.SetNodeText("title", Replace(vedio.title, "(" & vedio.id & ")", ""))
        nfo.SetNodeText("director", vedio.director)
        nfo.SetNodeText("rating", vedio.rating)
        nfo.SetNodeText("criticrating", vedio.criticrating)
        nfo.SetNodeText("year", vedio.year)
        nfo.SetNodeText("mpaa", vedio.mpaa)
        nfo.SetNodeText("customrating", vedio.customrating)
        nfo.SetNodeText("countrycode", vedio.countrycode)
        nfo.SetNodeText("premiered", vedio.premiered)
        nfo.SetNodeText("release", vedio.release)
        nfo.SetNodeText("runtime", vedio.runtime)
        nfo.SetNodeText("country", vedio.country)
        nfo.SetNodeText("studio", vedio.studio)
        nfo.SetNodeText("id", vedio.id)
        nfo.SetNodeText("num", vedio.num)

        '类别
        For Each item In Split(vedio.genre, " ")
            If Len(item.ToString) > 0 Then
                nfo.AppendNewNode("genre", item)
            End If
        Next
        '系列
        For Each item In Split(vedio.tag, " ")
            If Len(item.ToString) > 0 Then
                nfo.AppendNewNode("tag", item)
            End If
        Next

        '演员
        Dim i As Integer = 0
        Dim thumb = Split(vedio.actorthumb, " ")
        'Debug.Print(thumb.Count & ":" & Split(vedio.actor, " ").Count)
        For Each item In Split(vedio.actor, " ")
            If Len(item.ToString) > 0 Then
                nfo.AppendNewNode("actor")
                nfo.AppendNodeToNode("actor", "name", item)
                nfo.AppendNodeToNode("actor", "type", "Actor")
                nfo.AppendNodeToNode("actor", "thumb", thumb(i))
                i += 1
            End If
        Next

        'Fanart
        nfo.AppendNewNode("fanart")
        For Each item In Split(vedio.fanart, " ")
            If Len(item.ToString) > 0 Then
                nfo.AppendNodeToNode("fanart", "thumb", item, "preview", item)
            End If
        Next

        nfo.AppendNewNode("fanart_s")
        For Each item In Split(vedio.fanart_s, " ")
            If Len(item.ToString) > 0 Then
                nfo.AppendNodeToNode("fanart_s", "thumb", item, "preview", item)
            End If
        Next
    End Sub

    ''' <summary>
    ''' 出错误写日志
    ''' </summary>
    ''' <param name="ex"></param>
    Public Shared Sub WriteLog(ByVal ex As Exception)
        Dim myLogPath As String = Application.StartupPath & "\Log"
        Dim txtPath As String = myLogPath & "\" & Format(DateTime.Now, "yyyy年MM月dd日 HH：mm：ss") & ".txt"
        If Not IO.File.Exists(myLogPath) Then
            My.Computer.FileSystem.CreateDirectory(myLogPath)
        End If
        Try
            Using sw As StreamWriter = New StreamWriter(txtPath, True)
                sw.WriteLine("当前时间：" & DateTime.Now.ToString())
                sw.WriteLine("异常信息：" & ex.Message)
                sw.WriteLine("异常对象：" & ex.Source)
                sw.WriteLine("调用堆栈：" & vbLf & ex.StackTrace.Trim())
                sw.WriteLine("触发方法：" & ex.TargetSite.ToString)
                sw.WriteLine()
            End Using
        Catch ex1 As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox(ex.Message)
    End Sub


    ''' <summary>
    ''' 对字典进行排序
    ''' </summary>
    ''' <param name="dic"></param>
    Public Shared Sub Sort(ByRef dic As Dictionary(Of String, Integer))
        Dim count As Integer = dic.Count
        Dim arrayKey(count) As String
        Dim arrayValue(count) As Integer
        dic.Keys.CopyTo(arrayKey, 0)
        dic.Values.CopyTo(arrayValue, 0)
        Array.Sort(arrayValue, arrayKey)
        Array.Reverse(arrayKey) '降序
        Array.Reverse(arrayValue)
        dic.Clear()
        For i = 0 To count - 1
            dic.Add(arrayKey(i), arrayValue(i))
        Next
    End Sub

    Public Shared Function HandlePicExist(PicPath As String) As Boolean
        If IO.File.Exists(PicPath) Then
            If IsFileInUse(PicPath) Then
                Return False    '被占用
            Else
                Dim FI As New FileInfo(PicPath)
                If FI.Length <= 30 Then
                    Try
                        IO.File.Delete(PicPath)
                        Return True '文件被成功删除
                    Catch ex As Exception
                        Return False                   '文件被占用
                    End Try
                Else
                    Return False  '文件已存在
                End If
            End If
        Else
            Return True  '文件不存在
        End If
    End Function

    Public Shared Function IsFileInUse(fileName As String) As Boolean
        Dim inUse As Boolean = True
        Dim fs As FileStream = Nothing
        Try
            fs = New FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None)
            inUse = False
        Catch ex As Exception
        Finally
            If fs IsNot Nothing Then
                fs.Close()
            End If
        End Try
        Return inUse
    End Function


    Public Shared Function FormatDataBaseVedio(vedio As Vedio) As Vedio
        Dim VI As New Vedio
        VI.id = FormatDataBaseInfo(vedio.id, 1)
        VI.num = FormatDataBaseInfo(vedio.num, 1)
        VI.title = FormatDataBaseInfo(vedio.title)
        VI.runtime = FormatDataBaseInfo(vedio.runtime, 1)
        VI.studio = FormatDataBaseInfo(vedio.studio)
        VI.director = FormatDataBaseInfo(vedio.director)
        VI.genre = FormatDataBaseInfo(vedio.genre)
        VI.actor = FormatDataBaseInfo(vedio.actor)
        VI.tag = FormatDataBaseInfo(vedio.tag)
        VI.rating = vedio.rating
        VI.criticrating = vedio.criticrating
        VI.year = vedio.year
        VI.mpaa = vedio.mpaa
        VI.customrating = vedio.customrating
        VI.countrycode = vedio.countrycode
        VI.premiered = vedio.premiered
        VI.release = vedio.release
        VI.country = vedio.country
        VI.actorthumb = vedio.actorthumb
        VI.fanart = vedio.fanart
        VI.fanart_s = vedio.fanart_s
        VI.Pic_S = vedio.Pic_S
        VI.Pic_B = vedio.Pic_B
        Return VI
    End Function

    Public Shared Function FormatDataBaseInfo(str As String, Optional mode As Integer = 0) As String
        If mode = 0 Then
            Return Replace(Jencode(str), "'", "’")
        Else
            Return Replace(str, "'", "’")
        End If

    End Function


    '//vb将unicode转成汉字，如：\u8033\u9EA6，转后为：耳麦UnicodeDecode
    Public Shared Function Juncode(strCode As String) As String
        Juncode = strCode
        If InStr(Juncode, "\u") <= 0 Then
            Exit Function
        End If
        strCode = LCase(strCode)
        Dim mc As MatchCollection
        mc = Regex.Matches(strCode, "\\u\S{1,4}")
        For Each m In mc
            strCode = Replace(strCode, m.ToString, ChrW("&H" & Mid(CStr(m.ToString), 3, 6)))
        Next
        Juncode = strCode
    End Function


    '//将中文转为unicode编码，如：耳麦，转后为：\u8033\u9EA6 UnicodeEncode
    Public Shared Function Jencode(strCode As String) As String
        'Jencode = strCode
        Dim a() As String
        Dim str As String
        Dim i As Integer
        'StrTemp = strCode
        Jencode = ""
        For i = 0 To Len(strCode) - 1
            On Error Resume Next
            str = Mid(strCode, i + 1, 1)
            If isChinese(str) = True Then '//是中文
                Jencode = Jencode & "\u" & StrDup(4 - Len(Hex(AscW(str))), "0") & Hex(AscW(str))
            Else '//不是中文
                Jencode = Jencode & str
            End If

        Next

    End Function


    '//是否为中文
    Public Shared Function isChinese(Text As String) As Boolean

        Dim l As Long
        Dim i As Long
        l = Len(Text)
        isChinese = False

        For i = 1 To l
            If Asc(Mid(Text, i, 1)) < 0 Or Asc(Mid(Text, i, 1)) < 0 Then
                isChinese = True
                Exit Function
            End If
        Next

    End Function



End Class
