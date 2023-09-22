using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tipos_de_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            byte n1;
            //Inicializar variable
            n1 = 10;
            byte n2 = n1;

            //Declarar varias variables en la misma linea
            short num1, num2, num3;
            num1 = 9;
            num2 = 10;
            num3 = 5;

            //Modificar el valor que hay guardado en una variable
            int x1 = 10;
            //Incremwntar en uno el valor de x1
            x1 = x1 + 1;
            Console.WriteLine("x1 =" + x1);

            //Por ejemplo: Sumar 1 a la variable num1 de tipo short
            num1 = (short)(num1 * 1); //Conversion de int a short
           

            //Variables con númerros decimales
            double temperatura = 25.6;
            //Aumentar la temperatura en 10 grados
            temperatura = temperatura + 10;
            Console.WriteLine("Temperatura : " + temperatura);

            //Programa que a partir de la base y la altura, calcula el area de un triangulo
            double baseTriangulo, altura, area;
            baseTriangulo = 9;
            altura = 8.5;
            
            area = (baseTriangulo * altura) / 2;

            Console.WriteLine("base * altura = " + area);

            Console.ReadLine();
           
        }
    }
}
