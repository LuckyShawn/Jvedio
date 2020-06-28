Imports System.ComponentModel
<DefaultEvent("TextChanged")>
Public Class Chao_TextBox
    Private myTextBackColor As Color = Color.FromArgb(236, 236, 236)
    Private myTextForeColor As Color = Color.FromArgb(29, 29, 29)
    Private myTextFont As Font = New Font("微软雅黑", 12)
    Private myTextAlign As HorizontalAlignment = HorizontalAlignment.Left
    Private myText As String = ""
    Private myBorderColor As Color = Color.FromArgb(110, 20, 239)
    Private myLineColor As Color = Color.FromArgb(98, 0, 238)
    Private myHint As String = "Hint"
    Public Shadows Event TextChanged As PropertyChangedEventHandler
    Public Shadows Event KeyDown As KeyEventHandler


#Region "不可见属性"
    <Browsable(False)>
    Public Overloads Property BackColor As Color
    <Browsable(False)>
    Public Overloads Property Font As Font
    '<Browsable(False)>
    'Public Overrides Property Text As String
    <Browsable(False)>
    Public Overrides Property ForeColor As Color
    <Browsable(False)>
    Public Overloads Property RightToLeft As Boolean
    <Browsable(False)>
    Public Overloads Property Padding As Padding
    <Browsable(False)>
    Public Overloads Property AccessibleDescription As String
    <Browsable(False)>
    Public Overloads Property AccessibleRole As String
    <Browsable(False)>
    Public Overloads Property AccessibleName As String
    <Browsable(False)>
    Public Overloads Property ImeMode As ImeMode
    <Browsable(False)>
    Public Overrides Property ContextMenuStrip As ContextMenuStrip
    <Browsable(False)>
    Public Overrides Property Dock As DockStyle
    <Browsable(False)>
    Public Overrides Property MinimumSize As Size
    <Browsable(False)>
    Public Overrides Property MaximumSize As Size
    <Browsable(False)>
    Public Overrides Property BackgroundImage As Image
    <Browsable(False)>
    Public Overrides Property BackgroundImageLayout As ImageLayout
    <Browsable(False)>
    Public Overrides Property AutoSize As Boolean
    <Browsable(False)>
    Public Overrides Property AutoScroll As Boolean
    <Browsable(False)>
    Public Overloads Property AutoScrollMargin As Size
    <Browsable(False)>
    Public Overloads Property AutoScrollMinSize As Size
    <Browsable(False)>
    Public Overloads Property AutoSizeMode As AutoSizeMode
    <Browsable(False)>
    Public Overloads Property BorderStyle As BorderStyle
    <Browsable(False)>
    Public Overloads Property Margin As Padding
    '----------------设置属性不可见-----------------
#End Region

#Region "可见属性"


    <Description("对齐方式"), Category("Appearance"), Browsable(True)>
    Public Property TextAlign As HorizontalAlignment
        Get
            Return myTextAlign
        End Get
        Set(value As HorizontalAlignment)
            myTextAlign = value
            SystemTextBox.TextAlign = value
        End Set
    End Property

    <Description("背景颜色"), Category("Appearance"), Browsable(True)>
    Public Property Hint As String
        Get
            Return myHint
        End Get
        Set(value As String)
            If value = "" Then
                value = "Hint"
            End If
            myHint = value
            SystemTextBox.Text = value
            'Invalidate()
        End Set

    End Property


    <Description("背景颜色"), Category("Appearance"), Browsable(True)>
    Public Property TextBackColor As Color
        Get
            Return myTextBackColor
        End Get
        Set(value As Color)
            If value = Color.Transparent Then
                value = Color.FromName("Control")
            End If
            myTextBackColor = value
            SystemTextBox.BackColor = value
            Invalidate()
        End Set

    End Property

    <Description("文本字体"), Category("Appearance"), Browsable(True)>
    Public Property TextFont As Font
        Get
            Return myTextFont
        End Get
        Set(value As Font)
            myTextFont = value
            SystemTextBox.Font = value
            Me.Height = SystemTextBox.Height + 12 * 2
            Invalidate()
        End Set

    End Property


    <Description("提示"), Category("Appearance"), Browsable(True)>
    Public Property LineColor As Color
        Get
            Return myLineColor
        End Get
        Set(value As Color)
            myLineColor = value
            Invalidate()
        End Set

    End Property

    <Description("文本"), Category("Appearance"), Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overrides Property Text As String
        Get
            Return myText
        End Get
        Set(value As String)
            myText = value
            SystemTextBox.Text = value
            RaiseEvent TextChanged(Me, New PropertyChangedEventArgs("TextChanged"))
            Invalidate()
        End Set

    End Property

    <Description("边框颜色"), Category("Appearance"), Browsable(True)>
    Public Property BorderColor As Color
        Get
            Return myBorderColor
        End Get
        Set(value As Color)
            myBorderColor = value
            Invalidate()
        End Set

    End Property

    <Description("字体颜色"), Category("Appearance"), Browsable(True)>
    Public Property TextForeColor As Color
        Get
            Return myTextForeColor
        End Get
        Set(value As Color)
            myTextForeColor = value
            SystemTextBox.ForeColor = value
            Invalidate()
        End Set

    End Property



#End Region




    Private Sub SystemTextBox_MouseLeave(sender As Object, e As EventArgs) Handles SystemTextBox.MouseLeave
        IsMouseEnter = False
        Invalidate()
    End Sub

    Private Sub SystemTextBox_MouseEnter(sender As Object, e As EventArgs) Handles SystemTextBox.MouseEnter
        IsMouseEnter = True
        Invalidate()
    End Sub


    Private Sub SystemTextBox_LostFocus(sender As Object, e As EventArgs) Handles SystemTextBox.LostFocus
        IsFocus = False
        FocusTimer.Enabled = True
        If SystemTextBox.Text = "" Then
            SystemTextBox.Text = Hint
        End If
    End Sub

    Private Sub Chao_TextBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SystemTextBox_GotFocus(sender As Object, e As EventArgs) Handles SystemTextBox.GotFocus
        If SystemTextBox.Text = Hint Then
            SystemTextBox.Text = ""
        End If
        IsFocus = True
        FocusTimer.Enabled = True
    End Sub

    Private Sub SystemTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SystemTextBox.KeyDown
        RaiseEvent KeyDown(sender, e)
    End Sub

    Private Sub SystemTextBox_TextChanged(sender As Object, e As EventArgs) Handles SystemTextBox.TextChanged
        Me.Text = SystemTextBox.Text
    End Sub
End Class


