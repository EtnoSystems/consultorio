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
    public partial class Medicos_Alta : Form
    {
        public Medicos_Alta()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Medicos_Alta_Load(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregarOtra_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtNombre.ForeColor = Color.Black;
        }

        private void TxtNombreEditar_Enter(object sender, EventArgs e)
        {
            TxtNombreEditar.Text = "";
            TxtNombreEditar.ForeColor = Color.Black;
        }

        private void TxtApellidoEditar_Enter(object sender, EventArgs e)
        {
            TxtApellidoEditar.Text = "";
            TxtApellidoEditar.ForeColor = Color.Black;
        }

        private void TxtDocumentoEditar_Enter(object sender, EventArgs e)
        {
            TxtDocumentoEditar.Text = "";
            TxtDocumentoEditar.ForeColor = Color.Black;
        }

        private void BtnBuscarOtro_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            TxtNombreEditar.Focus();
        }

        void EstadoInicial()
        {
            TxtNombreEditar.Text = "";
            TxtApellidoEditar.Text = "";
            TxtDocumentoEditar.Text = "";
            panel3.Enabled = false;
            TxtTelefonoEditar.Text = "";
            TxtCelularEditar.Text = "";
            TxtEMailEditar.Text = "";
            CmbCiudadEditar.Text = "Ciudad";
            TxtDireccionEditar.Text = "";
            TxtDireccionEditar.Text = "";
            TxtNumeroEditar.Text = "";
            TxtPîsoEditar.Text = "";
            TxtMatriculaEditar.Text = "";
            TxtValorConsultaEditar.Text = "";
            TxtPorcentajeEditar.Text = "";
            TxtNombreEditar.Focus();

            //Destildar todos los items del checkedListBox
            for (int i = 0; i < ChkLstEspecialidadesEditar.Items.Count; i++)
                ChkLstEspecialidadesEditar.SetItemChecked(i, false);
        }

    }
}
