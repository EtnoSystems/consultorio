//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Direccion
    {
        public Direccion()
        {
            this.Persona = new HashSet<Persona>();
        }
    
        public int Id { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public int Ciudad_Id { get; set; }
        public string Barrio { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
        public virtual ICollection<Persona> Persona { get; set; }
    }
}
