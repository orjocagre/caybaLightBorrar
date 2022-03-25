using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Datos
{
   public class ClsDatosTelefonoPersona
    {


        ClsDatosConexion conex = new ClsDatosConexion();

       public void  agregarpersonaTelefono(int idpersona, int idtelefono)
        {
            MySqlCommand CM = new MySqlCommand();
           // MySqlParameter x = new MySqlParameter();//98704

            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarPersonaTelefono";

                CM.Parameters.AddWithValue("PidPersona", idpersona);
                CM.Parameters["PidPersona"].Direction = ParameterDirection.Input;

               /* x =*/ CM.Parameters.AddWithValue("PIdTelefono", idtelefono);
                CM.Parameters["PIdTelefono"].Direction = ParameterDirection.Input;

                CM.ExecuteNonQuery();
               // return Convert.ToInt32(x.Value.ToString());

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                //return -1;
            }
            finally
            {
                conex.conectar.Close();
            }
        }

        public DataTable consulta(String sql)
        {
            return new ClsDatosMetodosGlobales().bdConsultas(sql);
        }
    }





}
