Imports Backend

Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        Dim lg As New login
        lg.Show()
    End Sub


    ' Mantenimiento Productos
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim prod As New ProductoForm
        prod.ShowDialog()
        prod.Dispose()
    End Sub

    ' Mantemientos Colores
    Private Sub ColoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColoresToolStripMenuItem.Click
        Dim color As New ColorForm
        color.ShowDialog()
        color.Dispose()

    End Sub

    'Mantenimiento tipo productos
    Private Sub TipoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoProductoToolStripMenuItem.Click
        Dim tipoP As New TipoProd
        tipoP.ShowDialog()
        tipoP.Dispose()
    End Sub

    ' Manteni miento tipo planchas
    Private Sub TipoPlanchaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoPlanchaToolStripMenuItem.Click
        Dim tipoPL As New TipoPlanchaForm
        tipoPL.ShowDialog()
        tipoPL.Dispose()
    End Sub

    ' Mantenimiento Usuarios
    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim usuarioF As New UsuarioForm
        usuarioF.ShowDialog()
        usuarioF.Dispose()
    End Sub

    ' Mantenimiento Espesores
    Private Sub EspesoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspesoresToolStripMenuItem.Click
        Dim espesoresF As New EspesoresForm
        espesoresF.ShowDialog()
        espesoresF.Dispose()
    End Sub

    'Mantenimiento Sucursales
    Private Sub SucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        Dim sucursalF As New SucursalForm
        sucursalF.ShowDialog()
        sucursalF.Dispose()
    End Sub

    ' Mantenimiento Depositos
    Private Sub DepósitosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepósitosToolStripMenuItem.Click
        Dim deposF As New DepositoForm
        deposF.ShowDialog()
        deposF.Dispose()
    End Sub

    ' Mantemiento Vendedores
    Private Sub VendedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendedoresToolStripMenuItem.Click
        Dim vendF As New VendedorForm
        vendF.ShowDialog()
        vendF.Dispose()
    End Sub
    'Mantemimiento tipo cliente
    Private Sub TipoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoClienteToolStripMenuItem.Click
        Dim tipoC As New TipoClienteForm
        tipoC.ShowDialog()
        tipoC.Dispose()
    End Sub
    'Mantenimiento Clientes
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim cliF As New ClienteForm
        cliF.ShowDialog()
        cliF.Dispose()
    End Sub
    'Mantenimiento Proveedores
    Private Sub ProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedorToolStripMenuItem.Click
        Dim provF As New ProveedorForm
        provF.ShowDialog()
        provF.Dispose()
    End Sub
    'Mantenimiento Bancos
    Private Sub BancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancosToolStripMenuItem.Click
        Dim bancF As New BancoForm
        bancF.ShowDialog()
        bancF.Dispose()
    End Sub

    ' Inform de ventas
    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Dim infV As New ReporteDeCobrosForm

        infV.ShowDialog()
        infV.Dispose()
    End Sub
    'Ventas
    Private Sub VentasTS_Click(sender As Object, e As EventArgs) Handles VentasTS.Click

    End Sub

    'Compras
    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Dim cliC As New CompraForm
        cliC.ShowDialog()
        cliC.Dispose()
    End Sub
    ' Inform de compras
    Private Sub ComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem1.Click
        Dim infV As New ReporteCompra
        infV.ShowDialog()
        infV.Dispose()
    End Sub
    'Stock
    Private Sub StockTS_Click(sender As Object, e As EventArgs) Handles StockTS.Click

    End Sub
    'Mov. Interno
    Private Sub NuevoMovimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoMovimientoToolStripMenuItem.Click
        Dim infV As New MovInternoForm
        infV.ShowDialog()
        infV.Dispose()
    End Sub
    ' Listado Mov. Internos
    Private Sub ListadoMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoMovimientosToolStripMenuItem.Click
        Dim infV As New ListadoMovimientosForm
        infV.ShowDialog()
        infV.Dispose()
    End Sub
    ' Pagos
    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click
        Dim pagoForm As New PagoForm
        pagoForm.ShowDialog()
        pagoForm.Dispose()
    End Sub

    ' cambio $
    Private Sub CambioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioToolStripMenuItem.Click
        Dim cambioForm As New CambioForm
        cambioForm.ShowDialog()
        cambioForm.Dispose()
    End Sub

    Private Sub ReposicionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReposicionTS.Click
        Dim repof As New ReposicionesForm
        repof.ShowDialog()
        repof.Dispose()
    End Sub
    Private Sub CajaDelDíaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CajaDelDíaToolStripMenuItem.Click
        Dim caja As New CajaDiariaForm
        caja.ShowDialog()
        caja.Dispose()

    End Sub

    Private Sub CorteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorteToolStripMenuItem.Click
        Dim corte As New SeleccionMesaCorte
        corte.ShowDialog()
        Dim m = corte.mesacortes
        corte.Dispose()
        If m = 1 Then
            Dim nuevocorte As New CorteForm
            nuevocorte.mesa = 1
            nuevocorte.ShowDialog()
            nuevocorte.Dispose()
        ElseIf m = 2 Then
            Dim nuevocorte As New CorteForm
            nuevocorte.mesa = 2
            nuevocorte.ShowDialog()
            nuevocorte.Dispose()
        End If

    End Sub

    Private Sub PulidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PulidaToolStripMenuItem.Click
        Dim pulida As New SeleccionMesaPulida
        pulida.ShowDialog()
        Dim m = pulida.pulidora
        pulida.Dispose()
        If m = 1 Then
            Dim nuevapulida As New PulidaForm
            nuevapulida.mesa = 1
            nuevapulida.ShowDialog()
            nuevapulida.Dispose()
        ElseIf m = 2 Then
            Dim nuevapulida As New PulidaForm
            nuevapulida.mesa = 2
            nuevapulida.ShowDialog()
            nuevapulida.Dispose()
        ElseIf m = 3 Then
            Dim nuevapulida As New PulidaForm
            nuevapulida.mesa = 3
            nuevapulida.ShowDialog()
            nuevapulida.Dispose()
        End If
    End Sub
    Private Sub Inicio_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        MenuStrip1.Renderer = New ToolStripProfessionalRenderer(New ColoresMenu())
        aplicarNivel()
        Me.ResumeLayout()
    End Sub

    Private Sub aplicarNivel()
        Try
            Dim acc As New Acceso
            Dim r = acc.seguridad()
            If r = 2 Then
                manteTS.Enabled = False
                ComprasToolStripMenuItem.Enabled = False
                CobrosTS.Enabled = False
                ComprasToolStripMenuItem.Enabled = False
                AnularFacturaComentario.Enabled = False
                MovInternoToolStripMenuItem.Enabled = False
                StockTS.Enabled = False
                ReposicionTS.Enabled = False
                InformesTS.Enabled = False
                ProduccionTS.Enabled = False
                PedInternoTS.Enabled = False
            ElseIf r = 3 Then
                manteTS.Enabled = False
                ComprasToolStripMenuItem.Enabled = False
                CobrosTS.Enabled = True
                ComprasToolStripMenuItem.Enabled = False
                AnularFacturaComentario.Enabled = False
                MovInternoToolStripMenuItem.Enabled = False
                StockTS.Enabled = False
                ReposicionTS.Enabled = False
                InformesTS.Enabled = False
                ProduccionTS.Enabled = False
                PedInternoTS.Enabled = False

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub manteTS_DropDownOpened(sender As Object, e As EventArgs) Handles manteTS.DropDownOpened
        Dim ob = DirectCast(sender, ToolStripMenuItem)
        ob.ForeColor = Color.Black

    End Sub

    Private Sub manteTS_DropDownClosed(sender As Object, e As EventArgs) Handles manteTS.DropDownClosed
        Dim ob = DirectCast(sender, ToolStripMenuItem)
        ob.ForeColor = Color.White
    End Sub

    Private Sub PruebaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpedicionTS.Click
        Dim exp As New ExpedicionForm
        exp.ShowDialog()
        exp.Dispose()
    End Sub

    Private Sub ImageneToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ImagesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim pr As New PruebaImagens
        pr.ShowDialog()
        pr.Dispose()
    End Sub

    Private Sub MarcadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcadoToolStripMenuItem.Click
        Dim marc As New MarcadoForm
        marc.ShowDialog()
        marc.Dispose()
    End Sub

    Private Sub TempladoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TempladoToolStripMenuItem.Click
        Dim pulida As New SeleccionTemplado
        Dim res = pulida.ShowDialog()
        Dim m = pulida.templado
        pulida.Dispose()
        If m = 1 Then
            Dim nuevoTemp As New TempladoForm
            nuevoTemp.templado = 1
            nuevoTemp.ShowDialog()
            nuevoTemp.Dispose()
        ElseIf m = 2 Then
            Dim nuevoTemp As New TempladoForm
            nuevoTemp.templado = 2
            nuevoTemp.ShowDialog()
            nuevoTemp.Dispose()
        End If
    End Sub

    Private Sub ProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProducciónToolStripMenuItem.Click
        Dim inf As New InformesProduccion
        inf.ShowDialog()
        inf.Dispose()

    End Sub

    Private Sub AutorizaciónMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorizaciónMovimientosToolStripMenuItem.Click
        Dim auto As New ConfirmarMIForm
        auto.ShowDialog()
        auto.Dispose()
    End Sub

    Private Sub ExpediciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpediciónToolStripMenuItem.Click
        Dim exp As New ExpedicionForm
        exp.ShowDialog()
        exp.Dispose()
    End Sub

    Private Sub InformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeToolStripMenuItem.Click
        Dim infV As New ReporteDeCobrosForm

        infV.ShowDialog()
        infV.Dispose()
    End Sub

    Private Sub InformesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformesToolStripMenuItem.Click
        Dim inf As New InformesProduccion
        inf.ShowDialog()
        inf.Dispose()
    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        Dim infV As New StockForm
        infV.ShowDialog()
        infV.Dispose()
    End Sub

    Private Sub InformeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InformeToolStripMenuItem1.Click
        Dim reporte As New ReporteStockForm
        reporte.ShowDialog()
        reporte.Dispose()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PedInternoTS.Click
        Dim ped As New PedidoInternoGeneral
        ped.ShowDialog()
        ped.Dispose()
    End Sub

    Private Sub SaldoClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldoClientesToolStripMenuItem.Click
        Dim rep As New ReporteVentasClienteForm
        rep.ShowDialog()
        rep.Dispose()
    End Sub

    Private Sub VentasTipoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasTipoProductoToolStripMenuItem.Click
        Dim rep As New ReporteVentasPorProducto
        rep.ShowDialog()
        rep.Dispose()
    End Sub

    Private Sub PagosVendedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosVendedoresToolStripMenuItem.Click
        Dim rep As New ReporteVentasVendedores
        rep.ShowDialog()
        rep.Dispose()
    End Sub

    Private Sub CobrosTipoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobrosTipoProductoToolStripMenuItem.Click
        Dim rep As New ReporteCobrosPorProducto
        rep.ShowDialog()
        rep.Dispose()
    End Sub

    Private Sub PorMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorMesToolStripMenuItem.Click
        Dim rp As New StockPorMesForm
        rp.ShowDialog()
        rp.Dispose()
    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaVentaToolStripMenuItem.Click
        Dim cliV As New VentasForm
        cliV.ShowDialog()
        cliV.Dispose()
    End Sub

    Private Sub AnularFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles c.Click
        Dim cliV As New AnularFacturaForm
        cliV.ShowDialog()
        cliV.Dispose()
    End Sub

    Private Sub ReposicionesTempladoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReposicionesTempladoToolStripMenuItem.Click
        Dim rep As New InformeReposiciones2
        rep.ShowDialog()
        rep.Dispose()

    End Sub

    Private Sub SaldoClienteProduccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldoClienteProduccionToolStripMenuItem.Click
        Dim f As New SaldoPorClienteProduccionForm
        f.ShowDialog()
        f.Dispose()

    End Sub

    Private Sub Mesa1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Mesa1ToolStripMenuItem.Click
        Dim f As New MesaCorteInformeForm
        f.mesa = 1
        f.ShowDialog()
        f.Dispose()

    End Sub

    Private Sub Mesa2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Mesa2ToolStripMenuItem.Click
        Dim f As New MesaCorteInformeForm
        f.mesa = 2
        f.ShowDialog()
        f.Dispose()

    End Sub

    Private Sub Pulidora1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pulidora1ToolStripMenuItem.Click
        Dim f As New PulidoraInformeForm

        f.pulidora = 1
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub Pulidora2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pulidora2ToolStripMenuItem.Click
        Dim f As New PulidoraInformeForm

        f.pulidora = 2
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub Pulidora3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pulidora3ToolStripMenuItem.Click
        Dim f As New PulidoraInformeForm

        f.pulidora = 3
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub DescuentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescuentosToolStripMenuItem.Click
        Dim f As New DescuentoPorFacturaForm
        f.ShowDialog()
        f.Dispose()

    End Sub

    Private Sub SalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasToolStripMenuItem.Click
        Dim f As New StockPorDiaForm
        f.ShowDialog()
        f.Dispose()

    End Sub
End Class