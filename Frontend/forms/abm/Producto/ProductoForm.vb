Imports Backend

Public Class ProductoForm

    'Carga del formulario
    Private Sub ProductoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarProductos()
            cargarColores()
            cargarTipos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'Carga de productos de la db
    Private Sub cargarProductos()
        Me.SuspendLayout()
        Dim daoP As New ProductoDAO
        Dim ds = daoP.getProductos()
        dgvProductos.DataSource = ""
        dgvProductos.DataSource = ds.Tables("tabla")
        'dgvColores.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvProductos.ClearSelection()
        Me.SuspendLayout()
    End Sub

    'Carga de colores desde la BD
    Private Sub cargarColores()
        Dim daoC As New ColorDAO
        Dim colores = daoC.getColores()
        Dim listColores = colores.Tables("tabla")
        Dim rowV = listColores.NewRow()
        rowV("Color") = "-- Seleccione Color -- "
        rowV("ID") = 0
        listColores.Rows.InsertAt(rowV, 0)

        cbColores.DataSource = listColores.Copy
        cbColores.DisplayMember = "Color"
        cbColores.ValueMember = "ID"
    End Sub

    ' Carga de tipos desde la BD
    Private Sub cargarTipos()
        Dim daoT As New TipoProdDAO
        Dim tipos = daoT.getTipos()
        Dim listTipos = tipos.Tables("tabla")
        Dim rowV = listTipos.NewRow()
        rowV("Tipo") = "-- Seleccione Tipo -- "
        rowV("ID") = 0
        listTipos.Rows.InsertAt(rowV, 0)

        cbTipos.DataSource = listTipos.Copy
        cbTipos.DisplayMember = "Tipo"
        cbTipos.ValueMember = "ID"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        activarCampos()
    End Sub

    Private Sub limpiarCampos()
        txtAlto.Text = ""
        txtAncho.Text = ""
        txtBusqueda.Text = ""
        txtCodigo.Text = ""
        txtDesc.Text = ""
        txtPA.Text = ""
        txtPB.Text = ""
        txtPC.Text = ""
        txtPD.Text = ""
        txtSM.Text = ""
        txtSuperficie.Text = ""
    End Sub

    Private Sub activarCampos()

    End Sub
End Class