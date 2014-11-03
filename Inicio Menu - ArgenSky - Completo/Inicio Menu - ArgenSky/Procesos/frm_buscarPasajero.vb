Public Class frm_buscarPasajero

    Private Sub frm_buscarPasajero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.llenar_combo(Me.cbo_tipoDocumento, "Tipo_Documento", "id_TipoDoc", "descripcion")
        Me.txt_idPasajero.Text = ""
        Me.cbo_tipoDocumento.SelectedIndex = -1
        Me.txt_numeroDocumento.Text = ""
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

    Private Sub validar_carga_numerica(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_numeroDocumento.KeyPress, txt_idPasajero.KeyPress

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
        If (Me.txt_idPasajero.Text = "" And Me.cbo_tipoDocumento.SelectedIndex = -1 And Me.txt_numeroDocumento.Text = "") Then
            MessageBox.Show("Por favor ingrese algun criterio de busqueda", "Error en la busqueda", MessageBoxButtons.OK)
            Exit Sub
        End If
        Dim tabla As New Data.DataTable
        Dim consulta As String


        If (Me.txt_idPasajero.Text <> "") Then
            consulta = "select p.id_Pasajero AS 'Id Pasajero', p.nombre_Pasajero AS 'Nombre', p.apellido_Pasajero AS 'Apellido', t.descripcion AS 'Tipo Doc', p.numero_Documento AS 'Documento' , pa.descripcion AS 'Nacionalidad',s.descripcion AS 'Sexo'"
            consulta &= " from Pasajeros p join Sexo s ON (p.sexo = s.id_sexo ) join Pais pa ON (p.nacionalidad = pa.id_Pais )join Tipo_Documento t ON (p.tipo_Documento= t.id_TipoDoc)"
            consulta &= "where p.id_Pasajero Like '" & Me.txt_idPasajero.Text & "'"
            consulta &= " AND p.deleted = 0 "
            If (Me.cbo_tipoDocumento.SelectedIndex <> -1) Then
                consulta &= " AND p.tipo_Documento Like '" & Me.cbo_tipoDocumento.SelectedIndex & "'"
            End If
            If (Me.txt_numeroDocumento.Text <> "") Then
                consulta &= " AND p.numero_Documento Like '" & Me.txt_numeroDocumento.Text & "'"
            End If
        Else
            If (Me.cbo_tipoDocumento.SelectedIndex <> -1) Then
                consulta = "select p.id_Pasajero AS 'Id Pasajero', p.nombre_Pasajero AS 'Nombre', p.apellido_Pasajero AS 'Apellido', t.descripcion AS 'Tipo Doc', p.numero_Documento AS 'Documento' , pa.descripcion AS 'Nacionalidad',s.descripcion AS 'Sexo'"
                consulta &= " from Pasajeros p join Sexo s ON (p.sexo = s.id_sexo ) join Pais pa ON (p.nacionalidad = pa.id_Pais )join Tipo_Documento t ON (p.tipo_Documento= t.id_TipoDoc)"
                consulta &= "AND p.tipo_Documento Like '" & Me.cbo_tipoDocumento.SelectedIndex & "'"
                consulta &= " AND p.deleted = 0 "
                If (Me.txt_numeroDocumento.Text <> "") Then
                    consulta &= " AND p.numero_Documento Like '" & Me.txt_numeroDocumento.Text & "'"
                End If
            Else
                If (Me.txt_numeroDocumento.Text <> "") Then
                    consulta = "select p.id_Pasajero AS 'Id Pasajero', p.nombre_Pasajero AS 'Nombre', p.apellido_Pasajero AS 'Apellido', t.descripcion AS 'Tipo Doc', p.numero_Documento AS 'Documento' , pa.descripcion AS 'Nacionalidad',s.descripcion AS 'Sexo'"
                    consulta &= " from Pasajeros p join Sexo s ON (p.sexo = s.id_sexo ) join Pais pa ON (p.nacionalidad = pa.id_Pais )join Tipo_Documento t ON (p.tipo_Documento= t.id_TipoDoc)"
                    consulta &= " AND p.numero_Documento Like '" & Me.txt_numeroDocumento.Text & "'"
                    consulta &= " AND p.deleted = 0 "
                End If
            End If
        End If

        tabla = BDHelper.ConsultaSQL(consulta)

        If (tabla.Rows.Count <> 0) Then
            Me.grd_pasajeros.DataSource = tabla

        Else
            MessageBox.Show("La busqueda no tuvo exito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub



    Private Sub grd_pasajeros_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_pasajeros.CellContentClick
        If (e.RowIndex = -1) Then
            Exit Sub
        End If
        Dim row As DataGridViewRow = grd_pasajeros.Rows(e.RowIndex)

        If (MessageBox.Show("¿Está seguro que desea seleccionar el pasajero?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            frm_pasajes.cargarPasajeroSeleccionado(row)
            Me.Close()
        End If




    End Sub
End Class