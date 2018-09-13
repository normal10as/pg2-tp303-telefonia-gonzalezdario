Public Class Plan
    Private _credito As UInteger
    Private _precio As Decimal

    Sub New(credito As UInteger, precio As Decimal)
        Me.Credito = credito
        Me.Precio = precio
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
        If valor < _credito Then
            _credito = _credito - valor
        End If
    End Sub

    Public Function GetDisponible() As UInteger
        Return _credito
    End Function

End Class
