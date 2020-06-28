Imports System.Text.RegularExpressions
Imports ShareClass.Net
Imports System.Net
Imports System.IO
Imports ShareClass.ChaoSub
Imports System.Windows.Forms

''' <summary>
''' 对 Bus 网站进行解析，返回 Vedio
''' </summary>
Public Class Bus
    Private _BaseUrl As String = ""
    Private _Fanhao As String
    Private _Proxy As WebProxy
    Private _ReadFromDB As Boolean

    Property ReadFromDB As Boolean
        Get
            Return _ReadFromDB
        End Get
        Set
            _ReadFromDB = Value
        End Set
    End Property

    Property Proxy As WebProxy
        Get
            Return _Proxy
        End Get
        Set
            _Proxy = Value
        End Set
    End Property

    Property Fanhao As String
        Get
            Return _Fanhao
        End Get
        Set
            _Fanhao = Value
        End Set
    End Property

    Property BaseUrl As String
        Get
            Return _BaseUrl
        End Get
        Set
            _BaseUrl = Value
        End Set
    End Property




    Public Sub New(Fanhao As String, BaseUrl As String, Proxy As WebProxy, Optional ReadFromDB As Boolean = True)
        Me.Fanhao = Fanhao
        Me.BaseUrl = BaseUrl
        Me.Proxy = Proxy
        Me.ReadFromDB = ReadFromDB
    End Sub


    Public Overridable Async Function Parse() As Task(Of Vedio)

        Dim result As New Vedio
        Dim db As ShareClass.DataBase
        '先从数据库解析
        If ReadFromDB Then
            db = New ShareClass.DataBase("select * from PicUrl where num='" & Fanhao & "'")
            result = db.GetVedio()
            If result.title <> "" Then Return result
        End If
        '从网上解析
        Dim Url = BaseUrl & "/" & Fanhao
        Console.WriteLine(Url)
        Dim SourceCode As String = Await HttpGet(Url, Proxy:=Proxy)
        If SourceCode = "" Then Return result
        Dim str As String
        Dim mc As MatchCollection
        Dim mc2 As MatchCollection

        '<meta name="description" content="【發行日期】2012-11-30，【長度】29分鐘，(n0802)标题">
        mc = Regex.Matches(SourceCode, "<meta name=""description"".+>")
        Dim s As String()
        If mc.Count > 0 Then
            'Console.WriteLine(mc(0).ToString)
            mc2 = Regex.Matches(mc(0).ToString, "【發行日期】.+，")
            'Console.WriteLine(mc2(0).ToString)
            result.release = Regex.Matches(mc2(0).ToString, "\d\d\d\d-\d\d-\d\d")(0).ToString



            mc2 = Regex.Matches(mc(0).ToString, "【長度】\d+分鐘")
            result.runtime = Int(Regex.Matches(mc2(0).ToString, "\d+")(0).ToString)


            str = Split(mc(0).ToString, "，")(2)
            s = Split(Mid(str, 1, Len(str) - 2), " ")
            If UBound(s) - LBound(s) + 1 > 1 Then
                result.title = Replace(Mid(str, 1, Len(str) - 2), s(UBound(s) - LBound(s)), "")
            Else
                result.title = Mid(str, 1, Len(str) - 2)
            End If
        End If



        '<span class="header">導演:</span> <a href="https://www.dmmsee.net/studio/ok">キチックス/妄想族</a>'
        mc = Regex.Matches(SourceCode, "<span class=""header"">導演.+</a>")
        If mc.Count > 0 Then
            str = Split(mc(0).ToString, """")(4)
            mc2 = Regex.Matches(str, ">.+<")
            If mc2.Count > 0 Then
                str = mc2(0).ToString
                result.director = Mid(str, 2, Len(str) - 2)
            End If
        End If


        '<span class="header">製作商:</span> <a href="https://www.dmmsee.net/studio/ok">キチックス/妄想族</a>
        mc = Regex.Matches(SourceCode, "<span class=""header"">製作商.+</a>")
        If mc.Count > 0 Then
            str = Split(mc(0).ToString, """")(4)
            mc2 = Regex.Matches(str, ">.+<")
            If mc2.Count > 0 Then
                str = mc2(0).ToString
                result.studio = Mid(str, 2, Len(str) - 2)
            End If
        End If


        ' <span class="header">系列:</span> <a href="https://www.dmmsee.net/studio/ok">キチックス/妄想族</a>
        mc = Regex.Matches(SourceCode, "<span class=""header"">系列.+</a>")
        If mc.Count > 0 Then
            str = Split(mc(0).ToString, """")(4)
            mc2 = Regex.Matches(str, ">.+<")
            If mc2.Count > 0 Then
                str = mc2(0).ToString
                result.tag = Mid(str, 2, Len(str) - 2)
            End If
        End If



        ' 类别
        ' <span class="genre"><a href="https://www.dmmsee.net/genre/g">DMM獨家</a></span>
        mc = Regex.Matches(SourceCode, "<span class=""genre"">.+</span>")
        Dim tempstr() As String
        Dim leibie As String = ""
        If mc.Count > 0 Then
            For Each m In mc
                tempstr = Split(m.ToString, """")
                str = tempstr(UBound(tempstr))
                mc2 = Regex.Matches(str, ">.+</a>")
                str = mc2(0).ToString
                leibie = leibie & (Mid(str, 2, Len(str) - 5)) & " "
            Next
        End If
        result.genre = leibie




        '获得大小图地址
        Dim SPLX As Integer = ShareClass.Identify.GetVedioType(Fanhao)
        Dim url1 As String = ""
        If SPLX = 1 Then
            url1 = "https://images.javcdn.pw"
        ElseIf SPLX = 2 Then
            url1 = "https://pics.javcdn.pw"
        End If

        mc = Regex.Matches(SourceCode, url1 & "/cover/\S+\.jpg")

        If mc.Count > 0 Then

            Dim PicName As String = ""
            Dim m = Split(mc(0).ToString, "/")
            Dim t = Split(m(m.Count - 1), "_")
            PicName = t(0)

            If SPLX = 1 Then
                result.Pic_S = url1 & "/thumbs/" & PicName & ".jpg"
            ElseIf SPLX = 2 Then
                result.Pic_S = url1 & "/thumb/" & PicName & ".jpg"
            End If
            If InStr(mc(0).ToString, "nopic") > 0 Then
                result.Pic_B = url1 & "/cover/nopic.jpg"
            Else
                result.Pic_B = url1 & "/cover/" & PicName & "_b.jpg"
            End If

        End If
        'Console.WriteLine("大图地址：" & result.Pic_B)

        Dim doc = New HtmlAgilityPack.HtmlDocument
        doc.LoadHtml(SourceCode)

        Dim actor = doc.DocumentNode.SelectNodes("//div[@class='col-md-3 info']/ul//img") '演员
        If actor IsNot Nothing Then
            Dim act As String = ""
            For Each item In actor
                act = act & item.Attributes("title").Value & " "
            Next
            result.actor = act
        End If



        Dim img = doc.DocumentNode.SelectNodes("//div[@class='col-md-3 info']/ul//img") '头像地址
        If img IsNot Nothing Then
            Dim actorthumb As String = ""
            For Each item In img
                actorthumb = actorthumb & item.Attributes("src").Value & " "
            Next
            result.actorthumb = actorthumb
        End If


        '样品大图
        Dim sample1 = doc.DocumentNode.SelectNodes("//div[@id='sample-waterfall']/a")
        If sample1 IsNot Nothing Then
            Dim fanart As String = ""
            For Each item In sample1
                fanart = fanart & item.Attributes("href").Value & " "
            Next
            result.fanart = fanart
        End If

        '样品小图
        Dim sample2 = doc.DocumentNode.SelectNodes("//div[@id='sample-waterfall']/a/div/img")
        If sample2 IsNot Nothing Then
            Dim fanart_s As String = ""
            For Each item In sample2
                fanart_s = fanart_s & item.Attributes("src").Value & " "
            Next
            result.fanart_s = fanart_s
        End If

        result.id = Fanhao
        result.num = Fanhao
        result.title = Replace(result.title, Fanhao, "")
        result.title = Replace(result.title, "()", "")
        If result.runtime Is Nothing Then result.runtime = 0
        If result.release = "" Then result.release = "0000-00-00"


        '存图片地址到数据库：
        Dim Vedio As Vedio = result
        db = New DataBase("")
        Dim sql = "insert into PicUrl (num, actorthumb, fanart,Pic_S,Pic_B) values('" & Vedio.id & "', '" & Vedio.actorthumb & "', '" & Vedio.fanart & "','" & Vedio.Pic_S & "','" & Vedio.Pic_B & "')"
        db.UpdateCommand(sql)
        db.Dispose()

        'For Each field In result.GetType.GetFields
        '    Console.WriteLine("{0} = {1}", field.Name, field.GetValue(result))
        'Next

        '保存信息到数据库
        SaveToDataBase(Vedio)
        Return result
    End Function

    Public Function ReadBusIndex(Fanhao As String) As String
        Dim result As String = ""
        Dim FileP As String = Application.StartupPath & "\Data\BusIndex.txt"
        If File.Exists(FileP) Then
            If Not IsFileInUse(FileP) Then
                Dim content As String = Nothing
                Using SR As StreamReader = New StreamReader(FileP)
                    content = SR.ReadLine()
                    While (content IsNot Nothing)
                        If InStr(content, Fanhao) > 0 Then
                            result = Split(content, " ")(1)
                            Exit While
                        End If
                        content = SR.ReadLine()
                    End While
                End Using
            End If
        End If
        Return result
    End Function

    Public Sub SaveBusIndex(Fanhao As String, IC As String)
        Dim FileP As String = Application.StartupPath & "\Data\BusIndex.txt"
        If File.Exists(FileP) Then
            If Not IsFileInUse(FileP) Then
                Dim content As String = ""
                Using SR As StreamReader = New StreamReader(FileP)
                    content = SR.ReadToEnd
                End Using
                If InStr(content, Fanhao) <= 0 Then
                    Using FS As FileStream = New FileStream(FileP, FileMode.Append, FileAccess.Write)
                        FS.Lock(0, FS.Length)
                        Dim SW = New StreamWriter(FS)
                        SW.WriteLine(Fanhao & " " & IC)
                        FS.Unlock(0, FS.Length)
                        SW.Flush()
                    End Using
                End If
            End If
        End If
    End Sub
End Class
