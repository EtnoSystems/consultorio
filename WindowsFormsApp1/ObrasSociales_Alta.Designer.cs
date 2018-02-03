namespace WindowsFormsApp1
{
    partial class ObrasSociales_alta
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDenominacion = new System.Windows.Forms.TextBox();
            this.ChkActiva = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TxtPlus = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnAgregarOtra = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar una nueva obra social";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.Silver;
            this.TxtNombre.Location = new System.Drawing.Point(66, 75);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(194, 24);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.Text = "Nombre";
            this.TxtNombre.Enter += new System.EventHandler(this.TxtNombre_Enter);
            // 
            // TxtDenominacion
            // 
            this.TxtDenominacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDenominacion.ForeColor = System.Drawing.Color.Silver;
            this.TxtDenominacion.Location = new System.Drawing.Point(66, 117);
            this.TxtDenominacion.Name = "TxtDenominacion";
            this.TxtDenominacion.Size = new System.Drawing.Size(353, 24);
            this.TxtDenominacion.TabIndex = 2;
            this.TxtDenominacion.Text = "Denominación";
            this.TxtDenominacion.Enter += new System.EventHandler(this.TxtDenominacion_Enter);
            // 
            // ChkActiva
            // 
            this.ChkActiva.AutoSize = true;
            this.ChkActiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChkActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActiva.Location = new System.Drawing.Point(226, 160);
            this.ChkActiva.Name = "ChkActiva";
            this.ChkActiva.Size = new System.Drawing.Size(193, 22);
            this.ChkActiva.TabIndex = 4;
            this.ChkActiva.Text = "¿Se encuentra activa?";
            this.toolTip1.SetToolTip(this.ChkActiva, "Indique si la obra social está activa actualmente tildando la casilla o dejándola" +
        " vacía para indicar si está interrumpida");
            this.ChkActiva.UseVisualStyleBackColor = false;
            // 
            // TxtPlus
            // 
            this.TxtPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlus.ForeColor = System.Drawing.Color.Silver;
            this.TxtPlus.Location = new System.Drawing.Point(66, 158);
            this.TxtPlus.Name = "TxtPlus";
            this.TxtPlus.Size = new System.Drawing.Size(139, 24);
            this.TxtPlus.TabIndex = 3;
            this.TxtPlus.Text = "Plus";
            this.toolTip1.SetToolTip(this.TxtPlus, "Indique el monto que los usuarios de esta obra social deben abonar (0 siginifica " +
        "que no pagan)");
            this.TxtPlus.TextChanged += new System.EventHandler(this.TxtPlus_TextChanged);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.ForeColor = System.Drawing.Color.Silver;
            this.TxtDireccion.Location = new System.Drawing.Point(18, 35);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(313, 24);
            this.TxtDireccion.TabIndex = 5;
            this.TxtDireccion.Text = "Dirección";
            this.toolTip1.SetToolTip(this.TxtDireccion, "Indique el monto que los usuarios de esta obra social deben abonar (0 siginifica " +
        "que no pagan)");
            this.TxtDireccion.TextChanged += new System.EventHandler(this.TxtDireccion_TextChanged);
            this.TxtDireccion.Enter += new System.EventHandler(this.TxtDireccion_Enter);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.ForeColor = System.Drawing.Color.Silver;
            this.TxtTelefono.Location = new System.Drawing.Point(18, 74);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(137, 24);
            this.TxtTelefono.TabIndex = 6;
            this.TxtTelefono.Text = "Teléfono";
            this.toolTip1.SetToolTip(this.TxtTelefono, "Indique el monto que los usuarios de esta obra social deben abonar (0 siginifica " +
        "que no pagan)");
            this.TxtTelefono.Enter += new System.EventHandler(this.TxtTelefono_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.TxtTelefono);
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de contacto";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAgregar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.botonGuardar2;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(66, 370);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(70, 69);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnAgregarOtra
            // 
            this.BtnAgregarOtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAgregarOtra.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.botonGuardarAgregarDeshabilitado;
            this.BtnAgregarOtra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarOtra.FlatAppearance.BorderSize = 0;
            this.BtnAgregarOtra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarOtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarOtra.Location = new System.Drawing.Point(210, 370);
            this.BtnAgregarOtra.Name = "BtnAgregarOtra";
            this.BtnAgregarOtra.Size = new System.Drawing.Size(67, 69);
            this.BtnAgregarOtra.TabIndex = 7;
            this.BtnAgregarOtra.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSalir.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.checkout;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(344, 370);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 78);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(49, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 449);
            this.panel1.TabIndex = 9;
            // 
            // ObrasSociales_alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fondoFormularios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 477);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAgregarOtra);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtPlus);
            this.Controls.Add(this.ChkActiva);
            this.Controls.Add(this.TxtDenominacion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ObrasSociales_alta";
            this.Text = "Agregar Obras Sociales";
            this.Load += new System.EventHandler(this.ObrasSociales_alta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox TxtPlus;
        private System.Windows.Forms.CheckBox ChkActiva;
        private System.Windows.Forms.TextBox TxtDenominacion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAgregarOtra;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Panel panel1;
    }
}