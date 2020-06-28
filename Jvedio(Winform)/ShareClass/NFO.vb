Imports System.IO
Imports System.Xml

Public Class NFO
    Private XmlDoc As New System.Xml.XmlDocument
    Private FilePath As String = ""
    Sub New(FP As String, RootNodeName As String)
        FilePath = FP
        Try
            Dim header As XmlNode = XmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "yes")
            XmlDoc.AppendChild(header)
            Dim xm As XmlElement = XmlDoc.CreateElement(RootNodeName)
            XmlDoc.AppendChild(xm)
            CreateNewNode("source")
            CreateNewNode("plot")
            CreateNewNode("title")
            CreateNewNode("director")
            CreateNewNode("rating")
            CreateNewNode("criticrating")
            CreateNewNode("year")
            CreateNewNode("mpaa")
            CreateNewNode("customrating")
            CreateNewNode("countrycode")
            CreateNewNode("premiered")
            CreateNewNode("release")
            CreateNewNode("runtime")
            CreateNewNode("country")
            CreateNewNode("studio")
            CreateNewNode("id")
            CreateNewNode("num")
            XmlDoc.Save(FP)
        Catch ex As Exception
            ShareClass.ChaoSub.WriteLog(ex)
        End Try
    End Sub

    Private Sub CreateNewNode(NodeName As String, Optional NodeText As String = "", Optional NodeID As String = "", Optional NodeIDValue As String = "")
        Dim Root As XmlElement = XmlDoc.DocumentElement
        Dim XE As XmlElement = Nothing
        XE = XmlDoc.CreateElement(NodeName)
        If NodeID <> "" Then XE.SetAttribute(NodeID, NodeIDValue)
        XE.InnerText = NodeText
        Root.AppendChild(XE)
    End Sub

    Public Sub AppendNewNode(NodeName As String, Optional NodeText As String = "", Optional NodeID As String = "", Optional NodeIDValue As String = "")
        Try
            XmlDoc.Load(FilePath)
            Dim Root As XmlElement = XmlDoc.DocumentElement
            Dim XE As XmlElement = Nothing
            XE = XmlDoc.CreateElement(NodeName)
            If NodeID <> "" Then XE.SetAttribute(NodeID, NodeIDValue)
            XE.InnerText = NodeText
            Root.AppendChild(XE)
            XmlDoc.Save(FilePath)
        Catch ex As Exception
            ShareClass.ChaoSub.WriteLog(ex)
        End Try
    End Sub

    Public Sub AppendNodeToNode(ByVal FatherNode As String, ByVal NodeName As String, Optional ByVal NodeText As String = "", Optional NodeID As String = "", Optional NodeIDValue As String = "")

        If File.Exists(FilePath) AndAlso NodeName <> "" AndAlso FatherNode <> "" Then
            XmlDoc.Load(FilePath)

            Dim XE As XmlElement = XmlDoc.CreateElement(NodeName)
            If NodeID <> "" Then XE.SetAttribute(NodeID, NodeIDValue)
            XE.InnerText = NodeText


            Dim FatherList As XmlNodeList = XmlDoc.GetElementsByTagName(FatherNode)
            Dim Father As XmlNode = FatherList(FatherList.Count - 1)
            Father.AppendChild(XE)
            XmlDoc.Save(FilePath)
        End If
    End Sub

    Public Function ReadNodeFromXML(NodeName As String) As String

        If File.Exists(FilePath) AndAlso NodeName <> "" Then
            XmlDoc.Load(FilePath)
            Dim XN As XmlNode = XmlDoc.GetElementsByTagName(NodeName)(0)
            If XN IsNot Nothing Then
                Return XN.InnerText
            Else
                Return ""
            End If
        Else
            Return ""
        End If

    End Function


    Public Sub SetNodeText(NodeName As String, NodeText As String)
        If File.Exists(FilePath) AndAlso NodeName <> "" Then
            XmlDoc.Load(FilePath)
            Dim XN As XmlNode = XmlDoc.GetElementsByTagName(NodeName)(0)
            If XN IsNot Nothing Then
                XN.InnerText = NodeText
                XmlDoc.Save(FilePath)
            End If
        End If
    End Sub



End Class

