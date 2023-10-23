using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentenciaswitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcion; //es un menu
            char continuar; 

            do { // lo del do no entra
                Console.WriteLine("Escoge una opción");
                Console.WriteLine("a) Saludar");
                Console.WriteLine("b) Animar ");
                Console.WriteLine("c) Despedir ");
                opcion = char.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 'a':
                        Console.WriteLine("Hola !!!");
                        break;
                    case 'b':
                        Console.WriteLine("Vamossss !!!");
                        break;

                    case 'c':
                        Console.WriteLine("Hasta la proxima!!!");
                        break;
                    default:
                        Console.WriteLine("Te has equivocado");
                        break; //opcional

                        Console.ReadLine();


                }//llave de cierre de switch
                Console.WriteLine("quiere volver al menu : s-> si/ n-> no");
                // continuar = char.Parse(Console.ReadLine());
                continuar = Console.ReadKey().KeyChar; // co esto no hace falta dale a enter co que le des a la "s" por ejemplo se ejecuta solo

            }//llave de cierre de do
            while (continuar == 's');
                
            //Lo de do while y eso no va a entrar solo es a mayores
        }
    }
}
