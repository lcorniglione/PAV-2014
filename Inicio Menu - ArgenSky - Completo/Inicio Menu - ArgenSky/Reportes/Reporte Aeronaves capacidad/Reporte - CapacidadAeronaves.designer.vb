<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_capacidadAeronaves
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_capacidadAeronaves))
        Me.btn_filtrarAeronaves = New System.Windows.Forms.Button()
        Me.txt_filtro = New System.Windows.Forms.TextBox()
        Me.lbl_filtro = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.crv_reporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_filtrarAeronaves
        '
        Me.btn_filtrarAeronaves.BackColor = System.Drawing.Color.Transparent
        Me.btn_filtrarAeronaves.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_filtrarAeronaves.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_filtrarAeronaves.Location = New System.Drawing.Point(774, 19)
        Me.btn_filtrarAeronaves.Name = "btn_filtrarAeronaves"
        Me.btn_filtrarAeronaves.Size = New System.Drawing.Size(97, 25)
        Me.btn_filtrarAeronaves.TabIndex = 1
        Me.btn_filtrarAeronaves.Text = "Generar"
        Me.btn_filtrarAeronaves.UseVisualStyleBackColor = False
        '
        'txt_filtro
        '
        Me.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtro.Location = New System.Drawing.Point(624, 22)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(121, 20)
        Me.txt_filtro.TabIndex = 2
        '
        'lbl_filtro
        '
        Me.lbl_filtro.AutoSize = True
        Me.lbl_filtro.BackColor = System.Drawing.Color.Transparent
        Me.lbl_filtro.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl_filtro.Location = New System.Drawing.Point(480, 24)
        Me.lbl_filtro.Name = "lbl_filtro"
        Me.lbl_filtro.Size = New System.Drawing.Size(138, 13)
        Me.lbl_filtro.TabIndex = 3
        Me.lbl_filtro.Text = "Cantidad de asientos desde"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_filtro)
        Me.GroupBox1.Controls.Add(Me.btn_filtrarAeronaves)
        Me.GroupBox1.Controls.Add(Me.lbl_filtro)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(1, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(881, 56)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de reporte"
        '
        'crv_reporte
        '
        Me.crv_reporte.ActiveViewIndex = -1
        Me.crv_reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_reporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_reporte.Location = New System.Drawing.Point(3, 104)
        Me.crv_reporte.Name = "crv_reporte"
        Me.crv_reporte.Size = New System.Drawing.Size(879, 530)
        Me.crv_reporte.TabIndex = 5
        Me.crv_reporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frm_capacidadAeronaves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(884, 634)
        Me.Controls.Add(Me.crv_reporte)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_capacidadAeronaves"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capacidad de Aeronaves"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_filtrarAeronaves As System.Windows.Forms.Button
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents lbl_filtro As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents crv_reporte As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
