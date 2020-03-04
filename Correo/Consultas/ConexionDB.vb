Public Class ConexionDB
    Public Shared Function cadenaConexionBD()
        ' Configuracion generalaes. de datos del root ( necesario para operaciones de abm usuario). Host. 
        'Config.root = "root"
        'Config.Password = "system"
        'Config.Host = "localhost"
        'Config.DB = "producir"

        ' String de conexion

        Return String.Format("server={0};DataBase={1};User Id={2};Password={3}", Config.Host, Config.DB, Config.root, Config.Password)

    End Function
End Class
