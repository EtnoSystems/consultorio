namespace WindowsFormsApp1
{
    partial class CargarFeriados
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.BtnCalendarAdd = new System.Windows.Forms.Button();
            this.BtnCalendarRemove = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargar feriados y días no laborables";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(50, 76);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // BtnCalendarAdd
            // 
            this.BtnCalendarAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnCalendarAdd.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.CalendarAdd;
            this.BtnCalendarAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalendarAdd.FlatAppearance.BorderSize = 0;
            this.BtnCalendarAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnCalendarAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalendarAdd.Location = new System.Drawing.Point(285, 76);
            this.BtnCalendarAdd.Name = "BtnCalendarAdd";
            this.BtnCalendarAdd.Size = new System.Drawing.Size(75, 78);
            this.BtnCalendarAdd.TabIndex = 2;
            this.toolTip1.SetToolTip(this.BtnCalendarAdd, "Agregue la fecha seleccionada a los días no laborables");
            this.BtnCalendarAdd.UseVisualStyleBackColor = false;
            // 
            // BtnCalendarRemove
            // 
            this.BtnCalendarRemove.BackColor = System.Drawing.Color.Transparent;
            this.BtnCalendarRemove.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.CalendarRemove;
            this.BtnCalendarRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalendarRemove.FlatAppearance.BorderSize = 0;
            this.BtnCalendarRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnCalendarRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalendarRemove.Location = new System.Drawing.Point(285, 160);
            this.BtnCalendarRemove.Name = "BtnCalendarRemove";
            this.BtnCalendarRemove.Size = new System.Drawing.Size(75, 78);
            this.BtnCalendarRemove.TabIndex = 3;
            this.toolTip1.SetToolTip(this.BtnCalendarRemove, "Quite el día seleccionado de la lista de días no laborables");
            this.BtnCalendarRemove.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.checkout;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(385, 76);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 78);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 71);
            this.dataGridView1.TabIndex = 5;
            // 
            // CargarFeriados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fondoFormulariosBaja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 389);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCalendarRemove);
            this.Controls.Add(this.BtnCalendarAdd);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Name = "CargarFeriados";
            this.Text = "Feriados y días no laborables";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button BtnCalendarAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnCalendarRemove;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}