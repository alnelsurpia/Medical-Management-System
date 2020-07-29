Imports WeifenLuo.WinFormsUI.Docking
Imports System.IO
Public Class frmuploaded
    Inherits DockContent
    Private Sub frmuploaded_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateCombo(txttrno, "Select trno from tbltrmain group by trno asc")
        PopulateCombo(txttype, "Select ttype from tblimages group by ttype asc")
        PopulateItem()
        'PopulateCombo(txtdescription, "Select ttype tblimages group by ttype")
    End Sub
    Public Sub LoadMemberPic()
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = "Select * From tblimages Where trno = '" & txttrno.Text & "' and ttype like '%" & txttype.Text & "%' and description like '%" & txtdescription.Text & "%'"
        DReader.ReadData()
        'On Error Resume Next

        If DReader.nelReader.Read Then
            Try
                Dim arrImage() As Byte = CType(DReader.nelReader.Item("trimage"), Byte())
                If arrImage.Length <> 0 Then
                    'Dim arrImage1() As Byte = CType(DReader.JayDataReader.Item("autpic"), Byte())
                    Dim ms As New MemoryStream(arrImage)
                    primage.Image = Image.FromStream(ms)
                Else
                    primage.BackgroundImage = My.Resources.noimage3
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                'MessageBox.Show("Error has uccured")
            End Try
        Else
            primage.BackgroundImage = My.Resources.noimage3
        End If
        DReader.nelReader.Close()
    End Sub
    Private Sub cmdaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddnew.Click
        gpup.Visible = True
        gpup.Text = "Upload"
        gpup.BackColor = Color.Transparent
        cmdok.Text = "Upload"
    End Sub

    Private Sub HoverGradientButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsearch.Click
        gpup.Visible = True
        gpup.Text = "Search"
        gpup.BackColor = Color.AliceBlue
        cmdok.Text = "Search"
    End Sub

    Private Sub cmbprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprint.Click
        trimage = txttrno.Text
        frmimageprint.Close()
        frmimageprint.Show(frmmain.DockPanel1)
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        If cmdok.Text = "Upload" Then
            loadimage()
        Else
            LoadMemberPic()
        End If
    End Sub
    Private Sub loadimage()
        Dim d As New OpenFileDialog
        d.Filter = "All Files|*.*|All Image File|*.jpg,*.gif,*.bmp|Jpeg File|*.jpg" _
        & "|GIF Image|*.gif|Bitmap File|*.bmp"
        d.ShowDialog()
        If d.FileName.Trim <> "" Then
            Dim p As New FileStream(d.FileName, FileMode.Open, FileAccess.Read)
            '.Item(11, a).Value = Image.FromStream(ms)
            ' Dim i As Integer = dtg1.SelectedCells(0).RowIndex
            primage.Image = System.Drawing.Image.FromStream(p)
            'dtg1.SelectedRows(0).Cells(11).Value = 
        End If
    End Sub
    Private Sub CallMemberPicture()
        Try
            Dim strSELECT As String = "SELECT * FROM tblimages WHERE Trno like '%" & txttrno.Text & "%' and ttype like '%" & txttype.Text & "%' and description like '%" & txtdescription.Text & "%'"
            Dim dtData As New clsDataManipulation
            dtData.strSELECT = strSELECT

            dtData.IDGenSave = True

            Dim DReader As New DataClassReader
            DReader.strSELECTSQL = strSELECT
            DReader.ReadData()
            Dim strDataExe As String = ""
            If DReader.nelReader.Read Then
                strDataExe = "UPDATE tblimages SET " _
                & " trimage =?picsd , description = '" & txtdescription.Text & "',ttype = '" & txttype.Text & "',trno = '" & txttrno.Text & "', " _
                & " dateuploaded = '" & Now.ToShortDateString & "' " _
                & " WHERE trno ='" & txttrno.Text & "' and ttype = '" & txttype.Text & "' and description = '" & txtdescription.Text & "'"
            Else
                strDataExe = "INSERT INTO tblimages(trimage,description,ttype,trno,dateuploaded) " _
                & " VALUES(?picsd,'" & txtdescription.Text & "','" & txttype.Text & "','" & txttrno.Text & "','" & Now.ToShortDateString & "')"
            End If
            DReader.nelReader.Close()
            dtData.Save(primage, strDataExe)
            MessageBox.Show("Saved")
        Catch
            MessageBox.Show("Saved Failed Check the input try saving again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If txtdescription.Text <> "" Then
            CallMemberPicture()
            PopulateItem()
            'updatebiddinglist()
        Else
            MessageBox.Show("No Description")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txttrno.Text = ""
        txttrno.Text = ""
        txtdescription.Text = ""
        txttrno.Focus()
    End Sub

    Private Sub cmbclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clearthis()
    End Sub
    Private Sub clearthis()
        txttrno.Text = ""
        txttype.Text = ""
        txtdescription.Text = ""
        primage.BackgroundImage = My.Resources.noimage3
        primage.Image = My.Resources.noimage3
    End Sub
    Private Sub PopulateItem()
        dtglistimg.Rows.Clear()
        'dtgmenu.Columns.Clear()
        Dim strSELECT As String = ""
        'Dim dfrm As String = dtpfrom.Text
        'Dim dto As String = dtpto.Text
        strSELECT = "SELECT * FROM tblimages order by pk asc"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtglistimg
              
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("ttype")
                .Item(1, a).Value = DReader.nelReader.Item("description")
            End With

            a = a + 1
        Loop
        DReader.nelReader.Close()
    End Sub

    Private Sub dtglistimg_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglistimg.CellClick
        With dtglistimg.SelectedRows(0)
            txttrno.Text = .Cells(0).Value
            txttype.Text = .Cells(1).Value
            txtdescription.Text = .Cells(2).Value
            LoadMemberPic()
        End With
    End Sub

    Private Sub dtglistimg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglistimg.CellContentClick

    End Sub
End Class