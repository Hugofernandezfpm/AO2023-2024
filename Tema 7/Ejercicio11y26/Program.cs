using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11y26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double continuar;

            do
            {
                int ejercicio = 0;

                Console.WriteLine("Introducir ejercicio: 11 o 26");
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio == 11 || ejercicio == 26)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Este ejercicio no existe");
                }

                if (ejercicio == 11)
                {
                    string[] palabras = { "clase", "programacion", "ahorcado", "juego", "codigo", "video", "ordenador" };

                    Console.WriteLine("¡Bienvenido al Juego del Ahorcado!");

                    do
                    {
                        string palabraSecreta = palabras[new Random().Next(palabras.Length)];
                        char[] palabraAdivinada = new char[palabraSecreta.Length * 2 - 1];

                        // Inicializar la palabra adivinada con guiones bajos y espacios en blanco
                        for (int i = 0; i < palabraAdivinada.Length; i += 2)
                        {
                            palabraAdivinada[i] = '_';
                            if (i + 1 < palabraAdivinada.Length)
                            {
                                palabraAdivinada[i + 1] = ' ';
                            }
                        }

                        int intentos = 0;

                        while (intentos < 6 && palabraAdivinada.Contains('_'))
                        {
                            Console.WriteLine("\nPalabra actual: " + new string(palabraAdivinada));
                            Console.WriteLine("Intentos restantes: " + (6 - intentos));

                            Console.Write("Ingresa una letra o intenta adivinar la palabra: ");
                            string entrada = Console.ReadLine().ToLower();

                            if (entrada.Length == 1)
                            {
                                // Intento de adivinar una letra
                                char letra = entrada[0];

                                if (palabraSecreta.Contains(letra))
                                {
                                    // La letra está en la palabra secreta
                                    for (int i = 0; i < palabraSecreta.Length; i++)
                                    {
                                        if (palabraSecreta[i] == letra)
                                        {
                                            palabraAdivinada[i * 2] = letra;
                                        }
                                    }

                                    if (!palabraAdivinada.Contains('_'))
                                    {
                                        Console.WriteLine("¡Felicidades, has adivinado la palabra!");
                                        break;
                                    }
                                }
                                else
                                {
                                    // La letra no está en la palabra secreta
                                    intentos++;
                                    Console.WriteLine($"Incorrecto. Te quedan {6 - intentos} intentos.");
                                }
                            }
                            else if (entrada.Length == palabraSecreta.Length && entrada == palabraSecreta)
                            {
                                // Intento de adivinar la palabra completa
                                Console.WriteLine("¡Felicidades, has adivinado la palabra!");
                                break;
                            }
                            else
                            {
                                // Palabra ingresada al intentar adivinarla
                                if (entrada != palabraSecreta)
                                {
                                    intentos++;
                                    Console.WriteLine($"Incorrecto. Te quedan {6 - intentos} intentos.");
                                }
                                else
                                {
                                    Console.WriteLine("¡Felicidades, has adivinado la palabra!");
                                    break;
                                }
                            }
                        }

                        if (intentos == 6)
                        {
                            Console.WriteLine("\n¡Oh no! Has agotado tus intentos. La palabra era: " + palabraSecreta);
                        }

                        Console.Write("\n¿Quieres jugar de nuevo? (s/n): ");
                    } while (Console.ReadLine().ToLower()[0] == 's');
                }

                if (ejercicio == 26)
                {
                    while (true)
                    {
                        Console.WriteLine("Menú Principal:");
                        Console.WriteLine("1. Mostrar registros");
                        Console.WriteLine("2. Insertar nuevo registro");
                        Console.WriteLine("3. Consultar por DNI");
                        Console.WriteLine("4. Mostrar registros con salario superior a 2500€");
                        Console.WriteLine("5. Eliminar registro por DNI");
                        Console.WriteLine("6. Mostrar registros ordenados por salario");
                        Console.WriteLine("7. Gestionar historial con los cambios realizados sobre el fichero.");
                        Console.WriteLine("8. Salir");

                        Console.Write("Seleccione una opción: ");
                        string opcion = Console.ReadLine();

                        switch (opcion)
                        {
                            case "1":
                                string ruta = Directory.GetCurrentDirectory() + "\\fichero.txt";
                                StreamWriter datos = new StreamWriter(ruta, true);

                                datos.WriteLine("00000000T");
                                datos.WriteLine("Juan Antonio");
                                datos.WriteLine("20 años");
                                datos.WriteLine("3000€");

                                datos.Close();

                                break;

                            case "2":
                                Console.Write("Introduce el DNI");
                                int Dni = int.Parse(Console.ReadLine());

                                Console.Write("Introduce el Nombre y Apellidos");
                                int NombreyApellidos = int.Parse(Console.ReadLine());

                                Console.Write("Introduce la Edad");
                                int Edad = int.Parse(Console.ReadLine());

                                Console.Write("Introduce el Salario");
                                int Salario = int.Parse(Console.ReadLine());
                                break;

                            case "3":
                               
                                break;

                            case "4":
                                if (salario < 2500)
                                {
                                    Console.WriteLine("Los registros cuyos salarios son mayor a 2500 son: " + );
                                }
                                break;

                            case "5":
                              
                                break;

                            case "6":
                                
                                break;

                            case "7":
                               
                                break;

                            case "8":

                                break;

                            default:
                                Console.WriteLine("Opción no válida. Intente de nuevo.");
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
