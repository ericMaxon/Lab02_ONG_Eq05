Public Interface IInventario
    Function ObtenerValor(valorBuscado As String) As Vacunas
    Sub InsertarAlInventario(valor As Vacunas)
    Sub EliminarDelInventario(valor As Vacunas)
    Sub ActualizarElemento(antiguoEstado As Vacunas, nuevoEstado As Vacunas)
    Sub InsertarProducto(valorAingresar As String, valorNumerico As Integer)
    Function GetInvertario() As List(Of Vacunas)
    Function GetUbicacion() As String
End Interface
