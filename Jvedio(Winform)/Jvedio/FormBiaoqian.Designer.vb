<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBiaoqian
    Inherits System.Windows.Forms.Form

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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chao_FlowLayoutPanel1 = New ChaoControls.Chao_FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 695)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Chao_FlowLayoutPanel1
        '
        Me.Chao_FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Chao_FlowLayoutPanel1.AutoScroll = True
        Me.Chao_FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Chao_FlowLayoutPanel1.Location = New System.Drawing.Point(66, 12)
        Me.Chao_FlowLayoutPanel1.Name = "Chao_FlowLayoutPanel1"
        Me.Chao_FlowLayoutPanel1.Size = New System.Drawing.Size(422, 449)
        Me.Chao_FlowLayoutPanel1.TabIndex = 2
        '
        'FormBiaoqian
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Jvedio.My.Resources.Resource_Image.biaoqian
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.Chao_FlowLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBiaoqian"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "FormBiaoqian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Chao_FlowLayoutPanel1 As ChaoControls.Chao_FlowLayoutPanel
End Class
