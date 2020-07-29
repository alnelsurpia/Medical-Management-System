<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcollectionrec
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
        Me.GradientPanelXP1 = New Lybra.Forms.Controls.GradientPanelXP
        Me.Pay = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtrem = New System.Windows.Forms.TextBox
        Me.cmdprint = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcheckno = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.dtpdate = New System.Windows.Forms.DateTimePicker
        Me.btnpay = New System.Windows.Forms.Button
        Me.btnlocate = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbdesc = New System.Windows.Forms.ComboBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dtgmain = New System.Windows.Forms.DataGridView
        Me.dtgitem = New System.Windows.Forms.DataGridView
        Me.pk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GradientPanelXP1.SuspendLayout()
        Me.Pay.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtgmain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgitem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GradientPanelXP1
        '
        Me.GradientPanelXP1.BackColor1 = System.Drawing.Color.Green
        Me.GradientPanelXP1.BackColor2 = System.Drawing.Color.White
        Me.GradientPanelXP1.Controls.Add(Me.Pay)
        Me.GradientPanelXP1.Controls.Add(Me.btnlocate)
        Me.GradientPanelXP1.Controls.Add(Me.Label1)
        Me.GradientPanelXP1.Controls.Add(Me.cmbdesc)
        Me.GradientPanelXP1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientPanelXP1.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP1.Name = "GradientPanelXP1"
        Me.GradientPanelXP1.Size = New System.Drawing.Size(1068, 126)
        Me.GradientPanelXP1.TabIndex = 0
        '
        'Pay
        '
        Me.Pay.BackColor = System.Drawing.Color.White
        Me.Pay.Controls.Add(Me.Label5)
        Me.Pay.Controls.Add(Me.txtrem)
        Me.Pay.Controls.Add(Me.cmdprint)
        Me.Pay.Controls.Add(Me.Label4)
        Me.Pay.Controls.Add(Me.txtcheckno)
        Me.Pay.Controls.Add(Me.Label3)
        Me.Pay.Controls.Add(Me.Label2)
        Me.Pay.Controls.Add(Me.txtamount)
        Me.Pay.Controls.Add(Me.dtpdate)
        Me.Pay.Controls.Add(Me.btnpay)
        Me.Pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pay.Location = New System.Drawing.Point(3, 59)
        Me.Pay.Name = "Pay"
        Me.Pay.Size = New System.Drawing.Size(946, 62)
        Me.Pay.TabIndex = 5
        Me.Pay.TabStop = False
        Me.Pay.Text = "Pay"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(437, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Particular"
        '
        'txtrem
        '
        Me.txtrem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrem.Location = New System.Drawing.Point(440, 32)
        Me.txtrem.Name = "txtrem"
        Me.txtrem.Size = New System.Drawing.Size(273, 26)
        Me.txtrem.TabIndex = 10
        '
        'cmdprint
        '
        Me.cmdprint.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdprint.Location = New System.Drawing.Point(853, 33)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(61, 20)
        Me.cmdprint.TabIndex = 6
        Me.cmdprint.Text = "Print"
        Me.cmdprint.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(124, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Check no."
        '
        'txtcheckno
        '
        Me.txtcheckno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcheckno.Location = New System.Drawing.Point(127, 32)
        Me.txtcheckno.Name = "txtcheckno"
        Me.txtcheckno.Size = New System.Drawing.Size(131, 26)
        Me.txtcheckno.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Date Paid"
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(264, 32)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(170, 26)
        Me.txtamount.TabIndex = 5
        '
        'dtpdate
        '
        Me.dtpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdate.Location = New System.Drawing.Point(19, 33)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(108, 26)
        Me.dtpdate.TabIndex = 4
        '
        'btnpay
        '
        Me.btnpay.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnpay.Location = New System.Drawing.Point(719, 32)
        Me.btnpay.Name = "btnpay"
        Me.btnpay.Size = New System.Drawing.Size(128, 21)
        Me.btnpay.TabIndex = 3
        Me.btnpay.Text = "&Pay Selected Items"
        Me.btnpay.UseVisualStyleBackColor = False
        '
        'btnlocate
        '
        Me.btnlocate.Location = New System.Drawing.Point(249, 25)
        Me.btnlocate.Name = "btnlocate"
        Me.btnlocate.Size = New System.Drawing.Size(110, 28)
        Me.btnlocate.TabIndex = 2
        Me.btnlocate.Text = "Locate Charges"
        Me.btnlocate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clients Name"
        '
        'cmbdesc
        '
        Me.cmbdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdesc.FormattingEnabled = True
        Me.cmbdesc.Location = New System.Drawing.Point(12, 25)
        Me.cmbdesc.Name = "cmbdesc"
        Me.cmbdesc.Size = New System.Drawing.Size(231, 28)
        Me.cmbdesc.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 126)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtgmain)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtgitem)
        Me.SplitContainer1.Size = New System.Drawing.Size(1068, 369)
        Me.SplitContainer1.SplitterDistance = 513
        Me.SplitContainer1.TabIndex = 1
        '
        'dtgmain
        '
        Me.dtgmain.AllowUserToAddRows = False
        Me.dtgmain.AllowUserToDeleteRows = False
        Me.dtgmain.BackgroundColor = System.Drawing.Color.White
        Me.dtgmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgmain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.cb, Me.Column2, Me.Column3, Me.Column9})
        Me.dtgmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgmain.Location = New System.Drawing.Point(0, 0)
        Me.dtgmain.Name = "dtgmain"
        Me.dtgmain.RowHeadersVisible = False
        Me.dtgmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgmain.Size = New System.Drawing.Size(513, 369)
        Me.dtgmain.TabIndex = 0
        '
        'dtgitem
        '
        Me.dtgitem.AllowUserToAddRows = False
        Me.dtgitem.AllowUserToDeleteRows = False
        Me.dtgitem.BackgroundColor = System.Drawing.Color.White
        Me.dtgitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgitem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pk, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column11, Me.Column12})
        Me.dtgitem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgitem.Location = New System.Drawing.Point(0, 0)
        Me.dtgitem.Name = "dtgitem"
        Me.dtgitem.RowHeadersVisible = False
        Me.dtgitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgitem.Size = New System.Drawing.Size(551, 369)
        Me.dtgitem.TabIndex = 1
        '
        'pk
        '
        Me.pk.HeaderText = "pk"
        Me.pk.Name = "pk"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Description"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.HeaderText = "Price"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 60
        '
        'Column6
        '
        Me.Column6.HeaderText = "Qty"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 60
        '
        'Column7
        '
        Me.Column7.HeaderText = "Amount"
        Me.Column7.Name = "Column7"
        '
        'Column11
        '
        Me.Column11.HeaderText = "cost"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "payment"
        Me.Column12.Name = "Column12"
        '
        'Column8
        '
        Me.Column8.HeaderText = "chk"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        '
        'cb
        '
        Me.cb.HeaderText = "DR No."
        Me.cb.Name = "cb"
        '
        'Column2
        '
        Me.Column2.HeaderText = "QTY"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "Amount"
        Me.Column3.Name = "Column3"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Paid Amount"
        Me.Column9.Name = "Column9"
        '
        'frmcollectionrec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 495)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GradientPanelXP1)
        Me.Name = "frmcollectionrec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Collection"
        Me.GradientPanelXP1.ResumeLayout(False)
        Me.GradientPanelXP1.PerformLayout()
        Me.Pay.ResumeLayout(False)
        Me.Pay.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtgmain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgitem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientPanelXP1 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents btnlocate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbdesc As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dtgmain As System.Windows.Forms.DataGridView
    Friend WithEvents dtgitem As System.Windows.Forms.DataGridView
    Friend WithEvents btnpay As System.Windows.Forms.Button
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Pay As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents pk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcheckno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtrem As System.Windows.Forms.TextBox
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
