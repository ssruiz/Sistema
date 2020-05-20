Imports Backend

Public Class StockPorMesForm
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim mesSeleccionado As String = cbMes.SelectedValue
        ' MsgBox(cbDepo.SelectedValue)
        Dim hasta As String
        Dim mes As String
        Dim ds As New DataSet
        Dim mes2 As String
        Dim dt As New DataTable
        ' Dim sql As String
        Dim filtro As String
        'If cbTipo.SelectedValue = 0 Then
        '    sql = ""
        'ElseIf cbTipo.text = "herrajes" Then
        '    filtro = cbTipo.SelectedValue.ToString

        'ElseIf cbTipo.text = "planchas" Then
        '    filtro = cbTipo.SelectedValue.ToString

        'Else
        '    filtro = cbTipo.SelectedValue.ToString
        'End If

        If mesSeleccionado = "01" Or mesSeleccionado = "03" Or mesSeleccionado = "05" Or mesSeleccionado = "07" Or mesSeleccionado = "08" Or mesSeleccionado = "10" Or mesSeleccionado = "12" Then
            mes = "" & lblAnho.Text & "-" & mesSeleccionado & "-01 00:00:00"
            hasta = "" & lblAnho.Text & "-" & mesSeleccionado & "-31 23:59:59"
            mes2 = cbMes.Text
        Else
            If mesSeleccionado = "02" Then
                mes = "" & lblAnho.Text & "-" & mesSeleccionado & "-01 00:00:00"
                hasta = "" & lblAnho.Text & "-" & mesSeleccionado & "-28 23:59:59"
                mes2 = cbMes.Text
            Else
                mes = "" & lblAnho.Text & "-" & mesSeleccionado & "-01 00:00:00"
                hasta = "" & lblAnho.Text & "-" & mesSeleccionado & "-30 23:59:59"
                mes2 = cbMes.Text

            End If
        End If


        filtro = cbTipo.SelectedValue.ToString


        Dim sucursalt = cbDepo.Text
        Dim daosuc As New SucursalDAO
        Dim suc = daosuc.getSucursalNombre(sucursalt)

        Dim rep As New CRStockPorMes
        Dim daou As New SesionDAO
        rep.SetParameterValue("desde", mes)
        rep.SetParameterValue("hasta", hasta)
        rep.SetParameterValue("suc", suc.id)
        rep.SetParameterValue("depo", cbDepo.SelectedValue)
        rep.SetParameterValue("mes", mes2)
        rep.SetParameterValue("filtro", filtro)

        rep.SetParameterValue("usuario", daou.getUsuario())

        ReporteVentasView.ReportSource = rep
    End Sub

    Private Sub StockPorMesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        Dim dtmDate As Date
        dtmDate = Date.Now()
        lblAnho.Text = dtmDate.ToString("yyyy")
        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("01", "Enero")
        comboSource.Add("02", "Febrero")
        comboSource.Add("03", "Marzo")
        comboSource.Add("04", "Abril")
        comboSource.Add("05", "Mayo")
        comboSource.Add("06", "Junio")
        comboSource.Add("07", "Julio")
        comboSource.Add("08", "Agosto")
        comboSource.Add("09", "Septiembre")
        comboSource.Add("10", "Octubre")
        comboSource.Add("11", "Noviembre")
        comboSource.Add("12", "Diciembre")
        cbMes.DataSource = New BindingSource(comboSource, Nothing)
        cbMes.DisplayMember = "Value"
        cbMes.ValueMember = "Key"

        Dim comboSource2 As New Dictionary(Of String, String)()
        comboSource2.Add("Todos", "Todos")
        comboSource2.Add("Perfiles", "Perfiles")
        comboSource2.Add("Herrajes", "Herrajes")

        comboSource2.Add("Planchas", "Planchas")
        cbTipo.DataSource = New BindingSource(comboSource2, Nothing)
        cbTipo.DisplayMember = "Value"
        cbTipo.ValueMember = "Key"

        cargarColores()
        cargarTipos()
    End Sub

    Private Sub cargarColores()
        Dim daoC As New SucursalDAO
        Dim colores = daoC.getSucursales2()
        Dim listColores = colores.Tables("tabla")

        cbDepo.DataSource = listColores
        cbDepo.DisplayMember = "sucDesc"
        cbDepo.ValueMember = "depoCod"
    End Sub

    Private Sub cargarTipos()
        Dim daoC As New TipoProdDAO
        Dim colores = daoC.getTipos()
        Dim listColores = colores.Tables("tabla")
        Dim rowV = listColores.NewRow()
        rowV("Tipo") = "Todos"
        rowV("ID") = 0
        listColores.Rows.InsertAt(rowV, 0)

        cbTipo.DataSource = listColores.Copy
        cbTipo.DisplayMember = "Tipo"
        cbTipo.ValueMember = "ID"
    End Sub
End Class