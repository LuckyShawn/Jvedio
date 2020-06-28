Module New_Variable
    Public BubingFanhao As String = "SMDV,BT,CCDV,CWDV,CWP,CWPBD,CWPD,CYC,DRC,DRG,DRGBD,DSAM,DSAMBD,DSAMD,HEY,HEYDOUGA,HEYZO,KP,KSC,LAF,LAFBD,LLDV,MCBD,MKBD,MKD,MXX,NIP,PT,RED,RHJ,S2M,S2MBD,SKY,SKYHD,SMD,SSDV,SSKP,FC2PPV,FC2,GACHI"
    Public Scan_Shipinleixing As String = "3g2,3gp,3gp2,3gpp,amr,amv,asf,avi,bdmv,bik,d2v,divx,drc,dsa,dsm,dss,dsv,evo,f4v,flc,fli,flic,flv,hdmov,ifo,ivf,m1v,m2p,m2t,m2ts,m2v,m4b,m4p,m4v,mkv,mp2v,mp4,mp4v,mpe,mpeg,mpg,mpls,mpv2,mpv4,mov,mts,ogm,ogv,pss,pva,qt,ram,ratdvd,rm,rmm,rmvb,roq,rpm,smil,smk,swf,tp,tpr,ts,vob,vp6,webm,wm,wmp,wmv"
    Public DataBaseSavePath As String
    Public myChongfufanhaoIndex(0) As Integer
    Public CanImport As Boolean
    Public QibingFanhao As String
    Public Bubing As New List(Of String)
    Public Qibing As New List(Of String)
    Public Qibing_extra As New List(Of String)
    Public mySearchPattern As String()
    Public con_ConnectionString As String
    Public ChongFuFanhaoList As IEnumerable(Of ListViewItem)
    Public OpenPath As String
End Module
