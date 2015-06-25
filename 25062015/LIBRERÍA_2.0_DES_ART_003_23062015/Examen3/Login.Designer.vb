<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btLogin = New System.Windows.Forms.Button()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbContra = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbContraseña = New System.Windows.Forms.TextBox()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btLogin
        '
        Me.btLogin.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btLogin.Location = New System.Drawing.Point(83, 157)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(85, 31)
        Me.btLogin.TabIndex = 3
        Me.btLogin.Text = "Ingresar"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbUsuario.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.Location = New System.Drawing.Point(67, 62)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(63, 20)
        Me.lbUsuario.TabIndex = 1
        Me.lbUsuario.Text = "Usuario"
        '
        'lbContra
        '
        Me.lbContra.AutoSize = True
        Me.lbContra.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbContra.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContra.Location = New System.Drawing.Point(35, 112)
        Me.lbContra.Name = "lbContra"
        Me.lbContra.Size = New System.Drawing.Size(95, 20)
        Me.lbContra.TabIndex = 2
        Me.lbContra.Text = "Contraseña"
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(136, 62)
        Me.tbUsuario.MaxLength = 10
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(100, 20)
        Me.tbUsuario.TabIndex = 0
        '
        'tbContraseña
        '
        Me.tbContraseña.Location = New System.Drawing.Point(136, 112)
        Me.tbContraseña.MaxLength = 8
        Me.tbContraseña.Name = "tbContraseña"
        Me.tbContraseña.Size = New System.Drawing.Size(100, 20)
        Me.tbContraseña.TabIndex = 1
        '
        'btSalir
        '
        Me.btSalir.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btSalir.Location = New System.Drawing.Point(83, 195)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(85, 31)
        Me.btSalir.TabIndex = 4
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(271, 288)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.tbContraseña)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.lbContra)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.btLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Librería"
        Me.TransparencyKey = System.Drawing.Color.DarkOrange
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbUsuario As System.Windows.Forms.Label
    Friend WithEvents lbContra As System.Windows.Forms.Label
    Friend WithEvents tbUsuario As System.Windows.Forms.TextBox
    Friend WithEvents tbContraseña As System.Windows.Forms.TextBox
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents btLogin As System.Windows.Forms.Button

End Class
