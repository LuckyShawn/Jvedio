<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chao_TitlePanel
    Inherits System.Windows.Forms.Panel

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
        Me.DoubleBuffered = True
        Invalidate()

    End Sub




    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        'MyBase.OnPaintBackground(e)
    End Sub

    Protected Overrides Sub OnBackgroundImageLayoutChanged(e As EventArgs)
        MyBase.OnBackgroundImageLayoutChanged(e)
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim bmp As Bitmap = New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        g.Clear(Me.BackColor)
        e.Graphics.DrawImage(bmp, 0, 0)
        Dim bg As Bitmap = Me.BackgroundImage
        If bg IsNot Nothing Then
            Select Case Me.BackgroundImageLayout
                Case ImageLayout.None
                    e.Graphics.DrawImage(bg, New Rectangle(0, 0, bg.Width, bg.Height), New Rectangle(0, 0, bg.Width, bg.Height), GraphicsUnit.Pixel)
                Case ImageLayout.Center
                    e.Graphics.DrawImage(bg, New Rectangle((Me.Width - bg.Width) / 2, (Me.Height - bg.Height) / 2, bg.Width, bg.Height), New Rectangle(0, 0, bg.Width, bg.Height), GraphicsUnit.Pixel)
                Case ImageLayout.Stretch
                    e.Graphics.DrawImage(bg, New Rectangle(0, 0, Me.Width, Me.Height), New Rectangle(0, 0, bg.Width, bg.Height), GraphicsUnit.Pixel)
                Case ImageLayout.Tile
                    Dim XNum As Integer = Int(Me.Width / bg.Width) + 1
                    Dim YNum As Integer = Int(Me.Height / bg.Height) + 1
                    For i = 0 To XNum
                        For j = 0 To YNum
                            e.Graphics.DrawImage(bg, New Rectangle(i * bg.Width, j * bg.Height, bg.Width, bg.Height), New Rectangle(0, 0, bg.Width, bg.Height), GraphicsUnit.Pixel)
                        Next
                    Next
                Case ImageLayout.Zoom
                    e.Graphics.DrawImage(bg, New Rectangle((Me.Width - Me.Height * (bg.Width / bg.Height)) / 2, 0, Me.Height * (bg.Width / bg.Height), Me.Height), New Rectangle(0, 0, bg.Width, bg.Height), GraphicsUnit.Pixel)
            End Select
        End If

        g.Dispose()
        bmp.Dispose()
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

End Class
