﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class consultoriosEntities : DbContext
    {
        public consultoriosEntities()
            : base("name=consultoriosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Auditoria> Auditoria { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Datos_contacto> Datos_contacto { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<Especialidad> Especialidad { get; set; }
        public DbSet<Feriado> Feriado { get; set; }
        public DbSet<Obra_social> Obra_social { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Tipo_usuario> Tipo_usuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}