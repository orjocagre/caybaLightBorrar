using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClsLogicaBuscador
    {



        public int[] ordenarElementos(String[] lista, String clave)     //este  metodo recibe un arreglo de Strings y una clave y busca coincidencias de esa clave en el arreglo, devuelve un arreglo de enteros con las pociciones de los String que coinciden con la clave, donde el 0 es el mas parecido 
        {
            int[] coincidencias;
            int[] puntos = new int[lista.Length];
            for(int i=0; i<puntos.Length; i++)
            {
                puntos[i] = 0;
            }

            for (int i = 0; i < lista.Length; i++)   //recorre cada elemento del la lista
            {
                int pos = 0;  //se declara pos para mantener la posicion cuando se cambie la letra de la clave

                for (int j = 0; j < clave.Length; j++)   //recorre cada letra de la clave
                {
                    for (int k = pos; k < lista[i].Length; k++)    //recorre cada letra del elemento
                    {
                        if (clave.ToCharArray()[j] == lista[i].ToCharArray()[k])     //compara la letra de la clave con la letra del elemento
                        {
                            puntos[i] += (1 + k);   //aumenta los puntos en funcion de la posicion + 1
                            pos = k;                //se guarda la posicion actual
                            k = lista[i].Length;    //se salta a la siguiente letra de la clave
                        }
                        else if(k == lista[i].Length - 1)    //si se llego al final del elemento y no se encontro la letra de la clave
                        {
                            puntos[i] = 0;  //se reestablecen los puntos
                            j = clave.Length;   //se salta al siguiente elemento

                        }
                    }
                }
            }

            int validos = 0;



            for (int i=0; i<puntos.Length; i++)
            {
                if(puntos[i] > 0)
                {
                    validos++;
                }
            }

            coincidencias = new int[validos];


            for(int i=0; i<coincidencias.Length; i++)   //recorre el arrey de coincidencias guardando cada valor
            {
                int menor = 3000;   //se inicia el menor en 3000 para ir disminuyendolo
                int menorIndice = 0;    //variable para guardar el pocicion de valor menor
                
                for (int j = 0; j < puntos.Length; j++)     //recorre el arrey de puntos buscando el menor
                {
                    if (puntos[j] > 0 && puntos[j] < menor)     //compara el punto actual con el menor
                    {
                        menor = puntos[j];
                        menorIndice = j;
                    }
                }

                coincidencias[i] = menorIndice;
                puntos[menorIndice] = 0;
                
            }

            return coincidencias;

        }
       
    }
}
