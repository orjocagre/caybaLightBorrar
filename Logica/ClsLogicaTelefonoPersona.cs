using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
   public class ClsLogicaTelefonoPersona
    {


       public void  ingresarTelefonoPersona(int numero, int idpersona)
        {

           


            ClsDatosTelefonoPersona AddTelefonPersona = new ClsDatosTelefonoPersona();

             AddTelefonPersona.agregarpersonaTelefono(numero, idpersona);

           

        }













    }
}
