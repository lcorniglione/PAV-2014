Public Class ABM_Empleados
    Private Const conexionSTR As String = "workstation id=ArgenSky.mssql.somee.com;packet size=4096;user id=adminargensky;pwd=pav.2014;data source=ArgenSky.mssql.somee.com;persist security info=False;initial catalog=ArgenSky"
    Dim frm_Menu As Object
    Dim editar As estado = estado.insertar
    Public trans As Data.SqlClient.SqlTransaction
    Dim estadobusqueda As busqueda = busqueda.habilitada
    Enum Validacion
        positiva
        negativa
    End Enum
    Enum estado
        modificar
        insertar
        buscar
    End Enum
    Enum busqueda
        habilitada
        deshabilitada
    End Enum

    Private Sub ABM_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GroupBox1.Enabled = False
        Me.btn_nuevo.Enabled = True
        Me.btn_guardar.Enabled = False
        Me.llenar_ComboCargo(Me.cbo_cargo, "Cargo", "id_Cargo", "descripcion")
        Me.llenar_comboTipoDoc(Me.cbo_tipoDoc, "Tipo_Documento", "id_TipoDoc", "descripcion")
        Me.cargar_grilla(Me.buscar_Tabla)


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click

        Close()


    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        Me.editar = estado.insertar
        Me.activar_Botones()
        Me.estadobusqueda = busqueda.deshabilitada
        Me.txt_legajo.Focus()


        If btn_nuevo.Text = "Nuevo" Then
            btn_nuevo.Text = "Cancelar"
            'Limpiamos los campos de texto y/o combobox del formulario
            For Each unControl As Control In Me.Controls
                If (TypeOf unControl Is TextBox) Or (TypeOf unControl Is ComboBox) Then
                    unControl.Text = ""
                End If
            Next
            Me.txt_legajo.Text = "AUTOMATICO"
            Me.txt_legajo.Enabled = False
            limpiar_casilleros()
            btn_guardar.Enabled = True
            btn_salir.Enabled = False
            btn_buscar.Enabled = False
            txt_nombre.Focus()
        Else
            btn_nuevo.Text = "Nuevo"
            btn_borrar.Enabled = True
            btn_guardar.Enabled = False
            btn_salir.Enabled = True
            btn_buscar.Enabled = True
            GroupBox1.Enabled = False
        End If

    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click


        If Me.validar_Datos = Validacion.positiva Then

            If Me.editar = estado.insertar Then
                Me.txt_legajo.Text = Me.ultimo_Valor("select MAX(legajo_Empleado) from Empleados ") + 1
                If Me.validar_existencia = Validacion.negativa Then
                    Me.insertar()
                    Me.editar = estado.insertar
                    MessageBox.Show("Se grabo exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show("Ya existe un empleado con ese legajo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            Else
                Me.modificar(Me.txt_legajo.Text)
                MessageBox.Show("Se modifico exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.editar = estado.insertar
                Me.GroupBox1.Enabled = False
            End If

            limpiar_casilleros()
            Me.txt_legajo.Text = "AUTOMATICO"
            Me.txt_legajo.Enabled = False
            Me.cargar_grilla(Me.buscar_Tabla())
        End If
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim fila As String() = {Me.txt_legajo.Text, Me.txt_apellido.Text, Me.txt_nombre.Text, Me.txt_telefono.Text, Me.txt_email.Text, Me.txt_fechaNacimiento.Text, Me.cbo_cargo.Text}
        Dim esteControl As System.Windows.Forms.Control
        dgv_empleados.Rows.Add(fila)

        For Each esteControl In Me.Controls
            If (TypeOf esteControl Is TextBox) Or (TypeOf esteControl Is ComboBox) Then
                esteControl.Text = ""
            End If
        Next


    End Sub

    Function _validar_campos_vacios() As Boolean
        Dim esteControl As System.Windows.Forms.Control

        For Each esteControl In frm_Menu.tab_control.SelectedTab.Controls        'Reviso cada campo y valido no vacio.
            If esteControl.Enabled = True And esteControl.GetType().ToString <> "System.Windows.Forms.Panel" Then
                If esteControl.Text = "" Then
                    MsgBox("Se deben llenar todos los campos", vbOKOnly + vbCritical, "Importante")
                    Return False
                    Exit Function
                End If
            End If
        Next

        Return True
    End Function

    Private Sub llenar_ComboCargo(ByVal combo As ComboBox, ByVal tabla As String, ByVal pk As String, ByVal nombre_cargo As String)
        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim table As New Data.DataTable

        cnn.ConnectionString = conexionSTR
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT " & pk & ", " & nombre_cargo & " FROM " & tabla
        table.Load(cmd.ExecuteReader)
        cbo_cargo.DataSource = table
        cbo_cargo.DisplayMember = nombre_cargo
        cbo_cargo.ValueMember = pk
        cbo_cargo.SelectedIndex = -1
        cnn.Close()
    End Sub

    Private Sub llenar_comboTipoDoc(ByVal cbo As ComboBox, ByVal tabla As String, ByVal pk As String, ByVal tipo_doc As String)
        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim table As New Data.DataTable

        cnn.ConnectionString = conexionSTR
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT " & pk & "," & tipo_doc & " FROM " & tabla
        table.Load(cmd.ExecuteReader)
        cbo_tipoDoc.DataSource = table
        cbo_tipoDoc.DisplayMember = tipo_doc
        cbo_tipoDoc.ValueMember = pk
        cbo_tipoDoc.SelectedIndex = -1
        cnn.Close()
    End Sub

    Private Sub frm_abmPasajeros_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub insertar()
        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim table As New Data.DataTable
        Dim consulta As String
        cnn.ConnectionString = conexionSTR
        cnn.Open()
        consulta = "INSERT INTO Empleados (legajo_Empleado, apellido, nombre, telefono, mail, fecha_Nacimiento, cargo, tipo_Documento, numero_Documento, deleted)"
        consulta += "VALUES(" & Me.txt_legajo.Text & ",'" & Me.txt_apellido.Text & "','" & txt_nombre.Text & "'," & txt_telefono.Text & ",'" & Me.txt_email.Text & "','" & Me.txt_fechaNacimiento.Text & "','" & cbo_cargo.SelectedValue & "','" & cbo_tipoDoc.SelectedValue & "'," & Me.txt_nroDoc.Text & "," & "0" & ")"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = cnn
        cmd.ExecuteNonQuery()
        cnn.Close()

    End Sub

    Private Function validar_Datos() As Validacion
        If Me.txt_apellido.Text = "" Then
            MessageBox.Show("El Apellido no esta cargado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return Validacion.negativa
        End If

        If Me.cbo_cargo.Text = "" Then
            MessageBox.Show("El Cargo del empleado no esta cargado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            Return Validacion.negativa
        End If


        If IsDate(Me.txt_fechaNacimiento.Text) = False Then
            MessageBox.Show("La fecha de nacimiento cargada no es posible", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3)
            Return Validacion.negativa
        End If


        'If Me.txt_legajo.Text = "" Or IsNumeric(Me.txt_legajo.Text) = False Then
        '    MessageBox.Show("El legajo del empleado no esta cargado o no es válido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Return Validacion.negativa
        'End If


        If Me.txt_nombre.Text = "" Then
            MessageBox.Show("El nombre del empleado no esta cargado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return Validacion.negativa
        End If


        If IsNumeric(Me.txt_telefono.Text) = False Or Me.txt_telefono.Text = "" Then
            MessageBox.Show("No es un numero de telefono valido o no esta cargado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return Validacion.negativa
        End If


        If IsNumeric(txt_nombre.Text) Then
            MessageBox.Show("No se pueden ingresar numeros en el nombre", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



        If IsNumeric(txt_nroDoc.Text) = False Then
            MessageBox.Show("No se pueden ingresar letras ni caracteres alfanumericos en el nro de documento", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return Validacion.negativa
        End If

        Return Validacion.positiva
    End Function

    Private Function validar_existencia() As Validacion
        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim table As New Data.DataTable
        Dim consulta As String
        cnn.ConnectionString = conexionSTR
        cnn.Open()
        consulta = "SELECT * FROM Empleados WHERE legajo_Empleado = " & txt_legajo.Text
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = cnn

        table.Load(cmd.ExecuteReader)


        If table.Rows.Count >= 1 Then
            Return Validacion.positiva
        Else
            Return Validacion.negativa
        End If

    End Function


    Private Sub limpiar_casilleros()
        Me.txt_legajo.Text = ""
        Me.txt_nombre.Text = ""
        Me.txt_apellido.Text = ""
        Me.cbo_tipoDoc.SelectedIndex = -1
        Me.txt_nroDoc.Text = ""
        Me.cbo_cargo.SelectedIndex = -1
        Me.txt_fechaNacimiento.Text = ""
        Me.txt_telefono.Text = ""
        Me.txt_email.Text = ""

    End Sub

    Private Sub modificar(ByVal p1 As String)
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim consulta As String = ""

        conexion.ConnectionString = conexionSTR
        conexion.Open()

        consulta = "update Empleados "

        consulta &= "set  legajo_Empleado = " & Me.txt_legajo.Text
        consulta &= ", nombre = '" & Me.txt_nombre.Text & "'"
        consulta &= ", apellido = '" & Me.txt_apellido.Text & "'"
        consulta &= ", tipo_Documento = " & Me.cbo_tipoDoc.SelectedValue
        consulta &= ", numero_Documento = " & Me.txt_nroDoc.Text
        consulta &= ", cargo = " & Me.cbo_cargo.SelectedValue
        consulta &= ", telefono = " & Me.txt_telefono.Text
        consulta &= ", mail = '" & Me.txt_email.Text & "'"
        consulta &= ", fecha_Nacimiento = '" & Me.txt_fechaNacimiento.Text & "'"
        consulta &= ", deleted = " & "0"
        consulta &= " where legajo_Empleado = " & p1

        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion
        cmd.ExecuteNonQuery()
        conexion.Close()
        Me.txt_legajo.Enabled = True
    End Sub

    Private Sub borrar(ByVal p1 As String)
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable

        Dim consulta As String = ""

        conexion.ConnectionString = conexionSTR
        conexion.Open()
        consulta = "update Empleados "

        consulta &= "set  legajo_Empleado = " & Me.txt_legajo.Text
        consulta &= ", nombre = '" & Me.txt_nombre.Text & "'"
        consulta &= ", apellido = '" & Me.txt_apellido.Text & "'"
        consulta &= ", tipo_Documento = " & Me.cbo_tipoDoc.SelectedValue
        consulta &= ", numero_Documento = " & Me.txt_nroDoc.Text
        consulta &= ", cargo = " & Me.cbo_cargo.SelectedValue
        consulta &= ", telefono = " & Me.txt_telefono.Text
        consulta &= ", mail = '" & Me.txt_email.Text & "'"
        consulta &= ", fecha_Nacimiento = '" & Me.txt_fechaNacimiento.Text & "'"
        consulta &= ", deleted = " & "1"
        consulta &= " where legajo_Empleado = " & p1


        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion
        cmd.ExecuteNonQuery()
        conexion.Close()


    End Sub

    Private Sub cmd_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar.Click
        Me.borrar(Me.txt_legajo.Text)
        Me.editar = estado.insertar
        MessageBox.Show("Se borró exitosamente", "Importante", _
       MessageBoxButtons.OK)
        Me.estadobusqueda = busqueda.habilitada
        limpiar_casilleros()
        Me.preparar_Busqueda()
        Me.cargar_grilla(Me.buscar_Tabla())
        Me.GroupBox2.Enabled = True
    End Sub

    Private Sub preparar_Busqueda()
        limpiar_casilleros()
        Me.btn_guardar.Enabled = False
        Me.btn_borrar.Enabled = False
        Me.btn_nuevo.Enabled = True
        Me.txt_nombre.Enabled = False
        Me.txt_apellido.Enabled = False
        Me.cbo_cargo.Enabled = False
        Me.cbo_tipoDoc.Enabled = False
        Me.txt_fechaNacimiento.Enabled = False
        Me.txt_nroDoc.Enabled = False
        Me.txt_email.Enabled = False
        Me.txt_telefono.Enabled = False

    End Sub


    Private Sub cargar_grilla(ByVal tabla As Data.DataTable)
        Me.dgv_empleados.DataSource = tabla
        
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim consulta As String
        conexion.ConnectionString = conexionSTR
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text


        If Me.txt_legajo.Text <> "" Then
            consulta = "SELECT e.legajo_Empleado AS 'Legajo',e.apellido AS 'Apellido', e.nombre AS 'Nombre', e.telefono AS 'Telefono', e.mail AS 'Mail', e.fecha_Nacimiento AS 'Fecha de Nacimiento', c.descripcion AS 'Cargo', td.descripcion AS 'Tipo Documento', e.numero_Documento AS 'Numero de Documento'"
            consulta &= "FROM Empleados e join Cargo c ON (e.cargo = c.id_Cargo) join Tipo_Documento td ON (e.tipo_Documento = td.id_TipoDoc)"
            consulta &= "WHERE legajo_Empleado =" & Me.txt_legajo.Text

            If (Me.cbo_tipoDoc.SelectedIndex <> -1) Then
                consulta &= "AND e.tipo_Documento Like '" & Me.cbo_tipoDoc.SelectedIndex & "'"
            End If
            If (Me.txt_nroDoc.Text <> "") Then
                consulta &= " AND e.numero_Documento Like '" & Me.txt_nroDoc.Text & "'"
            End If

        Else
            If (Me.cbo_tipoDoc.SelectedIndex <> -1) Then
                consulta = "SELECT e.legajo_Empleado AS 'Legajo', e.apellido AS 'Apellido', e.nombre AS 'Nombre', e.telefono AS 'Telefono', e.mail AS 'Mail', e.fecha_Nacimiento AS 'Fecha de Nacimiento', c.descripcion AS 'Cargo', td.descripcion AS 'Tipo Documento', e.numero_Documento AS 'Numero de Documento'"
                consulta &= "FROM Empleados e join Cargo c ON (e.cargo = c.id_Cargo) join Tipo_Documento td ON (e.tipo_Documento = td.id_TipoDoc)"
                consulta &= "AND e.tipo_Documento ='" & cbo_tipoDoc.SelectedIndex & "'"
                consulta &= "AND e.deleted =" & "0"
                If (Me.txt_nroDoc.Text <> "") Then
                    consulta &= " AND e.nro_Documento Like '" & Me.txt_nroDoc.Text & "'"
                End If
            Else
                If (Me.txt_nroDoc.Text <> "") Then
                    consulta = "SELECT e.legajo_Empleado AS 'Legajo', e.apellido AS 'Apellido', e.nombre AS 'Nombre', e.telefono AS 'Telefono', e.mail AS 'Mail', e.fecha_Nacimiento AS 'Fecha de Nacimiento', c.descripcion AS 'Cargo', td.descripcion AS 'Tipo Documento', e.numero_Documento AS 'Numero de Documento'"
                    consulta &= "FROM Empleados e join Cargo c ON (e.cargo = c.id_Cargo) join Tipo_Documento td ON (e.tipo_Documento = td.id_TipoDoc)"
                    consulta &= "WHERE e.numero_Documento ='" & Me.txt_nroDoc.Text & "'"
                    consulta &= "AND e.deleted =" & "0"
                End If
            End If
        End If

        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())
        If tabla.Rows.Count > 0 Then
            Me.cargar_grilla(tabla)
        Else
            MessageBox.Show("La busqueda no tuvo exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Function buscar_Tabla() As Data.DataTable
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim consulta As String
        conexion.ConnectionString = conexionSTR
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

        consulta = "SELECT e.legajo_Empleado AS 'Legajo', e.apellido AS 'Apellido', e.nombre AS 'Nombre', e.telefono AS 'Telefono', e.mail AS 'Mail', e.fecha_Nacimiento AS 'Fecha de Nacimiento', c.descripcion AS 'Cargo', td.descripcion AS 'Tipo Documento', e.numero_Documento AS 'Numero de Documento'"
        consulta &= "FROM Empleados e join Cargo c ON (e.cargo = c.id_Cargo) join Tipo_Documento td ON (e.tipo_Documento = td.id_TipoDoc)"
        consulta &= "where(e.legajo_Empleado < 1000000) AND e.deleted = 0"
        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())
        Return tabla
    End Function


    Private Sub grd_pasajeros_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_empleados.CellDoubleClick
        If (e.RowIndex = -1) Then
            Exit Sub
        End If

        Me.estadobusqueda = busqueda.deshabilitada

        Dim row As DataGridViewRow = dgv_empleados.Rows(e.RowIndex)

        Me.editar = estado.modificar
        Me.activar_Botones()

        Me.txt_legajo.Text = row.Cells(0).Value
        Me.txt_nombre.Text = row.Cells(2).Value
        Me.txt_apellido.Text = row.Cells(1).Value
        Me.cbo_tipoDoc.SelectedText = row.Cells(7).Value
        Me.txt_nroDoc.Text = row.Cells(8).Value
        Me.txt_fechaNacimiento.Text = row.Cells(5).Value
        Me.txt_email.Text = row.Cells(4).Value
        Me.txt_telefono.Text = row.Cells(3).Value
        Me.cbo_cargo.SelectedText = row.Cells(6).Value

        Me.txt_legajo.Enabled = False
        Me.btn_guardar.Enabled = True
        Me.activarCampos()

    End Sub

    Private Sub activar_Botones()

        Me.GroupBox1.Enabled = False
        If Me.editar = ABM_Empleados.estado.insertar Then
            Me.GroupBox1.Enabled = True
            Me.txt_legajo.Enabled = True
            Me.txt_apellido.Enabled = True
            Me.txt_email.Enabled = True
            Me.txt_nombre.Enabled = True
            Me.txt_nroDoc.Enabled = True
            Me.txt_telefono.Enabled = True
            Me.cbo_cargo.Enabled = True
            Me.cbo_tipoDoc.Enabled = True
            Me.btn_borrar.Enabled = False
            Me.btn_buscar.Enabled = False

        End If
    End Sub


    Private Sub activarCampos()
        Me.GroupBox1.Enabled = True
    End Sub



    Private Function ultimo_Valor(ByVal consulta As String) As String
        Dim tabla As New Data.DataTable
        tabla = BDHelper.ConsultaSQL(consulta)
        Dim row As DataRow = tabla.Rows(0)
        Dim up As Integer
        Try
            up = Convert.ToString(row(0))
        Catch ex As InvalidCastException
            up = 0
        End Try
        Return up
    End Function
End Class
