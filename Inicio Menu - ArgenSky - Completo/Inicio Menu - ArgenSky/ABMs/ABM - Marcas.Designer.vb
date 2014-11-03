<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ABMMarcas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ABMMarcas))
        Me.grp_abmMarca = New System.Windows.Forms.GroupBox()
        Me.txt_nombreMarca = New System.Windows.Forms.TextBox()
        Me.lbl_nombreMarca = New System.Windows.Forms.Label()
        Me.txt_idMarca = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.lbl_idMarca = New System.Windows.Forms.Label()
        Me.grd_Marcas = New System.Windows.Forms.DataGridView()
        Me.btn_borrarMarca = New System.Windows.Forms.Button()
        Me.btn_nuevaMarca = New System.Windows.Forms.Button()
        Me.btn_salirMarca = New System.Windows.Forms.Button()
        Me.btn_guardarMarca = New System.Windows.Forms.Button()
        Me.grp_abmMarca.SuspendLayout()
        CType(Me.grd_Marcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_abmMarca
        '
        Me.grp_abmMarca.BackColor = System.Drawing.Color.Transparent
        Me.grp_abmMarca.Controls.Add(Me.txt_nombreMarca)
        Me.grp_abmMarca.Controls.Add(Me.lbl_nombreMarca)
        Me.grp_abmMarca.Controls.Add(Me.txt_idMarca)
        Me.grp_abmMarca.Controls.Add(Me.btn_buscar)
        Me.grp_abmMarca.Controls.Add(Me.lbl_idMarca)
        Me.grp_abmMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grp_abmMarca.ForeColor = System.Drawing.SystemColors.Info
        Me.grp_abmMarca.Location = New System.Drawing.Point(12, 43)
        Me.grp_abmMarca.Name = "grp_abmMarca"
        Me.grp_abmMarca.Size = New System.Drawing.Size(544, 76)
        Me.grp_abmMarca.TabIndex = 2
        Me.grp_abmMarca.TabStop = False
        Me.grp_abmMarca.Text = "Datos de marca"
        '
        'txt_nombreMarca
        '
        Me.txt_nombreMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombreMarca.Enabled = False
        Me.txt_nombreMarca.Location = New System.Drawing.Point(265, 31)
        Me.txt_nombreMarca.Name = "txt_nombreMarca"
        Me.txt_nombreMarca.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombreMarca.TabIndex = 1
        '
        'lbl_nombreMarca
        '
        Me.lbl_nombreMarca.AutoSize = True
        Me.lbl_nombreMarca.Enabled = False
        Me.lbl_nombreMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_nombreMarca.Location = New System.Drawing.Point(215, 33)
        Me.lbl_nombreMarca.Name = "lbl_nombreMarca"
        Me.lbl_nombreMarca.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombreMarca.TabIndex = 2
        Me.lbl_nombreMarca.Text = "Nombre"
        '
        'txt_idMarca
        '
        Me.txt_idMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_idMarca.Location = New System.Drawing.Point(63, 30)
        Me.txt_idMarca.MaxLength = 4
        Me.txt_idMarca.Name = "txt_idMarca"
        Me.txt_idMarca.Size = New System.Drawing.Size(100, 20)
        Me.txt_idMarca.TabIndex = 0
        '
        'btn_buscar
        '
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_buscar.Location = New System.Drawing.Point(425, 26)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(97, 27)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'lbl_idMarca
        '
        Me.lbl_idMarca.AutoSize = True
        Me.lbl_idMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_idMarca.Location = New System.Drawing.Point(6, 33)
        Me.lbl_idMarca.Name = "lbl_idMarca"
        Me.lbl_idMarca.Size = New System.Drawing.Size(51, 13)
        Me.lbl_idMarca.TabIndex = 0
        Me.lbl_idMarca.Text = "ID Marca"
        '
        'grd_Marcas
        '
        Me.grd_Marcas.AllowUserToAddRows = False
        Me.grd_Marcas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grd_Marcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_Marcas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_Marcas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_Marcas.Location = New System.Drawing.Point(12, 125)
        Me.grd_Marcas.MultiSelect = False
        Me.grd_Marcas.Name = "grd_Marcas"
        Me.grd_Marcas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grd_Marcas.RowHeadersVisible = False
        Me.grd_Marcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_Marcas.Size = New System.Drawing.Size(544, 150)
        Me.grd_Marcas.TabIndex = 3
        '
        'btn_borrarMarca
        '
        Me.btn_borrarMarca.BackColor = System.Drawing.Color.Transparent
        Me.btn_borrarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_borrarMarca.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_borrarMarca.Location = New System.Drawing.Point(128, 285)
        Me.btn_borrarMarca.Name = "btn_borrarMarca"
        Me.btn_borrarMarca.Size = New System.Drawing.Size(97, 27)
        Me.btn_borrarMarca.TabIndex = 8
        Me.btn_borrarMarca.Text = "Borrar"
        Me.btn_borrarMarca.UseVisualStyleBackColor = False
        '
        'btn_nuevaMarca
        '
        Me.btn_nuevaMarca.BackColor = System.Drawing.Color.Transparent
        Me.btn_nuevaMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevaMarca.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_nuevaMarca.Location = New System.Drawing.Point(25, 285)
        Me.btn_nuevaMarca.Name = "btn_nuevaMarca"
        Me.btn_nuevaMarca.Size = New System.Drawing.Size(97, 27)
        Me.btn_nuevaMarca.TabIndex = 5
        Me.btn_nuevaMarca.Text = "Nuevo"
        Me.btn_nuevaMarca.UseVisualStyleBackColor = False
        '
        'btn_salirMarca
        '
        Me.btn_salirMarca.BackColor = System.Drawing.Color.Transparent
        Me.btn_salirMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salirMarca.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_salirMarca.Location = New System.Drawing.Point(444, 285)
        Me.btn_salirMarca.Name = "btn_salirMarca"
        Me.btn_salirMarca.Size = New System.Drawing.Size(97, 27)
        Me.btn_salirMarca.TabIndex = 7
        Me.btn_salirMarca.Text = "Salir"
        Me.btn_salirMarca.UseVisualStyleBackColor = False
        '
        'btn_guardarMarca
        '
        Me.btn_guardarMarca.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardarMarca.Enabled = False
        Me.btn_guardarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardarMarca.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_guardarMarca.Location = New System.Drawing.Point(341, 285)
        Me.btn_guardarMarca.Name = "btn_guardarMarca"
        Me.btn_guardarMarca.Size = New System.Drawing.Size(97, 27)
        Me.btn_guardarMarca.TabIndex = 6
        Me.btn_guardarMarca.Text = "Guardar"
        Me.btn_guardarMarca.UseVisualStyleBackColor = False
        '
        'frm_ABMMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(568, 324)
        Me.Controls.Add(Me.btn_borrarMarca)
        Me.Controls.Add(Me.btn_nuevaMarca)
        Me.Controls.Add(Me.btn_salirMarca)
        Me.Controls.Add(Me.btn_guardarMarca)
        Me.Controls.Add(Me.grd_Marcas)
        Me.Controls.Add(Me.grp_abmMarca)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_ABMMarcas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM - Marcas"
        Me.grp_abmMarca.ResumeLayout(False)
        Me.grp_abmMarca.PerformLayout()
        CType(Me.grd_Marcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_abmMarca As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombreMarca As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombreMarca As System.Windows.Forms.Label
    Friend WithEvents txt_idMarca As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_idMarca As System.Windows.Forms.Label
    Friend WithEvents grd_Marcas As System.Windows.Forms.DataGridView
    Friend WithEvents btn_borrarMarca As System.Windows.Forms.Button
    Friend WithEvents btn_nuevaMarca As System.Windows.Forms.Button
    Friend WithEvents btn_salirMarca As System.Windows.Forms.Button
    Friend WithEvents btn_guardarMarca As System.Windows.Forms.Button

End Class
