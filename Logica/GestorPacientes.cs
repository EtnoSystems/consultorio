using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using BD;

namespace Logica
{
    public static class GestorPacientes
    { 
        public static PacienteDTO BuscarPacientePorDNI(string DNI)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    return (from n in dbContext.Persona
                            where n.DNI == DNI
                            select new PacienteDTO
                            {
                                Id = n.Id,
                                DNI = n.DNI,
                                Sexo=n.Sexo,
                                Nombre =n.Nombre,
                                Apellido =n.Apellido,
                                Obra_Social=n.Obra_social
                            }).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int AgregarPaciente(string nombre, string apellido, string documento, string sexo, Obra_social obraSocial, Datos_contacto datos_contacto, Direccion direccion)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    Persona persona = new Persona();
                    persona.Nombre = nombre;
                    persona.Apellido = apellido;
                    persona.Sexo = sexo;
                    persona.DNI = documento;
                    persona.Obra_social.Add(obraSocial);
                    persona.Datos_contacto.Add(datos_contacto);
                    persona.Direccion_Id = direccion.Id;

                    dbContext.Persona.Add(persona);
                    return (dbContext.SaveChanges());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
       /* public List<PacienteDTO> ListarPacientes() FALTA AGREGAR EL PACIENTEDTO.CS A LA CAPA ENTIDADES
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    var Query = (from n in dbContext.Persona_paciente
                                 select new PacienteDTO
                                 {

                                 }).Tolist();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        */ 

    }
}
