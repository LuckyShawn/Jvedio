Imports System.Drawing.Drawing2D
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chao_HscrollBar
    Inherits System.Windows.Forms.UserControl

    Private Button1Color As Color
    Private Button2Color As Color
    Private BarColor1 As Color
    Private BarDragMode As Boolean = False
    Private BeforeChangeX As Single
    Private BeforeChangeValue As Single

    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub



    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        With Me
            .MaximumSize = New Size(0, 80)
            .MinimumSize = New Size(20, 20)
            .Value = 50
            .Cursor = Cursors.Hand
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.ResizeRedraw, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        End With
        Button1Color = ButtonColor
        Button2Color = ButtonColor
        BarColor1 = ScrollBarColor
        Invalidate()
    End Sub



    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.DrawImage(Draw, 0, 0)
    End Sub



    Public Function Draw() As Bitmap
        Dim bmp As Bitmap = New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics
        g = Graphics.FromImage(bmp)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(Me.BackColor)
        Dim w As Single = CType(Me.Width, Single)
        Dim h As Single = CType(Me.Height, Single)
        Dim r As Single = h / 2
        '画左按钮
        Dim ButtonLeftPath As New GraphicsPath
        With ButtonLeftPath '这里得 -1 不然会有部分画不出来
            .AddLine(-1, -1, -1, h)
            .AddLine(-1, h, h, h)
            .AddArc(r, -1, h, h, 90, 180)
            .CloseFigure()
        End With
        'g.DrawPath(New Pen(Color.Red, 3), ButtonLeftPath)
        g.FillPath(New SolidBrush(Button1Color), ButtonLeftPath)

        '画左箭头
        Dim ArrowLeftPath As New GraphicsPath
        With ArrowLeftPath
            .AddLine(h / 8, h / 2, h * 3 / 8, h * 3 / 4)
            .AddLine(h * 3 / 8, h * 3 / 4, h * 3 / 8, h / 4)
            .CloseFigure()
        End With
        g.FillPath(New SolidBrush(ArrowColor), ArrowLeftPath)

        '画右按钮
        Dim ButtonRightPath As New GraphicsPath
        With ButtonRightPath '这里得 -1 不然会有部分画不出来
            .AddLine(w, h, w, -1)
            .AddLine(w, -1, w, -1)
            .AddArc(w - (h + r), -1, h + 1, h + 1, 270, 180)
            .CloseFigure()
        End With
        g.FillPath(New SolidBrush(Button2Color), ButtonRightPath)

        '画右箭头
        Dim ArrowRightPath As New GraphicsPath
        With ArrowRightPath
            .AddLine(w - h * 3 / 8, h / 4, w - h * 3 / 8, h * 3 / 4)
            .AddLine(w - h * 3 / 8, h * 3 / 4, w - h / 8, h / 2)
            .CloseFigure()
        End With
        g.FillPath(New SolidBrush(ArrowColor), ArrowRightPath)

        '画滑块
        Dim BH As Single = (LargeChange * (w - 2 * (r + 2))) / (Maximum - Minimum + LargeChange)
        Dim r1 As Single = r - 2
        Dim y As Single = BH * (Value - Minimum) / LargeChange
        Dim BarPath As New System.Drawing.Drawing2D.GraphicsPath
        With BarPath
            .AddArc(y + r + 2, 1, 2 * r1 + 1, 2 * r1 + 1, 90, 180)
            .AddLine(y + r + 2 + r1, 1, y + BH + r + 2 - r1, 1)
            .AddArc(y + BH + r + 2 - 2 * r1, 1, 2 * r1 + 1, 2 * r1 + 1, 270, 180)
            .CloseFigure()
        End With
        'g.DrawPath(New Pen(Color.Red, 1), BarPath)
        g.FillPath(New SolidBrush(BarColor1), BarPath)

        g.Dispose()
        Return bmp
    End Function

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        BarDragMode = False
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        Dim w As Single = CType(Me.Width, Single)
        Dim h As Single = CType(Me.Height, Single)
        Dim r As Single = h / 2
        '按下左按钮
        Dim ButtonLeftPath As New GraphicsPath
        With ButtonLeftPath '这里得 -1 不然会有部分画不出来
            .AddLine(-1, -1, -1, h)
            .AddLine(-1, h, h, h)
            .AddArc(r, -1, h, h, 90, 180)
            .CloseFigure()
        End With
        Dim ButtonLeftRegion As New Region(ButtonLeftPath)
        If ButtonLeftRegion.IsVisible(New Point(e.X, e.Y)) Then
            If Value <= Minimum Then
                Value = Minimum
            Else
                Value -= SmallChange
            End If
        End If

        '按下右按钮
        Dim ButtonRightPath As New GraphicsPath
        With ButtonRightPath '这里得 -1 不然会有部分画不出来
            .AddLine(w, h, w, -1)
            .AddLine(w, -1, w, -1)
            .AddArc(w - (h + r), -1, h + 1, h + 1, 270, 180)
            .CloseFigure()
        End With
        Dim ButtonRightRegion As New Region(ButtonRightPath)
        If ButtonRightRegion.IsVisible(New Point(e.X, e.Y)) Then
            If Value >= Maximum Then
                Value = Maximum
            Else
                Value += SmallChange
            End If
        End If
        Invalidate()

        '按住滑块
        Dim BH As Single = (LargeChange * (w - 2 * (r + 2))) / (Maximum - Minimum + LargeChange)
        Dim r1 As Single = r - 2
        Dim y As Single = BH * (Value - Minimum) / LargeChange
        Dim BarPath As New System.Drawing.Drawing2D.GraphicsPath
        With BarPath
            .AddArc(y + r + 2, 1, 2 * r1 + 1, 2 * r1 + 1, 90, 180)
            .AddLine(y + r + 2 + r1, 2, y + BH + r + 2 - r1, 2)
            .AddArc(y + BH + r + 2 - 2 * r1, 1, 2 * r1 + 1, 2 * r1 + 1, 270, 180)
            .CloseFigure()
        End With
        Dim BarRegion As New Region(BarPath)
        If BarRegion.IsVisible(New Point(e.X, e.Y)) Then
            BarDragMode = True
            BeforeChangeX = e.X
            BeforeChangeValue = Value
            'Debug.Print("拖拽")
        Else
            BarDragMode = False
        End If


        Dim k As Single = (w - BH - 2 * (r + 2)) / (Maximum - Minimum)
        '点击左边区域
        Dim VoidLeftPath As New System.Drawing.Drawing2D.GraphicsPath
        With VoidLeftPath
            .AddLine(h, h, h + Value * k, h)
            .AddArc(r + Value * k, 0, h, h - 1, 90, 180)
            .AddLine(h + Value * k, 0, h, 0)
            .AddArc(r, 0, h, h, 90, 180)
        End With

        Dim VoidLeftRegion As New Region(VoidLeftPath)
        If VoidLeftRegion.IsVisible(New Point(e.X, e.Y)) Then
            If Value <= Minimum Then
                Value = Minimum
            Else
                Value -= LargeChange
            End If
        End If


        '点击右边区域
        Dim VoidRightPath As New System.Drawing.Drawing2D.GraphicsPath
        With VoidRightPath
            .AddLine(w - h, 0, Value * k + BH, 0)
            .AddArc(Value * k + BH - r + 2, 0, h, h, 270, 180)
            .AddLine(Value * k + BH, h, w - h, h)
            .AddArc(w - h - r, 0, h, h, 270, 180)
        End With
        Dim VoidRightRegion As New Region(VoidRightPath)
        If VoidRightRegion.IsVisible(New Point(e.X, e.Y)) Then
            If Value >= Maximum Then
                Value = Maximum
            Else
                Value += LargeChange
            End If
        End If


    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        Dim w As Single = CType(Me.Width, Single)
        Dim h As Single = CType(Me.Height, Single)
        Dim r As Single = h / 2

        '左按钮
        Dim ButtonLeftPath As New GraphicsPath
        With ButtonLeftPath '这里得 -1 不然会有部分画不出来
            .AddLine(-1, -1, -1, h)
            .AddLine(-1, h, h, h)
            .AddArc(r, -1, h, h, 90, 180)
            .CloseFigure()
        End With
        Dim ButtonLeftRegion As New Region(ButtonLeftPath)
        If ButtonLeftRegion.IsVisible(New Point(e.X, e.Y)) Then
            Button1Color = GetRelativeColor(ButtonColor, -40)
        Else
            Button1Color = ButtonColor
        End If

        '右按钮
        Dim ButtonRightPath As New GraphicsPath
        With ButtonRightPath '这里得 -1 不然会有部分画不出来
            .AddLine(w, h, w, -1)
            .AddLine(w, -1, w, -1)
            .AddArc(w - (h + r), -1, h + 1, h + 1, 270, 180)
            .CloseFigure()
        End With
        Dim ButtonRightRegion As New Region(ButtonRightPath)
        If ButtonRightRegion.IsVisible(New Point(e.X, e.Y)) Then
            Button2Color = GetRelativeColor(ButtonColor, -40)
        Else
            Button2Color = ButtonColor
        End If

        '滑块
        Dim BH As Single = (LargeChange * (w - 2 * (r + 2))) / (Maximum - Minimum + LargeChange)
        Dim r1 As Single = r - 2
        Dim y As Single = BH * (Value - Minimum) / LargeChange
        Dim BarPath As New System.Drawing.Drawing2D.GraphicsPath
        With BarPath
            .AddArc(y + r + 2, 1, 2 * r1 + 1, 2 * r1 + 1, 90, 180)
            .AddLine(y + r + 2 + r1, 2, y + BH + r + 2 - r1, 2)
            .AddArc(y + BH + r + 2 - 2 * r1, 1, 2 * r1 + 1, 2 * r1 + 1, 270, 180)
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
            Dim k As Single = (w - BH - 2 * (r + 2)) / (Maximum - Minimum)
            Value = (e.X - BeforeChangeX) / k + BeforeChangeValue
            'Debug.Print(Value)
        End If

        '画一个暗色的圆
        'DarkPosition = New PointF(e.X, e.Y)

        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        Button1Color = ButtonColor
        Button2Color = ButtonColor
        BarColor1 = ScrollBarColor
        'DarkPosition = New Point(-1000.0F, -1000.0F)
        Invalidate()
    End Sub




    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Chao_HscrollBar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Name = "Chao_HscrollBar"
        Me.Size = New System.Drawing.Size(1114, 77)
        Me.ResumeLayout(False)

    End Sub
End Class
