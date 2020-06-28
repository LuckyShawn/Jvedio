Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Public Class Chao_VscrollBar
    Private myValue As Single = 50
    Private myButtonColor As Color = Color.LightGray
    Private myArrowColor As Color = Color.White
    Private myScrollBarColor As Color = Color.Gray
    Private myMaximum As Single = 100
    Private myMinimum As Single = 0
    Private mySmallChange As Single = 1
    Private myLargeChange As Single = 10
    Private Button1Color As Color
    Private Button2Color As Color
    Private BarColor1 As Color
    Private BarDragMode As Boolean = False
    Private BeforeChangeY As Single
    Private BeforeChangeValue As Single

    Private Event VScrollBar_Scroll As ScrollEventHandler
    Public Event ValueChanged As PropertyChangedEventHandler






#Region "identifier_string"
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
#End Region '不可见属性
#Region "identifier_string"

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
            'RaiseEvent VScrollBar_Scroll(Me, New ScrollEventArgs(ScrollEventType.ThumbPosition, value))
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

    Private Sub Chao_VscrollBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .MaximumSize = New Size(80, 0)
            .MinimumSize = New Size(20, 20)
            '.Value = 0
            .Cursor = Cursors.Hand
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.ResizeRedraw, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        End With
        Button1Color = ButtonColor
        Button2Color = ButtonColor
        BarColor1 = ScrollBarColor
    End Sub

    Private Sub Chao_VscrollBar_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Dim w As Single = CType(Me.Width, Single)
        Dim h As Single = CType(Me.Height, Single)
        Dim r As Single = w / 2
        Dim ButtonDownPath As New GraphicsPath
        With ButtonDownPath '这里得 -1 不然会有部分画不出来
            .AddArc(0, h - (w + r), w - 1, w - 1, 0, 180)
            .AddLine(0, h - 1, 0, h - w)
            .AddLine(0, h - 1, w - 1, h - 1)
            .CloseFigure()
        End With
        Dim ButtonDownRegion As New Region(ButtonDownPath)
        If ButtonDownRegion.IsVisible(New Point(e.X, e.Y)) Then
            If Value >= Maximum Then
                Value = Maximum
            Else
                Value += SmallChange
            End If
        End If



        Dim ButtonUpPath As New GraphicsPath
        With ButtonUpPath '这里得 -1 不然会有部分画不出来
            .AddLine(0, 0, 0, w - 1)
            .AddArc(0, r, w - 1, w - 1, 180, 180)
            .AddLine(w - 1, w - 1, w - 1, 0)
        End With
        Dim ButtonUpRegion As New Region(ButtonUpPath)
        If ButtonUpRegion.IsVisible(New Point(e.X, e.Y)) Then
            If Value <= Minimum Then
                Value = Minimum
            Else
                Value -= SmallChange
            End If
        End If

        Invalidate()
        '按住滑块

        Dim BH As Single = (LargeChange * (h - 2 * (r + 2))) / (Maximum - Minimum + LargeChange)
        Dim r1 As Single = r - 2
        Dim y As Single = BH * (Value - Minimum) / LargeChange
        Dim BarPath As New System.Drawing.Drawing2D.GraphicsPath
        With BarPath
            .AddArc(2, y + r + 2, 2 * r1, 2 * r1, 180, 180)
            .AddLine(w - 2, y + r + 2 + r1, w - 2, y + BH + r + 2 - r1)
            .AddArc(2, y + BH + r + 2 - 2 * r1, 2 * r1, 2 * r1, 0, 180)
            .CloseFigure()
        End With
        Dim BarRegion As New Region(BarPath)
        If BarRegion.IsVisible(New Point(e.X, e.Y)) Then
            BarDragMode = True
            BeforeChangeY = e.Y
            BeforeChangeValue = Value
            'Debug.Print("拖拽")
        Else
            BarDragMode = False
        End If

        Dim k As Single = (h - BH - 2 * (r + 2)) / (Maximum - Minimum)
        '在上边区域
        Dim VoidUpPath As New System.Drawing.Drawing2D.GraphicsPath
        With VoidUpPath
            .AddLine(0, w, 0, w + Value * k)
            .AddArc(0, r + Value * k, w, w - 1, 180, 180)
            .AddLine(w, w + Value * k, w, w)
            .AddArc(0, r, w, w, 180, 180)
        End With
        Dim VoidUpRegion As New Region(VoidUpPath)
        If VoidUpRegion.IsVisible(New Point(e.X, e.Y)) Then
            If Value <= Minimum Then
                Value = Minimum
            Else
                Value -= LargeChange
            End If
        End If
        '在下边区域
        Dim VoidDownPath As New System.Drawing.Drawing2D.GraphicsPath
        With VoidDownPath
            .AddLine(w, Value * k + BH + r + 2, w, h - w)
            .AddArc(0, h - (w + r), w, w, 0, 180)
            .AddLine(0, h - w, 0, Value * k + BH + r + 2)
            .AddLine(0, Value * k + BH + r + 2, w, Value * k + BH + r + 2)
        End With
        Dim VoidDownRegion As New Region(VoidDownPath)
        If VoidDownRegion.IsVisible(New Point(e.X, e.Y)) Then
            If Value >= Maximum Then
                Value = Maximum
            Else
                Value += LargeChange
            End If
        End If


    End Sub

    Private Sub Chao_VscrollBar_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Button1Color = ButtonColor
        Button2Color = ButtonColor
        BarColor1 = ScrollBarColor
        'DarkPosition = New Point(-1000.0F, -1000.0F)
        Invalidate()
    End Sub

    Private Sub Chao_VscrollBar_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove



        Dim w As Single = CType(Me.Width, Single)
        Dim h As Single = CType(Me.Height, Single)
        Dim r As Single = w / 2
        Dim ButtonDownPath As New GraphicsPath
        With ButtonDownPath '这里得 -1 不然会有部分画不出来
            .AddArc(0, h - (w + r), w - 1, w - 1, 0, 180)
            .AddLine(0, h - 1, 0, h - w)
            .AddLine(0, h - 1, w - 1, h - 1)
            .CloseFigure()
        End With
        Dim ButtonDownRegion As New Region(ButtonDownPath)
        If ButtonDownRegion.IsVisible(New Point(e.X, e.Y)) Then
            Button2Color = GetRelativeColor(ButtonColor, -40)
        Else
            Button2Color = ButtonColor
        End If

        Dim ButtonUpPath As New GraphicsPath
        With ButtonUpPath '这里得 -1 不然会有部分画不出来
            .AddLine(0, 0, 0, w - 1)
            .AddArc(0, r, w - 1, w - 1, 180, 180)
            .AddLine(w - 1, w - 1, w - 1, 0)
        End With
        Dim ButtonUpRegion As New Region(ButtonUpPath)
        If ButtonUpRegion.IsVisible(New Point(e.X, e.Y)) Then
            Button1Color = GetRelativeColor(ButtonColor, -40)
        Else
            Button1Color = ButtonColor
        End If


        Dim BH As Single = (LargeChange * (h - 2 * (r + 2))) / (Maximum - Minimum + LargeChange)
        Dim r1 As Single = r - 2
        Dim y As Single = BH * (Value - Minimum) / LargeChange
        Dim BarPath As New System.Drawing.Drawing2D.GraphicsPath
        With BarPath
            .AddArc(2, y + r + 2, 2 * r1, 2 * r1, 180, 180)
            .AddLine(w - 2, y + r + 2 + r1, w - 2, y + BH + r + 2 - r1)
            .AddArc(2, y + BH + r + 2 - 2 * r1, 2 * r1, 2 * r1, 0, 180)
            .CloseFigure()
        End With
        Dim BarRegion As New Region(BarPath)
        If BarRegion.IsVisible(New Point(e.X, e.Y)) Then
            'Debug.Print(ScrollBarColor.ToArgb)
            BarColor1 = GetRelativeColor(ScrollBarColor, 20)
        Else
            BarColor1 = ScrollBarColor
        End If
        'Debug.Print(GetDarkColor(ScrollBarColor))

        '按住滑块
        If BarDragMode Then
            Dim k As Single = (h - BH - 2 * (r + 2)) / (Maximum - Minimum)
            Value = (e.Y - BeforeChangeY) / k + BeforeChangeValue
            'Debug.Print(Value)
        End If

        '画一个暗色的圆
        'DarkPosition = New PointF(e.X, e.Y)

        Invalidate()

    End Sub



    Private Sub Chao_VscrollBar_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        BarDragMode = False
    End Sub

    Private Sub Chao_VscrollBar_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta < 0 Then
            Me.Value += LargeChange
        Else
            Me.Value -= LargeChange
        End If
    End Sub
End Class

