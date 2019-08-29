Module basTabValidation
    Private glbNoBlanks = " must not be blank."
    Private glbProjName = "Fisen Unit Generator"

    Public Function ProjectDataValid() As Boolean
        Dim tabOK As Boolean
        tabOK = True

        tabOK = tabOK And JobNumberOK() And ProjectNameOK() And UnitTagOK() And UnitNumberOK And QtyOK And UnitVersionOK()
        tabOK = tabOK And BrandModNumOK() And NomTonsOK

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
        Dim dummy As MsgBoxResult
        Dim ok As Boolean

        ok = True
        If Trim(frmMain.txtUnitVersion.Text) = "" Then
            dummy = MsgBox("Unit Version" & glbNoBlanks, MsgBoxStyle.OkOnly, glbProjName)
            ok = False
        End If

        If Not (IsNumeric(frmMain.txtUnitVersion.Text)) Then
            dummy = MsgBox("Unit Varsion must be a non zero number.", MsgBoxStyle.OkOnly, glbProjName)
        End If
        UnitVersionOK = ok
    End Function
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
