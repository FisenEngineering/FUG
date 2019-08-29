Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Public Class frmSelectBaseUnitSelection
    Private pCancelled As Boolean
    Private pImportFile As String
    Private pTag As String
    Public Property uTag As String
        Get
            uTag = pTag
        End Get
        Set(value As String)
            pTag = value
        End Set
    End Property
    Public Property Cancelled As Boolean
        Get
            Cancelled = pCancelled
        End Get
        Set(value As Boolean)
            pCancelled = value
        End Set
    End Property
    Public Property ImportFile As String
        Get
            ImportFile = pImportFile
        End Get
        Set(value As String)
            pImportFile = value
        End Set
    End Property
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        pImportFile = txtSourceFilePath.Text
        pTag = lstUnitTags.Text
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        pCancelled = True
        Me.Hide()
    End Sub

    Private Sub btnChooseFile_Click(sender As Object, e As EventArgs) Handles btnChooseFile.Click
        Dim lineitem As Integer


        If frmMain.txtProjectDirectory.Text <> "" Then
            OpenFileDialog1.InitialDirectory = frmMain.txtProjectDirectory.Text
        Else
            OpenFileDialog1.InitialDirectory = "J:\2900-2949\2988F - Sample Project\Sales Info"

        End If

        If ((frmMain.ThisUnit.Kingdom = "RTU") And (frmMain.ThisUnit.Family <> "Series100")) Then
            OpenFileDialog1.Filter = "UST Files (*.ust)|*.ust|XML files (*.xml)|*.xml|All files (*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1
        End If
        If frmMain.ThisUnit.Family = "Series100" Then
            OpenFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1

        End If
        If frmMain.ThisUnit.Kingdom = "Chiller" Then
            OpenFileDialog1.Filter = "Chiller Files (*.Chiller)|*.chiller|XML files (*.xml)|*.xml|All files (*.*)|*.*"
            OpenFileDialog1.FilterIndex = 2
        End If
        If ((frmMain.ThisUnit.Kingdom = "Misc") And (frmMain.ThisUnit.Family = "Series20ODSplit")) Then
            OpenFileDialog1.Filter = "UST Files (*.ust)|*.ust|XML files (*.xml)|*.xml|All files (*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1
        End If
        If ((frmMain.ThisUnit.Kingdom = "Misc") And (frmMain.ThisUnit.Family = "Series40ODSplit")) Then
            OpenFileDialog1.Filter = "UST Files (*.ust)|*.ust|XML files (*.xml)|*.xml|All files (*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1
        End If

        OpenFileDialog1.ShowDialog()
        txtSourceFilePath.Text = OpenFileDialog1.FileName

        If ((frmMain.ThisUnit.Kingdom = "Misc") And (frmMain.ThisUnit.Family = "Series20ODSplit")) Then
            Dim xdoc As XmlDocument = New XmlDocument
            xdoc.Load(txtSourceFilePath.Text)
            Dim xnodelist As XmlNodeList = xdoc.SelectNodes("//HvacQuote/LineItems/HvacQuoteLineItem")
            Dim xnode As XmlNode

            lineitem = 1
            For Each xnode In xnodelist
                If Not (xnode.SelectSingleNode("Component").Attributes.GetNamedItem("xsi:type") Is Nothing) Then
                    If xnode.SelectSingleNode("Component").Attributes.GetNamedItem("xsi:type").Value = "HvacVcUnit" Then

                        If Not (xnode.SelectSingleNode("Component").SelectSingleNode("Tag") Is Nothing) Then
                            lstUnitTags.Items.Add(xnode.SelectSingleNode("Component").SelectSingleNode("Tag").InnerText)
                        Else
                            xdoc.Save(txtSourceFilePath.Text & "old")
                            lstUnitTags.Items.Add("Untagged-" & lineitem)
                            Dim elem As XmlElement = xdoc.CreateElement("Tag")
                            elem.InnerText = "Untagged-" & lineitem
                            xnode.SelectSingleNode("Component").AppendChild(elem)
                            elem = Nothing

                        End If
                    End If
                End If
                lineitem = lineitem + 1
            Next
            xdoc.Save(txtSourceFilePath.Text)
            xdoc = Nothing
            lstUnitTags.SelectedIndex = 0
        End If

        If ((frmMain.ThisUnit.Kingdom = "Misc") And (frmMain.ThisUnit.Family = "Series40ODSplit")) Then
            Dim xdoc As XmlDocument = New XmlDocument
            xdoc.Load(txtSourceFilePath.Text)
            Dim xnodelist As XmlNodeList = xdoc.SelectNodes("//HvacQuote/LineItems/HvacQuoteLineItem")
            Dim xnode As XmlNode

            lineitem = 1
            For Each xnode In xnodelist
                If Not (xnode.SelectSingleNode("Component").Attributes.GetNamedItem("xsi:type") Is Nothing) Then
                    If xnode.SelectSingleNode("Component").Attributes.GetNamedItem("xsi:type").Value = "HvacVcUnit" Then

                        If Not (xnode.SelectSingleNode("Component").SelectSingleNode("Tag") Is Nothing) Then
                            lstUnitTags.Items.Add(xnode.SelectSingleNode("Component").SelectSingleNode("Tag").InnerText)
                        Else
                            xdoc.Save(txtSourceFilePath.Text & "old")
                            lstUnitTags.Items.Add("Untagged-" & lineitem)
                            Dim elem As XmlElement = xdoc.CreateElement("Tag")
                            elem.InnerText = "Untagged-" & lineitem
                            xnode.SelectSingleNode("Component").AppendChild(elem)
                            elem = Nothing

                        End If
                    End If
                End If
                lineitem = lineitem + 1
            Next
            xdoc.Save(txtSourceFilePath.Text)
            xdoc = Nothing
            lstUnitTags.SelectedIndex = 0
        End If


        If ((frmMain.ThisUnit.Kingdom = "RTU") And (frmMain.ThisUnit.Family <> "Series100")) Then
            Dim xdoc As XmlDocument = New XmlDocument
            xdoc.Load(txtSourceFilePath.Text)
            Dim xnodelist As XmlNodeList = xdoc.SelectNodes("//HvacQuote/LineItems/HvacQuoteLineItem")
            Dim xnode As XmlNode

            lineitem = 1
            For Each xnode In xnodelist
                If Not (xnode.SelectSingleNode("Component").Attributes.GetNamedItem("xsi:type") Is Nothing) Then
                    If xnode.SelectSingleNode("Component").Attributes.GetNamedItem("xsi:type").Value = "HvacVcUnit" Then

                        If Not (xnode.SelectSingleNode("Component").SelectSingleNode("Tag") Is Nothing) Then
                            lstUnitTags.Items.Add(xnode.SelectSingleNode("Component").SelectSingleNode("Tag").InnerText)
                        Else
                            xdoc.Save(txtSourceFilePath.Text & "old")
                            lstUnitTags.Items.Add("Untagged-" & lineitem)
                            Dim elem As XmlElement = xdoc.CreateElement("Tag")
                            elem.InnerText = "Untagged-" & lineitem
                            xnode.SelectSingleNode("Component").AppendChild(elem)
                            elem = Nothing

                        End If
                    End If
                End If
                lineitem = lineitem + 1
            Next
            xdoc.Save(txtSourceFilePath.Text)
            xdoc = Nothing
            lstUnitTags.SelectedIndex = 0

        Else
            'lstUnitTags.Visible = False
            'Label2.Visible = False
        End If

    End Sub


End Class
