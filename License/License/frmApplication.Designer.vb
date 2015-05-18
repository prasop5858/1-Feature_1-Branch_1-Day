<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApplication
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApplication))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonSort = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonOpen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonPrint = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewApplication = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridViewApplication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(719, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusVersion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 240)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(719, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusVersion
        '
        Me.ToolStripStatusVersion.Name = "ToolStripStatusVersion"
        Me.ToolStripStatusVersion.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusVersion.Text = "ToolStripStatusLabel1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonSort, Me.ToolStripSeparator1, Me.ToolStripButtonSearch, Me.ToolStripSeparator2, Me.ToolStripButtonAdd, Me.ToolStripSeparator3, Me.ToolStripButtonOpen, Me.ToolStripSeparator4, Me.ToolStripButtonDelete, Me.ToolStripSeparator5, Me.ToolStripButtonPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(719, 38)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonSort
        '
        Me.ToolStripButtonSort.Image = CType(resources.GetObject("ToolStripButtonSort.Image"), System.Drawing.Image)
        Me.ToolStripButtonSort.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSort.Name = "ToolStripButtonSort"
        Me.ToolStripButtonSort.Size = New System.Drawing.Size(34, 35)
        Me.ToolStripButtonSort.Text = "เรียง"
        Me.ToolStripButtonSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripButtonSearch
        '
        Me.ToolStripButtonSearch.Image = CType(resources.GetObject("ToolStripButtonSearch.Image"), System.Drawing.Image)
        Me.ToolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSearch.Name = "ToolStripButtonSearch"
        Me.ToolStripButtonSearch.Size = New System.Drawing.Size(38, 35)
        Me.ToolStripButtonSearch.Text = "ค้นหา"
        Me.ToolStripButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripButtonAdd
        '
        Me.ToolStripButtonAdd.Image = CType(resources.GetObject("ToolStripButtonAdd.Image"), System.Drawing.Image)
        Me.ToolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAdd.Name = "ToolStripButtonAdd"
        Me.ToolStripButtonAdd.Size = New System.Drawing.Size(31, 35)
        Me.ToolStripButtonAdd.Text = "เพิ่ม"
        Me.ToolStripButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripButtonOpen
        '
        Me.ToolStripButtonOpen.Image = CType(resources.GetObject("ToolStripButtonOpen.Image"), System.Drawing.Image)
        Me.ToolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonOpen.Name = "ToolStripButtonOpen"
        Me.ToolStripButtonOpen.Size = New System.Drawing.Size(30, 35)
        Me.ToolStripButtonOpen.Text = "เปิด"
        Me.ToolStripButtonOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripButtonDelete
        '
        Me.ToolStripButtonDelete.Image = CType(resources.GetObject("ToolStripButtonDelete.Image"), System.Drawing.Image)
        Me.ToolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDelete.Name = "ToolStripButtonDelete"
        Me.ToolStripButtonDelete.Size = New System.Drawing.Size(24, 35)
        Me.ToolStripButtonDelete.Text = "ลบ"
        Me.ToolStripButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripButtonPrint
        '
        Me.ToolStripButtonPrint.Image = CType(resources.GetObject("ToolStripButtonPrint.Image"), System.Drawing.Image)
        Me.ToolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPrint.Name = "ToolStripButtonPrint"
        Me.ToolStripButtonPrint.Size = New System.Drawing.Size(34, 35)
        Me.ToolStripButtonPrint.Text = "พิมพ์"
        Me.ToolStripButtonPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DataGridViewApplication
        '
        Me.DataGridViewApplication.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewApplication.Location = New System.Drawing.Point(18, 70)
        Me.DataGridViewApplication.Name = "DataGridViewApplication"
        Me.DataGridViewApplication.Size = New System.Drawing.Size(683, 150)
        Me.DataGridViewApplication.TabIndex = 3
        '
        'frmApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 262)
        Me.Controls.Add(Me.DataGridViewApplication)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmApplication"
        Me.Text = "Application License"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridViewApplication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonSort As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewApplication As System.Windows.Forms.DataGridView
End Class
