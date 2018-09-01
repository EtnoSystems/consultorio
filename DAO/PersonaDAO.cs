using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;

namespace DAO
{
    public static class PersonaDAO
    {
        public static List<Persona> BuscarPorFiltros (string dni, string apellido, string nombre)
        {
            List<Persona> resultado = new List<Persona>();
            List<Persona> resultadoDNI = new List<Persona>();
            List<Persona> resultadoAPELLIDO = new List<Persona>();
            List<Persona> resultadoNOMBRE = new List<Persona>();
            List<Persona> resultadoDniApellido = new List<Persona>();
            List<Persona> resultadoDniNombre = new List<Persona>();
            List<Persona> resultadoDniApellidoNombre = new List<Persona>();
            List<Persona> resultadoApellidoNombre = new List<Persona>();
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {

                    if (dni != "")
                    {
                        resultadoDNI = (from n in dbContext.Persona
                                        where n.DNI.Equals(dni)
                                        select n).ToList<Persona>();

                        if (resultadoDNI.Count > 0)
                        {
                            if (apellido != "")
                            {
                                resultadoDniApellido = (from n in resultadoDNI
                                                        where n.Apellido.Equals(apellido)
                                                        select n).ToList<Persona>();

                                if (resultadoDniApellido.Count > 0)
                                {
                                    if (nombre != "")
                                    {
                                        resultadoDniApellidoNombre = (from n in resultadoDniApellido
                                                                      where n.Nombre.Equals(nombre)
                                                                      select n).ToList<Persona>();
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
                                                          where n.Nombre.Equals(nombre)
                                                          select n).ToList<Persona>();

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
                                                 where n.Apellido.Equals(apellido)
                                                 select n).ToList<Persona>();

                            if (resultadoAPELLIDO.Count > 0)
                            {
                                if (nombre != "")
                                {
                                    resultadoApellidoNombre = (from n in resultadoAPELLIDO
                                                               where n.Nombre.Equals(nombre)
                                                               select n).ToList<Persona>();

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
                                                   where n.Nombre.Equals(nombre)
                                                   select n).ToList<Persona>();

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


    }    
    
}
