Public Class Espesor
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _espesor As Integer
    Public Property espesor() As Integer
        Get
            Return _espesor
        End Get
        Set(ByVal value As Integer)
            _espesor = value
        End Set
    End Property
End Class