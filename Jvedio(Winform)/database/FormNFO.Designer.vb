<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNFO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNFO))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chao_Button1 = New ChaoControls.Chao_Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chao_CheckBox1 = New ChaoControls.Chao_CheckBox()
        Me.Chao_Button2 = New ChaoControls.Chao_Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Chao_StatusIndicator1 = New ChaoControls.Chao_StatusIndicator()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormIconPicB
        '
        Me.FormIconPicB.Location = New System.Drawing.Point(16, 16)
        '
        'FormTextLabel
        '
        Me.FormTextLabel.Location = New System.Drawing.Point(64, 18)
        Me.FormTextLabel.Size = New System.Drawing.Size(95, 27)
        Me.FormTextLabel.Text = "扫描NFO"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(408, 20)
        '
        'TitlePanel
        '
        Me.TitlePanel.BackgroundImage = Global.database.My.Resources.Picture.panel_bg
        Me.TitlePanel.Size = New System.Drawing.Size(598, 64)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(400, 16)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "扫描文件夹"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(119, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(350, 25)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(475, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "选择文件夹"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.Chao_Button1.ButtonText = "扫描"
        Me.Chao_Button1.ButtonType = "ContainedButton"
        Me.Chao_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button1.Image = Nothing
        Me.Chao_Button1.ImagePosition = "Left"
        Me.Chao_Button1.Location = New System.Drawing.Point(58, 218)
        Me.Chao_Button1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button1.Name = "Chao_Button1"
        Me.Chao_Button1.Size = New System.Drawing.Size(197, 75)
        Me.Chao_Button1.TabIndex = 4
        Me.Chao_Button1.TextColor = System.Drawing.Color.White
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(598, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "状态栏"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Chao_CheckBox1.Checked = True
        Me.Chao_CheckBox1.CheckedInBackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Chao_CheckBox1.CheckedInForeColor = System.Drawing.Color.White
        Me.Chao_CheckBox1.CheckText = "覆盖已存在的信息"
        Me.Chao_CheckBox1.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox1.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox1.Location = New System.Drawing.Point(58, 144)
        Me.Chao_CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox1.Name = "Chao_CheckBox1"
        Me.Chao_CheckBox1.Size = New System.Drawing.Size(240, 35)
        Me.Chao_CheckBox1.TabIndex = 6
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
        Me.Chao_Button2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button2.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button2.ButtonShape = "RoundedRectangle"
        Me.Chao_Button2.ButtonText = "导入"
        Me.Chao_Button2.ButtonType = "ContainedButton"
        Me.Chao_Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button2.Image = Nothing
        Me.Chao_Button2.ImagePosition = "Left"
        Me.Chao_Button2.Location = New System.Drawing.Point(354, 218)
        Me.Chao_Button2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button2.Name = "Chao_Button2"
        Me.Chao_Button2.Size = New System.Drawing.Size(197, 75)
        Me.Chao_Button2.TabIndex = 7
        Me.Chao_Button2.TextColor = System.Drawing.Color.White
        '
        'Chao_StatusIndicator1
        '
        Me.Chao_StatusIndicator1.AccessibleRole = Nothing
        Me.Chao_StatusIndicator1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_StatusIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_StatusIndicator1.FailedColor = System.Drawing.Color.Red
        Me.Chao_StatusIndicator1.Location = New System.Drawing.Point(277, 232)
        Me.Chao_StatusIndicator1.MaximumSize = New System.Drawing.Size(50, 50)
        Me.Chao_StatusIndicator1.MinimumSize = New System.Drawing.Size(25, 25)
        Me.Chao_StatusIndicator1.Name = "Chao_StatusIndicator1"
        Me.Chao_StatusIndicator1.RunningColor = System.Drawing.Color.Gray
        Me.Chao_StatusIndicator1.RunningSpeed = 15
        Me.Chao_StatusIndicator1.Size = New System.Drawing.Size(50, 50)
        Me.Chao_StatusIndicator1.StandByColor = System.Drawing.Color.Blue
        Me.Chao_StatusIndicator1.Status = "Success"
        Me.Chao_StatusIndicator1.SuccessColor = System.Drawing.Color.Green
        Me.Chao_StatusIndicator1.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.database.My.Resources.Picture.问号
        Me.PictureBox2.Location = New System.Drawing.Point(544, 144)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 78
        Me.PictureBox2.TabStop = False
        '
        'FormNFO
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(600, 350)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Chao_StatusIndicator1)
        Me.Controls.Add(Me.Chao_Button2)
        Me.Controls.Add(Me.Chao_CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Chao_Button1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormResizable = False
        Me.MaximumSize = New System.Drawing.Size(600, 350)
        Me.MinimumSize = New System.Drawing.Size(600, 350)
        Me.Name = "FormNFO"
        Me.ShowIcon = False
        Me.Text = "扫描NFO"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Chao_CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button2, 0)
        Me.Controls.SetChildIndex(Me.Chao_StatusIndicator1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox2, 0)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Chao_Button1 As ChaoControls.Chao_Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Chao_CheckBox1 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_Button2 As ChaoControls.Chao_Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Chao_StatusIndicator1 As ChaoControls.Chao_StatusIndicator
    Friend WithEvents PictureBox2 As PictureBox
End Class
