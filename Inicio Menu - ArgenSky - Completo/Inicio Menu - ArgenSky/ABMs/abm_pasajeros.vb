

Public Class frm_abmPasajeros
    Enum conexion
        correcta
        incorrecta
    End Enum
    Enum validacion
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
    Dim editar As estado = estado.insertar
    Dim estadobusqueda As busqueda = busqueda.habilitada

    Dim string_conexion As String

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
    'Funcion para buscar una tabla con sus columnas correspondientes. Sirve para abm sin combo box.
    Private Function leo_tabla(ByVal nombre_tabla As String, ByVal pk_tabla As String) As Data.DataTable
        Dim consulta As String
        Dim tabla As New Data.DataTable

        consulta = "select * from " & nombre_tabla
        consulta += " where " & pk_tabla & " < 100 AND deleted = 0"


        tabla = BDHelper.ConsultaSQL(consulta)
        Return tabla
    End Function
   
    'Funcion para buscar una tabla con sus columnas correspondientes. Sirve para abm sin combo box.
    Private Function buscar_Tabla() As Data.DataTable
      
        Dim tabla As New Data.DataTable
        Dim consulta As String

        consulta = " select p.id_Pasajero AS 'Id Pasajero', p.nombre_Pasajero AS 'Nombre', p.apellido_Pasajero AS 'Apellido', t.descripcion AS 'Tipo Doc', p.numero_Documento AS 'Documento' , pa.descripcion AS 'Nacionalidad',s.descripcion AS 'Sexo',p.tipo_documento, p.sexo,p.nacionalidad"
        consulta &= " from Pasajeros p join Sexo s ON (p.sexo = s.id_sexo ) join Pais pa ON (p.nacionalidad = pa.id_Pais )join Tipo_Documento t ON (p.tipo_Documento= t.id_TipoDoc)"
        consulta &= "where(p.id_Pasajero < 100) AND p.deleted = 0"
        tabla = BDHelper.ConsultaSQL(consulta)
        Return tabla
    End Function







    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub frm_abmPasajeros_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
        'OTRA(FORMA)
        ''Dim rpta As Integer
        ''rpta = MessageBox.Show("¿Seguro que quiere salir?", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        ''If rpta = 1 Then End Else 
        ''e.Cancel = True

    End Sub

    Private Sub activar_Botones()
        If (Me.editar = estado.insertar) Then
            Me.txt_idPasajero.Enabled = False
            Me.txt_nombrePasajero.Enabled = True
            Me.txt_apellidoPasajero.Enabled = True
            'Me.cbo_tipoDocumento.Enabled = True
            'Me.txt_numeroDocumento.Enabled = True
            Me.cbo_nacionalidad.Enabled = True
            Me.cbo_sexo.Enabled = True
            Me.limpiar_casilleros()
            Me.txt_idPasajero.Focus()
            Me.cmd_guardar.Enabled = True
            Me.cmd_borrar.Enabled = False

        End If

        If (Me.editar = estado.modificar) Then
            Me.txt_idPasajero.Enabled = True
            Me.txt_nombrePasajero.Enabled = True
            Me.txt_apellidoPasajero.Enabled = True
            'Me.cbo_tipoDocumento.Enabled = True
            'Me.txt_numeroDocumento.Enabled = True
            Me.cbo_nacionalidad.Enabled = True
            Me.cbo_sexo.Enabled = True
            Me.limpiar_casilleros()
            Me.txt_idPasajero.Focus()
            Me.cmd_guardar.Enabled = True
            Me.cmd_borrar.Enabled = True
        End If


    End Sub


    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        Me.editar = estado.insertar
        Me.activar_Botones()
        Me.estadobusqueda = busqueda.deshabilitada
        Me.txt_idPasajero.Text = "AUTOMATICO"
        ' Me.txt_idPasajero.Text = Me.ultimo_Valor("select MAX(id_Pasajero) from Pasajeros ") + 1
        Me.txt_idPasajero.Enabled = False
        Me.cargar_grilla(Me.buscar_Tabla())




    End Sub

    Private Sub limpiar_casilleros()
        Me.txt_idPasajero.Text = ""
        Me.txt_nombrePasajero.Text = ""
        Me.txt_apellidoPasajero.Text = ""
        Me.cbo_tipoDocumento.SelectedIndex = -1
        Me.txt_numeroDocumento.Text = ""
        Me.cbo_nacionalidad.SelectedIndex = -1
        Me.cbo_sexo.SelectedIndex = -1

    End Sub

    Private Sub preparar_Busqueda()
        limpiar_casilleros()
        Me.cmd_guardar.Enabled = False
        Me.cmd_borrar.Enabled = False
        Me.cmd_nuevo.Enabled = True
        Me.txt_nombrePasajero.Enabled = False
        Me.txt_apellidoPasajero.Enabled = False
        Me.cbo_sexo.Enabled = False
        Me.cbo_nacionalidad.Enabled = False
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

    Private Sub validar_carga_textual(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombrePasajero.KeyPress, txt_apellidoPasajero.KeyPress

        If (IsNumeric(e.KeyChar) = True Or Asc(e.KeyChar) = 59) Then
            'MsgBox("No debe ingresar caracteres numericos ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub


    Public Function validar_datos() As validacion
        If (Me.txt_idPasajero.Text = "") Then
            MessageBox.Show("La casilla Id Pasajero no puede quedar vacia ", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_idPasajero.Focus()
            Return validacion.negativa
        End If

        If (Me.txt_nombrePasajero.Text = "") Then
            MessageBox.Show("Las casilla nombre no puede quedar vacia ", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_nombrePasajero.Focus()
            Return validacion.negativa
        End If

        If (Me.txt_apellidoPasajero.Text = "") Then
            MessageBox.Show("La casilla apellido no puede quedar vacia ", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_apellidoPasajero.Focus()
            Return validacion.negativa
        End If
        If (Me.cbo_tipoDocumento.SelectedIndex = -1) Then
            MessageBox.Show("Debe seleccionar un tipo de documento ", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cbo_tipoDocumento.Focus()
            Return validacion.negativa
        End If
        If (Me.txt_numeroDocumento.Text = "") Then
            MessageBox.Show("La casilla numero documento no puede quedar vacia ", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_numeroDocumento.Focus()
            Return validacion.negativa
        End If
        If (Me.cbo_nacionalidad.SelectedIndex = -1) Then
            MessageBox.Show("Debe seleccionar un tipo de documento ", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cbo_nacionalidad.Focus()
            Return validacion.negativa
        End If
        If (Me.cbo_sexo.SelectedIndex = -1) Then
            MessageBox.Show("Debe seleccionar un tipo de documento ", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cbo_sexo.Focus()
            Return validacion.negativa
        End If
        Return validacion.positiva
        'VALIDACION EN METODO VALIDAR
        'Private Sub validarCargaTextual(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nombrePasajero.Validated, txt_apellidoPasajero.Validated
        '    If (sender.Text = "") Then
        '        MessageBox.Show("Las casillas NO debe quedar vacia ", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        sender.Focus()
        '    End If
        'End Sub
        'VALIDACION EN METODO VALIDAR
        'Private Sub validarCargaCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_tipoDocumento.SelectedIndexChanged, cbo_nacionalidad.SelectedIndexChanged, cbo_sexo.SelectedIndexChanged
        '    If (sender.selectedIndex = -1) Then
        '        MessageBox.Show("Las casillas NO debe quedar sin seleccionar ", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        sender.Focus()
        '    End If
        'End Sub

    End Function

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If Me.validar_datos() = validacion.positiva Then
            'If (Me.buscar_en_grilla(Me.txt_idPasajero.Text) = False) Then
            '    Me.agregar_grilla(Me.txt_idPasajero.Text, Me.txt_nombrePasajero.Text, Me.txt_apellidoPasajero.Text, Me.cbo_tipoDocumento.SelectedItem, Me.txt_numeroDocumento.Text, Me.cbo_nacionalidad.SelectedItem, Me.cbo_sexo.SelectedItem)

            If (Me.editar = estado.insertar) Then
                Me.txt_idPasajero.Text = Me.ultimo_Valor("select MAX(id_Pasajero) from Pasajeros ") + 1
                If Me.validar_existencia() = validacion.negativa Then
                    If (Me.insertar() = conexion.correcta) Then
                        MessageBox.Show("Se grabó exitosamente", "Importante", _
                       MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("Hubo un error al conectarse con la base de datos", "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If


                    Me.editar = estado.insertar
                Else
                    MessageBox.Show("Ya existeuna persona con ese número de documento ", "Importante", MessageBoxButtons.OK)
                    Exit Sub
                End If

            Else
                If (Me.modificar(Me.txt_idPasajero.Text) = conexion.correcta) Then
                    MessageBox.Show("Se modificó exitosamente", "Importante", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("Hubo un error al conectarse con la base de datos", "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

                Me.editar = estado.insertar

            End If



            limpiar_casilleros()
            Me.txt_idPasajero.Text = "AUTOMATICO"
            Me.txt_idPasajero.Enabled = False
            Me.cmd_borrar.Enabled = False
            Me.cargar_grilla(Me.buscar_Tabla())

        End If
    End Sub


    Private Sub grd_pasajeros_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_pasajeros.CellDoubleClick
        If (e.RowIndex = -1) Then
            Exit Sub
        End If

        Me.estadobusqueda = busqueda.deshabilitada

        Dim row As DataGridViewRow = grd_pasajeros.Rows(e.RowIndex)
       
        Me.editar = estado.modificar
        Me.activar_Botones()

        Me.txt_idPasajero.Text = row.Cells(0).Value
        Me.txt_nombrePasajero.Text = row.Cells(1).Value
        Me.txt_apellidoPasajero.Text = row.Cells(2).Value
        Me.cbo_tipoDocumento.SelectedValue = row.Cells(7).Value
        Me.txt_numeroDocumento.Text = row.Cells(4).Value
        Me.cbo_nacionalidad.SelectedValue = row.Cells(9).Value
        Me.cbo_sexo.SelectedValue = row.Cells(8).Value

        Me.txt_idPasajero.Enabled = False


    End Sub


    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click

        If (Me.estadobusqueda = busqueda.deshabilitada) Then
            Me.txt_idPasajero.Enabled = True
            Me.estadobusqueda = busqueda.habilitada
            Me.preparar_Busqueda()

            'limpiar_casilleros()
        ElseIf (Me.estadobusqueda = busqueda.habilitada) Then

            If (Me.txt_idPasajero.Text = "" And Me.cbo_tipoDocumento.SelectedIndex = -1 And Me.txt_numeroDocumento.Text = "") Then
                MessageBox.Show("Por favor ingrese algun criterio de busqueda", "Error en la busqueda", MessageBoxButtons.OK)
                Exit Sub
            End If


            Dim tabla As New Data.DataTable
            Dim consulta As String



            If (Me.txt_idPasajero.Text <> "") Then
                consulta = "select p.id_Pasajero AS 'Id Pasajero', p.nombre_Pasajero AS 'Nombre', p.apellido_Pasajero AS 'Apellido', t.descripcion AS 'Tipo Doc', p.numero_Documento AS 'Documento' , pa.descripcion AS 'Nacionalidad',s.descripcion AS 'Sexo',p.tipo_documento, p.sexo,p.nacionalidad"
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
                    consulta = "select p.id_Pasajero AS 'Id Pasajero', p.nombre_Pasajero AS 'Nombre', p.apellido_Pasajero AS 'Apellido', t.descripcion AS 'Tipo Doc', p.numero_Documento AS 'Documento' , pa.descripcion AS 'Nacionalidad',s.descripcion AS 'Sexo',p.tipo_documento, p.sexo,p.nacionalidad"
                    consulta &= " from Pasajeros p join Sexo s ON (p.sexo = s.id_sexo ) join Pais pa ON (p.nacionalidad = pa.id_Pais )join Tipo_Documento t ON (p.tipo_Documento= t.id_TipoDoc)"
                    consulta &= "AND p.tipo_Documento Like '" & Me.cbo_tipoDocumento.SelectedIndex & "'"
                    consulta &= " AND p.deleted = 0 "
                    If (Me.txt_numeroDocumento.Text <> "") Then
                        consulta &= " AND p.numero_Documento Like '" & Me.txt_numeroDocumento.Text & "'"
                    End If
                Else
                    If (Me.txt_numeroDocumento.Text <> "") Then
                        consulta = "select p.id_Pasajero AS 'Id Pasajero', p.nombre_Pasajero AS 'Nombre', p.apellido_Pasajero AS 'Apellido', t.descripcion AS 'Tipo Doc', p.numero_Documento AS 'Documento' , pa.descripcion AS 'Nacionalidad',s.descripcion AS 'Sexo',p.tipo_documento, p.sexo,p.nacionalidad"
                        consulta &= " from Pasajeros p join Sexo s ON (p.sexo = s.id_sexo ) join Pais pa ON (p.nacionalidad = pa.id_Pais )join Tipo_Documento t ON (p.tipo_Documento= t.id_TipoDoc)"
                        consulta &= " AND p.numero_Documento Like '" & Me.txt_numeroDocumento.Text & "'"
                        consulta &= " AND p.deleted = 0 "
                    End If
                End If
            End If

            tabla = BDHelper.ConsultaSQL(consulta)

            If (tabla.Rows.Count <> 0) Then
                Me.cargar_grilla(tabla)
                'Me.limpiar_casilleros()
            Else
                MessageBox.Show("La busqueda no tuvo exito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        End If
    End Sub

    Private Sub frm_abmPasajeros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.llenar_combo(Me.cbo_tipoDocumento, "Tipo_Documento", "id_TipoDoc", "descripcion")
        Me.llenar_combo(Me.cbo_sexo, "Sexo", "id_Sexo", "descripcion")
        Me.llenar_combo(Me.cbo_nacionalidad, "Pais", "id_Pais", "descripcion")
        'Me.carga_grilla(Me.leo_tabla("Pasajeros"))
        Me.cargar_grilla(Me.buscar_Tabla())


    End Sub

    Private Sub cargar_grilla(ByVal tabla As Data.DataTable)
        Me.grd_pasajeros.DataSource = tabla
        Me.grd_pasajeros.Columns(7).Visible = False
        Me.grd_pasajeros.Columns(8).Visible = False
        Me.grd_pasajeros.Columns(9).Visible = False
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

    Private Function validar_existencia() As validacion
       
        Dim consulta As String = ""
        Dim tc As New Data.DataTable

        consulta = "select * from Pasajeros where id_Pasajero = " & Me.txt_idPasajero.Text & " AND deleted = 0"
        tc = BDHelper.ConsultaSQL(consulta)
        If tc.Rows.Count() = 1 Then
            Return validacion.positiva
        Else
            Return validacion.negativa
        End If

    End Function

    Private Function insertar() As conexion
        Dim estadoconexion As conexion

        Dim consulta As String = ""

      
        consulta = "INSERT INTO Pasajeros (id_Pasajero, nombre_Pasajero, apellido_Pasajero, tipo_Documento, numero_Documento, nacionalidad, sexo, deleted)"
        consulta += " VALUES(" & Me.txt_idPasajero.Text & ",'" & Me.txt_nombrePasajero.Text & "','" & Me.txt_apellidoPasajero.Text & "'," & Me.cbo_tipoDocumento.SelectedValue
        consulta += "," & Me.txt_numeroDocumento.Text & "," & Me.cbo_nacionalidad.SelectedValue & "," & Me.cbo_sexo.SelectedValue & ",0)"




        Try
            BDHelper.EjecutarSQL(consulta)
            estadoconexion = conexion.correcta

        Catch ex As Exception
            estadoconexion = conexion.incorrecta
        End Try
        Return estadoconexion


        
    End Function

    Private Function modificar(ByVal valor As Integer) As conexion
        Dim estadoconexion As conexion
       
        Dim consulta As String = ""

       

        consulta = "update Pasajeros "

        consulta &= "set  id_Pasajero = " & Me.txt_idPasajero.Text
        consulta &= ", nombre_Pasajero = '" & Me.txt_nombrePasajero.Text & "'"
        consulta &= ", apellido_Pasajero = '" & Me.txt_apellidoPasajero.Text & "'"
        consulta &= ", tipo_Documento = " & Me.cbo_tipoDocumento.SelectedValue
        consulta &= ", numero_Documento = " & Me.txt_numeroDocumento.Text
        consulta &= ", nacionalidad = " & Me.cbo_nacionalidad.SelectedValue
        consulta &= ", sexo = " & Me.cbo_sexo.SelectedValue

        consulta &= " where id_Pasajero = " & valor
        consulta &= " and deleted = 0"

        Try
            BDHelper.EjecutarSQL(consulta)
            estadoconexion = conexion.correcta

        Catch ex As Exception
            estadoconexion = conexion.incorrecta
        End Try
        Return estadoconexion

       
    End Function

    Private Sub desactivar_botones()
        Me.txt_nombrePasajero.Enabled = False
        Me.txt_apellidoPasajero.Enabled = False
        Me.txt_idPasajero.Enabled = True
        'Me.cbo_tipoDocumento.Enabled = True
        'Me.txt_numeroDocumento.Enabled = True
        Me.cbo_nacionalidad.Enabled = False
        Me.cbo_sexo.Enabled = False
        Me.limpiar_casilleros()
        Me.txt_idPasajero.Focus()
        Me.cmd_guardar.Enabled = False
        'Me.cmd_borrar.Enabled = True
        Me.editar = estado.insertar
    End Sub


    Private Sub cmd_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_borrar.Click
        Me.borrar()
        Me.editar = estado.insertar
        
        Me.estadobusqueda = busqueda.habilitada
        limpiar_casilleros()
        Me.preparar_Busqueda()
        Me.cargar_grilla(Me.buscar_Tabla())
    End Sub

    Private Sub borrar()
       

        Dim consulta As String = ""

        consulta = "UPDATE Pasajeros"
        consulta &= " set deleted = 1"
        consulta &= " WHERE(id_Pasajero = " & Me.txt_idPasajero.Text & ")"
        Try
            BDHelper.EjecutarSQL(consulta)
            MessageBox.Show("Se borró exitosamente", "Importante", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("No se pudo realizar la operacion", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub

    Private Sub cmd_buscar_ContextMenuChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_buscar.ContextMenuChanged

    End Sub

  

   


    Private Sub cmd_buscar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmd_buscar.MouseDown
        If e.Clicks = 2 Then
            cbo_tipoDocumento.SelectedIndex = -1
        End If
    End Sub

End Class


