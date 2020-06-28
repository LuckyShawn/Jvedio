Public Class ChaoFile


    ''' <summary>
    ''' 使文件大小带单位
    ''' </summary>
    ''' <param name="size"></param>
    ''' <returns></returns>
    Public Shared Function FormatFileSize(size As Double) As String
        If size <= 0 Then Return "0"
        Dim units As String() = New String() {"B", "KB", "MB", "GB", "TB", "PB"}
        Dim s As Double = 1024.0
        Dim i = 0
        While (size >= s)
            size /= s
            i += 1
        End While

        Return size.ToString("#0.00") & units(i)
    End Function



    Public Shared Function getFileSize(str1 As String) As String
        getFileSize = ""
        If str1 = "" Then Exit Function
        Dim num As Double
        num = Val(str1)
        num = num / 1024 / 1024
        If num < 1024 And num > 0 Then
            Return FormatNumber(num, 2) & " Mb"
        ElseIf num >= 1024 Then
            Return FormatNumber(num / 1024, 2) & " Gb"
        End If
    End Function




    Public Shared Function GetFileExtName(FilePathFileName As String) As String   '获取扩展名  .txt
        On Error Resume Next
        Dim i As Integer, j As Integer
        i = Len(FilePathFileName)
        j = InStrRev(FilePathFileName, ".")
        If j = 0 Then
            Return ".txt"
        Else
            Return Mid(FilePathFileName, j, i)
        End If
    End Function


    '====================获取路径名各部分:  如： c:\dir1001\aaa.txt

    Public Shared Function GetFileName(FilePathFileName As String) As String   '获取文件名  aaa.txt
        On Error Resume Next
        Dim i As Integer, j As Integer
        i = Len(FilePathFileName)
        j = InStrRev(FilePathFileName, "\")
        Return Mid(FilePathFileName, j + 1, i)
    End Function

    ''===========获取路径路径   c:\dir1001\
    Public Shared Function GetFilePath(FilePathFileName As String) As String '获取路径路径   c:\dir1001\
        On Error Resume Next
        Dim j As Integer
        j = InStrRev(FilePathFileName, "\")
        Return Mid(FilePathFileName, 1, j)
    End Function

    '===========获取文件名但不包括扩展名  aaa
    Public Shared Function GetFileNameNoExt(FilePathFileName As String) As String  '获取文件名但不包括扩展名  aaa
        On Error Resume Next
        Dim i As Integer, j As Integer, k As Integer
        i = Len(FilePathFileName)
        j = InStrRev(FilePathFileName, "\")
        k = InStrRev(FilePathFileName, ".")
        If k = 0 Then
            Return Mid(FilePathFileName, j + 1, i - j)
        Else
            Return Mid(FilePathFileName, j + 1, k - j - 1)
        End If

    End Function


End Class
