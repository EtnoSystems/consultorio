using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;

namespace Entidades
{
    public class PersonaDTO_ResultadoBusqueda
    {
        public PersonaDTO_ResultadoBusqueda()
        {
            this.Consulta = new HashSet<Consulta>();
            this.Consulta1 = new HashSet<Consulta>();
            this.Datos_contacto = new HashSet<Datos_contacto>();
            this.Especialidad = new HashSet<Especialidad>();
            this.Obra_social = new HashSet<Obra_social>();
        }

        public int Id { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public Nullable<int> Direccion_Id { get; set; }
        public string Matricula { get; set; }
        public Nullable<decimal> Valor_consulta { get; set; }
        public Nullable<decimal> Porcentaje_retencion { get; set; }
        public Nullable<System.DateTime> Fecha_nacimiento { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
        public virtual ICollection<Consulta> Consulta1 { get; set; }
        public virtual ICollection<Datos_contacto> Datos_contacto { get; set; }
        public virtual Direccion Direccion { get; set; }
        public virtual ICollection<Especialidad> Especialidad { get; set; }
        public virtual ICollection<Obra_social> Obra_social { get; set; }
    }
}
