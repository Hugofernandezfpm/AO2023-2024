using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4boletin3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe valor de radio:"); //Para que te pida que escribas el valor de radio
            double radio  = double.Parse(Console.ReadLine()); //Para que tu mismo le des el valor a radio
            double longitud, area, volumen, PI; 
            PI = Math.PI;
           longitud = 2 * PI * radio;
            area = PI * radio * radio;
            volumen = (4f / 3) * PI * radio * radio * radio; //hay q ponerle la f para que cuente todos los decimales

            
            Console.WriteLine("Longitud =" + longitud);
            Console.WriteLine("area =" + area);
            Console.WriteLine("volumen =" + volumen);
            Console.ReadLine();
        }
    }
}
