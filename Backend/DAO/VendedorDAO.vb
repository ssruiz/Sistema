Imports MySql.Data.MySqlClient

Public Class VendedorDAO
    Dim con As New MySqlConnection
    Public Function getVendedores() As DataSet
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim mysql = "SELECT * from vlistadovendedores"
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

    ' Guarda un nuevo usuario en la DB
    Public Sub guardar(ByVal modelo As Vendedor)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query2 = "INSERT INTO `vendedores` (`vendNombre`, `vendCel`, `vendPorc`) VALUES (@nombre, @cel, @porcen);"
            Dim cmd2 As New MySqlCommand(query2, con)
            cmd2.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd2.Parameters.AddWithValue("@cel", modelo.celular)
            cmd2.Parameters.AddWithValue("@porcen", modelo.porcentaje)
            cmd2.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function eliminar(ByVal id As String) As String
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query As String = "DELETE FROM `vendedores` WHERE `vendCod` = @cod;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cod", id)
            cmd.ExecuteNonQuery()
            Return "Vendedor/a eliminado/a correctamente"
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function

    Public Sub update(ByVal modelo As Vendedor)
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            '`prodEsp` = @esp,
            Dim query = "UPDATE `vendedores` SET `vendNombre` = @nombre, `vendCel` = @cel, `vendPorc` = @porc WHERE `vendCod` = @cod;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cod", modelo.id)
            cmd.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd.Parameters.AddWithValue("@cel", modelo.celular)
            cmd.Parameters.AddWithValue("@porc", modelo.porcentaje)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function getVendedor(ByVal id As String) As Vendedor
        Try
            Dim modelo As New Vendedor
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from `vendedores` where `vendCod`  = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetString(reader, 0)
                modelo.nombre = SafeGetString(reader, 1)
                modelo.celular = SafeGetString(reader, 2)
                modelo.porcentaje = SafeGetDecimal(reader, 3)
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
