Imports Entidades

Public Class Servicio
    Implements IPlan

    Private _credito As UInteger
    Private _precio As Decimal
    Private _consumo As Decimal

    Public Property Credito As UInteger
        Get
            Return _credito
        End Get
        Set(value As UInteger)
            _credito = value
        End Set
    End Property

    Public Property precio As Decimal Implements IPlan.precio
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property

    Public Sub NuevoConsumo(valor As UInteger)
        If valor <= GetDisponible() Then
            _consumo += valor
        End If
    End Sub

    Public Function GetDisponible() As UInteger
        Return _credito - _consumo
    End Function

    Public Function getDisponibleToSTring() As String Implements IPlan.getDisponibleToSTring
        Return GetDisponible() & " de " & _credito
    End Function

    Public Function getConsumosToSTring() As String Implements IPlan.getConsumosToSTring
        Return _consumo
    End Function
End Class
