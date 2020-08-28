Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radioBtnMinusculas.Checked = True
        radioBtnVerde.Checked = True

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnEvaluar_Click(sender As Object, e As EventArgs) Handles btnEvaluar.Click
        Dim texto As String = txtEntrada.Text
        If texto <> Nothing Then 'en caso que texto No sea vacio:
            Dim letras() As Char = texto.ToCharArray ' lleno el CharArray con los elementos del String(texto)
            Dim totalA As Integer = 0
            Dim totalE As Integer = 0
            Dim totalI As Integer = 0
            Dim totalO As Integer = 0
            Dim totalU As Integer = 0
            Dim totalVocales As Integer = 0
            For i = 0 To (letras.Length - 1) Step 1 'recorro el Array (de tipo Char)
                Select Case letras(i)
                    Case = "a"
                        totalA += 1
                        totalVocales += 1
                    Case = "e"
                        totalE += 1
                        totalVocales += 1
                    Case = "i"
                        totalI += 1
                        totalVocales += 1
                    Case = "o"
                        totalO += 1
                        totalVocales += 1
                    Case = "u"
                        totalU += 1
                        totalVocales += 1
                End Select
            Next
            Dim m As String
            m = "Cant. a : " & totalA & "| Cant. e : " & totalE & " | Cant. i : " & totalI & " | Cant. o : " & totalO & " | Cant. u :" & totalU
            lblVocales.Text = m
            txtCantVocales.Enabled = True
            txtCantVocales.Text = totalVocales.ToString

            If radioBtnMayusculas.Checked Then
                txtEntrada.Text = UCase(txtEntrada.Text)
            Else
                txtEntrada.Text = LCase(txtEntrada.Text)
            End If
            If checkNegrita.Checked Then
                txtEntrada.Font = New Font(txtEntrada.Font, FontStyle.Bold) 'negrita
            End If
            If checkCursiva.Checked Then
                txtEntrada.Font = New Font(txtEntrada.Font, FontStyle.Italic) ' cursiva
            End If
            If checkSubrayado.Checked Then
                txtEntrada.Font = New Font(txtEntrada.Font, FontStyle.Underline) 'subrayado
            End If

            If radioBtnRojo.Checked Then
                txtEntrada.ForeColor = Color.Red
            ElseIf radioBtnAmarillo.Checked Then
                txtEntrada.ForeColor = Color.Yellow
            Else
                txtEntrada.ForeColor = Color.Green
            End If
        Else
                MsgBox("No se ingresó ningún texto para evaluar", vbCritical, "Error")
        End If
    End Sub
End Class
