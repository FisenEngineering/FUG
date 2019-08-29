Public Class ClsSpecialPerf
    Private p100OANominalAirFlow As String
    Private p100OAMinCatAirFlow As String
    Private p100OABypassAirFlow As String
    Public Property OA100NominalAF As String
        Get
            OA100NominalAF = Format(p100OANominalAirFlow, "0")
        End Get
        Set(value As String)
            p100OANominalAirFlow = value
        End Set
    End Property
    Public Property OA100MinCatAF As String
        Get
            OA100MinCatAF = Format(p100OAMinCatAirFlow, "0")
        End Get
        Set(value As String)
            p100OAMinCatAirFlow = value
        End Set
    End Property
    Public Property OA100BypassAF As String
        Get
            OA100BypassAF = Format(p100OABypassAirFlow, "0")
        End Get
        Set(value As String)
            p100OABypassAirFlow = value
        End Set
    End Property
End Class
