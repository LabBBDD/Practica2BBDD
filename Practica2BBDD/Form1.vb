Public Class Form1

    Private Sub BtnAbrirBBDD_Click(sender As Object, e As EventArgs) Handles BtnAbrirBBDD.Click

        Dim ventanaAbrirBBDD As New OpenFileDialog()
        ventanaAbrirBBDD.Title = "Selecciona una base de datos"
        ventanaAbrirBBDD.Filter = "Archivos de base de datos|*.accbd"

        If ventanaAbrirBBDD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.Cursor = New Cursor(ventanaAbrirBBDD.OpenFile())
            lblRuta.Text = ventanaAbrirBBDD.FileName
        End If

    End Sub
End Class
