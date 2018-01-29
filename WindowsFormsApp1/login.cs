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
using DAO;
using Entidades;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        //VARIABLES
 
        bool primerinicio = true;
        //
        public Login()
        {
            InitializeComponent();
           // this.ActiveControl = label1;
        }
        
        // USUARIO ---------------------------------------------------------
        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (primerinicio)
            {
                primerinicio = false;
                TxtUsuario.SelectAll();
                TxtUsuario.ForeColor = Color.Black;
            }
            else
            {
                if (TxtUsuario.Text == "Usuario")
                {
                    TxtUsuario.Text = "";
                    TxtUsuario.ForeColor = Color.Black;
                }
            }

            
        }
        
        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposCompletos();
        }

        private void TxtUsuario_LostFocus(object sender, EventArgs e) //Cuando se saca foco, guarda el usuario
        {
            
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
            ValidarCamposCompletos();
            if (TxtPassword.Text != "")
                BtnMostrarOcultar.Visible = true;
            else
                BtnMostrarOcultar.Visible = false;
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IniciarSesion(TxtUsuario.Text.ToLower(), TxtPassword.Text.ToLower());
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath);
            EstadoInicial();
        }
        
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text != "" && TxtPassword.Text!= "" && TxtUsuario.Text!="Usuario" && TxtPassword.Text!="Contraseña")
                IniciarSesion(TxtUsuario.Text.ToLower().Trim(), TxtPassword.Text.Trim());
            else
            {
                MessageBox.Show("Debe ingresar un nombre de usuario y una clave");
                EstadoInicial();
                
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

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text=="" || TxtPassword.Text=="Contraseña")
            {
                TxtPassword.ForeColor = Color.LightGray;
                TxtPassword.Text = "Contraseña";
                TxtPassword.UseSystemPasswordChar = false;
                BtnMostrarOcultar.Visible = false;
            }
        }

        private void IniciarSesion(string nombre, string clave)
        {
            GestorUsuarios _gestorUsuarios = new GestorUsuarios();
            UsuarioDTO _usuario = new UsuarioDTO();
            
            _usuario = _gestorUsuarios.BuscarUsuarioPorUsername(nombre);

            if (_usuario != null)
            {
                
                if (string.Equals(clave, _usuario.Password))
                {
                    Globales.userObject = _gestorUsuarios.ObtenerCuentaPorUsername(_usuario.Nombre);

                    Globales.userName = _usuario.Nombre;
                    Globales.userType = _usuario.Tipo_usuario.Denominacion;

                    Principal main = new Principal();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesión, controle los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


               
            }
            else
            {
                MessageBox.Show("No se pudo iniciar sesión, controle los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void EstadoInicial()
        {
            primerinicio = true;
            BtnMostrarOcultar.Visible = false;
            BtnIngresar.Enabled = false;
            BtnIngresar.BackgroundImage = Image.FromFile(@"..\..\images\checkinDisable.png");
            TxtPassword.UseSystemPasswordChar = false;
            TxtPassword.ForeColor = Color.LightGray;
            TxtPassword.Text = "Contraseña";
            TxtUsuario.ForeColor = Color.LightGray;
            TxtUsuario.Text = "Usuario";
            TxtUsuario.SelectAll();
            TxtUsuario.Focus();
            TxtUsuario.TabIndex = 1;
            TxtPassword.TabIndex = 2;
            BtnIngresar.TabIndex = 3;
            BtnSalir.TabIndex = 4;
        }

        private void ValidarCamposCompletos()
        {
            if (TxtUsuario.Text!="" && TxtUsuario.Text!="Usuario"
                && TxtPassword.Text!="" && TxtPassword.Text!="Contraseña")
            {
                BtnIngresar.Enabled = true;
                BtnIngresar.BackgroundImage = Image.FromFile(@"..\..\images\checkinEnabled.png");
            }
            else
            {
                BtnIngresar.Enabled = false;
                BtnIngresar.BackgroundImage = Image.FromFile(@"..\..\images\checkinDisable.png");
            }
        }

    }
}
