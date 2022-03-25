using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Login
{
    class Modelo
    {

        public int registro(Usuarios usuario)
        {

            MySqlConnection conexion = Datos.DatosConexion.getConexion();
            conexion.Open();

            String sql = "INSERT INTO usuarios (usuario,password,nombre,id_tipo)" +
                "VALUES(@usuario, @password, @nombre, @id_tipo)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario1);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@id_tipo", 1);

            int resultado = comando.ExecuteNonQuery();

            return resultado;

        }

        public bool existeUsuario(string usuario) 
        {
            MySqlDataReader reader;


            MySqlConnection conexion = Datos.DatosConexion.getConexion();
            conexion.Open();

            String sql = "SELECT id FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if(reader.HasRows)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public Usuarios validacion(string usuario)
        {
            MySqlDataReader reader;


            MySqlConnection conexion = Datos.DatosConexion.getConexion();
            conexion.Open();

            String sql = "SELECT id, password, nombre, id_tipo FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();

                usr.Id = int.Parse(reader["id"].ToString());
                usr.Password = reader["password"].ToString();
                usr.Nombre = reader["nombre"].ToString();
                usr.Id_tpo = int.Parse(reader["id_tipo"].ToString());
                return usr;

            }
            return usr;

           /* if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }*/
        }
    }
}
