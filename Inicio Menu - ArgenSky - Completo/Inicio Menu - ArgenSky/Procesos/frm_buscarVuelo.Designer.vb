<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_buscarVuelo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_buscarVuelo))
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.gbx_pasajero = New System.Windows.Forms.GroupBox()
        Me.ckb_fecha = New System.Windows.Forms.CheckBox()
        Me.cbo_tipoPasaje = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_horaChekIn = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbo_localidaddestino = New System.Windows.Forms.ComboBox()
        Me.cbo_localidadOrigen = New System.Windows.Forms.ComboBox()
        Me.lbl_numeroDocumento = New System.Windows.Forms.Label()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.lbl_tipoDocumento = New System.Windows.Forms.Label()
        Me.txt_idVuelo = New System.Windows.Forms.TextBox()
        Me.lbl_idPasajero = New System.Windows.Forms.Label()
        Me.grd_Pasajeros = New System.Windows.Forms.DataGridView()
        Me.IdVuelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAeronave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Destino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Hora_Llegada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Hora_Salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasajesDisponibles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbx_pasajero.SuspendLayout()
        CType(Me.grd_Pasajeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_salir
        '
        Me.cmd_salir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_salir.ForeColor = System.Drawing.Color.White
        Me.cmd_salir.Location = New System.Drawing.Point(739, 355)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(97, 27)
        Me.cmd_salir.TabIndex = 22
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'gbx_pasajero
        '
        Me.gbx_pasajero.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbx_pasajero.BackColor = System.Drawing.Color.Transparent
        Me.gbx_pasajero.Controls.Add(Me.ckb_fecha)
        Me.gbx_pasajero.Controls.Add(Me.cbo_tipoPasaje)
        Me.gbx_pasajero.Controls.Add(Me.Label13)
        Me.gbx_pasajero.Controls.Add(Me.txt_horaChekIn)
        Me.gbx_pasajero.Controls.Add(Me.Label12)
        Me.gbx_pasajero.Controls.Add(Me.cbo_localidaddestino)
        Me.gbx_pasajero.Controls.Add(Me.cbo_localidadOrigen)
        Me.gbx_pasajero.Controls.Add(Me.lbl_numeroDocumento)
        Me.gbx_pasajero.Controls.Add(Me.cmd_buscar)
        Me.gbx_pasajero.Controls.Add(Me.lbl_tipoDocumento)
        Me.gbx_pasajero.Controls.Add(Me.txt_idVuelo)
        Me.gbx_pasajero.Controls.Add(Me.lbl_idPasajero)
        Me.gbx_pasajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbx_pasajero.ForeColor = System.Drawing.SystemColors.Info
        Me.gbx_pasajero.Location = New System.Drawing.Point(12, 47)
        Me.gbx_pasajero.Name = "gbx_pasajero"
        Me.gbx_pasajero.Size = New System.Drawing.Size(845, 104)
        Me.gbx_pasajero.TabIndex = 21
        Me.gbx_pasajero.TabStop = False
        Me.gbx_pasajero.Text = "Vuelos/Datos de busqueda"
        '
        'ckb_fecha
        '
        Me.ckb_fecha.AutoSize = True
        Me.ckb_fecha.Location = New System.Drawing.Point(80, 68)
        Me.ckb_fecha.Name = "ckb_fecha"
        Me.ckb_fecha.Size = New System.Drawing.Size(15, 14)
        Me.ckb_fecha.TabIndex = 28
        Me.ckb_fecha.UseVisualStyleBackColor = True
        '
        'cbo_tipoPasaje
        '
        Me.cbo_tipoPasaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipoPasaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_tipoPasaje.FormattingEnabled = True
        Me.cbo_tipoPasaje.Location = New System.Drawing.Point(305, 65)
        Me.cbo_tipoPasaje.Name = "cbo_tipoPasaje"
        Me.cbo_tipoPasaje.Size = New System.Drawing.Size(123, 21)
        Me.cbo_tipoPasaje.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(207, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Tipo de pasaje"
        '
        'txt_horaChekIn
        '
        Me.txt_horaChekIn.Enabled = False
        Me.txt_horaChekIn.Location = New System.Drawing.Point(101, 65)
        Me.txt_horaChekIn.Mask = "00/00/0000"
        Me.txt_horaChekIn.Name = "txt_horaChekIn"
        Me.txt_horaChekIn.Size = New System.Drawing.Size(100, 20)
        Me.txt_horaChekIn.TabIndex = 24
        Me.txt_horaChekIn.ValidatingType = GetType(Date)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Fecha / Hora"
        '
        'cbo_localidaddestino
        '
        Me.cbo_localidaddestino.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cbo_localidaddestino.DisplayMember = "descripcion"
        Me.cbo_localidaddestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_localidaddestino.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_localidaddestino.FormattingEnabled = True
        Me.cbo_localidaddestino.Location = New System.Drawing.Point(519, 26)
        Me.cbo_localidaddestino.Name = "cbo_localidaddestino"
        Me.cbo_localidaddestino.Size = New System.Drawing.Size(121, 21)
        Me.cbo_localidaddestino.TabIndex = 4
        Me.cbo_localidaddestino.ValueMember = "id_TipoDoc"
        '
        'cbo_localidadOrigen
        '
        Me.cbo_localidadOrigen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cbo_localidadOrigen.DisplayMember = "descripcion"
        Me.cbo_localidadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_localidadOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_localidadOrigen.FormattingEnabled = True
        Me.cbo_localidadOrigen.Location = New System.Drawing.Point(305, 26)
        Me.cbo_localidadOrigen.Name = "cbo_localidadOrigen"
        Me.cbo_localidadOrigen.Size = New System.Drawing.Size(123, 21)
        Me.cbo_localidadOrigen.TabIndex = 1
        Me.cbo_localidadOrigen.ValueMember = "id_TipoDoc"
        '
        'lbl_numeroDocumento
        '
        Me.lbl_numeroDocumento.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_numeroDocumento.AutoSize = True
        Me.lbl_numeroDocumento.Location = New System.Drawing.Point(434, 30)
        Me.lbl_numeroDocumento.Name = "lbl_numeroDocumento"
        Me.lbl_numeroDocumento.Size = New System.Drawing.Size(62, 13)
        Me.lbl_numeroDocumento.TabIndex = 0
        Me.lbl_numeroDocumento.Text = "Loc destino"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmd_buscar.BackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar.ForeColor = System.Drawing.Color.White
        Me.cmd_buscar.Location = New System.Drawing.Point(727, 19)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(97, 27)
        Me.cmd_buscar.TabIndex = 3
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = False
        '
        'lbl_tipoDocumento
        '
        Me.lbl_tipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_tipoDocumento.AutoSize = True
        Me.lbl_tipoDocumento.Location = New System.Drawing.Point(210, 30)
        Me.lbl_tipoDocumento.Name = "lbl_tipoDocumento"
        Me.lbl_tipoDocumento.Size = New System.Drawing.Size(57, 13)
        Me.lbl_tipoDocumento.TabIndex = 0
        Me.lbl_tipoDocumento.Text = "Loc origen"
        '
        'txt_idVuelo
        '
        Me.txt_idVuelo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_idVuelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_idVuelo.Location = New System.Drawing.Point(101, 27)
        Me.txt_idVuelo.Name = "txt_idVuelo"
        Me.txt_idVuelo.Size = New System.Drawing.Size(100, 20)
        Me.txt_idVuelo.TabIndex = 0
        '
        'lbl_idPasajero
        '
        Me.lbl_idPasajero.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_idPasajero.AutoSize = True
        Me.lbl_idPasajero.Location = New System.Drawing.Point(6, 30)
        Me.lbl_idPasajero.Name = "lbl_idPasajero"
        Me.lbl_idPasajero.Size = New System.Drawing.Size(46, 13)
        Me.lbl_idPasajero.TabIndex = 0
        Me.lbl_idPasajero.Text = "Id Vuelo"
        '
        'grd_Pasajeros
        '
        Me.grd_Pasajeros.AllowUserToAddRows = False
        Me.grd_Pasajeros.AllowUserToDeleteRows = False
        Me.grd_Pasajeros.AllowUserToOrderColumns = True
        Me.grd_Pasajeros.AllowUserToResizeColumns = False
        Me.grd_Pasajeros.AllowUserToResizeRows = False
        Me.grd_Pasajeros.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_Pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_Pasajeros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVuelo, Me.IdAeronave, Me.Origen, Me.Destino, Me.Estado, Me.Fecha_Hora_Llegada, Me.Fecha_Hora_Salida, Me.PasajesDisponibles})
        Me.grd_Pasajeros.Location = New System.Drawing.Point(12, 157)
        Me.grd_Pasajeros.Name = "grd_Pasajeros"
        Me.grd_Pasajeros.ReadOnly = True
        Me.grd_Pasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_Pasajeros.Size = New System.Drawing.Size(845, 192)
        Me.grd_Pasajeros.TabIndex = 23
        '
        'IdVuelo
        '
        Me.IdVuelo.HeaderText = "Id Vuelo"
        Me.IdVuelo.Name = "IdVuelo"
        Me.IdVuelo.ReadOnly = True
        '
        'IdAeronave
        '
        Me.IdAeronave.HeaderText = "Id Aeronave"
        Me.IdAeronave.Name = "IdAeronave"
        Me.IdAeronave.ReadOnly = True
        '
        'Origen
        '
        Me.Origen.HeaderText = "Origen"
        Me.Origen.Name = "Origen"
        Me.Origen.ReadOnly = True
        '
        'Destino
        '
        Me.Destino.HeaderText = "Destino"
        Me.Destino.Name = "Destino"
        Me.Destino.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'Fecha_Hora_Llegada
        '
        Me.Fecha_Hora_Llegada.HeaderText = "Fecha y Hora Llegada"
        Me.Fecha_Hora_Llegada.Name = "Fecha_Hora_Llegada"
        Me.Fecha_Hora_Llegada.ReadOnly = True
        '
        'Fecha_Hora_Salida
        '
        Me.Fecha_Hora_Salida.HeaderText = "Fecha y Hora Salida"
        Me.Fecha_Hora_Salida.Name = "Fecha_Hora_Salida"
        Me.Fecha_Hora_Salida.ReadOnly = True
        '
        'PasajesDisponibles
        '
        Me.PasajesDisponibles.HeaderText = "Pasajes Disponibles"
        Me.PasajesDisponibles.Name = "PasajesDisponibles"
        Me.PasajesDisponibles.ReadOnly = True
        '
        'frm_buscarVuelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(877, 394)
        Me.Controls.Add(Me.grd_Pasajeros)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.gbx_pasajero)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_buscarVuelo"
        Me.Text = "Buscar Vuelo"
        Me.gbx_pasajero.ResumeLayout(False)
        Me.gbx_pasajero.PerformLayout()
        CType(Me.grd_Pasajeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents gbx_pasajero As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_localidadOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_numeroDocumento As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_tipoDocumento As System.Windows.Forms.Label
    Friend WithEvents txt_idVuelo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_idPasajero As System.Windows.Forms.Label
    Friend WithEvents cbo_localidaddestino As System.Windows.Forms.ComboBox
    Friend WithEvents grd_Pasajeros As System.Windows.Forms.DataGridView
    Friend WithEvents txt_horaChekIn As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbo_tipoPasaje As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ckb_fecha As System.Windows.Forms.CheckBox
    Friend WithEvents IdVuelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdAeronave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Hora_Llegada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Hora_Salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasajesDisponibles As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
