Public Class clsWarrTest
    Private pQA As Boolean
    Private pAFlow As Boolean
    Private pCoilPress As Boolean
    Private pCtrls As Boolean
    Private pMotor As Boolean
    Private pElecHeat As Boolean
    Private pGasHeat As Boolean
    Private pGasTrain As Boolean
    Private pHydroPTest As Boolean
    Private pRefTest As Boolean
    Private pRefInsp As Boolean
    Private p1YrParts As Boolean
    Private p5YrParts As Boolean
    Private p1YrLabor As Boolean
    Private p5YrLabor As Boolean
    Private pCompWarr As String
    Private pHXWarr As String
    Private pNote4 As String

    Property Note4 As String
        Get
            Return pNote4
        End Get
        Set(value As String)
            pNote4 = value
        End Set
    End Property


    Property QA As Boolean
        Get
            QA = pQA
        End Get
        Set(value As Boolean)
            pQA = value
        End Set
    End Property
    Property AirflowTest As Boolean
        Get
            AirflowTest = pAFlow
        End Get
        Set(value As Boolean)
            pAFlow = value
        End Set
    End Property
    Property CoilTest As Boolean
        Get
            CoilTest = pCoilPress
        End Get
        Set(value As Boolean)
            pCoilPress = value
        End Set
    End Property
    Property CtrlTest As Boolean
        Get
            CtrlTest = pCtrls
        End Get
        Set(value As Boolean)
            pCtrls = value
        End Set
    End Property
    Property MotorTest As Boolean
        Get
            MotorTest = pMotor
        End Get
        Set(value As Boolean)
            pMotor = value
        End Set
    End Property
    Property EHeatTest As Boolean
        Get
            EHeatTest = pElecHeat
        End Get
        Set(value As Boolean)
            pElecHeat = value
        End Set
    End Property
    Property GHeatTest As Boolean
        Get
            GHeatTest = pGasHeat
        End Get
        Set(value As Boolean)
            pGasHeat = value
        End Set
    End Property
    Property GasTrainTest As Boolean
        Get
            GasTrainTest = pGasTrain
        End Get
        Set(value As Boolean)
            pGasTrain = value
        End Set
    End Property
    Property HydroPress As Boolean
        Get
            HydroPress = pHydroPTest
        End Get
        Set(value As Boolean)
            pHydroPTest = value
        End Set
    End Property
    Property RefTest As Boolean
        Get
            RefTest = pRefTest
        End Get
        Set(value As Boolean)
            pRefTest = value
        End Set
    End Property
    Property RefInsp As Boolean
        Get
            RefInsp = pRefInsp
        End Get
        Set(value As Boolean)
            pRefInsp = value
        End Set
    End Property
    Property Parts1yr As Boolean
        Get
            Parts1yr = p1YrParts
        End Get
        Set(value As Boolean)
            p1YrParts = value
            If value = True Then
                p5YrParts = False
                p1YrLabor = False
                p5YrLabor = False
            End If
        End Set
    End Property
    Property Parts5yr As Boolean
        Get
            Parts5yr = p5YrParts
        End Get
        Set(value As Boolean)
            p5YrParts = value
            p1YrParts = False
            p1YrLabor = False
            p5YrLabor = False
        End Set
    End Property
    Property Labor1yr As Boolean
        Get
            Labor1yr = p1YrLabor
        End Get
        Set(value As Boolean)
            p1YrLabor = value
            p5YrParts = False
            p1YrParts = False
            p5YrLabor = False
        End Set
    End Property
    Property Labor5yr As Boolean
        Get
            Labor5yr = p5YrLabor
        End Get
        Set(value As Boolean)
            p5YrLabor = value
            p5YrParts = False
            p1YrLabor = False
            p1YrParts = False
        End Set
    End Property
    Property CompWarr As String
        Get
            CompWarr = pCompWarr

        End Get
        Set(value As String)
            pCompWarr = value
        End Set
    End Property
    Property HXWarr As String
        Get
            HXWarr = pHXWarr

        End Get
        Set(value As String)
            pHXWarr = value
        End Set
    End Property
    Public Sub New()
        pQA = True
        pAFlow = False
        pCoilPress = False
        pCtrls = False
        pMotor = False
        pElecHeat = False
        pGasHeat = False
        pGasTrain = False
        pHydroPTest = False
        pRefTest = False
        pRefInsp = False
        p1YrParts = True
        p1YrLabor = False
        p5YrParts = False
        p5YrLabor = False
        pCompWarr = "One (1) Year Warranty - #Brand# Compressors and Electric Heater Elements"
        pHXWarr = "Ten (10) Year Warranty - Aluminized Steel Tubular Heat Exchangers"
        pNote4 = "-"
    End Sub
End Class
