using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
   public class ClsLogicaTelefono
    {


        public int agregarTelefono(int numero)
        {
            ClsDatosTelefono AddTelefono = new ClsDatosTelefono();
            

            return AddTelefono.agregarTelefono(numero);

        }




    }



}
