using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fernandez_rodriguez_hugo_examen3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double continuar;
            do
            {
                int ejercicio = 0;

                Console.WriteLine("Introducir ejercicio: 1-4");
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio >= 1 && ejercicio <= 4)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Este ejercicio no existe");
                }

                if (ejercicio == 1)
                {
                    int num1 = 500;
                    while (num1 >= 100)
                    {
                        Console.Write(num1);
                        if (num1 > 100)
                        Console.Write(",");
                        num1 -= 100;
                    }

                    Console.WriteLine();  

                    int num2 = 13;
                    while (num2 <= 25)
                    {
                        Console.Write(num2);
                        if (num2 < 25)
                        Console.Write(",");
                        num2 += 2;
                    }
                }

                if (ejercicio == 2)
                {
                    int n;
                    int m;

                    Console.Write("Ingrese el valor de n: ");
                    n = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el valor de m: ");
                    m = int.Parse(Console.ReadLine());

                    for (int i = n; i <= m; i++)
                    {
                        if (i % 2 == 0 && i % 11 == 0)
                        {
                            Console.WriteLine(i);
                            
                        }
                    }
                }  
               

                if (ejercicio == 3)
                {
                    Console.Write("Ingrese un valor para n: ");
                    int n = int.Parse(Console.ReadLine());

                    double suma = 0;
                    for (int i = 10; i <= n; i += 2)
                    {
                        suma += (Math.Pow(i, 3) + 1) / 2;
                    }

                    Console.WriteLine($"La suma es: {suma}");
                }
                if (ejercicio == 4)
                {
                    double numero;
                    Boolean primo = true;
                    Console.WriteLine("introduce un numero");
                    numero = double.Parse(Console.ReadLine());

                    for (int i = 2; i <= numero / 2; i++)
                    {
                        if (numero % i == 0)
                        {
                            primo = false;
                        }
                    }
                    if (primo)
                    {
                        Console.WriteLine("Es primo");
                    }
                    else
                    {
                        Console.WriteLine("No es primo");
                    }
                }

                Console.ReadLine();
                Console.WriteLine("quiere volver al menu : s-> si/ n-> no");
                continuar = Console.ReadKey().KeyChar;
            }
            while (continuar == 's');
            
            
            Console.ReadLine();

        }
    }
}
