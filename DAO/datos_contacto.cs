//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Datos_contacto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Tel_celular { get; set; }
        public string Tel_fijo { get; set; }
        public int Persona_Id { get; set; }
    
        public virtual Persona Persona { get; set; }
    }
}
