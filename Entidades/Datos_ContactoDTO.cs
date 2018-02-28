using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Entidades
{
    public class Datos_ContactoDTO
    {
        public int Id { get; set; }
        public string Email_primario { get; set; }
        public decimal Tel_celular { get; set; }
        public string Tel_fijo { get; set; }
        public string Persona_id { get; set; }
       
        public virtual ICollection<Persona> Persona { get; set; }
    }
}
