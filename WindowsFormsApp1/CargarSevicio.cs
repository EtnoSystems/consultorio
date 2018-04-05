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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace WindowsFormsApp1
{
    public partial class CargarSevicio : Form
    {
        public CargarSevicio()
        {
            InitializeComponent();
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarSevicio_Load(object sender, EventArgs e)
        {
            EstadoInicial();



        }

        void EstadoInicial()
        {
            LblNombrePaciente.Text = "";
            ChkOrden.Checked = false;
            LblCostoConsulta.Text = "";
            LblTotal.Text = "";
            LblReintegro.Text = "";
        }

        private void BtnAsentarServicio_Click(object sender, EventArgs e)
        {
            if (CargarServicio())
            {
                MessageBox.Show("Se cargó correctamente el servicio", "Carga de servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EstadoInicial();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Hubo un error", "Carga de servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool CargarServicio()
        {
            //Proceso de carga de servicio
            return true; //Si se pudo cargar
        }
    }
}
