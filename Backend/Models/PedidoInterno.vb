Public Class PedidoInterno
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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



    Private _soli As String
    Public Property soli() As String
        Get
            Return _soli
        End Get
        Set(ByVal value As String)
            _soli = value
        End Set
    End Property

    Private _auto As String
    Public Property auto() As String
        Get
            Return _auto
        End Get
        Set(ByVal value As String)
            _auto = value
        End Set
    End Property

    Private _depo As Integer
    Public Property depo() As Integer
        Get
            Return _depo
        End Get
        Set(ByVal value As Integer)
            _depo = value
        End Set
    End Property

    Private _cantidad As Integer
    Public Property cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
        End Set
    End Property

    Private _prodCod As Integer
    Public Property prodCod() As Integer
        Get
            Return _prodCod
        End Get
        Set(ByVal value As Integer)
            _prodCod = value
        End Set
    End Property

    Private _opti As Integer
    Public Property opti() As Integer
        Get
            Return _opti
        End Get
        Set(ByVal value As Integer)
            _opti = value
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

    Private _usrIns As String
    Public Property usrIns() As String
        Get
            Return _usrIns
        End Get
        Set(ByVal value As String)
            _usrIns = value
        End Set
    End Property

    Private _fechaIns As Date
    Public Property fechaIns() As Date
        Get
            Return _estado
        End Get
        Set(ByVal value As Date)
            _fechaIns = value
        End Set
    End Property

    Private _usrUpd As String
    Public Property usrUpd() As String
        Get
            Return _usrUpd
        End Get
        Set(ByVal value As String)
            _usrUpd = value
        End Set
    End Property

    Private _fechaUpd As Date
    Public Property fechaUpd() As Date
        Get
            Return _fechaUpd
        End Get
        Set(ByVal value As Date)
            _fechaUpd = value
        End Set
    End Property

    Private _prov As Integer
    Public Property prov() As Integer
        Get
            Return _prov
        End Get
        Set(ByVal value As Integer)
            _prov = value
        End Set
    End Property
End Class
