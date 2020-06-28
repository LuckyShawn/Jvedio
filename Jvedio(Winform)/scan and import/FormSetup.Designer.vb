<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSetup))
        Me.Chao_Button1 = New ChaoControls.Chao_Button()
        Me.Chao_Button2 = New ChaoControls.Chao_Button()
        Me.Chao_Button4 = New ChaoControls.Chao_Button()
        Me.Chao_CheckBox1 = New ChaoControls.Chao_CheckBox()
        Me.Chao_CheckBox2 = New ChaoControls.Chao_CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.FormTextLabel.Location = New System.Drawing.Point(64, 18)
        Me.FormTextLabel.Size = New System.Drawing.Size(64, 27)
        Me.FormTextLabel.Text = "setup"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(-206, 18)
        '
        'TitlePanel
        '
        Me.TitlePanel.BackgroundImage = Global.Import.My.Resources.Picture.panel_bg

        Me.TitlePanel.Size = New System.Drawing.Size(498, 64)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(300, 16)
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
        Me.Chao_Button1.ButtonBackColor = System.Drawing.SystemColors.Control
        Me.Chao_Button1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Chao_Button1.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button1.ButtonShape = "RoundedRectangle"
        Me.Chao_Button1.ButtonText = "保存"
        Me.Chao_Button1.ButtonType = "ContainedButton"
        Me.Chao_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button1.Image = Nothing
        Me.Chao_Button1.ImagePosition = "Left"
        Me.Chao_Button1.Location = New System.Drawing.Point(352, 181)
        Me.Chao_Button1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button1.Name = "Chao_Button1"
        Me.Chao_Button1.Size = New System.Drawing.Size(136, 62)
        Me.Chao_Button1.TabIndex = 78
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
        Me.Chao_Button2.ButtonBackColor = System.Drawing.SystemColors.Control
        Me.Chao_Button2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Chao_Button2.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button2.ButtonShape = "RoundedRectangle"
        Me.Chao_Button2.ButtonText = "恢复默认"
        Me.Chao_Button2.ButtonType = "TextButton"
        Me.Chao_Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button2.Image = Nothing
        Me.Chao_Button2.ImagePosition = "Left"
        Me.Chao_Button2.Location = New System.Drawing.Point(12, 181)
        Me.Chao_Button2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button2.Name = "Chao_Button2"
        Me.Chao_Button2.Size = New System.Drawing.Size(136, 62)
        Me.Chao_Button2.TabIndex = 79
        Me.Chao_Button2.TextColor = System.Drawing.Color.White
        '
        'Chao_Button4
        '
        Me.Chao_Button4.AccessibleRole = Nothing
        Me.Chao_Button4.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button4.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button4.ButtonBackColor = System.Drawing.SystemColors.Control
        Me.Chao_Button4.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Chao_Button4.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Chao_Button4.ButtonShape = "RoundedRectangle"
        Me.Chao_Button4.ButtonText = "浏览额外识别码"
        Me.Chao_Button4.ButtonType = "TextButton"
        Me.Chao_Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button4.Image = Nothing
        Me.Chao_Button4.ImagePosition = "Left"
        Me.Chao_Button4.Location = New System.Drawing.Point(229, 70)
        Me.Chao_Button4.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button4.Name = "Chao_Button4"
        Me.Chao_Button4.Size = New System.Drawing.Size(195, 50)
        Me.Chao_Button4.TabIndex = 81
        Me.Chao_Button4.TextColor = System.Drawing.Color.White
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
        Me.Chao_CheckBox1.CheckText = "启用额外识别码"
        Me.Chao_CheckBox1.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox1.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox1.Location = New System.Drawing.Point(18, 77)
        Me.Chao_CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox1.Name = "Chao_CheckBox1"
        Me.Chao_CheckBox1.Size = New System.Drawing.Size(204, 35)
        Me.Chao_CheckBox1.TabIndex = 82
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
        Me.Chao_CheckBox2.CheckText = "扫描NFO并使用其信息"
        Me.Chao_CheckBox2.CheckTextColor = System.Drawing.Color.Black
        Me.Chao_CheckBox2.CheckTextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_CheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_CheckBox2.Location = New System.Drawing.Point(18, 127)
        Me.Chao_CheckBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Chao_CheckBox2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Chao_CheckBox2.Name = "Chao_CheckBox2"
        Me.Chao_CheckBox2.Size = New System.Drawing.Size(284, 35)
        Me.Chao_CheckBox2.TabIndex = 83
        Me.Chao_CheckBox2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 26)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "?"
        Me.Label1.Visible = False
        '
        'FormSetup
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(500, 250)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chao_CheckBox2)
        Me.Controls.Add(Me.Chao_CheckBox1)
        Me.Controls.Add(Me.Chao_Button4)
        Me.Controls.Add(Me.Chao_Button2)
        Me.Controls.Add(Me.Chao_Button1)
        Me.FormResizable = False
        Me.FormShowMinPicB = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(500, 250)
        Me.MinimumSize = New System.Drawing.Size(500, 250)
        Me.Name = "FormSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "setup"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button1, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button2, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button4, 0)
        Me.Controls.SetChildIndex(Me.Chao_CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.Chao_CheckBox2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chao_Button1 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button2 As ChaoControls.Chao_Button
    Friend WithEvents Chao_Button4 As ChaoControls.Chao_Button
    Friend WithEvents Chao_CheckBox1 As ChaoControls.Chao_CheckBox
    Friend WithEvents Chao_CheckBox2 As ChaoControls.Chao_CheckBox
    Friend WithEvents Label1 As Label
End Class
