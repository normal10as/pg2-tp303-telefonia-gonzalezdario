Public Class Plan
    Private _credito As UInteger
    Private _precio As Decimal

    Sub New(Credito As UInteger, Precio As Decimal)
        Me.Credito = Credito
        Me.Precio = Precio
    End Sub

    Public Property Credito As UInteger
        Get
            Return _credito
        End Get
        Set(value As UInteger)
            _credito = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property

    Public Sub NuevoConsumo(valor As UInteger)

    End Sub

    Public Function GetDisponible() As UInteger

    End Function

End Class
