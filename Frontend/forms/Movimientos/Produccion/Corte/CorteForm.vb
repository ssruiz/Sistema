Imports Backend

Public Class CorteForm
    Dim producc As New CargaProduccion
    Dim productoP As New Producto
    Public mesa As Integer
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CorteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCortes.DataSource = New DataSetProduccion.CorteDataTable
        txtMesaCorte.Text = "MESA DE CORTE " + mesa.ToString
        Dim prod As New ProduccionDAO
        lblCortes.Text = prod.getCortesDia()
        lblRoturas.Text = prod.getCortesRoturaDia()
    End Sub

    Private Sub txtNroProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim prodDao As New ProduccionDAO
            If txtNroProd.Text <> "" Then
                producc = prodDao.getProduccion(txtNroProd.Text)

                If producc.idProd <> 0 Then
                    ' Guardar Corte
                    prodDao.guardarCorte(producc.idProd, mesa, 0)
                    'MsgBox("Corte Guardado", MsgBoxStyle.Information, "Corte")
                    dgvCortes.DataSource = prodDao.getCorte(producc.idProd).Tables("tabla")
                    lblCortes.Text = prodDao.getCortesDia()
                    lblRoturas.Text = prodDao.getCortesRoturaDia()
                    txtNroProd.Text = ""
                    txtNroProd.Focus()
                End If
            End If

        End If
    End Sub

    Private Sub btnMesa1_Click(sender As Object, e As EventArgs) Handles btnMesa1.Click
        Dim corteRot As New CorteRotura
        corteRot.mesa = mesa
        corteRot.ShowDialog()
        Dim prodDao As New ProduccionDAO
        lblCortes.Text = prodDao.getCortesDia()
        lblRoturas.Text = prodDao.getCortesRoturaDia()
        corteRot.Dispose()
    End Sub
End Class