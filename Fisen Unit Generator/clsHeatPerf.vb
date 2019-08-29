Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Public Class clsHeatPerf
    'Static Properties
    Private pType As String
    Private pControlStyle As String
    Private pOutCap As String
    Private pInCap As String
    Private pSSE As String
    Private pAFlow As String
    Private pEAT As String
    Private pLAT As String
    Private pDeltaT As String

    'Variable Properties
    Private pStmPres As String
    Private pCondFlow As String
    Private pCoilAPD As String
    Private pFluid As String
    Private pFluidFlow As String
    Private pEFT As String
    Private pLFT As String
    Private pFPD As String
    Private pNominalEH As String
    Private pAppliedEH As String
    Private pGasHeatContent As String
    Private pGasConsumption As String

    Public Property GasHeatContent As String
        Get
            Return pGasHeatContent
        End Get
        Set(value As String)
            pGasHeatContent = value
        End Set
    End Property

    Public Property GasConsumption As String
        Get
            Return pGasConsumption
        End Get
        Set(value As String)
            pGasConsumption = value
        End Set
    End Property

    Public Property HeatType As String
        Get
            HeatType = pType
        End Get
        Set(value As String)
            pType = value
        End Set
    End Property
    Public Property ControlStyle As String
        Get
            ControlStyle = pControlStyle
        End Get
        Set(value As String)
            pControlStyle = value
        End Set
    End Property
    Public Property OutputCapacity As String
        Get
            OutputCapacity = Format(Val(pOutCap), "0.0")
        End Get
        Set(value As String)
            pOutCap = value
        End Set
    End Property
    Public Property InputCapacity As String
        Get
            InputCapacity = Format(Val(pInCap), "0.0")
        End Get
        Set(value As String)
            pInCap = value
        End Set
    End Property
    Public Property Airflow As String
        Get
            Airflow = Format(Val(pAFlow), "0")
        End Get
        Set(value As String)
            pAFlow = value
        End Set
    End Property
    Public Property EnteringAirTemp As String
        Get
            EnteringAirTemp = Format(Val(pEAT), "0.0")
        End Get
        Set(value As String)
            pEAT = value
        End Set
    End Property
    Public Property LeavingAirTemp As String
        Get
            LeavingAirTemp = Format(Val(pLAT), "0.0")
        End Get
        Set(value As String)
            pLAT = value
        End Set
    End Property
    Public Property DeltaT As String
        Get
            DeltaT = Format(Val(pDeltaT), "0.0")
        End Get
        Set(value As String)
            pDeltaT = value
        End Set
    End Property
    Public Property SteamPressure As String
        Get
            SteamPressure = Format(Val(pStmPres), "0.0")
        End Get
        Set(value As String)
            pStmPres = value
        End Set
    End Property
    Public Property CondensateFlow As String
        Get
            CondensateFlow = Format(Val(pCondFlow), "0.0")
        End Get
        Set(value As String)
            pCondFlow = value
        End Set
    End Property
    Public Property CoilAPD As String
        Get
            CoilAPD = Format(Val(pCoilAPD), "0.00")
        End Get
        Set(value As String)
            pCoilAPD = value
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
    Public Property FluidFlow As String
        Get
            FluidFlow = Format(Val(pFluidFlow), "0.0")
        End Get
        Set(value As String)
            pFluidFlow = value
        End Set
    End Property
    Public Property EntFluidTemp As String
        Get
            EntFluidTemp = Format(Val(pEFT), "0.0")
        End Get
        Set(value As String)
            pEFT = value
        End Set
    End Property
    Public Property LvgFluidTemp As String
        Get
            LvgFluidTemp = Format(Val(pLFT), "0.0")
        End Get
        Set(value As String)
            pLFT = value
        End Set
    End Property
    Public Property FluidPressureDrop As String
        Get
            FluidPressureDrop = Format(Val(pFPD), "0.0")
        End Get
        Set(value As String)
            pFPD = value
        End Set
    End Property
    Public Property AppliedEHeat As String
        Get
            AppliedEHeat = Format(Val(pAppliedEH), "0.0")
        End Get
        Set(value As String)
            pAppliedEH = value
        End Set
    End Property
    Public Property NominalEHeat As String
        Get
            NominalEHeat = Format(Val(pNominalEH), "0.0")
        End Get
        Set(value As String)
            pNominalEH = value
        End Set
    End Property
    Public Property SSE As String
        Get
            SSE = Format(Val(pSSE), "0.0")
        End Get
        Set(value As String)
            pSSE = value
        End Set
    End Property

    Public Sub New()
        pType = "None"
        pControlStyle = "n/a"
        pOutCap = "-"
        pInCap = "-"
        pSSE = "-"
        pAFlow = "-"
        pEAT = "-"
        pLAT = "-"
        pDeltaT = "-"
        pStmPres = "-"
        pCondFlow = "-"
        pCoilAPD = "-"
        pFluid = "-"
        pFluidFlow = "-"
        pEFT = "-"
        pLFT = "-"
        pFPD = "-"
        pNominalEH = "-"
        pAppliedEH = "-"
        pGasConsumption = "-"
        pGasHeatContent = "1035.0"
    End Sub
    Public Sub ImportFSTUPGData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/HeatingData")

        pType = xNodeRoot.SelectSingleNode("HeatType").InnerText

        If pType = "Electric" Then
            pEAT = xNodeRoot.SelectSingleNode("EATdb").InnerText
            pOutCap = xNodeRoot.SelectSingleNode("CapOut").InnerText
            pNominalEH = xNodeRoot.SelectSingleNode("NominalElectricHeat").InnerText
            pAppliedEH = xNodeRoot.SelectSingleNode("AppliedElectricHeat").InnerText

            pAFlow = xNodeRoot.SelectSingleNode("SupplyAir").InnerText
            pLAT = xNodeRoot.SelectSingleNode("LeavingDB").InnerText
            pDeltaT = xNodeRoot.SelectSingleNode("AirTempRise").InnerText
            pDeltaT = Val(pLAT) - Val(pEAT)
            pControlStyle = "Staged"
        End If

        If pType = "Gas Heat" Then
            pEAT = xNodeRoot.SelectSingleNode("EATdb").InnerText
            pOutCap = xNodeRoot.SelectSingleNode("CapOut").InnerText
            pAFlow = xNodeRoot.SelectSingleNode("HeatAirflow").InnerText
            pInCap = xNodeRoot.SelectSingleNode("CapIn").InnerText
            pLAT = xNodeRoot.SelectSingleNode("LATdb").InnerText
            pSSE = xNodeRoot.SelectSingleNode("SSE").InnerText
            pDeltaT = Val(pLAT) - Val(pEAT)
            pControlStyle = "Staged"
        End If

        If pType = "No Heat" Then
            pType = "None"
        End If


        xDoc = Nothing

    End Sub
    Public Sub ImportFSTYPALData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/HeatingData")

        pType = xNodeRoot.SelectSingleNode("HeatType").InnerText

        If pType = "Electric Heat" Then
            pEAT = xNodeRoot.SelectSingleNode("EATdb").InnerText
            pOutCap = xNodeRoot.SelectSingleNode("CapOut").InnerText
            pNominalEH = xNodeRoot.SelectSingleNode("NominalElectricHeat").InnerText
            pAppliedEH = xNodeRoot.SelectSingleNode("AppliedElectricHeat").InnerText

            pAFlow = xNodeRoot.SelectSingleNode("SupplyAir").InnerText
            pLAT = xNodeRoot.SelectSingleNode("LeavingDB").InnerText
            pDeltaT = xNodeRoot.SelectSingleNode("AirTempRise").InnerText
        End If

        If pType = "Gas Heat" Then
            pOutCap = xNodeRoot.SelectSingleNode("CapOut").InnerText
            pInCap = xNodeRoot.SelectSingleNode("CapIn").InnerText

            pEAT = xNodeRoot.SelectSingleNode("EATdb").InnerText
            pLAT = xNodeRoot.SelectSingleNode("LATdb").InnerText
            pAFlow = xNodeRoot.SelectSingleNode("HeatAirflow").InnerText
            pGasConsumption = xNodeRoot.SelectSingleNode("GasConsumption").InnerText
            pGasHeatContent = xNodeRoot.SelectSingleNode("GasHeatContent").InnerText
            pSSE = "80.0"
            pDeltaT = Val(pLAT) - Val(pEAT)
            pControlStyle = xNodeRoot.SelectSingleNode("ControlStyle").InnerText
        End If

        xDoc = Nothing

    End Sub
    Public Sub ImportUPGData()
        Dim xdoc As XmlDocument = New XmlDocument
        xdoc.Load(frmMain.txtBaseUnitFile.Text)
        Dim xnodelist As XmlNodeList = xdoc.SelectNodes("//HvacQuote/LineItems/HvacQuoteLineItem")
        Dim xnode As XmlNode
        xnode = xdoc.SelectSingleNode("//HvacQuote/Performance/Dictionary/KeyValuePair[contains(.,'" & frmMain.ThisUnit.PerformanceID & "')]")
        pOutCap = xnode.SelectSingleNode("Value/SystemPerformance/Heating").SelectSingleNode("MaxOutputCapacityMbh").InnerText
        pInCap = xnode.SelectSingleNode("Value/SystemPerformance/Heating").SelectSingleNode("MaxInputCapacityMbh").InnerText
        pSSE = xnode.SelectSingleNode("Value/SystemPerformance/Heating").SelectSingleNode("SSE").InnerText
        pEAT = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/Heating").SelectSingleNode("EnteringDrybulb").InnerText
        pType = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/Heating").SelectSingleNode("HeatType").InnerText
        If pType = "None" Then
            pControlStyle = "n/a"
            pOutCap = "-"
            pInCap = "-"
            pSSE = "-"
            pAFlow = "-"
            pEAT = "-"
            pLAT = "-"
            pDeltaT = "-"
            pStmPres = "-"
            pCondFlow = "-"
            pCoilAPD = "-"
            pFluid = "-"
            pFluidFlow = "-"
            pEFT = "-"
            pLFT = "-"
            pFPD = "-"
            pNominalEH = "-"
            pAppliedEH = "-"
        End If

        If pType = "Gas" Then
            pControlStyle = "Staged"
        End If
        pLAT = xnode.SelectSingleNode("Value/SystemPerformance/Heating").SelectSingleNode("LeavingAirTemperature").InnerText
        If ((IsNumeric(pLAT)) And (IsNumeric(pEAT))) Then
            pDeltaT = pLAT - pEAT
        Else
            pDeltaT = "-"
        End If

        pStmPres = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/Heating").SelectSingleNode("SteamPressurePsig").InnerText
        pCondFlow = xnode.SelectSingleNode("Value/SystemPerformance/Heating").SelectSingleNode("SteamRate").InnerText
        If xnode.SelectSingleNode("Value/SystemPerformance/Conditions/Heating").SelectSingleNode("GlycolPercentage").InnerText = "0" Then
            pFluid = "Water"
        Else
            pFluid = "PG" & xnode.SelectSingleNode("Value/SystemPerformance/Conditions/Heating").SelectSingleNode("GlycolPercentage").InnerText
        End If
        pFluidFlow = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/Heating").SelectSingleNode("FlowrateGpm").InnerText
        pEFT = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/Heating").SelectSingleNode("EnteringWaterTemperature").InnerText
        pLFT = xnode.SelectSingleNode("Value/SystemPerformance/Heating").SelectSingleNode("LeavingWaterTemperature").InnerText
        pNominalEH = xnode.SelectSingleNode("Value/SystemPerformance/Conditions/Heating").SelectSingleNode("NominalElectricHeatPowerKw").InnerText
        pAppliedEH = xnode.SelectSingleNode("Value/SystemPerformance/Heating").SelectSingleNode("AppliedElectricHeatPowerKw").InnerText
        xdoc = Nothing
    End Sub
End Class
