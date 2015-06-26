Public Class IMEC

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub
   

    Private Sub Modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarComboBox()
        txtNumSerie.Visible = False
        rtxtDescripcionAlternativa.Visible = False
        llenarProveedor()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        rtxtDescripcionAlternativa.Visible = True
        txtNumSerie.Visible = True
        txtProveedor.Visible = False
        cboxProveedor.Visible = True
        modificarProducto()

    End Sub

    Private Sub cbDescripcionAlterna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDescripcionAlterna.CheckedChanged
        If cbDescripcionAlterna.Checked = True Then
            rtxtDescripcionAlternativa.Visible = True
        Else
            rtxtDescripcionAlternativa.Visible = False
        End If
    End Sub

    Private Sub cbNumSerie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNumSerie.CheckedChanged
        If cbNumSerie.Checked = True Then
            txtNumSerie.Visible = True
        Else
            txtNumSerie.Visible = False
        End If

    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        rtxtDescripcionAlternativa.Visible = True
        txtNumSerie.Visible = True
        txtProveedor.Visible = True
        cboxProveedor.Visible = False
        buscarProducto()
    End Sub

    Private Sub btmEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmEliminar.Click
        eliminarProducto()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        ValidarCamposVacios()
        cboxProveedor.Visible = True
        txtProveedor.Visible = False
        agregarProducto()

    End Sub

