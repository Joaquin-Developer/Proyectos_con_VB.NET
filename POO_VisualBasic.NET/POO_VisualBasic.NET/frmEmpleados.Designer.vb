<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Me.lbl_cedula = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.txt_primer_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_primer_nombre = New System.Windows.Forms.Label()
        Me.txt_segundo_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_segundo_nombre = New System.Windows.Forms.Label()
        Me.txt_segundo_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_segundo_apellido = New System.Windows.Forms.Label()
        Me.txt_primer_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_primer_apellido = New System.Windows.Forms.Label()
        Me.cboTiposEmpleados = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nivel_gerente = New System.Windows.Forms.TextBox()
        Me.lbl_nivel_gerente = New System.Windows.Forms.Label()
        Me.txt_sueldo_base = New System.Windows.Forms.TextBox()
        Me.lbl_sueldo_base = New System.Windows.Forms.Label()
        Me.txt_cantidad_horas = New System.Windows.Forms.TextBox()
        Me.lbl_cantidad_horas = New System.Windows.Forms.Label()
        Me.txt_precio_hora = New System.Windows.Forms.TextBox()
        Me.lbl_precio_hora = New System.Windows.Forms.Label()
        Me.txt_incentivo = New System.Windows.Forms.TextBox()
        Me.lbl_incentivo = New System.Windows.Forms.Label()
        Me.btn_agregar_empleado = New System.Windows.Forms.Button()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.btn_calcular_sueldo = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.lbl_total_a_pagar = New System.Windows.Forms.Label()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_cedula
        '
        Me.lbl_cedula.AutoSize = True
        Me.lbl_cedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cedula.Location = New System.Drawing.Point(12, 25)
        Me.lbl_cedula.Name = "lbl_cedula"
        Me.lbl_cedula.Size = New System.Drawing.Size(52, 17)
        Me.lbl_cedula.TabIndex = 0
        Me.lbl_cedula.Text = "Cedula"
        '
        'txt_cedula
        '
        Me.txt_cedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cedula.Location = New System.Drawing.Point(15, 42)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(103, 23)
        Me.txt_cedula.TabIndex = 1
        '
        'txt_primer_nombre
        '
        Me.txt_primer_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_primer_nombre.Location = New System.Drawing.Point(127, 42)
        Me.txt_primer_nombre.Name = "txt_primer_nombre"
        Me.txt_primer_nombre.Size = New System.Drawing.Size(150, 23)
        Me.txt_primer_nombre.TabIndex = 2
        '
        'lbl_primer_nombre
        '
        Me.lbl_primer_nombre.AutoSize = True
        Me.lbl_primer_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_primer_nombre.Location = New System.Drawing.Point(124, 25)
        Me.lbl_primer_nombre.Name = "lbl_primer_nombre"
        Me.lbl_primer_nombre.Size = New System.Drawing.Size(103, 17)
        Me.lbl_primer_nombre.TabIndex = 2
        Me.lbl_primer_nombre.Text = "Primer Nombre"
        '
        'txt_segundo_nombre
        '
        Me.txt_segundo_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_segundo_nombre.Location = New System.Drawing.Point(287, 42)
        Me.txt_segundo_nombre.Name = "txt_segundo_nombre"
        Me.txt_segundo_nombre.Size = New System.Drawing.Size(150, 23)
        Me.txt_segundo_nombre.TabIndex = 3
        '
        'lbl_segundo_nombre
        '
        Me.lbl_segundo_nombre.AutoSize = True
        Me.lbl_segundo_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_segundo_nombre.Location = New System.Drawing.Point(284, 25)
        Me.lbl_segundo_nombre.Name = "lbl_segundo_nombre"
        Me.lbl_segundo_nombre.Size = New System.Drawing.Size(119, 17)
        Me.lbl_segundo_nombre.TabIndex = 4
        Me.lbl_segundo_nombre.Text = "Segundo Nombre"
        '
        'txt_segundo_apellido
        '
        Me.txt_segundo_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_segundo_apellido.Location = New System.Drawing.Point(602, 42)
        Me.txt_segundo_apellido.Name = "txt_segundo_apellido"
        Me.txt_segundo_apellido.Size = New System.Drawing.Size(150, 23)
        Me.txt_segundo_apellido.TabIndex = 5
        '
        'lbl_segundo_apellido
        '
        Me.lbl_segundo_apellido.AutoSize = True
        Me.lbl_segundo_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_segundo_apellido.Location = New System.Drawing.Point(599, 25)
        Me.lbl_segundo_apellido.Name = "lbl_segundo_apellido"
        Me.lbl_segundo_apellido.Size = New System.Drawing.Size(119, 17)
        Me.lbl_segundo_apellido.TabIndex = 8
        Me.lbl_segundo_apellido.Text = "Segundo Apellido"
        '
        'txt_primer_apellido
        '
        Me.txt_primer_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_primer_apellido.Location = New System.Drawing.Point(445, 42)
        Me.txt_primer_apellido.Name = "txt_primer_apellido"
        Me.txt_primer_apellido.Size = New System.Drawing.Size(150, 23)
        Me.txt_primer_apellido.TabIndex = 4
        '
        'lbl_primer_apellido
        '
        Me.lbl_primer_apellido.AutoSize = True
        Me.lbl_primer_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_primer_apellido.Location = New System.Drawing.Point(442, 25)
        Me.lbl_primer_apellido.Name = "lbl_primer_apellido"
        Me.lbl_primer_apellido.Size = New System.Drawing.Size(103, 17)
        Me.lbl_primer_apellido.TabIndex = 6
        Me.lbl_primer_apellido.Text = "Primer Apellido"
        '
        'cboTiposEmpleados
        '
        Me.cboTiposEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTiposEmpleados.FormattingEnabled = True
        Me.cboTiposEmpleados.Items.AddRange(New Object() {"ADMINISTRADIVO/AS", "OPERARIO/AS", "GERENTE/AS"})
        Me.cboTiposEmpleados.Location = New System.Drawing.Point(239, 105)
        Me.cboTiposEmpleados.Name = "cboTiposEmpleados"
        Me.cboTiposEmpleados.Size = New System.Drawing.Size(289, 24)
        Me.cboTiposEmpleados.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Tipo Empleado"
        '
        'txt_nivel_gerente
        '
        Me.txt_nivel_gerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nivel_gerente.Location = New System.Drawing.Point(534, 106)
        Me.txt_nivel_gerente.Name = "txt_nivel_gerente"
        Me.txt_nivel_gerente.Size = New System.Drawing.Size(218, 23)
        Me.txt_nivel_gerente.TabIndex = 8
        '
        'lbl_nivel_gerente
        '
        Me.lbl_nivel_gerente.AutoSize = True
        Me.lbl_nivel_gerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nivel_gerente.Location = New System.Drawing.Point(531, 89)
        Me.lbl_nivel_gerente.Name = "lbl_nivel_gerente"
        Me.lbl_nivel_gerente.Size = New System.Drawing.Size(95, 17)
        Me.lbl_nivel_gerente.TabIndex = 12
        Me.lbl_nivel_gerente.Text = "Nivel Gerente"
        '
        'txt_sueldo_base
        '
        Me.txt_sueldo_base.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sueldo_base.Location = New System.Drawing.Point(15, 105)
        Me.txt_sueldo_base.Name = "txt_sueldo_base"
        Me.txt_sueldo_base.Size = New System.Drawing.Size(218, 23)
        Me.txt_sueldo_base.TabIndex = 6
        '
        'lbl_sueldo_base
        '
        Me.lbl_sueldo_base.AutoSize = True
        Me.lbl_sueldo_base.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sueldo_base.Location = New System.Drawing.Point(15, 88)
        Me.lbl_sueldo_base.Name = "lbl_sueldo_base"
        Me.lbl_sueldo_base.Size = New System.Drawing.Size(87, 17)
        Me.lbl_sueldo_base.TabIndex = 14
        Me.lbl_sueldo_base.Text = "Sueldo base"
        '
        'txt_cantidad_horas
        '
        Me.txt_cantidad_horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad_horas.Location = New System.Drawing.Point(15, 163)
        Me.txt_cantidad_horas.Name = "txt_cantidad_horas"
        Me.txt_cantidad_horas.Size = New System.Drawing.Size(169, 23)
        Me.txt_cantidad_horas.TabIndex = 9
        '
        'lbl_cantidad_horas
        '
        Me.lbl_cantidad_horas.AutoSize = True
        Me.lbl_cantidad_horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantidad_horas.Location = New System.Drawing.Point(12, 146)
        Me.lbl_cantidad_horas.Name = "lbl_cantidad_horas"
        Me.lbl_cantidad_horas.Size = New System.Drawing.Size(126, 17)
        Me.lbl_cantidad_horas.TabIndex = 16
        Me.lbl_cantidad_horas.Text = "Cantidad de Horas"
        '
        'txt_precio_hora
        '
        Me.txt_precio_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio_hora.Location = New System.Drawing.Point(193, 163)
        Me.txt_precio_hora.Name = "txt_precio_hora"
        Me.txt_precio_hora.Size = New System.Drawing.Size(170, 23)
        Me.txt_precio_hora.TabIndex = 10
        '
        'lbl_precio_hora
        '
        Me.lbl_precio_hora.AutoSize = True
        Me.lbl_precio_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio_hora.Location = New System.Drawing.Point(190, 146)
        Me.lbl_precio_hora.Name = "lbl_precio_hora"
        Me.lbl_precio_hora.Size = New System.Drawing.Size(83, 17)
        Me.lbl_precio_hora.TabIndex = 18
        Me.lbl_precio_hora.Text = "Precio Hora"
        '
        'txt_incentivo
        '
        Me.txt_incentivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_incentivo.Location = New System.Drawing.Point(524, 163)
        Me.txt_incentivo.Name = "txt_incentivo"
        Me.txt_incentivo.Size = New System.Drawing.Size(226, 23)
        Me.txt_incentivo.TabIndex = 11
        '
        'lbl_incentivo
        '
        Me.lbl_incentivo.AutoSize = True
        Me.lbl_incentivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_incentivo.Location = New System.Drawing.Point(521, 146)
        Me.lbl_incentivo.Name = "lbl_incentivo"
        Me.lbl_incentivo.Size = New System.Drawing.Size(156, 17)
        Me.lbl_incentivo.TabIndex = 20
        Me.lbl_incentivo.Text = "Incentivo Administrativo"
        '
        'btn_agregar_empleado
        '
        Me.btn_agregar_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_empleado.Location = New System.Drawing.Point(18, 212)
        Me.btn_agregar_empleado.Name = "btn_agregar_empleado"
        Me.btn_agregar_empleado.Size = New System.Drawing.Size(250, 32)
        Me.btn_agregar_empleado.TabIndex = 12
        Me.btn_agregar_empleado.Text = "Agregar Empleado"
        Me.btn_agregar_empleado.UseVisualStyleBackColor = True
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Location = New System.Drawing.Point(15, 289)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.Size = New System.Drawing.Size(737, 119)
        Me.dgvEmpleados.TabIndex = 23
        '
        'btn_calcular_sueldo
        '
        Me.btn_calcular_sueldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular_sueldo.Location = New System.Drawing.Point(287, 212)
        Me.btn_calcular_sueldo.Name = "btn_calcular_sueldo"
        Me.btn_calcular_sueldo.Size = New System.Drawing.Size(250, 32)
        Me.btn_calcular_sueldo.TabIndex = 13
        Me.btn_calcular_sueldo.Text = "Calcular Sueldo a pagar"
        Me.btn_calcular_sueldo.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Location = New System.Drawing.Point(559, 212)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(190, 32)
        Me.btn_salir.TabIndex = 14
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'lbl_total_a_pagar
        '
        Me.lbl_total_a_pagar.AutoSize = True
        Me.lbl_total_a_pagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_a_pagar.Location = New System.Drawing.Point(15, 269)
        Me.lbl_total_a_pagar.Name = "lbl_total_a_pagar"
        Me.lbl_total_a_pagar.Size = New System.Drawing.Size(171, 17)
        Me.lbl_total_a_pagar.TabIndex = 26
        Me.lbl_total_a_pagar.Text = "Monto total a pagar : 0.00"
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 422)
        Me.Controls.Add(Me.lbl_total_a_pagar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_calcular_sueldo)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Controls.Add(Me.btn_agregar_empleado)
        Me.Controls.Add(Me.txt_incentivo)
        Me.Controls.Add(Me.lbl_incentivo)
        Me.Controls.Add(Me.txt_precio_hora)
        Me.Controls.Add(Me.lbl_precio_hora)
        Me.Controls.Add(Me.txt_cantidad_horas)
        Me.Controls.Add(Me.lbl_cantidad_horas)
        Me.Controls.Add(Me.txt_sueldo_base)
        Me.Controls.Add(Me.lbl_sueldo_base)
        Me.Controls.Add(Me.txt_nivel_gerente)
        Me.Controls.Add(Me.lbl_nivel_gerente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboTiposEmpleados)
        Me.Controls.Add(Me.txt_segundo_apellido)
        Me.Controls.Add(Me.lbl_segundo_apellido)
        Me.Controls.Add(Me.txt_primer_apellido)
        Me.Controls.Add(Me.lbl_primer_apellido)
        Me.Controls.Add(Me.txt_segundo_nombre)
        Me.Controls.Add(Me.lbl_segundo_nombre)
        Me.Controls.Add(Me.txt_primer_nombre)
        Me.Controls.Add(Me.lbl_primer_nombre)
        Me.Controls.Add(Me.txt_cedula)
        Me.Controls.Add(Me.lbl_cedula)
        Me.Name = "frmEmpleados"
        Me.Text = "Mantenimiento de Empleados"
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_cedula As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents txt_primer_nombre As TextBox
    Friend WithEvents lbl_primer_nombre As Label
    Friend WithEvents txt_segundo_nombre As TextBox
    Friend WithEvents lbl_segundo_nombre As Label
    Friend WithEvents txt_segundo_apellido As TextBox
    Friend WithEvents lbl_segundo_apellido As Label
    Friend WithEvents txt_primer_apellido As TextBox
    Friend WithEvents lbl_primer_apellido As Label
    Friend WithEvents cboTiposEmpleados As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nivel_gerente As TextBox
    Friend WithEvents lbl_nivel_gerente As Label
    Friend WithEvents txt_sueldo_base As TextBox
    Friend WithEvents lbl_sueldo_base As Label
    Friend WithEvents txt_cantidad_horas As TextBox
    Friend WithEvents lbl_cantidad_horas As Label
    Friend WithEvents txt_precio_hora As TextBox
    Friend WithEvents lbl_precio_hora As Label
    Friend WithEvents txt_incentivo As TextBox
    Friend WithEvents lbl_incentivo As Label
    Friend WithEvents btn_agregar_empleado As Button
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents btn_calcular_sueldo As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents lbl_total_a_pagar As Label
End Class
