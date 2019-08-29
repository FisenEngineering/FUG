Module BasPsychrometrics
    Public Function psyAtmosphericPressure(elevation As Double) As Double
        Dim i As Integer
        Dim el(21), press(21)
        'Altitude    Press.
        el(1) = -1000 : press(1) = 31.02
        el(2) = -500 : press(2) = 30.47
        el(3) = 0 : press(3) = 29.921
        el(4) = 500 : press(4) = 29.38
        el(5) = 1000 : press(5) = 28.86
        el(6) = 2000 : press(6) = 27.82
        el(7) = 3000 : press(7) = 26.82
        el(8) = 4000 : press(8) = 25.82
        el(9) = 5000 : press(9) = 24.9
        el(10) = 6000 : press(10) = 23.98
        el(11) = 7000 : press(11) = 23.09
        el(12) = 8000 : press(12) = 22.22
        el(13) = 9000 : press(13) = 21.39
        el(14) = 10000 : press(14) = 20.48
        el(15) = 15000 : press(15) = 16.89
        el(16) = 20000 : press(16) = 13.76
        el(17) = 30000 : press(17) = 8.9
        el(18) = 40000 : press(18) = 5.56
        el(19) = 50000 : press(19) = 3.44
        el(20) = 60000 : press(20) = 2.14
        i = 1
        Do While elevation > el(i)
            i = i + 1
        Loop
        psyAtmosphericPressure = press(i)
    End Function
    Public Function psyEnthalpy_db_wb(dryBulb As Double, wetBulb As Double, atmPressure As Double)
        'Calculates the enthalpy given the dry bulb, wet bulb, and elevation of the point
        Dim tempEnthalpy As Double
        tempEnthalpy = (dryBulb * 0.24) + ((1061 + (0.444 * dryBulb)) * (psyHumRatio_db_wb(dryBulb, wetBulb, atmPressure)))
        psyEnthalpy_db_wb = tempEnthalpy
    End Function

    Public Function psyHumRatio_db_wb(dryBulb As Double, wetBulb As Double, atmPressure As Double) As Double
        'Calculates the Humidity ration given drybulb, wetbulb, and pressure
        Dim vp As Double
        vp = psyVaporPressure1_db_wb(dryBulb, wetBulb, atmPressure)

        psyHumRatio_db_wb = 0.622 * vp / (atmPressure - vp)
    End Function
    Public Function psyVaporPressure1_db_wb(dryBulb As Double, wetBulb As Double, atmPressure As Double) As Double
        'Calculate Vapor Pressure given dry bulb temp, wet bulb temp, and atm pressure
        Dim tempVP As Double
        Dim ws As Double
        Dim hl As Double
        Dim ch As Double
        Dim wh As Double
        Dim SatVapPress As Double

        SatVapPress = psySaturatedVaporPressure(wetBulb)

        ws = (SatVapPress / (atmPressure - SatVapPress)) * 0.62198
        If wetBulb <= 32.0# Then
            tempVP = (SatVapPress - 0.0005704) * atmPressure * ((dryBulb - wetBulb) / 1.8)
        Else
            hl = 1093.049 + (0.441 * (dryBulb - wetBulb))
            ch = 0.24 + (0.441 * ws)
            wh = ws - (ch * (dryBulb - wetBulb) / hl)
            tempVP = atmPressure * (wh / (0.62198 + wh))
        End If


        psyVaporPressure1_db_wb = tempVP
    End Function
    Public Function psySaturatedVaporPressure(Temperature As Double) As Double
        Dim tempSatVP As Double
        Dim a1, a2, a3, a4, a5, a6 As Double
        Dim b1, b2, b3, b4 As Double
        Dim p1, p2, p3, p4 As Double

        Dim Z, ta As Double
        a1 = -7.90298
        a2 = 5.02808
        a3 = -0.00000013816
        a4 = 11.344
        a5 = 0.0081328
        a6 = -3.49149
        b1 = -9.09718
        b2 = -3.56654
        b3 = 0.876793
        b4 = 0.0060273
        ta = (Temperature + 459.688) / 1.8
        If ta > 273.16 Then
            Z = 373.16 / ta
            p1 = (Z - 1) * a1
            p2 = Math.Log10(Z) * a2
            p3 = ((10 ^ ((1 - (1 / Z)) * a4)) - 1) * a3
            p4 = ((10 ^ (a6 * (Z - 1))) - 1) * a5
        Else
            Z = 273.16 / ta
            p1 = b1 * (Z - 1)
            p2 = b2 * Math.Log10(Z)
            p3 = b3 * (1 - (1 / Z))
            p4 = Math.Log10(b4)
        End If
        tempSatVP = 29.921 * (10 ^ (p1 + p2 + p3 + p4))

        psySaturatedVaporPressure = tempSatVP
    End Function

    Public Function psyWB(db As Double, h As Double, atm As Double)
        Dim wbtest As Double
        Dim htest As Double

        wbtest = db
        Do
            htest = 0.24 * wbtest + (1061 + 0.444 * wbtest) * psyHumRatio_db_wb(wbtest, wbtest, atm)
            wbtest = wbtest - 1
        Loop Until htest < h
        wbtest = wbtest + 2
        Do
            htest = 0.24 * wbtest + (1061 + 0.444 * wbtest) * psyHumRatio_db_wb(wbtest, wbtest, atm)
            wbtest = wbtest - 0.1
        Loop Until htest < h
        wbtest = wbtest + 0.1
        psyWB = wbtest
    End Function

    Public Function psySpecificVolume(db As Double, wb As Double, atm As Double)
        psySpecificVolume = (0.754 * (db + 459.7) * (1 + (7000 * psyHumRatio_db_wb(db, wb, atm) / 4360))) / atm
    End Function
End Module
