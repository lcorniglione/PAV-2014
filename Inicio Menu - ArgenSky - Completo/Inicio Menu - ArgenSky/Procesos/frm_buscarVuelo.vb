Public Class frm_buscarVuelo

  
    Private Sub frm_buscarVuelo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.llenar_combo(Me.cbo_localidaddestino, "Localidad", "id_Localidad", "descripcion")
        Me.llenar_combo(Me.cbo_localidadOrigen, "Localidad", "id_Localidad", "descripcion")
        Me.txt_idVuelo.Text = ""
        Me.cbo_localidaddestino.SelectedIndex = -1
        Me.cbo_localidadOrigen.SelectedIndex = -1
        Me.llenar_combo(Me.cbo_tipoPasaje, "Tipo_Pasaje", "id_TipoPasaje", "descripcion")
        Me.cbo_tipoPasaje.SelectedIndex = 0
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

    Private Sub validar_carga_numerica(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_idVuelo.KeyPress

        Select Case Asc(e.KeyChar)
            Case 4, 24, 19, 127, 13, 9, 15, 14, 8
                Exit Sub
        End Select
        If (IsNumeric(e.KeyChar) = False Or Asc(e.KeyChar) = 59) Then
            'MsgBox("Este carater no es un numero ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub


    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()

    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        If (Me.txt_idVuelo.Text = "" And Me.cbo_localidaddestino.SelectedIndex = -1 And Me.cbo_localidadOrigen.SelectedIndex = -1) Then
            MessageBox.Show("Por favor ingrese algun criterio de busqueda", "Error en la busqueda", MessageBoxButtons.OK)
            Exit Sub
        End If
        Dim tabla As New Data.DataTable
        Dim consulta As String
        Dim cpu As Integer
        Dim cpp As Integer

        Dim Economy As Boolean

        If (cbo_tipoPasaje.SelectedIndex = 0) Then
            Economy = True
        Else
            Economy = False

        End If


        If (Me.txt_idVuelo.Text <> "") Then
            consulta = "SELECT Vuelos.id_Vuelo AS 'Id Vuelo', Vuelos.id_Aeronave AS 'Id Aeronave', Ao.nombre_Aeropuerto AS 'Origen', Ad.nombre_Aeropuerto AS 'Destino', "
            consulta &= " Estados.descripcion AS 'Estado', Vuelos.fechaHora_Llegada AS 'Fecha/Hora Llegada', Vuelos.fechaHora_Salida AS 'Fecha/Hora Salida' "
            If (Economy) Then
                consulta &= " , Ae.cant_Pasaj_Economy AS 'PasajesDisponibles'"
            Else
                consulta &= " ,Ae.cant_Pasaj_Premium AS 'PasajesDisponibles' "
            End If
            consulta &= " FROM Vuelos JOIN Aeropuertos as Ao ON Vuelos.aeropuerto_Origen = Ao.id_Aeropuerto JOIN Aeropuertos as Ad ON Vuelos.aeropuerto_Destino = Ad.id_Aeropuerto JOIN"
            consulta &= " Estados ON Vuelos.estado = Estados.id_Estado JOIN Aeronaves Ae on ( Vuelos.id_Aeronave = Ae.id_Aeronave)"
            'ESTADO DE VUELO DEBE ESTAR EN 3 se pone 0 para probar

            consulta &= " WHERE (Vuelos.estado = 4)AND (Vuelos.id_Vuelo = " & txt_idVuelo.Text & ") "
            consulta &= " AND Vuelos.deleted = 0 "
            If (Me.cbo_localidaddestino.SelectedIndex <> -1) Then
                consulta &= " AND (Ad.localidad = " & cbo_localidaddestino.SelectedIndex & ")"
            End If
            If (Me.cbo_localidadOrigen.SelectedIndex <> -1) Then
                consulta &= " AND (Ao.localidad = " & cbo_localidadOrigen.SelectedIndex & ") "
            End If
        Else
            If (Me.cbo_localidaddestino.SelectedIndex <> -1) Then
                consulta = "SELECT Vuelos.id_Vuelo AS 'Id Vuelo', Vuelos.id_Aeronave AS 'Id Aeronave', Ao.nombre_Aeropuerto AS 'Origen', Ad.nombre_Aeropuerto AS 'Destino', "
                consulta &= " Estados.descripcion AS 'Estado', Vuelos.fechaHora_Llegada AS 'Fecha/Hora Llegada', Vuelos.fechaHora_Salida AS 'Fecha/Hora Salida'"
                If (Economy) Then
                    consulta &= " , Ae.cant_Pasaj_Economy AS 'PasajesDisponibles'"
                Else
                    consulta &= " ,Ae.cant_Pasaj_Premium AS 'PasajesDisponibles' "
                End If


                consulta &= " FROM Vuelos JOIN Aeropuertos as Ao ON Vuelos.aeropuerto_Origen = Ao.id_Aeropuerto JOIN Aeropuertos as Ad ON Vuelos.aeropuerto_Destino = Ad.id_Aeropuerto JOIN"
                consulta &= " Estados ON Vuelos.estado = Estados.id_Estado JOIN Aeronaves Ae on ( Vuelos.id_Aeronave = Ae.id_Aeronave)"
                '
                consulta &= " WHERE (Vuelos.estado = 4) "
                consulta &= " AND (Ad.localidad = " & cbo_localidaddestino.SelectedIndex & ")"
                consulta &= " AND Vuelos.deleted = 0 "
                If (Me.cbo_localidadOrigen.SelectedIndex <> -1) Then
                    consulta &= " AND (Ao.localidad = " & cbo_localidadOrigen.SelectedIndex & ") "
                End If
            Else
                If (Me.cbo_localidadOrigen.SelectedIndex <> -1) Then
                    consulta = "SELECT Vuelos.id_Vuelo AS 'Id Vuelo', Vuelos.id_Aeronave AS 'Id Aeronave', Ao.nombre_Aeropuerto AS 'Origen', Ad.nombre_Aeropuerto AS 'Destino', "
                    consulta &= " Estados.descripcion AS 'Estado', Vuelos.fechaHora_Llegada AS 'Fecha/Hora Llegada', Vuelos.fechaHora_Salida AS 'Fecha/Hora Salida'"
                    If (Economy) Then
                        consulta &= " , Ae.cant_Pasaj_Economy AS 'PasajesDisponibles'"
                    Else
                        consulta &= " ,Ae.cant_Pasaj_Premium AS 'PasajesDisponibles' "
                    End If
                    consulta &= " FROM Vuelos JOIN Aeropuertos as Ao ON Vuelos.aeropuerto_Origen = Ao.id_Aeropuerto JOIN Aeropuertos as Ad ON Vuelos.aeropuerto_Destino = Ad.id_Aeropuerto JOIN"
                    consulta &= " Estados ON Vuelos.estado = Estados.id_Estado JOIN Aeronaves Ae on ( Vuelos.id_Aeronave = Ae.id_Aeronave)"
                    '
                    consulta &= " WHERE (Vuelos.estado = 4) "
                    consulta &= " AND (Ao.localidad = " & cbo_localidadOrigen.SelectedIndex & ") "
                    consulta &= " AND Vuelos.deleted = 0 "
                End If
            End If
        End If

        If (ckb_fecha.Checked = True And IsDate(txt_horaChekIn.Text) = True) Then
            consulta &= " AND CONVERT(varchar(10), Vuelos.fechaHora_Salida, 103) ='" & txt_horaChekIn.Text & "'"
        End If



        tabla = BDHelper.ConsultaSQL(consulta)

        If (tabla.Rows.Count <> 0) Then

            'Me.grd_pasajeros.DataSource = tabla
            Me.grd_pasajeros.Rows.Clear()
            Dim eco As Integer
            Dim pre As Integer
            Dim pasajesdisponibles As Integer

            For Each row In tabla.Rows
                If (cbo_tipoPasaje.SelectedIndex = 0) Then
                    consulta = "select count(id_Pasajero) from Pasaje where id_TipoPasaje = 0 and id_Vuelo = " & row("Id Vuelo")
                    tabla = BDHelper.ConsultaSQL(consulta)
                    cpu = tabla.Rows(0)(0)
                Else
                    consulta = "select count(id_Pasajero) from Pasaje where id_TipoPasaje = 1 and id_Vuelo = " & row("Id Vuelo")
                    tabla = BDHelper.ConsultaSQL(consulta)
                    cpu = tabla.Rows(0)(0)
                End If

                pasajesdisponibles = row("PasajesDisponibles")
                Dim dif As Integer = pasajesdisponibles - cpu


                If (dif > 0) Then
                    Me.grd_Pasajeros.Rows.Add((New Object() {row("Id Vuelo"), row("Id Aeronave"), row("Origen"), row("Destino"), row("Estado"), row("Fecha/Hora Llegada"), row("Fecha/Hora Salida"), dif}))
                Else
                    MessageBox.Show("La busqueda no tuvo exito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


            Next row


        Else
            MessageBox.Show("La busqueda no tuvo exito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

   


    

 
   
    Private Sub grd_Pasajeros_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_Pasajeros.CellContentClick
        If (e.RowIndex = -1) Then
            Exit Sub
        End If
        Dim row As DataGridViewRow = grd_Pasajeros.Rows(e.RowIndex)
        Dim tipo As String
        If (cbo_tipoPasaje.SelectedIndex = 0) Then
            tipo = "Economy"

        Else
            tipo = "Premium"

        End If
        If (MessageBox.Show("¿Está seguro que desea seleccionar el vuelo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            row.Cells(7).Value = tipo
            frm_pasajes.cargarVueloSeleccionado(row)
            Me.Close()
        End If
    End Sub
    
    Private Sub ckb_fecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckb_fecha.CheckedChanged
        If (ckb_fecha.Checked = True) Then
            txt_horaChekIn.Enabled = True
        Else
            txt_horaChekIn.Enabled = False

        End If
    End Sub
End Class