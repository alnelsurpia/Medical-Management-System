<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOR
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbstat = New System.Windows.Forms.ComboBox
        Me.GradientPanelXP1 = New Lybra.Forms.Controls.GradientPanelXP
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtoramount = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdscan = New System.Windows.Forms.Button
        Me.txtor = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtcheckamnt = New System.Windows.Forms.TextBox
        Me.txtcheckno = New System.Windows.Forms.TextBox
        Me.txtdate = New System.Windows.Forms.DateTimePicker
        Me.GradientPanelXP2 = New Lybra.Forms.Controls.GradientPanelXP
        Me.dtpchkdate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbbank = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GradientPanelXP1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(397, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Status"
        '
        'cmbstat
        '
        Me.cmbstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstat.FormattingEnabled = True
        Me.cmbstat.Items.AddRange(New Object() {"Pending", "Collected"})
        Me.cmbstat.Location = New System.Drawing.Point(397, 19)
        Me.cmbstat.Name = "cmbstat"
        Me.cmbstat.Size = New System.Drawing.Size(106, 24)
        Me.cmbstat.TabIndex = 8
        Me.cmbstat.Text = "Collected"
        '
        'GradientPanelXP1
        '
        Me.GradientPanelXP1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GradientPanelXP1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP1.Controls.Add(Me.Label8)
        Me.GradientPanelXP1.Controls.Add(Me.cmbbank)
        Me.GradientPanelXP1.Controls.Add(Me.dtpchkdate)
        Me.GradientPanelXP1.Controls.Add(Me.Label7)
        Me.GradientPanelXP1.Controls.Add(Me.GradientPanelXP2)
        Me.GradientPanelXP1.Controls.Add(Me.txtdate)
        Me.GradientPanelXP1.Controls.Add(Me.txtcheckamnt)
        Me.GradientPanelXP1.Controls.Add(Me.txtcheckno)
        Me.GradientPanelXP1.Controls.Add(Me.Label6)
        Me.GradientPanelXP1.Controls.Add(Me.Label5)
        Me.GradientPanelXP1.Controls.Add(Me.Label4)
        Me.GradientPanelXP1.Controls.Add(Me.cmbstat)
        Me.GradientPanelXP1.Controls.Add(Me.Label3)
        Me.GradientPanelXP1.Controls.Add(Me.txtoramount)
        Me.GradientPanelXP1.Controls.Add(Me.Button1)
        Me.GradientPanelXP1.Controls.Add(Me.Label2)
        Me.GradientPanelXP1.Controls.Add(Me.Label1)
        Me.GradientPanelXP1.Controls.Add(Me.cmdscan)
        Me.GradientPanelXP1.Controls.Add(Me.txtor)
        Me.GradientPanelXP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanelXP1.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanelXP1.Name = "GradientPanelXP1"
        Me.GradientPanelXP1.Size = New System.Drawing.Size(510, 134)
        Me.GradientPanelXP1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(260, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "OR Amount"
        '
        'txtoramount
        '
        Me.txtoramount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoramount.Location = New System.Drawing.Point(263, 17)
        Me.txtoramount.Name = "txtoramount"
        Me.txtoramount.Size = New System.Drawing.Size(128, 26)
        Me.txtoramount.TabIndex = 6
        Me.txtoramount.Text = "0"
        Me.txtoramount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(438, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(151, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(14, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "OR Number"
        '
        'cmdscan
        '
        Me.cmdscan.Location = New System.Drawing.Point(377, 102)
        Me.cmdscan.Name = "cmdscan"
        Me.cmdscan.Size = New System.Drawing.Size(62, 29)
        Me.cmdscan.TabIndex = 2
        Me.cmdscan.Text = "S&can"
        Me.cmdscan.UseVisualStyleBackColor = True
        '
        'txtor
        '
        Me.txtor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtor.Location = New System.Drawing.Point(17, 18)
        Me.txtor.Name = "txtor"
        Me.txtor.Size = New System.Drawing.Size(128, 23)
        Me.txtor.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(182, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Check #"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(286, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Check Amount"
        '
        'txtcheckamnt
        '
        Me.txtcheckamnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcheckamnt.Location = New System.Drawing.Point(294, 73)
        Me.txtcheckamnt.Name = "txtcheckamnt"
        Me.txtcheckamnt.Size = New System.Drawing.Size(103, 23)
        Me.txtcheckamnt.TabIndex = 13
        '
        'txtcheckno
        '
        Me.txtcheckno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcheckno.Location = New System.Drawing.Point(185, 73)
        Me.txtcheckno.Name = "txtcheckno"
        Me.txtcheckno.Size = New System.Drawing.Size(98, 23)
        Me.txtcheckno.TabIndex = 12
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdate.Location = New System.Drawing.Point(154, 18)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(103, 23)
        Me.txtdate.TabIndex = 14
        '
        'GradientPanelXP2
        '
        Me.GradientPanelXP2.BackColor1 = System.Drawing.Color.Red
        Me.GradientPanelXP2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GradientPanelXP2.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GradientPanelXP2.Location = New System.Drawing.Point(17, 47)
        Me.GradientPanelXP2.Name = "GradientPanelXP2"
        Me.GradientPanelXP2.Size = New System.Drawing.Size(480, 3)
        Me.GradientPanelXP2.TabIndex = 15
        '
        'dtpchkdate
        '
        Me.dtpchkdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpchkdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpchkdate.Location = New System.Drawing.Point(403, 73)
        Me.dtpchkdate.Name = "dtpchkdate"
        Me.dtpchkdate.Size = New System.Drawing.Size(103, 23)
        Me.dtpchkdate.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(400, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Check Date"
        '
        'cmbbank
        '
        Me.cmbbank.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbank.FormattingEnabled = True
        Me.cmbbank.Location = New System.Drawing.Point(17, 73)
        Me.cmbbank.Name = "cmbbank"
        Me.cmbbank.Size = New System.Drawing.Size(162, 23)
        Me.cmbbank.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(14, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Bank Name"
        '
        'frmOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 134)
        Me.Controls.Add(Me.GradientPanelXP1)
        Me.Name = "frmOR"
        Me.Text = "Official Reciept Details"
        Me.GradientPanelXP1.ResumeLayout(False)
        Me.GradientPanelXP1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbstat As System.Windows.Forms.ComboBox
    Friend WithEvents GradientPanelXP1 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtoramount As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdscan As System.Windows.Forms.Button
    Friend WithEvents txtor As System.Windows.Forms.TextBox
    Friend WithEvents txtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcheckamnt As System.Windows.Forms.TextBox
    Friend WithEvents txtcheckno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpchkdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GradientPanelXP2 As Lybra.Forms.Controls.GradientPanelXP
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbbank As System.Windows.Forms.ComboBox
End Class
