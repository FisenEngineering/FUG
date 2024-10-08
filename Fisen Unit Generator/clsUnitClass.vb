﻿Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Imports System.Runtime.ConstrainedExecution

Public Class clsUnitClass
    Private pBrand As String
    Private pUnitKingdom As String
    Private pUnitFamily As String
    Private pBrandFamily As String
    Private pJobNumber As String
    Private pProjectName As String
    Private pUnitTag As String
    Private pUnitNumber As String
    Private pQty As String
    Private pVersion As String
    Private pNomTons As String
    Private pBrandModNum As String
    Private pModNum As String
    Private pUnitDate As String
    Private pPrintDate As String
    Private pPerformanceID As String
    Private pDescription
    Private pCommNodes As String
    Private pGenCodes As Boolean
    Private pBaseDwgOK As Boolean
    Private pResourcePath As String
    Private pUPGCertifications As ArrayList = New ArrayList
    Private pCabinet As String
    Private pNotes As String
    Private pCertASHRAE901 As Boolean
    Private pCertISO9001 As Boolean
    Private pCertAHRI As Boolean
    Private pCertCSADesign As Boolean
    Private pCertETL As Boolean
    Private pCertEStar As Boolean
    Private pCertAmQ As Boolean
    Private pCertCSACanUS As Boolean
    Private pCertETLCanUS As Boolean
    Private pCertCSAGas As Boolean

    Public Property CertASHRAE901 As Boolean
        Get
            Return pCertASHRAE901
        End Get
        Set(value As Boolean)
            pCertASHRAE901 = value
        End Set
    End Property
    Public Property CertISO9001 As Boolean
        Get
            Return pCertISO9001
        End Get
        Set(value As Boolean)
            pCertISO9001 = value
        End Set
    End Property
    Public Property CertAHRI As Boolean
        Get
            Return pCertAHRI
        End Get
        Set(value As Boolean)
            pCertAHRI = value
        End Set
    End Property
    Public Property CertCSADesign As Boolean
        Get
            Return pCertCSADesign
        End Get
        Set(value As Boolean)
            pCertCSADesign = value
        End Set
    End Property
    Public Property CertETL As Boolean
        Get
            Return pCertETL
        End Get
        Set(value As Boolean)
            pCertETL = value
        End Set
    End Property
    Public Property CertEStar As Boolean
        Get
            Return pCertEStar
        End Get
        Set(value As Boolean)
            pCertEStar = value
        End Set
    End Property
    Public Property CertAmQ As Boolean
        Get
            Return pCertAmQ
        End Get
        Set(value As Boolean)
            pCertAmQ = value
        End Set
    End Property
    Public Property CertCSACanUS As Boolean
        Get
            Return pCertCSACanUS
        End Get
        Set(value As Boolean)
            pCertCSACanUS = value
        End Set
    End Property
    Public Property CertETLCanUS As Boolean
        Get
            Return pCertETLCanUS
        End Get
        Set(value As Boolean)
            pCertETLCanUS = value
        End Set
    End Property
    Public Property CertCSAGas As Boolean
        Get
            Return pCertCSAGas
        End Get
        Set(value As Boolean)
            pCertCSAGas = value
        End Set
    End Property
    Public Property Notes As String
        Get
            Return pNotes
        End Get
        Set(value As String)
            If value = "" Then
                pNotes = "-"
            Else
                If pNotes = "-" Then
                    pNotes = value
                Else

                    pNotes = pNotes & vbCrLf & value
                End If
            End If
        End Set
    End Property

    Public Property Cabinet As String
        Get
            Return pCabinet
        End Get
        Set(value As String)
            pCabinet = value
        End Set
    End Property


    Public Property UPGCertifications As ArrayList
        Get
            Return pUPGCertifications
        End Get
        Set(value As ArrayList)
            pUPGCertifications = value
        End Set
    End Property

    Public Property JobNumber As String
        Get
            JobNumber = pJobNumber
        End Get
        Set(value As String)
            pJobNumber = value
        End Set
    End Property
    Public Property ProjectName As String
        Get
            ProjectName = pProjectName
        End Get
        Set(value As String)
            pProjectName = value
        End Set
    End Property
    Public Property uTag As String
        Get
            uTag = pUnitTag
        End Get
        Set(value As String)
            pUnitTag = value
        End Set
    End Property
    Public Property UnitNumber As String
        Get
            UnitNumber = pUnitNumber
        End Get
        Set(value As String)
            pUnitNumber = value
        End Set
    End Property
    Public Property Quantity As String
        Get
            Quantity = Format(Val(pQty), "0")
        End Get
        Set(value As String)
            pQty = value
        End Set
    End Property
    Public Property Version As String
        Get
            Version = pVersion
        End Get
        Set(value As String)
            pVersion = value
        End Set
    End Property
    Public Property NominalTons As String
        Get
            NominalTons = Trim(Format(Val(pNomTons), "0.0"))
        End Get
        Set(value As String)
            pNomTons = value
        End Set
    End Property
    Public Property BrandModelNumber As String
        Get
            BrandModelNumber = pBrandModNum
        End Get
        Set(value As String)
            pBrandModNum = value
        End Set
    End Property
    Public Property ModelNumber As String
        Get
            ModelNumber = pModNum
        End Get
        Set(value As String)
            pModNum = value
        End Set
    End Property
    Public Property UnitDate As String
        Get
            UnitDate = pUnitDate
        End Get
        Set(value As String)
            pUnitDate = value
        End Set
    End Property
    Public Property PrintDate As String
        Get
            PrintDate = pPrintDate
        End Get
        Set(value As String)
            pPrintDate = value
        End Set
    End Property
    Public Property Brand As String
        Get
            Brand = pBrand
        End Get
        Set(value As String)
            pBrand = value
        End Set
    End Property
    Public Property Kingdom() As String
        'RTU, AHU, Chiller, etc...
        Get
            Return pUnitKingdom
        End Get
        Set(value As String)
            pUnitKingdom = value
        End Set
    End Property
    Public Property Family() As String
        'Always JCI Words
        Get
            Return pUnitFamily
        End Get
        Set(value As String)
            pUnitFamily = value
        End Set
    End Property
    Public ReadOnly Property FamilyBrand() As String
        'Series 10, Predator, YCAL, etc...
        Get
            If pBrand = "JCI" Then
                Select Case pUnitFamily
                    Case Is = "DS"
                        pBrandFamily = "DSV/DSH"
                    Case Is = "Series20ODSplit"
                        pBrandFamily = "Series 20 OD Split System"
                    Case Is = "Series40ODSplit"
                        pBrandFamily = "Series 40 OD Split System"
                    Case Is = "YCUL"
                        pBrandFamily = "Air Cooled Scroll CU"
                    Case Is = "YCAV"
                        pBrandFamily = "YCAV"
                    Case Is = "YLAA"
                        pBrandFamily = "YLAA"
                    Case Is = "Blank"
                        pBrandFamily = InputBox("Please enter the plain text name of the unit family:", frmMain.gProgName, "Blank")
                    Case Else
                        Select Case pUnitFamily
                            Case Is = "Series5"
                                pBrandFamily = "Series 5"
                            Case Is = "Series10"
                                pBrandFamily = "Series 10"
                            Case Is = "Series12"
                                pBrandFamily = "Series 12R"
                            Case Is = "Series20"
                                pBrandFamily = "Series 20"
                            Case Is = "Series40"
                                pBrandFamily = "Series 40"
                            Case Is = "Series100"
                                pBrandFamily = "Series 100"
                            Case Is = "Choice"
                                pBrandFamily = "Choice"
                            Case Is = "Select"
                                pBrandFamily = "Select"
                            Case Is = "Premier"
                                pBrandFamily = "Premier"
                        End Select
                End Select
            End If
            If pBrand = "FRJ" Then
                Select Case pUnitFamily
                    Case Is = "Series10"
                        pBrandFamily = "ReliaCore 300"
                    Case Is = "Blank"
                        pBrandFamily = InputBox("Please enter the plain text name of the unit family:", frmMain.gProgName, "Blank")
                End Select
            End If
            If pBrand = "York" Then
                Select Case pUnitFamily
                    Case Is = "Series5"
                        pBrandFamily = "Sunline"
                    Case Is = "Series10"
                        pBrandFamily = "Predator"
                    Case Is = "Series12"
                        pBrandFamily = "Sun Core"
                    Case Is = "Series20"
                        pBrandFamily = "Sunline Magnum"
                    Case Is = "Series40"
                        pBrandFamily = "Millennium"
                    Case Is = "Series100"
                        pBrandFamily = "YPAL"
                    Case Is = "Choice"
                        pBrandFamily = "Sun Choice"
                    Case Is = "Select"
                        pBrandFamily = "Sun Select"
                    Case Is = "YLAA"
                        pBrandFamily = "YLAA"
                    Case Is = "YCAV"
                        pBrandFamily = "YCAV"
                    Case Is = "YLAA"
                        pBrandFamily = "YLAA"
                    Case Is = "YVAA"
                        pBrandFamily = "YVAA"
                    Case Is = "Blank"
                        pBrandFamily = InputBox("Please enter the plain text name of the unit family:", frmMain.gProgName, "Blank")
                End Select
            End If
            If pBrand = "TMP" Then
                Select Case pUnitFamily
                    Case Is = "Series5"
                        pBrandFamily = "OmniCore 100"
                    Case Is = "Series10"
                        pBrandFamily = "OmniPro"
                    Case Is = "Series12"
                        pBrandFamily = "OmniCore 200"
                    Case Is = "Series20"
                        pBrandFamily = "OmniPlus 100"
                    Case Is = "Series40"
                        pBrandFamily = "OmniMax"
                    Case Is = "Series100"
                        pBrandFamily = "OmniElite"
                    Case Is = "YLAA"
                        pBrandFamily = "YLAA"
                    Case Is = "Blank"
                        pBrandFamily = InputBox("Please enter the plain text name of the unit family:", frmMain.gProgName, "Blank")
                End Select
            End If

            If pBrand = "LUX" Then
                Select Case pUnitFamily
                    Case Is = "Series5"
                        pBrandFamily = "Optimum Series"
                    Case Is = "Series10"
                        pBrandFamily = "Ovation Series"
                    Case Is = "Series12"
                        pBrandFamily = "Eclipse Series"
                    Case Is = "Choice"
                        pBrandFamily = "Optimum Choice"
                    Case Is = "Blank"
                        pBrandFamily = InputBox("Please enter the plain text name of the unit family:", frmMain.gProgName, "Blank")
                    Case Else
                        pBrandFamily = "???????????"
                End Select
            End If

            Return pBrandFamily
        End Get
    End Property
    Public ReadOnly Property PerformanceID As String
        Get
            PerformanceID = pPerformanceID
        End Get
    End Property
    Public ReadOnly Property Desc
        Get
            Desc = pDescription
        End Get
    End Property
    Public ReadOnly Property ResourcePath As String
        Get
            ResourcePath = pResourcePath
        End Get
    End Property
    Public Property BaseDrawingOK As Boolean
        Get
            BaseDrawingOK = pBaseDwgOK
        End Get
        Set(value As Boolean)
            pBaseDwgOK = value
        End Set
    End Property
    Public Property CommNodes As String
        Get
            CommNodes = pCommNodes
        End Get
        Set(value As String)
            pCommNodes = value
        End Set
    End Property
    Public Property GenCodesPresent
        Get
            GenCodesPresent = pGenCodes
        End Get
        Set(value)
            pGenCodes = value
        End Set
    End Property
    Public Sub ImportUPGData()
        Dim xdoc As XmlDocument = New XmlDocument

        xdoc.Load(frmMain.txtBaseUnitFile.Text)
        Dim xnodelist As XmlNodeList = xdoc.SelectNodes("//HvacQuote/LineItems/HvacQuoteLineItem")
        Dim xnode As XmlNode
        xnode = xdoc.SelectSingleNode("//HvacQuote/LineItems/HvacQuoteLineItem/Component[contains(.,'" & pUnitTag & "')]")
        pBrandModNum = xnode.SelectSingleNode("ModelNumber").InnerText
        pDescription = xnode.SelectSingleNode("Description").InnerText
        pBrand = xnode.SelectSingleNode("Brand").InnerText
        If pBrand = "YOR" Then pBrand = "YORK"
        pQty = xnode.SelectSingleNode("Quantity").InnerText
        xnode = xdoc.SelectSingleNode("//HvacQuote/LineItems/HvacQuoteLineItem/Component[contains(.,'" & pUnitTag & "')]")
        pPerformanceID = xnode.SelectSingleNode("PerformanceId").InnerText
        pProjectName = xdoc.SelectSingleNode("//HvacQuote/Name").InnerText


        xdoc = Nothing
    End Sub
    Public Sub ImportFSTCerts()
        Dim xdoc As XmlDocument = New XmlDocument
        Dim TempCert As String

        xdoc.Load(frmMain.txtBaseUnitFile.Text)
        Dim xnode As XmlNode
        xnode = xdoc.SelectSingleNode("//BaseUnit/Certifications")
        If xnode.ChildNodes.Count > 0 Then
            For i = 0 To xnode.ChildNodes.Count - 1
                TempCert = xnode.ChildNodes.Item(i).InnerText
                Select Case TempCert
                    Case Is = "ASHRAE 90.1"
                        pCertASHRAE901 = True
                    Case Is = "ISO 9001"
                        pCertISO9001 = True
                    Case Is = "CSA Design"
                        pCertCSADesign = True
                    Case Is = "AHRI"
                        pCertAHRI = True
                    Case Is = "CSA Canada"
                        pCertCSACanUS = True
                    Case Is = "ETL Canada"
                        pCertETLCanUS = True
                    Case Is = "CSA Gas"
                        pCertCSAGas = True
                    Case Is = "ETL"
                        pCertETL = True
                    Case Is = "American Quality"
                        pCertAmQ = True
                    Case Is = "Energy Star"
                        pCertEStar = True
                End Select
            Next
        End If
    End Sub
    Public Sub ImportFSTYPALData()
        Dim xDoc As XmlDocument = New XmlDocument
        xDoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xNodeRoot As XmlNode = xDoc.SelectSingleNode("//BaseUnit/CoolingData")

        pNomTons = xNodeRoot.SelectSingleNode("NominalTons").InnerText

        xDoc = Nothing

    End Sub

    Public Sub ImportYPALData()
        Dim xdoc As XmlDocument = New XmlDocument

        xdoc.Load(frmMain.txtBaseUnitFile.Text)


        Dim xnode As XmlNode
        'xnode = xdoc.SelectSingleNode("TaggedPDF-doc/Document/Table/TBody/TR")
        xnode = xdoc.SelectSingleNode("//TaggedPDF-doc/Sect/Table/TR")
        'xnode = xdoc.SelectSingleNode("//TaggedPDF-doc/Table/TR")

        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD/P")
        'This is the unit tag
        pUnitTag = xnode.InnerText

        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        'this is the quantity
        pQty = xnode.InnerText

        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        'this is the model number
        pBrandModNum = xnode.InnerText

        xnode = xdoc.SelectSingleNode("//TaggedPDF-doc/Sect/Table")

        xnode = xnode.NextSibling
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TR/TD")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        pNomTons = Format(Val(Mid(xnode.InnerText, 1, 3)), "0.0")

        xdoc = Nothing
    End Sub

    Public Sub ImportYLAAData()
        Dim xdoc As XmlDocument = New XmlDocument

        xdoc.Load(frmMain.txtBaseUnitFile.Text)


        Dim xnode As XmlNode
        'Start with the Yorkworks PDF.  Export to XML Last tested on 3152F on 12 March 2018
        'xnode = xdoc.SelectSingleNode("TaggedPDF-doc/Document/Table/TBody/TR")
        xnode = xdoc.SelectSingleNode("TaggedPDF-doc/Table/TR")

        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD/P")
        'This is the unit tag
        pUnitTag = xnode.InnerText

        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        'this is the quantity
        pQty = xnode.InnerText

        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        'this is the model number
        pBrandModNum = xnode.InnerText

        xdoc = Nothing
    End Sub
    Public Sub ImportYCULData()
        Dim xdoc As XmlDocument = New XmlDocument

        xdoc.Load(frmMain.txtBaseUnitFile.Text)

        Dim xnode As XmlNode
        'xnode = xdoc.SelectSingleNode("TaggedPDF-doc/Document/Table/TBody/TR")
        xnode = xdoc.SelectSingleNode("TaggedPDF-doc/Table/TR")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        'This is the unit tag
        pUnitTag = Trim(xnode.InnerText)

        xnode = xnode.NextSibling
        'this is the quantity
        pQty = Trim(xnode.InnerText)

        xnode = xnode.NextSibling
        'this is the model number
        pBrandModNum = Trim(xnode.InnerText)

        xdoc = Nothing
    End Sub
    Public Sub ImportYVAAData()
        Dim xdoc As XmlDocument = New XmlDocument

        xdoc.Load(frmMain.txtBaseUnitFile.Text)
        Dim xnode As XmlNode
        xnode = xdoc.SelectSingleNode("TaggedPDF-doc/Part/Table/TR")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD/P")
        'This is the unit tag
        pUnitTag = xnode.InnerText

        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        'this is the quantity
        pQty = xnode.InnerText

        xnode = xnode.ParentNode
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("P")
        'this is the model number
        pBrandModNum = xnode.InnerText

        xdoc = Nothing
    End Sub
    Public Sub ImportYCAVData()
        Dim xdoc As XmlDocument = New XmlDocument

        'xdoc.Load(frmMain.txtBaseUnitFile.Text)
        xdoc.Load(frmMain.txtBaseUnitFile.Text)
        Dim xnode As XmlNode

        xnode = xdoc.SelectSingleNode("TaggedPDF-doc/Table/TR")
        xnode = xnode.NextSibling
        xnode = xnode.SelectSingleNode("TD")
        'This is the unit tag
        pUnitTag = xnode.InnerText

        xnode = xnode.NextSibling
        'this is the quantity
        pQty = xnode.InnerText

        xnode = xnode.NextSibling
        'this is the model number
        pBrandModNum = xnode.InnerText

        xdoc = Nothing
    End Sub
    Public Sub New()
        pCommNodes = "1"
        pGenCodes = False
        pBaseDwgOK = True
        pResourcePath = My.Settings.ResourceDir
        pCabinet = "Not Applicable"
        pNotes = "-"

    End Sub



End Class
