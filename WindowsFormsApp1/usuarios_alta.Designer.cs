namespace WindowsFormsApp1
{
    partial class Usuarios_alta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios_alta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.TxtPassword2 = new System.Windows.Forms.TextBox();
            this.TxtPassword1 = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGuardarAgregar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.CmbTipo);
            this.panel1.Controls.Add(this.TxtPassword2);
            this.panel1.Controls.Add(this.TxtPassword1);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(144, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 475);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seleccionar tipo de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cargar nuevos usuarios  al sistema";
            // 
            // btnGuardarAgregar
            // 
            this.btnGuardarAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarAgregar.BackgroundImage")));
            this.btnGuardarAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAgregar.FlatAppearance.BorderSize = 0;
            this.btnGuardarAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAgregar.Location = new System.Drawing.Point(135, 399);
            this.btnGuardarAgregar.Name = "btnGuardarAgregar";
            this.btnGuardarAgregar.Size = new System.Drawing.Size(79, 58);
            this.btnGuardarAgregar.TabIndex = 7;
            this.btnGuardarAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnGuardarAgregar, "Guardar datos y agregar otro usuario");
            this.btnGuardarAgregar.UseVisualStyleBackColor = false;
            this.btnGuardarAgregar.Click += new System.EventHandler(this.btnGuardarAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.ImageKey = "(ninguno)";
            this.btnSalir.Location = new System.Drawing.Point(220, 397);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 60);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir sin guardar");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(38, 397);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(79, 58);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar los datos del nuevo usuario");
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "Administrativo",
            "Atención el público",
            "Otro"});
            this.CmbTipo.Location = new System.Drawing.Point(38, 276);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(173, 26);
            this.CmbTipo.TabIndex = 5;
            this.toolTip1.SetToolTip(this.CmbTipo, "Seleccione el tipo de usuario");
            this.CmbTipo.SelectedIndexChanged += new System.EventHandler(this.CmbTipo_SelectedIndexChanged);
            this.CmbTipo.DropDownClosed += new System.EventHandler(this.CmbTipo_DropDownClosed);
            this.CmbTipo.Click += new System.EventHandler(this.CmbTipo_Click);
            // 
            // TxtPassword2
            // 
            this.TxtPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword2.ForeColor = System.Drawing.Color.Silver;
            this.TxtPassword2.Location = new System.Drawing.Point(38, 211);
            this.TxtPassword2.Name = "TxtPassword2";
            this.TxtPassword2.Size = new System.Drawing.Size(261, 24);
            this.TxtPassword2.TabIndex = 4;
            this.TxtPassword2.Text = "Repita la contraseña";
            this.toolTip1.SetToolTip(this.TxtPassword2, "Repita la contraseña ingresada");
            this.TxtPassword2.TextChanged += new System.EventHandler(this.TxtPassword2_TextChanged);
            this.TxtPassword2.Enter += new System.EventHandler(this.TxtPassword2_Enter);
            this.TxtPassword2.Leave += new System.EventHandler(this.TxtPassword2_Leave);
            this.TxtPassword2.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassword2_Validating);
            // 
            // TxtPassword1
            // 
            this.TxtPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword1.ForeColor = System.Drawing.Color.Silver;
            this.TxtPassword1.Location = new System.Drawing.Point(38, 171);
            this.TxtPassword1.Name = "TxtPassword1";
            this.TxtPassword1.Size = new System.Drawing.Size(261, 24);
            this.TxtPassword1.TabIndex = 3;
            this.TxtPassword1.Text = "Contraseña";
            this.toolTip1.SetToolTip(this.TxtPassword1, "Ingrese la contraseña");
            this.TxtPassword1.TextChanged += new System.EventHandler(this.TxtPassword1_TextChanged);
            this.TxtPassword1.Enter += new System.EventHandler(this.TxtPassword1_Enter);
            this.TxtPassword1.Leave += new System.EventHandler(this.TxtPassword1_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(38, 103);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(173, 24);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Nombre de usuario";
            this.toolTip1.SetToolTip(this.txtUsuario, "Ingrese el nombre de usuario");
            this.txtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUsuario_Validating);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Silver;
            this.txtNombre.Location = new System.Drawing.Point(38, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre completo";
            this.toolTip1.SetToolTip(this.txtNombre, "Ingrese el nombre completo");
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.txtNombre.Enter += new System.EventHandler(this.TxtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Usuarios_alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 546);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Usuarios_alta";
            this.Text = "Alta de usuarios";
            this.Load += new System.EventHandler(this.Usuarios_alta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox TxtPassword2;
        private System.Windows.Forms.TextBox TxtPassword1;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardarAgregar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
    }
}