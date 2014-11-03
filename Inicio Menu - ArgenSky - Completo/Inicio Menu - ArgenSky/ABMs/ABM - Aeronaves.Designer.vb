<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ABMAeronaves
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ABMAeronaves))
        Me.box_caraceristicasAeronave = New System.Windows.Forms.GroupBox()
        Me.txt_horasVueloRealizadas = New System.Windows.Forms.TextBox()
        Me.txt_autonomiaVuelo = New System.Windows.Forms.TextBox()
        Me.txt_cantSalidasEmergencia = New System.Windows.Forms.TextBox()
        Me.txt_cantMaxPasPremium = New System.Windows.Forms.TextBox()
        Me.txt_cantMaxPasEconomic = New System.Windows.Forms.TextBox()
        Me.txt_pesoMaxEquipaje = New System.Windows.Forms.TextBox()
        Me.lbl_horasVueloAcumuladas = New System.Windows.Forms.Label()
        Me.lbl_autonomia = New System.Windows.Forms.Label()
        Me.lbl_cantSalidasEmergencia = New System.Windows.Forms.Label()
        Me.lbl_cantPasajerosPremium = New System.Windows.Forms.Label()
        Me.lbl_cantPasajerosEconomic = New System.Windows.Forms.Label()
        Me.lbl_pesoMaxEquipaje = New System.Windows.Forms.Label()
        Me.box_datosIdentificatorios = New System.Windows.Forms.GroupBox()
        Me.txt_idAeronave = New System.Windows.Forms.TextBox()
        Me.lbl_Año = New System.Windows.Forms.Label()
        Me.lbl_Marca = New System.Windows.Forms.Label()
        Me.cbo_añoAeronave = New System.Windows.Forms.ComboBox()
        Me.cbo_marcaAeronave = New System.Windows.Forms.ComboBox()
        Me.btn_buscarAeronave = New System.Windows.Forms.Button()
        Me.lbl_idAeronave = New System.Windows.Forms.Label()
        Me.grd_Aeronaves = New System.Windows.Forms.DataGridView()
        Me.btn_NuevoAeronave = New System.Windows.Forms.Button()
        Me.btn_borrarAeronave = New System.Windows.Forms.Button()
        Me.btn_salirAeronave = New System.Windows.Forms.Button()
        Me.btn_guardarAeronave = New System.Windows.Forms.Button()
        Me.box_caraceristicasAeronave.SuspendLayout()
        Me.box_datosIdentificatorios.SuspendLayout()
        CType(Me.grd_Aeronaves, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'box_caraceristicasAeronave
        '
        Me.box_caraceristicasAeronave.BackColor = System.Drawing.Color.Transparent
        Me.box_caraceristicasAeronave.Controls.Add(Me.txt_horasVueloRealizadas)
        Me.box_caraceristicasAeronave.Controls.Add(Me.txt_autonomiaVuelo)
        Me.box_caraceristicasAeronave.Controls.Add(Me.txt_cantSalidasEmergencia)
        Me.box_caraceristicasAeronave.Controls.Add(Me.txt_cantMaxPasPremium)
        Me.box_caraceristicasAeronave.Controls.Add(Me.txt_cantMaxPasEconomic)
        Me.box_caraceristicasAeronave.Controls.Add(Me.txt_pesoMaxEquipaje)
        Me.box_caraceristicasAeronave.Controls.Add(Me.lbl_horasVueloAcumuladas)
        Me.box_caraceristicasAeronave.Controls.Add(Me.lbl_autonomia)
        Me.box_caraceristicasAeronave.Controls.Add(Me.lbl_cantSalidasEmergencia)
        Me.box_caraceristicasAeronave.Controls.Add(Me.lbl_cantPasajerosPremium)
        Me.box_caraceristicasAeronave.Controls.Add(Me.lbl_cantPasajerosEconomic)
        Me.box_caraceristicasAeronave.Controls.Add(Me.lbl_pesoMaxEquipaje)
        Me.box_caraceristicasAeronave.Enabled = False
        Me.box_caraceristicasAeronave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.box_caraceristicasAeronave.ForeColor = System.Drawing.SystemColors.Info
        Me.box_caraceristicasAeronave.Location = New System.Drawing.Point(12, 138)
        Me.box_caraceristicasAeronave.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.box_caraceristicasAeronave.Name = "box_caraceristicasAeronave"
        Me.box_caraceristicasAeronave.Padding = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.box_caraceristicasAeronave.Size = New System.Drawing.Size(771, 100)
        Me.box_caraceristicasAeronave.TabIndex = 4
        Me.box_caraceristicasAeronave.TabStop = False
        Me.box_caraceristicasAeronave.Text = "Características de la aeronave"
        '
        'txt_horasVueloRealizadas
        '
        Me.txt_horasVueloRealizadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_horasVueloRealizadas.Location = New System.Drawing.Point(695, 59)
        Me.txt_horasVueloRealizadas.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txt_horasVueloRealizadas.MaxLength = 10
        Me.txt_horasVueloRealizadas.Name = "txt_horasVueloRealizadas"
        Me.txt_horasVueloRealizadas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_horasVueloRealizadas.Size = New System.Drawing.Size(61, 20)
        Me.txt_horasVueloRealizadas.TabIndex = 6
        '
        'txt_autonomiaVuelo
        '
        Me.txt_autonomiaVuelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_autonomiaVuelo.Location = New System.Drawing.Point(420, 59)
        Me.txt_autonomiaVuelo.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txt_autonomiaVuelo.MaxLength = 8
        Me.txt_autonomiaVuelo.Name = "txt_autonomiaVuelo"
        Me.txt_autonomiaVuelo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_autonomiaVuelo.Size = New System.Drawing.Size(61, 20)
        Me.txt_autonomiaVuelo.TabIndex = 4
        '
        'txt_cantSalidasEmergencia
        '
        Me.txt_cantSalidasEmergencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantSalidasEmergencia.Location = New System.Drawing.Point(695, 33)
        Me.txt_cantSalidasEmergencia.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txt_cantSalidasEmergencia.MaxLength = 2
        Me.txt_cantSalidasEmergencia.Name = "txt_cantSalidasEmergencia"
        Me.txt_cantSalidasEmergencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_cantSalidasEmergencia.Size = New System.Drawing.Size(61, 20)
        Me.txt_cantSalidasEmergencia.TabIndex = 5
        '
        'txt_cantMaxPasPremium
        '
        Me.txt_cantMaxPasPremium.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantMaxPasPremium.Location = New System.Drawing.Point(199, 59)
        Me.txt_cantMaxPasPremium.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txt_cantMaxPasPremium.MaxLength = 3
        Me.txt_cantMaxPasPremium.Name = "txt_cantMaxPasPremium"
        Me.txt_cantMaxPasPremium.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_cantMaxPasPremium.Size = New System.Drawing.Size(61, 20)
        Me.txt_cantMaxPasPremium.TabIndex = 2
        '
        'txt_cantMaxPasEconomic
        '
        Me.txt_cantMaxPasEconomic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantMaxPasEconomic.Location = New System.Drawing.Point(199, 33)
        Me.txt_cantMaxPasEconomic.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txt_cantMaxPasEconomic.MaxLength = 3
        Me.txt_cantMaxPasEconomic.Name = "txt_cantMaxPasEconomic"
        Me.txt_cantMaxPasEconomic.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_cantMaxPasEconomic.Size = New System.Drawing.Size(61, 20)
        Me.txt_cantMaxPasEconomic.TabIndex = 1
        '
        'txt_pesoMaxEquipaje
        '
        Me.txt_pesoMaxEquipaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pesoMaxEquipaje.Location = New System.Drawing.Point(420, 33)
        Me.txt_pesoMaxEquipaje.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txt_pesoMaxEquipaje.MaxLength = 8
        Me.txt_pesoMaxEquipaje.Name = "txt_pesoMaxEquipaje"
        Me.txt_pesoMaxEquipaje.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_pesoMaxEquipaje.Size = New System.Drawing.Size(61, 20)
        Me.txt_pesoMaxEquipaje.TabIndex = 3
        '
        'lbl_horasVueloAcumuladas
        '
        Me.lbl_horasVueloAcumuladas.AutoSize = True
        Me.lbl_horasVueloAcumuladas.Location = New System.Drawing.Point(517, 61)
        Me.lbl_horasVueloAcumuladas.Name = "lbl_horasVueloAcumuladas"
        Me.lbl_horasVueloAcumuladas.Size = New System.Drawing.Size(129, 13)
        Me.lbl_horasVueloAcumuladas.TabIndex = 11
        Me.lbl_horasVueloAcumuladas.Text = "Horas de vuela realizadas"
        '
        'lbl_autonomia
        '
        Me.lbl_autonomia.AutoSize = True
        Me.lbl_autonomia.Location = New System.Drawing.Point(287, 61)
        Me.lbl_autonomia.Name = "lbl_autonomia"
        Me.lbl_autonomia.Size = New System.Drawing.Size(101, 13)
        Me.lbl_autonomia.TabIndex = 9
        Me.lbl_autonomia.Text = "Autonomia de vuelo"
        '
        'lbl_cantSalidasEmergencia
        '
        Me.lbl_cantSalidasEmergencia.AutoSize = True
        Me.lbl_cantSalidasEmergencia.Location = New System.Drawing.Point(517, 35)
        Me.lbl_cantSalidasEmergencia.Name = "lbl_cantSalidasEmergencia"
        Me.lbl_cantSalidasEmergencia.Size = New System.Drawing.Size(172, 13)
        Me.lbl_cantSalidasEmergencia.TabIndex = 6
        Me.lbl_cantSalidasEmergencia.Text = "Cantidad de salidas de emergencia"
        '
        'lbl_cantPasajerosPremium
        '
        Me.lbl_cantPasajerosPremium.AutoSize = True
        Me.lbl_cantPasajerosPremium.Location = New System.Drawing.Point(10, 61)
        Me.lbl_cantPasajerosPremium.Name = "lbl_cantPasajerosPremium"
        Me.lbl_cantPasajerosPremium.Size = New System.Drawing.Size(178, 13)
        Me.lbl_cantPasajerosPremium.TabIndex = 3
        Me.lbl_cantPasajerosPremium.Text = "Cantidad máxima pasajeros Premium"
        '
        'lbl_cantPasajerosEconomic
        '
        Me.lbl_cantPasajerosEconomic.AutoSize = True
        Me.lbl_cantPasajerosEconomic.Location = New System.Drawing.Point(10, 35)
        Me.lbl_cantPasajerosEconomic.Name = "lbl_cantPasajerosEconomic"
        Me.lbl_cantPasajerosEconomic.Size = New System.Drawing.Size(185, 13)
        Me.lbl_cantPasajerosEconomic.TabIndex = 0
        Me.lbl_cantPasajerosEconomic.Text = "Cantidad máxima pasajeros Economic"
        '
        'lbl_pesoMaxEquipaje
        '
        Me.lbl_pesoMaxEquipaje.AutoSize = True
        Me.lbl_pesoMaxEquipaje.Location = New System.Drawing.Point(287, 35)
        Me.lbl_pesoMaxEquipaje.Name = "lbl_pesoMaxEquipaje"
        Me.lbl_pesoMaxEquipaje.Size = New System.Drawing.Size(127, 13)
        Me.lbl_pesoMaxEquipaje.TabIndex = 0
        Me.lbl_pesoMaxEquipaje.Text = "Peso máximo de equipaje"
        '
        'box_datosIdentificatorios
        '
        Me.box_datosIdentificatorios.BackColor = System.Drawing.Color.Transparent
        Me.box_datosIdentificatorios.Controls.Add(Me.txt_idAeronave)
        Me.box_datosIdentificatorios.Controls.Add(Me.lbl_Año)
        Me.box_datosIdentificatorios.Controls.Add(Me.lbl_Marca)
        Me.box_datosIdentificatorios.Controls.Add(Me.cbo_añoAeronave)
        Me.box_datosIdentificatorios.Controls.Add(Me.cbo_marcaAeronave)
        Me.box_datosIdentificatorios.Controls.Add(Me.btn_buscarAeronave)
        Me.box_datosIdentificatorios.Controls.Add(Me.lbl_idAeronave)
        Me.box_datosIdentificatorios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.box_datosIdentificatorios.ForeColor = System.Drawing.SystemColors.Info
        Me.box_datosIdentificatorios.Location = New System.Drawing.Point(12, 47)
        Me.box_datosIdentificatorios.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.box_datosIdentificatorios.Name = "box_datosIdentificatorios"
        Me.box_datosIdentificatorios.Padding = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.box_datosIdentificatorios.Size = New System.Drawing.Size(771, 79)
        Me.box_datosIdentificatorios.TabIndex = 3
        Me.box_datosIdentificatorios.TabStop = False
        Me.box_datosIdentificatorios.Text = "Datos identificatorios"
        '
        'txt_idAeronave
        '
        Me.txt_idAeronave.Location = New System.Drawing.Point(111, 35)
        Me.txt_idAeronave.MaxLength = 5
        Me.txt_idAeronave.Name = "txt_idAeronave"
        Me.txt_idAeronave.Size = New System.Drawing.Size(100, 20)
        Me.txt_idAeronave.TabIndex = 0
        '
        'lbl_Año
        '
        Me.lbl_Año.AutoSize = True
        Me.lbl_Año.Location = New System.Drawing.Point(447, 38)
        Me.lbl_Año.Name = "lbl_Año"
        Me.lbl_Año.Size = New System.Drawing.Size(26, 13)
        Me.lbl_Año.TabIndex = 5
        Me.lbl_Año.Text = "Año"
        '
        'lbl_Marca
        '
        Me.lbl_Marca.AutoSize = True
        Me.lbl_Marca.Location = New System.Drawing.Point(247, 38)
        Me.lbl_Marca.Name = "lbl_Marca"
        Me.lbl_Marca.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Marca.TabIndex = 4
        Me.lbl_Marca.Text = "Marca"
        '
        'cbo_añoAeronave
        '
        Me.cbo_añoAeronave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_añoAeronave.Enabled = False
        Me.cbo_añoAeronave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_añoAeronave.FormattingEnabled = True
        Me.cbo_añoAeronave.Items.AddRange(New Object() {"2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990"})
        Me.cbo_añoAeronave.Location = New System.Drawing.Point(479, 35)
        Me.cbo_añoAeronave.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.cbo_añoAeronave.Name = "cbo_añoAeronave"
        Me.cbo_añoAeronave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbo_añoAeronave.Size = New System.Drawing.Size(121, 21)
        Me.cbo_añoAeronave.TabIndex = 2
        '
        'cbo_marcaAeronave
        '
        Me.cbo_marcaAeronave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_marcaAeronave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_marcaAeronave.FormattingEnabled = True
        Me.cbo_marcaAeronave.Location = New System.Drawing.Point(290, 35)
        Me.cbo_marcaAeronave.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.cbo_marcaAeronave.Name = "cbo_marcaAeronave"
        Me.cbo_marcaAeronave.Size = New System.Drawing.Size(121, 21)
        Me.cbo_marcaAeronave.TabIndex = 1
        '
        'btn_buscarAeronave
        '
        Me.btn_buscarAeronave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscarAeronave.Location = New System.Drawing.Point(659, 31)
        Me.btn_buscarAeronave.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btn_buscarAeronave.Name = "btn_buscarAeronave"
        Me.btn_buscarAeronave.Size = New System.Drawing.Size(97, 27)
        Me.btn_buscarAeronave.TabIndex = 6
        Me.btn_buscarAeronave.Text = "Buscar"
        Me.btn_buscarAeronave.UseVisualStyleBackColor = True
        '
        'lbl_idAeronave
        '
        Me.lbl_idAeronave.AutoSize = True
        Me.lbl_idAeronave.Location = New System.Drawing.Point(21, 38)
        Me.lbl_idAeronave.Name = "lbl_idAeronave"
        Me.lbl_idAeronave.Size = New System.Drawing.Size(67, 13)
        Me.lbl_idAeronave.TabIndex = 0
        Me.lbl_idAeronave.Tag = ""
        Me.lbl_idAeronave.Text = "ID Aeronave"
        '
        'grd_Aeronaves
        '
        Me.grd_Aeronaves.AllowUserToAddRows = False
        Me.grd_Aeronaves.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grd_Aeronaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_Aeronaves.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_Aeronaves.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.grd_Aeronaves.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grd_Aeronaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_Aeronaves.Location = New System.Drawing.Point(12, 243)
        Me.grd_Aeronaves.MultiSelect = False
        Me.grd_Aeronaves.Name = "grd_Aeronaves"
        Me.grd_Aeronaves.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grd_Aeronaves.RowHeadersVisible = False
        Me.grd_Aeronaves.RowTemplate.ReadOnly = True
        Me.grd_Aeronaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_Aeronaves.Size = New System.Drawing.Size(771, 167)
        Me.grd_Aeronaves.TabIndex = 5
        '
        'btn_NuevoAeronave
        '
        Me.btn_NuevoAeronave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_NuevoAeronave.BackColor = System.Drawing.Color.Transparent
        Me.btn_NuevoAeronave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_NuevoAeronave.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_NuevoAeronave.Location = New System.Drawing.Point(23, 414)
        Me.btn_NuevoAeronave.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btn_NuevoAeronave.Name = "btn_NuevoAeronave"
        Me.btn_NuevoAeronave.Size = New System.Drawing.Size(97, 27)
        Me.btn_NuevoAeronave.TabIndex = 6
        Me.btn_NuevoAeronave.Text = "Nuevo"
        Me.btn_NuevoAeronave.UseVisualStyleBackColor = False
        '
        'btn_borrarAeronave
        '
        Me.btn_borrarAeronave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_borrarAeronave.BackColor = System.Drawing.Color.Transparent
        Me.btn_borrarAeronave.Enabled = False
        Me.btn_borrarAeronave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_borrarAeronave.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_borrarAeronave.Location = New System.Drawing.Point(126, 414)
        Me.btn_borrarAeronave.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btn_borrarAeronave.Name = "btn_borrarAeronave"
        Me.btn_borrarAeronave.Size = New System.Drawing.Size(97, 27)
        Me.btn_borrarAeronave.TabIndex = 9
        Me.btn_borrarAeronave.Text = "Borrar"
        Me.btn_borrarAeronave.UseVisualStyleBackColor = False
        '
        'btn_salirAeronave
        '
        Me.btn_salirAeronave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_salirAeronave.BackColor = System.Drawing.Color.Transparent
        Me.btn_salirAeronave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salirAeronave.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_salirAeronave.Location = New System.Drawing.Point(674, 414)
        Me.btn_salirAeronave.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btn_salirAeronave.Name = "btn_salirAeronave"
        Me.btn_salirAeronave.Size = New System.Drawing.Size(97, 27)
        Me.btn_salirAeronave.TabIndex = 8
        Me.btn_salirAeronave.Text = "Salir"
        Me.btn_salirAeronave.UseVisualStyleBackColor = False
        '
        'btn_guardarAeronave
        '
        Me.btn_guardarAeronave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_guardarAeronave.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardarAeronave.Enabled = False
        Me.btn_guardarAeronave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarAeronave.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_guardarAeronave.Location = New System.Drawing.Point(571, 414)
        Me.btn_guardarAeronave.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btn_guardarAeronave.Name = "btn_guardarAeronave"
        Me.btn_guardarAeronave.Size = New System.Drawing.Size(97, 27)
        Me.btn_guardarAeronave.TabIndex = 7
        Me.btn_guardarAeronave.Text = "Gurdar"
        Me.btn_guardarAeronave.UseVisualStyleBackColor = False
        '
        'frm_ABMAeronaves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(792, 451)
        Me.Controls.Add(Me.btn_NuevoAeronave)
        Me.Controls.Add(Me.btn_borrarAeronave)
        Me.Controls.Add(Me.btn_salirAeronave)
        Me.Controls.Add(Me.btn_guardarAeronave)
        Me.Controls.Add(Me.grd_Aeronaves)
        Me.Controls.Add(Me.box_caraceristicasAeronave)
        Me.Controls.Add(Me.box_datosIdentificatorios)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_ABMAeronaves"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM - Aeronaves"
        Me.box_caraceristicasAeronave.ResumeLayout(False)
        Me.box_caraceristicasAeronave.PerformLayout()
        Me.box_datosIdentificatorios.ResumeLayout(False)
        Me.box_datosIdentificatorios.PerformLayout()
        CType(Me.grd_Aeronaves, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents box_caraceristicasAeronave As System.Windows.Forms.GroupBox
    Friend WithEvents txt_horasVueloRealizadas As System.Windows.Forms.TextBox
    Friend WithEvents txt_autonomiaVuelo As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantSalidasEmergencia As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantMaxPasPremium As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantMaxPasEconomic As System.Windows.Forms.TextBox
    Friend WithEvents txt_pesoMaxEquipaje As System.Windows.Forms.TextBox
    Friend WithEvents lbl_horasVueloAcumuladas As System.Windows.Forms.Label
    Friend WithEvents lbl_autonomia As System.Windows.Forms.Label
    Friend WithEvents lbl_cantSalidasEmergencia As System.Windows.Forms.Label
    Friend WithEvents lbl_cantPasajerosPremium As System.Windows.Forms.Label
    Friend WithEvents lbl_cantPasajerosEconomic As System.Windows.Forms.Label
    Friend WithEvents lbl_pesoMaxEquipaje As System.Windows.Forms.Label
    Friend WithEvents box_datosIdentificatorios As System.Windows.Forms.GroupBox
    Friend WithEvents txt_idAeronave As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Año As System.Windows.Forms.Label
    Friend WithEvents lbl_Marca As System.Windows.Forms.Label
    Friend WithEvents cbo_añoAeronave As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_marcaAeronave As System.Windows.Forms.ComboBox
    Friend WithEvents btn_buscarAeronave As System.Windows.Forms.Button
    Friend WithEvents lbl_idAeronave As System.Windows.Forms.Label
    Friend WithEvents grd_Aeronaves As System.Windows.Forms.DataGridView
    Friend WithEvents btn_NuevoAeronave As System.Windows.Forms.Button
    Friend WithEvents btn_borrarAeronave As System.Windows.Forms.Button
    Friend WithEvents btn_salirAeronave As System.Windows.Forms.Button
    Friend WithEvents btn_guardarAeronave As System.Windows.Forms.Button

End Class
