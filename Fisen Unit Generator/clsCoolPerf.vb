Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Public Class clsCoolPerf
    Private pTCap As String
    Private pSCap As String
    Private pLCap As String
    Private pEff As String
    Private pAmbDB As String
    Private pEntDB As String
    Private pEntWB As String
    Private pLvgDB As String
    Private pLvgWB As String
    Private pLvgDBUnit As String
    Private pLvgWBUnit As String
    Private pIEER As String
    Private pPower As String
    Private pElev As String
    Private pFaceV As String
    Private pRef As String
    Private pSuctionP As String
    Private pSuctionT As String

    Public Property LCap
        Get
            LCap = Format(pLCap, "0.0")
        End Get
        Set(value)
            pLCap = value
        End Set
    End Property
    Public Property SuctionT As String
        Get
            SuctionT = Format(Val(pSuctionT), "0.0")
        End Get
        Set(value As String)
            pSuctionT = value
        End Set
    End Property
    Public Property SuctionP As String
        Get
            SuctionP = Format(Val(pSuctionP), "0.0")
        End Get
        Set(value As String)
            pSuctionP = value
        End Set
    End Property
    Public Property FaceVelocity As String
        Get
            FaceVelocity = Format(Val(pFaceV), "0.0")
        End Get
        Set(value As String)
            pFaceV = value
        End Set
    End Property
    Public Property IEER() As String
        Get
            IEER = Format(Val(pIEER), "0.0")
        End Get
        Set(value As String)
            pIEER = value
        End Set
    End Property
    Public Property LeavingDBUnit() As String
        Get
            LeavingDBUnit = Format(Val(pLvgDBUnit), "0.0")
        End Get
        Set(value As String)
            pLvgDBUnit = value
        End Set
    End Property
    Public Property LeavingWBUnit As String
        Get
            LeavingWBUnit = Format(Val(pLvgWBUnit), "0.0")
        End Get
        Set(value As String)
            pLvgWBUnit = value
        End Set
    End Property
    Public Property TotalCapacity As String
        Get
            TotalCapacity = Format(Val(pTCap), "0.0")
        End Get
        Set(value As String)
            pTCap = value
        End Set
    End Property
    Public Property SensibleCapacity As String
        Get
            SensibleCapacity = Format(Val(pSCap), "0.0")
        End Get
        Set(value As String)
            pSCap = value
        End Set
    End Property
    Public Property Efficiency As String
        Get
            Efficiency = Format(Val(pEff), "0.0")
        End Get
        Set(value As String)
            pEff = value
        End Set
    End Property
    Public Property Refrigerant As String
        Get
            Refrigerant = pRef
        End Get
        Set(value As String)
            pRef = value
        End Set
    End Property
    Public Property AmbientDB As String
        Get
            AmbientDB = Format(Val(pAmbDB), "0.0")
        End Get
        Set(value As String)
            pAmbDB = value
        End Set
    End Property
    Public Property EnteringDB As String
        Get
            EnteringDB = Format(Val(pEntDB), "0.0")
        End Get
        Set(value As String)
            pEntDB = value
        End Set
    End Property
    Public Property EnteringWB As String
        Get
            EnteringWB = Format(Val(pEntWB), "0.0")
        End Get
        Set(value As String)
            pEntWB = value
        End Set
    End Property
    Public Property LeavingDB As String
        Get
            LeavingDB = Format(Val(pLvgDB), "0.0")
        End Get
        Set(value As String)
            pLvgDB = value
        End Set
    End Property
    Public Property LeavingWB As String
        Get
            LeavingWB = Format(Val(pLvgWB), "0.0")
        End Get
        Set(value As String)
            pLvgWB = value
        End Set
    End Property
    Public Property Power As String
        Get
            Power = Format(Val(pPower), "0.0")
        End Get
        Set(value As String)
            pPower = value
        End Set
    End Property
    Public Property Elevation As String
        Get
            Elevation = Format(Val(pElev), "0.0")
        End Get
        Set(value As String)
            pElev = value
        End Set
    End Property
    Public Sub New()
        pTCap = "-99.9"
        pSCap = "-99.9"
        pEff = "-99.9"
        pAmbDB = "95.0"
        pEntWB = "67"
        pEntDB = "80"
        pLvgDB = "-99.9"
        pLvgWB = "-99.9"
        pLvgDBUnit = "-99.0"
        pLvgWBUnit = " - 99.0"
        pIEER = "-10.0"
        pPower = "-99.9"
        pElev = "-99.9"
        pFaceV = "999.9"
        pRef = "R999Z"
        pSuctionP = "0.0"
        pSuctionT = "0.0"
    End Sub
    Public Sub ImportUPGData()
        Dim xdoc As XmlDocument = New XmlDocument
        xdoc.Load(frmMain.txtBaseUnitFile.Text)
        Dim xnodelist As XmlNodeList = xdoc.SelectNodes("//HvacQuote/LineItems/HvacQuoteLineItem")
        Dim xnode As XmlNode
        xnode = xdoc.SelectSingleNode("//HvacQuote/Performance/Dictionary/KeyValuePair[contains(.,'" & frmMain.ThisUnit.PerformanceID & "')]")
        pTCap = xnode.SelectSingleNode("Value/SystemPerformance/Cooling").SelectSingleNode("TotalCapacityMbh").InnerText
        pSCap = xnode.SelectSingleNode("Value/SystemPerformance/Cooling").SelectSingleNode("SensibleCapacityMbh").InnerText
        pEff = xnode.SelectSingleNode("Value/SystemPerformance/Cooling").SelectSingleNode("Ieer").InnerText
        pPower = xnode.SelectSingleNode("Value/SystemPerformance/Cooling").SelectSingleNode("PowerInputKw").InnerText
        pLvgDB = xnode.SelectSingleNode("Value/SystemPerformance/Cooling").SelectSingleNode("LeavingDrybulb").InnerText
        pLvgWB = xnode.SelectSingleNode("Value/SystemPerformance/Cooling").SelectSingleNode("LeavingWetbulb").InnerText
        pRef = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/Cooling").SelectSingleNode("RefrigerantType").InnerText
        pAmbDB = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/Cooling").SelectSingleNode("AmbientDrybulb").InnerText
        pEntDB = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/Cooling").SelectSingleNode("EnteringDrybulb").InnerText
        pEntWB = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/Cooling").SelectSingleNode("EnteringWetbulb").InnerText
        pElev = xnode.SelectSingleNode("Value/SystemPerformance/Conditions").SelectSingleNode("Altitude").InnerText
        pSuctionP = xnode.SelectSingleNode("Value/SystemPerformance/Cooling").SelectSingleNode("SuctionPressure").InnerText
        pSuctionT = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/Cooling").SelectSingleNode("SaturatedSuctionTemp").InnerText

        xdoc = Nothing
    End Sub
    Public Sub ImportFSTUPGData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/CoolingData")

        pTCap = xNodeRoot.SelectSingleNode("TCap").InnerText
        pSCap = xNodeRoot.SelectSingleNode("SCap").InnerText
        pEff = xNodeRoot.SelectSingleNode("Eff").InnerText
        pAmbDB = xNodeRoot.SelectSingleNode("Ambient").InnerText
        pEntDB = xNodeRoot.SelectSingleNode("EATdb").InnerText
        pEntWB = xNodeRoot.SelectSingleNode("EATwb").InnerText
        pLvgDB = xNodeRoot.SelectSingleNode("LATdb").InnerText
        pLvgWB = xNodeRoot.SelectSingleNode("LATwb").InnerText
        pPower = xNodeRoot.SelectSingleNode("Power").InnerText
        pRef = xNodeRoot.SelectSingleNode("Refrigerant").InnerText

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/SupplyFanData")
        pElev = xNodeRoot.SelectSingleNode("Elevation").InnerText

        xDoc = Nothing

    End Sub
    Public Sub ImportFSTYPALData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/CoolingData")

        pTCap = xNodeRoot.SelectSingleNode("TCap").InnerText
        pSCap = xNodeRoot.SelectSingleNode("SCap").InnerText
        pLCap = Format(Val(pTCap) - Val(pSCap), "0.0")

        pAmbDB = xNodeRoot.SelectSingleNode("Ambient").InnerText
        pEntDB = xNodeRoot.SelectSingleNode("EATdb").InnerText
        pEntWB = xNodeRoot.SelectSingleNode("EATwb").InnerText
        pLvgDB = xNodeRoot.SelectSingleNode("LATdb").InnerText
        pLvgWB = xNodeRoot.SelectSingleNode("LATwb").InnerText
        pLvgDBUnit = xNodeRoot.SelectSingleNode("LATdbUnit").InnerText
        pLvgWBUnit = xNodeRoot.SelectSingleNode("LATwbUnit").InnerText
        pFaceV = xNodeRoot.SelectSingleNode("FaceVelocity").InnerText
        pPower = xNodeRoot.SelectSingleNode("Power").InnerText
        pEff = xNodeRoot.SelectSingleNode("EER").InnerText
        pIEER = xNodeRoot.SelectSingleNode("IEER").InnerText

        pRef = xNodeRoot.SelectSingleNode("Refrigerant").InnerText

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/SupplyFanData")
        pElev = xNodeRoot.SelectSingleNode("Elevation").InnerText

        xDoc = Nothing

    End Sub
    Public Sub ImportYPALData()

        Dim xdoc As XmlDocument = New XmlDocument
        xdoc.Load(frmMain.txtBaseUnitFile.Text)
        Dim xnode As XmlNode
        Dim temp As String

        xnode = xdoc.SelectSingleNode("//TaggedPDF-doc/Sect/Table")
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
        pTCap = xnode.InnerText

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        pSCap = xnode.InnerText

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        pLCap = xnode.InnerText

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        temp = xnode.InnerText
        pEntDB = Mid(temp, 1, InStr(temp, "/") - 2)
        pEntWB = Mid(temp, InStr(temp, "/") + 2)

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        temp = xnode.InnerText
        pLvgDB = Mid(temp, 1, InStr(temp, "/") - 2)
        pLvgWB = Mid(temp, InStr(temp, "/") + 2)

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        temp = xnode.InnerText
        pLvgDBUnit = Mid(temp, 1, InStr(temp, "/") - 2)
        pLvgWBUnit = Mid(temp, InStr(temp, "/") + 2)

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.SelectSingleNode("P")
        If Trim(xnode.InnerText) <> "Face Velocity" Then
            xnode = xnode.ParentNode
            xnode = xnode.ParentNode
            xnode = xnode.NextSibling
            xnode = xnode.SelectSingleNode("TD")
            xnode = xnode.SelectSingleNode("P")
            If Trim(xnode.InnerText) <> "Face Velocity" Then
                xnode = xnode.ParentNode
                xnode = xnode.ParentNode
                xnode = xnode.NextSibling
                xnode = xnode.SelectSingleNode("TD")
                xnode = xnode.SelectSingleNode("P")
            End If
        End If
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        pFaceV = xnode.InnerText

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        pPower = xnode.InnerText

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        pEff = xnode.InnerText

        xnode = xnode.ParentNode
        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        pIEER = xnode.InnerText

    End Sub
End Class
