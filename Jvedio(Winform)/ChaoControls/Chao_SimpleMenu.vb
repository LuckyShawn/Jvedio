Imports System.Drawing.Drawing2D
Imports System.ComponentModel








Public Class Chao_SimpleMenu


End Class

Public Class Chao_SimpleMenuStripRender
    Inherits ToolStripRenderer

    Private BorderColor As Color = Color.FromArgb(205, 205, 205)
    Private MenuWidth As Single = 200
    'toolstrip背景
    Protected Overrides Sub OnRenderToolStripBackground(e As ToolStripRenderEventArgs)

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.FillPath(New SolidBrush(Color.White), DrawRoundRectangle(e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1, 5))

    End Sub



    '边框
    Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
        MyBase.OnRenderToolStripBorder(e)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.DrawRectangle(New Pen(BorderColor, 1), e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1)

    End Sub



    '重绘文本
    Protected Overrides Sub OnRenderItemText(ByVal e As ToolStripItemTextRenderEventArgs)

        'Dim myMenuItemFont As New Font("微软雅黑", 12)
        Dim g As Graphics = e.Graphics
        'g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Dim TextSize As SizeF = g.MeasureString(e.Item.Text, e.Item.Font)
        g.DrawString(e.Item.Text, e.Item.Font, New SolidBrush(e.Item.ForeColor), New PointF((MenuWidth - TextSize.Width) / 2, (e.Item.Height - TextSize.Height) / 2))

    End Sub

    'MenuItem
    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)

        Dim g As Graphics = e.Graphics
        Dim item As ToolStripItem = e.Item
        Dim ts As ToolStrip = e.ToolStrip

        e.Item.AutoSize = False
        e.ToolStrip.AutoSize = False
        e.Item.Height = 40
        e.ToolStrip.Height = e.ToolStrip.Items.Count * 40 + 16

        e.Item.Width = MenuWidth + 4
        e.ToolStrip.Width = MenuWidth

        If e.ToolStrip.Items.Count = 1 Then
            e.ToolStrip.Items.Item(0).Margin = New Padding(0, 6, 0, 6)
        ElseIf e.ToolStrip.Items.Count > 1 Then
            e.ToolStrip.Items.Item(0).Margin = New Padding(0, 6, 0, 0)
            e.ToolStrip.Items.Item(e.ToolStrip.Items.Count - 1).Margin = New Padding(0, 0, 0, 6)
        End If

        'MouseMove
        If item.Selected Then
            g.FillRectangle(New SolidBrush(Color.FromArgb(242, 242, 242)), 0, 0, e.Item.Width, e.Item.Height)
        Else
            g.FillRectangle(New SolidBrush(Color.White), 0, 0, e.Item.Width, e.Item.Height)
        End If

    End Sub
End Class