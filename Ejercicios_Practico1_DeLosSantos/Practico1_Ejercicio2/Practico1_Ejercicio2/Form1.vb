Public Class Form1

    Private Sub btnSuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuma.Click
        Try
            Dim num1 As Integer = txtNum1.Text
            Dim num2 As Integer = txtNum2.Text
            Dim suma As Integer = (num1 + num2)
            MsgBox("Suma = " & suma, vbEmpty, "Resultado")

        Catch ex As Exception
            MsgBox("Se produjo un error: " & ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub btnRestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestar.Click
        Try
            Dim num1 As Integer = txtNum1.Text
            Dim num2 As Integer = txtNum2.Text
            Dim resta As Integer = (num1 - num2)
            MsgBox("Resta = " & resta, vbEmpty, "Resultado")

        Catch ex As Exception
            MsgBox("Se produjo un error: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnMultiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiplicar.Click
        Try
            Dim num1 As Integer = txtNum1.Text
            Dim num2 As Integer = txtNum2.Text
            Dim multip As Integer = (num1 * num2)
            MsgBox("Multiplicación = " & multip, vbEmpty, "Resultado")

        Catch ex As Exception
            MsgBox("Se produjo un error: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnDividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDividir.Click
        Try
            Dim num1 As Integer = txtNum1.Text
            Dim num2 As Integer = txtNum2.Text
            Dim division As Integer = (num1 / num2)
            MsgBox("División = " & division, vbEmpty, "Resultado")

        Catch ex As Exception
            MsgBox("Se produjo un error: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
