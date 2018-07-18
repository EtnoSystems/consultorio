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
        int id;
        bool primerInicio = true;
        //string //usuario;

        public Usuarios_baja()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        #region txtUsuario
        /* private void txtUsuario_Validating(object sender, CancelEventArgs e)
         {
            usuario = TxtUsuario.Text;

             GestorUsuarios _gestorUsuarios = new GestorUsuarios();
             UsuarioDTO _usuario = new UsuarioDTO();

             _usuario = _gestorUsuarios.ObtenerCuentaPorUsername(usuario);

             if (_usuario != null)
             {
                 if(_usuario.Nombre!=Globales.userName)
                 {
                     LblNombreCompleto.Text = _usuario.Nombre_completo;
                     LblTipoUsuario.Text = _usuario.Tipo_usuario.Denominacion;
                     //lblConexion.Text = ultima conexion
                     btnEliminar.Enabled = true;
                 }
                 else
                 {
                     MessageBox.Show("No puede eliminar su propia cuenta de usuario");
                     EstadoInicial();
                 }

             }
             else
             {
                 errorProvider1.SetError(TxtUsuario, "El usuario buscado no existe");
                 TxtUsuario.Focus();
                 btnEliminar.Enabled = false;
             }
         }*/

        #endregion

        private void Usuarios_baja_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro que desea eliminar el usuario seleccionado?" , "Baja de usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                GestorUsuarios.EliminarUsuarioPorId(id);
            
            }
            EstadoInicial();
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (primerInicio)
            {
                primerInicio = false;
                TxtUsuario.ForeColor = Color.Black;
            }
            else
            {

            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void EstadoInicial()
        {
            DgvResultadoBusqueda.Visible = false;
            btnEliminar.Enabled = false;
            TxtUsuario.Text = "Nombre de usuario";
            TxtUsuario.ForeColor = Color.Black;
            TxtUsuario.SelectAll();
            TxtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ValidarErrorProviders())
            {
                return;
            }

 
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarUsuarios();
            }

        }

        private void DgvResultadoBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnEliminar.BackgroundImage = Image.FromFile(@"..\..\images\botonEliminarUsuario.png");
            //MessageBox.Show("El id del usuario seleccionado es "+ DgvResultadoBusqueda.Rows[e.RowIndex].Cells[0].Value.ToString());
            id = Convert.ToInt32(DgvResultadoBusqueda.Rows[e.RowIndex].Cells[0].Value);
            MessageBox.Show("el id seleccionado es " + id);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }

        void BuscarUsuarios()
        {
            GestorUsuarios gestorUsuarios = new GestorUsuarios();
            List<object> resultado_busqueda = gestorUsuarios.BuscarUsuarios(TxtUsuario.Text);

            if (resultado_busqueda.Count != 0)
            {
                DgvResultadoBusqueda.DataSource = resultado_busqueda;
                DgvResultadoBusqueda.Columns["Id"].Visible = false;
                DgvResultadoBusqueda.Visible = true;

                DgvResultadoBusqueda.RowHeadersVisible = false;
                DgvResultadoBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DgvResultadoBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgvResultadoBusqueda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; 
                DgvResultadoBusqueda.BackgroundColor = SystemColors.ControlLightLight;
                
                DgvResultadoBusqueda.Columns[1].HeaderText = "Usuario";
                DgvResultadoBusqueda.Columns[1].Width = 60;
                DgvResultadoBusqueda.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DgvResultadoBusqueda.Columns[2].HeaderText = "Nombre completo";
                DgvResultadoBusqueda.Columns[2].Width = 190;
                DgvResultadoBusqueda.Columns[3].HeaderText = "Privilegios";
                DgvResultadoBusqueda.Columns[3].Width = 80;
                DgvResultadoBusqueda.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("La busqueda no produjo resultados");
            }
        }

        private void TxtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (TxtUsuario.Text == "Nombre completo" || string.IsNullOrWhiteSpace(TxtUsuario.Text))
            {
                errorProvider1.SetError(TxtUsuario, "Este campo es obligatorio");
                return;
            }

            if (TxtUsuario.Text.ToLower().Trim() == Globales.userName)
            {
                errorProvider1.SetError(TxtUsuario, "No se puede eliminar el usuario actual");
                TxtUsuario.SelectAll();
                TxtUsuario.Focus();
                return;
            }
        }

        bool ValidarErrorProviders()
        {
            if (errorProvider1.GetError(TxtUsuario) != "")
            {
                TxtUsuario.Focus();
                TxtUsuario.SelectAll();
                return false;
            }
            return true;
        }

        private void TxtUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void DgvResultadoBusqueda_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var height = 40;
            foreach (DataGridViewRow dr in DgvResultadoBusqueda.Rows)
            {
                height += dr.Height;
            }

            DgvResultadoBusqueda.Height = height;
        }
    }
}
