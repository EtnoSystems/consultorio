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
    public partial class CargarSevicio : Form
    {
        public CargarSevicio()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarSevicio_Load(object sender, EventArgs e)
        {
            estadoInicial();
        }

        void estadoInicial()
        {
            lblNombrePaciente.Text = "";
            chkOrden.Checked = false;
            lblCostoConsulta.Text = "";
            lblTotal.Text = "";
            lblReintegro.Text = "";
        }

        private void btnAsentarYCargarOtro_Click(object sender, EventArgs e)
        {
            if (cargarServicio())
            {
                MessageBox.Show("Se cargó correctamente el servicio", "Carga de servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estadoInicial();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hubo un error", "Carga de servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsentarServicio_Click(object sender, EventArgs e)
        {
            if (cargarServicio())
            {
                MessageBox.Show("Se cargó correctamente el servicio", "Carga de servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estadoInicial();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hubo un error", "Carga de servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool cargarServicio()
        {
            //Proceso de carga de servicio
            return true; //Si se pudo cargar
        }
    }
}
