Public Class Form1

    Private Shared ruta
    Private Shared conexBD
    Private Shared personaAux
    Private Shared gestorPersonas

    Private Sub BtnAbrirBBDD_Click(sender As Object, e As EventArgs) Handles BtnAbrirBBDD.Click, LBPersonas.SelectedIndexChanged

        Dim ventanaAbrirBBDD As New OpenFileDialog()
        ventanaAbrirBBDD.Title = "Selecciona una base de datos"
        ventanaAbrirBBDD.Filter = "Archivos de base de datos|*.accdb"

        If ventanaAbrirBBDD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ventanaAbrirBBDD.OpenFile()
            ruta = ventanaAbrirBBDD.FileName
            lblRuta.Text = ruta
            BtnConectar.Enabled = True
        End If

    End Sub

    Private Sub BtnConectar_Click(sender As Object, e As EventArgs) Handles BtnConectar.Click

        Dim listaPersonas As New List(Of Persona)

        Try
            conexBD = New ConexionBD(ruta)
            gestorPersonas = New GestionPersonas(conexBD)
            MessageBox.Show(conexBD.comprobarEstado())
            MsgBox("Base de datos abierta con éxito")
            PnlArriba.Enabled = True
        Catch ex As Exception
            MsgBox("Fallo al conectar con la base de datos")
        End Try

        listaPersonas = gestorPersonas.getListaPersonas()
        For Each Personita In listaPersonas
            LBPersonas.Items.Add(Personita)
        Next

    End Sub

    Public Function getConexBD() As ConexionBD

        Return conexBD

    End Function

    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        If TextDni.Text.Equals("") Or TextNombre.Text.Equals("") Then
            MsgBox("Por favor, rellene todos los campos")
            Exit Sub
        End If
        Try
            LBPersonas.Items.Add(gestorPersonas.create(TextDni.Text, TextNombre.Text, conexBD))
            MsgBox("Se ha añadido el nuevo registro con éxito")
        Catch ex As Exception
            MsgBox("Fallo al introducir el nuevo registro")
        End Try
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TextDni.Text.Equals("") Or TextNombre.Text.Equals("") Then
            MsgBox("Por favor, rellene todos los campos")
            Exit Sub
        End If
        Try
            LBPersonas.SelectedItem = gestorPersonas.update(LBPersonas.SelectedIndices, TextDni.Text, TextNombre.Text, conexBD)
            MsgBox("El registro ha sido modificado con éxito")
        Catch ex As Exception
            MsgBox("Fallo al modificar el registro")
        End Try
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            gestorPersonas.delete(LBPersonas.SelectedIndices, conexBD)
            MsgBox("El registro ha sido eliminado con éxito")
        Catch ex As Exception
            MsgBox("Fallo al eliminar el registro")
        End Try

        LBPersonas.Items.Remove(LBPersonas.SelectedIndex)

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        TextDni.Clear()
        TextNombre.Clear()
        LBPersonas.SelectedItem = Nothing

    End Sub
End Class
