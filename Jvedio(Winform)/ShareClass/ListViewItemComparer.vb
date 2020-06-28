Imports System.Windows.Forms
Public Class ListViewItemComparer
    Implements IEqualityComparer(Of ListViewItem)
    Public Overloads Function Equals(ByVal x As ListViewItem, ByVal y As ListViewItem) As Boolean Implements IEqualityComparer(Of ListViewItem).Equals
        If x IsNot Nothing And y IsNot Nothing Then
            Return x.SubItems(0).Text.ToUpper = y.SubItems(0).Text.ToUpper
        Else
            Return False
        End If
    End Function

    Public Overloads Function GetHashCode(ByVal obj As ListViewItem) As Integer Implements IEqualityComparer(Of ListViewItem).GetHashCode
        '程序进行对比的时候，会先调用GetHashCode，如果返回相同的hash，
        '才会再调用Equals进行进一步判断。
        '所以GetHashCode是初步判断是否相同， Equals是具体判断

        If obj IsNot Nothing Then
            'Debug.Print(obj.SubItems(0).Text.ToUpper.GetHashCode)
            Return obj.SubItems(0).Text.ToUpper.GetHashCode
        Else
            Return 0
        End If
    End Function
End Class