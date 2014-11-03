Public Class frm_CantidadDeVuelos

    Private Sub reporteFormulario()
        Dim reporte As New cvr_CantidadDeVuelos

        Dim consulta As String

        Dim tabla As New Data.DataTable

        consulta = "SELECT id_Vuelo AS 'ID Vuelo', MONTH(fechaHora_Salida) AS 'Mes', YEAR(fechaHora_Salida) AS 'AÑO'"
        consulta &= " FROM Vuelos"
        consulta &= " WHERE YEAR(fechaHora_Salida) = '" & Me.cmb_año.Text & "'"


        tabla = BDHelper.ConsultaSQL(consulta)

        If (tabla.Rows.Count = 0) Then
            MessageBox.Show("No existen vuelos para el año seleccionado", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmb_año.Focus()
            Exit Sub
        End If

        reporte.SetDataSource(tabla)

        Me.cvr_CantidadDeVuelos.ReportSource = reporte

        Me.cvr_CantidadDeVuelos.Show()

        Me.cvr_CantidadDeVuelos.Refresh()
    End Sub

    Private Sub frm_CantidadDeVuelos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.cmb_año.Text = ""
        Me.cmb_año.SelectedText = ""
        Me.cmb_año.Focus()
    End Sub

    Private Sub btn_generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar.Click

        If Me.cmb_año.Text = "" Then
            MessageBox.Show("Asigne algún año valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cmb_año.Focus()
            Me.cvr_CantidadDeVuelos.Refresh()
            Return
        End If

        Me.reporteFormulario()
    End Sub

    Private Sub frm_CantidadDeVuelos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir?", "ArgenSky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

End Class