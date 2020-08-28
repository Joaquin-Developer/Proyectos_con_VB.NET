Imports Modelo_Empleados

Module Principal

    ' Creo la tabla fuera del Try 
    ' para poder devolverlo en el return de la Funcion
    'Dim dt As New DataTable
    Private dtEmpleados As New DataTable
    Private fila As DataRow

    Public Sub inicializarTabla()

        ' Agrego una columna al Datatable
        ' donde voy a guardar el Objeto que 
        ' traigo por parámetro
        dtEmpleados.Columns.Add("Cedula")
        dtEmpleados.Columns.Add("PrimerNombre")
        dtEmpleados.Columns.Add("SegundoNombre")
        dtEmpleados.Columns.Add("PrimerApellido")
        dtEmpleados.Columns.Add("SegundoApellido")
        dtEmpleados.Columns.Add("Tipo")
        dtEmpleados.Columns.Add("Sueldo")

    End Sub

    Public Sub agregarEmpleado(e As Empleado)

        Try
            'Fila es la variable que agregara filas(rows) a mi datatable
            fila = dtEmpleados.NewRow()
            fila("Cedula") = e.Cedula
            fila("PrimerNombre") = e._primer_nombre
            fila("SegundoNombre") = e._segundo_nombre
            fila("PrimerApellido") = e._primer_apellido
            fila("SegundoApellido") = e._segundo_apellido
            fila("Tipo") = e._tipo
            fila("Sueldo") = e._sueldo
            dtEmpleados.Rows.Add(fila)

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try

    End Sub

    Public Function getEmpleados() As DataTable

        Return dtEmpleados

    End Function


    Public Function getTiposEmpleados() As DataTable

        ' Creo la tabla fuera del Try 
        ' para poder devolverlo en el return de la Funcion
        Dim dt As New DataTable

        Try
            ' Agrego las columnas al Datatable
            ' donde voy a guardar los dato necesarios
            dt.Columns.Add("id")
            dt.Columns.Add("tipo")

            'Fila es la variable que agregara filas(rows) a mi datatable
            Dim fila As DataRow = dt.NewRow()

            fila = dt.NewRow()
            fila("id") = 0
            fila("tipo") = "Seleccione tipo de Empleado"
            dt.Rows.Add(fila)

            fila = dt.NewRow()
            fila("id") = 1
            fila("tipo") = "Administrativo/as"
            dt.Rows.Add(fila)

            fila = dt.NewRow()
            fila("id") = 2
            fila("tipo") = "Operario/as"
            dt.Rows.Add(fila)

            fila = dt.NewRow()
            fila("id") = 3
            fila("tipo") = "Gerente/as"
            dt.Rows.Add(fila)

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try

        Return dt

    End Function



End Module
