Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Public Class clsPhysicalData
    Private pLength As String
    Private pWidth As String
    Private pHeight As String
    Private pOpWeight As String
    Private pRigWeight As String
    Private pBaseUnitWeight As String
    Private pSFWeight As String
    Private pClearTop As String
    Private pClearBottom As String
    Private pClearLeft As String
    Private pClearRight As String
    Private pClearFront As String
    Private pClearBack As String
    Private pModLoadItem As New ArrayList
    Private pModLoadMass As New ArrayList
    Private pModLoadMod As New ArrayList
    Private pPointLoad As New ArrayList
    Private pBasePointLoad As New ArrayList
    Private pBasePointLoadXLoc As New ArrayList
    Private pBasePointLoadYLoc As New ArrayList

    Private pCalcPoints As String


    Public Property Length As String
        Get
            Length = Format(Val(pLength), "0")
        End Get
        Set(value As String)
            pLength = value
        End Set
    End Property
    Public Property Width As String
        Get
            Width = Format(Val(pWidth), "0")
        End Get
        Set(value As String)
            pWidth = value
        End Set
    End Property
    Public Property Height As String
        Get
            Height = Format(Val(pHeight), "0")
        End Get
        Set(value As String)
            pHeight = value
        End Set
    End Property
    Public Property OpWeight As String
        Get
            OpWeight = Format(Val(pOpWeight), "0")
        End Get
        Set(value As String)
            pOpWeight = value
        End Set
    End Property
    Public Property RigWeight As String
        Get
            RigWeight = Format(Val(pRigWeight), "0")
        End Get
        Set(value As String)
            pRigWeight = value
        End Set
    End Property
    Public Property BaseUnitWeight As String
        Get
            BaseUnitWeight = Format(Val(pBaseUnitWeight), "0")
        End Get
        Set(value As String)
            pBaseUnitWeight = value
        End Set
    End Property

    Public Property SFWeight As String
        Get
            SFWeight = Format(Val(pSFWeight), "0")
        End Get
        Set(value As String)
            pSFWeight = value
        End Set
    End Property
    Public Property ClrTop As String
        Get
            ClrTop = Format(Val(pClearTop), "0")
        End Get
        Set(value As String)
            pClearTop = value
        End Set
    End Property
    Public Property ClrBottom As String
        Get
            ClrBottom = Format(Val(pClearBottom), "0")
        End Get
        Set(value As String)
            pClearBottom = value
        End Set
    End Property
    Public Property ClrRight As String
        Get
            ClrRight = Format(Val(pClearRight), "0")
        End Get
        Set(value As String)
            pClearRight = value
        End Set
    End Property
    Public Property ClrLeft As String
        Get
            ClrLeft = Format(Val(pClearLeft), "0")
        End Get
        Set(value As String)
            pClearLeft = value
        End Set
    End Property
    Public Property ClrFront As String
        Get
            ClrFront = Format(Val(pClearFront), "0")
        End Get
        Set(value As String)
            pClearFront = value
        End Set
    End Property
    Public Property ClrBack As String
        Get
            ClrBack = Format(Val(pClearBack), "0")
        End Get
        Set(value As String)
            pClearBack = value
        End Set
    End Property
    Public Property PointLoad As ArrayList
        Get
            PointLoad = pPointLoad
        End Get
        Set(value As ArrayList)
            pPointLoad = value
        End Set
    End Property
    Public Property BasePointLoad As ArrayList
        Get
            BasePointLoad = pBasePointLoad
        End Get
        Set(value As ArrayList)
            pBasePointLoad = value
        End Set
    End Property
    Public Property BasePointLoadXLoc As ArrayList
        Get
            BasePointLoadXLoc = pBasePointLoadXLoc
        End Get
        Set(value As ArrayList)
            pBasePointLoadXLoc = value
        End Set
    End Property
    Public Property BasePointLoadYLoc As ArrayList
        Get
            BasePointLoadYLoc = pBasePointLoadYLoc
        End Get
        Set(value As ArrayList)
            pBasePointLoadYLoc = value
        End Set
    End Property


    Public Property ModLoadMod As ArrayList
        Get
            ModLoadMod = pModLoadMod
        End Get
        Set(value As ArrayList)
            pModLoadMod = value
        End Set
    End Property
    Public Property ModLoadItem As ArrayList
        Get
            ModLoadItem = pModLoadItem
        End Get
        Set(value As ArrayList)
            pModLoadItem = value
        End Set
    End Property
    Public Property ModLoadMass As ArrayList
        Get
            ModLoadMass = pModLoadMass
        End Get
        Set(value As ArrayList)
            pModLoadMass = value
        End Set
    End Property
    Public Property CalcPoints As String
        Get
            CalcPoints = pCalcPoints
        End Get
        Set(value As String)
            pCalcPoints = value
        End Set
    End Property
    Public Sub New()
        pCalcPoints = 4
    End Sub
    Public Sub ImportUPGData(UnitFamily As String)
        Dim xdoc As XmlDocument = New XmlDocument
        Dim nodeid As String
        If ((UnitFamily = "Series20ODSplit") Or (UnitFamily = "Series40ODSplit")) Then
            nodeid = "Value/SystemPerformance/Outdoor"
        Else
            nodeid = "Value/SystemPerformance/"
        End If
        xdoc.Load(frmMain.txtBaseUnitFile.Text)
        Dim xnodelist As XmlNodeList = xdoc.SelectNodes("//HvacQuote/LineItems/HvacQuoteLineItem")
        Dim xnode As XmlNode
        xnode = xdoc.SelectSingleNode("//HvacQuote/Performance/Dictionary/KeyValuePair[contains(.,'" & frmMain.ThisUnit.PerformanceID & "')]")
        pLength = xnode.SelectSingleNode(nodeid & "Dimensions").SelectSingleNode("LengthIn").InnerText
        pWidth = xnode.SelectSingleNode(nodeid & "Dimensions").SelectSingleNode("WidthIn").InnerText
        pHeight = xnode.SelectSingleNode(nodeid & "Dimensions").SelectSingleNode("HeightIn").InnerText
        pBaseUnitWeight = xnode.SelectSingleNode(nodeid & "Dimensions").SelectSingleNode("WeightLbs").InnerText
        pClearRight = xnode.SelectSingleNode(nodeid & "Clearance").SelectSingleNode("Right").InnerText
        pClearTop = xnode.SelectSingleNode(nodeid & "Clearance").SelectSingleNode("Top").InnerText
        pClearFront = xnode.SelectSingleNode(nodeid & "Clearance").SelectSingleNode("Front").InnerText
        pClearBottom = xnode.SelectSingleNode(nodeid & "Clearance").SelectSingleNode("Bottom").InnerText
        pClearBack = xnode.SelectSingleNode(nodeid & "Clearance").SelectSingleNode("Back").InnerText
        pClearLeft = xnode.SelectSingleNode(nodeid & "Clearance").SelectSingleNode("Left").InnerText
    End Sub

    Public Sub ImportFSTUPGData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/PhysicalData")

        pHeight = xNodeRoot.SelectSingleNode("Height").InnerText
        pLength = xNodeRoot.SelectSingleNode("Length").InnerText
        pWidth = xNodeRoot.SelectSingleNode("Width").InnerText
        pClearRight = xNodeRoot.SelectSingleNode("Right").InnerText
        pClearLeft = xNodeRoot.SelectSingleNode("Left").InnerText
        pClearTop = xNodeRoot.SelectSingleNode("Top").InnerText
        pClearBottom = xNodeRoot.SelectSingleNode("Bottom").InnerText
        pClearFront = xNodeRoot.SelectSingleNode("Front").InnerText
        pClearBack = xNodeRoot.SelectSingleNode("Back").InnerText
        pBaseUnitWeight = xNodeRoot.SelectSingleNode("Weight").InnerText

        xDoc = Nothing

    End Sub
    Public Sub ImportFSTYPALData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/PhysicalData")

        pHeight = xNodeRoot.SelectSingleNode("Height").InnerText
        pLength = xNodeRoot.SelectSingleNode("Length").InnerText
        pWidth = xNodeRoot.SelectSingleNode("Width").InnerText

        pBaseUnitWeight = xNodeRoot.SelectSingleNode("Weight").InnerText

        pBasePointLoad.Add(xNodeRoot.SelectSingleNode("AWeight").InnerText)
        pBasePointLoad.Add(xNodeRoot.SelectSingleNode("BWeight").InnerText)
        pBasePointLoad.Add(xNodeRoot.SelectSingleNode("CWeight").InnerText)
        pBasePointLoad.Add(xNodeRoot.SelectSingleNode("DWeight").InnerText)



        xDoc = Nothing

    End Sub
    Public Sub ImportFSTYVAAData()
        Dim xDoc As XmlDocument = New XmlDocument
        Dim PointCount As Integer
        Dim i As Integer
        Dim CurrentPoint As String
        Dim temp As String

        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/PhysicalData/PointLoads")

        PointCount = xNodeRoot.SelectSingleNode("NumberofLoads").InnerText

        For i = 1 To PointCount / 2
            CurrentPoint = "R" & Trim(Str(i))
            xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/PhysicalData/PointLoads/" & CurrentPoint)

            pBasePointLoad.Add(xNodeRoot.SelectSingleNode("Weight").InnerText)
            pBasePointLoadXLoc.Add(xNodeRoot.SelectSingleNode("XDist").InnerText)
            pBasePointLoadYLoc.Add(xNodeRoot.SelectSingleNode("YDist").InnerText)

            CurrentPoint = "L" & Trim(Str(i))
            xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/PhysicalData/PointLoads/" & CurrentPoint)
            pBasePointLoad.Add(xNodeRoot.SelectSingleNode("Weight").InnerText)
            pBasePointLoadXLoc.Add(xNodeRoot.SelectSingleNode("XDist").InnerText)
            pBasePointLoadYLoc.Add(xNodeRoot.SelectSingleNode("YDist").InnerText)

        Next

        xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/PhysicalData")

        temp = xNodeRoot.SelectSingleNode("RigWeight").InnerText
        frmMain.ThisChillerMainPerf.RigWeight = temp
        pRigWeight = temp
        temp = xNodeRoot.SelectSingleNode("OpWeight").InnerText
        frmMain.ThisChillerMainPerf.OpWeight = temp
        pOpWeight = temp

        temp = xNodeRoot.SelectSingleNode("RefCharge").InnerText
        frmMain.ThisChillerMainPerf.RefrigerantCharge = temp

    End Sub
    Public Sub ImportFSTYLAAData()
        Dim xDoc As XmlDocument = New XmlDocument
        Dim PointCount As Integer
        Dim i As Integer
        Dim CurrentPoint As String

        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/PhysicalData/PointLoads")

        PointCount = xNodeRoot.SelectSingleNode("NumberofLoads").InnerText

        For i = 1 To PointCount / 2
            CurrentPoint = "R" & Trim(Str(i))
            xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/PhysicalData/PointLoads/" & CurrentPoint)

            pBasePointLoad.Add(xNodeRoot.SelectSingleNode("Weight").InnerText)
            pBasePointLoadXLoc.Add(xNodeRoot.SelectSingleNode("XDist").InnerText)
            pBasePointLoadYLoc.Add(xNodeRoot.SelectSingleNode("YDist").InnerText)

            CurrentPoint = "L" & Trim(Str(i))
            xNodeRoot = xDoc.SelectSingleNode("//BaseUnit/PhysicalData/PointLoads/" & CurrentPoint)
            pBasePointLoad.Add(xNodeRoot.SelectSingleNode("Weight").InnerText)
            pBasePointLoadXLoc.Add(xNodeRoot.SelectSingleNode("XDist").InnerText)
            pBasePointLoadYLoc.Add(xNodeRoot.SelectSingleNode("YDist").InnerText)

        Next

    End Sub
    Public Sub ImportPointLoadsYPAL()
        pBasePointLoad.Add("1001")
        pBasePointLoad.Add("1002")
        pBasePointLoad.Add("1003")
        pBasePointLoad.Add("1004")

    End Sub
    Private Sub CheckPointLoadsUPG()
        Dim ModStub As String
        Dim UserID As String
        Dim dummy As MsgBoxResult

        ModStub = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)

        Dim con As ADODB.Connection = New ADODB.Connection
        Dim rs As ADODB.Recordset = New ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String

        UserID = Environment.UserName

        'con = New ADODB.Connection
        dbProvider = "FIL= MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        'rs = New ADODB.Recordset
        rs.CursorType = ADODB.CursorTypeEnum.adOpenDynamic

        MySQL = "Select * FROM tblUPGWeights WHERE ModelStub='" & ModStub & "'"
        rs.Open(MySQL, con)
        If rs.EOF And rs.BOF Then
            'This means the record is missing

            If ((UserID = "jlevine") Or (UserID = "jmucinski") Or (UserID = "jruemenapp")) Then
                frmUpdateWeightTables.Stubb = ModStub
                frmUpdateWeightTables.ShowDialog()
                frmUpdateWeightTables.Close()

                If frmUpdateWeightTables.Cancelled Then
                    dummy = MsgBox("Unit Weight Missing from tblUPGWeights" & vbCrLf & "Program User Aborted", vbOKOnly, "FUG Database Error")
                    Stop
                End If
            Else
                dummy = MsgBox("Unit Weight Missing from tblUPGWeights" & vbCrLf & "Please have Joe, Jonathan, or Josh Add the Unit.", vbOKOnly, "FUG Database Error")
                Stop
            End If
        Else

        End If

        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
    Public Sub ImportPointLoadsUPG()
        Dim ModStub As String

        ModStub = Mid(frmMain.ThisUnit.ModelNumber, 1, 5)

        Dim con As ADODB.Connection = New ADODB.Connection
        Dim rs As ADODB.Recordset = New ADODB.Recordset
        Dim dbProvider As String

        Dim MySQL As String
        Dim Denom As String
        Dim Numer As String

        Call CheckPointLoadsUPG()

        'con = New ADODB.Connection
        dbProvider = "FIL= MS ACCESS;DSN=FUGenerator"
        con.ConnectionString = dbProvider
        con.Open()

        'rs = New ADODB.Recordset
        rs.CursorType = ADODB.CursorTypeEnum.adOpenDynamic

        MySQL = "Select * FROM tblUPGWeights WHERE ModelStub='" & ModStub & "'"
        rs.Open(MySQL, con)

        Denom = rs.Fields("BaseWeight").Value
        If IsNumeric(pBaseUnitWeight) Then
            For i = 0 To 3
                Numer = rs.Fields(Chr(65 + i) & "Weight").Value
                pBasePointLoad.Add(Format(Val(Numer / Denom * pBaseUnitWeight), "0"))
            Next
        Else
            For i = 0 To 3
                pBasePointLoad.Add("-1")
            Next
        End If


        con.Close()
        rs = Nothing
        con = Nothing

    End Sub
End Class



