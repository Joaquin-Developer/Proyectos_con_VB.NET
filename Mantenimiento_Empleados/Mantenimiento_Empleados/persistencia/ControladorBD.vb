Imports MySql.Data.MySqlClient

Public Class ControladorBD

    Private dataBase As String = "Gestion_Empleados"
    Private uid As String = "root"
    Private conexion As MySqlConnection

    Friend Sub New()
        Me.dataBase = "Gestion_Empleados"
        Me.uid = "root"
        Me.conexion = New MySqlConnection("Server=localhost; Database=" + dataBase + "; Uid=" + uid + "; Pwd=")
    End Sub

    Friend Sub conexionBD()
        Try
            conexion.Open()
            MsgBox("Conexion a la Base de Datos " + dataBase + " exitosa", vbEmpty, "Mensaje")
            conexion.Close()
        Catch ex As Exception
            MsgBox("El error fué: " & ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Friend Sub consultaDatos(ByRef consulta As String)
        Dim dataTable As DataTable
        Dim dataAdapter As MySqlDataAdapter
        Dim dataSet As New DataSet
        'Dim consultaSql As String = "SELECT * FROM persona;"
        Try
            dataAdapter = New MySqlDataAdapter(consulta, conexion)
            conexion.Open()
            dataAdapter.Fill(dataSet)
            conexion.Close()
            dataTable = dataSet.Tables(0)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "Se produjo un error")
        End Try

    End Sub

    Friend Sub consultaTodaTabla(ByRef tabla As String)
        ' conusltas del tipo SELECT * FROM nombreTabla

        Dim dataTable As DataTable
        Dim dataAdapter As MySqlDataAdapter
        Dim dataSet As New DataSet
        Try
            Dim consulta As String = "SELECT * FROM " + tabla + ";"
            dataAdapter = New MySqlDataAdapter(consulta, conexion)
            conexion.Open()
            dataAdapter.Fill(dataSet)
            conexion.Close()
            dataTable = dataSet.Tables(0)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "Se produjo un error")
        End Try

    End Sub

    Friend Sub ingresoPersona(ByRef p As Empleado)
        Try
            Dim query As String = "INSERT INTO EMPLEADO VALUES(" & p.propCedula _
                & ",'" + p.propPrimerNombre & "'," _
                & "'" + p.propSegNombre & "'," _
                & "'" + p.propPrimerApellido & "'," _
                & "'" + p.propSegApellido & "'," _
                & p.propSueldoBase.ToString & ".0,'" + p.propTipoEmpleado & "')"

            Dim cmd As New MySqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = query
            cmd.Connection = conexion
            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Empleado agregado con éxito", vbInformation, "Agregado a la Base de Datos")
            MsgBox(p.mostrarDatos, vbEmpty, "Datos Ingresados:")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Se produjo un error al ingreso de datos en la BD")
        End Try

    End Sub

End Class
