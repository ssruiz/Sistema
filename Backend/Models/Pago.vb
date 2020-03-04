Public Class Pago
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _venta As Integer
    Public Property venta() As Integer
        Get
            Return _venta
        End Get
        Set(ByVal value As Integer)
            _venta = value
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

    Private _tpago As Integer
    Public Property tpago() As Integer
        Get
            Return _tpago
        End Get
        Set(ByVal value As Integer)
            _tpago = value
        End Set
    End Property

    Private _banco As Integer
    Public Property banco() As Integer
        Get
            Return _banco
        End Get
        Set(ByVal value As Integer)
            _banco = value
        End Set
    End Property

    Private _monto As Double
    Public Property monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    Private _descuento As Double
    Public Property descuento() As Double
        Get
            Return _descuento
        End Get
        Set(ByVal value As Double)
            _descuento = value
        End Set
    End Property

    Private _recargo As Double
    Public Property recargo() As Double
        Get
            Return _recargo
        End Get
        Set(ByVal value As Double)
            _recargo = value
        End Set
    End Property

    Private _motivo As String
    Public Property motivo() As String
        Get
            Return _motivo
        End Get
        Set(ByVal value As String)
            _motivo = value
        End Set
    End Property

    Private _chequenro As String
    Public Property chequenro() As String
        Get
            Return _chequenro
        End Get
        Set(ByVal value As String)
            _chequenro = value
        End Set
    End Property

    Private _chequevenc As Date
    Public Property chequevenc() As Date
        Get
            Return _chequevenc
        End Get
        Set(ByVal value As Date)
            _chequevenc = value
        End Set
    End Property

    Private _dias As Date
    Public Property dias() As Date
        Get
            Return _dias
        End Get
        Set(ByVal value As Date)
            _dias = value
        End Set
    End Property

    Private _saldo As Double
    Public Property saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
        End Set
    End Property

    Private _recibo As String
    Public Property recibo() As String
        Get
            Return _recibo
        End Get
        Set(ByVal value As String)
            _recibo = value
        End Set
    End Property

    Private _userIn As String
    Public Property userIn() As String
        Get
            Return _userIn
        End Get
        Set(ByVal value As String)
            _userIn = value
        End Set
    End Property

    Private _fechaI As Date
    Public Property fechaI() As Date
        Get
            Return _fechaI
        End Get
        Set(ByVal value As Date)
            _fechaI = value
        End Set
    End Property

    Private _userUp As String
    Public Property userUp() As String
        Get
            Return _userUp
        End Get
        Set(ByVal value As String)
            _userUp = value
        End Set
    End Property

    Private _fechaU As Date
    Public Property fechaU() As Date
        Get
            Return _fechaU
        End Get
        Set(ByVal value As Date)
            _fechaU = value
        End Set
    End Property

    Private _moneda As Char
    Public Property moneda() As Char
        Get
            Return _moneda
        End Get
        Set(ByVal value As Char)
            _moneda = value
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

    Private _comentario As String
    Public Property comentario() As String
        Get
            Return _comentario
        End Get
        Set(ByVal value As String)
            _comentario = value
        End Set
    End Property
End Class
