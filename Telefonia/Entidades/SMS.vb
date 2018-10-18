Public Class SMS
    Inherits Plan

    Sub New(credito As UInteger, precio As Decimal)
        MyBase.Credito = credito
        MyBase.Precio = precio
    End Sub

    Public Overrides Function GetDisponible() As UInteger
        Throw New NotImplementedException()
    End Function

End Class
