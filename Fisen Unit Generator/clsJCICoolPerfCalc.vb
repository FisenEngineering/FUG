Public Class clsJCICoolPerfCalc
    Public Sub AmbientSelection(Ambient As Double)
        Dim ExactAmbient As Boolean
        Dim LowAmbientBracket As Double
        Dim HighAmbientBracket As Double

        ExactAmbient = False
        If Ambient = 75 Then
            ExactAmbient = True
            LowAmbientBracket = 75
            HighAmbientBracket = 75
        End If

        If Ambient = 85 Then
            ExactAmbient = True
            LowAmbientBracket = 85
            HighAmbientBracket = 85
        End If

        If Ambient = 95 Then
            ExactAmbient = True
            LowAmbientBracket = 95
            HighAmbientBracket = 95
        End If

        If Ambient = 105 Then
            ExactAmbient = True
            LowAmbientBracket = 105
            HighAmbientBracket = 105
        End If

        If Ambient = 115 Then
            ExactAmbient = True
            LowAmbientBracket = 115
            HighAmbientBracket = 115
        End If

        If Ambient = 125 Then
            ExactAmbient = True
            LowAmbientBracket = 125
            HighAmbientBracket = 125
        End If

        If Not (ExactAmbient) Then
            Select Case Ambient
                Case < 75
                    LowAmbientBracket = 75
                    HighAmbientBracket = 85
                Case 75 To 84.9
                    LowAmbientBracket = 75
                    HighAmbientBracket = 85
                Case 85 To 94.9
                    LowAmbientBracket = 85
                    HighAmbientBracket = 95
                Case 95 To 104.9
                    LowAmbientBracket = 95
                    HighAmbientBracket = 105
                Case 105 To 114.9
                    LowAmbientBracket = 105
                    HighAmbientBracket = 115
                Case 115 To 124.9
                    LowAmbientBracket = 115
                    HighAmbientBracket = 125
                Case > 125
                    LowAmbientBracket = 115
                    HighAmbientBracket = 125
            End Select
        End If


    End Sub
End Class
