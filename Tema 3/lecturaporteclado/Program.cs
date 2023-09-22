using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lecturaporteclado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que solicita al usuario DNI y Edad y salario
            String dni;
            byte edad;
            float salario;
            
            Console.WriteLine("Introduce el DNI: ");
            dni = Console.ReadLine();

            Console.WriteLine("Introduce su edad: ");
            edad = byte.Parse(Console.ReadLine());   //saber por que tengo q poner un parse y por que puede fallar

            Console.WriteLine("Introduce su salario ");
            salario = float.Parse(Console.ReadLine());

           
            Console.WriteLine("DNI:" + dni);
            Console.WriteLine("Edad: " + edad);
            Console.ReadLine();


        }
    }
}
