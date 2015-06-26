<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Abastecedor
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
        Me.btLogin = New System.Windows.Forms.Button()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbContra = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbContraseña = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btLogin
        '
        Me.btLogin.Location = New System.Drawing.Point(84, 169)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(75, 23)
        Me.btLogin.TabIndex = 0
        Me.btLogin.Text = "Ingresar"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Location = New System.Drawing.Point(40, 69)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lbUsuario.TabIndex = 1
        Me.lbUsuario.Text = "Usuario"
        '
        'lbContra
        '
        Me.lbContra.AutoSize = True
        Me.lbContra.Location = New System.Drawing.Point(40, 117)
        Me.lbContra.Name = "lbContra"
        Me.lbContra.Size = New System.Drawing.Size(61, 13)
        Me.lbContra.TabIndex = 2
        Me.lbContra.Text = "Contraseña"
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(105, 69)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(100, 20)
        Me.tbUsuario.TabIndex = 3
        '
        'tbContraseña
        '
        Me.tbContraseña.Location = New System.Drawing.Point(107, 117)
        Me.tbContraseña.Name = "tbContraseña"
        Me.tbContraseña.Size = New System.Drawing.Size(100, 20)
        Me.tbContraseña.TabIndex = 4
        '
        'Abastecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 205)
        Me.Controls.Add(Me.tbContraseña)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.lbContra)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.btLogin)
        Me.Name = "Abastecedor"
        Me.Text = "Abastecedor"
        Me.TransparencyKey = System.Drawing.Color.DarkOrange
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btLogin As System.Windows.Forms.Button
    Friend WithEvents lbUsuario As System.Windows.Forms.Label
    Friend WithEvents lbContra As System.Windows.Forms.Label
    Friend WithEvents tbUsuario As System.Windows.Forms.TextBox
    Friend WithEvents tbContraseña As System.Windows.Forms.TextBox

End Class
