Imports persistencia.ControladorBD
Public Class FormPrincipal

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cBoxTipoEmpl.SelectedItem = 0
    End Sub
    '><
    Private Sub btnAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleado.Click
        Try

            Dim datosCorrectos As Boolean = True 'bandera
            Dim numCi, guion As Integer
            Dim cedulaEmpl As Integer
            Dim sueldo As Double
            guion = nudGuionCi.Value

            If txtCedula.Text.Length >= 6 And txtCedula.Text.Length <= 7 Then
                ' cedula tiene entre 6 y 7 digitos (sin contar el num despues del guión)
                If Integer.TryParse(txtCedula.Text, numCi) Then
                    'si se logró converir el string a numero
                    numCi = CInt(txtCedula.Text)
                    Dim ci As String = "" & numCi & "" & guion ' junto la cedula y guion en un solo numero
                    cedulaEmpl = CInt(ci)
                Else
                    datosCorrectos = False
                End If
            Else
                datosCorrectos = False
            End If
            If (validaNombres(txtPrimNombre.Text) And validaNombres(txtSegNombre.Text) And validaNombres(txtPrimApe.Text) And validaNombres(txtSegApe.Text)) = False Then
                ' validamos todos los nombres y apellidos, con que uno no esté correcto alcanza.
                datosCorrectos = False
            End If
            If Double.TryParse(txtSueldo.Text, sueldo) Then
                sueldo = Double.Parse(txtSueldo.Text)
            Else
                datosCorrectos = False
            End If

            If datosCorrectos Then
                Dim empleado As New Empleado(cedulaEmpl, txtPrimNombre.Text, txtSegNombre.Text, txtPrimApe.Text,
                                             txtSegApe.Text, sueldo, cBoxTipoEmpl.SelectedItem.ToString)

                ' persistir en la BD la info:
                Dim c As New ControladorBD
                c.ingresoPersona(empleado)

            Else
                MsgBox("Ingresó datos invalidos. Por favor, revise y corriga", vbCritical, "Error")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Se produjo un error")
        End Try

    End Sub

    Private Sub btnCancelarIngr_Click(sender As Object, e As EventArgs) Handles btnCancelarIngr.Click
        txtCedula.Text = ""
        nudGuionCi.Value = 0
        txtPrimNombre.Text = ""
        txtSegNombre.Text = ""
        txtPrimApe.Text = ""
        txtSegApe.Text = ""
        txtSueldo.Text = ""
        cBoxTipoEmpl.SelectedIndex = 0
    End Sub

    Private Sub btnRefrescarDGV_Click(sender As Object, e As EventArgs) Handles btnRefrescarDGV.Click
        ' actualizar DataGridView



    End Sub

    Private Function validaNombres(ByVal cadena As String) As Boolean

        Dim esCorrecto As Boolean = True

        Dim caracteres() As Char = cadena.ToCharArray
        Dim i, aux As Integer ' i: contador For, aux: variable auxiliar para intentar convertir a integer
        For i = 0 To (caracteres.Length - 1) Step 1
            If (Integer.TryParse(caracteres(i), aux)) Then
                esCorrecto = False
                Exit For ' en caso que sea afirmativo salimos, no es necesario seguir validando
                ' ya que con que un carácter del nombre sea un numero, ya no será valido.
            End If
        Next

        Return esCorrecto
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim i As Integer = MsgBox("¿Estás seguro que deseas cerrar el programa?", vbQuestion + vbYesNo, "Confirmar salida")
        If i = 6 Then
            Me.Close()
        End If
    End Sub


End Class
