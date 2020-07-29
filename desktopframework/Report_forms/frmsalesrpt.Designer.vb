<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsalesrpt
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
        Me.GradientPanelXP1 = New Lybra.Forms.Controls.GradientPanelXP
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnfilter = New System.Windows.Forms.Button
        Me.DataSet1 = New desktopframework.DataSet1
        Me.tbldelieveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbldelieveryTableAdapter = New desktopframework.DataSet1TableAdapters.tbldelieveryTableAdapter
        Me.GradientPanelXP1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbldelieveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GradientPanelXP1
        '
        Me.GradientPanelXP1.BackColor1 = System.Drawing.Color.White
        Me.GradientPanelXP1.BackColor2 = System.Drawing.Color.Blue
        Me.GradientPanelXP1.Controls.Add(Me.btnfilter)
        Me.GradientPanelXP1.Controls.Add(Me.Label2)
        Me.GradientPanelXP1.Controls.Add(Me.Label1)
        Me.GradientPanelXP1.Controls.Add(Me.dtpto)
        Me.GradientPanelXP1.Controls.Add(Me.dtpfrom)
        Me.GradientPanelXP1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanelXP1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP1.Name = "GradientPanelXP1"
        Me.GradientPanelXP1.Size = New System.Drawing.Size(888, 61)
        Me.GradientPanelXP1.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSet1_tbldelievery"
        ReportDataSource3.Value = Me.tbldelieveryBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "desktopframework.rptsales.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 61)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(888, 437)
        Me.ReportViewer1.TabIndex = 1
        '
        'dtpfrom
        '
        Me.dtpfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfrom.Location = New System.Drawing.Point(3, 24)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(113, 23)
        Me.dtpfrom.TabIndex = 0
        '
        'dtpto
        '
        Me.dtpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(132, 24)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(113, 23)
        Me.dtpto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To"
        '
        'btnfilter
        '
        Me.btnfilter.Location = New System.Drawing.Point(251, 24)
        Me.btnfilter.Name = "btnfilter"
        Me.btnfilter.Size = New System.Drawing.Size(75, 23)
        Me.btnfilter.TabIndex = 4
        Me.btnfilter.Text = "&Filter"
        Me.btnfilter.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbldelieveryBindingSource
        '
        Me.tbldelieveryBindingSource.DataMember = "tbldelievery"
        Me.tbldelieveryBindingSource.DataSource = Me.DataSet1
        '
        'tbldelieveryTableAdapter
        '
        Me.tbldelieveryTableAdapter.ClearBeforeFill = True
        '
        'frmsalesrpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 498)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GradientPanelXP1)
        Me.Name = "frmsalesrpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Report"
        Me.TopMost = True
        Me.GradientPanelXP1.ResumeLayout(False)
        Me.GradientPanelXP1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbldelieveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientPanelXP1 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnfilter As System.Windows.Forms.Button
    Friend WithEvents tbldelieveryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As desktopframework.DataSet1
    Friend WithEvents tbldelieveryTableAdapter As desktopframework.DataSet1TableAdapters.tbldelieveryTableAdapter
End Class
