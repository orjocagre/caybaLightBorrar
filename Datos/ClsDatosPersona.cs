using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Datos
{
    public class ClsDatosPersona
    {

        ClsDatosConexion conex = new ClsDatosConexion();

        public int agregarpersona(String Cedula, String Nombres, String Apellido)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();//98704

            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarPersona";

                CM.Parameters.AddWithValue("PCedula", Cedula);
                CM.Parameters["PCedula"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PNombres", Nombres);
                CM.Parameters["PNombres"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PApellidos", Apellido);
                CM.Parameters["PApellidos"].Direction = ParameterDirection.Input;

              
                x = CM.Parameters.AddWithValue("PMSJ", "");
                CM.Parameters["PMSJ"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();
                return Convert.ToInt32(x.Value.ToString());

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return -1;
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

