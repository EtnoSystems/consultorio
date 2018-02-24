using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Entidades
{
    public class PacienteDTO
    {
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public int Direccion_Id { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
        public virtual ICollection<Datos_contacto> Datos_Contacto { get; set; }
        public virtual ICollection<Direccion> Direccion { get; set; }
        public virtual ICollection<Obra_social> Obra_Social { get; set; }
    }
}
