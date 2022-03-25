using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ClsDatosOrden
    {
        ClsDatosConexion conex = new ClsDatosConexion();
        public int agregarOrden(int Pid_Producto, int Pid_factura, double Pcantidad, double Pprecio_unitario)
        {
            conex.conectar.Open();
            MySqlCommand CM = new MySqlCommand();

            try
            {
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarOrden";

                CM.Parameters.AddWithValue("Pid_Producto", Pid_Producto);
                CM.Parameters["Pid_Producto"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_factura", Pid_factura);
                CM.Parameters["Pid_factura"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pcantidad", Pcantidad);
                CM.Parameters["Pcantidad"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pprecio_unitario", Pprecio_unitario);
                CM.Parameters["Pprecio_unitario"].Direction = ParameterDirection.Input;

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
