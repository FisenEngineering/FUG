Public Class clsFilters
    Private pHasNewFinalFilters As Boolean
    Private pFFilterSize1 As String
    Private pFFilterSize2 As String
    Private pFFilterSize3 As String
    Private pFFilterQ1 As String
    Private pFFilterQ2 As String
    Private pFFilterQ3 As String
    Private pFFFaceArea As String
    Private pFFFaceVel As String
    Private pFFAPD As String
    Private pFFMaxAPD As String
    Private pFFDFA As String
    Private pFFStaticITem As String
    Public Property FFFaceArea As String
        Get
            FFFaceArea = pFFFaceArea
        End Get
        Set(value As String)
            pFFFaceArea = value
        End Set
    End Property
    Public Property FFFaceVelocity As String
        Get
            FFFaceVelocity = pFFFaceVel
        End Get
        Set(value As String)
            pFFFaceVel = value
        End Set
    End Property
    Public Property FFAPD As String
        Get
            FFAPD = pFFAPD
        End Get
        Set(value As String)
            pFFAPD = value
        End Set
    End Property
    Public Property FFMaxAPD As String
        Get
            FFMaxAPD = pFFMaxAPD
        End Get
        Set(value As String)
            pFFMaxAPD = value
        End Set
    End Property
    Public Property FFDFA As String
        Get
            FFDFA = pFFDFA
        End Get
        Set(value As String)
            pFFDFA = value
        End Set
    End Property
    Public Property FFStaticItem As String
        Get
            FFStaticItem = pFFStaticITem
        End Get
        Set(value As String)
            pFFStaticITem = value
        End Set
    End Property
    Public Property FFilterQ1 As String
        Get
            FFilterQ1 = pFFilterQ1
        End Get
        Set(value As String)
            pFFilterQ1 = FFilterQ1
        End Set
    End Property
    Public Property FFilterQ2 As String
        Get
            FFilterQ2 = pFFilterQ2
        End Get
        Set(value As String)
            pFFilterQ2 = FFilterQ2
        End Set
    End Property
    Public Property FFilterQ3 As String
        Get
            FFilterQ3 = pFFilterQ3
        End Get
        Set(value As String)
            pFFilterQ3 = FFilterQ3
        End Set
    End Property
    Public Property FFilterSize1 As String
        Get
            FFilterSize1 = pFFilterSize1
        End Get
        Set(value As String)
            pFFilterSize1 = value
        End Set
    End Property
    Public Property FFilterSize2 As String
        Get
            FFilterSize2 = pFFilterSize2
        End Get
        Set(value As String)
            pFFilterSize2 = value
        End Set
    End Property
    Public Property FFilterSize3 As String
        Get
            FFilterSize3 = pFFilterSize3
        End Get
        Set(value As String)
            pFFilterSize3 = value
        End Set
    End Property
    Public Property HasNewFinalFilters As Boolean
        Get
            HasNewFinalFilters = pHasNewFinalFilters
        End Get
        Set(value As Boolean)
            pHasNewFinalFilters = value
        End Set
    End Property

    Public Sub New()
        pHasNewFinalFilters = False
    End Sub
End Class
