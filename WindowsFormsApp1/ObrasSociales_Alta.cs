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
            CompletarCombos();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Funciones propias

        void CompletarCombos()
        {
            GestorObraSocial gestor = new GestorObraSocial();
            CmbObrasSociales.DataSource = gestor.ListarObrasSociales();
            CmbObrasSociales.DisplayMember = "Denominacion";
            CmbObrasSociales.ValueMember = "Id";

            CmbObrasSocialesModif.DataSource = gestor.ListarObrasSociales();
            CmbObrasSocialesModif.DisplayMember = "Denominacion";
            CmbObrasSocialesModif.ValueMember = "Id";
        }

        void CompletarCamposEdicion(int ide)
        {

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

        #endregion

        #region Formulario Agregar Obra Social

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
            if (ChkActiva.Checked == false)
            {
                if (MessageBox.Show("¿Está seguro que desea cargar la obra social como inactiva o interrumpida? - Si selecciona 'NO' se marcará automáticamente como activa y se guardará", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Guardar();
                }
                else
                {
                    ChkActiva.Checked = true;
                    Guardar();
                }
            }
            else
            {
                Guardar();
            }
        }

        private void TxtDenominacion_Enter_1(object sender, EventArgs e)
        {
            if (TxtDenominacion.Text == "Denominación")
            {
                TxtDenominacion.Text = "";
                TxtDenominacion.ForeColor = Color.Black;
            }
        }

        private void TxtDenominacion_Leave(object sender, EventArgs e)
        {
            if (TxtDenominacion.Text == "Denominación" || TxtDenominacion.Text == "")
            {
                TxtDenominacion.Text = "Denominación";
                TxtDenominacion.ForeColor = Color.Silver;
            }
            ValidarCamposCompletos();
        }

        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "Nombre")
            {
                TxtNombre.Text = "";
                TxtNombre.ForeColor = Color.Black;
            }
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "Nombre" || TxtNombre.Text == "")
            {
                TxtNombre.Text = "Nombre";
                TxtNombre.ForeColor = Color.Silver;
            }
            ValidarCamposCompletos();
        }

        private void TxtPlus_Enter(object sender, EventArgs e)
        {
            if (TxtPlus.Text == "Plus")
            {
                TxtPlus.Text = "";
                TxtPlus.ForeColor = Color.Black;
            }
        }

        private void TxtPlus_Leave(object sender, EventArgs e)
        {
            if (TxtPlus.Text == "")
            {
                TxtPlus.Text = "Plus";
                TxtPlus.ForeColor = Color.Silver;
            }
            ValidarCamposCompletos();
        }

        private void TxtPlus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtObservaciones_Enter(object sender, EventArgs e)
        {
            if (TxtObservaciones.Text == "Observaciones")
            {
                TxtObservaciones.Text = "";
                TxtObservaciones.ForeColor = Color.Black;
            }
        }

        private void TxtObservaciones_Leave(object sender, EventArgs e)
        {
            if (TxtObservaciones.Text == "" || TxtObservaciones.Text == "Observaciones")
            {
                TxtObservaciones.Text = "Observaciones";
                TxtObservaciones.ForeColor = Color.Silver;
            }
        }

        private void TxtDireccion_Enter_1(object sender, EventArgs e)
        {
            if (TxtDireccion.Text == "Dirección")
            {
                TxtDireccion.Text = "";
                TxtDireccion.ForeColor = Color.Black;
            }
        }

        private void TxtDireccion_Leave(object sender, EventArgs e)
        {
            if (TxtDireccion.Text == "Dirección" || TxtDireccion.Text == "")
            {
                TxtDireccion.Text = "Dirección";
                TxtDireccion.ForeColor = Color.Silver;
            }
        }

        private void TxtTelefono_Enter_1(object sender, EventArgs e)
        {
            if (TxtTelefono.Text == "Teléfono")
            {
                TxtTelefono.Text = "";
                TxtTelefono.ForeColor = Color.Black;
            }
        }

        private void TxtTelefono_Leave(object sender, EventArgs e)
        {
            if (TxtTelefono.Text == "Teléfono" || TxtTelefono.Text == "")
            {
                TxtTelefono.Text = "Teléfono";
                TxtTelefono.ForeColor = Color.Silver;
            }
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            //Verificar que no existe la denominacion que se esta por cargar
            if (MessageBox.Show("Esta seguro que desea guardar la obra social " + TxtDenominacion.Text + " ?", "Cargar una nueva obra social", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Guardar();
            }

        }

        private void CmbObrasSociales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Funciones de guardado

        void Guardar()
        {
            if (GuardarDatos() == 1)
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

        int GuardarDatos()
        {
            decimal decimalVal = 0;
            GestorObraSocial gestorObraSocial = new GestorObraSocial();
            decimalVal = Convert.ToDecimal(TxtPlus.Text);
            if (gestorObraSocial.AgregarObraSocial(TxtDenominacion.Text, TxtNombre.Text, decimalVal, ChkActiva.Checked, TxtDireccion.Text, TxtTelefono.Text, TxtObservaciones.Text) == 1)
            {
                return 1;
            }
            else return 0;
        }

        #endregion

        #region Menú Editar o Modificar Obra Social

        private void TxtNombreModif_Enter(object sender, EventArgs e)
        {
            if (TxtNombreModif.Text == "Nombre")
            {
                TxtNombreModif.Text = "";
                TxtNombreModif.ForeColor = Color.Black;
            }
        }

        private void TxtNombreModif_Leave(object sender, EventArgs e)
        {
            if (TxtNombreModif.Text == "" || TxtNombreModif.Text == "Nombre")
            {
                TxtNombreModif.Text = "Nombre";
                TxtNombreModif.ForeColor = Color.Silver;
            }
        }

        private void TxtPlusModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtPlusModif_Enter(object sender, EventArgs e)
        {
            if (TxtPlusModif.Text == "Plus")
            {
                TxtPlusModif.Text = "";
                TxtPlusModif.ForeColor = Color.Black;
            }
        }

        private void TxtPlusModif_Leave(object sender, EventArgs e)
        {
            if (TxtPlusModif.Text == "")
            {
                TxtPlusModif.Text = "Plus";
                TxtPlusModif.ForeColor = Color.Silver;
            }
        }

        private void TxtObservacionesModif_Enter(object sender, EventArgs e)
        {
            if (TxtObservacionesModif.Text == "Observaciones")
            {
                TxtObservacionesModif.Text = "";
                TxtObservacionesModif.ForeColor = Color.Black;
            }
        }

        private void TxtObservacionesModif_Leave(object sender, EventArgs e)
        {
            if (TxtObservacionesModif.Text == "" || TxtObservacionesModif.Text == "Observaciones")
            {
                TxtObservacionesModif.Text = "Observaciones";
                TxtObservacionesModif.ForeColor = Color.Silver;
            }
        }

        private void TxtDireccionModif_Enter(object sender, EventArgs e)
        {
            if (TxtDireccionModif.Text == "Dirección")
            {
                TxtDireccionModif.Text = "";
                TxtDireccionModif.ForeColor = Color.Black;
            }
        }

        private void TxtDireccionModif_Leave(object sender, EventArgs e)
        {
            if (TxtDireccionModif.Text == "" || TxtDireccionModif.Text == "Dirección")
            {
                TxtDireccionModif.Text = "Dirección";
                TxtDireccionModif.ForeColor = Color.Silver;
            }
        }

        private void TxtTelefonoModif_Enter(object sender, EventArgs e)
        {
            if (TxtTelefonoModif.Text == "Teléfono")
            {
                TxtTelefonoModif.Text = "";
                TxtTelefonoModif.ForeColor = Color.Black;
            }
        }

        private void TxtTelefonoModif_Leave(object sender, EventArgs e)
        {
            if (TxtTelefonoModif.Text == "" || TxtTelefonoModif.Text == "Teléfono")
            {
                TxtTelefonoModif.Text = "Teléfono";
                TxtTelefonoModif.ForeColor = Color.Silver;
            }
        }

        private void CmbObrasSocialesModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            //indice = CmbObrasSocialesModif.SelectedValue;
            //MessageBox.Show(obraSocialNombre);
        }

        #endregion

        #region Formulario Eliminar obras sociales

        #endregion

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
