Module CONEXIONES
    Public conexion As OleDb.OleDbConnection
    Public Sub abrirconexion()
        conexion = New OleDb.OleDbConnection
        conexion.ConnectionString = "provider= Microsoft.Jet.OLEDB.4.0;Data Source= C:\Users\josez\Desktop\base de datos expo\database.mdb"
        conexion.Open()
    End Sub
End Module
