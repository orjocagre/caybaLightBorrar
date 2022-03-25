using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Datos
{
    public class ClsDatosSinonimo
    {

        ClsDatosConexion conex = new ClsDatosConexion();

        public int agregarSinonimo(String Pnombre, String PnombreF, int PidProducto, int Pvisible)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();//98704

            try
            {
                conex.conectar.Open();

                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarSinonimo";

                CM.Parameters.AddWithValue("Pnombre", Pnombre);
                CM.Parameters["Pnombre"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PnombreF", PnombreF);
                CM.Parameters["PnombreF"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PidProducto", PidProducto);
                CM.Parameters["PidProducto"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pvisible", Pvisible);
                CM.Parameters["Pvisible"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("Pmsj", "");
                CM.Parameters["Pmsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();
                return Convert.ToInt32(x.Value.ToString());

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
