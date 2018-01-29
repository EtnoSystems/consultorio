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

        //string pass, pass2, nombre;
        bool primerinicio = true;
        bool badpassword = false;

#region Formulario
        public Usuarios_alta()
        {
            InitializeComponent();
        }

        private void Usuarios_alta_Load(object sender, EventArgs e)
        {

            EstadoInicial();
            

            GestorTiposDeUsuarios gestorTiposUsuarios = new GestorTiposDeUsuarios();
            /*List<Tipo_usuarioDTO> listaTipos = gestorTiposUsuarios.ListarTiposUsuarios();
            /*CmbTipo.DataSource= (from n in listaTipos
                        select n.Denominacion).ToList();*/
            
            CmbTipo.DataSource = gestorTiposUsuarios.ListarTiposUsuarios();
            CmbTipo.ValueMember = "Id";
            CmbTipo.DisplayMember = "Denominacion";
            CmbTipo.SelectedIndex = 1;
        }
        #endregion

#region Password 1
        private void TxtPassword1_Enter(object sender, EventArgs e)
        {
            if (badpassword)
            {
                badpassword = false;
            }
            else
            {
                TxtPassword1.ForeColor = Color.Black;
                if (TxtPassword1.Text == "Contraseña")
                    TxtPassword1.Text = "";
            }
            
            
            
            
        }

        private void TxtPassword1_Leave(object sender, EventArgs e)
        {
            if (TxtPassword1.Text == "Contraseña" || TxtPassword1.Text == "")
            {
                TxtPassword1.ForeColor = Color.Silver;
                TxtPassword1.Text = "Contraseña";
            }
            
        }
        #endregion

#region Password 2
        private void TxtPassword2_Leave(object sender, EventArgs e)
        {
            if (TxtPassword2.Text == "Repita la contraseña" || TxtPassword2.Text=="")
            {
                TxtPassword2.ForeColor = Color.Silver;
                TxtPassword2.Text = "Repita la contraseña";
            }
        }

        private void TxtPassword2_Enter(object sender, EventArgs e)
        {
            TxtPassword2.ForeColor = Color.Black;

            if (TxtPassword2.Text=="Repita la contraseña")
                TxtPassword2.Text = "";
        }

        private void TxtPassword2_TextChanged(object sender, EventArgs e)
        {
            if (TxtPassword2.Text!="Repita la contraseña")
            {
                errorProvider1.SetError(TxtPassword2, null);
            }
                

            ValidarCamposCompletos();

        }

        private void TxtPassword2_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtPassword2.Text)||(TxtPassword2.Text=="")||(TxtPassword2.Text=="Repita la contraseña"))
            {
                TxtPassword2.Text = "Repita la contraseña";
                TxtPassword2.ForeColor = Color.Silver;
                errorProvider1.SetError(TxtPassword2, "Debe confirmar la contraseña");
                return;
          
            }

            if (TxtPassword1.Text.Trim() != TxtPassword2.Text.Trim())
            {
                errorProvider1.SetError(TxtPassword2, "Las contraseñas ingresadas no coinciden");
                return;
            }
        }
        #endregion

#region txtUsuario

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposCompletos();
        }

        private void TxtUsuario_Validating(object sender, CancelEventArgs e)
        {
            //verifica que el usuario ingresado no exista
            GestorUsuarios gestorUsuarios = new GestorUsuarios();
            UsuarioDTO usuario = gestorUsuarios.ObtenerCuentaPorUsername(txtUsuario.Text.ToLower().Trim());

            if (usuario != null)
            {
                errorProvider1.SetError(txtUsuario, "El nombre de usuario ingresado no está disponible");
                //txtUsuario.Focus();
            }
            else
            {
                errorProvider1.SetError(txtUsuario, null);
            }
            
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            //HabilitarBotones();
            if (txtUsuario.Text == "")
            {
                txtUsuario.ForeColor = Color.Silver;
                txtUsuario.Text = "Nombre de usuario";
            }
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.ForeColor = Color.Black;
            if(txtUsuario.Text=="Nombre de usuario")
            {
                txtUsuario.Text = "";
            }
        }
        #endregion

