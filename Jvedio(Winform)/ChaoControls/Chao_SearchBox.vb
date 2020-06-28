Imports System.Drawing.Drawing2D
Imports System.ComponentModel
<DefaultEvent("KeyDown")>
Public Class Chao_SearchBox
    Private mySearchBoxMouseMoveColor As Color = Color.White
    Private mySearchBoxColor As Color = Color.Black
    Private mySearchTextForeColor As Color = Color.White
    Private mySearchIconColor As Color = Color.Gray
    Private myHintColor As Color = Color.Gray
    Private myText As String '搜索文本
    Private myHint As String = "Search"
    Public Shadows Event TextChanged As PropertyChangedEventHandler
    Public Event HintChanged As PropertyChangedEventHandler '提示文本更改后更新
    Public Shadows Event KeyDown As KeyEventHandler


#Region "不可见属性"
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
    Public Overloads Property Font As Font
    <Browsable(False)>
    Public Overrides Property ForeColor As Color
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
    '----------------设置属性不可见-----------------
#End Region


#Region "可见属性"

    <Description("搜索框颜色"), Category("Appearance"), Browsable(True)>
    Public Property SearchBoxMouseMoveColor() As Color
        Get
            Return mySearchBoxMouseMoveColor
        End Get
        Set(ByVal value As Color)
            mySearchBoxMouseMoveColor = value
            Invalidate() '告诉窗口重绘
        End Set
    End Property


    <Description("搜索框颜色"), Category("Appearance"), Browsable(True)>
    Public Property SearchBoxColor() As Color
        Get
            Return mySearchBoxColor
        End Get
        Set(ByVal value As Color)
            mySearchBoxColor = value
            TextBox1.BackColor = value
            'TextBox1.BackColor = Color.Red
            Invalidate() '告诉窗口重绘
        End Set
    End Property

    <Description("搜索图标颜色"), Category("Appearance"), Browsable(True)>
    Public Property SearchIconColor() As Color
        Get
            Return mySearchIconColor
        End Get
        Set(ByVal value As Color)
            mySearchIconColor = value
            Invalidate() '告诉窗口重绘
        End Set
    End Property

    <Description("搜索字体的颜色"), Category("Appearance"), Browsable(True)>
    Public Property SearchTextForeColor() As Color
        Get
            Return mySearchTextForeColor
        End Get
        Set(ByVal value As Color)
            mySearchTextForeColor = value
            Invalidate() '告诉窗口重绘
        End Set
    End Property

    <Description("提示文字颜色"), Category("Appearance"), Browsable(True)>
    Public Property HintColor() As Color
        Get
            Return myHintColor
        End Get
        Set(ByVal value As Color)
            myHintColor = value
            Invalidate() '告诉窗口重绘
        End Set
    End Property

    <Description("搜索文本"), Category("Data"), Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overrides Property Text() As String
        Get
            Return myText
        End Get
        Set(ByVal value As String)

            myText = value
            TextBox1.Text = value
            RaiseEvent TextChanged(Me, New PropertyChangedEventArgs("Text"))
            Invalidate()
        End Set
    End Property


    <Description("提示文本"), Category("Data"), Browsable(True)>
    Public Property Hint() As String
        Get
            Return myHint
        End Get
        Set(ByVal value As String)
            myHint = value
            Invalidate()
        End Set
    End Property

#End Region




    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.Text = TextBox1.Text
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = Hint Or TextBox1.Text = "Chao_SearchBox1" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = SearchTextForeColor
        End If
    End Sub


    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If sender.text = "" Then
            sender.text = Hint
            TextBox1.ForeColor = HintColor
        End If
    End Sub


    Private Sub Chao_SearchBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        RaiseEvent KeyDown(sender, e)
    End Sub

    Private Sub TextBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseMove
        SearchBoxMouseEnter = True
        Invalidate()
    End Sub

    Private Sub Chao_SearchBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
