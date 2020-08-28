Imports Modelo_Empleados

Public Class frmEmpleados
    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicializarTabla()
        CargarCombos()
        EsconderTodo()

    End Sub

    Private Sub cargarGrilla()

        dgvEmpleados.DataSource = getEmpleados()

    End Sub

    Private Sub LimpiarFormulario()

        txt_cedula.Text = ""
        txt_primer_apellido.Text = ""
        txt_primer_nombre.Text = ""
        txt_segundo_apellido.Text = ""
        txt_segundo_nombre.Text = ""
        txt_sueldo_base.Text = ""
        txt_nivel_gerente.Text = ""
        txt_cantidad_horas.Text = ""
        txt_precio_hora.Text = ""
        txt_incentivo.Text = ""
        cboTiposEmpleados.SelectedIndex = 0

        ' Escondo los controles que no son comunes a todos los empleados
        lbl_precio_hora.Visible = False
        txt_precio_hora.Visible = False
        lbl_cantidad_horas.Visible = False
        txt_cantidad_horas.Visible = False
        lbl_nivel_gerente.Visible = False
        txt_nivel_gerente.Visible = False
        lbl_incentivo.Visible = False
        txt_incentivo.Visible = False


    End Sub

    Private Sub EsconderTodo()


        ' Muestro Administrativos
        lbl_incentivo.Visible = False
        txt_incentivo.Visible = False

        ' Escondo Campos de Operarios
        lbl_cantidad_horas.Visible = False
        txt_cantidad_horas.Visible = False
        lbl_precio_hora.Visible = False
        txt_precio_hora.Visible = False

        ' Escondo Campos de Gerentes
        lbl_nivel_gerente.Visible = False
        txt_nivel_gerente.Visible = False


    End Sub

    Private Sub CargarCombos()

        ' La propiedad DataSource del ComboBox permite pasarle como
        ' parametro un DataTable
        cboTiposEmpleados.DataSource = getTiposEmpleados()
        cboTiposEmpleados.ValueMember = "id"
        cboTiposEmpleados.DisplayMember = "tipo"

        ' Parate en el indice 0 del contenido
        cboTiposEmpleados.SelectedIndex = 0

    End Sub

    Private Sub btn_agregar_empleado_Click(sender As Object, e As EventArgs) Handles btn_agregar_empleado.Click

        If txt_cedula.Text <> "" _
            And txt_primer_nombre.Text <> "" _
            And txt_primer_apellido.Text <> "" _
            And txt_sueldo_base.Text <> "" _
            And cboTiposEmpleados.SelectedValue <> 0 Then

            agregoEmpleadoGrilla()

        End If

    End Sub


    Private Sub agregoEmpleadoGrilla()

        Select Case cboTiposEmpleados.SelectedValue
            Case 0
                MsgBox("Debe seleccionar un tipo de empleado")
            Case 1

                ' VERIFICAR QUE LOS CAMPOS NECESARIOS
                ' PARA CREAR ADMINISTRATIVOS ESTEN COMPLETOS

                ' Guardo Admiistrativo
                Dim oAdm As New Administrativo
                oAdm.Cedula = txt_cedula.Text
                oAdm._primer_nombre = txt_primer_nombre.Text
                oAdm._segundo_nombre = txt_segundo_nombre.Text
                oAdm._primer_apellido = txt_primer_apellido.Text
                oAdm._segundo_apellido = txt_segundo_apellido.Text
                oAdm._sueldo = txt_sueldo_base.Text
                oAdm._incentivo = txt_incentivo.Text
                oAdm._tipo = "Administrativo"
                oAdm.CalcularSueldo()
                agregarEmpleado(oAdm)

            Case 2


                ' VERIFICAR QUE LOS CAMPOS NECESARIOS
                ' PARA CREAR OPERARIOS ESTEN COMPLETOS

                ' Guardo Operario
                Dim oOper As New Operario(
                txt_cedula.Text,
                txt_primer_nombre.Text,
                txt_segundo_nombre.Text,
                txt_primer_apellido.Text,
                txt_segundo_apellido.Text,
                "Operario",
                txt_sueldo_base.Text,
                txt_cantidad_horas.Text,
                txt_precio_hora.Text)

                oOper.CalcularSueldo()
                agregarEmpleado(oOper)

            Case 3

                ' VERIFICAR QUE LOS CAMPOS NECESARIOS
                ' PARA CREAR GERENTES ESTEN COMPLETOS

                ' Guardo Gerente 
                Dim oGerente As New Gerente
                oGerente.Cedula = txt_cedula.Text
                oGerente._primer_nombre = txt_primer_nombre.Text
                oGerente._segundo_nombre = txt_segundo_nombre.Text
                oGerente._primer_apellido = txt_primer_apellido.Text
                oGerente._segundo_apellido = txt_segundo_apellido.Text
                oGerente._sueldo = txt_sueldo_base.Text
                oGerente._nivel = txt_nivel_gerente.Text
                oGerente.CalcularSueldo()
                agregarEmpleado(oGerente)

        End Select

        cargarGrilla()
        LimpiarFormulario()
        montoAPagar()
    End Sub


    Private Sub cboTiposEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTiposEmpleados.SelectedIndexChanged

        If cboTiposEmpleados.ValueMember <> "" Then

            Dim tipo As Integer = cboTiposEmpleados.SelectedValue

            Select Case tipo

                Case 1
                    ' Muestro Administrativos

                    With lbl_incentivo
                        .Visible = True
                        .Top = lbl_cantidad_horas.Top
                        .Left = lbl_cantidad_horas.Left
                    End With

                    With txt_incentivo
                        .Visible = True
                        .Top = txt_cantidad_horas.Top
                        .Left = txt_cantidad_horas.Left
                    End With

                    ' Escondo Campos de Operarios
                    lbl_cantidad_horas.Visible = False
                    txt_cantidad_horas.Visible = False
                    lbl_precio_hora.Visible = False
                    txt_precio_hora.Visible = False

                    ' Escondo Campos de Gerentes
                    lbl_nivel_gerente.Visible = False
                    txt_nivel_gerente.Visible = False

                Case 2

                    ' Muestro Campos de Operarios
                    lbl_cantidad_horas.Visible = True
                    txt_cantidad_horas.Visible = True
                    lbl_precio_hora.Visible = True
                    txt_precio_hora.Visible = True

                    ' Escondo Admiistrativos
                    lbl_incentivo.Visible = False
                    txt_incentivo.Visible = False

                    ' Escondo Campos de Gerentes
                    lbl_nivel_gerente.Visible = False
                    txt_nivel_gerente.Visible = False

                Case 3

                    ' Muestro Campos de Gerentes
                    lbl_nivel_gerente.Visible = True
                    txt_nivel_gerente.Visible = True

                    ' Escondo Admiistrativos
                    lbl_incentivo.Visible = False
                    txt_incentivo.Visible = False

                    ' Escondo Campos de Operarios
                    lbl_cantidad_horas.Visible = False
                    txt_cantidad_horas.Visible = False
                    lbl_precio_hora.Visible = False
                    txt_precio_hora.Visible = False

            End Select

        End If

    End Sub

    Private Sub montoAPagar()
        Dim total As Double

        For Each row As DataRow In getEmpleados.Rows

            total += Double.Parse(row("Sueldo"))

        Next

        lbl_total_a_pagar.Text = "Monto total a pagar: " & total

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Close()
    End Sub

    Private Sub btn_calcular_sueldo_Click(sender As Object, e As EventArgs) Handles btn_calcular_sueldo.Click
        montoAPagar()
    End Sub





End Class