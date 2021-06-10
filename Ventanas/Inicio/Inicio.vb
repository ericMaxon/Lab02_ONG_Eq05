Public Class Inicio
    Private Const CANT_INICIAL As Integer = 20500

    Private almacenes As New List(Of Almacen)
    Private errorProvider As New ErrorProvider
    Private flag As Boolean
    Private dispInicial As Integer
    Public Navegacion As INav = New Navegacion()
    Private solicitudes As New List(Of Solicitud)

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxName.Items.AddRange({"Oxford", "BioNTech", "CoronaVac", "Sputnik V"})
        cbxLocalidad.Items.AddRange({"Panama", "Colon", "Veraguas", "Darien"})
        lblPc.Text = Environ("COMPUTERNAME")
        lblUser.Text = Environ("USERNAME")
    End Sub

    ' Funciones principales
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        If cbxName.SelectedIndex <> -1 Then
            If cbxLocalidad.SelectedIndex <> -1 Then
                If tbxQty.CausesValidation And Not flag Then
                    errorProvider.Clear()
                    Dim cant As Integer = tbxQty.Text
                    Dim productName As String = cbxName.SelectedItem.ToString()
                    Dim localidad As String = cbxLocalidad.SelectedItem.ToString()

                    Dim existeElAlmacen As Almacen = almacenes.Find(Function(almacen) almacen.GetUbicacion() = localidad)
                    If Not IsNothing(existeElAlmacen) Then
                        Dim nuevoEstado = existeElAlmacen
                        nuevoEstado.InsertarVacuna(productName, cant)
                        almacenes.Remove(existeElAlmacen)
                        almacenes.Add(nuevoEstado)

                    Else
                        almacenes.Add(New Almacen(localidad))
                        almacenes.Last().InsertarVacuna(productName, cant)
                    End If
                    Me.Reset()
                Else
                    MsgBox("Debe completar todos los campos", vbCritical, "Campos faltantes")
                End If
            Else
                errorProvider.SetError(cbxLocalidad, "Seleccione un valor")
            End If
        Else
            errorProvider.SetError(cbxName, "Seleccione un valor")
        End If
        dispInicial = Me.Totalidad()
        If (dispInicial >= CANT_INICIAL) Then
            btnSend.Location = New Point(82, 176)
            btnOrders.Visible = True
        End If

        MsgBox($"{dispInicial}")


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
        Try
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
        Catch ex As Exception
            flag = True
            errorProvider.SetError(tbxQty, "Solo valores numericos")
            tbxQty.Focus()

        End Try
    End Sub
    Private Sub tbxQty_Validated(ByRef Cancel As Boolean)
        Try
            If Not IsNumeric(tbxQty.Text) Then
                Cancel = True
            End If
        Catch ex As Exception
            Cancel = True
        End Try
    End Sub

    Public Function ObtenerAlmacenes() As List(Of Almacen)
        Return almacenes
    End Function
    Public Function ObtnenerDisponibilidadInicial() As Integer
        Return dispInicial
    End Function
    Public Function ObtenerSolicitudes() As List(Of Solicitud)
        Return solicitudes
    End Function
    Public Sub AsignarSolicitudes(nuevoEstado As List(Of Solicitud))
        solicitudes = nuevoEstado
    End Sub
    Private Function Totalidad() As Integer
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
