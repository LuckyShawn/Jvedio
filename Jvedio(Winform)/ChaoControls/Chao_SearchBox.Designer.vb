Imports System.Drawing.Drawing2D
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chao_SearchBox
    Inherits System.Windows.Forms.UserControl
    Private IconMouseMove As Boolean = False
    Private ClearMouseMove As Boolean = False
    Private SearchBoxMouseEnter As Boolean = False

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
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .MinimumSize = New Size(155, 20)
            .MaximumSize = New Size(0, 80)
        End With

        With TextBox1
            .BackColor = SearchBoxColor
            .ForeColor = SearchTextForeColor
            If .Text = Hint Then
                .ForeColor = HintColor
            Else
                .ForeColor = SearchTextForeColor
            End If
            .Left = Me.Height / 2 + 20
            .Top = (Me.Height - .Height) / 2
            .Width = Me.Width - Me.Height - 15
        End With

        Me.Text = "Search"
        TextBox1.Text = "Search"

    End Sub



    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim bmp As Bitmap = Draw()
        e.Graphics.DrawImage(bmp, 0, 0)
        bmp.Dispose()
    End Sub


    Private Function Draw() As Bitmap
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Dim r As Single = Me.Height / 2
        Dim pad As Single = 2
        Dim GP As New GraphicsPath
        With GP
            .AddArc(pad, pad, 2 * r - 2 * pad, 2 * r - 2 * pad, 90, 180)
            .AddLine(r + pad, pad, Me.Width - 2 * r - pad, pad)
            .AddArc(Me.Width - 2 * r - pad, pad, 2 * r - 2 * pad, 2 * r - 2 * pad, 270, 180)
            .CloseFigure()
        End With
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(Me.BackColor)
        g.FillPath(New SolidBrush(SearchBoxColor), GP)

        '画搜索框
        g.DrawImage(bmp, 0, 0)
        If SearchBoxMouseEnter Then
            g.DrawPath(New Pen(SearchBoxMouseMoveColor, 2), GP)
        End If
        '画一个搜索按钮
        If IconMouseMove Then
            g.DrawImage(DrawSearchIcon(TextBox1.Height, SearchBoxColor, GetRelativeColor(SearchIconColor, 20)), TextBox1.Left - TextBox1.Height - 5, TextBox1.Top)
        Else
            g.DrawImage(DrawSearchIcon(TextBox1.Height, SearchBoxColor, SearchIconColor), TextBox1.Left - TextBox1.Height - 5, TextBox1.Top)
        End If

        '画一个清空按钮
        'If ClearMouseMove Then
        '    g.DrawImage(DrawClearIcon(TextBox1.Height, SearchBoxColor, Color.Red), TextBox1.Width - TextBox1.Height, TextBox1.Top)
        'Else
        '    g.DrawImage(DrawClearIcon(TextBox1.Height, SearchBoxColor, Color.Blue), TextBox1.Width - TextBox1.Height, TextBox1.Top)
        'End If

        Return bmp
    End Function

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        SearchBoxMouseEnter = True
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        Dim IconRegion As New Region(New RectangleF(0, 0, Me.Height, Me.Height))
        If IconRegion.IsVisible(New Point(e.X, e.Y)) Then
            IconMouseMove = True
        Else
            IconMouseMove = False
        End If

        Dim ClearRegion As New Region(New RectangleF(Me.Width - Me.Height, 0, Me.Height, Me.Height))
        If ClearRegion.IsVisible(New Point(e.X, e.Y)) Then
            ClearMouseMove = True
        Else
            ClearMouseMove = False
        End If
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        IconMouseMove = False
        ClearMouseMove = False
        SearchBoxMouseEnter = False
        Invalidate()
    End Sub



    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(35, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 27)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Search"
        '
        'Chao_SearchBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Chao_SearchBox"
        Me.Size = New System.Drawing.Size(300, 50)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
End Class
