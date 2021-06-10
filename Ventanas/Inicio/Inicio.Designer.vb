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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
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
        Me.lblPc = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxLocalidad
        '
        Me.cbxLocalidad.FormattingEnabled = True
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
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Image = CType(resources.GetObject("btnSend.Image"), System.Drawing.Image)
        Me.btnSend.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSend.Location = New System.Drawing.Point(142, 176)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(121, 54)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "Enviar al inventario"
        Me.btnSend.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.AutoSize = True
        Me.btnOrders.FlatAppearance.BorderSize = 0
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.Image = CType(resources.GetObject("btnOrders.Image"), System.Drawing.Image)
        Me.btnOrders.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOrders.Location = New System.Drawing.Point(212, 176)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(106, 54)
        Me.btnOrders.TabIndex = 7
        Me.btnOrders.Text = "Iniciar Jornada"
        Me.btnOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.btnFinish.FlatAppearance.BorderSize = 0
        Me.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinish.Image = CType(resources.GetObject("btnFinish.Image"), System.Drawing.Image)
        Me.btnFinish.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFinish.Location = New System.Drawing.Point(365, 293)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(86, 42)
        Me.btnFinish.TabIndex = 12
        Me.btnFinish.Text = "Finalizar"
        Me.btnFinish.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'lblPc
        '
        Me.lblPc.AutoSize = True
        Me.lblPc.Location = New System.Drawing.Point(0, 319)
        Me.lblPc.Name = "lblPc"
        Me.lblPc.Size = New System.Drawing.Size(41, 15)
        Me.lblPc.TabIndex = 13
        Me.lblPc.Text = "Label1"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(0, 334)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(41, 15)
        Me.lblUser.TabIndex = 14
        Me.lblUser.Text = "Label2"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 347)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblPc)
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
    Friend WithEvents lblPc As Label
    Friend WithEvents lblUser As Label
End Class
