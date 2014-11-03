<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Vuelos
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Vuelos))
        Me.grpBox_datosVuelo = New System.Windows.Forms.GroupBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.lbl_marcaAvion = New System.Windows.Forms.Label()
        Me.grpBox_Destino = New System.Windows.Forms.GroupBox()
        Me.cbo_localidadDestino = New System.Windows.Forms.ComboBox()
        Me.cbo_aeropuertoDestino = New System.Windows.Forms.ComboBox()
        Me.lbl_localidadDestino = New System.Windows.Forms.Label()
        Me.lbl_horraLlegada = New System.Windows.Forms.Label()
        Me.lbl_aeropuetoDestino = New System.Windows.Forms.Label()
        Me.txt_fechaHoraDestino = New System.Windows.Forms.MaskedTextBox()
        Me.grpBox_Origen = New System.Windows.Forms.GroupBox()
        Me.cbo_LocalidadOrigen = New System.Windows.Forms.ComboBox()
        Me.cbo_AeropuertoOrigen = New System.Windows.Forms.ComboBox()
        Me.lbl_localidadOrigen = New System.Windows.Forms.Label()
        Me.lbl_horaSalida = New System.Windows.Forms.Label()
        Me.lbl_aeropuertoOrigen = New System.Windows.Forms.Label()
        Me.txt_fechaHoraOrigen = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_Estados = New System.Windows.Forms.ComboBox()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.cbo_aeronaves = New System.Windows.Forms.ComboBox()
        Me.lbl_aeronave = New System.Windows.Forms.Label()
        Me.txt_idVuelo = New System.Windows.Forms.TextBox()
        Me.lbl_idVuelo = New System.Windows.Forms.Label()
        Me.grpBox_tripulacion = New System.Windows.Forms.GroupBox()
        Me.cbo_azafata2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_copiloto = New System.Windows.Forms.ComboBox()
        Me.lbl_copiloto = New System.Windows.Forms.Label()
        Me.cbo_azafata1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_comisarioDeAbordo = New System.Windows.Forms.ComboBox()
        Me.lbl_comisario = New System.Windows.Forms.Label()
        Me.cbo_piloto = New System.Windows.Forms.ComboBox()
        Me.lbl_piloto = New System.Windows.Forms.Label()
        Me.btn_guardarTripulacion = New System.Windows.Forms.Button()
        Me.grd_Vuelos = New System.Windows.Forms.DataGridView()
        Me.tooltip_fechaHora = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_nuevoVuelo = New System.Windows.Forms.Button()
        Me.btn_salirVuelo = New System.Windows.Forms.Button()
        Me.grpBox_datosVuelo.SuspendLayout()
        Me.grpBox_Destino.SuspendLayout()
        Me.grpBox_Origen.SuspendLayout()
        Me.grpBox_tripulacion.SuspendLayout()
        CType(Me.grd_Vuelos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBox_datosVuelo
        '
        Me.grpBox_datosVuelo.BackColor = System.Drawing.Color.Transparent
        Me.grpBox_datosVuelo.Controls.Add(Me.btn_Buscar)
        Me.grpBox_datosVuelo.Controls.Add(Me.lbl_marcaAvion)
        Me.grpBox_datosVuelo.Controls.Add(Me.grpBox_Destino)
        Me.grpBox_datosVuelo.Controls.Add(Me.grpBox_Origen)
        Me.grpBox_datosVuelo.Controls.Add(Me.cbo_Estados)
        Me.grpBox_datosVuelo.Controls.Add(Me.lbl_estado)
        Me.grpBox_datosVuelo.Controls.Add(Me.cbo_aeronaves)
        Me.grpBox_datosVuelo.Controls.Add(Me.lbl_aeronave)
        Me.grpBox_datosVuelo.Controls.Add(Me.txt_idVuelo)
        Me.grpBox_datosVuelo.Controls.Add(Me.lbl_idVuelo)
        Me.grpBox_datosVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpBox_datosVuelo.ForeColor = System.Drawing.SystemColors.Info
        Me.grpBox_datosVuelo.Location = New System.Drawing.Point(12, 52)
        Me.grpBox_datosVuelo.Name = "grpBox_datosVuelo"
        Me.grpBox_datosVuelo.Size = New System.Drawing.Size(659, 222)
        Me.grpBox_datosVuelo.TabIndex = 1
        Me.grpBox_datosVuelo.TabStop = False
        Me.grpBox_datosVuelo.Text = "Datos del Vuelo"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Buscar.Location = New System.Drawing.Point(569, 24)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(78, 27)
        Me.btn_Buscar.TabIndex = 7
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = False
        '
        'lbl_marcaAvion
        '
        Me.lbl_marcaAvion.AutoSize = True
        Me.lbl_marcaAvion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_marcaAvion.Location = New System.Drawing.Point(278, 52)
        Me.lbl_marcaAvion.Name = "lbl_marcaAvion"
        Me.lbl_marcaAvion.Size = New System.Drawing.Size(32, 12)
        Me.lbl_marcaAvion.TabIndex = 16
        Me.lbl_marcaAvion.Text = "Marca"
        Me.lbl_marcaAvion.Visible = False
        '
        'grpBox_Destino
        '
        Me.grpBox_Destino.BackColor = System.Drawing.Color.Transparent
        Me.grpBox_Destino.Controls.Add(Me.cbo_localidadDestino)
        Me.grpBox_Destino.Controls.Add(Me.cbo_aeropuertoDestino)
        Me.grpBox_Destino.Controls.Add(Me.lbl_localidadDestino)
        Me.grpBox_Destino.Controls.Add(Me.lbl_horraLlegada)
        Me.grpBox_Destino.Controls.Add(Me.lbl_aeropuetoDestino)
        Me.grpBox_Destino.Controls.Add(Me.txt_fechaHoraDestino)
        Me.grpBox_Destino.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpBox_Destino.ForeColor = System.Drawing.SystemColors.Info
        Me.grpBox_Destino.Location = New System.Drawing.Point(337, 69)
        Me.grpBox_Destino.Name = "grpBox_Destino"
        Me.grpBox_Destino.Size = New System.Drawing.Size(310, 134)
        Me.grpBox_Destino.TabIndex = 5
        Me.grpBox_Destino.TabStop = False
        Me.grpBox_Destino.Text = "Destino"
        '
        'cbo_localidadDestino
        '
        Me.cbo_localidadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_localidadDestino.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_localidadDestino.FormattingEnabled = True
        Me.cbo_localidadDestino.Location = New System.Drawing.Point(116, 28)
        Me.cbo_localidadDestino.Name = "cbo_localidadDestino"
        Me.cbo_localidadDestino.Size = New System.Drawing.Size(172, 21)
        Me.cbo_localidadDestino.TabIndex = 0
        '
        'cbo_aeropuertoDestino
        '
        Me.cbo_aeropuertoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_aeropuertoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_aeropuertoDestino.FormattingEnabled = True
        Me.cbo_aeropuertoDestino.Location = New System.Drawing.Point(116, 55)
        Me.cbo_aeropuertoDestino.Name = "cbo_aeropuertoDestino"
        Me.cbo_aeropuertoDestino.Size = New System.Drawing.Size(172, 21)
        Me.cbo_aeropuertoDestino.TabIndex = 1
        '
        'lbl_localidadDestino
        '
        Me.lbl_localidadDestino.AutoSize = True
        Me.lbl_localidadDestino.Location = New System.Drawing.Point(8, 31)
        Me.lbl_localidadDestino.Name = "lbl_localidadDestino"
        Me.lbl_localidadDestino.Size = New System.Drawing.Size(53, 13)
        Me.lbl_localidadDestino.TabIndex = 8
        Me.lbl_localidadDestino.Text = "Localidad"
        '
        'lbl_horraLlegada
        '
        Me.lbl_horraLlegada.AutoSize = True
        Me.lbl_horraLlegada.Location = New System.Drawing.Point(8, 101)
        Me.lbl_horraLlegada.Name = "lbl_horraLlegada"
        Me.lbl_horraLlegada.Size = New System.Drawing.Size(106, 13)
        Me.lbl_horraLlegada.TabIndex = 2
        Me.lbl_horraLlegada.Text = "Fecha/Hora Llegada"
        '
        'lbl_aeropuetoDestino
        '
        Me.lbl_aeropuetoDestino.AutoSize = True
        Me.lbl_aeropuetoDestino.Location = New System.Drawing.Point(8, 58)
        Me.lbl_aeropuetoDestino.Name = "lbl_aeropuetoDestino"
        Me.lbl_aeropuetoDestino.Size = New System.Drawing.Size(59, 13)
        Me.lbl_aeropuetoDestino.TabIndex = 6
        Me.lbl_aeropuetoDestino.Text = "Aeropuerto"
        '
        'txt_fechaHoraDestino
        '
        Me.txt_fechaHoraDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fechaHoraDestino.Location = New System.Drawing.Point(116, 98)
        Me.txt_fechaHoraDestino.Mask = "00/00/0000 00:00"
        Me.txt_fechaHoraDestino.Name = "txt_fechaHoraDestino"
        Me.txt_fechaHoraDestino.Size = New System.Drawing.Size(172, 20)
        Me.txt_fechaHoraDestino.TabIndex = 2
        '
        'grpBox_Origen
        '
        Me.grpBox_Origen.BackColor = System.Drawing.Color.Transparent
        Me.grpBox_Origen.Controls.Add(Me.cbo_LocalidadOrigen)
        Me.grpBox_Origen.Controls.Add(Me.cbo_AeropuertoOrigen)
        Me.grpBox_Origen.Controls.Add(Me.lbl_localidadOrigen)
        Me.grpBox_Origen.Controls.Add(Me.lbl_horaSalida)
        Me.grpBox_Origen.Controls.Add(Me.lbl_aeropuertoOrigen)
        Me.grpBox_Origen.Controls.Add(Me.txt_fechaHoraOrigen)
        Me.grpBox_Origen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpBox_Origen.ForeColor = System.Drawing.SystemColors.Info
        Me.grpBox_Origen.Location = New System.Drawing.Point(10, 69)
        Me.grpBox_Origen.Name = "grpBox_Origen"
        Me.grpBox_Origen.Size = New System.Drawing.Size(310, 134)
        Me.grpBox_Origen.TabIndex = 4
        Me.grpBox_Origen.TabStop = False
        Me.grpBox_Origen.Text = "Origen"
        '
        'cbo_LocalidadOrigen
        '
        Me.cbo_LocalidadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_LocalidadOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_LocalidadOrigen.FormattingEnabled = True
        Me.cbo_LocalidadOrigen.Location = New System.Drawing.Point(116, 28)
        Me.cbo_LocalidadOrigen.Name = "cbo_LocalidadOrigen"
        Me.cbo_LocalidadOrigen.Size = New System.Drawing.Size(172, 21)
        Me.cbo_LocalidadOrigen.TabIndex = 0
        '
        'cbo_AeropuertoOrigen
        '
        Me.cbo_AeropuertoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_AeropuertoOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_AeropuertoOrigen.FormattingEnabled = True
        Me.cbo_AeropuertoOrigen.Location = New System.Drawing.Point(116, 55)
        Me.cbo_AeropuertoOrigen.Name = "cbo_AeropuertoOrigen"
        Me.cbo_AeropuertoOrigen.Size = New System.Drawing.Size(172, 21)
        Me.cbo_AeropuertoOrigen.TabIndex = 1
        '
        'lbl_localidadOrigen
        '
        Me.lbl_localidadOrigen.AutoSize = True
        Me.lbl_localidadOrigen.Location = New System.Drawing.Point(8, 31)
        Me.lbl_localidadOrigen.Name = "lbl_localidadOrigen"
        Me.lbl_localidadOrigen.Size = New System.Drawing.Size(53, 13)
        Me.lbl_localidadOrigen.TabIndex = 1
        Me.lbl_localidadOrigen.Text = "Localidad"
        '
        'lbl_horaSalida
        '
        Me.lbl_horaSalida.AutoSize = True
        Me.lbl_horaSalida.Location = New System.Drawing.Point(8, 101)
        Me.lbl_horaSalida.Name = "lbl_horaSalida"
        Me.lbl_horaSalida.Size = New System.Drawing.Size(97, 13)
        Me.lbl_horaSalida.TabIndex = 2
        Me.lbl_horaSalida.Text = "Fecha/Hora Salida"
        '
        'lbl_aeropuertoOrigen
        '
        Me.lbl_aeropuertoOrigen.AutoSize = True
        Me.lbl_aeropuertoOrigen.Location = New System.Drawing.Point(8, 58)
        Me.lbl_aeropuertoOrigen.Name = "lbl_aeropuertoOrigen"
        Me.lbl_aeropuertoOrigen.Size = New System.Drawing.Size(59, 13)
        Me.lbl_aeropuertoOrigen.TabIndex = 6
        Me.lbl_aeropuertoOrigen.Text = "Aeropuerto"
        '
        'txt_fechaHoraOrigen
        '
        Me.txt_fechaHoraOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fechaHoraOrigen.Location = New System.Drawing.Point(116, 98)
        Me.txt_fechaHoraOrigen.Mask = "00/00/0000 00:00"
        Me.txt_fechaHoraOrigen.Name = "txt_fechaHoraOrigen"
        Me.txt_fechaHoraOrigen.Size = New System.Drawing.Size(172, 20)
        Me.txt_fechaHoraOrigen.TabIndex = 2
        Me.txt_fechaHoraOrigen.ValidatingType = GetType(Date)
        '
        'cbo_Estados
        '
        Me.cbo_Estados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Estados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_Estados.FormattingEnabled = True
        Me.cbo_Estados.Location = New System.Drawing.Point(442, 28)
        Me.cbo_Estados.Name = "cbo_Estados"
        Me.cbo_Estados.Size = New System.Drawing.Size(121, 21)
        Me.cbo_Estados.TabIndex = 3
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(396, 31)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(40, 13)
        Me.lbl_estado.TabIndex = 12
        Me.lbl_estado.Text = "Estado"
        '
        'cbo_aeronaves
        '
        Me.cbo_aeronaves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_aeronaves.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_aeronaves.FormattingEnabled = True
        Me.cbo_aeronaves.Location = New System.Drawing.Point(267, 27)
        Me.cbo_aeronaves.Name = "cbo_aeronaves"
        Me.cbo_aeronaves.Size = New System.Drawing.Size(121, 21)
        Me.cbo_aeronaves.TabIndex = 2
        '
        'lbl_aeronave
        '
        Me.lbl_aeronave.AutoSize = True
        Me.lbl_aeronave.Location = New System.Drawing.Point(208, 31)
        Me.lbl_aeronave.Name = "lbl_aeronave"
        Me.lbl_aeronave.Size = New System.Drawing.Size(53, 13)
        Me.lbl_aeronave.TabIndex = 10
        Me.lbl_aeronave.Text = "Aeronave"
        '
        'txt_idVuelo
        '
        Me.txt_idVuelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_idVuelo.Location = New System.Drawing.Point(102, 27)
        Me.txt_idVuelo.Name = "txt_idVuelo"
        Me.txt_idVuelo.Size = New System.Drawing.Size(100, 20)
        Me.txt_idVuelo.TabIndex = 1
        '
        'lbl_idVuelo
        '
        Me.lbl_idVuelo.AutoSize = True
        Me.lbl_idVuelo.Location = New System.Drawing.Point(7, 31)
        Me.lbl_idVuelo.Name = "lbl_idVuelo"
        Me.lbl_idVuelo.Size = New System.Drawing.Size(89, 13)
        Me.lbl_idVuelo.TabIndex = 0
        Me.lbl_idVuelo.Text = "Número de Vuelo"
        '
        'grpBox_tripulacion
        '
        Me.grpBox_tripulacion.BackColor = System.Drawing.Color.Transparent
        Me.grpBox_tripulacion.Controls.Add(Me.cbo_azafata2)
        Me.grpBox_tripulacion.Controls.Add(Me.Label2)
        Me.grpBox_tripulacion.Controls.Add(Me.cbo_copiloto)
        Me.grpBox_tripulacion.Controls.Add(Me.lbl_copiloto)
        Me.grpBox_tripulacion.Controls.Add(Me.cbo_azafata1)
        Me.grpBox_tripulacion.Controls.Add(Me.Label1)
        Me.grpBox_tripulacion.Controls.Add(Me.cbo_comisarioDeAbordo)
        Me.grpBox_tripulacion.Controls.Add(Me.lbl_comisario)
        Me.grpBox_tripulacion.Controls.Add(Me.cbo_piloto)
        Me.grpBox_tripulacion.Controls.Add(Me.lbl_piloto)
        Me.grpBox_tripulacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpBox_tripulacion.ForeColor = System.Drawing.SystemColors.Info
        Me.grpBox_tripulacion.Location = New System.Drawing.Point(12, 280)
        Me.grpBox_tripulacion.Name = "grpBox_tripulacion"
        Me.grpBox_tripulacion.Size = New System.Drawing.Size(661, 111)
        Me.grpBox_tripulacion.TabIndex = 2
        Me.grpBox_tripulacion.TabStop = False
        Me.grpBox_tripulacion.Text = "Tripulacion de Vuelo"
        '
        'cbo_azafata2
        '
        Me.cbo_azafata2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_azafata2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_azafata2.FormattingEnabled = True
        Me.cbo_azafata2.Location = New System.Drawing.Point(453, 76)
        Me.cbo_azafata2.Name = "cbo_azafata2"
        Me.cbo_azafata2.Size = New System.Drawing.Size(152, 21)
        Me.cbo_azafata2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Segunda azafata"
        '
        'cbo_copiloto
        '
        Me.cbo_copiloto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_copiloto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_copiloto.FormattingEnabled = True
        Me.cbo_copiloto.Location = New System.Drawing.Point(66, 55)
        Me.cbo_copiloto.Name = "cbo_copiloto"
        Me.cbo_copiloto.Size = New System.Drawing.Size(152, 21)
        Me.cbo_copiloto.TabIndex = 1
        '
        'lbl_copiloto
        '
        Me.lbl_copiloto.AutoSize = True
        Me.lbl_copiloto.Location = New System.Drawing.Point(15, 58)
        Me.lbl_copiloto.Name = "lbl_copiloto"
        Me.lbl_copiloto.Size = New System.Drawing.Size(45, 13)
        Me.lbl_copiloto.TabIndex = 2
        Me.lbl_copiloto.Text = "Copiloto"
        '
        'cbo_azafata1
        '
        Me.cbo_azafata1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_azafata1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_azafata1.FormattingEnabled = True
        Me.cbo_azafata1.Location = New System.Drawing.Point(453, 49)
        Me.cbo_azafata1.Name = "cbo_azafata1"
        Me.cbo_azafata1.Size = New System.Drawing.Size(152, 21)
        Me.cbo_azafata1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Primer azafata"
        '
        'cbo_comisarioDeAbordo
        '
        Me.cbo_comisarioDeAbordo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_comisarioDeAbordo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_comisarioDeAbordo.FormattingEnabled = True
        Me.cbo_comisarioDeAbordo.Location = New System.Drawing.Point(453, 22)
        Me.cbo_comisarioDeAbordo.Name = "cbo_comisarioDeAbordo"
        Me.cbo_comisarioDeAbordo.Size = New System.Drawing.Size(152, 21)
        Me.cbo_comisarioDeAbordo.TabIndex = 2
        '
        'lbl_comisario
        '
        Me.lbl_comisario.AutoSize = True
        Me.lbl_comisario.Location = New System.Drawing.Point(345, 25)
        Me.lbl_comisario.Name = "lbl_comisario"
        Me.lbl_comisario.Size = New System.Drawing.Size(103, 13)
        Me.lbl_comisario.TabIndex = 4
        Me.lbl_comisario.Text = "Comisario de abordo"
        '
        'cbo_piloto
        '
        Me.cbo_piloto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_piloto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_piloto.FormattingEnabled = True
        Me.cbo_piloto.Location = New System.Drawing.Point(66, 25)
        Me.cbo_piloto.Name = "cbo_piloto"
        Me.cbo_piloto.Size = New System.Drawing.Size(152, 21)
        Me.cbo_piloto.TabIndex = 0
        '
        'lbl_piloto
        '
        Me.lbl_piloto.AutoSize = True
        Me.lbl_piloto.Location = New System.Drawing.Point(15, 28)
        Me.lbl_piloto.Name = "lbl_piloto"
        Me.lbl_piloto.Size = New System.Drawing.Size(33, 13)
        Me.lbl_piloto.TabIndex = 0
        Me.lbl_piloto.Text = "Piloto"
        '
        'btn_guardarTripulacion
        '
        Me.btn_guardarTripulacion.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardarTripulacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarTripulacion.Location = New System.Drawing.Point(144, 571)
        Me.btn_guardarTripulacion.Name = "btn_guardarTripulacion"
        Me.btn_guardarTripulacion.Size = New System.Drawing.Size(108, 27)
        Me.btn_guardarTripulacion.TabIndex = 3
        Me.btn_guardarTripulacion.Text = "Guardar Vuelo"
        Me.btn_guardarTripulacion.UseVisualStyleBackColor = False
        '
        'grd_Vuelos
        '
        Me.grd_Vuelos.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.grd_Vuelos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_Vuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_Vuelos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_Vuelos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.grd_Vuelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grd_Vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_Vuelos.DefaultCellStyle = DataGridViewCellStyle2
        Me.grd_Vuelos.Location = New System.Drawing.Point(12, 397)
        Me.grd_Vuelos.MultiSelect = False
        Me.grd_Vuelos.Name = "grd_Vuelos"
        Me.grd_Vuelos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grd_Vuelos.RowHeadersVisible = False
        Me.grd_Vuelos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grd_Vuelos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grd_Vuelos.RowTemplate.ReadOnly = True
        Me.grd_Vuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_Vuelos.Size = New System.Drawing.Size(661, 167)
        Me.grd_Vuelos.TabIndex = 2
        '
        'tooltip_fechaHora
        '
        Me.tooltip_fechaHora.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tooltip_fechaHora.ToolTipTitle = "Formato Mes/Dia/Año Horas:Minutos"
        '
        'btn_nuevoVuelo
        '
        Me.btn_nuevoVuelo.BackColor = System.Drawing.Color.Transparent
        Me.btn_nuevoVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevoVuelo.Location = New System.Drawing.Point(30, 571)
        Me.btn_nuevoVuelo.Name = "btn_nuevoVuelo"
        Me.btn_nuevoVuelo.Size = New System.Drawing.Size(108, 27)
        Me.btn_nuevoVuelo.TabIndex = 0
        Me.btn_nuevoVuelo.Text = "Nuevo Vuelo"
        Me.btn_nuevoVuelo.UseVisualStyleBackColor = False
        '
        'btn_salirVuelo
        '
        Me.btn_salirVuelo.BackColor = System.Drawing.Color.Transparent
        Me.btn_salirVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salirVuelo.Location = New System.Drawing.Point(551, 571)
        Me.btn_salirVuelo.Name = "btn_salirVuelo"
        Me.btn_salirVuelo.Size = New System.Drawing.Size(108, 27)
        Me.btn_salirVuelo.TabIndex = 4
        Me.btn_salirVuelo.Text = "Salir"
        Me.btn_salirVuelo.UseVisualStyleBackColor = False
        '
        'frm_Vuelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(686, 610)
        Me.Controls.Add(Me.btn_salirVuelo)
        Me.Controls.Add(Me.btn_nuevoVuelo)
        Me.Controls.Add(Me.btn_guardarTripulacion)
        Me.Controls.Add(Me.grd_Vuelos)
        Me.Controls.Add(Me.grpBox_tripulacion)
        Me.Controls.Add(Me.grpBox_datosVuelo)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Vuelos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vuelos"
        Me.grpBox_datosVuelo.ResumeLayout(False)
        Me.grpBox_datosVuelo.PerformLayout()
        Me.grpBox_Destino.ResumeLayout(False)
        Me.grpBox_Destino.PerformLayout()
        Me.grpBox_Origen.ResumeLayout(False)
        Me.grpBox_Origen.PerformLayout()
        Me.grpBox_tripulacion.ResumeLayout(False)
        Me.grpBox_tripulacion.PerformLayout()
        CType(Me.grd_Vuelos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBox_datosVuelo As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_aeronaves As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_aeronave As System.Windows.Forms.Label
    Friend WithEvents txt_idVuelo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_idVuelo As System.Windows.Forms.Label
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents cbo_LocalidadOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_localidadOrigen As System.Windows.Forms.Label
    Friend WithEvents txt_fechaHoraOrigen As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_horaSalida As System.Windows.Forms.Label
    Friend WithEvents cbo_AeropuertoOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_aeropuertoOrigen As System.Windows.Forms.Label
    Friend WithEvents cbo_Estados As System.Windows.Forms.ComboBox
    Friend WithEvents grpBox_Destino As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_localidadDestino As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_aeropuertoDestino As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_localidadDestino As System.Windows.Forms.Label
    Friend WithEvents lbl_horraLlegada As System.Windows.Forms.Label
    Friend WithEvents lbl_aeropuetoDestino As System.Windows.Forms.Label
    Friend WithEvents txt_fechaHoraDestino As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grpBox_Origen As System.Windows.Forms.GroupBox
    Friend WithEvents grpBox_tripulacion As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_azafata2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_azafata1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_comisarioDeAbordo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_comisario As System.Windows.Forms.Label
    Friend WithEvents cbo_copiloto As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_copiloto As System.Windows.Forms.Label
    Friend WithEvents cbo_piloto As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_piloto As System.Windows.Forms.Label
    Friend WithEvents btn_guardarTripulacion As System.Windows.Forms.Button
    Friend WithEvents grd_Vuelos As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_marcaAvion As System.Windows.Forms.Label
    Friend WithEvents tooltip_fechaHora As System.Windows.Forms.ToolTip
    Friend WithEvents btn_nuevoVuelo As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_salirVuelo As System.Windows.Forms.Button
End Class
