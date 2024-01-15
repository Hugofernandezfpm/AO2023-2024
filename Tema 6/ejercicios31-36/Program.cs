using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios31_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double continuar;

            do
            {
                int ejercicio = 0;

                Console.WriteLine("Introducir ejercicio: 31-36");
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio >= 31 && ejercicio <= 36)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Este ejercicio no existe");
                }

                if (ejercicio == 31)
                {
                    int[] numerosNegativos = new int[10];
                    Random rnd = new Random();

                    for (int i = 0; i < numerosNegativos.Length; i++)
                    {
                        numerosNegativos[i] = rnd.Next(-10,0);
                    }
                    
                    Random rnd2 = new Random();

                    for (int i = 0; i < 5; i++)
                    {
                        numerosNegativos[i] = rnd2.Next(0, 100);
                    }

                    for (int i = numerosNegativos.Length -6; i < numerosNegativos.Length; i++)
                    {
                        numerosNegativos[i] = rnd2.Next(0, 100);
                    }

                    Console.WriteLine(" el valor de la primera posicion es " + numerosNegativos[0] + " el valor de la ultima posicion es " + numerosNegativos[numerosNegativos.Length-1]);

                    int[] numerosNegativosCopia = new int[10];
                    for (int i  = 0; i < numerosNegativos.Length; i++)
                    {
                        numerosNegativosCopia[i] = numerosNegativos[i];
                    }

                    Array.Sort(numerosNegativosCopia);

                    double suma = 0;

                    for (int i = 0; i < numerosNegativos.Length; i++)
                    {
                        suma = suma + numerosNegativos[i]; //asi suma todas las posiciones una a una sumandolas entre si
                    }

                    for (int i = 0; i < numerosNegativos.Length; i++)
                    {
                      numerosNegativosCopia[i] =  numerosNegativosCopia[i] + 10;
                    }

                    double media = 0;
                    double media2 = 0;

                    for (int i = 0;i < numerosNegativos.Length; i++)
                    {
                        media = media + numerosNegativos[i];
                        media2= media2 + numerosNegativosCopia[i];
                    }

                    for (int i = 0;i <numerosNegativosCopia.Length; i++)
                    {
                        if (media < numerosNegativos[i])
                        {
                            numerosNegativos[i] = 0;
                        }
                        if (media2 < numerosNegativosCopia[i])
                        {
                            numerosNegativosCopia[i] = 0;
                        }
                    }

                    Console.WriteLine("Introduzca un numero: ");
                    double numero = double.Parse(Console.ReadLine());

                    for (int i = 0; i < numerosNegativos.Length ; i++)
                    {
                        if (numerosNegativos[i] == numero)
                        {
                            Console.WriteLine("La posicion que ocupa es " + i);
                            break;
                        }
                        if (numerosNegativosCopia[i] == numero)
                        {
                            Console.WriteLine("La posicion que ocupa es " + i);
                            break;
                        }
                        if (i == numerosNegativos.Length -1)
                        {
                            Console.WriteLine("No se a podido encontar el numero");
                        }
                    }
                }

                if (ejercicio == 32)
                {
                    Random generador = new Random(); //sirve para generar numeros randoms
                    int n1 = 10; //guarda numeros randoms entre los numeros que eliges en este caso etre 0 y 10
                    double[] nota = new double[n1];
                    double suma23 = 0;

                    for (int i = 0; i < nota.Length; i++)
                    {
                        nota[i] = generador.NextDouble();
                        suma23 = suma23 + nota[i];
                    }

                    double media = suma23;

                    if (media < 5)
                    {
                        Console.WriteLine("Suspenso");
                    }

                    else if (media < 7)
                    {
                        Console.WriteLine("Aprobado");
                    }

                    else if (media < 9)
                    {
                        Console.WriteLine("Notable");
                    }

                    else if (media <= 10)
                    {
                        Console.WriteLine("Sobresaliente");
                    }

                    else
                    {
                        Console.WriteLine("Error");
                    }
                }

                if (ejercicio == 33)
                {
                    // Array de enteros
                    int[] arrayEnteros3 = { 1, 2, 3, 4, 5 };

                    // Calcular la media
                    double media22 = 0;
                    for (int i = 0; i < arrayEnteros3.Length; i++)
                    {
                        media22 += arrayEnteros3[i];
                    }
                    media22 /= arrayEnteros3.Length;

                    // Calcular desviación con respecto a la media y mostrar los resultados
                    for (int i = 0; i < arrayEnteros3.Length; i++)
                    {
                        double desviacion = arrayEnteros3[i] - media22;
                        Console.WriteLine($"Elemento {i + 1}: {arrayEnteros3[i]}, Desviación: {desviacion}");
                    }
                }

                if (ejercicio == 34)
                {
                    // Declarar dos arrays de 5 elementos
                    int[] array1 = new int[5];
                    int[] array2 = new int[5];

                    // Pedir datos del primer array por teclado al usuario
                    Console.WriteLine("Introduce los elementos del primer array:");
                    for (int i = 0; i < array1.Length; i++)
                    {
                        Console.Write($"Elemento {i + 1}: ");
                        array1[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    // Dar valores al segundo array
                    for (int i = 0; i < array2.Length; i++)
                    {
                        array2[i] = array1[i] + 10;
                    }

                    // Mostrar ambos arrays por pantalla
                    Console.WriteLine(" Primer array: ");
                    for (int i = 0; i < array1.Length; i++)
                    {
                        Console.Write(array1[i] + " ");

                    }
                    Console.WriteLine();
                    Console.WriteLine(" Segundo array: ");
                    for (int i = 0; i < array2.Length; i++)
                    {
                        Console.Write(array2[i] + " ");
                    }
                }

                if (ejercicio == 35)
                {
                    double[] arrayValores = { 3, 4, 5 };

                    double sumaCuadrados = 0;
                    for (int i = 0; i < arrayValores.Length; i++)
                    {
                        sumaCuadrados += arrayValores[i] * arrayValores[i];
                    }

                    double modulo = Math.Sqrt(sumaCuadrados);

                    // Imprimir el resultado
                    Console.Write("El módulo del array ");
                    for (int i = 0; i < arrayValores.Length; i++)
                    {
                        Console.Write(arrayValores[i]);
                        if (i < arrayValores.Length - 1)
                            Console.Write(", ");
                    }
                    Console.WriteLine($" es: {modulo}");
                }

                if (ejercicio == 36)
                {
                    // Array de ejemplo
                    int[] array = { 5, 2, -7, 8, -3, 1, 0 };

                   

                    // Bucle for para encontrar la posición del primer número negativo
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] < 0)
                        {
                          
                          Console.WriteLine("El primer numero negativo es:" + array[i] + "se encuentra en la posición:" + i );
                            break;
                        }
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
