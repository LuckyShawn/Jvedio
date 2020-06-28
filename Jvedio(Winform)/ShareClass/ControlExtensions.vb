Imports System.Windows.Forms
''' <summary>
''' 防止ListView闪烁
''' </summary>
Public Class ControlExtensions
    Public Sub DoubleBuffering(ByVal control As Control, ByVal enable As Boolean)
        Dim doubleBufferPropertyInfo = control.[GetType]().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
        doubleBufferPropertyInfo.SetValue(control, enable, Nothing)
    End Sub
End Class