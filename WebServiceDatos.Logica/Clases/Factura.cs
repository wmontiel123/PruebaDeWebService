using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WebServiceDatos.Logica.Clases
{
    public class Factura
    {
        SqlCommand sqlCommand = null;
        SqlConnection sqlConnection = null;
        SqlParameter sqlParameter = null;
        SqlDataAdapter sqlDataAdapter = null;
        string stConexion;
        public string InsertarFactura(string ruc,int Importe)
        {
            string salida = " ";
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Facturas_Insertar", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@RUC", ruc));
                sqlCommand.Parameters.Add(new SqlParameter("@IMPORTE", Importe));

                sqlCommand.ExecuteNonQuery();

                salida = "Completo";





            }
            catch
            {
                salida = "No Exitoso";
            }
            finally
            { sqlConnection.Close(); }
            return salida;
        }


        public string ObtenerTotalFacturas(string ruc)
        {
            string salida = " ";
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Facturas_Total", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@RUC", ruc));

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Mensaje";
                sqlParameter.SqlDbType = System.Data.SqlDbType.VarChar;
                sqlParameter.Size = 50;
                sqlParameter.Direction = System.Data.ParameterDirection.Output;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();
            

                sqlCommand.ExecuteNonQuery();

                salida = "Total facturas del ruc: "+ruc+" "+sqlParameter.Value.ToString();





            }
            catch
            {
                salida = "No Exitoso";
            }
            finally
            { sqlConnection.Close(); }
            return salida;
        }
    }
}