#Region "Manejo de producto"
    '--------------------------------------------------Manejo de producto ----------------------------------------------------
    Dim productoModificado As Producto
    Dim productos As ArrayList
    Dim producto As Producto

    Dim pantallas As New Principal

    Private Sub agregarProducto()
        If ValidarCamposVacios() = False Then
            If rtxtDescripcionAlternativa.Text = "" And txtNumSerie.Text = "" Then
                producto = (New Producto(txtCodigo.Text.Trim, txtCategoria.Text.Trim, txtNombre.Text.Trim, Convert.ToInt32(mtxtPrecio.Text.Trim),
                                             Convert.ToInt32(mtxtNReorden.Text.Trim), rtxtDescripcion.Text.Trim, 0,
                                            0, cboxProveedor.Text.Trim, txtLocalizacion.Text.Trim, txtImp1.Text.Trim, txtPorc1.Text.Trim, txtImp2.Text.Trim, txtPorc2.Text))
                ValidarErrorGeneral()
                MessageBox.Show("El producto a sido agregado correctamente")
                productos.Add(producto)
                cargarComboBox()
                limpiar()

            ElseIf rtxtDescripcionAlternativa.Text = "" Then
                producto = (New Producto(txtCodigo.Text.Trim, txtCategoria.Text.Trim, txtNombre.Text.Trim, Convert.ToInt32(mtxtPrecio.Text.Trim),
                                           Convert.ToInt32(mtxtNReorden.Text.Trim), rtxtDescripcion.Text.Trim, 0,
                                           Convert.ToInt32(txtNumSerie.Text.Trim), cboxProveedor.Text.Trim, txtLocalizacion.Text.Trim, txtImp1.Text.Trim, txtPorc1.Text.Trim, txtImp2.Text.Trim, txtPorc2.Text))
                ValidarErrorGeneral()
                MessageBox.Show("El producto a sido agregado correctamente")
                productos.Add(producto)
                cargarComboBox()
                limpiar()
            ElseIf txtNumSerie.Text = "" Then
                producto = (New Producto(txtCodigo.Text.Trim, txtCategoria.Text.Trim, txtNombre.Text.Trim, Convert.ToInt32(mtxtPrecio.Text.Trim),
                                             Convert.ToInt32(mtxtNReorden.Text.Trim), rtxtDescripcion.Text.Trim, rtxtDescripcion.Text.Trim,
                                             0, cboxProveedor.Text.Trim, txtLocalizacion.Text.Trim, txtImp1.Text.Trim, txtPorc1.Text.Trim, txtImp2.Text.Trim, txtPorc2.Text))
                ValidarErrorGeneral()
                MessageBox.Show("El producto a sido agregado correctamente")
                productos.Add(producto)
                cargarComboBox()
                limpiar()
            Else
                producto = (New Producto(txtCodigo.Text.Trim, txtCategoria.Text.Trim, txtNombre.Text.Trim, Convert.ToInt32(mtxtPrecio.Text.Trim),
                                                 Convert.ToInt32(mtxtNReorden.Text.Trim), rtxtDescripcion.Text.Trim, rtxtDescripcionAlternativa.Text.Trim,
                                                 Convert.ToInt32(txtNumSerie.Text.Trim), cboxProveedor.SelectedItem.Trim, txtLocalizacion.Text.Trim, txtImp1.Text.Trim, txtPorc1.Text.Trim, txtImp2.Text.Trim, txtPorc2.Text))
                ValidarErrorGeneral()
                MessageBox.Show("El producto a sido agregado correctamente")
                productos.Add(producto)
                cargarComboBox()
                limpiar()

        End If
        Else

        MessageBox.Show("Existen campos obligatorios vacios")
        End If

    End Sub

    Private Sub modificarProducto()
        If ValidarErrorMod() = False Then
            Dim posicion As Integer
            For i = 0 To productos.Count - 1
                If productos.Item(i).nombre.ToString.Trim = cbNombre.Text.Trim Then
                    posicion = i

                    producto = (New Producto(txtCodigo.Text.Trim, txtCategoria.Text.Trim, txtNombre.Text.Trim, Convert.ToInt32(mtxtPrecio.Text.Trim),
                                             Convert.ToInt32(mtxtNReorden.Text.Trim), rtxtDescripcion.Text.Trim, rtxtDescripcion.Text.Trim,
                                             Convert.ToInt32(txtNumSerie.Text.Trim), cboxProveedor.Text.Trim, txtLocalizacion.Text.Trim, txtImp1.Text.Trim, txtPorc1.Text.Trim, txtImp2.Text.Trim, txtPorc2.Text))

                End If
            Next
            productos.RemoveAt(posicion)
            productos.Add(producto)
            cargarComboBox()
            limpiar()
            MessageBox.Show("El producto a sido correctamente modificado")
            rtxtDescripcionAlternativa.Visible = False
            txtNumSerie.Visible = False
        Else
            MessageBox.Show("Los datos del producto no pueden ser modificados")
        End If
        
    End Sub


    Public Sub listaProductos(ByVal nProductos As ArrayList)
        productos = New ArrayList(nProductos)
    End Sub
    Private Sub llenarProveedor()
        cboxProveedor.Items.Add("Universal")
        cboxProveedor.Items.Add("Payca")
        cboxProveedor.Items.Add("International Librería")
        cboxProveedor.Items.Add("Oficomer")
        cboxProveedor.Items.Add("Lehmann")

    End Sub
    Public Sub cargarComboBox()
        cbNombre.Items.Clear()
        Dim nombre As String
        For i = 0 To productos.Count - 1
            nombre = productos.Item(i).nombre.ToString
            cbNombre.Items.Add(nombre)
        Next
    End Sub
    Public Sub buscarProducto()
        Dim producto As Producto
        If cbNombre.Text = "" Then
            MessageBox.Show("Debe seleccionar un valor")
        Else
            For i = 0 To productos.Count - 1
                If productos.Item(i).nombre.ToString.Trim = cbNombre.Text.Trim Then
                    producto = (New Producto(productos.Item(i).codigo, productos.Item(i).categoria, productos.Item(i).nombre, productos.Item(i).precioUnitario, productos.Item(i).nivelReorden, productos.Item(i).descripcion, productos.Item(i).descripcionAlternativa, productos.Item(i).numeroSerie, productos.Item(i).proveedor, productos.Item(i).localizacion, productos.Item(i).impuesto1Tipo, productos.Item(i).impuesto1Porc, productos.Item(i).impuesto2Tipo, productos.Item(i).impuesto2Porc))
                    MessageBox.Show("Buscando producto: " & productos.Item(i).nombre)
                    limpiar()
                    cargarDatos(producto)
                End If
            Next

        End If

    End Sub

    Public Sub eliminarProducto()
        Dim pantalla As New Principal

        Dim posicionEliminar As New Integer
        If cbNombre.Text = "" Then
            MessageBox.Show("Debe seleccionar un valor")
        Else
            For i = 0 To productos.Count - 1
                If productos.Item(i).nombre.ToString.Trim = cbNombre.Text.Trim Then
                    posicionEliminar = i
                    MessageBox.Show("producto eliminado " & productos.Item(i).nombre)
                    rtxtDescripcionAlternativa.Visible = False
                    txtNumSerie.Visible = False
                End If
            Next
        End If
        productos.RemoveAt(posicionEliminar)
        pantalla.productos.Remove(posicionEliminar)
        limpiar()
        cargarComboBox()
    End Sub

    Private Sub cargarDatos(ByVal producto As Producto)
        txtCodigo.Text = producto.codigo
        txtCategoria.Text = producto.categoria
        txtNombre.Text = producto.nombre
        mtxtPrecio.Text = producto.precioUnitario
        mtxtNReorden.Text = producto.nivelReorden
        rtxtDescripcion.Text = producto.descripcion
        cboxProveedor.Text = producto.proveedor
        rtxtDescripcionAlternativa.Text = producto.descripcionAlternativa
        txtNumSerie.Text = producto.numeroSerie
        txtImp1.Text = producto.impuesto1Tipo
        txtPorc1.Text = producto.impuesto1Porc
        txtImp2.Text = producto.impuesto2Tipo
        txtPorc2.Text = producto.impuesto2Porc
        txtLocalizacion.Text = producto.localizacion
        txtProveedor.Text = producto.proveedor

        If rtxtDescripcion.Text = "" Then
            cbDescripcionAlterna.CheckState = True

        Else
            cbDescripcionAlterna.CheckState = False
        End If

        If txtNumSerie.Text = "" Then
            cbNumSerie.CheckState = True

        Else
            cbNumSerie.CheckState = False

        End If
    End Sub

    Private Sub limpiar()
        txtCodigo.Text = ""
        txtCategoria.Text = ""
        txtNombre.Text = ""
        mtxtPrecio.Text = ""
        mtxtNReorden.Text = ""
        rtxtDescripcion.Text = ""
        cboxProveedor.Text = ""
        rtxtDescripcionAlternativa.Text = ""
        txtNumSerie.Text = ""
        txtImp1.Text = ""
        txtPorc1.Text = ""
        txtImp2.Text = ""
        txtPorc2.Text = ""
        txtLocalizacion.Text = ""
        txtProveedor.Text = ""
    End Sub
    Private Sub limpiarGeneral()
        txtCodigo.Text = ""
        txtCategoria.Text = ""
        txtNombre.Text = ""
        mtxtPrecio.Text = ""
        mtxtNReorden.Text = ""
        rtxtDescripcion.Text = ""
        cboxProveedor.Text = ""
        rtxtDescripcionAlternativa.Text = ""
        txtNumSerie.Text = ""
        txtImp1.Text = ""
        txtPorc1.Text = ""
        txtImp2.Text = ""
        txtPorc2.Text = ""
        txtLocalizacion.Text = ""
        txtProveedor.Text = ""
        txtProveedor.Visible = False
        cboxProveedor.Visible = True
        txtNumSerie.Visible = False
        rtxtDescripcionAlternativa.Visible = False
    End Sub

