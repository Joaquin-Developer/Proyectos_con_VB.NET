Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            Dim nombre, apellido, txt As String
            nombre = txtNombre.Text
            apellido = txtApellido.Text
            Dim edad As Short = Short.Parse(nudEdad.Value)
            Dim altura As String = txtAltura.Text
            If (nombre.Length = 0) Or (apellido.Length = 0) Or (altura.Length = 0) Then
                MsgBox("No se completó todos los datos solicitados.", vbCritical, "Error")
            Else
                txt = apellido & ", " & nombre & " tiene " & edad & " años. Su sexo es " & devuelveSexo() & " y mide" & altura
                MsgBox(txt, vbEmpty, "Datos ingresados")
            End If

            If edad <= 18 Then
                txt = nombre & " es menor de edad "
                MsgBox(txt, vbEmpty, "Edad")
            Else
                txt = nombre & " es mayor de edad "
                MsgBox(txt, vbEmpty, "Edad")
            End If


        Catch ex As Exception
            MsgBox("Se produjo un error al realizar la acción.", vbCritical, "Error")
        End Try
    End Sub
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtNombre.Text = "" ' en este caso estamos usando la Propiedad Text, pero para modificar su valor
        ' Notese que si la usamos así: (Dim nombre As String = txtNombre.Text ) la usamos para obtener su valor.
        txtApellido.Text = ""
        txtAltura.Text = ""
        nudEdad.Value = 0
    End Sub

    Function devuelveSexo()
        Dim valor As String = cBoxSexo.Text
        Dim sexo As String = "" 'inicializo
        If valor = "M" Then
            sexo = "Hombre"
        Else
            If valor = "F" Then
                sexo = "Mujer"
            Else
                sexo = "Otro/No definido."
            End If

        End If

        Return sexo
    End Function

End Class
