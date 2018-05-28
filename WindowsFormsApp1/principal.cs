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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //consultaUsuarios consultaUsuarios = new consultaUsuarios();
            //consultaUsuarios.Show();    
            Usuarios_alta usuariosAlta = new Usuarios_alta();
            usuariosAlta.Show();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login _login = new Login();
            _login.Show();
        }

        private void PrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (Globales.userType == "administrador")
            {
                mnuReportes.Visible = true;
                mnuPersonal.Visible = true;
                MnuAgregarFeriados.Visible = true;
                MnuBarCode.Visible = true;
            }
            else
            {
                mnuReportes.Visible = false;
                mnuPersonal.Visible = false;
                MnuAgregarFeriados.Visible = false;
                MnuBarCode.Visible = false;
            }
            this.Text = "Gestión de obras sociales - USUARIO " + Globales.userObject.Nombre + " " + Globales.userType;
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del programa?", "Cerrar sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cambiar de usuario?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                Globales.userName = "";
                Globales.userType = "";
                login.Show();
                this.Hide();
            }
        }

        private void MnuAgregarPersonal_Click(object sender, EventArgs e)
        {
            Usuarios_alta altas = new Usuarios_alta();
            altas.Show();
        }

        private void MnuEliminarPersonal_Click(object sender, EventArgs e)
        {
            Usuarios_baja bajas = new Usuarios_baja();
            bajas.Show();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MnuServicio_Click(object sender, EventArgs e)
        {
            IngresoPaciente ingreso = new IngresoPaciente("Consulta");
            ingreso.Show();
            Globales.codigoFormulario = 1; //Codigo para luego reenviar al formulario de carga de servicio
        }

        private void mnuAgregarObraSocial_Click(object sender, EventArgs e)
        {
            ObrasSociales_alta osa = new ObrasSociales_alta();
            osa.Show();
        }

        private void mnuAgregarMedico_Click(object sender, EventArgs e)
        {
            Medicos_Alta medAlta = new Medicos_Alta();
            medAlta.Show();
        }

        private void MnuRecetarios_Click(object sender, EventArgs e)
        {
            IngresoPaciente pacientes = new IngresoPaciente();
            pacientes.Show();
            Globales.codigoFormulario = 2;
        }

        private void mnuReportes_Click(object sender, EventArgs e)
        {
            ReportesAdministrativos reportes = new ReportesAdministrativos();
            reportes.Show();
        }

        private void MnuAgregarFeriados_Click(object sender, EventArgs e)
        {
            CargarFeriados feriados = new CargarFeriados();
            feriados.Show();
        }

        private void mnuAgregarPaciente_Click(object sender, EventArgs e)
        {
            Pacientes_Alta pacientesAlta = new Pacientes_Alta();
            pacientesAlta.Show();
        }

        private void MnuObrasSociales_Click(object sender, EventArgs e)
        {
            ObrasSociales_alta _ObrasSociales = new ObrasSociales_alta();
            _ObrasSociales.Show();
        }
    }
}
