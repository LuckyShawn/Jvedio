
Imports System.ComponentModel
    Imports System.Configuration

Module New_Settings

    Public WithEvents Settings As New FormSettings


    NotInheritable Class FormSettings
        Inherits ApplicationSettingsBase

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("True")>
        Public Property ScanNFO() As Boolean
            Get
                Return CType(Me("ScanNFO"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("ScanNFO") = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <UserScopedSettingAttribute(), DefaultSettingValueAttribute("False")>
        Public Property EnableExtra() As Boolean
            Get
                Return CType(Me("EnableExtra"), Boolean)
            End Get
            Set(ByVal value As Boolean)
                Me("EnableExtra") = value
            End Set
        End Property


    End Class


End Module
