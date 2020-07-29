<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintItemlist
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
        Me.dtsitemlist = New desktopframework.dtsitemlist
        Me.tblitemlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblitemlistTableAdapter = New desktopframework.dtsitemlistTableAdapters.tblitemlistTableAdapter
        CType(Me.dtsitemlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblitemlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dtsitemlist_tblitemlist"
        ReportDataSource1.Value = Me.tblitemlistBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "desktopframework.rptitemlist.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(887, 485)
        Me.ReportViewer1.TabIndex = 0
        '
        'dtsitemlist
        '
        Me.dtsitemlist.DataSetName = "dtsitemlist"
        Me.dtsitemlist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblitemlistBindingSource
        '
        Me.tblitemlistBindingSource.DataMember = "tblitemlist"
        Me.tblitemlistBindingSource.DataSource = Me.dtsitemlist
        '
        'tblitemlistTableAdapter
        '
        Me.tblitemlistTableAdapter.ClearBeforeFill = True
        '
        'frmPrintItemlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 485)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmPrintItemlist"
        Me.TabText = "Print Item List"
        Me.Text = "Print Item List"
        CType(Me.dtsitemlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblitemlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblitemlistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtsitemlist As desktopframework.dtsitemlist
    Friend WithEvents tblitemlistTableAdapter As desktopframework.dtsitemlistTableAdapters.tblitemlistTableAdapter
End Class
