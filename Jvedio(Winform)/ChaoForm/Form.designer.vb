Imports System.ComponentModel
Imports System.Configuration
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    Private WithEvents FormSetting As FormSettings

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

        Me.SetStyle(
                ControlStyles.UserPaint Or
                ControlStyles.AllPaintingInWmPaint Or
                ControlStyles.OptimizedDoubleBuffer Or
                ControlStyles.ResizeRedraw Or
                ControlStyles.DoubleBuffer, True)

        UpdateStyles()


    End Sub




    Protected Overrides Sub OnResizeBegin(e As EventArgs)
        MyBase.OnResizeBegin(e)
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnResizeEnd(e As EventArgs)
        MyBase.OnResizeEnd(e)
        Me.Invalidate()
    End Sub

    'Sub SetSkin()
    '    '设置皮肤
    '    Console.WriteLine(FormSetting.SkinStyle)
    '    Dim SkinColor As New Skin(FormSetting.SkinStyle)
    '    Me.BackColor = SkinColor.BC2
    '    TitlePanel.BackColor = SkinColor.BC1
    '    FormTextLabel.ForeColor = SkinColor.FC1

    'End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        FormSetting = New FormSettings(Me.Name & Me.Text)

        '调整带下位置
        If Not DesignMode Then
            '用 Me.Name & Me.Text 来表示当前窗体设置的唯一标识性

            With FormSetting

                If FormResizable Then Me.Size = .FormSize

                If .FormStatus = "Normal" Then
                    MaxPicB.Image = My.Resources.Resource1.最大化1

                    If .FormLocation.X = 0 And .FormLocation.Y = 0 Then
                        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
                        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
                    Else
                        Me.Location = .FormLocation
                    End If
                Else
                    '最大化模式
                    MaxPicB.Image = My.Resources.Resource1.窗口化1

                End If

            End With

            If TitlePicB.Image IsNot Nothing Then
                FormTextLabel.Visible = False
            Else
                FormTextLabel.Visible = True
            End If


        End If

            'SetSkin()



            With TitlePanel
            .Width = Me.Width - 2
            .Location = New Point(1, 1)
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
        End With


        With ClosePicB
                .Image = My.Resources.Resource1.关闭1
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Size = New Size(24, 24)
                .Location = New Point(Me.Width - .Width - .Width, (TitlePanel.Height - .Height) / 2)
            .Anchor = AnchorStyles.Right Or AnchorStyles.Top
            .BackColor = Color.Transparent
                .Visible = True
                AddHandler .MouseEnter, AddressOf PicB_MouseEnter
                AddHandler .MouseLeave, AddressOf PicB_MouseLeave
            End With

        With MaxPicB
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Size = New Size(24, 24)
            .Location = New Point(ClosePicB.Left - 2 * .Width, ClosePicB.Top)
            .Anchor = AnchorStyles.Right Or AnchorStyles.Top
            .BackColor = Color.Transparent
            .Visible = FormResizable
            AddHandler .MouseEnter, AddressOf PicB_MouseEnter
            AddHandler .MouseLeave, AddressOf PicB_MouseLeave
        End With

        With MinPicB
                .Image = My.Resources.Resource1.最小化1
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Size = New Size(24, 24)
                .Top = ClosePicB.Top
                .Left = ClosePicB.Left - 2 * .Width - 2 * .Width * Int(FormResizable)
                .Anchor = AnchorStyles.Right Or AnchorStyles.Top
                .BackColor = Color.Transparent
                .Visible = FormShowMinPicB
                AddHandler .MouseEnter, AddressOf PicB_MouseEnter
                AddHandler .MouseLeave, AddressOf PicB_MouseLeave
            End With


        With SetPicB
            .Image = My.Resources.Resource1.选项1
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Size = New Size(24, 24)
            .Top = ClosePicB.Top
            .Left = ClosePicB.Left - 2 * .Width - 2 * .Width * (Int(FormShowMinPicB) + Int(FormResizable))
            .Anchor = AnchorStyles.Right Or AnchorStyles.Top
            .BackColor = Color.Transparent
            .Visible = FormShowSetupPicB
            AddHandler .MouseEnter, AddressOf PicB_MouseEnter
            AddHandler .MouseLeave, AddressOf PicB_MouseLeave
        End With

        With SkinPicB
            .Visible = FormShowSkinPicB
            .Top = (TitlePanel.Height - .Height) / 2
            .Left = ClosePicB.Left - .Width - 2 * ClosePicB.Width * (Int(FormShowMinPicB) + Int(FormResizable) + Int(FormShowSetupPicB) + 0.5)

        End With


        With FormIconPicB
                .Size = New Size(32, 32)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Top = (TitlePanel.Height - .Height) / 2
            .Left = .Width / 2
            .BackColor = Color.Transparent
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top
            End With

        With FormTextLabel
            .BackColor = Color.Transparent
            .Text = Me.Text
            .AutoSize = True
            .Left = FormIconPicB.Left + FormIconPicB.Width * 1.5
            .Top = (TitlePanel.Height - .Height) / 2
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top
        End With

        Dim TextLabelLength As Single = FormTextLabel.Width
        If TextLabelLength >= Screen.PrimaryScreen.WorkingArea.Width / 2 Then
            TextLabelLength = Screen.PrimaryScreen.WorkingArea.Width / 2
        End If





    End Sub


    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        With FormSetting
            .FormLocation = Me.Location
            .FormSize = Me.Size
            .Save()
        End With

    End Sub

    Private Sub PicB_MouseEnter(sender As Object, e As EventArgs)
        Select Case sender.name
            Case "ClosePicB"
                sender.image = My.Resources.Resource1.关闭2
                sender.BackColor = Color.FromArgb(251, 73, 45)
            Case "MaxPicB"
                If FormSetting.FormStatus = "Maximum" Then
                    sender.image = My.Resources.Resource1.窗口化2
                Else
                    sender.image = My.Resources.Resource1.最大化2
                End If
            Case "MinPicB"
                sender.image = My.Resources.Resource1.最小化2
            Case "SetPicB"
                sender.image = My.Resources.Resource1.选项2
        End Select
    End Sub

    Private Sub PicB_MouseLeave(sender As Object, e As EventArgs)
        Select Case sender.name
            Case "ClosePicB"
                sender.image = My.Resources.Resource1.关闭1
                sender.backcolor = Color.Transparent
            Case "MaxPicB"
                If FormSetting.FormStatus = "Maximum" Then
                    sender.image = My.Resources.Resource1.窗口化1
                Else
                    sender.image = My.Resources.Resource1.最大化1
                End If
            Case "MinPicB"
                sender.image = My.Resources.Resource1.最小化1
            Case "SetPicB"
                sender.image = My.Resources.Resource1.选项1
        End Select
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Invalidate()
        'Console.WriteLine("OnResize")
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Location = FormSetting.BeforeMax.Location
            Me.Size = FormSetting.BeforeMax.Size
        End If

        With ClosePicB
            .Location = New Point(Me.Width - .Width - .Width, (TitlePanel.Height - .Height) / 2)
        End With

        With MaxPicB
            .Location = New Point(ClosePicB.Left - 2 * .Width, ClosePicB.Top)
        End With

        With MinPicB
            .Left = ClosePicB.Left - 2 * .Width - 2 * .Width * Int(FormResizable)
        End With

        With SetPicB
            .Left = ClosePicB.Left - 2 * .Width - 2 * .Width * (Int(FormShowMinPicB) + Int(FormResizable))
        End With

        If FormSetting IsNot Nothing Then
            If Me.Width < Screen.PrimaryScreen.WorkingArea.Width Or Me.Height < Screen.PrimaryScreen.WorkingArea.Height Then
                MaxPicB.Image = My.Resources.Resource1.最大化1
                FormSetting.FormStatus = "Normal"

            ElseIf Me.Width >= Screen.PrimaryScreen.WorkingArea.Width And Me.Height >= Screen.PrimaryScreen.WorkingArea.Height Then
                MaxPicB.Image = My.Resources.Resource1.窗口化1
                FormSetting.FormStatus = "Maximum"

            End If
        End If


    End Sub



    '---------------绘制边框-------------------------
    'bug分辨率切换
