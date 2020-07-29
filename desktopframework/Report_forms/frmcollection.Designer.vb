<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcollection
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.CollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New desktopframework.DataSet1
        Me.GradientPanelXP1 = New Lybra.Forms.Controls.GradientPanelXP
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbdesc = New System.Windows.Forms.ComboBox
        Me.btnfilter = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.CollectionTableAdapter = New desktopframework.DataSet1TableAdapters.CollectionTableAdapter
        CType(Me.CollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanelXP1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CollectionBindingSource
        '
        Me.CollectionBindingSource.DataMember = "Collection"
        Me.CollectionBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GradientPanelXP1
        '
        Me.GradientPanelXP1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GradientPanelXP1.BackColor2 = System.Drawing.Color.Chocolate
        Me.GradientPanelXP1.Controls.Add(Me.Label3)
        Me.GradientPanelXP1.Controls.Add(Me.cmbdesc)
        Me.GradientPanelXP1.Controls.Add(Me.btnfilter)
        Me.GradientPanelXP1.Controls.Add(Me.Label2)
        Me.GradientPanelXP1.Controls.Add(Me.Label1)
        Me.GradientPanelXP1.Controls.Add(Me.dtpto)
        Me.GradientPanelXP1.Controls.Add(Me.dtpfrom)
        Me.GradientPanelXP1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanelXP1.Gradient = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GradientPanelXP1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP1.Name = "GradientPanelXP1"
        Me.GradientPanelXP1.Size = New System.Drawing.Size(906, 59)
        Me.GradientPanelXP1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Clients Name"
        '
        'cmbdesc
        '
        Me.cmbdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdesc.FormattingEnabled = True
        Me.cmbdesc.Location = New System.Drawing.Point(256, 29)
        Me.cmbdesc.Name = "cmbdesc"
        Me.cmbdesc.Size = New System.Drawing.Size(238, 24)
        Me.cmbdesc.TabIndex = 10
        '
        'btnfilter
        '
        Me.btnfilter.Location = New System.Drawing.Point(500, 29)
        Me.btnfilter.Name = "btnfilter"
        Me.btnfilter.Size = New System.Drawing.Size(75, 23)
        Me.btnfilter.TabIndex = 9
        Me.btnfilter.Text = "&Filter"
        Me.btnfilter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "From"
        '
        'dtpto
        '
        Me.dtpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(137, 27)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(113, 23)
        Me.dtpto.TabIndex = 6
        '
        'dtpfrom
        '
        Me.dtpfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfrom.Location = New System.Drawing.Point(8, 27)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(113, 23)
        Me.dtpfrom.TabIndex = 5
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1_Collection"
        ReportDataSource1.Value = Me.CollectionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "desktopframework.rptcollection.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 59)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(906, 402)
        Me.ReportViewer1.TabIndex = 1
        '
        'CollectionTableAdapter
        '
        Me.CollectionTableAdapter.ClearBeforeFill = True
        '
        'frmcollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 461)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GradientPanelXP1)
        Me.Name = "frmcollection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collection"
        Me.TopMost = True
        CType(Me.CollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanelXP1.ResumeLayout(False)
        Me.GradientPanelXP1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientPanelXP1 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnfilter As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbdesc As System.Windows.Forms.ComboBox
    Friend WithEvents CollectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As desktopframework.DataSet1
    Friend WithEvents CollectionTableAdapter As desktopframework.DataSet1TableAdapters.CollectionTableAdapter
End Class
