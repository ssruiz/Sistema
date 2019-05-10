Imports MySql.Data.MySqlClient

Public Class ProveedorDAO
    Dim con As New MySqlConnection
    Public Function getProveedores() As DataSet

        Dim ds As New DataSet
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadoproveedores"
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
    Public Sub guardar(ByVal modelo As Proveedor)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            ', `prodEsp`
            Dim query As String = "INSERT INTO `producir`.`proveedor` (`provNombre`, `provRuc`, `provTelefono`, `provMail`, `provContacto`) VALUES (@nombre, @ruc, @tel, @mail, @contacto);"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd.Parameters.AddWithValue("@tel", modelo.telf)
            cmd.Parameters.AddWithValue("@mail", modelo.email)
            cmd.Parameters.AddWithValue("@ruc", modelo.ruc)
            cmd.Parameters.AddWithValue("@contacto", modelo.contacto)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub update(ByVal modelo As Proveedor)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            ', `prodEsp`
            Dim query As String = "UPDATE `producir`.`proveedor` SET `provNombre` = @nombre, `provRuc` = @ruc, `provTelefono` = @tel, `provMail` = @mail, `provContacto` = @contacto WHERE `provCod` = @cod;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cod", modelo.id)
            cmd.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd.Parameters.AddWithValue("@tel", modelo.telf)
            cmd.Parameters.AddWithValue("@mail", modelo.email)
            cmd.Parameters.AddWithValue("@ruc", modelo.ruc)
            cmd.Parameters.AddWithValue("@contacto", modelo.contacto)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function getProveedor(ByVal id As String) As Proveedor
        Try
            Dim modelo As New Proveedor
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from proveedor where provCod = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetInt(reader, 0)
                modelo.nombre = SafeGetString(reader, 1)
                modelo.telf = SafeGetString(reader, 3)
                modelo.email = SafeGetString(reader, 4)
                modelo.ruc = SafeGetString(reader, 2)
                modelo.contacto = SafeGetString(reader, 5)
            End While
            reader.Close()
            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function
End Class
