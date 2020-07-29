<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtempdr
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
        Me.tbltempdrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbltempdrTableAdapter = New desktopframework.dtsitemlistTableAdapters.tbltempdrTableAdapter
        CType(Me.dtsitemlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbltempdrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dtsitemlist_tbltempdr"
        ReportDataSource1.Value = Me.tbltempdrBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "desktopframework.rpttempdr.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(783, 452)
        Me.ReportViewer1.TabIndex = 0
        '
        'dtsitemlist
        '
        Me.dtsitemlist.DataSetName = "dtsitemlist"
        Me.dtsitemlist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbltempdrBindingSource
        '
        Me.tbltempdrBindingSource.DataMember = "tbltempdr"
        Me.tbltempdrBindingSource.DataSource = Me.dtsitemlist
        '
        'tbltempdrTableAdapter
        '
        Me.tbltempdrTableAdapter.ClearBeforeFill = True
        '
        'frmtempdr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 452)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmtempdr"
        Me.TabText = "Temp DR"
        Me.Text = "Temp DR"
        CType(Me.dtsitemlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbltempdrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbltempdrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtsitemlist As desktopframework.dtsitemlist
    Friend WithEvents tbltempdrTableAdapter As desktopframework.dtsitemlistTableAdapters.tbltempdrTableAdapter
End Class
