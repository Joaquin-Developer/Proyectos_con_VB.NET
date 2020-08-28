<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFragm1 = New System.Windows.Forms.Label()
        Me.lblFragm2 = New System.Windows.Forms.Label()
        Me.txtFragm1 = New System.Windows.Forms.TextBox()
        Me.txtFragm2 = New System.Windows.Forms.TextBox()
        Me.lblFragm3 = New System.Windows.Forms.Label()
        Me.txtFragm3 = New System.Windows.Forms.TextBox()
        Me.btnFrase = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFragm1
        '
        Me.lblFragm1.AutoSize = True
        Me.lblFragm1.Location = New System.Drawing.Point(74, 61)
        Me.lblFragm1.Name = "lblFragm1"
        Me.lblFragm1.Size = New System.Drawing.Size(69, 13)
        Me.lblFragm1.TabIndex = 0
        Me.lblFragm1.Text = "Fragmento 1:"
        '
        'lblFragm2
        '
        Me.lblFragm2.AutoSize = True
        Me.lblFragm2.Location = New System.Drawing.Point(74, 95)
        Me.lblFragm2.Name = "lblFragm2"
        Me.lblFragm2.Size = New System.Drawing.Size(69, 13)
        Me.lblFragm2.TabIndex = 1
        Me.lblFragm2.Text = "Fragmento 2:"
        '
        'txtFragm1
        '
        Me.txtFragm1.Location = New System.Drawing.Point(149, 58)
        Me.txtFragm1.Name = "txtFragm1"
        Me.txtFragm1.Size = New System.Drawing.Size(162, 20)
        Me.txtFragm1.TabIndex = 2
        '
        'txtFragm2
        '
        Me.txtFragm2.Location = New System.Drawing.Point(149, 92)
        Me.txtFragm2.Name = "txtFragm2"
        Me.txtFragm2.Size = New System.Drawing.Size(162, 20)
        Me.txtFragm2.TabIndex = 3
        '
        'lblFragm3
        '
        Me.lblFragm3.AutoSize = True
        Me.lblFragm3.Location = New System.Drawing.Point(74, 127)
        Me.lblFragm3.Name = "lblFragm3"
        Me.lblFragm3.Size = New System.Drawing.Size(69, 13)
        Me.lblFragm3.TabIndex = 4
        Me.lblFragm3.Text = "Fragmento 3:"
        '
        'txtFragm3
        '
        Me.txtFragm3.Location = New System.Drawing.Point(149, 124)
        Me.txtFragm3.Name = "txtFragm3"
        Me.txtFragm3.Size = New System.Drawing.Size(162, 20)
        Me.txtFragm3.TabIndex = 5
        '
        'btnFrase
        '
        Me.btnFrase.Location = New System.Drawing.Point(115, 165)
        Me.btnFrase.Name = "btnFrase"
        Me.btnFrase.Size = New System.Drawing.Size(150, 23)
        Me.btnFrase.TabIndex = 6
        Me.btnFrase.Text = "Mostrar la frase completa"
        Me.btnFrase.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(375, 247)
        Me.Controls.Add(Me.btnFrase)
        Me.Controls.Add(Me.txtFragm3)
        Me.Controls.Add(Me.lblFragm3)
        Me.Controls.Add(Me.txtFragm2)
        Me.Controls.Add(Me.txtFragm1)
        Me.Controls.Add(Me.lblFragm2)
        Me.Controls.Add(Me.lblFragm1)
        Me.Name = "Form1"
        Me.Text = "Ejercicio 1 - Práctico 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFragm1 As System.Windows.Forms.Label
    Friend WithEvents lblFragm2 As System.Windows.Forms.Label
    Friend WithEvents txtFragm1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFragm2 As System.Windows.Forms.TextBox
    Friend WithEvents lblFragm3 As System.Windows.Forms.Label
    Friend WithEvents txtFragm3 As System.Windows.Forms.TextBox
    Friend WithEvents btnFrase As System.Windows.Forms.Button

End Class
