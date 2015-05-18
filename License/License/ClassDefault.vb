Public Class ClassDefault
    Public Shared strVersion As String = "Version 0.0.0"
    Public Shared Sub SortDataInCurrentColumn(ByVal DataGridView)
        Dim CurrentColumnIndex As Integer
        CurrentColumnIndex = DataGridView.CurrentCellAddress.X
        If DataGridView.SortOrder = SortOrder.Ascending Then
            DataGridView.Sort(DataGridView.Columns(CurrentColumnIndex), System.ComponentModel.ListSortDirection.Descending)
        Else
            DataGridView.Sort(DataGridView.Columns(CurrentColumnIndex), System.ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub
End Class
