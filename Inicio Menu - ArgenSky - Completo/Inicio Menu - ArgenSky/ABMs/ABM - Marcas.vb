Public Class frm_ABMMarcas

    Public string_conexion As String = "workstation id=ArgenSky.mssql.somee.com;packet size=4096;user id=adminargensky;pwd=pav.2014;data source=ArgenSky.mssql.somee.com;persist security info=False;initial catalog=ArgenSky"
    Public modificacion As Boolean = False

    Private Sub frm_ABMMarcas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_ABMMarcas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        estadoInicial()

    End Sub

    Private Sub estadoInicial()

        llenarGrid()
        limpiarTodo()
        btn_nuevaMarca.Enabled = True
        btn_buscar.Enabled = True
        btn_guardarMarca.Enabled = False
        lbl_nombreMarca.Enabled = False
        txt_nombreMarca.Enabled = False
        btn_borrarMarca.Enabled = False
        txt_idMarca.Enabled = True
        modificacion = False

    End Sub

    Private Sub limpiarTodo()

        txt_idMarca.Clear()
        txt_nombreMarca.Clear()

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

        consulta = "SELECT id_Marca AS 'ID Marca', nombre_Marca AS 'Nombre' FROM Marca WHERE deleted = 0"
        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())

        Me.grd_Marcas.DataSource = tabla
        Return tabla

    End Function

    Private Sub txt_idMarca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_idMarca.KeyPress

        Dim Sep As Char
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Sep) Or Char.IsControl(e.KeyChar)) Then e.Handled = True

    End Sub

    Private Sub habilitarAtras()

        If (btn_salirMarca.Text = "Salir") Then
            btn_salirMarca.Text = "Atrás"

        Else
            btn_salirMarca.Text = "Salir"
        End If

    End Sub

    Private Sub btn_guardarMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardarMarca.Click

        If Me.txt_idMarca.Text Is "" Then
            MessageBox.Show("Asigne una ID de Marca válido", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_idMarca.Focus()
            Return
        End If
        If Me.txt_nombreMarca.Text Is "" Then
            MessageBox.Show("Asigne un nombre de Marca válido", "Error de isnerción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_nombreMarca.Focus()
            Return
        End If

        If (modificacion = True) Then
            modificar(txt_nombreMarca.Text)
            modificacion = False
            habilitarAtras()
            estadoInicial()
            Return
        End If

        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand

        con = New Data.SqlClient.SqlConnection(string_conexion)
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT MAX(id_Marca) FROM Marca"
        Dim valorMax As Integer = cmd.ExecuteScalar()

        txt_idMarca.Text = valorMax + 1

        Dim res As Boolean = validar(Me.txt_idMarca.Text)
        If (res = True) Then
            MessageBox.Show("La Marca que intenta crear ya existe", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_idMarca.Focus()
            Return
        End If

        Dim strSQL As String = "INSERT INTO Marca (id_Marca, nombre_Marca)"
        strSQL = strSQL + " VALUES ('" & Me.txt_idMarca.Text & "','" & Me.txt_nombreMarca.Text & "')"

        cmd.CommandText = strSQL

        cmd.ExecuteNonQuery()

        Dim rest As Boolean = buscarFila(txt_idMarca.Text)
        If (rest = True) Then
            MessageBox.Show("Nueva Marca registrada correctamente", "Mensaje de inserción", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("La marca no puedo registrarse", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        estadoInicial()
        habilitarAtras()
        con.Close()

    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click

        If txt_idMarca.Text = "" Then
            MessageBox.Show("Asigne una ID de Marca", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_idMarca.Focus()
            Return
        End If

        Dim res As Boolean = buscarFila(txt_idMarca.Text)
        If (res = True) Then
            habilitarAtras()
        End If

    End Sub

    Private Sub btn_nuevaMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevaMarca.Click

        modificacion = False
        llenarGrid()
        limpiarTodo()
        btn_borrarMarca.Enabled = False
        lbl_nombreMarca.Enabled = True
        txt_nombreMarca.Enabled = True
        btn_guardarMarca.Enabled = True
        btn_nuevaMarca.Enabled = False
        btn_buscar.Enabled = False
        txt_idMarca.Enabled = False
        txt_idMarca.Text = "AUTOMATICO"
        habilitarAtras()

    End Sub

    Private Function modificar(ByRef nuevoValor As String)

        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand

        con.ConnectionString = string_conexion
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "UPDATE Marca SET nombre_Marca = '" & nuevoValor & "' WHERE id_Marca = " & txt_idMarca.Text
        cmd.ExecuteNonQuery()

        MessageBox.Show("El nombre de la Marca se modificó correctamente", "Mensaje de modificación", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Return True

    End Function

    Private Sub btn_salirMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salirMarca.Click
        If (btn_salirMarca.Text = "Salir") Then
            Close()
        Else
            estadoInicial()
            habilitarAtras()
        End If



    End Sub

    Private Sub btn_borrarMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrarMarca.Click

        If txt_idMarca.Text = "" Then
            MessageBox.Show("Asigne un ID de Marca", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Dim res As Boolean = validar(txt_idMarca.Text)
        If (res = False) Then
            MessageBox.Show("La Marca que desea eliminar no existe", "Error de elimnación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim rpta As Integer
        rpta = MessageBox.Show("¿Está seguro que desea eliminar esta Marca?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (rpta = DialogResult.Yes) Then
            Dim con As New Data.SqlClient.SqlConnection
            Dim cmd As New Data.SqlClient.SqlCommand


            con.ConnectionString = string_conexion
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            'cmd.CommandText = "DELETE FROM Marca WHERE id_Marca=" & txt_idMarca.Text SE CAMBIA POR BORRADO LOGICO
            cmd.CommandText = "UPDATE Marca SET deleted = 1 WHERE id_Marca = " & txt_idMarca.Text
            cmd.ExecuteNonQuery()

            MessageBox.Show("La Marca se eliminó correctamente", "Mensaje de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            estadoInicial()
            habilitarAtras()
        Else

        End If

    End Sub

    Private Function buscarFila(ByVal idMarca As String)

        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand

        con.ConnectionString = string_conexion
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT id_Marca AS 'ID Marca', nombre_Marca AS 'Nombre' FROM Marca WHERE deleted = 0 AND id_Marca=" & txt_idMarca.Text

        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            grd_Marcas.DataSource = dt
            Return True
        Else
            MessageBox.Show("La Marca no existe", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_idMarca.Text = ""
            txt_idMarca.Focus()
            Return False
        End If

        con.Close()

    End Function

    Private Function validar(ByVal idMarcaParam As String)

        Dim con As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand

        con.ConnectionString = string_conexion
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT id_Marca FROM Marca WHERE deleted = 0 AND id_Marca=" & txt_idMarca.Text
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

    Private Sub grd_Marcas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_Marcas.CellDoubleClick

        txt_idMarca.Enabled = False
        txt_nombreMarca.Enabled = True
        lbl_nombreMarca.Enabled = True
        btn_borrarMarca.Enabled = True
        btn_buscar.Enabled = False
        btn_nuevaMarca.Enabled = False
        habilitarAtras()
        If (e.RowIndex = -1) Then
            Exit Sub
        End If

        Dim row As DataGridViewRow = grd_Marcas.Rows(e.RowIndex)

        Me.txt_idMarca.Text = row.Cells(0).Value
        Me.txt_nombreMarca.Text = row.Cells(1).Value
        modificacion = True



    End Sub

    Private Sub txt_nombreMarca_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nombreMarca.Click

        If (modificacion = True) Then
            btn_buscar.Enabled = False
            btn_guardarMarca.Enabled = True
            txt_idMarca.Enabled = False
            btn_borrarMarca.Enabled = False
            Return
        End If

    End Sub

End Class
