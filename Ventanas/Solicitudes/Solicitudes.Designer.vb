<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Solicitudes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Solicitudes))
        Me.cboxUbiFilter = New System.Windows.Forms.ComboBox()
        Me.dgvTablero = New System.Windows.Forms.DataGridView()
        Me.clmNmSc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSecuencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUbi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmStatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmComment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvTablero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboxUbiFilter
        '
        Me.cboxUbiFilter.FormattingEnabled = True
        Me.cboxUbiFilter.Location = New System.Drawing.Point(107, 12)
        Me.cboxUbiFilter.Name = "cboxUbiFilter"
        Me.cboxUbiFilter.Size = New System.Drawing.Size(121, 23)
        Me.cboxUbiFilter.TabIndex = 0
        Me.cboxUbiFilter.Text = "Localidades"
        '
        'dgvTablero
        '
        Me.dgvTablero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTablero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNmSc, Me.clmSecuencia, Me.clmQty, Me.clmUbi, Me.clmStatus, Me.clmComment})
        Me.dgvTablero.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTablero.Location = New System.Drawing.Point(33, 82)
        Me.dgvTablero.MultiSelect = False
        Me.dgvTablero.Name = "dgvTablero"
        Me.dgvTablero.ReadOnly = True
        Me.dgvTablero.RowTemplate.Height = 25
        Me.dgvTablero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTablero.Size = New System.Drawing.Size(702, 346)
        Me.dgvTablero.TabIndex = 1
        '
        'clmNmSc
        '
        Me.clmNmSc.HeaderText = "Nro. Secuencia"
        Me.clmNmSc.Name = "clmNmSc"
        Me.clmNmSc.ReadOnly = True
        '
        'clmSecuencia
        '
        Me.clmSecuencia.HeaderText = "Secuencia"
        Me.clmSecuencia.Name = "clmSecuencia"
        Me.clmSecuencia.ReadOnly = True
        '
        'clmQty
        '
        Me.clmQty.HeaderText = "Cantidad"
        Me.clmQty.Name = "clmQty"
        Me.clmQty.ReadOnly = True
        '
        'clmUbi
        '
        Me.clmUbi.HeaderText = "Localidad"
        Me.clmUbi.Name = "clmUbi"
        Me.clmUbi.ReadOnly = True
        '
        'clmStatus
        '
        Me.clmStatus.HeaderText = "Estado"
        Me.clmStatus.Items.AddRange(New Object() {"Entregado", "Rechazado"})
        Me.clmStatus.Name = "clmStatus"
        Me.clmStatus.ReadOnly = True
        '
        'clmComment
        '
        Me.clmComment.HeaderText = "Motivo"
        Me.clmComment.Name = "clmComment"
        Me.clmComment.ReadOnly = True
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(62, 15)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(39, 15)
        Me.lblFilter.TabIndex = 2
        Me.lblFilter.Text = "Filtros"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(234, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.Text = "Estados"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(12, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 56)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Solicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.dgvTablero)
        Me.Controls.Add(Me.cboxUbiFilter)
        Me.Name = "Solicitudes"
        Me.Text = "Solicitudes"
        CType(Me.dgvTablero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboxUbiFilter As ComboBox
    Friend WithEvents dgvTablero As DataGridView
    Friend WithEvents lblFilter As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents clmNmSc As DataGridViewTextBoxColumn
    Friend WithEvents clmSecuencia As DataGridViewTextBoxColumn
    Friend WithEvents clmQty As DataGridViewTextBoxColumn
    Friend WithEvents clmUbi As DataGridViewTextBoxColumn
    Friend WithEvents clmStatus As DataGridViewComboBoxColumn
    Friend WithEvents clmComment As DataGridViewTextBoxColumn
End Class
