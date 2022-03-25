using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Datos
{
   public class ClsDatosRegistroTrabajador
    {


        ClsDatosConexion conex = new ClsDatosConexion();
        public int agregarTrabajador(int idpersona, int idTipoTrabajador, double salario)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();//98704


            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarTrabajador";

                CM.Parameters.AddWithValue("PidPersona", idpersona);
                CM.Parameters["PidPersona"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PidTipoTrabajador", idTipoTrabajador);
                CM.Parameters["PidTipoTrabajador"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Psalario", salario);
                CM.Parameters["Psalario"].Direction = ParameterDirection.Input;

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



        //Funcion para eliminar un trabajador 
        public int EliminarTrabajador(int idTrabajador)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();//98704

            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "EliminarTrabajador";

                CM.Parameters.AddWithValue("PidTrabajador", idTrabajador);
                CM.Parameters["PidTrabajador"].Direction = ParameterDirection.Input;


                CM.ExecuteNonQuery();
                return 1;
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


        public int editarTrabajador(int PidTrabajador, String Pcedula, String Pnombres, String Papellidos, int Pid_tipo_trabajador, double Psalario, int Pnumero)
        {
            MySqlCommand CM = new MySqlCommand();


            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "EditarTrabajador";

                CM.Parameters.AddWithValue("PidTrabajador", PidTrabajador);
                CM.Parameters["PidTrabajador"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pcedula", Pcedula);
                CM.Parameters["Pcedula"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pnombres", Pnombres);
                CM.Parameters["Pnombres"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Papellidos", Papellidos);
                CM.Parameters["Papellidos"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_tipo_trabajador", Pid_tipo_trabajador);
                CM.Parameters["Pid_tipo_trabajador"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Psalario", Psalario);
                CM.Parameters["Psalario"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pnumero", Pnumero);
                CM.Parameters["Pnumero"].Direction = ParameterDirection.Input;


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






        public DataTable ListarTrabajadores(String sql)
        {
            return new ClsDatosMetodosGlobales().bdConsultas(sql);
        }




















    }
}
