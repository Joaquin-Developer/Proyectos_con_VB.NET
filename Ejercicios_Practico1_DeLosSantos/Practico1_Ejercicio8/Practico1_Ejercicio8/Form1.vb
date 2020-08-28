Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim x As Integer ' variable auxiliar

        If (Integer.TryParse(txtNumeros.Text, x)) And (Integer.TryParse(txtExtra.Text, x)) Then
            Dim numeros As String = txtNumeros.Text
            Dim extra As String = txtExtra.Text
            If numeros.Length <> 0 And extra.Length <> 0 Then
                If numeros.Length < 6 Or numeros.Length > 7 Then
                    MsgBox("Numeros inválidos. La CI no puede tener mas de 7 dígitos iniciales, ni tener menos de 6.", vbCritical, "Error")
                ElseIf extra.Length > 1 Then
                    MsgBox("El numero extra después del guión debe ser de un solo dígito", vbCritical, "Error: CI inválida")
                Else
                    ' si está todo correcto :
                    Dim ci As String = numeros + "-" + extra
                    MsgBox("CI ingresada correctamente: " & ci, vbInformation, "Mensaje")
                End If
            Else
                MsgBox("Faltan campos por ingresar.", vbCritical, "Error")
            End If
        Else
            MsgBox("Deben ingresarse únicamente números.", vbCritical, "Error en el ingreso de datos.")
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
