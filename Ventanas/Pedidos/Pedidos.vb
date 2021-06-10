Public Class Pedidos
    Private errorProvider As New ErrorProvider
    Private flag As Boolean
    Private almacenes As List(Of Almacen)
    Private solicitudes As List(Of Solicitud)

    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxName.Items.AddRange({"Oxford", "BioNTech", "CoronaVac", "Sputnik V"})
        cbxLocalidad.Items.AddRange({"Panama", "Colon", "Veraguas", "Darien"})
        almacenes = Inicio.ObtenerAlmacenes()
        solicitudes = Inicio.ObtenerSolicitudes()
        btnGotoOrders.Visible = False
    End Sub


    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        Dim msgError As String
        If cbxName.SelectedIndex <> -1 Then
            If cbxLocalidad.SelectedIndex <> -1 Then
                If tbxQty.CausesValidation And Not flag Then
                    Dim cant = tbxQty.Text
                    Dim productName As String = cbxName.SelectedItem.ToString()
                    Dim localidad As String = cbxLocalidad.SelectedItem.ToString()

                    Dim selAlmacen As Almacen = almacenes.Find(Function(almacen) almacen.GetUbicacion() = localidad)
                    If IsNothing(selAlmacen) Then
                        msgError = $"No hay inventaio en esta localidad"
                        MsgBox(msgError)
                        solicitudes.Add(New Solicitud(productName, cant, localidad, "Rechazado", msgError))
                        Inicio.AsignarSolicitudes(solicitudes)
                        Return
                    End If
                    Dim vacunas As Vacunas = selAlmacen.ObtenerVacuna(productName)
                    If IsNothing(vacunas) Then
                        msgError = $"No existe este producto en esta localidad"
                        MsgBox(msgError)
                        solicitudes.Add(New Solicitud(productName, cant, localidad, "Rechazado", msgError))
                        Inicio.AsignarSolicitudes(solicitudes)
                        Return
                    End If
                    Dim disponible = Me.Disponible()

                    If disponible <= 300 Then
                        MsgBox("Ha alcanzado el maximo de unidades pedidas", vbInformation, "Limite de pedidos")
                        Inicio.AsignarSolicitudes(solicitudes)
                        Inicio.Navegacion.NavegarA(Me, New Solicitudes)
                        Return
                    End If
                    If cant < vacunas.NivelDeInventario Then
                        Dim nuevoEstado = vacunas
                        nuevoEstado.DisminuirInventario(cant)
                        selAlmacen.ActulizarElemento(vacunas, nuevoEstado)
                        solicitudes.Add(New Solicitud(nuevoEstado.GetSecuencia, cant, localidad, "Entregado", ""))
                    Else
                        msgError = "Ha sobrepasado el maximo de unidades disponibles"
                        MsgBox(msgError)
                        solicitudes.Add(New Solicitud(vacunas.GetSecuencia, cant, localidad, "Rechazado", msgError))

                    End If
                    Me.Reset()
                    Inicio.AsignarSolicitudes(solicitudes)
                Else
                    MsgBox("Debe completar todos los campos", vbCritical, "Campos faltantes")
                End If
            Else
                errorProvider.SetError(cbxLocalidad, "Seleccione un valor")
            End If
        Else
            errorProvider.SetError(cbxName, "Seleccione un valor")
        End If
        If solicitudes.Count > 0 Then
            btnAddOrder.Location = New Point(135, 191)
            btnGotoOrders.Visible = True
        End If
    End Sub
    Private Sub btnGotoOrders_Click(sender As Object, e As EventArgs) Handles btnGotoOrders.Click
        Inicio.Navegacion.NavegarA(Me, New Solicitudes())
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
    Private Sub Reset()
        cbxLocalidad.SelectedIndex = -1
        cbxName.SelectedIndex = -1
        tbxQty.Text = ""
    End Sub

End Class