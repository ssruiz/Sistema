Imports System.Web
Imports MySql.Data.MySqlClient

Public Class Conexion



    Public Shared ConexionMySQL As MySql.Data.MySqlClient.MySqlConnection
    Public Shared comando As MySql.Data.MySqlClient.MySqlCommand
    Public Shared adaptador As MySql.Data.MySqlClient.MySqlDataAdapter

    Public Shared ds As DataSet
    Private Shared _FECHASERVIDOR As Date


    Public Class Acceso
        Public Shared Property FECHASERVIDOR As Date
            Get
                Return _FECHASERVIDOR
            End Get
            Set(ByVal value As Date)
                _FECHASERVIDOR = value
            End Set
        End Property


        Public Shared Sub AbrirConexion()
            Try
                ConexionMySQL = New MySqlConnection("Data Source=localhost;Database=producir;User Id=root;Password=system")
            Catch ex As Exception
                Err.Description.ToString()
            End Try
        End Sub

        Public Shared Sub ObtenerFechaServidor()
            AbrirConexion()
            adaptador = New MySqlDataAdapter("SELECT NOW() AS CurrentDateTime", ConexionMySQL)
            ds = New DataSet
            adaptador.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                FECHASERVIDOR = ds.Tables(0).Rows(0).Item(0)
            Else
                FECHASERVIDOR = Today.Date
            End If

            ConexionMySQL.Close()
        End Sub

    End Class

End Class
