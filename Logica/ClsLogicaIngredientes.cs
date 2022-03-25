using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
namespace Logica
{
    public class ClsLogicaIngredientes
    {

        //LISTO

      /*  public String ingresarDatosReceta(string nombreReceta, int porciones, string procedimiento)
        {

            ClsLogicaAddReceta Receta = new ClsLogicaAddReceta();


            string X = Receta.AddReceta(nombreReceta, porciones, procedimiento);
            return X;

        }
        */

      /*  public int ingresarUM(int numero)
        {
            //HACER DESDE CERO
            ClsLogicaTelefono AddTelefono = new ClsLogicaTelefono();


            int X = AddTelefono.agregarTelefono(numero);
            return X;

        }*/

       


        public string ingresarIngredientes(string nombreIng)
        {
            String mensaje;
            int i;
             ClsDatosIngrendientes Ingrediente = new ClsDatosIngrendientes();
           i = Ingrediente.AddIngrediente(nombreIng);
            /*
              int a = Ingrediente.AddIngrediente(nombreIng);
              string U = "";
              if (a == 1)
              {

                  U = "Este Ingrediente ya se encuentra guardado,\n ingrese un nuevo ingrediente";


              }
              if (a == 7)
              {
                  U = "Se guardo un nuevo ingrediente guardo con exito";
              }

              return U;*/
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


        /*

        //Listar Ingredientes 
        public DataTable ListarIngredientes(String x)
        {
            String sql = "SELECT * FROM vistatrabajador WHERE vistatrabajador.cedula LIKE '%" + x + "%'";
            Datos.ClsDatosIngrendientes Lista = new Datos.ClsDatosIngrendientes();

            DataTable DT = new DataTable();
            DT = Lista.ListarIngredientes(sql);
            return DT;
        }
        */


    }
}
