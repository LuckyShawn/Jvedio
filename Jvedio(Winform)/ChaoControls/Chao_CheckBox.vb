Imports System.ComponentModel
<DefaultEvent("CheckedChanged")>
Public Class Chao_CheckBox
    Private myCheckedInBackColor As Color = Color.FromArgb(76, 217, 100)
    Private myCheckedInForeColor As Color = Color.White
    Private myChecked As Boolean = False
    Private myBorderWidth As Single = 2.0F
    Private myBorderColor As Color = Color.Black
    Private myFont As Font = New Font("微软雅黑", 12)
    Private myForeColor As Color = Color.Black
    Private myText As String = "CheckBox"

    Public Event CheckedChanged As PropertyChangedEventHandler

#Region "不可见属性"
    <Browsable(False)>
    Public Overloads Property Font As Font
    <Browsable(False)>
    Public Overloads Property ForeColor As Color

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
    '----------------设置属性不可见-----------------
#End Region

#Region "可见属性"

    <Description("文本"), Category("Appearance"), Browsable(True)>
    Public Property CheckText() As String
        Get
            Return myText
        End Get
        Set(ByVal value As String)
            myText = value
            Invalidate()
        End Set
    End Property

    <Description("字体颜色"), Category("Appearance"), Browsable(True)>
    Public Property CheckTextColor() As Color
        Get
            Return myForeColor
        End Get
        Set(ByVal value As Color)
            myForeColor = value
            Invalidate()
        End Set
    End Property


    <Description("字体"), Category("Appearance"), Browsable(True)>
    Public Property CheckTextFont() As Font
        Get
            Return myFont
        End Get
        Set(ByVal value As Font)
            myFont = value
            Invalidate()
        End Set
    End Property

    <Description("复选框边框粗细"), Category("Appearance"), Browsable(True)>
    Public Property BorderWidth() As Single
        Get
            Return myBorderWidth
        End Get
        Set(ByVal value As Single)
            myBorderWidth = value
            Invalidate()
        End Set
    End Property

    <Description("复选框边框颜色"), Category("Appearance"), Browsable(True)>
    Public Property BorderColor() As Color
        Get
            Return myBorderColor
        End Get
        Set(ByVal value As Color)
            myBorderColor = value
            Invalidate()
        End Set
    End Property


    <Description("是否选中"), Category("Data"), Browsable(True)>
    Public Property Checked() As Boolean
        Get
            Return myChecked
        End Get
        Set(ByVal value As Boolean)
            '顺序不能错
            myChecked = value
            Invalidate()
            '待修改：CheckedChanged中获取Checked不对
            RaiseEvent CheckedChanged(Me, New PropertyChangedEventArgs("Checked"))
        End Set
    End Property

    <Description("选中后底色的颜色"), Category("Appearance"), Browsable(True)>
    Public Property CheckedInBackColor() As Color
        Get
            Return myCheckedInBackColor
        End Get
        Set(ByVal value As Color)
            myCheckedInBackColor = value
            Invalidate()
        End Set
    End Property

    <Description("选中后对号的颜色"), Category("Appearance"), Browsable(True)>
    Public Property CheckedInForeColor() As Color
        Get
            Return myCheckedInForeColor
        End Get
        Set(ByVal value As Color)
            myCheckedInForeColor = value
            Invalidate()
        End Set
    End Property
#End Region
    Private Sub Chao_CheckBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
