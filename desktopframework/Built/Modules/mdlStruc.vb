Module mdlStruc

    Public Structure ItemInfo
        Dim ItemID As String
        Dim ItemName As String
        Dim Itemcode As String

        Public Sub New(ByVal _ItemID As String, ByVal _ItemName As String)
            'store these values
            ItemID = _ItemID
            ItemName = _ItemName
        End Sub

        Public Sub New(ByVal _ItemID As String, ByVal _ItemName As String, ByVal _Itemcode As String)
            'store these values
            ItemID = _ItemID
            ItemName = _ItemName
            Itemcode = _Itemcode
        End Sub

        Public Overrides Function ToString() As String
            Return Me.ItemName
        End Function
    End Structure


    Public Structure SupplierInfo
        Dim Suppliername As String
        Dim SupplierNo As String
        Dim SupplierAddress As String
        Dim SalesMan As String
        Dim fourth As String
        Dim cat As String
        Dim classification As String
        Dim unitbx As String
        Dim unitpcs As String
        Dim pcsprice As String
        Dim pcscost As String
        Dim bcost As String
        Dim tsize As String
        Dim brefdesc As String
        Dim category As String

        Public Sub New(ByVal _Suppliername As String, ByVal _Supplierno As String)
            Suppliername = _Suppliername
            SupplierNo = _Supplierno
        End Sub

        Public Sub New(ByVal _Suppliername As String, ByVal _Supplierno As String, ByVal _SupplierAddress As String)
            Suppliername = _Suppliername
            SupplierNo = _Supplierno
            SupplierAddress = _SupplierAddress
        End Sub

        Public Sub New(ByVal _Suppliername As String, ByVal _Supplierno As String, _
        ByVal _SupplierAddress As String, ByVal _SalesMan As String)
            Suppliername = _Suppliername
            SupplierNo = _Supplierno
            SupplierAddress = _SupplierAddress
            SalesMan = _SalesMan
        End Sub
        Public Sub New(ByVal _Suppliername As String, ByVal _Supplierno As String, _
       ByVal _SupplierAddress As String, ByVal _SalesMan As String, ByVal _fourth As String)
            Suppliername = _Suppliername
            SupplierNo = _Supplierno
            SupplierAddress = _SupplierAddress
            SalesMan = _SalesMan
            fourth = _fourth
        End Sub
        Public Sub New(ByVal _Suppliername As String, ByVal _Supplierno As String, _
    ByVal _SupplierAddress As String, ByVal _SalesMan As String, ByVal _fourth As String, _
     ByVal _cat As String)
            Suppliername = _Suppliername
            SupplierNo = _Supplierno
            SupplierAddress = _SupplierAddress
            SalesMan = _SalesMan
            fourth = _fourth
            cat = _cat
        End Sub
        Public Sub New(ByVal _Suppliername As String, ByVal _Supplierno As String, _
      ByVal _SupplierAddress As String, ByVal _SalesMan As String, ByVal _fourth As String, _
       ByVal _cat As String, ByVal _classification As String)
            Suppliername = _Suppliername
            SupplierNo = _Supplierno
            SupplierAddress = _SupplierAddress
            SalesMan = _SalesMan
            fourth = _fourth
            cat = _cat
            classification = _classification
        End Sub




        Public Sub New(ByVal _Suppliername As String, _
                       ByVal _Supplierno As String, _
                        ByVal _SupplierAddress As String, _
                        ByVal _SalesMan As String, _
                        ByVal _fourth As String, _
                        ByVal _cat As String, _
                        ByVal _classification As String, _
                        ByVal _unitbx As String, _
                        ByVal _unitpcs As String, _
                        ByVal _pcsprice As String, _
                        ByVal _pcscost As String, _
                        ByVal _bcost As String)
            Suppliername = _Suppliername
            SupplierNo = _Supplierno
            SupplierAddress = _SupplierAddress
            SalesMan = _SalesMan
            fourth = _fourth
            cat = _cat
            classification = _classification
            unitbx = _unitbx
            unitpcs = _unitpcs
            pcsprice = _pcsprice
            pcscost = _pcscost
            bcost = _bcost
        End Sub
        Public Sub New(ByVal _Suppliername As String, _
                       ByVal _Supplierno As String, _
                        ByVal _SupplierAddress As String, _
                        ByVal _SalesMan As String, _
                        ByVal _fourth As String, _
                        ByVal _cat As String, _
                        ByVal _classification As String, _
                        ByVal _unitbx As String, _
                        ByVal _unitpcs As String, _
                        ByVal _pcsprice As String, _
                        ByVal _pcscost As String)
            Suppliername = _Suppliername
            SupplierNo = _Supplierno
            SupplierAddress = _SupplierAddress
            SalesMan = _SalesMan
            fourth = _fourth
            cat = _cat
            classification = _classification
            unitbx = _unitbx
            unitpcs = _unitpcs
            pcsprice = _pcsprice
            pcscost = _pcscost
        End Sub
        Public Sub New(ByVal _Suppliername As String, _
                       ByVal _Supplierno As String, _
                        ByVal _SupplierAddress As String, _
                        ByVal _SalesMan As String, _
                        ByVal _fourth As String, _
                        ByVal _cat As String, _
                        ByVal _classification As String, _
                        ByVal _unitbx As String, _
                        ByVal _unitpcs As String, _
                        ByVal _pcsprice As String)
            Suppliername = _Suppliername
            SupplierNo = _Supplierno
            SupplierAddress = _SupplierAddress
            SalesMan = _SalesMan
            fourth = _fourth
            cat = _cat
            classification = _classification
            unitbx = _unitbx
            unitpcs = _unitpcs
            pcsprice = _pcsprice
        End Sub
        Public Sub New(ByVal _Suppliername As String, _
                       ByVal _Supplierno As String, _
                        ByVal _SupplierAddress As String, _
                        ByVal _SalesMan As String, _
                        ByVal _fourth As String, _
                        ByVal _cat As String, _
                        ByVal _classification As String, _
                        ByVal _unitbx As String, _
                        ByVal _unitpcs As String)
            Suppliername = _Suppliername
            SupplierNo = _Supplierno
            SupplierAddress = _SupplierAddress
            SalesMan = _SalesMan
            fourth = _fourth
            cat = _cat
            classification = _classification
            unitbx = _unitbx
            unitpcs = _unitpcs
        End Sub
        Public Sub New(ByVal _Suppliername As String, _
                       ByVal _Supplierno As String, _
                        ByVal _SupplierAddress As String, _
                        ByVal _SalesMan As String, _
                        ByVal _fourth As String, _
                        ByVal _cat As String, _
                        ByVal _classification As String, _
                        ByVal _unitbx As String)
            Suppliername = _Suppliername
            SupplierNo = _Supplierno
            SupplierAddress = _SupplierAddress
            SalesMan = _SalesMan
            fourth = _fourth
            cat = _cat
            classification = _classification
            unitbx = _unitbx
        End Sub
        '13 data
        Public Sub New(ByVal _Suppliername As String, _
                      ByVal _Supplierno As String, _
                       ByVal _SupplierAddress As String, _
                       ByVal _SalesMan As String, _
                       ByVal _fourth As String, _
                       ByVal _cat As String, _
                       ByVal _classification As String, _
                       ByVal _unitbx As String, _
                       ByVal _unitpcs As String, _
                       ByVal _pcsprice As String, _
                       ByVal _pcscost As String, _
                       ByVal _bcost As String, _
                       ByVal _tsize As String)
            Suppliername = _Suppliername
            SupplierNo = _Supplierno
            SupplierAddress = _SupplierAddress
            SalesMan = _SalesMan
            fourth = _fourth
            cat = _cat
            classification = _classification
            unitbx = _unitbx
            unitpcs = _unitpcs
            pcsprice = _pcsprice
            pcscost = _pcscost
            bcost = _bcost
            tsize = _tsize
        End Sub
        Public Sub New(ByVal _Suppliername As String, _
                     ByVal _Supplierno As String, _
                      ByVal _SupplierAddress As String, _
                      ByVal _SalesMan As String, _
                      ByVal _fourth As String, _
                      ByVal _cat As String, _
                      ByVal _classification As String, _
                      ByVal _unitbx As String, _
                      ByVal _unitpcs As String, _
                      ByVal _pcsprice As String, _
                      ByVal _pcscost As String, _
                      ByVal _bcost As String, _
                      ByVal _tsize As String, _
                      ByVal _brefdesc As String)
            Suppliername = _Suppliername
            SupplierNo = _Supplierno
            SupplierAddress = _SupplierAddress
            SalesMan = _SalesMan
            fourth = _fourth
            cat = _cat
            classification = _classification
            unitbx = _unitbx
            unitpcs = _unitpcs
            pcsprice = _pcsprice
            pcscost = _pcscost
            bcost = _bcost
            tsize = _tsize
            brefdesc = _brefdesc
        End Sub
        Public Sub New(ByVal _Suppliername As String, _
                   ByVal _Supplierno As String, _
                    ByVal _SupplierAddress As String, _
                    ByVal _SalesMan As String, _
                    ByVal _fourth As String, _
                    ByVal _cat As String, _
                    ByVal _classification As String, _
                    ByVal _unitbx As String, _
                    ByVal _unitpcs As String, _
                    ByVal _pcsprice As String, _
                    ByVal _pcscost As String, _
                    ByVal _bcost As String, _
                    ByVal _tsize As String, _
                    ByVal _brefdesc As String, ByVal _category As String)
            Suppliername = _Suppliername
            SupplierNo = _Supplierno
            SupplierAddress = _SupplierAddress
            SalesMan = _SalesMan
            fourth = _fourth
            cat = _cat
            classification = _classification
            unitbx = _unitbx
            unitpcs = _unitpcs
            pcsprice = _pcsprice
            pcscost = _pcscost
            bcost = _bcost
            tsize = _tsize
            brefdesc = _brefdesc
            category = _category
        End Sub
        Public Overrides Function ToString() As String
            Return Me.Suppliername
        End Function
    End Structure

    Public Structure CustomerInfo
        Dim CustomerName As String
        Dim CustomerAddress As String
        'Dim at As Integer

        Public Sub New(ByVal _CustomerName As String, ByVal _CustomerAddress As String)
            'store these values
            'at = _at
            CustomerName = _CustomerName
            CustomerAddress = _CustomerAddress
        End Sub

        Public Overrides Function ToString() As String
            Return Me.CustomerName
        End Function
    End Structure


    Public Structure BranchInfo
        Dim BranchName As String
        Dim BranchCode As String
        'Dim at As Integer

        Public Sub New(ByVal _BranchCode As String, ByVal _BranchName As String)
            'store these values
            'at = _at
            BranchName = _BranchName
            BranchCode = _BranchCode
        End Sub

        Public Overrides Function ToString() As String
            Return Me.BranchName
        End Function
    End Structure


    Public Structure MenuInfo
        Dim MenuID As String
        Dim MenuName As String
        Dim itemID As String
        Dim itemName As String

        Public Sub New(ByVal _MenuID As String, ByVal _MenuName As String, ByVal _itemID As String, ByVal _itemName As String)
            'store these values
            MenuID = _MenuID
            MenuName = _MenuName
            itemID = _itemID
            itemName = _itemName
        End Sub

        Public Overrides Function ToString() As String
            Return Me.MenuName
        End Function
    End Structure
End Module
