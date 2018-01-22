using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //consultaUsuarios consultaUsuarios = new consultaUsuarios();
            //consultaUsuarios.Show();    
            Usuarios_alta usuariosAlta = new Usuarios_alta();
            usuariosAlta.Show();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login _login = new Login();
            _login.Show();
        }

        private void PrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {       
            if (Globales.userType == "admin")
                mnuUsuarios.Visible = true;
            else
                mnuUsuarios.Visible = false;

            this.Text = "Gestión de obras sociales - USUARIO "+ Globales.userObject.nombre;

            //Correcciones del tamaño de los menús
           mnuMedicos.Size = new Size(125, 125);
           mnuPacientes.Size = new Size(125, 125);
           mnuPersonal.Size = new Size(125, 125);
          
            //mnuMedicos.Padding = new Padding(0, 0, -15, 0);

            //mnuAgregarMedico.Size = new Size(125, 120);
            //mnuAgregarMedico.Padding = new Padding(0, 0, 0, 0);

            //mnuAgregarPaciente.Padding = new Padding(0, 0, 0, 0);
            //mnuSalir.Size = new Size(120,120);
            //mnuSalir.ImageScaling =
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del programa?", "Cerrar sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cambiar de usuario?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                Globales.userName = "";
                Globales.userType = "";
                login.Show();
                this.Hide();
            }
        }

        private void mnuAgregarPersonal_Click(object sender, EventArgs e)
        {
            Usuarios_alta altas = new Usuarios_alta();
            altas.Show();
        }
    }
}
