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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.TxtEspecialidad = new System.Windows.Forms.TextBox();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnAgregarOtra = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 14);
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
            this.TxtDNI.Location = new System.Drawing.Point(43, 117);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(207, 24);
            this.TxtDNI.TabIndex = 3;
            this.TxtDNI.Text = "Documento";
            // 
            // TxtEspecialidad
            // 
            this.TxtEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEspecialidad.ForeColor = System.Drawing.Color.Silver;
            this.TxtEspecialidad.Location = new System.Drawing.Point(43, 186);
            this.TxtEspecialidad.Name = "TxtEspecialidad";
            this.TxtEspecialidad.Size = new System.Drawing.Size(257, 24);
            this.TxtEspecialidad.TabIndex = 4;
            this.TxtEspecialidad.Text = "Especialidad";
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMatricula.ForeColor = System.Drawing.Color.Silver;
            this.TxtMatricula.Location = new System.Drawing.Point(306, 186);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(117, 24);
            this.TxtMatricula.TabIndex = 5;
            this.TxtMatricula.Text = "Matrícula";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.ForeColor = System.Drawing.Color.Silver;
            this.TxtTelefono.Location = new System.Drawing.Point(256, 117);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(167, 24);
            this.TxtTelefono.TabIndex = 6;
            this.TxtTelefono.Text = "Teléfono";
            // 
            // TxtValor
            // 
            this.TxtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValor.ForeColor = System.Drawing.Color.Silver;
            this.TxtValor.Location = new System.Drawing.Point(122, 217);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(169, 24);
            this.TxtValor.TabIndex = 7;
            this.TxtValor.Text = "Valor de la consulta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.BtnAgregarOtra);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.TxtValor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 391);
            this.panel1.TabIndex = 10;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.botonGuardar2;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(35, 283);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(70, 69);
            this.BtnAgregar.TabIndex = 9;
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
            this.BtnAgregarOtra.Location = new System.Drawing.Point(181, 283);
            this.BtnAgregarOtra.Name = "BtnAgregarOtra";
            this.BtnAgregarOtra.Size = new System.Drawing.Size(67, 69);
            this.BtnAgregarOtra.TabIndex = 10;
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
            this.BtnSalir.Location = new System.Drawing.Point(313, 283);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 78);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Medicos_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fondoFormularios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(491, 441);
            this.ControlBox = false;
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.TxtEspecialidad);
            this.Controls.Add(this.TxtDNI);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Medicos_Alta";
            this.Text = "Alta de médicos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.TextBox TxtEspecialidad;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnAgregarOtra;
        private System.Windows.Forms.Button BtnSalir;
    }
}