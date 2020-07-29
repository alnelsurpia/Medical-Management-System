<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcogprint
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.dtsassesmentslip = New desktopframework.dtsassesmentslip
        Me.tbltrmainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbltrmainTableAdapter = New desktopframework.dtsassesmentslipTableAdapters.tbltrmainTableAdapter
        Me.dtslacking = New desktopframework.dtslacking
        Me.txtcogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtcogTableAdapter = New desktopframework.dtslackingTableAdapters.txtcogTableAdapter
        CType(Me.dtsassesmentslip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbltrmainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtslacking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dtsassesmentslip_tbltrmain"
        ReportDataSource1.Value = Me.tbltrmainBindingSource
        ReportDataSource2.Name = "dtslacking_txtcog"
        ReportDataSource2.Value = Me.txtcogBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "desktopframework.rptcog.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(813, 421)
        Me.ReportViewer1.TabIndex = 0
        '
        'dtsassesmentslip
        '
        Me.dtsassesmentslip.DataSetName = "dtsassesmentslip"
        Me.dtsassesmentslip.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbltrmainBindingSource
        '
        Me.tbltrmainBindingSource.DataMember = "tbltrmain"
        Me.tbltrmainBindingSource.DataSource = Me.dtsassesmentslip
        '
        'tbltrmainTableAdapter
        '
        Me.tbltrmainTableAdapter.ClearBeforeFill = True
        '
        'dtslacking
        '
        Me.dtslacking.DataSetName = "dtslacking"
        Me.dtslacking.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtcogBindingSource
        '
        Me.txtcogBindingSource.DataMember = "txtcog"
        Me.txtcogBindingSource.DataSource = Me.dtslacking
        '
        'txtcogTableAdapter
        '
        Me.txtcogTableAdapter.ClearBeforeFill = True
        '
        'frmcogprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 421)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmcogprint"
        Me.Text = "COG Print"
        CType(Me.dtsassesmentslip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbltrmainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtslacking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbltrmainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtsassesmentslip As desktopframework.dtsassesmentslip
    Friend WithEvents txtcogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtslacking As desktopframework.dtslacking
    Friend WithEvents tbltrmainTableAdapter As desktopframework.dtsassesmentslipTableAdapters.tbltrmainTableAdapter
    Friend WithEvents txtcogTableAdapter As desktopframework.dtslackingTableAdapters.txtcogTableAdapter
End Class
