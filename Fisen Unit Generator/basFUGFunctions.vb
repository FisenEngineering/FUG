Module basFUGFunctions
    Public Function ToFracSize(DecimalSize As String) As String
        Dim FracSize As String
        Dim Whole As String
        Dim FracPart As String
        Dim FracRep As String
        FracSize = "99 99/100"""
        Whole = Trim(Str(Int(Val(DecimalSize))))
        FracPart = Trim(Str(Val(DecimalSize) - Val(Whole)))

        Select Case FracPart
            Case Is = ".125"
                FracRep = " 1/8"""
            Case Is = ".25"
                FracRep = " 1/4"""
            Case Is = ".375"
                FracRep = " 3/8"""
            Case Is = ".5"
                FracRep = " 1/2"""
            Case Is = ".625"
                FracRep = " 5/8"""
            Case Is = ".75"
                FracRep = " 3/4"""
            Case Is = ".875"
                FracRep = " 7/8"""
            Case Else
                FracRep = """"
        End Select
        If Whole = "0" Then
            FracSize = FracRep
        Else
            FracSize = Whole & FracRep
        End If

        ToFracSize = FracSize

    End Function
End Module
