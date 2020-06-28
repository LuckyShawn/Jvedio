Module Variable
    Public BubingFanhao As String = "SMDV,BT,CCDV,CWDV,CWP,CWPBD,CWPD,CYC,DRC,DRG,DRGBD,DSAM,DSAMBD,DSAMD,HEY,HEYDOUGA,HEYZO,KP,KSC,LAF,LAFBD,LLDV,MCBD,MKBD,MKD,MXX,NIP,PT,RED,RHJ,S2M,S2MBD,SKY,SKYHD,SMD,SSDV,SSKP,FC2PPV,FC2,GACHI"
    Public QibingFanhao As String
    Public Bubing As New List(Of String)
    Public Qibing As New List(Of String)
    Public Qibing_extra As New List(Of String)

    Public con_ConnectionString As String
    Public con_ConnectionString_read As String
    Public DataBaseSavePath As String
    Public GlobalFanhaoID As String
    Public DisPlayNum As Integer = 15
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
