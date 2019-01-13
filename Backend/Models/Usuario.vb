Public Class Usuario
    Private _id As String
    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private _idNuevo As String
    Public Property idNuevo() As String
        Get
            Return _idNuevo
        End Get
        Set(ByVal value As String)
            _idNuevo = value
        End Set
    End Property


    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _nivel As Integer
    Public Property nivel() As Integer
        Get
            Return _nivel
        End Get
        Set(ByVal value As Integer)
            _nivel = value
        End Set
    End Property

    Private _fechaAlta As Date
    Public Property fechaAlta() As Date
        Get
            Return _fechaAlta
        End Get
        Set(ByVal value As Date)
            _fechaAlta = value
        End Set
    End Property

    Private _estado As Char
    Public Property estado() As Char
        Get
            Return _estado
        End Get
        Set(ByVal value As Char)
            _estado = value
        End Set
    End Property
End Class
