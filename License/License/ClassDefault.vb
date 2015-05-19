Imports System.Data.OleDb
Public Class ClassDefault
    Public Shared strVersion As String = "Version 0.0.0"
    Public Shared strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\npfiles\it_develop\prasop\dbLicense.mdb"
    Public Shared Conn As New OleDbConnection(strConn)
    Public Shared ds As New DataSet
    Public Shared da As OleDbDataAdapter
    Public Shared Sub SortDataInCurrentColumn(ByVal DataGridView)
        Dim CurrentColumnIndex As Integer
        CurrentColumnIndex = DataGridView.CurrentCellAddress.X
        If DataGridView.SortOrder = SortOrder.Ascending Then
            DataGridView.Sort(DataGridView.Columns(CurrentColumnIndex), System.ComponentModel.ListSortDirection.Descending)
        Else
            DataGridView.Sort(DataGridView.Columns(CurrentColumnIndex), System.ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub
    Public Shared Sub Find(ByVal strSearchString As String, ByVal DataGridView As DataGridView)
        Dim CurrentColumnIndex As Integer
        Dim intcount As Integer = 0
        Dim intcountRow As Integer = DataGridView.RowCount
        Dim strCurrentColumnIndex As Integer
        Dim strincount As Integer
        CurrentColumnIndex = DataGridView.CurrentCellAddress.X
        DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        For Each Row As DataGridViewRow In DataGridView.Rows
            If DataGridView.Rows(intcount).Cells(CurrentColumnIndex).Value.ToString = strSearchString Then
                DataGridView.Rows(intcount).Selected = True
                strCurrentColumnIndex = CurrentColumnIndex
                strincount = intcount
                DataGridView.CurrentCell = DataGridView.Rows(strincount).Cells(strCurrentColumnIndex)
                Exit Sub
            End If
            intcount += 1
            If (intcount = (intcountRow - 1)) Then
                MessageBox.Show("Value not found")
                DataGridView.ClearSelection()
                Exit Sub
            End If
        Next Row
    End Sub
End Class
