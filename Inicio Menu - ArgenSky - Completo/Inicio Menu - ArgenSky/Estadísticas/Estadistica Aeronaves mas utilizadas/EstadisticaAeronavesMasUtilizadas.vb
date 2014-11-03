Public Class frm_aeronavesMasUtilizadas

    Dim conexion As String = "Data Source=ArgenSky.mssql.somee.com;Persist Security Info=True;User ID=adminargensky;Password=pav.2014"

    
    Private Sub frm_aeronavesMasUtilizadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim reporte As New crv_aeronavesMasUtilizadas

        Dim consulta As String

        Dim tabla As New Data.DataTable

        consulta = "SELECT a.id_Aeronave, m.nombre_Marca, COUNT(v.id_Vuelo) AS 'cantVuelos' FROM Vuelos v JOIN Aeronaves a ON (v.id_Aeronave=a.id_Aeronave) JOIN Marca m ON (a.marca=m.id_Marca) GROUP BY a.id_Aeronave, m.nombre_Marca"
        tabla = BDHelper.ConsultaSQL(consulta)

        If (tabla.Rows.Count = 0) Then
            MessageBox.Show("No se han podido recuperar los datos de la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        reporte.SetDataSource(tabla)


        Me.crv_reporte.ReportSource = reporte

        Me.crv_reporte.Show()

        Me.crv_reporte.Refresh()

    End Sub
End Class
