Imports MySql.Data.MySqlClient

Public Class SucursalDAO
    Public Function getSucursales() As DataSet
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT * from vlistadosucursales"

            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function

    Public Function getSucursalesCB() As DataSet
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT ID,Nombre from vlistadosucursales"

            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function
    ' Guarda un nuevo usuario en la DB
    Public Sub guardar(ByVal modelo As Sucursal)
        Dim con As New MySqlConnection
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query2 = "INSERT INTO `sucursales` (`sucDesc`, `depoCod`) VALUES (@nombre, @dep);"
            Dim cmd2 As New MySqlCommand(query2, con)
            cmd2.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd2.Parameters.AddWithValue("@dep", modelo.deposito)
            cmd2.ExecuteNonQuery()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function eliminar(ByVal id As String) As String
        Dim con As New MySqlConnection
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query As String = " DELETE FROM `sucursales` WHERE `sucCod` = @cod;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cod", id)
            cmd.ExecuteNonQuery()
            Return "Sucursal eliminada correctamente"
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Function

    Public Sub update(ByVal modelo As Sucursal)
        Dim con As New MySqlConnection
        Try
            con = New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            '`prodEsp` = @esp,
            Dim query = "UPDATE `sucursales` SET `sucDesc` = @nombre, `depoCod` = @dep WHERE `sucCod` = @cod;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@cod", modelo.id)
            cmd.Parameters.AddWithValue("@nombre", modelo.nombre)
            cmd.Parameters.AddWithValue("@dep", modelo.deposito)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function getSucursal(ByVal id As String) As Sucursal
        Try
            Dim modelo As New Sucursal
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "Select * from `sucursales` where `sucCod`  = @codigo"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetString(reader, 0)
                modelo.nombre = SafeGetString(reader, 1)
                modelo.deposito = SafeGetInt(reader, 2)
            End While

            reader.Close()
            con.Close()
            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Function

    Public Function getSucursalesDepositos(ByVal id As Integer) As DataSet
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT IDD,Depósito from vlistadosucursalesdep where ID =" & id & " limit 1;"

            Dim cmd As New MySqlCommand(mysql, con)
            Dim adp As New MySqlDataAdapter(mysql, con)

            ds.Tables.Add("tabla")
            adp.Fill(ds.Tables("tabla"))

            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
        Return ds
    End Function
End Class
