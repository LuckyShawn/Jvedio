<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chao_ProgressIndicators
    Inherits System.Windows.Forms.UserControl

    Private myTimer As New Timer With {.Interval = 1}
    Private Value1 As Single = 0
    Private Value2 As Single = 20
    Private Fuhao As Integer = 1
    Private Temp As Single

    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()

                myTimer.Enabled = False
            End If
        Finally
            MyBase.Dispose(disposing)
            myTimer.Enabled = False
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
        End With

        Value1 = 0
        Value2 = Me.Width / 8

        AddHandler myTimer.Tick, AddressOf myTimer_Tick
        myTimer.Enabled = True
    End Sub

    Sub myTimer_Tick()
        ' If Not Me.Visible Then Exit Sub
        If ProgressType = "Linear" Then
            Value1 += Me.Width / (50 + Fuhao * 15)
            Value2 += Me.Width / (50 - Fuhao * 15)
            If Value1 >= Me.Width Then
                Value1 = -(Value2 - Value1)
                Value2 = 0
                Fuhao = -Fuhao
                Invalidate()
            End If
        Else

            Value1 += Me.Width / (50 + 20)
            Value2 += Me.Width / (50 - 20)

            If Value2 >= 360 Then
                Value2 += Me.Width / (50 + 50)
                Value1 += Me.Width / (50 - 20)
            End If

            If Value1 = Value2 Then
                Value2 += Me.Width / (50 - 20)
                Value1 += Me.Width / (50 + 20)
            End If




            Invalidate()
        End If

        Invalidate()
    End Sub
    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        Value1 = 0
        Value2 = Me.Width / 8
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
        g.Clear(BarBackColor)
        Dim h As Single = Me.Height
        Dim w As Single = Me.Width

        If ProgressType = "Linear" Then
            g.FillRectangle(New SolidBrush(BarFilledColor), New RectangleF(Value1, 0, Value2 - Value1, h))
        Else
            Dim r As Single = Math.Min(Me.Height, Me.Width)
            g.FillPie(New SolidBrush(BarFilledColor), New Rectangle(0, 0, r, r), Value1, Value2 - Value1)
            g.FillEllipse(New SolidBrush(BarBackColor), New Rectangle(r / 4, r / 4, r / 2, r / 2))
        End If


        g.Dispose()
        Return bmp
    End Function

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Chao_ProgressIndicators
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "Chao_ProgressIndicators"
        Me.Size = New System.Drawing.Size(834, 22)
        Me.ResumeLayout(False)

    End Sub

End Class
