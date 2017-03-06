Public Class ConexionBD

    Private Shared datConex = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Shared conexion As OleDb.OleDbConnection

    Public Sub New(ruta)

        datConex += ruta
        conexion = New OleDb.OleDbConnection(datConex)
        conexion.Open()

    End Sub

End Class
