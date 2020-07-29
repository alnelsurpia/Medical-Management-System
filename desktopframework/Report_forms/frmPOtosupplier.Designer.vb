<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOtosupplier
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
        Me.dtspotoclient = New desktopframework.dtspotoclient
        Me.tblpoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblpoTableAdapter = New desktopframework.dtspotoclientTableAdapters.tblpoTableAdapter
        CType(Me.dtspotoclient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblpoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dtspotoclient_tblpo"
        ReportDataSource1.Value = Me.tblpoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "desktopframework.rptpotosupplier.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(284, 262)
        Me.ReportViewer1.TabIndex = 0
        '
        'dtspotoclient
        '
        Me.dtspotoclient.DataSetName = "dtspotoclient"
        Me.dtspotoclient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblpoBindingSource
        '
        Me.tblpoBindingSource.DataMember = "tblpo"
        Me.tblpoBindingSource.DataSource = Me.dtspotoclient
        '
        'tblpoTableAdapter
        '
        Me.tblpoTableAdapter.ClearBeforeFill = True
        '
        'frmPOtosupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmPOtosupplier"
        Me.TabText = "PO to Supplier"
        Me.Text = "PO to Supplier"
        CType(Me.dtspotoclient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblpoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblpoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtspotoclient As desktopframework.dtspotoclient
    Friend WithEvents tblpoTableAdapter As desktopframework.dtspotoclientTableAdapters.tblpoTableAdapter
End Class
