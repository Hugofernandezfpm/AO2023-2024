using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7boletin3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            Console.WriteLine("Introduce grados celsius: ");
            celsius = double.Parse(Console.ReadLine());  //tambien se puede hacer con Convert.ToDouble

            fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine("Grados Fahrenheit: " + fahrenheit);
            Console.ReadLine();
        }
    }
}
