Imports System.ComponentModel
Imports System.Reflection
Public Class Form
    Private Draggable As Boolean = False
    Private MousePositionLength As Point



    Private myFormShowSetupPicB As Boolean = False
    Private myFormShowMinPicB As Boolean = True
    Private myFormResizable As Boolean = True
    Private myFormShowSkinPicB As Boolean = False


    Public Event FormMaximumEvent As EventHandler
    Public Event FormNormalEvent As EventHandler


    <Browsable(True)>
    Public Property FormShowSkinPicB As Boolean

        Get
            Return myFormShowSkinPicB
        End Get
        Set(value As Boolean)
            myFormShowSkinPicB = value
            SkinPicB.Visible = FormShowSkinPicB
        End Set

    End Property


    <Browsable(True)>
    Public Property FormShowMinPicB As Boolean

        Get
            Return myFormShowMinPicB
        End Get
        Set(value As Boolean)
            myFormShowMinPicB = value
        End Set

    End Property

    <Browsable(True)>
    Public Property FormResizable As Boolean

        Get
            Return myFormResizable
        End Get
        Set(value As Boolean)
            myFormResizable = value
        End Set

    End Property

    <Browsable(True)>
    Public Property FormShowSetupPicB As Boolean

        Get
            Return myFormShowSetupPicB
        End Get
        Set(value As Boolean)
            myFormShowSetupPicB = value
            SetPicB.Visible = value

            With SkinPicB
                .Top = (TitlePanel.Height - .Height) / 2
                .Left = ClosePicB.Left - .Width - 2 * ClosePicB.Width * (Int(FormShowMinPicB) + Int(FormResizable) + Int(value) + 0.5)

            End With
        End Set

    End Property





    Private Sub MaxForm()
        FormSetting.BeforeMax = New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
        Me.Top = 0
        Me.Left = 0
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width

        MaxPicB.Image = My.Resources.Resource1.窗口化1
        FormSetting.FormStatus = "Maximum"
        Me.OnResizeEnd(EventArgs.Empty)
    End Sub

    Private Sub NormalForm()
        Me.Location = FormSetting.BeforeMax.Location
        Me.Size = FormSetting.BeforeMax.Size
        MaxPicB.Image = My.Resources.Resource1.最大化1
        FormSetting.FormStatus = "Normal"

        Me.OnResizeEnd(EventArgs.Empty)
    End Sub

    Public Sub NormalFormEnd()

    End Sub


    Private Sub ClosePicB_Click(sender As Object, e As EventArgs) Handles ClosePicB.Click
        Me.Close()
    End Sub

    Private Sub MinPicB_Click(sender As Object, e As EventArgs) Handles MinPicB.Click
        FormSetting.BeforeMax = New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MaxPicB_Click(sender As Object, e As EventArgs) Handles MaxPicB.Click
        If Me.Width = Screen.PrimaryScreen.WorkingArea.Width And Me.Height = Screen.PrimaryScreen.WorkingArea.Height Then
            NormalForm()
        Else
            MaxForm()
        End If
        Me.OnResize(EventArgs.Empty)
    End Sub


    Private Sub Chao_TitlePanel1_MouseMove(sender As Object, e As MouseEventArgs) Handles TitlePanel.MouseMove, FormIconPicB.MouseMove, FormTextLabel.MouseMove, TitlePicB.MouseMove
        If Draggable Then
            If Me.Left = 0 And Me.Top = 0 And
                    Me.Width = Screen.PrimaryScreen.WorkingArea.Width And
                Me.Height = Screen.PrimaryScreen.WorkingArea.Height Then

                MousePositionLength.X = FormSetting.BeforeMax.Width / 2
                MousePositionLength.Y = 0
                Me.Size = FormSetting.BeforeMax.Size

                MaxPicB.Image = My.Resources.Resource1.最大化1

            Else
                Me.Left = MousePosition.X - MousePositionLength.X
                Me.Top = MousePosition.Y - MousePositionLength.Y
            End If

        End If
    End Sub

    Private Sub Chao_TitlePanel1_MouseUp(sender As Object, e As MouseEventArgs) Handles TitlePanel.MouseUp, FormIconPicB.MouseUp, FormTextLabel.MouseUp, TitlePicB.MouseUp
        Draggable = False
        If Me.Top < 0 Then Me.Top = 0
    End Sub

    Private Sub Chao_TitlePanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles TitlePanel.MouseDown, FormIconPicB.MouseDown, FormTextLabel.MouseDown, TitlePicB.MouseDown
        Draggable = True
        MousePositionLength.X = MousePosition.X - Me.Left
        MousePositionLength.Y = MousePosition.Y - Me.Top
    End Sub


    Private Sub OptimizedPanel1_DoubleClick(sender As Object, e As EventArgs) Handles TitlePanel.DoubleClick, FormIconPicB.DoubleClick, FormTextLabel.DoubleClick, TitlePicB.DoubleClick
        'If Me.Left = 0 And Me.Top = 0 And
        '    Me.Height = Screen.PrimaryScreen.WorkingArea.Height And
        '    Me.Width = Screen.PrimaryScreen.WorkingArea.Width Then
        '    NormalForm()
        'Else
        '    MaxForm()
        'End If
        MaxPicB_Click(sender, e)
        'Me.OnResize(EventArgs.Empty)
    End Sub

    Private Sub Chao_AdvanceForm_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        FormTextLabel.Text = Me.Text
    End Sub


    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        TitlePanel.Width = Me.Width - 2
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitlePanel.Width = Me.Width - 2
    End Sub

    Private Sub TitlePanel_Paint(sender As Object, e As PaintEventArgs) Handles TitlePanel.Paint

    End Sub

    Private Sub TitlePanel_Resize(sender As Object, e As EventArgs) Handles TitlePanel.Resize
        With ClosePicB
            .Location = New Point(Me.Width - .Width - .Width, (TitlePanel.Height - .Height) / 2)
        End With

        With MaxPicB
            .Location = New Point(ClosePicB.Left - 2 * .Width, ClosePicB.Top)
        End With

        With MinPicB
            .Top = ClosePicB.Top
            .Left = ClosePicB.Left - 2 * .Width - 2 * .Width * Int(FormResizable)
        End With

        If SetPicB.Visible Then
            With SetPicB
                .Top = ClosePicB.Top
                .Left = ClosePicB.Left - 2 * .Width - 2 * .Width * (Int(FormShowMinPicB) + Int(FormResizable))
            End With
        End If
    End Sub

    Private Sub FormTextLabel_Click(sender As Object, e As EventArgs) Handles FormTextLabel.Click


    End Sub

    Private Sub SkinPicB_Click(sender As Object, e As EventArgs) Handles SkinPicB.Click
        'If FormSetting.SkinStyle = "White" Then
        '    FormSetting.SkinStyle = "Black"
        'ElseIf FormSetting.SkinStyle = "Black" Then
        '    FormSetting.SkinStyle = "Blue"
        'ElseIf FormSetting.SkinStyle = "Blue" Then
        '    FormSetting.SkinStyle = "White"
        'End If
        'FormSetting.Save()
        'SetSkin()
    End Sub

    Private Sub SkinPicB_MouseEnter(sender As Object, e As EventArgs) Handles SkinPicB.MouseEnter
        SkinPicB.Image = My.Resources.Resource1.皮肤2
    End Sub

    Private Sub SkinPicB_MouseLeave(sender As Object, e As EventArgs) Handles SkinPicB.MouseLeave
        SkinPicB.Image = My.Resources.Resource1.皮肤
    End Sub

    Private Sub Form_FormMaximumEvent(sender As Object, e As EventArgs) Handles Me.FormMaximumEvent
        Console.WriteLine("Max")
    End Sub

    Private Sub Form_FormNormalEvent(sender As Object, e As EventArgs) Handles Me.FormNormalEvent
        Console.WriteLine("Normal")
    End Sub
End Class


