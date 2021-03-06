﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chao_TextBox
    Inherits System.Windows.Forms.UserControl

    Private myMouseDown As MD
    Private MouseDownTimer As New Timer With {.Interval = 1}

    Private IsMouseEnter As Boolean
    Private IsFocus As Boolean
    Private FocusTimer As New Timer With {.Interval = 1}
    Private FocusLength As Single = 0
    Structure MD
        Dim Enabled As Boolean
        Dim X As Single
        Dim Y As Single
    End Structure
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

    Protected Overrides Sub OnLostFocus(e As EventArgs)
        MyBase.OnLostFocus(e)

    End Sub

    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)
        SystemTextBox.Focus()
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
            '.MinimumSize = New Size(50, 50)
            .Cursor = Cursors.IBeam
        End With
        Dim g = Me.CreateGraphics
        Dim size = g.MeasureString(Text, TextFont)
        g.Dispose()
        SystemTextBox.Left = 12
        SystemTextBox.Top = 12
        SystemTextBox.Text = Hint
        AddHandler FocusTimer.Tick, AddressOf FocusTimer_Tick
        Invalidate()
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        Me.Height = SystemTextBox.Height + 12 * 2
        SystemTextBox.Width = Me.Width - 12 * 2
    End Sub

    Sub FocusTimer_Tick()
        If IsFocus Then
            FocusLength += Me.Width / 25
            If FocusLength >= Me.Width / 2 Then
                FocusLength = Me.Width / 2
                FocusTimer.Enabled = False
                Invalidate()
            End If
            Invalidate()
        Else
            FocusLength -= Me.Width / 25
            If FocusLength <= 0 Then
                FocusLength = 0
                FocusTimer.Enabled = False
                Invalidate()
            End If
            Invalidate()
        End If
    End Sub



    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        IsMouseEnter = True
        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        Me.Focus()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        IsMouseEnter = False
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        myMouseDown.Enabled = True
        myMouseDown.X = e.X
        myMouseDown.Y = e.Y
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        myMouseDown.Enabled = False
    End Sub



    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim bmp As Bitmap = Draw()
        e.Graphics.DrawImage(bmp, 0, 0)
        bmp.Dispose()

        '画文字
        SystemTextBox.ForeColor = TextForeColor
        If IsMouseEnter Then
            SystemTextBox.BackColor = GetRelativeColor(TextBackColor, -20)
        Else
            SystemTextBox.BackColor = TextBackColor
        End If
        'SystemTextBox.Text = Hint
        'SystemTextBox.Text = TextContent
        'SystemTextBox.Font = TextFont
    End Sub

    Function Draw() As Bitmap
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Dim g = Graphics.FromImage(bmp)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(TextBackColor)
        Dim h As Single = Me.Height
        Dim w As Single = Me.Width
        Dim myPadding As New Padding(10, 0, 0, 0)

        If IsMouseEnter Then
            g.Clear(GetRelativeColor(TextBackColor, -20))
        End If


        '画横杠
        g.DrawLine(New Pen(LineColor, 2), w / 2, h - 2, w / 2 - FocusLength, h - 2)
        g.DrawLine(New Pen(LineColor, 2), w / 2, h - 2, w / 2 + FocusLength, h - 2)



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
        Me.SystemTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'SystemTextBox
        '
        Me.SystemTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.SystemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SystemTextBox.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SystemTextBox.Location = New System.Drawing.Point(20, 20)
        Me.SystemTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SystemTextBox.Name = "SystemTextBox"
        Me.SystemTextBox.Size = New System.Drawing.Size(290, 27)
        Me.SystemTextBox.TabIndex = 0
        '
        'Chao_TextBox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.SystemTextBox)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Chao_TextBox"
        Me.Size = New System.Drawing.Size(324, 56)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SystemTextBox As TextBox
End Class
