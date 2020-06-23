Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Public Class clsElecData

    Private pCommVolts As String
    Private pCommPhase As String
    Private pCommFreq As String
    Private pCommMCA As String
    Private pCommMOP As String
    Private pCommDisconnect As Boolean
    Private pCommFusedDisc As Boolean
    Private pEmerVolts As String
    Private pEmerPhase As String
    Private pEmerFreq As String
    Private pEmerMCA As String
    Private pEmerMOP As String
    Private pEmerDisconnect As Boolean
    Private pEmerFusedDisc As Boolean
    Private pEmerCircuit As Boolean
    Private pConvOutlet As Boolean

    Private pYPALLoadCC1A As String
    Private pYPALLoadCC1B As String
    Private pYPALLoadCC2A As String
    Private pYPALLoadCC2B As String
    Private pYPALLoadCC3A As String
    Private pYPALLoadCC3B As String
    Private pYPALLoadCFans As String
    Private pYPALLoadSFan As String
    Private pYPALLoadRXFan As String
    Private pYPALLoadCtrlXfmr As String

    Private pMinFuse As String
    Private pSCCR As String
    Private pWiresPerPhase As String
    Private pLugSize As String
    Private pPowerFactor As String
    Private pControlkVA As String
    Private pCompressorkW As String
    Private pTotalkW As String
    Private pTotalFankW As String
    Private pTotalkWWithHydroKit As String

    Private pRecFuse As String
    Private pMaxCB As String
    Private pMaxDE As String
    Private pStarterType As String

    Private pCompkW As New ArrayList
    Private pCompRLA As New ArrayList
    Private pCompLRA As New ArrayList
    Private pFanQty As New ArrayList
    Private pFanFLAeach As New ArrayList

    Private pFisenLoad01 As String 'Chillers and YPAL Only?
    Private pFisenLoadFLA01 As String 'Chillers and YPAL Only?

    Private pCommLoad As New ArrayList
    Private pEmerLoad As New ArrayList
    Private pModLoad As New ArrayList

    Public Property ModLoad As ArrayList
        Get
            ModLoad = pModLoad
        End Get
        Set(value As ArrayList)
            pModLoad = value
        End Set
    End Property

    Public Property CommLoad As ArrayList
        Get
            CommLoad = pCommLoad
        End Get
        Set(value As ArrayList)
            pCommLoad = value
        End Set
    End Property

    Public Property EmerLoad As ArrayList
        Get
            EmerLoad = pEmerLoad
        End Get
        Set(value As ArrayList)
            pEmerLoad = value
        End Set
    End Property
    Public Property FisenLoad01 As String
        Get
            FisenLoad01 = pFisenLoad01
        End Get
        Set(value As String)
            pFisenLoad01 = value
        End Set
    End Property

    Public Property FisenLoadFLA01 As String
        Get
            FisenLoadFLA01 = pFisenLoadFLA01
        End Get
        Set(value As String)
            pFisenLoadFLA01 = value
        End Set
    End Property

    Public Property TotalFankW As String
        Get
            TotalFankW = pTotalFankW
        End Get
        Set(value As String)
            pTotalFankW = value
        End Set
    End Property

    Public Property TotalkWWithHydroKit As String
        Get
            TotalkWWithHydroKit = pTotalkWWithHydroKit
        End Get
        Set(value As String)
            pTotalkWWithHydroKit = value
        End Set
    End Property

    Public Property CompLRA As ArrayList
        Get
            Return pCompLRA
        End Get
        Set(value As ArrayList)
            pCompLRA = value
        End Set
    End Property

    Public Property CompkW As ArrayList
        Get
            Return pCompkW
        End Get
        Set(value As ArrayList)
            pCompkW = value
        End Set
    End Property

    Public Property CompRLA As ArrayList
        Get
            Return pCompRLA
        End Get
        Set(value As ArrayList)
            pCompRLA = value
        End Set
    End Property
    Public Property FanQty As ArrayList
        Get
            Return pFanQty
        End Get
        Set(value As ArrayList)
            pFanQty = value
        End Set
    End Property
    Public Property FanFLAeach As ArrayList
        Get
            Return pFanFLAeach
        End Get
        Set(value As ArrayList)
            pFanFLAeach = value
        End Set
    End Property


    Public Property StarterType As String
        Get
            StarterType = pStarterType
        End Get
        Set(value As String)
            pStarterType = value
        End Set
    End Property

    Public Property MaxDE As String
        Get
            MaxDE = pMaxDE
        End Get
        Set(value As String)
            pMaxDE = value
        End Set
    End Property
    Public Property MaxCB As String
        Get
            MaxCB = pMaxCB
        End Get
        Set(value As String)
            pMaxCB = value
        End Set
    End Property

    Public Property RecFuse As String
        Get
            RecFuse = pRecFuse
        End Get
        Set(value As String)
            pRecFuse = value
        End Set
    End Property

    Public Property TotalkW As String
        Get
            TotalkW = pTotalkW
        End Get
        Set(value As String)
            pTotalkW = value
        End Set
    End Property
    Public Property CompressorkW As String
        Get
            CompressorkW = pCompressorkW
        End Get
        Set(value As String)
            pCompressorkW = value
        End Set
    End Property

    Public Property ControlkVA As String
        Get
            ControlkVA = pControlkVA
        End Get
        Set(value As String)
            pControlkVA = value
        End Set
    End Property

    Public Property PowerFactor As String
        Get
            PowerFactor = pPowerFactor
        End Get
        Set(value As String)
            pPowerFactor = value
        End Set
    End Property

    Public Property LugSize As String
        Get
            LugSize = pLugSize
        End Get
        Set(value As String)
            pLugSize = value
        End Set
    End Property
    Public Property WiresPerPhase
        Get
            WiresPerPhase = pWiresPerPhase
        End Get
        Set(value)
            pWiresPerPhase = value
        End Set
    End Property

    Public Property SCCR As String
        Get
            SCCR = pSCCR
        End Get
        Set(value As String)
            pSCCR = value
        End Set
    End Property

    Public Property MinFuse As String
        Get
            MinFuse = pMinFuse
        End Get
        Set(value As String)
            pMinFuse = value
        End Set
    End Property

    Public Property YPALLoadCC1A As String
        Get
            YPALLoadCC1A = pYPALLoadCC1A
        End Get
        Set(value As String)
            pYPALLoadCC1A = value
        End Set
    End Property

    Public Property YPALLoadCC1B As String
        Get
            YPALLoadCC1B = pYPALLoadCC1B
        End Get
        Set(value As String)
            pYPALLoadCC1B = value
        End Set
    End Property

    Public Property YPALLoadCC2A As String
        Get
            YPALLoadCC2A = pYPALLoadCC2A
        End Get
        Set(value As String)
            pYPALLoadCC2A = value
        End Set
    End Property

    Public Property YPALLoadCC2B As String
        Get
            YPALLoadCC2B = pYPALLoadCC2B
        End Get
        Set(value As String)
            pYPALLoadCC2B = value
        End Set
    End Property

    Public Property YPALLoadCC3A As String
        Get
            YPALLoadCC3A = pYPALLoadCC3A
        End Get
        Set(value As String)
            pYPALLoadCC3A = value
        End Set
    End Property

    Public Property YPALLoadCC3B As String
        Get
            YPALLoadCC3B = pYPALLoadCC3B
        End Get
        Set(value As String)
            pYPALLoadCC3B = value
        End Set
    End Property

    Public Property YPALLoadCFans As String
        Get
            YPALLoadCFans = pYPALLoadCFans
        End Get
        Set(value As String)
            pYPALLoadCFans = value
        End Set
    End Property

    Public Property YPALLoadSFan As String
        Get
            YPALLoadSFan = pYPALLoadSFan
        End Get
        Set(value As String)
            pYPALLoadSFan = value
        End Set
    End Property

    Public Property YPALLoadRXFan As String
        Get
            YPALLoadRXFan = pYPALLoadRXFan
        End Get
        Set(value As String)
            pYPALLoadRXFan = value
        End Set
    End Property

    Public Property YPALLoadCtrlXfmr As String
        Get
            YPALLoadCtrlXfmr = pYPALLoadCtrlXfmr
        End Get
        Set(value As String)
            pYPALLoadCtrlXfmr = value
        End Set
    End Property


    Public Property CommVolts As String
        Get
            CommVolts = pCommVolts
        End Get
        Set(value As String)
            pCommVolts = value
        End Set
    End Property
    Public Property CommPhase As String
        Get
            CommPhase = pCommPhase
        End Get
        Set(value As String)
            pCommPhase = value
        End Set
    End Property
    Public Property CommFreq As String
        Get
            CommFreq = pCommFreq
        End Get
        Set(value As String)
            pCommFreq = value
        End Set
    End Property
    Public Property CommMCA As String
        Get
            CommMCA = Format(Val(pCommMCA), "0.0")
        End Get
        Set(value As String)
            pCommMCA = value
        End Set
    End Property
    Public Property CommMOP As String
        Get
            CommMOP = Format(Val(pCommMOP), "0")
        End Get
        Set(value As String)
            pCommMOP = value
        End Set
    End Property
    Public Property EmerVolts As String
        Get
            EmerVolts = pEmerVolts
        End Get
        Set(value As String)
            pEmerVolts = value
        End Set
    End Property
    Public Property EmerPhase As String
        Get
            EmerPhase = pEmerPhase
        End Get
        Set(value As String)
            pEmerPhase = value
        End Set
    End Property
    Public Property EmerFreq As String
        Get
            EmerFreq = pEmerFreq
        End Get
        Set(value As String)
            pEmerFreq = value
        End Set
    End Property
    Public Property EmerMCA As String
        Get
            If Val(pEmerMCA) = 0 Then
                EmerMCA = "-"
            Else
                EmerMCA = Format(Val(pEmerMCA), "0.0")
            End If

        End Get
        Set(value As String)
            pEmerMCA = value
        End Set
    End Property
    Public Property EmerMOP As String
        Get
            If pEmerMOP = "0" Then
                EmerMOP = "-"
            Else
                EmerMOP = Format(Val(pEmerMOP), "0")
            End If
        End Get
        Set(value As String)
            pEmerMOP = value
        End Set
    End Property
    Public Property ConvOutlet As Boolean
        Get
            ConvOutlet = pConvOutlet
        End Get
        Set(value As Boolean)
            pConvOutlet = value
        End Set
    End Property

    Public Property CommDisconnect As Boolean
        Get
            CommDisconnect = pCommDisconnect
        End Get
        Set(value As Boolean)
            pCommDisconnect = value
        End Set
    End Property
    Public Property EmerDisconnect As Boolean
        Get
            EmerDisconnect = pEmerDisconnect
        End Get
        Set(value As Boolean)
            pEmerDisconnect = value
        End Set
    End Property
    Public Property CommFused As Boolean
        Get
            CommFused = pCommFusedDisc
        End Get
        Set(value As Boolean)
            pCommFusedDisc = value
        End Set
    End Property
    Public Property EmerFused As Boolean
        Get
            EmerFused = pEmerFusedDisc
        End Get
        Set(value As Boolean)
            pEmerFusedDisc = value
        End Set
    End Property
    Public Property EmerCircuit As Boolean
        Get
            EmerCircuit = pEmerCircuit
        End Get
        Set(value As Boolean)
            pEmerCircuit = value
        End Set
    End Property
    Public Sub ImportUPGData(UnitFamily As String)
        Dim xdoc As XmlDocument = New XmlDocument
        Dim nodeid As String
        If ((UnitFamily = "Series20ODSplit") Or (UnitFamily = "Series40ODSplit")) Then
            nodeid = "Value/SystemPerformance/OutdoorElectrical"
        Else
            nodeid = "Value/SystemPerformance/Electrical"
        End If
        xdoc.Load(frmMain.txtBaseUnitFile.Text)
        Dim xnodelist As XmlNodeList = xdoc.SelectNodes("//HvacQuote/LineItems/HvacQuoteLineItem")
        Dim xnode As XmlNode
        xnode = xdoc.SelectSingleNode("//HvacQuote/Performance/Dictionary/KeyValuePair[contains(.,'" & frmMain.ThisUnit.PerformanceID & "')]")
        pCommVolts = xnode.SelectSingleNode(nodeid & "/PowerSpec/Voltages").SelectSingleNode("int").InnerText
        pCommPhase = xnode.SelectSingleNode(nodeid & "/PowerSpec").SelectSingleNode("Phase").InnerText
        pCommFreq = xnode.SelectSingleNode(nodeid & "/PowerSpec").SelectSingleNode("Frequency").InnerText
        pCommMCA = xnode.SelectSingleNode(nodeid).SelectSingleNode("MinCircuitAmps").InnerText
        pCommMOP = xnode.SelectSingleNode(nodeid).SelectSingleNode("FuseSize").InnerText
        xdoc = Nothing
    End Sub
    Public Sub ImportFSTUPGData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/ElectricalData")

        pCommVolts = xNodeRoot.SelectSingleNode("Volts").InnerText
        pCommPhase = xNodeRoot.SelectSingleNode("Phase").InnerText
        pCommFreq = xNodeRoot.SelectSingleNode("Frequency").InnerText
        pCommMCA = xNodeRoot.SelectSingleNode("MCA").InnerText
        pCommMOP = xNodeRoot.SelectSingleNode("MOP").InnerText

        xDoc = Nothing

    End Sub
    Public Sub ImportFSTYPALData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/ElectricalData")

        pCommVolts = xNodeRoot.SelectSingleNode("Volts").InnerText
        pCommPhase = xNodeRoot.SelectSingleNode("Phase").InnerText
        pCommFreq = xNodeRoot.SelectSingleNode("Frequency").InnerText
        pCommMCA = xNodeRoot.SelectSingleNode("MCA").InnerText
        pCommMOP = xNodeRoot.SelectSingleNode("MOP").InnerText

        pYPALLoadCC1A = xNodeRoot.SelectSingleNode("CC1A").InnerText
        pYPALLoadCC1B = xNodeRoot.SelectSingleNode("CC1B").InnerText
        pYPALLoadCC2A = xNodeRoot.SelectSingleNode("CC2A").InnerText
        pYPALLoadCC2B = xNodeRoot.SelectSingleNode("CC2B").InnerText
        pYPALLoadCC3A = xNodeRoot.SelectSingleNode("CC3A").InnerText
        pYPALLoadCC3B = xNodeRoot.SelectSingleNode("CC3B").InnerText

        pYPALLoadCFans = xNodeRoot.SelectSingleNode("CondenserFansFLA").InnerText
        pYPALLoadSFan = xNodeRoot.SelectSingleNode("SupplyFanFLA").InnerText
        pYPALLoadRXFan = xNodeRoot.SelectSingleNode("RXFanFLA").InnerText
        pYPALLoadCtrlXfmr = xNodeRoot.SelectSingleNode("ControlTransformerFLA").InnerText

        xDoc = Nothing

    End Sub

    Public Sub ImportFSTYLAAData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/ElectricalData")

        pCommVolts = xNodeRoot.SelectSingleNode("Volts").InnerText
        pCommPhase = xNodeRoot.SelectSingleNode("Phase").InnerText
        pCommFreq = xNodeRoot.SelectSingleNode("Frequency").InnerText

        pCommMCA = xNodeRoot.SelectSingleNode("MCA").InnerText
        pRecFuse = xNodeRoot.SelectSingleNode("RecFuse").InnerText
        pMaxCB = xNodeRoot.SelectSingleNode("MaxITCB").InnerText
        pMaxDE = xNodeRoot.SelectSingleNode("MOP").InnerText
        pCommMOP = xNodeRoot.SelectSingleNode("MOP").InnerText

        pSCCR = xNodeRoot.SelectSingleNode("SCCR").InnerText
        pWiresPerPhase = xNodeRoot.SelectSingleNode("WiresPerPhase").InnerText
        pLugSize = xNodeRoot.SelectSingleNode("LugSize").InnerText
        pStarterType = xNodeRoot.SelectSingleNode("StarterType").InnerText

        pCompressorkW = xNodeRoot.SelectSingleNode("CompressorkW").InnerText
        pTotalFankW = xNodeRoot.SelectSingleNode("TotalFankW").InnerText
        pTotalkW = xNodeRoot.SelectSingleNode("TotalkW").InnerText
        pTotalkWWithHydroKit = xNodeRoot.SelectSingleNode("TotalWithHydroKitkW").InnerText

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/ElectricalData/Circuit1")

        pCompRLA.Add(xNodeRoot.SelectSingleNode("CompressorARLA").InnerText)
        pCompRLA.Add(xNodeRoot.SelectSingleNode("CompressorBRLA").InnerText)
        pCompRLA.Add(xNodeRoot.SelectSingleNode("CompressorCRLA").InnerText)
        pFanQty.Add(xNodeRoot.SelectSingleNode("CFanQty").InnerText)
        pFanFLAeach.Add(xNodeRoot.SelectSingleNode("CFanFLA").InnerText)
        pCompLRA.Add(xNodeRoot.SelectSingleNode("CompressorALRA").InnerText)
        pCompLRA.Add(xNodeRoot.SelectSingleNode("CompressorBLRA").InnerText)
        pCompLRA.Add(xNodeRoot.SelectSingleNode("CompressorCLRA").InnerText)

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/ElectricalData/Circuit2")

        pCompRLA.Add(xNodeRoot.SelectSingleNode("CompressorARLA").InnerText)
        pCompRLA.Add(xNodeRoot.SelectSingleNode("CompressorBRLA").InnerText)
        pCompRLA.Add(xNodeRoot.SelectSingleNode("CompressorCRLA").InnerText)
        pFanQty.Add(xNodeRoot.SelectSingleNode("CFanQty").InnerText)
        pFanFLAeach.Add(xNodeRoot.SelectSingleNode("CFanFLA").InnerText)
        pCompLRA.Add(xNodeRoot.SelectSingleNode("CompressorALRA").InnerText)
        pCompLRA.Add(xNodeRoot.SelectSingleNode("CompressorBLRA").InnerText)
        pCompLRA.Add(xNodeRoot.SelectSingleNode("CompressorCLRA").InnerText)


        xDoc = Nothing

    End Sub

    Public Sub ImportFSTYVAAData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/ElectricalData")

        pCommVolts = xNodeRoot.SelectSingleNode("Volts").InnerText
        pCommPhase = xNodeRoot.SelectSingleNode("Phase").InnerText
        pCommFreq = xNodeRoot.SelectSingleNode("Frequency").InnerText

        pCommMCA = xNodeRoot.SelectSingleNode("MCA").InnerText
        pMinFuse = xNodeRoot.SelectSingleNode("MinFuse").InnerText
        pCommMOP = xNodeRoot.SelectSingleNode("MOP").InnerText
        pSCCR = xNodeRoot.SelectSingleNode("SCCR").InnerText
        pWiresPerPhase = xNodeRoot.SelectSingleNode("WiresPerPhase").InnerText
        pLugSize = xNodeRoot.SelectSingleNode("LugSize").InnerText
        pPowerFactor = xNodeRoot.SelectSingleNode("PowerFactor").InnerText
        pControlkVA = xNodeRoot.SelectSingleNode("ControlKVA").InnerText
        pCompressorkW = xNodeRoot.SelectSingleNode("CompressorkW").InnerText
        pTotalkW = xNodeRoot.SelectSingleNode("TotalkW").InnerText

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/ElectricalData/Circuit1")
        pCompkW.Add(xNodeRoot.SelectSingleNode("CompressorkW").InnerText)
        pCompRLA.Add(xNodeRoot.SelectSingleNode("CompressorRLA").InnerText)
        pFanQty.Add(xNodeRoot.SelectSingleNode("CFanQty").InnerText)
        pFanFLAeach.Add(xNodeRoot.SelectSingleNode("CFanFLA").InnerText)

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/ElectricalData/Circuit2")
        pCompkW.Add(xNodeRoot.SelectSingleNode("CompressorkW").InnerText)
        pCompRLA.Add(xNodeRoot.SelectSingleNode("CompressorRLA").InnerText)
        pFanQty.Add(xNodeRoot.SelectSingleNode("CFanQty").InnerText)
        pFanFLAeach.Add(xNodeRoot.SelectSingleNode("CFanFLA").InnerText)

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/ElectricalData/Circuit3")
        pCompkW.Add(xNodeRoot.SelectSingleNode("CompressorkW").InnerText)
        pCompRLA.Add(xNodeRoot.SelectSingleNode("CompressorRLA").InnerText)
        pFanQty.Add(xNodeRoot.SelectSingleNode("CFanQty").InnerText)
        pFanFLAeach.Add(xNodeRoot.SelectSingleNode("CFanFLA").InnerText)

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/ElectricalData/Circuit4")
        pCompkW.Add(xNodeRoot.SelectSingleNode("CompressorkW").InnerText)
        pCompRLA.Add(xNodeRoot.SelectSingleNode("CompressorRLA").InnerText)
        pFanQty.Add(xNodeRoot.SelectSingleNode("CFanQty").InnerText)
        pFanFLAeach.Add(xNodeRoot.SelectSingleNode("CFanFLA").InnerText)


        xDoc = Nothing

    End Sub
    Public Sub New()
        pCommVolts = "460"
        pCommPhase = "3"
        pCommFreq = "60"
        pConvOutlet = False
        pFisenLoad01 = " "
        pFisenLoadFLA01 = " "
    End Sub
End Class
