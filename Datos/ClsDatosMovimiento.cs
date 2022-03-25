using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ClsDatosMovimiento
    {
        ClsDatosConexion conex = new ClsDatosConexion();

        public int agregarMovimiento(int Pid_conjunto, double Pmonto, int Pentrada, String Pdescripcion, DateTime Pfecha)
        {
            MySqlCommand CM = new MySqlCommand();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarMovimiento";

                CM.Parameters.AddWithValue("Pid_conjunto", Pid_conjunto);
                CM.Parameters["Pid_conjunto"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pmonto", Pmonto);
                CM.Parameters["Pmonto"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pentrada", Pentrada);
                CM.Parameters["Pentrada"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pdescripcion", Pdescripcion);
                CM.Parameters["Pdescripcion"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pfecha", Pfecha);
                CM.Parameters["Pfecha"].Direction = ParameterDirection.Input;

                CM.ExecuteNonQuery();
                return 1;
   
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return 3;
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
