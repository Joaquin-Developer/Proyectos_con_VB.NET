Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' MsgBox("Mensaje de error.", vbCritical, "Error") prueba de mensaje de error en VB.

    End Sub

    Private Sub btnFrase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrase.Click
        Dim fragm1, fragm2, fragm3 As String
        fragm1 = txtFragm1.Text
        fragm2 = txtFragm2.Text
        fragm3 = txtFragm3.Text

        If (fragm1.Length = 0) Or (fragm2.Length = 0) Or (fragm3.Length = 0) Then
            MsgBox("Se deben completar todos los campos solicitados.", vbCritical, "Error")
        Else
            Dim mensaje, mensaje2 As String
            ' dos formas distintas de hacer concatenación (con Strings)
            mensaje = fragm1 + " " + fragm2 + " " + fragm3
            mensaje2 = fragm1 & " " & fragm2 & " " & fragm3
            MsgBox(mensaje, vbExclamation, "Concatenación")

        End If

    End Sub
End Class
