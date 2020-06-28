Imports System.Drawing.Drawing2D
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<System.Drawing.ToolboxBitmap(GetType(Chao_CheckBox), "Chao_CheckBox.bmp")>'该资源引入Resource 文件并设置其为嵌入.resx，图片属性为【嵌入的资源】16*16 BMP，以类名命名
Partial Class Chao_CheckBox
    Inherits System.Windows.Forms.UserControl

    Private IsMouseDown As Boolean = True
    Private IsMouseMove As Boolean = False
    Private MouseDownR As Single = 0
    Private MouseDownTimer As New Timer With {.Interval = 1}



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

        AddHandler MouseDownTimer.Tick, AddressOf MouseDownTimer_Tick
        With Me
            .MinimumSize = New Size(20, 20)
            .Cursor = Cursors.Hand
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.ResizeRedraw, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        End With
        Invalidate()

    End Sub


    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        If Checked Then
            Me.Checked = False
        Else
            Me.Checked = True
        End If
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        IsMouseDown = True
        MouseDownR = 0
        MouseDownTimer.Enabled = True
    End Sub


    Private Sub MouseDownTimer_Tick()
        MouseDownR += Me.Height / 16
        Invalidate()
        If MouseDownR >= Me.Height - 8 Then
            IsMouseDown = False
            MouseDownTimer.Enabled = False
            Invalidate()
        End If
    End Sub


    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        IsMouseMove = True
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        IsMouseMove = False
        Invalidate()
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim bmp As Bitmap
        bmp = Draw()
        e.Graphics.DrawImage(bmp, 0, 0)
        bmp.Dispose()
    End Sub


    Public Function Draw() As Bitmap
        Dim bmp As Bitmap = New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(Me.BackColor)

        Dim BorderPen As Pen
        If IsMouseMove Then
            BorderPen = New Pen(CheckedInBackColor, BorderWidth)
        ElseIf Me.Enabled = False Then
            BorderPen = New Pen(Color.Gray, BorderWidth)
        Else

            BorderPen = New Pen(BorderColor, BorderWidth)
        End If


        Dim BorderPath As GraphicsPath = GetBorderPath(4, 4, Me.Height - 8, (Me.Height - 8) / 5)
        Dim DuiHaoPath As GraphicsPath = GetDuiHaoPath(4, 4, Me.Height - 8, (Me.Height - 8) / 4)
        '画复选框
        If Checked Then
            If IsMouseMove Then
                g.FillPath(New SolidBrush(GetRelativeColor(CheckedInBackColor, -20)), BorderPath)
            Else
                g.FillPath(New SolidBrush(CheckedInBackColor), BorderPath)
            End If

            g.FillPath(New SolidBrush(CheckedInForeColor), DuiHaoPath)
        Else
            g.DrawPath(BorderPen, BorderPath)
        End If


        '画MouseDown
        Dim MouseDownSolidBrush As SolidBrush = New SolidBrush(GetRelativeColor(CheckedInBackColor, -20, 100))
        Dim x As Single = (Me.Height - 4) / 2
        Dim y As Single = Me.Height / 2
        Dim w As Single = Me.Height - 8
        Dim MouseDownPath As New GraphicsPath
        With MouseDownPath
            .AddEllipse(0, 0, 2 * y + 2, 2 * y + 2)
        End With
        If IsMouseDown Then
            g.Clip = New Region(MouseDownPath)
            g.FillEllipse(MouseDownSolidBrush, x - MouseDownR, y - MouseDownR, 2 * MouseDownR, 2 * MouseDownR)
        End If
        g.Clip = New Region(New RectangleF(0, 0, CType(Me.Width, Single), CType(Me.Height, Single)))

        '画文字
        Dim TextSolidBrush As SolidBrush
        If Me.Enabled Then
            TextSolidBrush = New SolidBrush(CheckTextColor)
        Else
            TextSolidBrush = New SolidBrush(Color.Gray)
        End If

        Dim TextSize As SizeF = g.MeasureString(CheckText, CheckTextFont)
        Dim TextPoint As PointF = New PointF(w + w / 2, (Me.Height - TextSize.Height) / 2)
        g.DrawString(CheckText, CheckTextFont, TextSolidBrush, TextPoint)

        '释放资源
        BorderPen.Dispose()
        BorderPath.Dispose()
        DuiHaoPath.Dispose()
        MouseDownSolidBrush.Dispose()
        MouseDownPath.Dispose()
        TextSolidBrush.Dispose()
        g.Dispose()
        Return bmp
    End Function

    Private Function GetBorderPath(x As Single, y As Single, w As Single, r As Single) As GraphicsPath
        Dim h As Single = w
        Dim myGraphicsPath As New GraphicsPath
        With myGraphicsPath
            .AddArc(x, y, 2 * r, 2 * r, 180, 90)
            .AddArc(x + w - 2 * r, y, 2 * r, 2 * r, 270, 90)
            .AddArc(x + w - 2 * r, y + h - 2 * r, 2 * r, 2 * r, 0, 90)
            .AddArc(x, y + h - 2 * r, 2 * r, 2 * r, 90, 90)
            .CloseFigure()
        End With
        Return myGraphicsPath
    End Function





    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Chao_CheckBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Chao_CheckBox"
        Me.Size = New System.Drawing.Size(145, 35)
        Me.ResumeLayout(False)

    End Sub
End Class
