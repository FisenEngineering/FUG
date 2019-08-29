Imports System.Xml
Imports System.Xml.Serialization

Public Class clsChillerMainPerf
    Private pNomTons As String
    Private pNetCap As String
    Private pEWT As String
    Private pLWT As String
    Private pFlow As String
    Private pVol As String
    Private pMinFlow As String
    Private pMaxFlow As String
    Private pAmbient As String
    Private pAlt As String
    Private pEER As String
    Private pNPLV As String
    Private pRigMass As String
    Private pOpMass As String
    Private pBaseFluidMass As String
    Private pRefChg As String
    Private pFluid As String
    Private pFluidPercent As String
    Private pFoulFactor As String
    Private pMinAmbient As String
    Private pCompType As String
    Private pElecDesc As String
    Private pRefrigerant As String
    Private pPINA As String
    Private pPINB As String
    Private pPINC As String
    Private pPIND As String
    Private pPINE As String
    Private pPINF As String
    Private pPING As String
    Private pPINH As String
    Private pPINI As String
    Private pElec As String
    Private pFanCount As String
    Private pCkt1BigCompRLA As String
    Private pCkt2BigCompRLA As String
    Private pCkt3BigCompRLA As String
    Private pCkt4BigCompRLA As String
    Private pCkt1CompRLA As New ArrayList
    Private pCkt2CompRLA As New ArrayList
    Private pCkt1CompLRA As New ArrayList
    Private pCkt2CompLRA As New ArrayList
    Private pCkt1FansQ As String
    Private pCkt1FansFLA As String
    Private pCkt2FansQ As String
    Private pCkt2FansFLA As String
    Private pCkt3FansQ As String
    Private pCkt3FansFLA As String
    Private pCkt4FansQ As String
    Private pCkt4FansFLA As String
    Private pMCA As String


    Private pPLRStage As New ArrayList
    Private pPLRAmbient As New ArrayList
    Private pPLRCapacity As New ArrayList
    Private pPLRTotalkW As New ArrayList
    Private pPLREfficiency As New ArrayList
    Private pHz63 As New ArrayList
    Private pHz125 As New ArrayList
    Private pHz250 As New ArrayList
    Private pHz500 As New ArrayList
    Private pHz1 As New ArrayList
    Private pHz2 As New ArrayList
    Private pHz4 As New ArrayList
    Private pHz8 As New ArrayList
    Private pHzLpA As New ArrayList
    Private pSoundTableTitle As String
    Private pNumPass As String
    Private pNotes As String

    Private pAHRIEWT As String
    Private pAHRILWT As String
    Private pAHRIFlow As String
    Private pAHRITPD As String
    Private pAHRIFluid As String
    Private pAHRIFoulFactor As String
    Private pAHRIVolume As String
    Private pAHRIAmbient As String
    Private pAHRIAltitude As String
    Private pAHRIEER As String
    Private pAHRINPLV As String
    Private pAHRICoolCap As String

    Private pFPD As String
    Private pEvapPD As String
    Private pStrainerPD As String
    Private pExtKitPD As String

    Public Property ExtKitPD As String
        Get
            ExtKitPD = pExtKitPD
        End Get
        Set(value As String)
            pExtKitPD = value
        End Set
    End Property

    Public Property StrainerPD As String
        Get
            StrainerPD = pStrainerPD
        End Get
        Set(value As String)
            pStrainerPD = value
        End Set
    End Property

    Public Property EvapPD As String
        Get
            EvapPD = pEvapPD
        End Get
        Set(value As String)
            pEvapPD = value
        End Set
    End Property
    Public Property AHRIEWT As String
        Get
            AHRIEWT = pAHRIEWT
        End Get
        Set(value As String)
            pAHRIEWT = value
        End Set
    End Property
    Public Property AHRILWT As String
        Get
            AHRILWT = pAHRILWT
        End Get
        Set(value As String)
            pAHRILWT = value
        End Set
    End Property
    Public Property AHRIFlow As String
        Get
            AHRIFlow = pAHRIFlow
        End Get
        Set(value As String)
            pAHRIFlow = value
        End Set
    End Property
    Public Property AHRITPD As String
        Get
            AHRITPD = pAHRITPD
        End Get
        Set(value As String)
            pAHRITPD = value
        End Set
    End Property
    Public Property AHRIFluid As String
        Get
            AHRIFluid = pAHRIFluid
        End Get
        Set(value As String)
            pAHRIFluid = value
        End Set
    End Property
    Public Property AHRIFoulFactor As String
        Get
            AHRIFoulFactor = pAHRIFoulFactor
        End Get
        Set(value As String)
            pAHRIFoulFactor = value
        End Set
    End Property
    Public Property AHRIVolume As String
        Get
            AHRIVolume = pAHRIVolume
        End Get
        Set(value As String)
            pAHRIVolume = value
        End Set
    End Property
    Public Property AHRIAmbient As String
        Get
            AHRIAmbient = pAHRIAmbient
        End Get
        Set(value As String)
            pAHRIAmbient = value
        End Set
    End Property
    Public Property AHRIAltitude As String
        Get
            AHRIAltitude = pAHRIAltitude
        End Get
        Set(value As String)
            pAHRIAltitude = value
        End Set
    End Property
    Public Property AHRIEER As String
        Get
            AHRIEER = pAHRIEER
        End Get
        Set(value As String)
            pAHRIEER = value
        End Set
    End Property
    Public Property AHRINPLV As String
        Get
            AHRINPLV = pAHRINPLV
        End Get
        Set(value As String)
            pAHRINPLV = value
        End Set
    End Property
    Public Property AHRICoolCap As String
        Get
            AHRICoolCap = pAHRICoolCap
        End Get
        Set(value As String)
            pAHRICoolCap = value
        End Set
    End Property
    Public Property Notes As String
        Get
            Notes = pNotes
        End Get
        Set(value As String)
            pNotes = value
        End Set
    End Property
    Public Property NumPass As String
        Get
            Return pNumPass
        End Get
        Set(value As String)
            pNumPass = value
        End Set
    End Property

    Public ReadOnly Property BaseFluidMass As String
        Get
            Return pBaseFluidMass
        End Get
    End Property

    Public Property SoundTableTitle As String
        Get
            Return pSoundTableTitle
        End Get
        Set(value As String)
            pSoundTableTitle = value
        End Set
    End Property

    Public Property Hz63 As ArrayList
        Get
            Return pHz63
        End Get
        Set(value As ArrayList)
            pHz63 = value
        End Set
    End Property
    Public Property Hz125 As ArrayList
        Get
            Return pHz125
        End Get
        Set(value As ArrayList)
            pHz125 = value
        End Set
    End Property
    Public Property Hz250 As ArrayList
        Get
            Return pHz250
        End Get
        Set(value As ArrayList)
            pHz250 = value
        End Set
    End Property
    Public Property Hz500 As ArrayList
        Get
            Return pHz500
        End Get
        Set(value As ArrayList)
            pHz500 = value
        End Set
    End Property
    Public Property Hz1 As ArrayList
        Get
            Return pHz1
        End Get
        Set(value As ArrayList)
            pHz1 = value
        End Set
    End Property
    Public Property Hz2 As ArrayList
        Get
            Return pHz2
        End Get
        Set(value As ArrayList)
            pHz2 = value
        End Set
    End Property
    Public Property Hz4 As ArrayList
        Get
            Return pHz4
        End Get
        Set(value As ArrayList)
            pHz4 = value
        End Set
    End Property
    Public Property Hz8 As ArrayList
        Get
            Return pHz8
        End Get
        Set(value As ArrayList)
            pHz8 = value
        End Set
    End Property
    Public Property HzLpA As ArrayList
        Get
            Return pHzLpA
        End Get
        Set(value As ArrayList)
            pHzLpA = value
        End Set
    End Property
    Public Property PLRStage As ArrayList
        Get
            Return pPLRStage
        End Get
        Set(value As ArrayList)
            pPLRStage = value
        End Set
    End Property
    Public Property PLRAmbient As ArrayList
        Get
            Return pPLRAmbient
        End Get
        Set(value As ArrayList)
            pPLRAmbient = value
        End Set
    End Property
    Public Property PLRCapacity As ArrayList
        Get
            Return pPLRCapacity
        End Get
        Set(value As ArrayList)
            pPLRCapacity = value
        End Set
    End Property
    Public Property PLRTotalkW As ArrayList
        Get
            Return pPLRTotalkW
        End Get
        Set(value As ArrayList)
            pPLRTotalkW = value
        End Set
    End Property
    Public Property PLREfficiency As ArrayList
        Get
            Return pPLREfficiency
        End Get
        Set(value As ArrayList)
            pPLREfficiency = value
        End Set
    End Property

    Public Property Ckt1CompRLA As ArrayList
        Get
            Return pCkt1CompRLA
        End Get
        Set(value As ArrayList)
            pCkt1CompRLA = value
        End Set
    End Property

    Public Property Ckt2CompRLA As ArrayList
        Get
            Return pCkt2CompRLA
        End Get
        Set(value As ArrayList)
            pCkt2CompRLA = value
        End Set
    End Property
    Public Property Ckt1CompLRA As ArrayList
        Get
            Return pCkt1CompLRA
        End Get
        Set(value As ArrayList)
            pCkt1CompLRA = value
        End Set
    End Property

    Public Property Ckt2CompLRA As ArrayList
        Get
            Return pCkt2CompLRA
        End Get
        Set(value As ArrayList)
            pCkt2CompLRA = value
        End Set
    End Property


    Property MCA As String
        Get
            If pMCA <> "-" Then
                MCA = Format(Val(pMCA), "0.0")
            Else
                MCA = "-"
            End If
        End Get
        Set(value As String)
            pMCA = value
        End Set
    End Property




    Property NominalTons As String
        Get
            NominalTons = Format(Val(pNomTons), "0.0")
        End Get
        Set(value As String)
            pNomTons = value
        End Set
    End Property
    Property NetCapacity As String
        Get
            NetCapacity = Format(Val(pNetCap), "0.0")
        End Get
        Set(value As String)
            pNetCap = value
        End Set
    End Property
    Property PINA As String
        Get
            PINA = pPINA
        End Get
        Set(value As String)
            pPINA = value
        End Set
    End Property
    Property PINB As String
        Get
            PINB = pPINB
        End Get
        Set(value As String)
            pPINB = value
        End Set
    End Property
    Property PINC As String
        Get
            PINC = pPINC
        End Get
        Set(value As String)
            pPINC = value
        End Set
    End Property
    Property PIND As String
        Get
            PIND = pPIND
        End Get
        Set(value As String)
            pPIND = value
        End Set
    End Property
    Property PINE As String
        Get
            PINE = pPINE
        End Get
        Set(value As String)
            pPINE = value
        End Set
    End Property
    Property PINF As String
        Get
            PINF = pPINF
        End Get
        Set(value As String)
            pPINF = value
        End Set
    End Property
    Property PING As String
        Get
            PING = pPING
        End Get
        Set(value As String)
            pPING = value
        End Set
    End Property
    Property PINH As String
        Get
            PINH = pPINH
        End Get
        Set(value As String)
            pPINH = value
        End Set
    End Property
    Property PINI As String
        Get
            PINI = pPINI
        End Get
        Set(value As String)
            pPINI = value
        End Set
    End Property
    Property Elec As String
        Get
            Elec = pElec
        End Get
        Set(value As String)
            pElec = value
        End Set
    End Property
    Property ElecDesc As String
        Get
            ElecDesc = pElecDesc
        End Get
        Set(value As String)
            pElecDesc = value
        End Set
    End Property
    Property Refrigerant As String
        Get
            Refrigerant = pRefrigerant
        End Get

        Set(value As String)
            pRefrigerant = value
        End Set
    End Property
    Property CompType As String
        Get
            CompType = pCompType
        End Get
        Set(value As String)
            pCompType = value
        End Set
    End Property
    Property MinAmbient As String
        Get
            MinAmbient = Format(Val(pMinAmbient), "0.0")
        End Get
        Set(value As String)
            pMinAmbient = value
        End Set
    End Property
    Public Property FoulingFactor As String
        Get
            FoulingFactor = Format(Val(pFoulFactor), "0.00000000")
        End Get
        Set(value As String)
            pFoulFactor = value
        End Set
    End Property
    Public Property Fluid As String
        Get
            Fluid = pFluid
        End Get
        Set(value As String)
            pFluid = value
        End Set
    End Property
    Public Property EWT As String
        Get
            EWT = Format(Val(pEWT), "0.0")
        End Get
        Set(value As String)
            pEWT = value
        End Set
    End Property
    Public Property LWT As String
        Get
            LWT = Format(Val(pLWT), "0.0")
        End Get
        Set(value As String)
            pLWT = value
        End Set
    End Property
    Public Property Flow As String
        Get
            Flow = Format(Val(pFlow), "0.0")
        End Get
        Set(value As String)
            pFlow = value
        End Set
    End Property
    Public Property FPD As String
        Get
            FPD = Format(Val(pFPD), "0.0")
        End Get
        Set(value As String)
            pFPD = value
        End Set
    End Property
    Public Property EvapVolume As String
        Get
            EvapVolume = Format(Val(pVol), "0.0")
        End Get
        Set(value As String)
            pVol = value
        End Set
    End Property
    Public Property MinFlow As String
        Get
            MinFlow = Format(Val(pMinFlow), "0.0")
        End Get
        Set(value As String)
            pMinFlow = value
        End Set
    End Property
    Public Property MaxFlow As String
        Get
            MaxFlow = Format(Val(pMaxFlow), "0.0")
        End Get
        Set(value As String)
            pMaxFlow = value
        End Set
    End Property
    Public Property Ambient As String
        Get
            Ambient = Format(Val(pAmbient), "0.0")
        End Get
        Set(value As String)
            pAmbient = value
        End Set
    End Property
    Public Property Altitude As String
        Get
            Altitude = Format(Val(pAlt), "0")
        End Get
        Set(value As String)
            pAlt = value
        End Set
    End Property
    Public Property EER As String
        Get
            EER = Format(Val(pEER), "0.0")
        End Get
        Set(value As String)
            pEER = value
        End Set
    End Property
    Public Property NPLV As String
        Get
            NPLV = Format(Val(pNPLV), "0.0")
        End Get
        Set(value As String)
            pNPLV = value
        End Set
    End Property
    Public Property RigWeight As String
        Get
            RigWeight = Format(Val(pRigMass), "0")
        End Get
        Set(value As String)
            pRigMass = value
        End Set
    End Property
    Public Property OpWeight As String
        Get
            OpWeight = Format(Val(pOpMass), "0")
        End Get
        Set(value As String)
            pOpMass = value
        End Set
    End Property
    Public Property RefrigerantCharge As String
        Get
            RefrigerantCharge = Format(Val(pRefChg), "0.0")
        End Get
        Set(value As String)
            pRefChg = value
        End Set
    End Property
    Public Property FanCount As String
        Get
            FanCount = pFanCount
        End Get
        Set(value As String)
            pFanCount = value
        End Set
    End Property
    Public Property FluidPercent As String
        Get
            FluidPercent = pFluidPercent
        End Get
        Set(value As String)
            pFluidPercent = value
        End Set
    End Property
    Public Property Ckt1BigCompRLA As String
        Get
            Ckt1BigCompRLA = pCkt1BigCompRLA
        End Get
        Set(value As String)
            pCkt1BigCompRLA = value
        End Set
    End Property
    Public Property Ckt2BigCompRLA As String
        Get
            Ckt2BigCompRLA = pCkt2BigCompRLA
        End Get
        Set(value As String)
            pCkt2BigCompRLA = value
        End Set
    End Property
    Public Property Ckt3BigCompRLA As String
        Get
            Ckt3BigCompRLA = pCkt3BigCompRLA
        End Get
        Set(value As String)
            pCkt3BigCompRLA = value
        End Set
    End Property
    Public Property Ckt4BigCompRLA As String
        Get
            Ckt4BigCompRLA = pCkt4BigCompRLA
        End Get
        Set(value As String)
            pCkt4BigCompRLA = value
        End Set
    End Property
    Public Property Ckt1FansQty As String
        Get
            Ckt1FansQty = pCkt1FansQ
        End Get
        Set(value As String)
            pCkt1FansQ = value
        End Set
    End Property
    Public Property Ckt2FansQty As String
        Get
            Ckt2FansQty = pCkt2FansQ
        End Get
        Set(value As String)
            pCkt2FansQ = value
        End Set
    End Property
    Public Property Ckt3FansQty As String
        Get
            Ckt3FansQty = pCkt3FansQ
        End Get
        Set(value As String)
            pCkt3FansQ = value
        End Set
    End Property
    Public Property Ckt4FansQty As String
        Get
            Ckt4FansQty = pCkt4FansQ
        End Get
        Set(value As String)
            pCkt4FansQ = value
        End Set
    End Property
    Public Property Ckt1FansFLA As String
        Get
            Ckt1FansFLA = pCkt1FansFLA
        End Get
        Set(value As String)
            pCkt1FansFLA = value
        End Set
    End Property
    Public Property Ckt2FansFLA As String
        Get
            Ckt2FansFLA = pCkt2FansFLA
        End Get
        Set(value As String)
            pCkt2FansFLA = value
        End Set
    End Property
    Public Property Ckt3FansFLA As String
        Get
            Ckt3FansFLA = pCkt3FansFLA
        End Get
        Set(value As String)
            pCkt3FansFLA = value
        End Set
    End Property
    Public Property Ckt4FansFLA As String
        Get
            Ckt4FansFLA = pCkt4FansFLA
        End Get
        Set(value As String)
            pCkt4FansFLA = value
        End Set
    End Property

    Public Sub New()
        pNomTons = 99.9
        pEWT = "52.0"
        pLWT = "42.0"
        pFlow = "400.0"
        pFPD = "10.0"
        pVol = "70.0"
        pMinFlow = "300.0"
        pMaxFlow = "1000.0"
        pAmbient = "95.0"
        pAlt = "0"
        pEER = "8.5"
        pNPLV = "14.0"
        pRigMass = "16000"
        pOpMass = "18000"
        pRefChg = "555.0"
        pFluid = "Water"
        pFluidPercent = "100"
        pFoulFactor = 0.0001
        pMinAmbient = 40.0
        pCompType = "VSD Screw"
        pRefrigerant = "R-134a"
        pPINA = "YLAA0092HE"
        pPINB = "46XFBBCTCB"
        pPINC = "XXBLXCXX50"
        pPIND = "SX1XXXHXXV"
        pPINE = "YAXGTXX7BX"
        pPINF = "XXXNP2XXXX"
        pPING = "....5...70"
        pPINH = "....5...80"
        pPINI = "....5...90"
        pElec = "460-3-60"
        pFanCount = -99
        pCkt1BigCompRLA = "0"
        pCkt1FansQ = "0"
        pCkt1FansFLA = "0"
        pCkt2BigCompRLA = "0"
        pCkt2FansQ = "0"
        pCkt2FansFLA = "0"
        pCkt3BigCompRLA = "0"
        pCkt3FansQ = "0"
        pCkt3FansFLA = "0"
        pCkt4BigCompRLA = "0"
        pCkt4FansQ = "0"
        pCkt4FansFLA = "0"
        pBaseFluidMass = "0.0"
        pMCA = "-"

    End Sub




    Public Sub ImportChillerEvaporatorData()
        Dim xDoc As XmlDocument = New XmlDocument

        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/EvaporatorData")

        pEWT = xNodeRoot.SelectSingleNode("EWT").InnerText
        pLWT = xNodeRoot.SelectSingleNode("LWT").InnerText
        pFlow = xNodeRoot.SelectSingleNode("FlowRate").InnerText
        Select Case frmMain.ThisUnit.Family
            Case Is = "YVAA"
                pFPD = xNodeRoot.SelectSingleNode("TPD").InnerText
                pNumPass = xNodeRoot.SelectSingleNode("NumPass").InnerText
            Case Is = "YLAA"
                pFPD = xNodeRoot.SelectSingleNode("TPD").InnerText
                pEvapPD = xNodeRoot.SelectSingleNode("EvapPD").InnerText
                pStrainerPD = xNodeRoot.SelectSingleNode("StrainerPD").InnerText
                pExtKitPD = xNodeRoot.SelectSingleNode("ExtKitPD").InnerText
        End Select

        pFluid = xNodeRoot.SelectSingleNode("Fluid").InnerText
        pFluidPercent = xNodeRoot.SelectSingleNode("Percent").InnerText
        pFoulFactor = xNodeRoot.SelectSingleNode("FoulFactor").InnerText

        pVol = xNodeRoot.SelectSingleNode("FluidVolume").InnerText
        pMinFlow = xNodeRoot.SelectSingleNode("MinFlow").InnerText
        pMaxFlow = xNodeRoot.SelectSingleNode("MaxFlow").InnerText

        xDoc = Nothing
    End Sub

    Public Sub ImportChillerCondenserData()
        Dim xDoc As XmlDocument = New XmlDocument

        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/CondenserData")

        pAmbient = xNodeRoot.SelectSingleNode("Ambient").InnerText
        pAlt = xNodeRoot.SelectSingleNode("Altitude").InnerText
        pCompType = xNodeRoot.SelectSingleNode("CompType").InnerText
        pMinAmbient = "40.0"

        xDoc = Nothing
    End Sub

    Public Sub ImportYLAASoundData()
        Dim xDoc As XmlDocument = New XmlDocument
        Dim i As Integer

        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/SoundData")

        For i = 1 To 6
            xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/SoundData/Stage" & Trim(Str(i)))

            pHz63.Add(xNodeRoot.SelectSingleNode("v63").InnerText)
            pHz125.Add(xNodeRoot.SelectSingleNode("v125").InnerText)
            pHz250.Add(xNodeRoot.SelectSingleNode("v250").InnerText)
            pHz500.Add(xNodeRoot.SelectSingleNode("v500").InnerText)
            pHz1.Add(xNodeRoot.SelectSingleNode("v1k").InnerText)
            pHz2.Add(xNodeRoot.SelectSingleNode("v2k").InnerText)
            pHz4.Add(xNodeRoot.SelectSingleNode("v4k").InnerText)
            pHz8.Add(xNodeRoot.SelectSingleNode("v8k").InnerText)
            pHzLpA.Add(xNodeRoot.SelectSingleNode("dBA").InnerText)

        Next i
        xDoc = Nothing
    End Sub

    Public Sub ImportYVAASoundData()
        Dim xDoc As XmlDocument = New XmlDocument

        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/SoundData")


        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/SoundData/Level100")

        pHz63.Add(xNodeRoot.SelectSingleNode("v63").InnerText)
        pHz125.Add(xNodeRoot.SelectSingleNode("v125").InnerText)
        pHz250.Add(xNodeRoot.SelectSingleNode("v250").InnerText)
        pHz500.Add(xNodeRoot.SelectSingleNode("v500").InnerText)
        pHz1.Add(xNodeRoot.SelectSingleNode("v1k").InnerText)
        pHz2.Add(xNodeRoot.SelectSingleNode("v2k").InnerText)
        pHz4.Add(xNodeRoot.SelectSingleNode("v4k").InnerText)
        pHz8.Add(xNodeRoot.SelectSingleNode("v8k").InnerText)
        pHzLpA.Add(xNodeRoot.SelectSingleNode("dBA").InnerText)

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/SoundData/Level75")

        pHz63.Add(xNodeRoot.SelectSingleNode("v63").InnerText)
        pHz125.Add(xNodeRoot.SelectSingleNode("v125").InnerText)
        pHz250.Add(xNodeRoot.SelectSingleNode("v250").InnerText)
        pHz500.Add(xNodeRoot.SelectSingleNode("v500").InnerText)
        pHz1.Add(xNodeRoot.SelectSingleNode("v1k").InnerText)
        pHz2.Add(xNodeRoot.SelectSingleNode("v2k").InnerText)
        pHz4.Add(xNodeRoot.SelectSingleNode("v4k").InnerText)
        pHz8.Add(xNodeRoot.SelectSingleNode("v8k").InnerText)
        pHzLpA.Add(xNodeRoot.SelectSingleNode("dBA").InnerText)

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/SoundData/Level50")

        pHz63.Add(xNodeRoot.SelectSingleNode("v63").InnerText)
        pHz125.Add(xNodeRoot.SelectSingleNode("v125").InnerText)
        pHz250.Add(xNodeRoot.SelectSingleNode("v250").InnerText)
        pHz500.Add(xNodeRoot.SelectSingleNode("v500").InnerText)
        pHz1.Add(xNodeRoot.SelectSingleNode("v1k").InnerText)
        pHz2.Add(xNodeRoot.SelectSingleNode("v2k").InnerText)
        pHz4.Add(xNodeRoot.SelectSingleNode("v4k").InnerText)
        pHz8.Add(xNodeRoot.SelectSingleNode("v8k").InnerText)
        pHzLpA.Add(xNodeRoot.SelectSingleNode("dBA").InnerText)

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/SoundData/Level25")

        pHz63.Add(xNodeRoot.SelectSingleNode("v63").InnerText)
        pHz125.Add(xNodeRoot.SelectSingleNode("v125").InnerText)
        pHz250.Add(xNodeRoot.SelectSingleNode("v250").InnerText)
        pHz500.Add(xNodeRoot.SelectSingleNode("v500").InnerText)
        pHz1.Add(xNodeRoot.SelectSingleNode("v1k").InnerText)
        pHz2.Add(xNodeRoot.SelectSingleNode("v2k").InnerText)
        pHz4.Add(xNodeRoot.SelectSingleNode("v4k").InnerText)
        pHz8.Add(xNodeRoot.SelectSingleNode("v8k").InnerText)
        pHzLpA.Add(xNodeRoot.SelectSingleNode("dBA").InnerText)

        xDoc = Nothing
    End Sub

    Public Sub ImportYLAAPerformanceData()
        Dim xDoc As XmlDocument = New XmlDocument
        Dim i As Integer

        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/PerformanceData")

        pEER = xNodeRoot.SelectSingleNode("EER").InnerText
        pNPLV = xNodeRoot.SelectSingleNode("NPLV").InnerText

        For i = 1 To 6
            xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/AuxPerformance/Stage" & Trim(Val(i)))

            pPLRAmbient.Add(xNodeRoot.SelectSingleNode("Ambient").InnerText)
            pPLRCapacity.Add(xNodeRoot.SelectSingleNode("Capacity").InnerText)
            pPLRTotalkW.Add(xNodeRoot.SelectSingleNode("TotalkW").InnerText)
            pPLREfficiency.Add(xNodeRoot.SelectSingleNode("Efficiency").InnerText)

        Next i

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/AuxPerformance")
        pAHRIEWT = xNodeRoot.SelectSingleNode("EWT").InnerText
        pAHRILWT = xNodeRoot.SelectSingleNode("LWT").InnerText
        pAHRIFlow = xNodeRoot.SelectSingleNode("Flow").InnerText
        pAHRITPD = xNodeRoot.SelectSingleNode("TPD").InnerText
        pAHRIFluid = xNodeRoot.SelectSingleNode("Fluid").InnerText
        pAHRIFoulFactor = xNodeRoot.SelectSingleNode("FoulFactor").InnerText
        pAHRIVolume = xNodeRoot.SelectSingleNode("Volume").InnerText
        pAHRIAmbient = xNodeRoot.SelectSingleNode("Ambient").InnerText
        pAHRIAltitude = xNodeRoot.SelectSingleNode("Altitude").InnerText
        pAHRIEER = xNodeRoot.SelectSingleNode("EER").InnerText
        pAHRINPLV = xNodeRoot.SelectSingleNode("NPLV").InnerText
        pAHRICoolCap = xNodeRoot.SelectSingleNode("CoolCap").InnerText

        xDoc = Nothing
    End Sub

    Public Sub ImportYVAAPerformanceData()
        Dim xDoc As XmlDocument = New XmlDocument

        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/PerformanceData")

        pEER = xNodeRoot.SelectSingleNode("EER").InnerText
        pNPLV = xNodeRoot.SelectSingleNode("NPLV").InnerText

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/AuxPerformance/Load100")

        pPLRAmbient.Add(xNodeRoot.SelectSingleNode("Ambient").InnerText)
        pPLRCapacity.Add(xNodeRoot.SelectSingleNode("Capacity").InnerText)
        pPLRTotalkW.Add(xNodeRoot.SelectSingleNode("TotalkW").InnerText)
        pPLREfficiency.Add(xNodeRoot.SelectSingleNode("Efficiency").InnerText)

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/AuxPerformance/Load75")

        pPLRAmbient.Add(xNodeRoot.SelectSingleNode("Ambient").InnerText)
        pPLRCapacity.Add(xNodeRoot.SelectSingleNode("Capacity").InnerText)
        pPLRTotalkW.Add(xNodeRoot.SelectSingleNode("TotalkW").InnerText)
        pPLREfficiency.Add(xNodeRoot.SelectSingleNode("Efficiency").InnerText)

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/AuxPerformance/Load50")

        pPLRAmbient.Add(xNodeRoot.SelectSingleNode("Ambient").InnerText)
        pPLRCapacity.Add(xNodeRoot.SelectSingleNode("Capacity").InnerText)
        pPLRTotalkW.Add(xNodeRoot.SelectSingleNode("TotalkW").InnerText)
        pPLREfficiency.Add(xNodeRoot.SelectSingleNode("Efficiency").InnerText)

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/AuxPerformance/Load25")

        pPLRAmbient.Add(xNodeRoot.SelectSingleNode("Ambient").InnerText)
        pPLRCapacity.Add(xNodeRoot.SelectSingleNode("Capacity").InnerText)
        pPLRTotalkW.Add(xNodeRoot.SelectSingleNode("TotalkW").InnerText)
        pPLREfficiency.Add(xNodeRoot.SelectSingleNode("Efficiency").InnerText)

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/AuxPerformance")
        pAHRIEWT = xNodeRoot.SelectSingleNode("EWT").InnerText
        pAHRILWT = xNodeRoot.SelectSingleNode("LWT").InnerText
        pAHRIFlow = xNodeRoot.SelectSingleNode("Flow").InnerText
        pAHRITPD = xNodeRoot.SelectSingleNode("TPD").InnerText
        pAHRIFluid = xNodeRoot.SelectSingleNode("Fluid").InnerText
        pAHRIFoulFactor = xNodeRoot.SelectSingleNode("FoulFactor").InnerText
        pAHRIVolume = xNodeRoot.SelectSingleNode("Volume").InnerText
        pAHRIAmbient = xNodeRoot.SelectSingleNode("Ambient").InnerText
        pAHRIAltitude = xNodeRoot.SelectSingleNode("Altitude").InnerText
        pAHRIEER = xNodeRoot.SelectSingleNode("EER").InnerText
        pAHRINPLV = xNodeRoot.SelectSingleNode("NPLV").InnerText
        pAHRICoolCap = xNodeRoot.SelectSingleNode("CoolCap").InnerText

        xDoc = Nothing
    End Sub

    Public Sub ImportYVAAPhysicalData()
        Dim xDoc As XmlDocument = New XmlDocument

        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/PhysicalData")
        pRigMass = xNodeRoot.SelectSingleNode("RigWeight").InnerText
        pOpMass = xNodeRoot.SelectSingleNode("OpWeight").InnerText
        pRefChg = xNodeRoot.SelectSingleNode("RefCharge").InnerText

        pNotes = xNodeRoot.SelectSingleNode("Notes").InnerText


        xDoc = Nothing
    End Sub

    Public Sub ImportYLAALoadTable()
        Dim xdoc As XmlDocument = New XmlDocument
        Dim CompStr As String
        Dim slashloc As Integer

        xdoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xnode As XmlNode


        'Start with the Yorkworks PDF.  Export to XML Last tested on 3152F on 12 March 2018
        xnode = xdoc.SelectSingleNode("TaggedPDF-doc/Part/Table")
        'xnode = xdoc.SelectSingleNode("TaggedPDF-doc/Document/Table")

        xnode = xnode.NextSibling 'at P
        xnode = xnode.NextSibling 'at Pin Table
        xnode = xnode.NextSibling 'at P
        xnode = xnode.NextSibling 'at Data Table
        xnode = xnode.NextSibling 'at P
        xnode = xnode.NextSibling 'at Electrical Load Table

        'xnode = xnode.SelectSingleNode("TBody/TR")
        xnode = xnode.SelectSingleNode("TR")
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        CompStr = xnode.InnerText
        slashloc = InStr(CompStr, "/")
        Ckt1CompRLA.Add(Format(Val(Trim(Mid(CompStr, 1, slashloc - 1))), "0.0"))
        CompStr = Trim(Trim(Mid(CompStr, slashloc + 1)))
        If Len(CompStr) > 0 Then
            slashloc = InStr(CompStr, "/")
            If slashloc > 0 Then
                Ckt1CompRLA.Add(Format(Val(Trim(Mid(CompStr, 1, slashloc - 1))), "0.0"))
                CompStr = Trim(Trim(Mid(CompStr, slashloc + 1)))
            Else
                Ckt1CompRLA.Add(Format(Val(Trim(CompStr)), "0.0"))
                CompStr = ""
            End If
        End If
        If Len(CompStr) > 0 Then
            slashloc = InStr(CompStr, "/")
            If slashloc > 0 Then
                Ckt1CompRLA.Add(Format(Val(Trim(Mid(CompStr, 1, slashloc - 1))), "0.0"))
                CompStr = Trim(Trim(Mid(CompStr, slashloc + 1)))
            Else
                Ckt1CompRLA.Add(Format(Val(Trim(CompStr)), "0.0"))
                CompStr = ""
            End If
        End If
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        CompStr = xnode.InnerText
        slashloc = InStr(CompStr, "/")
        Ckt2CompRLA.Add(Format(Val(Trim(Mid(CompStr, 1, slashloc - 1))), "0.0"))
        CompStr = Trim(Trim(Mid(CompStr, slashloc + 1)))
        If Len(CompStr) > 0 Then
            slashloc = InStr(CompStr, "/")
            If slashloc > 0 Then
                Ckt2CompRLA.Add(Format(Val(Trim(Mid(CompStr, 1, slashloc - 1))), "0.0"))
                CompStr = Trim(Trim(Mid(CompStr, slashloc + 1)))
            Else
                Ckt2CompRLA.Add(Format(Val(Trim(CompStr)), "0.0"))
                CompStr = ""
            End If
        End If
        If Len(CompStr) > 0 Then
            slashloc = InStr(CompStr, "/")
            If slashloc > 0 Then
                Ckt2CompRLA.Add(Format(Val(Trim(Mid(CompStr, 1, slashloc - 1))), "0.0"))
                CompStr = Trim(Trim(Mid(CompStr, slashloc + 1)))
            Else
                Ckt2CompRLA.Add(Format(Val(Trim(CompStr)), "0.0"))
                CompStr = ""
            End If
        End If

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        CompStr = xnode.InnerText
        slashloc = InStr(CompStr, "/")
        Ckt1FansQty = Trim(Mid(CompStr, 1, slashloc - 1))
        Ckt1FansFLA = Format(Val(Trim(Mid(CompStr, slashloc + 1))), "0.0")
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        CompStr = xnode.InnerText
        slashloc = InStr(CompStr, "/")
        Ckt2FansQty = Trim(Mid(CompStr, 1, slashloc - 1))
        Ckt2FansFLA = Format(Val(Trim(Mid(CompStr, slashloc + 1))), "0.0")

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        CompStr = xnode.InnerText
        slashloc = InStr(CompStr, "/")
        Ckt1CompLRA.Add(Format(Val(Trim(Mid(CompStr, 1, slashloc - 1))), "0.0"))
        CompStr = Trim(Trim(Mid(CompStr, slashloc + 1)))
        If Len(CompStr) > 0 Then
            slashloc = InStr(CompStr, "/")
            If slashloc > 0 Then
                Ckt1CompLRA.Add(Format(Val(Trim(Mid(CompStr, 1, slashloc - 1))), "0.0"))
                CompStr = Trim(Trim(Mid(CompStr, slashloc + 1)))
            Else
                Ckt1CompLRA.Add(Format(Val(Trim(CompStr)), "0.0"))
                CompStr = ""
            End If
        End If
        If Len(CompStr) > 0 Then
            slashloc = InStr(CompStr, "/")
            If slashloc > 0 Then
                Ckt1CompLRA.Add(Format(Val(Trim(Mid(CompStr, 1, slashloc - 1))), "0.0"))
                CompStr = Trim(Trim(Mid(CompStr, slashloc + 1)))
            Else
                Ckt1CompLRA.Add(Format(Val(Trim(CompStr)), "0.0"))
                CompStr = ""
            End If
        End If
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        CompStr = xnode.InnerText
        slashloc = InStr(CompStr, "/")
        Ckt2CompLRA.Add(Format(Val(Trim(Mid(CompStr, 1, slashloc - 1))), "0.0"))
        CompStr = Trim(Trim(Mid(CompStr, slashloc + 1)))
        If Len(CompStr) > 0 Then
            slashloc = InStr(CompStr, "/")
            If slashloc > 0 Then
                Ckt2CompLRA.Add(Format(Val(Trim(Mid(CompStr, 1, slashloc - 1))), "0.0"))
                CompStr = Trim(Trim(Mid(CompStr, slashloc + 1)))
            Else
                Ckt2CompLRA.Add(Format(Val(Trim(CompStr)), "0.0"))
                CompStr = ""
            End If
        End If
        If Len(CompStr) > 0 Then
            slashloc = InStr(CompStr, "/")
            If slashloc > 0 Then
                Ckt2CompLRA.Add(Format(Val(Trim(Mid(CompStr, 1, slashloc - 1))), "0.0"))
                CompStr = Trim(Trim(Mid(CompStr, slashloc + 1)))
            Else
                Ckt2CompLRA.Add(Format(Val(Trim(CompStr)), "0.0"))
                CompStr = ""
            End If
        End If
    End Sub

    Public Sub ImportYLAASoundTable1()
        Dim xdoc As XmlDocument = New XmlDocument
        Dim xnode As XmlNode
        Dim i As Integer

        xdoc.Load(frmMain.txtBaseUnitFile.Text)

        xnode = xdoc.SelectSingleNode("//*/P[contains(.,'" & "AHRI 370" & "')]")
        pSoundTableTitle = xnode.InnerText
        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        For i = 1 To 6
            xnode = xnode.SelectSingleNode("TD")
            xnode = xnode.SelectSingleNode("P")
            'do nothing
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("P")
            'do nothing
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("P")
            pHz63.Add(xnode.InnerText)
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("P")
            pHz125.Add(xnode.InnerText)
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("P")
            pHz250.Add(xnode.InnerText)
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("P")
            pHz500.Add(xnode.InnerText)
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("P")
            pHz1.Add(xnode.InnerText)
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("P")
            pHz2.Add(xnode.InnerText)
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("P")
            pHz4.Add(xnode.InnerText)
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("P")
            pHz8.Add(xnode.InnerText)
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("P")
            pHzLpA.Add(xnode.InnerText)
            If i = 6 Then Exit For
            xnode = xnode.ParentNode
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
        Next i

        xdoc = Nothing
    End Sub
    Public Sub ImportYLAAPartLoadTable()
        Dim xdoc As XmlDocument = New XmlDocument
        Dim xnode As XmlNode
        Dim i As Integer

        xdoc.Load(frmMain.txtBaseUnitFile.Text)
        ' xnode = xdoc.SelectSingleNode("TaggedPDF-doc/Part['Part Load Rating Data']")
        xnode = xdoc.SelectSingleNode("//*/P[contains(.,'" & "Part Load Rating Data" & "')]")
        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        For i = 1 To 6
            xnode = xnode.SelectSingleNode("TD")
            xnode = xnode.SelectSingleNode("P")
            pPLRStage.Add(xnode.InnerText)
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("P")
            pPLRAmbient.Add(Format(Val(xnode.InnerText), "0.0"))
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("P")
            pPLRCapacity.Add(Format(Val(xnode.InnerText), "0.0"))
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("P")
            pPLRTotalkW.Add(Format(Val(xnode.InnerText), "0.0"))
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("P")
            pPLREfficiency.Add(Format(Val(xnode.InnerText), "0.0"))
            If i = 6 Then Exit For
            xnode = xnode.ParentNode
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
        Next i

        xdoc = Nothing
    End Sub



End Class
