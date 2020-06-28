Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Public Class Chao_HscrollBar
    Private myValue As Single = 0
    Private myButtonColor As Color = Color.LightGray
    Private myArrowColor As Color = Color.White
    Private myScrollBarColor As Color = Color.Gray
    Private myMaximum As Single = 100
    Private myMinimum As Single = 0
    Private mySmallChange As Single = 1
    Private myLargeChange As Single = 10


    Public Event ValueChanged As PropertyChangedEventHandler






#Region "不可见属性"
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
    Public Overloads Property Font As Font
    <Browsable(False)>
    Public Overloads Property Margin As Padding
    '----------------设置属性不可见-----------------
#End Region

#Region "可见属性"

    <Description("上下箭头的颜色"), Category("Appearance"), Browsable(True)>
    Public Property ArrowColor() As Color
        Get
            Return myArrowColor
        End Get
        Set(ByVal value As Color)
            myArrowColor = value
            Invalidate()
        End Set
    End Property


    <Description("上下按钮的颜色"), Category("Appearance"), Browsable(True)>
    Public Property ButtonColor() As Color
        Get
            Return myButtonColor
        End Get
        Set(ByVal value As Color)
            myButtonColor = value
            Invalidate()
        End Set
    End Property



    <Description("滚动滑块颜色"), Category("Appearance"), Browsable(True)>
    Public Property ScrollBarColor() As Color
        Get
            Return myScrollBarColor
        End Get
        Set(ByVal value As Color)
            myScrollBarColor = value
            Invalidate()
        End Set
    End Property



    <Description("滚动滑块位置表示的值"), Category("Data"), Browsable(True)>
    Public Property Value() As Single
        Get
            Return myValue
        End Get
        Set(ByVal value As Single)
            If value > Maximum Then
                value = Maximum
            ElseIf value < Minimum Then
                value = Minimum
            End If

            myValue = value
            Invalidate()
            'RaiseEvent HscrollBar_Scroll(Me, New ScrollEventArgs(ScrollEventType.ThumbPosition, value))
            RaiseEvent ValueChanged(Me, New PropertyChangedEventArgs("ValueChanged"))
        End Set
    End Property

    <Description("最大值"), Category("Data"), Browsable(True)>
    Public Property Maximum() As Single
        Get
            Return myMaximum
        End Get
        Set(ByVal value As Single)
            If value > 1000 Then
                value = 1000
            ElseIf value < 0 Then
                value = 1
            End If
            myMaximum = value
            Invalidate()
        End Set
    End Property

    <Description("最小值"), Category("Data"), Browsable(True)>
    Public Property Minimum() As Single
        Get
            Return myMinimum
        End Get
        Set(ByVal value As Single)
            If value < 0 Or value >= Maximum Then
                value = 0
            End If
            myMinimum = value
            Invalidate()
        End Set
    End Property

    <Description("点击按钮或按箭头按键时，上下滚动的幅度"), Category("Data"), Browsable(True)>
    Public Property SmallChange() As Single
        Get
            Return mySmallChange
        End Get
        Set(ByVal value As Single)
            If value >= Maximum Or value <= 0 Then
                value = LargeChange / 10
            End If
            mySmallChange = value
            Invalidate()
        End Set
    End Property

    <Description("点击滚动框或者Page Up、Page Down，滑块变动的幅度"), Category("Data"), Browsable(True)>
    Public Property LargeChange() As Single
        Get
            Return myLargeChange
        End Get
        Set(ByVal value As Single)
            If value >= Maximum Or value <= 0 Then
                value = Maximum / 2
            End If
            myLargeChange = value
            Invalidate()
        End Set
    End Property
#End Region
    Private Sub Chao_HscrollBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub Chao_HscrollBar_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
    '    If e.Delta < 0 Then
    '        Me.Value += LargeChange
    '    Else
    '        Me.Value -= LargeChange
    '    End If
    'End Sub
End Class

