using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_con_Arrays
{


    class Program
    {
       
        public List<string> Alimentos = new List<string>();

        void Lista(List<string> Al)
        {
            Al.Add("Huevo");
            Al.Add("Leche");
            Al.Add("Pollo");

        }
        
    
        static void Main(string[] args)
        {

            int n = 0,contenedor=10^6, cont = 0; ;
            
            Console.WriteLine("Digite la cantidad de números que quiere comparar");
            
            n = Convert.ToInt32(Console.ReadLine()); 
          
           
 
       
            int[] numeros = new int[n];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite un número N[{i}] ");
                int num = Convert.ToInt32(Console.ReadLine());
                numeros[i] = num;
            }

            for (int j = 0; j < numeros.Length; j++)
            {
                if (contenedor > numeros[j])
                {
                    contenedor = numeros[j];
                }
            }

            for (int k = 0; k < numeros.Length; k++)
            {
                if (contenedor == numeros[k])
                {
                    cont += 1;
                }
            }
            Console.WriteLine($"El número menor es: {contenedor}");

            if (cont >1)
            { Console.WriteLine("El número menor se repite"); }
        }




    }
}

