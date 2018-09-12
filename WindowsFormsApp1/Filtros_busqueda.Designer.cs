namespace WindowsFormsApp1
{
    partial class Filtros_busqueda
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
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DgvResultadoBusqueda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultadoBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDNI
            // 
            this.TxtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDNI.ForeColor = System.Drawing.Color.Gray;
            this.TxtDNI.Location = new System.Drawing.Point(42, 25);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(100, 23);
            this.TxtDNI.TabIndex = 0;
            this.TxtDNI.Text = "DNI";
            this.TxtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDNI.Enter += new System.EventHandler(this.TxtDNI_Enter);
            this.TxtDNI.Leave += new System.EventHandler(this.TxtDNI_Leave);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.ForeColor = System.Drawing.Color.Gray;
            this.TxtApellido.Location = new System.Drawing.Point(42, 73);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 23);
            this.TxtApellido.TabIndex = 1;
            this.TxtApellido.Text = "Apellido";
            this.TxtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            this.TxtApellido.Enter += new System.EventHandler(this.TxtApellido_Enter);
            this.TxtApellido.Leave += new System.EventHandler(this.TxtApellido_Leave);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.Gray;
            this.TxtNombre.Location = new System.Drawing.Point(42, 122);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 23);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.Text = "Nombre";
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNombre.Enter += new System.EventHandler(this.TxtNombre_Enter);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.lupa1;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(54, 160);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 69);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DgvResultadoBusqueda
            // 
            this.DgvResultadoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResultadoBusqueda.Location = new System.Drawing.Point(198, 25);
            this.DgvResultadoBusqueda.MultiSelect = false;
            this.DgvResultadoBusqueda.Name = "DgvResultadoBusqueda";
            this.DgvResultadoBusqueda.Size = new System.Drawing.Size(492, 204);
            this.DgvResultadoBusqueda.TabIndex = 4;
            this.DgvResultadoBusqueda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultadoBusqueda_CellClick);
            this.DgvResultadoBusqueda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultadoBusqueda_CellDoubleClick);
            // 
            // Filtros_busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fondoFormularios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 253);
            this.Controls.Add(this.DgvResultadoBusqueda);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtDNI);
            this.Name = "Filtros_busqueda";
            this.Text = "Búsqueda";
            this.Load += new System.EventHandler(this.Filtros_busqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultadoBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView DgvResultadoBusqueda;
    }
}