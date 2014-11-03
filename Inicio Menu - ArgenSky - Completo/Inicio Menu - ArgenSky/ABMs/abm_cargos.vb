Public Class abm_cargos

    Dim string_conexion As String
    '= "Provider=SQLOLEDB;Data Source=NICOSAM-PC;Integrated Security=SSPI;Initial Catalog=ArgenSky"
    Enum busqueda
        habilitada
        deshabilitada
    End Enum
    Enum estado
        modificar
        insertar
        buscar
    End Enum
    Enum validacion
        positiva
        negativa
    End Enum
    Enum conexion
        correcta
        incorrecta
    End Enum

    Dim editar As estado = estado.insertar
    Dim estadobusqueda As busqueda = busqueda.habilitada
    'Funcion para buscar una tabla con sus columnas correspondientes.
    Private Function leo_tabla(ByVal nombre_tabla As String, ByVal pk_tabla As String) As Data.DataTable
        Dim sqlString As String
        Dim tabla As Data.DataTable
        sqlString = "select * from " & nombre_tabla
        sqlString += " where " & pk_tabla & " < 100 AND deleted = 0"

        tabla = BDHelper.ConsultaSQL(sqlString)

        Return tabla
    End Function

    Private Function insertar() As conexion
        Dim estadoconexion As conexion

        Dim consulta As String = ""


        consulta = "INSERT INTO Cargo (id_Cargo, descripcion, deleted)"
        consulta += " VALUES(" & Me.txt_idCargo.Text & ",'" & Me.txt_descripcionCargo.Text & "',0)"



        Try
            BDHelper.EjecutarSQL(consulta)
            estadoconexion = conexion.correcta

        Catch ex As Exception
            estadoconexion = conexion.incorrecta
        End Try
        Return estadoconexion
    End Function

    Private Sub abm_cargos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargar_grilla(Me.leo_tabla("Cargo", "id_Cargo"))
    End Sub

    Private Sub cargar_grilla(ByVal tabla As Data.DataTable)
        grd_cargos.Rows.Clear()
        Dim descripcion As String = ""
        Dim idcargo As String = ""
        'Me.grd_cargos.DataSource = tabla
        For Each row In tabla.Rows
            idcargo = row("id_Cargo")
            descripcion = row("descripcion")
            grd_cargos.Rows.Add((New Object() {idcargo, descripcion}))
        Next row






    End Sub

    Private Function validar_existencia() As validacion

        Dim consulta As String = ""
        Dim tc As New Data.DataTable


        consulta = "select * from Cargo where id_Cargo = " & Me.txt_idCargo.Text
        tc = BDHelper.ConsultaSQL(consulta)

        If tc.Rows.Count() = 1 Then
            Return validacion.positiva
        Else
            Return validacion.negativa
        End If

    End Function

    Private Function modificar(ByVal valor As Integer) As conexion
        Dim estadoconexion As conexion

        Dim consulta As String = ""



        consulta = "update Cargo "
        consulta &= "set  id_Cargo = " & Me.txt_idCargo.Text
        consulta &= ", descripcion = '" & Me.txt_descripcionCargo.Text & "'"
        consulta &= " where id_Cargo = " & valor
        'consulta &= " and deleted = 0"

        Try
            BDHelper.EjecutarSQL(consulta)
            estadoconexion = conexion.correcta

        Catch ex As Exception
            estadoconexion = conexion.incorrecta
        End Try
        Return estadoconexion
    End Function


    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub


    Private Sub abm_cargos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Public Function validar_datos() As validacion
        'If (Me.txt_idCargo.Text = "") Then
        '    MessageBox.Show("La casilla Id Cargo no puede quedar vacia ", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    txt_idCargo.Focus()
        '    Return validacion.negativa
        'End If
        If (Me.txt_descripcionCargo.Text = "") Then
            MessageBox.Show("Las casilla Descripcion no puede quedar vacia ", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_descripcionCargo.Focus()
            Return validacion.negativa
        End If
        Return validacion.positiva

    End Function

    Private Sub limpiar_casilleros()
        Me.txt_idCargo.Text = ""
        Me.txt_descripcionCargo.Text = ""
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

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If Me.validar_datos() = validacion.positiva Then
            'If (Me.buscar_en_grilla(Me.txt_idPasajero.Text) = False) Then
            '    Me.agregar_grilla(Me.txt_idPasajero.Text, Me.txt_nombrePasajero.Text, Me.txt_apellidoPasajero.Text, Me.cbo_tipoDocumento.SelectedItem, Me.txt_numeroDocumento.Text, Me.cbo_nacionalidad.SelectedItem, Me.cbo_sexo.SelectedItem)

            If (Me.editar = estado.insertar) Then

                Me.txt_idCargo.Text = Me.ultimo_Valor("select MAX (id_Cargo) from Cargo") + 1
                If Me.validar_existencia() = validacion.negativa Then

                    If (Me.insertar() = conexion.correcta) Then
                        Me.editar = estado.insertar
                        MessageBox.Show("Se grabó exitosamente", "Importante", _
                       MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("Hubo un error al conectarse con la base de datos", "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                Else
                    MessageBox.Show("Ya existe un cargo con ese número de documento ", "Importante", MessageBoxButtons.OK)
                    Exit Sub
                End If

            Else

                If (Me.modificar(Me.txt_idCargo.Text)) = conexion.correcta Then
                    MessageBox.Show("Se modificó exitosamente", "Importante", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("Hubo un error al conectarse con la base de datos", "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
                Me.editar = estado.insertar

            End If



            limpiar_casilleros()

            Me.txt_idCargo.Text = "AUTOMATICO"

            Me.txt_idCargo.Enabled = False
            Me.cmd_borrar.Enabled = False
            Me.cargar_grilla(Me.leo_tabla("Cargo", "id_Cargo"))

        End If
    End Sub

    Private Sub grd_cargos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_cargos.CellDoubleClick
        If (e.RowIndex = -1) Then
            Exit Sub
        End If

        Me.estadobusqueda = busqueda.deshabilitada

        Dim row As DataGridViewRow = grd_cargos.Rows(e.RowIndex)

        Me.editar = estado.modificar
        Me.activar_Botones()

        Me.txt_idCargo.Text = row.Cells(0).Value
        Me.txt_descripcionCargo.Text = row.Cells(1).Value

        Me.txt_idCargo.Enabled = False




    End Sub

    Private Sub activar_Botones()
        If (Me.editar = estado.insertar) Then
            Me.txt_idCargo.Enabled = False
            Me.txt_descripcionCargo.Enabled = True
            Me.limpiar_casilleros()
            Me.txt_idCargo.Focus()
            Me.cmd_guardar.Enabled = True
            Me.cmd_borrar.Enabled = False

        End If

        If (Me.editar = estado.modificar) Then
            Me.txt_idCargo.Enabled = True
            Me.txt_descripcionCargo.Enabled = True
            Me.limpiar_casilleros()
            Me.txt_idCargo.Focus()
            Me.cmd_guardar.Enabled = True
            Me.cmd_borrar.Enabled = True
        End If
    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        Me.editar = estado.insertar
        Me.activar_Botones()
        Me.estadobusqueda = busqueda.deshabilitada
        Me.txt_idCargo.Text = "AUTOMATICO"
        Me.txt_idCargo.Enabled = False
        Me.cargar_grilla(Me.leo_tabla("Cargo", "id_Cargo"))
    End Sub

    Private Sub validar_carga_numerica(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_idCargo.KeyPress

        Select Case Asc(e.KeyChar)
            Case 4, 24, 19, 127, 13, 9, 15, 14, 8
                Exit Sub
        End Select
        If (IsNumeric(e.KeyChar) = False Or Asc(e.KeyChar) = 59) Then
            'MsgBox("Este carater no es un numero ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub validar_carga_textual(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_descripcionCargo.KeyPress

        If (IsNumeric(e.KeyChar) = True Or Asc(e.KeyChar) = 59) Then
            'MsgBox("No debe ingresar caracteres numericos ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub cmd_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_borrar.Click
        Me.borrar()
        Me.editar = estado.insertar
        
        Me.estadobusqueda = busqueda.habilitada
        limpiar_casilleros()
        Me.preparar_Busqueda()
        Me.cargar_grilla(Me.leo_tabla("Cargo", "id_Cargo"))
    End Sub

    Private Sub preparar_Busqueda()
        limpiar_casilleros()
        Me.cmd_guardar.Enabled = False
        Me.cmd_borrar.Enabled = False
        Me.cmd_nuevo.Enabled = True
        Me.txt_idCargo.Enabled = True
        Me.txt_descripcionCargo.Enabled = True

    End Sub



    Private Sub borrar()
        Dim consulta As String = ""

        consulta = "update Cargo "
        consulta &= "set  deleted =  1"
        consulta &= " where id_Cargo = " & Me.txt_idCargo.Text
        Try
            BDHelper.EjecutarSQL(consulta)
            MessageBox.Show("Se borró exitosamente", "Importante", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("No se pudo realizar la operacion", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub



    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click

        If (Me.estadobusqueda = busqueda.deshabilitada) Then
            Me.txt_idCargo.Enabled = True

            Me.estadobusqueda = busqueda.habilitada
            Me.preparar_Busqueda()


        ElseIf (Me.estadobusqueda = busqueda.habilitada) Then

            If (Me.txt_idCargo.Text = "" And Me.txt_descripcionCargo.Text = "") Then
                MessageBox.Show("Por favor ingrese algun criterio de busqueda", "Error en la busqueda", MessageBoxButtons.OK)
                Exit Sub
            End If


            Dim consulta As String = ""
            Dim tabla As Data.DataTable



            If (Me.txt_idCargo.Text <> "") Then
                consulta = "select * from Cargo"
                consulta &= " where id_Cargo Like '" & Me.txt_idCargo.Text & "'"

                If (Me.txt_descripcionCargo.Text <> "") Then
                    consulta &= " AND descripcion Like '" & Me.txt_descripcionCargo.Text & "'"
                End If
            Else
                If (Me.txt_descripcionCargo.Text <> "") Then
                    consulta = "select * from Cargo"
                    consulta &= " where descripcion Like '" & Me.txt_descripcionCargo.Text & "'"
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


End Class

