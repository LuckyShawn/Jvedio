Imports System.ComponentModel
<DefaultEvent("ValueChanged")>
Public Class Chao_Sliders

    Private mySlideBackColor As Color = Color.FromArgb(198, 174, 231)
    Private mySlideFilledColor As Color = Color.FromArgb(98, 0, 238)
    Private myButtonColor As Color = Color.FromArgb(98, 0, 238)
    Private myEnableMoveTimer As Boolean = True

    Private myValue As Single = 50
    Private myMaximum As Single = 100
    Private myMinimum As Single = 0

    Public Event ValueChanged As PropertyChangedEventHandler


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

    <Description("是否显示滑动动画"), Category("Data"), Browsable(True)>
    Public Property EnableMoveTimer As Boolean
        Get
            Return myEnableMoveTimer
        End Get
        Set(value As Boolean)
            myEnableMoveTimer = value
        End Set

    End Property


    <Description("最小值"), Category("Data"), Browsable(True)>
    Public Property Minimum As Single
        Get
            Return myMinimum
        End Get
        Set(value As Single)
            If value >= Maximum Then
                myMinimum = Maximum - 10
            Else
                myMinimum = value
            End If
            If Me.Value < Minimum Then
                Me.Value = Minimum
            End If
            Invalidate()
        End Set

    End Property

    <Description("最大值"), Category("Data"), Browsable(True)>
    Public Property Maximum As Single
        Get
            Return myMaximum
        End Get
        Set(value As Single)
            If value <= Minimum Then
                myMaximum = Minimum + 10
            Else
                myMaximum = value
            End If
            If Me.Value > Maximum Then
                Me.Value = Maximum
            End If
            Invalidate()
        End Set

    End Property



    <Description("值"), Category("Data"), Browsable(True)>
    Public Property Value As Single
        Get
            Return myValue
        End Get
        Set(value As Single)
            If value <= Minimum Then
                value = Minimum
            ElseIf value >= Maximum Then
                value = Maximum
            End If
            myValue = value
            DrawValue = value
            RaiseEvent ValueChanged(Me, New PropertyChangedEventArgs("ValueChanged"))
            Invalidate()
        End Set

    End Property


    <Description("填充"), Category("Appearance"), Browsable(True)>
    Public Property ButtonColor As Color
        Get
            Return myButtonColor
        End Get
        Set(value As Color)
            myButtonColor = value
            Invalidate()
        End Set

    End Property

    <Description("填充颜色"), Category("Appearance"), Browsable(True)>
    Public Property SlideFilledColor As Color
        Get
            Return mySlideFilledColor
        End Get
        Set(value As Color)
            mySlideFilledColor = value
            Invalidate()
        End Set

    End Property


    <Description("为填充颜色"), Category("Appearance"), Browsable(True)>
    Public Property SlideBackColor As Color
        Get
            Return mySlideBackColor
        End Get
        Set(value As Color)
            mySlideBackColor = value
            Invalidate()
        End Set

    End Property


#End Region

    Private Sub Chao_Sliders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Chao_Sliders_ValueChanged(sender As Object, e As PropertyChangedEventArgs) Handles Me.ValueChanged
        Debug.Print(Value)
    End Sub
End Class
