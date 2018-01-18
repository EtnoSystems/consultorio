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
    public partial class login : Form
    {
        //VARIABLES
        string nombre, clave;
        //
        public login()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }
        
        // USUARIO ---------------------------------------------------------
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }
        
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void txtUsuario_LostFocus(object sender, EventArgs e) //Cuando se saca foco, guarda el usuario
        {
            nombre = txtUsuario.Text;
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e) //con enter hace foco en el campo password
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        // PASSWORD ---------------------------------------------------------
        private void txtPassword_Enter(object sender, EventArgs e) //GET FOCUS
        {
            txtPassword.UseSystemPasswordChar = true;
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_LostFocus(object sender, EventArgs e)
        {
           // clave = txtPassword.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
                btnMostrarOcultar.Visible = true;
            else
            {
                btnMostrarOcultar.Visible = false;
                
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clave = txtPassword.Text;
                iniciarSesion(nombre, clave);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            btnMostrarOcultar.Visible = false;
            txtPassword.UseSystemPasswordChar = false;
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (nombre != "" && clave != "") iniciarSesion(nombre, clave); else txtUsuario.Focus();
        }
       
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del programa?","Cerar Sistema",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit();
        }

        private void btnMostrarOcultar_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarOcultar_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnMostrarOcultar_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = Color.LightGray;
                btnMostrarOcultar.Visible = false;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void iniciarSesion(string nombre, string clave)
        {
            gestorUsuarios _gestorUsuarios = new gestorUsuarios();
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
              
               principal main = new principal();
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
