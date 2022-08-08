using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication4.Servicios
{
    /// <summary>
    /// Descripción breve de Factura
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Factura : System.Web.Services.WebService
    {

        [WebMethod]
        public string InsertarFacturas(string ruc, int Importe)
        {
            try
            {

                WebServiceDatos.Logica.Clases.Factura ob = new WebServiceDatos.Logica.Clases.Factura();
                return ob.InsertarFactura(ruc, Importe);

            }
            catch { }
            return "";
        }
        public string ObtenerTotalFacturas(string ruc)
        {
            string salida = "";
            try
            {

                WebServiceDatos.Logica.Clases.Factura ob = new WebServiceDatos.Logica.Clases.Factura();
                salida = ob.ObtenerTotalFacturas(ruc);

            }
            catch {
                salida = "error";
            }
            finally
            {

            }
            return salida;
           
        }
    }
}
