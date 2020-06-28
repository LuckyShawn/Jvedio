Imports System.Drawing.Drawing2D

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chao_Sliders
    Inherits System.Windows.Forms.UserControl

    Private DragMode As Boolean = False
    Private myMouseDown As MD
    Private MouseDownR As Single = 0
    Private MouseDownTimer As New Timer With {.Interval = 1}
    Private MouseUpTimer As New Timer With {.Interval = 1}
    Private ButtonMoveTimer As New Timer With {.Interval = 1}
    Private ValueBefore As Single
    Private ValueAfter As Single
    Private DrawValue As Single

    Structure MD
        Dim Enabled As Boolean
        Dim X As Single
        Dim Y As Single
    End Structure

    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer


    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        With Me
            '防止闪烁
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.ResizeRedraw, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            '.MinimumSize = New Size(150, 90)
            .Cursor = Cursors.Hand
        End With
        DrawValue = Value
        AddHandler MouseDownTimer.Tick, AddressOf MouseDownTimer_Tick
        AddHandler MouseUpTimer.Tick, AddressOf MouseUpTimer_Tick
        AddHandler ButtonMoveTimer.Tick, AddressOf ButtonMoveTimer_Tick
    End Sub

    Sub ButtonMoveTimer_Tick()
        DrawValue += (ValueAfter - ValueBefore) / 20
        'Debug.Print(Value)
        If ValueAfter - ValueBefore > 0 Then
            If DrawValue >= ValueAfter Then
                DrawValue = ValueAfter
                'Value = DrawValue
                ButtonMoveTimer.Enabled = False
            End If
        Else
            If DrawValue <= ValueAfter Then
                DrawValue = ValueAfter
                'Value = DrawValue
                ButtonMoveTimer.Enabled = False
            End If
        End If
        Invalidate()
    End Sub
    Sub MouseUpTimer_Tick()
        MouseDownR -= Me.Height / 20
        If MouseDownR <= 0 Then
            MouseDownR = 0
            MouseUpTimer.Enabled = False
        End If
        Invalidate()
    End Sub

    Sub MouseDownTimer_Tick()
        MouseDownR += Me.Height / 20
        If MouseDownR >= Me.Height / 5 * 2 Then
            MouseDownTimer.Enabled = False
        End If
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        Dim h As Single = Me.Height
        Dim w As Single = Me.Width
        Dim r As Single = h / 20
        Dim Padding As Single = 12 * r
        Dim ButtonX As Single = Padding + (Value - Minimum) / (Maximum - Minimum) * (w - 2 * Padding)
        Dim r2 As Single = 4 * r
        MouseDownTimer.Enabled = False
        MouseUpTimer.Enabled = False
        ButtonMoveTimer.Enabled = False
        '按下按钮
        Dim ButtonRegion As New Region(New RectangleF(ButtonX - r2, h / 2 - r2, 2 * r2, 2 * r2))
        If ButtonRegion.IsVisible(New Point(e.X, e.Y)) Then
            myMouseDown.Enabled = True
            myMouseDown.X = e.X
            myMouseDown.Y = e.Y
            MouseDownR = 0
            'MouseDownTimer.Enabled = True
            DragMode = True
        End If

        '按下填充区域
        Dim BackRegion As New Region(New RectangleF(Padding, 0, w - 2 * Padding, h))
        Dim LeftRegion As New Region(New RectangleF(0, 0, Padding, Me.Height))
        Dim RightRegion As New Region(New RectangleF(Me.Width - Padding, 0, Padding, Me.Height))
        If BackRegion.IsVisible(New Point(e.X, e.Y)) Then
            ValueBefore = DrawValue
            ValueAfter = (e.X - Padding) / (w - 2 * Padding) * (Maximum - Minimum) + Minimum
            DrawValue = ValueAfter
            Invalidate()
        ElseIf LeftRegion.IsVisible(New Point(e.X, e.Y)) Then
            ValueBefore = DrawValue
            ValueAfter = 0
            DrawValue = ValueAfter
            Invalidate()
        ElseIf RightRegion.IsVisible(New Point(e.X, e.Y)) Then
            ValueBefore = DrawValue
            ValueAfter = 100
            DrawValue = ValueAfter
            Invalidate()
        End If

    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        Dim h As Single = Me.Height
        Dim w As Single = Me.Width
        Dim r As Single = h / 20
        Dim Padding As Single = 12 * r
        Dim ButtonX As Single = Padding + (Value - Minimum) / (Maximum - Minimum) * (w - 2 * Padding)
        Dim r2 As Single = 4 * r
        If DragMode Then
            Dim MouseMoveValue As Single = (e.X - Padding) / (w - 2 * Padding) * (Maximum - Minimum) + Minimum
            If MouseMoveValue <= Minimum Then
                DrawValue = Minimum
            ElseIf MouseMoveValue >= Maximum Then
                DrawValue = Maximum
            Else
                DrawValue = MouseMoveValue
            End If
            Invalidate()
        End If

    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        DragMode = False
        MouseUpTimer.Enabled = True
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        Dim h As Single = Me.Height
        Dim w As Single = Me.Width
        Dim r As Single = h / 20
        Dim Padding As Single = 12 * r
        Dim ButtonX As Single = Padding + (Value - Minimum) / (Maximum - Minimum) * (w - 2 * Padding)
        Dim r2 As Single = 4 * r
        Dim MouseUpValue As Single = (e.X - Padding) / (w - 2 * Padding) * (Maximum - Minimum) + Minimum
        'If DragMode Then
        If MouseUpValue <= Minimum Then
                Value = Minimum
            ElseIf MouseUpValue >= Maximum Then
                Value = Maximum
            Else
                Value = MouseUpValue
            End If
        ' End If
        DragMode = False
        'MouseUpTimer.Enabled = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim bmp As Bitmap = Draw()
        e.Graphics.DrawImage(bmp, 0, 0)
        bmp.Dispose()
    End Sub

    Private Function Draw() As Bitmap
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Dim g = Graphics.FromImage(bmp)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(Me.BackColor)

        '画填充块
        Dim h As Single = Me.Height
        Dim w As Single = Me.Width
        Dim r As Single = h / 20
        Dim Padding As Single = 12 * r
        Dim BackPath As New GraphicsPath
        With BackPath
            .AddArc(Padding, h / 2 - r, 2 * r, 2 * r, 90, 180)
            .AddLine(Padding + r, h / 2 - r, w - (Padding + r), h / 2 - r)
            .AddArc(w - (Padding + 2 * r), h / 2 - r, 2 * r, 2 * r, 270, 180)
            .CloseFigure()
        End With
        g.FillPath(New SolidBrush(SlideBackColor), BackPath)


        Dim ButtonX As Single = Padding + (DrawValue - Minimum) / (Maximum - Minimum) * (w - 2 * Padding)
        Dim r2 As Single = 4 * r

        '画填充
        Dim FilledPath As New GraphicsPath
        With FilledPath
            .AddArc(Padding, h / 2 - r, 2 * r, 2 * r, 90, 180)
            .AddLine(Padding + r, h / 2 - r, ButtonX, h / 2 - r)
            .AddLine(ButtonX, h / 2 - r, ButtonX, h / 2 + r)
            .CloseFigure()
        End With
        g.FillPath(New SolidBrush(SlideFilledColor), FilledPath)

        '画滑块

        Dim ButtonRect As New RectangleF(ButtonX - r2, h / 2 - r2, 2 * r2, 2 * r2)
        g.FillEllipse(New SolidBrush(ButtonColor), ButtonRect)

        'MouseDown
        If myMouseDown.Enabled Then
            g.FillEllipse(New SolidBrush(GetRelativeColor(ButtonColor, 20, 100)), New RectangleF(ButtonX - MouseDownR, h / 2 - MouseDownR, 2 * MouseDownR, 2 * MouseDownR))
        End If



        g.Dispose()
        Return bmp


    End Function

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        Invalidate()
    End Sub

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Chao_Sliders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "Chao_Sliders"
        Me.Size = New System.Drawing.Size(600, 66)
        Me.ResumeLayout(False)

    End Sub

End Class
