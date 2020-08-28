<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelarIngr = New System.Windows.Forms.Button()
        Me.btnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cBoxTipoEmpl = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.txtSegApe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrimApe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSegNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrimNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudGuionCi = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnRefrescarDGV = New System.Windows.Forms.Button()
        Me.dgViewEmpleados = New System.Windows.Forms.DataGridView()
        Me.ci = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.primNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.segNmbr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.primApe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.segApe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sueldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudGuionCi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgViewEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(6, 33)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(43, 13)
        Me.lblCedula.TabIndex = 0
        Me.lblCedula.Text = "Cedula:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelarIngr)
        Me.GroupBox1.Controls.Add(Me.btnAgregarEmpleado)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtSegApe)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPrimApe)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSegNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPrimNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nudGuionCi)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.lblCedula)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Empleados:"
        '
        'btnCancelarIngr
        '
        Me.btnCancelarIngr.Location = New System.Drawing.Point(776, 66)
        Me.btnCancelarIngr.Name = "btnCancelarIngr"
        Me.btnCancelarIngr.Size = New System.Drawing.Size(161, 23)
        Me.btnCancelarIngr.TabIndex = 2
        Me.btnCancelarIngr.Text = "Borrar todo"
        Me.btnCancelarIngr.UseVisualStyleBackColor = True
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(776, 23)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(161, 23)
        Me.btnAgregarEmpleado.TabIndex = 12
        Me.btnAgregarEmpleado.Text = "AGREGAR"
        Me.btnAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cBoxTipoEmpl)
        Me.GroupBox3.Location = New System.Drawing.Point(636, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(134, 56)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo Empleado:"
        '
        'cBoxTipoEmpl
        '
        Me.cBoxTipoEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxTipoEmpl.FormattingEnabled = True
        Me.cBoxTipoEmpl.Items.AddRange(New Object() {"Común", "Administrativo", "Jefe"})
        Me.cBoxTipoEmpl.Location = New System.Drawing.Point(7, 19)
        Me.cBoxTipoEmpl.Name = "cBoxTipoEmpl"
        Me.cBoxTipoEmpl.Size = New System.Drawing.Size(121, 21)
        Me.cBoxTipoEmpl.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtSueldo)
        Me.GroupBox2.Location = New System.Drawing.Point(515, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 58)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sueldo Base:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "$"
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(19, 19)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(87, 20)
        Me.txtSueldo.TabIndex = 0
        '
        'txtSegApe
        '
        Me.txtSegApe.Location = New System.Drawing.Point(273, 63)
        Me.txtSegApe.Name = "txtSegApe"
        Me.txtSegApe.Size = New System.Drawing.Size(100, 20)
        Me.txtSegApe.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(183, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Segundo Apellido:"
        '
        'txtPrimApe
        '
        Me.txtPrimApe.Location = New System.Drawing.Point(82, 63)
        Me.txtPrimApe.Name = "txtPrimApe"
        Me.txtPrimApe.Size = New System.Drawing.Size(95, 20)
        Me.txtPrimApe.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Primer Apellido:"
        '
        'txtSegNombre
        '
        Me.txtSegNombre.Location = New System.Drawing.Point(404, 30)
        Me.txtSegNombre.Name = "txtSegNombre"
        Me.txtSegNombre.Size = New System.Drawing.Size(83, 20)
        Me.txtSegNombre.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(314, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Segundo Nombre:"
        '
        'txtPrimNombre
        '
        Me.txtPrimNombre.Location = New System.Drawing.Point(235, 30)
        Me.txtPrimNombre.Name = "txtPrimNombre"
        Me.txtPrimNombre.Size = New System.Drawing.Size(73, 20)
        Me.txtPrimNombre.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Primer Nombre:"
        '
        'nudGuionCi
        '
        Me.nudGuionCi.Location = New System.Drawing.Point(124, 30)
        Me.nudGuionCi.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudGuionCi.Name = "nudGuionCi"
        Me.nudGuionCi.ReadOnly = True
        Me.nudGuionCi.Size = New System.Drawing.Size(29, 20)
        Me.nudGuionCi.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "-"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(46, 30)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(56, 20)
        Me.txtCedula.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnRefrescarDGV)
        Me.GroupBox4.Controls.Add(Me.dgViewEmpleados)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(943, 246)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lista de todos los Empleados"
        '
        'btnRefrescarDGV
        '
        Me.btnRefrescarDGV.Location = New System.Drawing.Point(776, 19)
        Me.btnRefrescarDGV.Name = "btnRefrescarDGV"
        Me.btnRefrescarDGV.Size = New System.Drawing.Size(161, 23)
        Me.btnRefrescarDGV.TabIndex = 1
        Me.btnRefrescarDGV.Text = "Actualizar tabla"
        Me.btnRefrescarDGV.UseVisualStyleBackColor = True
        '
        'dgViewEmpleados
        '
        Me.dgViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgViewEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ci, Me.primNombre, Me.segNmbr, Me.primApe, Me.segApe, Me.sueldo, Me.tipoEmp})
        Me.dgViewEmpleados.Location = New System.Drawing.Point(9, 19)
        Me.dgViewEmpleados.Name = "dgViewEmpleados"
        Me.dgViewEmpleados.Size = New System.Drawing.Size(755, 221)
        Me.dgViewEmpleados.TabIndex = 0
        '
        'ci
        '
        Me.ci.HeaderText = "CI"
        Me.ci.Name = "ci"
        Me.ci.ReadOnly = True
        '
        'primNombre
        '
        Me.primNombre.HeaderText = "Primer Nombre"
        Me.primNombre.Name = "primNombre"
        Me.primNombre.ReadOnly = True
        '
        'segNmbr
        '
        Me.segNmbr.HeaderText = "Segundo Nombre"
        Me.segNmbr.Name = "segNmbr"
        Me.segNmbr.ReadOnly = True
        '
        'primApe
        '
        Me.primApe.HeaderText = "Primer Apellido"
        Me.primApe.Name = "primApe"
        Me.primApe.ReadOnly = True
        '
        'segApe
        '
        Me.segApe.HeaderText = "Segundo Apellido"
        Me.segApe.Name = "segApe"
        Me.segApe.ReadOnly = True
        '
        'sueldo
        '
        Me.sueldo.HeaderText = "Sueldo Base"
        Me.sueldo.Name = "sueldo"
        Me.sueldo.ReadOnly = True
        '
        'tipoEmp
        '
        Me.tipoEmp.HeaderText = "Tipo Empleado"
        Me.tipoEmp.Name = "tipoEmp"
        Me.tipoEmp.ReadOnly = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(880, 388)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 423)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrincipal"
        Me.Text = "Gestión de Empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudGuionCi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgViewEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCedula As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nudGuionCi As NumericUpDown
    Friend WithEvents txtSegNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrimNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSegApe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrimApe As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents btnCancelarIngr As Button
    Friend WithEvents btnAgregarEmpleado As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cBoxTipoEmpl As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgViewEmpleados As DataGridView
    Friend WithEvents ci As DataGridViewTextBoxColumn
    Friend WithEvents primNombre As DataGridViewTextBoxColumn
    Friend WithEvents segNmbr As DataGridViewTextBoxColumn
    Friend WithEvents primApe As DataGridViewTextBoxColumn
    Friend WithEvents segApe As DataGridViewTextBoxColumn
    Friend WithEvents sueldo As DataGridViewTextBoxColumn
    Friend WithEvents tipoEmp As DataGridViewTextBoxColumn
    Friend WithEvents btnRefrescarDGV As Button
    Friend WithEvents btnSalir As Button
End Class
