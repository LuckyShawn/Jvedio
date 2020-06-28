Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Public Class Identify
    ''' <summary>
    ''' 判断是步兵还是骑兵
    ''' </summary>
    ''' <param name="FileName"></param>
    ''' <returns></returns>
    Public Shared Function GetVedioType(FileName As String) As Integer
        '0  未识别
        '1  步兵
        '2  骑兵

        FileName = UCase(FileName)
        If InStr(FileName, "_") > 0 Then Return 1   '加勒比
        If InStr(FileName, "MKD-S") > 0 Or InStr(FileName, "MKBD-S") > 0 Then Return 1

        '进一步提取番号
        If InStr(FileName, "-") > 0 Then
            If IsNumeric(Split(FileName, "-")(0)) Then '一本道
                Return 1
            Else
                FileName = Split(FileName, "-")(0) '取得番号
            End If

        End If

        If GetFanhaoByRegExp(FileName, "(K|N)\d+") <> "" Then Return 1 'Tokyo-Hot

        '读取骑兵步兵列表
        If Not IO.File.Exists(Application.StartupPath & "\Data\Qibing.txt") Then Return 0

        Dim sr As IO.StreamReader = New IO.StreamReader(Application.StartupPath & "\Data\Qibing.txt")
        Dim QBTotal = Split(Replace(sr.ReadToEnd, "，", ","), ",")
        sr.Close()
        Dim Qibing As New List(Of String)
        For Each item In QBTotal
            If item <> "" And Len(item) > 0 Then Qibing.Add(item)
        Next

        If Qibing.Contains(FileName) Then Return 2

        '步兵
        Dim BubingFanhao As String = "SMDV,BT,CCDV,CWDV,CWP,CWPBD,CWPD,CYC,DRC,DRG,DRGBD,DSAM,DSAMBD,DSAMD,HEY,HEYDOUGA,HEYZO,KP,KSC,LAF,LAFBD,LLDV,MCBD,MKBD,MKD,MXX,NIP,PT,RED,RHJ,S2M,S2MBD,SKY,SKYHD,SMD,SSDV,SSKP,FC2PPV,FC2,GACHI"
        Dim Bubing As New List(Of String)
        For Each item In Split(Replace(BubingFanhao, "，", ","), ",")
            If item <> "" And Len(item) > 0 Then Bubing.Add(item)
        Next
        If Bubing.Contains(FileName) Then Return 1

        '剩下的如果还没匹配到
        If GetFanhaoByRegExp(FileName, "[A-Z][A-Z]+") <> "" Then Return 2 Else Return 0
    End Function




    Public Shared Function GetFanhaoByRegExp(SourceName As String, myPattern As String) As String
        Dim mc As MatchCollection = Regex.Matches(SourceName, myPattern)
        If mc.Count > 0 Then Return mc(0).Value Else Return ""
    End Function

    '判断NXXXX的N前面是否有英文
    Public Shared Function JudgeEnglishExist(str1 As String, str2 As String) As Boolean
        Dim snum As Integer
        snum = InStr(1, str1, str2)
        If snum > 1 Then
            If (Mid(str1, snum - 1, 1) < "z" And Mid(str1, snum - 1, 1) > "a") Or (Mid(str1, snum - 1, 1) < "Z" And Mid(str1, snum - 1, 1) > "A") Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' 从路径中提取出番号
    ''' </summary>
    ''' <param name="path"></param>
    ''' <returns></returns>
    Public Shared Function GetFanhao(path As String) As String
        '骑兵的正则表达式
        '正则表达式：[A-Za-z]+-?\d\d+   识别到“任意长度英文-至少2个数字”其中-可有可无
        '正则表达式：T28,sqte

        '未解决
        'dioguitar23.net_SMD-124.mp4
        'xiaose9831@第一会所@SKY-227.avi
        'MKD-S
        Dim result = ""
        If path = "" Then Return ""
        Dim stt As String
        If InStr(1, UCase(path), "T28") > 0 Then
            stt = UCase(GetFanhaoByRegExp(path, "T28-?\d\d+"))
            If InStr(1, stt, "-") > 0 Then
                result = stt
            ElseIf Len(stt) > 0 Then
                result = "T28-" & Mid(stt, 4, Len(stt) - 1)
            End If
        ElseIf InStr(1, path, "sqte") > 0 Then
            result = UCase(GetFanhaoByRegExp(path, "sqte-?\d\d+"))
            '步兵的正则表达式
        ElseIf InStr(1, UCase(path), "HEYZO") > 0 Then     'HEYZO
            stt = Replace(GetFanhaoByRegExp(LCase(path), "heyzo\s?\)?\(?_?(hd|lt)?\+?-?_?\d\d+"), "hd", "")
            stt = Replace(stt, "lt", "")
            result = AddGang(UCase((stt)))
        ElseIf InStr(1, UCase(path), "HEYDOUGA") > 0 Then      'HEYDOUGA
            result = UCase(GetFanhaoByRegExp(LCase(path), "heydouga_?-?\d\d+"))
        ElseIf InStr(1, UCase(path), "FC2") > 0 Then      'FC2PPV
            stt = UCase(GetFanhaoByRegExp(LCase(path), "\d{5,}"))
            If stt <> "" Then
                result = "FC2PPV-" & stt
            Else
                result = stt
            End If
        ElseIf InStr(1, UCase(path), "MKD-S") > 0 Then      'MKD-S
            result = UCase(GetFanhaoByRegExp(LCase(path), "mkd-s\d\d+"))
        ElseIf InStr(1, UCase(path), "MKBD-S") > 0 Then      'MKBD-S
            result = UCase(GetFanhaoByRegExp(LCase(path), "mkbd-s\d\d+"))
        ElseIf InStr(1, UCase(path), "S2M") > 0 Then      's2m
            result = UCase(GetFanhaoByRegExp(LCase(path), "s2m-?\d\d+"))
        ElseIf InStr(1, UCase(path), "S2MBD") > 0 Then      's2mbd
            result = UCase(GetFanhaoByRegExp(LCase(path), "s2mbd-?\d\d+"))
        ElseIf InStr(1, UCase(path), "S2MCR") > 0 Then      's2mcr
            result = UCase(GetFanhaoByRegExp(LCase(path), "s2mcr-?\d\d+"))
        ElseIf Len(GetFanhaoByRegExp(path, "\d{5,}(_|-)\d\d+")) > 0 Then        '加勒比，缺点，如果有时间如2012-01就会提取出时间
            result = UCase(GetFanhaoByRegExp(path, "\d{5,}(_|-)\d\d+"))
        ElseIf Len(GetFanhaoByRegExp(path, "(k|n)_?\d\d+")) > 0 Then  'Tokyo-Hot
            stt = GetFanhaoByRegExp(path, "(k|n)_?\d\d+")
            If JudgeEnglishExist(path, stt) = False Then
                result = UCase(stt)
            Else
                result = AddGang(UCase(GetFanhaoByRegExp(path, "[A-Za-z][A-Za-z]+-?\d\d+")))
            End If
        Else        '类骑兵
            result = AddGang(UCase(GetFanhaoByRegExp(path, "[A-Za-z][A-Za-z]+-?\d\d+"))) '缺点：匹配不到C-1023
        End If
        Return result
    End Function

    '添加"-"
    Shared Function AddGang(tFh As String) As String
        'red番号在javbus格式如下
        '有码：red-000
        '无码：red000
        If InStr(1, tFh, "-") > 0 Then
            Return tFh
        ElseIf tFh <> "" Then
            Return GetFanhaoByRegExp(tFh, "[A-Z]+") & "-" & GetFanhaoByRegExp(tFh, "\d+")
        Else
            Return ""
        End If
    End Function
End Class
