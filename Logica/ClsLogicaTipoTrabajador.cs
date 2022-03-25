using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
namespace Logica
{
   public class ClsLogicaTipoTrabajador
    {


        public string AddTipoT(String descripcion)
        {


            ClsDatosTipoTrabajador TipoT = new ClsDatosTipoTrabajador();

            int i = TipoT.AddTipoTrabajador(descripcion);
            String mensaje = "";


            if (i == 1)
            {
                mensaje = "Ya esta agregado este cargo de trabajdor,\n Ingrese un nuevo cargo!";

            }
            if (i == 7)
            {
                mensaje = "Se guardo con Éxito el nuevo cargo!";

            }



            return mensaje;
        }



        public DataTable ListarTrabajadores()
        {
            string sql = "SELECT * FROM vistatipotrabajador";
            // Datos.ClsDatosRegistroTrabajador Lista = new Datos.ClsDatosRegistroTrabajador();
            //  return new ClsDatosTipoTrabajador().ListarTipoTrabajador(sql);
            return new ClsDatosTipoTrabajador().ListarTipoTrabajador(sql);
        }

    }
}
