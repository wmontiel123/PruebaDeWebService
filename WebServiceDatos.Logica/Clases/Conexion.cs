using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace WebServiceDatos.Logica.Clases
{
    public class Conexion
    {
        public String getConexion()
        {
            return ConfigurationManager.ConnectionStrings["cnx"].ToString();
        }
    }
}