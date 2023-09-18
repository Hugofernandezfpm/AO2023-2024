using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicial_de_mi_nombre_con_asteriscos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hugo"; //Para poner el titulo 
            Console.ForegroundColor = ConsoleColor.Red; //Para poder cambiar el color de la letra
            Console.WriteLine(   //Para que lea el texto y uso \n para que lea el salto de linea y el + para iterpretarlo
             " *         *\n" +
             " *         *\n" +
             " *         *\n" +
             " *         *\n" +
             " ***********\n" +
             " *         *\n" +
             " *         *\n" +
             " *         *\n" +
             " *         *");

            Console.ReadLine(); //Para poder ejecutar y leer el texto
        }
    }
}
