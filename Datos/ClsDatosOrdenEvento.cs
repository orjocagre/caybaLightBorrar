using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ClsDatosOrdenEvento
    {
        ClsDatosConexion conex = new ClsDatosConexion();

        //agregar una orden sin el evento
        public int agregarOrdenEvento(int Pid_Producto, double Pcantidad, double Pprecio_unitario)
        {
            conex.conectar.Open();
            MySqlCommand CM = new MySqlCommand();

            try
            {
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarOrdenEvento";

                CM.Parameters.AddWithValue("Pid_Producto", Pid_Producto);
                CM.Parameters["Pid_Producto"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pcantidad", Pcantidad);
                CM.Parameters["Pcantidad"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pprecio_unitario", Pprecio_unitario);
                CM.Parameters["Pprecio_unitario"].Direction = ParameterDirection.Input;

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

        public int desVincularOrdenEvento(int idEvento)
        {
            conex.conectar.Open();
            MySqlCommand CM = new MySqlCommand();

            try
            {
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "DesvincularOrdenEvento";

                CM.Parameters.AddWithValue("Pid_evento", idEvento);
                CM.Parameters["Pid_evento"].Direction = ParameterDirection.Input;

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

        public int vincularOrdenEvento(int idEvento)
        {
            conex.conectar.Open();
            MySqlCommand CM = new MySqlCommand();

            try
            {
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "VincularOrdenEvento";

                CM.Parameters.AddWithValue("Pid_evento", idEvento);
                CM.Parameters["Pid_evento"].Direction = ParameterDirection.Input;

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
