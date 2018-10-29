Imports Entidades

Public Class Paquete
    Implements IPlan

    Private _nombre As String
    Private _precio As Decimal
    Private _servicios As List(Of Servicio)

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
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

    Public Sub AddServicio(servicio As Servicio)
        _servicios.Add(servicio)
    End Sub

    Public Sub removeServicio(servicio As Servicio)
        _servicios.Remove(servicio)
    End Sub

    Private Function getAllServicios() As List(Of Servicio)
        Return _servicios
    End Function

    Public Function getDisponibleToSTring() As String Implements IPlan.getDisponibleToSTring
        Throw New NotImplementedException()
    End Function

    Public Function getConsumosToSTring() As String Implements IPlan.getConsumosToSTring
        Throw New NotImplementedException()
    End Function
End Class
