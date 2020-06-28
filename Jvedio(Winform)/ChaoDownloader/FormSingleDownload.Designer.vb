<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSingleDownload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSingleDownload))
        Me.Chao_TextBox1 = New ChaoControls.Chao_TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chao_Button1 = New ChaoControls.Chao_Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chao_TextBox2 = New ChaoControls.Chao_TextBox()
        Me.Chao_Button2 = New ChaoControls.Chao_Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
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
        Me.FormTextLabel.Size = New System.Drawing.Size(92, 27)
        Me.FormTextLabel.Text = "单个下载"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(378, 18)
        '
        'TitlePanel
        '
        Me.TitlePanel.BackgroundImage = Global.ChaoDownloader.My.Resources.Resource.彩色
        Me.TitlePanel.Size = New System.Drawing.Size(568, 64)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(814, 16)
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
        Me.Chao_TextBox1.Hint = "……"
        Me.Chao_TextBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_TextBox1.Location = New System.Drawing.Point(109, 83)
        Me.Chao_TextBox1.Name = "Chao_TextBox1"
        Me.Chao_TextBox1.Size = New System.Drawing.Size(301, 51)
        Me.Chao_TextBox1.TabIndex = 1
        Me.Chao_TextBox1.Text = "……"
        Me.Chao_TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Chao_TextBox1.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Chao_TextBox1.TextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_TextBox1.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "指定为："
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(416, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "或"
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
        Me.Chao_Button1.ButtonBackColor = System.Drawing.SystemColors.Control
        Me.Chao_Button1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button1.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Chao_Button1.ButtonShape = "RoundedRectangle"
        Me.Chao_Button1.ButtonText = "选择视频"
        Me.Chao_Button1.ButtonType = "TextButton"
        Me.Chao_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button1.Image = Nothing
        Me.Chao_Button1.ImagePosition = "Left"
        Me.Chao_Button1.Location = New System.Drawing.Point(445, 83)
        Me.Chao_Button1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button1.Name = "Chao_Button1"
        Me.Chao_Button1.Size = New System.Drawing.Size(113, 51)
        Me.Chao_Button1.TabIndex = 36
        Me.Chao_Button1.TextColor = System.Drawing.Color.White
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 27)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "识别码为："
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
        Me.Chao_TextBox2.Enabled = False
        Me.Chao_TextBox2.Hint = "……"
        Me.Chao_TextBox2.LineColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Chao_TextBox2.Location = New System.Drawing.Point(109, 159)
        Me.Chao_TextBox2.Name = "Chao_TextBox2"
        Me.Chao_TextBox2.Size = New System.Drawing.Size(438, 51)
        Me.Chao_TextBox2.TabIndex = 38
        Me.Chao_TextBox2.Text = "……"
        Me.Chao_TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Chao_TextBox2.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Chao_TextBox2.TextFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_TextBox2.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
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
        Me.Chao_Button2.Location = New System.Drawing.Point(205, 223)
        Me.Chao_Button2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button2.Name = "Chao_Button2"
        Me.Chao_Button2.Size = New System.Drawing.Size(160, 70)
        Me.Chao_Button2.TabIndex = 39
        Me.Chao_Button2.TextColor = System.Drawing.Color.White
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormSingleDownload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 305)
        Me.Controls.Add(Me.Chao_Button2)
        Me.Controls.Add(Me.Chao_TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Chao_Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chao_TextBox1)
        Me.FormResizable = False
        Me.FormShowMinPicB = False
        Me.MaximumSize = New System.Drawing.Size(570, 305)
        Me.MinimumSize = New System.Drawing.Size(570, 305)
        Me.Name = "FormSingleDownload"
        Me.ShowInTaskbar = False
        Me.Text = "单个下载"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.Chao_TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Chao_TextBox2, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button2, 0)
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chao_TextBox1 As ChaoControls.Chao_TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Chao_Button1 As ChaoControls.Chao_Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Chao_TextBox2 As ChaoControls.Chao_TextBox
    Friend WithEvents Chao_Button2 As ChaoControls.Chao_Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
