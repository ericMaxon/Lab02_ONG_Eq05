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
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cboxStatus = New System.Windows.Forms.ComboBox()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.btnSee = New System.Windows.Forms.Button()
        Me.clmNmSc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSecuencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUbi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbxStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmComment = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.dgvTablero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNmSc, Me.clmSecuencia, Me.clmQty, Me.clmUbi, Me.tbxStatus, Me.clmComment})
        Me.dgvTablero.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTablero.Location = New System.Drawing.Point(33, 82)
        Me.dgvTablero.MultiSelect = False
        Me.dgvTablero.Name = "dgvTablero"
        Me.dgvTablero.ReadOnly = True
        Me.dgvTablero.RowTemplate.Height = 25
        Me.dgvTablero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTablero.Size = New System.Drawing.Size(662, 353)
        Me.dgvTablero.TabIndex = 1
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
        'cboxStatus
        '
        Me.cboxStatus.FormattingEnabled = True
        Me.cboxStatus.Location = New System.Drawing.Point(234, 12)
        Me.cboxStatus.Name = "cboxStatus"
        Me.cboxStatus.Size = New System.Drawing.Size(121, 23)
        Me.cboxStatus.TabIndex = 3
        Me.cboxStatus.Text = "Estados"
        '
        'btnGoBack
        '
        Me.btnGoBack.BackColor = System.Drawing.Color.Transparent
        Me.btnGoBack.FlatAppearance.BorderSize = 0
        Me.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoBack.Image = CType(resources.GetObject("btnGoBack.Image"), System.Drawing.Image)
        Me.btnGoBack.Location = New System.Drawing.Point(12, -2)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(40, 56)
        Me.btnGoBack.TabIndex = 4
        Me.btnGoBack.UseVisualStyleBackColor = False
        '
        'btnFinish
        '
        Me.btnFinish.AutoSize = True
        Me.btnFinish.FlatAppearance.BorderSize = 0
        Me.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinish.Image = CType(resources.GetObject("btnFinish.Image"), System.Drawing.Image)
        Me.btnFinish.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFinish.Location = New System.Drawing.Point(720, 421)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(68, 44)
        Me.btnFinish.TabIndex = 27
        Me.btnFinish.Text = "Finalizar"
        Me.btnFinish.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'btnSee
        '
        Me.btnSee.Location = New System.Drawing.Point(47, 53)
        Me.btnSee.Name = "btnSee"
        Me.btnSee.Size = New System.Drawing.Size(103, 23)
        Me.btnSee.TabIndex = 28
        Me.btnSee.Text = "Ver solicitudes"
        Me.btnSee.UseVisualStyleBackColor = True
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
        'tbxStatus
        '
        Me.tbxStatus.HeaderText = "Estado"
        Me.tbxStatus.Name = "tbxStatus"
        Me.tbxStatus.ReadOnly = True
        '
        'clmComment
        '
        Me.clmComment.HeaderText = "Motivo"
        Me.clmComment.Name = "clmComment"
        Me.clmComment.ReadOnly = True
        '
        'Solicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSee)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.cboxStatus)
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
    Friend WithEvents cboxStatus As ComboBox
    Friend WithEvents btnGoBack As Button
    Friend WithEvents btnFinish As Button
    Friend WithEvents btnSee As Button
    Friend WithEvents clmNmSc As DataGridViewTextBoxColumn
    Friend WithEvents clmSecuencia As DataGridViewTextBoxColumn
    Friend WithEvents clmQty As DataGridViewTextBoxColumn
    Friend WithEvents clmUbi As DataGridViewTextBoxColumn
    Friend WithEvents tbxStatus As DataGridViewTextBoxColumn
    Friend WithEvents clmComment As DataGridViewTextBoxColumn
End Class
