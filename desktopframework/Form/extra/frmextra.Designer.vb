<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmextra
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
        Me.GradientPanelXP1 = New Lybra.Forms.Controls.GradientPanelXP
        Me.cmbcalc = New System.Windows.Forms.Button
        Me.cmbpopulate = New System.Windows.Forms.Button
        Me.dtgitm = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GradientPanelXP1.SuspendLayout()
        CType(Me.dtgitm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GradientPanelXP1
        '
        Me.GradientPanelXP1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP1.Controls.Add(Me.cmbcalc)
        Me.GradientPanelXP1.Controls.Add(Me.cmbpopulate)
        Me.GradientPanelXP1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanelXP1.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP1.Name = "GradientPanelXP1"
        Me.GradientPanelXP1.Size = New System.Drawing.Size(891, 56)
        Me.GradientPanelXP1.TabIndex = 0
        '
        'cmbcalc
        '
        Me.cmbcalc.Location = New System.Drawing.Point(93, 12)
        Me.cmbcalc.Name = "cmbcalc"
        Me.cmbcalc.Size = New System.Drawing.Size(128, 23)
        Me.cmbcalc.TabIndex = 1
        Me.cmbcalc.Text = "Copy Category"
        Me.cmbcalc.UseVisualStyleBackColor = True
        '
        'cmbpopulate
        '
        Me.cmbpopulate.Location = New System.Drawing.Point(12, 12)
        Me.cmbpopulate.Name = "cmbpopulate"
        Me.cmbpopulate.Size = New System.Drawing.Size(75, 23)
        Me.cmbpopulate.TabIndex = 0
        Me.cmbpopulate.Text = "Populate"
        Me.cmbpopulate.UseVisualStyleBackColor = True
        '
        'dtgitm
        '
        Me.dtgitm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgitm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dtgitm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgitm.Location = New System.Drawing.Point(0, 56)
        Me.dtgitm.Name = "dtgitm"
        Me.dtgitm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgitm.Size = New System.Drawing.Size(891, 356)
        Me.dtgitm.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "pk"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "itemcode"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "description"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "Category"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'frmextra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 412)
        Me.Controls.Add(Me.dtgitm)
        Me.Controls.Add(Me.GradientPanelXP1)
        Me.Name = "frmextra"
        Me.Text = "frmextra"
        Me.GradientPanelXP1.ResumeLayout(False)
        CType(Me.dtgitm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientPanelXP1 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents dtgitm As System.Windows.Forms.DataGridView
    Friend WithEvents cmbcalc As System.Windows.Forms.Button
    Friend WithEvents cmbpopulate As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
