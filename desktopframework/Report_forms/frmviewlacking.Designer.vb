<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewlacking
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
        Me.GradientPanelXP1 = New Lybra.Forms.Controls.GradientPanelXP
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.cmdfilter = New System.Windows.Forms.Button
        Me.dtslacking = New desktopframework.dtslacking
        Me.tbltrmainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbltrmainTableAdapter = New desktopframework.dtslackingTableAdapters.tbltrmainTableAdapter
        Me.GradientPanelXP1.SuspendLayout()
        CType(Me.dtslacking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbltrmainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GradientPanelXP1
        '
        Me.GradientPanelXP1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP1.Controls.Add(Me.cmdfilter)
        Me.GradientPanelXP1.Controls.Add(Me.dtpto)
        Me.GradientPanelXP1.Controls.Add(Me.dtpfrom)
        Me.GradientPanelXP1.Controls.Add(Me.Label1)
        Me.GradientPanelXP1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanelXP1.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP1.Name = "GradientPanelXP1"
        Me.GradientPanelXP1.Size = New System.Drawing.Size(677, 73)
        Me.GradientPanelXP1.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dtslacking_tbltrmain"
        ReportDataSource1.Value = Me.tbltrmainBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "desktopframework.rptlacking.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 73)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(677, 373)
        Me.ReportViewer1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date Range"
        '
        'dtpfrom
        '
        Me.dtpfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfrom.Location = New System.Drawing.Point(15, 25)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(112, 21)
        Me.dtpfrom.TabIndex = 1
        '
        'dtpto
        '
        Me.dtpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(133, 25)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(112, 21)
        Me.dtpto.TabIndex = 2
        '
        'cmdfilter
        '
        Me.cmdfilter.Location = New System.Drawing.Point(252, 25)
        Me.cmdfilter.Name = "cmdfilter"
        Me.cmdfilter.Size = New System.Drawing.Size(75, 23)
        Me.cmdfilter.TabIndex = 3
        Me.cmdfilter.Text = "&Filter"
        Me.cmdfilter.UseVisualStyleBackColor = True
        '
        'dtslacking
        '
        Me.dtslacking.DataSetName = "dtslacking"
        Me.dtslacking.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbltrmainBindingSource
        '
        Me.tbltrmainBindingSource.DataMember = "tbltrmain"
        Me.tbltrmainBindingSource.DataSource = Me.dtslacking
        '
        'tbltrmainTableAdapter
        '
        Me.tbltrmainTableAdapter.ClearBeforeFill = True
        '
        'frmviewlacking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 446)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GradientPanelXP1)
        Me.Name = "frmviewlacking"
        Me.Text = "View lacking"
        Me.GradientPanelXP1.ResumeLayout(False)
        Me.GradientPanelXP1.PerformLayout()
        CType(Me.dtslacking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbltrmainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientPanelXP1 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdfilter As System.Windows.Forms.Button
    Friend WithEvents tbltrmainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtslacking As desktopframework.dtslacking
    Friend WithEvents tbltrmainTableAdapter As desktopframework.dtslackingTableAdapters.tbltrmainTableAdapter
End Class
