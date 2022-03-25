using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ClsDatosConjunto
    {

        ClsDatosConexion conex = new ClsDatosConexion();

        public int agregarConjunto(DateTime fechaInicio)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x;

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarConjunto";

                CM.Parameters.AddWithValue("Pfecha_inicio", fechaInicio);
                CM.Parameters["Pfecha_inicio"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("Pmsj", "");
                CM.Parameters["Pmsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();
                return Convert.ToInt32(x.Value);
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return -3;
            }
            finally
            {
                conex.conectar.Close();
            }
        }

        public int cerrarConjunto(int PidConjunto, DateTime Pfecha)
        {
            MySqlCommand CM = new MySqlCommand();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "CerrarConjunto";

                CM.Parameters.AddWithValue("PidConjunto", PidConjunto);
                CM.Parameters["PidConjunto"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pfecha", Pfecha);
                CM.Parameters["Pfecha"].Direction = ParameterDirection.Input;

               

                CM.ExecuteNonQuery();
                return 1;
            }
            catch (MySqlException e)
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
