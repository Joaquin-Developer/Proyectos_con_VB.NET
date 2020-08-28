Public Class Form1
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        lBoxLista.Items.Add(txtElemento.Text)
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        lBoxLista.Items.Remove(lBoxLista.SelectedItem)
    End Sub

    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        lBoxLista.Items.Clear()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
