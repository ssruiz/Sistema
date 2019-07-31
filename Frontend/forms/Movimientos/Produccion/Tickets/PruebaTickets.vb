Imports Backend
Imports BarcodeLib.Barcode
Imports BarcodeLib.Barcode.CrystalReports
Imports IDAutomation.Windows.Forms.LinearBarCode

Public Class PruebaTickets
    Dim ds As New DataSet
    Private Sub PruebaTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim daop As New ProduccionDAO

        ds = daop.getTickets(16, 17)
        ds.Tables("tabla").Columns.Add(New DataColumn("BarCode", System.Type.GetType("System.Byte[]")))
        'Dim barcode As New LinearCrystal()

        'Barcode.Type = BarcodeType.CODE128
        'Barcode.BarHeight = 50
        'Barcode.ImageFormat = System.Drawing.Imaging.ImageFormat.Png


        Dim barcode1 As IDAutomation.Windows.Forms.LinearBarCode.Barcode = New Barcode()
        'barcode1.Resolution = Barcode.Resolutions.Custom
        barcode1.ResolutionCustomDPI = 300
        barcode1.XDimensionCM = 0.03
        barcode1.BarHeightCM = 1.5
        For Each row As DataRow In ds.Tables("tabla").Rows
            'barcode.Data = CInt(row.Item("Produccion")).ToString + ""

            barcode1.DataToEncode = CInt(row.Item("Produccion")).ToString
            Dim MyBitmap As New System.Drawing.Bitmap(barcode1.BMPPicture)
            Dim converter As New ImageConverter
            Dim imageData = converter.ConvertTo(MyBitmap, GetType(Byte()))
            row.Item("BarCode") = imageData
            'Dim imageData = barcode.drawBarcodeAsBytes()
            'row.Item("BarCode") = imageData
        Next
        dgv.DataSource = ds.Tables("tabla")


        Dim rpt As New ImpresionDeEtiquetas
        rpt.SetDataSource(ds.Tables("tabla"))

        CrystalReportViewer1.ReportSource = rpt


    End Sub
End Class