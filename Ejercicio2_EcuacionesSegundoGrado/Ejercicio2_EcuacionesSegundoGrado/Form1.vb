Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim a, b, c As Double
        If (txtA.Text.Length = 0) Or (txtB.Text.Length = 0) Or (txtC.Text.Length = 0) Then
            MsgBox("Faltan campos por ingresar para poder realizar el calculo.", vbCritical, "Error")
        ElseIf Double.TryParse(txtA.Text, a) And Double.TryParse(txtB.Text, b) And Double.TryParse(txtC.Text, c) Then
            ' en caso de hacerse exitosamente las tres conversiones de text a Double
            calculo(a, b, c)
        Else
            MsgBox("Se deben ingresar numeros reales, como valores de a, b y c.", vbCritical, "Error")
        End If
    End Sub
    Private Sub calculo(a As Double, b As Double, c As Double)

        Dim discriminante As Double = (Math.Pow(b, 2)) - 4 * a * c
        If discriminante < 0.0 Then
            MsgBox("La ecuación no tiene raices reales.", vbInformation, "Mensaje")
        ElseIf (discriminante = 0.0) Then
            Dim raizUnica As Double
            raizUnica = (-1 * b) / (2 * a)
            MsgBox("La ecuación tiene una única raiz: x = " & raizUnica, vbInformation, "Raíces de la Ecuación.")
        Else
            Dim raiz1, raiz2 As Double
            raiz1 = ((-1 * b) + Math.Sqrt(discriminante)) / (2 * a)
            raiz2 = ((-1 * b) - Math.Sqrt(discriminante)) / (2 * a)
            MsgBox("Raíces de la ecuación: x1 = " & raiz1 & " | x2 = " & raiz2, vbInformation, "Raíces de la Ecuación.")
        End If

    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ' Limpiar lox TextBox's
        txtA.Text = ""
        txtB.Text = ""
        txtC.Text = ""
    End Sub
End Class
