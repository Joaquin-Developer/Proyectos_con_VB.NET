Public Class Form1
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub cBoxPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxPais.SelectedIndexChanged
        Select Case cBoxPais.SelectedIndex
            Case = 0 'Uruguay
                cBoxLocalidad.Items.Clear()
                cBoxLocalidad.Items.Add("Montevideo")
                cBoxLocalidad.Items.Add("Canelones")
                cBoxLocalidad.Items.Add("San José")
                cBoxLocalidad.Items.Add("Maldonado")
                cBoxLocalidad.Items.Add("Florida")
                cBoxLocalidad.Items.Add("Durazno")
                cBoxLocalidad.Items.Add("Rivera")
            Case = 1 'Argentina
                cBoxLocalidad.Items.Clear()
                cBoxLocalidad.Items.Add("Buenos Aires")
                cBoxLocalidad.Items.Add("Rosario")
                cBoxLocalidad.Items.Add("Mendoza")
                cBoxLocalidad.Items.Add("Santa Fé")
                cBoxLocalidad.Items.Add("Córdoba")
                cBoxLocalidad.Items.Add("Misiones")
            Case = 2 'Paraguay
                cBoxLocalidad.Items.Clear()
                cBoxLocalidad.Items.Add("Asunción")
                cBoxLocalidad.Items.Add("Ciudad del Éste")
                cBoxLocalidad.Items.Add("San Lorenzo")
            Case = 3 'Chile
                cBoxLocalidad.Items.Clear()
                cBoxLocalidad.Items.Add("Santiago")
                cBoxLocalidad.Items.Add("Concepción")
                cBoxLocalidad.Items.Add("La Serena")
                cBoxLocalidad.Items.Add("Temuco")
                cBoxLocalidad.Items.Add("Viña del Mar")
        End Select

    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ' SelectedItem es del tipo Object, debemos comprobar que no sean obnetos null.
        If cBoxPais.SelectedItem = Nothing Or cBoxLocalidad.SelectedItem = Nothing Then
            MsgBox("Debe seleccionar país y localidad.", vbCritical, "Error")
        Else
            ' con TOString convertimos el valor Object a tipo String.
            Dim pais As String = cBoxPais.SelectedItem.ToString
            Dim ciudad As String = cBoxLocalidad.SelectedItem.ToString
            ' no es tan necesario crear variables
            MsgBox("País: " & pais & " | Ciudad: " & ciudad, vbInformation, "Seleccionados:")

            'sin variables, se haría de la siguiente forma:
            'MsgBox("País: " & cBoxPais.SelectedItem.ToString & " | Ciudad: " & cBoxLocalidad.SelectedItem.ToString,
            '           vbCritical, "Seleccionado")
        End If

    End Sub
End Class
