Public Class Solicitud
    Private nombre As String
    Private cant As Integer
    Private ubi As String
    Private estado As String
    Private motivo As String

    Public Sub New(nombre As String, cant As String, ubi As String, estado As String, motivo As String)
        Me.nombre = nombre
        Me.cant = cant
        Me.ubi = ubi
        Me.estado = estado
        Me.motivo = motivo
    End Sub

    Public Property nombreProp As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property cantProp As Integer
        Get
            Return cant
        End Get
        Set(value As Integer)
            cant = value
        End Set
    End Property
    Public Property ubiProp As String
        Get
            Return ubi
        End Get
        Set(value As String)
            ubi = value
        End Set
    End Property
    Public Property estadoProp As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property
    Public Property motivoProp As String
        Get
            Return motivo
        End Get
        Set(value As String)
            motivo = value
        End Set
    End Property
End Class
