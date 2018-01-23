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
using DAO;
using Entidades;

namespace WindowsFormsApp1
{
    public partial class Usuarios_baja : Form
    {
        string usuario;

        public Usuarios_baja()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        #region txtUsuario
        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
           usuario = txtUsuario.Text;

            GestorUsuarios _gestorUsuarios = new GestorUsuarios();
            UsuarioDTO _usuario = new UsuarioDTO();

            _usuario = _gestorUsuarios.ObtenerCuentaPorUsername(usuario);

            if (_usuario != null)
            {
                lblNombre.Text = _usuario.Nombre;
                lblTipoUsuario.Text = _usuario.Tipo_usuario.Denominacion;
                //lblConexion.Text = ultima conexion
                btnEliminar.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(txtUsuario, "El usuario buscado no existe");
                txtUsuario.Focus();
                btnEliminar.Enabled = false;
            }
        }

        #endregion

        private void Usuarios_baja_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar al usuario " + usuario,"Baja de usuarios",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Elimina el usuario
                usuario = "";
                txtUsuario.Focus();
            }
        }
    }
}
