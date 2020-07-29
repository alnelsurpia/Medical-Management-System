<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtransactionref
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.dtstransref = New desktopframework.dtstransref
        Me.tbltrmainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbltrmainTableAdapter = New desktopframework.dtstransrefTableAdapters.tbltrmainTableAdapter
        Me.tbltransacDRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbltransacDRTableAdapter = New desktopframework.dtstransrefTableAdapters.tbltransacDRTableAdapter
        Me.dtslacking = New desktopframework.dtslacking
        Me.tbltrstausBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbltrstausTableAdapter = New desktopframework.dtslackingTableAdapters.tbltrstausTableAdapter
        Me.tblrebateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblrebateTableAdapter = New desktopframework.dtslackingTableAdapters.tblrebateTableAdapter
        CType(Me.dtstransref, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbltrmainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbltransacDRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtslacking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbltrstausBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblrebateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dtstransref_tbltrmain"
        ReportDataSource1.Value = Me.tbltrmainBindingSource
        ReportDataSource2.Name = "dtstransref_tbltransacDR"
        ReportDataSource2.Value = Me.tbltransacDRBindingSource
        ReportDataSource3.Name = "dtslacking_tbltrstaus"
        ReportDataSource3.Value = Me.tbltrstausBindingSource
        ReportDataSource4.Name = "dtslacking_tblrebate"
        ReportDataSource4.Value = Me.tblrebateBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "desktopframework.rpttransactionref.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(884, 503)
        Me.ReportViewer1.TabIndex = 0
        '
        'dtstransref
        '
        Me.dtstransref.DataSetName = "dtstransref"
        Me.dtstransref.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbltrmainBindingSource
        '
        Me.tbltrmainBindingSource.DataMember = "tbltrmain"
        Me.tbltrmainBindingSource.DataSource = Me.dtstransref
        '
        'tbltrmainTableAdapter
        '
        Me.tbltrmainTableAdapter.ClearBeforeFill = True
        '
        'tbltransacDRBindingSource
        '
        Me.tbltransacDRBindingSource.DataMember = "tbltransacDR"
        Me.tbltransacDRBindingSource.DataSource = Me.dtstransref
        '
        'tbltransacDRTableAdapter
        '
        Me.tbltransacDRTableAdapter.ClearBeforeFill = True
        '
        'dtslacking
        '
        Me.dtslacking.DataSetName = "dtslacking"
        Me.dtslacking.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbltrstausBindingSource
        '
        Me.tbltrstausBindingSource.DataMember = "tbltrstaus"
        Me.tbltrstausBindingSource.DataSource = Me.dtslacking
        '
        'tbltrstausTableAdapter
        '
        Me.tbltrstausTableAdapter.ClearBeforeFill = True
        '
        'tblrebateBindingSource
        '
        Me.tblrebateBindingSource.DataMember = "tblrebate"
        Me.tblrebateBindingSource.DataSource = Me.dtslacking
        '
        'tblrebateTableAdapter
        '
        Me.tblrebateTableAdapter.ClearBeforeFill = True
        '
        'frmtransactionref
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 503)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmtransactionref"
        Me.TabText = "Transaction Reference Slip"
        Me.Text = "Transaction Reference Slip"
        CType(Me.dtstransref, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbltrmainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbltransacDRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtslacking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbltrstausBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblrebateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbltrmainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtstransref As desktopframework.dtstransref
    Friend WithEvents tbltransacDRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tbltrstausBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtslacking As desktopframework.dtslacking
    Friend WithEvents tblrebateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tbltrmainTableAdapter As desktopframework.dtstransrefTableAdapters.tbltrmainTableAdapter
    Friend WithEvents tbltransacDRTableAdapter As desktopframework.dtstransrefTableAdapters.tbltransacDRTableAdapter
    Friend WithEvents tbltrstausTableAdapter As desktopframework.dtslackingTableAdapters.tbltrstausTableAdapter
    Friend WithEvents tblrebateTableAdapter As desktopframework.dtslackingTableAdapters.tblrebateTableAdapter
End Class
