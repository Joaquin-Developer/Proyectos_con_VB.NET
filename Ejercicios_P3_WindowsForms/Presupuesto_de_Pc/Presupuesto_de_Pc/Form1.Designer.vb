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
        Me.GroupBoxTipo = New System.Windows.Forms.GroupBox()
        Me.radioBtnEscritorio = New System.Windows.Forms.RadioButton()
        Me.radioBtnPortable = New System.Windows.Forms.RadioButton()
        Me.GroupBoxDisco = New System.Windows.Forms.GroupBox()
        Me.radioBtn1tb = New System.Windows.Forms.RadioButton()
        Me.radioBtn512gb = New System.Windows.Forms.RadioButton()
        Me.radioBtn360gb = New System.Windows.Forms.RadioButton()
        Me.GroupBoxMarca = New System.Windows.Forms.GroupBox()
        Me.lBoxMarca = New System.Windows.Forms.ListBox()
        Me.GroupBoxPeriferico = New System.Windows.Forms.GroupBox()
        Me.checkCamara = New System.Windows.Forms.CheckBox()
        Me.checkEscaner = New System.Windows.Forms.CheckBox()
        Me.checkImpresora = New System.Windows.Forms.CheckBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnBorrarTodo = New System.Windows.Forms.Button()
        Me.GroupBoxTipo.SuspendLayout()
        Me.GroupBoxDisco.SuspendLayout()
        Me.GroupBoxMarca.SuspendLayout()
        Me.GroupBoxPeriferico.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxTipo
        '
        Me.GroupBoxTipo.Controls.Add(Me.radioBtnEscritorio)
        Me.GroupBoxTipo.Controls.Add(Me.radioBtnPortable)
        Me.GroupBoxTipo.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxTipo.Name = "GroupBoxTipo"
        Me.GroupBoxTipo.Size = New System.Drawing.Size(128, 95)
        Me.GroupBoxTipo.TabIndex = 0
        Me.GroupBoxTipo.TabStop = False
        Me.GroupBoxTipo.Text = "Tipo"
        '
        'radioBtnEscritorio
        '
        Me.radioBtnEscritorio.AutoSize = True
        Me.radioBtnEscritorio.Location = New System.Drawing.Point(19, 42)
        Me.radioBtnEscritorio.Name = "radioBtnEscritorio"
        Me.radioBtnEscritorio.Size = New System.Drawing.Size(65, 17)
        Me.radioBtnEscritorio.TabIndex = 1
        Me.radioBtnEscritorio.TabStop = True
        Me.radioBtnEscritorio.Text = "Desktop"
        Me.radioBtnEscritorio.UseVisualStyleBackColor = True
        '
        'radioBtnPortable
        '
        Me.radioBtnPortable.AutoSize = True
        Me.radioBtnPortable.Location = New System.Drawing.Point(19, 19)
        Me.radioBtnPortable.Name = "radioBtnPortable"
        Me.radioBtnPortable.Size = New System.Drawing.Size(64, 17)
        Me.radioBtnPortable.TabIndex = 0
        Me.radioBtnPortable.TabStop = True
        Me.radioBtnPortable.Text = "Portable"
        Me.radioBtnPortable.UseVisualStyleBackColor = True
        '
        'GroupBoxDisco
        '
        Me.GroupBoxDisco.Controls.Add(Me.radioBtn1tb)
        Me.GroupBoxDisco.Controls.Add(Me.radioBtn512gb)
        Me.GroupBoxDisco.Controls.Add(Me.radioBtn360gb)
        Me.GroupBoxDisco.Location = New System.Drawing.Point(146, 12)
        Me.GroupBoxDisco.Name = "GroupBoxDisco"
        Me.GroupBoxDisco.Size = New System.Drawing.Size(134, 95)
        Me.GroupBoxDisco.TabIndex = 1
        Me.GroupBoxDisco.TabStop = False
        Me.GroupBoxDisco.Text = "Tamaño del Disco Duro"
        '
        'radioBtn1tb
        '
        Me.radioBtn1tb.AutoSize = True
        Me.radioBtn1tb.Location = New System.Drawing.Point(6, 66)
        Me.radioBtn1tb.Name = "radioBtn1tb"
        Me.radioBtn1tb.Size = New System.Drawing.Size(48, 17)
        Me.radioBtn1tb.TabIndex = 2
        Me.radioBtn1tb.TabStop = True
        Me.radioBtn1tb.Text = "1 TB"
        Me.radioBtn1tb.UseVisualStyleBackColor = True
        '
        'radioBtn512gb
        '
        Me.radioBtn512gb.AutoSize = True
        Me.radioBtn512gb.Location = New System.Drawing.Point(6, 42)
        Me.radioBtn512gb.Name = "radioBtn512gb"
        Me.radioBtn512gb.Size = New System.Drawing.Size(61, 17)
        Me.radioBtn512gb.TabIndex = 1
        Me.radioBtn512gb.TabStop = True
        Me.radioBtn512gb.Text = "512 GB"
        Me.radioBtn512gb.UseVisualStyleBackColor = True
        '
        'radioBtn360gb
        '
        Me.radioBtn360gb.AutoSize = True
        Me.radioBtn360gb.Location = New System.Drawing.Point(6, 19)
        Me.radioBtn360gb.Name = "radioBtn360gb"
        Me.radioBtn360gb.Size = New System.Drawing.Size(61, 17)
        Me.radioBtn360gb.TabIndex = 0
        Me.radioBtn360gb.TabStop = True
        Me.radioBtn360gb.Text = "360 GB"
        Me.radioBtn360gb.UseVisualStyleBackColor = True
        '
        'GroupBoxMarca
        '
        Me.GroupBoxMarca.Controls.Add(Me.lBoxMarca)
        Me.GroupBoxMarca.Location = New System.Drawing.Point(286, 12)
        Me.GroupBoxMarca.Name = "GroupBoxMarca"
        Me.GroupBoxMarca.Size = New System.Drawing.Size(107, 95)
        Me.GroupBoxMarca.TabIndex = 2
        Me.GroupBoxMarca.TabStop = False
        Me.GroupBoxMarca.Text = "Marca"
        '
        'lBoxMarca
        '
        Me.lBoxMarca.FormattingEnabled = True
        Me.lBoxMarca.Items.AddRange(New Object() {"IBM", "COMPAQ", "CLON"})
        Me.lBoxMarca.Location = New System.Drawing.Point(6, 19)
        Me.lBoxMarca.Name = "lBoxMarca"
        Me.lBoxMarca.Size = New System.Drawing.Size(90, 69)
        Me.lBoxMarca.TabIndex = 0
        '
        'GroupBoxPeriferico
        '
        Me.GroupBoxPeriferico.Controls.Add(Me.checkCamara)
        Me.GroupBoxPeriferico.Controls.Add(Me.checkEscaner)
        Me.GroupBoxPeriferico.Controls.Add(Me.checkImpresora)
        Me.GroupBoxPeriferico.Location = New System.Drawing.Point(399, 12)
        Me.GroupBoxPeriferico.Name = "GroupBoxPeriferico"
        Me.GroupBoxPeriferico.Size = New System.Drawing.Size(96, 95)
        Me.GroupBoxPeriferico.TabIndex = 3
        Me.GroupBoxPeriferico.TabStop = False
        Me.GroupBoxPeriferico.Text = "Periferico"
        '
        'checkCamara
        '
        Me.checkCamara.AutoSize = True
        Me.checkCamara.Location = New System.Drawing.Point(6, 66)
        Me.checkCamara.Name = "checkCamara"
        Me.checkCamara.Size = New System.Drawing.Size(62, 17)
        Me.checkCamara.TabIndex = 2
        Me.checkCamara.Text = "Cámara"
        Me.checkCamara.UseVisualStyleBackColor = True
        '
        'checkEscaner
        '
        Me.checkEscaner.AutoSize = True
        Me.checkEscaner.Location = New System.Drawing.Point(6, 42)
        Me.checkEscaner.Name = "checkEscaner"
        Me.checkEscaner.Size = New System.Drawing.Size(65, 17)
        Me.checkEscaner.TabIndex = 1
        Me.checkEscaner.Text = "Escáner"
        Me.checkEscaner.UseVisualStyleBackColor = True
        '
        'checkImpresora
        '
        Me.checkImpresora.AutoSize = True
        Me.checkImpresora.Location = New System.Drawing.Point(6, 20)
        Me.checkImpresora.Name = "checkImpresora"
        Me.checkImpresora.Size = New System.Drawing.Size(72, 17)
        Me.checkImpresora.TabIndex = 0
        Me.checkImpresora.Text = "Impresora"
        Me.checkImpresora.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(518, 50)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(121, 23)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "Generar Presupuesto"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(612, 288)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "SubTotal: $"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total: $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "I.V.A. $"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(152, 139)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(84, 20)
        Me.txtSubTotal.TabIndex = 9
        '
        'txtIva
        '
        Me.txtIva.Enabled = False
        Me.txtIva.Location = New System.Drawing.Point(152, 163)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.ReadOnly = True
        Me.txtIva.Size = New System.Drawing.Size(84, 20)
        Me.txtIva.TabIndex = 10
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(152, 189)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(84, 20)
        Me.txtTotal.TabIndex = 11
        '
        'btnBorrarTodo
        '
        Me.btnBorrarTodo.Location = New System.Drawing.Point(518, 84)
        Me.btnBorrarTodo.Name = "btnBorrarTodo"
        Me.btnBorrarTodo.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrarTodo.TabIndex = 12
        Me.btnBorrarTodo.Text = "Borrar todo"
        Me.btnBorrarTodo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 323)
        Me.Controls.Add(Me.btnBorrarTodo)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBoxPeriferico)
        Me.Controls.Add(Me.GroupBoxMarca)
        Me.Controls.Add(Me.GroupBoxDisco)
        Me.Controls.Add(Me.GroupBoxTipo)
        Me.Name = "Form1"
        Me.Text = "Cálculo de Presupuesto"
        Me.GroupBoxTipo.ResumeLayout(False)
        Me.GroupBoxTipo.PerformLayout()
        Me.GroupBoxDisco.ResumeLayout(False)
        Me.GroupBoxDisco.PerformLayout()
        Me.GroupBoxMarca.ResumeLayout(False)
        Me.GroupBoxPeriferico.ResumeLayout(False)
        Me.GroupBoxPeriferico.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxTipo As GroupBox
    Friend WithEvents radioBtnEscritorio As RadioButton
    Friend WithEvents radioBtnPortable As RadioButton
    Friend WithEvents GroupBoxDisco As GroupBox
    Friend WithEvents radioBtn1tb As RadioButton
    Friend WithEvents radioBtn512gb As RadioButton
    Friend WithEvents radioBtn360gb As RadioButton
    Friend WithEvents GroupBoxMarca As GroupBox
    Friend WithEvents lBoxMarca As ListBox
    Friend WithEvents GroupBoxPeriferico As GroupBox
    Friend WithEvents checkEscaner As CheckBox
    Friend WithEvents checkImpresora As CheckBox
    Friend WithEvents checkCamara As CheckBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtIva As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnBorrarTodo As Button
End Class
