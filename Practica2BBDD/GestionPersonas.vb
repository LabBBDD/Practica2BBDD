Imports System.Collections.Generic
Imports Practica2BBDD

Public Class GestionPersonas

    Public Shared listaPersonas

    Public Sub New(Conex As ConexionBD)

        listaPersonas = New List(Of Persona)
        listaPersonas.Add()

    End Sub

    Public Sub delete(personas As Persona)

    End Sub

    Public Sub update(personas As Persona)

    End Sub

    Public Sub create(personas As Persona)



    End Sub

    Public Sub readPersona(dni As String, personas As Persona)

    End Sub

    Public Sub readAll()

    End Sub
End Class
