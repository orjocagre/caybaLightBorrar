using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace VillaSofia
{
    class ClsControl
    {
        public string ctrlRegistro(ClsUsuarios usuario)
        {

            ClsModelo modelo = new ClsModelo();
            String respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario1) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.ConPassword)
                || string.IsNullOrEmpty(usuario.Nombre))
            {

                respuesta = "Debe llenar todos los campos";


            }
            else
            {
                if (usuario.Password == usuario.ConPassword)
                {

                    if (modelo.existeUsuario(usuario.Usuario1))
                    {

                        respuesta = "El usuario ya existe";

                    }
                    else
                    {

                        usuario.Password = generarSHA1(usuario.Password);
                        modelo.registro(usuario);

                    }

                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }

            return respuesta;

        }

        public string crtlLogin(string usuario, string password)
        {
            ClsModelo modelo = new ClsModelo();
            string respuesta = "";
            ClsUsuarios datosusuario = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";

            }
            else
            {
                datosusuario = modelo.validacion(usuario);
                if (datosusuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosusuario.Password != generarSHA1(password))
                    {
                        respuesta = "El usuario y/o contraseña no existen";
                    }
                    else
                    {

                        ClsSession.id = datosusuario.Id;
                        ClsSession.id_tipo = datosusuario.Id_tpo;
                        ClsSession.nombre = datosusuario.Nombre;
                        ClsSession.usuario = datosusuario.Usuario1;
                        //  Añadir un label para poner el nombre del usuario activo

                    }
                }
            }
            return respuesta;
        }

        private string generarSHA1(string cadena)
        {

            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] < 16)
                {
                    sb.Append("0");
                }

                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();

        }

    }
}

