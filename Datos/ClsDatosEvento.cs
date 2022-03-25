using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ClsDatosEvento
    {

        ClsDatosConexion conex = new ClsDatosConexion();


        public int cambiarEstadoEvento(int Popcion, int estado, int PidEvento)
        {
            MySqlCommand CM = new MySqlCommand();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "CambiarEstadoEvento";

                CM.Parameters.AddWithValue("Popcion", Popcion);
                CM.Parameters["Popcion"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pestado", estado);
                CM.Parameters["Pestado"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PidEvento", PidEvento);
                CM.Parameters["PidEvento"].Direction = ParameterDirection.Input;


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

        public int agregarEvento(DateTime Pfecha_contrato, DateTime Pfecha_evento, int Pid_tipo_evento, int Pnum_personas, String Phora_inicio, int Pid_tipo_servicio, int Psolo_local, String Phora_comida, int Phora_extra, String Pcomentarios, double Ptotal, double Panticipo, double Ppendiente, int PanticipoCancelado, int PtotalCancelado, String Pnombres, String Papellidos, String Pcedula, int Pnumero)
        {
            MySqlParameter x = new MySqlParameter();
            MySqlCommand CM = new MySqlCommand();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarEvento";

                

                CM.Parameters.AddWithValue("Pfecha_contrato", Pfecha_contrato.Date);
                CM.Parameters["Pfecha_contrato"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pfecha_evento", Pfecha_evento.Date);
                CM.Parameters["Pfecha_evento"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_tipo_evento", Pid_tipo_evento);
                CM.Parameters["Pid_tipo_evento"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pnum_personas", Pnum_personas);
                CM.Parameters["Pnum_personas"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Phora_inicio", Phora_inicio);
                CM.Parameters["Phora_inicio"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_tipo_servicio", Pid_tipo_servicio);
                CM.Parameters["Pid_tipo_servicio"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Psolo_local", Psolo_local);
                CM.Parameters["Psolo_local"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Phora_comida", Phora_comida);
                CM.Parameters["Phora_comida"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Phora_extra", Phora_extra);
                CM.Parameters["Phora_extra"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pcomentarios", Pcomentarios);
                CM.Parameters["Pcomentarios"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Ptotal", Ptotal);
                CM.Parameters["Ptotal"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Panticipo", Panticipo);
                CM.Parameters["Panticipo"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Ppendiente", Ppendiente);
                CM.Parameters["Ppendiente"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PanticipoCancelado", PanticipoCancelado);
                CM.Parameters["PanticipoCancelado"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PtotalCancelado", PtotalCancelado);
                CM.Parameters["PtotalCancelado"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pnombres", Pnombres);
                CM.Parameters["Pnombres"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Papellidos", Papellidos);
                CM.Parameters["Papellidos"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pcedula", Pcedula);
                CM.Parameters["Pcedula"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pnumero", Pnumero);
                CM.Parameters["Pnumero"].Direction = ParameterDirection.Input;

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

        public int editarEvento(int Pid_evento, DateTime Pfecha_contrato, DateTime Pfecha_evento, int Pid_tipo_evento, int Pnum_personas, String Phora_inicio, int Pid_tipo_servicio, int Psolo_local, String Phora_comida, int Phora_extra, String Pcomentarios, double Ptotal, double Panticipo, double Ppendiente, int PanticipoCancelado, int PtotalCancelado, String Pnombres, String Papellidos, String Pcedula, int Pnumero)
        {
            MySqlParameter x = new MySqlParameter();
            MySqlCommand CM = new MySqlCommand();
            
            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "EditarEvento";

                CM.Parameters.AddWithValue("Pid_evento", Pid_evento);
                CM.Parameters["Pid_evento"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pfecha_contrato", Pfecha_contrato.Date);
                CM.Parameters["Pfecha_contrato"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pfecha_evento", Pfecha_evento.Date);
                CM.Parameters["Pfecha_evento"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_tipo_evento", Pid_tipo_evento);
                CM.Parameters["Pid_tipo_evento"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pnum_personas", Pnum_personas);
                CM.Parameters["Pnum_personas"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Phora_inicio", Phora_inicio);
                CM.Parameters["Phora_inicio"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_tipo_servicio", Pid_tipo_servicio);
                CM.Parameters["Pid_tipo_servicio"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Psolo_local", Psolo_local);
                CM.Parameters["Psolo_local"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Phora_comida", Phora_comida);
                CM.Parameters["Phora_comida"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Phora_extra", Phora_extra);
                CM.Parameters["Phora_extra"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pcomentarios", Pcomentarios);
                CM.Parameters["Pcomentarios"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Ptotal", Ptotal);
                CM.Parameters["Ptotal"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Panticipo", Panticipo);
                CM.Parameters["Panticipo"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Ppendiente", Ppendiente);
                CM.Parameters["Ppendiente"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PanticipoCancelado", PanticipoCancelado);
                CM.Parameters["PanticipoCancelado"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PtotalCancelado", PtotalCancelado);
                CM.Parameters["PtotalCancelado"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pnombres", Pnombres);
                CM.Parameters["Pnombres"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Papellidos", Papellidos);
                CM.Parameters["Papellidos"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pcedula", Pcedula);
                CM.Parameters["Pcedula"].Direction = ParameterDirection.Input;

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

        public int agregarAreaEvento(int PidArea, int PidEvento)
        {
            MySqlCommand CM = new MySqlCommand();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarAreaEvento";

                CM.Parameters.AddWithValue("PidArea", PidArea);
                CM.Parameters["PidArea"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PidEvento", PidEvento);
                CM.Parameters["PidEvento"].Direction = ParameterDirection.Input;

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
        public int cambiarEstadoEvento(int Popcion, int PidEvento)
        {
            MySqlCommand CM = new MySqlCommand();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "CambiarEstadoEvento";

                CM.Parameters.AddWithValue("Popcion", Popcion);
                CM.Parameters["Popcion"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PidEvento", PidEvento);
                CM.Parameters["PidEvento"].Direction = ParameterDirection.Input;


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


        public DataTable consultas(String sql)
        {
            return new ClsDatosMetodosGlobales().bdConsultas(sql);
        }
    }
}
