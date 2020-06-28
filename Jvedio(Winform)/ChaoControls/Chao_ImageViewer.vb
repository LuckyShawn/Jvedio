Imports System.ComponentModel
Imports System.Collections.ObjectModel
Public Class Chao_ImageViewer

    Private myImageList As Image()




#Region "不可见属性"
    <Browsable(False)>
    Public Overloads Property BackColor As Color
    <Browsable(False)>
    Public Overloads Property Font As Font
    <Browsable(False)>
    Public Overrides Property Text As String
    <Browsable(False)>
    Public Overrides Property ForeColor As Color
    <Browsable(False)>
    Public Overloads Property RightToLeft As Boolean
    <Browsable(False)>
    Public Overloads Property Padding As Padding
    <Browsable(False)>
    Public Overloads Property AccessibleDescription As String
    <Browsable(False)>
    Public Overloads Property AccessibleRole As String
    <Browsable(False)>
    Public Overloads Property AccessibleName As String
    <Browsable(False)>
    Public Overloads Property ImeMode As ImeMode
    <Browsable(False)>
    Public Overrides Property ContextMenuStrip As ContextMenuStrip
    <Browsable(False)>
    Public Overrides Property Dock As DockStyle
    <Browsable(False)>
    Public Overrides Property MinimumSize As Size
    <Browsable(False)>
    Public Overrides Property MaximumSize As Size
    <Browsable(False)>
    Public Overrides Property BackgroundImage As Image
    <Browsable(False)>
    Public Overrides Property BackgroundImageLayout As ImageLayout
    <Browsable(False)>
    Public Overrides Property AutoSize As Boolean
    <Browsable(False)>
    Public Overrides Property AutoScroll As Boolean
    <Browsable(False)>
    Public Overloads Property AutoScrollMargin As Size
    <Browsable(False)>
    Public Overloads Property AutoScrollMinSize As Size
    <Browsable(False)>
    Public Overloads Property AutoSizeMode As AutoSizeMode
    <Browsable(False)>
    Public Overloads Property BorderStyle As BorderStyle
    <Browsable(False)>
    Public Overloads Property Margin As Padding
    '----------------设置属性不可见-----------------
#End Region

#Region "可见属性"


    '<Description("图像位置"), Category("Appearance"), Browsable(True), TypeConverter(GetType(ButtonShapeStringConverter))>    '继承自StringConverter
    'Public Property ButtonShape As String
    '    Get
    '        Return myButtonShape
    '    End Get
    '    Set(value As String)
    '        myButtonShape = value
    '        Invalidate()
    '    End Set

    'End Property

    '<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    <Description("插入图像"), Category("Appearance"), Browsable(True)>
    Public Property ImageList As Image()
        Get
            Return myImageList
        End Get
        Set(value As Image())
            myImageList = value
            Invalidate()
        End Set

    End Property

    '<Description("图像位置"), Category("Appearance"), Browsable(True), TypeConverter(GetType(ImagePositionStringConverter))> '继承自StringConverter
    'Public Property ImagePosition As String
    '    Get
    '        Return myImagePosition
    '    End Get
    '    Set(value As String)
    '        myImagePosition = value
    '        Invalidate()
    '    End Set

    'End Property



    '<Description("背景颜色"), Category("Appearance"), Browsable(True)>
    'Public Property ButtonBackColor As Color
    '    Get
    '        Return myButtonBackColor
    '    End Get
    '    Set(value As Color)
    '        myButtonBackColor = value
    '        Invalidate()
    '    End Set

    'End Property

    '<Description("文本"), Category("Appearance"), Browsable(True)>
    'Public Property ButtonFont As Font
    '    Get
    '        Return myButtonFont
    '    End Get
    '    Set(value As Font)
    '        myButtonFont = value
    '        Invalidate()
    '    End Set

    'End Property

    '<Description("文本"), Category("Appearance"), Browsable(True)>
    'Public Property ButtonText As String
    '    Get
    '        Return myButtonText
    '    End Get
    '    Set(value As String)
    '        myButtonText = value
    '        Invalidate()
    '    End Set

    'End Property

    '<Description("边框颜色"), Category("Appearance"), Browsable(True)>
    'Public Property BorderColor As Color
    '    Get
    '        Return myBorderColor
    '    End Get
    '    Set(value As Color)
    '        myBorderColor = value
    '        Invalidate()
    '    End Set

    'End Property

    '<Description("字体颜色"), Category("Appearance"), Browsable(True)>
    'Public Property TextColor As Color
    '    Get
    '        Return myTextColor
    '    End Get
    '    Set(value As Color)
    '        myTextColor = value
    '        Invalidate()
    '    End Set

    'End Property

    '<Description("按钮颜色"), Category("Appearance"), Browsable(True)>
    'Public Property ButtonColor As Color
    '    Get
    '        Return myButtonColor
    '    End Get
    '    Set(value As Color)
    '        myButtonColor = value
    '        Invalidate()
    '    End Set

    'End Property

    '<Description("按钮类型"), Category("Appearance"), Browsable(True), TypeConverter(GetType(ButtonTypeStringConverter))> '继承自StringConverter
    'Public Property ButtonType As String
    '    Get
    '        Return myButtonType
    '    End Get
    '    Set(value As String)
    '        myButtonType = value
    '        Invalidate()
    '    End Set

    'End Property
#End Region



    Private Sub Chao_ImageViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
