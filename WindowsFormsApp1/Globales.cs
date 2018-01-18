using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using Entidades;

namespace WindowsFormsApp1
{
    static class Globales
    {
        //Logica.gestorUsuarios _gestorUsuarios = new gestorUsuarios();

        private static UsuarioDTO _globalUserObject;
        private static string _globalUserName = "";
        private static string _globalUserType = "";

        public static UsuarioDTO userObject
        {
            get { return _globalUserObject; }
            set { _globalUserObject = value; }
        }

        public static string userName
        {
            get { return _globalUserName; }
            set { _globalUserName = value; }
        }

        public static string userType
        {
            get { return _globalUserType; }
            set { _globalUserType = value; }
        }




    }

    
}
