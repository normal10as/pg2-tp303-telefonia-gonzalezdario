Public Class Voz
    Inherits Servicio
    Private _minutos As DateTime

    Sub New(credito As UInteger, precio As Decimal)
        MyBase.Credito = credito
        MyBase.Precio = precio
    End Sub

    Public Property Minutos As DateTime
        Get
            Return _minutos
        End Get
        Set(value As DateTime)
            _minutos = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Credito & " minutos "
    End Function
End Class
