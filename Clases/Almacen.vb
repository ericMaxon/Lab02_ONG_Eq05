Public Class Almacen
    Private inventario As New List(Of Vacunas)
    Private ubicacion As String

    Public Sub New(ubicacion As String)
        Me.ubicacion = ubicacion
    End Sub

    Public Sub InsertarProductos(secuencia As String, cant As Integer)
        Dim producto =
        If() Then
            inventario.Add(New Vacunas(secuencia, cant))
        End If
    End Sub

    Public Function NivelDeInventario()

    End Function
End Class
