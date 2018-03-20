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

namespace WindowsFormsApp1
{
    public partial class ObrasSociales_alta : Form
    {
        public ObrasSociales_alta()
        {
            InitializeComponent();
        }

        private void ObrasSociales_alta_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void EstadoInicial()
        {
            #region Agregar Obra Social
            TxtDenominacion.Text = "Denominación";
            TxtDenominacion.ForeColor = Color.Silver;

            TxtNombre.Text = "Nombre";
            TxtNombre.ForeColor = Color.Silver;

            TxtDireccion.Text = "Dirección";
            TxtDireccion.ForeColor = Color.Silver;

            TxtPlus.Text = "Plus";
            TxtPlus.ForeColor = Color.Silver;

            TxtObservaciones.Text = "Observaciones";
            TxtObservaciones.ForeColor = Color.Silver;

            TxtTelefono.Text = "Teléfono";
            TxtTelefono.ForeColor = Color.Silver;

            ChkActiva.Checked = true;
            #endregion

            #region Modificar Obra Social
            TxtDireccionModif.Text = "Denominación";
            TxtDireccionModif.ForeColor = Color.Silver;

            TxtNombreModif.Text = "Nombre";
            TxtNombreModif.ForeColor = Color.Silver;

            TxtPlusModif.Text = "Plus";
            TxtPlusModif.ForeColor = Color.Silver;

            TxtObservacionesModif.Text = "Observaciones";
            TxtObservacionesModif.ForeColor = Color.Silver;

            TxtTelefonoModif.Text = "Teléfono";
            TxtTelefonoModif.ForeColor = Color.Silver;

            ChkActivaModif.Checked = false;
            #endregion

            #region Eliminar Obra Social
            LblNombre.Text = "-";
            LblDireccion.Text = "-";
            LblObservaciones.Text = "-";
            LblPlus.Text = "-";
            LblTelefono.Text = "-";
            ChkActivaEliminar.Checked = false;
            #endregion
        }

        void ValidarCamposCompletos()
        {
            if (TxtDenominacion.Text != "" && TxtDenominacion.Text != "Denominación"
                && TxtPlus.Text != "" && TxtPlus.Text != "Plus")
            {
                BtnAgregar.Enabled = true;
                BtnAgregarOtra.Enabled = true;
                BtnAgregar.BackgroundImage = Image.FromFile(@"..\..\images\botonGuardarHabilitado.png");
                BtnAgregarOtra.BackgroundImage = Image.FromFile(@"..\..\images\botonGuardarAgregarHabilitado.png");
            }
            else
            {
                BtnAgregar.Enabled = false;
                BtnAgregarOtra.Enabled = false;
                BtnAgregar.BackgroundImage = Image.FromFile(@"..\..\images\botonGuardarDeshabilitado.png");
                BtnAgregarOtra.BackgroundImage = Image.FromFile(@"..\..\images\botonGuardarAgregarDeshabilitado.png");
            }
        }

        private void TxtDenominacion_Enter(object sender, EventArgs e)
        {
            TxtDenominacion.Text = "";
            TxtDenominacion.ForeColor = Color.Black;
        }

        private void TxtPlus_TextChanged(object sender, EventArgs e)
        {
            TxtPlus.Text = "";
            TxtPlus.ForeColor = Color.Black;
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDireccion_Enter(object sender, EventArgs e)
        {
            TxtDireccion.Text = "";
            TxtDireccion.ForeColor = Color.Black;
        }

        private void TxtTelefono_Enter(object sender, EventArgs e)
        {
            TxtTelefono.Text = "";
            TxtTelefono.ForeColor = Color.Black;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (GuardarDatos())
            {
                MessageBox.Show("La obra social " + TxtDenominacion.Text + " se guardó correctamente", "Datos guardados exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EstadoInicial();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un error en el guardado de los datos", "No se pudo guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        bool GuardarDatos()
        {
            //Guarda los datos
            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
