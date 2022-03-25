using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ClsDatosMetodosGlobales
    {

        ClsDatosConexion conex = new ClsDatosConexion();

        public DataTable bdConsultas(String sql)
        {
            DataTable DT = new DataTable();

            try
            {
                MySqlCommand CM = new MySqlCommand(sql, conex.conectar);
                MySqlDataAdapter DA = new MySqlDataAdapter(CM);
                DA.Fill(DT);


            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conex.conectar.Close();
            }
            return DT;

        }
    }
}
