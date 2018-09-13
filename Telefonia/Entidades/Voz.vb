Public Class Voz
    Inherits Plan
    Private _minutos As DateTime

    Sub New(credito As UInteger, precio As Decimal)
        MyBase.New(credito, precio)
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
        Return GetDisponible() & Minutos
    End Function

End Class
