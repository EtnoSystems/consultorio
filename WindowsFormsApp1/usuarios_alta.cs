﻿using System;
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
        bool primerinicio = true;

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
            
        }
        #endregion

#region Password 1
        private void TxtPassword1_Enter(object sender, EventArgs e)
        {
            
            TxtPassword1.ForeColor = Color.Black;
            if(TxtPassword1.Text=="Contraseña")
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
                HabilitarBotones();
            }
        }
        #endregion

#region Password 2
        private void TxtPassword2_Leave(object sender, EventArgs e)
        {
            HabilitarBotones();
        }

        private void TxtPassword2_Enter(object sender, EventArgs e)
        {
            TxtPassword2.ForeColor = Color.Black;
            if(TxtPassword2.Text=="Repita la contraseña")
                TxtPassword2.Text = "";
        }

        private void TxtPassword2_TextChanged(object sender, EventArgs e)
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

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_Validating(object sender, CancelEventArgs e)
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

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            HabilitarBotones();
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
                txtUsuario.Text = "";
        }
        #endregion

#region txtNombre
        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            HabilitarBotones();
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
            }
            else
            {
               // txtNombre.ForeColor = Color.Black;
                //txtNombre.Text = "";
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
            AgregarUsuario(txtNombre.Text, txtUsuario.Text,TxtPassword1.Text,Convert.ToInt32(CmbTipo.SelectedValue.ToString()));
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
            AgregarUsuario(txtNombre.Text, txtUsuario.Text, TxtPassword1.Text, Convert.ToInt32(CmbTipo.SelectedValue.ToString()));
            EstadoInicial();
        }

        private void CmbTipo_DropDownClosed(object sender, EventArgs e)
        {
           HabilitarBotones();
          // MessageBox.Show(CmbTipo.SelectedValue.ToString());
        }

#region Funciones

        void HabilitarBotones()
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

        void AgregarUsuario(string nombreCompleto, string username, string clave, int id)
        {
            GestorTiposDeUsuarios gestorTiposDeUsuarios = new GestorTiposDeUsuarios();
            gestorTiposDeUsuarios.ObtenerTipoUsuarioPorId(Convert.ToInt32(CmbTipo.SelectedValue.ToString()));
            
            //PRIMERO DEBO CREAR UN OBJETO TIPO_USUARIO BUSCANDOLO POR ID EN LA BASE DE DATOS
            Tipo_usuarioDTO tipo_UsuarioDTO = gestorTiposDeUsuarios.ObtenerTipoUsuarioPorId(id);

            GestorUsuarios gestorUsuarios = new GestorUsuarios();

            if (gestorUsuarios.AgregarUsuario(nombreCompleto, username, clave, tipo_UsuarioDTO) > 0)
                MessageBox.Show("El usuario ha sido agregado correctamente");
            else
                MessageBox.Show("El usuario no pudo ser guardado");
            //MessageBox.Show("El usuario obtenido " + tipo_UsuarioDTO.Id.ToString() + " " + tipo_UsuarioDTO.Denominacion);
        }
#endregion

       void EstadoInicial()
        {
            btnGuardar.Enabled = false;
            btnGuardarAgregar.Enabled = false;
            txtNombre.ForeColor = Color.Silver;
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
    }
}
