using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

                Console.WriteLine("Introducir ejercicio: 5-25");
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio >= 5 && ejercicio <= 25)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Este ejercicio no existe");
                }


                //ejercicio 5 

                //Muestra los números del 320 al 160, contando de 20 en 20 utilizando un bucle while

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

                //ejercicio 6


                //Muestra los números múltiplos de 5 y 7 a la vez entre 0 y 100 utilizando un bucle for.

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

                //ejercicio 7

                //Muestra la tabla de multiplicar de un número introducido por teclado.

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

                //ejercicio 8

                //Escribe un programa que muestre en tres columnas,
                //el número, el cuadrado y el cubo de los 5 primeros números enteros a partir de uno que se
                //introduce por teclado.


                if (ejercicio == 8)
                {
                    int numero8;
                    Console.WriteLine("Introduce un numero ");
                    numero8 = int.Parse(Console.ReadLine());
                    
                    for (int j = numero8; j < numero8 + 5; j++)
                    {
                        Console.WriteLine(j + " " + Math.Pow(j, 2) + " " + Math.Pow(j, 3));
                    }
                }

                //ejercicio 9

                //

                if (ejercicio == 9)
                {

                }


                //ejercicio 10

                //Realizar un programa que calcule la suma de los m primeros números,
                //siendo m un número no negativo que es introducido POR TECLADO por el usuario.
                //El programa pedirá que el usuario introduzca un número hasta que un número positivo sea introducido,
                //si no repite el mensaje solicitando el dato.

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

                //Ejercicio 11

                //Calcular la suma de la serie 1/13 + 1/23 +... + 1/n3.
                //Donde n es un número positivo que se introduce por teclado.

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


                //ejercicio 12

                //Calcular la suma de los divisores de un número n  no negativo introducido por teclado.

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

                //ejercicio 13

                //Diseñar un programa que lea un número introducido por teclado y decida si ese número es perfecto. 
                //Un número es perfecto si es igual a la suma de sus divisores excepto el mismo.
                //Por ejemplo, el 6 es un número perfecto porque la suma de sus divisores da 1 + 2 + 3 = 6.

                if (ejercicio == 13)
                {
                    int n13 = 120;
                    int suma13 = 0;
                    for (int z = 1; z <= n13 / 2; z++)
                    {
                        if (n13 % z == 0)
                        {
                            suma13 = suma13 + z;
                        }
                    }

                    if (suma13 == n13)
                    {
                        Console.WriteLine("Número perfecto.");
                    }
                    else
                    {
                        Console.WriteLine("Numero no perfecto");
                    }
                }

                //ejercicio 14

                //Calcular la suma de los n primeros números que sean múltiplos de 5,
                //siendo n un número no negativo introducido por teclado.


                if (ejercicio == 14)
                {
                    Console.Write("Introduce un número no negativo (n): ");

                    // Leer el valor de n desde el teclado
                    int n = int.Parse(Console.ReadLine());

                    if (n >= 0)
                    {
                        // Inicializar la variable para almacenar la suma
                        int suma = 0;

                        // Bucle for para encontrar los primeros n múltiplos de 5 y sumarlos
                        for (int i = 1; i <= n; i++)
                        {
                            if(n % 5 == 0)
                            {
                            int multiploDe5 = n;
                            suma = multiploDe5;
                            }
                        }

                        // Mostrar la suma
                        Console.WriteLine($"La suma de los primeros números múltiplos de 5 es: {suma}");
                    }
                    else
                    {
                        Console.WriteLine("Por favor, introduce un número no negativo.");
                    }
                }

                // ejercicio 15

                //Diseñar un programa que calcule el factorial de un número introducido por teclado.
                //Ayuda: El factorial de un número n  es: n * (n - 1) * (n - 2)…*1
                //Por ejemplo el factorial de 4 es: 4 * 3 * 2 * 1


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

                //ejercicio 16

                //Diseñar un programa que cuente cuántos números múltiplos de 3 hay por debajo de un número
                //n dado por teclado por el usuario.


                if (ejercicio == 16)
                {
                    Console.Write("Ingrese un número: ");
                    int numeroUsuario = int.Parse(Console.ReadLine());

                    int contador = 0;

                    for (int i = 1; i < numeroUsuario; i++)
                    {
                        if (i % 3 == 0)
                        {
                            contador++;
                        }
                    }

                    Console.WriteLine($"Hay {contador} números múltiplos de 3 por debajo de {numeroUsuario}.");
                }


                // ejercicio 17

                //Diseñar un programa que cuente los divisores de un número n introducido por teclado.


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

                // ejercicio 18

                //Diseñar un programa que lea un número positivo  y nos diga si ese número es primo o no. 
               //Utilizar para resolverlo un bucle for.  Nota:
               //Un número es primo si solamente es divisible entre 1 y sí mismo.
               //Si el número introducido es negativo o cero el programa debe volver a pedir al usuario que
               //introduzca un número positivo.



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


                //ejercicio 19

                //Diseñar un programa que detecte (muestre por pantalla)
                //el primer número que sea múltiplo de 3,5 y 7 en un intervalo de dos
                //números n y m solicitados por teclado.


                if (ejercicio == 19)
                {
                    int x = 100;
                    int y = 1000;

                    for(int i = x; i <= y; i++)
                    {
                        if(i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                        {
                            Console.WriteLine(" Multiplos de 3, 5 y 7 " + i);
                        }
                    }
                }

                //ejercicio 21

                //Mostrar la tabla de multiplicar de los 10 primeros números.


                if (ejercicio == 21) 
                {
                    int i = 1;
                    while (i <= 10)
                    {
                        Console.WriteLine("Tablas de multplicar de " + i);
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.WriteLine(i + " * " + j + " = " + 1 * j);
                        }
                        Console.WriteLine();
                        i++;
                    }     
                }


                //ejercicio 22







                if (ejercicio == 22)
                {
                    int filas = 8;
                    int asteriscos = filas;
                    for (int i = 1; i <= filas; i++)
                    {
                        for(int j = 1;j <= asteriscos; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                        asteriscos--;
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
