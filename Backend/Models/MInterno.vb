Public Class MInterno
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _sorigen As Integer
    Public Property sorigen() As Integer
        Get
            Return _sorigen
        End Get
        Set(ByVal value As Integer)
            _sorigen = value
        End Set
    End Property

    Private _sdestino As Integer
    Public Property sdestino() As Integer
        Get
            Return _sdestino
        End Get
        Set(ByVal value As Integer)
            _sdestino = value
        End Set
    End Property

    Private _dorigen As Integer
    Public Property dorigen() As Integer
        Get
            Return _dorigen
        End Get
        Set(ByVal value As Integer)
            _dorigen = value
        End Set
    End Property

    Private _ddestino As Integer
    Public Property ddestino() As Integer
        Get
            Return _ddestino
        End Get
        Set(ByVal value As Integer)
            _ddestino = value
        End Set
    End Property


    Private _fecha As Date
    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property


    Private _obs As String
    Public Property obs() As String
        Get
            Return _obs
        End Get
        Set(ByVal value As String)
            _obs = value
        End Set
    End Property


    Private _solicitante As String
    Public Property solicitante() As String
        Get
            Return _solicitante
        End Get
        Set(ByVal value As String)
            _solicitante = value
        End Set
    End Property

    Private _autorizador As String
    Public Property autorizador() As String
        Get
            Return _autorizador
        End Get
        Set(ByVal value As String)
            _autorizador = value
        End Set
    End Property

    Private _estado As String
    Public Property estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property
End Class
