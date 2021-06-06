Public Interface IProducto
    Sub SetDest(ByVal dest As String)
    Sub SetNombre(ByVal name As String)
    Function GetDest() As String
    Function GetNombre() As String
    Function Inventario() As Integer
End Interface
