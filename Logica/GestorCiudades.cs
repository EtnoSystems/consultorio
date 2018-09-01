using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entidades;

namespace Logica
{
    public class GestorCiudades
    {
        public List<CiudadDTO> ListarCiudades() //DEVUELVE UN LIST DE CIUDADES
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    var Query = (from n in dbContext.Ciudad
                                 select new CiudadDTO
                                 {
                                     Id = n.Id,
                                     Denominacion = n.Denominacion
                                 }).ToList();
                    return Query;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
