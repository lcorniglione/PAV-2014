Public Class frm_capacidadAeronaves

    Dim conexion As String = "Data Source=ArgenSky.mssql.somee.com;Persist Security Info=True;User ID=adminargensky;Password=pav.2014"
    Private Sub btn_filtrarAeronaves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrarAeronaves.Click
       
        Dim reporte As New crv_capacidadAeronaves

        Dim consulta As String

        Dim tabla As New Data.DataTable

        If (txt_filtro.Text = "") Then
            consulta = "SELECT id_Aeronave, nombre_Marca, (cant_Pasaj_Economy + cant_Pasaj_Premium) AS 'Asientos' FROM Aeronaves JOIN Marca ON (marca=id_Marca)"
        Else
            consulta = "SELECT id_Aeronave, nombre_Marca, (cant_Pasaj_Economy + cant_Pasaj_Premium) AS 'Asientos' FROM Aeronaves JOIN Marca ON (marca=id_Marca) WHERE (cant_Pasaj_Economy + cant_Pasaj_Premium) >= " & txt_filtro.Text
        End If

        tabla = BDHelper.ConsultaSQL(consulta)
        If (tabla.Rows.Count < 1) Then
            MessageBox.Show("No existen aeronaves con esa capacidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If


        reporte.SetDataSource(tabla)


        Me.crv_reporte.ReportSource = reporte

        Me.crv_reporte.Show()

        Me.crv_reporte.Refresh()

    End Sub

    Private Sub frm_capacidadAeronaves_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_filtro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_filtro.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class
