Imports MySql.Data.MySqlClient

Public Class EspesorDAO
    Public Function getEspesores() As DataSet
        Dim clientes As New Collection
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()


            Dim mysql = "SELECT * from vlistadoespesores"

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



    Public Sub agregar(ByVal modelo As Espesor)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query As String = "INSERT INTO `espesor` (`espesor`) VALUES (@espesor);"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@espesor", modelo.espesor)


            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Sub update(ByVal modelo As Espesor)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query As String = "UPDATE `espesor` SET `espesor` = @espesor WHERE `espesorCod` = @id;"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@id", modelo.id)
            cmd.Parameters.AddWithValue("@espesor", modelo.espesor)


            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Sub eliminar(ByVal id As String)
        Try
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()

            Dim query As String = "DELETE FROM `espesor` WHERE `espesorCod` = @id;"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@id", id)


            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Public Function getEspesor(ByVal id As String) As Espesor
        Try
            Dim modelo As New Espesor
            Dim con As New MySqlConnection(ConexionDB.cadenaConexionBD(Sesion.Usuario, Sesion.Password))
            con.Open()
            Dim query = "SELECT * FROM `espesor` where `espesorCod` = @codigo;"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@codigo", id)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                modelo.id = SafeGetInt(reader, 0)
                modelo.espesor = SafeGetString(reader, 1)
            End While

            reader.Close()
            con.Close()
            Return modelo
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Function
End Class
