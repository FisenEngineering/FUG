Module basFUGFunctions
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

End Module
