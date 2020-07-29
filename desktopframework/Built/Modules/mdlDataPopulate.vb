Module mdlDataPopulate
    Public Sub PopulateCombo(ByVal cboData As ComboBox, ByVal strSELECT As String)
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        cboData.Items.Clear()
        With DReader.nelReader
            Do While .Read
                cboData.Items.Add(.Item(0))
            Loop
            .Close()
        End With
    End Sub

    Public Sub PopulateCombo(ByVal cboData As ComboBox, ByVal cboData1 As ComboBox, ByVal strSELECT As String)
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        cboData.Items.Clear()
        cboData1.Items.Clear()
        With DReader.nelReader
            Do While .Read
                cboData.Items.Add(.Item(0))
                cboData1.Items.Add(.Item(0))
            Loop
            .Close()
        End With
    End Sub
    Public Sub Populategetsum(ByVal strSELECT As String)
        Dim DReader As New DataClassReader
        Dim holder As Double = 0
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        With DReader.nelReader
            'sumcollector = .Item(0)
            Do While .Read
                holder = holder + .Item(0)
            Loop
            sumcollector = holder
            .Close()
        End With
    End Sub
    Public Sub Populatehour(ByVal strSELECT As String)
        'catpop = "0"
        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSELECT
        DReader.ReadData()
        With DReader.NelReader
            Do While .Read
                catpop = .Item(0).ToString
            Loop
            .Close()

        End With
    End Sub

    Public Sub PopulateComboStructure(ByVal cboData As ComboBox, ByVal strSQL As String)

        Dim DReader As New DataClassReader
        DReader.strSELECTSQL = strSQL
        DReader.ReadData()
        cboData.Items.Clear()
        With DReader.nelReader
            Do While .Read
                cboData.Items.Add(New ItemInfo(.Item(0).ToString, .Item(1).ToString))
            Loop
            .Close()
        End With
    End Sub

End Module
