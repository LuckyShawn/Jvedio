Imports System.Drawing

Public Class Skin
    Private _BC1 As Color
    Private _BC2 As Color
    Private _BC3 As Color
    Private _BC4 As Color
    Private _FC1 As Color
    Private _FC2 As Color
    Private _FC3 As Color
    Private _FC4 As Color

    Property BC1 As Color
        Get
            Return _BC1
        End Get
        Set
            _BC1 = Value
        End Set
    End Property

    Property BC2 As Color
        Get
            Return _BC2
        End Get
        Set
            _BC2 = Value
        End Set
    End Property

    Property BC3 As Color
        Get
            Return _BC3
        End Get
        Set
            _BC3 = Value
        End Set
    End Property

    Property BC4 As Color
        Get
            Return _BC4
        End Get
        Set
            _BC4 = Value
        End Set
    End Property

    Property FC1 As Color
        Get
            Return _FC1
        End Get
        Set
            _FC1 = Value
        End Set
    End Property

    Property FC2 As Color
        Get
            Return _FC2
        End Get
        Set
            _FC2 = Value
        End Set
    End Property

    Property FC3 As Color
        Get
            Return _FC3
        End Get
        Set
            _FC3 = Value
        End Set
    End Property

    Property FC4 As Color
        Get
            Return _FC4
        End Get
        Set
            _FC4 = Value
        End Set
    End Property



    Sub New(Style As String)
        Select Case Style
            Case "Black"
                Me.BC1 = Color.FromArgb(34, 37, 42)
                Me.FC1 = Color.FromArgb(224, 224, 224)
                Me.BC2 = Color.FromArgb(57, 61, 64)
                Me.FC2 = Color.FromArgb(148, 149, 153)
            Case "White"
                Me.BC1 = Color.FromArgb(208, 208, 208)
                Me.FC1 = Color.FromArgb(108, 108, 110)
                Me.BC2 = Color.FromArgb(235, 235, 237)
                Me.FC2 = Color.Black
            Case "Blue"
                Me.BC1 = Color.FromArgb(64, 86, 141)
                Me.FC1 = Color.White
                Me.BC2 = Color.FromArgb(204, 213, 240)
                Me.FC2 = Color.Black


        End Select
    End Sub


End Class
