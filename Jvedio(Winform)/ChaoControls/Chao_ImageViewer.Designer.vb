<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chao_ImageViewer
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

        'ImageList = New ImageList

        'ImageList = New List(Of Image)
        'ImageList.Add(My.Resources.ResourceImageViewer.bg)
        'ImageList.Add(My.Resources.ResourceImageViewer.bg2)
        'ImageList.Add(My.Resources.ResourceImageViewer._2)
        Invalidate()
        'ImageList.Clear()
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim bmp As Bitmap = DrawImageFromImageList()
        e.Graphics.DrawImage(bmp, 0, 0)
        bmp.Dispose()

    End Sub


    Private Function DrawImageFromImageList() As Bitmap
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(Me.BackColor)
        'Dim ImageSize As Size
        'Dim DrawImage As Bitmap
        'Dim ImagePoint As New Point
        'Dim DrawSize As New Size(100, 100)
        'For i = 0 To ImageList.Count - 1 Step 1
        '    DrawImage = ImageList.Item(i)
        '    ImageSize = DrawImage.Size
        '    Debug.Print(ImageSize.Width)
        '    g.DrawImage(DrawImage, New Rectangle(i * DrawSize.Width, 0, DrawSize.Width, DrawSize.Height), New Rectangle(0, 0, ImageSize.Width, ImageSize.Height), GraphicsUnit.Pixel)
        'Next
        Return bmp
    End Function

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(948, 551)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Chao_ImageViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "Chao_ImageViewer"
        Me.Size = New System.Drawing.Size(954, 554)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
