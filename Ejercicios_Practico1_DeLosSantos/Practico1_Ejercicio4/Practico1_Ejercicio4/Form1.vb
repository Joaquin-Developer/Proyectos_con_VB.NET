Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim peso, altura, imc As Double
        Dim estado As String
        If Double.TryParse(txtPeso.Text, peso) Then
            If Double.TryParse(txtAltura.Text, altura) Then
                imc = Math.Round(peso / (altura * altura))
                lblResultado.Text = imc
            Else
                MsgBox("Se produjo un error con el ingreso de datos.", vbCritical, "Error")
            End If
        End If
        ' <>
        If imc > 30 Then
            estado = "Obeso"
        Else
            If imc >= 25 And imc < 30 Then
                estado = "Sobrepeso"
            Else
                If imc >= 18.5 And imc < 25 Then
                    estado = "Normal"
                Else
                    estado = "Infrapeso"
                End If
            End If
        End If
        MsgBox("Estado del IMC : " & estado, vbInformation, "Información")
    End Sub

End Class
