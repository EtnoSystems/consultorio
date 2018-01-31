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
            this.cmbObraSocial = new System.Windows.Forms.ComboBox();
            this.chkOrden = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCostoConsulta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAsentarServicio = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAsentarYCargarOtro = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblReintegro = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.cmbObraSocial);
            this.groupBox1.Controls.Add(this.chkOrden);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obra Social";
            // 
            // cmbObraSocial
            // 
            this.cmbObraSocial.FormattingEnabled = true;
            this.cmbObraSocial.Location = new System.Drawing.Point(18, 33);
            this.cmbObraSocial.Name = "cmbObraSocial";
            this.cmbObraSocial.Size = new System.Drawing.Size(178, 26);
            this.cmbObraSocial.TabIndex = 1;
            // 
            // chkOrden
            // 
            this.chkOrden.AutoSize = true;
            this.chkOrden.Location = new System.Drawing.Point(212, 35);
            this.chkOrden.Name = "chkOrden";
            this.chkOrden.Size = new System.Drawing.Size(134, 22);
            this.chkOrden.TabIndex = 0;
            this.chkOrden.Text = "¿Tiene orden?";
            this.chkOrden.UseVisualStyleBackColor = true;
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblCostoConsulta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbMedico);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Médico tratante";
            // 
            // lblCostoConsulta
            // 
            this.lblCostoConsulta.AutoSize = true;
            this.lblCostoConsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblCostoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoConsulta.Location = new System.Drawing.Point(246, 41);
            this.lblCostoConsulta.Name = "lblCostoConsulta";
            this.lblCostoConsulta.Size = new System.Drawing.Size(51, 18);
            this.lblCostoConsulta.TabIndex = 4;
            this.lblCostoConsulta.Text = "costo";
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
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(18, 33);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(178, 26);
            this.cmbMedico.TabIndex = 1;
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
            // btnAsentarServicio
            // 
            this.btnAsentarServicio.BackColor = System.Drawing.Color.Transparent;
            this.btnAsentarServicio.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ServiceButton;
            this.btnAsentarServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsentarServicio.FlatAppearance.BorderSize = 0;
            this.btnAsentarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsentarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsentarServicio.Location = new System.Drawing.Point(34, 400);
            this.btnAsentarServicio.Name = "btnAsentarServicio";
            this.btnAsentarServicio.Size = new System.Drawing.Size(87, 83);
            this.btnAsentarServicio.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnAsentarServicio, "Asentar el servicio");
            this.btnAsentarServicio.UseVisualStyleBackColor = false;
            this.btnAsentarServicio.Click += new System.EventHandler(this.btnAsentarServicio_Click);
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
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePaciente.Location = new System.Drawing.Point(30, 35);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(168, 24);
            this.lblNombrePaciente.TabIndex = 9;
            this.lblNombrePaciente.Text = "nombre paciente";
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
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.checkout;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(306, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 83);
            this.btnSalir.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir de este menú");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAsentarYCargarOtro
            // 
            this.btnAsentarYCargarOtro.BackColor = System.Drawing.Color.Transparent;
            this.btnAsentarYCargarOtro.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Service2Button;
            this.btnAsentarYCargarOtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsentarYCargarOtro.FlatAppearance.BorderSize = 0;
            this.btnAsentarYCargarOtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsentarYCargarOtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsentarYCargarOtro.Location = new System.Drawing.Point(173, 400);
            this.btnAsentarYCargarOtro.Name = "btnAsentarYCargarOtro";
            this.btnAsentarYCargarOtro.Size = new System.Drawing.Size(87, 83);
            this.btnAsentarYCargarOtro.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnAsentarYCargarOtro, "Asentar el servvicio y cargar uno nuevo");
            this.btnAsentarYCargarOtro.UseVisualStyleBackColor = false;
            this.btnAsentarYCargarOtro.Click += new System.EventHandler(this.btnAsentarYCargarOtro_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(302, 307);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 22);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "costo";
            // 
            // lblReintegro
            // 
            this.lblReintegro.AutoSize = true;
            this.lblReintegro.BackColor = System.Drawing.Color.Salmon;
            this.lblReintegro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReintegro.Location = new System.Drawing.Point(302, 337);
            this.lblReintegro.Name = "lblReintegro";
            this.lblReintegro.Size = new System.Drawing.Size(58, 22);
            this.lblReintegro.TabIndex = 15;
            this.lblReintegro.Text = "costo";
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
            this.Controls.Add(this.lblReintegro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAsentarYCargarOtro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAsentarServicio);
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
        private System.Windows.Forms.ComboBox cmbObraSocial;
        private System.Windows.Forms.CheckBox chkOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAsentarServicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCostoConsulta;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAsentarYCargarOtro;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblReintegro;
        private System.Windows.Forms.Label label9;
    }
}