#Region "绘制边框改变大小"
    'Referrene: https://jailbreakvideo.ru/shadow-and-mouse-move-for-borderless-windows-forms-application
    Private Const WM_NCHITTEST As Integer = &H84
    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2
    Private m_aeroEnabled As Boolean
    Private Const CS_DROPSHADOW As Integer = &H20000
    Private Const WM_NCPAINT As Integer = &H85
    Private Const WM_ACTIVATEAPP As Integer = &H1C
    <System.Runtime.InteropServices.DllImport("dwmapi.dll")>
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer

    End Function
    <System.Runtime.InteropServices.DllImport("dwmapi.dll")>
    Public Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer

    End Function
    <System.Runtime.InteropServices.DllImport("dwmapi.dll")>
    Public Shared Function DwmIsCompositionEnabled(ByRef pfEnabled As Integer) As Integer

    End Function
    <System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr

    End Function

    Public Structure MARGINS
        Public leftWidth As Integer
        Public rightWidth As Integer
        Public topHeight As Integer
        Public bottomHeight As Integer
    End Structure

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            m_aeroEnabled = CheckAeroEnabled()
            Dim cp As CreateParams = MyBase.CreateParams
            If Not m_aeroEnabled Then cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Function CheckAeroEnabled() As Boolean
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim enabled As Integer = 0
            DwmIsCompositionEnabled(enabled)
            Return If((enabled = 1), True, False)
        End If

        Return False
    End Function

    Protected Overrides Sub WndProc(ByRef m As Message)
        '绘制边框
        Select Case m.Msg
            Case WM_NCPAINT
                If m_aeroEnabled Then
                    Dim v = 2
                    DwmSetWindowAttribute(Me.Handle, 2, v, 4)
                    Dim margins As MARGINS = New MARGINS() With {
                        .bottomHeight = 1,
                        .leftWidth = 1,
                        .rightWidth = 1,
                        .topHeight = 1
                    }
                    DwmExtendFrameIntoClientArea(Me.Handle, margins)
                End If

            Case Else
        End Select

        '更改大小
        Const WM_NCHITTEST As UInt32 = &H84
        Const WM_MOUSEMOVE As UInt32 = &H200
        Const HTLEFT As UInt32 = 10
        Const HTRIGHT As UInt32 = 11
        Const HTBOTTOMRIGHT As UInt32 = 17
        Const HTBOTTOM As UInt32 = 15
        Const HTBOTTOMLEFT As UInt32 = 16
        Const HTTOP As UInt32 = 12
        Const HTTOPLEFT As UInt32 = 13
        Const HTTOPRIGHT As UInt32 = 14
        Const RESIZE_HANDLE_SIZE As Integer = 10
        Dim handled As Boolean = False

        If m.Msg = WM_NCHITTEST OrElse m.Msg = WM_MOUSEMOVE Then
            Dim formSize As Size = Me.Size
            Dim screenPoint As Point = New Point(m.LParam.ToInt32())
            Dim clientPoint As Point = Me.PointToClient(screenPoint)
            Dim boxes As Dictionary(Of UInt32, Rectangle) = New Dictionary(Of UInt32, Rectangle)() From {
            {HTBOTTOMLEFT, New Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOM, New Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2 * RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOMRIGHT, New Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTRIGHT, New Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2 * RESIZE_HANDLE_SIZE)},
            {HTTOPRIGHT, New Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTTOP, New Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2 * RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTTOPLEFT, New Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTLEFT, New Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2 * RESIZE_HANDLE_SIZE)}
        }

            For Each hitBox As KeyValuePair(Of UInt32, Rectangle) In boxes

                If hitBox.Value.Contains(clientPoint) Then
                    m.Result = CType(hitBox.Key, IntPtr)
                    handled = True
                    Exit For
                End If
            Next
        End If
        '拖动窗口
        'If m.Msg = WM_NCHITTEST AndAlso CInt(m.Result) = HTCLIENT Then m.Result = CType(HTCAPTION, IntPtr)

        If Not handled Then MyBase.WndProc(m)

    End Sub
