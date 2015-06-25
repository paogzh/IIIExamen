Public Class Login
    Public usuario As Usuario
    Public kim As Usuario
    Public pao As Usuario
    Public invitado As Usuario
    Public invitado2 As Usuario
    Dim array As ArrayList = New ArrayList

    Public Sub CrearUsuarios()
        kim = New Usuario
        kim.nom = "Kimberly"
        kim.contra = "12012"
        pao = New Usuario
        pao.nom = "Paola"
        pao.contra = "07008"
        invitado = New Usuario
        invitado.nom = "invitado"
        invitado.contra = "19901"
        invitado2 = New Usuario
        invitado2.nom = "1"
        invitado2.contra = "1"
        'array.Add(kim)
        'array.Add(pao)
        'array.Add(invitado)

        If (kim.nom = tbUsuario.Text And kim.contra = tbContraseña.Text) Or (pao.nom = tbUsuario.Text And pao.contra = tbContraseña.Text) Or (invitado.nom = tbUsuario.Text And invitado.contra = tbContraseña.Text) Or (invitado2.nom = tbUsuario.Text And invitado2.contra = tbContraseña.Text) Then

            Dim pantallas As New Principal
            pantallas.Visible = True
        Else
            MessageBox.Show("Usuario o contraseña incorrecto")
            tbContraseña.Text = ""
            tbUsuario.Text = ""
            btLogin.BackColor = Color.White
            btLogin.ForeColor = Color.DarkBlue

        End If
    End Sub
    'End Sub
    'Public Sub Verificar(ByRef usuario As Usuario)
    '    ''''  CrearUsuarios()
    '    '''' For i As Integer = 0 To 2
    '    ''''    For Each usuario In array
    '    ''''    If usuario.Equals(array(i)) Then
    'llamar ventana q sigue 
    '    ''''  ''   '''' 
    '    ''''    MessageBox.Show(array(i))
    '    '''' Else
    '    ''''  MessageBox.Show("Usuario o contraseña incorrectos")
    '    '''' End If
    '    ''''   Next
    '    Next

    '    ''' End Sub


    Private Sub btLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogin.Click

        If tbContraseña.Text.Trim = "" Or tbUsuario.Text.Trim = "" Then
            MessageBox.Show("Los campos son obligatorios")
        Else
            btLogin.BackColor = Color.DarkGreen
            btLogin.ForeColor = Color.White
            usuario = New Usuario
            usuario.nom = tbUsuario.Text
            usuario.contra = tbContraseña.Text
            CrearUsuarios()
        End If
    End Sub



    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click
        Close()
    End Sub

   
    Private Sub tbContraseña_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbContraseña.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
