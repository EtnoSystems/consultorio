using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Logica
{
    public class GestorPersona
    {
        public int AgregarPersona(string dni, string nombre, string apellido, string sexo, Nullable<int> direccionId, string matricula, Nullable<decimal> porcentaje,int id_OS)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    Obra_social OS = (from n in dbContext.Obra_social
                                       where n.Id == id_OS
                                       select n).FirstOrDefault();



                    Persona persona = new Persona();

                    persona.DNI = dni;
                    persona.Nombre = nombre;
                    persona.Apellido = apellido;
                    persona.Sexo = sexo;
                    persona.Direccion_Id = direccionId;
                    persona.Matricula = matricula;
                    persona.Porcentaje_retencion = porcentaje;
                    persona.Obra_social.Add(OS);
                    
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
