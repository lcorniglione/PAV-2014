<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tarjeta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tarjeta))
        Me.gb_pasajero = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdb_AeNo = New System.Windows.Forms.RadioButton()
        Me.rdb_AeSI = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_numeroDoc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_idPasajero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_numeroVuelo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_letraAsiento = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_numAsiento = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rdb_bodegaNo = New System.Windows.Forms.RadioButton()
        Me.rdb_bodegaSI = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rdb_especialNo = New System.Windows.Forms.RadioButton()
        Me.rdb_especialSi = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.txt_cantbultos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_peso = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_generarTarjeta = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_numeroPasaje = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_agregarEquipaje = New System.Windows.Forms.Button()
        Me.btn_nuevatarjeta = New System.Windows.Forms.Button()
        Me.gb_pasajero.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_pasajero
        '
        Me.gb_pasajero.BackColor = System.Drawing.Color.Transparent
        Me.gb_pasajero.Controls.Add(Me.Panel1)
        Me.gb_pasajero.Controls.Add(Me.Label5)
        Me.gb_pasajero.Controls.Add(Me.txt_numeroDoc)
        Me.gb_pasajero.Controls.Add(Me.Label4)
        Me.gb_pasajero.Controls.Add(Me.txt_apellido)
        Me.gb_pasajero.Controls.Add(Me.label)
        Me.gb_pasajero.Controls.Add(Me.txt_nombre)
        Me.gb_pasajero.Controls.Add(Me.Label3)
        Me.gb_pasajero.Controls.Add(Me.txt_idPasajero)
        Me.gb_pasajero.Controls.Add(Me.Label2)
        Me.gb_pasajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gb_pasajero.ForeColor = System.Drawing.SystemColors.Info
        Me.gb_pasajero.Location = New System.Drawing.Point(12, 87)
        Me.gb_pasajero.Name = "gb_pasajero"
        Me.gb_pasajero.Size = New System.Drawing.Size(651, 110)
        Me.gb_pasajero.TabIndex = 0
        Me.gb_pasajero.TabStop = False
        Me.gb_pasajero.Text = "Pasajero"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdb_AeNo)
        Me.Panel1.Controls.Add(Me.rdb_AeSI)
        Me.Panel1.Location = New System.Drawing.Point(490, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 30)
        Me.Panel1.TabIndex = 9
        '
        'rdb_AeNo
        '
        Me.rdb_AeNo.AutoSize = True
        Me.rdb_AeNo.Location = New System.Drawing.Point(100, 10)
        Me.rdb_AeNo.Name = "rdb_AeNo"
        Me.rdb_AeNo.Size = New System.Drawing.Size(39, 17)
        Me.rdb_AeNo.TabIndex = 1
        Me.rdb_AeNo.TabStop = True
        Me.rdb_AeNo.Text = "No"
        Me.rdb_AeNo.UseVisualStyleBackColor = True
        '
        'rdb_AeSI
        '
        Me.rdb_AeSI.AutoSize = True
        Me.rdb_AeSI.Location = New System.Drawing.Point(14, 10)
        Me.rdb_AeSI.Name = "rdb_AeSI"
        Me.rdb_AeSI.Size = New System.Drawing.Size(34, 17)
        Me.rdb_AeSI.TabIndex = 0
        Me.rdb_AeSI.TabStop = True
        Me.rdb_AeSI.Text = "Si"
        Me.rdb_AeSI.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(514, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Atencion Especial"
        '
        'txt_numeroDoc
        '
        Me.txt_numeroDoc.Enabled = False
        Me.txt_numeroDoc.Location = New System.Drawing.Point(362, 65)
        Me.txt_numeroDoc.Name = "txt_numeroDoc"
        Me.txt_numeroDoc.Size = New System.Drawing.Size(100, 20)
        Me.txt_numeroDoc.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(256, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nro Documento"
        '
        'txt_apellido
        '
        Me.txt_apellido.Enabled = False
        Me.txt_apellido.Location = New System.Drawing.Point(362, 26)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(100, 20)
        Me.txt_apellido.TabIndex = 5
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(256, 29)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(44, 13)
        Me.label.TabIndex = 4
        Me.label.Text = "Apellido"
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(89, 65)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'txt_idPasajero
        '
        Me.txt_idPasajero.Enabled = False
        Me.txt_idPasajero.Location = New System.Drawing.Point(89, 26)
        Me.txt_idPasajero.Name = "txt_idPasajero"
        Me.txt_idPasajero.Size = New System.Drawing.Size(100, 20)
        Me.txt_idPasajero.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Id Pasajero"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(263, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número de Vuelo"
        '
        'txt_numeroVuelo
        '
        Me.txt_numeroVuelo.Location = New System.Drawing.Point(374, 53)
        Me.txt_numeroVuelo.Name = "txt_numeroVuelo"
        Me.txt_numeroVuelo.Size = New System.Drawing.Size(100, 20)
        Me.txt_numeroVuelo.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_letraAsiento)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_numAsiento)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Location = New System.Drawing.Point(12, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 72)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ubicacion"
        '
        'txt_letraAsiento
        '
        Me.txt_letraAsiento.Enabled = False
        Me.txt_letraAsiento.Location = New System.Drawing.Point(405, 33)
        Me.txt_letraAsiento.Name = "txt_letraAsiento"
        Me.txt_letraAsiento.Size = New System.Drawing.Size(100, 20)
        Me.txt_letraAsiento.TabIndex = 3
        Me.txt_letraAsiento.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(314, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Letra Asiento"
        Me.Label7.Visible = False
        '
        'txt_numAsiento
        '
        Me.txt_numAsiento.Enabled = False
        Me.txt_numAsiento.Location = New System.Drawing.Point(134, 33)
        Me.txt_numAsiento.Name = "txt_numAsiento"
        Me.txt_numAsiento.Size = New System.Drawing.Size(100, 20)
        Me.txt_numAsiento.TabIndex = 1
        Me.txt_numAsiento.Text = "Automatico"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Numero Asiento"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.btn_agregar)
        Me.GroupBox2.Controls.Add(Me.txt_cantbultos)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_peso)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox2.Location = New System.Drawing.Point(13, 346)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(650, 162)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro Equipaje"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rdb_bodegaNo)
        Me.Panel3.Controls.Add(Me.rdb_bodegaSI)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(25, 78)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(215, 20)
        Me.Panel3.TabIndex = 9
        '
        'rdb_bodegaNo
        '
        Me.rdb_bodegaNo.AutoSize = True
        Me.rdb_bodegaNo.Location = New System.Drawing.Point(164, 1)
        Me.rdb_bodegaNo.Name = "rdb_bodegaNo"
        Me.rdb_bodegaNo.Size = New System.Drawing.Size(39, 17)
        Me.rdb_bodegaNo.TabIndex = 8
        Me.rdb_bodegaNo.TabStop = True
        Me.rdb_bodegaNo.Text = "No"
        Me.rdb_bodegaNo.UseVisualStyleBackColor = True
        '
        'rdb_bodegaSI
        '
        Me.rdb_bodegaSI.AutoSize = True
        Me.rdb_bodegaSI.Location = New System.Drawing.Point(86, 1)
        Me.rdb_bodegaSI.Name = "rdb_bodegaSI"
        Me.rdb_bodegaSI.Size = New System.Drawing.Size(34, 17)
        Me.rdb_bodegaSI.TabIndex = 7
        Me.rdb_bodegaSI.TabStop = True
        Me.rdb_bodegaSI.Text = "Si"
        Me.rdb_bodegaSI.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(0, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Bodega"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdb_especialNo)
        Me.Panel2.Controls.Add(Me.rdb_especialSi)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(289, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 20)
        Me.Panel2.TabIndex = 6
        '
        'rdb_especialNo
        '
        Me.rdb_especialNo.AutoSize = True
        Me.rdb_especialNo.Location = New System.Drawing.Point(164, 1)
        Me.rdb_especialNo.Name = "rdb_especialNo"
        Me.rdb_especialNo.Size = New System.Drawing.Size(39, 17)
        Me.rdb_especialNo.TabIndex = 8
        Me.rdb_especialNo.TabStop = True
        Me.rdb_especialNo.Text = "No"
        Me.rdb_especialNo.UseVisualStyleBackColor = True
        '
        'rdb_especialSi
        '
        Me.rdb_especialSi.AutoSize = True
        Me.rdb_especialSi.Location = New System.Drawing.Point(86, 1)
        Me.rdb_especialSi.Name = "rdb_especialSi"
        Me.rdb_especialSi.Size = New System.Drawing.Size(34, 17)
        Me.rdb_especialSi.TabIndex = 7
        Me.rdb_especialSi.TabStop = True
        Me.rdb_especialSi.Text = "Si"
        Me.rdb_especialSi.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Especial"
        '
        'btn_agregar
        '
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_agregar.Location = New System.Drawing.Point(390, 121)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(114, 23)
        Me.btn_agregar.TabIndex = 8
        Me.btn_agregar.Text = "Guardar Equipaje"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'txt_cantbultos
        '
        Me.txt_cantbultos.Location = New System.Drawing.Point(404, 39)
        Me.txt_cantbultos.Name = "txt_cantbultos"
        Me.txt_cantbultos.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantbultos.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(286, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Cantidad de Bultos"
        '
        'txt_peso
        '
        Me.txt_peso.Location = New System.Drawing.Point(133, 39)
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.Size = New System.Drawing.Size(100, 20)
        Me.txt_peso.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Peso"
        '
        'btn_generarTarjeta
        '
        Me.btn_generarTarjeta.BackColor = System.Drawing.Color.Transparent
        Me.btn_generarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_generarTarjeta.Location = New System.Drawing.Point(202, 515)
        Me.btn_generarTarjeta.Name = "btn_generarTarjeta"
        Me.btn_generarTarjeta.Size = New System.Drawing.Size(163, 23)
        Me.btn_generarTarjeta.TabIndex = 5
        Me.btn_generarTarjeta.Text = "Guardar Tarjeta Embarque"
        Me.btn_generarTarjeta.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Transparent
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Location = New System.Drawing.Point(582, 514)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(13, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Número Pasajero"
        '
        'txt_numeroPasaje
        '
        Me.txt_numeroPasaje.Location = New System.Drawing.Point(107, 56)
        Me.txt_numeroPasaje.Name = "txt_numeroPasaje"
        Me.txt_numeroPasaje.Size = New System.Drawing.Size(100, 20)
        Me.txt_numeroPasaje.TabIndex = 8
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscar.Location = New System.Drawing.Point(582, 53)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 9
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'btn_agregarEquipaje
        '
        Me.btn_agregarEquipaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_agregarEquipaje.ForeColor = System.Drawing.Color.Transparent
        Me.btn_agregarEquipaje.Location = New System.Drawing.Point(543, 307)
        Me.btn_agregarEquipaje.Name = "btn_agregarEquipaje"
        Me.btn_agregarEquipaje.Size = New System.Drawing.Size(114, 23)
        Me.btn_agregarEquipaje.TabIndex = 10
        Me.btn_agregarEquipaje.Text = "Agregar Equipaje"
        Me.btn_agregarEquipaje.UseVisualStyleBackColor = False
        '
        'btn_nuevatarjeta
        '
        Me.btn_nuevatarjeta.BackColor = System.Drawing.Color.Transparent
        Me.btn_nuevatarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevatarjeta.Location = New System.Drawing.Point(16, 515)
        Me.btn_nuevatarjeta.Name = "btn_nuevatarjeta"
        Me.btn_nuevatarjeta.Size = New System.Drawing.Size(163, 23)
        Me.btn_nuevatarjeta.TabIndex = 11
        Me.btn_nuevatarjeta.Text = "Nueva Tarjeta Embarque"
        Me.btn_nuevatarjeta.UseVisualStyleBackColor = False
        '
        'frm_tarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Fondo_de_ventana_grande
        Me.ClientSize = New System.Drawing.Size(676, 550)
        Me.Controls.Add(Me.btn_nuevatarjeta)
        Me.Controls.Add(Me.btn_agregarEquipaje)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_numeroPasaje)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_generarTarjeta)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_numeroVuelo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gb_pasajero)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_tarjeta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarjeta Embarque"
        Me.gb_pasajero.ResumeLayout(False)
        Me.gb_pasajero.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_pasajero As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_numeroVuelo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_idPasajero As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdb_AeNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_AeSI As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_numeroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_letraAsiento As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_numAsiento As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rdb_especialNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_especialSi As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_cantbultos As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_peso As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_generarTarjeta As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_numeroPasaje As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rdb_bodegaNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_bodegaSI As System.Windows.Forms.RadioButton
    Friend WithEvents btn_agregarEquipaje As System.Windows.Forms.Button
    Friend WithEvents btn_nuevatarjeta As System.Windows.Forms.Button
End Class
