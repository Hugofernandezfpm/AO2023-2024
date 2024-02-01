using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernandez_Rodriguez_Hugo_Examen_Tema6
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
                    Console.Write("Ingrese el valor de n ");
                    int n = int.Parse(Console.ReadLine());


                    int[] arrayOriginal = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Ingrese el valor para la posición {i + 1}: ");
                        arrayOriginal[i] = int.Parse(Console.ReadLine());
                    }


                    int[] arrayCopia = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        arrayCopia[i] = arrayOriginal[i];
                    }

                    Console.WriteLine("Array original: " + arrayOriginal.Length);
                    Console.WriteLine("Array copia: " +  arrayCopia.Length);
                }

                if (ejercicio == 2)
                {
                    int[] miArray = { 23, 16, 70, 14, 30, 42, 17 };
                    int posicionMultiploSiete = -1;

                    for (int i = 0; i < miArray.Length; i++)
                    {
                        if (miArray[i] % 7 == 0)
                        {
                            posicionMultiploSiete = i;
                            break;  
                        }
                    }

                    if (posicionMultiploSiete != -1)
                    {
                        Console.WriteLine($"El primer múltiplo de 7 se encuentra en la posición {posicionMultiploSiete}.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún múltiplo de 7 en el array.");
                    }
                }

                if (ejercicio == 3)
                {
                    
                    Console.Write("Ingrese la longitud del array: ");
                    int longitud = int.Parse(Console.ReadLine());

                    
                    double[] miArray = new double[longitud];

                    
                    for (int i = 0; i < miArray.Length; i++)
                    {
                        Console.Write($"Ingrese el elemento {i + 1}: ");
                        miArray[i] = double.Parse(Console.ReadLine());
                    }

                    
                    Console.Write("Ingrese el valor");
                    double valor = double.Parse(Console.ReadLine());

                   
                    int contador = 0;

                   
                    for (int i = 0; i < miArray.Length; i++)
                    {
                        
                        if (miArray[i] > valor)
                        {
                            contador++;
                        }
                    }
                    Console.WriteLine($"La cantidad de valores por encima de {valor} en el array es: {contador}");
                }

                if (ejercicio == 4)
                {

                    int[] datos = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                    int media = 0;
                    int posiciones = 10;

                  
                    for (int i = datos.Length; i < datos.Length; i++)
                    {
                        
                        media = datos[i] / posiciones;
                    }

                    Console.Write("Desviación con respecto a la media: ");

                  

                    for (int i = 0;  i < datos.Length; i++)
                    {
                        int desvicación = media - datos[i];
                        Console.WriteLine("La desviación es de " + desvicación);
                        break;
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