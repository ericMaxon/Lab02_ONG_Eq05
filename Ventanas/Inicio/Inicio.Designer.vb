<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbxLocalidad = New System.Windows.Forms.ComboBox()
        Me.lblSecuencia = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.tbxQty = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.cbxName = New System.Windows.Forms.ComboBox()
        Me.lblUbi = New System.Windows.Forms.Label()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxLocalidad
        '
        Me.cbxLocalidad.FormattingEnabled = True
        Me.cbxLocalidad.Items.AddRange(New Object() {"Panama", "Colon", "Veraguas", "Darien"})
        Me.cbxLocalidad.Location = New System.Drawing.Point(142, 140)
        Me.cbxLocalidad.Name = "cbxLocalidad"
        Me.cbxLocalidad.Size = New System.Drawing.Size(144, 23)
        Me.cbxLocalidad.TabIndex = 0
        Me.cbxLocalidad.Text = "Lugar del almacen"
        '
        'lblSecuencia
        '
        Me.lblSecuencia.AutoSize = True
        Me.lblSecuencia.Location = New System.Drawing.Point(82, 73)
        Me.lblSecuencia.Name = "lblSecuencia"
        Me.lblSecuencia.Size = New System.Drawing.Size(60, 15)
        Me.lblSecuencia.TabIndex = 2
        Me.lblSecuencia.Text = "Secuencia"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(272, 73)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(55, 15)
        Me.lblQty.TabIndex = 3
        Me.lblQty.Text = "Cantidad"
        '
        'tbxQty
        '
        Me.tbxQty.Location = New System.Drawing.Point(250, 91)
        Me.tbxQty.Name = "tbxQty"
        Me.tbxQty.Size = New System.Drawing.Size(100, 23)
        Me.tbxQty.TabIndex = 4
        '
        'btnSend
        '
        Me.btnSend.AutoSize = True
        Me.btnSend.Location = New System.Drawing.Point(158, 187)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(117, 25)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "Enviar al inventario"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.AutoSize = True
        Me.btnOrders.Location = New System.Drawing.Point(169, 236)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(93, 25)
        Me.btnOrders.TabIndex = 7
        Me.btnOrders.Text = "Iniciar Jornada"
        Me.btnOrders.UseVisualStyleBackColor = True
        Me.btnOrders.Visible = False
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(158, 9)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(95, 15)
        Me.lblStart.TabIndex = 9
        Me.lblStart.Text = "Inicio de jornada"
        '
        'cbxName
        '
        Me.cbxName.FormattingEnabled = True
        Me.cbxName.Items.AddRange(New Object() {"Oxford", "BioNTech", "CoronaVac", "Sputnik V"})
        Me.cbxName.Location = New System.Drawing.Point(51, 91)
        Me.cbxName.Name = "cbxName"
        Me.cbxName.Size = New System.Drawing.Size(121, 23)
        Me.cbxName.TabIndex = 10
        Me.cbxName.Text = "Vacuna"
        '
        'lblUbi
        '
        Me.lblUbi.AutoSize = True
        Me.lblUbi.Location = New System.Drawing.Point(178, 122)
        Me.lblUbi.Name = "lblUbi"
        Me.lblUbi.Size = New System.Drawing.Size(58, 15)
        Me.lblUbi.TabIndex = 11
        Me.lblUbi.Text = "Localidad"
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(376, 312)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 23)
        Me.btnFinish.TabIndex = 12
        Me.btnFinish.Text = "Finalizar"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 347)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.lblUbi)
        Me.Controls.Add(Me.cbxName)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.btnOrders)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.tbxQty)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblSecuencia)
        Me.Controls.Add(Me.cbxLocalidad)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxLocalidad As ComboBox
    Friend WithEvents lblSecuencia As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents tbxQty As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents lblStart As Label
    Friend WithEvents cbxName As ComboBox
    Friend WithEvents lblUbi As Label
    Friend WithEvents btnFinish As Button
End Class
