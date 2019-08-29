Public Class frmAddHydroValve
    Private pCancelled As Boolean
    Private pNewValveTag As String
    Public Property NewValveTag As String
        Get
            NewValveTag = pNewValveTag
        End Get
        Set(value As String)
            pNewValveTag = value
        End Set
    End Property
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim nextValve As Integer
        Dim nextValveTag As String
        Dim ValveSize As String
        Dim ValveType As String
        Dim ValveStyle As String
        Dim ValveBrand As String
        Dim ValveVolume As String
        Dim ValveWeight As String
        Dim ValveCV As String
        Dim ValvePD As String
        Dim ValveDesc As String

        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim NewRow() As String

        nextValve = frmMain.ThisUnitHydroData.ButterflyValveTags.Count + 1
        nextValveTag = "V-" & Trim(Str(nextValve))
        pNewValveTag = nextValveTag
        frmMain.ThisUnitHydroData.ButterflyValveTags.Add(nextValveTag)
        ValveSize = ToFracSize(lstValveSize.Text)
        ValveBrand = lstValveBrand.Text
        If frmPipePkg.AutoValveDesc = "" Then
            ValveDesc = "User Entered"
        Else
            ValveDesc = frmPipePkg.AutoValveDesc
        End If

        If optBallValve.Checked Then
            ValveType = "Butterfly Valve"
        Else
            ValveType = "Ball Valve"
        End If
        ValveStyle = lstValveStyle.Text

        If optBallValve.Checked Then
            ValveType = "Ball Valve"
        Else
            ValveType = "Butterfly Valve"
        End If
        ValveStyle = lstValveStyle.Text

        If ValveStyle = "" Then Exit Sub

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblHydroValveData WHERE Type='" & ValveType & "' AND Style='" & ValveStyle & "' AND Brand='" & ValveBrand & "' AND Size='" & lstValveSize.Text & "'"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        ValveWeight = rs.Fields("DryWeight").Value
        ValveVolume = rs.Fields("FluidVol").Value
        ValveCV = rs.Fields("cV").Value

        con.Close()
        rs = Nothing
        con = Nothing

        ValvePD = Str((Val(frmPipePkg.txtFlow.Text) * (Val(frmPipePkg.txtFlow.Text) / Val(ValveCV)) ^ 2) * 2.31)

        NewRow = {nextValveTag, ValveDesc, ValveSize, ValveType, ValveStyle, ValveWeight, ValveVolume, ValvePD}
        frmPipePkg.gridValveSchedule.Rows.Add(NewRow)
        frmPipePkg.AutoValveDesc = ""
        Hide()
    End Sub
    Private Sub LoadValveStyles()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim ValveType As String
        Dim ThisStyle As String
        Dim NextStyle As String

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()
        lstValveStyle.Items.Clear()
        lstValveBrand.Items.Clear()
        lstValveSize.Items.Clear()

        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        If optBallValve.Checked Then
            ValveType = "Ball Valve"
        Else
            ValveType = "Butterfly Valve"
        End If

        MySQL = "SELECT * FROM tblHydroValveData WHERE Type='" & ValveType & "' ORDER BY Style"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        ThisStyle = rs.Fields("Style").Value
        lstValveStyle.Items.Add(rs.Fields("Style").Value)
        rs.MoveNext()
        Do While Not (rs.EOF)
            NextStyle = rs.Fields("Style").Value
            If NextStyle <> ThisStyle Then
                lstValveStyle.Items.Add(NextStyle)
                ThisStyle = NextStyle
            End If
            rs.MoveNext()
        Loop
        con.Close()
        rs = Nothing
        con = Nothing
        lstValveStyle.SetSelected(0, True)

    End Sub
    Private Sub LoadValveBrand()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim ValveType As String
        Dim ValveStyle As String
        Dim ThisBrand As String
        Dim NextBrand As String

        If optBallValve.Checked Then
            ValveType = "Ball Valve"
        Else
            ValveType = "Butterfly Valve"
        End If
        ValveStyle = lstValveStyle.Text

        If ValveStyle = "" Then Exit Sub

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        lstValveBrand.Items.Clear()
        lstValveSize.Items.Clear()



        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblHydroValveData WHERE Type='" & ValveType & "' AND Style='" & ValveStyle & "' ORDER BY Brand"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        ThisBrand = rs.Fields("Brand").Value
        lstValveBrand.Items.Add(ThisBrand)
        rs.MoveNext()
        Do While Not (rs.EOF)
            NextBrand = rs.Fields("Brand").Value
            If NextBrand <> ThisBrand Then
                lstValveBrand.Items.Add(NextBrand)
                ThisBrand = NextBrand
            End If
            rs.MoveNext()
        Loop
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub LoadValveSize()
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        Dim ValveType As String
        Dim ValveStyle As String
        Dim ValveBrand As String
        Dim ThisSize As String
        Dim NextSize As String

        If optBallValve.Checked Then
            ValveType = "Ball Valve"
        Else
            ValveType = "Butterfly Valve"
        End If
        ValveStyle = lstValveStyle.Text
        ValveBrand = lstValveBrand.Text

        If ValveBrand = "" Then Exit Sub

        con = New ADODB.Connection
        dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        lstValveSize.Items.Clear()



        rs = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        }

        MySQL = "SELECT * FROM tblHydroValveData WHERE Type='" & ValveType & "' AND Style='" & ValveStyle & "' AND Brand='" & ValveBrand & "' ORDER BY Size"
        rs.Open(MySQL, con)

        rs.MoveFirst()
        ThisSize = rs.Fields("Size").Value
        lstValveSize.Items.Add(ThisSize)
        rs.MoveNext()
        Do While Not (rs.EOF)
            NextSize = rs.Fields("Size").Value
            If NextSize <> ThisSize Then
                lstValveSize.Items.Add(NextSize)
                ThisSize = NextSize
            End If
            rs.MoveNext()
        Loop
        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Private Sub optButterflyValve_CheckedChanged(sender As Object, e As EventArgs) Handles optButterflyValve.CheckedChanged
        Call LoadValveStyles()
    End Sub

    Private Sub lstValveStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstValveStyle.SelectedIndexChanged
        Call LoadValveBrand()
        If lstValveBrand.Items.Count > 0 Then
            lstValveBrand.SetSelected(0, True)
        End If
    End Sub

    Private Sub lstValveBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstValveBrand.SelectedIndexChanged
        Call LoadValveSize()
        lstValveSize.SetSelected(0, True)
        If frmPipePkg.AutoValveDesc = "" Then
            'do nothing
        Else
            lstValveSize.Text = frmPipePkg.AutoValveSize
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        pCancelled = True
        frmPipePkg.AutoValveDesc = ""
        Hide()
    End Sub

    Private Sub frmAddHydroValve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCancelled = False
        If frmPipePkg.AutoValveDesc <> "" Then Me.Text = Me.Text & "-" & frmPipePkg.AutoValveDesc
        If frmPipePkg.AutoValveDesc = "" Then
            'do nothing
        Else
            If Val(frmPipePkg.AutoValveSize) <= 2 Then
                optBallValve.Checked = True
            End If
        End If
    End Sub
End Class