Imports System.ComponentModel
Imports System.Configuration

Module Module_Settings


    Public WithEvents Settings As New FormSettings
    NotInheritable Class FormSettings
        Inherits ApplicationSettingsBase

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("0")>
        Public Property SkipCondition() As Integer
            Get
                Return CType(Me("SkipCondition"), Integer)
            End Get
            Set(ByVal value As Integer)
                Me("SkipCondition") = value
            End Set
        End Property



        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
        Public Property DownLoadToDatabase() As Boolean
            Get
                Return CType(Me("DownLoadToDatabase"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("DownLoadToDatabase") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
        Public Property DownLoadToNFO() As Boolean
            Get
                Return CType(Me("DownLoadToNFO"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("DownLoadToNFO") = value
            End Set
        End Property


        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("http://www.baidu.com[Split]username[Split]123456")>
        Public Property ProxyContent() As String
            Get
                Return CType(Me("ProxyContent"), String)
            End Get
            Set(ByVal value As String)
                Me("ProxyContent") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
        Public Property EnableProxy() As Boolean
            Get
                Return CType(Me("EnableProxy"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("EnableProxy") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("")>
        Public Property LVI() As String
            Get
                Return CType(Me("LVI"), String)
            End Get
            Set(ByVal value As String)
                Me("LVI") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("")>
        Public Property LVG() As String
            Get
                Return CType(Me("LVG"), String)
            End Get
            Set(ByVal value As String)
                Me("LVG") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property CloseToTaskbar() As Boolean
            Get
                Return CType(Me("CloseToTaskbar"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("CloseToTaskbar") = value
            End Set
        End Property


        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property Group() As Boolean
            Get
                Return CType(Me("Group"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("Group") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("5")>
        Public Property DownLoadTimeOut() As Integer
            Get
                Return CType(Me("DownLoadTimeOut"), Integer)
            End Get
            Set(ByVal value As Integer)
                Me("DownLoadTimeOut") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("100")>
        Public Property MaxDownLoadNum() As Integer
            Get
                Return CType(Me("MaxDownLoadNum"), Integer)
            End Get
            Set(ByVal value As Integer)
                Me("MaxDownLoadNum") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
        Public Property DownLoadActor() As Boolean
            Get
                Return CType(Me("DownLoadActor"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("DownLoadActor") = value
            End Set
        End Property


        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
        Public Property DownLoadFanart() As Boolean
            Get
                Return CType(Me("DownLoadFanart"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("DownLoadFanart") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("20")>
        Public Property LayoutNumber() As Integer
            Get
                Return CType(Me("LayoutNumber"), Integer)
            End Get
            Set(ByVal value As Integer)
                Me("LayoutNumber") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("http://www.hitchao.cn")>
        Public Property FCWebSite() As String
            Get
                Return CType(Me("FCWebSite"), String)
            End Get
            Set(ByVal value As String)
                Me("FCWebSite") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("http://www.hitchao.cn")>
        Public Property BusWebSite() As String
            Get
                Return CType(Me("BusWebSite"), String)
            End Get
            Set(ByVal value As String)
                Me("BusWebSite") = value
            End Set
        End Property


        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("http://www.hitchao.cn")>
        Public Property DBWebSite() As String
            Get
                Return CType(Me("DBWebSite"), String)
            End Get
            Set(ByVal value As String)
                Me("DBWebSite") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
        Public Property CreateFanhaoFile() As Boolean
            Get
                Return CType(Me("CreateFanhaoFile"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("CreateFanhaoFile") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
        Public Property FallLayout() As Boolean
            Get
                Return CType(Me("FallLayout"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("FallLayout") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property MainFormShowPicExistOnly() As Boolean
            Get
                Return CType(Me("MainFormShowPicExistOnly"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("MainFormShowPicExistOnly") = value
            End Set
        End Property


        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property ShowDate() As Boolean
            Get
                Return CType(Me("ShowDate"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("ShowDate") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property ShowMingCheng() As Boolean
            Get
                Return CType(Me("ShowMingCheng"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("ShowMingCheng") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property ShowFanhao() As Boolean
            Get
                Return CType(Me("ShowFanhao"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("ShowFanhao") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property MainFormPicAutoSize() As Boolean
            Get
                Return CType(Me("MainFormPicAutoSize"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("MainFormPicAutoSize") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property MainFormPicClickShowBIgPic() As Boolean
            Get
                Return CType(Me("MainFormPicClickShowBIgPic"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("MainFormPicClickShowBIgPic") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property FixSideBar() As Boolean
            Get
                Return CType(Me("FixSideBar"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("FixSideBar") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property FixStatusBar() As Boolean
            Get
                Return CType(Me("FixStatusBar"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("FixStatusBar") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property CloseRightNow() As Boolean
            Get
                Return CType(Me("CloseRightNow"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("CloseRightNow") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("100,100,500,500")>
        Public Property BeforeMax() As Rectangle
            Get
                Return CType(Me("BeforeMax"), Rectangle)
            End Get
            Set(ByVal value As Rectangle)
                Me("BeforeMax") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("0,0")>
        Public Property FormLocation() As Point
            Get
                Return CType(Me("FormLocation"), Point)
            End Get
            Set(ByVal value As Point)
                Me("FormLocation") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("500, 500")>
        Public Property FormSize() As Size
            Get
                Return CType(Me("FormSize"), Size)
            End Get
            Set(ByVal value As Size)
                Me("FormSize") = value
            End Set
        End Property
    End Class

End Module
