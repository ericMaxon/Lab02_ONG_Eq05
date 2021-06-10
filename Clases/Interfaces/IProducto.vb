Public Interface IProducto
    Sub SetDest(ByVal dest As String)
    Sub SetNombre(ByVal name As String)
    Sub IncrementarInventario(ByVal cant As Integer)
    Sub DisminuirInventario(ByVal cant As Integer)
    Function GetDest() As String
    Function GetNombre() As String
    Function Inventario() As Integer
End Interface
