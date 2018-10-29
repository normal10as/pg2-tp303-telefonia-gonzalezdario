Public Class Persona
    Inherits Cliente

    Private _apellido As String
    Private _nombre As String
    Private _documento As UInteger

    Sub New(cuenta As UInteger, apellido As String, nombre As String, documento As UInteger)
        MyBase.New(cuenta)
        Me.Apellido = apellido
        Me.Nombre = nombre
        Me.Documento = documento
    End Sub

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 30 Then
                _apellido = value
            End If
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 50 Then
                _nombre = value
            End If
        End Set
    End Property

    Public Property Documento As UInteger
        Get
            Return _documento
        End Get
        Set(value As UInteger)
            _documento = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Apellido & " " & Nombre & " " & Cuenta
    End Function
End Class
