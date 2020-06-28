Imports System.ComponentModel
<DefaultEvent("CheckedChanged")>
Public Class Chao_Switch
    Private myCheckBackColor As Color = DefaultBackColor
    Private myCheckedInColor As Color = Color.FromArgb(76, 217, 100)
    Private myCheckedOffColor As Color = Color.Gray
    Private mySmallButtonColor As Color = Color.White
    Private CheckedValue As Boolean = True
    Private myCheckSpeed As Single = 6.0F

    Public Event CheckedChanged As PropertyChangedEventHandler

#Region "不可见属性"
    <Browsable(False)>
    Public Overloads Property BackColor As Color
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


    <Description("背景颜色"), Category("Appearance"), Browsable(True)>
    Public Property CheckBackColor() As Color
        Get
            Return myCheckBackColor
        End Get
        Set(ByVal value As Color)
            myCheckBackColor = value
            Invalidate()
        End Set
    End Property


    <Description("切换速度"), Category("Data"), Browsable(True)>
    Public Property CheckSpeed() As Single
        Get
            Return myCheckSpeed
        End Get
        Set(ByVal value As Single)
            '顺序不能错
            If value > 20 Then
                value = 20
            ElseIf value < 1 Then
                value = 1
            End If
            myCheckSpeed = value
            Invalidate()
        End Set
    End Property

    <Description("是否选中"), Category("Data"), Browsable(True)>
    Public Property Checked() As Boolean
        Get
            Return CheckedValue
        End Get
        Set(ByVal value As Boolean)
            '顺序不能错
            CheckedValue = value
            Invalidate()
            RaiseEvent CheckedChanged(Me, New PropertyChangedEventArgs("Checked"))
        End Set
    End Property

    <Description("选中后颜色"), Category("Appearance"), Browsable(True)>
    Public Property CheckedInColor() As Color
        Get
            Return myCheckedInColor
        End Get
        Set(ByVal value As Color)
            myCheckedInColor = value
            Invalidate()
        End Set
    End Property

    <Description("未选中颜色"), Category("Appearance"), Browsable(True)>
    Public Property CheckedOffColor() As Color
        Get
            Return myCheckedOffColor
        End Get
        Set(ByVal value As Color)
            myCheckedOffColor = value
            Invalidate()
        End Set
    End Property


    <Description("圆按钮颜色"), Category("Appearance"), Browsable(True)>
    Public Property SmallButtonColor() As Color
        Get
            Return mySmallButtonColor
        End Get
        Set(ByVal value As Color)
            mySmallButtonColor = value
            Invalidate()
        End Set
    End Property
#End Region

    Private Sub Chao_Switch_CheckedChanged(sender As Object, e As PropertyChangedEventArgs) Handles Me.CheckedChanged
        MouseDownTimer.Enabled = True
    End Sub
End Class
