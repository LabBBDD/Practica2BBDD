Public Class Persona
    Private _dni As String
    Private _nombre As String

    Public Sub New(ByVal dni As String, ByVal nombre As String)
        Me.dni = dni
        Me.nombre = nombre
    End Sub

    Public Property dni As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

End Class
