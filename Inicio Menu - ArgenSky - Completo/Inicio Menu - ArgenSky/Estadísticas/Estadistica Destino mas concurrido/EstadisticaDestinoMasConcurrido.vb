Public Class EstadisticaDestinoMasConcurrido

    Private Sub Estadistica_DestinoMasConcurrido_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Estadistica_DestinoMasConcurrido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generar_Reporte()
    End Sub

    Private Sub generar_Reporte()
        Dim reporte As New estadisticaDMC

        Dim consulta As String

        Dim tabla As New Data.DataTable

        consulta = "SELECT v.id_Vuelo AS 'id_Vuelo', p.descripcion AS 'Provincia' "
        consulta &= " FROM Aeropuertos AS a INNER JOIN"
        consulta &= " Localidad AS l ON a.localidad = l.id_Localidad INNER JOIN"
        consulta &= " Provincia AS p ON l.provincia = p.id_Provincia INNER JOIN"
        consulta &= " Vuelos AS v ON a.id_Aeropuerto = v.aeropuerto_Destino"

        tabla = BDHelper.ConsultaSQL(consulta)

        If (tabla.Rows.Count = 0) Then
            MessageBox.Show("No se han podido recuperar los datos de la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        reporte.SetDataSource(tabla)


        Me.CrystalReportViewer1.ReportSource = reporte

        Me.CrystalReportViewer1.Show()

        Me.CrystalReportViewer1.Refresh()
    End Sub

End Class