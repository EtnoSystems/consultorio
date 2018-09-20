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
using Entidades;

namespace WindowsFormsApp1
{
    public partial class Filtros_busqueda : Form
    {
        List<PersonaDTO> resultadoBusqueda;
        PersonaDTO seleccionado;
        
        string dni = "";
        string nombre = "";
        string apellido = "";

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
            resultadoBusqueda = GestorPersona.BuscarPersonas(dni, apellido, nombre);

            if (resultadoBusqueda.Count > 0)
            {
                DgvResultadoBusqueda.DataSource = resultadoBusqueda;
                DgvResultadoBusqueda.Columns["Id"].Visible = false;
                DgvResultadoBusqueda.Columns["Direccion"].Visible = false;
                DgvResultadoBusqueda.Columns["Matricula"].Visible = false;
                DgvResultadoBusqueda.Columns["Fecha_nacimiento"].Visible = false;
                DgvResultadoBusqueda.Columns["Especialidad"].Visible = false;
                DgvResultadoBusqueda.Columns["Obra_social"].Visible = false;
                DgvResultadoBusqueda.Columns["Valor_consulta"].Visible = false;
                DgvResultadoBusqueda.Columns["Sexo"].Visible = false;
                DgvResultadoBusqueda.Columns["Direccion_id"].Visible = false;
                DgvResultadoBusqueda.Columns["Consulta"].Visible = false;
                DgvResultadoBusqueda.Columns["Consulta1"].Visible = false;
                DgvResultadoBusqueda.Columns["Porcentaje_retencion"].Visible = false;
                DgvResultadoBusqueda.Columns["Datos_contacto"].Visible = false;
                DgvResultadoBusqueda.Visible = true;

                DgvResultadoBusqueda.RowHeadersVisible = false;
                DgvResultadoBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DgvResultadoBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgvResultadoBusqueda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DgvResultadoBusqueda.BackgroundColor = SystemColors.ControlLightLight;

                DgvResultadoBusqueda.Columns[1].HeaderText = "DNI";
                DgvResultadoBusqueda.Columns[1].Width = 60;
                DgvResultadoBusqueda.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DgvResultadoBusqueda.Columns[2].HeaderText = "Nombre";
                DgvResultadoBusqueda.Columns[2].Width = 190;
                DgvResultadoBusqueda.Columns[3].HeaderText = "Apellido";
                DgvResultadoBusqueda.Columns[3].Width = 80;
                DgvResultadoBusqueda.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            else
                MessageBox.Show("No encontro nada");
        }
        
        //se hace click sobre el grid
        private void DgvResultadoBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        //se hace dobleclick sobre el grid
        private void DgvResultadoBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionado = resultadoBusqueda[DgvResultadoBusqueda.CurrentCell.RowIndex];
            MessageBox.Show(seleccionado.DNI.ToString());
            Medicos_Alta medicos = new Medicos_Alta();
            medicos.Show();
        }

        private void TxtDNI_Enter(object sender, EventArgs e)
        {
            TxtDNI.ForeColor = Color.Black;
            TxtDNI.Text = "";
        }

        private void TxtApellido_Enter(object sender, EventArgs e)
        {
            TxtApellido.ForeColor = Color.Black;
            TxtApellido.Text = "";
        }

        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            TxtNombre.ForeColor = Color.Black;
            TxtNombre.Text = "";
        }

        private void TxtDNI_Leave(object sender, EventArgs e)
        {
            if (TxtDNI.Text == "")
            {
                TxtDNI.Text = "DNI";
                TxtDNI.ForeColor = Color.Gray;
                dni = "";
            }
            else
            {
                dni = TxtDNI.Text;
            }
        }

        private void TxtApellido_Leave(object sender, EventArgs e)
        {
            if (TxtApellido.Text == "")
            {
                TxtApellido.Text = "APELLIDO";
                TxtApellido.ForeColor = Color.Gray;
                apellido = "";
            }
            else
            {
                apellido = TxtApellido.Text;
            }
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                TxtNombre.Text = "Nombre";
                TxtNombre.ForeColor = Color.Gray;
                nombre = "";
            } else
            {
                nombre = TxtNombre.Text;
            }
        }

        private void TxtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GestorPersona.EliminarPersona(seleccionado);
        }
    }
}
