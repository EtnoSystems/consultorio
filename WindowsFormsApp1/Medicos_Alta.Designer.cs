namespace WindowsFormsApp1
{
    partial class Medicos_Alta
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkLstEspecialidad = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRetencion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPiso = new System.Windows.Forms.TextBox();
            this.TxtDepto = new System.Windows.Forms.TextBox();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.CmbCiudad = new System.Windows.Forms.ComboBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnAgregarOtra = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar nuevos profesionales médicos al sistema";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.Silver;
            this.TxtNombre.Location = new System.Drawing.Point(43, 69);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(207, 24);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.Text = "Nombre";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.ForeColor = System.Drawing.Color.Silver;
            this.TxtApellido.Location = new System.Drawing.Point(256, 69);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(167, 24);
            this.TxtApellido.TabIndex = 2;
            this.TxtApellido.Text = "Apellido";
            // 
            // TxtDNI
            // 
            this.TxtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDNI.ForeColor = System.Drawing.Color.Silver;
            this.TxtDNI.Location = new System.Drawing.Point(22, 88);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(207, 24);
            this.TxtDNI.TabIndex = 3;
            this.TxtDNI.Text = "Documento";
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMatricula.ForeColor = System.Drawing.Color.Silver;
            this.TxtMatricula.Location = new System.Drawing.Point(285, 361);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(117, 24);
            this.TxtMatricula.TabIndex = 14;
            this.TxtMatricula.Text = "Matrícula";
            // 
            // TxtValor
            // 
            this.TxtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValor.ForeColor = System.Drawing.Color.Silver;
            this.TxtValor.Location = new System.Drawing.Point(91, 411);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(169, 24);
            this.TxtValor.TabIndex = 15;
            this.TxtValor.Text = "Valor de la consulta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.CmbSexo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ChkLstEspecialidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtRetencion);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.TxtDNI);
            this.panel1.Controls.Add(this.TxtMatricula);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.BtnAgregarOtra);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.TxtValor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 568);
            this.panel1.TabIndex = 10;
            // 
            // CmbSexo
            // 
            this.CmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CmbSexo.Location = new System.Drawing.Point(236, 86);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(166, 26);
            this.CmbSexo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "%";
            // 
            // ChkLstEspecialidad
            // 
            this.ChkLstEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkLstEspecialidad.FormattingEnabled = true;
            this.ChkLstEspecialidad.Items.AddRange(new object[] {
            "Anestecista",
            "Cirujano",
            "Médico general"});
            this.ChkLstEspecialidad.Location = new System.Drawing.Point(32, 363);
            this.ChkLstEspecialidad.Name = "ChkLstEspecialidad";
            this.ChkLstEspecialidad.Size = new System.Drawing.Size(213, 23);
            this.ChkLstEspecialidad.Sorted = true;
            this.ChkLstEspecialidad.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "%";
            // 
            // TxtRetencion
            // 
            this.TxtRetencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRetencion.ForeColor = System.Drawing.Color.Silver;
            this.TxtRetencion.Location = new System.Drawing.Point(275, 411);
            this.TxtRetencion.Name = "TxtRetencion";
            this.TxtRetencion.Size = new System.Drawing.Size(36, 24);
            this.TxtRetencion.TabIndex = 16;
            this.toolTip1.SetToolTip(this.TxtRetencion, "Porcentaje de retención para inquilinos de consultorios");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.TxtPiso);
            this.groupBox1.Controls.Add(this.TxtDepto);
            this.groupBox1.Controls.Add(this.TxtCelular);
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.Controls.Add(this.CmbCiudad);
            this.groupBox1.Controls.Add(this.TxtTelefono);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 208);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de contacto";
            // 
            // TxtPiso
            // 
            this.TxtPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPiso.ForeColor = System.Drawing.Color.Silver;
            this.TxtPiso.Location = new System.Drawing.Point(341, 161);
            this.TxtPiso.Name = "TxtPiso";
            this.TxtPiso.Size = new System.Drawing.Size(48, 24);
            this.TxtPiso.TabIndex = 12;
            this.TxtPiso.Text = "Piso";
            // 
            // TxtDepto
            // 
            this.TxtDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDepto.ForeColor = System.Drawing.Color.Silver;
            this.TxtDepto.Location = new System.Drawing.Point(284, 161);
            this.TxtDepto.Name = "TxtDepto";
            this.TxtDepto.Size = new System.Drawing.Size(51, 24);
            this.TxtDepto.TabIndex = 11;
            this.TxtDepto.Text = "Dpto";
            // 
            // TxtCelular
            // 
            this.TxtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelular.ForeColor = System.Drawing.Color.Silver;
            this.TxtCelular.Location = new System.Drawing.Point(212, 32);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(161, 24);
            this.TxtCelular.TabIndex = 6;
            this.TxtCelular.Text = "Celular";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.ForeColor = System.Drawing.Color.Silver;
            this.TxtDireccion.Location = new System.Drawing.Point(15, 161);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(207, 24);
            this.TxtDireccion.TabIndex = 9;
            this.TxtDireccion.Text = "Dirección";
            // 
            // CmbCiudad
            // 
            this.CmbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCiudad.FormattingEnabled = true;
            this.CmbCiudad.Location = new System.Drawing.Point(15, 118);
            this.CmbCiudad.Name = "CmbCiudad";
            this.CmbCiudad.Size = new System.Drawing.Size(257, 26);
            this.CmbCiudad.TabIndex = 8;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.ForeColor = System.Drawing.Color.Silver;
            this.TxtTelefono.Location = new System.Drawing.Point(15, 32);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(164, 24);
            this.TxtTelefono.TabIndex = 5;
            this.TxtTelefono.Text = "Teléfono";
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMail.ForeColor = System.Drawing.Color.Silver;
            this.TxtMail.Location = new System.Drawing.Point(15, 75);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(254, 24);
            this.TxtMail.TabIndex = 7;
            this.TxtMail.Text = "E-Mail";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.botonGuardar2;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(32, 476);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(70, 69);
            this.BtnAgregar.TabIndex = 17;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregarOtra
            // 
            this.BtnAgregarOtra.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarOtra.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.botonGuardarAgregarDeshabilitado;
            this.BtnAgregarOtra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarOtra.FlatAppearance.BorderSize = 0;
            this.BtnAgregarOtra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarOtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarOtra.Location = new System.Drawing.Point(178, 476);
            this.BtnAgregarOtra.Name = "BtnAgregarOtra";
            this.BtnAgregarOtra.Size = new System.Drawing.Size(67, 69);
            this.BtnAgregarOtra.TabIndex = 18;
            this.BtnAgregarOtra.UseVisualStyleBackColor = false;
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
            this.BtnSalir.Location = new System.Drawing.Point(310, 476);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 78);
            this.BtnSalir.TabIndex = 19;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(228, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 24);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Nro.";
            // 
            // Medicos_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fondoFormularios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 617);
            this.ControlBox = false;
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Medicos_Alta";
            this.Text = "Alta de médicos";
            this.Load += new System.EventHandler(this.Medicos_Alta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnAgregarOtra;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.ComboBox CmbCiudad;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtPiso;
        private System.Windows.Forms.TextBox TxtDepto;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRetencion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckedListBox ChkLstEspecialidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.TextBox textBox1;
    }
}