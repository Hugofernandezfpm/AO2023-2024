using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comprobaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 3;

            if (9 % i == 0)
            {
                i += 10;

                Console.WriteLine("HOLA");
            }

            else
            {
                i -= 10;

                Console.WriteLine("ADIOS");
            }
            Console.ReadLine();
        }
    }
}
