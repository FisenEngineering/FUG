Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Module basImportChillers
    Public Sub ImportYVAA()


        Dim UnitReader As XmlReader
        Dim myXMLSettings As New XmlReaderSettings

        Dim myFluid As String

        UnitReader = XmlReader.Create("C:\Users\jlevine\Desktop\BaseUnitSelection.xml", myXMLSettings)
        UnitReader.ReadToFollowing("Table") 'This is the top table

        UnitReader.ReadToDescendant("TR")
        UnitReader.ReadToNextSibling("TR")
        UnitReader.ReadToDescendant("TD") 'Tag
        frmMain.txtUnitTag.Text = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD") 'Qty
        frmMain.txtQty.Text = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD") 'Model Number
        frmMain.txtModelNumber.Text = UnitReader.ReadElementContentAsString()
        frmMain.txtBrandModelNumber.Text = frmMain.txtModelNumber.Text
        UnitReader.ReadToNextSibling("TD") 'Net Cool Cap
        frmMain.ThisChillerMainPerf.NominalTons = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD") 'Electrical
        frmMain.ThisChillerMainPerf.Elec = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD") 'Refrigerant
        frmMain.ThisChillerMainPerf.Refrigerant = UnitReader.ReadElementContentAsString()

        UnitReader.ReadToFollowing("Table")
        'UnitReader.ReadToNextSibling("Table") 'This is the PIN table
        UnitReader.ReadToDescendant("TR")
        UnitReader.ReadToNextSibling("TR")
        UnitReader.ReadToDescendant("TD")

        frmMain.ThisChillerMainPerf.PINA = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD")
        frmMain.ThisChillerMainPerf.PINB = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD")
        frmMain.ThisChillerMainPerf.PINC = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD")
        frmMain.ThisChillerMainPerf.PIND = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD")
        frmMain.ThisChillerMainPerf.PINE = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD")
        frmMain.ThisChillerMainPerf.PINF = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD")
        frmMain.ThisChillerMainPerf.PING = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD")
        frmMain.ThisChillerMainPerf.PINH = UnitReader.ReadElementContentAsString()

        UnitReader.ReadToFollowing("Table")
        'UnitReader.ReadToNextSibling("Table") 'This is the Evap Performance table
        UnitReader.ReadToDescendant("TR") 'Skips the first line
        UnitReader.ReadToNextSibling("TR")
        UnitReader.ReadToDescendant("TD") 'Should be EWT datum
        frmMain.ThisChillerMainPerf.EWT = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD") 'fluid volume heading
        UnitReader.ReadToNextSibling("TD") 'Should be fluid volume datum
        frmMain.ThisChillerMainPerf.EvapVolume = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD") 'EER heading
        UnitReader.ReadToNextSibling("TD") 'Should be EER datum
        frmMain.ThisChillerMainPerf.EER = UnitReader.ReadElementContentAsString()

        UnitReader.ReadToFollowing("TH") ' Should move to the beginning of the next line
        UnitReader.ReadToNextSibling("TD") 'Should be LWT datum
        frmMain.ThisChillerMainPerf.LWT = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD") 'min flow heading
        UnitReader.ReadToNextSibling("TD") 'Should be min flow datum
        frmMain.ThisChillerMainPerf.MinFlow = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD") 'nplv heading
        UnitReader.ReadToNextSibling("TD") 'Should be nplv datum
        frmMain.ThisChillerMainPerf.NPLV = UnitReader.ReadElementContentAsString()

        UnitReader.ReadToFollowing("TH") ' Should move to the beginning of the next line
        UnitReader.ReadToNextSibling("TD") 'Should be Design Flow datum
        frmMain.ThisChillerMainPerf.Flow = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD") 'max flow heading
        UnitReader.ReadToNextSibling("TD") 'Should be max flow datum
        frmMain.ThisChillerMainPerf.MaxFlow = UnitReader.ReadElementContentAsString()

        UnitReader.ReadToFollowing("TH") ' Should move to the beginning of the next line
        UnitReader.ReadToNextSibling("TD") 'Should be Evap Pressure Drop datum
        frmMain.ThisChillerMainPerf.FPD = UnitReader.ReadElementContentAsString()

        UnitReader.ReadToFollowing("TH") ' Should move to the beginning of the next line
        UnitReader.ReadToNextSibling("TD") 'Should be Fluid datum
        myFluid = UnitReader.ReadElementContentAsString()
        If InStr(myFluid, "Ethylene") > 0 Then myFluid = "EG "
        If InStr(myFluid, "Prop") > 0 Then myFluid = "PG "
        UnitReader.ReadToNextSibling("TD") 'Should be percentage
        frmMain.ThisChillerMainPerf.Fluid = myFluid & UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD") 'Should be ambient header
        UnitReader.ReadToNextSibling("TD") 'should be design ambient
        frmMain.ThisChillerMainPerf.Ambient = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD") 'Should be Rigging Header
        UnitReader.ReadToNextSibling("TD") 'should be Rigging Data
        frmMain.ThisChillerMainPerf.RigWeight = UnitReader.ReadElementContentAsString()

        UnitReader.ReadToFollowing("TH") ' Should move to the beginning of the next line
        UnitReader.ReadToNextSibling("TD") 'Should be foul factor datum
        frmMain.ThisChillerMainPerf.FoulingFactor = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD") 'altitude heading
        UnitReader.ReadToNextSibling("TD") 'Should be altitude datum
        frmMain.ThisChillerMainPerf.Altitude = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD") 'Should be op Header
        UnitReader.ReadToNextSibling("TD") 'should be op Data
        frmMain.ThisChillerMainPerf.OpWeight = UnitReader.ReadElementContentAsString()

        UnitReader.ReadToFollowing("TH") ' Should move to the beginning of the next line
        UnitReader.ReadToNextSibling("TD") 'Should be comp type head
        UnitReader.ReadToNextSibling("TD") 'Should be comp type
        frmMain.ThisChillerMainPerf.CompType = UnitReader.ReadElementContentAsString()
        UnitReader.ReadToNextSibling("TD") 'ref charge head
        UnitReader.ReadToNextSibling("TD") 'Should be refcharge datum
        frmMain.ThisChillerMainPerf.RefrigerantCharge = UnitReader.ReadElementContentAsString()

    End Sub


End Module
