using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Logica
{
    public class GestorObraSocial
    {
        public Obra_social ObtenerObraSocialPorID(int id)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {

                    return (from n in dbContext.Obra_social
                            where n.Id == id
                            select new Obra_social
                            {
                                Id = n.Id,
                                Denominacion = n.Denominacion,
                                Plus = n.Plus,
                                Telefono = n.Telefono,
                                Direccion = n.Direccion,
                                Observaciones = n.Observaciones,
                                Activa = n.Activa,
                                Nombre_largo = n.Nombre_largo
                            }).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EliminarObraSocialPorId(int id)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    Obra_social obra_Social = (from n in dbContext.Obra_social
                                               where n.Id == id
                                               select n).FirstOrDefault();
                    dbContext.Obra_social.Remove(obra_Social);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AgregarObraSocial(string denominacion, string nombre, float plus, bool activa, string direccion, string telefono, string observacion)
        {
            return 1;
        }
    }
}
