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

        FUN_CMS.Renderer = New Chao_SimpleMenuStripRender(200, Color.FromArgb(245, 245, 245), Color.FromArgb(50, 60, 60))
        Sort_CMS.Renderer = New Chao_SimpleMenuStripRender(PictureBox5.Width + Label12.Width + Label13.Width, Color.FromArgb(185, 211, 221), Color.FromArgb(59, 132, 173))
        RefreshCMS.Renderer = New Chao_SimpleMenuStripRender(100, Color.FromArgb(40, 40, 40), Color.FromArgb(148, 149, 153))
        MIN_CMS.Renderer = New Chao_SimpleMenuStripRender(100, Color.FromArgb(241, 221, 187), Color.FromArgb(252, 132, 35))

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
        Me.FUN_CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.打开影片位置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开照片位置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开其网址ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除该番号ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除该文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Sort_CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.番号ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.名称ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.文件大小ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.导入时间ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.发行日期ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.喜爱程度ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.访问次数ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DEL_CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.刷新ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MIN_CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.打开主窗体ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoveCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.小图ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.大图ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.下载 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownLoadingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ArrowPicb = New System.Windows.Forms.PictureBox()
        Me.Chao_Panel1 = New ChaoControls.Chao_Panel()
        Me.Label_5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chao_SearchBox1 = New ChaoControls.Chao_SearchBox()
        Me.Label_4 = New System.Windows.Forms.Label()
        Me.Label_3 = New System.Windows.Forms.Label()
        Me.Label_2 = New System.Windows.Forms.Label()
        Me.Label_1 = New System.Windows.Forms.Label()
        Me.Label_0 = New System.Windows.Forms.Label()
        Me.Chao_Panel2 = New ChaoControls.Chao_Panel()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.Chao_StatusIndicator1 = New ChaoControls.Chao_StatusIndicator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chao_Panel3 = New ChaoControls.Chao_Panel()
        Me.Chao_CheckBox2 = New ChaoControls.Chao_CheckBox()
        Me.Chao_Button2 = New ChaoControls.Chao_Button()
        Me.Chao_CheckBox1 = New ChaoControls.Chao_CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chao_TextBox1 = New ChaoControls.Chao_TextBox()
        Me.Chao_Button3 = New ChaoControls.Chao_Button()
        Me.Chao_Button1 = New ChaoControls.Chao_Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chao_Button4 = New ChaoControls.Chao_Button()
        Me.Chao_Button5 = New ChaoControls.Chao_Button()
        Me.Chao_Button6 = New ChaoControls.Chao_Button()
        Me.Chao_Button7 = New ChaoControls.Chao_Button()
        Me.Chao_Button9 = New ChaoControls.Chao_Button()
        Me.Chao_Button10 = New ChaoControls.Chao_Button()
        Me.Chao_FlowLayoutPanel2 = New ChaoControls.Chao_FlowLayoutPanel()
        Me.Chao_FlowLayoutPanel1 = New ChaoControls.Chao_FluidPanel()
        Me.Search_CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FUN_CMS.SuspendLayout()
        Me.Sort_CMS.SuspendLayout()
        Me.DEL_CMS.SuspendLayout()
        Me.RefreshCMS.SuspendLayout()
        Me.MIN_CMS.SuspendLayout()
        Me.LoveCMS.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArrowPicb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Chao_Panel1.SuspendLayout()
        Me.Chao_Panel2.SuspendLayout()
        Me.Chao_Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Chao_FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormIconPicB
        '
        Me.FormIconPicB.Image = Global.Jvedio.My.Resources.Resource_Image.Jvedio1
        Me.FormIconPicB.Location = New System.Drawing.Point(16, 16)
        '
        'FormTextLabel
        '
        Me.FormTextLabel.Location = New System.Drawing.Point(64, 18)
        Me.FormTextLabel.Size = New System.Drawing.Size(73, 27)
        Me.FormTextLabel.Text = "Jvedio"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(1038, 13)
        '
        'TitlePicB
        '
        Me.TitlePicB.Image = CType(resources.GetObject("TitlePicB.Image"), System.Drawing.Image)
        Me.TitlePicB.Location = New System.Drawing.Point(46, 2)
        Me.TitlePicB.Size = New System.Drawing.Size(278, 45)
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TitlePanel.Controls.Add(Me.Chao_FlowLayoutPanel2)
        Me.TitlePanel.Size = New System.Drawing.Size(1228, 50)
        Me.TitlePanel.Controls.SetChildIndex(Me.SkinPicB, 0)
        Me.TitlePanel.Controls.SetChildIndex(Me.TitlePicB, 0)
        Me.TitlePanel.Controls.SetChildIndex(Me.FormIconPicB, 0)
        Me.TitlePanel.Controls.SetChildIndex(Me.FormTextLabel, 0)
        Me.TitlePanel.Controls.SetChildIndex(Me.SetPicB, 0)
        Me.TitlePanel.Controls.SetChildIndex(Me.Chao_FlowLayoutPanel2, 0)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(1030, 9)
        '
        'FUN_CMS
        '
        Me.FUN_CMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FUN_CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开影片位置ToolStripMenuItem, Me.打开照片位置ToolStripMenuItem, Me.复制ToolStripMenuItem, Me.打开其网址ToolStripMenuItem, Me.删除该番号ToolStripMenuItem, Me.删除该文件ToolStripMenuItem, Me.EditInfoToolStripMenuItem})
        Me.FUN_CMS.Name = "ContextMenuStrip1"
        Me.FUN_CMS.Size = New System.Drawing.Size(169, 172)
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
        '删除该番号ToolStripMenuItem
        '
        Me.删除该番号ToolStripMenuItem.Name = "删除该番号ToolStripMenuItem"
        Me.删除该番号ToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.删除该番号ToolStripMenuItem.Text = "删除该影片"
        '
        '删除该文件ToolStripMenuItem
        '
        Me.删除该文件ToolStripMenuItem.Name = "删除该文件ToolStripMenuItem"
        Me.删除该文件ToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.删除该文件ToolStripMenuItem.Text = "删除文件"
        '
        'EditInfoToolStripMenuItem
        '
        Me.EditInfoToolStripMenuItem.Name = "EditInfoToolStripMenuItem"
        Me.EditInfoToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.EditInfoToolStripMenuItem.Text = "编辑信息"
        '
        'Sort_CMS
        '
        Me.Sort_CMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Sort_CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.番号ToolStripMenuItem, Me.名称ToolStripMenuItem, Me.文件大小ToolStripMenuItem1, Me.导入时间ToolStripMenuItem1, Me.发行日期ToolStripMenuItem2, Me.喜爱程度ToolStripMenuItem1, Me.访问次数ToolStripMenuItem2})
        Me.Sort_CMS.Name = "ContextMenuStrip2"
        Me.Sort_CMS.Size = New System.Drawing.Size(139, 172)
        '
        '番号ToolStripMenuItem
        '
        Me.番号ToolStripMenuItem.Name = "番号ToolStripMenuItem"
        Me.番号ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.番号ToolStripMenuItem.Text = "识别码"
        '
        '名称ToolStripMenuItem
        '
        Me.名称ToolStripMenuItem.Name = "名称ToolStripMenuItem"
        Me.名称ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.名称ToolStripMenuItem.Text = "影片名称"
        '
        '文件大小ToolStripMenuItem1
        '
        Me.文件大小ToolStripMenuItem1.Name = "文件大小ToolStripMenuItem1"
        Me.文件大小ToolStripMenuItem1.Size = New System.Drawing.Size(138, 24)
        Me.文件大小ToolStripMenuItem1.Text = "文件大小"
        '
        '导入时间ToolStripMenuItem1
        '
        Me.导入时间ToolStripMenuItem1.Name = "导入时间ToolStripMenuItem1"
        Me.导入时间ToolStripMenuItem1.Size = New System.Drawing.Size(138, 24)
        Me.导入时间ToolStripMenuItem1.Text = "导入时间"
        '
        '发行日期ToolStripMenuItem2
        '
        Me.发行日期ToolStripMenuItem2.Name = "发行日期ToolStripMenuItem2"
        Me.发行日期ToolStripMenuItem2.Size = New System.Drawing.Size(138, 24)
        Me.发行日期ToolStripMenuItem2.Text = "发行日期"
        '
        '喜爱程度ToolStripMenuItem1
        '
        Me.喜爱程度ToolStripMenuItem1.Name = "喜爱程度ToolStripMenuItem1"
        Me.喜爱程度ToolStripMenuItem1.Size = New System.Drawing.Size(138, 24)
        Me.喜爱程度ToolStripMenuItem1.Text = "喜爱程度"
        '
        '访问次数ToolStripMenuItem2
        '
        Me.访问次数ToolStripMenuItem2.Name = "访问次数ToolStripMenuItem2"
        Me.访问次数ToolStripMenuItem2.Size = New System.Drawing.Size(138, 24)
        Me.访问次数ToolStripMenuItem2.Text = "访问次数"
        '
        'DEL_CMS
        '
        Me.DEL_CMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DEL_CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.删除ToolStripMenuItem})
        Me.DEL_CMS.Name = "ContextMenuStrip3"
        Me.DEL_CMS.Size = New System.Drawing.Size(109, 28)
        '
        '删除ToolStripMenuItem
        '
        Me.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem"
        Me.删除ToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.删除ToolStripMenuItem.Text = "删除"
        '
        'RefreshCMS
        '
        Me.RefreshCMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RefreshCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.刷新ToolStripMenuItem1})
        Me.RefreshCMS.Name = "ContextMenuStrip4"
        Me.RefreshCMS.Size = New System.Drawing.Size(109, 28)
        '
        '刷新ToolStripMenuItem1
        '
        Me.刷新ToolStripMenuItem1.Name = "刷新ToolStripMenuItem1"
        Me.刷新ToolStripMenuItem1.Size = New System.Drawing.Size(108, 24)
        Me.刷新ToolStripMenuItem1.Text = "刷新"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "JVEDIO"
        '
        'MIN_CMS
        '
        Me.MIN_CMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MIN_CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开主窗体ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.MIN_CMS.Name = "ContextMenuStrip5"
        Me.MIN_CMS.Size = New System.Drawing.Size(139, 52)
        '
        '打开主窗体ToolStripMenuItem
        '
        Me.打开主窗体ToolStripMenuItem.Name = "打开主窗体ToolStripMenuItem"
        Me.打开主窗体ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.打开主窗体ToolStripMenuItem.Text = "打开软件"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'LoveCMS
        '
        Me.LoveCMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.LoveCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.LoveCMS.Name = "ContextMenuStrip6"
        Me.LoveCMS.Size = New System.Drawing.Size(88, 148)
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
        '小图ToolStripMenuItem
        '
        Me.小图ToolStripMenuItem.Name = "小图ToolStripMenuItem"
        Me.小图ToolStripMenuItem.Size = New System.Drawing.Size(122, 26)
        Me.小图ToolStripMenuItem.Text = "小图"
        '
        '大图ToolStripMenuItem
        '
        Me.大图ToolStripMenuItem.Name = "大图ToolStripMenuItem"
        Me.大图ToolStripMenuItem.Size = New System.Drawing.Size(122, 26)
        Me.大图ToolStripMenuItem.Text = "大图"
        '
        '信息ToolStripMenuItem
        '
        Me.信息ToolStripMenuItem.Name = "信息ToolStripMenuItem"
        Me.信息ToolStripMenuItem.Size = New System.Drawing.Size(122, 26)
        Me.信息ToolStripMenuItem.Text = "信息"
        '
        '下载
        '
        Me.下载.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.小图ToolStripMenuItem, Me.大图ToolStripMenuItem, Me.信息ToolStripMenuItem})
        Me.下载.Name = "下载"
        Me.下载.Size = New System.Drawing.Size(210, 24)
        Me.下载.Text = "下载"
        '
        'DownLoadingTimer
        '
        Me.DownLoadingTimer.Enabled = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(231, 241)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(307, 84)
        Me.Panel2.TabIndex = 52
        Me.Panel2.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label14.Font = New System.Drawing.Font("微软雅黑", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(89, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(183, 36)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "扫描本机影片"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Jvedio.My.Resources.Resource_Image.文件夹
        Me.PictureBox2.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'ArrowPicb
        '
        Me.ArrowPicb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ArrowPicb.Image = Global.Jvedio.My.Resources.Resource_Image.箭头
        Me.ArrowPicb.Location = New System.Drawing.Point(1, 64)
        Me.ArrowPicb.Name = "ArrowPicb"
        Me.ArrowPicb.Size = New System.Drawing.Size(50, 50)
        Me.ArrowPicb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ArrowPicb.TabIndex = 53
        Me.ArrowPicb.TabStop = False
        '
        'Chao_Panel1
        '
        Me.Chao_Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Chao_Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Chao_Panel1.Controls.Add(Me.Label_5)
        Me.Chao_Panel1.Controls.Add(Me.Label11)
        Me.Chao_Panel1.Controls.Add(Me.Label5)
        Me.Chao_Panel1.Controls.Add(Me.Label4)
        Me.Chao_Panel1.Controls.Add(Me.Label3)
        Me.Chao_Panel1.Controls.Add(Me.Chao_SearchBox1)
        Me.Chao_Panel1.Controls.Add(Me.Label_4)
        Me.Chao_Panel1.Controls.Add(Me.Label_3)
        Me.Chao_Panel1.Controls.Add(Me.Label_2)
        Me.Chao_Panel1.Controls.Add(Me.Label_1)
        Me.Chao_Panel1.Controls.Add(Me.Label_0)
        Me.Chao_Panel1.Location = New System.Drawing.Point(1, 64)
        Me.Chao_Panel1.Name = "Chao_Panel1"
        Me.Chao_Panel1.Size = New System.Drawing.Size(220, 883)
        Me.Chao_Panel1.TabIndex = 56
        '
        'Label_5
        '
        Me.Label_5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label_5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label_5.Location = New System.Drawing.Point(0, 396)
        Me.Label_5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_5.Name = "Label_5"
        Me.Label_5.Size = New System.Drawing.Size(220, 49)
        Me.Label_5.TabIndex = 22
        Me.Label_5.Text = "其它"
        Me.Label_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(0, 555)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 49)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "标签"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(0, 506)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 49)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "演员"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(0, 457)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 49)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "类别"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(0, 189)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 49)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "更多    +"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Chao_SearchBox1
        '
        Me.Chao_SearchBox1.AccessibleRole = Nothing
        Me.Chao_SearchBox1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_SearchBox1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_SearchBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_SearchBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Chao_SearchBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_SearchBox1.Hint = "Search"
        Me.Chao_SearchBox1.HintColor = System.Drawing.Color.Gray
        Me.Chao_SearchBox1.Location = New System.Drawing.Point(5, 23)
        Me.Chao_SearchBox1.MaximumSize = New System.Drawing.Size(0, 80)
        Me.Chao_SearchBox1.MinimumSize = New System.Drawing.Size(155, 20)
        Me.Chao_SearchBox1.Name = "Chao_SearchBox1"
        Me.Chao_SearchBox1.SearchBoxColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Chao_SearchBox1.SearchBoxMouseMoveColor = System.Drawing.Color.White
        Me.Chao_SearchBox1.SearchIconColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Chao_SearchBox1.SearchTextForeColor = System.Drawing.Color.White
        Me.Chao_SearchBox1.Size = New System.Drawing.Size(211, 50)
        Me.Chao_SearchBox1.TabIndex = 17
        Me.Chao_SearchBox1.Text = "Search"
        '
        'Label_4
        '
        Me.Label_4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label_4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label_4.Location = New System.Drawing.Point(0, 347)
        Me.Label_4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_4.Name = "Label_4"
        Me.Label_4.Size = New System.Drawing.Size(220, 49)
        Me.Label_4.TabIndex = 16
        Me.Label_4.Text = "欧美"
        Me.Label_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_3
        '
        Me.Label_3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label_3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label_3.Location = New System.Drawing.Point(0, 295)
        Me.Label_3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_3.Name = "Label_3"
        Me.Label_3.Size = New System.Drawing.Size(220, 49)
        Me.Label_3.TabIndex = 15
        Me.Label_3.Text = "步兵"
        Me.Label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_2
        '
        Me.Label_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label_2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label_2.Location = New System.Drawing.Point(0, 243)
        Me.Label_2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_2.Name = "Label_2"
        Me.Label_2.Size = New System.Drawing.Size(220, 49)
        Me.Label_2.TabIndex = 14
        Me.Label_2.Text = "骑兵"
        Me.Label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_1
        '
        Me.Label_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label_1.Location = New System.Drawing.Point(0, 140)
        Me.Label_1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_1.Name = "Label_1"
        Me.Label_1.Size = New System.Drawing.Size(220, 49)
        Me.Label_1.TabIndex = 13
        Me.Label_1.Text = "我的喜爱"
        Me.Label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_0
        '
        Me.Label_0.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_0.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label_0.Location = New System.Drawing.Point(0, 88)
        Me.Label_0.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_0.Name = "Label_0"
        Me.Label_0.Size = New System.Drawing.Size(220, 49)
        Me.Label_0.TabIndex = 12
        Me.Label_0.Text = "所有视频"
        Me.Label_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Chao_Panel2
        '
        Me.Chao_Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Panel2.Controls.Add(Me.LabelStatus)
        Me.Chao_Panel2.Controls.Add(Me.Chao_StatusIndicator1)
        Me.Chao_Panel2.Controls.Add(Me.Label2)
        Me.Chao_Panel2.Location = New System.Drawing.Point(4, 954)
        Me.Chao_Panel2.Name = "Chao_Panel2"
        Me.Chao_Panel2.Size = New System.Drawing.Size(1216, 40)
        Me.Chao_Panel2.TabIndex = 57
        '
        'LabelStatus
        '
        Me.LabelStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelStatus.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelStatus.ForeColor = System.Drawing.Color.White
        Me.LabelStatus.Location = New System.Drawing.Point(8, 0)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(741, 35)
        Me.LabelStatus.TabIndex = 52
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Chao_StatusIndicator1
        '
        Me.Chao_StatusIndicator1.AccessibleRole = Nothing
        Me.Chao_StatusIndicator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_StatusIndicator1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_StatusIndicator1.BackColor = System.Drawing.Color.Transparent
        Me.Chao_StatusIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_StatusIndicator1.FailedColor = System.Drawing.Color.Red
        Me.Chao_StatusIndicator1.Location = New System.Drawing.Point(859, 2)
        Me.Chao_StatusIndicator1.MaximumSize = New System.Drawing.Size(50, 50)
        Me.Chao_StatusIndicator1.MinimumSize = New System.Drawing.Size(25, 25)
        Me.Chao_StatusIndicator1.Name = "Chao_StatusIndicator1"
        Me.Chao_StatusIndicator1.RunningColor = System.Drawing.Color.Gray
        Me.Chao_StatusIndicator1.RunningSpeed = 15
        Me.Chao_StatusIndicator1.Size = New System.Drawing.Size(32, 32)
        Me.Chao_StatusIndicator1.StandByColor = System.Drawing.Color.Blue
        Me.Chao_StatusIndicator1.Status = "StandBy"
        Me.Chao_StatusIndicator1.SuccessColor = System.Drawing.Color.Green
        Me.Chao_StatusIndicator1.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(906, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 35)
        Me.Label2.TabIndex = 53
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Chao_Panel3
        '
        Me.Chao_Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_Panel3.Controls.Add(Me.Chao_CheckBox2)
        Me.Chao_Panel3.Controls.Add(Me.Chao_Button2)
        Me.Chao_Panel3.Controls.Add(Me.Chao_CheckBox1)
        Me.Chao_Panel3.Controls.Add(Me.Panel4)
        Me.Chao_Panel3.Controls.Add(Me.PictureBox5)
        Me.Chao_Panel3.Controls.Add(Me.Label13)
        Me.Chao_Panel3.Controls.Add(Me.Label12)
        Me.Chao_Panel3.Location = New System.Drawing.Point(231, 57)
        Me.Chao_Panel3.Name = "Chao_Panel3"
        Me.Chao_Panel3.Size = New System.Drawing.Size(989, 50)
        Me.Chao_Panel3.TabIndex = 58
        '
        'Chao_CheckBox2
        '
        Me.Chao_CheckBox2.AccessibleRole = Nothing
        Me.Chao_CheckBox2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Chao_CheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox2.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox2.BorderWidth = 2.0!
        Me.Chao_CheckBox2.Checked = False
        Me.Chao_CheckBox2.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox2.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox2.CheckText = "可播放"
        Me.Chao_CheckBox2.CheckTextColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Chao_CheckBox2.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox2.Location = New System.Drawing.Point(472, 7)
        Me.Chao_CheckBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox2.Name = "Chao_CheckBox2"
        Me.Chao_CheckBox2.Size = New System.Drawing.Size(147, 35)
        Me.Chao_CheckBox2.TabIndex = 59
        '
        'Chao_Button2
        '
        Me.Chao_Button2.AccessibleRole = Nothing
        Me.Chao_Button2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Chao_Button2.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Chao_Button2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Chao_Button2.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button2.ButtonShape = "RoundedRectangle"
        Me.Chao_Button2.ButtonText = "批量管理"
        Me.Chao_Button2.ButtonType = "ContainedButton"
        Me.Chao_Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button2.Image = Nothing
        Me.Chao_Button2.ImagePosition = "Left"
        Me.Chao_Button2.Location = New System.Drawing.Point(335, 0)
        Me.Chao_Button2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button2.Name = "Chao_Button2"
        Me.Chao_Button2.Size = New System.Drawing.Size(120, 50)
        Me.Chao_Button2.TabIndex = 52
        Me.Chao_Button2.TextColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'Chao_CheckBox1
        '
        Me.Chao_CheckBox1.AccessibleRole = Nothing
        Me.Chao_CheckBox1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Chao_CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox1.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox1.BorderWidth = 2.0!
        Me.Chao_CheckBox1.Checked = False
        Me.Chao_CheckBox1.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox1.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox1.CheckText = "编辑模式"
        Me.Chao_CheckBox1.CheckTextColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Chao_CheckBox1.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox1.Location = New System.Drawing.Point(201, 8)
        Me.Chao_CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox1.Name = "Chao_CheckBox1"
        Me.Chao_CheckBox1.Size = New System.Drawing.Size(147, 35)
        Me.Chao_CheckBox1.TabIndex = 51
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Chao_TextBox1)
        Me.Panel4.Controls.Add(Me.Chao_Button3)
        Me.Panel4.Controls.Add(Me.Chao_Button1)
        Me.Panel4.Location = New System.Drawing.Point(664, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(322, 50)
        Me.Panel4.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(162, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 51)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "/0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Chao_TextBox1
        '
        Me.Chao_TextBox1.AccessibleRole = Nothing
        Me.Chao_TextBox1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_TextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Chao_TextBox1.Hint = "Hint"
        Me.Chao_TextBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_TextBox1.Location = New System.Drawing.Point(56, 0)
        Me.Chao_TextBox1.Name = "Chao_TextBox1"
        Me.Chao_TextBox1.Size = New System.Drawing.Size(100, 51)
        Me.Chao_TextBox1.TabIndex = 3
        Me.Chao_TextBox1.Text = "0"
        Me.Chao_TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Chao_TextBox1.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Chao_TextBox1.TextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_TextBox1.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'Chao_Button3
        '
        Me.Chao_Button3.AccessibleRole = Nothing
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
        Me.Chao_Button3.Location = New System.Drawing.Point(268, 0)
        Me.Chao_Button3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button3.Name = "Chao_Button3"
        Me.Chao_Button3.Size = New System.Drawing.Size(50, 50)
        Me.Chao_Button3.TabIndex = 2
        Me.Chao_Button3.TextColor = System.Drawing.Color.White
        '
        'Chao_Button1
        '
        Me.Chao_Button1.AccessibleRole = Nothing
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
        Me.Chao_Button1.Location = New System.Drawing.Point(0, 0)
        Me.Chao_Button1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button1.Name = "Chao_Button1"
        Me.Chao_Button1.Size = New System.Drawing.Size(50, 50)
        Me.Chao_Button1.TabIndex = 0
        Me.Chao_Button1.TextColor = System.Drawing.Color.White
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PictureBox5.Image = Global.Jvedio.My.Resources.Resource_Image.Arrow_Down
        Me.PictureBox5.Location = New System.Drawing.Point(145, 0)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 48
        Me.PictureBox5.TabStop = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(120, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 48)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "↑"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(24, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 10, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 48)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "文件大小"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1043, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 62)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Test"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Chao_Button4
        '
        Me.Chao_Button4.AccessibleRole = Nothing
        Me.Chao_Button4.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button4.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button4.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button4.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button4.ButtonFont = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Chao_Button4.ButtonShape = "RoundedRectangle"
        Me.Chao_Button4.ButtonText = "  文件"
        Me.Chao_Button4.ButtonType = "ContainedButton"
        Me.Chao_Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button4.Image = CType(resources.GetObject("Chao_Button4.Image"), System.Drawing.Bitmap)
        Me.Chao_Button4.ImagePosition = "Left"
        Me.Chao_Button4.Location = New System.Drawing.Point(3, 3)
        Me.Chao_Button4.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button4.Name = "Chao_Button4"
        Me.Chao_Button4.Size = New System.Drawing.Size(91, 50)
        Me.Chao_Button4.TabIndex = 7
        Me.Chao_Button4.TextColor = System.Drawing.Color.White
        '
        'Chao_Button5
        '
        Me.Chao_Button5.AccessibleRole = Nothing
        Me.Chao_Button5.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button5.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button5.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button5.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button5.ButtonFont = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Chao_Button5.ButtonShape = "RoundedRectangle"
        Me.Chao_Button5.ButtonText = "  下载"
        Me.Chao_Button5.ButtonType = "ContainedButton"
        Me.Chao_Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button5.Image = CType(resources.GetObject("Chao_Button5.Image"), System.Drawing.Bitmap)
        Me.Chao_Button5.ImagePosition = "Left"
        Me.Chao_Button5.Location = New System.Drawing.Point(100, 3)
        Me.Chao_Button5.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button5.Name = "Chao_Button5"
        Me.Chao_Button5.Size = New System.Drawing.Size(91, 50)
        Me.Chao_Button5.TabIndex = 8
        Me.Chao_Button5.TextColor = System.Drawing.Color.White
        '
        'Chao_Button6
        '
        Me.Chao_Button6.AccessibleRole = Nothing
        Me.Chao_Button6.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button6.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button6.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button6.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button6.ButtonFont = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Chao_Button6.ButtonShape = "RoundedRectangle"
        Me.Chao_Button6.ButtonText = "  关于"
        Me.Chao_Button6.ButtonType = "ContainedButton"
        Me.Chao_Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button6.Image = CType(resources.GetObject("Chao_Button6.Image"), System.Drawing.Bitmap)
        Me.Chao_Button6.ImagePosition = "Left"
        Me.Chao_Button6.Location = New System.Drawing.Point(197, 3)
        Me.Chao_Button6.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button6.Name = "Chao_Button6"
        Me.Chao_Button6.Size = New System.Drawing.Size(91, 50)
        Me.Chao_Button6.TabIndex = 9
        Me.Chao_Button6.TextColor = System.Drawing.Color.White
        '
        'Chao_Button7
        '
        Me.Chao_Button7.AccessibleRole = Nothing
        Me.Chao_Button7.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button7.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button7.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button7.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button7.ButtonFont = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Chao_Button7.ButtonShape = "RoundedRectangle"
        Me.Chao_Button7.ButtonText = "  更新"
        Me.Chao_Button7.ButtonType = "ContainedButton"
        Me.Chao_Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button7.Image = CType(resources.GetObject("Chao_Button7.Image"), System.Drawing.Bitmap)
        Me.Chao_Button7.ImagePosition = "Left"
        Me.Chao_Button7.Location = New System.Drawing.Point(294, 3)
        Me.Chao_Button7.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button7.Name = "Chao_Button7"
        Me.Chao_Button7.Size = New System.Drawing.Size(91, 50)
        Me.Chao_Button7.TabIndex = 10
        Me.Chao_Button7.TextColor = System.Drawing.Color.White
        '
        'Chao_Button9
        '
        Me.Chao_Button9.AccessibleRole = Nothing
        Me.Chao_Button9.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button9.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button9.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button9.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button9.ButtonFont = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Chao_Button9.ButtonShape = "RoundedRectangle"
        Me.Chao_Button9.ButtonText = " 查看"
        Me.Chao_Button9.ButtonType = "ContainedButton"
        Me.Chao_Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button9.Image = Global.Jvedio.My.Resources.Resource_Title.查看
        Me.Chao_Button9.ImagePosition = "Left"
        Me.Chao_Button9.Location = New System.Drawing.Point(391, 3)
        Me.Chao_Button9.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button9.Name = "Chao_Button9"
        Me.Chao_Button9.Size = New System.Drawing.Size(88, 50)
        Me.Chao_Button9.TabIndex = 12
        Me.Chao_Button9.TextColor = System.Drawing.Color.White
        '
        'Chao_Button10
        '
        Me.Chao_Button10.AccessibleRole = Nothing
        Me.Chao_Button10.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button10.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button10.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button10.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Chao_Button10.ButtonFont = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Chao_Button10.ButtonShape = "RoundedRectangle"
        Me.Chao_Button10.ButtonText = "  设置"
        Me.Chao_Button10.ButtonType = "ContainedButton"
        Me.Chao_Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button10.Image = Global.Jvedio.My.Resources.Resource_Title.设_置
        Me.Chao_Button10.ImagePosition = "Left"
        Me.Chao_Button10.Location = New System.Drawing.Point(485, 3)
        Me.Chao_Button10.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button10.Name = "Chao_Button10"
        Me.Chao_Button10.Size = New System.Drawing.Size(88, 50)
        Me.Chao_Button10.TabIndex = 13
        Me.Chao_Button10.TextColor = System.Drawing.Color.White
        '
        'Chao_FlowLayoutPanel2
        '
        Me.Chao_FlowLayoutPanel2.Controls.Add(Me.Chao_Button4)
        Me.Chao_FlowLayoutPanel2.Controls.Add(Me.Chao_Button5)
        Me.Chao_FlowLayoutPanel2.Controls.Add(Me.Chao_Button6)
        Me.Chao_FlowLayoutPanel2.Controls.Add(Me.Chao_Button7)
        Me.Chao_FlowLayoutPanel2.Controls.Add(Me.Chao_Button9)
        Me.Chao_FlowLayoutPanel2.Controls.Add(Me.Chao_Button10)
        Me.Chao_FlowLayoutPanel2.Location = New System.Drawing.Point(220, 0)
        Me.Chao_FlowLayoutPanel2.Name = "Chao_FlowLayoutPanel2"
        Me.Chao_FlowLayoutPanel2.Size = New System.Drawing.Size(587, 50)
        Me.Chao_FlowLayoutPanel2.TabIndex = 59
        '
        'Chao_FlowLayoutPanel1
        '
        Me.Chao_FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_FlowLayoutPanel1.AutoScroll = True
        Me.Chao_FlowLayoutPanel1.ContextMenuStrip = Me.RefreshCMS
        Me.Chao_FlowLayoutPanel1.Location = New System.Drawing.Point(231, 113)
        Me.Chao_FlowLayoutPanel1.Name = "Chao_FlowLayoutPanel1"
        Me.Chao_FlowLayoutPanel1.Size = New System.Drawing.Size(664, 98)
        Me.Chao_FlowLayoutPanel1.TabIndex = 59
        '
        'Search_CMS
        '
        Me.Search_CMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Search_CMS.Name = "ContextMenuStrip5"
        Me.Search_CMS.Size = New System.Drawing.Size(61, 4)
        '
        'FormMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1230, 1000)
        Me.Controls.Add(Me.Chao_FlowLayoutPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chao_Panel3)
        Me.Controls.Add(Me.Chao_Panel2)
        Me.Controls.Add(Me.ArrowPicb)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Chao_Panel1)
        Me.FormShowSkinPicB = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1050, 700)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jvedio"
        Me.Controls.SetChildIndex(Me.Chao_Panel1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.ArrowPicb, 0)
        Me.Controls.SetChildIndex(Me.Chao_Panel2, 0)
        Me.Controls.SetChildIndex(Me.Chao_Panel3, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.Chao_FlowLayoutPanel1, 0)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FUN_CMS.ResumeLayout(False)
        Me.Sort_CMS.ResumeLayout(False)
        Me.DEL_CMS.ResumeLayout(False)
        Me.RefreshCMS.ResumeLayout(False)
        Me.MIN_CMS.ResumeLayout(False)
        Me.LoveCMS.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArrowPicb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Chao_Panel1.ResumeLayout(False)
        Me.Chao_Panel2.ResumeLayout(False)
        Me.Chao_Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Chao_FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FUN_CMS As ContextMenuStrip
    Friend WithEvents 打开照片位置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开影片位置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开其网址ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Sort_CMS As ContextMenuStrip
    Friend WithEvents DEL_CMS As ContextMenuStrip
    Friend WithEvents 删除ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshCMS As ContextMenuStrip
    Friend WithEvents 删除该番号ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents MIN_CMS As ContextMenuStrip
    Friend WithEvents 打开主窗体ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoveCMS As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents 复制ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除该文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 刷新ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 番号ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 名称ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 文件大小ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 导入时间ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 发行日期ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents 喜爱程度ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 访问次数ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents 小图ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 大图ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 信息ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 下载 As ToolStripMenuItem
    Friend WithEvents DownLoadingTimer As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ArrowPicb As PictureBox
    Friend WithEvents Chao_Panel1 As ChaoControls.Chao_Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Chao_SearchBox1 As ChaoControls.Chao_SearchBox
    Friend WithEvents Label_4 As Label
    Friend WithEvents Label_3 As Label
    Friend WithEvents Label_2 As Label
    Friend WithEvents Label_1 As Label
    Friend WithEvents Label_0 As Label
    Friend WithEvents Chao_Panel2 As ChaoControls.Chao_Panel
    Friend WithEvents LabelStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Chao_Panel3 As ChaoControls.Chao_Panel
    Friend WithEvents Chao_Button2 As ChaoControls.Chao_Button
    Friend WithEvents Chao_CheckBox1 As ChaoControls.Chao_CheckBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Chao_TextBox1 As ChaoControls.Chao_TextBox
    Friend WithEvents Chao_Button3 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button1 As ChaoControls.Chao_Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Chao_StatusIndicator1 As ChaoControls.Chao_StatusIndicator
    Friend WithEvents Label_5 As Label
    Friend WithEvents Chao_Button4 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button7 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button6 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button5 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button9 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button10 As ChaoControls.Chao_Button
    Friend WithEvents Chao_CheckBox2 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_FlowLayoutPanel2 As ChaoControls.Chao_FlowLayoutPanel
    Friend WithEvents Chao_FlowLayoutPanel1 As ChaoControls.Chao_FluidPanel
    Friend WithEvents Search_CMS As ContextMenuStrip
