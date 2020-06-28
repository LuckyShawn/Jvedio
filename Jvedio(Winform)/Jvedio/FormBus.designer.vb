<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBus
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

        FUN_CMS.Renderer = New Chao_SimpleMenuStripRender(200, Color.FromArgb(40, 40, 40), Color.FromArgb(148, 149, 153))
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBus))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ExtraPanel = New System.Windows.Forms.Panel()
        Me.FUN_CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.打开影片位置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开照片位置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开其网址ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PicBYY = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.打开位置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FUN_CMS.SuspendLayout()
        CType(Me.PicBYY, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FormTextLabel.Size = New System.Drawing.Size(70, 27)
        Me.FormTextLabel.Text = "BigPic"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(1211, 20)
        Me.SetPicB.Margin = New System.Windows.Forms.Padding(4)
        '
        'TitlePicB
        '
        Me.TitlePicB.Size = New System.Drawing.Size(1169, 45)
        '
        'TitlePanel
        '
        Me.TitlePanel.Size = New System.Drawing.Size(1401, 64)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(1203, 16)
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.ExtraPanel)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 72)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1400, 796)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 600)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label14)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label15)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label16)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label17)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label18)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label19)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label20)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label21)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel6)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel5)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel1.SetFlowBreak(Me.FlowLayoutPanel2, True)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(823, 16)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(214, 526)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "名称："
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.FlowLayoutPanel2.SetFlowBreak(Me.Label14, True)
        Me.Label14.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(84, 10)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 27)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Label14"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 27)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "发行日期："
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.FlowLayoutPanel2.SetFlowBreak(Me.Label15, True)
        Me.Label15.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(124, 49)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 27)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Label15"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 27)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "长度："
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.FlowLayoutPanel2.SetFlowBreak(Me.Label16, True)
        Me.Label16.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label16.Location = New System.Drawing.Point(84, 88)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 27)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Label16"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 123)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 27)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "导演："
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlowLayoutPanel2.SetFlowBreak(Me.Label17, True)
        Me.Label17.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.Location = New System.Drawing.Point(84, 127)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 27)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Label17"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 162)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 27)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "制作商："
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlowLayoutPanel2.SetFlowBreak(Me.Label18, True)
        Me.Label18.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label18.Location = New System.Drawing.Point(104, 166)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 27)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Label18"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 201)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 27)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "发行商："
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlowLayoutPanel2.SetFlowBreak(Me.Label19, True)
        Me.Label19.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label19.Location = New System.Drawing.Point(104, 205)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 27)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Label19"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label20.Location = New System.Drawing.Point(4, 240)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 27)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "系列："
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlowLayoutPanel2.SetFlowBreak(Me.Label21, True)
        Me.Label21.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label21.Location = New System.Drawing.Point(84, 244)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 27)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Label21"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel2.SetFlowBreak(Me.Label6, True)
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 277)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 27)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "类别："
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel3.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel2.SetFlowBreak(Me.FlowLayoutPanel3, True)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(4, 314)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(52, 29)
        Me.FlowLayoutPanel3.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(4, 6)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 6, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "中出"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel2.SetFlowBreak(Me.Label7, True)
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 351)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 27)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "演员："
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.AutoSize = True
        Me.FlowLayoutPanel6.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel6.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel2.SetFlowBreak(Me.FlowLayoutPanel6, True)
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(4, 388)
        Me.FlowLayoutPanel6.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(52, 29)
        Me.FlowLayoutPanel6.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(4, 6)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 6, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 23)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "中出"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel2.SetFlowBreak(Me.Label8, True)
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 425)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 27)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "标签："
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.AutoSize = True
        Me.FlowLayoutPanel5.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel5.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel2.SetFlowBreak(Me.FlowLayoutPanel5, True)
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(4, 462)
        Me.FlowLayoutPanel5.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(31, 29)
        Me.FlowLayoutPanel5.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(4, 6)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 6, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 23)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "+"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel2.SetFlowBreak(Me.Label13, True)
        Me.Label13.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 499)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 27)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "额外图片："
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.AutoSize = True
        Me.FlowLayoutPanel4.Controls.Add(Me.PictureBox2)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(17, 622)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(167, 113)
        Me.FlowLayoutPanel4.TabIndex = 18
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(159, 105)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'ExtraPanel
        '
        Me.ExtraPanel.Location = New System.Drawing.Point(191, 621)
        Me.ExtraPanel.Name = "ExtraPanel"
        Me.ExtraPanel.Size = New System.Drawing.Size(200, 100)
        Me.ExtraPanel.TabIndex = 19
        '
        'FUN_CMS
        '
        Me.FUN_CMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FUN_CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开影片位置ToolStripMenuItem, Me.打开照片位置ToolStripMenuItem, Me.复制ToolStripMenuItem, Me.打开其网址ToolStripMenuItem, Me.EditInfoToolStripMenuItem})
        Me.FUN_CMS.Name = "ContextMenuStrip1"
        Me.FUN_CMS.Size = New System.Drawing.Size(169, 124)
        '
        '打开影片位置ToolStripMenuItem
        '
        Me.打开影片位置ToolStripMenuItem.Name = "打开影片位置ToolStripMenuItem"
        Me.打开影片位置ToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.打开影片位置ToolStripMenuItem.Text = "打开影片位置"
        '
        '打开照片位置ToolStripMenuItem
        '
        Me.打开照片位置ToolStripMenuItem.Name = "打开照片位置ToolStripMenuItem"
        Me.打开照片位置ToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.打开照片位置ToolStripMenuItem.Text = "打开照片位置"
        '
        '复制ToolStripMenuItem
        '
        Me.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem"
        Me.复制ToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.复制ToolStripMenuItem.Text = "复制文件"
        '
        '打开其网址ToolStripMenuItem
        '
        Me.打开其网址ToolStripMenuItem.Name = "打开其网址ToolStripMenuItem"
        Me.打开其网址ToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.打开其网址ToolStripMenuItem.Text = "打开网址"
        '
        'EditInfoToolStripMenuItem
        '
        Me.EditInfoToolStripMenuItem.Name = "EditInfoToolStripMenuItem"
        Me.EditInfoToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.EditInfoToolStripMenuItem.Text = "编辑信息"
        '
        'PicBYY
        '
        Me.PicBYY.Location = New System.Drawing.Point(451, 64)
        Me.PicBYY.Name = "PicBYY"
        Me.PicBYY.Size = New System.Drawing.Size(88, 33)
        Me.PicBYY.TabIndex = 2
        Me.PicBYY.TabStop = False
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
        'FormBus
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1403, 872)
        Me.Controls.Add(Me.PicBYY)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormBus"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BigPic"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.FlowLayoutPanel1, 0)
        Me.Controls.SetChildIndex(Me.PicBYY, 0)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.FlowLayoutPanel6.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel5.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FUN_CMS.ResumeLayout(False)
        CType(Me.PicBYY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents FUN_CMS As ContextMenuStrip
    Friend WithEvents 打开影片位置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开照片位置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 复制ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开其网址ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PicBYY As PictureBox
    Friend WithEvents ExtraPanel As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 打开位置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
