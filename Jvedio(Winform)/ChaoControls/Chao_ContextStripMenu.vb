Imports System.Drawing.Drawing2D

Public Class Chao_ContextStripMenu

End Class


Public Class Chao_ToolStripMenuItem
    Inherits ToolStripMenuItem

    Public Sub New()
        'AutoSize = False
        'Height = 50
    End Sub

    'Protected Overrides Function CreateDefaultDropDown() As ToolStripDropDown
    '    Dim baseDropDown = MyBase.CreateDefaultDropDown()
    '    If DesignMode Then Return baseDropDown
    '    Dim defaultDropDown = New Chao_ContextStripMenu()
    '    defaultDropDown.Items.AddRange(baseDropDown.Items)
    '    Return defaultDropDown
    'End Function
End Class

Public Class Chao_ContextMenuStripRender
        Inherits ToolStripRenderer

    Private BorderColor As Color = Color.FromArgb(205, 205, 205)
    Private IsCheckSet As Boolean = False
    Private IsImageSet As Boolean = False
    Private HasChildren As Boolean = False
    Private Max As Integer = 0
    'toolstrip背景
    Protected Overrides Sub OnRenderToolStripBackground(e As ToolStripRenderEventArgs)
        '
        'Dim g As Graphics =
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        'g.FillRectangle(New SolidBrush(Color.White), New RectangleF(e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width, e.AffectedBounds.Height))
        e.Graphics.FillPath(New SolidBrush(Color.White), DrawRoundRectangle(e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1, 5))

        'MyBase.OnRenderToolStripBackground(e)
    End Sub



    '边框
    Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
            MyBase.OnRenderToolStripBorder(e)
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        ' e.Graphics.DrawPath(New Pen(BorderColor, 1), DrawRoundRectangle(e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1, 5))
        e.Graphics.DrawRectangle(New Pen(BorderColor, 1), e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1)
        'MyBase.OnRenderToolStripBorder(e)
    End Sub

    '重绘箭头
    Protected Overrides Sub OnRenderArrow(e As ToolStripArrowRenderEventArgs)


        'Debug.Print(Max)
        HasChildren = True
        'Dim myMenuItemFont As New Font("微软雅黑", 12)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim ArrowPath As New GraphicsPath
        With ArrowPath
            If IsImageSet Or IsCheckSet Then
                .AddLine(50 + Max + 18.22F, 15.0F, 50 + Max + 23.43F, 20.0F)
                .AddLine(50 + Max + 23.43F, 20.0F, 50 + Max + 18.22F, 25.0F)
                .CloseFigure()
            Else
                .AddLine(Max + 18.22F, 15.0F, Max + 23.43F, 20.0F)
                .AddLine(Max + 23.43F, 20.0F, Max + 18.22F, 25.0F)
                .CloseFigure()
            End If
        End With
        g.FillPath(New SolidBrush(Color.FromArgb(111, 111, 111)), ArrowPath)
        'MyBase.OnRenderArrow(e)
    End Sub

    '重绘分界线
    Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.FillRectangle(New SolidBrush(Color.White), e.Item.Bounds)
        g.DrawLine(
            New Pen(Color.Gray),
            New Point(e.Item.Bounds.Left, e.Item.Bounds.Height / 2),
            New Point(e.Item.Bounds.Right, e.Item.Bounds.Height / 2))
    End Sub


    '重绘Image
    Protected Overrides Sub OnRenderItemImage(e As ToolStripItemImageRenderEventArgs)
        'MyBase.OnRenderItemImage(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.DrawImage(e.Image, CType((50 - 32) / 2, Single), CType((e.Item.Height - 32) / 2, Single), 32, 32)

        IsImageSet = True
    End Sub

    '重绘文本
    Protected Overrides Sub OnRenderItemText(ByVal e As ToolStripItemTextRenderEventArgs)

        'Dim myMenuItemFont As New Font("微软雅黑", 12)
        Dim g As Graphics = e.Graphics
        'g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Dim TextSize As SizeF = g.MeasureString(e.Item.Text, e.Item.Font)

        If IsImageSet Or IsCheckSet Then
            g.DrawString(e.Item.Text, e.Item.Font, New SolidBrush(e.Item.ForeColor), New PointF(50, (e.Item.Height - TextSize.Height) / 2))
        Else
            g.DrawString(e.Item.Text, e.Item.Font, New SolidBrush(e.Item.ForeColor), New PointF(10, (e.Item.Height - TextSize.Height) / 2))
        End If




    End Sub

    'MenuItem
    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)

        Dim g As Graphics = e.Graphics
        Dim item As ToolStripItem = e.Item
        Dim ts As ToolStrip = e.ToolStrip
        '统计分隔栏
        Dim SepCount As Integer = 0
        For i = 0 To e.ToolStrip.Items.Count - 1
            If e.ToolStrip.Items.Item(i).GetType.ToString =
            "System.Windows.Forms.ToolStripSeparator" Then
                SepCount += 1
                Debug.Print(e.ToolStrip.Items.Item(i).Height)
            End If

        Next

        e.Item.AutoSize = False
        e.Item.Height = 40
        e.ToolStrip.AutoSize = False
        e.ToolStrip.Height = (e.ToolStrip.Items.Count - SepCount) * 40 + SepCount * 6 + 16
        If IsCheckSet Or IsImageSet Then
            'Dim Max As Single = 0
            Dim TextSize As SizeF
            'Dim myMenuItemFont As New Font("微软雅黑", 12)
            For i = 0 To e.ToolStrip.Items.Count - 1
                TextSize = g.MeasureString(e.ToolStrip.Items.Item(i).Text, e.ToolStrip.Items.Item(i).Font)
                If TextSize.Width >= Max Then
                    Max = TextSize.Width
                End If
            Next
            If HasChildren Then
                e.Item.Width = 50 + Max + 54
                e.ToolStrip.Width = 50 + Max + 50
            Else
                ' Debug.Print("有图像无子菜单")
                e.Item.Width = 50 + Max + 24
                e.ToolStrip.Width = 50 + Max + 20
            End If

        Else
            'Dim Max As Single = 0
            Dim TextSize As SizeF
            'Dim myMenuItemFont As New Font("微软雅黑", 12)
            For i = 0 To e.ToolStrip.Items.Count - 1
                TextSize = g.MeasureString(e.ToolStrip.Items.Item(i).Text, e.ToolStrip.Items.Item(i).Font)
                If TextSize.Width >= Max Then
                    Max = TextSize.Width
                End If
            Next
            If HasChildren Then
                e.Item.Width = Max + 54
                e.ToolStrip.Width = Max + 50
            Else
                e.Item.Width = Max + 24
                e.ToolStrip.Width = Max + 20
            End If

        End If




        If e.ToolStrip.Items.Count = 1 Then
            e.ToolStrip.Items.Item(0).Margin = New Padding(0, 6, 0, 6)
        ElseIf e.ToolStrip.Items.Count > 1 Then
            e.ToolStrip.Items.Item(0).Margin = New Padding(0, 6, 0, 0)
            e.ToolStrip.Items.Item(e.ToolStrip.Items.Count - 1).Margin = New Padding(0, 0, 0, 6)
        End If

        If item.Selected Then
            g.FillRectangle(New SolidBrush(Color.FromArgb(242, 242, 242)), 0, 0, e.Item.Width, e.Item.Height)
        Else
            g.FillRectangle(New SolidBrush(Color.White), 0, 0, e.Item.Width, e.Item.Height)
        End If

    End Sub



    '取消ImageMargin
    Protected Overrides Sub OnRenderImageMargin(e As ToolStripRenderEventArgs)
        'MyBase.OnRenderImageMargin(e)

    End Sub



    '画复选框
    Protected Overrides Sub OnRenderItemCheck(e As ToolStripItemImageRenderEventArgs)
        'MyBase.OnRenderItemCheck(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim CheckPath As New GraphicsPath
        With CheckPath
            .AddLine(18.0F, 18.25F, 25.0F, 25.0F)
            .AddLine(25.0F, 25.0F, 40.0F, 11.5F)
        End With
        g.DrawPath(New Pen(Color.Black, 3), CheckPath)
        IsCheckSet = True

    End Sub

End Class