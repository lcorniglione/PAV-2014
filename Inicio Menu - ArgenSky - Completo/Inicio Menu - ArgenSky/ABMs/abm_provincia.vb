Public Class AMB_provincia
    Dim editar As estado = estado.insertar
    Dim estadobusqueda As busqueda = busqueda.habilitada
    Private Const conexionSTR As String = "workstation id=ArgenSky.mssql.somee.com;packet size=4096;user id=adminargensky;pwd=pav.2014;data source=ArgenSky.mssql.somee.com;persist security info=False;initial catalog=ArgenSky"
    Enum validacion
        positiva
        negativa
    End Enum
    Enum estado
        modificar
        insertar
        buscar
    End Enum
    Enum conexion
        correcta
        incorrecta
    End Enum
    Enum busqueda
        habilitada
        deshabilitada
    End Enum




    Private Sub AMB_provincia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btn_nuevo.Enabled = True
        Me.btn_guardar.Enabled = False
        Me.btn_buscar.Enabled = True
        Me.btn_salir.Enabled = True
        Me.btn_borrar.Enabled = False
        Me.cargar_grilla(Me.leo_tabla("Provincia", "id_Provincia"))
    End Sub

    Private Function validar_datos() As validacion

        'If IsNumeric(Me.txt_id.Text) = False Then
        '    MessageBox.Show("El id debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Return validacion.negativa
        'End If


        If txt_descripcion.Text = "" Then
            MessageBox.Show("Debe ingresar un descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return validacion.negativa
        End If


        If IsNumeric(Me.txt_descripcion.Text) = True Then
            MessageBox.Show("La descripcion no puede ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return validacion.negativa
        End If


        If Me.txt_id.Text = "" Then
            MessageBox.Show("Debe ingresar un id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If

        Return validacion.positiva


    End Function

    Private Function validar_existencia() As validacion
       
        Dim table As New Data.DataTable
        Dim consulta As String
       
        consulta = "SELECT * from Provincia WHERE id_Provincia = " & Me.txt_id.Text
        table = BDHelper.ConsultaSQL(consulta)
        If table.Rows.Count >= 1 Then
            Return validacion.positiva
        Else
            Return validacion.negativa
        End If

    End Function

    Private Function insertar()
        Dim estadoconexion As conexion

        Dim consulta As String = ""


        consulta = "INSERT INTO Provincia (id_Provincia, descripcion, deleted)"
        consulta += " VALUES(" & Me.txt_id.Text & ",'" & Me.txt_descripcion.Text & "',0)"



        Try
            BDHelper.EjecutarSQL(consulta)
            estadoconexion = conexion.correcta

        Catch ex As Exception
            estadoconexion = conexion.incorrecta
        End Try
        Return estadoconexion

    End Function

    Private Function modificar(ByVal p1 As String) As conexion
        Dim estadoconexion As conexion
        Dim consulta As String = ""


        consulta = "update Provincia "

        consulta &= "set id_Provincia =" & Me.txt_id.Text
        consulta &= ", descripcion =" & Me.txt_descripcion.Text
        consulta &= "WHERE id_Provincia =" & p1
        Try
            BDHelper.EjecutarSQL(consulta)
            estadoconexion = conexion.correcta
        Catch ex As Exception
            estadoconexion = conexion.incorrecta
        End Try
        Return estadoconexion
    End Function


    Private Function leo_tabla(ByVal nombre_tabla As String, ByVal pk_tabla As String) As Data.DataTable
        Dim sqlString As String
        Dim tabla As Data.DataTable
        sqlString = "select * from " & nombre_tabla
        sqlString += " where " & pk_tabla & " < 100 AND deleted = 0"

        tabla = BDHelper.ConsultaSQL(sqlString)

        Return tabla
    End Function

    Private Sub cargar_grilla(ByVal tabla As Data.DataTable)
        dgv_provincias.Rows.Clear()
        Dim descripcion As String = ""
        Dim idprovincia As String = ""
        'Me.grd_cargos.DataSource = tabla
        For Each row In tabla.Rows
            idprovincia = row("id_Provincia")
            descripcion = row("descripcion")
            dgv_provincias.Rows.Add((New Object() {idprovincia, descripcion}))
        Next row
    End Sub

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub


    Private Sub abm_provincia_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
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

    Private Sub limpiar_casilleros()
        Me.txt_id.Text = ""
        Me.txt_descripcion.Text = ""
    End Sub



    Private Sub dgv_provincia_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_provincias.CellDoubleClick
        If (e.RowIndex = -1) Then
            Exit Sub
        End If

        Me.estadobusqueda = busqueda.deshabilitada

        Dim row As DataGridViewRow = dgv_provincias.Rows(e.RowIndex)

        Me.editar = estado.modificar
        Me.activar_Botones()

        Me.txt_id.Text = row.Cells(0).Value
        Me.txt_descripcion.Text = row.Cells(1).Value

        Me.txt_id.Enabled = False




    End Sub

    Private Sub activar_Botones()
        If (Me.editar = estado.insertar) Then
            Me.txt_id.Enabled = False
            Me.txt_descripcion.Enabled = True
            Me.limpiar_casilleros()
            Me.txt_id.Focus()
            Me.btn_guardar.Enabled = True
            Me.btn_borrar.Enabled = False

        End If

        If (Me.editar = estado.modificar) Then
            Me.txt_id.Enabled = True
            Me.txt_descripcion.Enabled = True
            Me.limpiar_casilleros()
            Me.txt_id.Focus()
            Me.btn_guardar.Enabled = True
            Me.btn_borrar.Enabled = True
        End If

    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        Me.editar = estado.insertar
        Me.activar_Botones()
        Me.estadobusqueda = busqueda.deshabilitada
        Me.txt_id.Text = "AUTOMATICO"
        Me.txt_id.Enabled = False
        Me.cargar_grilla(Me.leo_tabla("Provincia", "id_Provincia"))
    End Sub

    Private Sub cmd_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar.Click
        Me.borrar()
        Me.editar = estado.insertar
        MessageBox.Show("Se borró exitosamente", "Importante", _
       MessageBoxButtons.OK)
        Me.estadobusqueda = busqueda.habilitada
        limpiar_casilleros()
        Me.preparar_Busqueda()
        Me.cargar_grilla(Me.leo_tabla("Provincia", "id_Provincia"))
    End Sub

    Private Sub preparar_Busqueda()
        limpiar_casilleros()
        Me.btn_guardar.Enabled = False
        Me.btn_borrar.Enabled = False
        Me.btn_nuevo.Enabled = True
        Me.txt_id.Enabled = True
        Me.txt_descripcion.Enabled = True

    End Sub

    Private Sub borrar()
        Dim consulta As String = ""

        consulta = "update Provincia "
        consulta &= "set  deleted =  1"
        consulta &= " where id_Provincia = " & Me.txt_id.Text
        BDHelper.EjecutarSQL(consulta)

    End Sub


    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click

        If (Me.estadobusqueda = busqueda.deshabilitada) Then
            Me.txt_id.Enabled = True

            Me.estadobusqueda = busqueda.habilitada
            Me.preparar_Busqueda()


        ElseIf (Me.estadobusqueda = busqueda.habilitada) Then

            If (Me.txt_id.Text = "" And Me.txt_descripcion.Text = "") Then
                MessageBox.Show("Por favor ingrese algun criterio de busqueda", "Error en la busqueda", MessageBoxButtons.OK)
                Exit Sub
            End If


            Dim consulta As String = ""
            Dim tabla As Data.DataTable



            If (Me.txt_id.Text <> "") Then
                consulta = "select * from Provincia"
                consulta &= " where id_Provincia Like '" & Me.txt_id.Text & "'"

                If (Me.txt_descripcion.Text <> "") Then
                    consulta &= " AND descripcion Like '" & Me.txt_descripcion.Text & "'"
                End If
            Else
                If (Me.txt_descripcion.Text <> "") Then
                    consulta = "select * from Provincia"
                    consulta &= " where descripcion Like '" & Me.txt_descripcion.Text & "'"
                End If
            End If

            consulta &= " AND deleted = 0"



            tabla = BDHelper.ConsultaSQL(consulta)
            If (tabla.Rows.Count <> 0) Then
                Me.cargar_grilla(tabla)
                'Me.limpiar_casilleros()
            Else
                MessageBox.Show("La busqueda no tuvo exito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub



    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If Me.validar_datos() = validacion.positiva Then
            'If (Me.buscar_en_grilla(Me.txt_idPasajero.Text) = False) Then
            '    Me.agregar_grilla(Me.txt_idPasajero.Text, Me.txt_nombrePasajero.Text, Me.txt_apellidoPasajero.Text, Me.cbo_tipoDocumento.SelectedItem, Me.txt_numeroDocumento.Text, Me.cbo_nacionalidad.SelectedItem, Me.cbo_sexo.SelectedItem)

            If (Me.editar = estado.insertar) Then

                Me.txt_id.Text = Me.ultimo_Valor("select MAX (id_Provincia) from Provincia") + 1
                If Me.validar_existencia() = validacion.negativa Then

                    If (Me.insertar() = conexion.correcta) Then
                        Me.editar = estado.insertar
                        MessageBox.Show("Se grabó exitosamente", "Importante", _
                       MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("Hubo un error al conectarse con la base de datos", "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                Else
                    MessageBox.Show("Ya existe una provincia con ese número de ID ", "Importante", MessageBoxButtons.OK)
                    Exit Sub
                End If

            Else

                If (Me.modificar(Me.txt_id.Text)) = conexion.correcta Then
                    MessageBox.Show("Se modificó exitosamente", "Importante", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("Hubo un error al conectarse con la base de datos", "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
                Me.editar = estado.insertar

            End If



            limpiar_casilleros()

            Me.txt_id.Text = "AUTOMATICO"

            Me.txt_id.Enabled = False
            Me.cargar_grilla(Me.leo_tabla("Provincia", "id_Provincia"))

        End If
    End Sub

End Class








