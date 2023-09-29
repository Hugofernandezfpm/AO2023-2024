using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5boletin3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el precio: ");
            double precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la cantidad : ");
            short cantidad = short.Parse(Console.ReadLine());
            double importefinal;
                importefinal = precio * cantidad;

            Console.WriteLine("El importe es: " + importefinal);
            Console.WriteLine("El precio del producto es: " + precio, "euros y la cantidad que compra es: " + cantidad, "y por lo tanto debe pagar: " + importefinal, "euros.Vuelva pronto ");
            Console.ReadLine();
        }
    }
}
