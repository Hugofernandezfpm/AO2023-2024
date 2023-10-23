using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenecho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("introduce el numero = ");
            numero = int.Parse(Console.ReadLine()); 

            //apartado a

        double raiz = Math.Sqrt(numero);
            raiz = Math.Round(raiz, 2);

            //apartado b

            double potencia = Math.Pow(numero, 6);

            //apartado c 

            short copia = (short)numero;

            //apartado d

            float porcentaje = numero * 0.2f;

            //apartado e

            
            numero = (int)(numero + 0.35f * numero);

            Console.WriteLine("apartado a" + numero + raiz);
            Console.WriteLine("apartado b" + numero + potencia);
            Console.WriteLine("apartado c" + numero + copia);
            Console.WriteLine("apartado d" + numero + porcentaje);
            Console.WriteLine("apartado e" + numero + numero);

            Console.ReadLine();
        }
    }
}
