using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2boletin5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explicacion Bucles Anidados: 10 filas de 10 asteriscos

            /* for (int i = 0; i < 10; i++)
             {

                 for (int j = 0; j < 10; j++)
                 {
                     Console.Write(" * ");
                 }
                 Console.WriteLine();
             }

             Console.ReadLine();*/

            int i = 0;
            while (i < 10)
            {
                int j = 0;
                while (j < 10)
                {
                    Console.Write(" * ");
                    j++;
                }
                Console.WriteLine();
                i--;
            }
            Console.ReadLine();
        }
    }
}
