Public Class clsDSUnitClass
    Private pFanSpeed As String
    Private pCompQty As String
    Private pCompSpeed As String

    Public Property FanSpeed() As String
        Get
            Return pFanSpeed
        End Get
        Set(value As String)
            pFanSpeed = value
        End Set
    End Property
    Public Property CompQty() As String
        Get
            Return pCompQty
        End Get
        Set(value As String)
            pCompQty = value
        End Set
    End Property
    Public Property CompSpeed() As String
        Get
            Return pCompSpeed
        End Get
        Set(value As String)
            pCompSpeed = value
        End Set
    End Property
    Public Sub New()
        pFanSpeed = "n/a"
        pCompQty = "2"
        pCompSpeed = "Single"
    End Sub
End Class
