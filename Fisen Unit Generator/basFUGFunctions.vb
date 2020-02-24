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

    Public Function SlopeIntercept(x1 As Double, y1 As Double, x2 As Double, y2 As Double, newx As Double) As Double
        Dim m As Double
        Dim b As Double
        m = (y2 - y1) / (x2 - x1)
        b = y1 - m * x1
        SlopeIntercept = m * newx + b
    End Function

    Public Function Model2Family(ModelNumber As String) As String
        Dim TempFamily As String
        Dim UPGTons As String

        TempFamily = "Unknown"

        If Mid(ModelNumber, 1, 1) = "J" Then
            UPGTons = Mid(ModelNumber, 2, 2)

            Select Case UPGTons
                Case Is = "03"
                    TempFamily = "Series5"
                Case Is = "04"
                    TempFamily = "Series5"
                Case Is = "05"
                    TempFamily = "Series5"
                Case Is = "A3"
                    TempFamily = "Series10"
                Case Is = "A4"
                    TempFamily = "Series10"
                Case Is = "A5"
                    TempFamily = "Series10"
                Case Is = "06"
                    TempFamily = "Series10"
                Case Is = "07"
                    TempFamily = "Series10"
                Case Is = "08"
                    TempFamily = "Series10"
                Case Is = "10"
                    TempFamily = "Series10"
                Case Is = "12"
                    TempFamily = "Series10"
                Case Is = "15"
                    TempFamily = "Series20"
                Case Is = "18"
                    TempFamily = "Series20"
                Case Is = "20"
                    TempFamily = "Series20"
                Case Is = "25"
                    TempFamily = "Series20"
            End Select
        End If

        If Mid(ModelNumber, 1, 2) = "AD" Then
            TempFamily = "Choice"
        End If

        If Mid(ModelNumber, 1, 4) = "YPAL" Then
            TempFamily = "Series100"
        End If

        Return TempFamily
    End Function

End Module
