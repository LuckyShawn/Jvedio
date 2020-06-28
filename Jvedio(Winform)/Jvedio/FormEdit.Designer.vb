<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEdit))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Chao_Button1 = New ChaoControls.Chao_Button()
        Me.Chao_Button2 = New ChaoControls.Chao_Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormIconPicB
        '
        Me.FormIconPicB.Location = New System.Drawing.Point(16, 16)
        '
        'FormTextLabel
        '
        Me.FormTextLabel.ForeColor = System.Drawing.Color.White
        Me.FormTextLabel.Location = New System.Drawing.Point(64, 18)
        Me.FormTextLabel.Size = New System.Drawing.Size(52, 27)
        Me.FormTextLabel.Text = "编辑"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(408, 18)
        '
        'TitlePanel
        '
        Me.TitlePanel.Size = New System.Drawing.Size(598, 64)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(814, 16)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(48, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 27)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(38, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 27)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "番号"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(133, 108)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(454, 25)
        Me.TextBox2.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(38, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 27)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "名称"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(133, 149)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(454, 25)
        Me.TextBox3.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(18, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 27)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "视频类型"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(18, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 27)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "发行日期"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(18, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 27)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "播放时长"
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.ForeColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(134, 272)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(454, 25)
        Me.TextBox6.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(28, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 27)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "制作商"
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.ForeColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(134, 313)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(454, 25)
        Me.TextBox7.TabIndex = 77
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(28, 354)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 27)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "发行商"
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.ForeColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(133, 354)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(454, 25)
        Me.TextBox8.TabIndex = 79
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0-其它", "1-步兵", "2-骑兵", "3-欧美"})
        Me.ComboBox1.Location = New System.Drawing.Point(133, 190)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 23)
        Me.ComboBox1.TabIndex = 81
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(133, 231)
        Me.DateTimePicker1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePicker1.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(38, 395)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 27)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "导演"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(134, 395)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(454, 25)
        Me.TextBox1.TabIndex = 83
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(38, 436)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 27)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "类别"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(133, 436)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(454, 25)
        Me.TextBox4.TabIndex = 85
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(38, 477)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 27)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "演员"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(133, 477)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(454, 25)
        Me.TextBox5.TabIndex = 87
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(38, 518)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 27)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "系列"
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox9.ForeColor = System.Drawing.Color.White
        Me.TextBox9.Location = New System.Drawing.Point(133, 518)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(454, 25)
        Me.TextBox9.TabIndex = 89
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(18, 559)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 27)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "喜爱程度"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(38, 600)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 27)
        Me.Label15.TabIndex = 93
        Me.Label15.Text = "标签"
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox10.ForeColor = System.Drawing.Color.White
        Me.TextBox10.Location = New System.Drawing.Point(133, 600)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(454, 25)
        Me.TextBox10.TabIndex = 92
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(128, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 27)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "ID"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.ForeColor = System.Drawing.Color.White
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"0-不喜欢", "1", "2", "3", "4", "5"})
        Me.ComboBox2.Location = New System.Drawing.Point(134, 559)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(199, 23)
        Me.ComboBox2.TabIndex = 95
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
        Me.Chao_Button1.ButtonBackColor = System.Drawing.Color.Transparent
        Me.Chao_Button1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Chao_Button1.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button1.ButtonShape = "RoundedRectangle"
        Me.Chao_Button1.ButtonText = "保存"
        Me.Chao_Button1.ButtonType = "ContainedButton"
        Me.Chao_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button1.Image = Nothing
        Me.Chao_Button1.ImagePosition = "Left"
        Me.Chao_Button1.Location = New System.Drawing.Point(136, 745)
        Me.Chao_Button1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button1.Name = "Chao_Button1"
        Me.Chao_Button1.Size = New System.Drawing.Size(119, 50)
        Me.Chao_Button1.TabIndex = 98
        Me.Chao_Button1.TextColor = System.Drawing.Color.White
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
        Me.Chao_Button2.ButtonBackColor = System.Drawing.Color.Transparent
        Me.Chao_Button2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Chao_Button2.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button2.ButtonShape = "RoundedRectangle"
        Me.Chao_Button2.ButtonText = "关闭"
        Me.Chao_Button2.ButtonType = "ContainedButton"
        Me.Chao_Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button2.Image = Nothing
        Me.Chao_Button2.ImagePosition = "Left"
        Me.Chao_Button2.Location = New System.Drawing.Point(329, 745)
        Me.Chao_Button2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button2.Name = "Chao_Button2"
        Me.Chao_Button2.Size = New System.Drawing.Size(132, 50)
        Me.Chao_Button2.TabIndex = 99
        Me.Chao_Button2.TextColor = System.Drawing.Color.White
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(513, 647)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 109
        Me.Button1.Text = "选择文件"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox11.ForeColor = System.Drawing.Color.White
        Me.TextBox11.Location = New System.Drawing.Point(133, 647)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(374, 25)
        Me.TextBox11.TabIndex = 108
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(136, 692)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 27)
        Me.Label18.TabIndex = 107
        Me.Label18.Text = "……"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(18, 642)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 27)
        Me.Label17.TabIndex = 106
        Me.Label17.Text = "文件位置"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 692)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 27)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "文件大小"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormEdit
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 800)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chao_Button2)
        Me.Controls.Add(Me.Chao_Button1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.MinimumSize = New System.Drawing.Size(500, 800)
        Me.Name = "FormEdit"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "编辑"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TextBox3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TextBox6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TextBox7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TextBox8, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.Controls.SetChildIndex(Me.DateTimePicker1, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TextBox4, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TextBox5, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.TextBox9, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.TextBox10, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.ComboBox2, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button1, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.TextBox11, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Chao_Button1 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button2 As ChaoControls.Chao_Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
