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
using BD;

namespace WindowsFormsApp1
{
    public partial class Filtros_busqueda : Form
    {
        public Filtros_busqueda()
        {
            InitializeComponent();
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Filtros_busqueda_Load(object sender, EventArgs e)
        {
            TxtNombre.Text = "Nombres";
            TxtApellido.Text = "Apellido";
            TxtDNI.Text = "DNI";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            List<Persona> resultado= GestorPersona.BuscarPersonas(TxtDNI.Text, TxtApellido.Text, TxtNombre.Text);

            if (resultado.Count !=0)
                MessageBox.Show(resultado[0].Direccion.Numero.ToString());
            else
                MessageBox.Show("No encontro nada");
        }
    }
}
