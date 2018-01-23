using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Entidades
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public int Tipo_usuario1_Id { get; set; }
        public string Nombre_completo { get; set; }

        public virtual Tipo_usuario Tipo_usuario { get; set; }
    }
}
