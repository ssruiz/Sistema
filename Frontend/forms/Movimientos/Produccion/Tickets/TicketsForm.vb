Imports Backend
Imports IDAutomation.Windows.Forms.LinearBarCode
Imports ZXing

Public Class TicketsForm
    Public idVenta = 0
    Dim ini = 0
    Dim fin = 0
    Public cliente = ""

    Public obs = ""
    Dim list As New DataSet
    Private Sub TicketsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarEtiquetas()
    End Sub

    Private Sub cargarEtiquetas()
        Try
            Dim daov As New VentaDAO
            Dim res = daov.cargarEtiquetas(idVenta)
            list = res
            dgvEtiquetas.DataSource = res.Tables("tabla")
            dgvEtiquetas.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            If dgvEtiquetas.Rows.Count = 0 Then
                MsgBox("La OT no posee etiquetas o ya fueron impresas", MsgBoxStyle.Information, "Etiquetas")
                Exit Sub
            End If
            If validarNros() Then
                Dim ticketsImprimir As New Tickets
                'Dim row = dgvVentas.CurrentRow.Index
                'Dim daoCliente As New ClienteDAO
                'Dim codigo = dgvVentas.Item(0, row).Value
                'Dim currentVenta = daoVent.obtenerVentaDatos(codigo)
                'Dim currentCliente = daoCliente.obtenerCliente(currentVenta.cliente)
                Dim usud As New SesionDAO
                Dim usuar = usud.getUsuario()
                Dim prodDao As New ProduccionDAO
                Dim daov As New VentaDAO
                Dim vent = daov.getVenta(idVenta)
                Dim ds = prodDao.getTickets(txtDesde.Text, txtHasta.Text)
                ds.Tables("tabla").Columns.Add(New DataColumn("BarCode", System.Type.GetType("System.Byte[]")))

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
                ticketsImprimir.SetParameterValue("Usuario", usuar)
                ticketsImprimir.SetParameterValue("Obs", vent.obs)
                ticketsImprimir.SetParameterValue("Cliente", cliente)
                'ticketsImprimir.SetParameterValue("Obra", usuar)
                'ticketsImprimir.SetParameterValue("Obs", obs)

                ini = txtDesde.Text
                fin = txtHasta.Text


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
                MsgBox("¡Tickets impresos!", MsgBoxStyle.Information, "Notificación")
                actualizarProduccion()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub actualizarProduccion()
        Try
            Dim daov As New VentaDAO
            daov.actualizarProduccion(idVenta, ini, fin)
        Catch ex As Exception

        End Try
    End Sub
    Private Function validarNros() As Boolean
        Dim dv As DataView
        If CInt(txtDesde.Text) = 0 And CInt(txtHasta.Text) = 0 Then

            Dim dv2 As New DataView(list.Tables("tabla"))
            dv2.Sort = "Produccion"
            txtHasta.Text = dv2(dv2.Count - 1)(1).ToString
            txtDesde.Text = dv2(0)(1).ToString
            'txtHasta.Text = dgvEtiquetas.Rows(dgvEtiquetas.Rows.Count - 1).Cells.Item("ProdCol").Value
            'txtDesde.Text = dgvEtiquetas.Rows(0).Cells.Item("ProdCol").Value
            Return True
        End If
        Dim st1 = 0
        Dim st2 = 0
        For Each row As DataGridViewRow In dgvEtiquetas.Rows
            If row.Cells.Item("ProdCol").Value = txtDesde.Text Then
                st1 = 1

            End If
            If row.Cells.Item("ProdCol").Value = txtHasta.Text Then
                st2 = 1
            End If
        Next

        If st1 <> 1 Then
            MsgBox("Nro. de produccion inicial seleccionado no encontrado. Vuelva a ingresar")
            txtDesde.Focus()
            Return False
        ElseIf st2 <> 1 Then
            MsgBox("Nro. de produccion final seleccionado no encontrado. Vuelva a ingresar")
            txtHasta.Focus()
            Return False
        ElseIf CInt(txtDesde.Text) > CInt(txtHasta.Text) Then
            MsgBox("Nro. de produccion final es menor al inicial. Vuelva a ingresar")
            txtDesde.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub txtDesde_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtHasta.Text = txtDesde.Text
            txtHasta.Focus()
            txtHasta.SelectAll()
        End If
    End Sub

    Private Sub txtDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesde.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtDesde_Click(sender As Object, e As EventArgs) Handles txtDesde.Click
        txtDesde.SelectAll()
    End Sub

    Private Sub txtHasta_Click(sender As Object, e As EventArgs) Handles txtHasta.Click
        txtHasta.SelectAll()
    End Sub

    Private Sub txtHasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnImprimir.PerformClick()
        End If
    End Sub
End Class