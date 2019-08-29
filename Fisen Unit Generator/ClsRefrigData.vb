Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO

Public Class ClsRefrigData
    Private pCUSuctionLineSize As String
    Private pCULiquidLineSize As String
    Private pRef As String

    Private _RefrigerantDrawings As ArrayList = New ArrayList

    Public Property Refrigerant As String
        Get
            Refrigerant = pRef
        End Get
        Set(value As String)
            pRef = value
        End Set
    End Property

    Public Property CULiquidLineSize As String
        Get
            CULiquidLineSize = pCULiquidLineSize
        End Get
        Set(value As String)
            If value = "" Then
                pCULiquidLineSize = "-"
            Else
                pCULiquidLineSize = value
            End If
        End Set
    End Property

    Public Property CUSuctionLineSize As String
        Get
            CUSuctionLineSize = pCUSuctionLineSize
        End Get
        Set(value As String)
            If value = "" Then
                pCUSuctionLineSize = "-"
            Else
                pCUSuctionLineSize = value
            End If
        End Set
    End Property


    Public Property RefrigerantDrawings As ArrayList
        Get
            Return _RefrigerantDrawings
        End Get
        Set(value As ArrayList)
            _RefrigerantDrawings = value
        End Set
    End Property

    Public Sub New()
        pCULiquidLineSize = "-"
        pCUSuctionLineSize = "-"
        pRef = "R410a"
    End Sub
End Class
