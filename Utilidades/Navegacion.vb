Public Class Navegacion
    Implements INav
    Dim pila As New List(Of Form)

    Public Sub NavegarA(ventanaActual As Form, nuevaVentana As Form) Implements INav.NavegarA
        pila.Add(ventanaActual)
        pila.Last().Hide()
        pila.Add(nuevaVentana)
        pila.Last().Show()
    End Sub

    Public Sub Regresar(ventanaActual As Form) Implements INav.Regresar
        pila.Last().Hide()
        pila.Remove(ventanaActual)
        pila.Last().Show()
    End Sub

End Class
