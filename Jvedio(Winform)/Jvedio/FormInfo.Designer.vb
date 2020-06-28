<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInfo
    Inherits System.Windows.Forms.Form

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

        ' 在 InitializeComponent() 调用之后添加任何初始化。        '设置显示模式

        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True) '禁止擦除背景.
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True) '双缓冲
        Me.UpdateStyles()

        ContextMenuStrip1.Renderer = New Chao_SimpleMenuStripRender(150, Color.FromArgb(40, 40, 40), Color.FromArgb(148, 149, 153))


    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInfo))
        Me.Title_label = New System.Windows.Forms.Label()
        Me.SomeInfo_label = New System.Windows.Forms.Label()
        Me.zhizuoshang_label = New System.Windows.Forms.Label()
        Me.faxingshang_label = New System.Windows.Forms.Label()
        Me.daoyan_label = New System.Windows.Forms.Label()
        Me.xilie_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.love_ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BigPicCompleteTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PicBYY = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.打开位置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Chao_Panel1 = New ChaoControls.Chao_Panel()
        Me.Chao_FlowLayoutPanel1 = New ChaoControls.Chao_FlowLayoutPanel()
        Me.Chao_FlowLayoutPanel3 = New ChaoControls.Chao_FlowLayoutPanel()
        Me.Chao_FlowLayoutPanel2 = New ChaoControls.Chao_FlowLayoutPanel()
        Me.Chao_Panel2 = New ChaoControls.Chao_Panel()
        Me.DownLoadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ExtraPicCompleteTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.love_ContextMenuStrip.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBYY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Chao_FlowLayoutPanel1.SuspendLayout()
        Me.Chao_Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title_label
        '
        Me.Title_label.AutoSize = True
        Me.Title_label.BackColor = System.Drawing.Color.Transparent
        Me.Chao_FlowLayoutPanel1.SetFlowBreak(Me.Title_label, True)
        Me.Title_label.Font = New System.Drawing.Font("楷体", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Title_label.ForeColor = System.Drawing.Color.White
        Me.Title_label.Location = New System.Drawing.Point(5, 5)
        Me.Title_label.Margin = New System.Windows.Forms.Padding(5)
        Me.Title_label.Name = "Title_label"
        Me.Title_label.Size = New System.Drawing.Size(75, 30)
        Me.Title_label.TabIndex = 3
        Me.Title_label.Text = "标题"
        '
        'SomeInfo_label
        '
        Me.SomeInfo_label.AutoSize = True
        Me.SomeInfo_label.BackColor = System.Drawing.Color.Transparent
        Me.Chao_FlowLayoutPanel1.SetFlowBreak(Me.SomeInfo_label, True)
        Me.SomeInfo_label.Font = New System.Drawing.Font("幼圆", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SomeInfo_label.ForeColor = System.Drawing.Color.White
        Me.SomeInfo_label.Location = New System.Drawing.Point(5, 157)
        Me.SomeInfo_label.Margin = New System.Windows.Forms.Padding(5)
        Me.SomeInfo_label.Name = "SomeInfo_label"
        Me.SomeInfo_label.Size = New System.Drawing.Size(255, 18)
        Me.SomeInfo_label.TabIndex = 4
        Me.SomeInfo_label.Text = "评分、发行日期、长度等信息"
        '
        'zhizuoshang_label
        '
        Me.zhizuoshang_label.AutoSize = True
        Me.zhizuoshang_label.BackColor = System.Drawing.Color.Transparent
        Me.zhizuoshang_label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_FlowLayoutPanel1.SetFlowBreak(Me.zhizuoshang_label, True)
        Me.zhizuoshang_label.Font = New System.Drawing.Font("幼圆", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.zhizuoshang_label.ForeColor = System.Drawing.Color.White
        Me.zhizuoshang_label.Location = New System.Drawing.Point(5, 129)
        Me.zhizuoshang_label.Margin = New System.Windows.Forms.Padding(5)
        Me.zhizuoshang_label.Name = "zhizuoshang_label"
        Me.zhizuoshang_label.Size = New System.Drawing.Size(84, 18)
        Me.zhizuoshang_label.TabIndex = 5
        Me.zhizuoshang_label.Text = "制作商："
        '
        'faxingshang_label
        '
        Me.faxingshang_label.AutoSize = True
        Me.faxingshang_label.BackColor = System.Drawing.Color.Transparent
        Me.faxingshang_label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_FlowLayoutPanel1.SetFlowBreak(Me.faxingshang_label, True)
        Me.faxingshang_label.Font = New System.Drawing.Font("幼圆", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.faxingshang_label.ForeColor = System.Drawing.Color.White
        Me.faxingshang_label.Location = New System.Drawing.Point(5, 101)
        Me.faxingshang_label.Margin = New System.Windows.Forms.Padding(5)
        Me.faxingshang_label.Name = "faxingshang_label"
        Me.faxingshang_label.Size = New System.Drawing.Size(84, 18)
        Me.faxingshang_label.TabIndex = 6
        Me.faxingshang_label.Text = "发行商："
        '
        'daoyan_label
        '
        Me.daoyan_label.AutoSize = True
        Me.daoyan_label.BackColor = System.Drawing.Color.Transparent
        Me.daoyan_label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_FlowLayoutPanel1.SetFlowBreak(Me.daoyan_label, True)
        Me.daoyan_label.Font = New System.Drawing.Font("幼圆", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.daoyan_label.ForeColor = System.Drawing.Color.White
        Me.daoyan_label.Location = New System.Drawing.Point(5, 73)
        Me.daoyan_label.Margin = New System.Windows.Forms.Padding(5)
        Me.daoyan_label.Name = "daoyan_label"
        Me.daoyan_label.Size = New System.Drawing.Size(65, 18)
        Me.daoyan_label.TabIndex = 7
        Me.daoyan_label.Text = "导演："
        '
        'xilie_label
        '
        Me.xilie_label.AutoSize = True
        Me.xilie_label.BackColor = System.Drawing.Color.Transparent
        Me.xilie_label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_FlowLayoutPanel1.SetFlowBreak(Me.xilie_label, True)
        Me.xilie_label.Font = New System.Drawing.Font("幼圆", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.xilie_label.ForeColor = System.Drawing.Color.White
        Me.xilie_label.Location = New System.Drawing.Point(5, 45)
        Me.xilie_label.Margin = New System.Windows.Forms.Padding(5)
        Me.xilie_label.Name = "xilie_label"
        Me.xilie_label.Size = New System.Drawing.Size(65, 18)
        Me.xilie_label.TabIndex = 8
        Me.xilie_label.Text = "系列："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("幼圆", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 481)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 27)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "预览图"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("幼圆", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(1227, 571)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 86)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = ">"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'love_ContextMenuStrip
        '
        Me.love_ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.love_ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.love_ContextMenuStrip.Name = "ContextMenuStrip6"
        Me.love_ContextMenuStrip.Size = New System.Drawing.Size(88, 148)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(87, 24)
        Me.ToolStripMenuItem1.Text = "0"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(87, 24)
        Me.ToolStripMenuItem2.Text = "1"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(87, 24)
        Me.ToolStripMenuItem3.Text = "2"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(87, 24)
        Me.ToolStripMenuItem4.Text = "3"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(87, 24)
        Me.ToolStripMenuItem5.Text = "4"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(87, 24)
        Me.ToolStripMenuItem6.Text = "5"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("幼圆", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 571)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 86)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "<"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BigPicCompleteTimer
        '
        Me.BigPicCompleteTimer.Enabled = True
        Me.BigPicCompleteTimer.Interval = 1000
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox7.Image = Global.Jvedio.My.Resources.Resource_FormInfo.右1
        Me.PictureBox7.Location = New System.Drawing.Point(1223, 415)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 21
        Me.PictureBox7.TabStop = False
        '
        'PicBYY
        '
        Me.PicBYY.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PicBYY.Location = New System.Drawing.Point(83, 415)
        Me.PicBYY.Name = "PicBYY"
        Me.PicBYY.Size = New System.Drawing.Size(39, 49)
        Me.PicBYY.TabIndex = 19
        Me.PicBYY.TabStop = False
        Me.PicBYY.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox8.Image = Global.Jvedio.My.Resources.Resource_FormInfo.编辑
        Me.PictureBox8.Location = New System.Drawing.Point(653, 415)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(100, 42)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox8.TabIndex = 17
        Me.PictureBox8.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.Jvedio.My.Resources.Resource_FormInfo.返回1
        Me.PictureBox6.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 13
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(545, 415)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 42)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.Jvedio.My.Resources.Resource_FormInfo.喜爱
        Me.PictureBox4.Location = New System.Drawing.Point(437, 415)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Jvedio.My.Resources.Resource_FormInfo.播放
        Me.PictureBox3.Location = New System.Drawing.Point(326, 415)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(41, 62)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(267, 338)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox9.Image = Global.Jvedio.My.Resources.Resource_FormInfo.左1
        Me.PictureBox9.Location = New System.Drawing.Point(5, 415)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox9.TabIndex = 22
        Me.PictureBox9.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开位置ToolStripMenuItem, Me.删除文件ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(139, 52)
        '
        '打开位置ToolStripMenuItem
        '
        Me.打开位置ToolStripMenuItem.Name = "打开位置ToolStripMenuItem"
        Me.打开位置ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.打开位置ToolStripMenuItem.Text = "打开位置"
        '
        '删除文件ToolStripMenuItem
        '
        Me.删除文件ToolStripMenuItem.Name = "删除文件ToolStripMenuItem"
        Me.删除文件ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.删除文件ToolStripMenuItem.Text = "删除文件"
        '
        'Chao_Panel1
        '
        Me.Chao_Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Chao_Panel1.Location = New System.Drawing.Point(83, 542)
        Me.Chao_Panel1.Name = "Chao_Panel1"
        Me.Chao_Panel1.Size = New System.Drawing.Size(1123, 195)
        Me.Chao_Panel1.TabIndex = 24
        '
        'Chao_FlowLayoutPanel1
        '
        Me.Chao_FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Chao_FlowLayoutPanel1.Controls.Add(Me.Title_label)
        Me.Chao_FlowLayoutPanel1.Controls.Add(Me.xilie_label)
        Me.Chao_FlowLayoutPanel1.Controls.Add(Me.daoyan_label)
        Me.Chao_FlowLayoutPanel1.Controls.Add(Me.faxingshang_label)
        Me.Chao_FlowLayoutPanel1.Controls.Add(Me.zhizuoshang_label)
        Me.Chao_FlowLayoutPanel1.Controls.Add(Me.SomeInfo_label)
        Me.Chao_FlowLayoutPanel1.Controls.Add(Me.Chao_FlowLayoutPanel3)
        Me.Chao_FlowLayoutPanel1.Controls.Add(Me.Chao_FlowLayoutPanel2)
        Me.Chao_FlowLayoutPanel1.Location = New System.Drawing.Point(326, 12)
        Me.Chao_FlowLayoutPanel1.Name = "Chao_FlowLayoutPanel1"
        Me.Chao_FlowLayoutPanel1.Size = New System.Drawing.Size(945, 388)
        Me.Chao_FlowLayoutPanel1.TabIndex = 25
        '
        'Chao_FlowLayoutPanel3
        '
        Me.Chao_FlowLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_FlowLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Chao_FlowLayoutPanel1.SetFlowBreak(Me.Chao_FlowLayoutPanel3, True)
        Me.Chao_FlowLayoutPanel3.Location = New System.Drawing.Point(4, 184)
        Me.Chao_FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_FlowLayoutPanel3.Name = "Chao_FlowLayoutPanel3"
        Me.Chao_FlowLayoutPanel3.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.Chao_FlowLayoutPanel3.Size = New System.Drawing.Size(937, 72)
        Me.Chao_FlowLayoutPanel3.TabIndex = 26
        '
        'Chao_FlowLayoutPanel2
        '
        Me.Chao_FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_FlowLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Chao_FlowLayoutPanel1.SetFlowBreak(Me.Chao_FlowLayoutPanel2, True)
        Me.Chao_FlowLayoutPanel2.Location = New System.Drawing.Point(4, 264)
        Me.Chao_FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_FlowLayoutPanel2.Name = "Chao_FlowLayoutPanel2"
        Me.Chao_FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.Chao_FlowLayoutPanel2.Size = New System.Drawing.Size(937, 61)
        Me.Chao_FlowLayoutPanel2.TabIndex = 26
        '
        'Chao_Panel2
        '
        Me.Chao_Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Chao_Panel2.Controls.Add(Me.Label_ID)
        Me.Chao_Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Chao_Panel2.MinimumSize = New System.Drawing.Size(0, 780)
        Me.Chao_Panel2.Name = "Chao_Panel2"
        Me.Chao_Panel2.Size = New System.Drawing.Size(1280, 790)
        Me.Chao_Panel2.TabIndex = 26
        '
        'DownLoadTimer
        '
        Me.DownLoadTimer.Enabled = True
        Me.DownLoadTimer.Interval = 1
        '
        'ExtraPicCompleteTimer
        '
        Me.ExtraPicCompleteTimer.Enabled = True
        Me.ExtraPicCompleteTimer.Interval = 1000
        '
        'Label_ID
        '
        Me.Label_ID.AutoSize = True
        Me.Label_ID.BackColor = System.Drawing.Color.Transparent
        Me.Label_ID.Location = New System.Drawing.Point(12, 766)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(55, 15)
        Me.Label_ID.TabIndex = 0
        Me.Label_ID.Text = "Label2"
        '
        'FormInfo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1280, 790)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Chao_FlowLayoutPanel1)
        Me.Controls.Add(Me.Chao_Panel1)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PicBYY)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Chao_Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info"
        Me.love_ContextMenuStrip.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBYY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Chao_FlowLayoutPanel1.ResumeLayout(False)
        Me.Chao_FlowLayoutPanel1.PerformLayout()
        Me.Chao_Panel2.ResumeLayout(False)
        Me.Chao_Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Title_label As Label
    Friend WithEvents SomeInfo_label As Label
    Friend WithEvents zhizuoshang_label As Label
    Friend WithEvents faxingshang_label As Label
    Friend WithEvents daoyan_label As Label
    Friend WithEvents xilie_label As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents love_ContextMenuStrip As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PicBYY As PictureBox
    Friend WithEvents BigPicCompleteTimer As Timer
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 打开位置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Chao_Panel1 As ChaoControls.Chao_Panel
    Friend WithEvents Chao_FlowLayoutPanel1 As ChaoControls.Chao_FlowLayoutPanel
    Friend WithEvents Chao_FlowLayoutPanel2 As ChaoControls.Chao_FlowLayoutPanel
    Friend WithEvents Chao_FlowLayoutPanel3 As ChaoControls.Chao_FlowLayoutPanel
    Friend WithEvents Chao_Panel2 As ChaoControls.Chao_Panel
    Friend WithEvents DownLoadTimer As Timer
    Friend WithEvents ExtraPicCompleteTimer As Timer
    Friend WithEvents Label_ID As Label
End Class
