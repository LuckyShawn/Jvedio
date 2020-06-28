<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chao_InheritsListBox
    'Inherits System.Windows.Forms.UserControl
    Inherits System.Windows.Forms.ListBox

    Private SelectedColor As Color = Color.FromArgb(225, 225, 225)

    Private Structure MD
        Dim IsMouseDown As Boolean
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

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Me.DrawMode = DrawMode.OwnerDrawVariable
        Me.ItemHeight = 40
        'AddHandler MouseMoveIndex.OnValueChanged, AddressOf MouseMoveIndex_OnValueChanged
        Me.DoubleBuffered = True
    End Sub







    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        MyBase.OnDrawItem(e)
        If Me.Items.Count = 0 Then Exit Sub
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim Index = e.Index '获取当前要进行绘制的行的序号， 从0开始。
        Dim Text = Me.GetItemText(Me.Items.Item(Index)) '获取当前要绘制的行的显示文本。
        Dim TextSize = g.MeasureString(Text, Font)
        Me.ItemHeight = TextSize.Height + 20
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            Dim rect = New Rectangle(e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height)
            g.FillRectangle(New SolidBrush(SelectedColor), rect)
        Else
            Dim rect = New Rectangle(e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height)
            g.FillRectangle(Brushes.White, rect)
        End If
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        g.DrawString(Text, Font, New SolidBrush(ForeColor), New PointF(10, e.Bounds.Top + (e.Bounds.Height - TextSize.Height) / 2))
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
