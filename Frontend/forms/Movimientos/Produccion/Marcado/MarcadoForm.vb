Imports Backend

Public Class MarcadoForm
    Dim producc As New CargaProduccion
    Dim productoP As New Producto
    Public mesa As Integer
    Dim imagenes As List(Of Image) = New List(Of Image)
    Dim indexImg = 0
    Private Sub MarcadoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPulida.DataSource = New DataSetProduccion.MarcadoDataTable
    End Sub
    Private Sub txtNroProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim prodDao As New ProduccionDAO


            If txtNroProd.Text <> "" Then
                producc = prodDao.getProduccion(txtNroProd.Text)

                If producc.idProd <> 0 Then
                    'Valida si ya paso por corte
                    If prodDao.validarCorte(producc.idProd) Then
                        prodDao.guardarMarcado(producc.idProd, 0)
                        'MsgBox("Marcado Guardado", MsgBoxStyle.Information, "Pulida")
                        dgvPulida.DataSource = prodDao.getMarcado(producc.idProd).Tables("tabla")
                        cargarImagenes()
                        txtNroProd.Text = ""
                        txtNroProd.Focus()
                    Else
                        MsgBox("Producción aun no pasó por corte", MsgBoxStyle.Critical, "Marcado")
                    End If
                    ' Guardar marcado

                End If
            End If
        End If
    End Sub


    Private Sub cargarImagenes()
        Try
            Dim daov As New VentaDAO
            imagenes = daov.cargarPlanos2(producc.venta)
            indexImg = 0
            If imagenes.Count > 0 Then
                pbPlano.Image = imagenes.Item(indexImg)
                pbPlano.SizeMode = PictureBoxSizeMode.Zoom
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnMesa1_Click(sender As Object, e As EventArgs) Handles btnMesa1.Click
        Dim corteRot As New MarcadoRotura

        corteRot.ShowDialog()

        corteRot.Dispose()
    End Sub

    Private Sub pbPlano_Click(sender As Object, e As EventArgs) Handles pbPlano.Click
        Dim plv As New PlanoViewver
        plv.plano = pbPlano.Image

        plv.ShowDialog()
        plv.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnImgNext.Click


        If imagenes.Count > 0 Then
            indexImg += 1

            If indexImg < imagenes.Count Then
                pbPlano.Image = imagenes.Item(indexImg)
            Else
                indexImg = 0
                pbPlano.Image = imagenes.Item(indexImg)

            End If

        End If
    End Sub

    Private Sub btnImgPrev_Click(sender As Object, e As EventArgs) Handles btnImgPrev.Click
        If imagenes.Count > 0 Then
            indexImg -= 1

            If indexImg >= 0 Then
                pbPlano.Image = imagenes.Item(indexImg)
            Else
                indexImg = imagenes.Count - 1
                pbPlano.Image = imagenes.Item(indexImg)

            End If

        End If
    End Sub
End Class