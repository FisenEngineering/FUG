Public Class ClsCustomCoil
    Private pCoilStyle As String
    Private pReheatCapacity As String
    Private pCstmCoilAF As String
    Private pEATDB As String
    Private pLATDB As String
    Private pRefType As String
    Private pRefPD As String
    Private pInCon As String
    Private pOutCon As String
    Private pFluidFlow As String
    Public Property FluidFlow As String
        Get
            FluidFlow = pFluidFlow
        End Get
        Set(value As String)
            pFluidFlow = value
        End Set
    End Property
    Public Property InletConn As String
        Get
            InletConn = pInCon
        End Get
        Set(value As String)
            pInCon = value
        End Set
    End Property
    Public Property OutletConn As String
        Get
            OutletConn = pOutCon
        End Get
        Set(value As String)
            pOutCon = value
        End Set
    End Property
    Public Property CoilStyle As String
        Get
            CoilStyle = pCoilStyle
        End Get
        Set(value As String)
            pCoilStyle = value
        End Set
    End Property
    Public Property ReheatCapacity As String
        Get
            ReheatCapacity = Format(Val(pReheatCapacity), "0.0")
        End Get
        Set(value As String)
            pReheatCapacity = value
        End Set
    End Property
    Public Property CstmCoilAirflow As String
        Get
            CstmCoilAirflow = Format(Val(pCstmCoilAF), "0")
        End Get
        Set(value As String)
            pCstmCoilAF = value
        End Set
    End Property
    Public Property EATDB As String
        Get
            EATDB = Format(Val(pEATDB), "0.0")
        End Get
        Set(value As String)
            pEATDB = value
        End Set
    End Property
    Public Property LATDB As String
        Get
            LATDB = Format(Val(pLATDB), "0.0")
        End Get
        Set(value As String)
            pLATDB = value
        End Set
    End Property
    Public ReadOnly Property DeltaT As String
        Get
            DeltaT = Trim(Str(Val(LATDB) - Val(EATDB)))
        End Get
    End Property
    Public Property RefType As String
        Get
            RefType = pRefType
        End Get
        Set(value As String)
            pRefType = value
        End Set
    End Property
    Public Property RefPD As String
        Get
            RefPD = Format(Val(pRefPD), "0.0")
        End Get
        Set(value As String)
            pRefPD = value
        End Set
    End Property
    Public Sub New()
        pCoilStyle = "None"
        pReheatCapacity = "0.0"
        pCstmCoilAF = "0"
        pEATDB = "70.0"
        pLATDB = "67.0"
        pRefType = "R410-A"
        pRefPD = "0.0"
        pInCon = "-"
        pOutCon = "-"
    End Sub
End Class
