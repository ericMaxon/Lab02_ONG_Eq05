Public Class Inicio
    Private Const CANT_INICIAL As Integer = 20500

    Private almacenes As New List(Of Almacen)
    Private errorProvider As New ErrorProvider
    Private flag As Boolean
    Private dispInicial As Integer
    Public Navegacion As INav = New Navegacion()

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Funciones principales
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If Not isEmpty(cbxName.SelectedItem.ToString()) Then
            If Not isEmpty(cbxLocalidad.SelectedItem.ToString()) Then
                If Not flag Then
                    Dim cant = tbxQty.Text
                    Dim productName As String = cbxName.SelectedItem.ToString()
                    Dim localidad As String = cbxLocalidad.SelectedItem.ToString()


                    Dim existeElAlmacen As Almacen = almacenes.Find(Function(almacen) almacen.GetUbicacion() = localidad)
                    If Not IsNothing(existeElAlmacen) Then
                        Dim existeIndex As Integer = almacenes.IndexOf(existeElAlmacen)
                        existeElAlmacen.InsertarVacuna(productName, cant)
                        almacenes.Insert(existeIndex, existeElAlmacen)
                    Else
                        almacenes.Add(New Almacen(localidad))
                        almacenes.Last().InsertarVacuna(productName, cant)
                    End If
                    almacenes.ForEach(Sub(almacen)
                                          dispInicial += almacen.DisponibilidadTotal()
                                      End Sub)
                    If (dispInicial >= CANT_INICIAL) Then
                        btnOrders.Visible = True
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

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        Navegacion.NavegarA(Me, New Pedidos())
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Me.Dispose()
        Application.Exit()
    End Sub
    ' Validacion del text box
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
    ' Validar comboboxes
    Private Function isEmpty(valor As String) As Boolean
        Return String.IsNullOrEmpty(valor)
    End Function

    Public Function ObtenerAlmacenes() As List(Of Almacen)
        Return almacenes
    End Function
    Public Function ObtnenerDisponibilidadInicial() As Integer
        Return dispInicial
    End Function
End Class
