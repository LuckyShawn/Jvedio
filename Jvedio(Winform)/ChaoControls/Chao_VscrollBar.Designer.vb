Imports System.Drawing.Drawing2D
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chao_VscrollBar
    Inherits System.Windows.Forms.UserControl

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
        Dim r As Single = w / 2
        '画上按钮
        Dim ButtonUpPath As New GraphicsPath
        With ButtonUpPath '这里得 -1 不然会有部分画不出来
            .AddLine(-1, -1, -1, w)
            .AddArc(-1, r - 1, w + 1, w + 1, 180, 180)
            .AddLine(w, w, w, -1)
        End With
        g.FillPath(New SolidBrush(Button1Color), ButtonUpPath)
        '画下按钮
        Dim ButtonDownPath As New GraphicsPath
        With ButtonDownPath '这里得 -1 不然会有部分画不出来
            .AddArc(-1, h - (w + r), w + 1, w + 1, 0, 180)
            .AddLine(-1, h, -1, h - w)
            .AddLine(-1, h, w, h)
            .CloseFigure()
        End With
        g.FillPath(New SolidBrush(Button2Color), ButtonDownPath)
        '画上箭头
        Dim ArrowUpPath As New GraphicsPath
        With ArrowUpPath
            .AddLine(w / 2, w / 8, w * 3 / 4, w * 3 / 8)
            .AddLine(w * 3 / 4, w * 3 / 8, w / 4, w * 3 / 8)
            .CloseFigure()
        End With
        g.FillPath(New SolidBrush(ArrowColor), ArrowUpPath)
        '画下箭头
        Dim ArrowDownPath As New GraphicsPath
        With ArrowDownPath
            .AddLine(w / 4, h - w * 3 / 8, w * 3 / 4, h - w * 3 / 8)
            .AddLine(w * 3 / 4, h - w * 3 / 8, w / 2, h - w / 8)
            .CloseFigure()
        End With
        g.FillPath(New SolidBrush(ArrowColor), ArrowDownPath)
        '画滑块
        Dim BH As Single = (LargeChange * (h - 2 * (r + 2))) / (Maximum - Minimum + LargeChange)
        Dim r1 As Single = r - 2
        Dim y As Single = BH * (Value - Minimum) / LargeChange
        Dim BarPath As New System.Drawing.Drawing2D.GraphicsPath
        With BarPath
            .AddArc(1, y + r + 2, 2 * r1 + 1, 2 * r1 + 1, 180, 180)
            .AddLine(w - 2, y + r + 2 + r1, w - 2, y + BH + r + 2 - r1)
            .AddArc(1, y + BH + r + 2 - 2 * r1, 2 * r1 + 1, 2 * r1 + 1, 0, 180)
            .CloseFigure()
        End With
        g.FillPath(New SolidBrush(BarColor1), BarPath)
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
        'Chao_HscrollBar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Name = "Chao_HscrollBar"
        Me.Size = New System.Drawing.Size(25, 350)
        Me.ResumeLayout(False)

    End Sub
End Class
