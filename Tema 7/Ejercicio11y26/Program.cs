using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

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

                    Console.WriteLine("Bienvenido al ahorcado");

                    do
                    {
                        string palabraSecreta = palabras[new Random().Next(palabras.Length)];
                        char[] palabraAdivinada = new char[palabraSecreta.Length * 2 - 1];

                        // Para que muestre la palabra oculta con guiones y espacios en blanco
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
                                // Para que te deje intentar adivinar la letra
                                char letra = entrada[0];

                                if (palabraSecreta.Contains(letra))
                                {
                                    // Para saber si la letra esta en la palabra oculta
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
                                    // Te resta una vida si fallas
                                    intentos++;
                                    Console.WriteLine($"Incorrecto. Te quedan {6 - intentos} intentos.");
                                }
                            }
                            else if (entrada.Length == palabraSecreta.Length && entrada == palabraSecreta)
                            {
                                // Para mostrar si acertaste la palabra
                                Console.WriteLine("Has acertado la palabra");
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
                                    Console.WriteLine("Has ganado");
                                    break;
                                }
                            }
                        }

                        if (intentos == 6)
                        {
                            Console.WriteLine("\nHas agotado todas tus vidas la palabra era : " + palabraSecreta);
                        }

                        Console.Write("\n¿Quieres jugar de nuevo? (s/n): ");
                    } while (Console.ReadLine().ToLower()[0] == 's');
                }

                if (ejercicio == 26)
                {

                    Console.Write("Introduce el DNI: ");
                    String Dni = Console.ReadLine();

                    Console.Write("Introduce el Nombre y Apellidos: ");
                    String NombreyApellidos = Console.ReadLine();

                    Console.Write("Introduce la Edad: ");
                    String Edad = Console.ReadLine();

                    Console.Write("Introduce el Salario: ");
                    String Salario = Console.ReadLine();

                    while (true)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Menú Principal:");
                        Console.WriteLine(" ");
                        Console.WriteLine("1. Mostrar registros");
                        Console.WriteLine(" ");
                        Console.WriteLine("2. Insertar nuevo registro");
                        Console.WriteLine(" ");
                        Console.WriteLine("3. Consultar por DNI");
                        Console.WriteLine(" ");
                        Console.WriteLine("4. Mostrar registros con salario superior a 2500€");
                        Console.WriteLine(" ");
                        Console.WriteLine("5. Eliminar registro por DNI");
                        Console.WriteLine(" ");
                        Console.WriteLine("6. Mostrar registros ordenados por salario");
                        Console.WriteLine(" ");
                        Console.WriteLine("7. Gestionar historial con los cambios realizados sobre el fichero.");
                        Console.WriteLine(" ");
                        Console.WriteLine("8. Salir");
                        Console.WriteLine(" ");

                        Console.Write("Seleccione una opción: ");
                        string opcion = Console.ReadLine();

                        switch (opcion)
                        {

                            case "1":
                                string ruta = Directory.GetCurrentDirectory() + "\\fichero.txt";
                                StreamWriter datos = new StreamWriter(ruta, true);

                                Console.Write("Dni: " + Dni);

                                Console.WriteLine(" ");

                                Console.Write("Nombre y Apellidos: " + NombreyApellidos);

                                Console.WriteLine(" ");

                                Console.Write("Edad: " + Edad);

                                Console.WriteLine(" ");

                                Console.Write("Salario: " + Salario);

                                Console.WriteLine(" ");

                                datos.Close();

                                break;

                            case "2":
                                ruta = Directory.GetCurrentDirectory() + "\\fichero.txt";
                                datos = new StreamWriter(ruta, true);

                                Console.Write("Introduce el DNI: ");
                                 Dni = Console.ReadLine();

                                Console.Write("Introduce el Nombre y Apellidos: ");
                                NombreyApellidos = Console.ReadLine();

                                Console.Write("Introduce la Edad: ");
                                Edad = Console.ReadLine();

                                Console.Write("Introduce el Salario: ");
                                Salario = Console.ReadLine();
                                datos.Close();
                                break;

                            case "3":
                               
                                int RegistroDni = Dni.Length - 1;
                                foreach (string Registro in RegistroDni.ToString().Split(','))
                                    break;

                            case "4":
                                int Salariototal = Salario.Length - 1;

                                if (Salariototal < 2500)
                                {
                                    Console.WriteLine("Los registros cuyos salarios son mayor a 2500 son: " + Salariototal);
                                }
                                break;

                            //case "5":

                            //    break;

                            //case "6":

                            //    break;

                            //case "7":
                            //    int RegistroSalario = Salario;
                            //    if (RegistroSalario )

                            //    break;

                            //case "8":

                            //    break;

                            default:
                                Console.WriteLine("Opción no válida. Intente de nuevo.");
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
