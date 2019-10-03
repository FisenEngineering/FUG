Imports System.Xml
Imports System.Xml.Serialization

Public Class ClsYPALMainPerf
    Private pStaticSummaryItem As New ArrayList
    Private pStaticSummaryData As New ArrayList

    Private pUnitSize As String
    Private pIEER As String
    Private pEER As String
    Private pGasConsumption As String
    Private pGasHeatContent As String
    Private pSFanModel As String
    Private pSFanMotor As String
    Private pRXFanModel As String
    Private pRXFanMotor As String

    Private pCC1AFLA As String
    Private pCC1BFLA As String
    Private pCC2AFLA As String
    Private pCC2BFLA As String
    Private pCC3AFLA As String
    Private pCC3BFLA As String
    Private pSFanFLA As String
    Private pRXFanFLA As String
    Private pCPXfrmrFLA As String
    Private pCFanTotalFLA As String

    Private pDuctedDischargePWL() As String = New String() {"-", "-", "-", "-", "-", "-", "-", "-", "-"}
    Private pDuctedInletPWL() As String = New String() {"-", "-", "-", "-", "-", "-", "-", "-", "-"}
    Private pRadiatedPWL() As String = New String() {"-", "-", "-", "-", "-", "-", "-", "-", "-"}



    Public Property CC1AFLA As String
        Get
            Return pCC1AFLA
        End Get
        Set(value As String)
            pCC1AFLA = value
        End Set
    End Property
    Public Property CC1BFLA As String
        Get
            Return pCC1BFLA
        End Get
        Set(value As String)
            pCC1BFLA = value
        End Set
    End Property
    Public Property CC2AFLA As String
        Get
            Return pCC2AFLA
        End Get
        Set(value As String)
            pCC2AFLA = value
        End Set
    End Property
    Public Property CC2BFLA As String
        Get
            Return pCC2BFLA
        End Get
        Set(value As String)
            pCC2BFLA = value
        End Set
    End Property
    Public Property CC3AFLA As String
        Get
            Return pCC3AFLA
        End Get
        Set(value As String)
            pCC3AFLA = value
        End Set
    End Property
    Public Property CC3BFLA As String
        Get
            Return pCC3BFLA
        End Get
        Set(value As String)
            pCC3BFLA = value
        End Set
    End Property

    Public Property SFanFLA As String
        Get
            Return pSFanFLA
        End Get
        Set(value As String)
            pSFanFLA = value
        End Set
    End Property
    Public Property RXFanFLA As String
        Get
            Return pRXFanFLA
        End Get
        Set(value As String)
            pRXFanFLA = value
        End Set
    End Property
    Public Property ControlXfmrFLA
        Get
            Return pCPXfrmrFLA
        End Get
        Set(value)
            pCPXfrmrFLA = value
        End Set
    End Property

    Public Property DuctedDischargePWL(ByVal index As Integer) As String
        Get
            Return pDuctedDischargePWL(index)
        End Get
        Set(ByVal value As String)
            pDuctedDischargePWL(index) = value
        End Set
    End Property

    Public Property DuctedInletPWL(ByVal index As Integer) As String
        Get
            Return pDuctedInletPWL(index)
        End Get
        Set(ByVal value As String)
            pDuctedInletPWL(index) = value
        End Set
    End Property

    Public Property RadiatedPWL(ByVal index As Integer) As String
        Get
            Return pRadiatedPWL(index)
        End Get
        Set(ByVal value As String)
            pRadiatedPWL(index) = value
        End Set
    End Property

    Public Property CFansFLA As String
        Get
            Return pCFanTotalFLA
        End Get
        Set(value As String)
            pCFanTotalFLA = value
        End Set
    End Property

    Public Property StaticSummaryItem As ArrayList
        Get
            Return pStaticSummaryItem
        End Get
        Set(value As ArrayList)
            pStaticSummaryItem = value
        End Set
    End Property
    Public Property StaticSummaryData As ArrayList
        Get
            Return pStaticSummaryData
        End Get
        Set(value As ArrayList)
            pStaticSummaryData = value
        End Set
    End Property

    Public Property EER As String
        Get
            EER = pEER
        End Get
        Set(value As String)
            pEER = value
        End Set
    End Property

    Public Property IEER As String
        Get
            IEER = pIEER
        End Get
        Set(value As String)
            pIEER = value
        End Set
    End Property
    Public Property SFanModel As String
        Get
            SFanModel = pSFanModel
        End Get
        Set(value As String)
            pSFanModel = value
        End Set
    End Property

    Public Property SFanMotor As String
        Get
            SFanMotor = pSFanMotor
        End Get
        Set(value As String)
            pSFanMotor = value
        End Set
    End Property

    Public Property RXFanMotor As String
        Get
            RXFanMotor = pRXFanMotor
        End Get
        Set(value As String)
            pRXFanMotor = value
        End Set
    End Property

    Public Property RXFanModel As String
        Get
            RXFanModel = pRXFanModel
        End Get
        Set(value As String)
            pRXFanModel = value
        End Set
    End Property

    Public Property GasHeatContent As String
        Get
            GasHeatContent = pGasHeatContent
        End Get
        Set(value As String)
            pGasHeatContent = value
        End Set
    End Property

    Public Property GasConsumption As String
        Get
            GasConsumption = pGasConsumption
        End Get
        Set(value As String)
            pGasConsumption = value
        End Set
    End Property

    Public Property UnitSize As String
        Get
            UnitSize = pUnitSize
        End Get
        Set(value As String)
            pUnitSize = value
        End Set
    End Property


    Public Sub New()
        pUnitSize = "-"
        pIEER = "-"
        pEER = "-"
        pGasConsumption = "-"
        pGasHeatContent = "-"
        pCC1AFLA = "-"
        pCC1BFLA = "-"
        pCC2AFLA = "-"
        pCC2BFLA = "-"
        pCC3AFLA = "-"
        pCC3BFLA = "-"
        pSFanFLA = "-"
        pRXFanFLA = "-"
        pCPXfrmrFLA = "-"

    End Sub
    Public Sub ImportFSTYPALData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/ProjectData")

        pUnitSize = xNodeRoot.SelectSingleNode("UnitSize").InnerText

        xDoc = Nothing

    End Sub
    Public Sub ImportYPALData()
        Dim xdoc As XmlDocument = New XmlDocument

        xdoc.Load(frmMain.txtBaseUnitFile.Text)


        Dim xnode As XmlNode
        'xnode = xdoc.SelectSingleNode("TaggedPDF-doc/Document/Table/TBody/TR")
        xnode = xdoc.SelectSingleNode("//TaggedPDF-doc/Sect/Table")

        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TR/TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        pUnitSize = xnode.InnerText

        xdoc = Nothing
    End Sub
    Public Sub ImportFSTYPALSoundData()
        Dim xDoc As XmlDocument = New XmlDocument
        Dim i As Integer
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        'Grab all the Ducted Discahrge Data and store in the array
        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/SoundData/DuctedDischarge/v63")
        For i = 0 To 8
            pDuctedDischargePWL(i) = xNodeRoot.InnerText
            If i <> 8 Then xNodeRoot = xNodeRoot.NextSibling
        Next i

        'Grab all the Ducted Inlet and store in the array
        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/SoundData/DuctedInlet/v63")
        For i = 0 To 8
            pDuctedInletPWL(i) = xNodeRoot.InnerText
            If i <> 8 Then xNodeRoot = xNodeRoot.NextSibling
        Next i

        'Grab all the Radiated and store in the array
        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/SoundData/Radiated/v63")
        For i = 0 To 8
            pRadiatedPWL(i) = xNodeRoot.InnerText
            If i <> 8 Then xNodeRoot = xNodeRoot.NextSibling
        Next i

        xDoc = Nothing
    End Sub
End Class
