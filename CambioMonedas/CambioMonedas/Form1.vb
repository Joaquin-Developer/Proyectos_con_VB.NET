Public Class Form1

    Enum Monedas
        Dolar = 0
        Euro
        Real
        PesoArg
    End Enum

    Enum Operacion
        Moneda = 0
        Compra
        Venta
    End Enum

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' a iniciar el formulario, estará seleccionado el elemento Dolar en el comboBox:
        cBoxMonedas.SelectedIndex = Monedas.Dolar
        radioBtnCompra.Checked = True

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea salir del programa?", vbQuestion + vbYesNo, "Mensaje") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub radioBtnVenta_CheckedChanged(sender As Object, e As EventArgs) Handles radioBtnVenta.CheckedChanged

        If radioBtnVenta.Checked Then
            checkPesosUY.Visible = True
        Else
            checkPesosUY.Visible = False
        End If
    End Sub

    Private Sub lvwCotizacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCotizacion.SelectedIndexChanged
        ' Evento para poder cambiar las cotizaciónes en ejecución
        Dim compra, venta, moneda As String
        Dim indice As Integer

        If lvwCotizacion.SelectedIndices.Count > 0 Then
            indice = lvwCotizacion.SelectedIndices.Item(0)
            moneda = lvwCotizacion.Items(indice).SubItems(Operacion.Moneda).Text

            If MsgBox("¿Desea cambiar la cotización del " + moneda + "?", vbQuestion + vbYesNo, "Mensaje") = MsgBoxResult.Yes Then
                compra = InputBox("Nueva cotización de compra " + moneda, vbQuestion, "0")
                lvwCotizacion.Items(indice).SubItems(Operacion.Compra).Text = compra
                venta = InputBox("Nueva cotización de venta " + moneda, vbQuestion, "0")
                lvwCotizacion.Items(indice).SubItems(Operacion.Venta).Text = venta

            End If
        End If
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        'Vamos a filtrar los caracteres permitidos en la caja de texto txtMonto
        ' Solo vamos a permitir el ingreso de números y el uso de la tecla retroceso o backspace
        If e.KeyChar < "0" Or e.KeyChar > "9" Then
            If e.KeyChar <> Chr(Keys.Back) Then
                e.KeyChar = ""
            End If
        End If

    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        Dim cotizacion As Decimal = 0
        If radioBtnCompra.Checked Then
            ' el cambio compra moneda extranjera
            cotizacion = Decimal.Parse(lvwCotizacion.Items(cBoxMonedas.SelectedIndex).SubItems(Operacion.Compra).Text)

        Else
            ' el cambio vende moneda extranjera
            cotizacion = Decimal.Parse(lvwCotizacion.Items(cBoxMonedas.SelectedIndex).SubItems(Operacion.Venta).Text)
            If checkPesosUY.Checked Then
                ' el Btn cliente tiene un monto en pesos uruguayos y quiere dicho monto en moneda extranjera
                ' como los cambios no tienen monedas de la moneda extranjera puede existir un vuelto en pesos uruguayos



            Else
                ' el monto ingresado es en moneda extranjera, debe indicar cuantos pesos URU se necesitan para transacción


            End If

        End If

    End Sub

End Class
