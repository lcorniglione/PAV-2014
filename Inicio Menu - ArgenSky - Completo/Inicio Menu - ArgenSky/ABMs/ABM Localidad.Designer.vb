<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ABM_Localidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ABM_Localidad))
        Me.lbl_provincia = New System.Windows.Forms.Label()
        Me.lbl_id_Localidad = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.gb_localidad = New System.Windows.Forms.GroupBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_id_Localidad = New System.Windows.Forms.TextBox()
        Me.cmb_provincia = New System.Windows.Forms.ComboBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.dg_localidad = New System.Windows.Forms.DataGridView()
        Me.gb_carateristicas = New System.Windows.Forms.GroupBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.gb_localidad.SuspendLayout()
        CType(Me.dg_localidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_carateristicas.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_provincia
        '
        Me.lbl_provincia.AutoSize = True
        Me.lbl_provincia.Location = New System.Drawing.Point(11, 59)
        Me.lbl_provincia.Name = "lbl_provincia"
        Me.lbl_provincia.Size = New System.Drawing.Size(54, 13)
        Me.lbl_provincia.TabIndex = 0
        Me.lbl_provincia.Text = "Provincia:"
        '
        'lbl_id_Localidad
        '
        Me.lbl_id_Localidad.AutoSize = True
        Me.lbl_id_Localidad.Location = New System.Drawing.Point(11, 22)
        Me.lbl_id_Localidad.Name = "lbl_id_Localidad"
        Me.lbl_id_Localidad.Size = New System.Drawing.Size(70, 13)
        Me.lbl_id_Localidad.TabIndex = 1
        Me.lbl_id_Localidad.Text = "ID Localidad:"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(11, 22)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbl_descripcion.TabIndex = 2
        Me.lbl_descripcion.Text = "Descripción:"
        '
        'gb_localidad
        '
        Me.gb_localidad.BackColor = System.Drawing.Color.Transparent
        Me.gb_localidad.Controls.Add(Me.btn_buscar)
        Me.gb_localidad.Controls.Add(Me.txt_id_Localidad)
        Me.gb_localidad.Controls.Add(Me.cmb_provincia)
        Me.gb_localidad.Controls.Add(Me.lbl_id_Localidad)
        Me.gb_localidad.Controls.Add(Me.lbl_provincia)
        Me.gb_localidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gb_localidad.ForeColor = System.Drawing.SystemColors.Info
        Me.gb_localidad.Location = New System.Drawing.Point(11, 41)
        Me.gb_localidad.Name = "gb_localidad"
        Me.gb_localidad.Size = New System.Drawing.Size(531, 83)
        Me.gb_localidad.TabIndex = 99999
        Me.gb_localidad.TabStop = False
        Me.gb_localidad.Text = "Localidades"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_buscar.Location = New System.Drawing.Point(299, 30)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(120, 30)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_id_Localidad
        '
        Me.txt_id_Localidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id_Localidad.Location = New System.Drawing.Point(80, 19)
        Me.txt_id_Localidad.Name = "txt_id_Localidad"
        Me.txt_id_Localidad.Size = New System.Drawing.Size(159, 20)
        Me.txt_id_Localidad.TabIndex = 1
        '
        'cmb_provincia
        '
        Me.cmb_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_provincia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_provincia.FormattingEnabled = True
        Me.cmb_provincia.Location = New System.Drawing.Point(80, 56)
        Me.cmb_provincia.Name = "cmb_provincia"
        Me.cmb_provincia.Size = New System.Drawing.Size(159, 21)
        Me.cmb_provincia.TabIndex = 0
        '
        'txt_descripcion
        '
        Me.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_descripcion.Location = New System.Drawing.Point(80, 19)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(296, 20)
        Me.txt_descripcion.TabIndex = 3
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Transparent
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Salir.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Salir.Location = New System.Drawing.Point(446, 354)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(97, 27)
        Me.btn_Salir.TabIndex = 8
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'dg_localidad
        '
        Me.dg_localidad.AllowUserToAddRows = False
        Me.dg_localidad.AllowUserToDeleteRows = False
        Me.dg_localidad.AllowUserToResizeColumns = False
        Me.dg_localidad.AllowUserToResizeRows = False
        Me.dg_localidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_localidad.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dg_localidad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dg_localidad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_localidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_localidad.Location = New System.Drawing.Point(11, 186)
        Me.dg_localidad.MultiSelect = False
        Me.dg_localidad.Name = "dg_localidad"
        Me.dg_localidad.ReadOnly = True
        Me.dg_localidad.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_localidad.RowHeadersVisible = False
        Me.dg_localidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_localidad.Size = New System.Drawing.Size(531, 162)
        Me.dg_localidad.TabIndex = 4
        '
        'gb_carateristicas
        '
        Me.gb_carateristicas.BackColor = System.Drawing.Color.Transparent
        Me.gb_carateristicas.Controls.Add(Me.txt_descripcion)
        Me.gb_carateristicas.Controls.Add(Me.lbl_descripcion)
        Me.gb_carateristicas.Enabled = False
        Me.gb_carateristicas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gb_carateristicas.ForeColor = System.Drawing.SystemColors.Info
        Me.gb_carateristicas.Location = New System.Drawing.Point(11, 130)
        Me.gb_carateristicas.Name = "gb_carateristicas"
        Me.gb_carateristicas.Size = New System.Drawing.Size(531, 50)
        Me.gb_carateristicas.TabIndex = 9999
        Me.gb_carateristicas.TabStop = False
        Me.gb_carateristicas.Text = "Características"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.Transparent
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_nuevo.Location = New System.Drawing.Point(11, 354)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(97, 27)
        Me.btn_nuevo.TabIndex = 5
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_guardar.Location = New System.Drawing.Point(114, 354)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(97, 27)
        Me.btn_guardar.TabIndex = 100000
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_eliminar.Location = New System.Drawing.Point(343, 354)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(97, 27)
        Me.btn_eliminar.TabIndex = 100001
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'frm_ABM_Localidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(554, 393)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.gb_carateristicas)
        Me.Controls.Add(Me.dg_localidad)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.gb_localidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_ABM_Localidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Localidad"
        Me.gb_localidad.ResumeLayout(False)
        Me.gb_localidad.PerformLayout()
        CType(Me.dg_localidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_carateristicas.ResumeLayout(False)
        Me.gb_carateristicas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_provincia As System.Windows.Forms.Label
    Friend WithEvents lbl_id_Localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents gb_localidad As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_Localidad As System.Windows.Forms.TextBox
    Friend WithEvents cmb_provincia As System.Windows.Forms.ComboBox
    Friend WithEvents dg_localidad As System.Windows.Forms.DataGridView
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents gb_carateristicas As System.Windows.Forms.GroupBox
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button

End Class
