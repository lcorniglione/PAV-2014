<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_abmPasajeros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_abmPasajeros))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_sexo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_nacionalidad = New System.Windows.Forms.ComboBox()
        Me.txt_apellidoPasajero = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nombrePasajero = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_borrar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.grd_pasajeros = New System.Windows.Forms.DataGridView()
        Me.gbx_pasajero = New System.Windows.Forms.GroupBox()
        Me.cbo_tipoDocumento = New System.Windows.Forms.ComboBox()
        Me.txt_numeroDocumento = New System.Windows.Forms.TextBox()
        Me.lbl_numeroDocumento = New System.Windows.Forms.Label()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.lbl_tipoDocumento = New System.Windows.Forms.Label()
        Me.txt_idPasajero = New System.Windows.Forms.TextBox()
        Me.lbl_idPasajero = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd_pasajeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_pasajero.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbo_sexo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbo_nacionalidad)
        Me.GroupBox1.Controls.Add(Me.txt_apellidoPasajero)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_nombrePasajero)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Location = New System.Drawing.Point(21, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(743, 94)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pasajeros"
        '
        'cbo_sexo
        '
        Me.cbo_sexo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cbo_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_sexo.Enabled = False
        Me.cbo_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_sexo.FormattingEnabled = True
        Me.cbo_sexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cbo_sexo.Location = New System.Drawing.Point(70, 57)
        Me.cbo_sexo.Name = "cbo_sexo"
        Me.cbo_sexo.Size = New System.Drawing.Size(100, 21)
        Me.cbo_sexo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sexo"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nacionalidad"
        '
        'cbo_nacionalidad
        '
        Me.cbo_nacionalidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cbo_nacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_nacionalidad.Enabled = False
        Me.cbo_nacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_nacionalidad.FormattingEnabled = True
        Me.cbo_nacionalidad.Items.AddRange(New Object() {"Afganistán", "Akrotiri", "Albania", "Alemania", "Andorra", "Angola", "Anguila", "Antártida", "Antigua y Barbuda", "Antillas Neerlandesas", "Arabia Saudí", "Arctic Ocean", "Argelia", "Argentina", "Armenia", "Aruba", "Ashmore and Cartier Islands", "Atlantic Ocean", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bahráin", "Bangladesh", "Barbados", "Bélgica", "Belice", "Benín", "Bermudas", "Bielorrusia", "Birmania; Myanmar", "Bolivia", "Bosnia y Hercegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Chad", "Chile", "China", "Chipre", "Clipperton Island", "Colombia", "Comoras", "Congo", "Coral Sea Islands", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dhekelia", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "El Vaticano", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Gaza Strip", "Georgia", "Ghana", "Gibraltar", "Granada", "Grecia", "Groenlandia", "Guam", "Guatemala", "Guernsey", "Guinea", "Guinea Ecuatorial", "Guinea-Bissau", "Guyana", "Haití", "Honduras", "Hong Kong", "Hungría", "India", "Indian Ocean", "Indonesia", "Irán", "Iraq", "Irlanda", "Isla Bouvet", "Isla Christmas", "Isla Norfolk", "Islandia", "Islas Caimán", "Islas Cocos", "Islas Cook", "Islas Feroe", "Islas Georgia del Sur y Sandwich del Sur", "Islas Heard y McDonald", "Islas Malvinas", "Islas Marianas del Norte", "Islas Marshall", "Islas Pitcairn", "Islas Salomón", "Islas Turcas y Caicos", "Islas Vírgenes Americanas", "Islas Vírgenes Británicas", "Israel", "Italia", "Jamaica", "Jan Mayen", "Japón", "Jersey", "Jordania", "Kazajistán", "Kenia", "Kirguizistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Macao", "Macedonia", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Man, Isle of", "Marruecos", "Mauricio", "Mauritania", "Mayotte", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Montserrat", "Mozambique", "Mundo", "Namia", "Nauru", "Navassa Island", "Nepal", "Nicaragua", "Níger", "Nigeria", "Niue", "Noruega", "Nueva Caledonia", "Nueva Zelanda", "Omán", "Pacific Ocean", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa-Nueva Guinea", "Paracel Islands", "Paraguay", "Perú", "Polinesia Francesa", "Polonia", "Portugal", "Puerto Rico", "Qatar", "Reino Unido", "República Centroafricana", "República Checa", "República Democrática del Congo", "República Dominicana", "Ruanda", "Rumania", "Rusia", "Sáhara Occidental", "Samoa", "Samoa Americana", "San Cristóbal y Nieves", "San Marino", "San Pedro y Miquelón", "San Vicente y las Granadinas", "Santa Helena", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Serbia", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Southern Ocean", "Spratly Islands", "Sri Lanka", "Suazilandia", "Sudáfrica", "Sudán", "Suecia", "Suiza", "Surinam", "Svalbard y Jan Mayen", "Tailandia", "Taiwán", "Tanzania", "Tayikistán", "Territorio Británico del Océano Indico", "Territorios Australes Franceses", "Timor Oriental", "Togo", "Tokelau", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Unión Europea", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Wake Island", "Wallis y Futuna", "West Bank", "Yemen", "Yibuti", "Zambia", "Zimbabue"})
        Me.cbo_nacionalidad.Location = New System.Drawing.Point(282, 56)
        Me.cbo_nacionalidad.Name = "cbo_nacionalidad"
        Me.cbo_nacionalidad.Size = New System.Drawing.Size(121, 21)
        Me.cbo_nacionalidad.TabIndex = 3
        '
        'txt_apellidoPasajero
        '
        Me.txt_apellidoPasajero.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_apellidoPasajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_apellidoPasajero.Enabled = False
        Me.txt_apellidoPasajero.Location = New System.Drawing.Point(282, 26)
        Me.txt_apellidoPasajero.Name = "txt_apellidoPasajero"
        Me.txt_apellidoPasajero.Size = New System.Drawing.Size(121, 20)
        Me.txt_apellidoPasajero.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(190, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Apellido"
        '
        'txt_nombrePasajero
        '
        Me.txt_nombrePasajero.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_nombrePasajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombrePasajero.Enabled = False
        Me.txt_nombrePasajero.Location = New System.Drawing.Point(70, 30)
        Me.txt_nombrePasajero.Name = "txt_nombrePasajero"
        Me.txt_nombrePasajero.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombrePasajero.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nombre "
        '
        'cmd_salir
        '
        Me.cmd_salir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmd_salir.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_salir.ForeColor = System.Drawing.Color.White
        Me.cmd_salir.Location = New System.Drawing.Point(654, 447)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(97, 27)
        Me.cmd_salir.TabIndex = 12
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'cmd_borrar
        '
        Me.cmd_borrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmd_borrar.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmd_borrar.Enabled = False
        Me.cmd_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_borrar.ForeColor = System.Drawing.Color.White
        Me.cmd_borrar.Location = New System.Drawing.Point(537, 447)
        Me.cmd_borrar.Name = "cmd_borrar"
        Me.cmd_borrar.Size = New System.Drawing.Size(97, 27)
        Me.cmd_borrar.TabIndex = 11
        Me.cmd_borrar.Text = "Borrar"
        Me.cmd_borrar.UseVisualStyleBackColor = False
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmd_guardar.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmd_guardar.Enabled = False
        Me.cmd_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_guardar.ForeColor = System.Drawing.Color.White
        Me.cmd_guardar.Location = New System.Drawing.Point(122, 447)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(97, 27)
        Me.cmd_guardar.TabIndex = 10
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = False
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmd_nuevo.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_nuevo.ForeColor = System.Drawing.Color.White
        Me.cmd_nuevo.Location = New System.Drawing.Point(19, 447)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(97, 27)
        Me.cmd_nuevo.TabIndex = 9
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'grd_pasajeros
        '
        Me.grd_pasajeros.AllowUserToAddRows = False
        Me.grd_pasajeros.AllowUserToDeleteRows = False
        Me.grd_pasajeros.AllowUserToResizeColumns = False
        Me.grd_pasajeros.AllowUserToResizeRows = False
        Me.grd_pasajeros.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.grd_pasajeros.BackgroundColor = System.Drawing.Color.White
        Me.grd_pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_pasajeros.Location = New System.Drawing.Point(19, 219)
        Me.grd_pasajeros.Name = "grd_pasajeros"
        Me.grd_pasajeros.ReadOnly = True
        Me.grd_pasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_pasajeros.Size = New System.Drawing.Size(743, 222)
        Me.grd_pasajeros.TabIndex = 13
        '
        'gbx_pasajero
        '
        Me.gbx_pasajero.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbx_pasajero.BackColor = System.Drawing.Color.Transparent
        Me.gbx_pasajero.Controls.Add(Me.cbo_tipoDocumento)
        Me.gbx_pasajero.Controls.Add(Me.txt_numeroDocumento)
        Me.gbx_pasajero.Controls.Add(Me.lbl_numeroDocumento)
        Me.gbx_pasajero.Controls.Add(Me.cmd_buscar)
        Me.gbx_pasajero.Controls.Add(Me.lbl_tipoDocumento)
        Me.gbx_pasajero.Controls.Add(Me.txt_idPasajero)
        Me.gbx_pasajero.Controls.Add(Me.lbl_idPasajero)
        Me.gbx_pasajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbx_pasajero.ForeColor = System.Drawing.SystemColors.Info
        Me.gbx_pasajero.Location = New System.Drawing.Point(19, 48)
        Me.gbx_pasajero.Name = "gbx_pasajero"
        Me.gbx_pasajero.Size = New System.Drawing.Size(743, 65)
        Me.gbx_pasajero.TabIndex = 7
        Me.gbx_pasajero.TabStop = False
        Me.gbx_pasajero.Text = "Pasajeros/Datos de busqueda"
        '
        'cbo_tipoDocumento
        '
        Me.cbo_tipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cbo_tipoDocumento.DisplayMember = "descripcion"
        Me.cbo_tipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_tipoDocumento.FormattingEnabled = True
        Me.cbo_tipoDocumento.Location = New System.Drawing.Point(284, 28)
        Me.cbo_tipoDocumento.Name = "cbo_tipoDocumento"
        Me.cbo_tipoDocumento.Size = New System.Drawing.Size(121, 21)
        Me.cbo_tipoDocumento.TabIndex = 1
        Me.cbo_tipoDocumento.ValueMember = "id_TipoDoc"
        '
        'txt_numeroDocumento
        '
        Me.txt_numeroDocumento.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_numeroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numeroDocumento.Location = New System.Drawing.Point(494, 28)
        Me.txt_numeroDocumento.Name = "txt_numeroDocumento"
        Me.txt_numeroDocumento.Size = New System.Drawing.Size(121, 20)
        Me.txt_numeroDocumento.TabIndex = 2
        '
        'lbl_numeroDocumento
        '
        Me.lbl_numeroDocumento.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_numeroDocumento.AutoSize = True
        Me.lbl_numeroDocumento.Location = New System.Drawing.Point(421, 31)
        Me.lbl_numeroDocumento.Name = "lbl_numeroDocumento"
        Me.lbl_numeroDocumento.Size = New System.Drawing.Size(67, 13)
        Me.lbl_numeroDocumento.TabIndex = 0
        Me.lbl_numeroDocumento.Text = "Numero Doc"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmd_buscar.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmd_buscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar.ForeColor = System.Drawing.Color.White
        Me.cmd_buscar.Location = New System.Drawing.Point(635, 24)
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
        Me.lbl_tipoDocumento.Location = New System.Drawing.Point(192, 31)
        Me.lbl_tipoDocumento.Name = "lbl_tipoDocumento"
        Me.lbl_tipoDocumento.Size = New System.Drawing.Size(86, 13)
        Me.lbl_tipoDocumento.TabIndex = 0
        Me.lbl_tipoDocumento.Text = "Tipo Documento"
        '
        'txt_idPasajero
        '
        Me.txt_idPasajero.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_idPasajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_idPasajero.Location = New System.Drawing.Point(72, 28)
        Me.txt_idPasajero.Name = "txt_idPasajero"
        Me.txt_idPasajero.Size = New System.Drawing.Size(100, 20)
        Me.txt_idPasajero.TabIndex = 0
        '
        'lbl_idPasajero
        '
        Me.lbl_idPasajero.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_idPasajero.AutoSize = True
        Me.lbl_idPasajero.Location = New System.Drawing.Point(6, 31)
        Me.lbl_idPasajero.Name = "lbl_idPasajero"
        Me.lbl_idPasajero.Size = New System.Drawing.Size(60, 13)
        Me.lbl_idPasajero.TabIndex = 0
        Me.lbl_idPasajero.Text = "Id Pasajero"
        '
        'frm_abmPasajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(778, 478)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_borrar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.grd_pasajeros)
        Me.Controls.Add(Me.gbx_pasajero)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(784, 1080)
        Me.MinimumSize = New System.Drawing.Size(784, 469)
        Me.Name = "frm_abmPasajeros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Pasajeros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grd_pasajeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_pasajero.ResumeLayout(False)
        Me.gbx_pasajero.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbo_nacionalidad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_apellidoPasajero As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_nombrePasajero As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_borrar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents grd_pasajeros As System.Windows.Forms.DataGridView
    Friend WithEvents gbx_pasajero As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_tipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_numeroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_numeroDocumento As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_tipoDocumento As System.Windows.Forms.Label
    Friend WithEvents txt_idPasajero As System.Windows.Forms.TextBox
    Friend WithEvents lbl_idPasajero As System.Windows.Forms.Label
End Class
