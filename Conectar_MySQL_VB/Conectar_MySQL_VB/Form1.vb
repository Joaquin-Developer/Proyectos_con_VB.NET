' Importacion de Librerias:
'Imports System.Data.Odbc
Imports MySql.Data.MySqlClient


' End Imports ##########################


Public Class Form1

    Private Sub btnConexion_Click(sender As Object, e As EventArgs) Handles btnConexion.Click

        Dim conexionDB As New MySqlConnection("Server=localhost; Database=ejercicio_msp; Uid=root;Pwd=")

        Try
            conexionDB.Open()
            MsgBox("Conexion a MySQL exitosa.", vbInformation, "Mensaje")
            conexionDB.Close()

        Catch ex As Exception

            MsgBox(ex.Message, vbCritical, "Error al intentar obtener conexion a MySQL.")

        End Try

    End Sub

    Private Sub btnConsultaDatos_Click(sender As Object, e As EventArgs) Handles btnConsultaDatos.Click

        Dim conexionDB As New MySqlConnection("Server=localhost; Database=ejercicio_msp; Uid=root;Pwd=")
        Dim dt As DataTable
        Dim da As MySqlDataAdapter
        Dim ds As New DataSet
        Dim consultaSql As String = "SELECT * FROM persona;"
        Try
            da = New MySqlDataAdapter(consultaSql, conexionDB)
            conexionDB.Open()
            da.Fill(ds)
            conexionDB.Close()
            dt = ds.Tables(0)
            dgvPersonas.DataSource = dt

            conexionDB.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error al intentar obtener conexion a MySQL.")
        End Try
    End Sub

End Class
