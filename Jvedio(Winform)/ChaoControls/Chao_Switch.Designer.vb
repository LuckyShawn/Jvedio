<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chao_Switch
    Inherits System.Windows.Forms.UserControl

    Private r1 As Single
    Private r2 As Single
    Private TargetPositionLeft As Single
    Private TargetPositionRight As Single
    Private Position As Single
    Private MouseDownTimer As New Timer With {.Interval = 10}

    'UserControl1 重写 Dispose，以清理组件列表。
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
            .MaximumSize = New Size(200, 100)
            .MinimumSize = New Size(40, 20)
            .Cursor = Cursors.Hand
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.ResizeRedraw, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        End With

        r1 = Me.Height
        r2 = r1 * 0.9F
        TargetPositionLeft = (r1 - r2) / 2
        TargetPositionRight = (r1 - r2) / 2 + CType(Me.Width, Single) - r1

        AddHandler MouseDownTimer.Tick, AddressOf MouseDownTimer_Tick


        If Checked Then
            Position = TargetPositionRight
        Else
            Position = TargetPositionLeft
        End If
    End Sub



    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        Me.Width = Me.Height * 2
        r1 = Me.Height
        r2 = r1 * 0.9F
        TargetPositionLeft = (r1 - r2) / 2
        TargetPositionRight = (r1 - r2) / 2 + CType(Me.Width, Single) - r1
        If Checked Then
            Position = TargetPositionRight
        Else
            Position = TargetPositionLeft
        End If
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If Checked Then
            Me.Checked = False
        Else
            Me.Checked = True
        End If
        MouseDownTimer.Enabled = True
    End Sub

    Private Sub MouseDownTimer_Tick()
        If Checked Then
            Position += CheckSpeed
            Invalidate()
            If Position >= TargetPositionRight Then
                Position = TargetPositionRight
                MouseDownTimer.Enabled = False
                Invalidate()
            End If
        Else
            Position -= CheckSpeed
            Invalidate()
            If Position <= TargetPositionLeft Then
                Position = TargetPositionLeft
                MouseDownTimer.Enabled = False
                Invalidate()
            End If

        End If
    End Sub

    '重写OnPaint
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim bmp As Bitmap = Draw()
        e.Graphics.DrawImage(bmp, 0, 0)
        bmp.Dispose()
    End Sub

    Private Function Draw() As Bitmap
        Dim bmp As Bitmap = New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(CheckBackColor)
        Dim CheckSolidBrush As SolidBrush
        If Checked Then
            CheckSolidBrush = New SolidBrush(CheckedInColor)
        Else
            CheckSolidBrush = New SolidBrush(CheckedOffColor)
        End If
        If Not Me.Enabled Then
            CheckSolidBrush = New SolidBrush(Color.Gray)
        End If
        g.FillEllipse(CheckSolidBrush, 0, 0, r1, r1)
        g.FillEllipse(CheckSolidBrush, CType(Me.Width, Single) - r1, 0, r1, r1)
        g.FillRectangle(CheckSolidBrush, r1 / 2, 0, CType(Me.Width, Single) - r1, CType(Me.Height, Single))
        Dim ButtonSolidBrush As New SolidBrush(mySmallButtonColor)
        g.FillEllipse(ButtonSolidBrush, Position, (r1 - r2) / 2, r2, r2)
        g.DrawImage(bmp, 0, 0)
        ButtonSolidBrush.Dispose()
        CheckSolidBrush.Dispose()
        g.Dispose()
        Return bmp
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
        'Chao_Switch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Chao_Switch"
        Me.Size = New System.Drawing.Size(70, 35)
        Me.ResumeLayout(False)

    End Sub
End Class
