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
        Me.lblRequest = New System.Windows.Forms.Label()
        Me.lblUbi = New System.Windows.Forms.Label()
        Me.cbxName = New System.Windows.Forms.ComboBox()
        Me.btnGotoOrders = New System.Windows.Forms.Button()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.tbxQty = New System.Windows.Forms.TextBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblSecuencia = New System.Windows.Forms.Label()
        Me.cbxLocalidad = New System.Windows.Forms.ComboBox()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        'lblUbi
        '
        Me.lblUbi.AutoSize = True
        Me.lblUbi.Location = New System.Drawing.Point(200, 135)
        Me.lblUbi.Name = "lblUbi"
        Me.lblUbi.Size = New System.Drawing.Size(58, 15)
        Me.lblUbi.TabIndex = 25
        Me.lblUbi.Text = "Localidad"
        '
        'cbxName
        '
        Me.cbxName.FormattingEnabled = True
        Me.cbxName.Items.AddRange(New Object() {"Oxford", "BioNTech", "CoronaVac", "Sputnik V"})
        Me.cbxName.Location = New System.Drawing.Point(73, 104)
        Me.cbxName.Name = "cbxName"
        Me.cbxName.Size = New System.Drawing.Size(121, 23)
        Me.cbxName.TabIndex = 24
        Me.cbxName.Text = "Vacuna"
        '
        'btnGotoOrders
        '
        Me.btnGotoOrders.AutoSize = True
        Me.btnGotoOrders.Location = New System.Drawing.Point(446, 12)
        Me.btnGotoOrders.Name = "btnGotoOrders"
        Me.btnGotoOrders.Size = New System.Drawing.Size(93, 25)
        Me.btnGotoOrders.TabIndex = 23
        Me.btnGotoOrders.Text = "Ver pedidos"
        Me.btnGotoOrders.UseVisualStyleBackColor = True
        Me.btnGotoOrders.Visible = False
        '
        'btnAddOrder
        '
        Me.btnAddOrder.AutoSize = True
        Me.btnAddOrder.Location = New System.Drawing.Point(180, 200)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(117, 25)
        Me.btnAddOrder.TabIndex = 22
        Me.btnAddOrder.Text = "Realizar pedido"
        Me.btnAddOrder.UseVisualStyleBackColor = True
        '
        'tbxQty
        '
        Me.tbxQty.Location = New System.Drawing.Point(272, 104)
        Me.tbxQty.Name = "tbxQty"
        Me.tbxQty.Size = New System.Drawing.Size(100, 23)
        Me.tbxQty.TabIndex = 21
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(294, 86)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(55, 15)
        Me.lblQty.TabIndex = 20
        Me.lblQty.Text = "Cantidad"
        '
        'lblSecuencia
        '
        Me.lblSecuencia.AutoSize = True
        Me.lblSecuencia.Location = New System.Drawing.Point(104, 86)
        Me.lblSecuencia.Name = "lblSecuencia"
        Me.lblSecuencia.Size = New System.Drawing.Size(60, 15)
        Me.lblSecuencia.TabIndex = 19
        Me.lblSecuencia.Text = "Secuencia"
        '
        'cbxLocalidad
        '
        Me.cbxLocalidad.FormattingEnabled = True
        Me.cbxLocalidad.Items.AddRange(New Object() {"Panama", "Colon", "Veraguas", "Darien"})
        Me.cbxLocalidad.Location = New System.Drawing.Point(164, 153)
        Me.cbxLocalidad.Name = "cbxLocalidad"
        Me.cbxLocalidad.Size = New System.Drawing.Size(144, 23)
        Me.cbxLocalidad.TabIndex = 18
        Me.cbxLocalidad.Text = "Lugar del almacen"
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(464, 346)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 23)
        Me.btnFinish.TabIndex = 26
        Me.btnFinish.Text = "Finalizar"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.lblUbi)
        Me.Controls.Add(Me.cbxName)
        Me.Controls.Add(Me.btnGotoOrders)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.tbxQty)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblSecuencia)
        Me.Controls.Add(Me.cbxLocalidad)
        Me.Controls.Add(Me.lblRequest)
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRequest As Label
    Friend WithEvents lblUbi As Label
    Friend WithEvents cbxName As ComboBox
    Friend WithEvents btnGotoOrders As Button
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents tbxQty As TextBox
    Friend WithEvents lblQty As Label
    Friend WithEvents lblSecuencia As Label
    Friend WithEvents cbxLocalidad As ComboBox
    Friend WithEvents btnFinish As Button
End Class
