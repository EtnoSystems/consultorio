using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Logica
{
    public class GestorDatosContacto
    {
        public Nullable<int> AgregarDatosDeContacto(string email, string celular, string fijo, int idPersona)
        {
            try
            {
                if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(celular) && string.IsNullOrEmpty(fijo)) return null;

                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    Datos_contacto datosContacto = new Datos_contacto();
                    datosContacto.Email = email;
                    datosContacto.Tel_celular = celular;
                    datosContacto.Tel_fijo = fijo;
                    datosContacto.Persona_Id = idPersona;

                    dbContext.Datos_contacto.Add(datosContacto);
                    return (dbContext.SaveChanges());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        

    }
}
