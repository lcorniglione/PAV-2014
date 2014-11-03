Public Class frm_ABM_Localidad
    Public cnn_string As String = "Data Source=ArgenSky.mssql.somee.com;Persist Security Info=True;User ID=adminargensky;Password=pav.2014"
    'Public cnn_string As String = "Data Source=NICOSAM-PC;Initial Catalog=ArgenSky;Integrated Security=True"

    Enum validacion
        positiva
        negativa
    End Enum

    Enum existe
        verdadero
        falso
    End Enum

    Private Sub limpiartodo()
        Me.txt_descripcion.Clear()
        Me.cmb_provincia.SelectedIndex = -1
        Me.txt_id_Localidad.Clear()
    End Sub

    Private Sub reiniciar_id()
        Me.txt_id_Localidad.Text = Me.ultimoPasajero()
    End Sub

    Private Sub cargarTabla(ByVal tabla As DataTable)
        Me.dg_localidad.DataSource = tabla
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
        consulta = "select l.id_Localidad AS 'ID Localidad', p.descripcion AS 'Provincia', l.descripcion AS 'Localidad'"
        consulta &= " from Localidad l JOIN Provincia p ON (l.provincia=p.id_Provincia)"
        consulta &= " where id_localidad < 100"
        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())
        Return tabla
    End Function

    Private Sub llenar_combo(ByVal cmb As ComboBox, ByVal id_tabla As String, ByVal display_tabla As String, ByVal n_tabla As String)
        Dim cnn As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim consulta As String

        cnn.ConnectionString = cnn_string
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        consulta = "select " & id_tabla & "," & display_tabla & " from " & n_tabla & " WHERE deleted LIKE '0'"
        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())

        cmb.DataSource = tabla
        cmb.DisplayMember = display_tabla
        cmb.ValueMember = id_tabla
        cmb.SelectedIndex = -1
        cnn.Close()
    End Sub

    Private Sub frm_ABM_Localidad_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If

    End Sub


    Private Sub frm_ABM_Localidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gb_carateristicas.Enabled = False
        Me.txt_id_Localidad.Enabled = True
        Me.btn_buscar.Text = "Buscar"
        Me.btn_guardar.Text = "Guardar"
        Me.btn_eliminar.Enabled = False
        Me.btn_guardar.Enabled = False
        Me.limpiartodo()
        Me.cargarTabla(Me.consultarTabla())
        Me.llenar_combo(Me.cmb_provincia, "id_Provincia", "descripcion", "Provincia")
        Me.txt_id_Localidad.Focus()
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        Me.limpiartodo()
        Me.cmb_provincia.Focus()
        Me.txt_id_Localidad.Text = Me.ultimoPasajero()
        Me.txt_id_Localidad.Enabled = False
        Me.btn_guardar.Enabled = True
        Me.gb_carateristicas.Enabled = True
        Me.cmb_provincia.SelectedIndex = -1
        Me.btn_guardar.Text = "Guardar"
        Me.btn_eliminar.Enabled = False
        Me.btn_buscar.Text = "Nueva Busqueda"
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        'Me.salir = True
        Me.Close()
    End Sub

  

    Private Function ultimoPasajero() As Integer
        Dim tabla As New Data.DataTable
        tabla = Me.ConsultaSQL("select MAX(id_Localidad) from Localidad")
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

    Private Function ConsultaSQL(ByVal sql As String) As Data.DataTable
        Dim cnn As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim tabla As New Data.DataTable

        cnn.ConnectionString = cnn_string
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql

        tabla.Load(cmd.ExecuteReader())
        Return tabla
    End Function

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click

        If Me.btn_buscar.Text = "Nueva Busqueda" Then
            Me.btn_guardar.Text = "Guardar"
            Me.btn_buscar.Text = "Buscar"
            Me.limpiartodo()
            Me.txt_id_Localidad.Focus()
            Me.gb_carateristicas.Enabled = False
            Me.txt_id_Localidad.Enabled = True
            Me.btn_guardar.Enabled = False
            Me.btn_eliminar.Enabled = False
            Return
        End If

        Dim tabla As New Data.DataTable
        Dim consulta As String
        consulta = ""

        If (Me.txt_id_Localidad.Text <> "" And Me.cmb_provincia.SelectedIndex <> -1) Then
            consulta = "select l.id_Localidad AS 'ID Localidad', p.descripcion AS 'Provincia', l.descripcion AS 'Localidad'"
            consulta &= " from Localidad l JOIN Provincia p ON (l.provincia=p.id_Provincia)"
            consulta &= " where id_Localidad LIKE '" & Me.txt_id_Localidad.Text & "' AND id_Provincia LIKE '" & Me.cmb_provincia.SelectedIndex & "'"

        ElseIf (Me.txt_id_Localidad.Text <> "" And Me.cmb_provincia.SelectedIndex = -1) Then
            consulta = "select l.id_Localidad AS 'ID Localidad', p.descripcion AS 'Provincia', l.descripcion AS 'Localidad'"
            consulta &= " from Localidad l JOIN Provincia p ON (l.provincia=p.id_Provincia)"
            consulta &= " where id_Localidad LIKE '" & Me.txt_id_Localidad.Text & "'"

        ElseIf (Me.txt_id_Localidad.Text = "" And Me.cmb_provincia.SelectedIndex <> -1) Then
            consulta = "select l.id_Localidad AS 'ID Localidad', p.descripcion AS 'Provincia', l.descripcion AS 'Localidad'"
            consulta &= " from Localidad l JOIN Provincia p ON (l.provincia=p.id_Provincia)"
            consulta &= " where id_Provincia LIKE '" & Me.cmb_provincia.SelectedIndex & "'"

        ElseIf (Me.txt_id_Localidad.Text = "" And Me.cmb_provincia.SelectedIndex = -1) Then
            MessageBox.Show("Debe ingresar algún dato", "ArgenSky", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        tabla = ConsultaSQL(consulta)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se ha encontrado ningún resultado", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Me.cargarTabla(tabla)
        Me.limpiartodo()
        Me.txt_id_Localidad.Focus()

    End Sub

    Private Sub dg_localidad_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_localidad.CellDoubleClick
        Try
            Dim row As DataGridViewRow = dg_localidad.Rows(e.RowIndex)
            Me.btn_eliminar.Enabled = True
            Me.btn_guardar.Enabled = True
            Me.gb_carateristicas.Enabled = True
            Me.txt_id_Localidad.Text = row.Cells(0).Value
            Me.cmb_provincia.Text = row.Cells(1).Value
            Me.txt_descripcion.Text = row.Cells(2).Value
            Me.btn_buscar.Text = "Nueva Busqueda"
            Me.btn_guardar.Text = "Modificar"
        Catch ex As ArgumentException
            Return
        End Try
    End Sub

    Private Function validar() As validacion
        If Me.txt_id_Localidad.Text = "" Then
            MessageBox.Show("Ingrese algún ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txt_id_Localidad.Focus()
            Return validacion.negativa
        End If

        If Me.txt_descripcion.Text = "" Then
            MessageBox.Show("Ingrese alguna descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txt_descripcion.Focus()
            Return validacion.negativa
        End If

        If Me.cmb_provincia.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una provincia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cmb_provincia.Focus()
            Return validacion.negativa
        End If

        Return validacion.positiva
    End Function

    Private Function existe_dato() As existe
        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim consulta As String = ""
        Dim tabla As New DataTable

        consulta = "select l.id_Localidad from Localidad l where l.id_Localidad LIKE '" & Me.txt_id_Localidad.Text & "'"

        cnn.ConnectionString = cnn_string
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())

        If tabla.Rows.Count() = 1 Then
            Return existe.verdadero
        Else
            Return existe.falso
        End If
    End Function

    Private Sub txt_id_Localidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_id_Localidad.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_descripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_descripcion.KeyPress
        If (IsNumeric(e.KeyChar) = True Or Asc(e.KeyChar) = 59) Then
            'MsgBox("No debe ingresar caracteres numericos ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click

        If Me.validar() = validacion.negativa Then
            Return
        End If

        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim consulta As String
        Dim mensaje As String
        Dim titulo As String

        cnn.ConnectionString = cnn_string
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text

        If Me.btn_guardar.Text = "Modificar" Then
            consulta = "UPDATE Localidad SET  descripcion = '" & Me.txt_descripcion.Text & "', provincia = '" & Me.cmb_provincia.SelectedIndex & "' "
            consulta &= "WHERE id_localidad LIKE '" & Me.txt_id_Localidad.Text & "'"
            mensaje = "La Localidad se modificó correctamente"
            titulo = "Mensaje de Modificación"
        Else
            consulta = "INSERT INTO Localidad (id_Localidad,provincia,descripcion) VALUES (" & Me.txt_id_Localidad.Text & "," & Me.cmb_provincia.SelectedValue & ",'" & Me.txt_descripcion.Text & "')"
            mensaje = "La Localidad se guardó correctamente"
            titulo = "Mensaje de Inserción"
        End If

        cmd.CommandText = consulta
        cmd.ExecuteNonQuery()
        MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.cargarTabla(Me.consultarTabla())
        cnn.Close()
        Me.limpiartodo()
        Me.reiniciar_id()
        Me.cmb_provincia.Focus()
        Me.btn_eliminar.Enabled = False
        Me.btn_buscar.Text = "Nueva Busqueda"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim consulta As String
        consulta = ""

        If Me.validar() = validacion.negativa Then
            Return
        Else
            consulta = "DELETE FROM Localidad WHERE id_localidad LIKE '" & Me.txt_id_Localidad.Text & "'"
        End If

        If Me.existe_dato() = existe.falso Then
            MessageBox.Show("No existen tales datos en la BD", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        cnn.ConnectionString = cnn_string
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.ExecuteNonQuery()
        MessageBox.Show("La Localidad se eliminó correctamente", "Mensaje de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.limpiartodo()
        Me.txt_id_Localidad.Focus()
        Me.cargarTabla(Me.consultarTabla())
        Me.btn_eliminar.Enabled = False
        Me.gb_carateristicas.Enabled = False
        Me.btn_buscar.Text = "Buscar"
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Text = "Guardar"
        cnn.Close()
    End Sub
End Class
