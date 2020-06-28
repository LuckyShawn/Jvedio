Imports System.IO
Module Module_IO

    Public Class XMLReader
        Public XD As New System.Xml.XmlDocument

        Public Sub New(ByVal str As String)
            Try
                MyClass.XD.LoadXml(str)       '加载配置文件  
            Catch ex As Exception

            End Try
        End Sub

        Public Function SelectSingle(ByVal Root As String, ByVal Node As String) As String
            Dim result As String = ""
            Dim XN As System.Xml.XmlNode = XD.SelectSingleNode("//" & Root & "/" & Node)
            If XN IsNot Nothing Then
                result = XN.InnerText
            End If
            Return result
        End Function

        Public Function SelectNodes(ByVal Root As String, ByVal Node As String) As String
            Dim result As String = ""
            Dim XN As System.Xml.XmlNodeList = XD.SelectNodes("//" & Root & "/" & Node)
            If XN IsNot Nothing Then
                For Each item As System.Xml.XmlNode In XN
                    result = result & item.InnerText & " "
                Next
            End If
            Return Strings.Left(result, Len(result) - 1)
        End Function
    End Class

End Module
