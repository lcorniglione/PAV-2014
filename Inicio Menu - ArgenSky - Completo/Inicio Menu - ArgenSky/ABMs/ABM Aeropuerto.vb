Public Class frm_ABMAeropuerto
    Public cnn_string As String = "Data Source=ArgenSky.mssql.somee.com;Persist Security Info=True;User ID=adminargensky;Password=pav.2014"
    'Public cnn_string As String = "Data Source=NICOSAM-PC;Initial Catalog=ArgenSky;Integrated Security=True"
    Enum validar
        positivo
        negativo
    End Enum

    Enum existe
        positivo
        negativo
    End Enum

    Private Sub limpiarTodo()
        Me.txt_nombre_Aeropuerto.Clear()
        Me.txt_telefono.Clear()
        Me.txt_cant_PuertasEmbarque.Clear()
        Me.txt_cant_Mangas.Clear()
        Me.txt_idAeropuerto.Clear()
        Me.cb_localidad.SelectedIndex = -1
    End Sub

    Private Sub reiniciarid()
        Me.txt_idAeropuerto.Text = Me.ultimoPsajero()
    End Sub

    Private Sub cargarTabla(ByVal tabla As DataTable)
        Me.grd_aeropuerto.DataSource = tabla
    End Sub

    Private Function consultarTabla()
        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim consulta As String

        cnn.ConnectionString = cnn_string
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        consulta = "select a.id_aeropuerto AS 'ID Aeropuerto'"
        consulta &= ",a.nombre_aeropuerto AS 'Nombre'"
        consulta &= ",l.descripcion AS 'Localidad',a.telefono AS 'Telefono',a.cant_PuertasEmbarque AS 'Cant PuertasEmbarque',a.cant_Mangas AS 'Cant Mangas'"
        consulta &= "from Aeropuertos a JOIN Localidad l ON (a.localidad=l.id_Localidad)"
        consulta &= "where a.id_Aeropuerto < 100"
        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())
        cnn.Close()
        Return tabla
    End Function

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim consulta As String = ""

        If Me.btn_buscar.Text = "Nueva Busqueda" Then
            Me.btn_guardar.Enabled = False
            Me.btn_guardar.Text = "Guardar"
            Me.grp_caracteristicas.Enabled = False
            Me.btn_buscar.Text = "Buscar"
            Me.txt_idAeropuerto.Enabled = True
            Me.btn_eliminar.Enabled = False
            Me.limpiarTodo()
            Return
        End If

        consulta = Me.completarConsulta()

        If (Me.txt_idAeropuerto.Text = "" And Me.txt_nombre_Aeropuerto.Text = "" And Me.cb_localidad.SelectedIndex = -1) Then
            MessageBox.Show("Ingrese algún dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txt_idAeropuerto.Focus()
            Return
        End If

        cnn.ConnectionString = cnn_string
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se ha encontrado ningún dato", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Me.cargarTabla(tabla)
        cnn.Close()
        Me.limpiarTodo()

    End Sub

    Private Sub btn_nuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        Me.limpiarTodo()
        Me.reiniciarid()
        Me.txt_idAeropuerto.Enabled = False
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.Enabled = True
        Me.grp_caracteristicas.Enabled = True
        Me.btn_buscar.Text = "Nueva Busqueda"
        Me.btn_eliminar.Enabled = False
        Me.txt_nombre_Aeropuerto.Focus()
    End Sub

    Private Sub frm_ABMAeropuerto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub


    Private Sub frm_ABMAeropuerto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btn_eliminar.Enabled = False
        Me.grp_caracteristicas.Enabled = False
        Me.txt_idAeropuerto.Enabled = True
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Text = "Guardar"
        Me.btn_buscar.Text = "Buscar"
        Me.limpiarTodo()
        Me.cargarTabla(Me.consultarTabla())
        Me.llenar_combo(Me.cb_localidad, "Localidad", "id_Localidad", "descripcion")
    End Sub

    Private Sub llenar_combo(ByVal cbo As ComboBox, ByVal n_tabla As String, ByVal id_tabla As String, ByVal display_tabla As String)
        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim consulta As String = ""

        cnn.ConnectionString = cnn_string
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        consulta = "select " & id_tabla & "," & display_tabla & " from " & n_tabla & " WHERE deleted LIKE '0'"
        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())

        cbo.DataSource = tabla
        cbo.DisplayMember = display_tabla
        cbo.ValueMember = id_tabla
        cbo.SelectedIndex = -1
        cnn.Close()
    End Sub

    Private Function validar_datos() As validar

        If Me.txt_idAeropuerto.Text = "" Then
            MessageBox.Show("No contiene ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txt_idAeropuerto.Focus()
            Return validar.negativo
        End If

        If Me.txt_nombre_Aeropuerto.Text = "" Then
            MessageBox.Show("Ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txt_nombre_Aeropuerto.Focus()
            Return validar.negativo
        End If

        If Me.cb_localidad.SelectedIndex = -1 Then
            MessageBox.Show("No seleccionó ninguna localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cb_localidad.Focus()
            Return validar.negativo
        End If

        If Me.txt_telefono.Text = "" Then
            MessageBox.Show("Ingrese un teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txt_telefono.Focus()
            Return validar.negativo
        End If

        If Me.txt_cant_PuertasEmbarque.Text = "" Then
            MessageBox.Show("Ingrese la cantidad de puertas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txt_cant_PuertasEmbarque.Focus()
            Return validar.negativo
        End If

        If Me.txt_cant_Mangas.Text = "" Then
            MessageBox.Show("Ingrese la cantidad de Mangas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txt_cant_Mangas.Focus()
            Return validar.negativo
        End If

        Return validar.positivo

    End Function

    Private Function ultimoPsajero()
        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable

        cnn.ConnectionString = cnn_string
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT MAX(id_aeropuerto) FROM Aeropuertos"
        tabla.Load(cmd.ExecuteReader())

        Dim row As DataRow = tabla.Rows(0)
        Dim up As Integer
        If IsDBNull(row(0)) Then
            up = 0
        Else
            up = row(0)
        End If
        up += 1
        Return up
    End Function

    Private Function consultaBusqueda() As String
        Dim sentencia As String = ""
        sentencia = "SELECT a.id_Aeropuerto AS 'ID Aeropuerto', a.nombre_aeropuerto AS 'Nombre', l.descripcion AS 'Localidad', a.telefono AS 'Telefono', a.cant_PuertasEmbarque AS 'Cant. Puertas', a.cant_Mangas AS 'Cant. Mangas'"
        sentencia &= "FROM Aeropuertos a JOIN Localidad l ON (a.localidad=l.id_Localidad)"
        Return sentencia
    End Function

    Private Function completarConsulta() As String
        Dim consulta As String = ""

        If (Me.txt_idAeropuerto.Text <> "" And Me.txt_nombre_Aeropuerto.Text <> "" And Me.cb_localidad.SelectedIndex <> -1) Then
            consulta = Me.consultaBusqueda()
            consulta &= "WHERE a.id_Aeropuerto LIKE '" & Me.txt_idAeropuerto.Text & "' AND id_Localidad LIKE '" & Me.cb_localidad.SelectedIndex + 1 & "' AND a.nombre_aeropuerto LIKE '" & Me.txt_nombre_Aeropuerto.Text & "'"
            Return consulta

        ElseIf (Me.txt_idAeropuerto.Text <> "" And Me.txt_nombre_Aeropuerto.Text <> "" And Me.cb_localidad.SelectedIndex = -1) Then
            consulta = Me.consultaBusqueda()
            consulta &= "WHERE a.id_Aeropuerto LIKE '" & Me.txt_idAeropuerto.Text & "' AND a.nombre_aeropuerto LIKE '" & Me.txt_nombre_Aeropuerto.Text & "'"
            Return consulta

        ElseIf (Me.txt_idAeropuerto.Text <> "" And Me.txt_nombre_Aeropuerto.Text = "" And Me.cb_localidad.SelectedIndex <> -1) Then
            consulta = Me.consultaBusqueda()
            consulta &= "WHERE a.id_Aeropuerto LIKE '" & Me.txt_idAeropuerto.Text & "' AND id_Localidad LIKE '" & Me.cb_localidad.SelectedIndex + 1 & "'"
            Return consulta

        ElseIf (Me.txt_idAeropuerto.Text <> "" And Me.txt_nombre_Aeropuerto.Text = "" And Me.cb_localidad.SelectedIndex = -1) Then
            consulta = Me.consultaBusqueda()
            consulta &= "WHERE a.id_Aeropuerto LIKE '" & Me.txt_idAeropuerto.Text & "'"
            Return consulta

        ElseIf (Me.txt_idAeropuerto.Text = "" And Me.txt_nombre_Aeropuerto.Text <> "" And Me.cb_localidad.SelectedIndex <> -1) Then
            consulta = Me.consultaBusqueda()
            consulta &= "WHERE id_Localidad LIKE '" & Me.cb_localidad.SelectedIndex + 1 & "' AND a.nombre_aeropuerto LIKE '" & Me.txt_nombre_Aeropuerto.Text & "'"
            Return consulta

        ElseIf (Me.txt_idAeropuerto.Text = "" And Me.txt_nombre_Aeropuerto.Text <> "" And Me.cb_localidad.SelectedIndex = -1) Then
            consulta = Me.consultaBusqueda()
            consulta &= "WHERE a.nombre_aeropuerto LIKE '" & Me.txt_nombre_Aeropuerto.Text & "'"
            Return consulta

        ElseIf (Me.txt_idAeropuerto.Text = "" And Me.txt_nombre_Aeropuerto.Text = "" And Me.cb_localidad.SelectedIndex <> -1) Then
            consulta = Me.consultaBusqueda()
            consulta &= "WHERE id_Localidad LIKE '" & Me.cb_localidad.SelectedIndex + 1 & "'"
            Return consulta
        End If
        Return consulta = ""
    End Function

    Private Sub btn_guardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If validar_datos() = validar.negativo Then
            Return
        End If

        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim consulta As String = ""
        Dim titulo As String
        Dim mensaje As String

        If Me.btn_guardar.Text = "Guardar" Then
            consulta = "INSERT INTO Aeropuertos (id_Aeropuerto, localidad, telefono, cant_PuertasEmbarque, cant_Mangas, nombre_aeropuerto)"
            consulta &= " VALUES (" & Me.txt_idAeropuerto.Text & "," & Me.cb_localidad.SelectedValue & "," & Me.txt_telefono.Text & ""
            consulta &= "," & txt_cant_PuertasEmbarque.Text & "," & Me.txt_cant_Mangas.Text & ",'" & Me.txt_nombre_Aeropuerto.Text & "')"
            mensaje = "El Aeropuerto se guardó correctamente"
            titulo = "Mensaje de Inserción"

        Else
            consulta = "UPDATE Aeropuertos SET nombre_aeropuerto = '" & Me.txt_nombre_Aeropuerto.Text & "', localidad = '" & Me.cb_localidad.SelectedIndex + 1 & "'"
            consulta &= ",telefono = '" & Me.txt_telefono.Text & "',cant_PuertasEmbarque = '" & Me.txt_cant_PuertasEmbarque.Text & "'"
            consulta &= ",cant_Mangas = '" & Me.txt_cant_Mangas.Text & "'"
            consulta &= "WHERE id_Aeropuerto LIKE '" & Me.txt_idAeropuerto.Text & "'"
            titulo = "Mensaje de Modificación"
            mensaje = "El Aeropuerto se modificó correctamente"
        End If

        cnn.ConnectionString = cnn_string
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.ExecuteNonQuery()
        MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.cargarTabla(Me.consultarTabla())
        Me.limpiarTodo()
        Me.reiniciarid()
        Me.txt_idAeropuerto.Enabled = False
        cnn.Close()
        Me.txt_nombre_Aeropuerto.Focus()
    End Sub

    Private Sub grd_aeropuerto_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_aeropuerto.CellDoubleClick

        Try
            Dim row As DataGridViewRow = grd_aeropuerto.Rows(e.RowIndex)
            Me.btn_eliminar.Enabled = True
            Me.btn_guardar.Enabled = True
            Me.btn_buscar.Text = "Nueva Busqueda"
            Me.btn_guardar.Text = "Modificar"
            Me.txt_idAeropuerto.Text = row.Cells(0).Value
            Me.txt_nombre_Aeropuerto.Text = row.Cells(1).Value
            Me.cb_localidad.Text = row.Cells(2).Value
            Me.txt_telefono.Text = row.Cells(3).Value
            Me.txt_cant_PuertasEmbarque.Text = row.Cells(4).Value
            Me.txt_cant_Mangas.Text = row.Cells(5).Value
            Me.grp_caracteristicas.Enabled = True
        Catch ex As ArgumentException
            Return
        End Try

    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim consulta As String = ""

        If validar_datos() = validar.negativo Then
            Return
        End If

        consulta = "DELETE FROM Aeropuertos WHERE id_Aeropuerto LIKE '" & Me.txt_idAeropuerto.Text & "'"

        If existe_dato() = existe.negativo Then
            MessageBox.Show("No existen tales datos en la BD", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        cnn.ConnectionString = cnn_string
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.ExecuteNonQuery()
        MessageBox.Show("El Aeropuerto se eliminó correctamente", "Mensaje de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cnn.Close()
        Me.limpiarTodo()
        Me.txt_idAeropuerto.Enabled = True
        Me.btn_eliminar.Enabled = False
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.Enabled = False
        Me.btn_buscar.Text = "Buscar"
        Me.grp_caracteristicas.Enabled = False
        Me.cargarTabla(Me.consultarTabla())
    End Sub

    Private Function existe_dato() As existe
        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable

        cnn.ConnectionString = cnn_string
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT id_Aeropuerto FROM Aeropuertos WHERE id_Aeropuerto = '" & Me.txt_idAeropuerto.Text & "'"
        tabla.Load(cmd.ExecuteReader())

        If tabla.Rows.Count = 1 Then
            Return existe.positivo
        End If
        Return existe.negativo
    End Function

    Private Sub txt_telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telefono.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_nombre_Aeropuerto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre_Aeropuerto.KeyPress
        If (IsNumeric(e.KeyChar) = True Or Asc(e.KeyChar) = 59) Then
            'MsgBox("No debe ingresar caracteres numericos ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txt_idAeropuerto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_idAeropuerto.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cant_PuertasEmbarque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cant_PuertasEmbarque.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cant_Mangas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cant_Mangas.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class
