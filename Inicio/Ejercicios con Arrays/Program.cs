using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_con_Arrays
{
    class Program
    {
        public int k = 0, sumapos = 0;

        public string EliminarEspacios(string nombre, int[] posicion)
        {

            foreach (var i in nombre)
            {
                k += 1;
                if (i == ' ')
                {
                    int j = 0;
                    posicion[j] = k;
                    j++;
                }
                
            }

            for (int j = 0; j > posicion.Length; j++)
            {
               sumapos = posicion[j];
            }

            return sumapos.ToString();
        }

    
        static void Main(string[] args)
        {
          
             int[] lista = { 1, 2, 3, 4, 5, 6, 7 };
            string name = "VOY AL BAÑO Y YA VUELVO";
            int[] Posición = new int[name.Length];
            

            EliminarEspacios(name, Posición[]);

        }
        }
    }

