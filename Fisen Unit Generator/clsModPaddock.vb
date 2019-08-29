Public Class clsModPaddock
    Private pTest As String

    Public Property Test As String
        Get
            Return pTest
        End Get
        Set(value As String)
            pTest = value
        End Set
    End Property

    Public Sub New()
        pTest = "Initial Value"
    End Sub

    Public Function UnitHas4StageBoard()
        Dim RVal As Boolean

        RVal = False

        Select Case frmMain.ThisUnit.Family
            Case Is = "Series40"
                RVal = True
            Case Is = "Series20"
                If Mid(frmMain.ThisUnit.ModelNumber, 4, 2) = "ZJ" Then RVal = True
        End Select

        UnitHas4StageBoard = RVal
    End Function
End Class
