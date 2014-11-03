<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_InicioMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_InicioMenu))
        Me.pnl_acceso = New System.Windows.Forms.Panel()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.txt_nombre_Usuario = New System.Windows.Forms.TextBox()
        Me.lbl_contraseña = New System.Windows.Forms.Label()
        Me.lbl_bienvenido = New System.Windows.Forms.Label()
        Me.lbl_nombreUsuario = New System.Windows.Forms.Label()
        Me.btn_Vuelos = New System.Windows.Forms.Button()
        Me.btn_tarjetaEmbarque = New System.Windows.Forms.Button()
        Me.btn_Pasaje = New System.Windows.Forms.Button()
        Me.btn_Reportes = New System.Windows.Forms.Button()
        Me.btn_Estadistica = New System.Windows.Forms.Button()
        Me.btn_Gestion = New System.Windows.Forms.Button()
        Me.btn_Provincias = New System.Windows.Forms.Button()
        Me.btn_Marcas = New System.Windows.Forms.Button()
        Me.btn_Empleado = New System.Windows.Forms.Button()
        Me.btn_Pasajeros = New System.Windows.Forms.Button()
        Me.btn_Cargo = New System.Windows.Forms.Button()
        Me.btn_Aeropuerto = New System.Windows.Forms.Button()
        Me.btn_Localidad = New System.Windows.Forms.Button()
        Me.btn_Aeronaves = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.box_datosLogin = New System.Windows.Forms.Panel()
        Me.lklbl_cerrarSesion = New System.Windows.Forms.LinkLabel()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_aeronavesMasUtilizadas = New System.Windows.Forms.Button()
        Me.btn_cantidadDeVuelos = New System.Windows.Forms.Button()
        Me.btn_DestinosMasFrecuentes = New System.Windows.Forms.Button()
        Me.btm_equipajePorPersona = New System.Windows.Forms.Button()
        Me.btn_capacidadAeronaves = New System.Windows.Forms.Button()
        Me.btn_aeropuertoPorProvincia = New System.Windows.Forms.Button()
        Me.btn_vuelosPorFecha = New System.Windows.Forms.Button()
        Me.pnl_acceso.SuspendLayout()
        Me.box_datosLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_acceso
        '
        Me.pnl_acceso.BackColor = System.Drawing.Color.Transparent
        Me.pnl_acceso.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondoLogin5
        Me.pnl_acceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_acceso.Controls.Add(Me.btn_ingresar)
        Me.pnl_acceso.Controls.Add(Me.txt_contraseña)
        Me.pnl_acceso.Controls.Add(Me.txt_nombre_Usuario)
        Me.pnl_acceso.Controls.Add(Me.lbl_contraseña)
        Me.pnl_acceso.Controls.Add(Me.lbl_bienvenido)
        Me.pnl_acceso.Controls.Add(Me.lbl_nombreUsuario)
        Me.pnl_acceso.Location = New System.Drawing.Point(471, 408)
        Me.pnl_acceso.Name = "pnl_acceso"
        Me.pnl_acceso.Size = New System.Drawing.Size(436, 264)
        Me.pnl_acceso.TabIndex = 1
        '
        'btn_ingresar
        '
        Me.btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ingresar.ForeColor = System.Drawing.Color.MediumPurple
        Me.btn_ingresar.Location = New System.Drawing.Point(148, 183)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(123, 35)
        Me.btn_ingresar.TabIndex = 4
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contraseña.Location = New System.Drawing.Point(217, 126)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña.Size = New System.Drawing.Size(193, 29)
        Me.txt_contraseña.TabIndex = 3
        '
        'txt_nombre_Usuario
        '
        Me.txt_nombre_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_Usuario.Location = New System.Drawing.Point(217, 77)
        Me.txt_nombre_Usuario.Name = "txt_nombre_Usuario"
        Me.txt_nombre_Usuario.Size = New System.Drawing.Size(193, 29)
        Me.txt_nombre_Usuario.TabIndex = 2
        '
        'lbl_contraseña
        '
        Me.lbl_contraseña.AutoSize = True
        Me.lbl_contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contraseña.ForeColor = System.Drawing.Color.MediumPurple
        Me.lbl_contraseña.Location = New System.Drawing.Point(17, 128)
        Me.lbl_contraseña.Name = "lbl_contraseña"
        Me.lbl_contraseña.Size = New System.Drawing.Size(116, 24)
        Me.lbl_contraseña.TabIndex = 1
        Me.lbl_contraseña.Text = "Contraseña"
        '
        'lbl_bienvenido
        '
        Me.lbl_bienvenido.AutoSize = True
        Me.lbl_bienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bienvenido.ForeColor = System.Drawing.Color.MediumPurple
        Me.lbl_bienvenido.Location = New System.Drawing.Point(131, 15)
        Me.lbl_bienvenido.Name = "lbl_bienvenido"
        Me.lbl_bienvenido.Size = New System.Drawing.Size(169, 33)
        Me.lbl_bienvenido.TabIndex = 0
        Me.lbl_bienvenido.Text = "Bienvenido"
        '
        'lbl_nombreUsuario
        '
        Me.lbl_nombreUsuario.AutoSize = True
        Me.lbl_nombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombreUsuario.ForeColor = System.Drawing.Color.MediumPurple
        Me.lbl_nombreUsuario.Location = New System.Drawing.Point(17, 79)
        Me.lbl_nombreUsuario.Name = "lbl_nombreUsuario"
        Me.lbl_nombreUsuario.Size = New System.Drawing.Size(190, 24)
        Me.lbl_nombreUsuario.TabIndex = 0
        Me.lbl_nombreUsuario.Text = "Nombre de usuario"
        '
        'btn_Vuelos
        '
        Me.btn_Vuelos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Vuelos.Image = Global.WindowsApplication1.My.Resources.Resources.botonVuelos
        Me.btn_Vuelos.Location = New System.Drawing.Point(12, 162)
        Me.btn_Vuelos.Name = "btn_Vuelos"
        Me.btn_Vuelos.Size = New System.Drawing.Size(227, 69)
        Me.btn_Vuelos.TabIndex = 5
        Me.btn_Vuelos.UseVisualStyleBackColor = True
        Me.btn_Vuelos.Visible = False
        '
        'btn_tarjetaEmbarque
        '
        Me.btn_tarjetaEmbarque.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_tarjetaEmbarque.Image = Global.WindowsApplication1.My.Resources.Resources.botonTarjetaEmbarque
        Me.btn_tarjetaEmbarque.Location = New System.Drawing.Point(10, 87)
        Me.btn_tarjetaEmbarque.Name = "btn_tarjetaEmbarque"
        Me.btn_tarjetaEmbarque.Size = New System.Drawing.Size(227, 69)
        Me.btn_tarjetaEmbarque.TabIndex = 6
        Me.btn_tarjetaEmbarque.UseVisualStyleBackColor = True
        Me.btn_tarjetaEmbarque.Visible = False
        '
        'btn_Pasaje
        '
        Me.btn_Pasaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Pasaje.Image = Global.WindowsApplication1.My.Resources.Resources.botonPasajes2
        Me.btn_Pasaje.Location = New System.Drawing.Point(12, 12)
        Me.btn_Pasaje.Name = "btn_Pasaje"
        Me.btn_Pasaje.Size = New System.Drawing.Size(227, 69)
        Me.btn_Pasaje.TabIndex = 7
        Me.btn_Pasaje.UseVisualStyleBackColor = True
        Me.btn_Pasaje.Visible = False
        '
        'btn_Reportes
        '
        Me.btn_Reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Reportes.Image = Global.WindowsApplication1.My.Resources.Resources.botonReportes
        Me.btn_Reportes.Location = New System.Drawing.Point(10, 387)
        Me.btn_Reportes.Name = "btn_Reportes"
        Me.btn_Reportes.Size = New System.Drawing.Size(227, 69)
        Me.btn_Reportes.TabIndex = 2
        Me.btn_Reportes.UseVisualStyleBackColor = True
        Me.btn_Reportes.Visible = False
        '
        'btn_Estadistica
        '
        Me.btn_Estadistica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Estadistica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Estadistica.Image = Global.WindowsApplication1.My.Resources.Resources.botonEstadistica
        Me.btn_Estadistica.Location = New System.Drawing.Point(12, 312)
        Me.btn_Estadistica.Name = "btn_Estadistica"
        Me.btn_Estadistica.Size = New System.Drawing.Size(227, 69)
        Me.btn_Estadistica.TabIndex = 3
        Me.btn_Estadistica.UseVisualStyleBackColor = True
        Me.btn_Estadistica.Visible = False
        '
        'btn_Gestion
        '
        Me.btn_Gestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Gestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Gestion.Image = Global.WindowsApplication1.My.Resources.Resources.botonGestion
        Me.btn_Gestion.Location = New System.Drawing.Point(12, 237)
        Me.btn_Gestion.Name = "btn_Gestion"
        Me.btn_Gestion.Size = New System.Drawing.Size(227, 69)
        Me.btn_Gestion.TabIndex = 4
        Me.btn_Gestion.UseVisualStyleBackColor = True
        Me.btn_Gestion.Visible = False
        '
        'btn_Provincias
        '
        Me.btn_Provincias.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Provincias.Image = Global.WindowsApplication1.My.Resources.Resources.botonProvincias
        Me.btn_Provincias.Location = New System.Drawing.Point(721, 273)
        Me.btn_Provincias.Name = "btn_Provincias"
        Me.btn_Provincias.Size = New System.Drawing.Size(227, 69)
        Me.btn_Provincias.TabIndex = 13
        Me.btn_Provincias.UseVisualStyleBackColor = True
        Me.btn_Provincias.Visible = False
        '
        'btn_Marcas
        '
        Me.btn_Marcas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Marcas.Image = Global.WindowsApplication1.My.Resources.Resources.botonMarcas
        Me.btn_Marcas.Location = New System.Drawing.Point(954, 273)
        Me.btn_Marcas.Name = "btn_Marcas"
        Me.btn_Marcas.Size = New System.Drawing.Size(227, 69)
        Me.btn_Marcas.TabIndex = 12
        Me.btn_Marcas.UseVisualStyleBackColor = True
        Me.btn_Marcas.Visible = False
        '
        'btn_Empleado
        '
        Me.btn_Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Empleado.Image = Global.WindowsApplication1.My.Resources.Resources.botonEmpleados
        Me.btn_Empleado.Location = New System.Drawing.Point(954, 199)
        Me.btn_Empleado.Name = "btn_Empleado"
        Me.btn_Empleado.Size = New System.Drawing.Size(227, 69)
        Me.btn_Empleado.TabIndex = 15
        Me.btn_Empleado.UseVisualStyleBackColor = True
        Me.btn_Empleado.Visible = False
        '
        'btn_Pasajeros
        '
        Me.btn_Pasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Pasajeros.Image = Global.WindowsApplication1.My.Resources.Resources.botonPasajeros
        Me.btn_Pasajeros.Location = New System.Drawing.Point(255, 273)
        Me.btn_Pasajeros.Name = "btn_Pasajeros"
        Me.btn_Pasajeros.Size = New System.Drawing.Size(227, 69)
        Me.btn_Pasajeros.TabIndex = 14
        Me.btn_Pasajeros.UseVisualStyleBackColor = True
        Me.btn_Pasajeros.Visible = False
        '
        'btn_Cargo
        '
        Me.btn_Cargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Cargo.Image = Global.WindowsApplication1.My.Resources.Resources.botonCargos
        Me.btn_Cargo.Location = New System.Drawing.Point(721, 199)
        Me.btn_Cargo.Name = "btn_Cargo"
        Me.btn_Cargo.Size = New System.Drawing.Size(227, 69)
        Me.btn_Cargo.TabIndex = 9
        Me.btn_Cargo.UseVisualStyleBackColor = True
        Me.btn_Cargo.Visible = False
        '
        'btn_Aeropuerto
        '
        Me.btn_Aeropuerto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Aeropuerto.Image = Global.WindowsApplication1.My.Resources.Resources.botonAeropuertos
        Me.btn_Aeropuerto.Location = New System.Drawing.Point(488, 199)
        Me.btn_Aeropuerto.Name = "btn_Aeropuerto"
        Me.btn_Aeropuerto.Size = New System.Drawing.Size(227, 69)
        Me.btn_Aeropuerto.TabIndex = 8
        Me.btn_Aeropuerto.UseVisualStyleBackColor = True
        Me.btn_Aeropuerto.Visible = False
        '
        'btn_Localidad
        '
        Me.btn_Localidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Localidad.Image = Global.WindowsApplication1.My.Resources.Resources.botonLocalidades
        Me.btn_Localidad.Location = New System.Drawing.Point(488, 274)
        Me.btn_Localidad.Name = "btn_Localidad"
        Me.btn_Localidad.Size = New System.Drawing.Size(227, 69)
        Me.btn_Localidad.TabIndex = 11
        Me.btn_Localidad.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_Localidad.UseVisualStyleBackColor = True
        Me.btn_Localidad.Visible = False
        '
        'btn_Aeronaves
        '
        Me.btn_Aeronaves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Aeronaves.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Aeronaves.Image = Global.WindowsApplication1.My.Resources.Resources.botonAeronaves
        Me.btn_Aeronaves.Location = New System.Drawing.Point(255, 198)
        Me.btn_Aeronaves.Name = "btn_Aeronaves"
        Me.btn_Aeronaves.Size = New System.Drawing.Size(227, 69)
        Me.btn_Aeronaves.TabIndex = 10
        Me.btn_Aeronaves.UseVisualStyleBackColor = True
        Me.btn_Aeronaves.Visible = False
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.BackColor = System.Drawing.Color.Transparent
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_salir.Image = Global.WindowsApplication1.My.Resources.Resources.botonSalir
        Me.btn_salir.Location = New System.Drawing.Point(1219, 677)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(119, 41)
        Me.btn_salir.TabIndex = 16
        Me.btn_salir.UseVisualStyleBackColor = False
        Me.btn_salir.Visible = False
        '
        'box_datosLogin
        '
        Me.box_datosLogin.BackColor = System.Drawing.Color.Transparent
        Me.box_datosLogin.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondoLogin5
        Me.box_datosLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.box_datosLogin.Controls.Add(Me.lklbl_cerrarSesion)
        Me.box_datosLogin.Controls.Add(Me.lbl_usuario)
        Me.box_datosLogin.Controls.Add(Me.lbl_Fecha)
        Me.box_datosLogin.Location = New System.Drawing.Point(1030, 12)
        Me.box_datosLogin.Name = "box_datosLogin"
        Me.box_datosLogin.Size = New System.Drawing.Size(227, 86)
        Me.box_datosLogin.TabIndex = 17
        Me.box_datosLogin.Visible = False
        '
        'lklbl_cerrarSesion
        '
        Me.lklbl_cerrarSesion.AutoSize = True
        Me.lklbl_cerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklbl_cerrarSesion.Location = New System.Drawing.Point(133, 21)
        Me.lklbl_cerrarSesion.Name = "lklbl_cerrarSesion"
        Me.lklbl_cerrarSesion.Size = New System.Drawing.Size(80, 15)
        Me.lklbl_cerrarSesion.TabIndex = 2
        Me.lklbl_cerrarSesion.TabStop = True
        Me.lklbl_cerrarSesion.Text = "Cerrar sesión"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_usuario.Location = New System.Drawing.Point(32, 19)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(67, 18)
        Me.lbl_usuario.TabIndex = 1
        Me.lbl_usuario.Text = "Usuario"
        Me.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(51, 47)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(49, 18)
        Me.lbl_Fecha.TabIndex = 0
        Me.lbl_Fecha.Text = "Fecha"
        Me.lbl_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btn_aeronavesMasUtilizadas
        '
        Me.btn_aeronavesMasUtilizadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_aeronavesMasUtilizadas.Image = CType(resources.GetObject("btn_aeronavesMasUtilizadas.Image"), System.Drawing.Image)
        Me.btn_aeronavesMasUtilizadas.Location = New System.Drawing.Point(255, 312)
        Me.btn_aeronavesMasUtilizadas.Name = "btn_aeronavesMasUtilizadas"
        Me.btn_aeronavesMasUtilizadas.Size = New System.Drawing.Size(227, 69)
        Me.btn_aeronavesMasUtilizadas.TabIndex = 18
        Me.btn_aeronavesMasUtilizadas.UseVisualStyleBackColor = True
        Me.btn_aeronavesMasUtilizadas.Visible = False
        '
        'btn_cantidadDeVuelos
        '
        Me.btn_cantidadDeVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cantidadDeVuelos.Image = CType(resources.GetObject("btn_cantidadDeVuelos.Image"), System.Drawing.Image)
        Me.btn_cantidadDeVuelos.Location = New System.Drawing.Point(488, 312)
        Me.btn_cantidadDeVuelos.Name = "btn_cantidadDeVuelos"
        Me.btn_cantidadDeVuelos.Size = New System.Drawing.Size(227, 69)
        Me.btn_cantidadDeVuelos.TabIndex = 19
        Me.btn_cantidadDeVuelos.UseVisualStyleBackColor = True
        Me.btn_cantidadDeVuelos.Visible = False
        '
        'btn_DestinosMasFrecuentes
        '
        Me.btn_DestinosMasFrecuentes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_DestinosMasFrecuentes.Image = CType(resources.GetObject("btn_DestinosMasFrecuentes.Image"), System.Drawing.Image)
        Me.btn_DestinosMasFrecuentes.Location = New System.Drawing.Point(721, 312)
        Me.btn_DestinosMasFrecuentes.Name = "btn_DestinosMasFrecuentes"
        Me.btn_DestinosMasFrecuentes.Size = New System.Drawing.Size(227, 69)
        Me.btn_DestinosMasFrecuentes.TabIndex = 20
        Me.btn_DestinosMasFrecuentes.UseVisualStyleBackColor = True
        Me.btn_DestinosMasFrecuentes.Visible = False
        '
        'btm_equipajePorPersona
        '
        Me.btm_equipajePorPersona.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btm_equipajePorPersona.Image = CType(resources.GetObject("btm_equipajePorPersona.Image"), System.Drawing.Image)
        Me.btm_equipajePorPersona.Location = New System.Drawing.Point(721, 387)
        Me.btm_equipajePorPersona.Name = "btm_equipajePorPersona"
        Me.btm_equipajePorPersona.Size = New System.Drawing.Size(227, 69)
        Me.btm_equipajePorPersona.TabIndex = 23
        Me.btm_equipajePorPersona.UseVisualStyleBackColor = True
        Me.btm_equipajePorPersona.Visible = False
        '
        'btn_capacidadAeronaves
        '
        Me.btn_capacidadAeronaves.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_capacidadAeronaves.Image = CType(resources.GetObject("btn_capacidadAeronaves.Image"), System.Drawing.Image)
        Me.btn_capacidadAeronaves.Location = New System.Drawing.Point(488, 387)
        Me.btn_capacidadAeronaves.Name = "btn_capacidadAeronaves"
        Me.btn_capacidadAeronaves.Size = New System.Drawing.Size(227, 69)
        Me.btn_capacidadAeronaves.TabIndex = 22
        Me.btn_capacidadAeronaves.UseVisualStyleBackColor = True
        Me.btn_capacidadAeronaves.Visible = False
        '
        'btn_aeropuertoPorProvincia
        '
        Me.btn_aeropuertoPorProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_aeropuertoPorProvincia.Image = CType(resources.GetObject("btn_aeropuertoPorProvincia.Image"), System.Drawing.Image)
        Me.btn_aeropuertoPorProvincia.Location = New System.Drawing.Point(255, 387)
        Me.btn_aeropuertoPorProvincia.Name = "btn_aeropuertoPorProvincia"
        Me.btn_aeropuertoPorProvincia.Size = New System.Drawing.Size(227, 69)
        Me.btn_aeropuertoPorProvincia.TabIndex = 21
        Me.btn_aeropuertoPorProvincia.UseVisualStyleBackColor = True
        Me.btn_aeropuertoPorProvincia.Visible = False
        '
        'btn_vuelosPorFecha
        '
        Me.btn_vuelosPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_vuelosPorFecha.Image = CType(resources.GetObject("btn_vuelosPorFecha.Image"), System.Drawing.Image)
        Me.btn_vuelosPorFecha.Location = New System.Drawing.Point(954, 387)
        Me.btn_vuelosPorFecha.Name = "btn_vuelosPorFecha"
        Me.btn_vuelosPorFecha.Size = New System.Drawing.Size(227, 69)
        Me.btn_vuelosPorFecha.TabIndex = 24
        Me.btn_vuelosPorFecha.UseVisualStyleBackColor = True
        Me.btn_vuelosPorFecha.Visible = False
        '
        'frm_InicioMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondoLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.btn_vuelosPorFecha)
        Me.Controls.Add(Me.btm_equipajePorPersona)
        Me.Controls.Add(Me.btn_capacidadAeronaves)
        Me.Controls.Add(Me.btn_aeropuertoPorProvincia)
        Me.Controls.Add(Me.btn_DestinosMasFrecuentes)
        Me.Controls.Add(Me.btn_cantidadDeVuelos)
        Me.Controls.Add(Me.btn_aeronavesMasUtilizadas)
        Me.Controls.Add(Me.box_datosLogin)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_Provincias)
        Me.Controls.Add(Me.btn_Marcas)
        Me.Controls.Add(Me.btn_Empleado)
        Me.Controls.Add(Me.btn_Pasajeros)
        Me.Controls.Add(Me.btn_Cargo)
        Me.Controls.Add(Me.btn_Aeropuerto)
        Me.Controls.Add(Me.btn_Localidad)
        Me.Controls.Add(Me.btn_Aeronaves)
        Me.Controls.Add(Me.btn_Vuelos)
        Me.Controls.Add(Me.btn_tarjetaEmbarque)
        Me.Controls.Add(Me.btn_Pasaje)
        Me.Controls.Add(Me.btn_Reportes)
        Me.Controls.Add(Me.btn_Estadistica)
        Me.Controls.Add(Me.btn_Gestion)
        Me.Controls.Add(Me.pnl_acceso)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_InicioMenu"
        Me.Text = "Bienvenido - ArgenSky"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_acceso.ResumeLayout(False)
        Me.pnl_acceso.PerformLayout()
        Me.box_datosLogin.ResumeLayout(False)
        Me.box_datosLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_acceso As System.Windows.Forms.Panel
    Friend WithEvents btn_ingresar As System.Windows.Forms.Button
    Friend WithEvents txt_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_contraseña As System.Windows.Forms.Label
    Friend WithEvents lbl_bienvenido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombreUsuario As System.Windows.Forms.Label
    Friend WithEvents btn_Vuelos As System.Windows.Forms.Button
    Friend WithEvents btn_tarjetaEmbarque As System.Windows.Forms.Button
    Friend WithEvents btn_Pasaje As System.Windows.Forms.Button
    Friend WithEvents btn_Reportes As System.Windows.Forms.Button
    Friend WithEvents btn_Estadistica As System.Windows.Forms.Button
    Friend WithEvents btn_Gestion As System.Windows.Forms.Button
    Friend WithEvents btn_Provincias As System.Windows.Forms.Button
    Friend WithEvents btn_Marcas As System.Windows.Forms.Button
    Friend WithEvents btn_Empleado As System.Windows.Forms.Button
    Friend WithEvents btn_Pasajeros As System.Windows.Forms.Button
    Friend WithEvents btn_Cargo As System.Windows.Forms.Button
    Friend WithEvents btn_Aeropuerto As System.Windows.Forms.Button
    Friend WithEvents btn_Localidad As System.Windows.Forms.Button
    Friend WithEvents btn_Aeronaves As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents box_datosLogin As System.Windows.Forms.Panel
    Friend WithEvents lklbl_cerrarSesion As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_aeronavesMasUtilizadas As System.Windows.Forms.Button
    Friend WithEvents btn_cantidadDeVuelos As System.Windows.Forms.Button
    Friend WithEvents btn_DestinosMasFrecuentes As System.Windows.Forms.Button
    Friend WithEvents btm_equipajePorPersona As System.Windows.Forms.Button
    Friend WithEvents btn_capacidadAeronaves As System.Windows.Forms.Button
    Friend WithEvents btn_aeropuertoPorProvincia As System.Windows.Forms.Button
    Friend WithEvents btn_vuelosPorFecha As System.Windows.Forms.Button

End Class
