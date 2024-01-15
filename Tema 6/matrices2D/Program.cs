using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double continuar;

            do
            {
                int ejercicio = 0;

                Console.WriteLine("Introducir ejercicio: 1-47");
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio >= 1 && ejercicio <= 47)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Este ejercicio no existe");
                }

                if (ejercicio == 44)
                {

                    int[,] m = new int[3, 3];
                    m[0, 0] = 1;
                    m[0, 1] = 2;
                    m[1, 0] = 3;
                    m[1, 1] = 4;
                    m[0, 2] = 5;
                    m[1, 2] = 6;
                    m[2, 2] = 7;
                    m[2, 1] = 8;
                    m[2, 0] = 9;

                    Console.Write("Escoge una fila");
                    int i = int.Parse(Console.ReadLine());


                    for (int j = 0; j < m.GetLength(1); j++)
                    {
                        Console.Write(m[i, j] + " ");
                    }
                    Console.WriteLine();
                    for (int j = 0; j < m.GetLength(1); j++)
                    {
                        m[2, j] = 0;
                        Console.Write(m[2, j] + " ");
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
