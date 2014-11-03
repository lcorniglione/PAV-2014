<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_buscarPasajero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_buscarPasajero))
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.grd_pasajeros = New System.Windows.Forms.DataGridView()
        Me.gbx_pasajero = New System.Windows.Forms.GroupBox()
        Me.cbo_tipoDocumento = New System.Windows.Forms.ComboBox()
        Me.txt_numeroDocumento = New System.Windows.Forms.TextBox()
        Me.lbl_numeroDocumento = New System.Windows.Forms.Label()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.lbl_tipoDocumento = New System.Windows.Forms.Label()
        Me.txt_idPasajero = New System.Windows.Forms.TextBox()
        Me.lbl_idPasajero = New System.Windows.Forms.Label()
        CType(Me.grd_pasajeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_pasajero.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_salir
        '
        Me.cmd_salir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmd_salir.BackColor = System.Drawing.Color.Transparent
        Me.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_salir.ForeColor = System.Drawing.Color.White
        Me.cmd_salir.Location = New System.Drawing.Point(640, 309)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(97, 27)
        Me.cmd_salir.TabIndex = 19
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'grd_pasajeros
        '
        Me.grd_pasajeros.AllowUserToAddRows = False
        Me.grd_pasajeros.AllowUserToDeleteRows = False
        Me.grd_pasajeros.AllowUserToResizeColumns = False
        Me.grd_pasajeros.AllowUserToResizeRows = False
        Me.grd_pasajeros.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.grd_pasajeros.BackgroundColor = System.Drawing.Color.White
        Me.grd_pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_pasajeros.Location = New System.Drawing.Point(5, 111)
        Me.grd_pasajeros.Name = "grd_pasajeros"
        Me.grd_pasajeros.ReadOnly = True
        Me.grd_pasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_pasajeros.Size = New System.Drawing.Size(743, 192)
        Me.grd_pasajeros.TabIndex = 20
        '
        'gbx_pasajero
        '
        Me.gbx_pasajero.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbx_pasajero.BackColor = System.Drawing.Color.Transparent
        Me.gbx_pasajero.Controls.Add(Me.cbo_tipoDocumento)
        Me.gbx_pasajero.Controls.Add(Me.txt_numeroDocumento)
        Me.gbx_pasajero.Controls.Add(Me.lbl_numeroDocumento)
        Me.gbx_pasajero.Controls.Add(Me.cmd_buscar)
        Me.gbx_pasajero.Controls.Add(Me.lbl_tipoDocumento)
        Me.gbx_pasajero.Controls.Add(Me.txt_idPasajero)
        Me.gbx_pasajero.Controls.Add(Me.lbl_idPasajero)
        Me.gbx_pasajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbx_pasajero.ForeColor = System.Drawing.SystemColors.Info
        Me.gbx_pasajero.Location = New System.Drawing.Point(5, 40)
        Me.gbx_pasajero.Name = "gbx_pasajero"
        Me.gbx_pasajero.Size = New System.Drawing.Size(743, 65)
        Me.gbx_pasajero.TabIndex = 14
        Me.gbx_pasajero.TabStop = False
        Me.gbx_pasajero.Text = "Pasajeros/Datos de busqueda"
        '
        'cbo_tipoDocumento
        '
        Me.cbo_tipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cbo_tipoDocumento.DisplayMember = "descripcion"
        Me.cbo_tipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_tipoDocumento.FormattingEnabled = True
        Me.cbo_tipoDocumento.Location = New System.Drawing.Point(284, 28)
        Me.cbo_tipoDocumento.Name = "cbo_tipoDocumento"
        Me.cbo_tipoDocumento.Size = New System.Drawing.Size(121, 21)
        Me.cbo_tipoDocumento.TabIndex = 1
        Me.cbo_tipoDocumento.ValueMember = "id_TipoDoc"
        '
        'txt_numeroDocumento
        '
        Me.txt_numeroDocumento.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_numeroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numeroDocumento.Location = New System.Drawing.Point(494, 28)
        Me.txt_numeroDocumento.Name = "txt_numeroDocumento"
        Me.txt_numeroDocumento.Size = New System.Drawing.Size(121, 20)
        Me.txt_numeroDocumento.TabIndex = 2
        '
        'lbl_numeroDocumento
        '
        Me.lbl_numeroDocumento.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_numeroDocumento.AutoSize = True
        Me.lbl_numeroDocumento.Location = New System.Drawing.Point(421, 31)
        Me.lbl_numeroDocumento.Name = "lbl_numeroDocumento"
        Me.lbl_numeroDocumento.Size = New System.Drawing.Size(67, 13)
        Me.lbl_numeroDocumento.TabIndex = 0
        Me.lbl_numeroDocumento.Text = "Numero Doc"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmd_buscar.BackColor = System.Drawing.Color.Transparent
        Me.cmd_buscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmd_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_buscar.ForeColor = System.Drawing.Color.White
        Me.cmd_buscar.Location = New System.Drawing.Point(635, 24)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(97, 27)
        Me.cmd_buscar.TabIndex = 3
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = False
        '
        'lbl_tipoDocumento
        '
        Me.lbl_tipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_tipoDocumento.AutoSize = True
        Me.lbl_tipoDocumento.Location = New System.Drawing.Point(192, 31)
        Me.lbl_tipoDocumento.Name = "lbl_tipoDocumento"
        Me.lbl_tipoDocumento.Size = New System.Drawing.Size(86, 13)
        Me.lbl_tipoDocumento.TabIndex = 0
        Me.lbl_tipoDocumento.Text = "Tipo Documento"
        '
        'txt_idPasajero
        '
        Me.txt_idPasajero.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_idPasajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_idPasajero.Location = New System.Drawing.Point(72, 28)
        Me.txt_idPasajero.Name = "txt_idPasajero"
        Me.txt_idPasajero.Size = New System.Drawing.Size(100, 20)
        Me.txt_idPasajero.TabIndex = 0
        '
        'lbl_idPasajero
        '
        Me.lbl_idPasajero.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_idPasajero.AutoSize = True
        Me.lbl_idPasajero.Location = New System.Drawing.Point(6, 31)
        Me.lbl_idPasajero.Name = "lbl_idPasajero"
        Me.lbl_idPasajero.Size = New System.Drawing.Size(60, 13)
        Me.lbl_idPasajero.TabIndex = 0
        Me.lbl_idPasajero.Text = "Id Pasajero"
        '
        'frm_buscarPasajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Fondo_de_ventana_grande
        Me.ClientSize = New System.Drawing.Size(749, 348)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.grd_pasajeros)
        Me.Controls.Add(Me.gbx_pasajero)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_buscarPasajero"
        Me.Text = "Buscar Pasajero"
        CType(Me.grd_pasajeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_pasajero.ResumeLayout(False)
        Me.gbx_pasajero.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents grd_pasajeros As System.Windows.Forms.DataGridView
    Friend WithEvents gbx_pasajero As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_tipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_numeroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_numeroDocumento As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_tipoDocumento As System.Windows.Forms.Label
    Friend WithEvents txt_idPasajero As System.Windows.Forms.TextBox
    Friend WithEvents lbl_idPasajero As System.Windows.Forms.Label
End Class
