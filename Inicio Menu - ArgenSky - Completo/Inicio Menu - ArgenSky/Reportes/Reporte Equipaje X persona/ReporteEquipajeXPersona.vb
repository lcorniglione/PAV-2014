Public Class ReporteEquipajeXPersona

    Private Sub crv_Equipaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crv_Equipaje.Load
        llenar_combo(cbo_vuelo, "Vuelos", "id_Vuelo", "id_Vuelo")

    End Sub

    Private Sub btn_generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar.Click

        If cbo_vuelo.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un vuelo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim reporte As New crv_EquipajeXPersona

        Dim consulta As String

        Dim tabla As New Data.DataTable

        consulta = "SELECT Equipaje.id_Pasajero, Equipaje.peso, Equipaje.bodega, Equipaje.especial, Equipaje.cant_bultos, Pasajeros.nombre_Pasajero, Pasajeros.apellido_Pasajero, Pasajeros.numero_Documento"
        consulta &= " FROM Equipaje INNER JOIN Pasajeros ON Equipaje.id_Pasajero = Pasajeros.id_Pasajero "
        'consulta &= " "
        'consulta &= " "

        If cbo_Pasajero.SelectedIndex <> -1 Then
            consulta &= "WHERE Equipaje.id_Vuelo =" & cbo_vuelo.SelectedIndex
        End If


        tabla = BDHelper.ConsultaSQL(consulta)

        If (tabla.Rows.Count = 0) Then
            MessageBox.Show("No existen Equipajes para los pasajeros en ese vuelo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        reporte.SetDataSource(tabla)


        Me.crv_Equipaje.ReportSource = reporte

        Me.crv_Equipaje.Show()

        Me.crv_Equipaje.Refresh()
    End Sub

    Private Sub llenar_combo(ByVal cbo As ComboBox, ByVal n_tabla As String, ByVal id_tabla As String, ByVal display_tabla As String)
        Dim table As New Data.DataTable
        Dim consulta As String

        consulta = "SELECT " & id_tabla & "," & display_tabla & " FROM " & n_tabla & " where deleted = 0"
        table = BDHelper.ConsultaSQL(consulta)

        cbo.DataSource = table
        cbo.DisplayMember = display_tabla
        cbo.ValueMember = id_tabla
        cbo.SelectedIndex = -1
    End Sub


    Private Sub llenar_combo1(ByVal cbo As ComboBox, ByVal n_tabla As String, ByVal id_tabla As String, ByVal display_tabla As String)
        Dim table As New Data.DataTable
        Dim consulta As String

        ' consulta = "SELECT " & id_tabla & "," & display_tabla & " FROM " & n_tabla & " where deleted = 0 AND id_Vuelo=" & cbo_vuelo.SelectedValue
        Dim C As String = cbo_vuelo.SelectedIndex
        consulta = "SELECT " & id_tabla & "," & display_tabla & " FROM " & n_tabla & " where deleted = 0 AND id_Vuelo=" & cbo_vuelo.SelectedIndex
        table = BDHelper.ConsultaSQL(consulta)


        cbo.DataSource = table
        cbo.DisplayMember = display_tabla
        cbo.ValueMember = id_tabla
        cbo.SelectedIndex = -1
    End Sub

   
    Private Sub cbo_vuelo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_vuelo.SelectedIndexChanged

        If cbo_vuelo.SelectedIndex <> -1 Then
            llenar_combo1(cbo_Pasajero, "Tarjeta_Embarque", "id_Pasajero", "id_Pasajero")
        End If


    End Sub

    Private Sub ReporteEquipajeXPersona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class