Public Class frm_Vuelos

    Public string_conexion As String = "workstation id=ArgenSky.mssql.somee.com;packet size=4096;user id=adminargensky;pwd=pav.2014;data source=ArgenSky.mssql.somee.com;persist security info=False;initial catalog=ArgenSky"
    Public modificacion As Boolean = False

    Private Sub frm_Vuelos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    
    Private Sub frm_Vuelos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        
        llenar_combo(cbo_aeronaves, "Aeronaves", "id_Aeronave", "id_Aeronave")
        cbo_aeronaves.SelectedIndex = 0
        llenar_combo(cbo_Estados, "Estados", "id_Estado", "descripcion")
        cbo_Estados.SelectedIndex = 0
        llenar_combo(cbo_LocalidadOrigen, "Localidad", "id_Localidad", "descripcion")
        cbo_LocalidadOrigen.SelectedIndex = 0
        llenar_combo(cbo_localidadDestino, "Localidad", "id_Localidad", "descripcion")
        cbo_localidadDestino.SelectedIndex = 0
        llenar_comboAeropuerto(cbo_AeropuertoOrigen, "Aeropuertos", "id_Aeropuerto", "nombre_aeropuerto", cbo_LocalidadOrigen.Text)
        cbo_AeropuertoOrigen.SelectedIndex = 0
        llenar_comboAeropuerto(cbo_aeropuertoDestino, "Aeropuertos", "id_Aeropuerto", "nombre_aeropuerto", cbo_localidadDestino.Text)
        cbo_aeropuertoDestino.SelectedIndex = 0

        
        llenar_comboTripulacion(cbo_piloto, "Empleados", "legajo_Empleado", "NombreApellido", 1, -1)
        cbo_piloto.SelectedIndex = 0
        llenar_comboTripulacion(cbo_copiloto, "Empleados", "legajo_Empleado", "NombreApellido", 1, cbo_piloto.SelectedValue)
        cbo_copiloto.SelectedIndex = 1
        llenar_comboTripulacion(cbo_comisarioDeAbordo, "Empleados", "legajo_Empleado", "NombreApellido", 3, -1)
        cbo_comisarioDeAbordo.SelectedIndex = 0
        llenar_comboTripulacion(cbo_azafata1, "Empleados", "legajo_Empleado", "NombreApellido", 2, -1)
        cbo_azafata1.SelectedIndex = 0
        llenar_comboTripulacion(cbo_azafata2, "Empleados", "legajo_Empleado", "NombreApellido", 2, cbo_azafata1.SelectedValue)
        cbo_azafata2.SelectedIndex = 1

        'tooltip_fechaHora.ShowAlways = True
        tooltip_fechaHora.SetToolTip(txt_fechaHoraOrigen, "Ejemplo: 10/10/2014 04:30")
        tooltip_fechaHora.SetToolTip(txt_fechaHoraDestino, "Ejemplo: 10/10/2014 04:30")
        estadoInicial()
        llenarGrid()

    End Sub

    Public Sub estadoInicial()
        limpiarTodo()
        grpBox_Origen.Enabled = False
        grpBox_Destino.Enabled = False
        grpBox_tripulacion.Enabled = False
        cbo_aeronaves.Enabled = False
        llenarGrid()
        btn_Buscar.Enabled = True
        btn_nuevoVuelo.Enabled = True
        txt_idVuelo.Enabled = True

    End Sub

    Private Sub llenarGrid()
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim consulta As String

        con.ConnectionString = string_conexion
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

        consulta = "SELECT v.id_Vuelo AS 'N° Vuelo', v.id_Aeronave AS 'Aeronave', ao.nombre_aeropuerto AS 'Origen', ad.nombre_aeropuerto AS 'Destino', v.fechaHora_Salida AS 'Fecha/Hora Salida', v.fechaHora_Llegada AS 'Fecha/Hora Llegada', e.descripcion AS 'Estado' FROM Vuelos v JOIN Aeropuertos ao ON (v.aeropuerto_Origen=ao.id_Aeropuerto) JOIN Aeropuertos ad ON (v.aeropuerto_Destino=ad.id_Aeropuerto) JOIN Estados e ON (v.estado=e.id_Estado) WHERE v.deleted = 0"

        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())

        Me.grd_Vuelos.DataSource = tabla
        con.Close()

    End Sub

    Private Sub limpiarTodo()
        txt_idVuelo.Clear()
        txt_fechaHoraDestino.Clear()
        txt_fechaHoraOrigen.Clear()
        cbo_Estados.SelectedIndex = 0
        lbl_marcaAvion.Visible = False
        'cbo_LocalidadOrigen.SelectedIndex = 0
        'cbo_localidadDestino.SelectedIndex = 0
        'cbo_AeropuertoOrigen.SelectedIndex = 0
        'cbo_aeropuertoDestino.SelectedIndex = 0
        cbo_piloto.SelectedIndex = 0
        cbo_copiloto.SelectedIndex = 0
        cbo_comisarioDeAbordo.SelectedIndex = 0
        cbo_azafata1.SelectedIndex = 0
        cbo_azafata2.SelectedIndex = 0
        btn_guardarTripulacion.Enabled = False

    End Sub

    Private Sub llenar_combo(ByVal cbo As ComboBox, ByVal n_tabla As String, ByVal id_tabla As String, ByVal display_tabla As String)

        Dim table As New Data.DataTable
        Dim consulta As String

        consulta = "SELECT " & id_tabla & "," & display_tabla & " FROM " & n_tabla & " where deleted = 0"
        table = BDHelper.ConsultaSQL(Consulta)

        cbo.DataSource = table
        cbo.DisplayMember = display_tabla
        cbo.ValueMember = id_tabla
        cbo.SelectedIndex = -1

    End Sub

    Private Sub llenar_comboAeropuerto(ByVal cbo As ComboBox, ByVal n_tabla As String, ByVal id_tabla As String, ByVal display_tabla As String, ByRef origen As String)

        Dim table As New Data.DataTable
        Dim consulta As String

        consulta = "SELECT " & id_tabla & "," & display_tabla & " FROM Aeropuertos a JOIN Localidad l ON (a.localidad = l.id_Localidad) WHERE l.descripcion = '" & origen & "'"
        table = BDHelper.ConsultaSQL(consulta)

        cbo.DataSource = table
        cbo.DisplayMember = display_tabla
        cbo.ValueMember = id_tabla
        cbo.SelectedIndex = -1

    End Sub

    Private Sub llenar_comboTripulacion(ByVal cbo As ComboBox, ByVal n_tabla As String, ByVal id_tabla As String, ByVal display_tabla As String, ByVal rol As Integer, ByVal excluir As Integer)

        Dim table As New Data.DataTable
        Dim consulta As String

        If (excluir <> -1) Then
            consulta = "SELECT " & id_tabla & ", apellido+', ' +nombre as NombreApellido FROM Empleados WHERE cargo = " & rol & " AND legajo_Empleado <> " & excluir
        Else
            consulta = "SELECT " & id_tabla & ", apellido+', ' +nombre as NombreApellido FROM Empleados WHERE cargo = " & rol
        End If

        table = BDHelper.ConsultaSQL(consulta)

        cbo.DataSource = table
        cbo.DisplayMember = display_tabla
        cbo.ValueMember = id_tabla
        cbo.SelectedIndex = -1

    End Sub

    Private Sub cbo_LocalidadOrigen_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_LocalidadOrigen.SelectionChangeCommitted
        llenar_comboAeropuerto(cbo_AeropuertoOrigen, "Aeropuertos", "id_Aeropuerto", "nombre_aeropuerto", cbo_LocalidadOrigen.Text)
        Try
            cbo_AeropuertoOrigen.SelectedIndex = 0
        Catch
            MessageBox.Show("No hay Aeropuertos en esta Localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cbo_LocalidadDestino_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_localidadDestino.SelectionChangeCommitted
        llenar_comboAeropuerto(cbo_aeropuertoDestino, "Aeropuertos", "id_Aeropuerto", "nombre_aeropuerto", cbo_localidadDestino.Text)
        Try
            cbo_aeropuertoDestino.SelectedIndex = 0

        Catch
            MessageBox.Show("No hay Aeropuertos en esta Localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cbo_aeronaves_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_aeronaves.SelectionChangeCommitted
        Dim table As New Data.DataTable
        Dim consulta As String

        consulta = "SELECT nombre_Marca FROM Marca m JOIN Aeronaves a ON (m.id_Marca = a.marca) WHERE a.id_Aeronave = " & cbo_aeronaves.Text
        table = BDHelper.ConsultaSQL(consulta)
        lbl_marcaAvion.Visible = True
        lbl_marcaAvion.Text = table.Rows(0)(0)
    End Sub

    Private Function validarFechas(ByVal fecha As String)
        Dim d As DateTime
        Try
            d = fecha.ToString
        Catch ex As Exception
            MessageBox.Show("Formato de fechas incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return -1
        End Try

        'Dim año As Integer = d.Year
        'Dim mes As Integer = d.Month
        'Dim dia As Integer = d.Day
        'Dim hora As Integer = d.Hour
        'Dim minutos As Integer = d.Minute
        'Dim fechaFin As String = año & "-" & mes & "-" & dia & " " & hora & ":" & minutos
        Return 1

    End Function

    Private Sub btn_guardarTripulacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardarTripulacion.Click

        If (txt_fechaHoraOrigen.MaskFull = False) Then
            MessageBox.Show("Ingrese fecha y hora de salida válida", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If (txt_fechaHoraDestino.MaskFull = False) Then
            MessageBox.Show("Ingrese fecha y hora de Llegada", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If (cbo_aeropuertoDestino.Text = cbo_AeropuertoOrigen.Text) Then
            MessageBox.Show("Origen y destino no pueden ser iguales válida", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If (validarFechas(txt_fechaHoraOrigen.Text) < 0) Then
            Return
        End If
        If (validarFechas(txt_fechaHoraDestino.Text) < 0) Then
            Return
        End If
        If (txt_fechaHoraOrigen.Text > txt_fechaHoraDestino.Text) Then
            MessageBox.Show("Fecha y hora de salida no puede ser mayor a la fecha y hora de llegada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If


        If (modificacion = True) Then
            modificar()
            modificacion = False
            habilitarAtras()
            estadoInicial()
            Return
        End If

        habilitarAtras()
        Dim res As Boolean = validar(Me.txt_idVuelo.Text)
        If (res = True) Then
            MessageBox.Show("El Vuelo que intenta crear ya existe", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        crearVuelo()


        Dim rest As Boolean = buscarFila(txt_idVuelo.Text)
        If (rest = True) Then
            MessageBox.Show("Nuevo Vuelo registrado correctamente", "Mensaje de inserción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'MessageBox.Show("El Vuelo no puedo registrarse", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        estadoInicial()

    End Sub

    Private Function modificar()

        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim MyTran As Data.SqlClient.SqlTransaction

        con.ConnectionString = string_conexion
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        MyTran = con.BeginTransaction()
        cmd.Transaction = MyTran
        Try
            cmd.CommandText = "UPDATE Vuelos SET  id_Aeronave = '" & Me.cbo_aeronaves.SelectedValue & "',aeropuerto_Origen = '" & Me.cbo_AeropuertoOrigen.SelectedValue & "',aeropuerto_Destino = '" & Me.cbo_aeropuertoDestino.SelectedValue & "',estado = '" & Me.cbo_Estados.SelectedValue & "',fechaHora_Llegada = '" & Me.txt_fechaHoraDestino.Text & "',fechaHora_Salida = '" & Me.txt_fechaHoraOrigen.Text & "' WHERE id_Vuelo = " & txt_idVuelo.Text
            cmd.ExecuteNonQuery()
            cmd.CommandText = "UPDATE Tripulacion SET  id_Piloto = '" & Me.cbo_piloto.SelectedValue & "',id_Copiloto= '" & Me.cbo_copiloto.SelectedValue & "',id_ComisarioBordo = '" & Me.cbo_comisarioDeAbordo.SelectedValue & "',id_Azafata1 = '" & Me.cbo_azafata1.SelectedValue & "',id_Azafata2 = '" & Me.cbo_azafata2.SelectedValue & "' WHERE id_Vuelo = " & txt_idVuelo.Text
            cmd.ExecuteNonQuery()
            MyTran.Commit()
            MessageBox.Show("El Vuelo se modificó correctamente", "Mensaje de modificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MyTran.Rollback()
            MessageBox.Show("La modificación no pudo realizarse", "Error de modifiación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Finally
            con.Close()
            con.Dispose()
        End Try

        Return True

    End Function

    Private Sub crearVuelo()
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim MyTran As Data.SqlClient.SqlTransaction


        con = New Data.SqlClient.SqlConnection(string_conexion)
        con.Open()
        

        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        MyTran = con.BeginTransaction()
        cmd.Transaction = MyTran
        Try
            Dim consulta1 As String = "INSERT INTO Vuelos (id_Vuelo, id_Aeronave, aeropuerto_Origen, aeropuerto_Destino, estado, fechaHora_Llegada, fechaHora_Salida)"
            'consulta1 = consulta1 + " VALUES (" & Me.txt_idVuelo.Text & ", " & cbo_aeronaves.SelectedValue & ", " & cbo_AeropuertoOrigen.SelectedValue & ", " & cbo_aeropuertoDestino.SelectedValue & ", " & cbo_Estados.SelectedValue & ", '" & txt_fechaHoraDestino.Text & "', '" & txt_fechaHoraOrigen.Text & "')"
            consulta1 = consulta1 + " VALUES (" & Me.txt_idVuelo.Text & ", " & cbo_aeronaves.SelectedValue & ", " & cbo_AeropuertoOrigen.SelectedValue & ", " & cbo_aeropuertoDestino.SelectedValue & ", " & cbo_Estados.SelectedValue & ", CONVERT(VARCHAR()," & txt_fechaHoraDestino.Text & ", 103), CONVERT(VARCHAR()," & txt_fechaHoraDestino.Text & ", 103)"
            cmd.CommandText = consulta1
            cmd.ExecuteNonQuery()

            Dim consulta2 As String = "INSERT INTO Tripulacion (id_Vuelo, id_Piloto, id_Copiloto, id_ComisarioBordo, id_Azafata1, id_Azafata2)"
            consulta2 = consulta2 + " VALUES (" & Me.txt_idVuelo.Text & ", " & cbo_piloto.SelectedValue & ", " & cbo_copiloto.SelectedValue & ", " & cbo_comisarioDeAbordo.SelectedValue & ", " & cbo_azafata1.SelectedValue & ", " & cbo_azafata2.SelectedValue & ")"
            cmd.CommandText = consulta2
            cmd.ExecuteNonQuery()

            MyTran.Commit()
        Catch ex As Exception
            MyTran.Rollback()
            MessageBox.Show("No se puedo agregar el vuelo", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_fechaHoraOrigen.Focus()
        Finally
            con.Close()
            con.Dispose()
        End Try
    End Sub

    Private Function validar(ByVal idVuelo As String)
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        con.ConnectionString = string_conexion
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT id_Vuelo FROM Vuelos WHERE deleted = 0 AND id_Vuelo=" & txt_idVuelo.Text
        cmd.ExecuteNonQuery()

        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        Dim resultado As String
        Try
            resultado = dt.Rows(0)(0)
        Catch ex As Exception
            Return False
        End Try


        If (resultado = idVuelo) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function buscarFila(ByVal idVuelo As String)

        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand

        con.ConnectionString = string_conexion
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT v.id_Vuelo AS 'N° Vuelo', v.id_Aeronave AS 'Aeronave', ao.nombre_aeropuerto AS 'Origen', ad.nombre_aeropuerto AS 'Destino', v.fechaHora_Salida AS 'Fecha/Hora Salida', v.fechaHora_Llegada AS 'Fecha/Hora Llegada', e.descripcion AS 'Estado' FROM Vuelos v JOIN Aeropuertos ao ON (v.aeropuerto_Origen=ao.id_Aeropuerto) JOIN Aeropuertos ad ON (v.aeropuerto_Destino=ad.id_Aeropuerto) JOIN Estados e ON (v.estado=e.id_Estado) WHERE v.deleted = 0 AND v.id_Vuelo=" & txt_idVuelo.Text


        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            grd_Vuelos.DataSource = dt
            Return True
        Else
            'MessageBox.Show("El vuelo no existe", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

            Return False
        End If

        con.Close()
    End Function

    
    Private Sub numeroVueloAuto()
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable

        con = New Data.SqlClient.SqlConnection(string_conexion)
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT MAX(id_Vuelo) FROM Vuelos"
        Dim valorMax As Integer = cmd.ExecuteScalar()

        txt_idVuelo.Text = valorMax + 1

        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevoVuelo.Click
        cbo_aeronaves.Enabled = True
        grpBox_Destino.Enabled = True
        grpBox_Origen.Enabled = True
        grpBox_tripulacion.Enabled = True
        btn_Buscar.Enabled = False
        btn_guardarTripulacion.Enabled = True
        txt_idVuelo.Enabled = False
        numeroVueloAuto()
        habilitarAtras()
    End Sub
    
    Private Sub txt_fechaHoraOrigen_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txt_fechaHoraOrigen.MaskInputRejected

    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        If (txt_idVuelo.Text <> "") Then
            Dim res As Boolean = buscarFila(txt_idVuelo.Text)
            If (res = True) Then
                txt_idVuelo.Clear()
                txt_idVuelo.Focus()
                habilitarAtras()
                Return

            End If
        Else

            If (cbo_Estados.Text = "") Then
                MessageBox.Show("Ingrese N° Vuelo o Estado para buscar un Vuelo", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Else
                habilitarAtras()
                Dim con As New Data.SqlClient.SqlConnection
                Dim cmd As New Data.SqlClient.SqlCommand

                con.ConnectionString = string_conexion
                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT v.id_Vuelo AS 'N° Vuelo', v.id_Aeronave AS 'Aeronave', ao.nombre_aeropuerto AS 'Origen', ad.nombre_aeropuerto AS 'Destino', v.fechaHora_Salida AS 'Fecha/Hora Salida', v.fechaHora_Llegada AS 'Fecha/Hora Llegada', e.descripcion AS 'Estado' FROM Vuelos v JOIN Aeropuertos ao ON (v.aeropuerto_Origen=ao.id_Aeropuerto) JOIN Aeropuertos ad ON (v.aeropuerto_Destino=ad.id_Aeropuerto) JOIN Estados e ON (v.estado=e.id_Estado) WHERE v.deleted = 0 AND e.id_Estado=" & cbo_Estados.SelectedValue


                Dim da As New SqlClient.SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                If dt.Rows.Count > 0 Then

                    grd_Vuelos.DataSource = dt

                Else
                    MessageBox.Show("No hay Vuuelos en este estado", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    estadoInicial()
                End If

                con.Close()
            End If
        End If
    End Sub

    Private Sub cargarTripulacion(ByRef idVuelo As Integer)

        Dim table As New Data.DataTable
        Dim consulta As String

        consulta = "SELECT e.apellido+', ' +e.nombre AS Piloto, ep.apellido+', ' +ep.nombre AS Copiloto, ec.apellido+', ' +ec.nombre AS Comisario, a1.apellido+', ' +a1.nombre AS Azafata1,a2.apellido+', ' +a2.nombre AS Azafata2 FROM Tripulacion t JOIN Empleados e ON (t.id_Piloto=e.legajo_Empleado) JOIN Empleados ep ON (t.id_Copiloto=ep.legajo_Empleado) JOIN Empleados ec ON (t.id_comisarioBordo=ec.legajo_Empleado) JOIN Empleados a1 ON (t.id_azafata1 = a1.legajo_Empleado) JOIN Empleados a2 ON (t.id_Azafata2=a2.legajo_Empleado) WHERE t.id_Vuelo = " & txt_idVuelo.Text
        table = BDHelper.ConsultaSQL(consulta)

        cbo_piloto.Text = table.Rows(0)(0)
        cbo_copiloto.Text = table.Rows(0)(1)
        cbo_comisarioDeAbordo.Text = table.Rows(0)(2)
        cbo_azafata1.Text = table.Rows(0)(3)
        cbo_azafata2.Text = table.Rows(0)(4)

    End Sub

    Private Sub grd_Vuelos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_Vuelos.CellDoubleClick
        cbo_aeronaves.Enabled = True
        grpBox_Destino.Enabled = True
        grpBox_Origen.Enabled = True
        grpBox_tripulacion.Enabled = True
        habilitarAtras()

        If (e.RowIndex = -1) Then
            Exit Sub
        End If

        Dim row As DataGridViewRow = grd_Vuelos.Rows(e.RowIndex)

        Me.txt_idVuelo.Text = row.Cells(0).Value
        Me.cbo_aeronaves.Text = row.Cells(1).Value
        Me.cbo_AeropuertoOrigen.Text = row.Cells(2).Value
        Me.cbo_aeropuertoDestino.Text = row.Cells(3).Value
        Me.txt_fechaHoraOrigen.Text = row.Cells(4).Value
        Me.txt_fechaHoraDestino.Text = row.Cells(5).Value
        Me.cbo_Estados.Text = row.Cells(6).Value

        cargarTripulacion(Me.txt_idVuelo.Text)
        btn_guardarTripulacion.Enabled = True
        btn_nuevoVuelo.Enabled = True
        btn_Buscar.Enabled = False
        modificacion = True
        
    End Sub

    Private Sub habilitarAtras()
        If (btn_salirVuelo.Text = "Salir") Then
            btn_salirVuelo.Text = "Atrás"

        Else
            btn_salirVuelo.Text = "Salir"
        End If


    End Sub

    Private Sub btn_salirVuelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salirVuelo.Click
        If (btn_salirVuelo.Text = "Salir") Then
            Close()
        Else
            estadoInicial()
            habilitarAtras()
        End If
    End Sub

    Private Sub cbo_piloto_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_piloto.SelectionChangeCommitted
        llenar_comboTripulacion(cbo_copiloto, "Empleados", "legajo_Empleado", "NombreApellido", 1, cbo_piloto.SelectedValue)
        cbo_copiloto.SelectedIndex = 0
        'Dim diferencia As TimeSpan = DateTime.Parse(txt_fechaHoraDestino.Text).Subtract(DateTime.Parse(txt_fechaHoraOrigen.Text))
        'Dim dif As DateTime = Convert.ToDateTime(diferencia.ToString())
        'Dim dif As DateTime = Convert.ToString(diferencia.ToString())
        'Dim res As String = Format(dif, "hh:mm")
        'MsgBox(dif)
    End Sub

    Private Sub cbo_azafata1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_azafata1.SelectionChangeCommitted
        llenar_comboTripulacion(cbo_azafata2, "Empleados", "legajo_Empleado", "NombreApellido", 2, cbo_azafata1.SelectedValue)
        cbo_azafata2.SelectedIndex = 0
    End Sub
End Class