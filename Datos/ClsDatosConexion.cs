using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace Datos
{
    public class ClsDatosConexion
    {
        static string host = "127.0.0.1";
        static string usuario = "root";
        static string clave = "root";
        static string BaseDatos = "caybaLite";

        /*static string host = "bxz5oysljxjxpbctsnrf-mysql.services.clever-cloud.com";
        static string usuario = "ut6e1oluo4pqdxba";
        static string clave = "7Vhkn5USbmWWqfmijAJO";
        static string BaseDatos = "bxz5oysljxjxpbctsnrf";*/

        public MySqlConnection conectar = new MySqlConnection("datasource=" + host + ";username=" + usuario + ";password=" + clave + ";database=" + BaseDatos);

    }
}
