Imports System.Net.Http
Imports System.Net
Imports System.IO
Imports ShareClass.Net
Imports ShareClass.ChaoSub
Imports ShareClass

Module Module_Net

    ' Library 反爬虫
    'https://blog.csdn.net/qq_39802740/article/details/101367856

    Public Enum PicDownLoadMode
        SmallPic = 0
        BigPicActors = 1
        ExtraPic = 2
    End Enum

    Public Class DownLoader
        Private _Fanhao As String
        Private _Mode As PicDownLoadMode
        Private _Proxy As WebProxy
        Private _vedio As Variable.Vedio

        Property vedio As ShareClass.Variable.Vedio
            Get
                Return _vedio
            End Get
            Set
                _vedio = Value
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

        Property Mode As PicDownLoadMode
            Get
                Return _Mode
            End Get
            Set
                _Mode = Value
            End Set
        End Property

        Sub New(Fanhao As String, Mode As PicDownLoadMode, Proxy As WebProxy)
            Me.Fanhao = Fanhao
            Me.Mode = Mode
            Me.Proxy = Proxy
        End Sub

        Public Async Function GetVedio() As Task(Of ShareClass.Variable.Vedio)
            Dim vedio As New ShareClass.Variable.Vedio
            If InStr(Fanhao, "FC2") > 0 Then
                Dim FC2 = New ShareClass.Javdb(Fanhao, Settings.DBWebSite, DownLoadProxy)
                vedio = Await FC2.Parse()
            Else
                Dim Bus = New ShareClass.Bus(Fanhao, Settings.BusWebSite, DownLoadProxy)
                vedio = Await Bus.Parse()
            End If
            Return vedio
        End Function

        Public Async Function Download(PicUrl As String) As Task(Of Boolean)
            Dim Picpath As String = ""
            Select Case Mode
                Case 0
                    Picpath = Application.StartupPath & "\Pic\SmallPic\" & Fanhao & ".jpg"
                Case 1
                    Picpath = Application.StartupPath & "\Pic\BigPic\" & Fanhao & ".jpg"
                Case 2
                    Dim RootPath = Application.StartupPath & "\Pic\Extra\" & Fanhao
                    Directory.CreateDirectory(RootPath)
                    Picpath = RootPath & "\" & Split(PicUrl, "/")(Split(PicUrl, "/").Count - 1)
            End Select
            Return Await DownLoadPic(Picpath, PicUrl)
        End Function

    End Class

    Public Class WebClientPro
        Inherits WebClient
        Private _timeOut As Integer


        Sub New(Optional TimeOt As Integer = 10000)
            TimeOut = TimeOt
        End Sub

        Public Property TimeOut As Integer
            Get
                Return _timeOut
            End Get
            Set(value As Integer)
                _timeOut = value
            End Set
        End Property

        Protected Overrides Function GetWebRequest(ByVal uri As Uri) As WebRequest
            Dim Request As WebRequest = MyBase.GetWebRequest(uri)
            Request.Timeout = Me.TimeOut
            Return Request
        End Function

        Protected Overrides Function GetWebResponse(request As WebRequest) As WebResponse
            Dim Response As WebResponse
            Try
                Response = CType(request.GetResponse(), HttpWebResponse)
                Return Response
            Catch ex As WebException
                'If ex.Status = WebExceptionStatus.Timeout Then
                '    'Console.WriteLine("webclient --Time out")
                '    'DownLoadNum -= 1
                'End If
                Return Nothing
            End Try
        End Function
    End Class

End Module
