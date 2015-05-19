Imports System.Data.OleDb
Imports License.ClassDefault
Public Class frmApplication
    Private Sub frmApplication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusVersion.Text = strVersion
        SetDataGridView()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        frmHome.Show()
        Me.Close()
    End Sub
    Private Sub SetDataGridView()
        RefreshData()
        Dim strSql As String
        strSql = "SELECT * FROM LICENSE"
        da = New OleDbDataAdapter(strSql, Conn)
        da.Fill(ds, "MyData")
        Me.DataGridViewApplication.DataSource = ds.Tables("MyData")
    End Sub
    Private Sub RefreshData()
        If ds.Tables.Contains("MyData") Then
            ds.Tables.Remove("MyData")
        End If
    End Sub
    Private Sub ToolStripButtonSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonSort.Click
        SortDataInCurrentColumn(DataGridViewApplication)
    End Sub
    Private Sub DataGridViewApplication_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewApplication.CellClick
        DataGridViewApplication.SelectionMode = DataGridViewSelectionMode.CellSelect
    End Sub
    Private Sub DataGridViewApplication_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewApplication.CellContentDoubleClick
        frmInfo_Application.Show()
        Me.Close()
    End Sub
    Private Sub ToolStripButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonSearch.Click
        Dim InputValue As String = InputBox("Enter Value", "Search", "Please Enter Value")
        If InputValue <> "" Then
            Find(InputValue, DataGridViewApplication)
        Else
        End If
    End Sub
    Private Sub ToolStripButtonOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonOpen.Click
        frmInfo_Application.Show()
        Me.Close()
    End Sub
    Private Sub DataGridViewApplication_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridViewApplication.KeyDown
        DataGridViewApplication.SelectionMode = DataGridViewSelectionMode.CellSelect
    End Sub
End Class