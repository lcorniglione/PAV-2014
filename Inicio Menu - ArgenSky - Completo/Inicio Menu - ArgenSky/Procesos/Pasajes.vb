Public Class frm_pasajes

    Public string_conexion As String = "workstation id=ArgenSky.mssql.somee.com;packet size=4096;user id=adminargensky;pwd=pav.2014;data source=ArgenSky.mssql.somee.com;persist security info=False;initial catalog=ArgenSky"


    Enum pasajero
        encontrado
        noencontrado
    End Enum

    Enum vuelo
        encontrado
        noencontrado
    End Enum

    Private estadopasajero As pasajero = pasajero.noencontrado
    Private estadovuelo As vuelo = vuelo.noencontrado

    Private Sub frm_pasajes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    'Public Function getIdVuelo() As Integer
    '    Return Integer.Parse(txt_idVuelo.Text)
    'End Function

    

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()

    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        limpiarcasilleros()

    End Sub

    Private Sub limpiarCasilleros()
        txt_idPasajero.Clear()
        txt_tipoDocumento.Clear()
        txt_nombrePasajero.Clear()
        txt_numeroDocumento.Clear()
        txt_sexoPasajero.Clear()
        txt_apellidoPasajero.Clear()
        txt_nacionalidad.Clear()
        txt_idVuelo.Clear()
        txt_Aeronave.Clear()
        txt_Estado.Clear()
        txt_Origen.Clear()
        txt_Destino.Clear()
        txt_Salida.Clear()
        txt_Llegada.Clear()
        txt_horaChekIn.Clear()
        txt_motivoViaje.Clear()
        txt_tipoPasaje.Clear()


        txt_horaChekIn.Clear()
        txt_motivoViaje.Clear()
        txt_tipoPasaje.Clear()

    End Sub

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If (estadopasajero = pasajero.encontrado) And (estadovuelo = vuelo.encontrado) And (validarDatosPasaje() = True) Then
           
            Dim MyTran As Data.SqlClient.SqlTransaction
            Dim cnn As New Data.SqlClient.SqlConnection
            Dim cmd As New Data.SqlClient.SqlCommand
            Dim tabla As New Data.DataTable
            Dim consulta As String
            Dim consultab As String
            'Cantidad Pasajes vendidos Actuales
            Dim pasajesactuales As Integer
            'Cantidad Asientos en avion
            Dim cantidada As Integer
            Dim CnString As String = "workstation id=ArgenSky.mssql.somee.com;packet size=4096;user id=adminargensky;pwd=pav.2014;data source=ArgenSky.mssql.somee.com;persist security info=False;initial catalog=ArgenSky"
            cnn.ConnectionString = CnString
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            MyTran = cnn.BeginTransaction
            cmd.Transaction = MyTran
            Dim tipoPasaje As Integer
            Try

                If (txt_tipoPasaje.Text = "Economy") Then
                    consulta = "select cant_Pasaj_Economy from Aeronaves where id_Aeronave = " & txt_Aeronave.Text
                    consultab = "select count(id_Pasajero) from Pasaje where id_TipoPasaje = 0 and id_Vuelo = " & txt_idVuelo.Text
                    tipoPasaje = 0
                Else
                    consulta = "select cant_Pasaj_Premium from Aeronaves where id_Aeronave = " & txt_Aeronave.Text
                    consultab = "select count(id_Pasajero) from Pasaje where id_TipoPasaje = 1 and id_Vuelo = " & txt_idVuelo.Text
                    tipoPasaje = 1
                End If

                tabla = BDHelper.ConsultaSQL(consulta)

                If (tabla.Rows.Count <> 0) Then
                    cantidada = tabla.Rows(0)(0)
                Else
                    MessageBox.Show("La busqueda no tuvo exito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If


                tabla = BDHelper.ConsultaSQL(consultab)

                If (tabla.Rows.Count <> 0) Then
                    pasajesactuales = tabla.Rows(0)(0)
                Else
                    MessageBox.Show("La busqueda no tuvo exito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If (cantidada - pasajesactuales <= 0) Then
                    MessageBox.Show("El vuelo ya esta completo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Dim d As Date = txt_horaChekIn.Text
                Dim año As Integer = d.Year
                Dim mes As Integer = d.Month
                Dim dia As Integer = d.Day
                Dim hora As Integer = d.Hour
                Dim minutos As Integer = d.Minute
                Dim segundos As Integer = d.Second
                Dim fecha As String = año & "-" & mes & "-" & dia & " " & hora & ":" & minutos & ":" & segundos & ".000"

                consulta = "INSERT INTO Pasaje"
                consulta &= "(id_Pasajero, id_Vuelo, fechahora_Chekin, motivoviaje, id_TipoPasaje, deleted)"
                consulta &= "VALUES (" & txt_idPasajero.Text & ", " & txt_idVuelo.Text & ",'" & fecha & "','" & Me.txt_motivoViaje.Text & "','" & tipoPasaje & "', 0)"
                BDHelper.EjecutarSQL(consulta)



                MyTran.Commit()
                MessageBox.Show("Pasaje registrado correctamente", "Mensaje de inserción", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.limpiarCasilleros()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

                MyTran.Rollback()
                MessageBox.Show("Los datos no fueron registrados exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
                cnn.Close()

            End Try
        End If
    End Sub

    Private Function validarDatosPasaje() As Boolean
        If (estadopasajero = pasajero.noencontrado) Then
            MessageBox.Show("Asigne un pasajero válido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmd_buscarPasajero.Focus()
            Return False
        End If
        If (estadovuelo = vuelo.noencontrado) Then
            MessageBox.Show("Asigne un vuelo válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmd_buscarVuelo.Focus()
            Return False
        End If

        If (IsDate(txt_horaChekIn.Text) = False) Then
            MessageBox.Show("Asigne una Fecha/hora válida ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_horaChekIn.Focus()
            Return False
        End If

        If (txt_motivoViaje.Text = "" Or IsNumeric(txt_motivoViaje.Text)) Then
            MessageBox.Show("Asigne un motivo válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_motivoViaje.Focus()
            Return False
        End If

        If (txt_tipoPasaje.Text = "") Then
            MessageBox.Show("Asigne horas de vuelo válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_tipoPasaje.Focus()
            Return False
        End If

        Return True


    End Function

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscarPasajero.Click
        frm_buscarPasajero.Show()
    End Sub

    Public Sub cargarPasajeroSeleccionado(ByRef row As DataGridViewRow)
        Me.txt_idPasajero.Text = row.Cells(0).Value
        Me.txt_nombrePasajero.Text = row.Cells(1).Value
        Me.txt_apellidoPasajero.Text = row.Cells(2).Value
        Me.txt_tipoDocumento.Text = row.Cells(3).Value
        Me.txt_numeroDocumento.Text = row.Cells(4).Value
        Me.txt_nacionalidad.Text = row.Cells(5).Value
        Me.txt_sexoPasajero.Text = row.Cells(6).Value
        Me.txt_idPasajero.Enabled = False
        estadopasajero = pasajero.encontrado
       



    End Sub

    Private Sub cmd_buscarVuelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscarVuelo.Click
        frm_buscarVuelo.Show()

    End Sub


    Public Sub cargarVueloSeleccionado(ByRef row As DataGridViewRow)
        Me.txt_idVuelo.Text = row.Cells(0).Value
        Me.txt_Aeronave.Text = row.Cells(1).Value
        Me.txt_Origen.Text = row.Cells(2).Value
        Me.txt_Destino.Text = row.Cells(3).Value
        Me.txt_Estado.Text = row.Cells(4).Value
        Me.txt_Llegada.Text = row.Cells(5).Value
        Me.txt_Salida.Text = row.Cells(6).Value
        Me.txt_idVuelo.Enabled = False
        Me.txt_tipoPasaje.Text = row.Cells(7).Value
        Dim fecha As DateTime = Date.Parse(txt_Salida.Text)
        fecha = fecha.AddHours(-2)
        txt_horaChekIn.Text = fecha.ToString
        estadovuelo = vuelo.encontrado

    End Sub

    Private Sub frm_pasajes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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

 
End Class