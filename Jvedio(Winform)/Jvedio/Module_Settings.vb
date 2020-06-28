Imports System.ComponentModel
Imports System.Configuration

Module Module_Settings

    Public WithEvents Settings As New FormSettings


    NotInheritable Class FormSettings
        Inherits ApplicationSettingsBase

#Region "FormYanyuan"

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property YanyuanShowNum() As Boolean
            Get
                Return CType(Me("YanyuanShowNum"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("YanyuanShowNum") = value
            End Set
        End Property


        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("所有")>
        Public Property YanyuanType() As String
            Get
                Return CType(Me("YanyuanType"), String)
            End Get
            Set(ByVal value As String)
                Me("YanyuanType") = value
            End Set
        End Property


#End Region

#Region "FormLeibie"

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property LeibieShowNum() As Boolean
            Get
                Return CType(Me("LeibieShowNum"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("LeibieShowNum") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("所有")>
        Public Property LeibieType() As String
            Get
                Return CType(Me("LeibieType"), String)
            End Get
            Set(ByVal value As String)
                Me("LeibieType") = value
            End Set
        End Property


#End Region

#Region "Variable"
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property EditLove() As Boolean
            Get
                Return CType(Me("EditLove"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("EditLove") = value
            End Set
        End Property



        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property EditBiaoqian() As Boolean
            Get
                Return CType(Me("EditBiaoqian"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("EditBiaoqian") = value
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
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property EditSPLX() As Boolean
            Get
                Return CType(Me("EditSPLX"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("EditSPLX") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property SortDesc() As Boolean
            Get
                Return CType(Me("SortDesc"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("SortDesc") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("文件大小")>
        Public Property SortType() As String
            Get
                Return CType(Me("SortType"), String)
            End Get
            Set(ByVal value As String)
                Me("SortType") = value
            End Set
        End Property
#End Region



        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
        Public Property ShowPlay() As Boolean
            Get
                Return CType(Me("ShowPlay"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("ShowPlay") = value
            End Set
        End Property


        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("100")>
        Public Property Opacity() As Integer
            Get
                Return CType(Me("Opacity"), Integer)
            End Get
            Set(ByVal value As Integer)
                Me("Opacity") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("Black")>
        Public Property SkinStyle() As String
            Get
                Return CType(Me("SkinStyle"), String)
            End Get
            Set(ByVal value As String)
                Me("SkinStyle") = value
            End Set
        End Property


        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property ShowStamp() As Boolean
            Get
                Return CType(Me("ShowStamp"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("ShowStamp") = value
            End Set
        End Property


        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property ShowDefaultInfo() As Boolean
            Get
                Return CType(Me("ShowDefaultInfo"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("ShowDefaultInfo") = value
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
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
        Public Property FormMainShowBigPic() As Boolean
            Get
                Return CType(Me("FormMainShowBigPic"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("FormMainShowBigPic") = value
            End Set
        End Property


        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
        Public Property RandomLoad() As Boolean
            Get
                Return CType(Me("RandomLoad"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("RandomLoad") = value
            End Set
        End Property


        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
        Public Property SideBarExpand() As Boolean
            Get
                Return CType(Me("SideBarExpand"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("SideBarExpand") = value
            End Set
        End Property


        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property FunctionBar() As Boolean
            Get
                Return CType(Me("FunctionBar"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("FunctionBar") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("http://www.hitchao.cn")>
        Public Property LibWebSite() As String
            Get
                Return CType(Me("LibWebSite"), String)
            End Get
            Set(ByVal value As String)
                Me("LibWebSite") = value
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
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
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
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
        Public Property MainFormPicAutoSize() As Boolean
            Get
                Return CType(Me("MainFormPicAutoSize"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("MainFormPicAutoSize") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
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

    End Class

End Module
