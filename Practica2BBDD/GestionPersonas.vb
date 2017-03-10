Imports System.Collections.Generic
Imports Practica2BBDD

Public Class GestionPersonas

    Public Shared listaPersonas

    Public Sub New(conex As ConexionBD)

        listaPersonas = New List(Of Persona)
        listaPersonas.Add(conex.leer("peticion"))

    End Sub

    Public Sub delete(indice As Integer, conex As ConexionBD)

        listaPersonas.Remove(indice)
        conex.modificar("peticion")

    End Sub

    Public Function update(indice As Integer, dni As String, nombre As String, conex As ConexionBD) As Persona

        listaPersonas.Item(indice).dni = dni
        listaPersonas.Item(indice).nombre = nombre
        Return listaPersonas.Item(indice)

    End Function

    Public Function create(dni As String, nombre As String, conex As ConexionBD) As Persona

        Dim aux As Persona
        aux = New Persona(dni, nombre)
        listaPersonas.Add(aux)
        conex.modificar("peticion")
        Return aux

    End Function

    Public Function getListaPers() As List(Of Persona)
        Return listaPersonas
    End Function

End Class
