Public Class CajaVenta
    Private _M2 As Double
    Public Property M2() As Double
        Get
            Return _M2
        End Get
        Set(ByVal value As Double)
            _M2 = value
        End Set
    End Property

    Private _anuladas As Integer
    Public Property anuladas() As Integer
        Get
            Return _anuladas
        End Get
        Set(ByVal value As Integer)
            _anuladas = value
        End Set
    End Property

    Private _reposiciones As Integer
    Public Property reposiciones() As Integer
        Get
            Return _reposiciones
        End Get
        Set(ByVal value As Integer)
            _reposiciones = value
        End Set
    End Property

    Private _credito As Integer
    Public Property credito() As Integer
        Get
            Return _credito
        End Get
        Set(ByVal value As Integer)
            _credito = value
        End Set
    End Property

    Private _contado As Integer
    Public Property contado() As Integer
        Get
            Return _contado
        End Get
        Set(ByVal value As Integer)
            _contado = value
        End Set
    End Property

    Private _descuentoGS As Double
    Public Property descuentoGS() As Double
        Get
            Return _descuentoGS
        End Get
        Set(ByVal value As Double)
            _descuentoGS = value
        End Set
    End Property

    Private _recargoGS As Double
    Public Property recargoGS() As Double
        Get
            Return _recargoGS
        End Get
        Set(ByVal value As Double)
            _recargoGS = value
        End Set
    End Property



    Private _precioPGS As Double
    Public Property precioPGS() As Double
        Get
            Return _precioPGS
        End Get
        Set(ByVal value As Double)
            _precioPGS = value
        End Set
    End Property

    Private _totalGS As Double
    Public Property totalGS() As Double
        Get
            Return _totalGS
        End Get
        Set(ByVal value As Double)
            _totalGS = value
        End Set
    End Property

    '' Dolares
    Private _descuentoDol As Double
    Public Property descuentoDol() As Double
        Get
            Return _descuentoDol
        End Get
        Set(ByVal value As Double)
            _descuentoDol = value
        End Set
    End Property

    Private _recargoDol As Double
    Public Property recargoDol() As Double
        Get
            Return _recargoDol
        End Get
        Set(ByVal value As Double)
            _recargoDol = value
        End Set
    End Property



    Private _precioPDol As Double
    Public Property precioPDol() As Double
        Get
            Return _precioPDol
        End Get
        Set(ByVal value As Double)
            _precioPDol = value
        End Set
    End Property

    Private _totalDol As Double
    Public Property totalDol() As Double
        Get
            Return _totalDol
        End Get
        Set(ByVal value As Double)
            _totalDol = value
        End Set
    End Property
End Class
