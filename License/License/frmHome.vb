﻿Imports License.ClassDefault
Public Class frmHome
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub frmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusVersion.Text = strVersion
    End Sub
    Private Sub ApplicationLicenseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicationLicenseToolStripMenuItem.Click
        frmApplication.Show()
        Me.Close()
    End Sub
End Class
