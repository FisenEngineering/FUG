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
        Call InitializeQuery()
    End Sub

    Private Sub Load100OAHistoryTable()
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
            End If

            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub LoadFilterHistoryTable()
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
    Private Sub LoadSupplyFanHistoryTable()
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
    Private Sub LoadLCVAVHistoryTable()
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
            End If
            rs.MoveNext()
        Loop

        AllLines.Append("}")
        txtReport.Rtf = AllLines.ToString

        con.Close()
        rs = Nothing
        con = Nothing
    End Sub
    Private Sub LoadDWallHistoryTable()
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
    Private Sub LoadHGBPHistoryTable()
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
    Private Sub LoadHWCoilHistoryTable()
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
    Private Sub LoadCustomControlsTable()
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

    Private Sub LoadLowAFHistoryTable()
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

    Private Sub LoadMGH_RHistoryTable()
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
    Private Sub LoadMHGRH_ConvHistoryTable()
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
    Private Sub LoadUnitReportTable()
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

    Private Sub InitializeQuery()
        If Not (cmbModCode.Text = "Not Selected") Then

            Select Case pMyModule
                Case Is = "Unit Report"
                    Call LoadUnitReportTable()
                Case Is = "100OA"
                    Call Load100OAHistoryTable()
                    Me.Text = "100% Outdoor Air History"
                Case Is = "CstmCtrl"
                    Call LoadCustomControlsTable()
                    Me.Text = "Custom Controls History"
                Case Is = "DWall"
                    Call LoadDWallHistoryTable()
                    Me.Text = "Double Wall History"
                Case Is = "Filters"
                    Call LoadFilterHistoryTable()
                    Me.Text = "Filter History"
                Case Is = "HGBP"
                    Call LoadHGBPHistoryTable()
                    Me.Text = "Hot Gas Bypass History"
                Case Is = "HWCoil"
                    Call LoadHWCoilHistoryTable()
                    Me.Text = "Hot Water Coil History"
                Case Is = "LCVAV"
                    Call LoadLCVAVHistoryTable()
                    Me.Text = "Light Commercial VAV"
                Case Is = "LowAF"
                    Call LoadLowAFHistoryTable()
                Case Is = "MGH(R)"
                    Call LoadMGH_RHistoryTable()
                Case Is = "MHGRH_Conv"
                    Call LoadMHGRH_ConvHistoryTable
                Case Is = "RFan"
                    'ToDo
                    Me.Text = "New Return Fan - History is Offline"
                Case Is = "SFan"
                    Call LoadSupplyFanHistoryTable()
                    Me.Text = "New Supply Fan"
                Case Is = "XFan"
                    'ToDo
                    Me.Text = "New Exhaust Fan - History is Offline"
            End Select
        Else

        End If
    End Sub
    Private Sub chkFilterByFamily_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilterByFamily.CheckedChanged
        Call InitializeQuery()
    End Sub

    Private Sub frmHistoryReport_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width < 530 Then Me.Width = 530
        If Me.Height < 265 Then Me.Height = 265

        txtReport.Width = Me.Width - 40
        txtReport.Height = Me.Height - 144

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
        Call InitializeQuery()
    End Sub
End Class