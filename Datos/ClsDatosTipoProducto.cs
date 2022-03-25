using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Datos
{
    public class ClsDatosTipoProducto
    {
        ClsDatosConexion conex = new ClsDatosConexion();

        public int bajarSubirTipoProducto(int id, int upDown)
        {

            MySqlCommand CM = new MySqlCommand();

            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "SubirBajarTipoProducto";

                CM.Parameters.AddWithValue("PidTipoProducto", id);
                CM.Parameters["PidTipoProducto"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PUpDown", upDown);
                CM.Parameters["PUpDown"].Direction = ParameterDirection.Input;

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


        public int moverTipoProducto(int id, int posfinal)
        {
            MySqlCommand CM = new MySqlCommand();


            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "MoverTipoProducto";

                CM.Parameters.AddWithValue("PidTipoProducto", id);
                CM.Parameters["PidTipoProducto"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PposFinal", posfinal);
                CM.Parameters["PposFinal"].Direction = ParameterDirection.Input;

                CM.ExecuteNonQuery();

                return 1;

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Data.ToString());
                return 3;

            }
            finally
            {
                conex.conectar.Close();
            }
        }
        public int eliminarTipoProducto(int id)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();

            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "EliminarTipoProducto";

                CM.Parameters.AddWithValue("Pid", id);
                CM.Parameters["Pid"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("Pmsj", "");
                CM.Parameters["Pmsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();

                return Convert.ToInt32(x.Value.ToString());


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

        public int actualizarTipoProducto(int id, String descripcion)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();

            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "EditarTipoProducto";

                CM.Parameters.AddWithValue("PidTipoProducto", id);
                CM.Parameters["PidTipoProducto"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pdescripcion", descripcion);
                CM.Parameters["Pdescripcion"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("Pmsj", "");
                CM.Parameters["Pmsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();

                return Convert.ToInt32(x.Value.ToString());

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

        public int insertarTipoProducto(String descripcion, int orden)
        {
            MySqlCommand CM = new MySqlCommand();

            try
            {
                conex.conectar.Open();
                MySqlParameter x = new MySqlParameter();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarTipoProducto";

                CM.Parameters.AddWithValue("Pdescripcion", descripcion);
                CM.Parameters["Pdescripcion"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Porden", orden);
                CM.Parameters["Porden"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("Pmsj", "");
                CM.Parameters["Pmsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();
                return Convert.ToInt32(x.Value.ToString());

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Data.ToString());
                return 3;

            }
            finally
            {
                conex.conectar.Close();
            }
        }


        public DataTable buscarTipoProducto(String sql)
        {
            return new ClsDatosMetodosGlobales().bdConsultas(sql);
        }
    }
}
