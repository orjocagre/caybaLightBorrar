using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Usuarios
    {

        int id, id_tpo;
        String Usuario, password, conPassword, nombre;

        public string Usuario1 { get => Usuario; set => Usuario = value; }
        public string Password { get => password; set => password = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public int Id_tpo { get => id_tpo; set => id_tpo = value; }
    }
}
