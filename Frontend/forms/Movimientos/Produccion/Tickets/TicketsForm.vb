Imports Backend

Public Class TicketsForm
    Public idVenta = 0
    Dim ini = 0
    Dim fin = 0
    Private Sub TicketsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarEtiquetas()
    End Sub

    Private Sub cargarEtiquetas()
        Try
            Dim daov As New VentaDAO
            Dim res = daov.cargarEtiquetas(idVenta)
            dgvEtiquetas.DataSource = res.Tables("tabla")
            dgvEtiquetas.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            If validarNros() Then
                Dim ticketsImprimir As New Tickets
                'Dim row = dgvVentas.CurrentRow.Index
                'Dim daoCliente As New ClienteDAO
                'Dim codigo = dgvVentas.Item(0, row).Value
                'Dim currentVenta = daoVent.obtenerVentaDatos(codigo)
                'Dim currentCliente = daoCliente.obtenerCliente(currentVenta.cliente)
                ticketsImprimir.SetParameterValue("inicio", txtDesde.Text)
                ticketsImprimir.SetParameterValue("fin", txtHasta.Text)
                ini = txtDesde.Text
                fin = txtHasta.Text


                ticketsImprimir.PrintOptions.PrinterName = "Microsoft Print to PDF" ''PONER NOMBRE DE IMPRESORA

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
            txtHasta.Text = dgvEtiquetas.Rows(dgvEtiquetas.Rows.Count - 1).Cells.Item("ProdCol").Value
            txtDesde.Text = dgvEtiquetas.Rows(0).Cells.Item("ProdCol").Value
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
        ElseIf CInt(txtDesde.Text) > CInt(txtHasta.text) Then
            MsgBox("Nro. de produccion final es menor al inicial. Vuelva a ingresar")
            txtDesde.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub txtDesde_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtHasta.Focus()
        End If
    End Sub

    Private Sub txtDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesde.KeyPress
        soloNumeros(e)
    End Sub
End Class