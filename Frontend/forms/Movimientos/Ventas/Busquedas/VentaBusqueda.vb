Imports Backend

Public Class VentaBusqueda
    Public codigoCliente As String
    Public estadoFiltro As String
    Dim list As New DataSet
    Public ventaSel = 0
    Public venta As String
    Public inicial = 0
    Dim clienteBusqueda As New Cliente


    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles tabControlPago.DrawItem

        'Firstly we'll define some parameters.
        Dim CurrentTab As TabPage = tabControlPago.TabPages(e.Index)
        Dim ItemRect As Rectangle = tabControlPago.GetTabRect(e.Index)
        Dim FillBrush As New SolidBrush(Color.FromArgb(146, 43, 18))
        Dim TextBrush As New SolidBrush(Color.White)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        'If we are currently painting the Selected TabItem we'll 
        'change the brush colors and inflate the rectangle.
        If CBool(e.State And DrawItemState.Selected) Then
            FillBrush.Color = Color.FromArgb(217, 60, 0)

            TextBrush.Color = Color.White
            ItemRect.Inflate(2, 2)
        End If

        'Set up rotation for left and right aligned tabs
        If tabControlPago.Alignment = TabAlignment.Left Or tabControlPago.Alignment = TabAlignment.Right Then
            Dim RotateAngle As Single = 90
            If tabControlPago.Alignment = TabAlignment.Left Then RotateAngle = 270
            Dim cp As New PointF(ItemRect.Left + (ItemRect.Width \ 2), ItemRect.Top + (ItemRect.Height \ 2))
            e.Graphics.TranslateTransform(cp.X, cp.Y)
            e.Graphics.RotateTransform(RotateAngle)
            ItemRect = New Rectangle(-(ItemRect.Height \ 2), -(ItemRect.Width \ 2), ItemRect.Height, ItemRect.Width)
        End If

        'Next we'll paint the TabItem with our Fill Brush
        e.Graphics.FillRectangle(FillBrush, ItemRect)

        'Now draw the text.
        e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, RectangleF.op_Implicit(ItemRect), sf)

        'Reset any Graphics rotation
        e.Graphics.ResetTransform()

        'Finally, we should Dispose of our brushes.
        FillBrush.Dispose()
        TextBrush.Dispose()

        Dim fb As New SolidBrush(Color.FromArgb(26, 51, 92)) 'Me.BackColor)
        Dim LastTabRect As Rectangle = tabControlPago.GetTabRect(tabControlPago.TabPages.Count - 1)
        Dim Rect As Rectangle

        Rect.Location = New Point(LastTabRect.Right + tabControlPago.Left, tabControlPago.Top)
        Rect.Size = New Size(tabControlPago.Right - Rect.Left, LastTabRect.Height)
        e.Graphics.FillRectangle(fb, Rect)

        fb.Dispose()

        'Label2.Text = "rect location = " & Rect.X & ", " & Rect.Y & ", Size = " & Rect.Width & ", " & Rect.Height
    End Sub


    'BUSQUEDA POR FECHA
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim daov As New VentaDAO

            Dim r = daov.getVentasFecha(dpickerDesdeFP.Value.ToString("yyyy-MM-dd"), dpHastaFP.Value.ToString("yyyy-MM-dd"))
            dgvVentasPorFecha.DataSource = r.Tables("tabla")
            dgvVentasPorFecha.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvVentasPorFecha_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVentasPorFecha.SelectionChanged
        If dgvVentasPorFecha.Focused And dgvVentasPorFecha.SelectedRows.Count > 0 Then
            Try

                Dim row = dgvVentasPorFecha.CurrentRow
                Dim codigo = row.Cells(1).Value

                Dim daoP As New VentaDAO
                Dim producto = daoP.getDetalleBusquedaVentas(codigo)
                dgvProductosPorFecha.DataSource = producto.Tables("tabla")
                dgvProductosPorFecha.ClearSelection()

                dgvProductosPorFecha.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvProductosPorFecha.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvProductosPorFecha.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvProductosPorFecha.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvProductosPorFecha.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvProductosPorFecha.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvProductosPorFecha.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub dgvVentasPorFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvVentasPorFecha.KeyDown, dgvVentasPorCliente.KeyDown
        Try
            If sender.SelectedRows.Count > 0 Then
                If e.KeyCode = Keys.Enter Then
                    e.SuppressKeyPress = True
                    Dim row = sender.CurrentRow
                    Dim codigo = row.Cells(1).Value
                    ventaSel = codigo
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    '' BUSQUEDA POR CLIENTES
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusquedaPorCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim buscarC As New ClienteBusqueda
            Dim res = buscarC.ShowDialog()

            If res = DialogResult.OK Then
                clienteBusqueda = buscarC.cliente
                Dim daov As New VentaDAO
                list = daov.getVentasCliente(clienteBusqueda.id)
                dgvVentasPorCliente.DataSource = list.Tables("tabla")
                dgvVentasPorCliente.ClearSelection()
                If dgvVentasPorCliente.Rows.Count > 0 Then
                    dgvVentasPorCliente.Rows(0).Selected = True
                    dgvVentasPorCliente.Focus()
                End If

            End If
                buscarC.Dispose()
        End If
    End Sub

    Private Sub dgvVentasPorCliente_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVentasPorCliente.SelectionChanged
        If dgvVentasPorCliente.Focused And dgvVentasPorCliente.SelectedRows.Count > 0 Then
            Try

                Dim row = dgvVentasPorCliente.CurrentRow
                Dim codigo = row.Cells(1).Value

                Dim daoP As New VentaDAO
                Dim producto = daoP.getDetalleBusquedaVentas(codigo)
                dgvDetalleVentaCliente.DataSource = producto.Tables("tabla")
                dgvDetalleVentaCliente.ClearSelection()

                dgvDetalleVentaCliente.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalleVentaCliente.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalleVentaCliente.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalleVentaCliente.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalleVentaCliente.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalleVentaCliente.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetalleVentaCliente.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub tabControlPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControlPago.SelectedIndexChanged
        If tabControlPago.SelectedIndex = 1 Then
            txtBusquedaPorCliente.Focus()
        End If
    End Sub

    Private Sub VentaBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        tabControlPago.SelectedIndex = inicial
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim daov As New VentaDAO
            Dim dv As New DataView(list.Tables("tabla"))
            dv.RowFilter = String.Format("Fecha >= '{0}' and Fecha <= '{1}' ", dpdesde2.Value.ToString("yyyy-MM-dd"), dphasta2.Value.ToString("yyyy-MM-dd"))
            dgvVentasPorCliente.DataSource = dv
            dgvVentasPorCliente.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class