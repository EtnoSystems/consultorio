using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Logica
{
    public class GestorDireccion
    {
        public Nullable<int> AgregarDireccion(string calle, string numero, string piso, string depto, int ciudadId)
        {
            try
            {
                if (calle == "" && numero == "" && piso == "" && depto == "")
                {
                    return null;
                }

                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    Direccion direccion = new Direccion();
                    direccion.Calle = calle;
                    direccion.Numero = numero;
                    direccion.Piso = piso;
                    direccion.Departamento = depto;
                    direccion.Ciudad_Id = ciudadId;

                    dbContext.Direccion.Add(direccion);
                    dbContext.SaveChanges();
                    return direccion.Id;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
