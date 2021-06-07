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
        Me.btnLocalidad = New System.Windows.Forms.ComboBox()
        Me.lblSecuencia = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.tbxQty = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnLocalidad
        '
        Me.btnLocalidad.FormattingEnabled = True
        Me.btnLocalidad.Location = New System.Drawing.Point(142, 140)
        Me.btnLocalidad.Name = "btnLocalidad"
        Me.btnLocalidad.Size = New System.Drawing.Size(144, 23)
        Me.btnLocalidad.TabIndex = 0
        Me.btnLocalidad.Text = "Lugar del almacen"
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
        Me.lblQty.Location = New System.Drawing.Point(266, 73)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(55, 15)
        Me.lblQty.TabIndex = 3
        Me.lblQty.Text = "Cantidad"
        '
        'tbxQty
        '
        Me.tbxQty.Location = New System.Drawing.Point(240, 90)
        Me.tbxQty.Name = "tbxQty"
        Me.tbxQty.Size = New System.Drawing.Size(100, 23)
        Me.tbxQty.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(178, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(178, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(158, 31)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(95, 15)
        Me.lblStart.TabIndex = 9
        Me.lblStart.Text = "Inicio de jornada"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(51, 91)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 10
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 347)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbxQty)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblSecuencia)
        Me.Controls.Add(Me.btnLocalidad)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLocalidad As ComboBox
    Friend WithEvents lblSecuencia As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents tbxQty As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblStart As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
