<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblRequest = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbxQty = New System.Windows.Forms.TextBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblSecuencia = New System.Windows.Forms.Label()
        Me.btnLocalidad = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(66, 109)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 18
        '
        'lblRequest
        '
        Me.lblRequest.AutoSize = True
        Me.lblRequest.Location = New System.Drawing.Point(203, 44)
        Me.lblRequest.Name = "lblRequest"
        Me.lblRequest.Size = New System.Drawing.Size(49, 15)
        Me.lblRequest.TabIndex = 17
        Me.lblRequest.Text = "Pedidos"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(193, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(193, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbxQty
        '
        Me.tbxQty.Location = New System.Drawing.Point(255, 108)
        Me.tbxQty.Name = "tbxQty"
        Me.tbxQty.Size = New System.Drawing.Size(100, 23)
        Me.tbxQty.TabIndex = 14
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(281, 91)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(55, 15)
        Me.lblQty.TabIndex = 13
        Me.lblQty.Text = "Cantidad"
        '
        'lblSecuencia
        '
        Me.lblSecuencia.AutoSize = True
        Me.lblSecuencia.Location = New System.Drawing.Point(97, 91)
        Me.lblSecuencia.Name = "lblSecuencia"
        Me.lblSecuencia.Size = New System.Drawing.Size(60, 15)
        Me.lblSecuencia.TabIndex = 12
        Me.lblSecuencia.Text = "Secuencia"
        '
        'btnLocalidad
        '
        Me.btnLocalidad.FormattingEnabled = True
        Me.btnLocalidad.Location = New System.Drawing.Point(157, 158)
        Me.btnLocalidad.Name = "btnLocalidad"
        Me.btnLocalidad.Size = New System.Drawing.Size(144, 23)
        Me.btnLocalidad.TabIndex = 11
        Me.btnLocalidad.Text = "Lugar del almacen"
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblRequest)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbxQty)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblSecuencia)
        Me.Controls.Add(Me.btnLocalidad)
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblRequest As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents tbxQty As TextBox
    Friend WithEvents lblQty As Label
    Friend WithEvents lblSecuencia As Label
    Friend WithEvents btnLocalidad As ComboBox
End Class
