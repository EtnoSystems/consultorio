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
            // recibe un id de obra social y devuelve todos los médicos que atienden con ella
            // si el id es nulo, entonces devuelve todos los medicos.
            List<ListadoMedicosDTO> listaResultados = new List<ListadoMedicosDTO>();

            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    if (id_OS != null)
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

                    else
                    {
                        var Medicos = (from n in dbContext.Persona
                                       where n.Matricula != null
                                       select new ListadoMedicosDTO
                                       {
                                           Id = n.Id,
                                           Apellido_y_Nombre = n.Apellido + ", " + n.Nombre
                                       }).ToList();
                        return Medicos;


                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
