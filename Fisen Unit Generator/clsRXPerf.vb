Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Public Class ClsRXPerf
    Private pFanStyle As String
    Private pAirflow As String
    Private pFanCount As String

    Private pESP As String
    Private pESPElev As String
    Private pTSP As String
    Private pRPM As String
    Private pMaxRPM As String
    Private pMhp As String
    Private pBhp As String
    Private pPower As String
    Private pDriveType As String
    Private pDuctLoc As String
    Private pInletPWL() As String = New String() {"-", "-", "-", "-", "-", "-", "-", "-"}
    Private pOutletPWL() As String = New String() {"-", "-", "-", "-", "-", "-", "-", "-"}
    Private pSPSItemDesc() As String = New String() {"-", "-", "-", "-", "-", "-"}
    Private pSPSItemData() As String = New String() {"-", "-", "-", "-", "-", "-"}
    Private pSPSItemDataElev() As String = New String() {"-", "-", "-", "-", "-", "-"}
    Private pCabEffects As String
    Private pCabEffectsElev As String
    Private pMotorText As String

    Private pInletdBW As String
    Private pOutletdBW As String
    Private pInletdBA5 As String
    Private pOutletdBA5 As String
    Private pFanSelected As String
    Private pXRangeFan As Boolean

    Private pUPGXFanPresent As Boolean

    Private pStaticSummaryItem As ArrayList = New ArrayList
    Private pStaticPSTP As ArrayList = New ArrayList
    Private pStaticPATP As ArrayList = New ArrayList

    Public Property UPGXFanPresent As Boolean
        Get
            Return pUPGXFanPresent
        End Get
        Set(value As Boolean)
            pUPGXFanPresent = value
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

    Public Property FanCount As String
        Get
            Return pFanCount
        End Get
        Set(value As String)
            pFanCount = value
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
    Public Property XRangeFan As Boolean
        Get
            XRangeFan = pXRangeFan
        End Get
        Set(value As Boolean)
            pXRangeFan = value
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

    Public Property MaxRPM As String
        Get
            Return pMaxRPM
        End Get
        Set(value As String)
            pMaxRPM = value
        End Set
    End Property
    Public Property FanStyle As String
        Get
            Return pFanStyle
        End Get
        Set(value As String)
            pFanStyle = value
            If pFanStyle = "" Then pFanStyle = "-"
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
            If pAirflow = "n/a" Then
                Return "-"
            Else
                Return Format(Val(pESP), "0.00")
            End If
        End Get
        Set(value As String)
            pESP = value
        End Set
    End Property
    Public Property TSP As String
        Get
            If pAirflow = "n/a" Then
                Return "-"
            Else
                Return Format(Val(pTSP), "0.00")
            End If

        End Get
        Set(value As String)
            pTSP = value
        End Set
    End Property
    Public Property RPM As String
        Get
            If pAirflow = "n/a" Then
                Return "-"
            Else
                Return Format(Val(pRPM), "0")
            End If
        End Get
        Set(value As String)
            pRPM = value
        End Set
    End Property
    Public Property MotorHP As String
        Get
            If pAirflow = "n/a" Then
                Return "-"
            Else
                Return pMhp
            End If
        End Get
        Set(value As String)
            pMhp = value
        End Set
    End Property
    Public Property BrakeHP As String
        Get
            If pAirflow = "n/a" Then
                Return "-"
            Else
                Return Format(Val(pBhp), "0.0")
            End If

        End Get
        Set(value As String)
            pBhp = value
        End Set
    End Property
    Public Property kWPower As String
        Get
            If pAirflow = "n/a" Then
                Return "-"
            Else
                Return Format(Val(pPower), "0.0")
            End If

        End Get
        Set(value As String)
            pPower = value
        End Set
    End Property
    Public Property DriveType As String
        Get
            If pAirflow = "n/a" Then
                Return "-"
            Else
                Return pDriveType
            End If

        End Get
        Set(value As String)
            pDriveType = value
        End Set
    End Property
    Public Property DuctLoc As String
        Get
            If pAirflow = "n/a" Then
                Return "-"
            Else
                Return pDuctLoc
            End If
        End Get
        Set(value As String)
            pDuctLoc = value
        End Set
    End Property
    Public Sub New()
        pFanStyle = "-"
        pAirflow = "n/a"
        pESP = "-"
        pTSP = "-"
        pRPM = "-"
        pMaxRPM = "-"
        pMhp = "-"
        pBhp = "-"
        pPower = "-"
        pDriveType = "-"
        pDuctLoc = "-"
        pFanCount = "1"
    End Sub
    Public Sub NoRXFans()
        pFanStyle = "-"
        pAirflow = "n/a"
        pESP = "-"
        pTSP = "-"
        pRPM = "-"
        pMhp = "-"
        pBhp = "-"
        pPower = "-"
        pDriveType = "-"
        pDuctLoc = "-"
        pOutletdBW = "-"
        pInletdBW = "-"
        pOutletdBA5 = "-"
        pInletdBA5 = "-"
    End Sub
    Public Sub ImportUPGData()
        Dim xdoc As XmlDocument = New XmlDocument
        xdoc.Load(frmMain.txtBaseUnitFile.Text)
        Dim xnodelist As XmlNodeList = xdoc.SelectNodes("//HvacQuote/LineItems/HvacQuoteLineItem")
        Dim xnode As XmlNode
        xnode = xdoc.SelectSingleNode("//HvacQuote/Performance/Dictionary/KeyValuePair[contains(.,'" & frmMain.ThisUnit.PerformanceID & "')]")
        pAirflow = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/ExhaustAirBlower").SelectSingleNode("Airflow").InnerText
        If pAirflow > 0 Then pFanStyle = "Exhaust"
        pESP = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/ExhaustAirBlower").SelectSingleNode("StaticPressure").InnerText
        pTSP = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/ExhaustAirBlower").SelectSingleNode("UnitStaticResistance").InnerText
        pRPM = xnode.SelectSingleNode("Value/SystemPerformance/ExhaustAirBlower").SelectSingleNode("Rpm").InnerText
        pMhp = xnode.SelectSingleNode("Value/SystemPerformance/ExhaustAirBlower").SelectSingleNode("MotorRatingHP").InnerText
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
    Public Sub ImportFSTUPGData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/RXFanData")
        If xNodeRoot.SelectSingleNode("Present").InnerText = "True" Then
            pFanStyle = "Exhaust"
            pAirflow = xNodeRoot.SelectSingleNode("Airflow").InnerText
            pESP = xNodeRoot.SelectSingleNode("ESP").InnerText
            pRPM = xNodeRoot.SelectSingleNode("RPM").InnerText
            pDuctLoc = xNodeRoot.SelectSingleNode("DuctLoc").InnerText
            pMhp = xNodeRoot.SelectSingleNode("MotorHP").InnerText
            pBhp = xNodeRoot.SelectSingleNode("BHP").InnerText
            pPower = xNodeRoot.SelectSingleNode("FankW").InnerText
            pDriveType = xNodeRoot.SelectSingleNode("DriveType").InnerText
        End If
        xDoc = Nothing

    End Sub
    Public Sub ImportFSTYPALData()
        Dim xDoc As XmlDocument = New XmlDocument
        Dim temp As String

        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/RXFanData")

        temp = xNodeRoot.SelectSingleNode("FanType").InnerText
        Select Case temp
            Case Is = "-"
                pFanStyle = "-"
            Case Is = "Return"
                pFanStyle = "Return"
            Case Is = "Exhaust"
                pFanStyle = "Exhaust"
            Case Else
                pFanStyle = "***ERROR***"
        End Select

        pAirflow = xNodeRoot.SelectSingleNode("Airflow").InnerText
        pESP = xNodeRoot.SelectSingleNode("ESP").InnerText
        pRPM = xNodeRoot.SelectSingleNode("RPM").InnerText

        pMotorText = xNodeRoot.SelectSingleNode("MotorText").InnerText
        pFanSelected = xNodeRoot.SelectSingleNode("FanName").InnerText

        pMhp = xNodeRoot.SelectSingleNode("MotorHP").InnerText
        pBhp = xNodeRoot.SelectSingleNode("BHP").InnerText

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/SupplyFanData/StaticPressureSummary")

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
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.SelectSingleNode("P")
        pFanStyle = Trim(Mid(xnode.InnerText, 1, InStr(xnode.InnerText, " ")))
        xnode = xnode.ParentNode

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
        'stop here
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
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        temp = xnode.InnerText
        dstart = (InStrRev(temp, "-")) + 1
        pMhp = Trim(Mid(temp, dstart))
        temp = InStr(pMhp, "HP")
        pMhp = Trim(Mid(pMhp, 1, (InStr(pMhp, " ") - 1)))

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.NextSibling

        xnode = xnode.SelectSingleNode("TD")
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
