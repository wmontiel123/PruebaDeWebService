using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WebServiceDatos.Logica.Clases
{
    public class Clientes
    {
        SqlCommand sqlCommand = null;
        SqlConnection sqlConnection = null;
        SqlParameter sqlParameter = null;
        SqlDataAdapter sqlDataAdapter = null;
        string stConexion;



        public Clientes()
        {
            Conexion Obconexion = new Conexion();
            stConexion = Obconexion.getConexion();

        }

        public string InsertarClientes(string ruc, string razon_social, DateTime fecha, int Estado)
        {
            string salida = " ";
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Cliente_Create", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@RUC", ruc));
                sqlCommand.Parameters.Add(new SqlParameter("@RAZON_SOCIAL", razon_social));
                sqlCommand.Parameters.Add(new SqlParameter("@FECHA_CONSTITUCION", fecha));
                sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", Estado));

                sqlCommand.ExecuteNonQuery();

                salida = "Completo";





            }
            catch
            {
                salida = "No Exitoso";
            } finally
            { sqlConnection.Close(); }
            return salida;
        }


        public string ActualizarClientes(string ruc,int Estado)
        {
            string salida = " ";
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Cliente_Update", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@RUC", ruc));
                sqlCommand.Parameters.Add(new SqlParameter("@ESTADO", Estado));

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
    }
}
