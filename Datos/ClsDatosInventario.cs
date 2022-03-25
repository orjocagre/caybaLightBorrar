using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ClsDatosInventario
    {
        ClsDatosConexion conex = new ClsDatosConexion();

        public int agregarInventario(DateTime fecha, int inicial)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x;

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarInventario";

                CM.Parameters.AddWithValue("Pfecha", fecha.ToString("yyy-MM-dd"));
                CM.Parameters["Pfecha"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Phora", fecha.ToString("HH:mm:ss"));
                CM.Parameters["Phora"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pinicial", inicial);
                CM.Parameters["Pinicial"].Direction = ParameterDirection.Input;

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
        public int agregarInventarioProducto(int Pid_inventario, int Pid_insumo, double Pcantidad, int PporPeso)
        {
            MySqlCommand CM = new MySqlCommand();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarInventarioInsumo";

                CM.Parameters.AddWithValue("Pid_inventario", Pid_inventario);
                CM.Parameters["Pid_inventario"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_insumo", Pid_insumo);
                CM.Parameters["Pid_insumo"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pcantidad", Pcantidad);
                CM.Parameters["Pcantidad"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PporPeso", PporPeso);
                CM.Parameters["PporPeso"].Direction = ParameterDirection.Input;

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
