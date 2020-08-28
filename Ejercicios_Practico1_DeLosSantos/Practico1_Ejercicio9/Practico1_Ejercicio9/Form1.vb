Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listBoxTabla.Items.Clear()
        NumericOpDuwnNumero.Minimum = 0
    End Sub

    Private Sub btnMostrarTabla_Click(sender As Object, e As EventArgs) Handles btnMostrarTabla.Click
        Dim numero As Integer = NumericOpDuwnNumero.Value
        If listBoxTabla.Items.Count <> 0 Then
            listBoxTabla.Items.Clear()
        End If
        For i = 1 To 20 Step 1
            listBoxTabla.Items.Add(i & " x " & numero & " = " & (numero * i))
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        listBoxTabla.Items.Clear()
    End Sub
End Class
