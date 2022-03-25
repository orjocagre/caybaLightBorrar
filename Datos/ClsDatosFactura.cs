using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ClsDatosFactura
    {
        ClsDatosConexion conex = new ClsDatosConexion();

        public int agregarFactura(DateTime Pfecha, int Pnum_mesa, String Pnombre, String PRUC, int Pid_trabajador, int Pid_estado_factura)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarFactura";

                CM.Parameters.AddWithValue("Pfecha", Pfecha.Date);
                CM.Parameters["Pfecha"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Phora", Pfecha.ToString("HH:mm:ss"));
                CM.Parameters["Phora"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pnum_mesa", Pnum_mesa);
                CM.Parameters["Pnum_mesa"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pnombre", Pnombre);
                CM.Parameters["Pnombre"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PRUC", PRUC);
                CM.Parameters["PRUC"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_trabajador", Pid_trabajador);
                CM.Parameters["Pid_trabajador"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_estado_factura", Pid_estado_factura);
                CM.Parameters["Pid_estado_factura"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("Pmsj", "");
                CM.Parameters["Pmsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();

                return Convert.ToInt32(x.Value.ToString());

             
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

        public int agregarDatosFactura(int id_factura, String Pnombre, String PRUC, int Pid_trabajador)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarDatosFactura";

                CM.Parameters.AddWithValue("Pid_factura", id_factura);
                CM.Parameters["Pid_factura"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pnombre", Pnombre);
                CM.Parameters["Pnombre"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("PRUC", PRUC);
                CM.Parameters["PRUC"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_trabajador", Pid_trabajador);
                CM.Parameters["Pid_trabajador"].Direction = ParameterDirection.Input;

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

        public int agregarPagoFactura(int idFactura, double Pefectivo, double Ptarjeta)
        {

            MySqlCommand CM = new MySqlCommand();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarPagoFactura";


                CM.Parameters.AddWithValue("PidFactura", idFactura);
                CM.Parameters["PidFactura"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Ptarjeta", Ptarjeta);
                CM.Parameters["Ptarjeta"].Direction = ParameterDirection.Input;


                CM.Parameters.AddWithValue("Pefectivo", Pefectivo);
                CM.Parameters["Pefectivo"].Direction = ParameterDirection.Input;

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

        public int guardarTotalFactura(int PidFactura, double Ptotal)
        {
            MySqlCommand CM = new MySqlCommand();
            MySqlParameter x = new MySqlParameter();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "GuardarTotalFactura";

                CM.Parameters.AddWithValue("PidFactura", PidFactura);
                CM.Parameters["PidFactura"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Ptotal", Ptotal);
                CM.Parameters["Ptotal"].Direction = ParameterDirection.Input;

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

        public int cambiarEstadoFactura(int Pid_factura, int Pid_estado_factura)
        {
            MySqlCommand CM = new MySqlCommand();

            try
            {
                conex.conectar.Open();
                CM.Connection = conex.conectar;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "CambiarEstadoFactura";

                CM.Parameters.AddWithValue("Pid_factura", Pid_factura);
                CM.Parameters["Pid_factura"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("Pid_estado_factura", Pid_estado_factura);
                CM.Parameters["Pid_estado_factura"].Direction = ParameterDirection.Input;

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
