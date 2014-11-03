<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_cargos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abm_cargos))
        Me.grd_cargos = New System.Windows.Forms.DataGridView()
        Me.cmd_borrar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.txt_descripcionCargo = New System.Windows.Forms.TextBox()
        Me.lbl_descripcionCargo = New System.Windows.Forms.Label()
        Me.lbl_idCargo = New System.Windows.Forms.Label()
        Me.txt_idCargo = New System.Windows.Forms.TextBox()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.gbx_cargos = New System.Windows.Forms.GroupBox()
        Me.IdCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grd_cargos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_cargos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_cargos
        '
        Me.grd_cargos.AllowUserToAddRows = False
        Me.grd_cargos.AllowUserToDeleteRows = False
        Me.grd_cargos.AllowUserToResizeColumns = False
        Me.grd_cargos.AllowUserToResizeRows = False
        Me.grd_cargos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd_cargos.BackgroundColor = System.Drawing.Color.White
        Me.grd_cargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_cargos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCargo, Me.Descripcion})
        Me.grd_cargos.Location = New System.Drawing.Point(12, 111)
        Me.grd_cargos.Name = "grd_cargos"
        Me.grd_cargos.ReadOnly = True
        Me.grd_cargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_cargos.Size = New System.Drawing.Size(545, 140)
        Me.grd_cargos.TabIndex = 2
        '
        'cmd_borrar
        '
        Me.cmd_borrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_borrar.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmd_borrar.Enabled = False
        Me.cmd_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_borrar.ForeColor = System.Drawing.SystemColors.Info
        Me.cmd_borrar.Location = New System.Drawing.Point(329, 257)
        Me.cmd_borrar.Name = "cmd_borrar"
        Me.cmd_borrar.Size = New System.Drawing.Size(97, 27)
        Me.cmd_borrar.TabIndex = 8
        Me.cmd_borrar.Text = "Borrar"
        Me.cmd_borrar.UseVisualStyleBackColor = False
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_guardar.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmd_guardar.Enabled = False
        Me.cmd_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_guardar.ForeColor = System.Drawing.SystemColors.Info
        Me.cmd_guardar.Location = New System.Drawing.Point(115, 256)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(97, 27)
        Me.cmd_guardar.TabIndex = 6
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = False
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_nuevo.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_nuevo.ForeColor = System.Drawing.SystemColors.Info
        Me.cmd_nuevo.Location = New System.Drawing.Point(12, 256)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(97, 27)
        Me.cmd_nuevo.TabIndex = 5
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'cmd_salir
        '
        Me.cmd_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_salir.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_salir.ForeColor = System.Drawing.SystemColors.Info
        Me.cmd_salir.Location = New System.Drawing.Point(454, 257)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(97, 27)
        Me.cmd_salir.TabIndex = 9
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'txt_descripcionCargo
        '
        Me.txt_descripcionCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_descripcionCargo.Location = New System.Drawing.Point(255, 24)
        Me.txt_descripcionCargo.Name = "txt_descripcionCargo"
        Me.txt_descripcionCargo.Size = New System.Drawing.Size(100, 20)
        Me.txt_descripcionCargo.TabIndex = 1
        '
        'lbl_descripcionCargo
        '
        Me.lbl_descripcionCargo.AutoSize = True
        Me.lbl_descripcionCargo.Location = New System.Drawing.Point(189, 31)
        Me.lbl_descripcionCargo.Name = "lbl_descripcionCargo"
        Me.lbl_descripcionCargo.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcionCargo.TabIndex = 0
        Me.lbl_descripcionCargo.Text = "Descripcion"
        '
        'lbl_idCargo
        '
        Me.lbl_idCargo.AutoSize = True
        Me.lbl_idCargo.Location = New System.Drawing.Point(6, 34)
        Me.lbl_idCargo.Name = "lbl_idCargo"
        Me.lbl_idCargo.Size = New System.Drawing.Size(47, 13)
        Me.lbl_idCargo.TabIndex = 0
        Me.lbl_idCargo.Text = "Id Cargo"
        '
        'txt_idCargo
        '
        Me.txt_idCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_idCargo.Location = New System.Drawing.Point(72, 27)
        Me.txt_idCargo.Name = "txt_idCargo"
        Me.txt_idCargo.Size = New System.Drawing.Size(100, 20)
        Me.txt_idCargo.TabIndex = 0
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_buscar.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmd_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar.ForeColor = System.Drawing.SystemColors.Info
        Me.cmd_buscar.Location = New System.Drawing.Point(442, 22)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(97, 27)
        Me.cmd_buscar.TabIndex = 7
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = False
        '
        'gbx_cargos
        '
        Me.gbx_cargos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_cargos.BackColor = System.Drawing.Color.Transparent
        Me.gbx_cargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.gbx_cargos.Controls.Add(Me.txt_descripcionCargo)
        Me.gbx_cargos.Controls.Add(Me.lbl_descripcionCargo)
        Me.gbx_cargos.Controls.Add(Me.cmd_buscar)
        Me.gbx_cargos.Controls.Add(Me.txt_idCargo)
        Me.gbx_cargos.Controls.Add(Me.lbl_idCargo)
        Me.gbx_cargos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbx_cargos.ForeColor = System.Drawing.SystemColors.Info
        Me.gbx_cargos.Location = New System.Drawing.Point(12, 41)
        Me.gbx_cargos.Name = "gbx_cargos"
        Me.gbx_cargos.Size = New System.Drawing.Size(545, 64)
        Me.gbx_cargos.TabIndex = 1
        Me.gbx_cargos.TabStop = False
        Me.gbx_cargos.Text = "Cargos/Datos de busqueda"
        '
        'IdCargo
        '
        Me.IdCargo.HeaderText = "IdCargo"
        Me.IdCargo.Name = "IdCargo"
        Me.IdCargo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'abm_cargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(569, 295)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_borrar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grd_cargos)
        Me.Controls.Add(Me.gbx_cargos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.Name = "abm_cargos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Cargos"
        CType(Me.grd_cargos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_cargos.ResumeLayout(False)
        Me.gbx_cargos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grd_cargos As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_borrar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents txt_descripcionCargo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcionCargo As System.Windows.Forms.Label
    Friend WithEvents lbl_idCargo As System.Windows.Forms.Label
    Friend WithEvents txt_idCargo As System.Windows.Forms.TextBox
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents gbx_cargos As System.Windows.Forms.GroupBox
    Friend WithEvents IdCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
