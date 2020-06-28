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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Chao_CheckBox3 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox2 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox1 = New ChaoControls.Chao_CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Chao_RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Chao_RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Chao_StatusIndicator3 = New ChaoControls.Chao_StatusIndicator()
        Me.Chao_StatusIndicator2 = New ChaoControls.Chao_StatusIndicator()
        Me.Chao_StatusIndicator1 = New ChaoControls.Chao_StatusIndicator()
        Me.Chao_Button3 = New ChaoControls.Chao_Button()
        Me.Chao_Button2 = New ChaoControls.Chao_Button()
        Me.Chao_TextBox3 = New ChaoControls.Chao_TextBox()
        Me.Chao_TextBox2 = New ChaoControls.Chao_TextBox()
        Me.Chao_Button1 = New ChaoControls.Chao_Button()
        Me.Chao_TextBox1 = New ChaoControls.Chao_TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Chao_CheckBox4 = New ChaoControls.Chao_CheckBox()
        Me.Chao_TabSelectorBar1 = New ChaoControls.Chao_TabSelectorBar()
        Me.Chao_Button4 = New ChaoControls.Chao_Button()
        Me.Chao_Button5 = New ChaoControls.Chao_Button()
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
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
        Me.FormTextLabel.Text = "设置"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(531, 18)
        '
        'TitlePanel
        '
        Me.TitlePanel.BackgroundImage = Global.ChaoDownloader.My.Resources.Resource.彩色
        Me.TitlePanel.Size = New System.Drawing.Size(721, 64)
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
        Me.TabControl1.Location = New System.Drawing.Point(0, 110)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 373)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Chao_CheckBox3)
        Me.TabPage1.Controls.Add(Me.Chao_CheckBox2)
        Me.TabPage1.Controls.Add(Me.Chao_CheckBox1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Chao_RadioButton2)
        Me.TabPage1.Controls.Add(Me.Chao_RadioButton1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(715, 344)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "下载"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(488, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 27)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "则跳过不下载"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"数据库中的信息不为空", "大小图都存在", "至少存在一张预览图", "不跳过"})
        Me.ComboBox1.Location = New System.Drawing.Point(182, 154)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(288, 38)
        Me.ComboBox1.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 27)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "当识别码满足："
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
        Me.Chao_CheckBox3.CheckText = "下载信息到数据库"
        Me.Chao_CheckBox3.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox3.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox3.Location = New System.Drawing.Point(25, 80)
        Me.Chao_CheckBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox3.Name = "Chao_CheckBox3"
        Me.Chao_CheckBox3.Size = New System.Drawing.Size(213, 35)
        Me.Chao_CheckBox3.TabIndex = 56
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
        Me.Chao_CheckBox2.CheckText = "下载信息到NFO"
        Me.Chao_CheckBox2.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox2.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox2.Location = New System.Drawing.Point(262, 80)
        Me.Chao_CheckBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox2.Name = "Chao_CheckBox2"
        Me.Chao_CheckBox2.Size = New System.Drawing.Size(213, 35)
        Me.Chao_CheckBox2.TabIndex = 55
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
        Me.Chao_CheckBox1.CheckText = "下载预览图"
        Me.Chao_CheckBox1.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox1.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox1.Location = New System.Drawing.Point(495, 80)
        Me.Chao_CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox1.Name = "Chao_CheckBox1"
        Me.Chao_CheckBox1.Size = New System.Drawing.Size(213, 35)
        Me.Chao_CheckBox1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 27)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "下载位置："
        '
        'Chao_RadioButton2
        '
        Me.Chao_RadioButton2.BackColor = System.Drawing.Color.White
        Me.Chao_RadioButton2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Chao_RadioButton2.Location = New System.Drawing.Point(314, 21)
        Me.Chao_RadioButton2.MaximumSize = New System.Drawing.Size(2000, 60)
        Me.Chao_RadioButton2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_RadioButton2.Name = "Chao_RadioButton2"
        Me.Chao_RadioButton2.Size = New System.Drawing.Size(313, 30)
        Me.Chao_RadioButton2.TabIndex = 1
        Me.Chao_RadioButton2.Text = "以识别码为名建立新文件夹"
        Me.Chao_RadioButton2.UseVisualStyleBackColor = False
        '
        'Chao_RadioButton1
        '
        Me.Chao_RadioButton1.BackColor = System.Drawing.Color.White
        Me.Chao_RadioButton1.Checked = True
        Me.Chao_RadioButton1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Chao_RadioButton1.Location = New System.Drawing.Point(178, 22)
        Me.Chao_RadioButton1.MaximumSize = New System.Drawing.Size(2000, 60)
        Me.Chao_RadioButton1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_RadioButton1.Name = "Chao_RadioButton1"
        Me.Chao_RadioButton1.Size = New System.Drawing.Size(130, 30)
        Me.Chao_RadioButton1.TabIndex = 0
        Me.Chao_RadioButton1.TabStop = True
        Me.Chao_RadioButton1.Text = "默认"
        Me.Chao_RadioButton1.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Chao_StatusIndicator3)
        Me.TabPage2.Controls.Add(Me.Chao_StatusIndicator2)
        Me.TabPage2.Controls.Add(Me.Chao_StatusIndicator1)
        Me.TabPage2.Controls.Add(Me.Chao_Button3)
        Me.TabPage2.Controls.Add(Me.Chao_Button2)
        Me.TabPage2.Controls.Add(Me.Chao_TextBox3)
        Me.TabPage2.Controls.Add(Me.Chao_TextBox2)
        Me.TabPage2.Controls.Add(Me.Chao_Button1)
        Me.TabPage2.Controls.Add(Me.Chao_TextBox1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(715, 344)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "网站"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        Me.Chao_StatusIndicator3.Location = New System.Drawing.Point(647, 142)
        Me.Chao_StatusIndicator3.MaximumSize = New System.Drawing.Size(50, 50)
        Me.Chao_StatusIndicator3.MinimumSize = New System.Drawing.Size(25, 25)
        Me.Chao_StatusIndicator3.Name = "Chao_StatusIndicator3"
        Me.Chao_StatusIndicator3.RunningColor = System.Drawing.Color.Gray
        Me.Chao_StatusIndicator3.RunningSpeed = 15
        Me.Chao_StatusIndicator3.Size = New System.Drawing.Size(32, 32)
        Me.Chao_StatusIndicator3.StandByColor = System.Drawing.Color.Blue
        Me.Chao_StatusIndicator3.Status = "Success"
        Me.Chao_StatusIndicator3.SuccessColor = System.Drawing.Color.Green
        Me.Chao_StatusIndicator3.TabIndex = 12
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
        Me.Chao_StatusIndicator2.Location = New System.Drawing.Point(647, 86)
        Me.Chao_StatusIndicator2.MaximumSize = New System.Drawing.Size(50, 50)
        Me.Chao_StatusIndicator2.MinimumSize = New System.Drawing.Size(25, 25)
        Me.Chao_StatusIndicator2.Name = "Chao_StatusIndicator2"
        Me.Chao_StatusIndicator2.RunningColor = System.Drawing.Color.Gray
        Me.Chao_StatusIndicator2.RunningSpeed = 15
        Me.Chao_StatusIndicator2.Size = New System.Drawing.Size(32, 32)
        Me.Chao_StatusIndicator2.StandByColor = System.Drawing.Color.Blue
        Me.Chao_StatusIndicator2.Status = "Success"
        Me.Chao_StatusIndicator2.SuccessColor = System.Drawing.Color.Green
        Me.Chao_StatusIndicator2.TabIndex = 11
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
        Me.Chao_StatusIndicator1.Location = New System.Drawing.Point(647, 31)
        Me.Chao_StatusIndicator1.MaximumSize = New System.Drawing.Size(50, 50)
        Me.Chao_StatusIndicator1.MinimumSize = New System.Drawing.Size(25, 25)
        Me.Chao_StatusIndicator1.Name = "Chao_StatusIndicator1"
        Me.Chao_StatusIndicator1.RunningColor = System.Drawing.Color.Gray
        Me.Chao_StatusIndicator1.RunningSpeed = 15
        Me.Chao_StatusIndicator1.Size = New System.Drawing.Size(32, 32)
        Me.Chao_StatusIndicator1.StandByColor = System.Drawing.Color.Blue
        Me.Chao_StatusIndicator1.Status = "Failed"
        Me.Chao_StatusIndicator1.SuccessColor = System.Drawing.Color.Green
        Me.Chao_StatusIndicator1.TabIndex = 10
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
        Me.Chao_Button3.ButtonBackColor = System.Drawing.Color.White
        Me.Chao_Button3.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button3.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button3.ButtonShape = "RoundedRectangle"
        Me.Chao_Button3.ButtonText = "测试"
        Me.Chao_Button3.ButtonType = "ContainedButton"
        Me.Chao_Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button3.Image = Nothing
        Me.Chao_Button3.ImagePosition = "Left"
        Me.Chao_Button3.Location = New System.Drawing.Point(497, 130)
        Me.Chao_Button3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button3.Name = "Chao_Button3"
        Me.Chao_Button3.Size = New System.Drawing.Size(128, 51)
        Me.Chao_Button3.TabIndex = 8
        Me.Chao_Button3.TextColor = System.Drawing.Color.White
        Me.Chao_Button3.Visible = False
        '
        'Chao_Button2
        '
        Me.Chao_Button2.AccessibleRole = Nothing
        Me.Chao_Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_Button2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button2.ButtonBackColor = System.Drawing.Color.White
        Me.Chao_Button2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button2.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button2.ButtonShape = "RoundedRectangle"
        Me.Chao_Button2.ButtonText = "测试"
        Me.Chao_Button2.ButtonType = "ContainedButton"
        Me.Chao_Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button2.Image = Nothing
        Me.Chao_Button2.ImagePosition = "Left"
        Me.Chao_Button2.Location = New System.Drawing.Point(497, 73)
        Me.Chao_Button2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button2.Name = "Chao_Button2"
        Me.Chao_Button2.Size = New System.Drawing.Size(128, 51)
        Me.Chao_Button2.TabIndex = 7
        Me.Chao_Button2.TextColor = System.Drawing.Color.White
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
        Me.Chao_TextBox3.Location = New System.Drawing.Point(122, 131)
        Me.Chao_TextBox3.Name = "Chao_TextBox3"
        Me.Chao_TextBox3.Size = New System.Drawing.Size(369, 51)
        Me.Chao_TextBox3.TabIndex = 6
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
        Me.Chao_TextBox2.Location = New System.Drawing.Point(122, 74)
        Me.Chao_TextBox2.Name = "Chao_TextBox2"
        Me.Chao_TextBox2.Size = New System.Drawing.Size(369, 51)
        Me.Chao_TextBox2.TabIndex = 5
        Me.Chao_TextBox2.Text = "http://www.baidu.com"
        Me.Chao_TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Chao_TextBox2.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Chao_TextBox2.TextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_TextBox2.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
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
        Me.Chao_Button1.Location = New System.Drawing.Point(497, 16)
        Me.Chao_Button1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button1.Name = "Chao_Button1"
        Me.Chao_Button1.Size = New System.Drawing.Size(128, 51)
        Me.Chao_Button1.TabIndex = 4
        Me.Chao_Button1.TextColor = System.Drawing.Color.White
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
        Me.Chao_TextBox1.Location = New System.Drawing.Point(122, 16)
        Me.Chao_TextBox1.Name = "Chao_TextBox1"
        Me.Chao_TextBox1.Size = New System.Drawing.Size(369, 51)
        Me.Chao_TextBox1.TabIndex = 3
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
        Me.Label3.Location = New System.Drawing.Point(40, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FC源"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DB源"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bus源"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Chao_CheckBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(715, 344)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "其它"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        Me.Chao_CheckBox4.CheckText = "关闭后最小化"
        Me.Chao_CheckBox4.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox4.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox4.Location = New System.Drawing.Point(12, 22)
        Me.Chao_CheckBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox4.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox4.Name = "Chao_CheckBox4"
        Me.Chao_CheckBox4.Size = New System.Drawing.Size(213, 35)
        Me.Chao_CheckBox4.TabIndex = 4
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
        Me.Chao_TabSelectorBar1.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Chao_TabSelectorBar1.Name = "Chao_TabSelectorBar1"
        Me.Chao_TabSelectorBar1.Size = New System.Drawing.Size(723, 50)
        Me.Chao_TabSelectorBar1.SlideColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_TabSelectorBar1.SlideHeight = 2.0!
        Me.Chao_TabSelectorBar1.TabBackColor = System.Drawing.Color.White
        Me.Chao_TabSelectorBar1.TabFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_TabSelectorBar1.TabForeColor = System.Drawing.Color.Black
        Me.Chao_TabSelectorBar1.TabImageList = Nothing
        Me.Chao_TabSelectorBar1.TabIndex = 2
        Me.Chao_TabSelectorBar1.TabSelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        '
        'Chao_Button4
        '
        Me.Chao_Button4.AccessibleRole = Nothing
        Me.Chao_Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Chao_Button4.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button4.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button4.ButtonBackColor = System.Drawing.SystemColors.Control
        Me.Chao_Button4.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button4.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button4.ButtonShape = "RoundedRectangle"
        Me.Chao_Button4.ButtonText = "还原默认设置"
        Me.Chao_Button4.ButtonType = "ContainedButton"
        Me.Chao_Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button4.Image = Nothing
        Me.Chao_Button4.ImagePosition = "Left"
        Me.Chao_Button4.Location = New System.Drawing.Point(4, 489)
        Me.Chao_Button4.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button4.Name = "Chao_Button4"
        Me.Chao_Button4.Size = New System.Drawing.Size(197, 57)
        Me.Chao_Button4.TabIndex = 3
        Me.Chao_Button4.TextColor = System.Drawing.Color.White
        '
        'Chao_Button5
        '
        Me.Chao_Button5.AccessibleRole = Nothing
        Me.Chao_Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chao_Button5.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button5.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button5.ButtonBackColor = System.Drawing.SystemColors.Control
        Me.Chao_Button5.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button5.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button5.ButtonShape = "RoundedRectangle"
        Me.Chao_Button5.ButtonText = "保存"
        Me.Chao_Button5.ButtonType = "ContainedButton"
        Me.Chao_Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button5.Image = Nothing
        Me.Chao_Button5.ImagePosition = "Left"
        Me.Chao_Button5.Location = New System.Drawing.Point(579, 489)
        Me.Chao_Button5.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button5.Name = "Chao_Button5"
        Me.Chao_Button5.Size = New System.Drawing.Size(140, 57)
        Me.Chao_Button5.TabIndex = 4
        Me.Chao_Button5.TextColor = System.Drawing.Color.White
        '
        'FormSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 551)
        Me.Controls.Add(Me.Chao_Button5)
        Me.Controls.Add(Me.Chao_Button4)
        Me.Controls.Add(Me.Chao_TabSelectorBar1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(723, 551)
        Me.Name = "FormSetup"
        Me.Text = "设置"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.Chao_TabSelectorBar1, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button4, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button5, 0)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Chao_Button1 As ChaoControls.Chao_Button
    Friend WithEvents Chao_TextBox1 As ChaoControls.Chao_TextBox
    Friend WithEvents Chao_Button3 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button2 As ChaoControls.Chao_Button
    Friend WithEvents Chao_TextBox3 As ChaoControls.Chao_TextBox
    Friend WithEvents Chao_TextBox2 As ChaoControls.Chao_TextBox
    Friend WithEvents Chao_StatusIndicator1 As ChaoControls.Chao_StatusIndicator
    Friend WithEvents Chao_StatusIndicator3 As ChaoControls.Chao_StatusIndicator
    Friend WithEvents Chao_StatusIndicator2 As ChaoControls.Chao_StatusIndicator
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Chao_TabSelectorBar1 As ChaoControls.Chao_TabSelectorBar
    Friend WithEvents Chao_Button4 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button5 As ChaoControls.Chao_Button
    Friend WithEvents Chao_RadioButton2 As RadioButton
    Friend WithEvents Chao_RadioButton1 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Chao_CheckBox1 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox4 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox3 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox2 As ChaoControls.Chao_CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
End Class
