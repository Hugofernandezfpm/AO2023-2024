﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referenciaifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que clasifica um mumeor como par o impar

            int numero = 11;

            if (numero % 2 == 0) 
            {
                Console.WriteLine(numero + " es par , ");
            }
            else
            {
                Console.WriteLine(numero + " es impar, ");
            }

            //Progrma que indica si un numero es cero o distinto de cero

            int numero2 = 3

            if (numero2! 0)
            {
                Console.WriteLine(numero2 + " es distinto de 0");
            }
            else
            {
                Console.WriteLine(numero2 + " es igual a 0");
            }


            //Programa que clasifica un numero como multiplo de 3 o no

            int numero3 = 15;

            if(numero3 % 3 == 0);
            {
                Console.WriteLine(numero3 + "Es multiplo de 3");
            }
            else
            {
                Console.WriteLine(numero3 + "no es multiplo de 3 ");
            }

            //Programa que a partir del salario bruto de un trabajador aplica
            //un irpf del 15% si el salario <= 1200€ y u irpf del 19 si es superior


            double salario , salarioNeto;

            Console.WriteLine("Introduzca eñ salario bruto: ");
            salario = double.Parse(Console.ReadLine());

            if(salario <= 1200)
            {
                salarioNeto = salario - salario * 0.19;
            }

            Console.WriteLine("Salario neto:" + salarioNeto);
        }

    }
}
