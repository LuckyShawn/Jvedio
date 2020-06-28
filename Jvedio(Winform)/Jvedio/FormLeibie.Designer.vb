<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLeibie
    Inherits ChaoForm.Form

    'Form 重写 Dispose，以清理组件列表。
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

#Region "Disable ScrollBar"
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ShowScrollBar(ByVal hWnd As IntPtr, ByVal wBar As Integer, ByVal bShow As Boolean) As Boolean

    End Function

    Private Enum ScrollBarDirection
        SB_HORZ = 0
        SB_VERT = 1
        SB_CTL = 2
        SB_BOTH = 3
    End Enum

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Try
            If Chao_FlowLayoutPanel1.IsHandleCreated Then
                ShowScrollBar(Chao_FlowLayoutPanel1.Handle, CInt(ScrollBarDirection.SB_BOTH), False)
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        MyBase.WndProc(m)
    End Sub

#End Region

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        '双缓冲
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        ContextMenuStrip1.Renderer = New Chao_SimpleMenuStripRender(Label1.Width + PictureBox1.Width, Color.FromArgb(40, 40, 40), Color.FromArgb(148, 149, 153))

    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLeibie))
        Me.Chao_SearchBox1 = New ChaoControls.Chao_SearchBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.所有ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.骑兵ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.步兵ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.欧美ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Chao_FlowLayoutPanel1 = New ChaoControls.Chao_FlowLayoutPanel()
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormIconPicB
        '
        Me.FormIconPicB.Location = New System.Drawing.Point(16, 16)
        '
        'FormTextLabel
        '
        Me.FormTextLabel.Location = New System.Drawing.Point(64, 18)
        Me.FormTextLabel.Size = New System.Drawing.Size(52, 27)
        Me.FormTextLabel.Text = "类别"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(608, 20)
        '
        'TitlePanel
        '
        Me.TitlePanel.Size = New System.Drawing.Size(798, 64)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(600, 16)
        '
        'Chao_SearchBox1
        '
        Me.Chao_SearchBox1.AccessibleRole = Nothing
        Me.Chao_SearchBox1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_SearchBox1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_SearchBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_SearchBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Chao_SearchBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_SearchBox1.Hint = "Search"
        Me.Chao_SearchBox1.HintColor = System.Drawing.Color.Gray
        Me.Chao_SearchBox1.Location = New System.Drawing.Point(0, 69)
        Me.Chao_SearchBox1.MaximumSize = New System.Drawing.Size(0, 80)
        Me.Chao_SearchBox1.MinimumSize = New System.Drawing.Size(155, 20)
        Me.Chao_SearchBox1.Name = "Chao_SearchBox1"
        Me.Chao_SearchBox1.SearchBoxColor = System.Drawing.Color.Black
        Me.Chao_SearchBox1.SearchBoxMouseMoveColor = System.Drawing.Color.White
        Me.Chao_SearchBox1.SearchIconColor = System.Drawing.Color.Gray
        Me.Chao_SearchBox1.SearchTextForeColor = System.Drawing.Color.White
        Me.Chao_SearchBox1.Size = New System.Drawing.Size(341, 50)
        Me.Chao_SearchBox1.TabIndex = 2
        Me.Chao_SearchBox1.Text = "Search"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Jvedio.My.Resources.Resource_Image.Arrow_Down
        Me.PictureBox1.Location = New System.Drawing.Point(448, 71)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(348, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "所有"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.所有ToolStripMenuItem, Me.骑兵ToolStripMenuItem, Me.步兵ToolStripMenuItem, Me.欧美ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 100)
        '
        '所有ToolStripMenuItem
        '
        Me.所有ToolStripMenuItem.Name = "所有ToolStripMenuItem"
        Me.所有ToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.所有ToolStripMenuItem.Text = "所有"
        '
        '骑兵ToolStripMenuItem
        '
        Me.骑兵ToolStripMenuItem.Name = "骑兵ToolStripMenuItem"
        Me.骑兵ToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.骑兵ToolStripMenuItem.Text = "骑兵"
        '
        '步兵ToolStripMenuItem
        '
        Me.步兵ToolStripMenuItem.Name = "步兵ToolStripMenuItem"
        Me.步兵ToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.步兵ToolStripMenuItem.Text = "步兵"
        '
        '欧美ToolStripMenuItem
        '
        Me.欧美ToolStripMenuItem.Name = "欧美ToolStripMenuItem"
        Me.欧美ToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.欧美ToolStripMenuItem.Text = "欧美"
        '
        'Chao_FlowLayoutPanel1
        '
        Me.Chao_FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_FlowLayoutPanel1.AutoScroll = True
        Me.Chao_FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Chao_FlowLayoutPanel1.Location = New System.Drawing.Point(12, 125)
        Me.Chao_FlowLayoutPanel1.Name = "Chao_FlowLayoutPanel1"
        Me.Chao_FlowLayoutPanel1.Size = New System.Drawing.Size(776, 363)
        Me.Chao_FlowLayoutPanel1.TabIndex = 5
        '
        'FormLeibie
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.Chao_FlowLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chao_SearchBox1)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "FormLeibie"
        Me.Text = "类别"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.Chao_SearchBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.Chao_FlowLayoutPanel1, 0)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chao_SearchBox1 As ChaoControls.Chao_SearchBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 所有ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 骑兵ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 步兵ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 欧美ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Chao_FlowLayoutPanel1 As ChaoControls.Chao_FlowLayoutPanel
End Class
