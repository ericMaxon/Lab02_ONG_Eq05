Public Class Pedidos
    Private errorProvider As ErrorProvider
    Private flag As Boolean
    Private almacenes As List(Of Almacen)
    Private solicitudes As List(Of Solicitud)

    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        almacenes = Inicio.ObtenerAlmacenes()
    End Sub


    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        If Not isEmpty(cbxName.SelectedItem.ToString()) Then
            If Not isEmpty(cbxLocalidad.SelectedItem.ToString()) Then
                If Not flag Then
                    Dim cant = tbxQty.Text
                    Dim productName As String = cbxName.SelectedItem.ToString()
                    Dim localidad As String = cbxLocalidad.SelectedItem.ToString()

                    Dim selAlmacen As Almacen = almacenes.Find(Function(almacen) almacen.GetUbicacion() = localidad)
                    Dim vacunas = selAlmacen.ObtenerVacuna(productName)
                    Dim disponible = Me.Disponible()

                    If disponible > 300 Then
                        If cant < vacunas.NivelDeInventario Then
                            Dim nuevoEstado = vacunas
                            nuevoEstado.DisminuirInventario(cant)
                            selAlmacen.ActulizarElemento(vacunas, nuevoEstado)
                        Else

                        End If
                    Else
                        MsgBox("Ha alcanzado el maximo de unidades pedidas")
                    End If


                Else
                        MsgBox("Debe completar todos los campos", vbCritical, "Campos faltantes")
                End If
            Else
                errorProvider.SetError(cbxLocalidad, "Seleccione un valor")
            End If
        Else
            errorProvider.SetError(cbxName, "Seleccione un valor")
        End If
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Me.Dispose()
        Application.Exit()
    End Sub

    ' Validacion de los controles
    Private Sub tbxQty_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbxQty.Validating
        If String.IsNullOrEmpty(tbxQty.Text.Trim) Then
            errorProvider.SetError(tbxQty, "No puede estar vacio este campo")
        Else
            flag = False
            errorProvider.SetError(tbxQty, String.Empty)
            tbxQty_Validated(flag)
            If flag Then
                errorProvider.SetError(tbxQty, "Solo valores numericos")
                tbxQty.Focus()
            End If
        End If
    End Sub
    Private Sub tbxQty_Validated(ByRef Cancel As Boolean)
        If Not IsNumeric(tbxQty.Text) Then
            Cancel = True
        End If
    End Sub
    Private Function isEmpty(valor As String) As Boolean
        Return String.IsNullOrEmpty(valor)
    End Function
    Private Function Disponible() As Integer
        Dim total As Integer
        almacenes.ForEach(Sub(almacen)
                              total += almacen.DisponibilidadTotal()
                          End Sub)
        Return total
    End Function
End Class