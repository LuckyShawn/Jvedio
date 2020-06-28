Module Module_Variable
    '-------------------DownLoad-------------------
    Public Const ExtraPicFrequency As Integer = 1000
    Public DownLoadProxy As System.Net.WebProxy
    '-------------------DownLoad-------------------




    Public InfoIDList As New List(Of Double)    '用于在 Info 窗口显示左右的列表

    Public SmallPicDownLoadCompleted = False
    Public BigPicDownloadCompleted = False
    Public ExtrapicDownloadComplete = False
    Public InfoDownloadCompleted = False

    Public IsSelectFromDatabase = False '判断是否正在读取并显示
    Public Panel_PicboxMouseEnter As Boolean = False
    'Public BubingFanhao As String = "SMDV,BT,CCDV,CWDV,CWP,CWPBD,CWPD,CYC,DRC,DRG,DRGBD,DSAM,DSAMBD,DSAMD,HEY,HEYDOUGA,HEYZO,KP,KSC,LAF,LAFBD,LLDV,MCBD,MKBD,MKD,MXX,NIP,PT,RED,RHJ,S2M,S2MBD,SKY,SKYHD,SMD,SSDV,SSKP,FC2PPV,FC2,GACHI"
    Public QibingFanhao As String
    Public Bubing As New List(Of String)
    Public Qibing As New List(Of String)

    Public DownLoadNum As Integer = 0   '当前下载数目
    Public Const MaxDownLoadNum As Integer = 5 '全局下载数目



    Public DownLoadList As New List(Of Panel)
    Public DownLoadThread As Threading.Thread
    Public DownLoadThreadPause As Boolean = False
    Public DownLoadThreadCancel As Boolean = False
    Public DownloadThreadFrequency As Integer = 1500
    Public IsThreadRunning As Boolean = False
    Public FC2Running As Boolean = False
    Public BusRunning As Boolean = False
    Public IsClosingFromInfo As Boolean = False
    Public FC2StartIndex As Integer = 0
    Public BusStartIndex As Integer = 0

    Public BigPicDownloadThread As New Threading.Thread(Sub()

                                                        End Sub)
    Public PauseDownload As Boolean = False


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
    'Public Structure VedioInfo
    '    Dim ID As Double
    '    Dim fanhao As String
    '    Dim mingcheng As String
    '    Dim wenjiandaxiao As Double
    '    Dim weizhi As String
    '    Dim shipinleixing As Integer
    '    Dim daorushijian As String
    '    Dim fangwencishu As Integer
    '    Dim faxingriqi As String
    '    Dim changdu As Integer
    '    Dim zhizuoshang As String
    '    Dim faxingshang As String
    '    Dim daoyan As String
    '    Dim leibie As String
    '    Dim yanyuan As String
    '    Dim xilie As String
    '    Dim love As Integer
    '    Dim biaoqian As String
    'End Structure


    Public myVersion As Double
    Public GlobalID As Double
    Public GlobalFanhao As String
    Public PaixuSql As String
    Public Clickindex As Integer = 10
    Public myLeibie As String
    Public myYanyuan As String
    Public myBiaoqian As String
    Public myFaxingshang As String
    Public myZhizuoshang As String
    Public myDaoyan As String
    Public myXilie As String
    Public mySearch As String
    Public myThreadIsCompleted(0) As Boolean
    Public myThreadNum As Integer
    Public MyThread(0) As System.Threading.Thread
    Public MyExtraPicThread(0) As System.Threading.Thread
    Public MySingleThread As System.Threading.Thread

    Public Dark_bgC As Color()
    Public Light_bgC As Color()
    Public Dark_FC As Color()
    Public Light_FC As Color()
    Public Blue_bgC As Color()
    Public Blue_FC As Color()
    Public global_Backcolor As Color()
    Public global_Forecolor As Color()
    Public mysql As String
    Public Leibie_click As String
    Public Yanyuan_click As String
    Public Biaoqian_click As String
    Public Cebianlan_click As String
    '1所有视频
    '2所有视频
    '3所有视频
    '4所有视频
    '5所有视频
    '10类别
    '11演员
    '12标签
    '13发行商
    '14制作商
    '15导演
    '16系列
    '20查找
    Public IsSmallPicAutoSize As Boolean
    Public IsCloseNow As Boolean '是否开启了夜间模式
    Public JavWebSite As String 'javbus网页
    Public JavLibrarySite As String 'JavLibrary网页
    Public BigPicSavePath As String
    Public SmallPicSavePath As String
    Public ActressesPicSavePath As String
    Public ExtraPicSavePath As String
    Public DataBaseSavePath As String
    Public con_ConnectionString As String
    Public con_ConnectionString_read As String
    Public Paixuleixing As String
    Public IsFanhaoShow As Boolean
    Public IsMingchengShow As Boolean
    Public IsRiqiShow As Boolean
    Public IsClickSmalPicShowBigPic As Boolean
    Public ColorZhuti As String
    Public showPictureOnly As Boolean

    Public LovePicBTemp As Object

    '初始窗体的位置和大小
    Public Me_X As Double
    Public Me_Y As Double
    Public Me_Width As Double
    Public Me_Height As Double
    Public NewItem As String
    Public ToolTipbtnName As String
    Public SmallPicFanhao As Font = New Font("微软雅黑", 12)
    Public SmallPicMingcheng As Font = New Font("微软雅黑", 12)
    Public SmallPicRiqi As Font = New Font("微软雅黑", 12)

    Public TotalNum As Int16
    '扫描设置
    Public Scan_Shipinleixing As String = "3g2,3gp,3gp2,3gpp,amr,amv,asf,avi,bdmv,bik,d2v,divx,drc,dsa,dsm,dss,dsv,evo,f4v,flc,fli,flic,flv,hdmov,ifo,ivf,m1v,m2p,m2t,m2ts,m2v,m4b,m4p,m4v,mkv,mp2v,mp4,mp4v,mpe,mpeg,mpg,mpls,mpv2,mpv4,mov,mts,ogm,ogv,pss,pva,qt,ram,ratdvd,rm,rmm,rmvb,roq,rpm,smil,smk,swf,tp,tpr,ts,vob,vp6,webm,wm,wmp,wmv"



    '其他
    Public myBitmap(0) As Bitmap '额外照片的image地址
    Public ExtraPicIndex As Integer
    Public zidingyiName As String
    Public SearchPattern As String()

    Public SmallFramePad As Single = 20
    Public EditMode As Boolean = False
    Public EditList As New List(Of Double)
End Module
