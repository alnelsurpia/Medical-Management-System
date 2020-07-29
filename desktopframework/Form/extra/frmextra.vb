Public Class frmextra

    Private Sub cmbpopulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpopulate.Click
        populaterebateitems()
    End Sub
    Private Sub populaterebateitems()
        dtgitm.Rows.Clear()
        Dim strSELECT As String = ""
        strSELECT = "SELECT * FROM tbltrmain"
        tabledrebate(strSELECT)
    End Sub
    Private Sub tabledrebate(ByVal strq As String)
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strq
        DReader.ReadData()
        Dim a As Integer = 0
        Do While DReader.nelReader.Read
            With dtgitm
                .Rows.Add()
                .Item(0, a).Value = DReader.nelReader.Item("pk")
                .Item(1, a).Value = DReader.nelReader.Item("itemcode")
                .Item(2, a).Value = DReader.nelReader.Item("descripition")
                '.Item(3, a).Value = DReader.nelReader.Item("descripition")
            End With
            a = a + 1
        Loop
        DReader.nelReader.Close()
        locateamout()
        'lbltotal.Text = FormatNumber(SumItUp(dtgpritems, 7), 2)
    End Sub
    Private Sub locateamout()
        Dim rCnt As Integer = dtgitm.RowCount - 1
        Dim a As Integer
        Dim itemcode As String = ""
        Dim pk As String = ""
        With dtgitm
            For a = 0 To rCnt
                itemcode = .Item(1, a).Value
                Populatehour("SELECT category from tblitemlist where itemcode = '" & itemcode & "'")
                .Item(3, a).Value = catpop
            Next a
        End With
    End Sub

    Private Sub cmbcalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcalc.Click
        copycat()
    End Sub
    Private Sub copycat()
        Dim rCnt As Integer = dtgitm.RowCount - 1
        Dim a As Integer
        Dim itemcode As String = ""
        Dim pk As String = ""
        Dim cat As String = ""
        With dtgitm
            For a = 0 To rCnt
                itemcode = .Item(1, a).Value
                cat = .Item(3, a).Value
                savecat(itemcode, cat)
            Next a
            MessageBox.Show("Done!")
        End With
    End Sub
    Private Sub savecat(ByVal itemcode As String, ByVal cat1 As String)
        Dim dtData As New clsDataManipulation
        dtData.strSELECT = "SELECT * FROM tbltrmain WHERE itemcode = '" & itemcode & "'"
        dtData.strUpdate = "UPDATE tbltrmain SET " _
            & " cat ='" & cat1 & "'" _
            & " WHERE itemcode ='" & itemcode & "'"
        dtData.strAdd = "SELECT * FROM tbltrmain"
        dtData.Save()
    End Sub

    Private Sub frmextra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class