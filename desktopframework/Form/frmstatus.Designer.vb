<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstatus
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
        Me.trstat = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GenerateTransactionSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerateAssesmentSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InputORDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IssueChargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbtrno = New System.Windows.Forms.ComboBox
        Me.cmdfilter = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.Panel2 = New System.Windows.Forms.Panel
        CType(Me.trstat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'trstat
        '
        Me.trstat.AllowUserToAddRows = False
        Me.trstat.AllowUserToDeleteRows = False
        Me.trstat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.trstat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7})
        Me.trstat.ContextMenuStrip = Me.ContextMenuStrip1
        Me.trstat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trstat.Location = New System.Drawing.Point(0, 0)
        Me.trstat.Name = "trstat"
        Me.trstat.ReadOnly = True
        Me.trstat.RowHeadersVisible = False
        Me.trstat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.trstat.Size = New System.Drawing.Size(1187, 460)
        Me.trstat.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "TR No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Client Name"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "PR - Date"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "PO - Date"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "RPQ - Date"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "CI - Date"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "OR - Date"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateTransactionSlipToolStripMenuItem, Me.GenerateAssesmentSlipToolStripMenuItem, Me.InputORDetailsToolStripMenuItem, Me.IssueChargeToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(209, 92)
        '
        'GenerateTransactionSlipToolStripMenuItem
        '
        Me.GenerateTransactionSlipToolStripMenuItem.Name = "GenerateTransactionSlipToolStripMenuItem"
        Me.GenerateTransactionSlipToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.GenerateTransactionSlipToolStripMenuItem.Text = "Generate Transaction Slip"
        '
        'GenerateAssesmentSlipToolStripMenuItem
        '
        Me.GenerateAssesmentSlipToolStripMenuItem.Name = "GenerateAssesmentSlipToolStripMenuItem"
        Me.GenerateAssesmentSlipToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.GenerateAssesmentSlipToolStripMenuItem.Text = "Generate Assesment Slip"
        '
        'InputORDetailsToolStripMenuItem
        '
        Me.InputORDetailsToolStripMenuItem.Name = "InputORDetailsToolStripMenuItem"
        Me.InputORDetailsToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.InputORDetailsToolStripMenuItem.Text = "Input OR Details"
        '
        'IssueChargeToolStripMenuItem
        '
        Me.IssueChargeToolStripMenuItem.Name = "IssueChargeToolStripMenuItem"
        Me.IssueChargeToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.IssueChargeToolStripMenuItem.Text = "Issue Charge Invoice"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbtrno)
        Me.Panel1.Controls.Add(Me.cmdfilter)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpto)
        Me.Panel1.Controls.Add(Me.dtpfrom)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1187, 70)
        Me.Panel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(878, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(309, 63)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Baj Pharma"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Transaction Number"
        '
        'cmbtrno
        '
        Me.cmbtrno.FormattingEnabled = True
        Me.cmbtrno.Location = New System.Drawing.Point(224, 38)
        Me.cmbtrno.Name = "cmbtrno"
        Me.cmbtrno.Size = New System.Drawing.Size(244, 21)
        Me.cmbtrno.TabIndex = 5
        '
        'cmdfilter
        '
        Me.cmdfilter.Location = New System.Drawing.Point(474, 37)
        Me.cmdfilter.Name = "cmdfilter"
        Me.cmdfilter.Size = New System.Drawing.Size(75, 23)
        Me.cmdfilter.TabIndex = 4
        Me.cmdfilter.Text = "&Filter"
        Me.cmdfilter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From ------------------------>"
        '
        'dtpto
        '
        Me.dtpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(116, 37)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(102, 23)
        Me.dtpto.TabIndex = 1
        Me.dtpto.Value = New Date(2011, 3, 22, 0, 0, 0, 0)
        '
        'dtpfrom
        '
        Me.dtpfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfrom.Location = New System.Drawing.Point(11, 37)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(101, 23)
        Me.dtpfrom.TabIndex = 0
        Me.dtpfrom.Value = New Date(2011, 3, 22, 0, 0, 0, 0)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.trstat)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1187, 460)
        Me.Panel2.TabIndex = 3
        '
        'frmstatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 530)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmstatus"
        Me.TabText = "Status"
        Me.Text = "Status"
        CType(Me.trstat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trstat As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GenerateTransactionSlipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateAssesmentSlipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdfilter As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbtrno As System.Windows.Forms.ComboBox
    Friend WithEvents InputORDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IssueChargeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
