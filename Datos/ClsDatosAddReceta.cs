using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace Datos
{
  public  class ClsDatosAddReceta
    {




        ClsDatosConexion conex = new ClsDatosConexion();

        public int AddReceta(String nombreReceta, int porciones, String procedimiento)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();//98704

            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarReceta";

                CM.Parameters.AddWithValue("Pnombre_receta", nombreReceta);
                CM.Parameters["Pnombre_receta"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PnumPorciones", porciones);
                CM.Parameters["PnumPorciones"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PProcedimiento", procedimiento);
                CM.Parameters["PProcedimiento"].Direction = ParameterDirection.Input;


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
        public int ediarReceta(int idReceta, String nombreReceta, int porciones, String procedimiento)
        {
            MySqlCommand CM = new MySqlCommand();

            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "EditarReceta";

                CM.Parameters.AddWithValue("Pid_receta", idReceta);
                CM.Parameters["Pid_receta"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pnombre_receta", nombreReceta);
                CM.Parameters["Pnombre_receta"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PnumPorciones", porciones);
                CM.Parameters["PnumPorciones"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pprocedimiento", procedimiento);
                CM.Parameters["Pprocedimiento"].Direction = ParameterDirection.Input;

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
        public void eliminarReceta(int idReceta)
        {
            MySqlCommand CM = new MySqlCommand();
            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "EliminarReceta";

                CM.Parameters.AddWithValue("PidReceta", idReceta);
                CM.Parameters["PidReceta"].Direction = ParameterDirection.Input;

              
                CM.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conex.conectar.Close();
            }
        }










    }
}
