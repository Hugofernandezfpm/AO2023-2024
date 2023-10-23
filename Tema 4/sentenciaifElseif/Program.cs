using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentenciaifElseif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que clasifica un número como negativo, cero o positivo
            int numero = 900;

            if (numero < 0)
            {
                Console.WriteLine("Numero negativo. ");
            }
            else if (numero == 0)
            {
                Console.WriteLine("Número es cero.");
            }
            else
            {
                Console.WriteLine("Numero positivo. ");
            }

            //Programa que clasifica un numero como multiplo de 3 y de 5 o de uno de los dos

            int numero1 = 25;
            if (numero1 % 3 == 0 && numero1 % 5 == 0)
            {
                Console.WriteLine("Es mutiplo de ambos");
            }
            else if (numero1 % 3 == 0)  // una vez usado if el resto es else if pero solaamente se añade if si vas a añadir datos

            {
                Console.WriteLine("Es multiplo de 3");
            }
            else if (numero1 % 5 == 0)
            {
                Console.WriteLine("Es multiplo de 5");
            }
            else // se usa else solo cuando no se añade nada
            {
                Console.WriteLine("No es multiplo de ninguno");
            }
            Console.ReadLine();


            //
            //
            //
            //

            Boolean examenesAprobados = true;
            Boolean tareasAprobadas = true;
            Boolean comportamientoCorrecto = true;

            if (examenesAprobados && tareasAprobadas && comportamientoCorrecto)

            {
                Console.WriteLine("Enhorabuena has aprobado");
            }
            else if (!examenesAprobados)
            {
                Console.WriteLine("Examenes suspensos");
            }
            else if (!tareasAprobadas)
            {
                Console.WriteLine("Tareas suspensas");
            }
            else if (!comportamientoCorrecto)
            {
                Console.WriteLine("Comportamiento suspenso");
            }

            Console.ReadLine();
        }
    }
}
