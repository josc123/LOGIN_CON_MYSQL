Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class frmlogin
    Dim conexion As New MySqlConnection


    Public Sub Conectar()
        Try
            conexion.ConnectionString = "server = localhost;user=root;password=Admin;database=database"
            conexion.Open()
            PBOFF.Visible = False
            PBON.Visible = True
            TXTCONEXION.Text = ("CONECTADO")

        Catch ex As Exception

            PBON.Visible = False
            TXTCONEXION.Text = ("CONEXION FALLIDA")
            Me.Close()
        End Try



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()

            End If
            Dim requerimiento As String = String.Empty

            requerimiento = "SELECT * FROM NOMINA WHERE USUARIO='" & TXTUSER.Text & "' AND CLAVE ='" & TXTPASS.Text & "'"

            Dim SQLCOMAND As MySqlCommand
            SQLCOMAND = New MySqlCommand(requerimiento, conexion)
            Dim TABLA As MySqlDataReader

            TABLA = SQLCOMAND.ExecuteReader
            Dim CANTIDAD As Integer = 0

            While TABLA.Read
                CANTIDAD += 1

            End While

            If CANTIDAD = 1 Then
                MsgBox("USUARIO Y CCCONTRASEÑA CORRECTAS")
                Me.Hide()
                Form1.Show()

            ElseIf CANTIDAD > 1 Then
                MsgBox("ERROR, DATOS DUPLICADOS")

            ElseIf TXTUSER.Text = "" Or TXTPASS.Text = "" Then
                MsgBox("VERFIQUE SU USUARIO O CONTRASEÑA")

            Else
                MsgBox("USUARIO, CONTRASEÑA NO VALIDOS ")

            End If
            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conexion.Dispose()




        End Try


    End Sub
End Class
