using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ClsDatosInsumo
    {

        ClsDatosConexion conex = new ClsDatosConexion();

        public int agregarInsumo(String Pdescripcion, String PdescripcionF, int Porden, int Pid_um, double Ppeso_llena, double Ppeso_vacia, double Ptamano)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x;

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarInsumo";

                CM.Parameters.AddWithValue("Pdescripcion", Pdescripcion);
                CM.Parameters["Pdescripcion"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PdescripcionF", PdescripcionF);
                CM.Parameters["PdescripcionF"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Porden", Porden);
                CM.Parameters["Porden"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_um", Pid_um);
                CM.Parameters["Pid_um"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Ppeso_llena", Ppeso_llena);
                CM.Parameters["Ppeso_llena"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Ppeso_vacia", Ppeso_vacia);
                CM.Parameters["Ppeso_vacia"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Ptamano", Ptamano);
                CM.Parameters["Ptamano"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("Pmsj", "");
                CM.Parameters["Pmsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();
                return Convert.ToInt32(x.Value);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return -3;
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
