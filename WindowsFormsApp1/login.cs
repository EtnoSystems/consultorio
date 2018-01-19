using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica; //Agregué la referencia a la capa lógica para tener acceso al gestor de usuarios
using Entidades;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        //VARIABLES
        string nombre, clave;
        //
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }
        
        // USUARIO ---------------------------------------------------------
        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Usuario")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.Black;
            }
        }
        
        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void TxtUsuario_LostFocus(object sender, EventArgs e) //Cuando se saca foco, guarda el usuario
        {
            nombre = TxtUsuario.Text;
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e) //con enter hace foco en el campo password
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtPassword.Focus();
            }
        }

        // PASSWORD ---------------------------------------------------------
        private void TxtPassword_Enter(object sender, EventArgs e) //GET FOCUS
        {
            TxtPassword.UseSystemPasswordChar = true;
            if (TxtPassword.Text == "Contraseña")
            {
                TxtPassword.Text = "";
                TxtPassword.ForeColor = Color.Black;
            }
        }

        private void TxtPassword_LostFocus(object sender, EventArgs e)
        {
           // clave = txtPassword.Text;
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (TxtPassword.Text != "")
                BtnMostrarOcultar.Visible = true;
            else
            {
                BtnMostrarOcultar.Visible = false;
                
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clave = TxtPassword.Text;
                IniciarSesion(nombre, clave);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            BtnMostrarOcultar.Visible = false;
            TxtPassword.UseSystemPasswordChar = false;
        }
        
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (nombre != "" && clave != "")
                IniciarSesion(nombre, clave);
            else
            {
                MessageBox.Show("Debe ingresar un nombre de usuario y una clave");
                TxtUsuario.Focus();
            }
                
        }
       
        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del programa?","Cerar Sistema",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit();
        }

        private void BtnMostrarOcultar_Click(object sender, EventArgs e)
        {

        }

        private void BtnMostrarOcultar_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = false;
        }

        private void BtnMostrarOcultar_MouseUp(object sender, MouseEventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = true;
        }

        private void BxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "Contraseña";
                TxtPassword.UseSystemPasswordChar = false;
                TxtPassword.ForeColor = Color.LightGray;
                BtnMostrarOcultar.Visible = false;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "Usuario";
                TxtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void IniciarSesion(string nombre, string clave)
        {
            GestorUsuarios _gestorUsuarios = new GestorUsuarios();
            //string nombre = txtUsuario.Text; //La variable nombre guarda el nombre con el que el usuario intenta iniciar sesión
            UsuarioDTO _usuario = new UsuarioDTO();

            //_usuario = _gestorUsuarios.ObtenerCuentaPorUsername(nombre);
            _usuario = _gestorUsuarios.IniciarSesion(nombre, clave);

            if (_usuario != null)
            {
                Globales.userObject = _gestorUsuarios.ObtenerCuentaPorUsername(_usuario.nombre);

                
                Globales.userName = _usuario.nombre;
                Globales.userType = _usuario.tipo_usuario;
                //MessageBox.Show("Bienvenido al sistema " + Globales.userName, "Ha iniciado sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
               Principal main = new Principal();
               main.Show();
               this.Hide();
            }
            else
            {
                MessageBox.Show("No se pudo iniciar sesión, controle los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*if (_usuario != null) //chequea si el nombre que el usuario ingresó existe en la BD
            {
                MessageBox.Show("se encontró el usuario: " + _usuario.nombre + " " + _usuario.password + " " + _usuario.tipo_usuario);
            }
            else
            {
                //Mensaje de error en el inicio de sesión
                MessageBox.Show("El usuario ingresado no existe", "Error en el inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
            }*/
        }

    }
}
