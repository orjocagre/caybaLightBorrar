using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
    public class ClsLogicaPersona
    {

        public string Agregarpersona(String Cedula, String Nombres, String Apellido)
        {


            String mensaje;
            int i;
           

            ClsDatosPersona Addpersona = new ClsDatosPersona();

            i = Addpersona.agregarpersona(Cedula, Nombres, Apellido);

            if (i == -1)
            {
                mensaje = "Error al guardar";

            }
            else 
            {
                mensaje = i.ToString();


            }
            

            return mensaje;
        }
    }
    }

