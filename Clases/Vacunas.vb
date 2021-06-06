Public Class Vacunas
    Implements IProducto
    Private destino As String
    Private secuencia As String
    Private cant As Integer

    Public Sub New(secuencia As String, cant As Integer)
        Me.cant = cant
        Me.secuencia = secuencia
        Me.destino = ""
    End Sub

    Public Sub SetDest(dest As String) Implements IProducto.SetDest
        destino = dest
    End Sub

    Public Sub IncrementarInventario(cant As Integer) Implements IProducto.IncrementarInventario
        Dim nuevoNivelDeInventario = Me.cant + cant
        Me.cant = nuevoNivelDeInventario
    End Sub
    Public Sub SetSecuencia(sec As String) Implements IProducto.SetNombre
        secuencia = sec
    End Sub

    Public Function GetDest() As String Implements IProducto.GetDest
        Return destino
    End Function

    Public Function GetSecuencia() As String Implements IProducto.GetNombre
        Return secuencia
    End Function
    Public Function NivelDeInventario() As Integer Implements IProducto.Inventario
        Return cant
    End Function
End Class
