Imports System.ComponentModel
Imports System.Configuration

Module Module_Settings

    Public WithEvents Settings As New FormSettings


    NotInheritable Class FormSettings
        Inherits ApplicationSettingsBase


        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
        Public Property NfoCover() As Boolean
            Get
                Return CType(Me("NfoCover"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("NfoCover") = value
            End Set
        End Property

    End Class

End Module
