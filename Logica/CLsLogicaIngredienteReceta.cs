using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
   public class CLsLogicaIngredienteReceta
    {


        public String ingresarDatosIngrediente(string nombreIng)
        {

            ClsLogicaIngredientes AddIngrediente = new ClsLogicaIngredientes();


            string X = AddIngrediente.ingresarIngredientes(nombreIng);

            return X;
        }

       public String ingresarDatosReceta(String nombreReceta, int porciones, String procedimiento)
        {

            ClsLogicaAddReceta AddReceta = new ClsLogicaAddReceta();


            string X = AddReceta.AddReceta(nombreReceta, porciones, procedimiento);

            return X;
        }
       

        public String AddIngredienteR(int idIngrediente, int idReceta, double cantidad,int IDUM)
        {


            ClsDatosIngredienteReceta IReceta = new ClsDatosIngredienteReceta();
            int i = IReceta.AddIngredienteReceta(idIngrediente,idReceta,cantidad, IDUM);

            string mensaje="";
            if (i == 1)
            {
                mensaje = "Ya esta agregado este ingrediente a la receta,\n Ingrese un nuevo ingrediente!";

            }
           if(i == 7)
           {
                mensaje = "Se guardo con Éxito el nuevo igrediente!";

           }
           
          
            return mensaje;
        }

        public string EliminarRecetaIngrediente(int ireceta, int idingrediente)
        {
            int i;
            ClsDatosIngredienteReceta InReceta = new ClsDatosIngredienteReceta();

            i = InReceta.EliminarReceta(ireceta, idingrediente);
            String mensaje;



            if (i == -1)
            {
                mensaje = "Error al Eliminar";

            }
            else
            {
                mensaje = "Error al Eliminar";


            }



            return mensaje;
        }

        //COMPONER
        public DataTable ListarIngredientes(string x)
        {
            string sql = "SELECT * FROM vistamostraringredientes WHERE vistamostraringredientes.id_receta LIKE '%" + x + "%'";
            // Datos.ClsDatosRegistroTrabajador Lista = new Datos.ClsDatosRegistroTrabajador();
            //  return new ClsDatosTipoTrabajador().ListarTipoTrabajador(sql);
            return new ClsDatosTipoTrabajador().ListarTipoTrabajador(sql);
        }
      

    }
}
