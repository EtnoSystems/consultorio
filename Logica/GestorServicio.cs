using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Entidades;

namespace Logica
{
    public class GestorServicio
    {
        public List<ListadoMedicosDTO> Filtro_Por_ObraSocial (Nullable<int> id_OS) //no contempla el caso de que id_OS sea null
        {
            List<ListadoMedicosDTO> listaResultados = new List<ListadoMedicosDTO>();
            
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {

                    var OS = (from n in dbContext.Obra_social
                                 where n.Id == id_OS
                                 select n).FirstOrDefault();

                    
                    foreach (Persona persona in OS.Persona)
                    {
                        if (persona.Matricula != null)
                        {
                            ListadoMedicosDTO medico = new ListadoMedicosDTO();
                            medico.Id = persona.Id;
                            medico.Apellido_y_Nombre = persona.Apellido + ", " + persona.Nombre;
                            listaResultados.Add(medico);
                        }
                    }

                    return listaResultados;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
