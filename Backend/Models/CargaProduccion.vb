Public Class CargaProduccion
    Private _idProd As Integer
    Public Property idProd() As Integer
        Get
            Return _idProd
        End Get
        Set(ByVal value As Integer)
            _idProd = value
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

    Private _panho As Integer
    Public Property panho() As Integer
        Get
            Return _panho
        End Get
        Set(ByVal value As Integer)
            _panho = value
        End Set
    End Property

    Private _codProd As Integer
    Public Property codProd() As Integer
        Get
            Return _codProd
        End Get
        Set(ByVal value As Integer)
            _codProd = value
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

    Private _ancho As Double
    Public Property ancho() As Double
        Get
            Return _ancho
        End Get
        Set(ByVal value As Double)
            _ancho = value
        End Set
    End Property

    Private _alto As Double
    Public Property alto() As Double
        Get
            Return _alto
        End Get
        Set(ByVal value As Double)
            _alto = value
        End Set
    End Property

    Private _sup As Double
    Public Property sup() As Double
        Get
            Return _sup
        End Get
        Set(ByVal value As Double)
            _sup = value
        End Set
    End Property

    Private _cliente As String
    Public Property cliente() As String
        Get
            Return _cliente
        End Get
        Set(ByVal value As String)
            _cliente = value
        End Set
    End Property

    Private _opCod As Integer
    Public Property opCod() As Integer
        Get
            Return _opCod
        End Get
        Set(ByVal value As Integer)
            _opCod = value
        End Set
    End Property

    Private _opDesc As String
    Public Property opDesc() As String
        Get
            Return _opDesc
        End Get
        Set(ByVal value As String)
            _opDesc = value
        End Set
    End Property

    Private _cliCod As Integer
    Public Property cliCod() As Integer
        Get
            Return _cliCod
        End Get
        Set(ByVal value As Integer)
            _cliCod = value
        End Set
    End Property

    Private _fechaOt As Date
    Public Property fechaOt() As Date
        Get
            Return _fechaOt
        End Get
        Set(ByVal value As Date)
            _fechaOt = value
        End Set
    End Property

    Private _roturas As Integer
    Public Property roturas() As Integer
        Get
            Return _roturas
        End Get
        Set(ByVal value As Integer)
            _roturas = value
        End Set
    End Property

    Private _repo As String
    Public Property repo() As String
        Get
            Return _repo
        End Get
        Set(ByVal value As String)
            _repo = value
        End Set
    End Property
End Class
