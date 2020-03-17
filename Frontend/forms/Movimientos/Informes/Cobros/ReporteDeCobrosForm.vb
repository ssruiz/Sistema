Imports Backend
Imports CrystalDecisions.Shared

Public Class ReporteDeCobrosForm
    Dim diccionarioMontos As New Dictionary(Of Integer, Double)
    Dim diccionarioMontosSinCC As New Dictionary(Of Integer, Double)
    Dim totalFacturas = 0
    Dim totalPagado = 0
    Dim totalPagado2 = 0
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            diccionarioMontos = New Dictionary(Of Integer, Double)
            diccionarioMontosSinCC = New Dictionary(Of Integer, Double)
            totalFacturas = 0
            totalPagado = 0
            totalPagado2 = 0
            Dim objreporte As New CobrosReporte2
            Dim daoc As New CobrosDAO
            Dim pagos = daoc.getCobros(dpInicio.Value, dpFin.Value)

            Dim nuevosDatos = arreglarTabla(pagos.Tables("tabla").Copy)

            For Each pair As KeyValuePair(Of Integer, Double) In diccionarioMontos
                totalPagado += pair.Value
            Next

            For Each pair As KeyValuePair(Of Integer, Double) In diccionarioMontosSinCC
                totalPagado2 += pair.Value
            Next
            objreporte.Subreports("Cobros").SetDataSource(nuevosDatos)
            objreporte.SetParameterValue("inicio", dpInicio.Value)
            objreporte.SetParameterValue("fin", dpFin.Value)

            objreporte.SetParameterValue("TotalDeTotalPagado", totalPagado2)
            objreporte.SetParameterValue("TotalFacturaSumaRpt", totalFacturas)
            objreporte.SetParameterValue("fechaInicio", dpInicio.Value.ToShortDateString)
            objreporte.SetParameterValue("fechaFin", dpFin.Value.ToShortDateString)
            objreporte.SetParameterValue("inicioR", dpInicio.Value)
            objreporte.SetParameterValue("finR", dpFin.Value)

            objreporte.SetParameterValue("inicioA", dpInicio.Value)
            objreporte.SetParameterValue("finA", dpFin.Value)

            ' objreporte.SetParameterValue("inicioanu", dpInicio.Value)
            'objreporte.SetParameterValue("finanu", dpFin.Value)

            objreporte.SetParameterValue("inicioCh", dpInicio.Value)
            objreporte.SetParameterValue("finCh", dpInicio.Value)

            Dim daou As New SesionDAO
            objreporte.SetParameterValue("estado", "")
            objreporte.SetParameterValue("unidad", 0)
            objreporte.SetParameterValue("tipov", "")
            objreporte.SetParameterValue("Usuario", daou.getUsuario())
            'objreporte.SetDatabaseLogon("samuel", "system", "localhost", "producir")


            'objreporte.Subreports("HeaderRpt.rpt").SetDataSource(HeaderDT)
            rptvCobros.ReportSource = objreporte

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function arreglarTabla(ByVal dataT As DataTable) As DataTable
        ' Dim dataT = dgvP.DataSource
        For Each row As DataRow In dataT.Rows
            Dim ventaC = CInt(row("VentaCod").ToString)
            Dim MontoPagatoTotal As Double
            Dim gs As Double
            Dim cheque As Double
            Dim tc As Double
            Dim td As Double
            Dim boleta As Double
            ' obtencion de montos
            Double.TryParse(row("Gs").ToString, gs)
            Double.TryParse(row("GsCheque").ToString, cheque)
            Double.TryParse(row("TC").ToString, tc)
            Double.TryParse(row("TD").ToString, td)
            Double.TryParse(row("Boleta").ToString, boleta)

            Dim suma = gs + cheque + tc + td + boleta

            Double.TryParse(row("MontoPagado").ToString, MontoPagatoTotal)


            Dim pValue As Double = 0



            If diccionarioMontos.TryGetValue(ventaC, pValue) Then
                'If ventaC = 2249 Then
                '    MsgBox("Ya ingrese al diccionario")
                '    Console.WriteLine("OT > " + ventaC.ToString + " suma>" + suma.ToString + " tipo> " + row("TipoPagoFinal").ToString)
                'End If
                'MsgBox("Venta " + ventaC.ToString + " ya existe")
                row("MontoPagado") = suma + pValue
                row("TotalPagado") = suma + pValue

                diccionarioMontos(ventaC) += suma
                Dim tipo = row("TipoPagoFinal").ToString
                Dim aux2 = 0
                Dim aux = 0
                Double.TryParse(row("TotalFactura").ToString, aux)
                If tipo <> "Credito Cobrado" Then
                    If diccionarioMontosSinCC.TryGetValue(ventaC, aux2) Then

                        diccionarioMontosSinCC(ventaC) += suma + pValue
                    Else

                        diccionarioMontosSinCC.Add(ventaC, suma + pValue)
                    End If
                    totalFacturas += aux
                End If

            Else

                'If ventaC = 2249 Then
                '    MsgBox("Vpy a entrar al diccionario")
                '    Console.WriteLine("OT > " + ventaC.ToString + " suma>" + suma.ToString + " tipo> " + row("TipoPagoFinal").ToString)
                'End If
                suma += MontoPagatoTotal
                row("TotalPagado") = suma
                diccionarioMontos.Add(ventaC, suma)
                Dim aux = 0
                Double.TryParse(row("TotalFactura").ToString, aux)
                Dim tipo = row("TipoPagoFinal").ToString
                Dim aux2 = 0
                If tipo <> "Credito Cobrado" Then
                    If diccionarioMontosSinCC.TryGetValue(ventaC, aux2) Then

                        diccionarioMontosSinCC(ventaC) += suma
                    Else
                        'If ventaC = 2249 Then
                        '    MsgBox("entre aqui 2")
                        'End If
                        diccionarioMontosSinCC.Add(ventaC, suma)
                    End If
                    totalFacturas += aux
                End If

            End If
        Next row
        Return dataT
    End Function

    Private Sub ReporteDeCobrosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = (Me.ClientSize.Width / 2) - (lblTitulo.Width / 2)
        'configureCrystalReports()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    'Private Sub configureCrystalReports()
    '    Try
    '        Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
    '        myConnectionInfo.ServerName = "consis"
    '        myConnectionInfo.DatabaseName = "producir "
    '        myConnectionInfo.UserID = "samuel"
    '        myConnectionInfo.Password = "system"
    '        myConnectionInfo.Type = ConnectionInfoType.Query 'Importante agregar este Type 
    '        myConnectionInfo.IntegratedSecurity = False
    '        setDBLOGONforREPORT(myConnectionInfo)
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub setDBLOGONforREPORT(ByVal myconnectioninfo As ConnectionInfo)
    '    Dim mytableloginfos As New TableLogOnInfos()
    '    mytableloginfos = ReporteVentasView .LogOnInfo
    '    For Each myTableLogOnInfo As TableLogOnInfo In mytableloginfos
    '        myTableLogOnInfo.ConnectionInfo = myconnectioninfo
    '    Next
    'End Sub

End Class