using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio25boletin5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            for(int i = 0; i < 10; i++)
            {
                int numero = aleatorio.Next(10,24);
                Console.WriteLine(numero + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
