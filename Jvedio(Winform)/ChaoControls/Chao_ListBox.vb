Imports System.ComponentModel
Imports System.Collections.ObjectModel

Public Class Chao_ListBox
    Private myListBoxBackColor As Color = Color.White
    Private myListBoxFont As Font = New Font("微软雅黑", 12)
    Private myTextColor As Color = Color.Black
    Private myListBoxItems As String()
    Private myBorderColor As Color = Color.Gray
    Private myBorderWidth As Single = 1

    Private mySelectedColor As Color = Color.FromArgb(225, 225, 225)
    Private myItemHeight As Single = 40

    Public Event ListBoxItemsChanged As PropertyChangedEventHandler


    Private myItems As List(Of String)



#Region "不可见属性"
    <Browsable(False)>
    Public Overloads Property BackColor As Color
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




    Public Property Items As List(Of String)
        Get
            Return myItems
        End Get
        Set(value As List(Of String))
            myItems = value
            RaiseEvent ListBoxItemsChanged(Me, New PropertyChangedEventArgs("Item"))
        End Set
    End Property

    '<Description("集合"), Category("Data"), Browsable(True)>
    'Public Property Items As String()
    '    Get
    '        Return myItems
    '    End Get
    '    Set(value As String())
    '        myItems = value
    '        RaiseEvent ListBoxItemsChanged(Me, New PropertyChangedEventArgs("Item"))
    '    End Set
    'End Property



    <Description("边框宽度"), Category("Appearance"), Browsable(True)>
    Public Property BorderWidth As Single
        Get
            Return myBorderWidth
        End Get
        Set(value As Single)
            myBorderWidth = value
            Invalidate()
        End Set

    End Property

    <Description("每一项高度"), Category("Appearance"), Browsable(True)>
    Public Property ItemHeight As Single
        Get
            Return myItemHeight
        End Get
        Set(value As Single)
            myItemHeight = value
            Invalidate()
        End Set

    End Property

    <Description("选中后颜色"), Category("Data"), Browsable(True)>
    Public Property SelectedColor As Color
        Get
            Return mySelectedColor
        End Get
        Set(value As Color)
            mySelectedColor = value
            Invalidate()
        End Set

    End Property




    <Description("背景颜色"), Category("Appearance"), Browsable(True)>
    Public Property ListBoxBackColor As Color
        Get
            Return myListBoxBackColor
        End Get
        Set(value As Color)
            myListBoxBackColor = value
            Invalidate()
        End Set

    End Property

    <Description("文本"), Category("Appearance"), Browsable(True)>
    Public Property ListBoxFont As Font
        Get
            Return myListBoxFont
        End Get
        Set(value As Font)
            myListBoxFont = value
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
    Public Property TextColor As Color
        Get
            Return myTextColor
        End Get
        Set(value As Color)
            myTextColor = value
            Invalidate()
        End Set

    End Property


#End Region

    Private Sub Chao_ListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Chao_ListBox_ListBoxItemsChanged(sender As Object, e As PropertyChangedEventArgs) Handles Me.ListBoxItemsChanged
        IniTial()
    End Sub
End Class


Public Class StringArrayDescriptionProvider
    Inherits TypeDescriptionProvider

    Private Shared _baseProvider As TypeDescriptionProvider

    Sub New()
        _baseProvider = TypeDescriptor.GetProvider(GetType(String()))
    End Sub

    Public Overrides Function CreateInstance(ByVal provider As IServiceProvider, ByVal objectType As Type, ByVal argTypes As Type(), ByVal args As Object()) As Object
        Return Array.CreateInstance(GetType(String), 0)
    End Function

    Public Overrides Function GetCache(ByVal instance As Object) As IDictionary
        Return _baseProvider.GetCache(instance)
    End Function

    Public Overrides Function GetExtendedTypeDescriptor(ByVal instance As Object) As ICustomTypeDescriptor
        Return _baseProvider.GetExtendedTypeDescriptor(instance)
    End Function

    Public Overrides Function GetFullComponentName(ByVal component As Object) As String
        Return _baseProvider.GetFullComponentName(component)
    End Function

    Public Overrides Function GetReflectionType(ByVal objectType As Type, ByVal instance As Object) As Type
        Return _baseProvider.GetReflectionType(objectType, instance)
    End Function

    'Public Overrides Function GetRuntimeType(ByVal reflectionType As Type) As Type
    '    Return _baseProvider.GetRuntimeType(reflectionType)
    'End Function

    Public Overrides Function GetTypeDescriptor(ByVal objectType As Type, ByVal instance As Object) As ICustomTypeDescriptor
        Return _baseProvider.GetTypeDescriptor(objectType, instance)
    End Function

    'Public Overrides Function IsSupportedType(ByVal type As Type) As Boolean
    '    Return _baseProvider.IsSupportedType(type)
    'End Function
End Class






