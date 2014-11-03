<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pasajes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pasajes))
        Me.grpBox_Pasajero = New System.Windows.Forms.GroupBox()
        Me.txt_nacionalidad = New System.Windows.Forms.TextBox()
        Me.txt_sexoPasajero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_apellidoPasajero = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nombrePasajero = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_tipoDocumento = New System.Windows.Forms.TextBox()
        Me.txt_numeroDocumento = New System.Windows.Forms.TextBox()
        Me.lbl_numeroDocumento = New System.Windows.Forms.Label()
        Me.cmd_buscarPasajero = New System.Windows.Forms.Button()
        Me.lbl_tipoDocumento = New System.Windows.Forms.Label()
        Me.txt_idPasajero = New System.Windows.Forms.TextBox()
        Me.lbl_idPasajero = New System.Windows.Forms.Label()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.grpBox_pasaje = New System.Windows.Forms.GroupBox()
        Me.txt_Llegada = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Destino = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Salida = New System.Windows.Forms.TextBox()
        Me.txt_Origen = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmd_buscarVuelo = New System.Windows.Forms.Button()
        Me.txt_Estado = New System.Windows.Forms.TextBox()
        Me.txt_Aeronave = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_idVuelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_idVuelo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_tipoPasaje = New System.Windows.Forms.TextBox()
        Me.txt_horaChekIn = New System.Windows.Forms.TextBox()
        Me.txt_motivoViaje = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grpBox_Pasajero.SuspendLayout()
        Me.grpBox_pasaje.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBox_Pasajero
        '
        Me.grpBox_Pasajero.BackColor = System.Drawing.Color.Transparent
        Me.grpBox_Pasajero.Controls.Add(Me.txt_nacionalidad)
        Me.grpBox_Pasajero.Controls.Add(Me.txt_sexoPasajero)
        Me.grpBox_Pasajero.Controls.Add(Me.Label2)
        Me.grpBox_Pasajero.Controls.Add(Me.Label3)
        Me.grpBox_Pasajero.Controls.Add(Me.txt_apellidoPasajero)
        Me.grpBox_Pasajero.Controls.Add(Me.Label6)
        Me.grpBox_Pasajero.Controls.Add(Me.txt_nombrePasajero)
        Me.grpBox_Pasajero.Controls.Add(Me.Label7)
        Me.grpBox_Pasajero.Controls.Add(Me.txt_tipoDocumento)
        Me.grpBox_Pasajero.Controls.Add(Me.txt_numeroDocumento)
        Me.grpBox_Pasajero.Controls.Add(Me.lbl_numeroDocumento)
        Me.grpBox_Pasajero.Controls.Add(Me.cmd_buscarPasajero)
        Me.grpBox_Pasajero.Controls.Add(Me.lbl_tipoDocumento)
        Me.grpBox_Pasajero.Controls.Add(Me.txt_idPasajero)
        Me.grpBox_Pasajero.Controls.Add(Me.lbl_idPasajero)
        Me.grpBox_Pasajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpBox_Pasajero.ForeColor = System.Drawing.SystemColors.Info
        Me.grpBox_Pasajero.Location = New System.Drawing.Point(6, 52)
        Me.grpBox_Pasajero.Name = "grpBox_Pasajero"
        Me.grpBox_Pasajero.Size = New System.Drawing.Size(754, 135)
        Me.grpBox_Pasajero.TabIndex = 11
        Me.grpBox_Pasajero.TabStop = False
        Me.grpBox_Pasajero.Text = "Datos pasajero"
        '
        'txt_nacionalidad
        '
        Me.txt_nacionalidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_nacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nacionalidad.Enabled = False
        Me.txt_nacionalidad.Location = New System.Drawing.Point(567, 94)
        Me.txt_nacionalidad.Name = "txt_nacionalidad"
        Me.txt_nacionalidad.Size = New System.Drawing.Size(135, 20)
        Me.txt_nacionalidad.TabIndex = 21
        '
        'txt_sexoPasajero
        '
        Me.txt_sexoPasajero.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_sexoPasajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sexoPasajero.Enabled = False
        Me.txt_sexoPasajero.Location = New System.Drawing.Point(567, 61)
        Me.txt_sexoPasajero.Name = "txt_sexoPasajero"
        Me.txt_sexoPasajero.Size = New System.Drawing.Size(135, 20)
        Me.txt_sexoPasajero.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(480, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Sexo"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(480, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nacionalidad"
        '
        'txt_apellidoPasajero
        '
        Me.txt_apellidoPasajero.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_apellidoPasajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_apellidoPasajero.Enabled = False
        Me.txt_apellidoPasajero.Location = New System.Drawing.Point(328, 94)
        Me.txt_apellidoPasajero.Name = "txt_apellidoPasajero"
        Me.txt_apellidoPasajero.Size = New System.Drawing.Size(134, 20)
        Me.txt_apellidoPasajero.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Apellido"
        '
        'txt_nombrePasajero
        '
        Me.txt_nombrePasajero.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_nombrePasajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombrePasajero.Enabled = False
        Me.txt_nombrePasajero.Location = New System.Drawing.Point(106, 94)
        Me.txt_nombrePasajero.Name = "txt_nombrePasajero"
        Me.txt_nombrePasajero.Size = New System.Drawing.Size(131, 20)
        Me.txt_nombrePasajero.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nombre "
        '
        'txt_tipoDocumento
        '
        Me.txt_tipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_tipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tipoDocumento.Enabled = False
        Me.txt_tipoDocumento.Location = New System.Drawing.Point(106, 61)
        Me.txt_tipoDocumento.Name = "txt_tipoDocumento"
        Me.txt_tipoDocumento.Size = New System.Drawing.Size(131, 20)
        Me.txt_tipoDocumento.TabIndex = 11
        '
        'txt_numeroDocumento
        '
        Me.txt_numeroDocumento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_numeroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numeroDocumento.Enabled = False
        Me.txt_numeroDocumento.Location = New System.Drawing.Point(328, 61)
        Me.txt_numeroDocumento.Name = "txt_numeroDocumento"
        Me.txt_numeroDocumento.Size = New System.Drawing.Size(134, 20)
        Me.txt_numeroDocumento.TabIndex = 9
        '
        'lbl_numeroDocumento
        '
        Me.lbl_numeroDocumento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_numeroDocumento.AutoSize = True
        Me.lbl_numeroDocumento.Location = New System.Drawing.Point(255, 63)
        Me.lbl_numeroDocumento.Name = "lbl_numeroDocumento"
        Me.lbl_numeroDocumento.Size = New System.Drawing.Size(67, 13)
        Me.lbl_numeroDocumento.TabIndex = 4
        Me.lbl_numeroDocumento.Text = "Numero Doc"
        '
        'cmd_buscarPasajero
        '
        Me.cmd_buscarPasajero.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmd_buscarPasajero.BackColor = System.Drawing.Color.Transparent
        Me.cmd_buscarPasajero.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_buscarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscarPasajero.ForeColor = System.Drawing.Color.White
        Me.cmd_buscarPasajero.Location = New System.Drawing.Point(651, 19)
        Me.cmd_buscarPasajero.Name = "cmd_buscarPasajero"
        Me.cmd_buscarPasajero.Size = New System.Drawing.Size(97, 27)
        Me.cmd_buscarPasajero.TabIndex = 1
        Me.cmd_buscarPasajero.Text = "Buscar Pasajero"
        Me.cmd_buscarPasajero.UseVisualStyleBackColor = False
        '
        'lbl_tipoDocumento
        '
        Me.lbl_tipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_tipoDocumento.AutoSize = True
        Me.lbl_tipoDocumento.Location = New System.Drawing.Point(12, 63)
        Me.lbl_tipoDocumento.Name = "lbl_tipoDocumento"
        Me.lbl_tipoDocumento.Size = New System.Drawing.Size(86, 13)
        Me.lbl_tipoDocumento.TabIndex = 5
        Me.lbl_tipoDocumento.Text = "Tipo Documento"
        '
        'txt_idPasajero
        '
        Me.txt_idPasajero.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_idPasajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_idPasajero.Enabled = False
        Me.txt_idPasajero.Location = New System.Drawing.Point(106, 26)
        Me.txt_idPasajero.Name = "txt_idPasajero"
        Me.txt_idPasajero.Size = New System.Drawing.Size(131, 20)
        Me.txt_idPasajero.TabIndex = 0
        '
        'lbl_idPasajero
        '
        Me.lbl_idPasajero.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_idPasajero.AutoSize = True
        Me.lbl_idPasajero.Location = New System.Drawing.Point(13, 26)
        Me.lbl_idPasajero.Name = "lbl_idPasajero"
        Me.lbl_idPasajero.Size = New System.Drawing.Size(60, 13)
        Me.lbl_idPasajero.TabIndex = 6
        Me.lbl_idPasajero.Text = "Id Pasajero"
        '
        'cmd_salir
        '
        Me.cmd_salir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_salir.ForeColor = System.Drawing.Color.White
        Me.cmd_salir.Location = New System.Drawing.Point(657, 433)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(97, 27)
        Me.cmd_salir.TabIndex = 2
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmd_guardar.BackColor = System.Drawing.Color.Transparent
        Me.cmd_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_guardar.ForeColor = System.Drawing.Color.White
        Me.cmd_guardar.Location = New System.Drawing.Point(115, 433)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(97, 27)
        Me.cmd_guardar.TabIndex = 1
        Me.cmd_guardar.Text = "Guardar Pasaje"
        Me.cmd_guardar.UseVisualStyleBackColor = False
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmd_nuevo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_nuevo.ForeColor = System.Drawing.Color.White
        Me.cmd_nuevo.Location = New System.Drawing.Point(12, 433)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(97, 27)
        Me.cmd_nuevo.TabIndex = 0
        Me.cmd_nuevo.Text = "Nuevo Pasaje"
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'grpBox_pasaje
        '
        Me.grpBox_pasaje.BackColor = System.Drawing.Color.Transparent
        Me.grpBox_pasaje.Controls.Add(Me.txt_Llegada)
        Me.grpBox_pasaje.Controls.Add(Me.Label11)
        Me.grpBox_pasaje.Controls.Add(Me.txt_Destino)
        Me.grpBox_pasaje.Controls.Add(Me.Label10)
        Me.grpBox_pasaje.Controls.Add(Me.txt_Salida)
        Me.grpBox_pasaje.Controls.Add(Me.txt_Origen)
        Me.grpBox_pasaje.Controls.Add(Me.Label8)
        Me.grpBox_pasaje.Controls.Add(Me.Label9)
        Me.grpBox_pasaje.Controls.Add(Me.cmd_buscarVuelo)
        Me.grpBox_pasaje.Controls.Add(Me.txt_Estado)
        Me.grpBox_pasaje.Controls.Add(Me.txt_Aeronave)
        Me.grpBox_pasaje.Controls.Add(Me.Label5)
        Me.grpBox_pasaje.Controls.Add(Me.txt_idVuelo)
        Me.grpBox_pasaje.Controls.Add(Me.Label4)
        Me.grpBox_pasaje.Controls.Add(Me.lbl_idVuelo)
        Me.grpBox_pasaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpBox_pasaje.ForeColor = System.Drawing.SystemColors.Info
        Me.grpBox_pasaje.Location = New System.Drawing.Point(6, 206)
        Me.grpBox_pasaje.Name = "grpBox_pasaje"
        Me.grpBox_pasaje.Size = New System.Drawing.Size(754, 132)
        Me.grpBox_pasaje.TabIndex = 17
        Me.grpBox_pasaje.TabStop = False
        Me.grpBox_pasaje.Text = "Datos Vuelo"
        '
        'txt_Llegada
        '
        Me.txt_Llegada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Llegada.Enabled = False
        Me.txt_Llegada.Location = New System.Drawing.Point(567, 98)
        Me.txt_Llegada.Name = "txt_Llegada"
        Me.txt_Llegada.Size = New System.Drawing.Size(135, 20)
        Me.txt_Llegada.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(480, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Llegada"
        '
        'txt_Destino
        '
        Me.txt_Destino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Destino.Enabled = False
        Me.txt_Destino.Location = New System.Drawing.Point(567, 62)
        Me.txt_Destino.Name = "txt_Destino"
        Me.txt_Destino.Size = New System.Drawing.Size(135, 20)
        Me.txt_Destino.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(480, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Destino"
        '
        'txt_Salida
        '
        Me.txt_Salida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Salida.Enabled = False
        Me.txt_Salida.Location = New System.Drawing.Point(328, 98)
        Me.txt_Salida.Name = "txt_Salida"
        Me.txt_Salida.Size = New System.Drawing.Size(134, 20)
        Me.txt_Salida.TabIndex = 23
        '
        'txt_Origen
        '
        Me.txt_Origen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Origen.Enabled = False
        Me.txt_Origen.Location = New System.Drawing.Point(328, 62)
        Me.txt_Origen.Name = "txt_Origen"
        Me.txt_Origen.Size = New System.Drawing.Size(134, 20)
        Me.txt_Origen.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(255, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Salida"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(255, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Origen"
        '
        'cmd_buscarVuelo
        '
        Me.cmd_buscarVuelo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmd_buscarVuelo.BackColor = System.Drawing.Color.Transparent
        Me.cmd_buscarVuelo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_buscarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscarVuelo.ForeColor = System.Drawing.Color.White
        Me.cmd_buscarVuelo.Location = New System.Drawing.Point(651, 20)
        Me.cmd_buscarVuelo.Name = "cmd_buscarVuelo"
        Me.cmd_buscarVuelo.Size = New System.Drawing.Size(97, 27)
        Me.cmd_buscarVuelo.TabIndex = 1
        Me.cmd_buscarVuelo.Text = "Buscar Vuelo"
        Me.cmd_buscarVuelo.UseVisualStyleBackColor = False
        '
        'txt_Estado
        '
        Me.txt_Estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Estado.Enabled = False
        Me.txt_Estado.Location = New System.Drawing.Point(108, 96)
        Me.txt_Estado.Name = "txt_Estado"
        Me.txt_Estado.Size = New System.Drawing.Size(131, 20)
        Me.txt_Estado.TabIndex = 19
        '
        'txt_Aeronave
        '
        Me.txt_Aeronave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Aeronave.Enabled = False
        Me.txt_Aeronave.Location = New System.Drawing.Point(108, 60)
        Me.txt_Aeronave.Name = "txt_Aeronave"
        Me.txt_Aeronave.Size = New System.Drawing.Size(131, 20)
        Me.txt_Aeronave.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Estado"
        '
        'txt_idVuelo
        '
        Me.txt_idVuelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_idVuelo.Enabled = False
        Me.txt_idVuelo.Location = New System.Drawing.Point(108, 23)
        Me.txt_idVuelo.Name = "txt_idVuelo"
        Me.txt_idVuelo.Size = New System.Drawing.Size(131, 20)
        Me.txt_idVuelo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Aeronave"
        '
        'lbl_idVuelo
        '
        Me.lbl_idVuelo.AutoSize = True
        Me.lbl_idVuelo.Location = New System.Drawing.Point(13, 27)
        Me.lbl_idVuelo.Name = "lbl_idVuelo"
        Me.lbl_idVuelo.Size = New System.Drawing.Size(89, 13)
        Me.lbl_idVuelo.TabIndex = 18
        Me.lbl_idVuelo.Text = "Número de Vuelo"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_tipoPasaje)
        Me.GroupBox1.Controls.Add(Me.txt_horaChekIn)
        Me.GroupBox1.Controls.Add(Me.txt_motivoViaje)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Location = New System.Drawing.Point(6, 353)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 71)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Pasaje"
        '
        'txt_tipoPasaje
        '
        Me.txt_tipoPasaje.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_tipoPasaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tipoPasaje.Enabled = False
        Me.txt_tipoPasaje.Location = New System.Drawing.Point(567, 28)
        Me.txt_tipoPasaje.Name = "txt_tipoPasaje"
        Me.txt_tipoPasaje.Size = New System.Drawing.Size(135, 20)
        Me.txt_tipoPasaje.TabIndex = 28
        '
        'txt_horaChekIn
        '
        Me.txt_horaChekIn.Enabled = False
        Me.txt_horaChekIn.Location = New System.Drawing.Point(106, 30)
        Me.txt_horaChekIn.Name = "txt_horaChekIn"
        Me.txt_horaChekIn.Size = New System.Drawing.Size(131, 20)
        Me.txt_horaChekIn.TabIndex = 27
        '
        'txt_motivoViaje
        '
        Me.txt_motivoViaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_motivoViaje.Location = New System.Drawing.Point(328, 31)
        Me.txt_motivoViaje.Name = "txt_motivoViaje"
        Me.txt_motivoViaje.Size = New System.Drawing.Size(134, 20)
        Me.txt_motivoViaje.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(243, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Motivo de viaje"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(472, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Tipo de pasaje"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Fecha / Hora"
        '
        'frm_pasajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(778, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpBox_pasaje)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grpBox_Pasajero)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(784, 1080)
        Me.MinimumSize = New System.Drawing.Size(784, 469)
        Me.Name = "frm_pasajes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pasajes"
        Me.grpBox_Pasajero.ResumeLayout(False)
        Me.grpBox_Pasajero.PerformLayout()
        Me.grpBox_pasaje.ResumeLayout(False)
        Me.grpBox_pasaje.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBox_Pasajero As System.Windows.Forms.GroupBox
    Friend WithEvents txt_numeroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_numeroDocumento As System.Windows.Forms.Label
    Friend WithEvents cmd_buscarPasajero As System.Windows.Forms.Button
    Friend WithEvents lbl_tipoDocumento As System.Windows.Forms.Label
    Friend WithEvents txt_idPasajero As System.Windows.Forms.TextBox
    Friend WithEvents lbl_idPasajero As System.Windows.Forms.Label
    Friend WithEvents txt_tipoDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_apellidoPasajero As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_nombrePasajero As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_sexoPasajero As System.Windows.Forms.TextBox
    Friend WithEvents txt_nacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents grpBox_pasaje As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_buscarVuelo As System.Windows.Forms.Button
    Friend WithEvents txt_idVuelo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_idVuelo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Salida As System.Windows.Forms.TextBox
    Friend WithEvents txt_Origen As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Estado As System.Windows.Forms.TextBox
    Friend WithEvents txt_Aeronave As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Llegada As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Destino As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_motivoViaje As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_tipoPasaje As System.Windows.Forms.TextBox
    Friend WithEvents txt_horaChekIn As System.Windows.Forms.TextBox
End Class
