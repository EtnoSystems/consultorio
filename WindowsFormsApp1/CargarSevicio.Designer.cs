namespace WindowsFormsApp1
{
    partial class CargarSevicio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbObraSocial = new System.Windows.Forms.ComboBox();
            this.ChkOrden = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblCostoConsulta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbMedico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAsentarServicio = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LblNombrePaciente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblReintegro = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "PACIENTE:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CmbObraSocial);
            this.groupBox1.Controls.Add(this.ChkOrden);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obra Social";
            // 
            // CmbObraSocial
            // 
            this.CmbObraSocial.FormattingEnabled = true;
            this.CmbObraSocial.Location = new System.Drawing.Point(18, 33);
            this.CmbObraSocial.Name = "CmbObraSocial";
            this.CmbObraSocial.Size = new System.Drawing.Size(178, 26);
            this.CmbObraSocial.TabIndex = 1;
            // 
            // ChkOrden
            // 
            this.ChkOrden.AutoSize = true;
            this.ChkOrden.Location = new System.Drawing.Point(212, 35);
            this.ChkOrden.Name = "ChkOrden";
            this.ChkOrden.Size = new System.Drawing.Size(134, 22);
            this.ChkOrden.TabIndex = 0;
            this.ChkOrden.Text = "¿Tiene orden?";
            this.ChkOrden.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "COSTO TOTAL DEL SERVICIO";
           
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.LblCostoConsulta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CmbMedico);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Médico tratante";
            // 
            // LblCostoConsulta
            // 
            this.LblCostoConsulta.AutoSize = true;
            this.LblCostoConsulta.BackColor = System.Drawing.Color.Transparent;
            this.LblCostoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCostoConsulta.Location = new System.Drawing.Point(246, 41);
            this.LblCostoConsulta.Name = "LblCostoConsulta";
            this.LblCostoConsulta.Size = new System.Drawing.Size(51, 18);
            this.LblCostoConsulta.TabIndex = 4;
            this.LblCostoConsulta.Text = "costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo consulta";
            // 
            // CmbMedico
            // 
            this.CmbMedico.FormattingEnabled = true;
            this.CmbMedico.Location = new System.Drawing.Point(18, 33);
            this.CmbMedico.Name = "CmbMedico";
            this.CmbMedico.Size = new System.Drawing.Size(178, 26);
            this.CmbMedico.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "$";
            // 
            // BtnAsentarServicio
            // 
            this.BtnAsentarServicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnAsentarServicio.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ServiceButton;
            this.BtnAsentarServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAsentarServicio.FlatAppearance.BorderSize = 0;
            this.BtnAsentarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAsentarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsentarServicio.Location = new System.Drawing.Point(81, 400);
            this.BtnAsentarServicio.Name = "BtnAsentarServicio";
            this.BtnAsentarServicio.Size = new System.Drawing.Size(87, 83);
            this.BtnAsentarServicio.TabIndex = 5;
            this.toolTip1.SetToolTip(this.BtnAsentarServicio, "Asentar el servicio");
            this.BtnAsentarServicio.UseVisualStyleBackColor = false;
            this.BtnAsentarServicio.Click += new System.EventHandler(this.BtnAsentarServicio_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "REINTEGRO POR ORDEN";
            // 
            // LblNombrePaciente
            // 
            this.LblNombrePaciente.AutoSize = true;
            this.LblNombrePaciente.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePaciente.Location = new System.Drawing.Point(30, 35);
            this.LblNombrePaciente.Name = "LblNombrePaciente";
            this.LblNombrePaciente.Size = new System.Drawing.Size(168, 24);
            this.LblNombrePaciente.TabIndex = 9;
            this.LblNombrePaciente.Text = "nombre paciente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(34, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.checkout;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(273, 400);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(87, 83);
            this.BtnSalir.TabIndex = 11;
            this.toolTip1.SetToolTip(this.BtnSalir, "Salir de este menú");
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(302, 307);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(58, 22);
            this.LblTotal.TabIndex = 13;
            this.LblTotal.Text = "costo";
            // 
            // LblReintegro
            // 
            this.LblReintegro.AutoSize = true;
            this.LblReintegro.BackColor = System.Drawing.Color.Salmon;
            this.LblReintegro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReintegro.Location = new System.Drawing.Point(302, 337);
            this.LblReintegro.Name = "LblReintegro";
            this.LblReintegro.Size = new System.Drawing.Size(58, 22);
            this.LblReintegro.TabIndex = 15;
            this.LblReintegro.Text = "costo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "$";
            // 
            // CargarSevicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fondoFormularios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 522);
            this.Controls.Add(this.LblReintegro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblNombrePaciente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnAsentarServicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CargarSevicio";
            this.Text = "Cargar servicio";
            this.Load += new System.EventHandler(this.CargarSevicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbObraSocial;
        private System.Windows.Forms.CheckBox ChkOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAsentarServicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblCostoConsulta;
        private System.Windows.Forms.Label LblNombrePaciente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblReintegro;
        private System.Windows.Forms.Label label9;
    }
}