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
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlVerForms = New System.Windows.Forms.Panel()
        Me.pnlBarraMenu = New System.Windows.Forms.Panel()
        Me.btnVerForm3 = New System.Windows.Forms.Button()
        Me.btnVerForm2 = New System.Windows.Forms.Button()
        Me.btnVerForm1 = New System.Windows.Forms.Button()
        Me.pnlBarraTitulo = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.picBoxCerrar = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlContenedor.SuspendLayout()
        Me.pnlBarraMenu.SuspendLayout()
        Me.pnlBarraTitulo.SuspendLayout()
        CType(Me.picBoxCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlContenedor.Controls.Add(Me.pnlVerForms)
        Me.pnlContenedor.Controls.Add(Me.pnlBarraMenu)
        Me.pnlContenedor.Controls.Add(Me.pnlBarraTitulo)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1100, 600)
        Me.pnlContenedor.TabIndex = 0
        '
        'pnlVerForms
        '
        Me.pnlVerForms.BackColor = System.Drawing.Color.White
        Me.pnlVerForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlVerForms.Location = New System.Drawing.Point(250, 40)
        Me.pnlVerForms.Name = "pnlVerForms"
        Me.pnlVerForms.Size = New System.Drawing.Size(850, 560)
        Me.pnlVerForms.TabIndex = 2
        '
        'pnlBarraMenu
        '
        Me.pnlBarraMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlBarraMenu.Controls.Add(Me.btnVerForm3)
        Me.pnlBarraMenu.Controls.Add(Me.btnVerForm2)
        Me.pnlBarraMenu.Controls.Add(Me.btnVerForm1)
        Me.pnlBarraMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBarraMenu.Location = New System.Drawing.Point(0, 40)
        Me.pnlBarraMenu.Name = "pnlBarraMenu"
        Me.pnlBarraMenu.Size = New System.Drawing.Size(250, 560)
        Me.pnlBarraMenu.TabIndex = 1
        '
        'btnVerForm3
        '
        Me.btnVerForm3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnVerForm3.FlatAppearance.BorderSize = 0
        Me.btnVerForm3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerForm3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnVerForm3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerForm3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerForm3.ForeColor = System.Drawing.Color.White
        Me.btnVerForm3.Location = New System.Drawing.Point(0, 186)
        Me.btnVerForm3.Name = "btnVerForm3"
        Me.btnVerForm3.Size = New System.Drawing.Size(250, 40)
        Me.btnVerForm3.TabIndex = 2
        Me.btnVerForm3.Text = "Formulario 3"
        Me.btnVerForm3.UseVisualStyleBackColor = False
        '
        'btnVerForm2
        '
        Me.btnVerForm2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnVerForm2.FlatAppearance.BorderSize = 0
        Me.btnVerForm2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerForm2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnVerForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerForm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerForm2.ForeColor = System.Drawing.Color.White
        Me.btnVerForm2.Location = New System.Drawing.Point(0, 140)
        Me.btnVerForm2.Name = "btnVerForm2"
        Me.btnVerForm2.Size = New System.Drawing.Size(250, 40)
        Me.btnVerForm2.TabIndex = 1
        Me.btnVerForm2.Text = "Formulario 2"
        Me.btnVerForm2.UseVisualStyleBackColor = False
        '
        'btnVerForm1
        '
        Me.btnVerForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnVerForm1.FlatAppearance.BorderSize = 0
        Me.btnVerForm1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVerForm1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnVerForm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerForm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerForm1.ForeColor = System.Drawing.Color.White
        Me.btnVerForm1.Location = New System.Drawing.Point(0, 94)
        Me.btnVerForm1.Name = "btnVerForm1"
        Me.btnVerForm1.Size = New System.Drawing.Size(250, 40)
        Me.btnVerForm1.TabIndex = 0
        Me.btnVerForm1.Text = "Formulario 1"
        Me.btnVerForm1.UseVisualStyleBackColor = False
        '
        'pnlBarraTitulo
        '
        Me.pnlBarraTitulo.BackColor = System.Drawing.Color.Navy
        Me.pnlBarraTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.pnlBarraTitulo.Controls.Add(Me.picBoxCerrar)
        Me.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlBarraTitulo.Name = "pnlBarraTitulo"
        Me.pnlBarraTitulo.Size = New System.Drawing.Size(1100, 40)
        Me.pnlBarraTitulo.TabIndex = 0
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizar.Location = New System.Drawing.Point(1023, 12)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(31, 16)
        Me.btnMinimizar.TabIndex = 0
        Me.btnMinimizar.Text = "-"
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'picBoxCerrar
        '
        Me.picBoxCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBoxCerrar.Image = Global.Sistema_Consulta_Medica_AppCliente.My.Resources.Resources.iconoCerrar
        Me.picBoxCerrar.Location = New System.Drawing.Point(1060, 4)
        Me.picBoxCerrar.Name = "picBoxCerrar"
        Me.picBoxCerrar.Size = New System.Drawing.Size(37, 33)
        Me.picBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxCerrar.TabIndex = 0
        Me.picBoxCerrar.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Navy
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(33, 15)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(179, 16)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Sistema de Consulta Médica"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 600)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "FormPrincipal"
        Me.Text = "Form1"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlBarraMenu.ResumeLayout(False)
        Me.pnlBarraTitulo.ResumeLayout(False)
        Me.pnlBarraTitulo.PerformLayout()
        CType(Me.picBoxCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlBarraTitulo As Panel
    Friend WithEvents pnlBarraMenu As Panel
    Friend WithEvents pnlVerForms As Panel
    Friend WithEvents picBoxCerrar As PictureBox
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnVerForm1 As Button
    Friend WithEvents btnVerForm2 As Button
    Friend WithEvents btnVerForm3 As Button
    Friend WithEvents lblTitulo As Label
End Class
