using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entidades;

namespace DAO
{
    public static class PersonaDAO
    {
        public static List<PersonaDTO> BuscarPorFiltros (string dni, string apellido, string nombre)
        {
            List<PersonaDTO> resultado = new List<PersonaDTO>();
            List<PersonaDTO> resultadoDNI = new List<PersonaDTO>();
            List<PersonaDTO> resultadoAPELLIDO = new List<PersonaDTO>();
            List<PersonaDTO> resultadoNOMBRE = new List<PersonaDTO>();
            List<PersonaDTO> resultadoDniApellido = new List<PersonaDTO>();
            List<PersonaDTO> resultadoDniNombre = new List<PersonaDTO>();
            List<PersonaDTO> resultadoDniApellidoNombre = new List<PersonaDTO>();
            List<PersonaDTO> resultadoApellidoNombre = new List<PersonaDTO>();
            //PersonaDTO_ResultadoBusqueda persona = new PersonaDTO_ResultadoBusqueda();
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {

                    if (dni != "")
                    {
                       resultadoDNI = (from n in dbContext.Persona
                                        where n.DNI.Equals(dni)
                                        select new PersonaDTO
                                        {
                                            Id = n.Id,
                                            DNI = n.DNI,
                                            Nombre = n.Nombre,
                                            Apellido = n.Apellido,
                                            Sexo = n.Sexo,
                                            Direccion_Id = n.Direccion_Id,
                                            Matricula = n.Matricula,
                                            Valor_consulta = n.Valor_consulta,
                                            Porcentaje_retencion = n.Porcentaje_retencion,
                                            Fecha_nacimiento = n.Fecha_nacimiento,
                                            Consulta = n.Consulta,
                                            Consulta1 = n.Consulta1,
                                            Datos_contacto = n.Datos_contacto,
                                            Direccion = n.Direccion,
                                            Especialidad = n.Especialidad,
                                            Obra_social = n.Obra_social
                                        }).ToList();
                        if (resultadoDNI.Count > 0)
                        {
                            if (apellido != "")
                            {
                                resultadoDniApellido = (from n in resultadoDNI
                                                        where n.Apellido.Contains(apellido)
                                                        select new PersonaDTO
                                                        {
                                                            Id = n.Id,
                                                            DNI = n.DNI,
                                                            Nombre = n.Nombre,
                                                            Apellido = n.Apellido,
                                                            Sexo = n.Sexo,
                                                            Direccion_Id = n.Direccion_Id,
                                                            Matricula = n.Matricula,
                                                            Valor_consulta = n.Valor_consulta,
                                                            Porcentaje_retencion = n.Porcentaje_retencion,
                                                            Fecha_nacimiento = n.Fecha_nacimiento,
                                                            Consulta = n.Consulta,
                                                            Consulta1 = n.Consulta1,
                                                            Datos_contacto = n.Datos_contacto,
                                                            Direccion = n.Direccion,
                                                            Especialidad = n.Especialidad,
                                                            Obra_social = n.Obra_social
                                                        }).ToList();

                                if (resultadoDniApellido.Count > 0)
                                {
                                    if (nombre != "")
                                    {
                                        resultadoDniApellidoNombre = (from n in resultadoDniApellido
                                                                      where n.Nombre.Contains(nombre)
                                                                      select n).ToList<PersonaDTO>();
                                        if (resultadoDniApellidoNombre.Count>0)
                                        {
                                            return resultadoDniApellidoNombre;
                                        }
                                        else
                                        {
                                            return resultado;
                                        }
                                    }
                                    else
                                    {
                                        return resultadoDniApellido;
                                    }
                                }
                                else
                                {
                                    return resultado;
                                }
                            }
                            else
                            {
                                if (nombre != "")
                                {
                                    resultadoDniNombre = (from n in resultadoDNI
                                                          where n.Nombre.Contains(nombre)
                                                          select n).ToList<PersonaDTO>();

                                    if (resultadoDniNombre.Count > 0)
                                    {
                                        return resultadoDniNombre;
                                    }
                                    else
                                    {
                                        return resultado;
                                    }
                                }
                                else
                                {
                                    return resultadoDNI;
                                }
                            }
                        }
                        else
                        {
                            return resultado;
                        }
                    }
                    else
                    {
                        if (apellido != "")
                        {
                            resultadoAPELLIDO = (from n in dbContext.Persona
                                                 where n.Apellido.Contains(apellido)
                                                 select new PersonaDTO
                                                 {
                                                     Id = n.Id,
                                                     DNI = n.DNI,
                                                     Nombre = n.Nombre,
                                                     Apellido = n.Apellido,
                                                     Sexo = n.Sexo,
                                                     Direccion_Id = n.Direccion_Id,
                                                     Matricula = n.Matricula,
                                                     Valor_consulta = n.Valor_consulta,
                                                     Porcentaje_retencion = n.Porcentaje_retencion,
                                                     Fecha_nacimiento = n.Fecha_nacimiento,
                                                     Consulta = n.Consulta,
                                                     Consulta1 = n.Consulta1,
                                                     Datos_contacto = n.Datos_contacto,
                                                     Direccion = n.Direccion,
                                                     Especialidad = n.Especialidad,
                                                     Obra_social = n.Obra_social
                                                 }).ToList();

                            if (resultadoAPELLIDO.Count > 0)
                            {
                                if (nombre != "")
                                {
                                    resultadoApellidoNombre = (from n in resultadoAPELLIDO
                                                               where n.Nombre.Contains(nombre)
                                                               select n).ToList<PersonaDTO>();

                                    if (resultadoApellidoNombre.Count > 0)
                                    {
                                        return resultadoApellidoNombre;
                                    }
                                    else
                                    {
                                        return resultado;
                                    }
                                }
                                else
                                {
                                    return resultadoAPELLIDO;
                                }
                            }
                            else
                            {
                                return resultado;
                            }
                        }
                        else
                        {
                            if (nombre != "")
                            {
                                resultadoNOMBRE = (from n in dbContext.Persona
                                                   where n.Nombre.Contains(nombre)
                                                   select new PersonaDTO
                                                   {
                                                       Id = n.Id,
                                                       DNI = n.DNI,
                                                       Nombre = n.Nombre,
                                                       Apellido = n.Apellido,
                                                       Sexo = n.Sexo,
                                                       Direccion_Id = n.Direccion_Id,
                                                       Matricula = n.Matricula,
                                                       Valor_consulta = n.Valor_consulta,
                                                       Porcentaje_retencion = n.Porcentaje_retencion,
                                                       Fecha_nacimiento = n.Fecha_nacimiento,
                                                       Consulta = n.Consulta,
                                                       Consulta1 = n.Consulta1,
                                                       Datos_contacto = n.Datos_contacto,
                                                       Direccion = n.Direccion,
                                                       Especialidad = n.Especialidad,
                                                       Obra_social = n.Obra_social
                                                   }).ToList();

                                if (resultadoNOMBRE.Count > 0)
                                {
                                    return resultadoNOMBRE;
                                }
                                else
                                {
                                    return resultado;
                                }
                            }
                            else
                            {
                                return resultado;
                            }
                        }
                    }



                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }


        public static void EliminarPersona (PersonaDTO unSeleccionado)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    var query = (from n in dbContext.Persona
                                 where n.Id == unSeleccionado.Id
                                 select n).Single();

                    dbContext.Persona.Remove(query);
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
