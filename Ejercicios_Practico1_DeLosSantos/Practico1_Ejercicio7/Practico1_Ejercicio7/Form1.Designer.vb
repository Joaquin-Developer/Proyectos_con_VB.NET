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
        Me.lblCadenaDeTexto = New System.Windows.Forms.Label()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.btnEvaluar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantVocales = New System.Windows.Forms.TextBox()
        Me.lblVocales = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radioBtnMayusculas = New System.Windows.Forms.RadioButton()
        Me.radioBtnMinusculas = New System.Windows.Forms.RadioButton()
        Me.checkNegrita = New System.Windows.Forms.CheckBox()
        Me.checkCursiva = New System.Windows.Forms.CheckBox()
        Me.checkSubrayado = New System.Windows.Forms.CheckBox()
        Me.radioBtnRojo = New System.Windows.Forms.RadioButton()
        Me.radioBtnAmarillo = New System.Windows.Forms.RadioButton()
        Me.radioBtnVerde = New System.Windows.Forms.RadioButton()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCadenaDeTexto
        '
        Me.lblCadenaDeTexto.AutoSize = True
        Me.lblCadenaDeTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCadenaDeTexto.Location = New System.Drawing.Point(3, 40)
        Me.lblCadenaDeTexto.Name = "lblCadenaDeTexto"
        Me.lblCadenaDeTexto.Size = New System.Drawing.Size(115, 16)
        Me.lblCadenaDeTexto.TabIndex = 0
        Me.lblCadenaDeTexto.Text = "Cadena de Texto:"
        '
        'txtEntrada
        '
        Me.txtEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntrada.Location = New System.Drawing.Point(116, 34)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(561, 26)
        Me.txtEntrada.TabIndex = 1
        '
        'btnEvaluar
        '
        Me.btnEvaluar.Location = New System.Drawing.Point(116, 66)
        Me.btnEvaluar.Name = "btnEvaluar"
        Me.btnEvaluar.Size = New System.Drawing.Size(561, 23)
        Me.btnEvaluar.TabIndex = 2
        Me.btnEvaluar.Text = "Evaluar carácteres"
        Me.btnEvaluar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cantidad total de carácteres:"
        '
        'txtCantVocales
        '
        Me.txtCantVocales.Enabled = False
        Me.txtCantVocales.Location = New System.Drawing.Point(152, 113)
        Me.txtCantVocales.Name = "txtCantVocales"
        Me.txtCantVocales.ReadOnly = True
        Me.txtCantVocales.Size = New System.Drawing.Size(31, 20)
        Me.txtCantVocales.TabIndex = 4
        '
        'lblVocales
        '
        Me.lblVocales.AutoSize = True
        Me.lblVocales.Location = New System.Drawing.Point(274, 116)
        Me.lblVocales.Name = "lblVocales"
        Me.lblVocales.Size = New System.Drawing.Size(283, 13)
        Me.lblVocales.TabIndex = 5
        Me.lblVocales.Text = "Cant. a : 0 | Cant. e : 0 | Cant. i : 0 | Cant. o : 0 | Cant. u : 0 "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioBtnVerde)
        Me.GroupBox1.Controls.Add(Me.radioBtnAmarillo)
        Me.GroupBox1.Controls.Add(Me.radioBtnRojo)
        Me.GroupBox1.Location = New System.Drawing.Point(402, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(141, 121)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.checkSubrayado)
        Me.GroupBox2.Controls.Add(Me.checkCursiva)
        Me.GroupBox2.Controls.Add(Me.checkNegrita)
        Me.GroupBox2.Location = New System.Drawing.Point(206, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 121)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Formato:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radioBtnMinusculas)
        Me.GroupBox3.Controls.Add(Me.radioBtnMayusculas)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(151, 100)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Convertir a:"
        '
        'radioBtnMayusculas
        '
        Me.radioBtnMayusculas.AutoSize = True
        Me.radioBtnMayusculas.Location = New System.Drawing.Point(22, 19)
        Me.radioBtnMayusculas.Name = "radioBtnMayusculas"
        Me.radioBtnMayusculas.Size = New System.Drawing.Size(81, 17)
        Me.radioBtnMayusculas.TabIndex = 0
        Me.radioBtnMayusculas.TabStop = True
        Me.radioBtnMayusculas.Text = "Mayúsculas"
        Me.radioBtnMayusculas.UseVisualStyleBackColor = True
        '
        'radioBtnMinusculas
        '
        Me.radioBtnMinusculas.AutoSize = True
        Me.radioBtnMinusculas.Location = New System.Drawing.Point(22, 51)
        Me.radioBtnMinusculas.Name = "radioBtnMinusculas"
        Me.radioBtnMinusculas.Size = New System.Drawing.Size(78, 17)
        Me.radioBtnMinusculas.TabIndex = 1
        Me.radioBtnMinusculas.TabStop = True
        Me.radioBtnMinusculas.Text = "Minúsculas"
        Me.radioBtnMinusculas.UseVisualStyleBackColor = True
        '
        'checkNegrita
        '
        Me.checkNegrita.AutoSize = True
        Me.checkNegrita.Location = New System.Drawing.Point(15, 20)
        Me.checkNegrita.Name = "checkNegrita"
        Me.checkNegrita.Size = New System.Drawing.Size(60, 17)
        Me.checkNegrita.TabIndex = 0
        Me.checkNegrita.Text = "Negrita"
        Me.checkNegrita.UseVisualStyleBackColor = True
        '
        'checkCursiva
        '
        Me.checkCursiva.AutoSize = True
        Me.checkCursiva.Location = New System.Drawing.Point(15, 51)
        Me.checkCursiva.Name = "checkCursiva"
        Me.checkCursiva.Size = New System.Drawing.Size(61, 17)
        Me.checkCursiva.TabIndex = 1
        Me.checkCursiva.Text = "Cursiva"
        Me.checkCursiva.UseVisualStyleBackColor = True
        '
        'checkSubrayado
        '
        Me.checkSubrayado.AutoSize = True
        Me.checkSubrayado.Location = New System.Drawing.Point(15, 83)
        Me.checkSubrayado.Name = "checkSubrayado"
        Me.checkSubrayado.Size = New System.Drawing.Size(77, 17)
        Me.checkSubrayado.TabIndex = 2
        Me.checkSubrayado.Text = "Subrayado"
        Me.checkSubrayado.UseVisualStyleBackColor = True
        '
        'radioBtnRojo
        '
        Me.radioBtnRojo.AutoSize = True
        Me.radioBtnRojo.Location = New System.Drawing.Point(18, 20)
        Me.radioBtnRojo.Name = "radioBtnRojo"
        Me.radioBtnRojo.Size = New System.Drawing.Size(47, 17)
        Me.radioBtnRojo.TabIndex = 0
        Me.radioBtnRojo.TabStop = True
        Me.radioBtnRojo.Text = "Rojo"
        Me.radioBtnRojo.UseVisualStyleBackColor = True
        '
        'radioBtnAmarillo
        '
        Me.radioBtnAmarillo.AutoSize = True
        Me.radioBtnAmarillo.Location = New System.Drawing.Point(18, 51)
        Me.radioBtnAmarillo.Name = "radioBtnAmarillo"
        Me.radioBtnAmarillo.Size = New System.Drawing.Size(61, 17)
        Me.radioBtnAmarillo.TabIndex = 1
        Me.radioBtnAmarillo.TabStop = True
        Me.radioBtnAmarillo.Text = "Amarillo"
        Me.radioBtnAmarillo.UseVisualStyleBackColor = True
        '
        'radioBtnVerde
        '
        Me.radioBtnVerde.AutoSize = True
        Me.radioBtnVerde.Location = New System.Drawing.Point(18, 82)
        Me.radioBtnVerde.Name = "radioBtnVerde"
        Me.radioBtnVerde.Size = New System.Drawing.Size(53, 17)
        Me.radioBtnVerde.TabIndex = 2
        Me.radioBtnVerde.TabStop = True
        Me.radioBtnVerde.Text = "Verde"
        Me.radioBtnVerde.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(602, 340)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.Text = "Salir"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 390)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblVocales)
        Me.Controls.Add(Me.txtCantVocales)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEvaluar)
        Me.Controls.Add(Me.txtEntrada)
        Me.Controls.Add(Me.lblCadenaDeTexto)
        Me.Name = "Form1"
        Me.Text = "Ejercicio 7 - Práctico 1 VB.NET"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCadenaDeTexto As Label
    Friend WithEvents txtEntrada As TextBox
    Friend WithEvents btnEvaluar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCantVocales As TextBox
    Friend WithEvents lblVocales As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents checkSubrayado As CheckBox
    Friend WithEvents checkCursiva As CheckBox
    Friend WithEvents checkNegrita As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radioBtnMinusculas As RadioButton
    Friend WithEvents radioBtnMayusculas As RadioButton
    Friend WithEvents radioBtnVerde As RadioButton
    Friend WithEvents radioBtnAmarillo As RadioButton
    Friend WithEvents radioBtnRojo As RadioButton
    Friend WithEvents btnCerrar As Button
End Class
