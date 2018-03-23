using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Entidades
{
    public class ObraSocialDTO
    {
        public int Id { get; set; }
        public string Denominacion { get; set; }
        public decimal Plus { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Observaciones { get; set; }
        public string Nombre_Largo { get; set; }
        public bool Activa { get; set; }
        public int Editor_Id { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Persona> Persona { get; set; }
    }
}
