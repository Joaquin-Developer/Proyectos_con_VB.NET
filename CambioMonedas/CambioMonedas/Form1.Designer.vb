<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Dolar", "41.40", "43.60"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Euro", "45.39", "50.39"}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Real", "7.52", "9.52"}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Peso Argentino", "0.17", "0.63"}, -1)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.checkPesosUY = New System.Windows.Forms.CheckBox()
        Me.radioBtnCompra = New System.Windows.Forms.RadioButton()
        Me.radioBtnVenta = New System.Windows.Forms.RadioButton()
        Me.cBoxMonedas = New System.Windows.Forms.ComboBox()
        Me.lvwCotizacion = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblVuelto = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Moneda:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto:"
        '
        'lblMonto
        '
        Me.lblMonto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonto.Location = New System.Drawing.Point(74, 17)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(184, 19)
        Me.lblMonto.TabIndex = 2
        Me.lblMonto.Text = "0"
        Me.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Monto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Vuelto:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(227, 24)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(190, 20)
        Me.txtMonto.TabIndex = 6
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(761, 48)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(75, 23)
        Me.btnCambiar.TabIndex = 7
        Me.btnCambiar.Text = "Cambiar"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'checkPesosUY
        '
        Me.checkPesosUY.AutoSize = True
        Me.checkPesosUY.Location = New System.Drawing.Point(423, 27)
        Me.checkPesosUY.Name = "checkPesosUY"
        Me.checkPesosUY.Size = New System.Drawing.Size(62, 17)
        Me.checkPesosUY.TabIndex = 8
        Me.checkPesosUY.Text = "en UY$"
        Me.checkPesosUY.UseVisualStyleBackColor = True
        '
        'radioBtnCompra
        '
        Me.radioBtnCompra.AutoSize = True
        Me.radioBtnCompra.Location = New System.Drawing.Point(21, 19)
        Me.radioBtnCompra.Name = "radioBtnCompra"
        Me.radioBtnCompra.Size = New System.Drawing.Size(61, 17)
        Me.radioBtnCompra.TabIndex = 9
        Me.radioBtnCompra.TabStop = True
        Me.radioBtnCompra.Text = "Compra"
        Me.radioBtnCompra.UseVisualStyleBackColor = True
        '
        'radioBtnVenta
        '
        Me.radioBtnVenta.AutoSize = True
        Me.radioBtnVenta.Location = New System.Drawing.Point(21, 42)
        Me.radioBtnVenta.Name = "radioBtnVenta"
        Me.radioBtnVenta.Size = New System.Drawing.Size(53, 17)
        Me.radioBtnVenta.TabIndex = 10
        Me.radioBtnVenta.TabStop = True
        Me.radioBtnVenta.Text = "Venta"
        Me.radioBtnVenta.UseVisualStyleBackColor = True
        '
        'cBoxMonedas
        '
        Me.cBoxMonedas.FormattingEnabled = True
        Me.cBoxMonedas.Items.AddRange(New Object() {"Dolar", "Euro", "Real", "Peso Argentino"})
        Me.cBoxMonedas.Location = New System.Drawing.Point(61, 23)
        Me.cBoxMonedas.Name = "cBoxMonedas"
        Me.cBoxMonedas.Size = New System.Drawing.Size(114, 21)
        Me.cBoxMonedas.TabIndex = 11
        '
        'lvwCotizacion
        '
        Me.lvwCotizacion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvwCotizacion.HideSelection = False
        Me.lvwCotizacion.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.lvwCotizacion.Location = New System.Drawing.Point(6, 19)
        Me.lvwCotizacion.Name = "lvwCotizacion"
        Me.lvwCotizacion.Size = New System.Drawing.Size(196, 129)
        Me.lvwCotizacion.TabIndex = 12
        Me.lvwCotizacion.UseCompatibleStateImageBehavior = False
        Me.lvwCotizacion.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Moneda"
        Me.ColumnHeader1.Width = 84
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Compra"
        Me.ColumnHeader2.Width = 54
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Venta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cBoxMonedas)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtMonto)
        Me.GroupBox2.Controls.Add(Me.checkPesosUY)
        Me.GroupBox2.Location = New System.Drawing.Point(226, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 85)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Moneda a cambiar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvwCotizacion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 157)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cotización de la Moneda"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radioBtnCompra)
        Me.GroupBox3.Controls.Add(Me.radioBtnVenta)
        Me.GroupBox3.Location = New System.Drawing.Point(226, 103)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(175, 66)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operación:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblVuelto)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.lblMonto)
        Me.GroupBox4.Location = New System.Drawing.Point(453, 103)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(284, 66)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cambio"
        '
        'lblVuelto
        '
        Me.lblVuelto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVuelto.Location = New System.Drawing.Point(74, 42)
        Me.lblVuelto.Name = "lblVuelto"
        Me.lblVuelto.Size = New System.Drawing.Size(184, 19)
        Me.lblVuelto.TabIndex = 5
        Me.lblVuelto.Text = "0"
        Me.lblVuelto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(761, 183)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 209)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCambiar)
        Me.Name = "Form1"
        Me.Text = "Cambio Monedas Internacionales"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents btnCambiar As Button
    Friend WithEvents checkPesosUY As CheckBox
    Friend WithEvents radioBtnCompra As RadioButton
    Friend WithEvents radioBtnVenta As RadioButton
    Friend WithEvents cBoxMonedas As ComboBox
    Friend WithEvents lvwCotizacion As ListView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblVuelto As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