#End Region

#Region "Validaciones"
    Private Sub ValidarErrorGeneral()
        If txtCodigo.Text = "" Then
            ErrorGeneral.SetError(txtCodigo, "Campo obligatorio")
        End If
        If mtxtPrecio.Text = "" Then
            ErrorGeneral.SetError(mtxtPrecio, "Campo obligatorio")
        End If

        If mtxtNReorden.Text = "" Then
            ErrorGeneral.SetError(mtxtNReorden, "Campo obligatorio")
        End If
        If txtPorc1.Text = "" Or txtImp1.Text = "" Then
            ErrorGeneral.SetError(txtPorc1, "Campo obligatorio")
        End If
    End Sub

    Function ValidarErrorMod() As Boolean
        If txtCodigo.Text = "" Then
            ErrorGeneral.SetError(txtCodigo, "Campo obligatorio")
            Return True
        End If
        If mtxtPrecio.Text = "" Then
            ErrorGeneral.SetError(mtxtPrecio, "Campo obligatorio")
            Return True
        End If

        If mtxtNReorden.Text = "" Then
            ErrorGeneral.SetError(mtxtNReorden, "Campo obligatorio")
            Return True
        End If
        If txtPorc1.Text = "" Or txtImp1.Text = "" Then
            ErrorGeneral.SetError(txtPorc1, "Campo obligatorio")
            Return True
        End If
        If txtPorc2.Text = "" Or txtImp2.Text = "" Then
            ErrorGeneral.SetError(txtPorc1, "Campo obligatorio")
            Return True
        End If
        If txtCategoria.Text = "" Then
            ErrorGeneral.SetError(txtCategoria, "Campo obligatorio")
            Return True
        End If
        If rtxtDescripcionAlternativa.Text = "" Then
            ErrorGeneral.SetError(rtxtDescripcionAlternativa, "Campo obligatorio")
            Return True
        End If

        If rtxtDescripcion.Text = "" Then
            ErrorGeneral.SetError(rtxtDescripcion, "Campo obligatorio")
            Return True
        End If
        If txtNumSerie.Text = "" Then
            ErrorGeneral.SetError(txtNumSerie, "Campo obligatorio")
            Return True
        End If
        Return False
    End Function

    Function ValidarCamposVacios() As Boolean
        Dim resultado As Boolean
        If txtCodigo.Text.Trim = "" Or txtCategoria.Text = "" Or txtNombre.Text = "" Or mtxtPrecio.Text = "" Or mtxtNReorden.Text = "" Or rtxtDescripcion.Text = "" Or
             cboxProveedor.Text = "" Or txtImp1.Text = "" Or
            txtPorc1.Text = "" Or txtImp2.Text = "" Or txtPorc2.Text = "" Or txtLocalizacion.Text = "" Then
            resultado = True
        End If
        Return resultado
    End Function


#End Region


    Private Sub btLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLimpiar.Click
        limpiarGeneral()
    End Sub

#Region "ValidarSoloNumeros"
    Private Sub mtxtPrecio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mtxtPrecio.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub mtxtNReorden_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mtxtNReorden.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumSerie.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPorc1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorc1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtPorc2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorc2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region
   

    Private Sub cboxPrecio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxPrecio.CheckedChanged
        If cboxPrecio.Checked = True Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub CalcularPrecio()
        Dim precio As Integer
        Dim cantidad As Integer
        cantidad = CInt(txtCantidad.Text)
        precio = cantidad * CInt(mtxtPrecio.Text)
        txtPrecio.Text = CStr(precio)
    End Sub
 
    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
        CalcularPrecio()
    End Sub
End Class