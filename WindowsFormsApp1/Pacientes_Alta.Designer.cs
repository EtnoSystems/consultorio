namespace WindowsFormsApp1
{
    partial class Pacientes_Alta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtAfiliado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPNacimiento = new System.Windows.Forms.DateTimePicker();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.ChkLstObrasSociales = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtPiso = new System.Windows.Forms.TextBox();
            this.TxtDepto = new System.Windows.Forms.TextBox();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.CmbCiudad = new System.Windows.Forms.ComboBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnAgregarOtra = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.ForeColor = System.Drawing.Color.Silver;
            this.TxtApellido.Location = new System.Drawing.Point(236, 45);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(167, 24);
            this.TxtApellido.TabIndex = 2;
            this.TxtApellido.Text = "Apellido";
            this.TxtApellido.Enter += new System.EventHandler(this.TxtApellido_Enter);
            this.TxtApellido.Leave += new System.EventHandler(this.TxtApellido_Leave);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.Silver;
            this.TxtNombre.Location = new System.Drawing.Point(23, 45);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(207, 24);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.Text = "Nombre";
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.Enter += new System.EventHandler(this.TxtNombre_Enter);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.TxtAfiliado);
            this.panel1.Controls.Add(this.TxtApellido);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.DTPNacimiento);
            this.panel1.Controls.Add(this.CmbSexo);
            this.panel1.Controls.Add(this.ChkLstObrasSociales);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.TxtDNI);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.BtnAgregarOtra);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(46, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 592);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TxtAfiliado
            // 
            this.TxtAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAfiliado.ForeColor = System.Drawing.Color.Silver;
            this.TxtAfiliado.Location = new System.Drawing.Point(27, 395);
            this.TxtAfiliado.Name = "TxtAfiliado";
            this.TxtAfiliado.Size = new System.Drawing.Size(376, 24);
            this.TxtAfiliado.TabIndex = 24;
            this.TxtAfiliado.Text = "Número de afiliado";
            this.TxtAfiliado.TextChanged += new System.EventHandler(this.TxtAfiliado_TextChanged);
            this.TxtAfiliado.Enter += new System.EventHandler(this.TxtAfiliado_Enter);
            this.TxtAfiliado.Leave += new System.EventHandler(this.TxtAfiliado_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // DTPNacimiento
            // 
            this.DTPNacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPNacimiento.Location = new System.Drawing.Point(23, 129);
            this.DTPNacimiento.MinDate = new System.DateTime(2018, 5, 27, 0, 0, 0, 0);
            this.DTPNacimiento.Name = "DTPNacimiento";
            this.DTPNacimiento.Size = new System.Drawing.Size(326, 24);
            this.DTPNacimiento.TabIndex = 5;
            // 
            // CmbSexo
            // 
            this.CmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Location = new System.Drawing.Point(236, 75);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(166, 26);
            this.CmbSexo.TabIndex = 4;
            this.CmbSexo.SelectedIndexChanged += new System.EventHandler(this.CmbSexo_SelectedIndexChanged);
            // 
            // ChkLstObrasSociales
            // 
            this.ChkLstObrasSociales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkLstObrasSociales.FormattingEnabled = true;
            this.ChkLstObrasSociales.Items.AddRange(new object[] {
            "Iosper",
            "Jerárquico Salud",
            "Osecac ",
            "Osprera"});
            this.ChkLstObrasSociales.Location = new System.Drawing.Point(111, 425);
            this.ChkLstObrasSociales.Name = "ChkLstObrasSociales";
            this.ChkLstObrasSociales.Size = new System.Drawing.Size(213, 61);
            this.ChkLstObrasSociales.Sorted = true;
            this.ChkLstObrasSociales.TabIndex = 13;
            this.ChkLstObrasSociales.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChkLstObrasSociales_ItemCheck);
            this.ChkLstObrasSociales.SelectedIndexChanged += new System.EventHandler(this.ChkLstObrasSociales_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TxtNumero);
            this.groupBox1.Controls.Add(this.TxtPiso);
            this.groupBox1.Controls.Add(this.TxtDepto);
            this.groupBox1.Controls.Add(this.TxtCelular);
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.Controls.Add(this.CmbCiudad);
            this.groupBox1.Controls.Add(this.TxtTelefono);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 208);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de contacto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.ForeColor = System.Drawing.Color.Silver;
            this.TxtNumero.Location = new System.Drawing.Point(228, 161);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(68, 24);
            this.TxtNumero.TabIndex = 11;
            this.TxtNumero.Text = "Nro.";
            this.TxtNumero.TextChanged += new System.EventHandler(this.TxtNumero_TextChanged);
            // 
            // TxtPiso
            // 
            this.TxtPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPiso.ForeColor = System.Drawing.Color.Silver;
            this.TxtPiso.Location = new System.Drawing.Point(302, 161);
            this.TxtPiso.Name = "TxtPiso";
            this.TxtPiso.Size = new System.Drawing.Size(48, 24);
            this.TxtPiso.TabIndex = 12;
            this.TxtPiso.Text = "Piso";
            this.TxtPiso.Enter += new System.EventHandler(this.TxtPiso_Enter);
            this.TxtPiso.Leave += new System.EventHandler(this.TxtPiso_Leave);
            // 
            // TxtDepto
            // 
            this.TxtDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDepto.ForeColor = System.Drawing.Color.Silver;
            this.TxtDepto.Location = new System.Drawing.Point(356, 161);
            this.TxtDepto.Name = "TxtDepto";
            this.TxtDepto.Size = new System.Drawing.Size(49, 24);
            this.TxtDepto.TabIndex = 13;
            this.TxtDepto.Text = "Dpto";
            this.TxtDepto.Enter += new System.EventHandler(this.TxtDepto_Enter);
            this.TxtDepto.Leave += new System.EventHandler(this.TxtDepto_Leave);
            // 
            // TxtCelular
            // 
            this.TxtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelular.ForeColor = System.Drawing.Color.Silver;
            this.TxtCelular.Location = new System.Drawing.Point(212, 32);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(193, 24);
            this.TxtCelular.TabIndex = 7;
            this.TxtCelular.Text = "Celular";
            this.TxtCelular.Enter += new System.EventHandler(this.TxtCelular_Enter);
            this.TxtCelular.Leave += new System.EventHandler(this.TxtCelular_Leave);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.ForeColor = System.Drawing.Color.Silver;
            this.TxtDireccion.Location = new System.Drawing.Point(15, 161);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(207, 24);
            this.TxtDireccion.TabIndex = 10;
            this.TxtDireccion.Text = "Dirección";
            this.TxtDireccion.Enter += new System.EventHandler(this.TxtDireccion_Enter);
            this.TxtDireccion.Leave += new System.EventHandler(this.TxtDireccion_Leave);
            // 
            // CmbCiudad
            // 
            this.CmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCiudad.FormattingEnabled = true;
            this.CmbCiudad.Location = new System.Drawing.Point(15, 118);
            this.CmbCiudad.Name = "CmbCiudad";
            this.CmbCiudad.Size = new System.Drawing.Size(257, 26);
            this.CmbCiudad.TabIndex = 9;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.ForeColor = System.Drawing.Color.Silver;
            this.TxtTelefono.Location = new System.Drawing.Point(15, 32);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(164, 24);
            this.TxtTelefono.TabIndex = 6;
            this.TxtTelefono.Text = "Teléfono";
            this.TxtTelefono.Enter += new System.EventHandler(this.TxtTelefono_Enter);
            this.TxtTelefono.Leave += new System.EventHandler(this.TxtTelefono_Leave);
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMail.ForeColor = System.Drawing.Color.Silver;
            this.TxtMail.Location = new System.Drawing.Point(15, 75);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(254, 24);
            this.TxtMail.TabIndex = 8;
            this.TxtMail.Text = "E-Mail";
            this.TxtMail.Enter += new System.EventHandler(this.TxtMail_Enter);
            this.TxtMail.Leave += new System.EventHandler(this.TxtMail_Leave);
            // 
            // TxtDNI
            // 
            this.TxtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDNI.ForeColor = System.Drawing.Color.Silver;
            this.TxtDNI.Location = new System.Drawing.Point(22, 75);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(207, 24);
            this.TxtDNI.TabIndex = 3;
            this.TxtDNI.Text = "Documento";
            this.TxtDNI.Enter += new System.EventHandler(this.TxtDNI_Enter);
            this.TxtDNI.Leave += new System.EventHandler(this.TxtDNI_Leave);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.botonGuardar2;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(36, 507);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(70, 69);
            this.BtnAgregar.TabIndex = 14;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnAgregarOtra
            // 
            this.BtnAgregarOtra.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarOtra.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.botonGuardarAgregarDeshabilitado;
            this.BtnAgregarOtra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarOtra.FlatAppearance.BorderSize = 0;
            this.BtnAgregarOtra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarOtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarOtra.Location = new System.Drawing.Point(182, 507);
            this.BtnAgregarOtra.Name = "BtnAgregarOtra";
            this.BtnAgregarOtra.Size = new System.Drawing.Size(67, 69);
            this.BtnAgregarOtra.TabIndex = 15;
            this.BtnAgregarOtra.UseVisualStyleBackColor = false;
            this.BtnAgregarOtra.Click += new System.EventHandler(this.BtnAgregarOtra_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.checkout;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(314, 507);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 78);
            this.BtnSalir.TabIndex = 16;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar pacientes al sistema";
            // 
            // Pacientes_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fondoFormularios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(537, 625);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pacientes_Alta";
            this.Text = "Alta de pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Alta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox ChkLstObrasSociales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtPiso;
        private System.Windows.Forms.TextBox TxtDepto;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.ComboBox CmbCiudad;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnAgregarOtra;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtAfiliado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPNacimiento;
    }
}