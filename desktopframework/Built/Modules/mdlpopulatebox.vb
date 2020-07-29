Module mdlpopulatebox
    'Public Sub populategridmdl()
    '    frminbox.dtg1.Rows.Clear()
    '    'dtgmenu.Columns.Clear()
    '    Dim strSELECT As String = ""
    '    'Dim dfrm As String = dtpfrom.Text
    '    'Dim dto As String = dtpto.Text
    '    strSELECT = "SELECT * FROM tbljoborderdetails where msgread = 'Pending' and destination like '" & P_username & "'  order by STR_TO_DATE(tbljoborderdetails.dateCompletion, '%m/%d/%Y') asc"
    '    Dim DReader As New DataClassReader
    '    DReader.strSELECTSQL = strSELECT
    '    DReader.ReadData()
    '    Dim a As Integer = 0
    '    Do While DReader.nelReader.Read
    '        With frminbox.dtg1
    '            .Rows.Add()
    '            .Item(0, a).Value = DReader.nelReader.Item("jobno")
    '            .Item(1, a).Value = DReader.nelReader.Item("jobdesc")
    '            .Item(2, a).Value = DReader.nelReader.Item("customername")
    '            .Item(3, a).Value = DReader.nelReader.Item("jo_T")
    '            .Item(4, a).Value = DReader.nelReader.Item("tdate")
    '            .Item(5, a).Value = DReader.nelReader.Item("dateCompletion")
    '        End With
    '        frminbox.Label4.Text = a + 1
    '        a = a + 1
    '    Loop
    '    DReader.nelReader.Close()
    'End Sub

    'Public Sub PlayRingTone()

    '    If My.Settings.ringtonepath.ToString = "" Then
    '        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
    '    Else
    '        Try
    '            My.Computer.Audio.Play(My.Settings.ringtonepath)
    '        Catch
    '            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
    '        End Try
    '    End If

    '    'My.Computer.Audio.Play(My.Resources.youhavemail.ToString)
    '    'My.Computer.Audio.Play(
    '    'My.Computer.Audio.Play(
    '    'My.Computer.Audio.Play("", AudioPlayMode.Background)
    'End Sub

    'Public Sub populategridhistory()
    '    frmhistory.dtg1.Rows.Clear()
    '    'dtgmenu.Columns.Clear()
    '    Dim strSELECT As String = ""
    '    'Dim dfrm As String = dtpfrom.Text
    '    'Dim dto As String = dtpto.Text
    '    strSELECT = "SELECT * FROM tbljohndlerhistory where jonumber like '%" & selectedhistoryjo & "%' order by STR_TO_DATE(tbljohndlerhistory.tdate, '%m/%d/%Y'),personhandled asc"
    '    Dim DReader As New DataClassReader
    '    DReader.strSELECTSQL = strSELECT
    '    DReader.ReadData()
    '    Dim a As Integer = 0
    '    Do While DReader.nelReader.Read
    '        With frmhistory.dtg1
    '            .Rows.Add()
    '            .Item(0, a).Value = DReader.nelReader.Item("jonumber")
    '            .Item(1, a).Value = DReader.nelReader.Item("ttype")
    '            .Item(2, a).Value = DReader.nelReader.Item("ttime")
    '            .Item(3, a).Value = DReader.nelReader.Item("tdate")
    '            .Item(4, a).Value = DReader.nelReader.Item("department")
    '            .Item(5, a).Value = DReader.nelReader.Item("personhandled")
    '        End With
    '        frmhistory.lblcustname.Text = a + 1
    '        a = a + 1
    '    Loop
    '    DReader.nelReader.Close()
    'End Sub
End Module
