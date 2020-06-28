Imports ShareClass.Bus
Imports System.Windows.Forms
Imports HtmlAgilityPack
Imports ShareClass.ChaoSub
Imports System.IO
Imports System.Net
Public Class Javdb
    Inherits Bus
    Public Sub New(Fanhao As String, BaseUrl As String, Proxy As WebProxy, Optional ReadFromDB As Boolean = True)
        MyBase.New(Fanhao, BaseUrl, Proxy)
    End Sub

    Public Overrides Async Function Parse() As Task(Of Vedio)
        Dim result As New Vedio
        Dim db As ShareClass.DataBase

            '先从数据库解析
            If ReadFromDB Then
                db = New ShareClass.DataBase("select * from PicUrl where num='" & Fanhao & "'")
                result = db.GetVedio()
                If result.num <> "" Then Return result
            End If
            Dim IC As String = ReadDBFCIndex(Fanhao)
            Dim url As String = ""
            If IC = "" Then
                url = BaseUrl & "/search?q=" & Fanhao
                Dim ICSourceCode = Await ShareClass.Net.HttpGet(url, Proxy:=Proxy)
                If ICSourceCode <> "" Then
                    IC = GetIdentificationCode(ICSourceCode, Fanhao)
                End If
            End If

            If IC <> "" Then
                SaveDBFCIndex(Fanhao, IC)
                url = BaseUrl & "/v/" & IC
            Else
                Console.WriteLine("IC获取失败")
                Return result
            End If

            Dim SourceCode = Await ShareClass.Net.HttpGet(url, Proxy:=Proxy)
            If SourceCode = "" Then Return result


            Dim doc = New HtmlAgilityPack.HtmlDocument
            doc.LoadHtml(SourceCode)

            Dim InfoList As New List(Of String)
            Dim title = doc.DocumentNode.SelectNodes("//h2[@class='title is-4']/strong") '标题
            Dim strong = doc.DocumentNode.SelectNodes("//div[@class='panel-block']/strong")
            Dim other = doc.DocumentNode.SelectNodes("//div[@class='panel-block']/span")
            If title IsNot Nothing Then result.title = title(0).InnerText
            Dim i As Integer = 0
            If other IsNot Nothing And strong IsNot Nothing Then
                For Each item In other
                    InfoList.Add(strong(i).InnerText & Replace(item.InnerText, ",&nbsp", ""))
                    i += 1
                Next
            End If
            '信息
            For Each item In InfoList
                Dim info = Split(item, ":")
                Select Case info(0)
                    Case "時間"
                        result.release = info(1)
                    Case "時長"
                        result.runtime = Split(info(1), " ")(0)
                    Case "賣家"
                        result.studio = info(1)
                    Case "類別"
                        result.tag = Replace(info(1), ";", " ")
                    Case "評分"
                        result.rating = Mid(info(1), 3, 1)
                End Select
            Next
            '图片
            result.Pic_S = "https://jdbimgs.com/thumbs/" & LCase(Strings.Left(IC, 2)) & "/" & IC & ".jpg"
            result.Pic_B = "https://jdbimgs.com/covers/" & LCase(Strings.Left(IC, 2)) & "/" & IC & ".jpg"

            Dim extrapic = doc.DocumentNode.SelectNodes("//div[@class='tile-images preview-images']/a") '标题
            If extrapic IsNot Nothing Then
                Dim total As String = ""
                For Each item In extrapic
                    total = total & item.Attributes("href").Value & " "
                Next
                result.fanart = Strings.Left(total, total.Length - 1)
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


    Public Function GetIdentificationCode(SourceCode As String, Fanhao As String) As String
        Dim result As String = ""
        Dim number As String = Split(Fanhao, "-")(1)
        Dim doc = New HtmlAgilityPack.HtmlDocument
        doc.LoadHtml(SourceCode)
        Dim ID = doc.DocumentNode.SelectNodes("//a[@class='box']")
        Try
            If ID IsNot Nothing Then
                For Each item In ID
                    If InStr(item.OuterHtml, number) > 0 Then
                        result = Split(item.Attributes("href").Value, "/")(2)
                    End If
                Next
            Else
                result = ""
            End If
        Catch ex As Exception
            result = ""
        End Try
        Return result
    End Function



    Public Function ReadDBFCIndex(Fanhao As String) As String
        Dim result As String = ""
        Dim FileP As String = Application.StartupPath & "\Data\DBFCIndex.txt"
        If File.Exists(FileP) Then
            If Not IsFileInUse(FileP) Then
                Dim content As String = Nothing
                Using SR As StreamReader = New StreamReader(FileP)
                    content = SR.ReadLine()
                    While (content IsNot Nothing)
                        If InStr(content, Split(Fanhao, "-")(1)) > 0 Then
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

    Public Sub SaveDBFCIndex(Fanhao As String, IC As String)
        Dim FileP As String = Application.StartupPath & "\Data\DBFCIndex.txt"
        If File.Exists(FileP) Then
            If Not IsFileInUse(FileP) Then
                Dim content As String = ""
                Using SR As StreamReader = New StreamReader(FileP)
                    content = SR.ReadToEnd
                End Using
                If InStr(content, Split(Fanhao, "-")(1)) <= 0 Then
                    Using FS As FileStream = New FileStream(FileP, FileMode.Append, FileAccess.Write)
                        FS.Lock(0, FS.Length)
                        Dim SW = New StreamWriter(FS)
                        SW.WriteLine(Split(Fanhao, "-")(1) & " " & IC)
                        FS.Unlock(0, FS.Length)
                        SW.Flush()
                    End Using
                End If
            End If
        End If
    End Sub



End Class
