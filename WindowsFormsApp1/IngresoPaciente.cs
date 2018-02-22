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

        }

        void Redireccionar(int dni, int codigo)
        {

        }

        private void IngresoPaciente_Load(object sender, EventArgs e)
        {
           // TxtBusqueda.Text = codigo;
        }

        
    }
}
