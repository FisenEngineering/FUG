Public Class frmHistoryReport
    Private pMyModule As String
    Dim CW As Integer = Me.Width ' Current Width
    Dim CH As Integer = Me.Height ' Current Height
    Dim IW As Integer = Me.Width ' Initial Width
    Dim IH As Integer = Me.Height ' Initial Height

    Public Property MyModule As String
        Get
            Return pMyModule
        End Get
        Set(value As String)
            pMyModule = value
        End Set
    End Property
    Private Sub frmHistoryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbModCode.Text = "Not Selected"
        Me.Text = "Modification History"
        If frmMain.chkDebug.Checked Then
            Label1.Visible = True
            Label1.Text = Me.Width
        End If
        Call InitializeQuery(False)
    End Sub

    Private Sub Load100OAHistoryTable(XL As Boolean)
        'Upgraded to 3.0 Excel File to Desktop
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder

        Dim historyreport As System.IO.StreamWriter
        Dim tempfilename As String

        If XL Then
            tempfilename = XLSavePath("FUG - LCVAVHistoryReport.csv")
            historyreport = My.Computer.FileSystem.OpenTextFileWriter(tempfilename, False)
            OneLine = "UnitID" & "," & "Version" & "," & "ModelNumber" & "," & "JobName" & ","
            OneLine = OneLine & "Controller" & "," & "HeatType" & "," & "HeatCtrl" & ", " & "CoolCtrl" & "," & "ModeCtrl" & "," & "ZoneOverride"
            historyreport.WriteLine(OneLine)
        End If


        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        txtReport.Text = ""

        MySQL = "SELECT * FROM tblHistory100OA"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)

        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        Me.Width = 1000

        Do While Not (rs.EOF)
            If Not (chkFilterByFamily.Checked) Or (frmMain.ThisUnit.Family = Model2Family(rs.Fields(4).Value)) Then
                'next line contains 12 escape codes
                OneLine = "\highlight1 " & rs.Fields(2).Value & " " & rs.Fields(3).Value & " " & rs.Fields(4).Value & " - " & rs.Fields(1).Value
                OneLine = OneLine.PadRight(135 + 17, " ") & "\par "
                AllLines.Append(OneLine)
                OneLine = "\highlight0 \tab " & rs.Fields(5).Value & " Controller" & "\tab " & rs.Fields(6).Value & " Heat" & "\tab " & rs.Fields(7).Value & " Heat Control" & "\tab " & rs.Fields(8).Value & " Cool Control" & "\tab " & rs.Fields(9).Value & " Mode Control" & "\tab \b " & "Zone Override:\b0  " & rs.Fields(10).Value & "\par"
                AllLines.Append(OneLine)
                If XL Then
                    OneLine = rs.Fields(2).Value & "," & rs.Fields(3).Value & "," & rs.Fields(4).Value & "," & rs.Fields(1).Value & "," & rs.Fields(5).Value & "," & rs.Fields(6).Value & "," & rs.Fields(7).Value & ", " & rs.Fields(8).Value & "," & rs.Fields(9).Value & "," & rs.Fields(10).Value
                    historyreport.WriteLine(OneLine)
                End If

            End If

            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        If XL Then
            historyreport.Close()
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub LoadFilterHistoryTable(XL As Boolean)
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder

        Dim PFBString, ExtModString As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        txtReport.Text = ""

        MySQL = "SELECT * FROM tblHistoryFilters"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)

        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        Me.Width = 920

        Do While Not (rs.EOF)
            If Not (chkFilterByFamily.Checked) Or (frmMain.ThisUnit.Family = Model2Family(rs.Fields(4).Value)) Then
                OneLine = "\highlight1 " & rs.Fields(2).Value & " " & rs.Fields(3).Value & " " & rs.Fields(4).Value & " - " & rs.Fields(1).Value
                OneLine = OneLine.PadRight(120 + 17, " ") & "\par "
                AllLines.Append(OneLine)

                If rs.Fields(7).Value = "TRUE" Then
                    PFBString = "With Prefilters"
                Else
                    PFBString = "No Prefilters"
                End If

                If rs.Fields(8).Value = "None" Then
                    ExtModString = ""
                Else
                    ExtModString = "\b External Module:\b0 " & rs.Fields(8).Value
                End If

                OneLine = "\highlight0 \tab \b Bank:\b0" & rs.Fields(5).Value & "\tab \b Material:\b0 " & rs.Fields(6).Value & "\tab \b Airflow:\b0" & rs.Fields(20).Value & " cfm \tab at " & rs.Fields(19).Value & " iwc Delta P " & PFBString & "\tab " & ExtModString & "\par "
                AllLines.Append(OneLine)

                OneLine = "\tab " & rs.Fields(9).Value & " - (" & rs.Fields(11).Value & ")" & rs.Fields(10).Value
                AllLines.Append(OneLine)

                If rs.Fields(12).Value <> "-" Then
                    OneLine = " / (" & rs.Fields(13).Value & ")" & rs.Fields(12).Value
                    AllLines.Append(OneLine)
                End If
                If rs.Fields(14).Value <> "-" Then
                    OneLine = " / (" & rs.Fields(15).Value & ")" & rs.Fields(14).Value
                    AllLines.Append(OneLine)
                End If
                If rs.Fields(16).Value <> "-" Then
                    OneLine = " / (" & rs.Fields(17).Value & ")" & rs.Fields(16).Value
                    AllLines.Append(OneLine)
                End If
                If PFBString = "With Prefilters" Then
                    OneLine = " Prefilters: " & rs.Fields(18).Value
                    AllLines.Append(OneLine)
                End If
                AllLines.Append("\par")
            End If

            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub LoadSupplyFanHistoryTable(XL As Boolean)
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder
        Dim fanvar As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        txtReport.Text = ""

        MySQL = "SELECT * FROM tblHistorySFan"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)
        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        Me.Width = 1300

        Do While Not (rs.EOF)
            If Not (chkFilterByFamily.Checked) Or (frmMain.ThisUnit.Family = Model2Family(rs.Fields(4).Value)) Then
                'next line contains 12 escape codes
                OneLine = "\highlight1 " & rs.Fields(2).Value & " " & rs.Fields(3).Value & " " & rs.Fields(4).Value & " - " & rs.Fields(1).Value
                OneLine = OneLine.PadRight(175 + 17, " ") & "\par "
                AllLines.Append(OneLine)
                fanvar = rs.Fields(8).Value
                fanvar = fanvar.PadRight(25, " ")
                OneLine = "\highlight0 \tab \b Airflow:\b0 " & rs.Fields(5).Value & " \tab \b ESP:\b0 " & rs.Fields(6).Value & "\tab \b1 TSP:\b0 " & rs.Fields(7).Value & " \tab \b No. Fans:\b0 " & rs.Fields(9).Value & "\tab \b1 Fan:\b0 " & fanvar & "\tab \b Fan bhp ea.:\b0 " & Format(Val(rs.Fields(10).Value), "0.0") & "\tab \b System bhp:\b0 " & Format(Val(rs.Fields(11).Value), "0.0") & "\tab \b Motor hp ea.:\b0 " & rs.Fields(12).Value & "\tab \b System hp:\b0 " & rs.Fields(13).Value & "\par "
                AllLines.Append(OneLine)
            End If

            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub LoadLCVAVHistoryTable(XL As Boolean)
        'Upgraded to 3.0 Excel File to Desktop
        'Upgraded to 2.0 style reporting
        Dim historyreport As System.IO.StreamWriter
        Dim tempfilename As String

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder

        If XL Then
            tempfilename = XLSavePath("FUG - LCVAVHistoryReport.csv")
            historyreport = My.Computer.FileSystem.OpenTextFileWriter(tempfilename, False)
            OneLine = "UnitID" & "," & "Version" & "," & "ModelNumber" & "," & "JobName" & ","
            OneLine = OneLine & "Style" & "," & "DSPC" & "," & "SATCooling" & ", " & "MWU" & "," & "HSFanReheat" & "," & "HeatPump" & "," & "ECMStaged" & "," & "UpgradeBoard"
            historyreport.WriteLine(OneLine)
        End If

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        txtReport.Text = ""

        MySQL = "SELECT * FROM tblHistoryLCVAV"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)

        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        Me.Width = 1050

        Do While Not (rs.EOF)
            If Not (chkFilterByFamily.Checked) Or (frmMain.ThisUnit.Family = Model2Family(rs.Fields(4).Value)) Then
                OneLine = "\highlight1 " & rs.Fields(2).Value & " " & rs.Fields(3).Value & " " & rs.Fields(4).Value & " - " & rs.Fields(1).Value
                OneLine = OneLine.PadRight(140 + 17, " ") & "\par "
                AllLines.Append(OneLine)
                OneLine = "\highlight0 \tab \b" & rs.Fields(5).Value & " \tab DSPC:\b0 " & rs.Fields(6).Value & " \tab \b SAT Ctrl:\b0 " & rs.Fields(7).Value & " \tab \b MWU: \b0 " & rs.Fields(8).Value & " \tab \b HSFan for Reheat: \b0 " & rs.Fields(9).Value & " \tab \b Heat Pump: \b0" & rs.Fields(10).Value & " \tab \b ECM Staging: \b0" & rs.Fields(11).Value & " \tab \b Board Upgrade: \b0" & rs.Fields(12).Value & "\par "
                AllLines.Append(OneLine)
                If XL Then
                    OneLine = rs.Fields(2).Value & "," & rs.Fields(3).Value & "," & rs.Fields(4).Value & "," & rs.Fields(1).Value & "," & rs.Fields(5).Value & "," & rs.Fields(6).Value & "," & rs.Fields(7).Value & ", " & rs.Fields(8).Value & "," & rs.Fields(9).Value & "," & rs.Fields(10).Value & "," & rs.Fields(11).Value & "," & rs.Fields(12).Value
                    historyreport.WriteLine(OneLine)
                End If
            End If
            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        If XL Then
            historyreport.Close()
        End If

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub LoadDWallHistoryTable(XL As Boolean)
        'Upgraded to 2.0 style reporting

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        Me.Width = 530

        txtReport.Text = ""

        MySQL = "SELECT * FROM tblHistoryDWall"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)
        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        Do While Not (rs.EOF)
            If Not (chkFilterByFamily.Checked) Or (frmMain.ThisUnit.Family = Model2Family(rs.Fields(4).Value)) Then
                OneLine = "\highlight1 " & rs.Fields(2).Value & " " & rs.Fields(3).Value & " " & rs.Fields(4).Value & " - " & rs.Fields(1).Value
                OneLine = OneLine.PadRight(80, " ") & "\par "
                AllLines.Append(OneLine)
                OneLine = "\highlight0 \tab \b " & rs.Fields(5).Value & " \tab Using:\b0 " & rs.Fields(6).Value & " \par "
                AllLines.Append(OneLine)
            End If

            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub LoadHGBPHistoryTable(XL As Boolean)
        'Upgraded to 2.0 style reporting
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        txtReport.Text = ""

        MySQL = "SELECT * FROM tblHistoryHGBP"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)
        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        Me.Width = 800

        Do While Not (rs.EOF)
            If Not (chkFilterByFamily.Checked) Or (frmMain.ThisUnit.Family = Model2Family(rs.Fields(4).Value)) Then
                'next line contains 12 escape codes
                OneLine = "\highlight1 " & rs.Fields(2).Value & " " & rs.Fields(3).Value & " " & rs.Fields(4).Value & " - " & rs.Fields(1).Value
                OneLine = OneLine.PadRight(120 + 17, " ") & "\par "
                AllLines.Append(OneLine)
                OneLine = "\highlight0 \tab " & "\b Circuit 1:\b0 " & rs.Fields(5).Value & "\tab " & "\b  Circuit 2:\b0 " & rs.Fields(6).Value & "\tab " & "\b  Circuit 3:\b0 " & rs.Fields(7).Value & "\tab " & "\b  Circuit 4:\b0 " & rs.Fields(8).Value & "\par "
                AllLines.Append(OneLine)
            End If

            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub LoadHWCoilHistoryTable(XL As Boolean)
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder
        Dim fanvar As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        txtReport.Text = ""

        MySQL = "SELECT * FROM tblHistoryHWCoil"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)
        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        Me.Width = 1370

        Do While Not (rs.EOF)
            If Not (chkFilterByFamily.Checked) Or (frmMain.ThisUnit.Family = Model2Family(rs.Fields(4).Value)) Then
                'next line contains 12 escape codes
                OneLine = "\highlight1 " & rs.Fields(2).Value & " " & rs.Fields(3).Value & " " & rs.Fields(4).Value & " - " & rs.Fields(1).Value
                OneLine = OneLine.PadRight(180 + 17, " ") & "\par "
                AllLines.Append(OneLine)
                OneLine = "\highlight0 \tab \b Heating AF:\b0 " & rs.Fields(5).Value & " \tab \b EAT:\b0 " & rs.Fields(6).Value & "\tab \b1 EFT:\b0 " & rs.Fields(7).Value & " \tab \b Fluid Flow:\b0 " & rs.Fields(8).Value & "\tab \b1 Fluid:\b0 " & rs.Fields(9).Value & "\tab \b Fluid %:\b0 " & rs.Fields(10).Value & "\tab \b LAT:\b0 " & rs.Fields(11).Value & "\tab \b LFT:\b0 " & rs.Fields(12).Value & "\tab \b Coil APD:\b0 " & rs.Fields(13).Value & "\tab \b FPD:\b0 " & rs.Fields(14).Value & "\tab \b Capacity:\b0 " & rs.Fields(15).Value & "\par "
                AllLines.Append(OneLine)
            End If

            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub LoadCustomControlsTable(XL As Boolean)
        'Upgraded to 2.0 style reporting
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        txtReport.Text = ""

        MySQL = "SELECT * FROM tblHistoryCstmCtrl"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)
        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        Me.Width = 880

        Do While Not (rs.EOF)
            If Not (chkFilterByFamily.Checked) Or (frmMain.ThisUnit.Family = Model2Family(rs.Fields(4).Value)) Then
                'next line contains 12 escape codes
                OneLine = "\highlight1 " & rs.Fields(2).Value & " " & rs.Fields(3).Value & " " & rs.Fields(4).Value & " - " & rs.Fields(1).Value
                OneLine = OneLine.PadRight(120 + 17, " ") & "\par "
                AllLines.Append(OneLine)
                OneLine = "\highlight0 \tab " & "\b Modification Code:\b0 " & rs.Fields(5).Value & "\tab " & "\b  Description:\b0 " & rs.Fields(6).Value & "\tab " & "\b  Base Controller:\b0 " & rs.Fields(7).Value & "\par "
                AllLines.Append(OneLine)
            End If

            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub LoadLowAFHistoryTable(XL As Boolean)
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        txtReport.Text = ""

        MySQL = "SELECT * FROM tblHistorySFan"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)
        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        Me.Width = 1300

        Do While Not (rs.EOF)
            If Not (chkFilterByFamily.Checked) Or (frmMain.ThisUnit.Family = Model2Family(rs.Fields(4).Value)) Then
                'next line contains 12 escape codes
                OneLine = "\highlight1 " & rs.Fields(2).Value & " " & rs.Fields(3).Value & " " & rs.Fields(4).Value & " - " & rs.Fields(1).Value
                OneLine = OneLine.PadRight(175 + 17, " ") & "\par "
                AllLines.Append(OneLine)
                OneLine = "\highlight0 \tab \b Airflow:\b0 " & rs.Fields(5).Value & " \tab \b TSP:\b0 " & rs.Fields(6).Value & "\tab \b1 Solution:\b0 " & rs.Fields(7).Value & " \tab \b Nominal Air:\b0 " & rs.Fields(8).Value & "\tab \b1 MinCatAir:\b0 " & rs.Fields(9).Value & "\tab \b BypasAir:\b0 " & rs.Fields(10).Value & "\par "
                AllLines.Append(OneLine)
            End If

            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub

    Private Sub LoadMGH_RHistoryTable(XL As Boolean)
        'Upgraded to 2.0 style reporting

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        Me.Width = 710

        txtReport.Text = ""

        MySQL = "SELECT * FROM tblHistoryMGH_R"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)
        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        Do While Not (rs.EOF)
            If Not (chkFilterByFamily.Checked) Or (frmMain.ThisUnit.Family = Model2Family(rs.Fields(4).Value)) Then
                OneLine = "\highlight1 " & rs.Fields(2).Value & " " & rs.Fields(3).Value & " " & rs.Fields(4).Value & " - " & rs.Fields(1).Value
                OneLine = OneLine.PadRight(110, " ") & "\par "
                AllLines.Append(OneLine)
                OneLine = "\highlight0 \tab \b Propane:\b0 " & rs.Fields(5).Value & " \tab\b Elevation:\b0 " & rs.Fields(6).Value & " \tab\b GBAS:\b0 " & rs.Fields(7).Value & " \tab\b CstmCtrl:\b0 " & rs.Fields(8).Value & " \tab\b Controller:\b0 " & rs.Fields(9).Value & " \tab\b DeltaT:\b0 " & rs.Fields(10).Value & " \par "
                AllLines.Append(OneLine)
            End If

            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub LoadMHGRH_ConvHistoryTable(XL As Boolean)
        'Upgraded to 2.0 style reporting

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        Me.Width = 1000

        txtReport.Text = ""

        MySQL = "SELECT * FROM tblHistoryMHGRH_Conv"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)
        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        Do While Not (rs.EOF)
            If Not (chkFilterByFamily.Checked) Or (frmMain.ThisUnit.Family = Model2Family(rs.Fields(4).Value)) Then
                OneLine = "\highlight1 " & rs.Fields(2).Value & " " & rs.Fields(3).Value & " " & rs.Fields(4).Value & " - " & rs.Fields(1).Value
                OneLine = OneLine.PadRight(160, " ") & "\par "
                AllLines.Append(OneLine)
                OneLine = "\highlight0 \tab \b RH Capacity:\b0 " & rs.Fields(5).Value & " \tab\b RH Airflow:\b0 " & rs.Fields(6).Value & " \tab\b EAT:\b0 " & rs.Fields(7).Value & " \tab\b Ckts of RH:\b0 " & rs.Fields(8).Value & " \tab\b DH Strat:\b0 " & rs.Fields(9).Value & " \tab\b RH Strat:\b0 " & rs.Fields(10).Value & " \tab\b DeltaT:\b0 " & rs.Fields(11).Value & " \par "
                AllLines.Append(OneLine)
            End If

            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub LoadCustomCoilTable(XL As Boolean)

    End Sub
    Private Sub LoadUnitReportTable(XL As Boolean)
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder
        Dim fanvar As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        txtReport.Text = ""

        MySQL = "SELECT * FROM tblHistory"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)
        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        Me.Width = 780

        Do While Not (rs.EOF)
            If Not (chkFilterByFamily.Checked) Or (frmMain.ThisUnit.Family = Model2Family(rs.Fields(4).Value)) Then
                'next line contains 12 escape codes
                OneLine = "\highlight1 " & rs.Fields(2).Value & " " & rs.Fields(3).Value & " " & rs.Fields(4).Value & " - " & rs.Fields(1).Value
                OneLine = OneLine.PadRight(100 + 17, " ") & "\par "
                AllLines.Append(OneLine)
                OneLine = "\highlight0 \tab \b Mod Codes:\b0 " & rs.Fields(6).Value
                OneLine = OneLine.PadRight(120, " ")
                AllLines.Append(OneLine)
                If Environment.UserName = "jlevine" Then
                    OneLine = " \tab \b Creator:\b0 " & rs.Fields(7).Value
                    AllLines.Append(OneLine)
                End If
                OneLine = "\par"
                AllLines.Append(OneLine)
            End If

            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub LoadAFlowModHistoryTable(XL As Boolean)
        'Upgraded to 2.0 style reporting

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim OneLine As String
        Dim AllLines As New System.Text.StringBuilder

        Dim i, j As Integer
        Dim OneMod(10) As String
        Dim TempMods As String


        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        Me.Width = 1000

        txtReport.Text = ""

        MySQL = "SELECT * FROM tblHistoryAFlowMod"

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        rs.Open(MySQL, con)
        AllLines.Clear()
        AllLines.Append("{\rtf1\ansi ")
        AllLines.Append("{\colortbl;\red152\green251\blue152;}")

        Do While Not (rs.EOF)
            If Not (chkFilterByFamily.Checked) Or (frmMain.ThisUnit.Family = Model2Family(rs.Fields(4).Value)) Then
                OneLine = "\highlight1 " & rs.Fields(2).Value & " " & rs.Fields(3).Value & " " & rs.Fields(4).Value & " - " & rs.Fields(1).Value
                OneLine = OneLine.PadRight(160, " ") & "\par "
                AllLines.Append(OneLine)
                i = 0
                TempMods = rs.Fields(5).Value
                Do While InStr(TempMods, "===")
                    OneMod(i) = Mid(TempMods, 1, InStr(TempMods, "===") - 2)
                    TempMods = Trim(Mid(TempMods, InStr(TempMods, "===") + 4))
                    i = i + 1
                Loop
                OneMod(i) = TempMods
                For j = 0 To i
                    OneLine = "\highlight0 \tab \b RH Mod:\b0 " & OneMod(j) & " \tab\b Controller:\b0 " & rs.Fields(6).Value & " \tab\b Airflow:\b0 " & rs.Fields(7).Value & " \tab\b Duct Flanges:\b0 " & rs.Fields(8).Value & " \tab\b USP Adjustment:\b0 " & rs.Fields(9).Value & " \par "
                    AllLines.Append(OneLine)
                Next j
            End If

            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub InitializeQuery(ExcelNeed As Boolean)
        Dim dummy As MsgBoxResult

        If Not (cmbModCode.Text = "Not Selected") Then

            Select Case pMyModule
                Case Is = "Unit Report"
                    Call LoadUnitReportTable(ExcelNeed)
                Case Is = "100OA"
                    Call Load100OAHistoryTable(ExcelNeed)
                    Me.Text = "100% Outdoor Air History"
                Case Is = "AFlowMod"
                    Call LoadAFlowModHistoryTable(ExcelNeed)
                    Me.Text = "Air Flow Reconfiguration"
                Case Is = "CstmCtrl"
                    Call LoadCustomControlsTable(ExcelNeed)
                    Me.Text = "Custom Controls History"
                Case Is = "CustomCoil"
                    Call LoadCustomCoilTable(ExcelNeed)
                    Me.Text = "Custom Coil History"
                Case Is = "DWall"
                    Call LoadDWallHistoryTable(ExcelNeed)
                    Me.Text = "Double Wall History"
                Case Is = "Filters"
                    Call LoadFilterHistoryTable(ExcelNeed)
                    Me.Text = "Filter History"
                Case Is = "HGBP"
                    Call LoadHGBPHistoryTable(ExcelNeed)
                    Me.Text = "Hot Gas Bypass History"
                Case Is = "HWCoil"
                    Call LoadHWCoilHistoryTable(ExcelNeed)
                    Me.Text = "Hot Water Coil History"
                Case Is = "LCVAV"
                    Call LoadLCVAVHistoryTable(ExcelNeed)
                    Me.Text = "Light Commercial VAV"
                Case Is = "LowAF"
                    Call LoadLowAFHistoryTable(ExcelNeed)
                Case Is = "MGH(R)"
                    Call LoadMGH_RHistoryTable(ExcelNeed)
                Case Is = "MHGRH_Conv"
                    Call LoadMHGRH_ConvHistoryTable(ExcelNeed)
                Case Is = "RFan"
                    'ToDo
                    Me.Text = "New Return Fan - History is Offline"
                Case Is = "SFan"
                    Call LoadSupplyFanHistoryTable(ExcelNeed)
                    Me.Text = "New Supply Fan"
                Case Is = "XFan"
                    'ToDo
                    Me.Text = "New Exhaust Fan - History is Offline"
                Case Else
                    dummy = MsgBox("Reporting for that module is not yet available." & vbCrLf & "The development team may be able to provide you with a data file.", vbOKOnly, "Incomplete Report Detected")
            End Select
        Else

        End If
    End Sub
    Private Sub chkFilterByFamily_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilterByFamily.CheckedChanged
        Call InitializeQuery(False)
    End Sub

    Private Sub frmHistoryReport_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width < 530 Then Me.Width = 530
        If Me.Height < 265 Then Me.Height = 265

        txtReport.Width = Me.Width - 40
        txtReport.Height = Me.Height - 144

        TabControl1.Width = Me.Width - 30
        TabControl1.Height = Me.Height - 135

        DataGridView1.Width = Me.Width - 40
        DataGridView1.Height = Me.Height - 144

        If frmMain.chkDebug.Checked Then
            Label1.Text = Me.Width
        End If
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pMyModule = "Not Selected"
    End Sub

    Private Sub cmbModCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModCode.SelectedIndexChanged
        If pMyModule = "" Then
            pMyModule = "Not Selected"
        Else
            pMyModule = cmbModCode.Text
        End If
        Call InitializeQuery(False)
    End Sub

    Private Sub cmdExcelNeed_Click(sender As Object, e As EventArgs) Handles cmdExcelNeed.Click
        Call InitializeQuery(True)
    End Sub

    Private Function XLSavePath(FileName As String) As String
        Dim temp As String

        temp = My.Settings.LastHistoryPath

        FolderBrowserDialog1.SelectedPath = temp
        FolderBrowserDialog1.ShowDialog()
        temp = FolderBrowserDialog1.SelectedPath & "\"
        My.Settings.LastHistoryPath = temp
        My.Settings.Save()
        temp = temp & FileName
        Return temp
    End Function
End Class