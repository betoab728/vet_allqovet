using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllqovetDAO
{
  public static class Conexion
    {
        public static string Cadenaconexion()
        {
            return AllqovetDAO.Properties.Settings.Default.cnx;
        }
    }
}
