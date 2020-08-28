Public Class Form1
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtNombre.Text.Length = 0 Then
            MsgBox("No se ingresó ningún nombre", vbCritical, "Error")
        ElseIf validarNombre() Then
            ' caso que se valide correctamente el nombre
            lBoxNombres.Items.Add(txtNombre.Text)
            MsgBox("Se agregó nombre " & txtNombre.Text & " a la lista", vbInformation, "Nombre agregado con éxito")
            txtNombre.Text = "" ' dejamos vacío el nombre para seguir agregando
        Else
            ' caso contrario
            MsgBox(txtNombre.Text & "  no es un nombre valido", vbCritical, "Error al ingresar nombre a la lista")
            txtNombre.Text = ""
        End If
    End Sub

    Private Function validarNombre() As Boolean
        Dim esCorrecto As Boolean = True
        Dim caracteres() As Char = txtNombre.Text.ToCharArray
        Dim i, aux As Integer ' i: contador For, aux: variable auxiliar para intentar convertir a integer
        For i = 0 To (caracteres.Length - 1) Step 1
            If (Integer.TryParse(caracteres(i), aux)) Then
                esCorrecto = False
                Exit For ' en caso que sea afirmativo salimos, no es necesario seguir validando
                ' ya que con que un carácter del nombre sea un numero, ya no será valido.
            End If
        Next
        Return esCorrecto

    End Function

    Private Sub btnVaciarLista_Click(sender As Object, e As EventArgs) Handles btnVaciarLista.Click
        lBoxNombres.Items.Clear()
    End Sub

    Private Sub btnEliminarElemento_Click(sender As Object, e As EventArgs) Handles btnEliminarElemento.Click
        Try
            If lBoxNombres.SelectedItem = Nothing Then
                MsgBox("Debe seleccionar un elemento de la lista para eliminar", vbExclamation, "No se pudo eliminar elemento")
            Else
                Dim eliminado As String = lBoxNombres.SelectedItem.ToString
                If eliminado.Length <> 0 Then
                    MsgBox("Se eliminó el elemento " & eliminado, vbCritical, "")
                End If
                lBoxNombres.Items.Remove(lBoxNombres.SelectedItem)
            End If


        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
