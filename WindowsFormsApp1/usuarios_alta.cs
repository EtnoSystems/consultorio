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
    public partial class Usuarios_alta : Form
    {

        string pass, pass2, nombre, tipo;

        private void txtPassword1_Enter(object sender, EventArgs e)
        {
            txtPassword1.ForeColor = Color.Black;
            txtPassword1.Text = "";
        }

        private void txtPassword2_Leave(object sender, EventArgs e)
        {
            if (txtPassword2.Text == "Contraseña" || txtPassword2.Text == "")
            {
                txtPassword2.ForeColor = Color.Silver;
                txtPassword2.Text = "Contraseña";
            }
            else
            {
                pass2 = txtPassword2.Text;

                if (pass != pass2)
                {
                    txtPassword1.Text = "";
                    txtPassword2.Text = "";
                    txtPassword1.Focus();
                }
            }
        }

        private void txtPassword2_Enter(object sender, EventArgs e)
        {
            txtPassword2.ForeColor = Color.Black;
            txtPassword2.Text = "";
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword1_Leave(object sender, EventArgs e)
        {
            if (txtPassword1.Text == "Contraseña" || txtPassword1.Text == "")
            {
                txtPassword1.ForeColor = Color.Silver;
                txtPassword1.Text = "Contraseña";
            }
            else
            {
                pass = txtPassword1.Text;
            }
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword2_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtPassword2, "Las contraseñas insgresadas no coinciden");
        }

        public Usuarios_alta()
        {
            InitializeComponent();
        }

        private void usuarios_alta_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnGuardarAgregar.Enabled = false;
        }

        // FUNCIONES 

        void habilitarBotones()
        {
            if (txtNombre.Text != "" && txtNombre.Text != "Nombre completo"
                && txtUsuario.Text != "" && txtUsuario.Text != "Nombre de usuario"
                && txtPassword1.Text != "" && txtPassword1.Text != "Contraseña"
                && txtPassword2.Text != "" && txtPassword2.Text != "Contraseña"
                && cmbTipo.Text != "Tipo de usuario")
            {
                btnGuardar.Enabled = true;
                btnGuardarAgregar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
                btnGuardarAgregar.Enabled = false;
            }
        }
    }
}
