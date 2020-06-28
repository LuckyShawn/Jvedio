Imports System.ComponentModel
Public Class Chao_ProgressIndicators

    Private myBarBackColor As Color = Color.FromArgb(198, 174, 231)
    Private myBarFilledColor As Color = Color.FromArgb(98, 0, 238)
    Private myProgressType As String = "Linear" '"Linear ", "Circular"


#Region "不可见属性"
    '<Browsable(False)>
    'Public Overloads Property BackColor As Color
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

    <Description("类型"), Category("Appearance"), Browsable(True), TypeConverter(GetType(ProgressIndicatorsStringConverter))>
    Public Property ProgressType As String
        Get
            Return myProgressType
        End Get
        Set(value As String)
            myProgressType = value
            Invalidate()
        End Set

    End Property


    <Description("填充颜色"), Category("Appearance"), Browsable(True)>
    Public Property BarFilledColor As Color
        Get
            Return myBarFilledColor
        End Get
        Set(value As Color)
            myBarFilledColor = value
            Invalidate()
        End Set

    End Property


    <Description("为填充颜色"), Category("Appearance"), Browsable(True)>
    Public Property BarBackColor As Color
        Get
            Return myBarBackColor
        End Get
        Set(value As Color)
            myBarBackColor = value
            Invalidate()
        End Set

    End Property


#End Region

    Private Sub Chao_ProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class ProgressIndicatorsStringConverter
    Inherits StringConverter
    Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As StandardValuesCollection
        Return New StandardValuesCollection(New String() {"Linear ", "Circular"})
    End Function
    Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
        Return True ' 不能输入下拉属性以外的值
    End Function

End Class