#region txtNombre
        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposCompletos();
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
           // HabilitarBotones();
            if (txtNombre.Text == "" || txtNombre.Text=="Nombre completo")
            {
                txtNombre.ForeColor = Color.Silver;
                txtNombre.Text = "Nombre completo";
            }
            
        }

        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            if (primerinicio)
            {
                primerinicio = false;
                txtNombre.SelectAll();
            }
            else
            {
                if (txtNombre.Text=="Nombre completo")
                {
                    //txtNombre.ForeColor = Color.Black;
                    txtNombre.Text = "";
                }
                    
                
            }
            txtNombre.ForeColor = Color.Black;

        }
        #endregion

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarErrorProviders())
                return;

            AgregarUsuario(txtNombre.Text.ToLower().Trim(), txtUsuario.Text.ToLower().Trim(), TxtPassword1.Text.Trim(), Convert.ToInt32(CmbTipo.SelectedValue.ToString()));
            this.Close();  
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

        private void btnGuardarAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarErrorProviders())
                return;


            
            AgregarUsuario(txtNombre.Text.ToLower().Trim(), txtUsuario.Text.ToLower().Trim(), TxtPassword1.Text.Trim(), Convert.ToInt32(CmbTipo.SelectedValue.ToString()));
            EstadoInicial();
                   
        }

        private void CmbTipo_DropDownClosed(object sender, EventArgs e)
        {
           //HabilitarBotones();
          // MessageBox.Show(CmbTipo.SelectedValue.ToString());
        }

        private void TxtPassword1_TextChanged(object sender, EventArgs e)
        {
            if (TxtPassword1.Text!="Contraseña")
            {
                errorProvider1.SetError(TxtPassword1, null);
                errorProvider1.SetError(TxtPassword2, null);
            }
                

            ValidarCamposCompletos();
        }

        #region Funciones

        void ValidarCamposCompletos()
        {
            if (txtNombre.Text != "" && txtNombre.Text != "Nombre completo"
                && txtUsuario.Text != "" && txtUsuario.Text != "Nombre de usuario"
                && TxtPassword1.Text != "" && TxtPassword1.Text != "Contraseña"
                && TxtPassword2.Text != "" && TxtPassword2.Text != "Repita la contraseña")
                //&& CmbTipo.Text != "Tipo de usuario")
            {
                btnGuardar.Enabled = true;
                btnGuardarAgregar.Enabled = true;
                btnGuardar.BackgroundImage = Image.FromFile(@"C:\Users\Jorge\Desktop\consultorios\consultorios\WindowsFormsApp1\images\botonGuardarHabilitado.png");
                btnGuardarAgregar.BackgroundImage = Image.FromFile(@"C:\Users\Jorge\Desktop\consultorios\consultorios\WindowsFormsApp1\images\botonGuardarAgregarHabilitado.png");

            }
            else
            {
                btnGuardar.Enabled = false;
                btnGuardarAgregar.Enabled = false;
                btnGuardar.BackgroundImage = Image.FromFile(@"C:\Users\Jorge\Desktop\consultorios\consultorios\WindowsFormsApp1\images\botonGuardarDeshabilitado.png");
                btnGuardarAgregar.BackgroundImage = Image.FromFile(@"C:\Users\Jorge\Desktop\consultorios\consultorios\WindowsFormsApp1\images\botonGuardarAgregarDeshabilitado.png");
            }
        }

        bool ValidarErrorProviders()
        {
            if (errorProvider1.GetError(txtUsuario) != "")
            {
                txtUsuario.SelectAll();
                txtUsuario.Focus();
                return false;
            }

            if (errorProvider1.GetError(TxtPassword2) != "")
            {
                badpassword = true;
                TxtPassword1.Text = "Contraseña";
                TxtPassword2.Text = "Repita la contraseña";
                TxtPassword2.ForeColor = Color.Silver;
                TxtPassword1.Focus();
                TxtPassword1.SelectAll();
                return false;
            }
            return true;
        }

        void AgregarUsuario(string nombreCompleto, string username, string clave, int id)
        {
            GestorTiposDeUsuarios gestorTiposDeUsuarios = new GestorTiposDeUsuarios();
            gestorTiposDeUsuarios.ObtenerTipoUsuarioPorId(Convert.ToInt32(CmbTipo.SelectedValue.ToString()));
            
            //PRIMERO DEBO CREAR UN OBJETO TIPO_USUARIO BUSCANDOLO POR ID EN LA BASE DE DATOS
            Tipo_usuarioDTO tipo_UsuarioDTO = gestorTiposDeUsuarios.ObtenerTipoUsuarioPorId(id);

            GestorUsuarios gestorUsuarios = new GestorUsuarios();

            if (gestorUsuarios.AgregarUsuario(nombreCompleto, username, clave, tipo_UsuarioDTO) > 0)
                MessageBox.Show("El usuario " + username + " ha sido agregado correctamente","¡Nuevo usuario en el sistema!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("El usuario no pudo ser guardado","Error de guardado",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //MessageBox.Show("El usuario obtenido " + tipo_UsuarioDTO.Id.ToString() + " " + tipo_UsuarioDTO.Denominacion);
        }

        void EstadoInicial()
        {
            btnGuardar.Enabled = false;
            btnGuardarAgregar.Enabled = false;
            txtNombre.ForeColor = Color.Silver;
            btnGuardar.BackgroundImage = Image.FromFile(@"C:\Users\Jorge\Desktop\consultorios\consultorios\WindowsFormsApp1\images\botonGuardarDeshabilitado.png");
            btnGuardarAgregar.BackgroundImage = Image.FromFile(@"C:\Users\Jorge\Desktop\consultorios\consultorios\WindowsFormsApp1\images\botonGuardarAgregarDeshabilitado.png");
            txtNombre.Text = "Nombre completo";
            txtNombre.SelectAll();
            txtUsuario.ForeColor = Color.Silver;
            txtUsuario.Text = "Nombre de usuario";
            TxtPassword1.ForeColor = Color.Silver;
            TxtPassword1.Text = "Contraseña";
            TxtPassword2.ForeColor = Color.Silver;
            TxtPassword2.Text = "Repita la contraseña";
            txtNombre.Focus();
            
        }

        #endregion

        private void TxtPassword1_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(TxtPassword1.Text) || (TxtPassword1.Text=="") || (TxtPassword1.Text=="Contraseña"))
            {
                TxtPassword1.Text = "Contraseña";
                TxtPassword1.ForeColor = Color.Silver;
                errorProvider1.SetError(TxtPassword1, "Debe definir una contraseña");
                return;
            }

            if ((TxtPassword2.Text.Trim() != "") && (TxtPassword1.Text.Trim() != TxtPassword2.Text.Trim()))
            {
                errorProvider1.SetError(TxtPassword2, "Las contraseñas ingresadas no coinciden");
                return;
            }

        }
    }
}
