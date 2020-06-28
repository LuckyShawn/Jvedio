Imports System.ComponentModel
'**************************************************************************************
'     * 创建时间：   2020.1.23
'     * 作        者：   https://github.com/hitchao
'     * 说        明：   
'     * 参        考：   UI设计参考自：https://material.io/components/buttons/buttons.html
'**************************************************************************************
<DefaultEvent("Click")>
Public Class Chao_Button
    Private myButtonBackColor As Color = DefaultBackColor
    Private myButtonFont As Font = New Font("微软雅黑", 12)
    Private myButtonType As String = "ContainedButton"  '三种按钮类型："ContainedButton", "OutlinedButton", "TextButton"
    Private myButtonColor As Color = Color.FromArgb(110, 20, 239)
    Private myTextColor As Color = Color.White
    Private myBorderColor As Color = Color.FromArgb(110, 20, 239)
    Private myButtonText As String = "Button" '默认居中
    Private myImage As Bitmap '设置了图像后，文字居中格式改变
    Private myImagePosition As String = "Left"   '三种图像对齐方式："Left", "Center", "Right"
    Private myButtonShape As String = "RoundedRectangle"  '三种按钮形状："Circle", "RoundedRectangle", "Rectangle"



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


    <Description("图像位置"), Category("Appearance"), Browsable(True), TypeConverter(GetType(ButtonShapeStringConverter))>    '继承自StringConverter
    Public Property ButtonShape As String
        Get
            Return myButtonShape
        End Get
        Set(value As String)
            myButtonShape = value
            Invalidate()
        End Set

    End Property

    <Description("插入图像"), Category("Appearance"), Browsable(True)>
    Public Property Image As Bitmap
        Get
            Return myImage
        End Get
        Set(value As Bitmap)
            myImage = value
            Invalidate()
        End Set

    End Property

    <Description("图像位置"), Category("Appearance"), Browsable(True), TypeConverter(GetType(ImagePositionStringConverter))> '继承自StringConverter
    Public Property ImagePosition As String
        Get
            Return myImagePosition
        End Get
        Set(value As String)
            myImagePosition = value
            Invalidate()
        End Set

    End Property



    <Description("背景颜色"), Category("Appearance"), Browsable(True)>
    Public Property ButtonBackColor As Color
        Get
            Return myButtonBackColor
        End Get
        Set(value As Color)
            myButtonBackColor = value
            Invalidate()
        End Set

    End Property

    <Description("文本"), Category("Appearance"), Browsable(True)>
    Public Property ButtonFont As Font
        Get
            Return myButtonFont
        End Get
        Set(value As Font)
            myButtonFont = value
            Invalidate()
        End Set

    End Property

    <Description("文本"), Category("Appearance"), Browsable(True)>
    Public Property ButtonText As String
        Get
            Return myButtonText
        End Get
        Set(value As String)
            myButtonText = value
            Invalidate()
        End Set

    End Property

    <Description("边框颜色"), Category("Appearance"), Browsable(True)>
    Public Property BorderColor As Color
        Get
            Return myBorderColor
        End Get
        Set(value As Color)
            myBorderColor = value
            Invalidate()
        End Set

    End Property

    <Description("字体颜色"), Category("Appearance"), Browsable(True)>
    Public Property TextColor As Color
        Get
            Return myTextColor
        End Get
        Set(value As Color)
            myTextColor = value
            Invalidate()
        End Set

    End Property

    <Description("按钮颜色"), Category("Appearance"), Browsable(True)>
    Public Property ButtonColor As Color
        Get
            Return myButtonColor
        End Get
        Set(value As Color)
            myButtonColor = value
            Invalidate()
        End Set

    End Property

    <Description("按钮类型"), Category("Appearance"), Browsable(True), TypeConverter(GetType(ButtonTypeStringConverter))> '继承自StringConverter
    Public Property ButtonType As String
        Get
            Return myButtonType
        End Get
        Set(value As String)
            myButtonType = value
            Invalidate()
        End Set

    End Property
#End Region

    Private Sub Chao_RoundButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MouseDownR += Me.Width / 16
        Invalidate()
        If MouseDownR > Math.Max(Me.Width, Me.Height) Then
            myMouseDown.IsMouseDown = False
            IsClicked = True
            Timer1.Enabled = False
            Invalidate()
        End If
    End Sub
End Class
Public Class ButtonTypeStringConverter
    Inherits StringConverter
    Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As StandardValuesCollection
        Return New StandardValuesCollection(New String() {"ContainedButton", "OutlinedButton", "TextButton"})
    End Function
    Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
        Return True ' 不能输入下拉属性以外的值
    End Function

End Class

Public Class ImagePositionStringConverter
    Inherits StringConverter
    Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As StandardValuesCollection
        Return New StandardValuesCollection(New String() {"Left", "Center", "Right"})
    End Function
    Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
        Return True ' 不能输入下拉属性以外的值
    End Function

End Class

Public Class ButtonShapeStringConverter
    Inherits StringConverter
    Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As StandardValuesCollection
        Return New StandardValuesCollection(New String() {"RoundedRectangle", "Rectangle", "Ellipse"})
    End Function
    Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
        Return True ' 不能输入下拉属性以外的值
    End Function

End Class



