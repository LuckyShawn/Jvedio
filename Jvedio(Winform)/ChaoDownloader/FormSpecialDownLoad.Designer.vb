<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSpecialDownLoad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSpecialDownLoad))
        Me.Chao_TextBox2 = New ChaoControls.Chao_TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chao_TextBox1 = New ChaoControls.Chao_TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chao_Button2 = New ChaoControls.Chao_Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Chao_StatusIndicator1 = New ChaoControls.Chao_StatusIndicator()
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormIconPicB
        '
        Me.FormIconPicB.Location = New System.Drawing.Point(16, 16)
        '
        'FormTextLabel
        '
        Me.FormTextLabel.Location = New System.Drawing.Point(64, 18)
        Me.FormTextLabel.Size = New System.Drawing.Size(92, 27)
        Me.FormTextLabel.Text = "批量下载"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(270, 18)
        '
        'TitlePanel
        '
        Me.TitlePanel.BackgroundImage = Global.ChaoDownloader.My.Resources.Resource.彩色
        Me.TitlePanel.Size = New System.Drawing.Size(460, 64)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(814, 16)
        '
        'Chao_TextBox2
        '
        Me.Chao_TextBox2.AccessibleRole = Nothing
        Me.Chao_TextBox2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_TextBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_TextBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_TextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Chao_TextBox2.Enabled = False
        Me.Chao_TextBox2.Hint = "……"
        Me.Chao_TextBox2.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_TextBox2.Location = New System.Drawing.Point(116, 156)
        Me.Chao_TextBox2.Name = "Chao_TextBox2"
        Me.Chao_TextBox2.Size = New System.Drawing.Size(324, 51)
        Me.Chao_TextBox2.TabIndex = 42
        Me.Chao_TextBox2.Text = "……"
        Me.Chao_TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Chao_TextBox2.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Chao_TextBox2.TextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_TextBox2.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 27)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "识别码："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 27)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "识别码："
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
        Me.Chao_TextBox1.Hint = "……"
        Me.Chao_TextBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_TextBox1.Location = New System.Drawing.Point(116, 80)
        Me.Chao_TextBox1.Name = "Chao_TextBox1"
        Me.Chao_TextBox1.Size = New System.Drawing.Size(324, 51)
        Me.Chao_TextBox1.TabIndex = 39
        Me.Chao_TextBox1.Text = "……"
        Me.Chao_TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Chao_TextBox1.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Chao_TextBox1.TextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_TextBox1.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(263, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 27)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "->"
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
        Me.Chao_Button2.ButtonText = "添加到下载"
        Me.Chao_Button2.ButtonType = "ContainedButton"
        Me.Chao_Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button2.Image = Nothing
        Me.Chao_Button2.ImagePosition = "Left"
        Me.Chao_Button2.Location = New System.Drawing.Point(151, 362)
        Me.Chao_Button2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button2.Name = "Chao_Button2"
        Me.Chao_Button2.Size = New System.Drawing.Size(160, 70)
        Me.Chao_Button2.TabIndex = 46
        Me.Chao_Button2.TextColor = System.Drawing.Color.White
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 27)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "编号："
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 27)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "位数："
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(116, 298)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.ReadOnly = True
        Me.NumericUpDown1.Size = New System.Drawing.Size(107, 30)
        Me.NumericUpDown1.TabIndex = 50
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BackColor = System.Drawing.SystemColors.Control
        Me.NumericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(116, 225)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(130, 30)
        Me.NumericUpDown2.TabIndex = 51
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown2.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.BackColor = System.Drawing.SystemColors.Control
        Me.NumericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NumericUpDown3.Location = New System.Drawing.Point(305, 225)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(130, 30)
        Me.NumericUpDown3.TabIndex = 52
        Me.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown3.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Chao_StatusIndicator1
        '
        Me.Chao_StatusIndicator1.AccessibleRole = Nothing
        Me.Chao_StatusIndicator1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_StatusIndicator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_StatusIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_StatusIndicator1.FailedColor = System.Drawing.Color.Red
        Me.Chao_StatusIndicator1.Location = New System.Drawing.Point(336, 381)
        Me.Chao_StatusIndicator1.MaximumSize = New System.Drawing.Size(50, 50)
        Me.Chao_StatusIndicator1.MinimumSize = New System.Drawing.Size(25, 25)
        Me.Chao_StatusIndicator1.Name = "Chao_StatusIndicator1"
        Me.Chao_StatusIndicator1.RunningColor = System.Drawing.Color.Gray
        Me.Chao_StatusIndicator1.RunningSpeed = 15
        Me.Chao_StatusIndicator1.Size = New System.Drawing.Size(35, 35)
        Me.Chao_StatusIndicator1.StandByColor = System.Drawing.Color.Blue
        Me.Chao_StatusIndicator1.Status = "StandBy"
        Me.Chao_StatusIndicator1.SuccessColor = System.Drawing.Color.Green
        Me.Chao_StatusIndicator1.TabIndex = 53
        '
        'FormSpecialDownLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 444)
        Me.Controls.Add(Me.Chao_StatusIndicator1)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chao_Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Chao_TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chao_TextBox1)
        Me.FormResizable = False
        Me.FormShowMinPicB = False
        Me.MaximumSize = New System.Drawing.Size(462, 444)
        Me.MinimumSize = New System.Drawing.Size(462, 444)
        Me.Name = "FormSpecialDownLoad"
        Me.ShowInTaskbar = False
        Me.Text = "批量下载"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.Chao_TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Chao_TextBox2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.NumericUpDown1, 0)
        Me.Controls.SetChildIndex(Me.NumericUpDown2, 0)
        Me.Controls.SetChildIndex(Me.NumericUpDown3, 0)
        Me.Controls.SetChildIndex(Me.Chao_StatusIndicator1, 0)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chao_TextBox2 As ChaoControls.Chao_TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Chao_TextBox1 As ChaoControls.Chao_TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Chao_Button2 As ChaoControls.Chao_Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Chao_StatusIndicator1 As ChaoControls.Chao_StatusIndicator
End Class
