Public Class Principal

    Public productos As ArrayList = New ArrayList

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub


  
    

   
    Private Sub bt_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Modificar.Click
        Dim pantallaModificar As New IMEC
        pantallaModificar.listaProductos(productos)
        pantallaModificar.Visible = True
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarProductos()
    End Sub

    '-------------------------------------------Manejo de productos ------------------------------------
   
    Private Sub cargarProductos()
        Dim prodPreCargados As ArrayList = New ArrayList
        Dim nuevoProducto1 As Producto
        Dim nuevoProducto2 As Producto
        Dim nuevoProducto3 As Producto

        nuevoProducto1 = New Producto("01", "Papeleria", "Cartulina Satinada", 200, 300, "Colores variados", "", 123, "Payca", "San José", "IVI", "13", "Impuesto Extra", "10")
        prodPreCargados.Add(nuevoProducto1)
        nuevoProducto2 = New Producto("02", "Papeleria", "Papel de Banano", 1500, 50, "Paquete 100 unidades", "", 345, "Payca", "San José", "IVI", "13", "Impuesto Extra", "10")
        prodPreCargados.Add(nuevoProducto2)
        nuevoProducto3 = New Producto("03", "Tecnología", "Mouse Inalambrico", 4500, 15, "Marca: Genius", "Colores variados", 567, "Oficomer", "San José", "IVI", "13", "Impuesto Extra", "10")
        prodPreCargados.Add(nuevoProducto3)

        listaProductos(prodPreCargados)
        MessageBox.Show("Bienvendo, Cargando productos al sistema...")
    End Sub

    Dim producto As Producto
    Public Sub agregarProducto(ByVal nCodigo As String, ByVal nCategoria As String, ByVal nNombre As String,
           ByVal nPrecioUnitario As Integer, ByVal nNivelReorden As Integer, ByVal nDescripcion As String,
           ByVal nDescripcionAlternativa As String, ByVal nNumeroSerie As Integer,
           ByVal nProveedor As String, ByVal nLocalizacion As String, ByVal nImpuesto1Tipo As String,
        ByVal nImpuesto1Porc As String, ByVal nImpuesto2Tipo As String, ByVal nImpuesto2Porc As String)

     

        For i = 0 To productos.Count - 1
            If productos.Item(i).codigo.ToString.Trim = nCodigo Then
                productos.Remove(i)

                productos.Add(New Producto(nCodigo, nCategoria, nNombre, nPrecioUnitario, nNivelReorden, nDescripcion, nDescripcionAlternativa, nNumeroSerie, nProveedor, nLocalizacion, nImpuesto1Tipo, nImpuesto1Porc, nImpuesto2Tipo, nImpuesto2Porc))
              

                MessageBox.Show("Producto Modificado")
                Exit For
            Else
                producto = New Producto(nCodigo, nCategoria, nNombre, nPrecioUnitario, nNivelReorden, nDescripcion, nDescripcionAlternativa, nNumeroSerie, nProveedor, nLocalizacion, nImpuesto1Tipo, nImpuesto1Porc, nImpuesto2Tipo, nImpuesto2Porc)
                productos.Add(producto)

                MessageBox.Show("Producto Agregado")
            End If
        Next

    End Sub
    'Public Sub eliminarProducto(ByVal nCodigo As String, ByVal nCategoria As String, ByVal nNombre As String,
    '       ByVal nPrecioUnitario As Integer, ByVal nNivelReorden As Integer, ByVal nDescripcion As String,
    '       ByVal nDescripcionAlternativa As String, ByVal nNumeroSerie As Integer,
    '       ByVal nProveedor As String, ByVal nLocalizacion As String, ByVal nImpuesto1Tipo As String,
    '    ByVal nImpuesto1Porc As String, ByVal nImpuesto2Tipo As String, ByVal nImpuesto2Porc As String)

    '    Dim pantEliminar As New Eliminar
    '    Dim pantConsultar As New Consultar

    '    For i = 0 To productos.Count - 1
    '        If productos.Item(i).codigo.ToString.Trim = nCodigo Then
    '            productos.Remove(i)
    '            Exit For
    '        End If
    '    Next
    'End Sub

 Public Sub listaProductos(ByVal nProductos As ArrayList)
        productos.Clear()
        productos = nProductos
    End Sub

End Class