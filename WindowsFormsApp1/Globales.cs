using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class Globales
    {
        private static string _globalUserName = "";
        private static string _globalUserType = "";

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
