namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMostrarOcultar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.BtnMostrarOcultar);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.BtnIngresar);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.TxtUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(67, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 257);
            this.panel1.TabIndex = 1;
            // 
            // BtnMostrarOcultar
            // 
            this.BtnMostrarOcultar.BackColor = System.Drawing.Color.Transparent;
            this.BtnMostrarOcultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMostrarOcultar.BackgroundImage")));
            this.BtnMostrarOcultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMostrarOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMostrarOcultar.FlatAppearance.BorderSize = 0;
            this.BtnMostrarOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarOcultar.Location = new System.Drawing.Point(286, 96);
            this.BtnMostrarOcultar.Name = "BtnMostrarOcultar";
            this.BtnMostrarOcultar.Size = new System.Drawing.Size(35, 23);
            this.BtnMostrarOcultar.TabIndex = 6;
            this.BtnMostrarOcultar.UseVisualStyleBackColor = false;
            this.BtnMostrarOcultar.Click += new System.EventHandler(this.BtnMostrarOcultar_Click);
            this.BtnMostrarOcultar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnMostrarOcultar_MouseDown);
            this.BtnMostrarOcultar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnMostrarOcultar_MouseUp);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.BackgroundImage")));
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.ImageKey = "(ninguno)";
            this.BtnSalir.Location = new System.Drawing.Point(204, 175);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 55);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip2.SetToolTip(this.BtnSalir, "Cierra el programa");
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.BtnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIngresar.BackgroundImage")));
            this.BtnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.ForeColor = System.Drawing.Color.Black;
            this.BtnIngresar.ImageKey = "(ninguno)";
            this.BtnIngresar.Location = new System.Drawing.Point(82, 175);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 55);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.BtnIngresar, "Presiones para iniciar sesión");
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtPassword.Location = new System.Drawing.Point(81, 96);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(198, 24);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.Text = "Contraseña";
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            this.TxtPassword.LostFocus += new System.EventHandler(this.TxtPassword_LostFocus);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtUsuario.Location = new System.Drawing.Point(81, 57);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(198, 24);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.Text = "Usuario";
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsuario_KeyDown);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            this.TxtUsuario.LostFocus += new System.EventHandler(this.TxtUsuario_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Por favor, inicie sesión en el sistema";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Inicio de Sesión";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipTitle = "Salir del sistema";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 391);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Iniciar sesíon";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button BtnMostrarOcultar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}