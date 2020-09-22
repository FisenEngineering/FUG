Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Imports System.Drawing.Imaging

Public Class clsSupplyPerf
    Private pAirflow As String
    Private pFanCount As String

    Private pESP As String
    Private pESPElev As String
    Private pUSP As String
    Private pTSP As String
    Private pRPM As String
    Private pMhp As String
    Private pMhpUnits As String
    Private pBhp As String
    Private pBhpUnits As String
    Private pPower As String
    Private pMFLA As String
    Private pDriveType As String
    Private pMotorText As String
    Private pDuctLoc As String
    Private pInletPWL() As String = New String() {"-", "-", "-", "-", "-", "-", "-", "-"}
    Private pOutletPWL() As String = New String() {"-", "-", "-", "-", "-", "-", "-", "-"}
    Private pInletdBW As String
    Private pOutletdBW As String
    Private pInletdBA5 As String
    Private pOutletdBA5 As String
    Private pXRangeFan As Boolean
    Private pSPSItemDesc() As String = New String() {"-", "-", "-", "-", "-", "-"}
    Private pSPSItemData() As String = New String() {"-", "-", "-", "-", "-", "-"}
    Private pSPSItemDataElev() As String = New String() {"-", "-", "-", "-", "-", "-"}
    Private pCabEffects As String
    Private pCabEffectsElev As String
    Private pMaxRPM As String
    Private pFanSelected As String
    Private pStaticSummaryItem As ArrayList = New ArrayList
    Private pStaticPSTP As ArrayList = New ArrayList
    Private pStaticPATP As ArrayList = New ArrayList

    Private pStaticNameYPal As ArrayList = New ArrayList
    Private pStaticDataYPal As ArrayList = New ArrayList

    Private pSFanVFDPresent As Boolean

    Public Property MhpUnits As String
        Get
            MhpUnits = pMhpUnits
        End Get
        Set(value As String)
            pMhpUnits = value
        End Set
    End Property
    Public Property BhpUnits As String
        Get
            BhpUnits = pBhpUnits
        End Get
        Set(value As String)
            pBhpUnits = value
        End Set
    End Property
    Public Property MFLA As String
        Get
            MFLA = pMFLA
        End Get
        Set(value As String)
            pMFLA = value
        End Set
    End Property



    Public Property FanCount As String
        Get
            Return pFanCount
        End Get
        Set(value As String)
            pFanCount = value
        End Set
    End Property
    Public Property VFDPresent As Boolean
        Get
            Return pSFanVFDPresent
        End Get
        Set(value As Boolean)
            pSFanVFDPresent = value
        End Set
    End Property

    Public Property StaticNameYpal As ArrayList
        Get
            Return pStaticNameYPal
        End Get
        Set(ByVal value As ArrayList)
            pStaticNameYPal = value
        End Set
    End Property

    Public Property StaticDataYpal As ArrayList
        Get
            Return pStaticDataYPal
        End Get
        Set(ByVal value As ArrayList)
            pStaticDataYPal = value
        End Set
    End Property

    Public Property MotorText As String
        Get
            Return pMotorText
        End Get
        Set(value As String)
            pMotorText = value
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
    Public Property StaticPDataSTP As ArrayList
        Get
            Return pStaticPSTP
        End Get
        Set(value As ArrayList)
            pStaticPSTP = value
        End Set
    End Property
    Public Property StaticPDataATP As ArrayList
        Get
            Return pStaticPATP
        End Get
        Set(value As ArrayList)
            pStaticPATP = value
        End Set
    End Property
    Public Property ESPElev
        Get
            Return pESPElev
        End Get
        Set(value)
            pESPElev = value
        End Set
    End Property
    Public Property CabEffects
        Get
            Return pCabEffects
        End Get
        Set(value)
            pCabEffects = value
        End Set
    End Property
    Public Property CabEffectsElev
        Get
            Return pCabEffectsElev
        End Get
        Set(value)
            pCabEffectsElev = value
        End Set
    End Property
    Public Property SPSItemDesc(ByVal index As Integer) As String
        Get
            Return SPSItemDesc(index)
        End Get
        Set(ByVal value As String)
            pSPSItemDesc(index) = value
        End Set
    End Property
    Public Property SPSItemData(ByVal index As Integer) As String
        Get
            Return SPSItemData(index)
        End Get
        Set(ByVal value As String)
            pSPSItemData(index) = value
        End Set
    End Property
    Public Property SPSItemDataElev(ByVal index As Integer) As String
        Get
            Return SPSItemDataElev(index)
        End Get
        Set(ByVal value As String)
            pSPSItemDataElev(index) = value
        End Set
    End Property
    Public Property FanSelected As String
        Get
            FanSelected = pFanSelected
        End Get
        Set(value As String)
            pFanSelected = value
        End Set
    End Property
    Public Property MaxRPM As String
        Get
            MaxRPM = pMaxRPM
        End Get
        Set(value As String)
            pMaxRPM = value
        End Set
    End Property
    Public Property XRangeFan As Boolean
        Get
            XRangeFan = pXRangeFan
        End Get
        Set(value As Boolean)
            pXRangeFan = value
        End Set
    End Property

    Public Property Inlet_dBA5
        Get
            Inlet_dBA5 = pInletdBA5
        End Get
        Set(value)
            pInletdBA5 = value
        End Set
    End Property
    Public Property Outlet_dBA5
        Get
            Outlet_dBA5 = pOutletdBA5
        End Get
        Set(value)
            pOutletdBA5 = value
        End Set
    End Property
    Public Property Outlet_dBW
        Get
            Outlet_dBW = pOutletdBW
        End Get
        Set(value)
            pOutletdBW = value
        End Set
    End Property
    Public Property Inlet_dBW
        Get
            Inlet_dBW = pInletdBW
        End Get
        Set(value)
            pInletdBW = value
        End Set
    End Property

    Public Property InletPWL(ByVal index As Integer) As String
        Get
            Return pInletPWL(index)
        End Get
        Set(ByVal value As String)
            pInletPWL(index) = value
        End Set
    End Property

    Public Property OutletPWL(ByVal index As Integer) As String
        Get
            Return pOutletPWL(index)
        End Get
        Set(ByVal value As String)
            pOutletPWL(index) = value
        End Set
    End Property
    Public Property USP As String
        Get
            If pUSP = 0 Then
                USP = " "
            Else
                USP = Format(Val(pUSP), "0.00")
            End If
        End Get
        Set(value As String)
            pUSP = value
        End Set
    End Property
    Public Property Airflow() As String
        Get
            Return pAirflow
        End Get
        Set(value As String)
            pAirflow = value
        End Set
    End Property
    Public Property ESP As String
        Get
            Return Format(Val(pESP), "0.00")
        End Get
        Set(value As String)
            pESP = value
        End Set
    End Property
    Public Property TSP As String
        Get
            Return pTSP
        End Get
        Set(value As String)
            pTSP = value
        End Set
    End Property
    Public Property RPM As String
        Get
            Return pRPM
        End Get
        Set(value As String)
            pRPM = value
        End Set
    End Property
    Public Property MotorHP As String
        Get
            Select Case pMhp
                Case Is = "7.50"
                    pMhp = "7.5"
                Case Is = "7.5"
                    pMhp = "7.5"
                Case Is = "1.50"
                    pMhp = "1.5"
                Case Is = "1.5"
                    pMhp = "1.5"
                Case Else
                    pMhp = Format(Val(pMhp), "0")
            End Select
            Return pMhp
        End Get
        Set(value As String)
            Select Case value
                Case Is = "7.50"
                    pMhp = "7.5"
                Case Is = "7.5"
                    pMhp = "7.5"
                Case Is = "1.50"
                    pMhp = "1.5"
                Case Is = "1.5"
                    pMhp = "1.5"
                Case Else
                    pMhp = Format(Val(value), "0")
            End Select
            pMhp = value
        End Set
    End Property
    Public Property BrakeHP As String
        Get
            Return Format(Val(pBhp), "0.0")
        End Get
        Set(value As String)
            pBhp = value
        End Set
    End Property
    Public Property kWPower As String
        Get
            Return Format(Val(pPower), "0.0")
        End Get
        Set(value As String)
            pPower = value
        End Set
    End Property
    Public Property DriveType As String
        Get
            Return pDriveType
        End Get
        Set(value As String)
            pDriveType = value
        End Set
    End Property
    Public Property DuctLoc As String
        Get
            Return pDuctLoc
        End Get
        Set(value As String)
            pDuctLoc = value
        End Set
    End Property

    Public Sub New()
        pAirflow = " "
        pESP = " "
        pESPElev = " "
        pTSP = " "
        pRPM = " "
        pMhp = " "
        pBhp = " "
        pPower = " "
        pDriveType = " "
        pDuctLoc = " "
        pXRangeFan = False
        pMaxRPM = "9999"
        pOutletdBW = "-"
        pInletdBW = "-"
        pOutletdBA5 = "-"
        pInletdBA5 = "-"
        pFanSelected = "None"
        pCabEffects = " "
        pCabEffectsElev = " "
        pSFanVFDPresent = False

        pMFLA = "-"
        pMhpUnits = "hp"
        pBhpUnits = "bhp"
    End Sub
    Public Sub ImportUPGData()
        Dim xdoc As XmlDocument = New XmlDocument
        xdoc.Load(frmMain.txtBaseUnitFile.Text)
        Dim xnodelist As XmlNodeList = xdoc.SelectNodes("//HvacQuote/LineItems/HvacQuoteLineItem")
        Dim xnode As XmlNode
        xnode = xdoc.SelectSingleNode("//HvacQuote/Performance/Dictionary/KeyValuePair[contains(.,'" & frmMain.ThisUnit.PerformanceID & "')]")
        pAirflow = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/SupplyAirBlower").SelectSingleNode("Airflow").InnerText
        pESP = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/SupplyAirBlower").SelectSingleNode("StaticPressure").InnerText
        pUSP = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/SupplyAirBlower").SelectSingleNode("UnitStaticResistance").InnerText
        pRPM = xnode.SelectSingleNode("Value/SystemPerformance/SupplyAirBlower").SelectSingleNode("Rpm").InnerText
        pMhp = xnode.SelectSingleNode("Value/SystemPerformance/SupplyAirBlower").SelectSingleNode("MotorRatingHP").InnerText
        If pMhp = "7.50" Then pMhp = "7.5"
        pBhp = xnode.SelectSingleNode("Value/SystemPerformance/SupplyAirBlower").SelectSingleNode("RequiredPowerHP").InnerText
        pPower = xnode.SelectSingleNode("Value/SystemPerformance/SupplyAirBlower").SelectSingleNode("PowerInputKw").InnerText
        pDriveType = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/SupplyAirBlower").SelectSingleNode("HasBeltDrive").InnerText
        If pDriveType = "true" Then
            pDriveType = "Belt"
        Else
            pDriveType = "Direct"
        End If
        pDuctLoc = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/SupplyAirBlower").SelectSingleNode("DuctLocation").InnerText

        xdoc = Nothing
    End Sub
    Public Sub ImportFSTYPALData()
        Dim xDoc As XmlDocument = New XmlDocument
        Dim i As Integer
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/SupplyFanData")

        pAirflow = xNodeRoot.SelectSingleNode("Airflow").InnerText
        pESP = xNodeRoot.SelectSingleNode("ESP").InnerText
        pRPM = xNodeRoot.SelectSingleNode("RPM").InnerText

        pMotorText = xNodeRoot.SelectSingleNode("MotorText").InnerText

        pMhp = xNodeRoot.SelectSingleNode("MotorHP").InnerText
        pBhp = xNodeRoot.SelectSingleNode("BHP").InnerText
        pFanSelected = xNodeRoot.SelectSingleNode("FanName").InnerText

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/SupplyFanData/StaticPressureSummary")
        pStaticNameYPal.Clear()
        pStaticDataYPal.Clear()
        For i = 0 To xNodeRoot.ChildNodes.Count - 2
            pStaticNameYPal.Add(xNodeRoot.ChildNodes.Item(i).SelectSingleNode("Name").InnerText)
            pStaticDataYPal.Add(xNodeRoot.ChildNodes.Item(i).SelectSingleNode("Value").InnerText)
        Next
        pTSP = xNodeRoot.SelectSingleNode("TSP").InnerText

        xDoc = Nothing

    End Sub
    Public Sub ImportFSTUPGData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/SupplyFanData")

        pAirflow = xNodeRoot.SelectSingleNode("Airflow").InnerText
        pESP = xNodeRoot.SelectSingleNode("ESP").InnerText
        pRPM = xNodeRoot.SelectSingleNode("RPM").InnerText
        pDuctLoc = xNodeRoot.SelectSingleNode("DuctLoc").InnerText
        pMhp = xNodeRoot.SelectSingleNode("MotorHP").InnerText
        pBhp = xNodeRoot.SelectSingleNode("BHP").InnerText
        pPower = xNodeRoot.SelectSingleNode("FankW").InnerText
        pDriveType = xNodeRoot.SelectSingleNode("DriveType").InnerText

        xDoc = Nothing

    End Sub
    Public Sub ImportYPALData()
        Dim xdoc As XmlDocument = New XmlDocument
        Dim temp As String
        Dim dstart As Integer

        xdoc.Load(frmMain.txtBaseUnitFile.Text)


        Dim xnode As XmlNode
        'xnode = xdoc.SelectSingleNode("TaggedPDF-doc/Document/Table/TBody/TR")
        xnode = xdoc.SelectSingleNode("//TaggedPDF-doc/Sect/Table")

        xnode = xnode.NextSibling
        xnode = xnode.NextSibling

        xnode = xnode.SelectSingleNode("TR")
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        pAirflow = xnode.InnerText

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        pESP = xnode.InnerText

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TR")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        temp = xnode.InnerText
        dstart = (InStrRev(temp, "-")) + 1
        pMhp = Trim(Mid(temp, dstart))
        pMhp = Trim(Mid(pMhp, 1, Len(pMhp) - InStr(pMhp, "HP") + 1))

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        pBhp = xnode.InnerText
        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        pRPM = xnode.InnerText

        xdoc = Nothing
    End Sub


End Class
