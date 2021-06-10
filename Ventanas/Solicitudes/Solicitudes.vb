Public Class Solicitudes
    Private Sub Solicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboxUbiFilter.Items.AddRange({"Panama", "Colon", "Veraguas", "Darien"})
        cboxStatus.Items.AddRange({"Entregado", "Rechazado"})
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Inicio.Navegacion.Regresar(Me)
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub cboxUbiFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxUbiFilter.SelectedIndexChanged, cboxStatus.SelectedIndexChanged
        dgvTablero.Rows.Clear()

        Dim nmSec As Integer = 1
        Inicio.ObtenerSolicitudes().ForEach(Sub(solicitud)
                                                If cboxUbiFilter.SelectedIndex <> -1 Then
                                                    If solicitud.ubiProp = cboxUbiFilter.SelectedItem.ToString() Then
                                                        solicitud.estadoProp = solicitud.estadoProp
                                                        dgvTablero.Rows.Add(nmSec, solicitud.nombreProp, solicitud.cantProp, solicitud.ubiProp, solicitud.estadoProp, solicitud.motivoProp)
                                                    End If
                                                End If
                                                If cboxStatus.SelectedIndex <> -1 Then
                                                    If solicitud.estadoProp = cboxStatus.SelectedItem.ToString() Then
                                                        solicitud.estadoProp = solicitud.estadoProp
                                                        dgvTablero.Rows.Add(nmSec, solicitud.nombreProp, solicitud.cantProp, solicitud.ubiProp, solicitud.estadoProp, solicitud.motivoProp)
                                                    End If
                                                End If
                                                nmSec += 1
                                            End Sub)
    End Sub

    Private Sub btnSee_Click(sender As Object, e As EventArgs) Handles btnSee.Click
        dgvTablero.Rows.Clear()
        Dim nmSec As Integer = 1
        Inicio.ObtenerSolicitudes().ForEach(Sub(solicitud)
                                                dgvTablero.Rows.Add(nmSec, solicitud.nombreProp, solicitud.cantProp, solicitud.ubiProp, solicitud.estadoProp, solicitud.motivoProp)
                                                nmSec += 1
                                            End Sub)
    End Sub
End Class