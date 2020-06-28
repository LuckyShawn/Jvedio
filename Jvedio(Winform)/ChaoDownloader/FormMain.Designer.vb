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
        Dim ce As New ShareClass.ControlExtensions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重新下载ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开文件夹ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.清空ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chao_Button1 = New ChaoControls.Chao_Button()
        Me.Chao_StatusIndicator1 = New ChaoControls.Chao_StatusIndicator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Chao_ContextStripMenu1 = New ChaoControls.Chao_ContextStripMenu()
        Me.打开下载器ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.DownloadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Chao_Panel1 = New ChaoControls.Chao_Panel()
        Me.Chao_Button2 = New ChaoControls.Chao_Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Chao_ContextStripMenu1.SuspendLayout()
        Me.Chao_Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormIconPicB
        '
        Me.FormIconPicB.Image = Global.ChaoDownloader.My.Resources.Resource.下载
        Me.FormIconPicB.Location = New System.Drawing.Point(16, 16)
        '
        'FormTextLabel
        '
        Me.FormTextLabel.Location = New System.Drawing.Point(64, 18)
        Me.FormTextLabel.Size = New System.Drawing.Size(133, 27)
        Me.FormTextLabel.Text = "Jvedio下载器"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(684, 18)
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.White
        Me.TitlePanel.BackgroundImage = Global.ChaoDownloader.My.Resources.Resource.彩色
        Me.TitlePanel.Size = New System.Drawing.Size(874, 64)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(628, 16)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.删除ToolStripMenuItem, Me.重新下载ToolStripMenuItem, Me.打开文件夹ToolStripMenuItem, Me.清空ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(154, 100)
        '
        '删除ToolStripMenuItem
        '
        Me.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem"
        Me.删除ToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.删除ToolStripMenuItem.Text = "删除"
        '
        '重新下载ToolStripMenuItem
        '
        Me.重新下载ToolStripMenuItem.Name = "重新下载ToolStripMenuItem"
        Me.重新下载ToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.重新下载ToolStripMenuItem.Text = "重新下载"
        '
        '打开文件夹ToolStripMenuItem
        '
        Me.打开文件夹ToolStripMenuItem.Name = "打开文件夹ToolStripMenuItem"
        Me.打开文件夹ToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.打开文件夹ToolStripMenuItem.Text = "打开文件夹"
        '
        '清空ToolStripMenuItem
        '
        Me.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem"
        Me.清空ToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.清空ToolStripMenuItem.Text = "清空"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "N.png")
        Me.ImageList2.Images.SetKeyName(1, "S.png")
        Me.ImageList2.Images.SetKeyName(2, "B.png")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "下载2.png")
        Me.ImageList1.Images.SetKeyName(1, "完成.png")
        Me.ImageList1.Images.SetKeyName(2, "删除_回收站.png")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 478)
        Me.Panel1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(-4, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 50)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "清空窗口"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(-5, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 50)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "添加单个"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(-5, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "从数据库载入"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(-5, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "批量添加"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Chao_Button1
        '
        Me.Chao_Button1.AccessibleRole = Nothing
        Me.Chao_Button1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button1.ButtonBackColor = System.Drawing.SystemColors.Control
        Me.Chao_Button1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button1.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button1.ButtonShape = "RoundedRectangle"
        Me.Chao_Button1.ButtonText = "开始"
        Me.Chao_Button1.ButtonType = "ContainedButton"
        Me.Chao_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button1.Image = Nothing
        Me.Chao_Button1.ImagePosition = "Left"
        Me.Chao_Button1.Location = New System.Drawing.Point(3, 6)
        Me.Chao_Button1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button1.Name = "Chao_Button1"
        Me.Chao_Button1.Size = New System.Drawing.Size(115, 50)
        Me.Chao_Button1.TabIndex = 0
        Me.Chao_Button1.TextColor = System.Drawing.Color.White
        '
        'Chao_StatusIndicator1
        '
        Me.Chao_StatusIndicator1.AccessibleRole = Nothing
        Me.Chao_StatusIndicator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_StatusIndicator1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_StatusIndicator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Chao_StatusIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_StatusIndicator1.FailedColor = System.Drawing.Color.Red
        Me.Chao_StatusIndicator1.Location = New System.Drawing.Point(800, 510)
        Me.Chao_StatusIndicator1.MaximumSize = New System.Drawing.Size(50, 50)
        Me.Chao_StatusIndicator1.MinimumSize = New System.Drawing.Size(25, 25)
        Me.Chao_StatusIndicator1.Name = "Chao_StatusIndicator1"
        Me.Chao_StatusIndicator1.RunningColor = System.Drawing.Color.Gray
        Me.Chao_StatusIndicator1.RunningSpeed = 15
        Me.Chao_StatusIndicator1.Size = New System.Drawing.Size(25, 25)
        Me.Chao_StatusIndicator1.StandByColor = System.Drawing.Color.Blue
        Me.Chao_StatusIndicator1.Status = "Success"
        Me.Chao_StatusIndicator1.SuccessColor = System.Drawing.Color.Green
        Me.Chao_StatusIndicator1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(229, 502)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(646, 36)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "状态栏"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Jvedio下载器"
        '
        'Chao_ContextStripMenu1
        '
        Me.Chao_ContextStripMenu1.AutoSize = False
        Me.Chao_ContextStripMenu1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Chao_ContextStripMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开下载器ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.Chao_ContextStripMenu1.Name = "Chao_ContextStripMenu"
        Me.Chao_ContextStripMenu1.Size = New System.Drawing.Size(148, 136)
        '
        '打开下载器ToolStripMenuItem
        '
        Me.打开下载器ToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.打开下载器ToolStripMenuItem.Name = "打开下载器ToolStripMenuItem"
        Me.打开下载器ToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.打开下载器ToolStripMenuItem.Text = "打开下载器"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(236, 338)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(635, 161)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = ""
        '
        'DownloadTimer
        '
        Me.DownloadTimer.Enabled = True
        Me.DownloadTimer.Interval = 1000
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(517, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 31)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "0/0"
        '
        'Chao_Panel1
        '
        Me.Chao_Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_Panel1.Controls.Add(Me.Chao_Button2)
        Me.Chao_Panel1.Controls.Add(Me.ProgressBar1)
        Me.Chao_Panel1.Controls.Add(Me.Chao_Button1)
        Me.Chao_Panel1.Controls.Add(Me.Label6)
        Me.Chao_Panel1.Location = New System.Drawing.Point(236, 72)
        Me.Chao_Panel1.Name = "Chao_Panel1"
        Me.Chao_Panel1.Size = New System.Drawing.Size(635, 59)
        Me.Chao_Panel1.TabIndex = 10
        '
        'Chao_Button2
        '
        Me.Chao_Button2.AccessibleRole = Nothing
        Me.Chao_Button2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button2.ButtonBackColor = System.Drawing.SystemColors.Control
        Me.Chao_Button2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Chao_Button2.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button2.ButtonShape = "RoundedRectangle"
        Me.Chao_Button2.ButtonText = "停止"
        Me.Chao_Button2.ButtonType = "ContainedButton"
        Me.Chao_Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button2.Image = Nothing
        Me.Chao_Button2.ImagePosition = "Left"
        Me.Chao_Button2.Location = New System.Drawing.Point(124, 6)
        Me.Chao_Button2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button2.Name = "Chao_Button2"
        Me.Chao_Button2.Size = New System.Drawing.Size(115, 50)
        Me.Chao_Button2.TabIndex = 3
        Me.Chao_Button2.TextColor = System.Drawing.Color.White
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(285, 19)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(212, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(236, 135)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(635, 197)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "识别码"
        Me.ColumnHeader1.Width = 108
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "状态"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 540)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Chao_Panel1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Chao_StatusIndicator1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.FormShowSetupPicB = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(876, 540)
        Me.Name = "FormMain"
        Me.Text = "Jvedio下载器"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Chao_StatusIndicator1, 0)
        Me.Controls.SetChildIndex(Me.RichTextBox1, 0)
        Me.Controls.SetChildIndex(Me.Chao_Panel1, 0)
        Me.Controls.SetChildIndex(Me.ListView1, 0)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Chao_ContextStripMenu1.ResumeLayout(False)
        Me.Chao_Panel1.ResumeLayout(False)
        Me.Chao_Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 删除ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 重新下载ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开文件夹ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents 清空ToolStripMenuItem As ToolStripMenuItem
    Public WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Chao_ContextStripMenu1 As ChaoControls.Chao_ContextStripMenu
    Friend WithEvents 打开下载器ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents DownloadTimer As Timer
    Friend WithEvents Chao_StatusIndicator1 As ChaoControls.Chao_StatusIndicator
    Friend WithEvents Label5 As Label
    Friend WithEvents Chao_Button1 As ChaoControls.Chao_Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Chao_Panel1 As ChaoControls.Chao_Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Chao_Button2 As ChaoControls.Chao_Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class



