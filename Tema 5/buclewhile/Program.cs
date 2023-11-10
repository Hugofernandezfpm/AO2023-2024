using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclewhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa que muestra por pantalla los numeros entre el 100 y el 150

            int i = 100; //Inicializando la variable de control

            while (i <= 150)
            {
                Console.Write(i + " ");
                //SUmandole 1 a la i
                i++; //Lo mismo que escribir i = i + 1 sirven de las dos formas
            }
            Console.WriteLine();

            Console.WriteLine("Numeros impares entre 100 y 150");

            //Resetear la variable i

            i = 101;

            while (i < 150)
            {
                Console.Write(i + " "); //siempre se pone este espacio para que no aparezcan los numeros todos juntos
                i += 2;
            }

            //Mostrar todos los numeros pero los pares en rojo y los impares en blanco"

            i= 100; //Para reiniciar i
            Console.WriteLine();
            Console.WriteLine("Rojo y Blanco");
            while (i <= 150)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(i + " ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(i + " ");
                }
                i++;
            }

            //Mostrar los valores entre n y m , cambiando de color cada 10 valores


            int n = 25;
            int m = 120;
            int contador = 0;

            i = n; //Inicializo la variable de cotrol
            Console.WriteLine();
            Console.WriteLine(" Valores entre " + n + " y " + m);
            while (i <= m)
            {
                if(contador == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    
                }
                else if(contador == 20)
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                }
                Console.WriteLine(i + " ");
                i = i + 1;
                contador++;
            }






            
            
            Console.ReadLine();
        }
    }
}
