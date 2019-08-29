Public Class clsImportUPG
    Private pImportFile As String
    Private pImportTag As String
    Public Property ImportFile As String
        Get
            ImportFile = pImportFile
        End Get
        Set(value As String)
            pImportFile = value
        End Set
    End Property
    Public Property Tag As String
        Get
            Tag = pImportTag
        End Get
        Set(value As String)
            pImportTag = value
        End Set
    End Property
End Class
