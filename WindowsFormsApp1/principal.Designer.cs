namespace WindowsFormsApp1
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedicos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgregarMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminarMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.ffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgregarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditarPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgregarPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminarPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditarPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuObrasSociales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecetarios = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgregarObraSocial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminarObraSocial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditarObrasSociales = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuObrasSociales,
            this.mnuRecetarios,
            this.reportesToolStripMenuItem,
            this.cambiarUsuarioToolStripMenuItem,
            this.mnuSalir,
            this.mnuAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(1273, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(118, 664);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.AutoSize = false;
            this.mnuUsuarios.AutoToolTip = true;
            this.mnuUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mnuUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMedicos,
            this.mnuPacientes,
            this.mnuPersonal});
            this.mnuUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("mnuUsuarios.Image")));
            this.mnuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuUsuarios.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuUsuarios.Size = new System.Drawing.Size(112, 111);
            this.mnuUsuarios.Text = "Principal";
            this.mnuUsuarios.ToolTipText = "Administrador de mèdicos, pacientes y usuarios (ctrl + u)";
            this.mnuUsuarios.Click += new System.EventHandler(this.PrincipalToolStripMenuItem_Click);
            // 
            // mnuMedicos
            // 
            this.mnuMedicos.AutoSize = false;
            this.mnuMedicos.AutoToolTip = true;
            this.mnuMedicos.BackColor = System.Drawing.Color.Transparent;
            this.mnuMedicos.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.medics;
            this.mnuMedicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mnuMedicos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuMedicos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregarMedico,
            this.mnuEliminarMedico,
            this.ffToolStripMenuItem});
            this.mnuMedicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuMedicos.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuMedicos.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnuMedicos.Name = "mnuMedicos";
            this.mnuMedicos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuMedicos.Size = new System.Drawing.Size(152, 22);
            this.mnuMedicos.Text = "Usuarios";
            this.mnuMedicos.ToolTipText = "Gestionar personal médico";
            this.mnuMedicos.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // mnuAgregarMedico
            // 
            this.mnuAgregarMedico.AutoToolTip = true;
            this.mnuAgregarMedico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuAgregarMedico.Image = global::WindowsFormsApp1.Properties.Resources.doctorAdd;
            this.mnuAgregarMedico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAgregarMedico.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuAgregarMedico.Name = "mnuAgregarMedico";
            this.mnuAgregarMedico.Size = new System.Drawing.Size(126, 82);
            this.mnuAgregarMedico.ToolTipText = "Agregar personal médico";
            // 
            // mnuEliminarMedico
            // 
            this.mnuEliminarMedico.AutoToolTip = true;
            this.mnuEliminarMedico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuEliminarMedico.Image = global::WindowsFormsApp1.Properties.Resources.doctorRemove;
            this.mnuEliminarMedico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuEliminarMedico.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuEliminarMedico.Name = "mnuEliminarMedico";
            this.mnuEliminarMedico.Size = new System.Drawing.Size(126, 82);
            this.mnuEliminarMedico.ToolTipText = "Dar de baja personal médico";
            // 
            // ffToolStripMenuItem
            // 
            this.ffToolStripMenuItem.AutoToolTip = true;
            this.ffToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.doctorEdit;
            this.ffToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ffToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ffToolStripMenuItem.Name = "ffToolStripMenuItem";
            this.ffToolStripMenuItem.Size = new System.Drawing.Size(126, 82);
            this.ffToolStripMenuItem.ToolTipText = "Editar datos de personal médico";
            // 
            // mnuPacientes
            // 
            this.mnuPacientes.AutoSize = false;
            this.mnuPacientes.AutoToolTip = true;
            this.mnuPacientes.BackColor = System.Drawing.Color.Transparent;
            this.mnuPacientes.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pacients;
            this.mnuPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mnuPacientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuPacientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregarPaciente,
            this.mnuEliminarPaciente,
            this.mnuEditarPacientes});
            this.mnuPacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuPacientes.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuPacientes.Name = "mnuPacientes";
            this.mnuPacientes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuPacientes.Size = new System.Drawing.Size(152, 22);
            this.mnuPacientes.Text = "Pacientes";
            this.mnuPacientes.ToolTipText = "Gestionar los pacientes";
            // 
            // mnuAgregarPaciente
            // 
            this.mnuAgregarPaciente.AutoToolTip = true;
            this.mnuAgregarPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuAgregarPaciente.Image = global::WindowsFormsApp1.Properties.Resources.pacientAdd;
            this.mnuAgregarPaciente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAgregarPaciente.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuAgregarPaciente.Name = "mnuAgregarPaciente";
            this.mnuAgregarPaciente.Size = new System.Drawing.Size(173, 82);
            this.mnuAgregarPaciente.Text = "addP";
            this.mnuAgregarPaciente.ToolTipText = "Agregar un paciente nuevo";
            // 
            // mnuEliminarPaciente
            // 
            this.mnuEliminarPaciente.AutoToolTip = true;
            this.mnuEliminarPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuEliminarPaciente.Image = global::WindowsFormsApp1.Properties.Resources.pacientRemove;
            this.mnuEliminarPaciente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuEliminarPaciente.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuEliminarPaciente.Name = "mnuEliminarPaciente";
            this.mnuEliminarPaciente.Size = new System.Drawing.Size(173, 82);
            this.mnuEliminarPaciente.Text = "remove";
            this.mnuEliminarPaciente.ToolTipText = "Eliminar pacientes";
            // 
            // mnuEditarPacientes
            // 
            this.mnuEditarPacientes.AutoToolTip = true;
            this.mnuEditarPacientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuEditarPacientes.Image = global::WindowsFormsApp1.Properties.Resources.pacientEdit;
            this.mnuEditarPacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuEditarPacientes.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuEditarPacientes.Name = "mnuEditarPacientes";
            this.mnuEditarPacientes.Size = new System.Drawing.Size(173, 82);
            this.mnuEditarPacientes.Text = "edit";
            this.mnuEditarPacientes.ToolTipText = "Editar datos de pacientes";
            // 
            // mnuPersonal
            // 
            this.mnuPersonal.AutoSize = false;
            this.mnuPersonal.AutoToolTip = true;
            this.mnuPersonal.BackColor = System.Drawing.Color.Transparent;
            this.mnuPersonal.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.admin;
            this.mnuPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mnuPersonal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuPersonal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregarPersonal,
            this.mnuEliminarPersonal,
            this.mnuEditarPersonal});
            this.mnuPersonal.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuPersonal.Name = "mnuPersonal";
            this.mnuPersonal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuPersonal.Size = new System.Drawing.Size(152, 22);
            this.mnuPersonal.Text = "admins";
            this.mnuPersonal.ToolTipText = "Gestionar el personal ";
            // 
            // mnuAgregarPersonal
            // 
            this.mnuAgregarPersonal.AutoSize = false;
            this.mnuAgregarPersonal.AutoToolTip = true;
            this.mnuAgregarPersonal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuAgregarPersonal.Image = global::WindowsFormsApp1.Properties.Resources.userAdd2;
            this.mnuAgregarPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAgregarPersonal.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuAgregarPersonal.Name = "mnuAgregarPersonal";
            this.mnuAgregarPersonal.Size = new System.Drawing.Size(211, 82);
            this.mnuAgregarPersonal.Text = "add";
            this.mnuAgregarPersonal.ToolTipText = "Agregar un empleado nuevo";
            this.mnuAgregarPersonal.Click += new System.EventHandler(this.mnuAgregarPersonal_Click);
            // 
            // mnuEliminarPersonal
            // 
            this.mnuEliminarPersonal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuEliminarPersonal.Image = global::WindowsFormsApp1.Properties.Resources.userRemove2;
            this.mnuEliminarPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuEliminarPersonal.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuEliminarPersonal.Name = "mnuEliminarPersonal";
            this.mnuEliminarPersonal.Size = new System.Drawing.Size(211, 82);
            this.mnuEliminarPersonal.Text = "remove";
            // 
            // mnuEditarPersonal
            // 
            this.mnuEditarPersonal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuEditarPersonal.Image = global::WindowsFormsApp1.Properties.Resources.userEdit2;
            this.mnuEditarPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuEditarPersonal.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuEditarPersonal.Name = "mnuEditarPersonal";
            this.mnuEditarPersonal.Size = new System.Drawing.Size(211, 82);
            this.mnuEditarPersonal.Text = "edit";
            // 
            // mnuObrasSociales
            // 
            this.mnuObrasSociales.AutoToolTip = true;
            this.mnuObrasSociales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuObrasSociales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgregarObraSocial,
            this.mnuEliminarObraSocial,
            this.mnuEditarObrasSociales});
            this.mnuObrasSociales.Image = global::WindowsFormsApp1.Properties.Resources.obrasSociales;
            this.mnuObrasSociales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuObrasSociales.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuObrasSociales.Name = "mnuObrasSociales";
            this.mnuObrasSociales.Size = new System.Drawing.Size(105, 79);
            this.mnuObrasSociales.Text = "os";
            this.mnuObrasSociales.ToolTipText = "Administrar datos de obras sociales";
            // 
            // mnuRecetarios
            // 
            this.mnuRecetarios.AutoToolTip = true;
            this.mnuRecetarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuRecetarios.Image = global::WindowsFormsApp1.Properties.Resources.medicOrder;
            this.mnuRecetarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuRecetarios.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuRecetarios.Name = "mnuRecetarios";
            this.mnuRecetarios.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuRecetarios.Size = new System.Drawing.Size(105, 79);
            this.mnuRecetarios.Text = "receta";
            this.mnuRecetarios.ToolTipText = "Recetarios";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.AutoToolTip = true;
            this.reportesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reportesToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.report;
            this.reportesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(105, 79);
            this.reportesToolStripMenuItem.Text = "reportes";
            this.reportesToolStripMenuItem.ToolTipText = "Imprimir reportes";
            // 
            // cambiarUsuarioToolStripMenuItem
            // 
            this.cambiarUsuarioToolStripMenuItem.AutoToolTip = true;
            this.cambiarUsuarioToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cambiarUsuarioToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.changeUser;
            this.cambiarUsuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cambiarUsuarioToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.cambiarUsuarioToolStripMenuItem.Name = "cambiarUsuarioToolStripMenuItem";
            this.cambiarUsuarioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.cambiarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(105, 79);
            this.cambiarUsuarioToolStripMenuItem.Text = "cambiar usuario";
            this.cambiarUsuarioToolStripMenuItem.ToolTipText = "Cerrar sesión e iniciar con otro usuario";
            this.cambiarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cambiarUsuarioToolStripMenuItem_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.AutoToolTip = true;
            this.mnuSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuSalir.Image = global::WindowsFormsApp1.Properties.Resources.exitIcon;
            this.mnuSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSalir.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(105, 79);
            this.mnuSalir.Text = "cerrar";
            this.mnuSalir.ToolTipText = "Salir del sistema";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.AutoToolTip = true;
            this.mnuAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuAyuda.Image = global::WindowsFormsApp1.Properties.Resources.help;
            this.mnuAyuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAyuda.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuAyuda.Name = "mnuAyuda";
            this.mnuAyuda.Size = new System.Drawing.Size(105, 79);
            this.mnuAyuda.Text = "help";
            this.mnuAyuda.ToolTipText = "Ayuda";
            // 
            // mnuAgregarObraSocial
            // 
            this.mnuAgregarObraSocial.AutoToolTip = true;
            this.mnuAgregarObraSocial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuAgregarObraSocial.Image = global::WindowsFormsApp1.Properties.Resources.obraSocialAdd;
            this.mnuAgregarObraSocial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAgregarObraSocial.Name = "mnuAgregarObraSocial";
            this.mnuAgregarObraSocial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuAgregarObraSocial.Size = new System.Drawing.Size(211, 82);
            this.mnuAgregarObraSocial.Text = "add";
            this.mnuAgregarObraSocial.ToolTipText = "Agregar una nueva obra social";
            // 
            // mnuEliminarObraSocial
            // 
            this.mnuEliminarObraSocial.AutoToolTip = true;
            this.mnuEliminarObraSocial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuEliminarObraSocial.Image = global::WindowsFormsApp1.Properties.Resources.obraSocialRemove;
            this.mnuEliminarObraSocial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuEliminarObraSocial.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuEliminarObraSocial.Name = "mnuEliminarObraSocial";
            this.mnuEliminarObraSocial.Size = new System.Drawing.Size(211, 82);
            this.mnuEliminarObraSocial.Text = "remove";
            this.mnuEliminarObraSocial.ToolTipText = "Eliminar obras sociales";
            // 
            // mnuEditarObrasSociales
            // 
            this.mnuEditarObrasSociales.AutoToolTip = true;
            this.mnuEditarObrasSociales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuEditarObrasSociales.Image = global::WindowsFormsApp1.Properties.Resources.obrasSocialesEdit;
            this.mnuEditarObrasSociales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuEditarObrasSociales.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuEditarObrasSociales.Name = "mnuEditarObrasSociales";
            this.mnuEditarObrasSociales.Size = new System.Drawing.Size(211, 82);
            this.mnuEditarObrasSociales.Text = "edit";
            this.mnuEditarObrasSociales.ToolTipText = "Editar datos de obras sociales";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1391, 664);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de obras sociales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuMedicos;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregarMedico;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminarMedico;
        private System.Windows.Forms.ToolStripMenuItem ffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPacientes;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregarPaciente;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminarPaciente;
        private System.Windows.Forms.ToolStripMenuItem mnuEditarPacientes;
        private System.Windows.Forms.ToolStripMenuItem mnuRecetarios;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuPersonal;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregarPersonal;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminarPersonal;
        private System.Windows.Forms.ToolStripMenuItem mnuEditarPersonal;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnuObrasSociales;
        private System.Windows.Forms.ToolStripMenuItem mnuAgregarObraSocial;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminarObraSocial;
        private System.Windows.Forms.ToolStripMenuItem mnuEditarObrasSociales;
    }
}

