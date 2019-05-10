Imports Backend

Public Class MovInternoDetalle
    Dim listado As DataSet
    Public mi As MInterno
    Public origen As Sucursal
    Public destino As Sucursal
    Public depoOrigen As Deposito
    Public depoDestino As Deposito
    Private Sub MovInternoDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarMovimiento()
        cargarDetalle()
    End Sub

    Private Sub cargarMovimiento()
        txtAutorizado.Text = mi.autorizador
        txtSO.Text = origen.nombre
        txtSD.Text = destino.nombre
        txtDO.Text = depoOrigen.nombre
        txtDD.Text = depoDestino.nombre
        txtFecha.Text = mi.fecha
        txtSolicidato.Text = mi.solicitante
    End Sub

    Private Sub cargarDetalle()
        Try
            Dim daoM As New MovInternoDAO
            listado = daoM.getDetalle(mi.id)
            dgvProductos.DataSource = listado.Tables("tabla")
            dgvProductos.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class