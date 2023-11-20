using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boletin5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double continuar;

            do
            {



                int ejercicio = 0;

                Console.WriteLine("Introducir ejercicio: 5-20");
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio >= 5 && ejercicio <= 20)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Este ejercicio no existe");
                }

                if (ejercicio == 5)
                {
                    int numero = 320;

                    while (numero >= 160)
                    {
                        Console.WriteLine(numero + " ");
                        numero -= 20;
                        //numero = numero - 20 //Sirve de las dos formas
                    }
                }

                if (ejercicio == 6)
                {
                    for (int numero = 0; numero <= 100; numero++)
                    {
                        if (numero % 5 == 0 && numero % 7 == 0)
                        {
                            Console.WriteLine(numero + " ");
                        }
                    }
                }

                if (ejercicio == 7)
                {
                    Console.WriteLine("Introduce el numero para mostrar su tabla de multiplicar: ");
                    double numero = double.Parse(Console.ReadLine());

                    for (int i = 1; i <= 10; i++)
                    {
                        double resultado = numero * i;
                        Console.WriteLine(numero + " x " + i + " = " + resultado);
                    }

                }

                if (ejercicio == 8)
                {
                    int numero8;
                    Console.WriteLine("Introduce un numero ");
                    numero8 = int.Parse(Console.ReadLine());
                    int j = numero8;
                    for (; j < numero8 + 5; j++)
                    {
                        Console.WriteLine(j + " " + Math.Pow(j, 2) + " " + Math.Pow(j, 3));
                    }
                }

                if (ejercicio == 9)
                {

                }

                if (ejercicio == 10)
                {
                    int m = -1;
                    int suma = 0;
                    int contador = 0;
                    int i = 0;

                    do
                    {
                        if (contador == 0)
                        {
                            Console.WriteLine("Introduzca un numero positivo: ");
                            m = int.Parse(Console.ReadLine());
                        }
                       else if (contador == 1)
                        {
                            Console.WriteLine("Por favor introduzca un numero positivo");
                            m = int.Parse(Console.ReadLine());
                        }
                        else if (contador == 2)
                        {
                            Console.WriteLine("Introduce un numero positivo. PRIMER AVISO");
                            m = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Dejalo, esto no es lo tuyo");
                        }

                        contador++;
                    }
                    while (m < 0 && contador <= 3);

                    for (i = 1; i <= m; i++)
                    {
                        suma = suma + i;
                        Console.WriteLine("la suma es: " + suma);
                    }
                    
                }

                if (ejercicio == 11)
                {
                    // Solicitar al usuario que ingrese el valor de n
                    Console.Write("Ingrese un número positivo n: ");
                    int n = int.Parse(Console.ReadLine());

                    // Inicializar la suma
                    double suma = 0;

                    // Calcular la suma de la serie
                    for (int i = 1; i <= n; i++)
                    {
                        suma += 1.0 / Math.Pow(i, 3);
                    }

                   
                    Console.WriteLine($"La suma de la serie hasta 1/{n}^3 es: {suma}");
                
            }

                if (ejercicio == 12) // va a caer uno parecido al 12 en el examen
                {
                    // Asignar un valor directamente a la variable numero

                    Console.WriteLine(" Introduzca el numero ");
                    double numero;
                    numero = double.Parse(Console.ReadLine());
                    


                    // Calcular la suma de los divisores y mostrar el resultado
                    int resultado = 0;
                    for (int i = 1; i <= numero; i++) 
                        {
                        if (numero % i == 0)
                        {
                            resultado += i;
                        }
                        }
                        Console.WriteLine($"La suma de los divisores de {numero} es: {resultado}");
                    
                   
                }

                if (ejercicio == 12) //Es el 12 de otra manera
                {
                    int n12 = 0;
                    int sumaDivisores = 0;

                    do
                    {
                        Console.WriteLine("Introduce numero mayor que cero");
                        n12 = int.Parse(Console.ReadLine());
                    }
                    while (n12 <= 0);

                    for (int i = 1; i <= n12; i++)
                    {
                        if (n12 % 12 == 0)
                        {
                            sumaDivisores = sumaDivisores + i;
                        }
                    }
                    Console.WriteLine("La suma de sus divisores es " + sumaDivisores);
                         
                }

                if (ejercicio == 13)
                {

                }

                if (ejercicio == 14)
                {

                }

                if (ejercicio == 15)
                {
                    int i;
                    int numero15;
                    long factorial = 1;
                    Console.WriteLine("Introduce un número: ");
                    numero15 = int.Parse(Console.ReadLine());

                    for (i = numero15; i >= 1; i--)
                    {
                        factorial = factorial * i;
                    }
                    Console.WriteLine($"El factorial de " + numero15 +  " es " + factorial);
                }

                if(ejercicio == 16)
                {

                }
                

                if (ejercicio == 17)
                {
                    int numero17;
                    int contadordivisores = 0;
                    int i = 0;

                    Console.WriteLine("Introduce numero");
                    numero17 = int.Parse(Console.ReadLine());

                    for (i = 2; i <= numero17/2; i++)
                    {
                        if(numero17 % i == 0)
                        {
                            contadordivisores++;
                        }
                    }
                    Console.WriteLine("Los divisores de " + numero17 + " son " + contadordivisores);
                    
                }

                

                if (ejercicio == 18)
                {
                   
                    double numero18;
                    Boolean primo = true;
                    Console.WriteLine("introduce un numero");
                    numero18 = double.Parse(Console.ReadLine());

                    for(int i = 2; i <= numero18 / 2; i++)
                    {
                        if (numero18 % i == 0)
                        {
                            primo = false;
                        }
                    }
                    if(primo)
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
        }
    }
}
