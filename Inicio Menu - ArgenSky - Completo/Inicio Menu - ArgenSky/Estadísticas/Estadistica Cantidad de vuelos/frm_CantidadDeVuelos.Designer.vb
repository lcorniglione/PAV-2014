<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CantidadDeVuelos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CantidadDeVuelos))
        Me.grp_filtroEstadistico = New System.Windows.Forms.GroupBox()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.lbl_año = New System.Windows.Forms.Label()
        Me.cmb_año = New System.Windows.Forms.ComboBox()
        Me.cvr_CantidadDeVuelos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.grp_filtroEstadistico.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_filtroEstadistico
        '
        Me.grp_filtroEstadistico.BackColor = System.Drawing.Color.Transparent
        Me.grp_filtroEstadistico.Controls.Add(Me.btn_generar)
        Me.grp_filtroEstadistico.Controls.Add(Me.lbl_año)
        Me.grp_filtroEstadistico.Controls.Add(Me.cmb_año)
        Me.grp_filtroEstadistico.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grp_filtroEstadistico.ForeColor = System.Drawing.SystemColors.Info
        Me.grp_filtroEstadistico.Location = New System.Drawing.Point(-3, 49)
        Me.grp_filtroEstadistico.Name = "grp_filtroEstadistico"
        Me.grp_filtroEstadistico.Size = New System.Drawing.Size(881, 64)
        Me.grp_filtroEstadistico.TabIndex = 0
        Me.grp_filtroEstadistico.TabStop = False
        Me.grp_filtroEstadistico.Text = "Filtro Estadístico"
        '
        'btn_generar
        '
        Me.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_generar.Location = New System.Drawing.Point(310, 18)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(97, 27)
        Me.btn_generar.TabIndex = 2
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'lbl_año
        '
        Me.lbl_año.AutoSize = True
        Me.lbl_año.Location = New System.Drawing.Point(67, 26)
        Me.lbl_año.Name = "lbl_año"
        Me.lbl_año.Size = New System.Drawing.Size(29, 13)
        Me.lbl_año.TabIndex = 1
        Me.lbl_año.Text = "Año:"
        '
        'cmb_año
        '
        Me.cmb_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_año.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_año.FormattingEnabled = True
        Me.cmb_año.Items.AddRange(New Object() {"", "2010", "2011", "2012", "2013", "2014"})
        Me.cmb_año.Location = New System.Drawing.Point(102, 23)
        Me.cmb_año.Name = "cmb_año"
        Me.cmb_año.Size = New System.Drawing.Size(159, 21)
        Me.cmb_año.TabIndex = 0
        '
        'cvr_CantidadDeVuelos
        '
        Me.cvr_CantidadDeVuelos.ActiveViewIndex = -1
        Me.cvr_CantidadDeVuelos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cvr_CantidadDeVuelos.Cursor = System.Windows.Forms.Cursors.Default
        Me.cvr_CantidadDeVuelos.Location = New System.Drawing.Point(-3, 119)
        Me.cvr_CantidadDeVuelos.Name = "cvr_CantidadDeVuelos"
        Me.cvr_CantidadDeVuelos.Size = New System.Drawing.Size(881, 507)
        Me.cvr_CantidadDeVuelos.TabIndex = 1
        Me.cvr_CantidadDeVuelos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frm_CantidadDeVuelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Fondo_de_ventana_grande
        Me.ClientSize = New System.Drawing.Size(874, 624)
        Me.Controls.Add(Me.cvr_CantidadDeVuelos)
        Me.Controls.Add(Me.grp_filtroEstadistico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_CantidadDeVuelos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cantidad De Vuelos"
        Me.grp_filtroEstadistico.ResumeLayout(False)
        Me.grp_filtroEstadistico.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_filtroEstadistico As System.Windows.Forms.GroupBox
    Friend WithEvents cvr_CantidadDeVuelos As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents lbl_año As System.Windows.Forms.Label
    Friend WithEvents cmb_año As System.Windows.Forms.ComboBox
End Class
