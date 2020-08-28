Public Class Principal

    Private Sub CBoxPaises_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBoxPaises.SelectedIndexChanged
        Select Case CBoxPaises.SelectedIndex
            Case Is = 0 ' index inicia en cero
                lboxLocalidades.Items.Clear()   'primero limpiamos los elementos que puedan haber en el ListBox
                lboxLocalidades.Items.Add("Montevideo")
                lboxLocalidades.Items.Add("Canelones")
                lboxLocalidades.Items.Add("San José")
                lboxLocalidades.Items.Add("Maldonado")
                lboxLocalidades.Items.Add("Durazno")
                lboxLocalidades.Items.Add("Rivera")
            Case Is = 1
                lboxLocalidades.Items.Clear()
                lboxLocalidades.Items.Add("Sao Paulo")
                lboxLocalidades.Items.Add("Brasilia")
                lboxLocalidades.Items.Add("Porto Alegre")
            Case Is = 2
                lboxLocalidades.Items.Clear()
                lboxLocalidades.Items.Add("Buenos Aires")
                lboxLocalidades.Items.Add("Cordoba")
                lboxLocalidades.Items.Add("Santa Fé")
                lboxLocalidades.Items.Add("Rosario")

        End Select

    End Sub
End Class
