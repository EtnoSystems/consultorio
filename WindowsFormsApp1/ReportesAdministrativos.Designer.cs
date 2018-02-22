namespace WindowsFormsApp1
{
    partial class ReportesAdministrativos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RdObraSocial = new System.Windows.Forms.RadioButton();
            this.RdProfesional = new System.Windows.Forms.RadioButton();
            this.CmbPrimerFiltro = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.RdEmpleado = new System.Windows.Forms.RadioButton();
            this.RdPaciente = new System.Windows.Forms.RadioButton();
            this.ChkFiltro = new System.Windows.Forms.CheckBox();
            this.BtnNuevaConsulta = new System.Windows.Forms.Button();
            this.CmbSegundoFiltro = new System.Windows.Forms.ComboBox();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CmbFiltro);
            this.groupBox1.Controls.Add(this.CmbSegundoFiltro);
            this.groupBox1.Controls.Add(this.BtnNuevaConsulta);
            this.groupBox1.Controls.Add(this.ChkFiltro);
            this.groupBox1.Controls.Add(this.RdEmpleado);
            this.groupBox1.Controls.Add(this.RdPaciente);
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnConsultar);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.CmbPrimerFiltro);
            this.groupBox1.Controls.Add(this.RdProfesional);
            this.groupBox1.Controls.Add(this.RdObraSocial);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informar por";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 256);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(646, 351);
            this.dataGridView1.TabIndex = 2;
            // 
            // RdObraSocial
            // 
            this.RdObraSocial.AutoSize = true;
            this.RdObraSocial.Location = new System.Drawing.Point(16, 29);
            this.RdObraSocial.Name = "RdObraSocial";
            this.RdObraSocial.Size = new System.Drawing.Size(113, 22);
            this.RdObraSocial.TabIndex = 0;
            this.RdObraSocial.TabStop = true;
            this.RdObraSocial.Text = "Obra social";
            this.RdObraSocial.UseVisualStyleBackColor = true;
            this.RdObraSocial.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RdProfesional
            // 
            this.RdProfesional.AutoSize = true;
            this.RdProfesional.Location = new System.Drawing.Point(16, 57);
            this.RdProfesional.Name = "RdProfesional";
            this.RdProfesional.Size = new System.Drawing.Size(112, 22);
            this.RdProfesional.TabIndex = 1;
            this.RdProfesional.TabStop = true;
            this.RdProfesional.Text = "Profesional";
            this.RdProfesional.UseVisualStyleBackColor = true;
            this.RdProfesional.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // CmbPrimerFiltro
            // 
            this.CmbPrimerFiltro.FormattingEnabled = true;
            this.CmbPrimerFiltro.Location = new System.Drawing.Point(16, 85);
            this.CmbPrimerFiltro.Name = "CmbPrimerFiltro";
            this.CmbPrimerFiltro.Size = new System.Drawing.Size(269, 26);
            this.CmbPrimerFiltro.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(312, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(341, 24);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(312, 97);
            this.dateTimePicker2.MaxDate = new System.DateTime(2018, 2, 11, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(341, 24);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.Value = new System.DateTime(2018, 2, 11, 0, 0, 0, 0);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(312, 149);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(108, 45);
            this.BtnConsultar.TabIndex = 5;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasta";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(545, 149);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(108, 45);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // RdEmpleado
            // 
            this.RdEmpleado.AutoSize = true;
            this.RdEmpleado.Location = new System.Drawing.Point(150, 57);
            this.RdEmpleado.Name = "RdEmpleado";
            this.RdEmpleado.Size = new System.Drawing.Size(101, 22);
            this.RdEmpleado.TabIndex = 10;
            this.RdEmpleado.TabStop = true;
            this.RdEmpleado.Text = "Empleado";
            this.RdEmpleado.UseVisualStyleBackColor = true;
            // 
            // RdPaciente
            // 
            this.RdPaciente.AutoSize = true;
            this.RdPaciente.Location = new System.Drawing.Point(150, 29);
            this.RdPaciente.Name = "RdPaciente";
            this.RdPaciente.Size = new System.Drawing.Size(91, 22);
            this.RdPaciente.TabIndex = 9;
            this.RdPaciente.TabStop = true;
            this.RdPaciente.Text = "Paciente";
            this.RdPaciente.UseVisualStyleBackColor = true;
            // 
            // ChkFiltro
            // 
            this.ChkFiltro.AutoSize = true;
            this.ChkFiltro.Location = new System.Drawing.Point(16, 126);
            this.ChkFiltro.Name = "ChkFiltro";
            this.ChkFiltro.Size = new System.Drawing.Size(124, 22);
            this.ChkFiltro.TabIndex = 11;
            this.ChkFiltro.Text = "Agregar filtro";
            this.toolTip1.SetToolTip(this.ChkFiltro, "Marcar si desea agregar otro filtro a la consulta");
            this.ChkFiltro.UseVisualStyleBackColor = true;
            this.ChkFiltro.CheckedChanged += new System.EventHandler(this.ChkFiltro_CheckedChanged);
            // 
            // BtnNuevaConsulta
            // 
            this.BtnNuevaConsulta.Location = new System.Drawing.Point(428, 149);
            this.BtnNuevaConsulta.Name = "BtnNuevaConsulta";
            this.BtnNuevaConsulta.Size = new System.Drawing.Size(108, 45);
            this.BtnNuevaConsulta.TabIndex = 12;
            this.BtnNuevaConsulta.Text = "Nueva consulta";
            this.BtnNuevaConsulta.UseVisualStyleBackColor = true;
            // 
            // CmbSegundoFiltro
            // 
            this.CmbSegundoFiltro.FormattingEnabled = true;
            this.CmbSegundoFiltro.Location = new System.Drawing.Point(16, 168);
            this.CmbSegundoFiltro.Name = "CmbSegundoFiltro";
            this.CmbSegundoFiltro.Size = new System.Drawing.Size(269, 26);
            this.CmbSegundoFiltro.TabIndex = 14;
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Location = new System.Drawing.Point(146, 124);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(139, 26);
            this.CmbFiltro.TabIndex = 15;
            this.toolTip1.SetToolTip(this.CmbFiltro, "Seleccione otro filtro de la lista (P.E. filtrar profesionales que atendieron con" +
        " determinada obra social)");
            // 
            // ReportesAdministrativos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fondoLogIn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 670);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ReportesAdministrativos";
            this.Text = "Generar reportes";
            this.Load += new System.EventHandler(this.ReportesAdministrativos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CmbPrimerFiltro;
        private System.Windows.Forms.RadioButton RdProfesional;
        private System.Windows.Forms.RadioButton RdObraSocial;
        private System.Windows.Forms.RadioButton RdEmpleado;
        private System.Windows.Forms.RadioButton RdPaciente;
        private System.Windows.Forms.Button BtnNuevaConsulta;
        private System.Windows.Forms.CheckBox ChkFiltro;
        private System.Windows.Forms.ComboBox CmbSegundoFiltro;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}