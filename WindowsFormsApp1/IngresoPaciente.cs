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
        PacienteDTO paciente; //agregado

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
            paciente = GestorPacientes.BuscarPacientePorDNI(TxtBusqueda.ToString()); //agregado
            if (paciente != null)
            {
                if (MessageBox.Show("El DNI ingresado no existe, ¿desea cargar los datos?", "DNI no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Pacientes_Alta pacientes_Alta = new Pacientes_Alta();
                    Globales.dni = TxtBusqueda.ToString();
                    pacientes_Alta.Show();
                }
                else
                {
                    TxtBusqueda.Focus();
                }
            }
            else
            {
                MostrarDatosPaciente datos = new MostrarDatosPaciente();
                datos.Show();
            }
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
