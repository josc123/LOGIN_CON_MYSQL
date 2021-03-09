Imports System.Data.OleDb

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirconexion()

    End Sub
    Dim pro As String
        Dim constring As String
        Dim comando As String
    Dim miconexion As OleDbConnection = New OleDbConnection

    Public Sub cargardatos()
        Dim da As New OleDb.OleDbDataAdapter("select * from NOMINA", conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DGVDATA.DataSource = ds.Tables(0)
        Else
            DGVDATA.DataSource = Nothing
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pro = "provider= Microsoft.Jet.OLEDB.4.0;Data Source=Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\josez\Desktop\base de datos expo\database.mdb"
        constring = pro
        miconexion.ConnectionString = constring
        miconexion.Open()
        comando = "insert into NOMINA ([Id],[NOMBRE],[APELLIDO],[CEDULA],[EDAD],[SEXO]) values('" & txtid.Text & "'  ,  '" & txtnom.Text & "'  ,  '" & txtapell.Text & "' , '" & txtced.Text & "' , '" & txtedad.Text & "' , '" & CBSEX.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(comando, miconexion)
        cmd.Parameters.Add(New OleDbParameter("Id", CType(txtid.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Id", CType(txtnom.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Id", CType(txtapell.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Id", CType(txtced.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Id", CType(txtedad.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Id", CType(CBSEX.Text, String)))
        MessageBox.Show("los datos se han guardo con exito")

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            miconexion.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        txtid.Text = ""
        txtnom.Text = ""
        txtapell.Text = ""
        txtced.Text = ""
        txtedad.Text = ""
        CBSEX.Text = ""
    End Sub

    Private Sub BTNMOSTRAR_Click(sender As Object, e As EventArgs) Handles BTNMOSTRAR.Click
        If PNLDATA.Visible = False Then
            PNLDATA.Visible = True
        Else
        End If
        cargardatos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If PNLDATA.Visible = True Then
            PNLDATA.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
