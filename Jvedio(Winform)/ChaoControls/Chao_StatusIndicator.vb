Imports System.ComponentModel
Public Class Chao_StatusIndicator

    Private myStatus As String = "Success"  '"Failed", "Running", "Success", "StandBy"
    Private myFailedColor As Color = Color.Red
    Private myRunningColor As Color = Color.Gray
    Private myStandByColor As Color = Color.Blue
    Private mySuccessColor As Color = Color.Green
    Private myRunningSpeed As Integer = 15
#Region "不可见属性"
    <Browsable(False)>
    Public Overloads Property Font As Font
    <Browsable(False)>
    Public Overrides Property Text As String
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

    <Description("成功颜色"), Category("Appearance"), Browsable(True)>
    Public Property RunningSpeed As Integer
        Get
            Return myRunningSpeed
        End Get
        Set(value As Integer)
            If value <= 0 Or value >= 50 Then
                value = 15
            End If
            myRunningSpeed = value
            Invalidate()
        End Set

    End Property

    <Description("成功颜色"), Category("Appearance"), Browsable(True)>
    Public Property SuccessColor As Color
        Get
            Return mySuccessColor
        End Get
        Set(value As Color)
            mySuccessColor = value
            Invalidate()
        End Set

    End Property

    <Description("待机颜色"), Category("Appearance"), Browsable(True)>
    Public Property StandByColor As Color
        Get
            Return myStandByColor
        End Get
        Set(value As Color)
            myStandByColor = value
            Invalidate()
        End Set

    End Property

    <Description("运行颜色"), Category("Appearance"), Browsable(True)>
    Public Property RunningColor As Color
        Get
            Return myRunningColor
        End Get
        Set(value As Color)
            myRunningColor = value
            Invalidate()
        End Set

    End Property

    <Description("失败颜色"), Category("Appearance"), Browsable(True)>
    Public Property FailedColor As Color
        Get
            Return myFailedColor
        End Get
        Set(value As Color)
            myFailedColor = value
            Invalidate()
        End Set

    End Property

    <Description("状态"), Category("Appearance"), Browsable(True), TypeConverter(GetType(StatusIndicatorStringConverter))> '继承自StringConverter
    Public Property Status As String
        Get
            Return myStatus
        End Get
        Set(value As String)
            myStatus = value
            If value = "Running" Then
                RunningTimer.Enabled = True
            Else
                RunningTimer.Enabled = False
                Invalidate()
            End If

        End Set

    End Property

#End Region


    Private Sub Chao_StatusIndicator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


Public Class StatusIndicatorStringConverter
    Inherits StringConverter
    Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As StandardValuesCollection
        Return New StandardValuesCollection(New String() {"Failed", "Running", "Success", "StandBy"})
    End Function
    Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
        Return True ' 不能输入下拉属性以外的值
    End Function

End Class
