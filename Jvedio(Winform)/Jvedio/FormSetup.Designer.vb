<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSetup

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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSetup))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Chao_CheckBox16 = New ChaoControls.Chao_CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Chao_CheckBox12 = New ChaoControls.Chao_CheckBox()
        Me.Chao_TextBoxNum = New ChaoControls.Chao_TextBox()
        Me.Chao_CheckBox10 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox7 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox3 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox2 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox1 = New ChaoControls.Chao_CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Chao_StatusIndicator4 = New ChaoControls.Chao_StatusIndicator()
        Me.Chao_Button1 = New ChaoControls.Chao_Button()
        Me.Chao_TextBox4 = New ChaoControls.Chao_TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Chao_StatusIndicator3 = New ChaoControls.Chao_StatusIndicator()
        Me.Chao_StatusIndicator2 = New ChaoControls.Chao_StatusIndicator()
        Me.Chao_StatusIndicator1 = New ChaoControls.Chao_StatusIndicator()
        Me.Chao_Button6 = New ChaoControls.Chao_Button()
        Me.Chao_Button5 = New ChaoControls.Chao_Button()
        Me.Chao_TextBox3 = New ChaoControls.Chao_TextBox()
        Me.Chao_TextBox2 = New ChaoControls.Chao_TextBox()
        Me.Chao_Button4 = New ChaoControls.Chao_Button()
        Me.Chao_TextBox1 = New ChaoControls.Chao_TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Chao_CheckBox17 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox11 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox9 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox8 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox6 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox5 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox4 = New ChaoControls.Chao_CheckBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Chao_CheckBox15 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox14 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox13 = New ChaoControls.Chao_CheckBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ProxyStatusIndicator = New ChaoControls.Chao_StatusIndicator()
        Me.Chao_Button7 = New ChaoControls.Chao_Button()
        Me.ProxyPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProxyUsername = New ChaoControls.Chao_TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProxyWeb = New ChaoControls.Chao_TextBox()
        Me.ProxyCheckBox = New ChaoControls.Chao_CheckBox()
        Me.Chao_TabSelectorBar1 = New ChaoControls.Chao_TabSelectorBar()
        Me.Chao_Button2 = New ChaoControls.Chao_Button()
        Me.Chao_Button3 = New ChaoControls.Chao_Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Chao_Sliders1 = New ChaoControls.Chao_Sliders()
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormIconPicB
        '
        Me.FormIconPicB.Image = Global.Jvedio.My.Resources.Resource_Image.设置
        Me.FormIconPicB.Location = New System.Drawing.Point(16, 16)
        '
        'FormTextLabel
        '
        Me.FormTextLabel.Location = New System.Drawing.Point(64, 18)
        Me.FormTextLabel.Size = New System.Drawing.Size(52, 27)
        Me.FormTextLabel.Text = "设置"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(510, 18)
        '
        'TitlePanel
        '
        Me.TitlePanel.BackgroundImage = Global.Jvedio.My.Resources.Resource_Image.panel_bg
        Me.TitlePanel.Size = New System.Drawing.Size(700, 64)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(814, 16)
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 116)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(678, 322)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Chao_CheckBox16)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Chao_CheckBox12)
        Me.TabPage1.Controls.Add(Me.Chao_TextBoxNum)
        Me.TabPage1.Controls.Add(Me.Chao_CheckBox10)
        Me.TabPage1.Controls.Add(Me.Chao_CheckBox7)
        Me.TabPage1.Controls.Add(Me.Chao_CheckBox3)
        Me.TabPage1.Controls.Add(Me.Chao_CheckBox2)
        Me.TabPage1.Controls.Add(Me.Chao_CheckBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(670, 293)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "基本"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Chao_CheckBox16
        '
        Me.Chao_CheckBox16.AccessibleRole = Nothing
        Me.Chao_CheckBox16.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox16.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox16.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox16.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox16.BorderWidth = 2.0!
        Me.Chao_CheckBox16.Checked = False
        Me.Chao_CheckBox16.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox16.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox16.CheckText = "主界面显示大图"
        Me.Chao_CheckBox16.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox16.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox16.Location = New System.Drawing.Point(315, 62)
        Me.Chao_CheckBox16.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox16.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox16.Name = "Chao_CheckBox16"
        Me.Chao_CheckBox16.Size = New System.Drawing.Size(217, 35)
        Me.Chao_CheckBox16.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(13, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 27)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "每页显示个数"
        '
        'Chao_CheckBox12
        '
        Me.Chao_CheckBox12.AccessibleRole = Nothing
        Me.Chao_CheckBox12.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox12.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox12.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox12.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox12.BorderWidth = 2.0!
        Me.Chao_CheckBox12.Checked = False
        Me.Chao_CheckBox12.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox12.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox12.CheckText = "默认信息显示窗口"
        Me.Chao_CheckBox12.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox12.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox12.Location = New System.Drawing.Point(18, 105)
        Me.Chao_CheckBox12.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox12.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox12.Name = "Chao_CheckBox12"
        Me.Chao_CheckBox12.Size = New System.Drawing.Size(241, 35)
        Me.Chao_CheckBox12.TabIndex = 11
        '
        'Chao_TextBoxNum
        '
        Me.Chao_TextBoxNum.AccessibleRole = Nothing
        Me.Chao_TextBoxNum.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_TextBoxNum.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_TextBoxNum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_TextBoxNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_TextBoxNum.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_TextBoxNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Chao_TextBoxNum.Hint = "Hint"
        Me.Chao_TextBoxNum.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_TextBoxNum.Location = New System.Drawing.Point(167, 197)
        Me.Chao_TextBoxNum.Name = "Chao_TextBoxNum"
        Me.Chao_TextBoxNum.Size = New System.Drawing.Size(81, 56)
        Me.Chao_TextBoxNum.TabIndex = 10
        Me.Chao_TextBoxNum.Text = "20"
        Me.Chao_TextBoxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Chao_TextBoxNum.TextBackColor = System.Drawing.Color.White
        Me.Chao_TextBoxNum.TextFont = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chao_TextBoxNum.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        '
        'Chao_CheckBox10
        '
        Me.Chao_CheckBox10.AccessibleRole = Nothing
        Me.Chao_CheckBox10.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox10.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox10.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox10.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox10.BorderWidth = 2.0!
        Me.Chao_CheckBox10.Checked = False
        Me.Chao_CheckBox10.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox10.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox10.CheckText = "瀑布式布局"
        Me.Chao_CheckBox10.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox10.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox10.Location = New System.Drawing.Point(315, 105)
        Me.Chao_CheckBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox10.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox10.Name = "Chao_CheckBox10"
        Me.Chao_CheckBox10.Size = New System.Drawing.Size(155, 35)
        Me.Chao_CheckBox10.TabIndex = 9
        Me.Chao_CheckBox10.Visible = False
        '
        'Chao_CheckBox7
        '
        Me.Chao_CheckBox7.AccessibleRole = Nothing
        Me.Chao_CheckBox7.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox7.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox7.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox7.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox7.BorderWidth = 2.0!
        Me.Chao_CheckBox7.Checked = False
        Me.Chao_CheckBox7.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox7.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox7.CheckText = "固定侧边栏"
        Me.Chao_CheckBox7.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox7.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox7.Location = New System.Drawing.Point(18, 148)
        Me.Chao_CheckBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox7.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox7.Name = "Chao_CheckBox7"
        Me.Chao_CheckBox7.Size = New System.Drawing.Size(217, 35)
        Me.Chao_CheckBox7.TabIndex = 6
        '
        'Chao_CheckBox3
        '
        Me.Chao_CheckBox3.AccessibleRole = Nothing
        Me.Chao_CheckBox3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox3.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox3.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox3.BorderWidth = 2.0!
        Me.Chao_CheckBox3.Checked = False
        Me.Chao_CheckBox3.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox3.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox3.CheckText = "点击小图弹出大图"
        Me.Chao_CheckBox3.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox3.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox3.Location = New System.Drawing.Point(315, 148)
        Me.Chao_CheckBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox3.Name = "Chao_CheckBox3"
        Me.Chao_CheckBox3.Size = New System.Drawing.Size(217, 35)
        Me.Chao_CheckBox3.TabIndex = 2
        Me.Chao_CheckBox3.Visible = False
        '
        'Chao_CheckBox2
        '
        Me.Chao_CheckBox2.AccessibleRole = Nothing
        Me.Chao_CheckBox2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox2.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox2.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox2.BorderWidth = 2.0!
        Me.Chao_CheckBox2.Checked = False
        Me.Chao_CheckBox2.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox2.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox2.CheckText = "主界面图片自适应"
        Me.Chao_CheckBox2.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox2.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox2.Location = New System.Drawing.Point(18, 62)
        Me.Chao_CheckBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox2.Name = "Chao_CheckBox2"
        Me.Chao_CheckBox2.Size = New System.Drawing.Size(217, 35)
        Me.Chao_CheckBox2.TabIndex = 1
        '
        'Chao_CheckBox1
        '
        Me.Chao_CheckBox1.AccessibleRole = Nothing
        Me.Chao_CheckBox1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox1.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox1.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox1.BorderWidth = 2.0!
        Me.Chao_CheckBox1.Checked = False
        Me.Chao_CheckBox1.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox1.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox1.CheckText = "关闭后最小化"
        Me.Chao_CheckBox1.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox1.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox1.Location = New System.Drawing.Point(18, 19)
        Me.Chao_CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox1.Name = "Chao_CheckBox1"
        Me.Chao_CheckBox1.Size = New System.Drawing.Size(182, 35)
        Me.Chao_CheckBox1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Chao_StatusIndicator4)
        Me.TabPage2.Controls.Add(Me.Chao_Button1)
        Me.TabPage2.Controls.Add(Me.Chao_TextBox4)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Chao_StatusIndicator3)
        Me.TabPage2.Controls.Add(Me.Chao_StatusIndicator2)
        Me.TabPage2.Controls.Add(Me.Chao_StatusIndicator1)
        Me.TabPage2.Controls.Add(Me.Chao_Button6)
        Me.TabPage2.Controls.Add(Me.Chao_Button5)
        Me.TabPage2.Controls.Add(Me.Chao_TextBox3)
        Me.TabPage2.Controls.Add(Me.Chao_TextBox2)
        Me.TabPage2.Controls.Add(Me.Chao_Button4)
        Me.TabPage2.Controls.Add(Me.Chao_TextBox1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(670, 293)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "网站"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Chao_StatusIndicator4
        '
        Me.Chao_StatusIndicator4.AccessibleRole = Nothing
        Me.Chao_StatusIndicator4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_StatusIndicator4.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator4.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_StatusIndicator4.BackColor = System.Drawing.Color.White
        Me.Chao_StatusIndicator4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_StatusIndicator4.FailedColor = System.Drawing.Color.Red
        Me.Chao_StatusIndicator4.Location = New System.Drawing.Point(620, 202)
        Me.Chao_StatusIndicator4.MaximumSize = New System.Drawing.Size(50, 50)
        Me.Chao_StatusIndicator4.MinimumSize = New System.Drawing.Size(25, 25)
        Me.Chao_StatusIndicator4.Name = "Chao_StatusIndicator4"
        Me.Chao_StatusIndicator4.RunningColor = System.Drawing.Color.Gray
        Me.Chao_StatusIndicator4.RunningSpeed = 15
        Me.Chao_StatusIndicator4.Size = New System.Drawing.Size(32, 32)
        Me.Chao_StatusIndicator4.StandByColor = System.Drawing.Color.Blue
        Me.Chao_StatusIndicator4.Status = "Success"
        Me.Chao_StatusIndicator4.SuccessColor = System.Drawing.Color.Green
        Me.Chao_StatusIndicator4.TabIndex = 28
        Me.Chao_StatusIndicator4.Visible = False
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
        Me.Chao_Button1.ButtonBackColor = System.Drawing.Color.White
        Me.Chao_Button1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button1.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button1.ButtonShape = "RoundedRectangle"
        Me.Chao_Button1.ButtonText = "测试"
        Me.Chao_Button1.ButtonType = "ContainedButton"
        Me.Chao_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button1.Image = Nothing
        Me.Chao_Button1.ImagePosition = "Left"
        Me.Chao_Button1.Location = New System.Drawing.Point(470, 190)
        Me.Chao_Button1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button1.Name = "Chao_Button1"
        Me.Chao_Button1.Size = New System.Drawing.Size(128, 51)
        Me.Chao_Button1.TabIndex = 27
        Me.Chao_Button1.TextColor = System.Drawing.Color.White
        Me.Chao_Button1.Visible = False
        '
        'Chao_TextBox4
        '
        Me.Chao_TextBox4.AccessibleRole = Nothing
        Me.Chao_TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_TextBox4.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox4.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_TextBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_TextBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Chao_TextBox4.Hint = "Hint"
        Me.Chao_TextBox4.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_TextBox4.Location = New System.Drawing.Point(87, 191)
        Me.Chao_TextBox4.Name = "Chao_TextBox4"
        Me.Chao_TextBox4.Size = New System.Drawing.Size(377, 51)
        Me.Chao_TextBox4.TabIndex = 26
        Me.Chao_TextBox4.Text = "http://www.baidu.com"
        Me.Chao_TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Chao_TextBox4.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Chao_TextBox4.TextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_TextBox4.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Chao_TextBox4.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 27)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Lib"
        Me.Label4.Visible = False
        '
        'Chao_StatusIndicator3
        '
        Me.Chao_StatusIndicator3.AccessibleRole = Nothing
        Me.Chao_StatusIndicator3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_StatusIndicator3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_StatusIndicator3.BackColor = System.Drawing.Color.White
        Me.Chao_StatusIndicator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_StatusIndicator3.FailedColor = System.Drawing.Color.Red
        Me.Chao_StatusIndicator3.Location = New System.Drawing.Point(620, 145)
        Me.Chao_StatusIndicator3.MaximumSize = New System.Drawing.Size(50, 50)
        Me.Chao_StatusIndicator3.MinimumSize = New System.Drawing.Size(25, 25)
        Me.Chao_StatusIndicator3.Name = "Chao_StatusIndicator3"
        Me.Chao_StatusIndicator3.RunningColor = System.Drawing.Color.Gray
        Me.Chao_StatusIndicator3.RunningSpeed = 15
        Me.Chao_StatusIndicator3.Size = New System.Drawing.Size(32, 32)
        Me.Chao_StatusIndicator3.StandByColor = System.Drawing.Color.Blue
        Me.Chao_StatusIndicator3.Status = "Success"
        Me.Chao_StatusIndicator3.SuccessColor = System.Drawing.Color.Green
        Me.Chao_StatusIndicator3.TabIndex = 24
        Me.Chao_StatusIndicator3.Visible = False
        '
        'Chao_StatusIndicator2
        '
        Me.Chao_StatusIndicator2.AccessibleRole = Nothing
        Me.Chao_StatusIndicator2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_StatusIndicator2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_StatusIndicator2.BackColor = System.Drawing.Color.White
        Me.Chao_StatusIndicator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_StatusIndicator2.FailedColor = System.Drawing.Color.Red
        Me.Chao_StatusIndicator2.Location = New System.Drawing.Point(620, 89)
        Me.Chao_StatusIndicator2.MaximumSize = New System.Drawing.Size(50, 50)
        Me.Chao_StatusIndicator2.MinimumSize = New System.Drawing.Size(25, 25)
        Me.Chao_StatusIndicator2.Name = "Chao_StatusIndicator2"
        Me.Chao_StatusIndicator2.RunningColor = System.Drawing.Color.Gray
        Me.Chao_StatusIndicator2.RunningSpeed = 15
        Me.Chao_StatusIndicator2.Size = New System.Drawing.Size(32, 32)
        Me.Chao_StatusIndicator2.StandByColor = System.Drawing.Color.Blue
        Me.Chao_StatusIndicator2.Status = "Success"
        Me.Chao_StatusIndicator2.SuccessColor = System.Drawing.Color.Green
        Me.Chao_StatusIndicator2.TabIndex = 23
        '
        'Chao_StatusIndicator1
        '
        Me.Chao_StatusIndicator1.AccessibleRole = Nothing
        Me.Chao_StatusIndicator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_StatusIndicator1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_StatusIndicator1.BackColor = System.Drawing.Color.White
        Me.Chao_StatusIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_StatusIndicator1.FailedColor = System.Drawing.Color.Red
        Me.Chao_StatusIndicator1.Location = New System.Drawing.Point(620, 34)
        Me.Chao_StatusIndicator1.MaximumSize = New System.Drawing.Size(50, 50)
        Me.Chao_StatusIndicator1.MinimumSize = New System.Drawing.Size(25, 25)
        Me.Chao_StatusIndicator1.Name = "Chao_StatusIndicator1"
        Me.Chao_StatusIndicator1.RunningColor = System.Drawing.Color.Gray
        Me.Chao_StatusIndicator1.RunningSpeed = 15
        Me.Chao_StatusIndicator1.Size = New System.Drawing.Size(32, 32)
        Me.Chao_StatusIndicator1.StandByColor = System.Drawing.Color.Blue
        Me.Chao_StatusIndicator1.Status = "Failed"
        Me.Chao_StatusIndicator1.SuccessColor = System.Drawing.Color.Green
        Me.Chao_StatusIndicator1.TabIndex = 22
        '
        'Chao_Button6
        '
        Me.Chao_Button6.AccessibleRole = Nothing
        Me.Chao_Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_Button6.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button6.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button6.ButtonBackColor = System.Drawing.Color.White
        Me.Chao_Button6.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button6.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button6.ButtonShape = "RoundedRectangle"
        Me.Chao_Button6.ButtonText = "测试"
        Me.Chao_Button6.ButtonType = "ContainedButton"
        Me.Chao_Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button6.Image = Nothing
        Me.Chao_Button6.ImagePosition = "Left"
        Me.Chao_Button6.Location = New System.Drawing.Point(470, 133)
        Me.Chao_Button6.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button6.Name = "Chao_Button6"
        Me.Chao_Button6.Size = New System.Drawing.Size(128, 51)
        Me.Chao_Button6.TabIndex = 21
        Me.Chao_Button6.TextColor = System.Drawing.Color.White
        Me.Chao_Button6.Visible = False
        '
        'Chao_Button5
        '
        Me.Chao_Button5.AccessibleRole = Nothing
        Me.Chao_Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_Button5.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button5.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button5.ButtonBackColor = System.Drawing.Color.White
        Me.Chao_Button5.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button5.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button5.ButtonShape = "RoundedRectangle"
        Me.Chao_Button5.ButtonText = "测试"
        Me.Chao_Button5.ButtonType = "ContainedButton"
        Me.Chao_Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button5.Image = Nothing
        Me.Chao_Button5.ImagePosition = "Left"
        Me.Chao_Button5.Location = New System.Drawing.Point(470, 76)
        Me.Chao_Button5.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button5.Name = "Chao_Button5"
        Me.Chao_Button5.Size = New System.Drawing.Size(128, 51)
        Me.Chao_Button5.TabIndex = 20
        Me.Chao_Button5.TextColor = System.Drawing.Color.White
        '
        'Chao_TextBox3
        '
        Me.Chao_TextBox3.AccessibleRole = Nothing
        Me.Chao_TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_TextBox3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_TextBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_TextBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Chao_TextBox3.Hint = "Hint"
        Me.Chao_TextBox3.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_TextBox3.Location = New System.Drawing.Point(87, 134)
        Me.Chao_TextBox3.Name = "Chao_TextBox3"
        Me.Chao_TextBox3.Size = New System.Drawing.Size(377, 51)
        Me.Chao_TextBox3.TabIndex = 19
        Me.Chao_TextBox3.Text = "http://www.baidu.com"
        Me.Chao_TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Chao_TextBox3.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Chao_TextBox3.TextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_TextBox3.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Chao_TextBox3.Visible = False
        '
        'Chao_TextBox2
        '
        Me.Chao_TextBox2.AccessibleRole = Nothing
        Me.Chao_TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_TextBox2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_TextBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_TextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Chao_TextBox2.Hint = "Hint"
        Me.Chao_TextBox2.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_TextBox2.Location = New System.Drawing.Point(87, 77)
        Me.Chao_TextBox2.Name = "Chao_TextBox2"
        Me.Chao_TextBox2.Size = New System.Drawing.Size(377, 51)
        Me.Chao_TextBox2.TabIndex = 18
        Me.Chao_TextBox2.Text = "http://www.baidu.com"
        Me.Chao_TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Chao_TextBox2.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Chao_TextBox2.TextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_TextBox2.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        '
        'Chao_Button4
        '
        Me.Chao_Button4.AccessibleRole = Nothing
        Me.Chao_Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_Button4.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button4.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button4.ButtonBackColor = System.Drawing.Color.White
        Me.Chao_Button4.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button4.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button4.ButtonShape = "RoundedRectangle"
        Me.Chao_Button4.ButtonText = "测试"
        Me.Chao_Button4.ButtonType = "ContainedButton"
        Me.Chao_Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button4.Image = Nothing
        Me.Chao_Button4.ImagePosition = "Left"
        Me.Chao_Button4.Location = New System.Drawing.Point(470, 19)
        Me.Chao_Button4.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button4.Name = "Chao_Button4"
        Me.Chao_Button4.Size = New System.Drawing.Size(128, 51)
        Me.Chao_Button4.TabIndex = 17
        Me.Chao_Button4.TextColor = System.Drawing.Color.White
        '
        'Chao_TextBox1
        '
        Me.Chao_TextBox1.AccessibleRole = Nothing
        Me.Chao_TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_TextBox1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_TextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Chao_TextBox1.Hint = "Hint"
        Me.Chao_TextBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_TextBox1.Location = New System.Drawing.Point(87, 19)
        Me.Chao_TextBox1.Name = "Chao_TextBox1"
        Me.Chao_TextBox1.Size = New System.Drawing.Size(377, 51)
        Me.Chao_TextBox1.TabIndex = 16
        Me.Chao_TextBox1.Text = "http://www.baidu.com"
        Me.Chao_TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Chao_TextBox1.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Chao_TextBox1.TextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_TextBox1.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 27)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "FC"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 27)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "DB"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Bus"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Chao_Sliders1)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Chao_CheckBox17)
        Me.TabPage3.Controls.Add(Me.Chao_CheckBox11)
        Me.TabPage3.Controls.Add(Me.Chao_CheckBox9)
        Me.TabPage3.Controls.Add(Me.Chao_CheckBox8)
        Me.TabPage3.Controls.Add(Me.Chao_CheckBox6)
        Me.TabPage3.Controls.Add(Me.Chao_CheckBox5)
        Me.TabPage3.Controls.Add(Me.Chao_CheckBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(670, 293)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "显示"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Chao_CheckBox17
        '
        Me.Chao_CheckBox17.AccessibleRole = Nothing
        Me.Chao_CheckBox17.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox17.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox17.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox17.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox17.BorderWidth = 2.0!
        Me.Chao_CheckBox17.Checked = False
        Me.Chao_CheckBox17.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox17.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox17.CheckText = "标记"
        Me.Chao_CheckBox17.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox17.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox17.Location = New System.Drawing.Point(5, 176)
        Me.Chao_CheckBox17.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox17.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox17.Name = "Chao_CheckBox17"
        Me.Chao_CheckBox17.Size = New System.Drawing.Size(135, 35)
        Me.Chao_CheckBox17.TabIndex = 15
        '
        'Chao_CheckBox11
        '
        Me.Chao_CheckBox11.AccessibleRole = Nothing
        Me.Chao_CheckBox11.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox11.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox11.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox11.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox11.BorderWidth = 2.0!
        Me.Chao_CheckBox11.Checked = False
        Me.Chao_CheckBox11.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox11.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox11.CheckText = "功能栏"
        Me.Chao_CheckBox11.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox11.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox11.Location = New System.Drawing.Point(5, 133)
        Me.Chao_CheckBox11.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox11.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox11.Name = "Chao_CheckBox11"
        Me.Chao_CheckBox11.Size = New System.Drawing.Size(135, 35)
        Me.Chao_CheckBox11.TabIndex = 14
        '
        'Chao_CheckBox9
        '
        Me.Chao_CheckBox9.AccessibleRole = Nothing
        Me.Chao_CheckBox9.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox9.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox9.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox9.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox9.BorderWidth = 2.0!
        Me.Chao_CheckBox9.Checked = False
        Me.Chao_CheckBox9.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox9.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox9.CheckText = "状态栏"
        Me.Chao_CheckBox9.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox9.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox9.Location = New System.Drawing.Point(5, 90)
        Me.Chao_CheckBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox9.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox9.Name = "Chao_CheckBox9"
        Me.Chao_CheckBox9.Size = New System.Drawing.Size(126, 35)
        Me.Chao_CheckBox9.TabIndex = 13
        '
        'Chao_CheckBox8
        '
        Me.Chao_CheckBox8.AccessibleRole = Nothing
        Me.Chao_CheckBox8.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox8.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox8.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox8.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox8.BorderWidth = 2.0!
        Me.Chao_CheckBox8.Checked = False
        Me.Chao_CheckBox8.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox8.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox8.CheckText = "仅显示有图影片"
        Me.Chao_CheckBox8.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox8.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox8.Location = New System.Drawing.Point(5, 47)
        Me.Chao_CheckBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox8.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox8.Name = "Chao_CheckBox8"
        Me.Chao_CheckBox8.Size = New System.Drawing.Size(203, 35)
        Me.Chao_CheckBox8.TabIndex = 12
        Me.Chao_CheckBox8.Visible = False
        '
        'Chao_CheckBox6
        '
        Me.Chao_CheckBox6.AccessibleRole = Nothing
        Me.Chao_CheckBox6.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox6.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox6.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox6.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox6.BorderWidth = 2.0!
        Me.Chao_CheckBox6.Checked = False
        Me.Chao_CheckBox6.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox6.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox6.CheckText = "日期"
        Me.Chao_CheckBox6.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox6.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox6.Location = New System.Drawing.Point(232, 4)
        Me.Chao_CheckBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox6.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox6.Name = "Chao_CheckBox6"
        Me.Chao_CheckBox6.Size = New System.Drawing.Size(182, 35)
        Me.Chao_CheckBox6.TabIndex = 11
        '
        'Chao_CheckBox5
        '
        Me.Chao_CheckBox5.AccessibleRole = Nothing
        Me.Chao_CheckBox5.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox5.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox5.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox5.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox5.BorderWidth = 2.0!
        Me.Chao_CheckBox5.Checked = False
        Me.Chao_CheckBox5.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox5.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox5.CheckText = "名称"
        Me.Chao_CheckBox5.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox5.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox5.Location = New System.Drawing.Point(124, 4)
        Me.Chao_CheckBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox5.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox5.Name = "Chao_CheckBox5"
        Me.Chao_CheckBox5.Size = New System.Drawing.Size(182, 35)
        Me.Chao_CheckBox5.TabIndex = 10
        '
        'Chao_CheckBox4
        '
        Me.Chao_CheckBox4.AccessibleRole = Nothing
        Me.Chao_CheckBox4.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox4.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox4.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox4.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox4.BorderWidth = 2.0!
        Me.Chao_CheckBox4.Checked = False
        Me.Chao_CheckBox4.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox4.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox4.CheckText = "识别码"
        Me.Chao_CheckBox4.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox4.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox4.Location = New System.Drawing.Point(5, 4)
        Me.Chao_CheckBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox4.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox4.Name = "Chao_CheckBox4"
        Me.Chao_CheckBox4.Size = New System.Drawing.Size(182, 35)
        Me.Chao_CheckBox4.TabIndex = 9
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Chao_CheckBox15)
        Me.TabPage4.Controls.Add(Me.Chao_CheckBox14)
        Me.TabPage4.Controls.Add(Me.Chao_CheckBox13)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(670, 293)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "杂项"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Chao_CheckBox15
        '
        Me.Chao_CheckBox15.AccessibleRole = Nothing
        Me.Chao_CheckBox15.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox15.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox15.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox15.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox15.BorderWidth = 2.0!
        Me.Chao_CheckBox15.Checked = False
        Me.Chao_CheckBox15.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox15.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox15.CheckText = "启动后随机展示"
        Me.Chao_CheckBox15.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox15.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox15.Location = New System.Drawing.Point(6, 103)
        Me.Chao_CheckBox15.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox15.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox15.Name = "Chao_CheckBox15"
        Me.Chao_CheckBox15.Size = New System.Drawing.Size(236, 35)
        Me.Chao_CheckBox15.TabIndex = 14
        '
        'Chao_CheckBox14
        '
        Me.Chao_CheckBox14.AccessibleRole = Nothing
        Me.Chao_CheckBox14.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox14.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox14.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox14.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox14.BorderWidth = 2.0!
        Me.Chao_CheckBox14.Checked = False
        Me.Chao_CheckBox14.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox14.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox14.CheckText = "显示演员数目"
        Me.Chao_CheckBox14.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox14.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox14.Location = New System.Drawing.Point(6, 60)
        Me.Chao_CheckBox14.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox14.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox14.Name = "Chao_CheckBox14"
        Me.Chao_CheckBox14.Size = New System.Drawing.Size(190, 35)
        Me.Chao_CheckBox14.TabIndex = 13
        '
        'Chao_CheckBox13
        '
        Me.Chao_CheckBox13.AccessibleRole = Nothing
        Me.Chao_CheckBox13.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox13.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox13.BackColor = System.Drawing.Color.White
        Me.Chao_CheckBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox13.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox13.BorderWidth = 2.0!
        Me.Chao_CheckBox13.Checked = False
        Me.Chao_CheckBox13.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox13.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox13.CheckText = "显示类别数目"
        Me.Chao_CheckBox13.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox13.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox13.Location = New System.Drawing.Point(6, 17)
        Me.Chao_CheckBox13.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox13.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox13.Name = "Chao_CheckBox13"
        Me.Chao_CheckBox13.Size = New System.Drawing.Size(236, 35)
        Me.Chao_CheckBox13.TabIndex = 12
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Panel1)
        Me.TabPage5.Controls.Add(Me.ProxyCheckBox)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(670, 293)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "代理"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.ProxyStatusIndicator)
        Me.Panel1.Controls.Add(Me.Chao_Button7)
        Me.Panel1.Controls.Add(Me.ProxyPassword)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ProxyUsername)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ProxyWeb)
        Me.Panel1.Location = New System.Drawing.Point(17, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(645, 212)
        Me.Panel1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(394, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 27)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "显示密码"
        '
        'ProxyStatusIndicator
        '
        Me.ProxyStatusIndicator.AccessibleRole = Nothing
        Me.ProxyStatusIndicator.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProxyStatusIndicator.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ProxyStatusIndicator.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ProxyStatusIndicator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ProxyStatusIndicator.BackColor = System.Drawing.Color.White
        Me.ProxyStatusIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ProxyStatusIndicator.FailedColor = System.Drawing.Color.Red
        Me.ProxyStatusIndicator.Location = New System.Drawing.Point(554, 135)
        Me.ProxyStatusIndicator.MaximumSize = New System.Drawing.Size(50, 50)
        Me.ProxyStatusIndicator.MinimumSize = New System.Drawing.Size(25, 25)
        Me.ProxyStatusIndicator.Name = "ProxyStatusIndicator"
        Me.ProxyStatusIndicator.RunningColor = System.Drawing.Color.Gray
        Me.ProxyStatusIndicator.RunningSpeed = 15
        Me.ProxyStatusIndicator.Size = New System.Drawing.Size(32, 32)
        Me.ProxyStatusIndicator.StandByColor = System.Drawing.Color.Blue
        Me.ProxyStatusIndicator.Status = "Failed"
        Me.ProxyStatusIndicator.SuccessColor = System.Drawing.Color.Green
        Me.ProxyStatusIndicator.TabIndex = 24
        '
        'Chao_Button7
        '
        Me.Chao_Button7.AccessibleRole = Nothing
        Me.Chao_Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_Button7.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button7.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button7.ButtonBackColor = System.Drawing.Color.White
        Me.Chao_Button7.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button7.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button7.ButtonShape = "RoundedRectangle"
        Me.Chao_Button7.ButtonText = "测试"
        Me.Chao_Button7.ButtonType = "ContainedButton"
        Me.Chao_Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button7.Image = Nothing
        Me.Chao_Button7.ImagePosition = "Left"
        Me.Chao_Button7.Location = New System.Drawing.Point(505, 74)
        Me.Chao_Button7.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button7.Name = "Chao_Button7"
        Me.Chao_Button7.Size = New System.Drawing.Size(128, 51)
        Me.Chao_Button7.TabIndex = 23
        Me.Chao_Button7.TextColor = System.Drawing.Color.White
        '
        'ProxyPassword
        '
        Me.ProxyPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProxyPassword.Location = New System.Drawing.Point(170, 141)
        Me.ProxyPassword.Name = "ProxyPassword"
        Me.ProxyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ProxyPassword.Size = New System.Drawing.Size(218, 25)
        Me.ProxyPassword.TabIndex = 5
        Me.ProxyPassword.Text = "123456"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 27)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "密码"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 27)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "用户名"
        '
        'ProxyUsername
        '
        Me.ProxyUsername.AccessibleRole = Nothing
        Me.ProxyUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProxyUsername.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ProxyUsername.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ProxyUsername.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ProxyUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ProxyUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ProxyUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProxyUsername.Hint = "Hint"
        Me.ProxyUsername.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ProxyUsername.Location = New System.Drawing.Point(170, 74)
        Me.ProxyUsername.Name = "ProxyUsername"
        Me.ProxyUsername.Size = New System.Drawing.Size(316, 51)
        Me.ProxyUsername.TabIndex = 2
        Me.ProxyUsername.Text = "username"
        Me.ProxyUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ProxyUsername.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ProxyUsername.TextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.ProxyUsername.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 27)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "代理服务器"
        '
        'ProxyWeb
        '
        Me.ProxyWeb.AccessibleRole = Nothing
        Me.ProxyWeb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProxyWeb.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ProxyWeb.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ProxyWeb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ProxyWeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ProxyWeb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ProxyWeb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProxyWeb.Hint = "Hint"
        Me.ProxyWeb.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ProxyWeb.Location = New System.Drawing.Point(170, 17)
        Me.ProxyWeb.Name = "ProxyWeb"
        Me.ProxyWeb.Size = New System.Drawing.Size(316, 51)
        Me.ProxyWeb.TabIndex = 0
        Me.ProxyWeb.Text = "http://www.baidu.com"
        Me.ProxyWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ProxyWeb.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ProxyWeb.TextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.ProxyWeb.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        '
        'ProxyCheckBox
        '
        Me.ProxyCheckBox.AccessibleRole = Nothing
        Me.ProxyCheckBox.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ProxyCheckBox.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ProxyCheckBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ProxyCheckBox.BackColor = System.Drawing.Color.White
        Me.ProxyCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ProxyCheckBox.BorderColor = System.Drawing.Color.Black
        Me.ProxyCheckBox.BorderWidth = 2.0!
        Me.ProxyCheckBox.Checked = False
        Me.ProxyCheckBox.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ProxyCheckBox.CheckedInForeColor = System.Drawing.Color.White
        Me.ProxyCheckBox.CheckText = "代理服务器"
        Me.ProxyCheckBox.CheckTextColor = System.Drawing.Color.Black
        Me.ProxyCheckBox.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.ProxyCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProxyCheckBox.Enabled = False
        Me.ProxyCheckBox.Location = New System.Drawing.Point(17, 23)
        Me.ProxyCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ProxyCheckBox.MinimumSize = New System.Drawing.Size(20, 20)
        Me.ProxyCheckBox.Name = "ProxyCheckBox"
        Me.ProxyCheckBox.Size = New System.Drawing.Size(171, 35)
        Me.ProxyCheckBox.TabIndex = 0
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
        Me.Chao_TabSelectorBar1.Index = 2
        Me.Chao_TabSelectorBar1.Location = New System.Drawing.Point(0, 60)
        Me.Chao_TabSelectorBar1.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Chao_TabSelectorBar1.Name = "Chao_TabSelectorBar1"
        Me.Chao_TabSelectorBar1.Size = New System.Drawing.Size(702, 50)
        Me.Chao_TabSelectorBar1.SlideColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Chao_TabSelectorBar1.SlideHeight = 2.0!
        Me.Chao_TabSelectorBar1.TabBackColor = System.Drawing.Color.White
        Me.Chao_TabSelectorBar1.TabFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_TabSelectorBar1.TabForeColor = System.Drawing.Color.Black
        Me.Chao_TabSelectorBar1.TabImageList = Nothing
        Me.Chao_TabSelectorBar1.TabIndex = 2
        Me.Chao_TabSelectorBar1.TabSelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(237, Byte), Integer))
        '
        'Chao_Button2
        '
        Me.Chao_Button2.AccessibleRole = Nothing
        Me.Chao_Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Chao_Button2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button2.ButtonBackColor = System.Drawing.Color.Transparent
        Me.Chao_Button2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Chao_Button2.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button2.ButtonShape = "RoundedRectangle"
        Me.Chao_Button2.ButtonText = "还原默认设置"
        Me.Chao_Button2.ButtonType = "ContainedButton"
        Me.Chao_Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button2.Image = Nothing
        Me.Chao_Button2.ImagePosition = "Left"
        Me.Chao_Button2.Location = New System.Drawing.Point(4, 444)
        Me.Chao_Button2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button2.Name = "Chao_Button2"
        Me.Chao_Button2.Size = New System.Drawing.Size(192, 56)
        Me.Chao_Button2.TabIndex = 3
        Me.Chao_Button2.TextColor = System.Drawing.Color.White
        '
        'Chao_Button3
        '
        Me.Chao_Button3.AccessibleRole = Nothing
        Me.Chao_Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_Button3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button3.ButtonBackColor = System.Drawing.Color.Transparent
        Me.Chao_Button3.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Chao_Button3.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button3.ButtonShape = "RoundedRectangle"
        Me.Chao_Button3.ButtonText = "保存"
        Me.Chao_Button3.ButtonType = "ContainedButton"
        Me.Chao_Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button3.Image = Nothing
        Me.Chao_Button3.ImagePosition = "Left"
        Me.Chao_Button3.Location = New System.Drawing.Point(550, 444)
        Me.Chao_Button3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button3.Name = "Chao_Button3"
        Me.Chao_Button3.Size = New System.Drawing.Size(140, 56)
        Me.Chao_Button3.TabIndex = 4
        Me.Chao_Button3.TextColor = System.Drawing.Color.White
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(8, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 27)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "主窗体透明度"
        '
        'Chao_Sliders1
        '
        Me.Chao_Sliders1.AccessibleRole = Nothing
        Me.Chao_Sliders1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Sliders1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Sliders1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Sliders1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Sliders1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_Sliders1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Sliders1.EnableMoveTimer = True
        Me.Chao_Sliders1.Location = New System.Drawing.Point(185, 225)
        Me.Chao_Sliders1.Maximum = 100.0!
        Me.Chao_Sliders1.Minimum = 70.0!
        Me.Chao_Sliders1.Name = "Chao_Sliders1"
        Me.Chao_Sliders1.Size = New System.Drawing.Size(360, 40)
        Me.Chao_Sliders1.SlideBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Chao_Sliders1.SlideFilledColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_Sliders1.TabIndex = 17
        Me.Chao_Sliders1.Value = 100.0!
        '
        'FormSetup
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(702, 500)
        Me.Controls.Add(Me.Chao_Button3)
        Me.Controls.Add(Me.Chao_Button2)
        Me.Controls.Add(Me.Chao_TabSelectorBar1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(702, 500)
        Me.Name = "FormSetup"
        Me.Text = "设置"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.Chao_TabSelectorBar1, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button2, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button3, 0)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Chao_CheckBox1 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox3 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox2 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox7 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_TabSelectorBar1 As ChaoControls.Chao_TabSelectorBar
    Friend WithEvents Chao_Button2 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button3 As ChaoControls.Chao_Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Chao_CheckBox10 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_TextBoxNum As ChaoControls.Chao_TextBox
    Friend WithEvents Chao_CheckBox9 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox8 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox6 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox5 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox4 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox11 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_StatusIndicator3 As ChaoControls.Chao_StatusIndicator
    Friend WithEvents Chao_StatusIndicator2 As ChaoControls.Chao_StatusIndicator
    Friend WithEvents Chao_StatusIndicator1 As ChaoControls.Chao_StatusIndicator
    Friend WithEvents Chao_Button6 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button5 As ChaoControls.Chao_Button
    Friend WithEvents Chao_TextBox3 As ChaoControls.Chao_TextBox
    Friend WithEvents Chao_TextBox2 As ChaoControls.Chao_TextBox
    Friend WithEvents Chao_Button4 As ChaoControls.Chao_Button
    Friend WithEvents Chao_TextBox1 As ChaoControls.Chao_TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Chao_CheckBox12 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox13 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox14 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_StatusIndicator4 As ChaoControls.Chao_StatusIndicator
    Friend WithEvents Chao_Button1 As ChaoControls.Chao_Button
    Friend WithEvents Chao_TextBox4 As ChaoControls.Chao_TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents ProxyCheckBox As ChaoControls.Chao_CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProxyWeb As ChaoControls.Chao_TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ProxyUsername As ChaoControls.Chao_TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ProxyPassword As TextBox
    Friend WithEvents ProxyStatusIndicator As ChaoControls.Chao_StatusIndicator
    Friend WithEvents Chao_Button7 As ChaoControls.Chao_Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Chao_CheckBox15 As ChaoControls.Chao_CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Chao_CheckBox16 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox17 As ChaoControls.Chao_CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Chao_Sliders1 As ChaoControls.Chao_Sliders
End Class
