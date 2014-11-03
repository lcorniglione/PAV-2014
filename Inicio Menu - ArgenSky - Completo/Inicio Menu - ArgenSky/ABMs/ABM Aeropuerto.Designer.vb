<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ABMAeropuerto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ABMAeropuerto))
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_cantPuertas = New System.Windows.Forms.Label()
        Me.lbl_cantMangas = New System.Windows.Forms.Label()
        Me.txt_nombre_Aeropuerto = New System.Windows.Forms.TextBox()
        Me.txt_cant_Mangas = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cant_PuertasEmbarque = New System.Windows.Forms.MaskedTextBox()
        Me.grp_aeropuerto = New System.Windows.Forms.GroupBox()
        Me.cb_localidad = New System.Windows.Forms.ComboBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_idAeropuerto = New System.Windows.Forms.TextBox()
        Me.lbl_id_Aeropuerto = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.grp_caracteristicas = New System.Windows.Forms.GroupBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.grd_aeropuerto = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grp_aeropuerto.SuspendLayout()
        Me.grp_caracteristicas.SuspendLayout()
        CType(Me.grd_aeropuerto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(377, 22)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Location = New System.Drawing.Point(202, 22)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(56, 13)
        Me.lbl_localidad.TabIndex = 1
        Me.lbl_localidad.Text = "Localidad:"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(395, 22)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_telefono.TabIndex = 2
        Me.lbl_telefono.Text = "Telèfono:"
        '
        'lbl_cantPuertas
        '
        Me.lbl_cantPuertas.AutoSize = True
        Me.lbl_cantPuertas.Location = New System.Drawing.Point(9, 22)
        Me.lbl_cantPuertas.Name = "lbl_cantPuertas"
        Me.lbl_cantPuertas.Size = New System.Drawing.Size(74, 13)
        Me.lbl_cantPuertas.TabIndex = 3
        Me.lbl_cantPuertas.Text = "Cant. Puertas:"
        '
        'lbl_cantMangas
        '
        Me.lbl_cantMangas.AutoSize = True
        Me.lbl_cantMangas.Location = New System.Drawing.Point(202, 22)
        Me.lbl_cantMangas.Name = "lbl_cantMangas"
        Me.lbl_cantMangas.Size = New System.Drawing.Size(76, 13)
        Me.lbl_cantMangas.TabIndex = 4
        Me.lbl_cantMangas.Text = "Cant. Mangas:"
        '
        'txt_nombre_Aeropuerto
        '
        Me.txt_nombre_Aeropuerto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombre_Aeropuerto.Location = New System.Drawing.Point(430, 20)
        Me.txt_nombre_Aeropuerto.Name = "txt_nombre_Aeropuerto"
        Me.txt_nombre_Aeropuerto.Size = New System.Drawing.Size(107, 20)
        Me.txt_nombre_Aeropuerto.TabIndex = 1
        '
        'txt_cant_Mangas
        '
        Me.txt_cant_Mangas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cant_Mangas.Location = New System.Drawing.Point(282, 19)
        Me.txt_cant_Mangas.Mask = "99999999"
        Me.txt_cant_Mangas.Name = "txt_cant_Mangas"
        Me.txt_cant_Mangas.Size = New System.Drawing.Size(107, 20)
        Me.txt_cant_Mangas.TabIndex = 5
        '
        'txt_cant_PuertasEmbarque
        '
        Me.txt_cant_PuertasEmbarque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cant_PuertasEmbarque.Location = New System.Drawing.Point(89, 19)
        Me.txt_cant_PuertasEmbarque.Mask = "99999999"
        Me.txt_cant_PuertasEmbarque.Name = "txt_cant_PuertasEmbarque"
        Me.txt_cant_PuertasEmbarque.Size = New System.Drawing.Size(107, 20)
        Me.txt_cant_PuertasEmbarque.TabIndex = 4
        '
        'grp_aeropuerto
        '
        Me.grp_aeropuerto.BackColor = System.Drawing.Color.Transparent
        Me.grp_aeropuerto.Controls.Add(Me.cb_localidad)
        Me.grp_aeropuerto.Controls.Add(Me.btn_buscar)
        Me.grp_aeropuerto.Controls.Add(Me.txt_idAeropuerto)
        Me.grp_aeropuerto.Controls.Add(Me.lbl_id_Aeropuerto)
        Me.grp_aeropuerto.Controls.Add(Me.txt_nombre_Aeropuerto)
        Me.grp_aeropuerto.Controls.Add(Me.lbl_localidad)
        Me.grp_aeropuerto.Controls.Add(Me.lbl_nombre)
        Me.grp_aeropuerto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grp_aeropuerto.ForeColor = System.Drawing.SystemColors.Info
        Me.grp_aeropuerto.Location = New System.Drawing.Point(12, 43)
        Me.grp_aeropuerto.Name = "grp_aeropuerto"
        Me.grp_aeropuerto.Size = New System.Drawing.Size(657, 55)
        Me.grp_aeropuerto.TabIndex = 999
        Me.grp_aeropuerto.TabStop = False
        Me.grp_aeropuerto.Text = "Aeropuerto"
        '
        'cb_localidad
        '
        Me.cb_localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_localidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_localidad.FormattingEnabled = True
        Me.cb_localidad.Location = New System.Drawing.Point(264, 19)
        Me.cb_localidad.Name = "cb_localidad"
        Me.cb_localidad.Size = New System.Drawing.Size(107, 21)
        Me.cb_localidad.TabIndex = 2
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_buscar.Location = New System.Drawing.Point(543, 15)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(109, 27)
        Me.btn_buscar.TabIndex = 3
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_idAeropuerto
        '
        Me.txt_idAeropuerto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_idAeropuerto.Location = New System.Drawing.Point(89, 20)
        Me.txt_idAeropuerto.Name = "txt_idAeropuerto"
        Me.txt_idAeropuerto.Size = New System.Drawing.Size(107, 20)
        Me.txt_idAeropuerto.TabIndex = 0
        '
        'lbl_id_Aeropuerto
        '
        Me.lbl_id_Aeropuerto.AutoSize = True
        Me.lbl_id_Aeropuerto.Location = New System.Drawing.Point(9, 22)
        Me.lbl_id_Aeropuerto.Name = "lbl_id_Aeropuerto"
        Me.lbl_id_Aeropuerto.Size = New System.Drawing.Size(76, 13)
        Me.lbl_id_Aeropuerto.TabIndex = 2
        Me.lbl_id_Aeropuerto.Text = "ID Aeropuerto:"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_guardar.Location = New System.Drawing.Point(115, 418)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(97, 27)
        Me.btn_guardar.TabIndex = 8
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Transparent
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Salir.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Salir.Location = New System.Drawing.Point(572, 418)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(97, 27)
        Me.btn_Salir.TabIndex = 10
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.Transparent
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 418)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(97, 27)
        Me.btn_nuevo.TabIndex = 7
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_eliminar.Location = New System.Drawing.Point(452, 418)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(97, 27)
        Me.btn_eliminar.TabIndex = 9
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'grp_caracteristicas
        '
        Me.grp_caracteristicas.BackColor = System.Drawing.Color.Transparent
        Me.grp_caracteristicas.Controls.Add(Me.txt_telefono)
        Me.grp_caracteristicas.Controls.Add(Me.txt_cant_PuertasEmbarque)
        Me.grp_caracteristicas.Controls.Add(Me.txt_cant_Mangas)
        Me.grp_caracteristicas.Controls.Add(Me.lbl_cantMangas)
        Me.grp_caracteristicas.Controls.Add(Me.lbl_cantPuertas)
        Me.grp_caracteristicas.Controls.Add(Me.lbl_telefono)
        Me.grp_caracteristicas.Enabled = False
        Me.grp_caracteristicas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grp_caracteristicas.ForeColor = System.Drawing.SystemColors.Info
        Me.grp_caracteristicas.Location = New System.Drawing.Point(12, 114)
        Me.grp_caracteristicas.Name = "grp_caracteristicas"
        Me.grp_caracteristicas.Size = New System.Drawing.Size(657, 52)
        Me.grp_caracteristicas.TabIndex = 9999
        Me.grp_caracteristicas.TabStop = False
        Me.grp_caracteristicas.Text = "Características"
        '
        'txt_telefono
        '
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_telefono.Location = New System.Drawing.Point(453, 20)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(107, 20)
        Me.txt_telefono.TabIndex = 4
        '
        'grd_aeropuerto
        '
        Me.grd_aeropuerto.AllowUserToAddRows = False
        Me.grd_aeropuerto.AllowUserToDeleteRows = False
        Me.grd_aeropuerto.AllowUserToResizeColumns = False
        Me.grd_aeropuerto.AllowUserToResizeRows = False
        Me.grd_aeropuerto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_aeropuerto.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_aeropuerto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.grd_aeropuerto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grd_aeropuerto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_aeropuerto.Location = New System.Drawing.Point(12, 172)
        Me.grd_aeropuerto.MultiSelect = False
        Me.grd_aeropuerto.Name = "grd_aeropuerto"
        Me.grd_aeropuerto.ReadOnly = True
        Me.grd_aeropuerto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grd_aeropuerto.RowHeadersVisible = False
        Me.grd_aeropuerto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_aeropuerto.Size = New System.Drawing.Size(657, 240)
        Me.grd_aeropuerto.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 141)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(709, 214)
        Me.DataGridView1.TabIndex = 12
        '
        'frm_ABMAeropuerto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(676, 457)
        Me.Controls.Add(Me.grd_aeropuerto)
        Me.Controls.Add(Me.grp_caracteristicas)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.grp_aeropuerto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_ABMAeropuerto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Aeropuerto"
        Me.grp_aeropuerto.ResumeLayout(False)
        Me.grp_aeropuerto.PerformLayout()
        Me.grp_caracteristicas.ResumeLayout(False)
        Me.grp_caracteristicas.PerformLayout()
        CType(Me.grd_aeropuerto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_cantPuertas As System.Windows.Forms.Label
    Friend WithEvents lbl_cantMangas As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_Aeropuerto As System.Windows.Forms.TextBox
    Friend WithEvents txt_cant_Mangas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cant_PuertasEmbarque As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grp_aeropuerto As System.Windows.Forms.GroupBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents txt_idAeropuerto As System.Windows.Forms.TextBox
    Friend WithEvents lbl_id_Aeropuerto As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents grp_caracteristicas As System.Windows.Forms.GroupBox
    Friend WithEvents grd_aeropuerto As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cb_localidad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox

End Class
