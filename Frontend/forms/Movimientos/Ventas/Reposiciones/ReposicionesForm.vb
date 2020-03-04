Imports Backend
Imports IDAutomation.Windows.Forms.LinearBarCode


Imports ZXing
Public Class ReposicionesForm
    Dim producc As New CargaProduccion
    Dim productoP As New Producto
    Dim roturacheck = False
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
        Dim daop As New ReposicionesDAO
        roturacheck = daop.checkRotura(producc.idProd)
        If roturacheck = True Then
            txtMotCod.Text = 9
            txtMotivo.Text = "Rotura"
        Else
            txtMotCod.Text = ""
            txtMotivo.Text = ""
        End If

    End Sub
    Private Sub ReposicionesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvReposiciones.DataSource = New DataSet1.listadoReposicionesDataTable
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim result As Integer = MessageBox.Show("¿Guardar reposición?", "Guardar", MessageBoxButtons.YesNo)
        If roturacheck = False Then
            MsgBox("Producción no presenta rotura. ", MsgBoxStyle.Information, "Notificación")
            Exit Sub
        End If
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
                If dgvReposiciones.Rows.Count > 0 Then
                    Dim ticketsImprimir As New TicketsRepo
                    'Dim row = dgvVentas.CurrentRow.Index
                    'Dim daoCliente As New ClienteDAO
                    'Dim codigo = dgvVentas.Item(0, row).Value
                    'Dim currentVenta = daoVent.obtenerVentaDatos(codigo)
                    'Dim currentCliente = daoCliente.obtenerCliente(currentVenta.cliente)
                    Dim usud As New SesionDAO
                    Dim usuar = usud.getUsuario()
                    Dim prodDao As New ProduccionDAO
                    Dim daov As New VentaDAO
                    Dim daoC As New ClienteDAO
                    Dim vent = daov.getVenta(producc.venta)
                    Dim ds = prodDao.getTickets(producc.idProd, producc.idProd)
                    ds.Tables("tabla").Columns.Add(New DataColumn("BarCode", System.Type.GetType("System.Byte[]")))
                    'Dim row = dgvReposiciones.Rows(dgvReposiciones.Rows.Count - 1)
                    Dim codigo = dgvReposiciones.Item(0, dgvReposiciones.Rows.Count - 1).Value
                    Dim cliente = daoC.getCliente(vent.cliente)
                    'dgv1.DataSource = ds.Tables("tabla")
                    Dim barcode1 As IDAutomation.Windows.Forms.LinearBarCode.Barcode = New Barcode()


                    'barcode1.Resolution = Barcode.Resolutions.Custom
                    barcode1.ResolutionCustomDPI = 600
                    'barcode1.XDimensionCM = 0.03

                    barcode1.XDimensionCM = 3.5
                    'barcode1.BarHeightCM = 5.5
                    barcode1.BarHeightCM = 2.5
                    barcode1.ShowText = True
                    'barcode1.ShowTextLocation = "above"
                    '' Barcode zhing

                    Dim barwriter As New BarcodeWriter
                    barwriter.Format = BarcodeFormat.CODE_128

                    For Each row As DataRow In ds.Tables("tabla").Rows
                        'barcode.Data = CInt(row.Item("Produccion")).ToString + ""

                        'barcode1.DataToEncode = CInt(row.Item("Produccion")).ToString
                        Dim img = barwriter.Write(CInt(row.Item("Produccion")).ToString)
                        'Dim MyBitmap As New System.Drawing.Bitmap(barcode1.BMPPicture)
                        'Dim converter As New ImageConverter
                        'Dim imageData = converter.ConvertTo(MyBitmap, GetType(Byte()))
                        Dim converter As New ImageConverter
                        Dim imageData = converter.ConvertTo(img, GetType(Byte()))
                        row.Item("BarCode") = imageData
                        'Dim imageData = barcode.drawBarcodeAsBytes()
                        'row.Item("BarCode") = imageData
                    Next

                    ticketsImprimir.SetDataSource(ds.Tables("tabla"))
                    ' ticketsImprimir.SetParameterValue("inicio", txtDesde.Text)
                    'ticketsImprimir.SetParameterValue("fin", txtHasta.Text)
                    'ticketsImprimir.SetParameterValue("Cliente", cliente)
                    Dim cliented As New ClienteDAO

                    ticketsImprimir.SetParameterValue("Usuario", usuar)
                    ticketsImprimir.SetParameterValue("Obs", vent.obs)
                    ticketsImprimir.SetParameterValue("Cliente", "Fab. CNEL. OVIEDO - " + cliente.nombre)
                    ticketsImprimir.SetParameterValue("NuevaOt", codigo)
                    'ticketsImprimir.SetParameterValue("Obra", usuar)
                    'ticketsImprimir.SetParameterValue("Obs", obs)




                    ticketsImprimir.PrintOptions.PrinterName = "Datamax-O'Neil E-4205A Mark III" ''PONER NOMBRE DE IMPRESORA
                    'ticketsImprimir.PrintOptions.PrinterName = "Win2PDF" ''PONER NOMBRE DE IMPRESORA

                    ticketsImprimir.PrintToPrinter(1, False, 0, 0)

                    'If ticketsImprimir.Print =  Then
                    '    MsgBox "Canceled"
                    '    ElseIf moReport.PrintingStatus.Progress = crPrintingFailed Then
                    '    MsgBox "Error"
                    '   Else
                    '    MsgBox "Printed"
                    'End If
                    ' MsgBox("¡Tickets impresos!", MsgBoxStyle.Information, "Notificación")
                    'Dim daop As New ProduccionDAO
                    'Dim ds As New DataSet
                    'Dim daoV As New VentaDAO
                    'Dim daoC As New ClienteDAO
                    'Dim vent = daoV.getVenta(producc.venta)
                    ''Dim cliente = 
                    '' ds = daop.getTickets(producc.idProd, producc.idProd)
                    'ds.Tables("tabla").Columns.Add(New DataColumn("BarCode", System.Type.GetType("System.Byte[]")))
                    ''Dim barcode As New LinearCrystal()

                    ''Barcode.Type = BarcodeType.CODE128
                    ''Barcode.BarHeight = 50
                    ''Barcode.ImageFormat = System.Drawing.Imaging.ImageFormat.Png


                    'Dim barcode1 As IDAutomation.Windows.Forms.LinearBarCode.Barcode = New Barcode()
                    ''barcode1.Resolution = Barcode.Resolutions.Custom
                    'barcode1.ResolutionCustomDPI = 300
                    'barcode1.XDimensionCM = 0.03
                    'barcode1.BarHeightCM = 1.5
                    'For Each row As DataRow In ds.Tables("tabla").Rows
                    '    'barcode.Data = CInt(row.Item("Produccion")).ToString + ""

                    '    barcode1.DataToEncode = CInt(row.Item("Produccion")).ToString
                    '    Dim MyBitmap As New System.Drawing.Bitmap(barcode1.BMPPicture)
                    '    Dim converter As New ImageConverter
                    '    Dim imageData = converter.ConvertTo(MyBitmap, GetType(Byte()))
                    '    row.Item("BarCode") = imageData
                    '    'row.Item("")
                    '    'Dim imageData = barcode.drawBarcodeAsBytes()
                    '    'row.Item("BarCode") = imageData
                    'Next
                    ''dgv.DataSource = ds.Tables("tabla")


                    'Dim rpt As New ImpresionDeEtiquetas
                    'rpt.SetDataSource(ds.Tables("tabla"))
                    ''rpt.PrintOptions.PrinterName = "Datamax-O'Neil E-4205A Mark III"
                    'rpt.PrintOptions.PrinterName = "Win2PDF"
                    'rpt.PrintToPrinter(1, False, 0, 0)
                    ''/CrystalReportViewer1.ReportSource = rpt
                End If


            Catch ex As Exception

            End Try
        End If

    End Sub
End Class