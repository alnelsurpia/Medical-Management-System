Public Class frmUser

    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim iDark As New clsDressUp.clsDarkDress
        Dim iLight As New clsDressUp.clsLightDress

        iDark.DressUp(GradientPanelXP1)
        iLight.DressUp(GradientPanelXP2)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = False

        'dtData.IDGenSave = True
        'dtData.IDGenCode = "CL"
        'dtData.IDGenValue = txtUsername.Text

        dtData.strSELECT = "SELECT * FROM tblsec WHERE " _
        & " tusername='" & txtUsername.Text & "'"
        dtData.strUpdate = "UPDATE tblsec SET tpassword='" & txtPassword.Text & "' " _
            & " WHERE tusername='" & txtUsername.Text & "'"
        dtData.strAdd = "INSERT INTO tblsec(tusername, tpassword) " _
        & " VALUES('" & txtUsername.Text & "','" & txtPassword.Text & "')"
        dtData.Save()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim dtData As New clsDataManipulation
        dtData.IDGenSave = False

        dtData.strSELECT = "SELECT * FROM tblsec WHERE " _
        & " tusername='" & txtUsername.Text & "'"
        dtData.strDELETE = "DELETE FROM tblsec  " _
            & " WHERE tusername='" & txtUsername.Text & "'"
        dtData.DELETE()
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = "SELECT * FROM tblsec WHERE " _
        & " tusername='" & txtUsername.Text & "'"
        DReader.ReadData()
        If DReader.nelReader.Read Then
            txtPassword.Text = DReader.nelReader.Item("tpassword")
        Else
            'error traping
        End If
        DReader.nelReader.Close()
    End Sub
End Class