using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fernandezrodriguezhugo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor, ingresa un valor entero: ");
            int valorEntero = int.Parse(Console.ReadLine());

            double raizCuadrada = Math.Sqrt(valorEntero);
            double raizCuadradaRedondeada = Math.Round(raizCuadrada, 2);

            Console.WriteLine("La raíz cuadrada de valorEntero:" + valorEntero + "con precisión de dos decimales es:" + raizCuadradaRedondeada);

            double valoralaSexta = Math.Pow(valorEntero, 6);

            Console.WriteLine("El valor a la sexta es:" + valoralaSexta);
            Console.ReadLine();

        }
    }
}
