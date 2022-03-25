using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class ClsLogicaSinonimo
    {

        String[] desagruparSinonimos(String x)
        {

            String[] y = x.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            List<String> z = new List<string>();

            for (int i = 0; i < y.Length; i++)
            {

                y[i] = y[i].Trim();

                if (y[i] != "")
                {
                    //**************************************SE*QUITAN*LOS*ESPACIOS*DOBLES***********************************************
                    Boolean ultCaracterEsEspacio = false;
                    //int tamPalabra = y[i].Length;
                    for (int j = 0; j < y[i].Length; j++)
                    {
                        if (y[i].ToCharArray()[j] == ' ')
                        {
                            if (ultCaracterEsEspacio)
                            {
                                y[i] = y[i].Remove(j, 1);
                                j--;
                                //tamPalabra--;
                            }
                            ultCaracterEsEspacio = true;
                        }
                        else
                        {
                            ultCaracterEsEspacio = false;
                        }

                    }
                    //*******************************************************************************************************************

                    z.Add(y[i]);
                }
            }


            String[] a = new String[z.Count];
            for (int i = 0; i < z.Count; i++)
            {
                a[i] = z.ElementAt(i);
            }

            return a;
        }

        public void agregarSinonimo(int idProducto, String x)
        {
            String[] y = desagruparSinonimos(x);
            String sin;
            ClsDatosSinonimo sinonimo = new ClsDatosSinonimo();

            for (int i=0; i<y.Length; i++)
            {
                sin = y[i].Replace(" ", "").Replace('á', 'a').Replace('é', 'e').Replace('í', 'i').Replace('ó', 'o').Replace('ú', 'u').ToLower();
                sinonimo.agregarSinonimo(y[i], sin, idProducto, 1);
            }

        }

        public void agregarSinonimoPrincipal(int idProducto, String x)
        {
            ClsDatosSinonimo sinonimo = new ClsDatosSinonimo();

            x.Trim();
            String sin = x.Replace(" ", "").Replace('á', 'a').Replace('é', 'e').Replace('í', 'i').Replace('ó', 'o').Replace('ú', 'u').ToLower();

            sinonimo.agregarSinonimo(x, sin, idProducto, 2);
        }


        public void eliminarSinonimos(int idProducto)
        {
            ClsDatosSinonimo sinonimo = new ClsDatosSinonimo();
            sinonimo.consulta("DELETE FROM sinonimo WHERE sinonimo.idProducto = " + idProducto.ToString());

        }

        public String buscarSinonimos(int idProducto)
        {
            ClsDatosSinonimo sinonimo = new ClsDatosSinonimo();
            DataTable DT = sinonimo.consulta("SELECT sinonimo.nombre FROM sinonimo WHERE sinonimo.visible = 1 AND sinonimo.idProducto = "+idProducto.ToString()+" ORDER BY idSinonimo");
            String sin = "";
            for(int i=0; i<DT.Rows.Count; i++)
            {
                sin = sin + DT.Rows[i].Field<String>("nombre") + "\r\n";
            }
            return sin;
        }
    }
}
