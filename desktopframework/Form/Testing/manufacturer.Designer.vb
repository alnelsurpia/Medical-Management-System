<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmanufacturerinfo
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Me.GradientPanelXP1 = New Lybra.Forms.Controls.GradientPanelXP
        Me.dtgitemlist = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbprint = New System.Windows.Forms.Button
        Me.cmbdesc = New System.Windows.Forms.ComboBox
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.cmddel = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.GradientPanelXP1.SuspendLayout()
        CType(Me.dtgitemlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GradientPanelXP1
        '
        Me.GradientPanelXP1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP1.BackColor2 = System.Drawing.Color.White
        Me.GradientPanelXP1.Controls.Add(Me.dtgitemlist)
        Me.GradientPanelXP1.Controls.Add(Me.Panel1)
        Me.GradientPanelXP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanelXP1.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP1.Name = "GradientPanelXP1"
        Me.GradientPanelXP1.Size = New System.Drawing.Size(1003, 474)
        Me.GradientPanelXP1.TabIndex = 0
        '
        'dtgitemlist
        '
        Me.dtgitemlist.AllowUserToDeleteRows = False
        Me.dtgitemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgitemlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column11, Me.Column2, Me.Column3, Me.Column6, Me.Column4, Me.Column5})
        Me.dtgitemlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgitemlist.Location = New System.Drawing.Point(0, 62)
        Me.dtgitemlist.Name = "dtgitemlist"
        Me.dtgitemlist.RowHeadersVisible = False
        Me.dtgitemlist.Size = New System.Drawing.Size(1003, 412)
        Me.dtgitemlist.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "[ ]"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 30
        '
        'Column11
        '
        Me.Column11.HeaderText = "pk"
        Me.Column11.Name = "Column11"
        Me.Column11.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Supplier No"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "Supplier Name"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Width = 200
        '
        'Column6
        '
        Me.Column6.HeaderText = "Address"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "Person Incharge"
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.HeaderText = "Contact No."
        Me.Column5.Name = "Column5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbprint)
        Me.Panel1.Controls.Add(Me.cmbdesc)
        Me.Panel1.Controls.Add(Me.cmdsearch)
        Me.Panel1.Controls.Add(Me.cmddel)
        Me.Panel1.Controls.Add(Me.cmdsave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 62)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Supplier Name"
        '
        'cmbprint
        '
        Me.cmbprint.Location = New System.Drawing.Point(363, 33)
        Me.cmbprint.Name = "cmbprint"
        Me.cmbprint.Size = New System.Drawing.Size(75, 23)
        Me.cmbprint.TabIndex = 5
        Me.cmbprint.Text = "&Print"
        Me.cmbprint.UseVisualStyleBackColor = True
        Me.cmbprint.Visible = False
        '
        'cmbdesc
        '
        Me.cmbdesc.FormattingEnabled = True
        Me.cmbdesc.Location = New System.Drawing.Point(5, 34)
        Me.cmbdesc.Name = "cmbdesc"
        Me.cmbdesc.Size = New System.Drawing.Size(271, 21)
        Me.cmbdesc.TabIndex = 4
        '
        'cmdsearch
        '
        Me.cmdsearch.Location = New System.Drawing.Point(282, 33)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdsearch.TabIndex = 3
        Me.cmdsearch.Text = "Search"
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'cmddel
        '
        Me.cmddel.Location = New System.Drawing.Point(682, 32)
        Me.cmddel.Name = "cmddel"
        Me.cmddel.Size = New System.Drawing.Size(75, 23)
        Me.cmddel.TabIndex = 1
        Me.cmddel.Text = "&Delete"
        Me.cmddel.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(601, 32)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 23)
        Me.cmdsave.TabIndex = 0
        Me.cmdsave.Text = "&Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'frmmanufacturerinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 474)
        Me.Controls.Add(Me.GradientPanelXP1)
        Me.Name = "frmmanufacturerinfo"
        Me.TabText = "Supplier Information"
        Me.Text = "Supplier Information"
        Me.GradientPanelXP1.ResumeLayout(False)
        CType(Me.dtgitemlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientPanelXP1 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents cmddel As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents dtgitemlist As System.Windows.Forms.DataGridView
    Friend WithEvents cmbdesc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbprint As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
