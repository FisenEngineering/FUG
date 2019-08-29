Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Public Class ClsHydronicsData
    Private pInletSize As String
    Private pOutletSize As String
    Private pFlow As String
    Private pFluid As String
    Private pPercentByWeight As String

    Private _butterflyValveSizes As ArrayList = New ArrayList
    Private _butterflyValveTags As ArrayList = New ArrayList
    Private _butterflyValveDescription As ArrayList = New ArrayList
    Private _butterflyValveStyle As ArrayList = New ArrayList

    Private pHWVPresent As Boolean
    Private pHWVTag As String
    Private pHWVDescription As String
    Private pHWVSize As String
    Private pHWVtype As String
    Private pHWVMPN As String

    Public Property HWVPresent As Boolean
        Get
            Return pHWVPresent
        End Get
        Set(value As Boolean)
            pHWVPresent = value
        End Set
    End Property
    Public Property HWVTag As String
        Get
            Return pHWVTag
        End Get
        Set(value As String)
            pHWVTag = value
        End Set
    End Property
    Public Property HWVDescription As String
        Get
            Return pHWVDescription
        End Get
        Set(value As String)
            pHWVDescription = value
        End Set
    End Property
    Public Property HWVSize As String
        Get
            Return pHWVSize
        End Get
        Set(value As String)
            pHWVSize = value
        End Set
    End Property
    Public Property HWVType As String
        Get
            Return pHWVtype
        End Get
        Set(value As String)
            pHWVtype = value
        End Set
    End Property
    Public Property HWVMPN As String
        Get
            Return pHWVMPN
        End Get
        Set(value As String)
            pHWVMPN = value
        End Set
    End Property

    Public Property Flow As String
        Get
            Flow = pFlow
        End Get
        Set(value As String)
            pFlow = value
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

    Public Property PercentByWeight
        Get
            PercentByWeight = pPercentByWeight
        End Get
        Set(value)
            If pFluid = "Water" Then
                pPercentByWeight = "100"
            Else
                pPercentByWeight = value
            End If
        End Set
    End Property
    Public Property InletSize As String
        Get
            InletSize = pInletSize
        End Get
        Set(value As String)
            If value = "" Then
                pInletSize = "-"
            Else
                pInletSize = value
            End If
        End Set
    End Property

    Public Property OutletSize As String
        Get
            OutletSize = pOutletSize
        End Get
        Set(value As String)
            If value = "" Then
                pOutletSize = "-"
            Else
                pOutletSize = value
            End If
        End Set
    End Property

    Public Property ButterflyValveTags As ArrayList
        Get
            Return _butterflyValveTags
        End Get
        Set(value As ArrayList)
            _butterflyValveTags = value
        End Set
    End Property

    Public Property ButterflyValveDescription As ArrayList
        Get
            Return _butterflyValveDescription
        End Get
        Set(value As ArrayList)
            _butterflyValveDescription = value
        End Set
    End Property

    Public Property ButterflyValveSizes As ArrayList
        Get
            Return _butterflyValveSizes
        End Get
        Set(value As ArrayList)
            _butterflyValveSizes = value
        End Set
    End Property

    Public Property ButterflyValveStyle As ArrayList
        Get
            Return _butterflyValveStyle
        End Get
        Set(value As ArrayList)
            _butterflyValveStyle = value
        End Set
    End Property

    Public Sub New()
        pInletSize = "-"
        pOutletSize = "-"
        pFlow = "0.0"
        pFluid = "Water"
        pPercentByWeight = "100"
    End Sub
End Class
