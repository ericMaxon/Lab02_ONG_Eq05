Public Class Almacen
    Implements IInventario
    Private inventario As New List(Of Vacunas)
    Private ubicacion As String

    Public Sub New(ubicacion As String)
        Me.ubicacion = ubicacion
    End Sub
    ' Funciones principales del inventario
    Public Function ObtenerVacuna(valorBuscado As String) As Vacunas Implements IInventario.ObtenerValor
        Return Me.inventario.Find(Function(vacuna) vacuna.GetSecuencia() = valorBuscado)
    End Function
    Private Sub InsertarAlInventario(vacuna As Vacunas) Implements IInventario.InsertarAlInventario
        inventario.Add(vacuna)
    End Sub
    Private Sub EliminarDelInventario(vacuna As Vacunas) Implements IInventario.EliminarDelInventario
        inventario.Remove(vacuna)
    End Sub
    Private Sub ActulizarElemento(antiguoEstado As Vacunas, nuevoEstado As Vacunas) Implements IInventario.ActualizarElemento
        EliminarDelInventario(antiguoEstado)' Eliminando el estado anterior de la vacuna
        InsertarAlInventario(nuevoEstado)' Insertando el nuevo estado actulizada de la vacuna
    End Sub
    ' Funciones principales del almacen
    Public Sub InsertarVacuna(secuencia As String, cant As Integer) Implements IInventario.InsertarProducto
        Dim vacunaIngresada As Vacunas = ObtenerVacuna(secuencia)
        If (vacunaIngresada IsNot Nothing) Then                 ' Si existe la secuencia de la vacuna se incrementa su valor
            Dim nuevoEstado = vacunaIngresada
            nuevoEstado.IncrementarInventario(cant)
            ActulizarElemento(vacunaIngresada, nuevoEstado)             
        Else                                                    ' Si no existe se crea una nueva instancia de la vacuna
            InsertarAlInventario(New Vacunas(secuencia, cant))
        End If
    End Sub
    ' Acceso a los datos de la clase
    Public Function GetInventario() As List(Of Vacunas) Implements IInventario.GetInvertario
        Return inventario
    End Function
    Public Function GetUbicacion() As String Implements IInventario.GetUbicacion
        Return ubicacion
    End Function
End Class
