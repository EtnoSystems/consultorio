using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;

namespace Entidades
{
    public class CiudadDTO
    {
        public int Id { get; set; }
        public string Denominacion { get; set; }

        public virtual ICollection<Direccion> Direccion { get; set; }
    }
}
