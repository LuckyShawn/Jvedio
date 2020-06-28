<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormYanyuan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormYanyuan))
        Me.Chao_SearchBox1 = New ChaoControls.Chao_SearchBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.所有ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.骑兵ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.步兵ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.欧美ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chao_TextBox1 = New ChaoControls.Chao_TextBox()
        Me.Chao_Button3 = New ChaoControls.Chao_Button()
        Me.Chao_Button1 = New ChaoControls.Chao_Button()
        Me.Chao_Button2 = New ChaoControls.Chao_Button()
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
        Me.FormTextLabel.Text = "演员"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(708, 20)
        '
        'TitlePanel
        '
        Me.TitlePanel.Size = New System.Drawing.Size(955, 64)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(757, 16)
        '
        'Chao_SearchBox1
        '
        Me.Chao_SearchBox1.AccessibleRole = Nothing
        Me.Chao_SearchBox1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_SearchBox1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_SearchBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_SearchBox1.BackColor = System.Drawing.Color.Transparent
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
        Me.PictureBox1.Location = New System.Drawing.Point(448, 69)
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
        Me.Label1.Location = New System.Drawing.Point(348, 69)
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
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(795, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 51)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "/0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Chao_TextBox1
        '
        Me.Chao_TextBox1.AccessibleRole = Nothing
        Me.Chao_TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_TextBox1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_TextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Chao_TextBox1.Hint = "Hint"
        Me.Chao_TextBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_TextBox1.Location = New System.Drawing.Point(689, 69)
        Me.Chao_TextBox1.Name = "Chao_TextBox1"
        Me.Chao_TextBox1.Size = New System.Drawing.Size(100, 51)
        Me.Chao_TextBox1.TabIndex = 7
        Me.Chao_TextBox1.Text = "0"
        Me.Chao_TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Chao_TextBox1.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Chao_TextBox1.TextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_TextBox1.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'Chao_Button3
        '
        Me.Chao_Button3.AccessibleRole = Nothing
        Me.Chao_Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_Button3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button3.ButtonBackColor = System.Drawing.Color.Transparent
        Me.Chao_Button3.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button3.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button3.ButtonShape = "Ellipse"
        Me.Chao_Button3.ButtonText = ""
        Me.Chao_Button3.ButtonType = "ContainedButton"
        Me.Chao_Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button3.Image = Global.Jvedio.My.Resources.Resource_Image.Arrow_Right
        Me.Chao_Button3.ImagePosition = "Left"
        Me.Chao_Button3.Location = New System.Drawing.Point(901, 69)
        Me.Chao_Button3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button3.Name = "Chao_Button3"
        Me.Chao_Button3.Size = New System.Drawing.Size(50, 50)
        Me.Chao_Button3.TabIndex = 6
        Me.Chao_Button3.TextColor = System.Drawing.Color.White
        '
        'Chao_Button1
        '
        Me.Chao_Button1.AccessibleRole = Nothing
        Me.Chao_Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_Button1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button1.ButtonBackColor = System.Drawing.Color.Transparent
        Me.Chao_Button1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button1.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button1.ButtonShape = "Ellipse"
        Me.Chao_Button1.ButtonText = ""
        Me.Chao_Button1.ButtonType = "ContainedButton"
        Me.Chao_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button1.Image = Global.Jvedio.My.Resources.Resource_Image.Arrow_Left
        Me.Chao_Button1.ImagePosition = "Left"
        Me.Chao_Button1.Location = New System.Drawing.Point(633, 69)
        Me.Chao_Button1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button1.Name = "Chao_Button1"
        Me.Chao_Button1.Size = New System.Drawing.Size(50, 50)
        Me.Chao_Button1.TabIndex = 5
        Me.Chao_Button1.TextColor = System.Drawing.Color.White
        '
        'Chao_Button2
        '
        Me.Chao_Button2.AccessibleRole = Nothing
        Me.Chao_Button2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button2.ButtonBackColor = System.Drawing.Color.Transparent
        Me.Chao_Button2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Chao_Button2.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button2.ButtonShape = "RoundedRectangle"
        Me.Chao_Button2.ButtonText = "刷新"
        Me.Chao_Button2.ButtonType = "ContainedButton"
        Me.Chao_Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button2.Image = Nothing
        Me.Chao_Button2.ImagePosition = "Left"
        Me.Chao_Button2.Location = New System.Drawing.Point(503, 67)
        Me.Chao_Button2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button2.Name = "Chao_Button2"
        Me.Chao_Button2.Size = New System.Drawing.Size(120, 50)
        Me.Chao_Button2.TabIndex = 47
        Me.Chao_Button2.TextColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'Chao_FlowLayoutPanel1
        '
        Me.Chao_FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_FlowLayoutPanel1.AutoScroll = True
        Me.Chao_FlowLayoutPanel1.Location = New System.Drawing.Point(13, 137)
        Me.Chao_FlowLayoutPanel1.Name = "Chao_FlowLayoutPanel1"
        Me.Chao_FlowLayoutPanel1.Size = New System.Drawing.Size(932, 351)
        Me.Chao_FlowLayoutPanel1.TabIndex = 48
        '
        'FormYanyuan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(957, 500)
        Me.Controls.Add(Me.Chao_FlowLayoutPanel1)
        Me.Controls.Add(Me.Chao_Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Chao_TextBox1)
        Me.Controls.Add(Me.Chao_Button3)
        Me.Controls.Add(Me.Chao_Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chao_SearchBox1)
        Me.MinimumSize = New System.Drawing.Size(957, 500)
        Me.Name = "FormYanyuan"
        Me.Text = "演员"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.Chao_SearchBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button1, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button3, 0)
        Me.Controls.SetChildIndex(Me.Chao_TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button2, 0)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Chao_TextBox1 As ChaoControls.Chao_TextBox
    Friend WithEvents Chao_Button3 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button1 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button2 As ChaoControls.Chao_Button
    Friend WithEvents Chao_FlowLayoutPanel1 As ChaoControls.Chao_FlowLayoutPanel
End Class
