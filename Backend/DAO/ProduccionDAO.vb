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
                mysql = "UPDATE `producir`.`corte` SET `corteMesa` = @mesa, `corteNroOpti` = IF(`corteNroOpti` IS NULL , 0 , `corteNroOpti`+1), `corteUsuUpd` = @user, `corteFchUpd` = @fecha, `corteEstado` = 'R' WHERE `pCod` = @prod;"
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
                mysql = "UPDATE `producir`.`pulida` SET `pulidora` = @puli, `nroOpti` = IF(`nroOpti` IS NULL , 1 , `nroOpti`+1), `puliUsrUpd` = @user, `puliFchUpd` = @fecha, `puliEstado` = 'R' WHERE `pCod` = @prod;"

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
                mysql = "UPDATE `producir`.`templado` SET `templaRotura` = @fecha, 'templaEstado' = 'R' , `templaUsrUpd` = @user, `templaFchUpd` = @fecha WHERE `pCod` = @prod;"

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
End Class
