Imports Backend

Public Class TempladoForm
    Public templado = 0
    Dim producc As New CargaProduccion
    Dim productoP As New Producto
    Private Sub TempladoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If templado = 1 Then
            txtPulidora.Text = "TEMPLADOS - ENTRADA"
            txtSalidaEntrada.Text = "Nro. Entradas"
        Else
            txtPulidora.Text = "TEMPLADOS - SALIDA"
            txtSalidaEntrada.Text = "Nro. Salidas"
        End If

        Dim prodDao As New ProduccionDAO
        lblEntradas.Text = prodDao.getTempEntradasDia()
        lblSalidas.Text = prodDao.getTempSalidasDia()
        lblRoturas.Text = prodDao.getTempRoturas()
    End Sub

    Private Sub txtNroProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim prodDao As New ProduccionDAO
            If txtNroProd.Text <> "" Then
                producc = prodDao.getProduccion(txtNroProd.Text)
                Dim productDao As New ProductoDAO

                Dim producto = productDao.getProducto(producc.codProd)
                If producc.idProd <> 0 Then
                    If templado = 1 Then

                        If prodDao.validarCorte(producc.idProd) = False Then
                            MsgBox("Producción aun no pasó por corte", MsgBoxStyle.Critical, "Templado")
                            Exit Sub
                        ElseIf prodDao.validarMarcado(producc.idProd) = False Then
                            MsgBox("Producción aun no pasó por marcado", MsgBoxStyle.Critical, "Templado")
                            Exit Sub
                        End If

                        If prodDao.controlarEntradaTemplado(producc.idProd) Then
                            Dim ban = False
                            If dgvPulida.Rows.Count > 0 Then
                                For i As Integer = 0 To dgvPulida.Rows.Count - 1
                                    If producc.idProd = CInt(dgvPulida.Rows(i).Cells(0).Value.ToString) Then
                                        ban = True
                                        Exit For
                                    End If
                                Next
                            End If


                            If ban = False Then

                                dgvPulida.Rows.Add(producc.idProd, producto.codigo, producc.panho, producc.ancho, producc.alto, Date.Now, "", "")
                                Dim piezas = dgvPulida.Rows.Count
                                lblPiezas.Text = piezas
                            End If


                        End If
                    Else

                        If prodDao.validarCorte(producc.idProd) = False Then
                            MsgBox("Producción aun no pasó por corte", MsgBoxStyle.Critical, "Templado")
                            Exit Sub
                        ElseIf prodDao.validarMarcado(producc.idProd) = False Then
                            MsgBox("Producción aun no pasó por marcado", MsgBoxStyle.Critical, "Templado")
                            Exit Sub
                        End If

                        If prodDao.controlarEntradaTemplado2(producc.idProd) Then
                            Dim ban = False
                            If dgvPulida.Rows.Count > 0 Then
                                For i As Integer = 0 To dgvPulida.Rows.Count - 1
                                    If producc.idProd = CInt(dgvPulida.Rows(i).Cells(0).Value.ToString) Then
                                        ban = True
                                        Exit For
                                    End If
                                Next
                            End If

                            If ban = False Then
                                dgvPulida.Rows.Add(producc.idProd, producto.codigo, producc.panho, producc.ancho, producc.alto, "", Date.Now, "")
                                Dim piezas = dgvPulida.Rows.Count
                                lblPiezas.Text = piezas
                            End If
                        End If


                    End If




                    ''Entrada al horno
                    'If templado = 1 Then
                    '    If prodDao.validarCorte(producc.idProd) Then

                    '        If prodDao.validarMarcado(producc.idProd) Then

                    '            ' Guardar Entrada al horno
                    '            Dim i = prodDao.guardarTemplado(producc.idProd, templado, 0)
                    '            If i = 1 Then
                    '                MsgBox("Templado Entrada Horno. Guardada", MsgBoxStyle.Information, "Pulida")
                    '                dgvPulida.DataSource = prodDao.getTemplado(producc.idProd).Tables("tabla")
                    '            End If

                    '        Else
                    '            MsgBox("Producción aun no pasó por marcado", MsgBoxStyle.Critical, "Templado - Entrada")
                    '        End If

                    '    Else
                    '        MsgBox("Producción aun no pasó por corte", MsgBoxStyle.Critical, "Marcado")
                    '    End If


                    'Else
                    '    If prodDao.validarCorte(producc.idProd) Then

                    '        If prodDao.validarMarcado(producc.idProd) Then

                    '            ' Guardar Entrada al horno
                    '            Dim i = prodDao.guardarTemplado(producc.idProd, templado, 0)
                    '            If i = 1 Then
                    '                MsgBox("Templado Salida Horno. Guardada", MsgBoxStyle.Information, "Pulida")
                    '                dgvPulida.DataSource = prodDao.getTemplado(producc.idProd).Tables("tabla")
                    '            End If

                    '        Else
                    '            MsgBox("Producción aun no pasó por marcado", MsgBoxStyle.Critical, "Templado - Salida")
                    '        End If

                    '    Else
                    '        MsgBox("Producción aun no pasó por corte", MsgBoxStyle.Critical, "Marcado")
                    '    End If
                    '    ' Guardar marcado
                    'End If
                End If


            End If
            txtNroProd.Text = ""
            txtNroProd.Focus()
            'Dim prodDao As New ProduccionDAO
            lblEntradas.Text = prodDao.getTempEntradasDia()
            lblSalidas.Text = prodDao.getTempSalidasDia()
            lblRoturas.Text = prodDao.getTempRoturas()
        End If

    End Sub

    Private Sub btnMesa1_Click(sender As Object, e As EventArgs) Handles btnMesa1.Click
        Dim corteRot As New TempladoRotura
        corteRot.templa = templado
        corteRot.ShowDialog()

        corteRot.Dispose()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim prodDao As New ProduccionDAO
        If templado = 1 Then

            If dgvPulida.Rows.Count > 0 Then
                prodDao.guardarTemplados(dgvPulida.Rows, 1)
            End If
            'If prodDao.validarCorte(producc.idProd) Then

            '    If prodDao.validarMarcado(producc.idProd) Then

            '        ' Guardar Entrada al horno
            '        Dim i = prodDao.guardarTemplado(producc.idProd, templado, 0)
            '        If i = 1 Then
            '            MsgBox("Templado Entrada Horno. Guardada", MsgBoxStyle.Information, "Pulida")
            '            dgvPulida.DataSource = prodDao.getTemplado(producc.idProd).Tables("tabla")
            '        End If

            '    Else
            '        MsgBox("Producción aun no pasó por marcado", MsgBoxStyle.Critical, "Templado - Entrada")
            '    End If

            'Else
            '    MsgBox("Producción aun no pasó por corte", MsgBoxStyle.Critical, "Marcado")
            'End If


        Else

            ' Guardar Entrada al horno
            If dgvPulida.Rows.Count > 0 Then
                prodDao.guardarTemplados(dgvPulida.Rows, 2)
            End If


        End If
    End Sub
End Class