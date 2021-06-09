Public Class Solicitud
    Private nmSec As Integer
    Private nombre As String
    Private cant As Integer
    Private ubi As String
    Private estado As String
    Private motivo As String

    Public Property nmSecProp As Integer
        Get
            Return nmSec
        End Get
        Set(value As Integer)
            nmSec = value
        End Set
    End Property
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
