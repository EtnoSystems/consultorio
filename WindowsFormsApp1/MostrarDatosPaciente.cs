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
    public partial class MostrarDatosPaciente : Form
    {
        public MostrarDatosPaciente()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Pacientes_Alta pacientesAlta = new Pacientes_Alta();
            //Cargar los datos en el formulario para editarlos
            pacientesAlta.Show();
        }
    }
}
