Public Class frm_tarjeta

    Enum pasajero
        encontrado
        noencontrado
    End Enum

    Dim estadopasajero As pasajero = pasajero.noencontrado
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim consulta As String
        Dim tabla As Data.DataTable

        If Me.txt_numeroPasaje.Text = "" Or Me.txt_numeroVuelo.Text = "" Then
            MessageBox.Show("Debe ingresar un numero de pasajero y un numero de vuelo", "Aviso", MessageBoxButtons.OK)
            Exit Sub
        End If


        'If IsNumeric(Me.txt_numeroPasaje.Text) = False Or IsNothing(Me.txt_numeroVuelo.Text) = False Then
        '    MessageBox.Show("Por favor no ingrese caracteres alfanumericos en los campos: 'Numero de pasaje' y 'Numero de vuelo'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If



        consulta = "SELECt Pasaje.id_Pasajero, Pasaje.id_Vuelo, Pasajeros.nombre_Pasajero, Pasajeros.apellido_Pasajero, Pasajeros.numero_Documento FROM Pasaje INNER JOIN Pasajeros ON Pasaje.id_Pasajero = Pasajeros.id_Pasajero"
        tabla = BDHelper.ConsultaSQL(consulta)

        txt_apellido.Text = tabla.Rows(0)(3)
        txt_idPasajero.Text = tabla.Rows(0)(0)
        txt_nombre.Text = tabla.Rows(0)(2)
        txt_numeroDoc.Text = tabla.Rows(0)(4)

        txt_idPasajero.Enabled = False
        estadopasajero = pasajero.encontrado

    End Sub

   
    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        If (estadopasajero = pasajero.noencontrado) Then
            MessageBox.Show(" Ingrese un pasajero válido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            txt_numeroPasaje.Focus()
            Exit Sub
        End If

        Dim consulta As String
        Dim tabla As Data.DataTable
        Dim peso As Double
        Dim capacidad As Double
        Dim ppc As Double
        Dim row As Data.DataRow
        consulta = "SELECT Aeronaves.equipaje_PesoMax, Aeronaves.cant_Pasaj_Economy + Aeronaves.cant_Pasaj_Premium AS Expr1 FROM Aeronaves INNER JOIN Vuelos ON Aeronaves.id_Aeronave = Vuelos.id_Aeronave WHERE Vuelos.id_Vuelo = " & txt_numeroVuelo.Text

        tabla = BDHelper.ConsultaSQL(consulta)
        peso = tabla.Rows(0)(0)
        capacidad = tabla.Rows(0)(1)
        ppc = peso / capacidad


        If Me.txt_peso.Text > ppc Then
            MessageBox.Show("Ha superado el limite de peso de equipaje para esa aeronave. PESO MAX: " & ppc, "Aviso", MessageBoxButtons.OK)
            Exit Sub
        End If


        If Me.txt_cantbultos.Text = "" Or IsNumeric(txt_cantbultos.Text) = False Or txt_cantbultos.Text <= 0 Then
            MessageBox.Show("Asigne una cantidad de bultos válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        GroupBox2.Enabled = False



    End Sub

    Private Sub frm_tarjeta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub frm_tarjeta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.rdb_AeNo.Checked = True
        Me.rdb_bodegaNo.Checked = True
        Me.rdb_especialNo.Checked = True
        GroupBox2.Enabled = False

    End Sub


    Private Sub btn_agregarEquipaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregarEquipaje.Click
        GroupBox2.Enabled = True
    End Sub

  
    Private Sub btn_generarTarjeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generarTarjeta.Click
        If (estadopasajero = pasajero.noencontrado) Then
            MessageBox.Show(" Ingrese un pasajero válido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim MyTran As Data.SqlClient.SqlTransaction
        Dim cnn As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim consulta As String
        Dim tabla As Data.DataTable
        Dim cantidad As Integer

        Dim ae As Integer
        Dim bodega As Integer
        Dim especial As Integer
        Dim CnString As String = "workstation id=ArgenSky.mssql.somee.com;packet size=4096;user id=adminargensky;pwd=pav.2014;data source=ArgenSky.mssql.somee.com;persist security info=False;initial catalog=ArgenSky"

        cnn.ConnectionString = CnString
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        MyTran = cnn.BeginTransaction
        cmd.Transaction = MyTran
        Try

            If (rdb_AeSI.Checked = True) Then
                ae = 1
            Else
                ae = 0
            End If

            If (rdb_bodegaSI.Checked = True) Then
                bodega = 1
            Else
                bodega = 0
            End If

            If (rdb_especialSi.Checked = True) Then
                especial = 1
            Else
                especial = 0
            End If

            Dim idAeronave As Integer
            consulta = " SELECT id_Aeronave FROM Vuelos where  id_Vuelo = " & txt_numeroVuelo.Text
            tabla = BDHelper.ConsultaSQL(consulta)
            idAeronave = tabla.Rows(0)(0)
            consulta = ""
            consulta = "SELECT COUNT(id_Pasajero) AS 'Cantidad' FROM Tarjeta_Embarque WHERE id_Vuelo = " & txt_numeroVuelo.Text
            tabla = BDHelper.ConsultaSQL(consulta)
            cantidad = tabla.Rows(0)(0) + 1
            txt_numAsiento.Text = cantidad
            consulta = ""
            consulta = "INSERT INTO Tarjeta_Embarque (id_Pasajero, id_Vuelo, atencion_Especial, numero_Asiento, letra_Asiento, id_Aeronave, deleted) "
            consulta &= "VALUES (" & Me.txt_idPasajero.Text & ", " & txt_numeroVuelo.Text & ", " & ae & ", " & txt_numAsiento.Text & ", 'A'," & idAeronave & ", 0)"
            BDHelper.EjecutarSQL(consulta)
            consulta = ""
            consulta = "INSERT INTO Equipaje (id_Pasajero, id_Vuelo, peso, bodega, especial, cant_bultos, deleted) VALUES(" & txt_idPasajero.Text & "," & txt_numeroVuelo.Text & "," & txt_peso.Text & "," & bodega & "," & especial & "," & txt_cantbultos.Text & ", 0)"
            BDHelper.EjecutarSQL(consulta)

            MyTran.Commit()

            MessageBox.Show("Los datos fueron registrados exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MyTran.Rollback()
            MessageBox.Show("Los datos no fueron registrados exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btn_nuevatarjeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevatarjeta.Click
        txt_numeroPasaje.Clear()
        txt_numeroVuelo.Clear()
        txt_idPasajero.Clear()
        txt_nombre.Clear()
        txt_apellido.Clear()
        txt_numeroDoc.Clear()
        rdb_AeNo.Checked = True
        'txt_numAsiento.Clear()
        txt_peso.Clear()
        rdb_bodegaNo.Checked = True
        txt_cantbultos.Clear()
        rdb_especialNo.Checked = True

    End Sub

   
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class