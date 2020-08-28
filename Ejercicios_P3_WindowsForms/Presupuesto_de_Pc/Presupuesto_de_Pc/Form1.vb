Public Class Form1
    Private subtotal As Double = 0.0
    Private impuesto As Double = 0.0
    Private total As Double = 0.0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ' Botón Generar Presupuesto
        Try
            Dim totalTipo As Double = precioTipo()
            Dim totalDisco As Double = precioDisco()
            Dim totalMarca As Double = precioMarca()
            Dim precioPerif As Double = precioPeriferico()
            subtotal = totalTipo + totalDisco + totalMarca + precioPerif
            impuesto = calcularIva(subtotal)
            total = subtotal + impuesto
            ' luego de calculado todo, seteamos los componentes TextBox de la GUI :
            txtSubTotal.Text = subtotal.ToString
            txtSubTotal.Enabled = True

            txtIva.Text = impuesto.ToString
            txtIva.Enabled = True

            txtTotal.Text = total.ToString
            txtTotal.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Se produjo un Error")
        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnBorrarTodo_Click(sender As Object, e As EventArgs) Handles btnBorrarTodo.Click
        inicializar()
    End Sub

    Private Function precioTipo() As Double
        If radioBtnPortable.Checked Then
            Return 2000.0
        Else
            Return 1000.0
        End If
    End Function
    Private Function precioDisco() As Double
        If radioBtn360gb.Checked Then
            Return 100.0
        ElseIf radioBtn512gb.Checked Then
            Return 150.0
        Else
            Return 200.0
        End If
    End Function
    Private Function precioMarca() As Double
        Select Case lBoxMarca.SelectedIndex
            Case = 0
                Return 500.0
            Case = 1
                Return 300.0
            Case = 2
                Return 150.0
        End Select
    End Function
    Private Function precioPeriferico() As Double
        Dim precio As Double = 0
        If checkImpresora.Checked Then
            precio += 7.0
        End If
        If checkEscaner.Checked Then
            precio += 3.0
        End If
        If checkCamara.Checked Then
            precio += 2.0
        End If
        Return precio
    End Function
    Private Function calcularIva(ByRef subtotal) As Double
        Return (subtotal * 0.22)

    End Function
    Private Sub inicializar()
        radioBtnPortable.Checked = True
        radioBtnEscritorio.Checked = False
        radioBtn360gb.Checked = True
        radioBtn512gb.Checked = False
        radioBtn1tb.Checked = False
        lBoxMarca.SelectedIndex = 0
        checkCamara.Checked = False
        checkEscaner.Checked = False
        checkImpresora.Checked = True
        subtotal = 0
        impuesto = 0
        total = 0
        txtIva.Text = String.Empty
        txtIva.Enabled = False
        txtSubTotal.Text = String.Empty
        txtSubTotal.Enabled = False
        txtTotal.Text = String.Empty
        txtTotal.Enabled = False
    End Sub

End Class
