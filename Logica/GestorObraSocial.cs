using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Entidades;

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

        public List<ObraSocialDTO> ListarObrasSociales()
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    var Query = (from n in dbContext.Obra_social
                                 select new ObraSocialDTO
                                 {
                                     Id = n.Id,
                                     Denominacion = n.Denominacion,
                                     Nombre_Largo = n.Nombre_largo,
                                     Plus = n.Plus,
                                     Direccion = n.Direccion,
                                     Observaciones = n.Observaciones,
                                     Activa = n.Activa,
                                     Telefono = n.Telefono,
                                 }).ToList();
                    return Query;
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

        public int AgregarObraSocial(string denominacion, string nombre, decimal plus, bool activa, string direccion, string telefono, string observacion)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    Obra_social obra_Social = new Obra_social();
                    obra_Social.Denominacion = denominacion;
                    obra_Social.Nombre_largo = nombre;
                    obra_Social.Plus = plus;
                    obra_Social.Activa = activa;
                    obra_Social.Observaciones = observacion;
                    obra_Social.Direccion = direccion;
                    obra_Social.Telefono = telefono;

                    dbContext.Obra_social.Add(obra_Social);
                    return (dbContext.SaveChanges());
                }
            }
            catch (Exception)
            {
                throw;
                //return 0;
            }
        }
    }
}
