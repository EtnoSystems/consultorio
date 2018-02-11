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
    public partial class ReportesAdministrativos : Form
    {
        public ReportesAdministrativos()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkFiltro.Checked)
            {
                RdEmpleado.Enabled = false;
                RdObraSocial.Enabled = false;
                RdProfesional.Enabled = false;
                RdPaciente.Enabled = false;
                CmbFiltro.Enabled = true;
                CmbSegundoFiltro.Enabled = true;
                ChequearFiltro();
            }
            else
            {
                RdEmpleado.Enabled = true;
                RdObraSocial.Enabled = true;
                RdProfesional.Enabled = true;
                RdPaciente.Enabled = true;
                CmbFiltro.Enabled = false;
                CmbSegundoFiltro.Enabled = false;
            }
        }

        void ChequearFiltro()
        {
            CmbFiltro.Items.Clear();

            if (RdEmpleado.Checked)
            {
                CmbFiltro.Items.Add("Obra social");
                CmbFiltro.Items.Add("Paciente");
                CmbFiltro.Items.Add("Profesional");
            }
            else if (RdObraSocial.Checked)
            {
                CmbFiltro.Items.Add("Empleado");
                CmbFiltro.Items.Add("Paciente");
                CmbFiltro.Items.Add("Profesional");
            }
            else if (RdProfesional.Checked)
            {
                CmbFiltro.Items.Add("Empleado");
                CmbFiltro.Items.Add("Paciente");
                CmbFiltro.Items.Add("Obra Social");
            }
            else if (RdPaciente.Checked)
            {
                CmbFiltro.Items.Add("Empleado");
                CmbFiltro.Items.Add("Profesional");
                CmbFiltro.Items.Add("Obra Social");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportesAdministrativos_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        void EstadoInicial()
        {
            RdEmpleado.Enabled = true;
            RdObraSocial.Enabled = true;
            RdObraSocial.Checked = true;
            RdPaciente.Enabled = true;
            RdProfesional.Enabled = true;
            ChkFiltro.Checked = false;
            CmbFiltro.Enabled = false;
            CmbSegundoFiltro.Enabled = false;
            BtnConsultar.Enabled = false;
        }
    }
}
