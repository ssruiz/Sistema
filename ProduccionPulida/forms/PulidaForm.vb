Imports Backend
Imports Frontend

Public Class PulidaForm
    Dim producc As New CargaProduccion
    Dim productoP As New Producto
    Public mesa As Integer
    Private Sub PulidaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPulida.DataSource = New DataSetProduccion.PulidaDataTable
        txtPulidora.Text = "PULIDORA " + mesa.ToString
    End Sub

    Private Sub txtNroProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim prodDao As New ProduccionDAO
            If txtNroProd.Text <> "" Then
                producc = prodDao.getProduccion(txtNroProd.Text)

                If producc.idProd <> 0 Then

                    If prodDao.validarCorte(producc.idProd) = False Then
                        MsgBox("Producción aun no pasó por corte", MsgBoxStyle.Critical, "Pulida")
                        Exit Sub
                    End If

                    If prodDao.validarPulidaEstado(producc.idProd) = False Then
                        'MsgBox("Producción ya pasó por pulida", MsgBoxStyle.Critical, "Pulida")
                        Exit Sub
                    End If
                    ' Guardar Corte
                    prodDao.guardarPulida(producc.idProd, mesa, 0)
                    'MsgBox("Pulida Guardada", MsgBoxStyle.Information, "Pulida")
                    dgvPulida.DataSource = prodDao.getPulida(producc.idProd).Tables("tabla")
                    txtNroProd.Text = ""
                    txtNroProd.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btnMesa1_Click(sender As Object, e As EventArgs) Handles btnMesa1.Click
        Dim corteRot As New RoturaPulida
        corteRot.pulidora = mesa
        corteRot.ShowDialog()

        corteRot.Dispose()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        Dim lg As New MesasPulidoras
        lg.Show()
    End Sub
End Class