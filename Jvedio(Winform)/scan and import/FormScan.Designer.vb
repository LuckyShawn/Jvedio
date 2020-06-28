<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormScan
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


    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        '防止闪烁
        Dim ce As New ShareClass.ControlExtensions
        ce.DoubleBuffering(ListView3, True)
        ce.DoubleBuffering(ListView2, True)
        ce.DoubleBuffering(ListView4, True)
        ce.DoubleBuffering(ListView1, True)


    End Sub




    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormScan))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开文件夹ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.更改视频类型为ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.其它ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.步兵ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.骑兵ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.刷新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chao_Button1 = New ChaoControls.Chao_Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Chao_TextBox1 = New ChaoControls.Chao_TextBox()
        Me.Chao_Button2 = New ChaoControls.Chao_Button()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.打开文件夹ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Chao_Button3 = New ChaoControls.Chao_Button()
        Me.Chao_TabSelectorBar1 = New ChaoControls.Chao_TabSelectorBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chao_ProgressIndicators1 = New ChaoControls.Chao_ProgressIndicators()
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormIconPicB
        '
        Me.FormIconPicB.Image = Global.Import.My.Resources.Picture.搜索
        Me.FormIconPicB.Location = New System.Drawing.Point(16, 16)
        '
        'FormTextLabel
        '
        Me.FormTextLabel.ForeColor = System.Drawing.Color.White
        Me.FormTextLabel.Location = New System.Drawing.Point(64, 18)
        Me.FormTextLabel.Size = New System.Drawing.Size(112, 27)
        Me.FormTextLabel.Text = "扫描与导入"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(652, 18)
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.DimGray
        Me.TitlePanel.BackgroundImage = Global.Import.My.Resources.Picture.panel_bg

        Me.TitlePanel.Size = New System.Drawing.Size(842, 64)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(596, 16)
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "文件夹 (1).png")
        Me.ImageList1.Images.SetKeyName(1, "视频 (1).png")
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "选择一个文件夹"
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.删除ToolStripMenuItem, Me.打开文件夹ToolStripMenuItem, Me.更改视频类型为ToolStripMenuItem, Me.刷新ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(188, 108)
        '
        '删除ToolStripMenuItem
        '
        Me.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem"
        Me.删除ToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.删除ToolStripMenuItem.Text = "移出列表"
        '
        '打开文件夹ToolStripMenuItem
        '
        Me.打开文件夹ToolStripMenuItem.Name = "打开文件夹ToolStripMenuItem"
        Me.打开文件夹ToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.打开文件夹ToolStripMenuItem.Text = "打开文件夹"
        '
        '更改视频类型为ToolStripMenuItem
        '
        Me.更改视频类型为ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.其它ToolStripMenuItem, Me.步兵ToolStripMenuItem, Me.骑兵ToolStripMenuItem})
        Me.更改视频类型为ToolStripMenuItem.Name = "更改视频类型为ToolStripMenuItem"
        Me.更改视频类型为ToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.更改视频类型为ToolStripMenuItem.Text = "更改视频类型为"
        '
        '其它ToolStripMenuItem
        '
        Me.其它ToolStripMenuItem.Name = "其它ToolStripMenuItem"
        Me.其它ToolStripMenuItem.Size = New System.Drawing.Size(137, 26)
        Me.其它ToolStripMenuItem.Text = "0-其它"
        '
        '步兵ToolStripMenuItem
        '
        Me.步兵ToolStripMenuItem.Name = "步兵ToolStripMenuItem"
        Me.步兵ToolStripMenuItem.Size = New System.Drawing.Size(137, 26)
        Me.步兵ToolStripMenuItem.Text = "1-步兵"
        '
        '骑兵ToolStripMenuItem
        '
        Me.骑兵ToolStripMenuItem.Name = "骑兵ToolStripMenuItem"
        Me.骑兵ToolStripMenuItem.Size = New System.Drawing.Size(137, 26)
        Me.骑兵ToolStripMenuItem.Text = "2-骑兵"
        '
        '刷新ToolStripMenuItem
        '
        Me.刷新ToolStripMenuItem.Image = CType(resources.GetObject("刷新ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem"
        Me.刷新ToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.刷新ToolStripMenuItem.Text = "刷新"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(36, 105)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(844, 500)
        Me.TabControl1.TabIndex = 63
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.Panel1)
        Me.TabPage4.Controls.Add(Me.Chao_Button1)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.PictureBox9)
        Me.TabPage4.Controls.Add(Me.PictureBox8)
        Me.TabPage4.Controls.Add(Me.PictureBox7)
        Me.TabPage4.Controls.Add(Me.PictureBox2)
        Me.TabPage4.Controls.Add(Me.ListView1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(836, 471)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "开始扫描"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(193, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(257, 100)
        Me.Panel1.TabIndex = 86
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Import.My.Resources.Picture.文件夹
        Me.PictureBox3.Location = New System.Drawing.Point(3, 18)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 85
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 27)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "选择或拖入文件夹"
        '
        'Chao_Button1
        '
        Me.Chao_Button1.AccessibleRole = Nothing
        Me.Chao_Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Chao_Button1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button1.ButtonBackColor = System.Drawing.Color.White
        Me.Chao_Button1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Chao_Button1.ButtonFont = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Chao_Button1.ButtonShape = "RoundedRectangle"
        Me.Chao_Button1.ButtonText = "开始扫描"
        Me.Chao_Button1.ButtonType = "ContainedButton"
        Me.Chao_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button1.Image = Nothing
        Me.Chao_Button1.ImagePosition = "Left"
        Me.Chao_Button1.Location = New System.Drawing.Point(323, 394)
        Me.Chao_Button1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button1.Name = "Chao_Button1"
        Me.Chao_Button1.Size = New System.Drawing.Size(160, 70)
        Me.Chao_Button1.TabIndex = 82
        Me.Chao_Button1.TextColor = System.Drawing.Color.White
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label3.Location = New System.Drawing.Point(520, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 31)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "取消扫描"
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox9.Image = Global.Import.My.Resources.Picture.文件夹1
        Me.PictureBox9.Location = New System.Drawing.Point(666, 334)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox9.TabIndex = 80
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox8.Image = Global.Import.My.Resources.Picture.删除1
        Me.PictureBox8.Location = New System.Drawing.Point(720, 334)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 79
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.Import.My.Resources.Picture.清空删除1
        Me.PictureBox7.Location = New System.Drawing.Point(774, 334)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 78
        Me.PictureBox7.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Import.My.Resources.Picture.问号
        Me.PictureBox2.Location = New System.Drawing.Point(612, 334)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 77
        Me.PictureBox2.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.ListView1.AllowDrop = True
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Font = New System.Drawing.Font("楷体", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.HideSelection = False
        Me.ListView1.LabelEdit = True
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(10, 30)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(820, 296)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.TabIndex = 67
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.SmallIcon
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Controls.Add(Me.Chao_TextBox1)
        Me.TabPage5.Controls.Add(Me.Chao_Button2)
        Me.TabPage5.Controls.Add(Me.ListView3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(836, 471)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "扫描结果"
        '
        'Chao_TextBox1
        '
        Me.Chao_TextBox1.AccessibleRole = Nothing
        Me.Chao_TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_TextBox1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_TextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Chao_TextBox1.Hint = "查找识别码"
        Me.Chao_TextBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Chao_TextBox1.Location = New System.Drawing.Point(10, 334)
        Me.Chao_TextBox1.Name = "Chao_TextBox1"
        Me.Chao_TextBox1.Size = New System.Drawing.Size(820, 51)
        Me.Chao_TextBox1.TabIndex = 84
        Me.Chao_TextBox1.Text = "查找识别码"
        Me.Chao_TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Chao_TextBox1.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Chao_TextBox1.TextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_TextBox1.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        '
        'Chao_Button2
        '
        Me.Chao_Button2.AccessibleRole = Nothing
        Me.Chao_Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Chao_Button2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button2.ButtonBackColor = System.Drawing.Color.White
        Me.Chao_Button2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Chao_Button2.ButtonFont = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Chao_Button2.ButtonShape = "RoundedRectangle"
        Me.Chao_Button2.ButtonText = "导入"
        Me.Chao_Button2.ButtonType = "ContainedButton"
        Me.Chao_Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button2.Image = Nothing
        Me.Chao_Button2.ImagePosition = "Left"
        Me.Chao_Button2.Location = New System.Drawing.Point(323, 394)
        Me.Chao_Button2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button2.Name = "Chao_Button2"
        Me.Chao_Button2.Size = New System.Drawing.Size(160, 70)
        Me.Chao_Button2.TabIndex = 83
        Me.Chao_Button2.TextColor = System.Drawing.Color.White
        '
        'ListView3
        '
        Me.ListView3.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.ListView3.AllowColumnReorder = True
        Me.ListView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView3.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListView3.FullRowSelect = True
        Me.ListView3.HideSelection = False
        Me.ListView3.LabelEdit = True
        Me.ListView3.LargeImageList = Me.ImageList1
        Me.ListView3.Location = New System.Drawing.Point(10, 30)
        Me.ListView3.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(820, 296)
        Me.ListView3.SmallImageList = Me.ImageList1
        Me.ListView3.TabIndex = 61
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "识别码"
        Me.ColumnHeader1.Width = 141
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "视频类型"
        Me.ColumnHeader2.Width = 121
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "文件大小"
        Me.ColumnHeader3.Width = 146
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "文件所在位置"
        Me.ColumnHeader4.Width = 185
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.White
        Me.TabPage6.Controls.Add(Me.ListView4)
        Me.TabPage6.Controls.Add(Me.ListView2)
        Me.TabPage6.Controls.Add(Me.Label6)
        Me.TabPage6.Controls.Add(Me.Label7)
        Me.TabPage6.Controls.Add(Me.Chao_Button3)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(836, 471)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "错误统计"
        '
        'ListView4
        '
        Me.ListView4.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.ListView4.AllowColumnReorder = True
        Me.ListView4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListView4.ContextMenuStrip = Me.ContextMenuStrip2
        Me.ListView4.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListView4.FullRowSelect = True
        Me.ListView4.HideSelection = False
        Me.ListView4.LargeImageList = Me.ImageList1
        Me.ListView4.Location = New System.Drawing.Point(52, 10)
        Me.ListView4.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(783, 183)
        Me.ListView4.SmallImageList = Me.ImageList1
        Me.ListView4.TabIndex = 87
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "识别码"
        Me.ColumnHeader9.Width = 141
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "视频类型"
        Me.ColumnHeader10.Width = 121
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "文件大小"
        Me.ColumnHeader11.Width = 146
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "文件所在位置"
        Me.ColumnHeader12.Width = 185
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开文件夹ToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(158, 30)
        '
        '打开文件夹ToolStripMenuItem1
        '
        Me.打开文件夹ToolStripMenuItem1.Image = Global.Import.My.Resources.Picture.文件夹2
        Me.打开文件夹ToolStripMenuItem1.Name = "打开文件夹ToolStripMenuItem1"
        Me.打开文件夹ToolStripMenuItem1.Size = New System.Drawing.Size(157, 26)
        Me.打开文件夹ToolStripMenuItem1.Text = "打开文件夹"
        '
        'ListView2
        '
        Me.ListView2.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.ListView2.AllowColumnReorder = True
        Me.ListView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView2.ContextMenuStrip = Me.ContextMenuStrip2
        Me.ListView2.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.HideSelection = False
        Me.ListView2.LargeImageList = Me.ImageList1
        Me.ListView2.Location = New System.Drawing.Point(52, 201)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(783, 186)
        Me.ListView2.SmallImageList = Me.ImageList1
        Me.ListView2.TabIndex = 86
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "识别码"
        Me.ColumnHeader5.Width = 141
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "视频类型"
        Me.ColumnHeader6.Width = 121
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "文件大小"
        Me.ColumnHeader7.Width = 146
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "文件所在位置"
        Me.ColumnHeader8.Width = 185
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 10)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 183)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "未识别的视频"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightBlue
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 201)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 186)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "重复的视频"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Chao_Button3
        '
        Me.Chao_Button3.AccessibleRole = Nothing
        Me.Chao_Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Chao_Button3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button3.ButtonBackColor = System.Drawing.Color.White
        Me.Chao_Button3.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Chao_Button3.ButtonFont = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Chao_Button3.ButtonShape = "RoundedRectangle"
        Me.Chao_Button3.ButtonText = "生成报告"
        Me.Chao_Button3.ButtonType = "ContainedButton"
        Me.Chao_Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button3.Image = Nothing
        Me.Chao_Button3.ImagePosition = "Left"
        Me.Chao_Button3.Location = New System.Drawing.Point(323, 394)
        Me.Chao_Button3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button3.Name = "Chao_Button3"
        Me.Chao_Button3.Size = New System.Drawing.Size(160, 70)
        Me.Chao_Button3.TabIndex = 84
        Me.Chao_Button3.TextColor = System.Drawing.Color.White
        '
        'Chao_TabSelectorBar1
        '
        Me.Chao_TabSelectorBar1.AccessibleRole = Nothing
        Me.Chao_TabSelectorBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_TabSelectorBar1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_TabSelectorBar1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_TabSelectorBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_TabSelectorBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_TabSelectorBar1.BaseTabControl = Me.TabControl1
        Me.Chao_TabSelectorBar1.ImageDrawStyle = "Leading"
        Me.Chao_TabSelectorBar1.Index = -1
        Me.Chao_TabSelectorBar1.Location = New System.Drawing.Point(0, 60)
        Me.Chao_TabSelectorBar1.MaximumSize = New System.Drawing.Size(0, 50)
        Me.Chao_TabSelectorBar1.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Chao_TabSelectorBar1.Name = "Chao_TabSelectorBar1"
        Me.Chao_TabSelectorBar1.Size = New System.Drawing.Size(844, 50)
        Me.Chao_TabSelectorBar1.SlideColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Chao_TabSelectorBar1.SlideHeight = 2.0!
        Me.Chao_TabSelectorBar1.TabBackColor = System.Drawing.Color.White
        Me.Chao_TabSelectorBar1.TabFont = New System.Drawing.Font("楷体", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Chao_TabSelectorBar1.TabForeColor = System.Drawing.Color.Black
        Me.Chao_TabSelectorBar1.TabImageList = Nothing
        Me.Chao_TabSelectorBar1.TabIndex = 65
        Me.Chao_TabSelectorBar1.TabSelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(200, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 577)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(842, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "状态栏"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Chao_ProgressIndicators1
        '
        Me.Chao_ProgressIndicators1.AccessibleRole = Nothing
        Me.Chao_ProgressIndicators1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_ProgressIndicators1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_ProgressIndicators1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_ProgressIndicators1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_ProgressIndicators1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_ProgressIndicators1.BarBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Chao_ProgressIndicators1.BarFilledColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_ProgressIndicators1.Location = New System.Drawing.Point(0, 567)
        Me.Chao_ProgressIndicators1.Name = "Chao_ProgressIndicators1"
        Me.Chao_ProgressIndicators1.ProgressType = "Linear"
        Me.Chao_ProgressIndicators1.Size = New System.Drawing.Size(842, 10)
        Me.Chao_ProgressIndicators1.TabIndex = 86
        '
        'FormScan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(844, 607)
        Me.Controls.Add(Me.Chao_ProgressIndicators1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Chao_TabSelectorBar1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormShowSetupPicB = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(844, 600)
        Me.Name = "FormScan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "扫描与导入"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.Chao_TabSelectorBar1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Chao_ProgressIndicators1, 0)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 删除ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer6 As Timer
    Friend WithEvents 打开文件夹ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents ListView3 As ListView
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Chao_TabSelectorBar1 As ChaoControls.Chao_TabSelectorBar
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Chao_Button1 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button2 As ChaoControls.Chao_Button
    Friend WithEvents Chao_TextBox1 As ChaoControls.Chao_TextBox
    Friend WithEvents Chao_Button3 As ChaoControls.Chao_Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents 更改视频类型为ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 其它ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 步兵ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 骑兵ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents 刷新ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListView4 As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents 打开文件夹ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Chao_ProgressIndicators1 As ChaoControls.Chao_ProgressIndicators
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class



