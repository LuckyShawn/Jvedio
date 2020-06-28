Module Module_Variable

    Public DownLoadList As New List(Of String)
    Public DownLoadThread As Threading.Thread
    Public DownLoadThreadPause As Boolean = False
    Public DownLoadThreadCancel As Boolean = False
    Public DownloadThreadFrequency As Integer = 1500
    Public IsThreadRunning As Boolean = False
    Public FC2Running As Boolean = False
    Public BusRunning As Boolean = False


    Public Const FCFrequency As Integer = 2000
    Public Const BusFrequency As Integer = 1000
    Public Const WebClientFrequency As Integer = 1000
    Public GetSourceCodeFrequency As Integer = 1000

    Public DownLoadMsg As New List(Of String)

    Public DownLoadingList As New List(Of String)
    Public DownLoadedList As New List(Of String)


    Public DownLoadProxy As System.Net.WebProxy
    Public DownLoadtList As New List(Of String) '保证每次下载不重复
    Public InfoFanhaoList As New List(Of String)
    Public SmallPicDownLoadCompleted = False
    Public BigPicDownloadCompleted = True
    Public ExtrapicDownloadComplete = True
    Public IsSelectFromDatabase = False
    Public Panel_PicboxMouseEnter As Boolean = False
    Public BubingFanhao As String = "SMDV,BT,CCDV,CWDV,CWP,CWPBD,CWPD,CYC,DRC,DRG,DRGBD,DSAM,DSAMBD,DSAMD,HEY,HEYDOUGA,HEYZO,KP,KSC,LAF,LAFBD,LLDV,MCBD,MKBD,MKD,MXX,NIP,PT,RED,RHJ,S2M,S2MBD,SKY,SKYHD,SMD,SSDV,SSKP,FC2PPV,FC2,GACHI"
    Public QibingFanhao As String
    Public Bubing As New List(Of String)
    Public Qibing As New List(Of String)
    Public MaxWebClient As Integer = 30

    Public DownLoadNum As Integer = 0   '当前下载数目
    Public Const MaxDownLoadNum As Integer = 5 '全局下载数目
    Public PauseDownload As Boolean = False
    Public GlobalPause As Boolean = False

    Public HttpClientNum As Integer = 0
    Public Const MaxHttpClientNum As Integer = 3
    Public PauseHttpClient As Boolean = False

    Public Tasks As New List(Of Task)
    Public StopFormInfoDownLoad As Boolean = False
    Public GlobalFanhao As String

    Public BigPicSavePath As String
    Public SmallPicSavePath As String
    Public ActressesPicSavePath As String
    Public ExtraPicSavePath As String
    Public DataBaseSavePath As String
    Public con_ConnectionString As String
    Public con_ConnectionString_read As String

    Public Structure Vedio
        Dim title As String
        Dim director As String
        Dim rating As String
        Dim criticrating As String
        Dim year As String
        Dim mpaa As String
        Dim customrating As String
        Dim countrycode As String
        Dim premiered As String
        Dim release As String
        Dim runtime As String
        Dim country As String
        Dim studio As String
        Dim id As String
        Dim num As String
        Dim genre As String
        Dim tag As String
        Dim actor As String
        Dim actorthumb As String
        Dim fanart As String
        Dim fanart_s As String
        Dim Pic_S As String
        Dim Pic_B As String
    End Structure

    Public Structure VedioInfo
        Dim ID As Double
        Dim fanhao As String
        Dim mingcheng As String
        Dim wenjiandaxiao As Double
        Dim weizhi As String
        Dim shipinleixing As Integer
        Dim daorushijian As String
        Dim fangwencishu As Integer
        Dim faxingriqi As String
        Dim changdu As Integer
        Dim zhizuoshang As String
        Dim faxingshang As String
        Dim daoyan As String
        Dim leibie As String
        Dim yanyuan As String
        Dim xilie As String
        Dim love As Integer
        Dim biaoqian As String
    End Structure



End Module
