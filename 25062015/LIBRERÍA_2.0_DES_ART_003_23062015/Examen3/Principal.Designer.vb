<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.bt_atras = New System.Windows.Forms.Button()
        Me.bt_Modificar = New System.Windows.Forms.Button()
        Me.btInsertar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_atras
        '
        Me.bt_atras.BackColor = System.Drawing.Color.Transparent
        Me.bt_atras.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_atras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_atras.Location = New System.Drawing.Point(82, 265)
        Me.bt_atras.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_atras.Name = "bt_atras"
        Me.bt_atras.Size = New System.Drawing.Size(185, 31)
        Me.bt_atras.TabIndex = 5
        Me.bt_atras.Text = "Atrás"
        Me.bt_atras.UseVisualStyleBackColor = False
        '
        'bt_Modificar
        '
        Me.bt_Modificar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_Modificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_Modificar.Location = New System.Drawing.Point(82, 59)
        Me.bt_Modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_Modificar.Name = "bt_Modificar"
        Me.bt_Modificar.Size = New System.Drawing.Size(185, 31)
        Me.bt_Modificar.TabIndex = 4
        Me.bt_Modificar.Text = "Manejo de Productos"
        Me.bt_Modificar.UseVisualStyleBackColor = True
        '
        'btInsertar
        '
        Me.btInsertar.Location = New System.Drawing.Point(50, -48)
        Me.btInsertar.Margin = New System.Windows.Forms.Padding(4)
        Me.btInsertar.Name = "btInsertar"
        Me.btInsertar.Size = New System.Drawing.Size(185, 31)
        Me.btInsertar.TabIndex = 10
        Me.btInsertar.Text = "Agregar"
        Me.btInsertar.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(348, 471)
        Me.Controls.Add(Me.bt_atras)
        Me.Controls.Add(Me.bt_Modificar)
        Me.Controls.Add(Me.btInsertar)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_atras As System.Windows.Forms.Button
    Friend WithEvents bt_Modificar As System.Windows.Forms.Button
    Friend WithEvents btInsertar As System.Windows.Forms.Button
End Class
