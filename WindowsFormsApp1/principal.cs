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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //consultaUsuarios consultaUsuarios = new consultaUsuarios();
            //consultaUsuarios.Show();    
            usuarios_alta usuariosAlta = new usuarios_alta();
            usuariosAlta.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login _login = new login();
            _login.Show();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void principal_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("hola don " + Globales.userObject.Id.ToString());
            
            // MessageBox.Show("Bienvenido " + Globales.userName);
            if (Globales.userType == "admin") principalToolStripMenuItem.Visible = true; else principalToolStripMenuItem.Visible = false;
            this.Text = "Gestión de obras sociales - USUARIO " + Globales.userObject.nombre;
        }
    }
}
