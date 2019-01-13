Public Class ConexionDB

    Public Shared Function cadenaConexionBD(ByVal user As String, ByVal passwd As String)
        Dim server As String = "localhost"
        'Dim BD As String = "stocklynch"
        Sesion.Host = "localhost"
        'Dim server As String = "192.168.1.31"
        Dim BD As String = "producir"
        'Dim server As String = "192.168.0.110"
        'Dim BD As String = "stocklynch"

        'Dim cadenaConexion As String = "database=mysql;server=localhost;Allow Zero Datetime=True;Convert Zero Datetime=True;User Id='" & usuario & "';Password='" & password & "' ; Pooling=false;Connection Lifetime=1; Max Pool Size=1"
        'Dim ConexionBaseDatos As String = "Database=stockcapiata;Data Source=localhost;Allow Zero Datetime=True;Convert Zero Datetime=True;User Id='" & usuario & "';Password='" & password & "' ; Pooling=false;Connection Lifetime=1; Max Pool Size=1"




        Return String.Format("server={0};DataBase={1};User Id={2};Password={3}", Sesion.Host, BD, user, passwd)
        'Return ConexionBaseDatos
    End Function
    Public Shared Function cadenaConexionBD2(ByVal user As String, ByVal passwd As String)
        Dim server As String = "localhost"
        Dim BD As String = "mysql"

        'Dim cadenaConexion As String = "database=mysql;server=localhost;Allow Zero Datetime=True;Convert Zero Datetime=True;User Id='" & usuario & "';Password='" & password & "' ; Pooling=false;Connection Lifetime=1; Max Pool Size=1"
        'Dim ConexionBaseDatos As String = "Database=stockcapiata;Data Source=localhost;Allow Zero Datetime=True;Convert Zero Datetime=True;User Id='" & usuario & "';Password='" & password & "' ; Pooling=false;Connection Lifetime=1; Max Pool Size=1"




        Return String.Format("server={0};DataBase={1};User Id={2};Password={3}", server, BD, "samuel", "system")
        'Return ConexionBaseDatos
    End Function


End Class

