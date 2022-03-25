using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
namespace Logica
{
   public class ClsLogicaAddReceta
    {


        public void eliminarReceta(int idReceta)
        {
            ClsDatosAddReceta receta = new ClsDatosAddReceta();
            receta.eliminarReceta(idReceta);
        }

        public String editarReceta(int idReceta, String nombreReceta, int porciones, String procedimiento)
        {
            ClsDatosAddReceta receta = new ClsDatosAddReceta();
            int msj = receta.ediarReceta(idReceta, nombreReceta, porciones, procedimiento);
            if(msj == 1)
            {
                return "Receta Editada";
            }
            else
            {
                return "Error en sintaxis Sql";
            }
        }

        public string AddReceta(String nombreReceta, int porciones, String procedimiento)
        {
            int i;
            ClsDatosAddReceta Receta = new ClsDatosAddReceta();

            i = Receta.AddReceta(nombreReceta, porciones, procedimiento);
            String mensaje;


          
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

        
        public DataTable RecetaLista(string x)
        {
            string sql = "SELECT * FROM receta WHERE receta.id_receta LIKE '%" + x + "%'";
            return new ClsDatosUM().UM(sql);
        }

        public DataTable RecetaListaConNom(string x)
        {
            string sql = "SELECT * FROM receta WHERE receta.nombre_receta LIKE '%" + x + "%'";
            return new ClsDatosUM().UM(sql);
        }

    }






   
}
