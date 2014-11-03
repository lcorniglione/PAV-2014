Public Class frm_InicioMenu

    Dim string_conexion As String = "workstation id=ArgenSky.mssql.somee.com;packet size=4096;user id=adminargensky;pwd=pav.2014;data source=ArgenSky.mssql.somee.com;persist security info=False;initial catalog=ArgenSky"
    Dim bandera As Boolean = False
    Dim gestion As Boolean = False
    Dim reportes As Boolean = False
    Dim estadisticas As Boolean = False
    Dim sesion As Boolean = False
    

    Private Sub frm_InicioMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = btn_ingresar

    End Sub

    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingresar.Click
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand


        conexion.ConnectionString = Me.string_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Usuario "
        'cmd.CommandText += "where nombre_Usuario like '" & txt_nombre_Usuario.Text & "' AND password like '" & txt_contraseña.Text & "'"
        cmd.CommandText = "select * from Usuario where nombre_Usuario like 'Lucho' AND password like '123456'"

        If (cmd.ExecuteReader().HasRows()) Then

            lbl_usuario.Text = txt_nombre_Usuario.Text
            mostrar_Menu()
            sesion = True

        Else
            MessageBox.Show("Usuario o contraseña incorrecto", "Acceso incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txt_nombre_Usuario.SelectAll()
            txt_nombre_Usuario.Focus()
            txt_contraseña.Text = ""
        End If

    End Sub

    Private Sub mostrar_Menu()
        btn_salir.Visible = True
        pnl_acceso.Visible = False
        Me.Text = "Menú - ArgenSky"
        btn_Gestion.Visible = True
        btn_Pasaje.Visible = True
        btn_Estadistica.Visible = True
        btn_Vuelos.Visible = True
        btn_tarjetaEmbarque.Visible = True
        btn_Reportes.Visible = True
        box_datosLogin.Visible = True

        lbl_Fecha.Text = Date.Now

        bandera = True
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub frm_Menu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        If (sesion = True) Then
            If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btn_Gestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Gestion.Click
        If (btn_aeropuertoPorProvincia.Visible = True) Then
            btn_Reportes.PerformClick()
        End If
        If (btn_aeronavesMasUtilizadas.Visible = True) Then
            btn_Estadistica.PerformClick()
        End If

        If (gestion = False) Then
            btn_Aeronaves.Visible = True
            btn_Aeropuerto.Visible = True
            btn_Cargo.Visible = True
            btn_Empleado.Visible = True
            btn_Localidad.Visible = True
            btn_Marcas.Visible = True
            btn_Pasajeros.Visible = True
            btn_Provincias.Visible = True

            gestion = True
        Else
            btn_Aeronaves.Visible = False
            btn_Aeropuerto.Visible = False
            btn_Cargo.Visible = False
            btn_Empleado.Visible = False
            btn_Localidad.Visible = False
            btn_Marcas.Visible = False
            btn_Pasajeros.Visible = False
            btn_Provincias.Visible = False

            gestion = False
        End If

    End Sub


    Private Sub lklbl_cerrarSesion_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklbl_cerrarSesion.LinkClicked
        If MessageBox.Show("¿Seguro que desea cerrar sesión?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sesion = False
            Application.Restart()

        End If
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lbl_Fecha.Text = Format(DateTime.Now, "dd/MM/yyyy - H:mm")

    End Sub

    Private Sub btn_Marcas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Marcas.Click
        frm_ABMMarcas.ShowDialog()
    End Sub

    Private Sub btn_Aeronaves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aeronaves.Click
        frm_ABMAeronaves.ShowDialog()
    End Sub

    Private Sub btn_Cargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cargo.Click
        abm_cargos.ShowDialog()
    End Sub

    Private Sub btn_Empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Empleado.Click
        ABM_Empleados.ShowDialog()
    End Sub

    Private Sub btn_Pasajeros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Pasajeros.Click
        frm_abmPasajeros.ShowDialog()
    End Sub

    Private Sub btn_Localidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Localidad.Click
        frm_ABM_Localidad.ShowDialog()
    End Sub

    Private Sub btn_Provincias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Provincias.Click
        AMB_provincia.ShowDialog()
    End Sub

    Private Sub btn_Aeropuerto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aeropuerto.Click
        frm_ABMAeropuerto.ShowDialog()
    End Sub

    Private Sub btn_Vuelos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Vuelos.Click
        frm_Vuelos.ShowDialog()
    End Sub

    Private Sub btn_tarjetaEmbarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tarjetaEmbarque.Click
        frm_tarjeta.ShowDialog()
    End Sub

    Private Sub btn_Pasaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Pasaje.Click
        frm_pasajes.ShowDialog()
    End Sub

    Private Sub btn_Reportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reportes.Click
        If (btn_aeronavesMasUtilizadas.Visible = True) Then
            btn_Estadistica.PerformClick()
        End If
        If (btn_Aeronaves.Visible = True) Then
            btn_Gestion.PerformClick()
        End If

        If (reportes = False) Then
            btn_aeropuertoPorProvincia.Visible = True
            btn_capacidadAeronaves.Visible = True
            btm_equipajePorPersona.Visible = True
            btn_vuelosPorFecha.Visible = True
            reportes = True
        Else
            btn_aeropuertoPorProvincia.Visible = False
            btn_capacidadAeronaves.Visible = False
            btm_equipajePorPersona.Visible = False
            btn_vuelosPorFecha.Visible = False

            reportes = False
        End If

    End Sub

    Private Sub btn_Estadistica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Estadistica.Click
        If (btn_aeropuertoPorProvincia.Visible = True) Then
            btn_Reportes.PerformClick()
        End If
        If (btn_Aeronaves.Visible = True) Then
            btn_Gestion.PerformClick()
        End If

        If (estadisticas = False) Then
            btn_aeronavesMasUtilizadas.Visible = True
            btn_DestinosMasFrecuentes.Visible = True
            btn_cantidadDeVuelos.Visible = True

            estadisticas = True
        Else
            btn_aeronavesMasUtilizadas.Visible = False
            btn_DestinosMasFrecuentes.Visible = False
            btn_cantidadDeVuelos.Visible = False

            estadisticas = False
        End If
    End Sub

    Private Sub btn_aeronavesMasUtilizadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aeronavesMasUtilizadas.Click
        frm_aeronavesMasUtilizadas.ShowDialog()
    End Sub

    Private Sub btn_DestinosMasFrecuentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DestinosMasFrecuentes.Click
        EstadisticaDestinoMasConcurrido.ShowDialog()
    End Sub

    Private Sub btn_cantidadDeVuelos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cantidadDeVuelos.Click
        frm_CantidadDeVuelos.ShowDialog()
    End Sub

    Private Sub btn_aeropuertoPorProvincia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aeropuertoPorProvincia.Click
        ReporteAeropuertoXProvincia.ShowDialog()
    End Sub

    Private Sub btn_capacidadAeronaves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_capacidadAeronaves.Click
        frm_capacidadAeronaves.ShowDialog()
    End Sub

    Private Sub btm_equipajePorPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btm_equipajePorPersona.Click
        ReporteEquipajeXPersona.ShowDialog()
    End Sub
End Class


