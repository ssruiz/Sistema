Imports MySql.Data.MySqlClient

Public Class ProduccionDAO
    Dim con As New MySqlConnection
    Public Function getProduccionDia() As Produccion
        Dim prod As New Produccion
        Try

            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * FROM `producciondia` WHERE `prodDiaFecha` = CURDATE(); "
            Dim cmd As New MySqlCommand(query, con)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                prod.id = SafeGetInt(reader, 0)
                prod.total = SafeGetDouble(reader, 1)
            End While

        Catch ex As Exception
        Finally
            con.Close()
        End Try
        Return prod
    End Function

    Public Function getProduccion(ByVal id As String) As CargaProduccion
        Dim ds As New CargaProduccion
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vproduccion where IDProd = @codigo"

            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                ds.idProd = SafeGetInt(reader, 0)
                ds.venta = SafeGetInt(reader, 1)
                ds.panho = SafeGetInt(reader, 2)
                ds.codProd = SafeGetInt(reader, 3)
                ds.cantidad = SafeGetInt(reader, 4)
                ds.ancho = SafeGetDouble(reader, 5)
                ds.alto = SafeGetDouble(reader, 6)
                ds.sup = SafeGetDouble(reader, 7)
                ds.cliente = SafeGetString(reader, 8)
                ds.opCod = SafeGetInt(reader, 9)
                ds.opDesc = SafeGetString(reader, 10)
                ds.cliCod = SafeGetInt(reader, 11)
                ds.fechaOt = SafeGetDate(reader, 12)
            End While
            reader.Close()
            Return ds
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function



    Public Function controlarEntradaTemplado(idProd As Integer) As Boolean
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim queryComp = "Select * from `producir`.`templado` where `pCod` = @prod"
            Dim cmdComp As New MySqlCommand(queryComp, con)
            cmdComp.Parameters.AddWithValue("@prod", idProd)
            Dim reader = cmdComp.ExecuteReader()
            Dim estado = ""
            If reader.Read Then
                estado = SafeGetString(reader, 5)
                reader.Close()
                If estado = "H" Then
                    MsgBox("Producción ya entró al horno.", MsgBoxStyle.Critical, "Templado")
                    Return False
                ElseIf estado = "T" Then
                    MsgBox("Producción ya terminada.", MsgBoxStyle.Critical, "Templado")
                    Return False
                End If

                Return True



            End If
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function

    Public Function controlarEntradaTemplado2(idProd As Integer) As Boolean
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim queryComp = "Select * from `producir`.`templado` where `pCod` = @prod"
            Dim cmdComp As New MySqlCommand(queryComp, con)
            cmdComp.Parameters.AddWithValue("@prod", idProd)
            Dim reader = cmdComp.ExecuteReader()
            Dim estado = ""
            If reader.Read Then
                estado = SafeGetString(reader, 5)
                reader.Close()
                If estado = "H" Then
                    Return True
                ElseIf estado = "T" Then
                    MsgBox("Producción ya terminada.", MsgBoxStyle.Critical, "Templado")
                    Return False
                End If


            End If
            Return False
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function

    ' En realidad actualiza la tabla corte para esa produccion
    Public Sub guardarCorte(ByVal idProd As String, ByVal mesa As Integer, ByVal rotura As Integer)
        Try

            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = ""
            If rotura = 0 Then
                mysql = "UPDATE `producir`.`corte` SET `corteMesa` = @mesa, `corteNroOpti` = IF(`corteNroOpti` IS NULL , 0 , `corteNroOpti`+1), `corteUsuUpd` = @user, `corteFchUpd` = @fecha, `corteEstado` = 'T' WHERE `pCod` = @prod;"
            Else
                mysql = "UPDATE `producir`.`corte` SET `corteMesa` = @mesa, `corteNroOpti` = IF(`corteNroOpti` IS NULL , 0 , `corteNroOpti`+1), `corteUsuUpd` = @user,`corteRotFecha` = @fecha, `corteFchUpd` = @fecha, `corteEstado` = 'R' WHERE `pCod` = @prod;"
            End If

            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@mesa", mesa)
            cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            cmd.Parameters.AddWithValue("@prod", idProd)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function getCorte(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vcorte where `Nro. Prod.` = " & id & " ;"
            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getTickets(ByVal inicio As String, ByVal fin As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "CALL reportetickets(@inicio,@fin)"
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@inicio", inicio)
            cmd.Parameters.AddWithValue("@fin", fin)

            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Sub guardarTemplados(rows As DataGridViewRowCollection, ByVal templado As Integer)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = ""
            If templado = 1 Then
                query = "UPDATE `producir`.`templado` SET `templaEntrada` = @entrada, `templaEstado` = 'H' , `templaUsrUpd` = @user, `templaFchUpd` = @fecha WHERE `pCod` = @prod;"
                Dim cmd As New MySqlCommand(query, con)
                For Each row As DataGridViewRow In rows
                    Dim entrada = row.Cells(5).Value
                    Dim user = Sesion.Usuario
                    Dim codigoProd = row.Cells(0).Value

                    cmd.Parameters.AddWithValue("@entrada", entrada)
                    cmd.Parameters.AddWithValue("@user", user)
                    cmd.Parameters.AddWithValue("@fecha", Date.Now)
                    cmd.Parameters.AddWithValue("@prod", codigoProd)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()

                Next

            Else

                query = "UPDATE `producir`.`templado` SET `templaSalida` = @salida, `templaEstado` = 'T' , `templaUsrUpd` = @user, `templaFchUpd` = @fecha WHERE `pCod` = @prod;"
                Dim cmd As New MySqlCommand(query, con)
                For Each row As DataGridViewRow In rows
                    Dim salida = row.Cells(6).Value
                    Dim user = Sesion.Usuario
                    Dim codigoProd = row.Cells(0).Value

                    cmd.Parameters.AddWithValue("@salida", salida)
                    cmd.Parameters.AddWithValue("@user", user)
                    cmd.Parameters.AddWithValue("@fecha", Date.Now)
                    cmd.Parameters.AddWithValue("@prod", codigoProd)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()

                Next

            End If

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub



    Public Function getPulida(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vpulida where `Nro. Prod.` = " & id & " ;"
            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Sub guardarPulida(ByVal idProd As String, ByVal pulidora As Integer, ByVal rotura As Integer)
        Try

            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = ""
            If rotura = 0 Then

                mysql = "UPDATE `producir`.`pulida` SET `pulidora` = @puli, `nroOpti` = IF(`nroOpti` IS NULL , 1 , `nroOpti`+1), `puliUsrUpd` = @user, `puliFchUpd` = @fecha, `puliEstado` = 'T' WHERE `pCod` = @prod;"
            Else
                mysql = "UPDATE `producir`.`pulida` SET `pulidora` = @puli, `nroOpti` = IF(`nroOpti` IS NULL , 1 , `nroOpti`+1), `puliUsrUpd` = @user, `puliRotFch` = @fecha, `puliFchUpd` = @fecha, `puliEstado` = 'R' WHERE `pCod` = @prod;"

            End If

            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@puli", pulidora)
            cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            cmd.Parameters.AddWithValue("@prod", idProd)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub guardarMarcado(ByVal idProd As String, ByVal rotura As Integer)
        Try

            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = ""
            If rotura = 0 Then

                mysql = "UPDATE `producir`.`marcado` SET `marcadoUsrUpd` = @user, `marcadoFchUpd` = @fecha, `marcadoEstado` = 'T' WHERE `pCod` = @prod;"
            Else
                mysql = "UPDATE `producir`.`marcado` SET `marcadoUsrUpd` = @user, `marcadoRotFch` = @fecha, `marcadoFchUpd` = @fecha, `marcadoEstado` = 'R' WHERE `pCod` = @prod;"

            End If

            Dim cmd As New MySqlCommand(mysql, con)

            cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            cmd.Parameters.AddWithValue("@prod", idProd)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function getMarcado(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vmarcado where `Nro. Prod.` = " & id & " ;"
            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function guardarTemplado(ByVal idProd As String, ByVal templado As Integer, ByVal rotura As Integer) As Integer
        Try

            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = ""
            If rotura = 0 Then
                If templado = 1 Then
                    mysql = "UPDATE `producir`.`templado` SET `templaEntrada` = @fecha, `templaEstado` = 'H' , `templaUsrUpd` = @user, `templaFchUpd` = @fecha WHERE `pCod` = @prod;"
                Else
                    Dim queryComp = "Select * from `producir`.`templado` where `pCod` = @prod and templaEstado = 'H'"
                    Dim cmdComp As New MySqlCommand(queryComp, con)
                    cmdComp.Parameters.AddWithValue("@prod", idProd)
                    Dim reader = cmdComp.ExecuteReader()

                    If reader.Read Then
                        reader.Close()
                        mysql = "UPDATE `producir`.`templado` SET `templaSalida` = @fecha, `templaEstado` = 'T' , `templaUsrUpd` = @user, `templaFchUpd` = @fecha WHERE `pCod` = @prod;"
                    Else
                        MsgBox("Producción aún no entro a horno.", MsgBoxStyle.Critical, "Templado")
                        mysql = ""
                        Return 0
                    End If

                End If

            Else
                mysql = "UPDATE `producir`.`templado` SET `templaRotura` = @fecha, `templaEstado` = 'R' , `templaUsrUpd` = @user, `templaFchUpd` = @fecha WHERE `pCod` = @prod;"

            End If


            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            cmd.Parameters.AddWithValue("@prod", idProd)
            cmd.ExecuteNonQuery()
            Return 1


        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function

    Public Function getTemplado(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vtemplado where `Nro. Prod.` = " & id & " ;"
            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    'VALIDACIONES
    Public Function validarCorteEstado(idProd As Integer) As Boolean
        Dim res = False
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT `corteEstado` FROM `producir`.`corte` where pCod = @id ;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", idProd)
            Dim reader = cmd.ExecuteReader
            If reader.Read Then
                Dim estado = safeGetChar(reader, 0)
                If estado = "T" Then
                    MsgBox("Produccion ya pasó por corte")
                    res = False
                Else
                    res = True
                End If

            End If

            reader.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return res
    End Function

    Public Function validarCorte(ByVal idP As Integer) As Boolean
        Dim res = False
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT `corteCod` FROM `producir`.`corte` where pCod = @id and corteEstado = 'T' ;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", idP)
            Dim reader = cmd.ExecuteReader
            If reader.Read Then

                res = True
            End If

            reader.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return res
    End Function

    Public Function validarMarcadoEstado(idProd As Integer) As Boolean
        Dim res = False
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT `marcadoEstado` FROM `producir`.`marcado` where pCod = @id ;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", idProd)
            Dim reader = cmd.ExecuteReader
            If reader.Read Then
                Dim estado = safeGetChar(reader, 0)
                If estado = "T" Then
                    MsgBox("Produccion ya pasó por marcado")
                    res = False
                Else
                    res = True
                End If
            End If

            reader.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return res

    End Function

    Public Function validarMarcado(ByVal idP As Integer) As Boolean
        Dim res = False
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT `marcadoCod` FROM `producir`.`marcado` where pCod = @id and marcadoEstado = 'T' ;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", idP)
            Dim reader = cmd.ExecuteReader
            If reader.Read Then
                res = True
            End If

            reader.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return res
    End Function


    Public Function validarPulidaEstado(ByVal idProd As Integer) As Boolean
        Dim res = False
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT `puliEstado` FROM `producir`.`pulida` where pCod = @id ;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", idProd)
            Dim reader = cmd.ExecuteReader
            If reader.Read Then
                Dim estado = safeGetChar(reader, 0)
                If estado = "T" Then
                    MsgBox("Produccion ya pasó por pulida")
                    res = False
                Else
                    res = True
                End If
            End If

            reader.Close()

        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return res
    End Function
    Public Function getProduccionBarCode(ByVal desde As String, ByVal hasta As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT `pCod` AS Produccion FROM `produccion` WHERE `pCod` BETWEEN " & CInt(desde) & " AND " & CInt(hasta) & " ;"
            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function


    Public Function getExpTemplado(ByVal ot) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * FROM `vexpedtemplado` WHERE Ot = @ot "
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@ot", ot)


            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getExpCorte(ByVal ot) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * FROM `vexpcorte` WHERE Ot = @ot"
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@ot", ot)


            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getExpMarcado(ByVal ot) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * FROM `vexpmarcado` WHERE Ot = @ot "
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@ot", ot)


            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getExpPulida(ByVal ot) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * FROM `vexppulida` WHERE Ot = @ot"
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@ot", ot)


            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getExtTotalPanhos(ByVal ot) As Integer
        Dim ds = 0
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT SUM(vd.`ventDetCantidad`) AS Maximo FROM `ventasdet` vd  WHERE vd.`ventCod` = @ot"
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@ot", ot)


            Dim reader = cmd.ExecuteReader
            If reader.Read() Then
                ds = SafeGetInt(reader, 0)
            End If
            reader.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getExtTotalPanhosExpedidos(ByVal ot) As Integer
        Dim ds = 0
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT COUNT(`pCod`) FROM `produccion` p WHERE p.ventCod = @ot and p.`produccion_expedido` = 'S'"
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@ot", ot)


            Dim reader = cmd.ExecuteReader
            If reader.Read() Then
                ds = SafeGetInt(reader, 0)
            End If
            reader.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Sub guardarExpedicion(ByVal nrop As String)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "INSERT INTO `producir`.`expedicion` (`pCod`, `expFI`, `expUI`) VALUES (@prod, @fecha ,@user);"
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@prod", nrop)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function cargarExped(ByVal ot As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * FROM `vventaexpediciones` WHERE ID = @ot "
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@ot", ot)


            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function guardarExpedicion2(expediciones As DataGridViewRowCollection) As Integer
        Dim res = 0
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim i = 1
            For Each row As Windows.Forms.DataGridViewRow In expediciones
                Dim nroProd = row.Cells(1).Value

                If i = 1 Then
                    Dim query = "INSERT INTO `producir`.`expedicion` (`pCod`, `expFI`, `expUI`) VALUES (@prod, @fecha ,@user);  SELECT LAST_INSERT_ID();"
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@prod", nroProd)
                    cmd.Parameters.AddWithValue("@fecha", Date.Now)
                    cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
                    Dim last = cmd.ExecuteScalar()
                    res = last

                    Dim queryUpdate = "UPDATE `producir`.`expedicion` SET `nroExp` = @nro WHERE `expCod` = @nro;"
                    Dim cmd2 As New MySqlCommand(queryUpdate, con)
                    cmd2.Parameters.AddWithValue("@nro", last)
                    cmd2.ExecuteNonQuery()
                    i = i + 1
                Else
                    Dim query = "INSERT INTO `producir`.`expedicion` (`pCod`, `nroExp`, `expFI`, `expUI`) VALUES (@prod, @nro, @fecha ,@user);"
                    Dim cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@prod", nroProd)
                    cmd.Parameters.AddWithValue("@nro", res)
                    cmd.Parameters.AddWithValue("@fecha", Date.Now)
                    cmd.Parameters.AddWithValue("@user", Sesion.Usuario)
                    cmd.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return res
    End Function


    Public Function cargarProduccionOT(id As Integer) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * FROM `vexpediciontodojunto` WHERE OT = @ot "
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@ot", id)


            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function cargarProduccionOTErrores(id As Integer) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * FROM `vexpediciontodojunto` WHERE OT = @ot and Expedido = 'S'"
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@ot", id)


            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getDetalleExpedicion(id As Integer) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "CALL `spreporteexpediciones`(@nro) "
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@nro", id)


            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getExpediciones(id As Integer) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadoexpediciones where Venta = @ot "
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@ot", id)


            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getExtTotalPanhosTerminados(ByVal ot) As Integer
        Dim ds = 0
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT COUNT(p.`pCod`) FROM `templado` p INNER JOIN `produccion` tp ON tp.`pCod` = p.`pCod` WHERE tp.`ventCod` = @ot AND p.`templaEstado` = 'T'"
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@ot", ot)


            Dim reader = cmd.ExecuteReader
            If reader.Read() Then
                ds = SafeGetInt(reader, 0)
            End If
            reader.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getExtTotalPanhosRotos(ByVal ot) As Integer
        Dim ds = 0
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT SUM(p.`produccion_roturas`) FROM `produccion` p WHERE p.`ventCod` = @ot "
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@ot", ot)


            Dim reader = cmd.ExecuteReader
            If reader.Read() Then
                ds = SafeGetInt(reader, 0)
            End If
            reader.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function cargarExpedicionesRealizadas(ByVal id As String) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from listadoexpediciones2 where `Venta` = " & id & " and Repo = 'N';"
            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getCortesDia() As Double
        Dim ds As Double
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT SUM(m2) FROM ( SELECT c.`pCod`, (dt.`ventDetSup` / dt.`ventDetCantidad`) AS m2, c.`corteFchUpd` AS Fecha FROM `corte` c INNER JOIN `produccion` p ON p.`pCod` = c.`pCod` INNER JOIN `ventasdet` dt ON dt.`ventDetcod` = p.`ventDetCod` WHERE DATE_FORMAT(c.`corteFchUpd`, '%Y-%m-%d') = @fecha ) AS t"
            'MsgBox(Date.Today)
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@fecha", Date.Today.ToString("yyyy-MM-dd"))
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                ds = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ds
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getCortesRoturaDia() As Double
        Dim ds As Double
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim mysql = "SELECT SUM(m2) FROM ( SELECT c.`pCod`, (dt.`ventDetSup` / dt.`ventDetCantidad`) AS m2, c.`corteRotFecha` AS Fecha FROM `corte` c INNER JOIN `produccion` p ON p.`pCod` = c.`pCod` INNER JOIN `ventasdet` dt ON dt.`ventDetcod` = p.`ventDetCod` WHERE DATE_FORMAT(c.`corteRotFecha`, '%Y-%m-%d') = @fecha ) AS t"

            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@fecha", Date.Today.ToString("yyyy-MM-dd"))

            Dim reader = cmd.ExecuteReader()

            While reader.Read
                ds = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ds
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getMarcadosDia() As Double
        Dim ds As Double
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT SUM(m2) FROM ( SELECT c.`pCod`, (dt.`ventDetSup` / dt.`ventDetCantidad`) AS m2, c.`marcadoFchUpd` AS Fecha FROM `marcado` c INNER JOIN `produccion` p ON p.`pCod` = c.`pCod` INNER JOIN `ventasdet` dt ON dt.`ventDetcod` = p.`ventDetCod` WHERE DATE_FORMAT(c.`marcadoFchUpd`, '%Y-%m-%d') = @fecha ) AS t"
            'MsgBox(Date.Today)
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@fecha", Date.Today.ToString("yyyy-MM-dd"))
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                ds = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ds
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getMarcadosRoturaDia() As Double
        Dim ds As Double
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT SUM(m2) FROM ( SELECT c.`pCod`, (dt.`ventDetSup` / dt.`ventDetCantidad`) AS m2, c.`marcadoRotFch` AS Fecha FROM `marcado` c INNER JOIN `produccion` p ON p.`pCod` = c.`pCod` INNER JOIN `ventasdet` dt ON dt.`ventDetcod` = p.`ventDetCod` WHERE DATE_FORMAT(c.`marcadoRotFch`, '%Y-%m-%d') = @fecha ) AS t"


            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@fecha", Date.Today.ToString("yyyy-MM-dd"))

            Dim reader = cmd.ExecuteReader()

            While reader.Read
                ds = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ds
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getPulidasDia() As Double
        Dim ds As Double
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT SUM(m2) FROM ( SELECT c.`pCod`, (dt.`ventDetSup` / dt.`ventDetCantidad`) AS m2, c.`puliFchUpd` AS Fecha FROM `pulida` c INNER JOIN `produccion` p ON p.`pCod` = c.`pCod` INNER JOIN `ventasdet` dt ON dt.`ventDetcod` = p.`ventDetCod` WHERE DATE_FORMAT(c.`puliFchUpd`, '%Y-%m-%d') = @fecha ) AS t "
            'MsgBox(Date.Today)
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@fecha", Date.Today.ToString("yyyy-MM-dd"))
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                ds = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ds
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getPulidasRoturasDia() As Double
        Dim ds As Double
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT SUM(m2) FROM ( SELECT c.`pCod`, (dt.`ventDetSup` / dt.`ventDetCantidad`) AS m2, c.`puliRotFch` AS Fecha FROM `pulida` c INNER JOIN `produccion` p ON p.`pCod` = c.`pCod` INNER JOIN `ventasdet` dt ON dt.`ventDetcod` = p.`ventDetCod` WHERE DATE_FORMAT(c.`puliRotFch`, '%Y-%m-%d') = @fecha ) AS t "

            'MsgBox(Date.Today)
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@fecha", Date.Today.ToString("yyyy-MM-dd"))
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                ds = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ds
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getTempEntradasDia() As Double
        Dim ds As Double
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT SUM(m2) FROM ( SELECT c.`pCod`, (dt.`ventDetSup` / dt.`ventDetCantidad`) AS m2, c.`templaEntrada` AS Fecha FROM `templado` c INNER JOIN `produccion` p ON p.`pCod` = c.`pCod` INNER JOIN `ventasdet` dt ON dt.`ventDetcod` = p.`ventDetCod` WHERE DATE_FORMAT(c.`templaEntrada`, '%Y-%m-%d') = @fecha ) AS t"
            'MsgBox(Date.Today)
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@fecha", Date.Today.ToString("yyyy-MM-dd"))
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                ds = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ds
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getTempSalidasDia() As Double
        Dim ds As Double
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT SUM(m2) FROM ( SELECT c.`pCod`, (dt.`ventDetSup` / dt.`ventDetCantidad`) AS m2, c.`templaSalida` AS Fecha FROM `templado` c INNER JOIN `produccion` p ON p.`pCod` = c.`pCod` INNER JOIN `ventasdet` dt ON dt.`ventDetcod` = p.`ventDetCod` WHERE DATE_FORMAT(c.`templaSalida`, '%Y-%m-%d') = @fecha ) AS t"
            'MsgBox(Date.Today)
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@fecha", Date.Today.ToString("yyyy-MM-dd"))
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                ds = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ds
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function getTempRoturas() As Double
        Dim ds As Double
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT SUM(m2) FROM ( SELECT c.`pCod`, (dt.`ventDetSup` / dt.`ventDetCantidad`) AS m2, c.`templaRotura` AS Fecha FROM `templado` c INNER JOIN `produccion` p ON p.`pCod` = c.`pCod` INNER JOIN `ventasdet` dt ON dt.`ventDetcod` = p.`ventDetCod` WHERE DATE_FORMAT(c.`templaRotura`, '%Y-%m-%d') = @fecha ) AS t"
            'MsgBox(Date.Today)
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@fecha", Date.Today.ToString("yyyy-MM-dd"))
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                ds = SafeGetDouble(reader, 0)
            End While
            reader.Close()
            Return ds
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Sub actualizarProduccion(ByVal prod As Integer)
        Try
            Dim p = getProduccion(prod)
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "(SELECT * FROM `producir`.`producciondia` WHERE `prodDiaFecha` = CURDATE())"
            Dim cmd As New MySqlCommand(query, con)
            Dim reader = cmd.ExecuteReader()
            If Not reader.HasRows Then
                reader.Close()
                Dim queryInser = "INSERT INTO `producir`.`producciondia` (`prodDiaSup`, `prodDiaFecha`) VALUES ( @sup, CURDATE());"
                Dim cmdInsert As New MySqlCommand(queryInser, con)
                cmdInsert.Parameters.AddWithValue("@sup", p.sup)
                cmdInsert.ExecuteNonQuery()
            Else
                reader.Close()
                Dim query2 = "UPDATE `producir`.`producciondia` SET `prodDiaSup` = `prodDiaSup` + @sup WHERE `prodDiaFecha` = CURDATE();"
                Dim cmd2 As New MySqlCommand(query2, con)
                cmd2.Parameters.AddWithValue("@sup", p.sup)
                cmd2.ExecuteNonQuery()
            End If



        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub completarOrden(ByVal desde As String, ByVal hasta As String)
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim queryCorte = "CALL updateorden(@desde,@hasta);"
            Dim cmd As New MySqlCommand(queryCorte, con)
            cmd.Parameters.AddWithValue("@desde", desde)
            cmd.Parameters.AddWithValue("@hasta", hasta)
            cmd.ExecuteNonQuery()



        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try

    End Sub

    Public Function pulidasPendientes(ByVal desde As Date, ByVal hasta As Date) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "CALL reporteprodpulidapend(@desde,@hasta);"
            Dim cmd As New MySqlCommand(mysql, con)
            cmd.Parameters.AddWithValue("@desde", desde)
            cmd.Parameters.AddWithValue("@hasta", hasta)

            Dim adp As New MySqlDataAdapter(cmd)
            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
        Return ds
    End Function
End Class
