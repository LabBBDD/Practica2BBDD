Public Class ConexionBD

    Private Shared datConex = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Shared conexion As OleDb.OleDbConnection

    Public Sub New(ruta)

        datConex += ruta
        conexion = New OleDb.OleDbConnection(datConex)
        conexion.Open()

    End Sub

    Public Function comprobarEstado()
        Return conexion.State
    End Function

    Public Function leer(ByVal sql As String) As OleDb.OleDbDataReader
        Dim com As New OleDb.OleDbCommand(sql, conexion)
        Return com.ExecuteReader()
    End Function

    Public Function modificar(ByVal sql As String) As Integer
        Dim com As New OleDb.OleDbCommand(sql, conexion)
        Return com.ExecuteNonQuery()
    End Function

End Class
