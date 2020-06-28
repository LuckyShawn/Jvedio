<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQuickEdit
    Inherits ChaoForm.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormQuickEdit))
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Chao_CheckBox3 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox2 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox1 = New ChaoControls.Chao_CheckBox()
        Me.Chao_Button2 = New ChaoControls.Chao_Button()
        Me.Chao_Button1 = New ChaoControls.Chao_Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Chao_ProgressIndicators1 = New ChaoControls.Chao_ProgressIndicators()
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.FormTextLabel.Size = New System.Drawing.Size(92, 27)
        Me.FormTextLabel.Text = "批量设置"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(336, 20)
        '
        'TitlePanel
        '
        Me.TitlePanel.Size = New System.Drawing.Size(526, 64)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(814, 16)
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.ForeColor = System.Drawing.Color.White
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"0-不喜欢", "1", "2", "3", "4", "5"})
        Me.ComboBox2.Location = New System.Drawing.Point(162, 149)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(322, 23)
        Me.ComboBox2.TabIndex = 101
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(161, 188)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(323, 25)
        Me.TextBox1.TabIndex = 99
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0-其它", "1-步兵", "2-骑兵", "3-欧美"})
        Me.ComboBox1.Location = New System.Drawing.Point(161, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(323, 23)
        Me.ComboBox1.TabIndex = 97
        '
        'Chao_CheckBox3
        '
        Me.Chao_CheckBox3.AccessibleRole = Nothing
        Me.Chao_CheckBox3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox3.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox3.BorderWidth = 2.0!
        Me.Chao_CheckBox3.Checked = False
        Me.Chao_CheckBox3.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox3.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox3.CheckText = "设置标签"
        Me.Chao_CheckBox3.CheckTextColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Chao_CheckBox3.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox3.Location = New System.Drawing.Point(14, 186)
        Me.Chao_CheckBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox3.Name = "Chao_CheckBox3"
        Me.Chao_CheckBox3.Size = New System.Drawing.Size(125, 27)
        Me.Chao_CheckBox3.TabIndex = 106
        '
        'Chao_CheckBox2
        '
        Me.Chao_CheckBox2.AccessibleRole = Nothing
        Me.Chao_CheckBox2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox2.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox2.BorderWidth = 2.0!
        Me.Chao_CheckBox2.Checked = False
        Me.Chao_CheckBox2.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox2.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox2.CheckText = "喜爱程度"
        Me.Chao_CheckBox2.CheckTextColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Chao_CheckBox2.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox2.Location = New System.Drawing.Point(14, 145)
        Me.Chao_CheckBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox2.Name = "Chao_CheckBox2"
        Me.Chao_CheckBox2.Size = New System.Drawing.Size(125, 27)
        Me.Chao_CheckBox2.TabIndex = 105
        '
        'Chao_CheckBox1
        '
        Me.Chao_CheckBox1.AccessibleRole = Nothing
        Me.Chao_CheckBox1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_CheckBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_CheckBox1.BorderColor = System.Drawing.Color.Black
        Me.Chao_CheckBox1.BorderWidth = 2.0!
        Me.Chao_CheckBox1.Checked = False
        Me.Chao_CheckBox1.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox1.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox1.CheckText = "视频类型"
        Me.Chao_CheckBox1.CheckTextColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Chao_CheckBox1.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox1.Location = New System.Drawing.Point(14, 102)
        Me.Chao_CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox1.Name = "Chao_CheckBox1"
        Me.Chao_CheckBox1.Size = New System.Drawing.Size(125, 27)
        Me.Chao_CheckBox1.TabIndex = 104
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
        Me.Chao_Button2.Location = New System.Drawing.Point(311, 279)
        Me.Chao_Button2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button2.Name = "Chao_Button2"
        Me.Chao_Button2.Size = New System.Drawing.Size(132, 50)
        Me.Chao_Button2.TabIndex = 103
        Me.Chao_Button2.TextColor = System.Drawing.Color.White
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
        Me.Chao_Button1.Location = New System.Drawing.Point(113, 279)
        Me.Chao_Button1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button1.Name = "Chao_Button1"
        Me.Chao_Button1.Size = New System.Drawing.Size(119, 50)
        Me.Chao_Button1.TabIndex = 102
        Me.Chao_Button1.TextColor = System.Drawing.Color.White
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(158, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 15)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "PS:标签以空格分开"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Chao_ProgressIndicators1)
        Me.Panel1.Location = New System.Drawing.Point(467, 245)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(504, 258)
        Me.Panel1.TabIndex = 108
        '
        'Chao_ProgressIndicators1
        '
        Me.Chao_ProgressIndicators1.AccessibleRole = Nothing
        Me.Chao_ProgressIndicators1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_ProgressIndicators1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_ProgressIndicators1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_ProgressIndicators1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_ProgressIndicators1.BarBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Chao_ProgressIndicators1.BarFilledColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_ProgressIndicators1.Location = New System.Drawing.Point(11, 117)
        Me.Chao_ProgressIndicators1.Name = "Chao_ProgressIndicators1"
        Me.Chao_ProgressIndicators1.ProgressType = "Linear"
        Me.Chao_ProgressIndicators1.Size = New System.Drawing.Size(482, 25)
        Me.Chao_ProgressIndicators1.TabIndex = 0
        '
        'FormQuickEdit
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(528, 341)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Chao_Button2)
        Me.Controls.Add(Me.Chao_Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chao_CheckBox3)
        Me.Controls.Add(Me.Chao_CheckBox2)
        Me.Controls.Add(Me.Chao_CheckBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormResizable = False
        Me.FormShowMinPicB = False
        Me.MaximumSize = New System.Drawing.Size(528, 341)
        Me.MinimumSize = New System.Drawing.Size(528, 341)
        Me.Name = "FormQuickEdit"
        Me.ShowInTaskbar = False
        Me.Text = "批量设置"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.ComboBox2, 0)
        Me.Controls.SetChildIndex(Me.Chao_CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.Chao_CheckBox2, 0)
        Me.Controls.SetChildIndex(Me.Chao_CheckBox3, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button1, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button2, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Chao_Button1 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button2 As ChaoControls.Chao_Button
    Friend WithEvents Chao_CheckBox1 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox2 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox3 As ChaoControls.Chao_CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Chao_ProgressIndicators1 As ChaoControls.Chao_ProgressIndicators
End Class
