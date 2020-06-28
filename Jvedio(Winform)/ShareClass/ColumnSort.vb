
''' <summary>
''' ListView排序
''' </summary>
Public Class ColumnSort : Implements IComparer
    Public columnNum As Integer = 0
    Public bAscending As Boolean = True
    Public Sub New(ByVal column_to_sort As Integer)
        columnNum = column_to_sort
    End Sub
    Private Function CompareInt(ByVal x As Integer, ByVal y As Integer) As Integer
        If x > y Then
            Return 1
        ElseIf x < y Then
            Return -1
        Else
            Return 0
        End If
    End Function
    Public Function Compare(ByVal a As Object, ByVal b As Object) As Integer Implements IComparer.Compare
        Dim listItemA As System.Windows.Forms.ListViewItem = DirectCast(a, System.Windows.Forms.ListViewItem)
        Dim listItemB As System.Windows.Forms.ListViewItem = DirectCast(b, System.Windows.Forms.ListViewItem)
        Dim xText As String = listItemA.SubItems(columnNum).Text
        Dim yText As String = listItemB.SubItems(columnNum).Text
        Dim xInt As Integer, yInt As Integer

        If bAscending Then
            If Integer.TryParse(xText, xInt) AndAlso Integer.TryParse(yText, yInt) Then
                Return CompareInt(xInt, yInt)
            Else
                Return [String].Compare(xText, yText)
            End If
        Else
            If Integer.TryParse(xText, xInt) AndAlso Integer.TryParse(yText, yInt) Then
                Return -1 * CompareInt(xInt, yInt)
            Else
                Return -1 * [String].Compare(xText, yText)
            End If
        End If
    End Function
End Class