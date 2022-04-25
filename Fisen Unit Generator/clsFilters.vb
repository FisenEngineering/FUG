Public Class clsFilters
    Private pHasNewFilters As Boolean
    Private pFilterBankName As String
    Private pFilterType As String
    Private pFilterSize1 As String
    Private pFilterSize2 As String
    Private pFilterSize3 As String
    Private pFilterSize4 As String
    Private pFilterQ1 As String
    Private pFilterQ2 As String
    Private pFilterQ3 As String
    Private pFilterQ4 As String
    Private pFaceArea As String
    Private pFaceVel As String
    Private pFAPD As String
    Private pFMaxAPD As String
    Private pFDFA As String
    Private pFStaticITem As String
    Private pPreFiltersPresent As Boolean
    Private pPreFilterType As String
    Private pPreFiltAPD As String
    Private pPreFiltMaxAPD As String
    Private pPreFiltDFA As String
    Public Property PreFilterPresent As Boolean
        Get
            PreFilterPresent = pPreFiltersPresent
        End Get
        Set(value As Boolean)
            pPreFiltersPresent = value
        End Set
    End Property
    Public Property PrefilterType As String
        Get
            PrefilterType = pPreFilterType
        End Get
        Set(value As String)
            pPreFilterType = value
        End Set
    End Property

    Public Property FilterType As String
        Get
            FilterType = pFilterType
        End Get
        Set(value As String)
            pFilterType = value
        End Set
    End Property
    Public Property PreFiltDFA As String
        Get
            PreFiltDFA = pPreFiltDFA
        End Get
        Set(value As String)
            pPreFiltDFA = value
        End Set
    End Property
    Public Property PreFiltMaxAPD As String
        Get
            PreFiltMaxAPD = pPreFiltMaxAPD
        End Get
        Set(value As String)
            pPreFiltMaxAPD = value
        End Set
    End Property
    Public Property PreFiltAPD As String
        Get
            PreFiltAPD = pPreFiltAPD
        End Get
        Set(value As String)
            pPreFiltAPD = value
        End Set
    End Property
    Public Property FilterBankName As String
        Get
            FilterBankName = pFilterBankName
        End Get
        Set(value As String)
            pFilterBankName = value
        End Set
    End Property
    Public Property FaceArea As String
        Get
            FaceArea = pFaceArea
        End Get
        Set(value As String)
            pFaceArea = value
        End Set
    End Property
    Public Property FaceVelocity As String
        Get
            FaceVelocity = pFaceVel
        End Get
        Set(value As String)
            pFaceVel = value
        End Set
    End Property
    Public Property FAPD As String
        Get
            FAPD = pFAPD
        End Get
        Set(value As String)
            pFAPD = value
        End Set
    End Property
    Public Property FMaxAPD As String
        Get
            FMaxAPD = pFMaxAPD
        End Get
        Set(value As String)
            pFMaxAPD = value
        End Set
    End Property
    Public Property FDFA As String
        Get
            FDFA = pFDFA
        End Get
        Set(value As String)
            pFDFA = value
        End Set
    End Property
    Public Property FStaticItem As String
        Get
            FStaticItem = pFStaticITem
        End Get
        Set(value As String)
            pFStaticITem = value
        End Set
    End Property
    Public Property FilterQ1 As String
        Get
            FilterQ1 = pFilterQ1
        End Get
        Set(value As String)
            pFilterQ1 = value
        End Set
    End Property
    Public Property FilterQ2 As String
        Get
            FilterQ2 = pFilterQ2
        End Get
        Set(value As String)
            pFilterQ2 = value
        End Set
    End Property
    Public Property FilterQ3 As String
        Get
            FilterQ3 = pFilterQ3
        End Get
        Set(value As String)
            pFilterQ3 = value
        End Set
    End Property
    Public Property FilterQ4 As String
        Get
            FilterQ4 = pFilterQ4
        End Get
        Set(value As String)
            pFilterQ4 = value
        End Set
    End Property
    Public Property FilterSize1 As String
        Get
            FilterSize1 = pFilterSize1
        End Get
        Set(value As String)
            pFilterSize1 = value
        End Set
    End Property
    Public Property FilterSize2 As String
        Get
            FilterSize2 = pFilterSize2
        End Get
        Set(value As String)
            pFilterSize2 = value
        End Set
    End Property
    Public Property FilterSize3 As String
        Get
            FilterSize3 = pFilterSize3
        End Get
        Set(value As String)
            pFilterSize3 = value
        End Set
    End Property
    Public Property FilterSize4 As String
        Get
            FilterSize4 = pFilterSize4
        End Get
        Set(value As String)
            pFilterSize4 = value
        End Set
    End Property
    Public Property HasNewFilters As Boolean
        Get
            HasNewFilters = pHasNewFilters
        End Get
        Set(value As Boolean)
            pHasNewFilters = value
        End Set
    End Property

    Public Sub New()
        pHasNewFilters = False
        pFilterBankName = "-"
        pFilterQ1 = "-"
        pFilterQ2 = "-"
        pFilterQ3 = "-"
        pFilterQ4 = "-"
        pFilterSize1 = "-"
        pFilterSize2 = "-"
        pFilterSize3 = "-"
        pFilterSize4 = "-"
        pFilterType = "-"
    End Sub
End Class
