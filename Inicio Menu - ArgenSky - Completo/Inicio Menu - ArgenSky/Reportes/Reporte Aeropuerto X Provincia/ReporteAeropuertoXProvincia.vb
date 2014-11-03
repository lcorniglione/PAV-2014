Public Class ReporteAeropuertoXProvincia


    Private Sub btn_filtrarProvincias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrarProvincias.Click
        generar_Reporte()
    End Sub

    Private Sub generar_Reporte()
        Dim reporte As New ReporteAXP

        Dim consulta As String

        Dim tabla As New Data.DataTable

        consulta = "SELECT a.id_Aeropuerto as 'Id Aeropuerto', a.telefono as 'Telefono', a.nombre_aeropuerto as 'Nombre Aeropuerto', l.descripcion as 'Localidad', p.descripcion as 'Provincia' "
        consulta &= " FROM Aeropuertos AS a INNER JOIN "
        consulta &= " Localidad AS l ON a.localidad = l.id_Localidad INNER JOIN"
        consulta &= " Provincia AS p ON l.provincia = p.id_Provincia"
        If (cmb_provincia.SelectedIndex <> -1) Then
            consulta &= " where p.id_Provincia = " & cmb_provincia.SelectedValue
        End If

        tabla = BDHelper.ConsultaSQL(consulta)

        If (tabla.Rows.Count = 0) Then
            MessageBox.Show("No existen Aeropuertos en la provincia seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        reporte.SetDataSource(tabla)


        Me.CrystalReportViewer1.ReportSource = reporte

        Me.CrystalReportViewer1.Show()

        Me.CrystalReportViewer1.Refresh()
    End Sub

    Private Sub Reporte___AeropuertoXProvincia_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Reporte___AeropuertoXProvincia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.llenar_combo(Me.cmb_provincia, "Provincia", "id_Provincia", "descripcion")

    End Sub
    Private Sub llenar_combo(ByVal combo As ComboBox, ByVal tabla As String, ByVal idValue As String, ByVal displayValue As String)

        Dim table As New Data.DataTable

        Dim consulta As String = "SELECT " & idValue & ", " & displayValue & " FROM " & tabla

        table = BDHelper.ConsultaSQL(consulta)
        combo.DataSource = table
        combo.DisplayMember = displayValue
        combo.ValueMember = idValue
        combo.SelectedIndex = -1

    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        cmb_provincia.SelectedIndex = -1
        generar_Reporte()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class