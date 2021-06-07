<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Informe
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.dgvTablero = New System.Windows.Forms.DataGridView()
        Me.cboxUbiFilter = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clmSecuencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUbi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvTablero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(25, 33)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(39, 15)
        Me.lblFilter.TabIndex = 6
        Me.lblFilter.Text = "Filtros"
        '
        'dgvTablero
        '
        Me.dgvTablero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTablero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSecuencia, Me.clmType, Me.clmQty, Me.clmUbi, Me.clmStatus})
        Me.dgvTablero.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTablero.Location = New System.Drawing.Point(184, 76)
        Me.dgvTablero.MultiSelect = False
        Me.dgvTablero.Name = "dgvTablero"
        Me.dgvTablero.ReadOnly = True
        Me.dgvTablero.RowTemplate.Height = 25
        Me.dgvTablero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTablero.Size = New System.Drawing.Size(543, 141)
        Me.dgvTablero.TabIndex = 5
        '
        'cboxUbiFilter
        '
        Me.cboxUbiFilter.FormattingEnabled = True
        Me.cboxUbiFilter.Location = New System.Drawing.Point(70, 30)
        Me.cboxUbiFilter.Name = "cboxUbiFilter"
        Me.cboxUbiFilter.Size = New System.Drawing.Size(121, 23)
        Me.cboxUbiFilter.TabIndex = 4
        Me.cboxUbiFilter.Text = "Localidades"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(197, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.Text = "Estados"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 351)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(73, 384)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 393)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Label2"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(73, 418)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 427)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Label3"
        '
        'clmSecuencia
        '
        Me.clmSecuencia.HeaderText = "Numero secuencial"
        Me.clmSecuencia.Name = "clmSecuencia"
        Me.clmSecuencia.ReadOnly = True
        '
        'clmType
        '
        Me.clmType.HeaderText = "Nombre"
        Me.clmType.Name = "clmType"
        Me.clmType.ReadOnly = True
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
        Me.clmStatus.Name = "clmStatus"
        Me.clmStatus.ReadOnly = True
        '
        'Informe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 518)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.dgvTablero)
        Me.Controls.Add(Me.cboxUbiFilter)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Informe"
        Me.Text = "Informe"
        CType(Me.dgvTablero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFilter As Label
    Friend WithEvents dgvTablero As DataGridView
    Friend WithEvents clmSecuencia As DataGridViewTextBoxColumn
    Friend WithEvents clmType As DataGridViewTextBoxColumn
    Friend WithEvents clmQty As DataGridViewTextBoxColumn
    Friend WithEvents clmUbi As DataGridViewTextBoxColumn
    Friend WithEvents clmStatus As DataGridViewTextBoxColumn
    Friend WithEvents cboxUbiFilter As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
End Class
