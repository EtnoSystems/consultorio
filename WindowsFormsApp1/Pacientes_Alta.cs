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

namespace WindowsFormsApp1
{
    public partial class Pacientes_Alta : Form
    {
        public Pacientes_Alta()
        {
            InitializeComponent();
        }

        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            TxtNombre.ForeColor = Color.Black;
            TxtNombre.Text = "";
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "" || TxtNombre.Text == "Nombre")
            {
                TxtNombre.ForeColor = Color.Silver;
                TxtNombre.Text = "Nombre";
            }
        }

        private void TxtApellido_Enter(object sender, EventArgs e)
        {
            TxtApellido.ForeColor = Color.Black;
            TxtApellido.Text = "";
        }

        private void TxtApellido_Leave(object sender, EventArgs e)
        {
            if (TxtApellido.Text == "" || TxtApellido.Text == "Apellido")
            {
                TxtApellido.ForeColor = Color.Silver;
                TxtApellido.Text = "Apellido";
            }
        }

        private void TxtDNI_Enter(object sender, EventArgs e)
        {
            TxtDNI.ForeColor = Color.Black;
            TxtDNI.Text = "";
        }

        private void TxtDNI_Leave(object sender, EventArgs e)
        {
            if (TxtDNI.Text == "" || TxtDNI.Text == "Documento")
            {
                TxtDNI.ForeColor = Color.Silver;
                TxtDNI.Text = "Documento";
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTelefono_Enter(object sender, EventArgs e)
        {
            TxtTelefono.ForeColor = Color.Black;
            TxtTelefono.Text = "";
        }

        private void TxtTelefono_Leave(object sender, EventArgs e)
        {
            if (TxtTelefono.Text == "" || TxtTelefono.Text == "Teléfono")
            {
                TxtTelefono.ForeColor = Color.Silver;
                TxtTelefono.Text = "Teléfono";
            }
        }

        private void TxtCelular_Enter(object sender, EventArgs e)
        {
            TxtCelular.ForeColor = Color.Black;
            TxtCelular.Text = "";
        }

        private void TxtCelular_Leave(object sender, EventArgs e)
        {
            if (TxtCelular.Text == "" || TxtCelular.Text == "Celular")
            {
                TxtCelular.ForeColor = Color.Silver;
                TxtCelular.Text = "Celular";
            }
        }

        private void TxtMail_Enter(object sender, EventArgs e)
        {
            TxtMail.ForeColor = Color.Black;
            TxtMail.Text = "";
        }

        private void TxtMail_Leave(object sender, EventArgs e)
        {
            if (TxtMail.Text == "" || TxtMail.Text == "E-mail")
            {
                TxtMail.ForeColor = Color.Silver;
                TxtMail.Text = "E-Mail";
            }
        }

        private void TxtDireccion_Enter(object sender, EventArgs e)
        {
            TxtDireccion.ForeColor = Color.Black;
            TxtDireccion.Text = "";
        }

        private void TxtDireccion_Leave(object sender, EventArgs e)
        {
            if (TxtDireccion.Text == "" || TxtDireccion.Text == "Dirección")
            {
                TxtDireccion.ForeColor = Color.Silver;
                TxtDireccion.Text = "Dirección";
            }
        }

        private void TxtDepto_Enter(object sender, EventArgs e)
        {
            TxtDepto.ForeColor = Color.Black;
            TxtDepto.Text = "";
        }

        private void TxtDepto_Leave(object sender, EventArgs e)
        {
            if (TxtDepto.Text == "" || TxtDepto.Text == "Depto")
            {
                TxtDepto.ForeColor = Color.Silver;
                TxtDepto.Text = "Depto";
            }
        }

        private void TxtPiso_Enter(object sender, EventArgs e)
        {
            TxtPiso.ForeColor = Color.Black;
            TxtPiso.Text = "";
        }

        private void TxtPiso_Leave(object sender, EventArgs e)
        {
            if (TxtPiso.Text == "" || TxtPiso.Text == "Piso")
            {
                TxtPiso.ForeColor = Color.Silver;
                TxtPiso.Text = "Piso";
            }
        }

        private void Pacientes_Alta_Load(object sender, EventArgs e)
        {

        }

        void EstadoInicial()
        {
            TxtNombre.Text = "Nombre";
            TxtNombre.ForeColor = Color.Silver;
            TxtApellido.Text = "Apellido";
            TxtApellido.ForeColor = Color.Silver;
            TxtDNI.Text = "Documento";
            TxtDNI.ForeColor = Color.Silver;
            TxtTelefono.Text = "Teléfono";
            TxtTelefono.ForeColor = Color.Silver;
            TxtCelular.Text = "Celular";
            TxtCelular.ForeColor = Color.Silver;
            TxtMail.Text = "E-Mail";
            TxtMail.ForeColor = Color.Silver;
            TxtDireccion.Text = "Dirección";
            TxtDireccion.ForeColor = Color.Silver;
            TxtDepto.Text = "Depto";
            TxtDepto.ForeColor = Color.Silver;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPaciente();
        }

        void AgregarPaciente()
        {
            GestorDireccion gestorDireccion = new GestorDireccion();
            int idDireccion = gestorDireccion.AgregarDireccion(TxtDireccion.Text, TxtNumero.Text, TxtPiso.Text, TxtDepto.Text, /*Convert.ToInt32(CmbCiudad.SelectedValue.ToString())*/1);
            
            //GestorObraSocial gestorObraSocial = new GestorObraSocial();
            //gestorObraSocial.ObtenerObraSocialPorID(Convert.ToInt32(Cmb);

            GestorPersona gestorPersona = new GestorPersona();
            int idPersona = gestorPersona.AgregarPersona(TxtDNI.Text, TxtNombre.Text, TxtApellido.Text, CmbSexo.SelectedItem.ToString(), idDireccion, "dbd", 0);

            GestorDatosContacto gestorDatosContacto = new GestorDatosContacto();
            gestorDatosContacto.AgregarDatosDeContacto(TxtMail.Text, TxtCelular.Text, TxtTelefono.Text, idPersona);
            
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregarOtra_Click(object sender, EventArgs e)
        {
            AgregarPaciente();
        }
    }
}
