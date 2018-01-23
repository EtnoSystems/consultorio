using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace WindowsFormsApp1
{
    public partial class Usuarios_alta : Form
    {

        string pass, pass2, nombre, tipo;

#region Formulario
        public Usuarios_alta()
        {
            InitializeComponent();
        }

        private void usuarios_alta_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnGuardarAgregar.Enabled = false;
            txtNombre.ForeColor = Color.Silver;

            GestorTiposDeUsuarios gestorTiposUsuarios = new GestorTiposDeUsuarios();
            /*List<Tipo_usuarioDTO> listaTipos = gestorTiposUsuarios.ListarTiposUsuarios();
            /*CmbTipo.DataSource= (from n in listaTipos
                        select n.Denominacion).ToList();*/
            
            CmbTipo.DataSource = gestorTiposUsuarios.ListarTiposUsuarios();
            CmbTipo.ValueMember = "Id";
            CmbTipo.DisplayMember = "Denominacion";
            
        }
        #endregion

#region Password 1
        private void txtPassword1_Enter(object sender, EventArgs e)
        {
            TxtPassword1.ForeColor = Color.Black;
            TxtPassword1.Text = "";
        }

        private void TxtPassword1_Leave(object sender, EventArgs e)
        {
            if (TxtPassword1.Text == "Contraseña" || TxtPassword1.Text == "")
            {
                TxtPassword1.ForeColor = Color.Silver;
                TxtPassword1.Text = "Contraseña";
            }
            else
            {
                pass = TxtPassword1.Text;
                habilitarBotones();
            }
        }
        #endregion

#region Password 2
        private void txtPassword2_Leave(object sender, EventArgs e)
        {
            habilitarBotones();
        }

        private void txtPassword2_Enter(object sender, EventArgs e)
        {
            TxtPassword2.ForeColor = Color.Black;
            TxtPassword2.Text = "";
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword2_Validating(object sender, CancelEventArgs e)
        {
            if (TxtPassword2.Text == "Contraseña" || TxtPassword2.Text == "")
            {
                TxtPassword2.ForeColor = Color.Silver;
                TxtPassword2.Text = "Contraseña";
            }
            else
            {
                pass2 = TxtPassword2.Text;

                if (pass != pass2)
                {
                    errorProvider1.SetError(TxtPassword2, "Las contraseñas ingresadas no coinciden");
                    TxtPassword2.Text = "";
                    //TxtPassword1.Focus();
                }
                else
                {
                    errorProvider1.SetError(TxtPassword2, null);
                }
            }
        }
        #endregion

#region txtUsuario

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            nombre = txtUsuario.Text;
            //verifica que el usuario ingresado no exista
            GestorUsuarios gestorUsuarios = new GestorUsuarios();
            UsuarioDTO usuario = gestorUsuarios.ObtenerCuentaPorUsername(nombre);

            if (usuario != null)
            {
                errorProvider1.SetError(txtUsuario, "El nombre de usuario ingresado no está disponible");
                txtUsuario.Focus();
            }
            else
            {
                errorProvider1.SetError(txtUsuario, null);
            }
            
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            habilitarBotones();
            if (txtUsuario.Text == "")
            {
                txtUsuario.ForeColor = Color.Silver;
                txtUsuario.Text = "Nombre de usuario";
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Text = "";
        }
        #endregion

#region txtNombre
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            habilitarBotones();
            if (txtNombre.Text == "")
            {
                txtNombre.ForeColor = Color.Silver;
                txtNombre.Text = "Nombre completo";
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
           if (txtNombre.Text == "Nombre completo")
            {
                txtNombre.ForeColor = Color.Black;
              //  txtNombre.Text = "";
            }
        }
        #endregion

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbTipo_Click(object sender, EventArgs e)
        {
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTipo_DropDownClosed(object sender, EventArgs e)
        {
           habilitarBotones();
           MessageBox.Show(CmbTipo.SelectedValue.ToString());
        }

#region Funciones

        void habilitarBotones()
        {
            if (txtNombre.Text != "" && txtNombre.Text != "Nombre completo"
                && txtUsuario.Text != "" && txtUsuario.Text != "Nombre de usuario"
                && TxtPassword1.Text != "" && TxtPassword1.Text != "Contraseña"
                && TxtPassword2.Text != "" && TxtPassword2.Text != "Repita la contraseña"
                && CmbTipo.Text != "Tipo de usuario")
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

        void agregarUsuario(string nombre, string usuario, string clave, int id)
        {

        }
#endregion
    }
}
