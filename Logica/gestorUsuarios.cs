using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Entidades;

namespace Logica
{
    public class GestorUsuarios
    {
        /*
        public Tipo_usuarioDTO ListarUsuariosAdministradores() //DEVUELVE UN LIST DE USUARIOS
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    var admins = from n in dbContext.Tipo_usuario
                                 where n.Denominacion == "administrador"
                                 select n.Usuario;
                                            
                              

                }
            }
            catch (Exception)
            {
                throw;
            }
        }*/

        public static List<UsuarioDTO> ListarUsuarios() //DEVUELVE UN LIST DE USUARIOS
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    var Query = (from n in dbContext.Usuario
                                 select new UsuarioDTO
                                 {
                                     Id = n.Id,
                                     Nombre = n.Nombre,
                                     Password = n.Password,
                                     
                                 }).ToList();
                    return Query;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static UsuarioDTO ObtenerCuentaPorUsername(string username) //BUSCA UN USUARIO POR "USERNAME": SI LO ENCUENTRA DEVUELVE EL OBJETO. sINO DEVUELVE NULL
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    return (from n in dbContext.Usuario
                                   where n.Nombre == username
                                   select new UsuarioDTO
                                   {
                                       Id = n.Id,
                                       Nombre = n.Nombre,
                                       Password = n.Password,
                                       Tipo_usuario = n.Tipo_usuario,
                                       Tipo_usuario1_Id = n.Tipo_usuario_Id
                                       
                                   }).SingleOrDefault();
                
                    
                }
            }
            catch (Exception)
            {
                throw;
            }   
        }


        public static UsuarioDTO BuscarUsuarioPorUsername(string username) //FUNCION INICIAR SESION
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    return (from n in dbContext.Usuario
                            where n.Nombre == username   //n.Password == clave
                            select new UsuarioDTO
                            {
                                Id = n.Id,
                                Nombre = n.Nombre,
                                Password = n.Password,
                                Tipo_usuario1_Id = n.Tipo_usuario_Id,
                                Tipo_usuario=n.Tipo_usuario,
                            
                            }).SingleOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        

        /* public List<UsuarioDTO> ListarUsuariosAdministradores()
         {
            try
            {
                 using (consultoriosEntities dbContext = new consultoriosEntities())
                 {
                     //List<tipo_usuario> tipos_usuarios = dbContext.tipo_usuario;

                     var tipos = from item in dbContext.tipo_usuario
                                 where item.denominacion == "admin"
                                 select 

                 }
            }
            catch (Exception)
            {
                 throw;
            }


         }*/

        public static int AgregarUsuario (string nombreCompleto, string userName, string clave, Tipo_usuarioDTO tipo_UsuarioDTO)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    Usuario usuario = new Usuario();
                    usuario.Nombre_completo = nombreCompleto;
                    usuario.Nombre = userName;
                    usuario.Password = clave;
                    usuario.Tipo_usuario_Id = tipo_UsuarioDTO.Id;


                    //entidad.Tipo_usuario.Denominacion = tipo;
               
                    dbContext.Usuario.Add(usuario);
                    return(dbContext.SaveChanges());
                }
                    

            }
            catch (Exception)
            {
                throw;
            }
        }

        
        public static void ModificarUsuario (UsuarioDTO _Usuario)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    Usuario Entidad = (from n in dbContext.Usuario
                                       where n.Id == _Usuario.Id
                                       select n).FirstOrDefault();
                    Entidad.Nombre = _Usuario.Nombre;
                    Entidad.Password = _Usuario.Password;
                    Entidad.Tipo_usuario = _Usuario.Tipo_usuario;
                    dbContext.Entry(Entidad).CurrentValues.SetValues(Entidad);
                    dbContext.SaveChanges();
                }
                    
            }
            catch (Exception)
            {

            }
        }


        public static List<object> BuscarUsuarios(string NombreCompleto)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    var Query = (from n in dbContext.Usuario
                                 where n.Nombre_completo.Contains(NombreCompleto)
                                 select new
                                 {
                                     n.Id,
                                     n.Nombre,
                                     n.Nombre_completo,
                                     n.Tipo_usuario.Denominacion
                                     
                                 }).ToList<object>();
                    return Query;
                }
            }
            catch
            {
                throw;
            }
        }


        public static void EliminarUsuarioPorId (int id)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    Usuario Entidad = (from n in dbContext.Usuario
                                       where n.Id == id
                                       select n).FirstOrDefault();
                    dbContext.Usuario.Remove(Entidad);
                    dbContext.SaveChanges();
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }

       
    }

   
}
