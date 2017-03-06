Public Class Form1

    Private Shared ruta
    Private Shared conexBD
    Private Shared personaAux
    Private Shared gestorPersonas

    Private Sub BtnAbrirBBDD_Click(sender As Object, e As EventArgs) Handles BtnAbrirBBDD.Click, LBPersonas.SelectedIndexChanged

        Dim ventanaAbrirBBDD As New OpenFileDialog()
        ventanaAbrirBBDD.Title = "Selecciona una base de datos"
        ventanaAbrirBBDD.Filter = "Archivos de base de datos|*.accbd"

        If ventanaAbrirBBDD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.Cursor = New Cursor(ventanaAbrirBBDD.OpenFile())
            ruta = ventanaAbrirBBDD.FileName
            lblRuta.Text = ruta
        End If

    End Sub


    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        If TextDni.Text.Equals("") Or TextNombre.Text.Equals("") Then
            MsgBox("ALGUNO DE LOS CAMPOS ESTÁ VACIO")
            Exit Sub
        End If
        Try
            personaAux = New Persona(TextDni.Text, TextNombre.Text)
            MsgBox("EL REGISTRO HA SIDO AÑADIDO CON ÉXITO")
        Catch ex As Exception
            MsgBox("FALLO AL INTRODUCIR EL REGISTRO")
        End Try
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TextDni.Text.Equals("") Or TextNombre.Text.Equals("") Then
            MsgBox("ALGUNO DE LOS CAMPOS ESTÁ VACIO")
            Exit Sub
        End If
        Try
            personaAux = New Persona(TextDni.Text, TextNombre.Text)
            personaAux.actualizar()
            MsgBox("EL REGISTRO HA SIDO MODIFICADO CON ÉXITO")
        Catch ex As Exception
            MsgBox("FALLO AL MODIFICAR EL NUEVO REGISTRO")
        End Try
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            personaAux = New Persona(TextDni.Text, TextNombre.Text)
            personaAux.borrar()
            MsgBox("EL REGISTRO HA SIDO ELIMINADO CON ÉXITO")
        Catch ex As Exception
            MsgBox("FALLO AL ELIMINAR EL NUEVO REGISTRO")
        End Try
    End Sub

    Private Sub BtbConectar_Click(sender As Object, e As EventArgs) Handles BtbConectar.Click

        conexBD = New ConexionBD(ruta)
        gestorPersonas = New GestionPersonas(conexBD)

    End Sub

End Class
