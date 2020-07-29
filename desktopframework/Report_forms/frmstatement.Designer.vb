<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statement
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
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.tblstatementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New desktopframework.DataSet1
        Me.GradientPanelXP1 = New Lybra.Forms.Controls.GradientPanelXP
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbclientname = New System.Windows.Forms.ComboBox
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.tblstatementTableAdapter = New desktopframework.DataSet1TableAdapters.tblstatementTableAdapter
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.tblstatementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanelXP1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblstatementBindingSource
        '
        Me.tblstatementBindingSource.DataMember = "tblstatement"
        Me.tblstatementBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GradientPanelXP1
        '
        Me.GradientPanelXP1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP1.Controls.Add(Me.Label2)
        Me.GradientPanelXP1.Controls.Add(Me.dtpto)
        Me.GradientPanelXP1.Controls.Add(Me.dtpfrom)
        Me.GradientPanelXP1.Controls.Add(Me.Label1)
        Me.GradientPanelXP1.Controls.Add(Me.cmbclientname)
        Me.GradientPanelXP1.Controls.Add(Me.cmdsearch)
        Me.GradientPanelXP1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanelXP1.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP1.Name = "GradientPanelXP1"
        Me.GradientPanelXP1.Size = New System.Drawing.Size(830, 52)
        Me.GradientPanelXP1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Client Name"
        '
        'cmbclientname
        '
        Me.cmbclientname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbclientname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbclientname.DisplayMember = "suppname"
        Me.cmbclientname.FormattingEnabled = True
        Me.cmbclientname.Location = New System.Drawing.Point(184, 27)
        Me.cmbclientname.Name = "cmbclientname"
        Me.cmbclientname.Size = New System.Drawing.Size(271, 21)
        Me.cmbclientname.TabIndex = 7
        '
        'cmdsearch
        '
        Me.cmdsearch.Location = New System.Drawing.Point(461, 26)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdsearch.TabIndex = 6
        Me.cmdsearch.Text = "Filter"
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSet1_tblstatement"
        ReportDataSource3.Value = Me.tblstatementBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "desktopframework.rptstatement.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 52)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(830, 462)
        Me.ReportViewer1.TabIndex = 1
        '
        'tblstatementTableAdapter
        '
        Me.tblstatementTableAdapter.ClearBeforeFill = True
        '
        'dtpto
        '
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(94, 26)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(85, 20)
        Me.dtpto.TabIndex = 10
        Me.dtpto.Value = New Date(2010, 12, 15, 0, 0, 0, 0)
        '
        'dtpfrom
        '
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfrom.Location = New System.Drawing.Point(3, 27)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(85, 20)
        Me.dtpfrom.TabIndex = 9
        Me.dtpfrom.Value = New Date(2010, 12, 15, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Date Range"
        '
        'Statement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 514)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GradientPanelXP1)
        Me.Name = "Statement"
        Me.Text = "Statement"
        CType(Me.tblstatementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanelXP1.ResumeLayout(False)
        Me.GradientPanelXP1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientPanelXP1 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbclientname As System.Windows.Forms.ComboBox
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents tblstatementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As desktopframework.DataSet1
    Friend WithEvents tblstatementTableAdapter As desktopframework.DataSet1TableAdapters.tblstatementTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
End Class
