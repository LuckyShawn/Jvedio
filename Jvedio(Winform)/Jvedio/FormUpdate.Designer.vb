<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdate))
        Me.Chao_Button1 = New ChaoControls.Chao_Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Chao_Button2 = New ChaoControls.Chao_Button()
        Me.Chao_StatusIndicator1 = New ChaoControls.Chao_StatusIndicator()
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
        Me.FormTextLabel.ForeColor = System.Drawing.Color.Black
        Me.FormTextLabel.Location = New System.Drawing.Point(64, 18)
        Me.FormTextLabel.Size = New System.Drawing.Size(113, 27)
        Me.FormTextLabel.Text = "Jvedio更新"
        '
        'SetPicB
        '
        Me.SetPicB.Image = CType(resources.GetObject("SetPicB.Image"), System.Drawing.Image)
        Me.SetPicB.Location = New System.Drawing.Point(225, 19)
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.Pink
        Me.TitlePanel.Size = New System.Drawing.Size(415, 64)
        '
        'SkinPicB
        '
        Me.SkinPicB.Location = New System.Drawing.Point(814, 16)
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
        Me.Chao_Button1.ButtonShape = "RoundedRectangle"
        Me.Chao_Button1.ButtonText = "前往下载"
        Me.Chao_Button1.ButtonType = "ContainedButton"
        Me.Chao_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button1.Image = Nothing
        Me.Chao_Button1.ImagePosition = "Left"
        Me.Chao_Button1.Location = New System.Drawing.Point(254, 215)
        Me.Chao_Button1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button1.Name = "Chao_Button1"
        Me.Chao_Button1.Size = New System.Drawing.Size(151, 70)
        Me.Chao_Button1.TabIndex = 3
        Me.Chao_Button1.TextColor = System.Drawing.Color.White
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "当前版本"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "最新版本"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(166, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "……"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(166, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 31)
        Me.Label4.TabIndex = 7
        '
        'Chao_Button2
        '
        Me.Chao_Button2.AccessibleRole = Nothing
        Me.Chao_Button2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Chao_Button2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Chao_Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Chao_Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chao_Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button2.ButtonBackColor = System.Drawing.Color.Transparent
        Me.Chao_Button2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chao_Button2.ButtonFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Chao_Button2.ButtonShape = "RoundedRectangle"
        Me.Chao_Button2.ButtonText = "检测更新"
        Me.Chao_Button2.ButtonType = "ContainedButton"
        Me.Chao_Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chao_Button2.Image = Nothing
        Me.Chao_Button2.ImagePosition = "Left"
        Me.Chao_Button2.Location = New System.Drawing.Point(29, 215)
        Me.Chao_Button2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Chao_Button2.Name = "Chao_Button2"
        Me.Chao_Button2.Size = New System.Drawing.Size(151, 70)
        Me.Chao_Button2.TabIndex = 8
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
        Me.Chao_StatusIndicator1.Location = New System.Drawing.Point(200, 233)
        Me.Chao_StatusIndicator1.MaximumSize = New System.Drawing.Size(50, 50)
        Me.Chao_StatusIndicator1.MinimumSize = New System.Drawing.Size(25, 25)
        Me.Chao_StatusIndicator1.Name = "Chao_StatusIndicator1"
        Me.Chao_StatusIndicator1.RunningColor = System.Drawing.Color.Gray
        Me.Chao_StatusIndicator1.RunningSpeed = 15
        Me.Chao_StatusIndicator1.Size = New System.Drawing.Size(34, 34)
        Me.Chao_StatusIndicator1.StandByColor = System.Drawing.Color.Blue
        Me.Chao_StatusIndicator1.Status = "Success"
        Me.Chao_StatusIndicator1.SuccessColor = System.Drawing.Color.Green
        Me.Chao_StatusIndicator1.TabIndex = 9
        '
        'FormUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(417, 297)
        Me.Controls.Add(Me.Chao_StatusIndicator1)
        Me.Controls.Add(Me.Chao_Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chao_Button1)
        Me.FormResizable = False
        Me.FormShowMinPicB = False
        Me.Name = "FormUpdate"
        Me.ShowInTaskbar = False
        Me.Text = "Jvedio更新"
        Me.Controls.SetChildIndex(Me.TitlePanel, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Chao_Button2, 0)
        Me.Controls.SetChildIndex(Me.Chao_StatusIndicator1, 0)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Chao_Button2 As ChaoControls.Chao_Button
    Friend WithEvents Chao_StatusIndicator1 As ChaoControls.Chao_StatusIndicator
End Class
