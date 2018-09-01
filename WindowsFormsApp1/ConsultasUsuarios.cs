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
    public partial class ConsultasUsuarios : Form
    {
        public ConsultasUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultasUsuarios_Load(object sender, EventArgs e)
        {
            GestorUsuarios _gestorUsuarios = new GestorUsuarios();
           // Tipo_usuarioDTO _tipoUsuarioDTO = _gestorUsuarios.ListarUsuariosAdministradores();
           // dataGridView1.DataSource = _tipoUsuarioDTO.Usuario.ToList();
           // MessageBox.Show(_tipoUsuarioDTO.Denominacion);
            
        }
    }
}
