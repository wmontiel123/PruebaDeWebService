using System;
using System.Web.Services;



namespace WebApplication4.Servicios
{
    /// <summary>
    /// Descripción breve de Cliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Cliente : System.Web.Services.WebService
    {

        [WebMethod]
        public string AltaClientes(string ruc, string razon_social, DateTime fecha, int Estado)
        {
           try {

                WebServiceDatos.Logica.Clases.Clientes ob = new WebServiceDatos.Logica.Clases.Clientes();
                return ob.InsertarClientes(ruc, razon_social, fecha, Estado);       

            } catch { }
            return "";
        }
        public string ActualizarClientes(string ruc, int Estado)
        {
            try
            {

                WebServiceDatos.Logica.Clases.Clientes ob = new WebServiceDatos.Logica.Clases.Clientes();
                return ob.ActualizarClientes(ruc,Estado);

            }
            catch { }
            return "";
        }
    }
}
