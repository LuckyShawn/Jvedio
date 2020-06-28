Imports System.ComponentModel
<DefaultEvent("Click")>
Public Class Chao_TabSelectorBar
    Private myBaseTabControl As TabControl
    Private myTabFont As Font = New Font("微软雅黑", 12)
    Private myTabForeColor As Color = Color.Black
    Private myTabBackColor As Color = Color.White
    Private myTabSelectedForeColor As Color = Color.FromArgb(110, 20, 239)
    Private myIndex As Integer = 0
    Private mySlideColor As Color = Color.FromArgb(98, 0, 238)
    Private mySlideHeight As Single = 2.0F
    Private myTabImageList As ImageList
    Private myImageDrawStyle As String = "Leading" 'Leading, Top

    Public Event BaseTabControlChanged As PropertyChangedEventHandler


#Region "不可见属性"
    <Browsable(False)>
    Public Overrides Property BackColor As Color
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
    Public Overloads Property Font As Font
    <Browsable(False)>
    Public Overrides Property ForeColor As Color
    '----------------设置属性不可见-----------------
#End Region

#Region "可见属性"

    <Description("图像位置"), Category("Appearance"), Browsable(True), TypeConverter(GetType(ImageDrawStyleStringConverter))>    '继承自StringConverter
    Public Property ImageDrawStyle As String
        Get
            Return myImageDrawStyle
        End Get
        Set(value As String)
            myImageDrawStyle = value
            Invalidate()
        End Set

    End Property

    <Description("设置图像"), Category("Data"), Browsable(True)>
    Public Property TabImageList() As ImageList
        Get
            Return myTabImageList
        End Get
        Set(ByVal value As ImageList)
            myTabImageList = value
            Invalidate()
        End Set
    End Property


    <Description("Index"), Category("Data"), Browsable(True)>
    Public Property Index() As Integer
        Get
            Return myIndex
        End Get
        Set(ByVal value As Integer)
            myIndex = value
            Invalidate()
        End Set
    End Property

    <Description("选择一个现有的TabControl"), Category("Data"), Browsable(True)>
    Public Property BaseTabControl() As TabControl
        Get
            Return myBaseTabControl
        End Get
        Set(ByVal value As TabControl)
            myBaseTabControl = value
            RaiseEvent BaseTabControlChanged(Me, New PropertyChangedEventArgs("BaseTabControl"))
            Invalidate()
        End Set
    End Property

    <Description("字体"), Category("Appearance"), Browsable(True)>
    Public Property TabFont() As Font
        Get
            Return myTabFont
        End Get
        Set(ByVal value As Font)
            '顺序不能错
            myTabFont = value
            Invalidate()
        End Set
    End Property

    <Description("滑块高度"), Category("Appearance"), Browsable(True)>
    Public Property SlideHeight() As Single
        Get
            Return mySlideHeight
        End Get
        Set(ByVal value As Single)
            mySlideHeight = value
            Invalidate()
        End Set
    End Property

    <Description("滑块颜色"), Category("Appearance"), Browsable(True)>
    Public Property SlideColor() As Color
        Get
            Return mySlideColor
        End Get
        Set(ByVal value As Color)
            mySlideColor = value
            Invalidate()
        End Set
    End Property

    <Description("字体背景颜色"), Category("Appearance"), Browsable(True)>
    Public Property TabBackColor() As Color
        Get
            Return myTabBackColor
        End Get
        Set(ByVal value As Color)
            myTabBackColor = value
            Invalidate()
        End Set
    End Property


    <Description("字体前景颜色"), Category("Appearance"), Browsable(True)>
    Public Property TabForeColor() As Color
        Get
            Return myTabForeColor
        End Get
        Set(ByVal value As Color)
            myTabForeColor = value
            Invalidate()
        End Set
    End Property

    <Description("字体选中后颜色"), Category("Appearance"), Browsable(True)>
    Public Property TabSelectedForeColor() As Color
        Get
            Return myTabSelectedForeColor
        End Get
        Set(ByVal value As Color)
            myTabSelectedForeColor = value
            Invalidate()
        End Set
    End Property
#End Region


    Private Sub Chao_TabSelectorBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If BaseTabControl IsNot Nothing Then
            Index = BaseTabControl.SelectedIndex
            TabCount = BaseTabControl.TabCount
            BarWidth = Me.Width / TabCount
            BeforeMouseDownIndex = Index
            AddHandler BaseTabControl.SelectedIndexChanged, AddressOf BaseTabControl_SelectedIndexChanged
            AddHandler BaseTabControl.ControlAdded, AddressOf BaseTabControl_ControlAdded
            AddHandler BaseTabControl.ControlRemoved, AddressOf BaseTabControl_ControlRemoved
            Invalidate()
        End If
    End Sub

    Private Sub Chao_TabSelectorBar_BaseTabControlChanged(sender As Object, e As PropertyChangedEventArgs) Handles Me.BaseTabControlChanged
        Index = BaseTabControl.SelectedIndex
        TabCount = BaseTabControl.TabCount
        If TabCount = 0 Then
            BarWidth = 0
        Else
            BarWidth = Me.Width / TabCount
        End If
        BeforeMouseDownIndex = Index
        AddHandler BaseTabControl.SelectedIndexChanged, AddressOf BaseTabControl_SelectedIndexChanged
        AddHandler BaseTabControl.ControlAdded, AddressOf BaseTabControl_ControlAdded
        AddHandler BaseTabControl.ControlRemoved, AddressOf BaseTabControl_ControlRemoved
        Me.Width = BaseTabControl.Width
        Invalidate()
    End Sub
End Class

Public Class ImageDrawStyleStringConverter
    Inherits StringConverter
    Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As StandardValuesCollection
        Return New StandardValuesCollection(New String() {"Leading", "Top"})
    End Function
    Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
        Return True ' 不能输入下拉属性以外的值
    End Function

End Class
