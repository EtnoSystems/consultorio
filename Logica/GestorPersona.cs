using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using DAO;


namespace Logica
{
    public static class GestorPersona
    {
       public static List<Persona> BuscarPersonas(string dni,string apellido,string nombre)
        {
            return PersonaDAO.BuscarPorFiltros(dni, apellido, nombre);            
        }

        public static int AgregarPersona(string dni, string nombre, string apellido, string sexo, Nullable<int> direccionId, string matricula, Nullable<decimal> porcentaje,List<Nullable<int>> listID_OS)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    Persona persona = new Persona();

                    persona.DNI = dni;
                    persona.Nombre = nombre;
                    persona.Apellido = apellido;
                    persona.Sexo = sexo;
                    persona.Direccion_Id = direccionId;
                    persona.Matricula = matricula;
                    persona.Porcentaje_retencion = porcentaje;

                    foreach (Nullable<int> ID in listID_OS)
                    {

                        Obra_social OS = (from n in dbContext.Obra_social
                                          where n.Id == ID
                                          select n).FirstOrDefault();
                        persona.Obra_social.Add(OS);
                    }
                    
                    
                    dbContext.Persona.Add(persona);
                    dbContext.SaveChanges();
                    return persona.Id;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
