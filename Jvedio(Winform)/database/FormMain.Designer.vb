<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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

    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开视频所在位置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Chao_SearchBox1 = New ChaoControls.Chao_SearchBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.去除重复项ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.清除所有名称ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.清除所有下载信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重置数据库ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormIconPicB
        '
        Me.FormIconPicB.Image = Global.database.My.Resources.Picture.数据库维护服务
        Me.FormIconPicB.Location = New System.Drawing.Point(16, 16)
        '
        'FormTextLabel
        '
        Me.FormTextLabel.Location = New System.Drawing.Point(64, 18)
        Me.FormTextLabel.Size = New System.Drawing.Size(112, 27)
        Me.FormTextLabel.Text = "数据库操作"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(808, 18)
        '
        'TitlePanel
        '
        Me.TitlePanel.BackgroundImage = Global.database.My.Resources.Picture.panel_bg
        Me.TitlePanel.Size = New System.Drawing.Size(998, 64)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(800, 16)
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.ListView1.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(190, 60)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(800, 536)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 114
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "识别码"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "名称"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "标签"
        Me.ColumnHeader4.Width = 50
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "发行商"
        Me.ColumnHeader5.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "制作商"
        Me.ColumnHeader6.Width = 88
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "类别"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "系列"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "导演"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "演员"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.打开视频所在位置ToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(203, 82)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.database.My.Resources.Picture.修改
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(202, 26)
        Me.ToolStripMenuItem2.Text = "修改"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.database.My.Resources.Picture.删除2
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(202, 26)
        Me.ToolStripMenuItem3.Text = "删除"
        '
        '打开视频所在位置ToolStripMenuItem
        '
        Me.打开视频所在位置ToolStripMenuItem.Image = Global.database.My.Resources.Picture.打开文件夹
        Me.打开视频所在位置ToolStripMenuItem.Name = "打开视频所在位置ToolStripMenuItem"
        Me.打开视频所在位置ToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.打开视频所在位置ToolStripMenuItem.Text = "打开视频所在位置"
        '
        'Chao_SearchBox1
        '
        Me.Chao_SearchBox1.AccessibleRole = Nothing
        Me.Chao_SearchBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_SearchBox1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_SearchBox1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_SearchBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_SearchBox1.BackColor = System.Drawing.Color.Transparent
        Me.Chao_SearchBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_SearchBox1.Hint = "Search"
        Me.Chao_SearchBox1.HintColor = System.Drawing.Color.White
        Me.Chao_SearchBox1.Location = New System.Drawing.Point(3, 6)
        Me.Chao_SearchBox1.MaximumSize = New System.Drawing.Size(0, 80)
        Me.Chao_SearchBox1.MinimumSize = New System.Drawing.Size(155, 50)
        Me.Chao_SearchBox1.Name = "Chao_SearchBox1"
        Me.Chao_SearchBox1.SearchBoxColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Chao_SearchBox1.SearchBoxMouseMoveColor = System.Drawing.Color.White
        Me.Chao_SearchBox1.SearchIconColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Chao_SearchBox1.SearchTextForeColor = System.Drawing.Color.White
        Me.Chao_SearchBox1.Size = New System.Drawing.Size(180, 50)
        Me.Chao_SearchBox1.TabIndex = 84
        Me.Chao_SearchBox1.Text = "Search"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.去除重复项ToolStripMenuItem, Me.清除所有名称ToolStripMenuItem, Me.清除所有下载信息ToolStripMenuItem, Me.重置数据库ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.ShowItemToolTips = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(212, 124)
        '
        '去除重复项ToolStripMenuItem
        '
        Me.去除重复项ToolStripMenuItem.Name = "去除重复项ToolStripMenuItem"
        Me.去除重复项ToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.去除重复项ToolStripMenuItem.Text = "去除重复项"
        '
        '清除所有名称ToolStripMenuItem
        '
        Me.清除所有名称ToolStripMenuItem.Name = "清除所有名称ToolStripMenuItem"
        Me.清除所有名称ToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.清除所有名称ToolStripMenuItem.Text = "清除所有名称"
        '
        '清除所有下载信息ToolStripMenuItem
        '
        Me.清除所有下载信息ToolStripMenuItem.Name = "清除所有下载信息ToolStripMenuItem"
        Me.清除所有下载信息ToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.清除所有下载信息ToolStripMenuItem.Text = "清除所有下载信息"
        '
        '重置数据库ToolStripMenuItem
        '
        Me.重置数据库ToolStripMenuItem.Name = "重置数据库ToolStripMenuItem"
        Me.重置数据库ToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.重置数据库ToolStripMenuItem.Text = "重置数据库"
        '
        'Timer2
        '
        Me.Timer2.Interval = 300
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Chao_SearchBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(186, 568)
        Me.Panel2.TabIndex = 66
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(5, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 59)
        Me.Button1.TabIndex = 93
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(0, 505)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(186, 51)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "导入NFO信息"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 438)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 51)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "导入单个视频"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Image = Global.database.My.Resources.Picture.统计
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(0, 375)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 51)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "统计"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(0, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 51)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "去除无效项"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(0, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 51)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "重置数据库"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(0, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 51)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "清除信息"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(0, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 51)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "去除重复项"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Image = Global.database.My.Resources.Picture.刷新1
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(0, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 51)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "刷新"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(190, 600)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(806, 23)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "状态栏"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(1000, 625)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "数据库操作"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.ListView1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents 修改ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 去除重复项ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 清除所有名称ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 清除所有下载信息ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 重置数据库ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Chao_SearchBox1 As ChaoControls.Chao_SearchBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents 打开视频所在位置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
