﻿Public Class Modelo
    Private _nombre As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "Modelo: " & Nombre
    End Function

End Class