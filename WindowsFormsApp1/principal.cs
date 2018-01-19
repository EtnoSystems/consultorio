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
           // MessageBox.Show("hola don " + Globales.userObject.Id.ToString());
            
            // MessageBox.Show("Bienvenido " + Globales.userName);
            if (Globales.userType == "admin")
                principalToolStripMenuItem.Visible = true;
            else
                principalToolStripMenuItem.Visible = false;

            this.Text = "Gestión de obras sociales - USUARIO " + Globales.userObject.nombre;
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
