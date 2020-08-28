<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAccesoNativoMySQL
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btConectar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lsBD = New System.Windows.Forms.ComboBox()
        Me.txtPuerto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtServidor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.opDatos = New System.Windows.Forms.RadioButton()
        Me.opNoDatos = New System.Windows.Forms.RadioButton()
        Me.btEjecutar = New System.Windows.Forms.Button()
        Me.txtSQL = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.bePanel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bePanel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btUsarEsquema = New System.Windows.Forms.Button()
        Me.bePanelNumTablas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bePanelNumRegistros = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btUsarEsquema)
        Me.GroupBox1.Controls.Add(Me.btConectar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lsBD)
        Me.GroupBox1.Controls.Add(Me.txtPuerto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtServidor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtContrasena)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de conexión con servidor MySQL "
        '
        'btConectar
        '
        Me.btConectar.Location = New System.Drawing.Point(455, 33)
        Me.btConectar.Name = "btConectar"
        Me.btConectar.Size = New System.Drawing.Size(175, 43)
        Me.btConectar.TabIndex = 6
        Me.btConectar.Text = "Conectar con servidor"
        Me.ToolTip1.SetToolTip(Me.btConectar, "Conectar con servidor de MySQL Server")
        Me.btConectar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Usar el esquema (BD)"
        '
        'lsBD
        '
        Me.lsBD.FormattingEnabled = True
        Me.lsBD.Location = New System.Drawing.Point(124, 83)
        Me.lsBD.Name = "lsBD"
        Me.lsBD.Size = New System.Drawing.Size(321, 21)
        Me.lsBD.TabIndex = 4
        '
        'txtPuerto
        '
        Me.txtPuerto.Location = New System.Drawing.Point(356, 34)
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(89, 20)
        Me.txtPuerto.TabIndex = 1
        Me.txtPuerto.Text = "3306"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Puerto"
        '
        'txtServidor
        '
        Me.txtServidor.Location = New System.Drawing.Point(124, 31)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(150, 20)
        Me.txtServidor.TabIndex = 0
        Me.txtServidor.Text = "localhost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Servidor"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(356, 56)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(89, 20)
        Me.txtContrasena.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(124, 57)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(150, 20)
        Me.txtUsuario.TabIndex = 2
        Me.txtUsuario.Text = "root"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.opDatos)
        Me.GroupBox2.Controls.Add(Me.opNoDatos)
        Me.GroupBox2.Controls.Add(Me.btEjecutar)
        Me.GroupBox2.Controls.Add(Me.txtSQL)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(636, 122)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consulta SQL a ejecutar "
        '
        'opDatos
        '
        Me.opDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opDatos.AutoSize = True
        Me.opDatos.Checked = True
        Me.opDatos.Location = New System.Drawing.Point(515, 47)
        Me.opDatos.Name = "opDatos"
        Me.opDatos.Size = New System.Drawing.Size(100, 17)
        Me.opDatos.TabIndex = 2
        Me.opDatos.TabStop = True
        Me.opDatos.Text = "Devuelve datos"
        Me.ToolTip1.SetToolTip(Me.opDatos, "Consulta SQL que devuelve registros (SELECT)")
        Me.opDatos.UseVisualStyleBackColor = True
        '
        'opNoDatos
        '
        Me.opNoDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opNoDatos.AutoSize = True
        Me.opNoDatos.Location = New System.Drawing.Point(515, 20)
        Me.opNoDatos.Name = "opNoDatos"
        Me.opNoDatos.Size = New System.Drawing.Size(115, 17)
        Me.opNoDatos.TabIndex = 1
        Me.opNoDatos.TabStop = True
        Me.opNoDatos.Text = "No devuelve datos"
        Me.ToolTip1.SetToolTip(Me.opNoDatos, "Consulta SQL que no devuelve registros (DELETE, INSERT, UPDATE)")
        Me.opNoDatos.UseVisualStyleBackColor = True
        '
        'btEjecutar
        '
        Me.btEjecutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btEjecutar.Location = New System.Drawing.Point(515, 87)
        Me.btEjecutar.Name = "btEjecutar"
        Me.btEjecutar.Size = New System.Drawing.Size(115, 29)
        Me.btEjecutar.TabIndex = 3
        Me.btEjecutar.Text = "Ejecutar"
        Me.ToolTip1.SetToolTip(Me.btEjecutar, "Ejecutar consulta SQL especificada")
        Me.btEjecutar.UseVisualStyleBackColor = True
        '
        'txtSQL
        '
        Me.txtSQL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSQL.Location = New System.Drawing.Point(6, 19)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSQL.Size = New System.Drawing.Size(498, 97)
        Me.txtSQL.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 259)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(636, 196)
        Me.DataGridView1.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bePanel1, Me.bePanel2, Me.bePanelNumTablas, Me.bePanelNumRegistros})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 462)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.ShowItemToolTips = True
        Me.StatusStrip1.Size = New System.Drawing.Size(660, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'bePanel1
        '
        Me.bePanel1.AutoToolTip = True
        Me.bePanel1.Name = "bePanel1"
        Me.bePanel1.Size = New System.Drawing.Size(0, 17)
        '
        'bePanel2
        '
        Me.bePanel2.Name = "bePanel2"
        Me.bePanel2.Size = New System.Drawing.Size(0, 17)
        '
        'btUsarEsquema
        '
        Me.btUsarEsquema.Location = New System.Drawing.Point(455, 80)
        Me.btUsarEsquema.Name = "btUsarEsquema"
        Me.btUsarEsquema.Size = New System.Drawing.Size(175, 26)
        Me.btUsarEsquema.TabIndex = 10
        Me.btUsarEsquema.Text = "Usar el esquema"
        Me.ToolTip1.SetToolTip(Me.btUsarEsquema, "Usar la base de datos (esquema) seleccionado")
        Me.btUsarEsquema.UseVisualStyleBackColor = True
        '
        'bePanelNumTablas
        '
        Me.bePanelNumTablas.Name = "bePanelNumTablas"
        Me.bePanelNumTablas.Size = New System.Drawing.Size(0, 17)
        '
        'bePanelNumRegistros
        '
        Me.bePanelNumRegistros.Name = "bePanelNumRegistros"
        Me.bePanelNumRegistros.Size = New System.Drawing.Size(0, 17)
        Me.bePanelNumRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'formAccesoNativoMySQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 484)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formAccesoNativoMySQL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AjpdSoft Acceso nativo MySQL VB.Net"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lsBD As System.Windows.Forms.ComboBox
    Friend WithEvents txtPuerto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtServidor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btEjecutar As System.Windows.Forms.Button
    Friend WithEvents txtSQL As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btConectar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents opDatos As System.Windows.Forms.RadioButton
    Friend WithEvents opNoDatos As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents bePanel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bePanel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btUsarEsquema As System.Windows.Forms.Button
    Friend WithEvents bePanelNumTablas As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bePanelNumRegistros As System.Windows.Forms.ToolStripStatusLabel

End Class
