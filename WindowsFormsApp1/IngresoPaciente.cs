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
using Entidades;

namespace WindowsFormsApp1
{
    public partial class IngresoPaciente : Form
    {

        private string codigo = "";

        public IngresoPaciente()
        {
            InitializeComponent();
        }

        public IngresoPaciente(string cod) : this()
        {
            this.codigo = cod;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscarPaciente_Click(object sender, EventArgs e)
        {
            CargarSevicio servicio = new CargarSevicio();
            servicio.Show(); 

            //GestorPacientes gestorPacientes = new GestorPacientes();
            //PacienteDTO paciente = gestorPacientes.BuscarPacientePorDNI(TxtBusqueda.Text);

            //if (paciente!=null)
            //{
            //    CargarSevicio servicio = new CargarSevicio();
            //    servicio.paciente = paciente;
            //    servicio.Show();
            //    this.Hide();

            //    //MessageBox.Show("encontre algo papee");
            //}
            //else
            //{
            //    MessageBox.Show("no encontre nada papee");
            //}
        }

        void Redireccionar(int dni, int codigo)
        {

        }

        private void IngresoPaciente_Load(object sender, EventArgs e)
        {
           // TxtBusqueda.Text = codigo;
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
