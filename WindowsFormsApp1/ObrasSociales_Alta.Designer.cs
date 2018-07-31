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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TxtDenominacion = new System.Windows.Forms.TextBox();
            this.TxtPlus = new System.Windows.Forms.TextBox();
            this.ChkActiva = new System.Windows.Forms.CheckBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtTelefonoModif = new System.Windows.Forms.TextBox();
            this.TxtDireccionModif = new System.Windows.Forms.TextBox();
            this.ChkActivaModif = new System.Windows.Forms.CheckBox();
            this.TxtPlusModif = new System.Windows.Forms.TextBox();
            this.ChkActivaEliminar = new System.Windows.Forms.CheckBox();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.TxtObservacionesModif = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtNombreModif = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnAgregarOtra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CmbObrasSocialesModif = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGuardarCambios = new System.Windows.Forms.Button();
            this.BtnGuardarYModifOtro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblNombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblObservaciones = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblPlus = new System.Windows.Forms.Label();
            this.Plus = new System.Windows.Forms.Label();
            this.CmbObrasSociales = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEliminarOtro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.consultoriosDataSet = new WindowsFormsApp1.consultoriosDataSet();
            this.consultoriosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TxtDenominacion
            // 
            this.TxtDenominacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDenominacion.ForeColor = System.Drawing.Color.Silver;
            this.TxtDenominacion.Location = new System.Drawing.Point(17, 42);
            this.TxtDenominacion.Name = "TxtDenominacion";
            this.TxtDenominacion.Size = new System.Drawing.Size(176, 24);
            this.TxtDenominacion.TabIndex = 1;
            this.TxtDenominacion.Text = "Denominación";
            this.toolTip1.SetToolTip(this.TxtDenominacion, "Coloque el nombre completo de la obra social (Ej. Obra Social de los Empleados de" +
        " Comercio y Actividades Civiles)");
            this.TxtDenominacion.TextChanged += new System.EventHandler(this.TxtDenominacion_TextChanged);
            this.TxtDenominacion.Enter += new System.EventHandler(this.TxtDenominacion_Enter_1);
            this.TxtDenominacion.Leave += new System.EventHandler(this.TxtDenominacion_Leave);
            // 
            // TxtPlus
            // 
            this.TxtPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlus.ForeColor = System.Drawing.Color.Silver;
            this.TxtPlus.Location = new System.Drawing.Point(17, 125);
            this.TxtPlus.Name = "TxtPlus";
            this.TxtPlus.Size = new System.Drawing.Size(139, 24);
            this.TxtPlus.TabIndex = 3;
            this.TxtPlus.Text = "Plus";
            this.toolTip1.SetToolTip(this.TxtPlus, "Indique el monto que los usuarios de esta obra social deben abonar (0 siginifica " +
        "que no pagan)");
            this.TxtPlus.Enter += new System.EventHandler(this.TxtPlus_Enter);
            this.TxtPlus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlus_KeyPress);
            this.TxtPlus.Leave += new System.EventHandler(this.TxtPlus_Leave);
            // 
            // ChkActiva
            // 
            this.ChkActiva.AutoSize = true;
            this.ChkActiva.BackColor = System.Drawing.Color.Transparent;
            this.ChkActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActiva.Location = new System.Drawing.Point(177, 127);
            this.ChkActiva.Name = "ChkActiva";
            this.ChkActiva.Size = new System.Drawing.Size(193, 22);
            this.ChkActiva.TabIndex = 4;
            this.ChkActiva.Text = "¿Se encuentra activa?";
            this.toolTip1.SetToolTip(this.ChkActiva, "Indique si la obra social está activa actualmente tildando la casilla o dejándola" +
        " vacía para indicar si está interrumpida");
            this.ChkActiva.UseVisualStyleBackColor = false;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.ForeColor = System.Drawing.Color.Silver;
            this.TxtDireccion.Location = new System.Drawing.Point(18, 34);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(313, 24);
            this.TxtDireccion.TabIndex = 6;
            this.TxtDireccion.Text = "Dirección";
            this.toolTip1.SetToolTip(this.TxtDireccion, "Indique el monto que los usuarios de esta obra social deben abonar (0 siginifica " +
        "que no pagan)");
            this.TxtDireccion.Enter += new System.EventHandler(this.TxtDireccion_Enter_1);
            this.TxtDireccion.Leave += new System.EventHandler(this.TxtDireccion_Leave);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.ForeColor = System.Drawing.Color.Silver;
            this.TxtTelefono.Location = new System.Drawing.Point(18, 73);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(137, 24);
            this.TxtTelefono.TabIndex = 7;
            this.TxtTelefono.Text = "Teléfono";
            this.toolTip1.SetToolTip(this.TxtTelefono, "Indique el monto que los usuarios de esta obra social deben abonar (0 siginifica " +
        "que no pagan)");
            this.TxtTelefono.Enter += new System.EventHandler(this.TxtTelefono_Enter_1);
            this.TxtTelefono.Leave += new System.EventHandler(this.TxtTelefono_Leave);
            // 
            // TxtTelefonoModif
            // 
            this.TxtTelefonoModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoModif.ForeColor = System.Drawing.Color.Silver;
            this.TxtTelefonoModif.Location = new System.Drawing.Point(18, 73);
            this.TxtTelefonoModif.Name = "TxtTelefonoModif";
            this.TxtTelefonoModif.Size = new System.Drawing.Size(137, 24);
            this.TxtTelefonoModif.TabIndex = 6;
            this.TxtTelefonoModif.Text = "Teléfono";
            this.toolTip1.SetToolTip(this.TxtTelefonoModif, "Indique el monto que los usuarios de esta obra social deben abonar (0 siginifica " +
        "que no pagan)");
            this.TxtTelefonoModif.Enter += new System.EventHandler(this.TxtTelefonoModif_Enter);
            this.TxtTelefonoModif.Leave += new System.EventHandler(this.TxtTelefonoModif_Leave);
            // 
            // TxtDireccionModif
            // 
            this.TxtDireccionModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionModif.ForeColor = System.Drawing.Color.Silver;
            this.TxtDireccionModif.Location = new System.Drawing.Point(18, 34);
            this.TxtDireccionModif.Name = "TxtDireccionModif";
            this.TxtDireccionModif.Size = new System.Drawing.Size(313, 24);
            this.TxtDireccionModif.TabIndex = 5;
            this.TxtDireccionModif.Text = "Dirección";
            this.toolTip1.SetToolTip(this.TxtDireccionModif, "Indique el monto que los usuarios de esta obra social deben abonar (0 siginifica " +
        "que no pagan)");
            this.TxtDireccionModif.Enter += new System.EventHandler(this.TxtDireccionModif_Enter);
            this.TxtDireccionModif.Leave += new System.EventHandler(this.TxtDireccionModif_Leave);
            // 
            // ChkActivaModif
            // 
            this.ChkActivaModif.AutoSize = true;
            this.ChkActivaModif.BackColor = System.Drawing.Color.Transparent;
            this.ChkActivaModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActivaModif.Location = new System.Drawing.Point(177, 137);
            this.ChkActivaModif.Name = "ChkActivaModif";
            this.ChkActivaModif.Size = new System.Drawing.Size(193, 22);
            this.ChkActivaModif.TabIndex = 4;
            this.ChkActivaModif.Text = "¿Se encuentra activa?";
            this.toolTip1.SetToolTip(this.ChkActivaModif, "Indique si la obra social está activa actualmente tildando la casilla o dejándola" +
        " vacía para indicar si está interrumpida");
            this.ChkActivaModif.UseVisualStyleBackColor = false;
            // 
            // TxtPlusModif
            // 
            this.TxtPlusModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlusModif.ForeColor = System.Drawing.Color.Silver;
            this.TxtPlusModif.Location = new System.Drawing.Point(17, 135);
            this.TxtPlusModif.Name = "TxtPlusModif";
            this.TxtPlusModif.Size = new System.Drawing.Size(139, 24);
            this.TxtPlusModif.TabIndex = 3;
            this.TxtPlusModif.Text = "Plus";
            this.toolTip1.SetToolTip(this.TxtPlusModif, "Indique el monto que los usuarios de esta obra social deben abonar (0 siginifica " +
        "que no pagan)");
            this.TxtPlusModif.Enter += new System.EventHandler(this.TxtPlusModif_Enter);
            this.TxtPlusModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlusModif_KeyPress);
            this.TxtPlusModif.Leave += new System.EventHandler(this.TxtPlusModif_Leave);
            // 
            // ChkActivaEliminar
            // 
            this.ChkActivaEliminar.AutoSize = true;
            this.ChkActivaEliminar.BackColor = System.Drawing.Color.Transparent;
            this.ChkActivaEliminar.Enabled = false;
            this.ChkActivaEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActivaEliminar.Location = new System.Drawing.Point(174, 135);
            this.ChkActivaEliminar.Name = "ChkActivaEliminar";
            this.ChkActivaEliminar.Size = new System.Drawing.Size(193, 22);
            this.ChkActivaEliminar.TabIndex = 4;
            this.ChkActivaEliminar.Text = "¿Se encuentra activa?";
            this.toolTip1.SetToolTip(this.ChkActivaEliminar, "Indique si la obra social está activa actualmente tildando la casilla o dejándola" +
        " vacía para indicar si está interrumpida");
            this.ChkActivaEliminar.UseVisualStyleBackColor = false;
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.ForeColor = System.Drawing.Color.Silver;
            this.TxtObservaciones.Location = new System.Drawing.Point(17, 167);
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(353, 24);
            this.TxtObservaciones.TabIndex = 5;
            this.TxtObservaciones.Text = "Observaciones";
            this.toolTip1.SetToolTip(this.TxtObservaciones, "Coloque el nombre completo de la obra social (Ej. Obra Social de los Empleados de" +
        " Comercio y Actividades Civiles)");
            this.TxtObservaciones.Enter += new System.EventHandler(this.TxtObservaciones_Enter);
            this.TxtObservaciones.Leave += new System.EventHandler(this.TxtObservaciones_Leave);
            // 
            // TxtObservacionesModif
            // 
            this.TxtObservacionesModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservacionesModif.ForeColor = System.Drawing.Color.Silver;
            this.TxtObservacionesModif.Location = new System.Drawing.Point(17, 177);
            this.TxtObservacionesModif.Name = "TxtObservacionesModif";
            this.TxtObservacionesModif.Size = new System.Drawing.Size(353, 24);
            this.TxtObservacionesModif.TabIndex = 10;
            this.TxtObservacionesModif.Text = "Observaciones";
            this.toolTip1.SetToolTip(this.TxtObservacionesModif, "Coloque el nombre completo de la obra social (Ej. Obra Social de los Empleados de" +
        " Comercio y Actividades Civiles)");
            this.TxtObservacionesModif.Enter += new System.EventHandler(this.TxtObservacionesModif_Enter);
            this.TxtObservacionesModif.Leave += new System.EventHandler(this.TxtObservacionesModif_Leave);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.Silver;
            this.TxtNombre.Location = new System.Drawing.Point(17, 81);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(353, 24);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.Text = "Nombre";
            this.toolTip1.SetToolTip(this.TxtNombre, "Coloque el nombre completo de la obra social (Ej. Obra Social de los Empleados de" +
        " Comercio y Actividades Civiles)");
            this.TxtNombre.Enter += new System.EventHandler(this.TxtNombre_Enter);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // TxtNombreModif
            // 
            this.TxtNombreModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreModif.ForeColor = System.Drawing.Color.Silver;
            this.TxtNombreModif.Location = new System.Drawing.Point(17, 92);
            this.TxtNombreModif.Name = "TxtNombreModif";
            this.TxtNombreModif.Size = new System.Drawing.Size(353, 24);
            this.TxtNombreModif.TabIndex = 11;
            this.TxtNombreModif.Text = "Nombre";
            this.toolTip1.SetToolTip(this.TxtNombreModif, "Coloque el nombre completo de la obra social (Ej. Obra Social de los Empleados de" +
        " Comercio y Actividades Civiles)");
            this.TxtNombreModif.Enter += new System.EventHandler(this.TxtNombreModif_Enter);
            this.TxtNombreModif.Leave += new System.EventHandler(this.TxtNombreModif_Leave);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(25, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 484);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fondoFormularios;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(458, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.TxtObservaciones);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.ChkActiva);
            this.panel1.Controls.Add(this.TxtPlus);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.BtnAgregarOtra);
            this.panel1.Controls.Add(this.TxtDenominacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 414);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TxtTelefono);
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de contacto";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.botonGuardar2;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(79, 333);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(70, 69);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click_1);
            // 
            // BtnAgregarOtra
            // 
            this.BtnAgregarOtra.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarOtra.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.botonGuardarAgregarDeshabilitado;
            this.BtnAgregarOtra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarOtra.FlatAppearance.BorderSize = 0;
            this.BtnAgregarOtra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarOtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarOtra.Location = new System.Drawing.Point(219, 333);
            this.BtnAgregarOtra.Name = "BtnAgregarOtra";
            this.BtnAgregarOtra.Size = new System.Drawing.Size(67, 69);
            this.BtnAgregarOtra.TabIndex = 7;
            this.BtnAgregarOtra.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar una nueva obra social";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fondoFormulariosModificacion;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(458, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.TxtNombreModif);
            this.panel2.Controls.Add(this.TxtObservacionesModif);
            this.panel2.Controls.Add(this.CmbObrasSocialesModif);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.ChkActivaModif);
            this.panel2.Controls.Add(this.TxtPlusModif);
            this.panel2.Controls.Add(this.BtnGuardarCambios);
            this.panel2.Controls.Add(this.BtnGuardarYModifOtro);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(34, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 417);
            this.panel2.TabIndex = 11;
            // 
            // CmbObrasSocialesModif
            // 
            this.CmbObrasSocialesModif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbObrasSocialesModif.FormattingEnabled = true;
            this.CmbObrasSocialesModif.Location = new System.Drawing.Point(17, 48);
            this.CmbObrasSocialesModif.Name = "CmbObrasSocialesModif";
            this.CmbObrasSocialesModif.Size = new System.Drawing.Size(353, 26);
            this.CmbObrasSocialesModif.TabIndex = 9;
            this.CmbObrasSocialesModif.SelectedIndexChanged += new System.EventHandler(this.CmbObrasSocialesModif_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.TxtTelefonoModif);
            this.groupBox2.Controls.Add(this.TxtDireccionModif);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 117);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de contacto";
            // 
            // BtnGuardarCambios
            // 
            this.BtnGuardarCambios.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarCambios.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.botonGuardar2;
            this.BtnGuardarCambios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.BtnGuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarCambios.Location = new System.Drawing.Point(86, 335);
            this.BtnGuardarCambios.Name = "BtnGuardarCambios";
            this.BtnGuardarCambios.Size = new System.Drawing.Size(70, 69);
            this.BtnGuardarCambios.TabIndex = 6;
            this.BtnGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // BtnGuardarYModifOtro
            // 
            this.BtnGuardarYModifOtro.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarYModifOtro.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.botonGuardarAgregarDeshabilitado;
            this.BtnGuardarYModifOtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardarYModifOtro.FlatAppearance.BorderSize = 0;
            this.BtnGuardarYModifOtro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnGuardarYModifOtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarYModifOtro.Location = new System.Drawing.Point(232, 335);
            this.BtnGuardarYModifOtro.Name = "BtnGuardarYModifOtro";
            this.BtnGuardarYModifOtro.Size = new System.Drawing.Size(67, 69);
            this.BtnGuardarYModifOtro.TabIndex = 7;
            this.BtnGuardarYModifOtro.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modificar una obra social existente";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fondoFormulariosBaja;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(458, 453);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.LblNombre);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.LblObservaciones);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.LblPlus);
            this.panel3.Controls.Add(this.Plus);
            this.panel3.Controls.Add(this.CmbObrasSociales);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.ChkActivaEliminar);
            this.panel3.Controls.Add(this.BtnEliminar);
            this.panel3.Controls.Add(this.BtnEliminarOtro);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(34, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 410);
            this.panel3.TabIndex = 12;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Location = new System.Drawing.Point(90, 93);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(14, 18);
            this.LblNombre.TabIndex = 14;
            this.LblNombre.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(16, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre";
            // 
            // LblObservaciones
            // 
            this.LblObservaciones.AutoSize = true;
            this.LblObservaciones.BackColor = System.Drawing.Color.Transparent;
            this.LblObservaciones.Location = new System.Drawing.Point(141, 171);
            this.LblObservaciones.Name = "LblObservaciones";
            this.LblObservaciones.Size = new System.Drawing.Size(14, 18);
            this.LblObservaciones.TabIndex = 12;
            this.LblObservaciones.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(14, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Observaciones";
            // 
            // LblPlus
            // 
            this.LblPlus.AutoSize = true;
            this.LblPlus.BackColor = System.Drawing.Color.Transparent;
            this.LblPlus.Location = new System.Drawing.Point(75, 135);
            this.LblPlus.Name = "LblPlus";
            this.LblPlus.Size = new System.Drawing.Size(14, 18);
            this.LblPlus.TabIndex = 10;
            this.LblPlus.Text = "-";
            // 
            // Plus
            // 
            this.Plus.AutoSize = true;
            this.Plus.BackColor = System.Drawing.Color.Transparent;
            this.Plus.Location = new System.Drawing.Point(14, 135);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(55, 18);
            this.Plus.TabIndex = 9;
            this.Plus.Text = "Plus $";
            // 
            // CmbObrasSociales
            // 
            this.CmbObrasSociales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbObrasSociales.FormattingEnabled = true;
            this.CmbObrasSociales.Location = new System.Drawing.Point(17, 44);
            this.CmbObrasSociales.Name = "CmbObrasSociales";
            this.CmbObrasSociales.Size = new System.Drawing.Size(340, 26);
            this.CmbObrasSociales.TabIndex = 8;
            this.CmbObrasSociales.SelectedIndexChanged += new System.EventHandler(this.CmbObrasSociales_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.LblTelefono);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.LblDireccion);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 117);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de contacto";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.LblTelefono.Location = new System.Drawing.Point(106, 78);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(14, 18);
            this.LblTelefono.TabIndex = 14;
            this.LblTelefono.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(20, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Teléfono";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.LblDireccion.Location = new System.Drawing.Point(106, 37);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(14, 18);
            this.LblDireccion.TabIndex = 12;
            this.LblDireccion.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(20, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dirección";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.EliminarBoton;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(90, 328);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(70, 69);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarOtro
            // 
            this.BtnEliminarOtro.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarOtro.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.EliminarOtroBoton;
            this.BtnEliminarOtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarOtro.FlatAppearance.BorderSize = 0;
            this.BtnEliminarOtro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarOtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarOtro.Location = new System.Drawing.Point(236, 328);
            this.BtnEliminarOtro.Name = "BtnEliminarOtro";
            this.BtnEliminarOtro.Size = new System.Drawing.Size(67, 69);
            this.BtnEliminarOtro.TabIndex = 7;
            this.BtnEliminarOtro.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eliminar una obra social ";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.checkout;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(213, 508);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 78);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // consultoriosDataSet
            // 
            this.consultoriosDataSet.DataSetName = "consultoriosDataSet";
            this.consultoriosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultoriosDataSetBindingSource
            // 
            this.consultoriosDataSetBindingSource.DataSource = this.consultoriosDataSet;
            this.consultoriosDataSetBindingSource.Position = 0;
            // 
            // ObrasSociales_alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fondoLogIn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 598);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ObrasSociales_alta";
            this.Text = "Gestión de Obras Sociales";
            this.Load += new System.EventHandler(this.ObrasSociales_alta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoriosDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.CheckBox ChkActiva;
        private System.Windows.Forms.TextBox TxtPlus;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnAgregarOtra;
        private System.Windows.Forms.TextBox TxtDenominacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtTelefonoModif;
        private System.Windows.Forms.TextBox TxtDireccionModif;
        private System.Windows.Forms.CheckBox ChkActivaModif;
        private System.Windows.Forms.TextBox TxtPlusModif;
        private System.Windows.Forms.Button BtnGuardarCambios;
        private System.Windows.Forms.Button BtnGuardarYModifOtro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ChkActivaEliminar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEliminarOtro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPlus;
        private System.Windows.Forms.Label Plus;
        private System.Windows.Forms.ComboBox CmbObrasSociales;
        private consultoriosDataSet consultoriosDataSet;
        private System.Windows.Forms.BindingSource consultoriosDataSetBindingSource;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbObrasSocialesModif;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.TextBox TxtObservacionesModif;
        private System.Windows.Forms.Label LblObservaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtNombreModif;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label label5;
    }
}