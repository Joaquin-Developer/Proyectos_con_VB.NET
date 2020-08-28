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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cBoxSexo = New System.Windows.Forms.ComboBox()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.lblMtrs = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.nudEdad = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(24, 45)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(24, 80)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(47, 13)
        Me.lblApellido.TabIndex = 1
        Me.lblApellido.Text = "Apellido:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(86, 42)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(205, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(86, 77)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(205, 20)
        Me.txtApellido.TabIndex = 3
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(24, 117)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(35, 13)
        Me.lblEdad.TabIndex = 5
        Me.lblEdad.Text = "Edad:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(164, 117)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 6
        Me.lblSexo.Text = "Sexo:"
        '
        'cBoxSexo
        '
        Me.cBoxSexo.DisplayMember = "M"
        Me.cBoxSexo.FormattingEnabled = True
        Me.cBoxSexo.Items.AddRange(New Object() {"M", "F", "Otro"})
        Me.cBoxSexo.Location = New System.Drawing.Point(204, 114)
        Me.cBoxSexo.Name = "cBoxSexo"
        Me.cBoxSexo.Size = New System.Drawing.Size(87, 21)
        Me.cBoxSexo.TabIndex = 7
        Me.cBoxSexo.Text = "M"
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Location = New System.Drawing.Point(24, 158)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(37, 13)
        Me.lblAltura.TabIndex = 8
        Me.lblAltura.Text = "Altura:"
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(86, 155)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(72, 20)
        Me.txtAltura.TabIndex = 9
        '
        'lblMtrs
        '
        Me.lblMtrs.AutoSize = True
        Me.lblMtrs.Location = New System.Drawing.Point(164, 158)
        Me.lblMtrs.Name = "lblMtrs"
        Me.lblMtrs.Size = New System.Drawing.Size(38, 13)
        Me.lblMtrs.TabIndex = 10
        Me.lblMtrs.Text = "metros"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(216, 153)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 11
        Me.btnOk.Text = "Aceptar"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(216, 221)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 20)
        Me.btnBorrar.TabIndex = 12
        Me.btnBorrar.Text = "Borrar todo"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'nudEdad
        '
        Me.nudEdad.Location = New System.Drawing.Point(86, 115)
        Me.nudEdad.Name = "nudEdad"
        Me.nudEdad.Size = New System.Drawing.Size(72, 20)
        Me.nudEdad.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 253)
        Me.Controls.Add(Me.nudEdad)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblMtrs)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.lblAltura)
        Me.Controls.Add(Me.cBoxSexo)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "Form1"
        Me.Text = "Formulario de datos personales"
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents cBoxSexo As ComboBox
    Friend WithEvents lblAltura As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents lblMtrs As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents nudEdad As NumericUpDown
End Class
