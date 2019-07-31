Imports System.Drawing.Printing
Imports System.Drawing
Imports IDAutomation.Windows.Forms.LinearBarCode
Public Class frmIDAutomation
    Inherits System.Windows.Forms.Form
    'This line was added to allow printing as a DLL
    Dim NewBarcode As IDAutomation.Windows.Forms.LinearBarCode.Barcode = New Barcode()

#Region " Windows Form Designer generated code "

	Public Sub New()
		MyBase.New()

		'This call is required by the Windows Form Designer.
		InitializeComponent()

		'Add any initialization after the InitializeComponent() call

	End Sub

	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If Not (components Is Nothing) Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	Friend WithEvents txtDataToEncode As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents cboSymbology As System.Windows.Forms.ComboBox
	Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents cmdPrint As System.Windows.Forms.Button
	Friend WithEvents chkUseCheckDigit As System.Windows.Forms.CheckBox
	Friend WithEvents chkShowText As System.Windows.Forms.CheckBox
	Friend WithEvents chkShowCheckDigit As System.Windows.Forms.CheckBox
	Friend WithEvents cmdDisplayMetafile As System.Windows.Forms.Button
    Friend WithEvents Barcode1 As IDAutomation.Windows.Forms.LinearBarCode.Barcode
    Friend WithEvents IndEMF As System.Windows.Forms.CheckBox
    Friend WithEvents cmdPrintAsDLL As System.Windows.Forms.Button
    Friend WithEvents ApplyDTE As System.Windows.Forms.Button
    Friend WithEvents SaveJPEG As System.Windows.Forms.Button
    Friend WithEvents SaveTIFF300 As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtDataToEncode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSymbology = New System.Windows.Forms.ComboBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.chkUseCheckDigit = New System.Windows.Forms.CheckBox()
        Me.chkShowText = New System.Windows.Forms.CheckBox()
        Me.chkShowCheckDigit = New System.Windows.Forms.CheckBox()
        Me.cmdDisplayMetafile = New System.Windows.Forms.Button()
        Me.Barcode1 = New IDAutomation.Windows.Forms.LinearBarCode.Barcode()
        Me.IndEMF = New System.Windows.Forms.CheckBox()
        Me.cmdPrintAsDLL = New System.Windows.Forms.Button()
        Me.ApplyDTE = New System.Windows.Forms.Button()
        Me.SaveJPEG = New System.Windows.Forms.Button()
        Me.SaveTIFF300 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDataToEncode
        '
        Me.txtDataToEncode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataToEncode.Location = New System.Drawing.Point(8, 168)
        Me.txtDataToEncode.Name = "txtDataToEncode"
        Me.txtDataToEncode.Size = New System.Drawing.Size(280, 22)
        Me.txtDataToEncode.TabIndex = 1
        Me.txtDataToEncode.Text = ""
        Me.txtDataToEncode.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data To Encode:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Symbology"
        '
        'cboSymbology
        '
        Me.cboSymbology.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSymbology.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSymbology.Location = New System.Drawing.Point(9, 212)
        Me.cboSymbology.Name = "cboSymbology"
        Me.cboSymbology.Size = New System.Drawing.Size(279, 24)
        Me.cboSymbology.Sorted = True
        Me.cboSymbology.TabIndex = 4
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(312, 336)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(128, 22)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "Exit"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(312, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(408, 152)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Enhanced Metafile Image"
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(312, 304)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(128, 22)
        Me.cmdPrint.TabIndex = 12
        Me.cmdPrint.Text = "Print Barcode"
        '
        'chkUseCheckDigit
        '
        Me.chkUseCheckDigit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseCheckDigit.Location = New System.Drawing.Point(8, 248)
        Me.chkUseCheckDigit.Name = "chkUseCheckDigit"
        Me.chkUseCheckDigit.Size = New System.Drawing.Size(204, 16)
        Me.chkUseCheckDigit.TabIndex = 14
        Me.chkUseCheckDigit.Text = "Use Check Digit"
        '
        'chkShowText
        '
        Me.chkShowText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowText.Location = New System.Drawing.Point(8, 272)
        Me.chkShowText.Name = "chkShowText"
        Me.chkShowText.Size = New System.Drawing.Size(204, 16)
        Me.chkShowText.TabIndex = 15
        Me.chkShowText.Text = "Show Human Readable Text"
        '
        'chkShowCheckDigit
        '
        Me.chkShowCheckDigit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowCheckDigit.Location = New System.Drawing.Point(8, 296)
        Me.chkShowCheckDigit.Name = "chkShowCheckDigit"
        Me.chkShowCheckDigit.Size = New System.Drawing.Size(204, 16)
        Me.chkShowCheckDigit.TabIndex = 16
        Me.chkShowCheckDigit.Text = "Show Check Digit In Text"
        '
        'cmdDisplayMetafile
        '
        Me.cmdDisplayMetafile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisplayMetafile.Location = New System.Drawing.Point(456, 304)
        Me.cmdDisplayMetafile.Name = "cmdDisplayMetafile"
        Me.cmdDisplayMetafile.Size = New System.Drawing.Size(128, 22)
        Me.cmdDisplayMetafile.TabIndex = 5
        Me.cmdDisplayMetafile.Text = "Display Metafile"
        '
        'Barcode1
        '
        Me.Barcode1.ApplyTilde = True
        Me.Barcode1.BackColor = System.Drawing.Color.White
        Me.Barcode1.BarHeightCM = "1.000"
        Me.Barcode1.CheckCharacter = True
        Me.Barcode1.CheckCharacterInText = False
        Me.Barcode1.CODABARStartChar = "A"
        Me.Barcode1.CODABARStopChar = "B"
        Me.Barcode1.Code128Set = Code128CharacterSets.Auto
        Me.Barcode1.DataToEncode = "1234567890"
        Me.Barcode1.FitControlToBarcode = True
        Me.Barcode1.LeftMarginCM = "0.200"
        Me.Barcode1.Location = New System.Drawing.Point(24, 8)
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.NarrowToWideRatio = "2.0"
        Me.Barcode1.PostnetHeightShort = "0.1270"
        Me.Barcode1.PostnetHeightTall = "0.3226"
        Me.Barcode1.PostnetSpacing = "0.066"
        Me.Barcode1.Resolution = Resolutions.Printer
        Me.Barcode1.ResolutionCustomDPI = "203.00"
        Me.Barcode1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Barcode1.RotationAngle = RotationAngles.Zero_Degrees
        Me.Barcode1.ShowText = True
        Me.Barcode1.ShowTextLocation = HRTextPositions.Bottom
        Me.Barcode1.Size = New System.Drawing.Size(104, 66)
        Me.Barcode1.SuppSeparationCM = "0.350"
        Me.Barcode1.SymbologyID = Symbologies.Code128
        Me.Barcode1.TabIndex = 20
        Me.Barcode1.TextFontColor = System.Drawing.Color.Black
        Me.Barcode1.TextMarginCM = "0.100"
        Me.Barcode1.TopMarginCM = "0.200"
        Me.Barcode1.UPCESystem = "1"
        Me.Barcode1.XDimensionCM = "0.0260"
        Me.Barcode1.XDimensionMILS = "10.2362"
        '
        'IndEMF
        '
        Me.IndEMF.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndEMF.Location = New System.Drawing.Point(8, 320)
        Me.IndEMF.Name = "IndEMF"
        Me.IndEMF.Size = New System.Drawing.Size(248, 16)
        Me.IndEMF.TabIndex = 21
        Me.IndEMF.Text = "Use Device Independent EMF"
        '
        'cmdPrintAsDLL
        '
        Me.cmdPrintAsDLL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintAsDLL.Location = New System.Drawing.Point(456, 336)
        Me.cmdPrintAsDLL.Name = "cmdPrintAsDLL"
        Me.cmdPrintAsDLL.Size = New System.Drawing.Size(128, 22)
        Me.cmdPrintAsDLL.TabIndex = 22
        Me.cmdPrintAsDLL.Text = "Print as DLL"
        '
        'ApplyDTE
        '
        Me.ApplyDTE.Location = New System.Drawing.Point(120, 136)
        Me.ApplyDTE.Name = "ApplyDTE"
        Me.ApplyDTE.Size = New System.Drawing.Size(168, 24)
        Me.ApplyDTE.TabIndex = 23
        Me.ApplyDTE.Text = "Apply Data To Encode"
        '
        'SaveJPEG
        '
        Me.SaveJPEG.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveJPEG.Location = New System.Drawing.Point(600, 304)
        Me.SaveJPEG.Name = "SaveJPEG"
        Me.SaveJPEG.Size = New System.Drawing.Size(120, 22)
        Me.SaveJPEG.TabIndex = 24
        Me.SaveJPEG.Text = "Save as JPEG"
        '
        'SaveTIFF300
        '
        Me.SaveTIFF300.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveTIFF300.Location = New System.Drawing.Point(600, 336)
        Me.SaveTIFF300.Name = "SaveTIFF300"
        Me.SaveTIFF300.Size = New System.Drawing.Size(120, 22)
        Me.SaveTIFF300.TabIndex = 25
        Me.SaveTIFF300.Text = "Save as TIFF"
        '
        'frmIDAutomation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.ClientSize = New System.Drawing.Size(749, 363)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.SaveTIFF300, Me.SaveJPEG, Me.ApplyDTE, Me.cmdPrintAsDLL, Me.IndEMF, Me.Barcode1, Me.Label1, Me.Label2, Me.Label4, Me.cboSymbology, Me.txtDataToEncode, Me.cmdExit, Me.PictureBox1, Me.cmdPrint, Me.chkUseCheckDigit, Me.chkShowText, Me.chkShowCheckDigit, Me.cmdDisplayMetafile})
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmIDAutomation"
        Me.Text = "IDAutomation Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		'Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Barcode1, Me.Label3, Me.Label1, Me.Label2, Me.cboCode128Set, Me.cmdExit, Me.cboSymbology, Me.txtDataToEncode, Me.cmdExit, Me.PictureBox1, Me.Label4, Me.cmdPrint, Me.chkUseCheckDigit, Me.chkShowText, Me.chkShowCheckDigit, Me.cmdDisplayMetafile, Me.Label5, Me.cboRotation})
		cboSymbology.Items.Add("CODE11")
		cboSymbology.Items.Add("CODE39")
		cboSymbology.Items.Add("CODE39EXT")
		cboSymbology.Items.Add("INTERLEAVED25")
		cboSymbology.Items.Add("CODABAR")
		cboSymbology.Items.Add("MSI")
		cboSymbology.Items.Add("UPCA")
		cboSymbology.Items.Add("IND25")
		cboSymbology.Items.Add("MAT25")
		cboSymbology.Items.Add("EAN13")
		cboSymbology.Items.Add("EAN8")
		cboSymbology.Items.Add("UPCE")
		cboSymbology.Items.Add("CODE128")
		cboSymbology.Items.Add("CODE93")
		cboSymbology.Items.Add("CODE93EXT")
		cboSymbology.Items.Add("POSTNET")
		cboSymbology.Items.Add("PLANET")
        SetSymbologyBoxEntry()
        txtDataToEncode.Text = "123456789012"
        chkUseCheckDigit.Checked = True
        chkShowText.Checked = True
        chkShowCheckDigit.Checked = True
	End Sub

	Private Sub SetSymbologyBoxEntry()
		Dim SymbID As String

        If Barcode1.SymbologyID = Symbologies.Codabar Then
            SymbID = "CODABAR"
        ElseIf Barcode1.SymbologyID = Symbologies.Code11 Then
            SymbID = "CODE11"
        ElseIf Barcode1.SymbologyID = Symbologies.Code128 Then
            SymbID = "CODE128"
        ElseIf Barcode1.SymbologyID = Symbologies.Code39 Then
            SymbID = "CODE39"
        ElseIf Barcode1.SymbologyID = Symbologies.Code39Ext Then
            SymbID = "CODE39EXT"
        ElseIf Barcode1.SymbologyID = Symbologies.Code93 Then
            SymbID = "CODE93"
        ElseIf Barcode1.SymbologyID = Symbologies.Code93Ext Then
            SymbID = "CODE93EXT"
        ElseIf Barcode1.SymbologyID = Symbologies.Ean13 Then
            SymbID = "EAN13"
        ElseIf Barcode1.SymbologyID = Symbologies.Ean8 Then
            SymbID = "EAN8"
        ElseIf Barcode1.SymbologyID = Symbologies.Ind25 Then
            SymbID = "IND25"
        ElseIf Barcode1.SymbologyID = Symbologies.Interleaved25 Then
            SymbID = "INTERLEAVED25"
        ElseIf Barcode1.SymbologyID = Symbologies.Mat25 Then
            SymbID = "MAT25"
        ElseIf Barcode1.SymbologyID = Symbologies.MSI Then
            SymbID = "MSI"
        ElseIf Barcode1.SymbologyID = Symbologies.Planet Then
            SymbID = "PLANET"
        ElseIf Barcode1.SymbologyID = Symbologies.Postnet Then
            SymbID = "POSTNET"
        ElseIf Barcode1.SymbologyID = Symbologies.UPCa Then
            SymbID = "UPCA"
        ElseIf Barcode1.SymbologyID = Symbologies.UPCe Then
            SymbID = "UPCE"
        End If

        Dim cboIndex As Integer
        cboIndex = cboSymbology.FindStringExact(SymbID)
        cboSymbology.SelectedIndex = cboIndex

        If Barcode1.Code128Set = Code128CharacterSets.A Then
            SymbID = "A"
        ElseIf Barcode1.Code128Set = Code128CharacterSets.B Then
            SymbID = "B"
        ElseIf Barcode1.Code128Set = Code128CharacterSets.C Then
            SymbID = "C"
        ElseIf Barcode1.Code128Set = Code128CharacterSets.Auto Then
            SymbID = "AUTO"
        End If

        If Barcode1.RotationAngle = RotationAngles.Zero_Degrees Then
            SymbID = "0 Degrees"
        ElseIf Barcode1.RotationAngle = RotationAngles.Ninety_Degrees Then
            SymbID = "90 Degrees"
        ElseIf Barcode1.RotationAngle = RotationAngles.One_Hundred_Eighty_Degrees Then
            SymbID = "180 Degrees"
        ElseIf Barcode1.RotationAngle = RotationAngles.Two_Hundred_Seventy_Degrees Then
            SymbID = "270 Degrees"
        End If
        UpdateFormCaption()
    End Sub

    Private Sub UpdateFormCaption()
        If Barcode1.SymbologyID = Symbologies.Codabar Then
            Me.Text = "IDAutomation Example - " & "Barcoding with Codabar"
        ElseIf Barcode1.SymbologyID = Symbologies.Code11 Then
            Me.Text = "IDAutomation Example - " & "Barcoding with Code11"
        ElseIf Barcode1.SymbologyID = Symbologies.Code128 Then
            If Barcode1.Code128Set = Code128CharacterSets.A Then
                Me.Text = "IDAutomation Example - " & "Barcoding with Code128 Set A"
            ElseIf Barcode1.Code128Set = Code128CharacterSets.B Then
                Me.Text = "IDAutomation Example - " & "Barcoding with Code128 Set B"
            ElseIf Barcode1.Code128Set = Code128CharacterSets.C Then
                Me.Text = "IDAutomation Example - " & "Barcoding with Code128 Set C"
            ElseIf Barcode1.Code128Set = Code128CharacterSets.Auto Then
                Me.Text = "IDAutomation Example - " & "Barcoding with Code128 Auto"
            End If
        ElseIf Barcode1.SymbologyID = Symbologies.Code39 Then
            Me.Text = "IDAutomation Example - " & "Barcoding with Code39"
        ElseIf Barcode1.SymbologyID = Symbologies.Code39Ext Then
            Me.Text = "IDAutomation Example - " & "Barcoding with Code39 Extended"
        ElseIf Barcode1.SymbologyID = Symbologies.Code93 Then
            Me.Text = "IDAutomation Example - " & "Barcoding with Code93"
        ElseIf Barcode1.SymbologyID = Symbologies.Code93Ext Then
            Me.Text = "IDAutomation Example - " & "Barcoding with Code93 Extended"
        ElseIf Barcode1.SymbologyID = Symbologies.Ean13 Then
            Me.Text = "IDAutomation Example - " & "Barcoding with EAN-13"
        ElseIf Barcode1.SymbologyID = Symbologies.Ean8 Then
            Me.Text = "IDAutomation Example - " & "Barcoding with EAN-8"
        ElseIf Barcode1.SymbologyID = Symbologies.Ind25 Then
            Me.Text = "IDAutomation Example - " & "Barcoding with Industrial 2 of 5"
        ElseIf Barcode1.SymbologyID = Symbologies.Interleaved25 Then
            Me.Text = "IDAutomation Example - " & "Barcoding with Interleaved 2 of 5"
        ElseIf Barcode1.SymbologyID = Symbologies.Mat25 Then
            Me.Text = "IDAutomation Example - " & "Barcoding with MAT 2 of 5"
        ElseIf Barcode1.SymbologyID = Symbologies.MSI Then
            Me.Text = "IDAutomation Example - " & "Barcoding with MSI Plessey"
        ElseIf Barcode1.SymbologyID = Symbologies.Planet Then
            Me.Text = "IDAutomation Example - " & "Barcoding with Planet"
        ElseIf Barcode1.SymbologyID = Symbologies.Postnet Then
            Me.Text = "IDAutomation Example - " & "Barcoding with Postnet"
        ElseIf Barcode1.SymbologyID = Symbologies.UPCa Then
            Me.Text = "IDAutomation Example - " & "Barcoding with UPC-A"
        ElseIf Barcode1.SymbologyID = Symbologies.UPCe Then
            Me.Text = "IDAutomation Example - " & "Barcoding with UPC-E"
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        UpdateFormCaption()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'This is the event handler to print the image of this barcode on the printer
        'Make sure that system.drawing.printing is imported to use this
        'Create the document object that we are sending to the printer
        Dim prndoc As PrintDocument = New PrintDocument()
        'Give the document a title.  This is what displays in the Printers Control Panel item
        prndoc.DocumentName = "Printing a Barcode"
        'Add an event handler to handle any additional processing that may need to occur, such
        'as positioning of text
        AddHandler prndoc.PrintPage, New System.Drawing.Printing.PrintPageEventHandler(AddressOf PrintDocumentOnPrintPage)
        'Initiate the printing of the page.  PrintDocumentOnPrintPage will be handled next
        prndoc.Print()
    End Sub

    Private Sub PrintDocumentOnPrintPage(ByVal sender As Object, ByVal ppea As PrintPageEventArgs)
        Dim grfx As System.Drawing.Graphics = ppea.Graphics
        'Dim myImage As System.Drawing.Imaging.Metafile
        'Ensure that the Graphics object is printing in MM instead of the default inches
        grfx.PageUnit = GraphicsUnit.Millimeter
        grfx.PageScale = 1.0F
        grfx.DrawString(Me.Text, Me.Font, Brushes.Black, 0, 0)
        'The new and more efficient method of printing is to use PaintOnGraphics:
        'http://idautomation.com/formscontrols/FormsControlManual.html#Printing_Visual_Studio_Dotnet        
        Barcode1.PaintOnGraphics(grfx, 0, 200)
        'If IndEMF.Checked Then
        '   myImage = Barcode1.IndependentEMF
        'Else
        '    Barcode1.RefreshPrinterDPI()
        '    myImage = Barcode1.Picture
        'End If
        'grfx.DrawImage(myImage, 5, 5)
    End Sub

    Private Sub cboSymbology_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSymbology.SelectedIndexChanged
        If cboSymbology.SelectedItem.ToString = "CODE128" Then
            Barcode1.SymbologyID = Symbologies.Code128
        ElseIf cboSymbology.SelectedItem.ToString = "CODABAR" Then
            Barcode1.SymbologyID = Symbologies.Codabar
        ElseIf cboSymbology.SelectedItem.ToString = "CODE11" Then
            Barcode1.SymbologyID = Symbologies.Code11
        ElseIf cboSymbology.SelectedItem.ToString = "CODE39" Then
            Barcode1.SymbologyID = Symbologies.Code39
        ElseIf cboSymbology.SelectedItem.ToString = "CODE39EXT" Then
            Barcode1.SymbologyID = Symbologies.Code39Ext
        ElseIf cboSymbology.SelectedItem.ToString = "CODE93" Then
            Barcode1.SymbologyID = Symbologies.Code93
        ElseIf cboSymbology.SelectedItem.ToString = "CODE93EXT" Then
            Barcode1.SymbologyID = Symbologies.Code93Ext
        ElseIf cboSymbology.SelectedItem.ToString = "EAN13" Then
            Barcode1.SymbologyID = Symbologies.Ean13
        ElseIf cboSymbology.SelectedItem.ToString = "EAN8" Then
            Barcode1.SymbologyID = Symbologies.Ean8
        ElseIf cboSymbology.SelectedItem.ToString = "IND25" Then
            Barcode1.SymbologyID = Symbologies.Ind25
        ElseIf cboSymbology.SelectedItem.ToString = "INTERLEAVED25" Then
            Barcode1.SymbologyID = Symbologies.Interleaved25
        ElseIf cboSymbology.SelectedItem.ToString = "MAT25" Then
            Barcode1.SymbologyID = Symbologies.Mat25
        ElseIf cboSymbology.SelectedItem.ToString = "MSI" Then
            Barcode1.SymbologyID = Symbologies.MSI
        ElseIf cboSymbology.SelectedItem.ToString = "PLANET" Then
            Barcode1.SymbologyID = Symbologies.Planet
        ElseIf cboSymbology.SelectedItem.ToString = "POSTNET" Then
            Barcode1.SymbologyID = Symbologies.Postnet
        ElseIf cboSymbology.SelectedItem.ToString = "UPCA" Then
            Barcode1.SymbologyID = Symbologies.UPCa
        ElseIf cboSymbology.SelectedItem.ToString = "UPCE" Then
            Barcode1.SymbologyID = Symbologies.UPCe
        End If

        UpdateFormCaption()
    End Sub

    Private Sub chkUseCheckDigit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseCheckDigit.CheckedChanged
        If chkUseCheckDigit.Checked = True Then
            Barcode1.CheckCharacter = True
        Else
            Barcode1.CheckCharacter = False
        End If
    End Sub

    Private Sub chkShowText_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowText.CheckedChanged
        If chkShowText.Checked = True Then
            Barcode1.ShowText = True
        Else
            Barcode1.ShowText = False
        End If
    End Sub

    Private Sub chkShowCheckDigit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowCheckDigit.CheckedChanged
        If chkShowCheckDigit.Checked = True Then
            Barcode1.CheckCharacterInText = True
        Else
            Barcode1.CheckCharacterInText = False
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdDisplayMetafile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisplayMetafile.Click
        Dim myImage As System.Drawing.Imaging.Metafile
        ' "Picture" creates the EMF with resolution information (for precise printing) and
        ' "IndependentEMF" is a device independent WMF that can be used for
        ' displaying in a picture box or printing to printers with different DPI.
        If IndEMF.Checked Then
            myImage = Barcode1.IndependentEMF
        Else
            myImage = Barcode1.Picture
        End If
        PictureBox1.Image = Nothing
        Dim grfx As System.Drawing.Graphics = PictureBox1.CreateGraphics()
        PictureBox1.Refresh()
        grfx.DrawImage(myImage, 10, 10)
        grfx.Dispose()
        myImage = Nothing
        grfx = Nothing
    End Sub


    Private Sub cmdPrintAsDLL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintAsDLL.Click
        'The following line of code is remarked out because it was placed in the declarations of the frmIDAutomation class 
        'Dim NewBarcode As IDAutomation.Windows.Forms.LinearBarCode.Barcode = New Barcode()
        MsgBox("The following method will print 2 barcodes to your printer.")
        Dim I As Integer
        For I = 1 To 2
            NewBarcode.DataToEncode = "1029384700" & I
            'If you wish to only create an instance of the barcode object, the RefreshImage() method
            'must be called to update the image before printing.
            NewBarcode.RefreshImage()
            Dim prndoc As PrintDocument = New PrintDocument()
            prndoc.DocumentName = "Printing Barcode Number" & I
            AddHandler prndoc.PrintPage, New System.Drawing.Printing.PrintPageEventHandler(AddressOf PrintDocumentOnPrintPageFromDLL)
            prndoc.Print()
        Next I
    End Sub

    Private Sub PrintDocumentOnPrintPageFromDLL(ByVal sender As Object, ByVal ppea As PrintPageEventArgs)
        Dim grfx As System.Drawing.Graphics = ppea.Graphics
        'Ensure that the Graphics object is printing in MM instead of the default inches
        grfx.PageUnit = GraphicsUnit.Millimeter
        grfx.PageScale = 1.0F
        grfx.DrawString(Me.Text, Me.Font, Brushes.Black, 0, 0)
        Barcode1.PaintOnGraphics(grfx, 0, 200)
    End Sub

    Private Sub ApplyDTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyDTE.Click
        Barcode1.DataToEncode = txtDataToEncode.Text
    End Sub

    Private Sub SaveJPEG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJPEG.Click
        Barcode1.Resolution = Resolutions.Custom
        'Here we make this 96 DPI, the resolution of the web browser
        Barcode1.ResolutionCustomDPI = 96
        'After setting the resolution we should always refresh the image
        Barcode1.RefreshImage()
        Barcode1.SaveImageAs("SavedBarcode.Jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
        'Reset the resolution source to the printer (in case we print a barcode)
        Barcode1.Resolution = Resolutions.Printer
    End Sub

    Private Sub SaveTIFF300_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveTIFF300.Click
        Barcode1.Resolution = Resolutions.Custom
        'Here we make this 300 DPI
        Barcode1.ResolutionCustomDPI = 300
        'After setting the resolution we should always refresh the image
        Barcode1.RefreshImage()
        Barcode1.SaveImageAs("SavedBarcode.Tiff", System.Drawing.Imaging.ImageFormat.Tiff)
        'Reset the resolution source to the printer (in case we print a barcode)
        Barcode1.Resolution = Resolutions.Printer
    End Sub
End Class
