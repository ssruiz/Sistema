Imports Backend
Imports IDAutomation.Windows.Forms.LinearBarCode
Public Class ReposicionesForm
    Dim producc As New CargaProduccion
    Dim productoP As New Producto
    Private Sub txtNroProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If txtNroProd.Text <> "" Then
                Dim daov As New ReposicionesDAO
                producc = daov.getProduccion(txtNroProd.Text)
                Dim daop As New ProductoDAO
                productoP = daop.getProducto(producc.codProd)
                cargarProduccion()
                Dim r = daov.cargarListado(txtNroProd.Text)
                dgvReposiciones.DataSource = r.Tables("tabla")
                btnGuardar.Enabled = True
                dgvReposiciones.ClearSelection()
            End If
        End If
    End Sub

    Private Sub cargarProduccion()
        txtAlto.Text = producc.alto
        txtAncho.Text = producc.ancho
        txtPanho.Text = producc.panho
        txtProducto.Text = productoP.descripcion
        txtSup.Text = producc.sup
        txtCliente.Text = producc.cliente
        txtCliCod.Text = producc.cliCod
        txtOpCod.Text = producc.opCod
        txtOpDesc.Text = producc.opDesc
        txtFecha.Text = producc.fechaOt
        txtOT.Text = producc.venta
    End Sub
    Private Sub ReposicionesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvReposiciones.DataSource = New DataSet1.listadoReposicionesDataTable
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim result As Integer = MessageBox.Show("¿Guardar reposición?", "Guardar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Dim daor As New ReposicionesDAO
                daor.guardarReposicion(txtOT.Text, txtMotCod.Text, producc.idProd)
                MsgBox("Reposición guardada", MsgBoxStyle.Information, "Notificación")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnEtiquetas_Click(sender As Object, e As EventArgs) Handles btnEtiquetas.Click
        If producc.idProd <> 0 Then
            Try
                Dim daop As New ProduccionDAO
                Dim ds As New DataSet
                Dim daoV As New VentaDAO
                Dim daoC As New ClienteDAO
                Dim vent = daoV.getVenta(producc.venta)
                'Dim cliente = 
                ' ds = daop.getTickets(producc.idProd, producc.idProd)
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
                    'row.Item("")
                    'Dim imageData = barcode.drawBarcodeAsBytes()
                    'row.Item("BarCode") = imageData
                Next
                'dgv.DataSource = ds.Tables("tabla")


                Dim rpt As New ImpresionDeEtiquetas
                rpt.SetDataSource(ds.Tables("tabla"))
                'rpt.PrintOptions.PrinterName = "Datamax-O'Neil E-4205A Mark III"
                rpt.PrintOptions.PrinterName = "Win2PDF"
                rpt.PrintToPrinter(1, False, 0, 0)
                '/CrystalReportViewer1.ReportSource = rpt

            Catch ex As Exception

            End Try
        End If

    End Sub
End Class