Public Class frm_ABMAeronaves

    Public string_conexion As String = "workstation id=ArgenSky.mssql.somee.com;packet size=4096;user id=adminargensky;pwd=pav.2014;data source=ArgenSky.mssql.somee.com;persist security info=False;initial catalog=ArgenSky"
    Public modificacion As Boolean = False

    Private Sub frm_ABMAeronaves_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

         If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub frm_ABMAeronaves_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarGrid()
        llenar_combo(cbo_marcaAeronave, "Marca", "id_Marca", "nombre_Marca")
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

    Private Function llenarGrid() As Data.DataTable

        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim consulta As String

        con.ConnectionString = string_conexion
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

        consulta = "SELECT id_Aeronave AS 'ID Aeronave', Marca.nombre_Marca AS 'Marca', año AS 'Año', cant_Pasaj_Economy AS 'Cant. Economy', cant_Pasaj_Premium AS 'Cant. Premium', equipaje_PesoMax AS 'Peso equipaje', autonomia_Vuelo AS 'Autonomia', cant_SalidasEmerg AS 'Salidas emergencia', horas_Vuelo AS 'Horas de vuelo' FROM Aeronaves JOIN Marca ON (marca=id_Marca) WHERE Aeronaves.deleted = 0"

        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())

        Me.grd_Aeronaves.DataSource = tabla
        Return tabla

    End Function

    Private Sub habilitarAtras()
        If (btn_salirAeronave.Text = "Salir") Then
            btn_salirAeronave.Text = "Atrás"
        Else
            btn_salirAeronave.Text = "Salir"
        End If


    End Sub

    Private Sub limpiarTodo()
        txt_idAeronave.Clear()
        cbo_añoAeronave.Text = ""
        cbo_marcaAeronave.Text = ""
        txt_pesoMaxEquipaje.Clear()
        txt_cantMaxPasEconomic.Clear()
        txt_cantMaxPasPremium.Clear()
        txt_cantSalidasEmergencia.Clear()
        txt_autonomiaVuelo.Clear()
        txt_horasVueloRealizadas.Clear()
    End Sub

    Private Sub estadoInicial()

        llenarGrid()
        limpiarTodo()
        btn_buscarAeronave.Enabled = True
        cbo_añoAeronave.Enabled = False
        txt_idAeronave.Enabled = True
        box_caraceristicasAeronave.Enabled = False
        btn_NuevoAeronave.Enabled = True
        btn_borrarAeronave.Enabled = False
        btn_guardarAeronave.Enabled = False
        modificacion = False
        btn_salirAeronave.Text = "Salir"

    End Sub

    Private Function validarCampos()

        If Me.txt_idAeronave.Text = "" Then
            MessageBox.Show("Error al generar un ID de Aeronave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn_salirAeronave.Focus()
            Return False
        End If

        If Me.cbo_marcaAeronave.Text = "" Then
            MessageBox.Show("Asigne una marca válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbo_marcaAeronave.Focus()
            Return False
        End If

        If Me.cbo_añoAeronave.Text = "" Then
            MessageBox.Show("Asigne un año válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbo_añoAeronave.Focus()
            Return False
        End If

        If Me.txt_cantMaxPasEconomic.Text = "" Or txt_cantMaxPasPremium.Text = "" Then
            MessageBox.Show("Asigne una cantidad de pasajeros válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_cantMaxPasEconomic.Focus()
            Return False
        End If

        If Me.txt_pesoMaxEquipaje.Text = "" Then
            MessageBox.Show("Asigne un peso de equipaje válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_pesoMaxEquipaje.Focus()
            Return False
        End If

        If Me.txt_autonomiaVuelo.Text = "" Then
            MessageBox.Show("Asigne una autonomía de vuelo válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_autonomiaVuelo.Focus()
            Return False
        End If

        If Me.txt_cantSalidasEmergencia.Text = "" Then
            MessageBox.Show("Asigne una cantidad de salidas de emergencia válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_cantSalidasEmergencia.Focus()
            Return False
        End If

        If Me.txt_horasVueloRealizadas.Text = "" Then
            MessageBox.Show("Asigne horas de vuelo válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_horasVueloRealizadas.Focus()
            Return False
        End If
        Return True

    End Function

    Private Sub btn_guardarAeronave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardarAeronave.Click

        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable

        con = New Data.SqlClient.SqlConnection(string_conexion)
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT MAX(id_Aeronave) FROM Aeronaves"
        Dim valorMax As Integer = cmd.ExecuteScalar()

        txt_idAeronave.Text = valorMax + 1

        If (validarCampos() = False) Then
            Return
        End If

        If (modificacion = True) Then
            modificar()
            modificacion = False

            estadoInicial()
            Return
        End If

        Dim res As Boolean = validar(Me.txt_idAeronave.Text)
        If (res = True) Then
            MessageBox.Show("La Aeronave que intenta crear ya existe", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim consulta As String = "INSERT INTO Aeronaves (id_Aeronave, marca, año, cant_Pasaj_Economy, cant_Pasaj_Premium, equipaje_PesoMax, autonomia_Vuelo, cant_SalidasEmerg, horas_Vuelo)"
        consulta = consulta + " VALUES ('" & Me.txt_idAeronave.Text & "','" & Me.cbo_marcaAeronave.SelectedValue & "','" & Me.cbo_añoAeronave.Text & "','" & Me.txt_cantMaxPasEconomic.Text & "','" & Me.txt_cantMaxPasPremium.Text & "','" & Me.txt_pesoMaxEquipaje.Text & "','" & Me.txt_autonomiaVuelo.Text & "','" & Me.txt_cantSalidasEmergencia.Text & "','" & Me.txt_horasVueloRealizadas.Text & "')"

        cmd.CommandText = consulta

        cmd.ExecuteNonQuery()

        Dim rest As Boolean = buscarFila(txt_idAeronave.Text)
        If (rest = True) Then
            MessageBox.Show("Nueva Aeronave registrada correctamente", "Mensaje de inserción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("La Aeronave no puedo registrarse", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        estadoInicial()

        con.Close()

    End Sub

    Private Function modificar()

        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand

        con.ConnectionString = string_conexion
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "UPDATE Aeronaves SET marca = '" & Me.cbo_marcaAeronave.SelectedValue & "',año = '" & Me.cbo_añoAeronave.Text & "',cant_Pasaj_Economy = '" & Me.txt_cantMaxPasEconomic.Text & "',cant_Pasaj_Premium = '" & Me.txt_cantMaxPasPremium.Text & "',equipaje_PesoMax = '" & Me.txt_pesoMaxEquipaje.Text & "',autonomia_Vuelo = '" & Me.txt_autonomiaVuelo.Text & "',cant_SalidasEmerg = '" & Me.txt_cantSalidasEmergencia.Text & "',horas_Vuelo = '" & Me.txt_horasVueloRealizadas.Text & "'" & "WHERE id_Aeronave = " & txt_idAeronave.Text
        cmd.ExecuteNonQuery()

        MessageBox.Show("La Aeronave se modificó correctamente", "Mensaje de modificación", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Return True

    End Function

    Private Function validar(ByVal idMarcaParam As String)
        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        con.ConnectionString = string_conexion
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT id_Aeronave FROM Aeronaves WHERE deleted = 0 AND id_Aeronave=" & txt_idAeronave.Text
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


        If (resultado = idMarcaParam) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function buscarFila(ByVal idMarca As String)

        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand


        con.ConnectionString = string_conexion
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT id_Aeronave AS 'ID Aeronave', Marca.nombre_Marca AS 'Marca', año AS 'Año', cant_Pasaj_Economy AS 'Cant. Economy', cant_Pasaj_Premium AS 'Cant. Premium', equipaje_PesoMax AS 'Peso equipaje', autonomia_Vuelo AS 'Autonomia', cant_SalidasEmerg AS 'Salidas emergencia', horas_Vuelo AS 'Horas de vuelo' FROM Aeronaves JOIN Marca ON (marca=id_Marca) WHERE Aeronaves.deleted = 0 AND id_Aeronave=" & txt_idAeronave.Text


        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            grd_Aeronaves.DataSource = dt
            Return True
        Else
            MessageBox.Show("La Aeronave no existe", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_idAeronave.Text = ""
            txt_idAeronave.Focus()
            Return False
        End If

        con.Close()
    End Function

    Private Sub btn_buscarAeronave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscarAeronave.Click

        If (txt_idAeronave.Text <> "") Then
            Dim res As Boolean = buscarFila(txt_idAeronave.Text)
            If (res = True) Then
                habilitarAtras()
            End If
        Else
            If (cbo_marcaAeronave.Text = "") Then
                MessageBox.Show("Ingrese ID o Marca para buscar una Aeronave", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Else
                habilitarAtras()
                Dim con As New Data.SqlClient.SqlConnection
                Dim cmd As New Data.SqlClient.SqlCommand

                con.ConnectionString = string_conexion
                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT id_Aeronave AS 'ID Aeronave', Marca.nombre_Marca AS 'Marca', año AS 'Año', cant_Pasaj_Economy AS 'Cant. Economy', cant_Pasaj_Premium AS 'Cant. Premium', equipaje_PesoMax AS 'Peso equipaje', autonomia_Vuelo AS 'Autonomia', cant_SalidasEmerg AS 'Salidas emergencia', horas_Vuelo AS 'Horas de vuelo' FROM Aeronaves JOIN Marca ON (marca=id_Marca) WHERE Aeronaves.deleted = 0 AND marca.nombre_Marca LIKE'" & cbo_marcaAeronave.Text & "'"


                Dim da As New SqlClient.SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                If dt.Rows.Count > 0 Then

                    grd_Aeronaves.DataSource = dt

                Else
                    MessageBox.Show("No hay Aeronaves con esta marca", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    txt_idAeronave.Text = ""
                    txt_idAeronave.Focus()
                    estadoInicial()

                End If

                con.Close()
            End If
        End If

    End Sub

    Private Sub btn_borrarAeronave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrarAeronave.Click


        If txt_idAeronave.Text = "" Then
            MessageBox.Show("Asigne una ID de Aeronave", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If


        Dim res As Boolean = validar(txt_idAeronave.Text)
        If (res = False) Then
            MessageBox.Show("La Aeronave que desea borrar no existe", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim rpta As Integer
        rpta = MessageBox.Show("¿Está seguro que desea eliminar esta Aeronave?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (rpta = DialogResult.Yes) Then
            Dim con As New Data.SqlClient.SqlConnection
            Dim cmd As New Data.SqlClient.SqlCommand


            con.ConnectionString = string_conexion
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            'cmd.CommandText = "DELETE FROM Aeronaves WHERE id_Aeronave=" & txt_idAeronave.Text
            cmd.CommandText = "UPDATE Aeronaves SET  Aeronaves.deleted = 1 WHERE id_Aeronave = " & txt_idAeronave.Text
            cmd.ExecuteNonQuery()

            MessageBox.Show("La Aeronave se eliminó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            estadoInicial()
            habilitarAtras()
        Else

        End If

    End Sub

    Public Function txtNumerico(ByVal txtControl As TextBox, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean

        If (txtControl.Text.IndexOf(".") = 0) Then
            txtControl.Text = ""
            Return False
        End If

        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = "." Then
            If caracter = "." Then
                If decimales = True Then
                    If txtControl.Text.IndexOf(".") <> -1 Then Return True
                Else : Return True
                End If
            End If
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub txt_autonomiaVuelo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_autonomiaVuelo.KeyPress
        e.Handled = txtNumerico(txt_autonomiaVuelo, e.KeyChar, True)
    End Sub

    Private Sub txt_horasVueloRealizadas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_horasVueloRealizadas.KeyPress
        e.Handled = txtNumerico(txt_horasVueloRealizadas, e.KeyChar, True)
    End Sub

    Private Sub txt_pesoMaxEquipaje_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pesoMaxEquipaje.KeyPress
        e.Handled = txtNumerico(txt_pesoMaxEquipaje, e.KeyChar, True)
    End Sub

    Private Sub txt_cantSalidasEmergencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantSalidasEmergencia.KeyPress
        e.Handled = txtNumerico(txt_pesoMaxEquipaje, e.KeyChar, False)
    End Sub

    Private Sub txt_cantMaxPasEconomic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantMaxPasEconomic.KeyPress
        e.Handled = txtNumerico(txt_pesoMaxEquipaje, e.KeyChar, False)
    End Sub

    Private Sub txt_cantMaxPasPremium_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantMaxPasPremium.KeyPress
        e.Handled = txtNumerico(txt_pesoMaxEquipaje, e.KeyChar, False)
    End Sub

    Private Sub txt_idAeronave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_idAeronave.KeyPress
        e.Handled = txtNumerico(txt_idAeronave, e.KeyChar, False)
    End Sub

    Private Sub btn_NuevoAeronave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NuevoAeronave.Click

        estadoInicial()
        btn_buscarAeronave.Enabled = False
        cbo_añoAeronave.Enabled = True
        btn_NuevoAeronave.Enabled = False
        btn_guardarAeronave.Enabled = True
        txt_idAeronave.Enabled = False
        box_caraceristicasAeronave.Enabled = True
        habilitarAtras()

        txt_idAeronave.Text = "AUTOMATICO"

    End Sub

    Private Sub grd_Marcas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_Aeronaves.CellDoubleClick

        If (btn_NuevoAeronave.Enabled = False) Then
            estadoInicial()
            habilitarAtras()
        End If
        cbo_añoAeronave.Enabled = True
        box_caraceristicasAeronave.Enabled = True
        btn_borrarAeronave.Enabled = True
        btn_buscarAeronave.Enabled = False
        btn_NuevoAeronave.Enabled = False

        habilitarAtras()

        If (e.RowIndex = -1) Then
            Exit Sub
        End If

        Dim row As DataGridViewRow = grd_Aeronaves.Rows(e.RowIndex)

        Me.txt_idAeronave.Text = row.Cells(0).Value
        Me.cbo_marcaAeronave.Text = row.Cells(1).Value
        Me.cbo_añoAeronave.Text = row.Cells(2).Value
        Me.txt_cantMaxPasEconomic.Text = row.Cells(3).Value
        Me.txt_cantMaxPasPremium.Text = row.Cells(4).Value
        Me.txt_pesoMaxEquipaje.Text = row.Cells(5).Value
        Me.txt_autonomiaVuelo.Text = row.Cells(6).Value
        Me.txt_cantSalidasEmergencia.Text = row.Cells(7).Value
        Me.txt_horasVueloRealizadas.Text = row.Cells(8).Value
        Me.txt_idAeronave.Enabled = False
        btn_guardarAeronave.Enabled = True
        modificacion = True



    End Sub

    Private Sub box_caraceristicasAeronave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles box_caraceristicasAeronave.KeyPress

        If (modificacion = True) Then
            btn_buscarAeronave.Enabled = False
            btn_guardarAeronave.Enabled = True
            txt_idAeronave.Enabled = False
            btn_borrarAeronave.Enabled = False
            Return
        End If

    End Sub

    Private Sub btn_salirAeronave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_salirAeronave.Click
        If (btn_salirAeronave.Text = "Salir") Then
            Close()
        Else
            estadoInicial()

        End If
    End Sub

    
End Class
