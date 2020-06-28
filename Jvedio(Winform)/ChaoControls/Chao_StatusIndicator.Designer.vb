<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chao_StatusIndicator
    Inherits System.Windows.Forms.UserControl

    Private RunningTimer As New Timer With {.Interval = 1}
    Private RunningAngel As Integer = 0

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
            '防止闪烁
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.ResizeRedraw, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .MinimumSize = New Size(25, 25)
            .MaximumSize = New Size(50, 50)
        End With


        AddHandler RunningTimer.Tick, AddressOf RunningTimer_Tick
        If Status = "Running" Then RunningTimer.Enabled = True
        Invalidate() '绘画写在OnPaint里了

    End Sub

    Sub RunningTimer_Tick()
        RunningAngel += RunningSpeed
        If RunningAngel = 360 Then RunningAngel = 0
        Invalidate()
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim bmp As Bitmap = Draw()
        e.Graphics.DrawImage(bmp, 0, 0)
        bmp.Dispose()
    End Sub

    Function Draw() As Bitmap
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(Me.BackColor)
        Dim pad As Single = 2
        Dim w As Single = Me.Width
        Dim r As Single = w / 2
        Dim pad2 As Single = w - 1.414 * r
        Select Case Status
            Case "Failed"
                g.DrawEllipse(New Pen(FailedColor, 1.5), New RectangleF(pad, pad, w - 2 * pad, w - 2 * pad))
                g.DrawLine(New Pen(FailedColor, 2), pad2, pad2, w - pad2, w - pad2)
                g.DrawLine(New Pen(FailedColor, 2), w - pad2, pad2, pad2, w - pad2)
            Case "Running"
                g.FillPie(New SolidBrush(RunningColor), New Rectangle(0, 0, w, w), RunningAngel, 120)
                g.FillEllipse(New SolidBrush(BackColor), New RectangleF(w / 8, w / 8, w - 2 * w / 8, w - 2 * w / 8))
            Case "Success"
                g.DrawEllipse(New Pen(SuccessColor, 1.5), New RectangleF(pad, pad, w - 2 * pad, w - 2 * pad))
                g.DrawLine(New Pen(SuccessColor, 2), w / 6, w - 5 * w / 12, w / 3, w - w / 4)
                g.DrawLine(New Pen(SuccessColor, 2), w / 3, w - w / 4, 48 * w / 60, w / 3)
            Case "StandBy"
        End Select

        Return bmp
    End Function


    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        Me.Width = Me.Height
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Chao_StatusIndicator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "Chao_StatusIndicator"
        Me.Size = New System.Drawing.Size(87, 88)
        Me.ResumeLayout(False)

    End Sub

End Class
