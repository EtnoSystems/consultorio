using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Entidades
{
    public class DireccionDTO
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public int Ciudad_id { get; set; }

        public virtual ICollection<Ciudad> Ciudad { get; set; }
        public virtual ICollection<Persona> Persona { get; set; }
    }
}
