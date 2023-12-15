using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace boletin2arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1:
            Console.WriteLine("********* EJERCICIO 1 *********");
            int[] a1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] a2 = new int[100]; // 1,2,3,4,5,6,7,8,9,10,... 100

            for (int i = 0; i < 100; i++)
            {
                a2[i] = i + 1;
            }
            //Visualizar los dos arrays
            for (int i = 0; i < a1.Length; i++)
            {
                Console.Write(a1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("a2: ");
            Console.WriteLine();
            Funciones.printArray(a2);
            Console.WriteLine();
            //Ejercicio 2: 
            Funciones.printEnunciado(2);
            float[] a3 = new float[20];

            Funciones.printArray(a3);


            //Ejercicio 3: 
            Funciones.printEnunciado(3);
            int[] a4 = new int[10];

            a4[0] = -1;
            a4[2] = -1;
            a4[5] = -1;
            a4[9] = -1;

            Funciones.printArray(a4);

            //Ejercicio 4:
            Funciones.printEnunciado(4);

            String[] libros = new string[50];

            libros[0] = "Los Pilares de la Tierra";
            libros[1] = "El archivo de las tormentas";
            libros[2] = "Los bolechas";
            libros[3] = "Los secretos de Youtube";
            libros[4] = "El clan del oso cavernario";

            /* for(int i = 0; i < libros.Length; i++)
             {
                 Console.WriteLine(libros[i] + " ");
             }
             Console.WriteLine();*/

            Funciones.printArray(libros);

            Funciones.printEnunciado(5);

            short[] a5 = new short[4];

            for (int i = 0; i < a5.Length; i++)
            {
                Console.WriteLine("Intro valor posicion. " + i);
                a5[i] = short.Parse(Console.ReadLine());
            }

            Funciones.printArray(a5);

            Funciones.printEnunciado(6);

            double[] a6 = new double[8];

            //Actualizar la última pos a -1
            a6[a6.Length - 1] = -1;

            for (int i = 0; i < a6.Length; i++)
            {
                Console.Write(a6[i] + " ");
            }

            Console.WriteLine();

            Funciones.printEnunciado(7);

            int n;
            Console.WriteLine("Intro número de elementos: ");
            n = int.Parse(Console.ReadLine());

            int[] a7 = new int[n];
            a7[0] = 10;
            a7[a7.Length - 1] = 9; //Última pos

            Funciones.printEnunciado(8);
            int[] a8 = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < a8.Length; i++)
            {
                a8[i] = rnd.Next(11);
            }

            Funciones.printArray(a8);

            Funciones.printEnunciado(12);

            int[] a12 = new int[50];

            Funciones.llenarArray(a12, -10, 10);
            Console.WriteLine("Matriz ejercicio 12: ");
            Funciones.printArray(a12);

            long suma = 0;
            for (int i = 0; i < a12.Length; i++)
            {
                suma = suma + a12[i];
            }

            Console.WriteLine("Suma: " + suma);


            Funciones.printEnunciado(16);
            int[] a16 = new int[50];

            //Llenar de úmeros aleatorios
            Random rnd2 = new Random();

            for (int i = 0; i < a16.Length; i++)
            {
                a16[i] = rnd2.Next(-100, 101);
            }

            int contadorNegativos = 0;
            for (int i = 0; i < a16.Length; i++)
            {
                if (a16[i] < 0)
                {
                    contadorNegativos++;
                }
            }

            Console.WriteLine("Números negativos: " + contadorNegativos);
            Funciones.printEnunciado(18);

            string[] a18 = new string[10];
            a18[0] = "RC Celta de Vigo";
            int contador18 = 0;
            for (int i = 0; i < a18.Length; i++)
            {
                if (a18[i] is null)
                {
                    contador18++;
                }
            }
            Console.WriteLine("Posiciones vacías: " + contador18);

            Funciones.printEnunciado(31);

            Funciones.printEnunciado(32);

            Random generador = new Random(); //sirve para generar numeros randoms
            int n1 = 10; //guarda numeros randoms entre los numeros que eliges en este caso etre 0 y 10
            double[] nota = new double[n1];
            double suma23 = 0;

            for (int i = 0; i < nota.Length; i++)
            {
                nota[i] = generador.NextDouble();
                suma23 = suma23 + nota[i];
            }

            double media = suma23 / 10;

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



            Funciones.printEnunciado(33);

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



            Funciones.printEnunciado(34);

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


            Funciones.printEnunciado(35);

            double[] arrayValores = { 3, 4, 5 };

            double sumaCuadrados = 0;
            for (int i = 0; i < arrayValores.Length; i++)
            {
                sumaCuadrados += arrayValores[i] * arrayValores[i];
            }

            double modulo = Math.Sqrt(sumaCuadrados);

            // Imprimir el resultado
            Console.Write("El módulo del array {");
            for (int i = 0; i < arrayValores.Length; i++)
            {
                Console.Write(arrayValores[i]);
                if (i < arrayValores.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine($" es: {modulo}");
        

            Funciones.printEnunciado(36);

            // Array de ejemplo
            int[] array = { 5, 2, -7, 8, -3, 1, 0 };

            // Variable para almacenar la posición del primer número negativo
            int posicionNegativo = -1;

            // Bucle for para encontrar la posición del primer número negativo
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    // Se encontró el primer número negativo, almacenar la posición y salir del bucle
                    posicionNegativo = i;
                    break;
                }
            }

            // Mostrar el resultado por pantalla
            if (posicionNegativo != -1)
            {
                Console.WriteLine("El primer número negativo es {0} y se encuentra en la posición {1}.", array[posicionNegativo], posicionNegativo);
            }
            else
            {
                Console.WriteLine("No se encontraron números negativos en el array.");
            }



            Console.ReadLine();
        }
    }
}
