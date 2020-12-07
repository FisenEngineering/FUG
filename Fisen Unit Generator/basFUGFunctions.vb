Module basFUGFunctions
    Public Function Ver2FileVer(lVersionNum As String) As String
        Dim MyVer As String
        Dim dotloc As Integer

        MyVer = lVersionNum
        MyVer = "V" & MyVer
        dotloc = InStr(MyVer, ".")
        MyVer = Mid(MyVer, 1, dotloc - 1) & "_" & Mid(MyVer, dotloc + 1)
        Return MyVer

    End Function
    Public Sub AddUniqueEndDeviceRequirements(ModCodeLocal As String)
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim MySQL As String

        Dim i As Integer
        Dim Foundit As Boolean

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenStatic
        }

        MySQL = "SELECT * FROM tblRequiredEndDevices WHERE FIOpCode='" & ModCodeLocal & "'"
        rs.Open(MySQL, con)

        If rs.RecordCount = 0 Then
            rs.Close()
            con.Close()
            Exit Sub
        End If

        rs.MoveFirst()
        Do While Not (rs.EOF)
            Foundit = False
            For i = 0 To frmMain.ThisUnitEndDevices.Count - 1
                If frmMain.ThisUnitEndDevices.Item(i) = Trim(Str(rs.Fields("EndDeviceID").Value)) Then Foundit = True
            Next

            If Not (Foundit) Then
                frmMain.ThisUnitEndDevices.Add(Trim(Str(rs.Fields("EndDeviceID").Value)))
            End If
            rs.MoveNext()
        Loop

        rs.Close()
        con.Close()

    End Sub
    Public Function ToFracSize(DecimalSize As String) As String
        Dim FracSize As String
        Dim Whole As String
        Dim FracPart As String
        Dim FracRep As String
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

        If Mid(ModelNumber, 1, 3) = "ZLG" Then
            TempFamily = "Series12"
        End If

        If Mid(ModelNumber, 1, 2) = "AD" Then
            TempFamily = "Choice"
        End If

        If Mid(ModelNumber, 1, 4) = "YPAL" Then
            TempFamily = "Series100"
        End If

        Return TempFamily
    End Function

    Public Function S10AuxPanelRqd() As Boolean
        Dim TempBool As Boolean
        Dim TallCase As Boolean
        Dim ShortCase As Boolean

        TempBool = False
        If S10CabinetHeightTorS() = "Tall" Then TallCase = True Else TallCase = False
        ShortCase = Not (TallCase)





        If frmMain.optMLB6126.Checked Then TempBool = True
        If frmMain.optMLB812U.Checked Then TempBool = True


        Return TempBool
    End Function

    Public Function S10CabinetHeightTorS() As String
        Dim CabHeight As String
        Dim ModelNum As String
        Dim Stubb3 As String
        Dim StubbEff As String

        CabHeight = "Short"
        ModelNum = frmMain.ThisUnit.ModelNumber
        Stubb3 = Mid(ModelNum, 1, 3)
        StubbEff = Mid(ModelNum, 4, 2)

        Select Case StubbEff
            Case Is = "ZT"
                Select Case Stubb3
                    Case Is = "JA3", Is = "JA4", Is = "JA5"
                        CabHeight = "Short"
                    Case Is = "J06", Is = "J07", Is = "J08"
                        CabHeight = "Short"
                    Case Is = "J10", Is = "J12"
                        CabHeight = "Tall"
                End Select
            Case Is = "ZH"
                Select Case Stubb3
                    Case Is = "JA3", Is = "JA4", Is = "JA5", Is = "J06", Is = "J07"
                        CabHeight = "Short"
                    Case Is = "J08", Is = "J10", Is = "J12"
                        CabHeight = "Tall"
                End Select
            Case Is = "ZR"
                Select Case Stubb3
                    Case Is = "JA3", Is = "JA4", Is = "JA5", Is = "J06", Is = "J07"
                        CabHeight = "Short"
                    Case Is = "J08", Is = "J10", Is = "J12"
                        CabHeight = "Tall"
                End Select
            Case Is = "ZJ"
                Select Case Stubb3
                    Case Is = "JA3", Is = "JA4", Is = "JA5"
                        CabHeight = "Short"
                    Case Is = "J06", Is = "J07", Is = "J08", Is = "J10", Is = "J12"
                        CabHeight = "Tall"
                End Select
            Case Is = "ZF"
                Select Case Stubb3
                    Case Is = "J06", Is = "J07"
                        CabHeight = "Short"
                    Case Is = "J08", Is = "J10", Is = "J12"
                        CabHeight = "Tall"
                End Select
        End Select

        Return CabHeight

    End Function

    Public Function NEMAMotorFLA(hp As String, Volts As String) As String
        Dim FLA As String

        Select Case hp
            Case Is = "-"
                FLA = ""
            Case Is = "0.25"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = "5.8"
                    Case Is = "230-1"
                        FLA = "2.9"
                    Case Is = "208-3"
                        FLA = "1.11"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "0.33"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = "7.2"
                    Case Is = "230-1"
                        FLA = "3.6"
                    Case Is = "208-3"
                        FLA = 1.34

                    Case Else
                        FLA = ""
                End Select
            Case Is = "0.5"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = "9.8"
                    Case Is = "230-1"
                        FLA = "4.9"
                    Case Is = "208-3"
                        FLA = "2.2"
                    Case Is = "230-3"
                        FLA = "2.2"
                    Case Is = "460-3"
                        FLA = "1.1"
                    Case Is = "575-3"
                        FLA = "0.9"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "0.75"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = "13.8"
                    Case Is = "230-1"
                        FLA = "6.9"
                    Case Is = "208-3"
                        FLA = "3.1"
                    Case Is = "230-3"
                        FLA = "3.2"
                    Case Is = "460-3"
                        FLA = "1.6"
                    Case Is = "575-3"
                        FLA = "1.3"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "1"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = "16"
                    Case Is = "230-1"
                        FLA = "8.0"
                    Case Is = "208-3"
                        FLA = "4.0"
                    Case Is = "230-3"
                        FLA = "4.2"
                    Case Is = "460-3"
                        FLA = "2.1"
                    Case Is = "575-3"
                        FLA = "1.7"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "1.5"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = "20.0"
                    Case Is = "230-1"
                        FLA = "10.0"
                    Case Is = "208-3"
                        FLA = "5.7"
                    Case Is = "230-3"
                        FLA = "6.0"
                    Case Is = "460-3"
                        FLA = "3.0"
                    Case Is = "575-3"
                        FLA = "2.4"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "2"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = "24.0"
                    Case Is = "230-1"
                        FLA = "12.0"
                    Case Is = "208-3"
                        FLA = "7.5"
                    Case Is = "230-3"
                        FLA = "6.8"
                    Case Is = "460-3"
                        FLA = "3.4"
                    Case Is = "575-3"
                        FLA = "2.7"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "3"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = "34.0"
                    Case Is = "230-1"
                        FLA = "17.0"
                    Case Is = "208-3"
                        FLA = "10.6"
                    Case Is = "230-3"
                        FLA = "9.6"
                    Case Is = "460-3"
                        FLA = "4.8"
                    Case Is = "575-3"
                        FLA = "3.9"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "5"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = "56.0"
                    Case Is = "230-1"
                        FLA = "28.0"
                    Case Is = "208-3"
                        FLA = "16.7"
                    Case Is = "230-3"
                        FLA = "15.2"
                    Case Is = "460-3"
                        FLA = "7.6"
                    Case Is = "575-3"
                        FLA = "6.1"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "7.5"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = "80.0"
                    Case Is = "230-1"
                        FLA = "40.0"
                    Case Is = "208-3"
                        FLA = "24.0"
                    Case Is = "230-3"
                        FLA = "22.0"
                    Case Is = "460-3"
                        FLA = "11.0"
                    Case Is = "575-3"
                        FLA = "9.0"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "10"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = "100.0"
                    Case Is = "230-1"
                        FLA = "50.0"
                    Case Is = "208-3"
                        FLA = "31.0"
                    Case Is = "230-3"
                        FLA = "28.0"
                    Case Is = "460-3"
                        FLA = "14.0"
                    Case Is = "575-3"
                        FLA = "11.0"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "15"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = "135.0"
                    Case Is = "230-1"
                        FLA = "68.0"
                    Case Is = "208-3"
                        FLA = "46.0"
                    Case Is = "230-3"
                        FLA = "42.0"
                    Case Is = "460-3"
                        FLA = "21.0"
                    Case Is = "575-3"
                        FLA = "17.0"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "20"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = ""
                    Case Is = "230-1"
                        FLA = "88.0"
                    Case Is = "208-3"
                        FLA = "59.0"
                    Case Is = "230-3"
                        FLA = "54.0"
                    Case Is = "460-3"
                        FLA = "27.0"
                    Case Is = "575-3"
                        FLA = "22.0"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "25"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = ""
                    Case Is = "230-1"
                        FLA = "110.0"
                    Case Is = "208-3"
                        FLA = "75.0"
                    Case Is = "230-3"
                        FLA = "68.0"
                    Case Is = "460-3"
                        FLA = "34.0"
                    Case Is = "575-3"
                        FLA = "27.0"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "30"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = ""
                    Case Is = "230-1"
                        FLA = "136.0"
                    Case Is = "208-3"
                        FLA = "88.0"
                    Case Is = "230-3"
                        FLA = "80.0"
                    Case Is = "460-3"
                        FLA = "40.0"
                    Case Is = "575-3"
                        FLA = "32.0"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "40"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = ""
                    Case Is = "230-1"
                        FLA = "176.0"
                    Case Is = "208-3"
                        FLA = "114.0"
                    Case Is = "230-3"
                        FLA = "104.0"
                    Case Is = "460-3"
                        FLA = "52.0"
                    Case Is = "575-3"
                        FLA = "41.0"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "50"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = ""
                    Case Is = "230-1"
                        FLA = "216.0"
                    Case Is = "208-3"
                        FLA = "143.0"
                    Case Is = "230-3"
                        FLA = "130.0"
                    Case Is = "460-3"
                        FLA = "65.0"
                    Case Is = "575-3"
                        FLA = "52.0"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "60"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = ""
                    Case Is = "230-1"
                        FLA = ""
                    Case Is = "208-3"
                        FLA = "169.0"
                    Case Is = "230-3"
                        FLA = "154.0"
                    Case Is = "460-3"
                        FLA = "77.0"
                    Case Is = "575-3"
                        FLA = "62.0"
                    Case Else
                        FLA = ""
                End Select
            Case Is = "75"
                Select Case Volts
                    Case Is = "115-1"
                        FLA = ""
                    Case Is = "230-1"
                        FLA = ""
                    Case Is = "208-3"
                        FLA = "211.0"
                    Case Is = "230-3"
                        FLA = "192.0"
                    Case Is = "460-3"
                        FLA = "96.0"
                    Case Is = "575-3"
                        FLA = "77"
                    Case Else
                        FLA = ""
                End Select
            Case Else
                FLA = ""
        End Select
        NEMAMotorFLA = FLA
    End Function

    Public Function XfmrPrimaryAmps(PVolts As Double, VA As Double) As Double
        Dim TempAmps As Double

        TempAmps = VA / PVolts

        Return TempAmps
    End Function

    Public Function SuperUser() As Boolean
        Dim tempsu As Boolean
        Dim UID As String

        tempsu = False
        UID = Environment.UserName
        If UID = "jlevine" Then tempsu = True
        If UID = "jmucinski" Then tempsu = True
        If UID = "jruemenapp" Then tempsu = True

        Return tempsu
    End Function

    Public Sub WriteToEventLog(ErrorModule As String, ErrorMsg As String, ErrorClass As String, ErrorButtonz As String)
        Dim errorreport As System.IO.StreamWriter
        Dim tempfilename As String

        ' Call WriteToEventLog("LowAF", "User Cancelled", "Operator", dummy)
        tempfilename = "\\filesrvr\FUG\db\FUGErrorLog.csv"

        errorreport = My.Computer.FileSystem.OpenTextFileWriter(tempfilename, True)
        errorreport.WriteLine(Now.ToString & "," & ErrorModule & "," & ErrorMsg & "," & ErrorClass & "," & ErrorButtonz)
        errorreport.Close()
    End Sub
End Module
