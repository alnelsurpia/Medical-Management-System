<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmci
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.dtsRPQ = New desktopframework.dtsRPQ
        Me.tblcinoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblcinoTableAdapter = New desktopframework.dtsRPQTableAdapters.tblcinoTableAdapter
        CType(Me.dtsRPQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblcinoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dtsRPQ_tblcino"
        ReportDataSource1.Value = Me.tblcinoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "desktopframework.rptinvoicemain.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(992, 518)
        Me.ReportViewer1.TabIndex = 0
        '
        'dtsRPQ
        '
        Me.dtsRPQ.DataSetName = "dtsRPQ"
        Me.dtsRPQ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblcinoBindingSource
        '
        Me.tblcinoBindingSource.DataMember = "tblcino"
        Me.tblcinoBindingSource.DataSource = Me.dtsRPQ
        '
        'tblcinoTableAdapter
        '
        Me.tblcinoTableAdapter.ClearBeforeFill = True
        '
        'frmci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 518)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmci"
        Me.TabText = "Charge Invoice"
        Me.Text = "Charge Invoice"
        CType(Me.dtsRPQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblcinoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblcinoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtsRPQ As desktopframework.dtsRPQ
    Friend WithEvents tblcinoTableAdapter As desktopframework.dtsRPQTableAdapters.tblcinoTableAdapter
End Class
