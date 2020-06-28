Imports System.Net
Module Module1
    Public Class WebClientPro
        Inherits WebClient
        Private _timeOut As Integer


        Sub New(Optional TimeOt As Integer = 15000)
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
