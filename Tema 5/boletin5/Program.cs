using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boletin5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double continuar;

            do
            {



                int ejercicio = 0;

                Console.WriteLine("Introducir ejercicio: 5-9");
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio >= 5 && ejercicio <= 9)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Este ejercicio no existe");
                }

                if (ejercicio == 5)
                {
                    int numero = 320;

                    while (numero >= 160)
                    {
                        Console.WriteLine(numero + " ");
                        numero -= 20;
                        //numero = numero - 20 //Sirve de las dos formas
                    }
                }

                if (ejercicio == 6)
                {
                    for (int numero = 0; numero <= 100; numero++)
                    {
                        if (numero % 5 == 0 && numero % 7 == 0)
                        {
                            Console.WriteLine(numero + " ");
                        }
                    }
                }

                if (ejercicio == 7)
                {
                    Console.WriteLine("Introduce el numero para mostrar su tabla de multiplicar: ");
                    double numero = double.Parse(Console.ReadLine());

                    for (int i = 1; i <= 10; i++)
                    {
                        double resultado = numero * i;
                        Console.WriteLine(numero + " x " + i + " = " + resultado);
                    }

                }

                if (ejercicio == 8)
                {

                }

                if (ejercicio == 9)
                {

                }

                if (ejercicio == 10)
                {
                    
                }

                if (ejercicio == 11)
                {

                }

                if (ejercicio == 12)
                {

                }

                Console.WriteLine("quiere volver al menu : s-> si/ n-> no");
                continuar = Console.ReadKey().KeyChar;
            }
            while (continuar == 's');
        }
    }
}
