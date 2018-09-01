using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entidades;

namespace Logica
{
    public class GestorTiposDeUsuarios
    {
        public static List<Tipo_usuarioDTO> ListarTiposUsuarios() //DEVUELVE UN LIST DE TIPOS DE USUARIOS
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    var Query = (from n in dbContext.Tipo_usuario
                                 select new Tipo_usuarioDTO
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

        public static Tipo_usuarioDTO ObtenerTipoUsuarioPorId(int id)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    return (from n in dbContext.Tipo_usuario
                                 where n.Id==id
                                 select new Tipo_usuarioDTO
                                 {
                                     Id = n.Id,
                                     Denominacion = n.Denominacion
                                 }).FirstOrDefault();
                    //return Query;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
