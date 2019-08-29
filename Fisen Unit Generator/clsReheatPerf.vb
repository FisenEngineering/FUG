Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Public Class clsReheatPerf
    Private pContType As String
    Private pRHCap As String
    Private pRHFlow As String
    Private pEAT As String
    Private pLAT As String
    Private pDeltaT As String
    Private pDHCap As String
    Private pCoilAPD As String
    Private pPipeStyle As String
    Private pCircuitsRH As String

    Private pEATdb As String
    Private pEATwb As String
    Private pLATdb As String
    Private pLATwb As String
    Private pPower As String
    Private pGPH As String

    Public Property GPH As String
        Get
            Return pGPH
        End Get
        Set(value As String)
            pGPH = value
        End Set
    End Property

    Public Property Power As String
        Get
            Return pPower
        End Get
        Set(value As String)
            pPower = value
        End Set
    End Property

    Public Property LATwb As String
        Get
            Return pLATwb
        End Get
        Set(value As String)
            pLATwb = value
        End Set
    End Property

    Public Property LATdb As String
        Get
            Return pLATdb
        End Get
        Set(value As String)
            pLATdb = value
        End Set
    End Property

    Public Property EATwb As String
        Get
            Return pEATwb
        End Get
        Set(value As String)
            pEATwb = value
        End Set
    End Property

    Public Property EATdb As String
        Get
            Return pEATdb
        End Get
        Set(value As String)
            pEATdb = value
        End Set
    End Property
    Public Property CircuitsRH As String
        Get
            Return pCircuitsRH
        End Get
        Set(value As String)
            pCircuitsRH = value
        End Set
    End Property
    Public Property ControlType As String
        Get
            Return pContType
        End Get
        Set(value As String)
            pContType = value
        End Set
    End Property
    Public Property RHCapacity As String
        Get
            If pContType = "n/a" Then
                Return "-"
            Else
                Return Format(Val(pRHCap), "0.0")
            End If
        End Get
        Set(value As String)
            pRHCap = value
        End Set
    End Property
    Public Property RHAirflow As String
        Get
            If pContType = "n/a" Then
                Return "-"
            Else
                Return Format(Val(pRHFlow), "0")
            End If
        End Get
        Set(value As String)
            pRHFlow = value
        End Set
    End Property
    Public Property EAT As String
        Get
            If pContType = "n/a" Then
                Return "-"
            Else
                Return Format(Val(pEAT), "0.0")
            End If
        End Get
        Set(value As String)
            pEAT = value
        End Set
    End Property
    Public Property LAT As String
        Get
            If pContType = "n/a" Then
                Return "-"
            Else
                Return Format(Val(pLAT), "0.0")
            End If
        End Get
        Set(value As String)
            pLAT = value
        End Set
    End Property
    Public ReadOnly Property DeltaT As String
        Get
            If pContType = "n/a" Then
                Return "-"
            Else
                Return Format(Val(pLAT) - Val(pEAT), "0.0")
            End If
        End Get
    End Property
    Public Property DHCapacity As String
        Get
            If pContType = "n/a" Then
                Return "-"
            Else
                Return Format(Val(pDHCap), "0.0")
            End If
        End Get
        Set(value As String)
            pDHCap = value
        End Set
    End Property
    Public Property CoilAPD As String
        Get
            If pContType = "n/a" Then
                Return "-"
            Else
                Return Format(Val(pCoilAPD), "0.0")
            End If
        End Get
        Set(value As String)
            pCoilAPD = value
        End Set
    End Property
    Public Property PipingStyle As String
        Get
            Return pPipeStyle
        End Get
        Set(value As String)
            pPipeStyle = value
        End Set
    End Property
    Public Sub New()
        pContType = "On/Off"
        pRHCap = "-99.9"
        pRHFlow = "-99.9"
        pEAT = "-99.9"
        pLAT = "-99.9"
        pDHCap = " "
        pCoilAPD = "n/a"
        pPipeStyle = "Parallel"
    End Sub
    Public Sub ImportUPGData()
        Dim xdoc As XmlDocument = New XmlDocument
        xdoc.Load(frmMain.txtBaseUnitFile.Text)
        Dim xnodelist As XmlNodeList = xdoc.SelectNodes("//HvacQuote/LineItems/HvacQuoteLineItem")
        Dim xnode As XmlNode
        Dim temp As String
        xnode = xdoc.SelectSingleNode("//HvacQuote/Performance/Dictionary/KeyValuePair[contains(.,'" & frmMain.ThisUnit.PerformanceID & "')]")
        pRHCap = xnode.SelectSingleNode("Value/SystemPerformance/Reheat").SelectSingleNode("SensibleCapacityMbh").InnerText
        temp = xnode.SelectSingleNode("Value/SystemPerformance/Reheat").SelectSingleNode("TotalCapacityMbh").InnerText
        If Val(temp) > Val(pRHCap) Then pRHCap = temp

        pEAT = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/Reheat").SelectSingleNode("EnteringDrybulb").InnerText
        pLAT = xnode.SelectSingleNode("Value/SystemPerformance/Reheat").SelectSingleNode("LeavingDrybulb").InnerText
        pDHCap = xnode.SelectSingleNode("Value/SystemPerformance/Reheat").SelectSingleNode("GallonsRemovedPerHour").InnerText
        xdoc = Nothing
        If pRHCap = "0" Then Call NoReheat()
    End Sub
    Public Sub ImportFSTUPGData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/ReheatData")

        pContType = xNodeRoot.SelectSingleNode("ReheatStyle").InnerText

        pRHCap = xNodeRoot.SelectSingleNode("TCap").InnerText
        pEATdb = xNodeRoot.SelectSingleNode("EATdb").InnerText
        pEAT = pEATdb
        pEATwb = xNodeRoot.SelectSingleNode("EATwb").InnerText
        pLATdb = xNodeRoot.SelectSingleNode("LATdb").InnerText
        pLAT = pLATdb
        pLATwb = xNodeRoot.SelectSingleNode("LATwb").InnerText
        pPower = xNodeRoot.SelectSingleNode("Power").InnerText
        pGPH = xNodeRoot.SelectSingleNode("GPH").InnerText
        If IsNumeric(pGPH) Then
            pDHCap = Str(Val(pGPH) * 8.345)
        End If
        xDoc = Nothing

        If ((pContType = "No Reheat") Or (pContType = "None")) Then Call NoReheat()


    End Sub
    Public Sub NoReheat()
        pContType = "n/a"
        pRHCap = "-"
        pRHFlow = "-"
        pEAT = "-"
        pLAT = "-"
        pDHCap = "-"
        pCoilAPD = "-"
        pPipeStyle = "-"
        pRHCap = "-"
        pEATdb = "-"
        pEATwb = "-"
        pLATdb = "-"
        pLATwb = "-"
        pPower = "-"
        pGPH = "-"
    End Sub
End Class
