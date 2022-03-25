using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ClsDatosProducto
    {


        ClsDatosConexion conex = new ClsDatosConexion();


        public int eliminarProducto(int id)
        {
            //try
            //{
            //    conex.conectar.Open();
            //    String sql = "DELETE FROM producto WHERE producto.idProducto = " + id.ToString();
            //    MySqlCommand CM = new MySqlCommand(sql, conex.conectar);
            //    return CM.ExecuteNonQuery();
            //}
            //catch(MySqlException e)
            //{
            //    Console.WriteLine(e.ToString());
            //    return 3;
            //}
            //finally
            //{
            //    conex.conectar.Close();
            //}

            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "EliminarProducto";

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

        public int insertarProducto(int reseve, DateTime fecha, String nombre, double precio, int idTipoProducto, int idProcedencia, int orden)
        {
            MySqlCommand CM = new MySqlCommand();


            try
            {
                conex.conectar.Open();
                MySqlParameter x = new MySqlParameter();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarProducto";

                CM.Parameters.AddWithValue("Pid_restaurante_evento", reseve);
                CM.Parameters["Pid_restaurante_evento"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pfecha", fecha.Date);
                CM.Parameters["Pfecha"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pnombre", nombre);
                CM.Parameters["Pnombre"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pprecio", precio);
                CM.Parameters["Pprecio"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PidTipoProducto", idTipoProducto);
                CM.Parameters["PidTipoProducto"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PidProcedencia", idProcedencia);
                CM.Parameters["PidProcedencia"].Direction = ParameterDirection.Input;

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
                return -3;

            }
            finally
            {
                conex.conectar.Close();
            }
        }
        public int insertarProductoInsumo(int Pid_producto, int Pid_insumo, double Pcantidad)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x;

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarProductoInsumo";

                CM.Parameters.AddWithValue("Pid_producto", Pid_producto);
                CM.Parameters["Pid_producto"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_insumo", Pid_insumo);
                CM.Parameters["Pid_insumo"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pcantidad", Pcantidad);
                CM.Parameters["Pcantidad"].Direction = ParameterDirection.Input;

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
        public int editarProducto(int Pidreseve, int idProducto, String nombre, double precio, int idTipoProducto, int idProcedencia)
        {
            MySqlCommand CM = new MySqlCommand();


            try
            {
                conex.conectar.Open();
                MySqlParameter x = new MySqlParameter();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "EditarProducto";

                CM.Parameters.AddWithValue("Pidreseve", Pidreseve);
                CM.Parameters["Pidreseve"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PidProducto", idProducto);
                CM.Parameters["PidProducto"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pnombre", nombre);
                CM.Parameters["Pnombre"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pprecio", precio);
                CM.Parameters["Pprecio"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PidTipoProducto", idTipoProducto);
                CM.Parameters["PidTipoProducto"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PidProcedencia", idProcedencia);
                CM.Parameters["PidProcedencia"].Direction = ParameterDirection.Input;

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

        public int bajarSubirProducto(int id, int upDown)
        {

            MySqlCommand CM = new MySqlCommand();

            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "SubirBajarProducto";

                CM.Parameters.AddWithValue("PidProducto", id);
                CM.Parameters["PidProducto"].Direction = ParameterDirection.Input;

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


        public int moverProducto(int id, int posfinal)
        {
            MySqlCommand CM = new MySqlCommand();


            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "MoverProducto";

                CM.Parameters.AddWithValue("PidProducto", id);
                CM.Parameters["PidProducto"].Direction = ParameterDirection.Input;

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

        public int cambiarVisibilidad(int idProducto)
        {
            MySqlCommand CM = new MySqlCommand();


            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "CambiarVisibilidadProducto";

                CM.Parameters.AddWithValue("PidProducto", idProducto);
                CM.Parameters["PidProducto"].Direction = ParameterDirection.Input;

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

        public DataTable consulta(String sql)
        {
            return new ClsDatosMetodosGlobales().bdConsultas(sql);
        }

    }
}
