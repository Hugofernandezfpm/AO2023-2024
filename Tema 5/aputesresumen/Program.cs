using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aputesresumen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double continuar;

            do
            {
                int ejercicio = 0;

                Console.WriteLine("Introducir ejercicio: 1-3");
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio >= 1 && ejercicio <= 3)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Este ejercicio no existe");
                }

                if (ejercicio == 1)
                {
                    for (int i = 1; i <= 7; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    for (int i = 7; i >= 1; i--) //(int i=1; i <=7; i++) 
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                }
               
                




                Console.ReadLine();
                Console.WriteLine("quiere volver al menu : s-> si/ n-> no");
                continuar = Console.ReadKey().KeyChar;
            }
            while (continuar == 's');
        }
    }
}
