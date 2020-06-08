Imports System.IO

Module basTabValidation
    Private glbNoBlanks = " must not be blank."
    Private glbProjName = "Fisen Unit Generator"

    Public Function ProjectDataValid() As Boolean
        Dim tabOK As Boolean
        tabOK = True

        tabOK = tabOK And JobNumberOK() And ProjectNameOK() And UnitTagOK() And UnitNumberOK() And QtyOK() And UnitVersionOK()
        tabOK = tabOK And BrandModNumOK() And NomTonsOK()

        ProjectDataValid = tabOK
    End Function
    Private Function NomTonsOK() As Boolean
        Dim dummy As MsgBoxResult
        Dim ok As Boolean

        ok = True
        If Trim(frmMain.txtNominalTons.Text) = "" Then
            dummy = MsgBox("Nominal Tonnage" & glbNoBlanks, MsgBoxStyle.OkOnly, glbProjName)
            ok = False
        End If

        If Not (IsNumeric(frmMain.txtNominalTons.Text)) Then
            dummy = MsgBox("Nominal Tonnage must be a non zero number.", MsgBoxStyle.OkOnly, glbProjName)
        End If
        NomTonsOK = ok
    End Function
    Private Function BrandModNumOK() As Boolean
        Dim dummy As MsgBoxResult
        Dim ok As Boolean

        ok = True
        If Trim(frmMain.txtBrandModelNumber.Text) = "" Then
            dummy = MsgBox("Brand Model Number" & glbNoBlanks, MsgBoxStyle.OkOnly, glbProjName)
            ok = False
        End If
        BrandModNumOK = ok
    End Function
    Private Function UnitVersionOK() As Boolean
        Dim con As ADODB.Connection
        Dim rs As ADODB.Recordset
        Dim dbProvider As String
        Dim jname, unit, ver As String

        Dim dummy As MsgBoxResult
        Dim ok As Boolean
        Dim HighVer, errmsg As String
        Dim tempver As Single

        jname = frmMain.txtProjectName.Text
        unit = frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text
        ver = frmMain.txtUnitVersion.Text

        ok = True
        If Trim(frmMain.txtUnitVersion.Text) = "" Then
            dummy = MsgBox("Unit Version" & glbNoBlanks, MsgBoxStyle.OkOnly, glbProjName)
            ok = False
        End If

        If Not (IsNumeric(frmMain.txtUnitVersion.Text)) Then
            dummy = MsgBox("Unit Varsion must be a non zero number.", MsgBoxStyle.OkOnly, glbProjName)
            ok = False
        End If

        'Check and see if the current version is already in the database
        If ok Then
            con = New ADODB.Connection
            dbProvider = "FIL=MS ACCESS;DSN=FUGenerator"
            con.ConnectionString = dbProvider
            con.Open()

            rs = New ADODB.Recordset With {
                .CursorType = ADODB.CursorTypeEnum.adOpenDynamic
            }

            Dim MySQL As String



            'MySQL = "Select * FROM tblHistory WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') AND (Version='" & ver & "') ORDER BY Version DESC"
            MySQL = "Select * FROM tblHistory WHERE (JobName='" & jname & "') AND (UnitID='" & unit & "') ORDER BY Version DESC"

            rs.Open(MySQL, con)

            If Not (rs.EOF And rs.BOF) Then
                HighVer = rs.Fields(3).Value
                If Val(HighVer) >= Val(ver) Then
                    tempver = Val(HighVer)
                    tempver = tempver + 0.1
                    errmsg = "You have already generated a submittal with the version of the submittal." & vbCrLf & "Yes to Auto Increment to " & Trim(Str(tempver)) & vbCrLf & "No to replace existing submittal record." & vbCrLf & "Cancel to change manually."
                    dummy = MsgBox(errmsg, vbYesNoCancel, "Fisen Unit Generator")
                    If dummy = vbYes Then frmMain.txtUnitVersion.Text = Trim(Str(tempver))
                    If dummy = vbCancel Then ok = False
                End If
            End If

            con.Close()
            rs = Nothing
            con = Nothing

        End If
        Call MoveOldSubmittal()
        UnitVersionOK = ok
    End Function
    Private Sub MoveOldSubmittal()
        Dim SubDir As String
        Dim SubName As String
        Dim NewVerNum, OldVerNum As String

        SubDir = frmMain.txtProjectDirectory.Text & frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & "\Submittal Source (Do not Distribute)\"

        SubName = frmMain.txtJobNumber.Text & "-" & frmMain.txtUnitNumber.Text & " - Submittal V"
        NewVerNum = frmMain.txtUnitVersion.Text
        OldVerNum = Trim(Int(Val(NewVerNum)) - 1)
        SubName = SubName & OldVerNum & "_0.docx"
        If File.Exists(SubDir & SubName) Then
            File.Move(SubDir & SubName, SubDir & "Archives\" & SubName)
        End If


    End Sub
    Private Function QtyOK() As Boolean
        Dim dummy As MsgBoxResult
        Dim ok As Boolean

        ok = True
        If Trim(frmMain.txtQty.Text) = "" Then
            dummy = MsgBox("Quantity" & glbNoBlanks, MsgBoxStyle.OkOnly, glbProjName)
            ok = False
        End If
        If Val(frmMain.txtQty.Text) <= 0 Then
            dummy = MsgBox("Quantity must be a non zero number.", MsgBoxStyle.OkOnly, glbProjName)
        End If
        QtyOK = ok
    End Function
    Private Function UnitNumberOK() As Boolean
        Dim dummy As MsgBoxResult
        Dim ok As Boolean

        ok = True
        If Trim(frmMain.txtUnitNumber.Text) = "" Then
            dummy = MsgBox("Unit Number" & glbNoBlanks, MsgBoxStyle.OkOnly, glbProjName)
            ok = False
        End If
        UnitNumberOK = ok
    End Function
    Private Function JobNumberOK() As Boolean
        Dim dummy As MsgBoxResult
        Dim ok As Boolean

        ok = True
        If Trim(frmMain.txtJobNumber.Text) = "" Then
            dummy = MsgBox("Job Number" & glbNoBlanks, MsgBoxStyle.OkOnly, glbProjName)
            ok = False
        End If
        JobNumberOK = ok
    End Function
    Private Function ProjectNameOK() As Boolean
        Dim dummy As MsgBoxResult
        Dim ok As Boolean
        dummy = 0

        ok = True
        If Trim(frmMain.txtProjectName.Text) = "" Then
            frmMain.txtProjectName.Text = "SAMPLE PROJECT"
        End If
        ProjectNameOK = ok
    End Function
    Private Function UnitTagOK() As Boolean
        Dim dummy As MsgBoxResult
        Dim ok As Boolean

        ok = True
        If Trim(frmMain.txtUnitTag.Text) = "" Then
            dummy = MsgBox("Unit Tag Blank.  Use Default?", MsgBoxStyle.YesNo, glbProjName)
            If dummy = MsgBoxResult.Yes Then
                frmMain.txtUnitTag.Text = frmMain.ThisUnit.Kingdom & "-1"
            Else
                ok = False
            End If
        End If
        UnitTagOK = ok
    End Function
End Module
