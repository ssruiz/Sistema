Imports MySql.Data.MySqlClient

Public Class ClienteDAO
    Dim con As New MySqlConnection
    Public Function getClientes() As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadoclientes"
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

    ' Guarda un nuevo producto en la DB
    Public Sub guardar(ByVal modelo As Cliente)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            ', `prodEsp`
            Dim query As String = "INSERT INTO `clientes` (`clieLimitCred`, `cliePrecio`, `tclieCod`, `clieCi`, `clieNombre`, `clieDirec`, `clieCel`, `clieTelf`, `clieMail`, `clieRuc`, `vendCod`, `clieResponsable`, `clieUI`, `clieFI`, `clieUU`, `clieFU`, `clieSaldo`, `sucCod`) VALUES (@limite, @precio, @tipo, @ci, @nombre, @dir, @cel, @tel, @mail, @ruc, @vendedor, @responsable, @user, @fecha, @user, @fecha, @saldo, @sucursal);"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@limite", modelo.limiteC)
            cmd.Parameters.AddWithValue("@precio", modelo.precioDefault)
            cmd.Parameters.AddWithValue("@tipo", modelo.tipo)
            cmd.Parameters.AddWithValue("@ci", modelo.ci)
            cmd.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd.Parameters.AddWithValue("@dir", modelo.dir)
            cmd.Parameters.AddWithValue("@cel", modelo.cel)
            cmd.Parameters.AddWithValue("@tel", modelo.telf)
            cmd.Parameters.AddWithValue("@mail", modelo.email)
            cmd.Parameters.AddWithValue("@ruc", modelo.ruc)
            cmd.Parameters.AddWithValue("@vendedor", modelo.vendedor)
            cmd.Parameters.AddWithValue("@responsable", modelo.responsable)
            cmd.Parameters.AddWithValue("@user", Sesion.Codigo)
            cmd.Parameters.AddWithValue("@saldo", modelo.saldo)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            If modelo.sucursal <> 0 Then
                cmd.Parameters.AddWithValue("@sucursal", modelo.sucursal)
            Else
                cmd.Parameters.AddWithValue("@sucursal", DBNull.Value)
            End If


            'cmd.Parameters.AddWithValue("@fe", modelo.alto)
            'cmd.Parameters.AddWithValue("@alto", modelo.alto)

            'If modelo.tipoPL <> 0 Then
            '    cmd.Parameters.AddWithValue("@tpl", modelo.tipoPL)
            '    cmd.Parameters.AddWithValue("@alto", modelo.alto)
            '    cmd.Parameters.AddWithValue("@ancho", modelo.ancho)
            '    cmd.Parameters.AddWithValue("@superf", modelo.superficie)
            '    cmd.Parameters.AddWithValue("@stockm", modelo.stockMin)
            'Else
            '    cmd.Parameters.AddWithValue("@tpl", DBNull.Value)
            '    cmd.Parameters.AddWithValue("@alto", DBNull.Value)
            '    cmd.Parameters.AddWithValue("@ancho", DBNull.Value)
            '    cmd.Parameters.AddWithValue("@superf", DBNull.Value)
            '    cmd.Parameters.AddWithValue("@stockm", DBNull.Value)
            'End If
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub eliminar(ByVal id As String)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query As String = "DELETE FROM `clientes` WHERE `clieCod` = @id;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub update(ByVal modelo As Cliente)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            '`prodEsp` = @esp,
            Dim query = "UPDATE `clientes` SET `clieLimitCred` = @limite, `cliePrecio` = @precio, `tclieCod` = @tipo, `clieCi` = @ci, `clieNombre` = @nombre, `clieDirec` = @dir, `clieCel` = @cel, `clieTelf` = @tel, `clieMail` = @mail, `clieRuc` = @ruc, `vendCod` = @vendedor, `clieResponsable` = @responsable, `clieUU` = @user, `clieFU` = @fecha, `clieSaldo` = @saldo, `sucCod` = @sucursal WHERE `clieCod` = @cod;"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cod", modelo.id)
            cmd.Parameters.AddWithValue("@limite", modelo.limiteC)
            cmd.Parameters.AddWithValue("@precio", modelo.precioDefault)
            cmd.Parameters.AddWithValue("@tipo", modelo.tipo)
            cmd.Parameters.AddWithValue("@ci", modelo.ci)
            cmd.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd.Parameters.AddWithValue("@dir", modelo.dir)
            cmd.Parameters.AddWithValue("@cel", modelo.cel)
            cmd.Parameters.AddWithValue("@tel", modelo.telf)
            cmd.Parameters.AddWithValue("@mail", modelo.email)
            cmd.Parameters.AddWithValue("@ruc", modelo.ruc)
            cmd.Parameters.AddWithValue("@vendedor", modelo.vendedor)
            cmd.Parameters.AddWithValue("@responsable", modelo.responsable)
            cmd.Parameters.AddWithValue("@user", Sesion.Codigo)
            cmd.Parameters.AddWithValue("@saldo", modelo.saldo)
            cmd.Parameters.AddWithValue("@fecha", Date.Now)
            If modelo.sucursal <> 0 Then
                cmd.Parameters.AddWithValue("@sucursal", modelo.sucursal)
            Else
                cmd.Parameters.AddWithValue("@sucursal", DBNull.Value)
            End If




            'If modelo.tipoPL <> 0 Then
            '    cmd.Parameters.AddWithValue("@tpl", modelo.tipoPL)
            '    cmd.Parameters.AddWithValue("@alto", modelo.alto)
            '    cmd.Parameters.AddWithValue("@ancho", modelo.ancho)
            '    cmd.Parameters.AddWithValue("@sup", modelo.superficie)
            '    cmd.Parameters.AddWithValue("@stm", modelo.stockMin)
            'Else
            '    cmd.Parameters.AddWithValue("@tpl", DBNull.Value)
            '    cmd.Parameters.AddWithValue("@alto", DBNull.Value)
            '    cmd.Parameters.AddWithValue("@ancho", DBNull.Value)
            '    cmd.Parameters.AddWithValue("@sup", DBNull.Value)
            '    cmd.Parameters.AddWithValue("@stm", DBNull.Value)
            'End If
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function getCliente(ByVal id As String) As Cliente
        Try
            Dim modelo As New Cliente
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from clientes where clieCod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetInt(reader, 0)
                modelo.limiteC = SafeGetDouble(reader, 1)
                modelo.precioDefault = safeGetChar(reader, 2)
                modelo.tipo = SafeGetInt(reader, 3)
                modelo.ci = SafeGetString(reader, 4)
                modelo.nombre = SafeGetString(reader, 5)
                modelo.dir = SafeGetString(reader, 6)
                modelo.cel = SafeGetString(reader, 7)
                modelo.telf = SafeGetString(reader, 8)
                modelo.email = SafeGetString(reader, 9)
                modelo.ruc = SafeGetString(reader, 10)
                modelo.vendedor = SafeGetInt(reader, 11)
                modelo.responsable = SafeGetString(reader, 12)
                modelo.usuI = SafeGetString(reader, 13)
                modelo.fechaI = SafeGetDate(reader, 14)
                modelo.usuU = SafeGetString(reader, 15)
                modelo.fechaU = SafeGetDate(reader, 16)
                modelo.saldo = SafeGetDouble(reader, 17)
                modelo.sucursal = SafeGetInt(reader, 18)
            End While
            reader.Close()
            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function

    Public Function buscarClientes(ByVal filtro) As DataSet
        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadoclientes where Nombre LIKE '%" & filtro & "%' OR CI LIKE  '%" & filtro & "%'"
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