#End Region
    '---------------绘制边框-------------------------

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TitlePanel = New ChaoControls.Chao_Panel()
        Me.SkinPicB = New System.Windows.Forms.PictureBox()
        Me.MinPicB = New System.Windows.Forms.PictureBox()
        Me.ClosePicB = New System.Windows.Forms.PictureBox()
        Me.MaxPicB = New System.Windows.Forms.PictureBox()
        Me.SetPicB = New System.Windows.Forms.PictureBox()
        Me.FormTextLabel = New System.Windows.Forms.Label()
        Me.FormIconPicB = New System.Windows.Forms.PictureBox()
        Me.TitlePicB = New System.Windows.Forms.PictureBox()
        Me.TitlePanel.SuspendLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClosePicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitlePanel
        '
        Me.TitlePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitlePanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TitlePanel.Controls.Add(Me.SkinPicB)
        Me.TitlePanel.Controls.Add(Me.MinPicB)
        Me.TitlePanel.Controls.Add(Me.ClosePicB)
        Me.TitlePanel.Controls.Add(Me.MaxPicB)
        Me.TitlePanel.Controls.Add(Me.SetPicB)
        Me.TitlePanel.Controls.Add(Me.FormTextLabel)
        Me.TitlePanel.Controls.Add(Me.FormIconPicB)
        Me.TitlePanel.Controls.Add(Me.TitlePicB)
        Me.TitlePanel.Location = New System.Drawing.Point(1, 1)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(1012, 64)
        Me.TitlePanel.TabIndex = 1
        '
        'SkinPicB
        '
        Me.SkinPicB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SkinPicB.BackColor = System.Drawing.Color.Transparent
        Me.SkinPicB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SkinPicB.Image = Global.ChaoForm.My.Resources.Resource1.皮肤
        Me.SkinPicB.Location = New System.Drawing.Point(840, 16)
        Me.SkinPicB.Name = "SkinPicB"
        Me.SkinPicB.Size = New System.Drawing.Size(32, 32)
        Me.SkinPicB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SkinPicB.TabIndex = 6
        Me.SkinPicB.TabStop = False
        Me.SkinPicB.Visible = False
        '
        'MinPicB
        '
        Me.MinPicB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinPicB.BackColor = System.Drawing.Color.Transparent
        Me.MinPicB.Image = Global.ChaoForm.My.Resources.Resource1.最小化1
        Me.MinPicB.Location = New System.Drawing.Point(908, 19)
        Me.MinPicB.Name = "MinPicB"
        Me.MinPicB.Size = New System.Drawing.Size(24, 24)
        Me.MinPicB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MinPicB.TabIndex = 2
        Me.MinPicB.TabStop = False
        '
        'ClosePicB
        '
        Me.ClosePicB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClosePicB.BackColor = System.Drawing.Color.Transparent
        Me.ClosePicB.Image = Global.ChaoForm.My.Resources.Resource1.关闭1
        Me.ClosePicB.Location = New System.Drawing.Point(968, 19)
        Me.ClosePicB.Name = "ClosePicB"
        Me.ClosePicB.Size = New System.Drawing.Size(24, 24)
        Me.ClosePicB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ClosePicB.TabIndex = 0
        Me.ClosePicB.TabStop = False
        '
        'MaxPicB
        '
        Me.MaxPicB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaxPicB.BackColor = System.Drawing.Color.Transparent
        Me.MaxPicB.Image = Global.ChaoForm.My.Resources.Resource1.最大化1
        Me.MaxPicB.Location = New System.Drawing.Point(938, 19)
        Me.MaxPicB.Name = "MaxPicB"
        Me.MaxPicB.Size = New System.Drawing.Size(24, 24)
        Me.MaxPicB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MaxPicB.TabIndex = 1
        Me.MaxPicB.TabStop = False
        '
        'SetPicB
        '
        Me.SetPicB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SetPicB.BackColor = System.Drawing.Color.Transparent
        Me.SetPicB.Image = Global.ChaoForm.My.Resources.Resource1.选项1
        Me.SetPicB.Location = New System.Drawing.Point(878, 19)
        Me.SetPicB.Name = "SetPicB"
        Me.SetPicB.Size = New System.Drawing.Size(24, 24)
        Me.SetPicB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SetPicB.TabIndex = 5
        Me.SetPicB.TabStop = False
        Me.SetPicB.Visible = False
        '
        'FormTextLabel
        '
        Me.FormTextLabel.AutoSize = True
        Me.FormTextLabel.BackColor = System.Drawing.Color.Transparent
        Me.FormTextLabel.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormTextLabel.ForeColor = System.Drawing.Color.White
        Me.FormTextLabel.Location = New System.Drawing.Point(46, 16)
        Me.FormTextLabel.Name = "FormTextLabel"
        Me.FormTextLabel.Size = New System.Drawing.Size(203, 27)
        Me.FormTextLabel.TabIndex = 4
        Me.FormTextLabel.Text = "Chao_AdvanceForm"
        '
        'FormIconPicB
        '
        Me.FormIconPicB.BackColor = System.Drawing.Color.Transparent
        Me.FormIconPicB.Location = New System.Drawing.Point(8, 16)
        Me.FormIconPicB.Name = "FormIconPicB"
        Me.FormIconPicB.Size = New System.Drawing.Size(32, 32)
        Me.FormIconPicB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FormIconPicB.TabIndex = 3
        Me.FormIconPicB.TabStop = False
        '
        'TitlePicB
        '
        Me.TitlePicB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitlePicB.BackColor = System.Drawing.Color.Transparent
        Me.TitlePicB.Location = New System.Drawing.Point(46, 9)
        Me.TitlePicB.Name = "TitlePicB"
        Me.TitlePicB.Size = New System.Drawing.Size(780, 45)
        Me.TitlePicB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.TitlePicB.TabIndex = 6
        Me.TitlePicB.TabStop = False
        '
        'Form
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1014, 465)
        Me.Controls.Add(Me.TitlePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form"
        Me.Text = "Chao_Form"
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.SkinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClosePicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormIconPicB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlePicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClosePicB As PictureBox
    Friend WithEvents MinPicB As PictureBox
    Friend WithEvents MaxPicB As PictureBox
    Public WithEvents FormIconPicB As PictureBox
    Public WithEvents FormTextLabel As Label
    Public WithEvents SetPicB As PictureBox
    Public WithEvents TitlePicB As PictureBox
    Public WithEvents TitlePanel As ChaoControls.Chao_Panel
    Public WithEvents SkinPicB As PictureBox
End Class


NotInheritable Class FormSettings
    Inherits ApplicationSettingsBase

    '为了使客户端代码能够区分同一应用程序设置类的多个实例之间的歧义
    Sub New(Optional ByVal _SettingsKey As String = "")
        Me.SettingsKey = _SettingsKey
    End Sub


    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    <UserScopedSettingAttribute(), DefaultSettingValueAttribute("Dark")>
    Public Property SkinStyle() As String
        Get
            Return CType(Me("SkinStyle"), String)
        End Get
        Set(ByVal value As String)
            Me("SkinStyle") = value
        End Set
    End Property


    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    <UserScopedSettingAttribute(), DefaultSettingValueAttribute("Normal")>
    Public Property FormStatus() As String
        Get
            Return CType(Me("FormStatus"), String)
        End Get
        Set(ByVal value As String)
            Me("FormStatus") = value
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    <UserScopedSettingAttribute(), DefaultSettingValueAttribute("0,0,500,500")>
    Public Property BeforeMax() As Rectangle
        Get
            Return CType(Me("BeforeMax"), Rectangle)
        End Get
        Set(ByVal value As Rectangle)
            Me("BeforeMax") = value
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    <UserScopedSettingAttribute(), DefaultSettingValueAttribute("0,0")>
    Public Property FormLocation() As Point
        Get
            Return CType(Me("FormLocation"), Point)
        End Get
        Set(ByVal value As Point)
            Me("FormLocation") = value
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    <UserScopedSettingAttribute(), DefaultSettingValueAttribute("500, 500")>
    Public Property FormSize() As Size
        Get
            Return CType(Me("FormSize"), Size)
        End Get
        Set(ByVal value As Size)
            Me("FormSize") = value
        End Set
    End Property
End Class
