Imports System.Net.Http
Imports System.Net
Public Class Net

    Public Shared Async Function TestUrl(url As String) As Task(Of Boolean)
        Return Await Task.Run(Function()
                                  Dim result As Boolean = False
                                  Try
                                      Dim HttpWebRequest As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
                                      With HttpWebRequest
                                          .Timeout = 5000
                                          .Method = "GET"
                                          .KeepAlive = False
                                          .Referer = url
                                          .UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36"
                                      End With
                                      Dim HttpWebResponse As HttpWebResponse = CType(HttpWebRequest.GetResponse(), HttpWebResponse)
                                      If HttpWebResponse.StatusCode = HttpStatusCode.OK Then result = True
                                      HttpWebResponse.Close()

                                  Catch e As WebException
                                      Console.WriteLine("URL={0},Message-{1}", url, e.Message)
                                  Catch e As Exception
                                      Console.WriteLine("URL={0},Message-{1}", url, e.Message)
                                  End Try
                                  Return result

                              End Function)
    End Function

    Public Shared Async Function HttpGet(URL As String, Optional TryNum As Integer = 2, Optional Proxy As WebProxy = Nothing) As Task(Of String)
        Dim HtmlText As String = ""
        Dim num As Integer = 0
        While num < TryNum And HtmlText = ""
            HtmlText = Await Task.Run(Function()
                                          Dim result As String = ""
                                          Dim Request As HttpWebRequest
                                          Dim Response As HttpWebResponse
                                          Try
                                              Request = CType(HttpWebRequest.Create(URL), HttpWebRequest)
                                              With Request
                                                  .Accept = "*/*"
                                                  .Timeout = 6000
                                                  .Method = "GET"
                                                  .KeepAlive = False
                                                  .Referer = URL
                                                  .UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36"
                                                  .ReadWriteTimeout = 3000
                                                  If Proxy IsNot Nothing Then .Proxy = Proxy
                                              End With
                                              Response = CType(Request.GetResponse, HttpWebResponse)
                                              Select Case Response.StatusCode
                                                  Case HttpStatusCode.OK
                                                      Dim SR = New IO.StreamReader(Response.GetResponseStream)
                                                      result = SR.ReadToEnd
                                                      SR.Close()
                                                  Case Else
                                                      num = 2
                                              End Select
                                              Response.Close()
                                          Catch e As WebException
                                              Console.WriteLine("URL={0},Message-{1}", URL, e.Message)
                                              If e.Status = WebExceptionStatus.Timeout Then
                                                  num += 1    '超时继续重试
                                              Else
                                                  num = 2
                                              End If
                                          Catch e As Exception
                                              Console.WriteLine("URL={0},Message-{1}", URL, e.Message)
                                          Finally
                                              If Response IsNot Nothing Then Response.Close()
                                          End Try
                                          Return result
                                      End Function)
        End While
        Return HtmlText
    End Function


    '异步下载图片(小文件)
    Public Shared Async Function DownLoadPic(Path As String, URL As String, Optional TryNum As Integer = 2, Optional Proxy As WebProxy = Nothing) As Task(Of Boolean)
        If IO.File.Exists(Path) Then
            If New IO.FileInfo(Path).Length >= 4000 Then Return False
        End If
        Dim DownLoadResult As Boolean = False
        Dim num As Integer = 0
        While num < TryNum And DownLoadResult = False
            DownLoadResult = Await Task.Run(Function()
                                                Dim result As Boolean = False
                                                Dim Request As HttpWebRequest
                                                Dim Response As HttpWebResponse
                                                Dim FS As IO.FileStream
                                                Try
                                                    FS = IO.File.OpenWrite(Path)
                                                    Request = CType(HttpWebRequest.Create(URL), HttpWebRequest)
                                                    With Request
                                                        .Accept = "*/*"
                                                        .Timeout = 6000
                                                        .Method = "GET"
                                                        .KeepAlive = False
                                                        .Referer = URL
                                                        .UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36"
                                                        .ReadWriteTimeout = 3000
                                                        If Proxy IsNot Nothing Then .Proxy = Proxy
                                                    End With
                                                    Response = CType(Request.GetResponse, HttpWebResponse)
                                                    Select Case Response.StatusCode
                                                        Case HttpStatusCode.OK
                                                            '下载文件
                                                            Dim RS = Response.GetResponseStream
                                                            RS.CopyTo(FS)
                                                            FS.Flush()
                                                            FS.Close()
                                                            result = True
                                                        Case Else
                                                            result = False
                                                    End Select
                                                    Response.Close()
                                                Catch e As WebException
                                                    Console.WriteLine("URL={0},Message-{1}", URL, e.Message)
                                                    If e.Status = WebExceptionStatus.Timeout Then num += 1 Else num = 2
                                                Catch e As Exception
                                                    num = 2
                                                    Console.WriteLine("URL={0},Message-{1}", URL, e.Message)
                                                Finally
                                                    If Response IsNot Nothing Then Response.Close()
                                                    If FS IsNot Nothing Then FS.Close()
                                                End Try
                                                Return result
                                            End Function)
        End While
        Return DownLoadResult

    End Function



End Class
