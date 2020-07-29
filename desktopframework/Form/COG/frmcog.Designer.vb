<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcog
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
        Me.GradientPanelXP1 = New Lybra.Forms.Controls.GradientPanelXP
        Me.dtgcog = New System.Windows.Forms.DataGridView
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GradientPanelXP3 = New Lybra.Forms.Controls.GradientPanelXP
        Me.cmdprint = New System.Windows.Forms.Button
        Me.txtpk = New System.Windows.Forms.TextBox
        Me.cmdclose = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.dtpdate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbtype = New System.Windows.Forms.ComboBox
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.cmbtrno = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbdesc = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GradientPanelXP2 = New Lybra.Forms.Controls.GradientPanelXP
        Me.dtgmain = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GradientPanelXP4 = New Lybra.Forms.Controls.GradientPanelXP
        Me.cmdfilter = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.cmddelete = New System.Windows.Forms.Button
        Me.GradientPanelXP1.SuspendLayout()
        CType(Me.dtgcog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanelXP3.SuspendLayout()
        Me.GradientPanelXP2.SuspendLayout()
        CType(Me.dtgmain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanelXP4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GradientPanelXP1
        '
        Me.GradientPanelXP1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP1.Controls.Add(Me.dtgcog)
        Me.GradientPanelXP1.Controls.Add(Me.GradientPanelXP3)
        Me.GradientPanelXP1.Controls.Add(Me.GradientPanelXP2)
        Me.GradientPanelXP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanelXP1.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP1.Name = "GradientPanelXP1"
        Me.GradientPanelXP1.Size = New System.Drawing.Size(894, 477)
        Me.GradientPanelXP1.TabIndex = 0
        '
        'dtgcog
        '
        Me.dtgcog.AllowUserToAddRows = False
        Me.dtgcog.AllowUserToDeleteRows = False
        Me.dtgcog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgcog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dtgcog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgcog.Location = New System.Drawing.Point(0, 152)
        Me.dtgcog.Name = "dtgcog"
        Me.dtgcog.RowHeadersVisible = False
        Me.dtgcog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgcog.Size = New System.Drawing.Size(606, 325)
        Me.dtgcog.TabIndex = 10
        '
        'Column6
        '
        Me.Column6.HeaderText = "pk"
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        '
        'Column5
        '
        Me.Column5.HeaderText = "trno"
        Me.Column5.Name = "Column5"
        Me.Column5.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Type"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 250
        '
        'Column4
        '
        Me.Column4.HeaderText = "Amount"
        Me.Column4.Name = "Column4"
        '
        'GradientPanelXP3
        '
        Me.GradientPanelXP3.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP3.Controls.Add(Me.cmddelete)
        Me.GradientPanelXP3.Controls.Add(Me.cmdprint)
        Me.GradientPanelXP3.Controls.Add(Me.txtpk)
        Me.GradientPanelXP3.Controls.Add(Me.cmdclose)
        Me.GradientPanelXP3.Controls.Add(Me.cmdsave)
        Me.GradientPanelXP3.Controls.Add(Me.dtpdate)
        Me.GradientPanelXP3.Controls.Add(Me.Label5)
        Me.GradientPanelXP3.Controls.Add(Me.cmbtype)
        Me.GradientPanelXP3.Controls.Add(Me.txtamount)
        Me.GradientPanelXP3.Controls.Add(Me.cmbtrno)
        Me.GradientPanelXP3.Controls.Add(Me.Label4)
        Me.GradientPanelXP3.Controls.Add(Me.Label1)
        Me.GradientPanelXP3.Controls.Add(Me.cmbdesc)
        Me.GradientPanelXP3.Controls.Add(Me.Label2)
        Me.GradientPanelXP3.Controls.Add(Me.Label3)
        Me.GradientPanelXP3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanelXP3.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP3.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP3.Name = "GradientPanelXP3"
        Me.GradientPanelXP3.Size = New System.Drawing.Size(606, 152)
        Me.GradientPanelXP3.TabIndex = 9
        '
        'cmdprint
        '
        Me.cmdprint.Location = New System.Drawing.Point(352, 117)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(49, 23)
        Me.cmdprint.TabIndex = 14
        Me.cmdprint.Text = "&Print"
        Me.cmdprint.UseVisualStyleBackColor = True
        '
        'txtpk
        '
        Me.txtpk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpk.Location = New System.Drawing.Point(395, 12)
        Me.txtpk.Name = "txtpk"
        Me.txtpk.Size = New System.Drawing.Size(79, 30)
        Me.txtpk.TabIndex = 13
        Me.txtpk.Visible = False
        '
        'cmdclose
        '
        Me.cmdclose.Location = New System.Drawing.Point(457, 117)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(58, 23)
        Me.cmdclose.TabIndex = 12
        Me.cmdclose.Text = "&Close"
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(311, 117)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(42, 23)
        Me.cmdsave.TabIndex = 11
        Me.cmdsave.Text = "&Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'dtpdate
        '
        Me.dtpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdate.Location = New System.Drawing.Point(267, 14)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(122, 26)
        Me.dtpdate.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(223, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date"
        '
        'cmbtype
        '
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"COG", "Rebate", "Freight", "Labor", "Others"})
        Me.cmbtype.Location = New System.Drawing.Point(95, 58)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(420, 21)
        Me.cmbtype.TabIndex = 3
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(95, 108)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(210, 30)
        Me.txtamount.TabIndex = 8
        '
        'cmbtrno
        '
        Me.cmbtrno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtrno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtrno.FormattingEnabled = True
        Me.cmbtrno.Location = New System.Drawing.Point(95, 18)
        Me.cmbtrno.Name = "cmbtrno"
        Me.cmbtrno.Size = New System.Drawing.Size(121, 21)
        Me.cmbtrno.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TR no."
        '
        'cmbdesc
        '
        Me.cmbdesc.FormattingEnabled = True
        Me.cmbdesc.Location = New System.Drawing.Point(95, 83)
        Me.cmbdesc.Name = "cmbdesc"
        Me.cmbdesc.Size = New System.Drawing.Size(420, 21)
        Me.cmbdesc.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Type."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Description"
        '
        'GradientPanelXP2
        '
        Me.GradientPanelXP2.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP2.Controls.Add(Me.dtgmain)
        Me.GradientPanelXP2.Controls.Add(Me.GradientPanelXP4)
        Me.GradientPanelXP2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GradientPanelXP2.Gradient = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GradientPanelXP2.Location = New System.Drawing.Point(606, 0)
        Me.GradientPanelXP2.Name = "GradientPanelXP2"
        Me.GradientPanelXP2.Size = New System.Drawing.Size(288, 477)
        Me.GradientPanelXP2.TabIndex = 0
        '
        'dtgmain
        '
        Me.dtgmain.AllowUserToAddRows = False
        Me.dtgmain.AllowUserToDeleteRows = False
        Me.dtgmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgmain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dtgmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgmain.Location = New System.Drawing.Point(0, 68)
        Me.dtgmain.Name = "dtgmain"
        Me.dtgmain.RowHeadersVisible = False
        Me.dtgmain.Size = New System.Drawing.Size(288, 409)
        Me.dtgmain.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "TR no"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'GradientPanelXP4
        '
        Me.GradientPanelXP4.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP4.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP4.Controls.Add(Me.cmdfilter)
        Me.GradientPanelXP4.Controls.Add(Me.Label6)
        Me.GradientPanelXP4.Controls.Add(Me.dtpto)
        Me.GradientPanelXP4.Controls.Add(Me.dtpfrom)
        Me.GradientPanelXP4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanelXP4.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP4.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP4.Name = "GradientPanelXP4"
        Me.GradientPanelXP4.Size = New System.Drawing.Size(288, 68)
        Me.GradientPanelXP4.TabIndex = 0
        '
        'cmdfilter
        '
        Me.cmdfilter.Location = New System.Drawing.Point(221, 39)
        Me.cmdfilter.Name = "cmdfilter"
        Me.cmdfilter.Size = New System.Drawing.Size(42, 23)
        Me.cmdfilter.TabIndex = 12
        Me.cmdfilter.Text = "&Filter"
        Me.cmdfilter.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date Range"
        '
        'dtpto
        '
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(114, 40)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(101, 20)
        Me.dtpto.TabIndex = 1
        '
        'dtpfrom
        '
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfrom.Location = New System.Drawing.Point(7, 40)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(101, 20)
        Me.dtpfrom.TabIndex = 0
        '
        'cmddelete
        '
        Me.cmddelete.Location = New System.Drawing.Point(400, 117)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(58, 23)
        Me.cmddelete.TabIndex = 15
        Me.cmddelete.Text = "&Delete"
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'frmcog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 477)
        Me.Controls.Add(Me.GradientPanelXP1)
        Me.Name = "frmcog"
        Me.TabText = "COG, FREIGHT & HANDLING, LABOR, OTHERS"
        Me.Text = "COG, FREIGHT & HANDLING, LABOR, OTHERS"
        Me.GradientPanelXP1.ResumeLayout(False)
        CType(Me.dtgcog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanelXP3.ResumeLayout(False)
        Me.GradientPanelXP3.PerformLayout()
        Me.GradientPanelXP2.ResumeLayout(False)
        CType(Me.dtgmain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanelXP4.ResumeLayout(False)
        Me.GradientPanelXP4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientPanelXP1 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents GradientPanelXP2 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbtrno As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbdesc As System.Windows.Forms.ComboBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GradientPanelXP3 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents dtgcog As System.Windows.Forms.DataGridView
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents dtgmain As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradientPanelXP4 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents cmdfilter As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtpk As System.Windows.Forms.TextBox
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents cmddelete As System.Windows.Forms.Button
End Class
