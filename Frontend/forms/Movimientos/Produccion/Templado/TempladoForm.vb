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
    End Sub

    Private Sub txtNroProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim prodDao As New ProduccionDAO
            If txtNroProd.Text <> "" Then
                producc = prodDao.getProduccion(txtNroProd.Text)

                If producc.idProd <> 0 Then
                    'Entrada al horno
                    If templado = 1 Then
                        If prodDao.validarCorte(producc.idProd) Then

                            If prodDao.validarMarcado(producc.idProd) Then

                                ' Guardar Entrada al horno
                                Dim i = prodDao.guardarTemplado(producc.idProd, templado, 0)
                                If i = 1 Then
                                    MsgBox("Templado Entrada Horno. Guardada", MsgBoxStyle.Information, "Pulida")
                                    dgvPulida.DataSource = prodDao.getTemplado(producc.idProd).Tables("tabla")
                                End If

                            Else
                                MsgBox("Producción aun no pasó por marcado", MsgBoxStyle.Critical, "Templado - Entrada")
                            End If

                        Else
                            MsgBox("Producción aun no pasó por corte", MsgBoxStyle.Critical, "Marcado")
                        End If


                    Else
                        If prodDao.validarCorte(producc.idProd) Then

                            If prodDao.validarMarcado(producc.idProd) Then

                                ' Guardar Entrada al horno
                                Dim i = prodDao.guardarTemplado(producc.idProd, templado, 0)
                                If i = 1 Then
                                    MsgBox("Templado Salida Horno. Guardada", MsgBoxStyle.Information, "Pulida")
                                    dgvPulida.DataSource = prodDao.getTemplado(producc.idProd).Tables("tabla")
                                End If

                            Else
                                MsgBox("Producción aun no pasó por marcado", MsgBoxStyle.Critical, "Templado - Salida")
                            End If

                        Else
                            MsgBox("Producción aun no pasó por corte", MsgBoxStyle.Critical, "Marcado")
                        End If
                        ' Guardar marcado
                    End If
                End If


            End If
        End If
    End Sub

    Private Sub btnMesa1_Click(sender As Object, e As EventArgs) Handles btnMesa1.Click
        'Dim corteRot As New RoturaPulida
        'corteRot.pulidora = mesa
        'corteRot.ShowDialog()

        'corteRot.Dispose()
    End Sub
End Class