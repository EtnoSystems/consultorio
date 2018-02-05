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
    
    public partial class Consulta
    {
        public int Id { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Medico_Id { get; set; }
        public int Paciente_Id { get; set; }
        public decimal Plus { get; set; }
        public decimal Retencion_medico { get; set; }
        public decimal Reintegro_por_orden { get; set; }
        public bool Orden_presentada { get; set; }
        public Nullable<int> Obra_social_Id { get; set; }
        public int Editor_Id { get; set; }
        public int Persona_Id { get; set; }
    
        public virtual Obra_social Obra_social { get; set; }
        public virtual Persona_medico Persona_medico { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
