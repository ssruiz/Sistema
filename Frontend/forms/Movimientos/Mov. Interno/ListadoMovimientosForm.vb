﻿Imports Backend

Public Class ListadoMovimientosForm
    Dim sucursales As DataSet
    Dim listado As DataSet
    Dim mi As New MInterno
    Dim sucursal As Sucursal
    Dim origen As Sucursal
    Dim destino As Sucursal
    Dim depoOrigen As Deposito
    Dim depoDestino As Deposito
    Dim fechaInicio As Date
    Dim fechaFin As Date
    Private Sub ListadoMovimientosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarSucursales()
    End Sub

    Private Sub cargarSucursales()
        Try
            Dim daoS As New SucursalDAO
            sucursales = daoS.getSucursalesCB()
            Dim lista = sucursales.Tables("tabla").Copy

            Dim lista2 = sucursales.Tables("tabla").Copy()
            Dim rowSol = lista.NewRow
            Dim rowDest = lista2.NewRow
            rowSol("Nombre") = "-- Seleccione Sucursal -- "
            rowSol("ID") = 0
            rowDest("Nombre") = "-- Seleccione Sucursal -- "
            rowDest("ID") = 0
            lista.Rows.InsertAt(rowSol, 0)
            lista2.Rows.InsertAt(rowDest, 0)
            cbS1.DataSource = lista
            cbS1.DisplayMember = "Nombre"
            cbS1.ValueMember = "ID"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbS1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbS1.SelectedIndexChanged
        If cbS1.SelectedIndex <> 0 Then
            cargarMovimientos(cbS1.SelectedValue)
            limpiarDatos()
            sucursal = New Sucursal
            sucursal.id = cbS1.SelectedValue
            sucursal.nombre = cbS1.SelectedItem("Nombre")
        End If
    End Sub

    Private Sub limpiarDatos()
        txtAutorizado.Text = ""
        txtSO.Text = ""
        txtSD.Text = ""
        txtDO.Text = ""
        txtDD.Text = ""
        txtFecha.Text = ""
        txtSolicidato.Text = ""
        mi = New MInterno
    End Sub
    Private Sub cargarMovimientos(ByVal id As Integer)
        Try
            Dim daoM As New MovInternoDAO
            listado = daoM.getMovimientos(id)
            dgvMovimientos.DataSource = listado.Tables("tabla")
            dgvMovimientos.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvProductos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMovimientos.SelectionChanged
        If dgvMovimientos.Focused And dgvMovimientos.SelectedRows.Count > 0 Then
            Try
                btnDetalle.Enabled = True
                Dim row = dgvMovimientos.CurrentRow.Index
                Dim codigo = dgvMovimientos.Item(0, row).Value
                Dim daoP As New MovInternoDAO
                mi = daoP.getMI(codigo)
                cargarMovimiento()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub cargarMovimiento()
        Dim daoS As New SucursalDAO
        Dim daoP As New DepositoDAO
        destino = daoS.getSucursal(mi.sdestino)
        origen = daoS.getSucursal(mi.sorigen)
        depoDestino = daoP.getDeposito(mi.ddestino)
        depoOrigen = daoP.getDeposito(mi.dorigen)
        txtAutorizado.Text = mi.autorizador
        txtSO.Text = origen.nombre
        txtSD.Text = destino.nombre
        txtDO.Text = depoOrigen.nombre
        txtDD.Text = depoDestino.nombre
        txtFecha.Text = mi.fecha
        txtSolicidato.Text = mi.solicitante
    End Sub

    Private Sub chbRecibido_CheckedChanged(sender As Object, e As EventArgs) Handles chbRecibido.CheckedChanged
        aplicarFiltro()
    End Sub
    Private Sub chbEnviados_CheckedChanged(sender As Object, e As EventArgs) Handles chbEnviados.CheckedChanged
        aplicarFiltro()
    End Sub
    Private Sub aplicarFiltro()
        Try
            Dim dv As New DataView(listado.Tables("tabla"))
            If chbRecibido.Checked And chbEnviados.Checked Then
                dv.RowFilter = String.Format("SO = '{0}' or SD = '{0}' ", sucursal.id.ToString)
            ElseIf Not chbRecibido.Checked And chbEnviados.Checked Then
                dv.RowFilter = String.Format("SO = '{0}'", sucursal.id)
            ElseIf chbRecibido.Checked And Not chbEnviados.Checked Then
                dv.RowFilter = String.Format("SD = '{0}'", sucursal.id)
            End If
            dgvMovimientos.DataSource = dv
            dgvMovimientos.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        limpiarDatos()
    End Sub

    Private Sub dpInicio_ValueChanged(sender As Object, e As EventArgs) Handles dpInicio.ValueChanged
        lblDesdeF.Text = dpInicio.Value.ToShortDateString
        fechaInicio = dpInicio.Value.ToShortDateString
    End Sub

    Private Sub dpFin_ValueChanged(sender As Object, e As EventArgs) Handles dpFin.ValueChanged
        lblHastaF.Text = dpFin.Value.ToShortDateString
        fechaFin = dpFin.Value.ToShortDateString
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltro.Click
        lblDesdeF.Text = ""
        lblHastaF.Text = ""
        fechaInicio = Nothing
        fechaFin = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAplicarFiltro.Click
        Try
            If lblDesdeF.Text <> "" And lblHastaF.Text <> "" Then
                Dim dv As New DataView(listado.Tables("tabla"))
                dv.RowFilter = String.Format("Fecha >= '{0}' and Fecha <= '{1}'", fechaInicio, fechaFin)
                dgvMovimientos.DataSource = dv
                dgvMovimientos.ClearSelection()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        If mi.id <> 0 Then
            Dim detalle As New MovInternoDetalle
            detalle.mi = mi
            detalle.origen = origen
            detalle.destino = destino
            detalle.depoOrigen = depoOrigen
            detalle.depoDestino = depoDestino
            detalle.ShowDialog()
            detalle.Dispose()
        End If
    End Sub
End Class