End Class



Public Class Chao_SimpleMenuStripRender
    Inherits ToolStripRenderer

    Private BorderColor As Color = Color.FromArgb(205, 205, 205)
    Private MenuWidth As Single = 200
    Private BackColor As Color = Color.White
    Private ForeColor As Color = Color.Black

    Sub New(width As Single, FC As Color, BC As Color)
        MenuWidth = width
        BackColor = BC
        ForeColor = FC
    End Sub


    'toolstrip背景
    Protected Overrides Sub OnRenderToolStripBackground(e As ToolStripRenderEventArgs)

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.FillRectangle(New SolidBrush(BackColor), e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1)

    End Sub



    '边框
    Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
        MyBase.OnRenderToolStripBorder(e)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.DrawRectangle(New Pen(BorderColor, 1), e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1)

    End Sub



    '重绘文本
    Protected Overrides Sub OnRenderItemText(ByVal e As ToolStripItemTextRenderEventArgs)

        'Dim myMenuItemFont As New Font("微软雅黑", 12)
        Dim g As Graphics = e.Graphics
        'g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Dim TextSize As SizeF = g.MeasureString(e.Item.Text, e.Item.Font)
        g.DrawString(e.Item.Text, e.Item.Font, New SolidBrush(ForeColor), New PointF((MenuWidth - TextSize.Width) / 2, (e.Item.Height - TextSize.Height) / 2))

    End Sub

    'MenuItem
    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)


        e.Item.AutoSize = False
        e.ToolStrip.AutoSize = False
        e.Item.Height = 40
        e.ToolStrip.Height = e.ToolStrip.Items.Count * 40 + 16

        e.Item.Width = MenuWidth + 4
        e.ToolStrip.Width = MenuWidth

        If e.ToolStrip.Items.Count = 1 Then
            e.ToolStrip.Items.Item(0).Margin = New Padding(0, 6, 0, 6)
        ElseIf e.ToolStrip.Items.Count > 1 Then
            e.ToolStrip.Items.Item(0).Margin = New Padding(0, 6, 0, 0)
            e.ToolStrip.Items.Item(e.ToolStrip.Items.Count - 1).Margin = New Padding(0, 0, 0, 6)
        End If

        'MouseMove
        If e.Item.Selected Then
            e.Graphics.FillRectangle(New SolidBrush(ShareClass.ChaoSub.GetRelativeColor(BackColor, -20)), 0, 0, e.Item.Width, e.Item.Height)
        Else
            e.Graphics.FillRectangle(New SolidBrush(BackColor), 0, 0, e.Item.Width, e.Item.Height)
        End If

    End Sub
End Class
