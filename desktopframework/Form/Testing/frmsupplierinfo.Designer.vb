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
        Me.components = New System.ComponentModel.Container
        Me.GradientPanelXP1 = New Lybra.Forms.Controls.GradientPanelXP
        Me.dtgitemlist = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbprint = New System.Windows.Forms.Button
        Me.cmbdesc = New System.Windows.Forms.ComboBox
        Me.TblsupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtssupplier = New desktopframework.dtssupplier
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.cmddel = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.TblsupplierTableAdapter = New desktopframework.dtssupplierTableAdapters.tblsupplierTableAdapter
        Me.Button1 = New System.Windows.Forms.Button
        Me.GradientPanelXP1.SuspendLayout()
        CType(Me.dtgitemlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblsupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtssupplier, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dtgitemlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column11, Me.Column2, Me.Column3, Me.Column6, Me.Column4, Me.Column5, Me.Column7, Me.Column8})
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
        'Column7
        '
        Me.Column7.HeaderText = "Manufacturer"
        Me.Column7.Items.AddRange(New Object() {"True", "False"})
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Supplier"
        Me.Column8.Items.AddRange(New Object() {"True", "False"})
        Me.Column8.Name = "Column8"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Suppliers/Manufacturer"
        '
        'cmbprint
        '
        Me.cmbprint.Location = New System.Drawing.Point(442, 32)
        Me.cmbprint.Name = "cmbprint"
        Me.cmbprint.Size = New System.Drawing.Size(57, 23)
        Me.cmbprint.TabIndex = 5
        Me.cmbprint.Text = "&Print"
        Me.cmbprint.UseVisualStyleBackColor = True
        Me.cmbprint.Visible = False
        '
        'cmbdesc
        '
        Me.cmbdesc.DataSource = Me.TblsupplierBindingSource
        Me.cmbdesc.DisplayMember = "suppname"
        Me.cmbdesc.FormattingEnabled = True
        Me.cmbdesc.Location = New System.Drawing.Point(5, 34)
        Me.cmbdesc.Name = "cmbdesc"
        Me.cmbdesc.Size = New System.Drawing.Size(271, 21)
        Me.cmbdesc.TabIndex = 4
        '
        'TblsupplierBindingSource
        '
        Me.TblsupplierBindingSource.DataMember = "tblsupplier"
        Me.TblsupplierBindingSource.DataSource = Me.Dtssupplier
        '
        'Dtssupplier
        '
        Me.Dtssupplier.DataSetName = "dtssupplier"
        Me.Dtssupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdsearch
        '
        Me.cmdsearch.Location = New System.Drawing.Point(378, 32)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(58, 23)
        Me.cmdsearch.TabIndex = 3
        Me.cmdsearch.Text = "Search"
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'cmddel
        '
        Me.cmddel.Location = New System.Drawing.Point(556, 32)
        Me.cmddel.Name = "cmddel"
        Me.cmddel.Size = New System.Drawing.Size(51, 23)
        Me.cmddel.TabIndex = 1
        Me.cmddel.Text = "&Delete"
        Me.cmddel.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(503, 32)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(47, 23)
        Me.cmdsave.TabIndex = 0
        Me.cmdsave.Text = "&Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'TblsupplierTableAdapter
        '
        Me.TblsupplierTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(282, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Add New"
        Me.Button1.UseVisualStyleBackColor = True
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
        CType(Me.TblsupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtssupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientPanelXP1 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents cmddel As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents dtgitemlist As System.Windows.Forms.DataGridView
    Friend WithEvents cmbdesc As System.Windows.Forms.ComboBox
    Friend WithEvents TblsupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dtssupplier As desktopframework.dtssupplier
    Friend WithEvents TblsupplierTableAdapter As desktopframework.dtssupplierTableAdapters.tblsupplierTableAdapter
    Friend WithEvents cmbprint As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
