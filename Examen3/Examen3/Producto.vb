Public Class Producto
    Public codigo As String
    Public categoria As String
    Public nombre As String
    Public precioUnitario As Integer
    Public nivelReorden As Integer
    Public descripcion As String
    Public descripcionAlternativa As String
    Public numeroSerie As Integer
    Public proveedor As String
    Public localizacion As String
    Public impuesto1Tipo As String
    Public impuesto2Tipo As String
    Public impuesto1Porc As String
    Public impuesto2Porc As String
    Private _p1 As String


    Dim nuevo As Producto
    Sub New(ByVal nCodigo As String, ByVal nCategoria As String, ByVal nNombre As String,
           ByVal nPrecioUnitario As Integer, ByVal nNivelReorden As Integer, ByVal nDescripcion As String,
           ByVal nDescripcionAlternativa As String, ByVal nNumeroSerie As Integer,
           ByVal nProveedor As String, ByVal nLocalizacion As String, ByVal nImpuesto1Tipo As String,
           ByVal nImpuesto1Porc As String, ByVal nImpuesto2Tipo As String, ByVal nImpuesto2Porc As String)

        codigo = nCodigo
        categoria = nCategoria
        nombre = nNombre
        precioUnitario = nPrecioUnitario
        nivelReorden = nNivelReorden
        descripcion = nDescripcion
        descripcionAlternativa = nDescripcionAlternativa
        numeroSerie = nNumeroSerie
        proveedor = nProveedor
        localizacion = nLocalizacion
        impuesto1Tipo = nImpuesto1Tipo
        impuesto1Porc = nImpuesto1Porc
        impuesto2Tipo = nImpuesto2Tipo
        impuesto2Porc = nImpuesto2Porc
    End Sub

End Class
