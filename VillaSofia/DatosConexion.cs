using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DatosConexion
    {

        public static MySqlConnection getConexion()
        {

             string host = "127.0.0.1";
             string usuario = "root";
               string clave = "root";
            string BaseDatos = "bxz5oysljxjxpbctsnrf";

        String conectar = ("datasource=" + host +
            ";username=" + usuario + ";password=" + clave + ";database=" + BaseDatos);

        MySqlConnection conexion = new MySqlConnection(conectar);

        return conexion;
     }

    }
}
