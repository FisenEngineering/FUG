Public Class ClsERW
    Private pContainsERW As Boolean
    Private pERWhp As String
    Private pERWVolts As String
    Private pERWModelNumber As String
    Private pSFStaticOAHood As String
    Private pSFStaticMetalFilt As String
    Private pSFStaticOADamp As String
    Private pSFStaticOAFilt As String
    Private pSFStaticERW As String
    Private pSFStaticTrans As String
    Private pSFStaticCabFX As String
    Private pSFStaticTotal As String
    Private pRXFStaticRAOpening As String
    Private pRXFStaticSafetyGrate As String
    Private pRXFStaticRAFilt As String
    Private pRXFStaticERW As String
    Private pRXFStaticHWCloth As String
    Private pRXFStaticReliefDamp As String
    Private pRXFStaticReliefHood As String
    Private pRXFStaticTrans As String
    Private pRXFStaticCabFX As String
    Private pRXFStaticTotal As String

    Private pSupplyAFSummer1 As String
    Private pOAAFSummer1 As String
    Private pOATdbSummer1 As String
    Private pOATwbSummer1 As String
    Private pReturnAFSummer1 As String
    Private pRATdbSummer1 As String
    Private pRATwbSummer1 As String
    Private pSupplyAFSummer2 As String
    Private pOAAFSummer2 As String
    Private pOATdbSummer2 As String
    Private pOATwbSummer2 As String
    Private pReturnAFSummer2 As String
    Private pRATdbSummer2 As String
    Private pRATwbSummer2 As String
    Private pSupplyAFWinter1 As String
    Private pOAAFWinter1 As String
    Private pOATdbWinter1 As String
    Private pOATwbWinter1 As String
    Private pReturnAFWinter1 As String
    Private pRATdbWinter1 As String
    Private pRATwbWinter1 As String
    Private pSupplyAFWinter2 As String
    Private pOAAFWinter2 As String
    Private pOATdbWinter2 As String
    Private pOATwbWinter2 As String
    Private pReturnAFWinter2 As String
    Private pRATdbWinter2 As String
    Private pRATwbWinter2 As String
    Private pSupplyAFWinterFF As String
    Private pOAAFWinterFF As String
    Private pOATdbWinterFF As String
    Private pOATwbWinterFF As String
    Private pReturnAFWinterFF As String
    Private pRATdbWinterFF As String
    Private pRATwbWinterFF As String

    Private pPerfSAAFlowS1 As String
    Private pPerfSATempdbS1 As String
    Private pPerfSATempwbS1 As String
    Private pPerfXATempdbS1 As String
    Private pPerfXATempwbS1 As String
    Private pPerfXAAFlowS1 As String
    Private pPerfSensEffS1 As String
    Private pPerfLatEffS1 As String
    Private pPerfTotEffS1 As String
    Private pPerfSAAFlowS2 As String
    Private pPerfSATempdbS2 As String
    Private pPerfSATempwbS2 As String
    Private pPerfXATempdbS2 As String
    Private pPerfXATempwbS2 As String
    Private pPerfXAAFlowS2 As String
    Private pPerfSensEffS2 As String
    Private pPerfLatEffS2 As String
    Private pPerfTotEffS2 As String
    Private pPerfSAAFlowW1 As String
    Private pPerfSATempdbW1 As String
    Private pPerfSATempwbW1 As String
    Private pPerfXATempdbW1 As String
    Private pPerfXATempwbW1 As String
    Private pPerfXAAFlowW1 As String
    Private pPerfSensEffW1 As String
    Private pPerfLatEffW1 As String
    Private pPerfTotEffW1 As String
    Private pPerfSAAFlowW2 As String
    Private pPerfSATempdbW2 As String
    Private pPerfSATempwbW2 As String
    Private pPerfXATempdbW2 As String
    Private pPerfXATempwbW2 As String
    Private pPerfXAAFlowW2 As String
    Private pPerfSensEffW2 As String
    Private pPerfLatEffW2 As String
    Private pPerfTotEffW2 As String
    Private pPerfSAAFlowWFF As String
    Private pPerfSATempdbWFF As String
    Private pPerfSATempwbWFF As String
    Private pPerfXATempdbWFF As String
    Private pPerfXATempwbWFF As String
    Private pPerfXAAFlowWFF As String
    Private pPerfSensEffWFF As String
    Private pPerfLatEffWFF As String
    Private pPerfTotEffWFF As String

    Private pMixPerfS1WLFlow As String
    Private pMixPerfS1WLdb As String
    Private pMixPerfS1WLwb As String
    Private pMixPerfS1RAFlow As String
    Private pMixPerfS1RAdb As String
    Private pMixPerfS1RAwb As String
    Private pMixPerfS1MixFlow As String
    Private pMixPerfS1MAdb As String
    Private pMixPerfS1MAwb As String
    Private pMixPerfS2WLFlow As String
    Private pMixPerfS2WLdb As String
    Private pMixPerfS2WLwb As String
    Private pMixPerfS2RAFlow As String
    Private pMixPerfS2RAdb As String
    Private pMixPerfS2RAwb As String
    Private pMixPerfS2MixFlow As String
    Private pMixPerfS2MAdb As String
    Private pMixPerfS2MAwb As String
    Private pMixPerfW1WLFlow As String
    Private pMixPerfW1WLdb As String
    Private pMixPerfW1WLwb As String
    Private pMixPerfW1RAFlow As String
    Private pMixPerfW1RAdb As String
    Private pMixPerfW1RAwb As String
    Private pMixPerfW1MixFlow As String
    Private pMixPerfW1MAdb As String
    Private pMixPerfW1MAwb As String
    Private pMixPerfW2WLFlow As String
    Private pMixPerfW2WLdb As String
    Private pMixPerfW2WLwb As String
    Private pMixPerfW2RAFlow As String
    Private pMixPerfW2RAdb As String
    Private pMixPerfW2RAwb As String
    Private pMixPerfW2MixFlow As String
    Private pMixPerfW2MAdb As String
    Private pMixPerfW2MAwb As String
    Private pMixPerfWFFWLFlow As String
    Private pMixPerfWFFWLdb As String
    Private pMixPerfWFFWLwb As String
    Private pMixPerfWFFRAFlow As String
    Private pMixPerfWFFRAdb As String
    Private pMixPerfWFFRAwb As String
    Private pMixPerfWFFMixFlow As String
    Private pMixPerfWFFMAdb As String
    Private pMixPerfWFFMAwb As String

    Public Property SFStaticOAHood As String
        Get
            SFStaticOAHood = pSFStaticOAHood
        End Get
        Set(value As String)
            pSFStaticOAHood = value
        End Set
    End Property
    Public Property SFStaticMetalFilt As String
        Get
            SFStaticMetalFilt = pSFStaticMetalFilt
        End Get
        Set(value As String)
            pSFStaticMetalFilt = value
        End Set
    End Property
    Public Property SFStaticOADamp As String
        Get
            SFStaticOADamp = pSFStaticOADamp
        End Get
        Set(value As String)
            pSFStaticOADamp = value
        End Set
    End Property
    Public Property SFStaticOAFilt As String
        Get
            SFStaticOAFilt = pSFStaticOAFilt
        End Get
        Set(value As String)
            pSFStaticOAFilt = value
        End Set
    End Property
    Public Property SFStaticERW As String
        Get
            SFStaticERW = pSFStaticERW
        End Get
        Set(value As String)
            pSFStaticERW = value
        End Set
    End Property
    Public Property SFStaticTrans As String
        Get
            SFStaticTrans = pSFStaticTrans
        End Get
        Set(value As String)
            pSFStaticTrans = value
        End Set
    End Property
    Public Property SFStaticCabFX As String
        Get
            SFStaticCabFX = pSFStaticCabFX
        End Get
        Set(value As String)
            pSFStaticCabFX = value
        End Set
    End Property
    Public Property SFStaticTotal As String
        Get
            SFStaticTotal = pSFStaticTotal
        End Get
        Set(value As String)
            pSFStaticTotal = value
        End Set
    End Property

    Public Property RXFStaticRAOpening As String
        Get
            RXFStaticRAOpening = pRXFStaticRAOpening
        End Get
        Set(value As String)
            pRXFStaticRAOpening = value
        End Set
    End Property
    Public Property RXFStaticSafetyGrate As String
        Get
            RXFStaticSafetyGrate = pRXFStaticSafetyGrate
        End Get
        Set(value As String)
            pRXFStaticSafetyGrate = value
        End Set
    End Property
    Public Property RXFStaticRAFilt As String
        Get
            RXFStaticRAFilt = pRXFStaticRAFilt
        End Get
        Set(value As String)
            pRXFStaticRAFilt = value
        End Set
    End Property
    Public Property RXFStaticERW As String
        Get
            RXFStaticERW = pRXFStaticERW
        End Get
        Set(value As String)
            pRXFStaticERW = value
        End Set
    End Property
    Public Property RXFStaticHWCloth As String
        Get
            RXFStaticHWCloth = pRXFStaticHWCloth
        End Get
        Set(value As String)
            pRXFStaticHWCloth = value
        End Set
    End Property
    Public Property RXFStaticReliefDamp As String
        Get
            RXFStaticReliefDamp = pRXFStaticReliefDamp
        End Get
        Set(value As String)
            pRXFStaticReliefDamp = value
        End Set
    End Property
    Public Property RXFStaticReliefHood As String
        Get
            RXFStaticReliefHood = pRXFStaticReliefHood
        End Get
        Set(value As String)
            pRXFStaticReliefHood = value
        End Set
    End Property
    Public Property RXFStaticTrans As String
        Get
            RXFStaticTrans = pRXFStaticTrans
        End Get
        Set(value As String)
            pRXFStaticTrans = value
        End Set
    End Property
    Public Property RXFStaticCabFX As String
        Get
            RXFStaticCabFX = pRXFStaticCabFX
        End Get
        Set(value As String)
            pRXFStaticCabFX = value
        End Set
    End Property
    Public Property RXFStaticTotal As String
        Get
            RXFStaticTotal = pRXFStaticTotal
        End Get
        Set(value As String)
            pRXFStaticTotal = value
        End Set
    End Property

    Public Property SupplyAFSummer1 As String
        Get
            SupplyAFSummer1 = pSupplyAFSummer1
        End Get
        Set(value As String)
            pSupplyAFSummer1 = value
        End Set
    End Property
    Public Property OAAFSummer1 As String
        Get
            OAAFSummer1 = pOAAFSummer1
        End Get
        Set(value As String)
            pOAAFSummer1 = value
        End Set
    End Property
    Public Property OATdbSummer1 As String
        Get
            OATdbSummer1 = pOATdbSummer1
        End Get
        Set(value As String)
            pOATdbSummer1 = value
        End Set
    End Property
    Public Property OATwbSummer1 As String
        Get
            OATwbSummer1 = pOATwbSummer1
        End Get
        Set(value As String)
            pOATwbSummer1 = value
        End Set
    End Property
    Public Property ReturnAFSummer1 As String
        Get
            ReturnAFSummer1 = pReturnAFSummer1
        End Get
        Set(value As String)
            pReturnAFSummer1 = value
        End Set
    End Property
    Public Property RATdbSummer1 As String
        Get
            RATdbSummer1 = pRATdbSummer1
        End Get
        Set(value As String)
            pRATdbSummer1 = value
        End Set
    End Property
    Public Property RATwbSummer1 As String
        Get
            RATwbSummer1 = pRATwbSummer1
        End Get
        Set(value As String)
            pRATwbSummer1 = value
        End Set
    End Property
    Public Property SupplyAFSummer2 As String
        Get
            SupplyAFSummer2 = pSupplyAFSummer2
        End Get
        Set(value As String)
            pSupplyAFSummer2 = value
        End Set
    End Property
    Public Property OAAFSummer2 As String
        Get
            OAAFSummer2 = pOAAFSummer2
        End Get
        Set(value As String)
            pOAAFSummer2 = value
        End Set
    End Property
    Public Property OATdbSummer2 As String
        Get
            OATdbSummer2 = pOATdbSummer2
        End Get
        Set(value As String)
            pOATdbSummer2 = value
        End Set
    End Property
    Public Property OATwbSummer2 As String
        Get
            OATwbSummer2 = pOATwbSummer2
        End Get
        Set(value As String)
            pOATwbSummer2 = value
        End Set
    End Property
    Public Property ReturnAFSummer2 As String
        Get
            ReturnAFSummer2 = pReturnAFSummer2
        End Get
        Set(value As String)
            pReturnAFSummer2 = value
        End Set
    End Property
    Public Property RATdbSummer2 As String
        Get
            RATdbSummer2 = pRATdbSummer2
        End Get
        Set(value As String)
            pRATdbSummer2 = value
        End Set
    End Property
    Public Property RATwbSummer2 As String
        Get
            RATwbSummer2 = pRATwbSummer2
        End Get
        Set(value As String)
            pRATwbSummer2 = value
        End Set
    End Property

    Public Property SupplyAFWinter1 As String
        Get
            SupplyAFWinter1 = pSupplyAFWinter1
        End Get
        Set(value As String)
            pSupplyAFWinter1 = value
        End Set
    End Property
    Public Property OAAFWinter1 As String
        Get
            OAAFWinter1 = pOAAFWinter1
        End Get
        Set(value As String)
            pOAAFWinter1 = value
        End Set
    End Property
    Public Property OATdbWinter1 As String
        Get
            OATdbWinter1 = pOATdbWinter1
        End Get
        Set(value As String)
            pOATdbWinter1 = value
        End Set
    End Property
    Public Property OATwbWinter1 As String
        Get
            OATwbWinter1 = pOATwbWinter1
        End Get
        Set(value As String)
            pOATwbWinter1 = value
        End Set
    End Property
    Public Property ReturnAFWinter1 As String
        Get
            ReturnAFWinter1 = pReturnAFWinter1
        End Get
        Set(value As String)
            pReturnAFWinter1 = value
        End Set
    End Property
    Public Property RATdbWinter1 As String
        Get
            RATdbWinter1 = pRATdbWinter1
        End Get
        Set(value As String)
            pRATdbWinter1 = value
        End Set
    End Property
    Public Property RATwbWinter1 As String
        Get
            RATwbWinter1 = pRATwbWinter1
        End Get
        Set(value As String)
            pRATwbWinter1 = value
        End Set
    End Property
    Public Property SupplyAFWinter2 As String
        Get
            SupplyAFWinter2 = pSupplyAFWinter2
        End Get
        Set(value As String)
            pSupplyAFWinter2 = value
        End Set
    End Property
    Public Property OAAFWinter2 As String
        Get
            OAAFWinter2 = pOAAFWinter2
        End Get
        Set(value As String)
            pOAAFWinter2 = value
        End Set
    End Property
    Public Property OATdbWinter2 As String
        Get
            OATdbWinter2 = pOATdbWinter2
        End Get
        Set(value As String)
            pOATdbWinter2 = value
        End Set
    End Property
    Public Property OATwbWinter2 As String
        Get
            OATwbWinter2 = pOATwbWinter2
        End Get
        Set(value As String)
            pOATwbWinter2 = value
        End Set
    End Property
    Public Property ReturnAFWinter2 As String
        Get
            ReturnAFWinter2 = pReturnAFWinter2
        End Get
        Set(value As String)
            pReturnAFWinter2 = value
        End Set
    End Property
    Public Property RATdbWinter2 As String
        Get
            RATdbWinter2 = pRATdbWinter2
        End Get
        Set(value As String)
            pRATdbWinter2 = value
        End Set
    End Property
    Public Property RATwbWinter2 As String
        Get
            RATwbWinter2 = pRATwbWinter2
        End Get
        Set(value As String)
            pRATwbWinter2 = value
        End Set
    End Property

    Public Property SupplyAFWinterFF As String
        Get
            SupplyAFWinterFF = pSupplyAFWinterFF
        End Get
        Set(value As String)
            pSupplyAFWinterFF = value
        End Set
    End Property
    Public Property OAAFWinterFF As String
        Get
            OAAFWinterFF = pOAAFWinterFF
        End Get
        Set(value As String)
            pOAAFWinterFF = value
        End Set
    End Property
    Public Property OATdbWinterFF As String
        Get
            OATdbWinterFF = pOATdbWinterFF
        End Get
        Set(value As String)
            pOATdbWinterFF = value
        End Set
    End Property
    Public Property OATwbWinterFF As String
        Get
            OATwbWinterFF = pOATwbWinterFF
        End Get
        Set(value As String)
            pOATwbWinterFF = value
        End Set
    End Property
    Public Property ReturnAFWinterFF As String
        Get
            ReturnAFWinterFF = pReturnAFWinterFF
        End Get
        Set(value As String)
            pReturnAFWinterFF = value
        End Set
    End Property
    Public Property RATdbWinterFF As String
        Get
            RATdbWinterFF = pRATdbWinterFF
        End Get
        Set(value As String)
            pRATdbWinterFF = value
        End Set
    End Property
    Public Property RATwbWinterFF As String
        Get
            RATwbWinterFF = pRATwbWinterFF
        End Get
        Set(value As String)
            pRATwbWinterFF = value
        End Set
    End Property

    Public Property PerfSAAFlowS1 As String
        Get
            PerfSAAFlowS1 = pPerfSAAFlowS1
        End Get
        Set(value As String)
            pPerfSAAFlowS1 = value
        End Set
    End Property

    Public Property PerfSATempdbS1 As String
        Get
            PerfSATempdbS1 = pPerfSATempdbS1
        End Get
        Set(value As String)
            pPerfSATempdbS1 = value
        End Set
    End Property

    Public Property PerfSATempwbS1 As String
        Get
            PerfSATempwbS1 = pPerfSATempwbS1
        End Get
        Set(value As String)
            pPerfSATempwbS1 = value
        End Set
    End Property

    Public Property PerfXATempdbS1 As String
        Get
            PerfXATempdbS1 = pPerfXATempdbS1
        End Get
        Set(value As String)
            pPerfXATempdbS1 = value
        End Set
    End Property

    Public Property PerfXATempwbS1 As String
        Get
            PerfXATempwbS1 = pPerfXATempwbS1
        End Get
        Set(value As String)
            pPerfXATempwbS1 = value
        End Set
    End Property

    Public Property PerfXAAFlowS1 As String
        Get
            PerfXAAFlowS1 = pPerfXAAFlowS1
        End Get
        Set(value As String)
            pPerfXAAFlowS1 = value
        End Set
    End Property

    Public Property PerfSensEffS1 As String
        Get
            PerfSensEffS1 = pPerfSensEffS1
        End Get
        Set(value As String)
            pPerfSensEffS1 = value
        End Set
    End Property

    Public Property PerfLatEffS1 As String
        Get
            PerfLatEffS1 = pPerfLatEffS1
        End Get
        Set(value As String)
            pPerfLatEffS1 = value
        End Set
    End Property

    Public Property PerfTotEffS1 As String
        Get
            PerfTotEffS1 = pPerfTotEffS1
        End Get
        Set(value As String)
            pPerfTotEffS1 = value
        End Set
    End Property

    Public Property PerfSAAFlowS2 As String
        Get
            PerfSAAFlowS2 = pPerfSAAFlowS2
        End Get
        Set(value As String)
            pPerfSAAFlowS2 = value
        End Set
    End Property

    Public Property PerfSATempdbS2 As String
        Get
            PerfSATempdbS2 = pPerfSATempdbS2
        End Get
        Set(value As String)
            pPerfSATempdbS2 = value
        End Set
    End Property

    Public Property PerfSATempwbS2 As String
        Get
            PerfSATempwbS2 = pPerfSATempwbS2
        End Get
        Set(value As String)
            pPerfSATempwbS2 = value
        End Set
    End Property

    Public Property PerfXATempdbS2 As String
        Get
            PerfXATempdbS2 = pPerfXATempdbS2
        End Get
        Set(value As String)
            pPerfXATempdbS2 = value
        End Set
    End Property

    Public Property PerfXATempwbS2 As String
        Get
            PerfXATempwbS2 = pPerfXATempwbS2
        End Get
        Set(value As String)
            pPerfXATempwbS2 = value
        End Set
    End Property

    Public Property PerfXAAFlowS2 As String
        Get
            PerfXAAFlowS2 = pPerfXAAFlowS2
        End Get
        Set(value As String)
            pPerfXAAFlowS2 = value
        End Set
    End Property

    Public Property PerfSensEffS2 As String
        Get
            PerfSensEffS2 = pPerfSensEffS2
        End Get
        Set(value As String)
            pPerfSensEffS2 = value
        End Set
    End Property

    Public Property PerfLatEffS2 As String
        Get
            PerfLatEffS2 = pPerfLatEffS2
        End Get
        Set(value As String)
            pPerfLatEffS2 = value
        End Set
    End Property

    Public Property PerfTotEffS2 As String
        Get
            PerfTotEffS2 = pPerfTotEffS2
        End Get
        Set(value As String)
            pPerfTotEffS2 = value
        End Set
    End Property

    Public Property PerfSAAFlowW1 As String
        Get
            PerfSAAFlowW1 = pPerfSAAFlowW1
        End Get
        Set(value As String)
            pPerfSAAFlowW1 = value
        End Set
    End Property

    Public Property PerfSATempdbW1 As String
        Get
            PerfSATempdbW1 = pPerfSATempdbW1
        End Get
        Set(value As String)
            pPerfSATempdbW1 = value
        End Set
    End Property

    Public Property PerfSATempwbW1 As String
        Get
            PerfSATempwbW1 = pPerfSATempwbW1
        End Get
        Set(value As String)
            pPerfSATempwbW1 = value
        End Set
    End Property

    Public Property PerfXATempdbW1 As String
        Get
            PerfXATempdbW1 = pPerfXATempdbW1
        End Get
        Set(value As String)
            pPerfXATempdbW1 = value
        End Set
    End Property

    Public Property PerfXATempwbW1 As String
        Get
            PerfXATempwbW1 = pPerfXATempwbW1
        End Get
        Set(value As String)
            pPerfXATempwbW1 = value
        End Set
    End Property

    Public Property PerfXAAFlowW1 As String
        Get
            PerfXAAFlowW1 = pPerfXAAFlowW1
        End Get
        Set(value As String)
            pPerfXAAFlowW1 = value
        End Set
    End Property

    Public Property PerfSensEffW1 As String
        Get
            PerfSensEffW1 = pPerfSensEffW1
        End Get
        Set(value As String)
            pPerfSensEffW1 = value
        End Set
    End Property

    Public Property PerfLatEffW1 As String
        Get
            PerfLatEffW1 = pPerfLatEffW1
        End Get
        Set(value As String)
            pPerfLatEffW1 = value
        End Set
    End Property

    Public Property PerfTotEffW1 As String
        Get
            PerfTotEffW1 = pPerfTotEffW1
        End Get
        Set(value As String)
            pPerfTotEffW1 = value
        End Set
    End Property

    Public Property PerfSAAFlowW2 As String
        Get
            PerfSAAFlowW2 = pPerfSAAFlowW2
        End Get
        Set(value As String)
            pPerfSAAFlowW2 = value
        End Set
    End Property

    Public Property PerfSATempdbW2 As String
        Get
            PerfSATempdbW2 = pPerfSATempdbW2
        End Get
        Set(value As String)
            pPerfSATempdbW2 = value
        End Set
    End Property

    Public Property PerfSATempwbW2 As String
        Get
            PerfSATempwbW2 = pPerfSATempwbW2
        End Get
        Set(value As String)
            pPerfSATempwbW2 = value
        End Set
    End Property

    Public Property PerfXATempdbW2 As String
        Get
            PerfXATempdbW2 = pPerfXATempdbW2
        End Get
        Set(value As String)
            pPerfXATempdbW2 = value
        End Set
    End Property

    Public Property PerfXATempwbW2 As String
        Get
            PerfXATempwbW2 = pPerfXATempwbW2
        End Get
        Set(value As String)
            pPerfXATempwbW2 = value
        End Set
    End Property

    Public Property PerfXAAFlowW2 As String
        Get
            PerfXAAFlowW2 = pPerfXAAFlowW2
        End Get
        Set(value As String)
            pPerfXAAFlowW2 = value
        End Set
    End Property

    Public Property PerfSensEffW2 As String
        Get
            PerfSensEffW2 = pPerfSensEffW2
        End Get
        Set(value As String)
            pPerfSensEffW2 = value
        End Set
    End Property

    Public Property PerfLatEffW2 As String
        Get
            PerfLatEffW2 = pPerfLatEffW2
        End Get
        Set(value As String)
            pPerfLatEffW2 = value
        End Set
    End Property

    Public Property PerfTotEffW2 As String
        Get
            PerfTotEffW2 = pPerfTotEffW2
        End Get
        Set(value As String)
            pPerfTotEffW2 = value
        End Set
    End Property

    Public Property PerfSAAFlowWFF As String
        Get
            PerfSAAFlowWFF = pPerfSAAFlowWFF
        End Get
        Set(value As String)
            pPerfSAAFlowWFF = value
        End Set
    End Property

    Public Property PerfSATempdbWFF As String
        Get
            PerfSATempdbWFF = pPerfSATempdbWFF
        End Get
        Set(value As String)
            pPerfSATempdbWFF = value
        End Set
    End Property

    Public Property PerfSATempwbWFF As String
        Get
            PerfSATempwbWFF = pPerfSATempwbWFF
        End Get
        Set(value As String)
            pPerfSATempwbWFF = value
        End Set
    End Property

    Public Property PerfXATempdbWFF As String
        Get
            PerfXATempdbWFF = pPerfXATempdbWFF
        End Get
        Set(value As String)
            pPerfXATempdbWFF = value
        End Set
    End Property

    Public Property PerfXATempwbWFF As String
        Get
            PerfXATempwbWFF = pPerfXATempwbWFF
        End Get
        Set(value As String)
            pPerfXATempwbWFF = value
        End Set
    End Property

    Public Property PerfXAAFlowWFF As String
        Get
            PerfXAAFlowWFF = pPerfXAAFlowWFF
        End Get
        Set(value As String)
            pPerfXAAFlowWFF = value
        End Set
    End Property

    Public Property PerfSensEffWFF As String
        Get
            PerfSensEffWFF = pPerfSensEffWFF
        End Get
        Set(value As String)
            pPerfSensEffWFF = value
        End Set
    End Property

    Public Property PerfLatEffWFF As String
        Get
            PerfLatEffWFF = pPerfLatEffWFF
        End Get
        Set(value As String)
            pPerfLatEffWFF = value
        End Set
    End Property
    Public Property MixPerfS1WLFlow As String
        Get
            MixPerfS1WLFlow = pMixPerfS1WLFlow
        End Get
        Set(value As String)
            pMixPerfS1WLFlow = value
        End Set
    End Property

    Public Property MixPerfS1WLdb As String
        Get
            MixPerfS1WLdb = pMixPerfS1WLdb
        End Get
        Set(value As String)
            pMixPerfS1WLdb = value
        End Set
    End Property

    Public Property MixPerfS1WLwb As String
        Get
            MixPerfS1WLwb = pMixPerfS1WLwb
        End Get
        Set(value As String)
            pMixPerfS1WLwb = value
        End Set
    End Property

    Public Property MixPerfS1RAFlow As String
        Get
            MixPerfS1RAFlow = pMixPerfS1RAFlow
        End Get
        Set(value As String)
            pMixPerfS1RAFlow = value
        End Set
    End Property

    Public Property MixPerfS1RAdb As String
        Get
            MixPerfS1RAdb = pMixPerfS1RAdb
        End Get
        Set(value As String)
            pMixPerfS1RAdb = value
        End Set
    End Property

    Public Property MixPerfS1RAwb As String
        Get
            MixPerfS1RAwb = pMixPerfS1RAwb
        End Get
        Set(value As String)
            pMixPerfS1RAwb = value
        End Set
    End Property

    Public Property MixPerfS1MixFlow As String
        Get
            MixPerfS1MixFlow = pMixPerfS1MixFlow
        End Get
        Set(value As String)
            pMixPerfS1MixFlow = value
        End Set
    End Property

    Public Property MixPerfS1MAdb As String
        Get
            MixPerfS1MAdb = pMixPerfS1MAdb
        End Get
        Set(value As String)
            pMixPerfS1MAdb = value
        End Set
    End Property

    Public Property MixPerfS1MAwb As String
        Get
            MixPerfS1MAwb = pMixPerfS1MAwb
        End Get
        Set(value As String)
            pMixPerfS1MAwb = value
        End Set
    End Property

    Public Property MixPerfS2WLFlow As String
        Get
            MixPerfS2WLFlow = pMixPerfS2WLFlow
        End Get
        Set(value As String)
            pMixPerfS2WLFlow = value
        End Set
    End Property

    Public Property MixPerfS2WLdb As String
        Get
            MixPerfS2WLdb = pMixPerfS2WLdb
        End Get
        Set(value As String)
            pMixPerfS2WLdb = value
        End Set
    End Property

    Public Property MixPerfS2WLwb As String
        Get
            MixPerfS2WLwb = pMixPerfS2WLwb
        End Get
        Set(value As String)
            pMixPerfS2WLwb = value
        End Set
    End Property

    Public Property MixPerfS2RAFlow As String
        Get
            MixPerfS2RAFlow = pMixPerfS2RAFlow
        End Get
        Set(value As String)
            pMixPerfS2RAFlow = value
        End Set
    End Property

    Public Property MixPerfS2RAdb As String
        Get
            MixPerfS2RAdb = pMixPerfS2RAdb
        End Get
        Set(value As String)
            pMixPerfS2RAdb = value
        End Set
    End Property

    Public Property MixPerfS2RAwb As String
        Get
            MixPerfS2RAwb = pMixPerfS2RAwb
        End Get
        Set(value As String)
            pMixPerfS2RAwb = value
        End Set
    End Property

    Public Property MixPerfS2MixFlow As String
        Get
            MixPerfS2MixFlow = pMixPerfS2MixFlow
        End Get
        Set(value As String)
            pMixPerfS2MixFlow = value
        End Set
    End Property

    Public Property MixPerfS2MAdb As String
        Get
            MixPerfS2MAdb = pMixPerfS2MAdb
        End Get
        Set(value As String)
            pMixPerfS2MAdb = value
        End Set
    End Property

    Public Property MixPerfS2MAwb As String
        Get
            MixPerfS2MAwb = pMixPerfS2MAwb
        End Get
        Set(value As String)
            pMixPerfS2MAwb = value
        End Set
    End Property

    Public Property MixPerfW1WLFlow As String
        Get
            MixPerfW1WLFlow = pMixPerfW1WLFlow
        End Get
        Set(value As String)
            pMixPerfW1WLFlow = value
        End Set
    End Property

    Public Property MixPerfW1WLdb As String
        Get
            MixPerfW1WLdb = pMixPerfW1WLdb
        End Get
        Set(value As String)
            pMixPerfW1WLdb = value
        End Set
    End Property

    Public Property MixPerfW1WLwb As String
        Get
            MixPerfW1WLwb = pMixPerfW1WLwb
        End Get
        Set(value As String)
            pMixPerfW1WLwb = value
        End Set
    End Property

    Public Property MixPerfW1RAFlow As String
        Get
            MixPerfW1RAFlow = pMixPerfW1RAFlow
        End Get
        Set(value As String)
            pMixPerfW1RAFlow = value
        End Set
    End Property

    Public Property MixPerfW1RAdb As String
        Get
            MixPerfW1RAdb = pMixPerfW1RAdb
        End Get
        Set(value As String)
            pMixPerfW1RAdb = value
        End Set
    End Property

    Public Property MixPerfW1RAwb As String
        Get
            MixPerfW1RAwb = pMixPerfW1RAwb
        End Get
        Set(value As String)
            pMixPerfW1RAwb = value
        End Set
    End Property

    Public Property MixPerfW1MixFlow As String
        Get
            MixPerfW1MixFlow = pMixPerfW1MixFlow
        End Get
        Set(value As String)
            pMixPerfW1MixFlow = value
        End Set
    End Property

    Public Property MixPerfW1MAdb As String
        Get
            MixPerfW1MAdb = pMixPerfW1MAdb
        End Get
        Set(value As String)
            pMixPerfW1MAdb = value
        End Set
    End Property

    Public Property MixPerfW1MAwb As String
        Get
            MixPerfW1MAwb = pMixPerfW1MAwb
        End Get
        Set(value As String)
            pMixPerfW1MAwb = value
        End Set
    End Property

    Public Property MixPerfW2WLFlow As String
        Get
            MixPerfW2WLFlow = pMixPerfW2WLFlow
        End Get
        Set(value As String)
            pMixPerfW2WLFlow = value
        End Set
    End Property

    Public Property MixPerfW2WLdb As String
        Get
            MixPerfW2WLdb = pMixPerfW2WLdb
        End Get
        Set(value As String)
            pMixPerfW2WLdb = value
        End Set
    End Property

    Public Property MixPerfW2WLwb As String
        Get
            MixPerfW2WLwb = pMixPerfW2WLwb
        End Get
        Set(value As String)
            pMixPerfW2WLwb = value
        End Set
    End Property

    Public Property MixPerfW2RAFlow As String
        Get
            MixPerfW2RAFlow = pMixPerfW2RAFlow
        End Get
        Set(value As String)
            pMixPerfW2RAFlow = value
        End Set
    End Property

    Public Property MixPerfW2RAdb As String
        Get
            MixPerfW2RAdb = pMixPerfW2RAdb
        End Get
        Set(value As String)
            pMixPerfW2RAdb = value
        End Set
    End Property

    Public Property MixPerfW2RAwb As String
        Get
            MixPerfW2RAwb = pMixPerfW2RAwb
        End Get
        Set(value As String)
            pMixPerfW2RAwb = value
        End Set
    End Property

    Public Property MixPerfW2MixFlow As String
        Get
            MixPerfW2MixFlow = pMixPerfW2MixFlow
        End Get
        Set(value As String)
            pMixPerfW2MixFlow = value
        End Set
    End Property

    Public Property MixPerfW2MAdb As String
        Get
            MixPerfW2MAdb = pMixPerfW2MAdb
        End Get
        Set(value As String)
            pMixPerfW2MAdb = value
        End Set
    End Property

    Public Property MixPerfW2MAwb As String
        Get
            MixPerfW2MAwb = pMixPerfW2MAwb
        End Get
        Set(value As String)
            pMixPerfW2MAwb = value
        End Set
    End Property

    Public Property MixPerfWFFWLFlow As String
        Get
            MixPerfWFFWLFlow = pMixPerfWFFWLFlow
        End Get
        Set(value As String)
            pMixPerfWFFWLFlow = value
        End Set
    End Property

    Public Property MixPerfWFFWLdb As String
        Get
            MixPerfWFFWLdb = pMixPerfWFFWLdb
        End Get
        Set(value As String)
            pMixPerfWFFWLdb = value
        End Set
    End Property

    Public Property MixPerfWFFWLwb As String
        Get
            MixPerfWFFWLwb = pMixPerfWFFWLwb
        End Get
        Set(value As String)
            pMixPerfWFFWLwb = value
        End Set
    End Property

    Public Property MixPerfWFFRAFlow As String
        Get
            MixPerfWFFRAFlow = pMixPerfWFFRAFlow
        End Get
        Set(value As String)
            pMixPerfWFFRAFlow = value
        End Set
    End Property

    Public Property MixPerfWFFRAdb As String
        Get
            MixPerfWFFRAdb = pMixPerfWFFRAdb
        End Get
        Set(value As String)
            pMixPerfWFFRAdb = value
        End Set
    End Property

    Public Property MixPerfWFFRAwb As String
        Get
            MixPerfWFFRAwb = pMixPerfWFFRAwb
        End Get
        Set(value As String)
            pMixPerfWFFRAwb = value
        End Set
    End Property

    Public Property MixPerfWFFMixFlow As String
        Get
            MixPerfWFFMixFlow = pMixPerfWFFMixFlow
        End Get
        Set(value As String)
            pMixPerfWFFMixFlow = value
        End Set
    End Property

    Public Property MixPerfWFFMAdb As String
        Get
            MixPerfWFFMAdb = pMixPerfWFFMAdb
        End Get
        Set(value As String)
            pMixPerfWFFMAdb = value
        End Set
    End Property

    Public Property MixPerfWFFMAwb As String
        Get
            MixPerfWFFMAwb = pMixPerfWFFMAwb
        End Get
        Set(value As String)
            pMixPerfWFFMAwb = value
        End Set
    End Property



    Public Property PerfTotEffWFF As String
        Get
            PerfTotEffWFF = pPerfTotEffWFF
        End Get
        Set(value As String)
            pPerfTotEffWFF = value
        End Set
    End Property
    Public Sub New()
        pContainsERW = False
        pERWVolts = "460"
        pERWhp = "0"
        pERWModelNumber = "ZZZ-ZZ-ZZZZ"
        pSFStaticCabFX = "0.00"
        pSFStaticMetalFilt = "0.00"
        pSFStaticOADamp = "0.00"
        pSFStaticOAFilt = "0.00"
        pSFStaticERW = "0.00"
        pSFStaticTrans = "0.00"
        pSFStaticCabFX = "0.00"
        pSFStaticTotal = "0.00"
        pRXFStaticRAOpening = "0.00"
        pRXFStaticSafetyGrate = "0.00"
        pRXFStaticRAFilt = "0.00"
        pRXFStaticHWCloth = "0.00"
        pRXFStaticReliefDamp = "0.00"
        pRXFStaticReliefHood = "0.00"
        pRXFStaticTrans = "0.00"
        pRXFStaticCabFX = "0.00"
        pRXFStaticTotal = "0.00"

        pSupplyAFSummer1 = "0.00"
        pOAAFSummer1 = "0.00"
        pOATdbSummer1 = "0.00"
        pOATwbSummer1 = "0.00"
        pReturnAFSummer1 = "0.00"
        pRATdbSummer1 = "0.00"
        pRATwbSummer1 = "0.00"
        pSupplyAFSummer2 = "0.00"
        pOAAFSummer2 = "0.00"
        pOATdbSummer2 = "0.00"
        pOATwbSummer2 = "0.00"
        pReturnAFSummer2 = "0.00"
        pRATdbSummer2 = "0.00"
        pRATwbSummer2 = "0.00"
        pSupplyAFWinter1 = "0.00"
        pOAAFWinter1 = "0.00"
        pOATdbWinter1 = "0.00"
        pOATwbWinter1 = "0.00"
        pReturnAFWinter1 = "0.00"
        pRATdbWinter1 = "0.00"
        pRATwbWinter1 = "0.00"
        pSupplyAFWinter2 = "0.00"
        pOAAFWinter2 = "0.00"
        pOATdbWinter2 = "0.00"
        pOATwbWinter2 = "0.00"
        pReturnAFWinter2 = "0.00"
        pRATdbWinter2 = "0.00"
        pRATwbWinter2 = "0.00"
        pSupplyAFWinterFF = "0.00"
        pOAAFWinterFF = "0.00"
        pOATdbWinterFF = "0.00"
        pOATwbWinterFF = "0.00"
        pReturnAFWinterFF = "0.00"
        pRATdbWinterFF = "0.00"
        pRATwbWinterFF = "0.00"

    End Sub








    Public Property ERW_ModelNumber As String
        Get
            ERW_ModelNumber = pERWModelNumber
        End Get
        Set(value As String)
            pERWModelNumber = value
        End Set
    End Property
    Public Property ERW_hp As String
        Get
            ERW_hp = pERWhp
        End Get
        Set(value As String)
            pERWhp = value
        End Set
    End Property

    Public Property ERW_Voltage
        Get
            ERW_Voltage = pERWVolts
        End Get
        Set(value)
            pERWVolts = value
        End Set
    End Property


    Public Property ContainsERW As Boolean
        Get
            ContainsERW = pContainsERW
        End Get
        Set(value As Boolean)
            pContainsERW = value
        End Set
    End Property


End Class
