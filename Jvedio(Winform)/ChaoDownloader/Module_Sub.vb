Imports System.IO
Imports System.Xml
Module Module_Sub


    Public Function IsDirectoryScanable(dir As String) As Boolean
        Dim FileInfo As DirectoryInfo
        If My.Computer.FileSystem.DirectoryExists(dir) Then '是否存在
            If Len(dir) <= 3 Then '磁盘根目录
                Return True
            End If
            FileInfo = My.Computer.FileSystem.GetDirectoryInfo(dir)
            'Debug.Print(FileInfo.Attributes.ToString)
            If InStr(FileInfo.Attributes.ToString, "System") > 0 Or (InStr(FileInfo.Attributes.ToString, "System") And InStr(FileInfo.Attributes.ToString, "Hidden")) Then
                '如果文件夹属性时system或者system | hidden 则返回false
                Return False
            Else
                '试试看能不能获得所有子目录
                Try
                    Dim Fi As String() = Directory.GetDirectories(dir)
                Catch ex As Exception '不能获得子目录说明无权访问
                    Debug.Print(ex.Message)
                    Return False
                End Try
                Return True
            End If
        Else
            Debug.Print("不存在")
            Return False
        End If
    End Function

    Public Function IsAtLeastOneExtraPic(Path As String, Fanhao As String) As Boolean
        Dim result As Boolean = False
        Dim myIReadOnlyCollection As IReadOnlyCollection(Of String)
        Dim myfi As DirectoryInfo = New DirectoryInfo(Path)
        Dim mySearchPattern(0) As String
        mySearchPattern(0) = "*.jpg"
        If IsDirectoryScanable(Path) Then
            myIReadOnlyCollection = My.Computer.FileSystem.GetFiles(Path, FileIO.SearchOption.SearchTopLevelOnly, mySearchPattern)
        Else
            Return False
        End If

        If InStr(Path, "\Extra\") > 0 Then
            '扫描该文件夹下所有文件，有一个则返回真
            If myIReadOnlyCollection.Count > 0 Then Return True
        ElseIf InStr(Path, "\DownLoad\") > 0 Then
            '扫描该文件夹下所有文件，去除_s,_b有一个则返回真
            If myIReadOnlyCollection.Count > 2 Then Return True
        End If

        Return result
    End Function


    Public Sub CreateDir()
        IO.Directory.CreateDirectory(SmallPicSavePath)
        IO.Directory.CreateDirectory(BigPicSavePath)
        IO.Directory.CreateDirectory(ExtraPicSavePath)
        IO.Directory.CreateDirectory(ActressesPicSavePath)
    End Sub

End Module
