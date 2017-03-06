Public Class Form1

    Private Sub BtnAbrirBBDD_Click(sender As Object, e As EventArgs) Handles BtnAbrirBBDD.Click, ListBox1.SelectedIndexChanged

        Dim ventanaAbrirBBDD As New OpenFileDialog()
        ventanaAbrirBBDD.Title = "Selecciona una base de datos"
        ventanaAbrirBBDD.Filter = "Archivos de base de datos|*.accbd"

        If ventanaAbrirBBDD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.Cursor = New Cursor(ventanaAbrirBBDD.OpenFile())
            lblRuta.Text = ventanaAbrirBBDD.FileName
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Personas.Click

    End Sub

    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles Añadir.Click
        If txtDni.Text.Equals("") Or txtNombre.Text.Equals("") Then
            MsgBox("ALGUNO DE LOS CAMPOS ESTÁ VACIO")
            Exit Sub
        End If
        Try
            persona = New Persona(txtDNI.Text, txtNombre.Text)
            persona.añadir()
            MsgBox("EL REGISTRO HA SIDO AÑADIDO CON ÉXITO")
            Form1_Load(sender, e)
        Catch ex As Exception
            MsgBox("FALLO AL INTRODUCIR EL REGISTRO")
        End Try
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        If txtDni.Text.Equals("") Or txtNombre.Text.Equals("") Then
            MsgBox("ALGUNO DE LOS CAMPOS ESTÁ VACIO")
            Exit Sub
        End If
        Try
            persona = New Persona(txtDni.Text, txtNombre.Text)
            persona.actualizar()
            MsgBox("EL REGISTRO HA SIDO MODIFICADO CON ÉXITO")
            Form1_Load(sender, e)
        Catch ex As Exception
            MsgBox("FALLO AL MODIFICAR EL NUEVO REGISTRO")
        End Try
    End Sub

    Private Sub TextDni_TextChanged(sender As Object, e As EventArgs) Handles TextDni.TextChanged

    End Sub

    Private Sub TextNombre_TextChanged(sender As Object, e As EventArgs) Handles TextNombre.TextChanged

    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click

    End Sub
End Class
