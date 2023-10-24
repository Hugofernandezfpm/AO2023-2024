using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de litros gastados en un mes: ");
            int litros = int.Parse(Console.ReadLine());

            double pago = 0;

            if (litros <= 50)
            {
                pago = 0;
            }
            else if (litros <= 200)
            {
                pago = (litros - 50) * 4.75;
            }
            else
            {
                pago = (litros - 200) * 20 + 150 * 4.75;
            }

            if (pago < 45)
            {
                pago = 45; // Cuota mínima de 45 euros
            }

            Console.WriteLine($"El gasto de agua es de  " + pago);
            Console.ReadLine();
        }
    
    }
}
