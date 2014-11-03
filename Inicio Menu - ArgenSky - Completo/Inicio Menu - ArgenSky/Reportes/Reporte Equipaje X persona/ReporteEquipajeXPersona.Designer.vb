<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteEquipajeXPersona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteEquipajeXPersona))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.cbo_Pasajero = New System.Windows.Forms.ComboBox()
        Me.cbo_vuelo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.crv_Equipaje = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_generar)
        Me.GroupBox1.Controls.Add(Me.cbo_Pasajero)
        Me.GroupBox1.Controls.Add(Me.cbo_vuelo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(849, 60)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Reporte"
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(742, 15)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_generar.TabIndex = 5
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'cbo_Pasajero
        '
        Me.cbo_Pasajero.FormattingEnabled = True
        Me.cbo_Pasajero.Location = New System.Drawing.Point(559, 17)
        Me.cbo_Pasajero.Name = "cbo_Pasajero"
        Me.cbo_Pasajero.Size = New System.Drawing.Size(121, 21)
        Me.cbo_Pasajero.TabIndex = 4
        '
        'cbo_vuelo
        '
        Me.cbo_vuelo.FormattingEnabled = True
        Me.cbo_vuelo.Location = New System.Drawing.Point(333, 17)
        Me.cbo_vuelo.Name = "cbo_vuelo"
        Me.cbo_vuelo.Size = New System.Drawing.Size(121, 21)
        Me.cbo_vuelo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(476, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID. Pasajero"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID. Vuelo"
        '
        'crv_Equipaje
        '
        Me.crv_Equipaje.ActiveViewIndex = -1
        Me.crv_Equipaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_Equipaje.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_Equipaje.Location = New System.Drawing.Point(13, 79)
        Me.crv_Equipaje.Name = "crv_Equipaje"
        Me.crv_Equipaje.Size = New System.Drawing.Size(849, 544)
        Me.crv_Equipaje.TabIndex = 1
        '
        'ReporteEquipajeXPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 624)
        Me.Controls.Add(Me.crv_Equipaje)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteEquipajeXPersona"
        Me.Text = "Listado de Equipaje por persona"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents crv_Equipaje As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents cbo_Pasajero As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_vuelo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
