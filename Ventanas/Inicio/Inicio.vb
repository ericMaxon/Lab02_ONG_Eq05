Public Class Inicio
    Private almacenes As New List(Of Almacen)
    Private errorProvider As New ErrorProvider

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If Not String.IsNullOrEmpty(cbxLocalidad.SelectedItem.ToString()) And Not String.IsNullOrEmpty(cbxName.SelectedItem.ToString()) Then
            If IsNumeric(tbxQty.Text) And Not String.IsNullOrEmpty(tbxQty.Text.Trim) Then
                Dim cant = tbxQty.Text
                Dim productName As String
                Dim localidad As String
                Dim totalidad As Integer
                productName = cbxName.SelectedItem
                localidad = cbxLocalidad.SelectedItem
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
                                      totalidad += almacen.DisponibilidadTotal()
                                  End Sub)
                If (totalidad >= 20500) Then
                    btnOrders.Visible = True
                End If
            Else
                MsgBox($"{cbxLocalidad.SelectedItem} {cbxName.SelectedItem}")
                MsgBox("Debe completar todos los campos", vbCritical, "Campos faltantes")
            End If
        End If
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click

    End Sub

    Private Sub tbxQty_TextChanged(sender As Object, e As EventArgs) Handles tbxQty.TextChanged

    End Sub

    Private Sub tbxQty_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbxQty.Validating
        If String.IsNullOrEmpty(tbxQty.Text.Trim) Then
            errorProvider.SetError(tbxQty, "No puede estar vacio este campo")
        Else
            Dim flag As Boolean
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

    Private Sub cbxName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxName.SelectedIndexChanged

    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Me.Dispose()
        Application.Exit()
    End Sub

    ' Validate
End Class
