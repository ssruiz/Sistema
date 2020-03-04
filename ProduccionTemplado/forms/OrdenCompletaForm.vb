Imports Backend

Public Class OrdenCompletaForm
    Private Sub txtNroProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True


            If txtNroProd.Text <> "" Then
                txtNroProdHasta.Focus()
            End If
        End If
    End Sub

    Private Sub txtNroProdHata_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroProdHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnConfirmar.PerformClick()

        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If txtNroProdHasta.Text = "" Then
            txtNroProdHasta.Text = txtNroProd.Text
        ElseIf CInt(txtNroProdHasta.Text) < CInt(txtNroProd.Text) Then
            MsgBox("Verifique los números de producción. Hasta debe ser mayor a desde", MsgBoxStyle.Critical, "Error parámetros")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("Produccion: " + txtNroProd.Text + "--" + txtNroProdHasta.Text + "¿Confirmar orden completa?", "Templado", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
                Dim prodDao As New ProduccionDAO
                If txtNroProd.Text <> "" Then
                    'Dim producc = prodDao.getProduccion(txtNroProd.Text, txtNroProdHata.Text)


                    ' Guardar Corte
                    prodDao.completarOrden(txtNroProd.Text, txtNroProdHasta.Text)
                    Me.DialogResult = DialogResult.OK

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub OrdenCompletaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNroProd.Focus()
    End Sub
End Class