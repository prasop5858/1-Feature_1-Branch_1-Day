Imports License.ClassDefault
Public Class frmApplication
    Private Sub frmApplication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusVersion.Text = strVersion
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        frmHome.Show()
        Me.Close()
    End Sub
End Class