using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                string[] palabras = { "clase", "programacion", "ahorcado", "juego", "codigo", "video", "ordenador" };

                Console.WriteLine("¡Bienvenido al Juego del Ahorcado!");

                do
                {
                    string palabraSecreta = palabras[new Random().Next(palabras.Length)];
                    char[] palabraAdivinada = new char[palabraSecreta.Length];
                    for (int i = 0; i < palabraAdivinada.Length; i++)
                    {
                        palabraAdivinada[i] = '_';
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
                                        palabraAdivinada[i] = letra;
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
                            Console.WriteLine("Entrada no válida. Por favor, ingresa una letra o intenta adivinar la palabra.");
                        }
                    }

                    if (intentos == 6)
                    {
                        Console.WriteLine("\n¡Oh no! Has agotado tus intentos. La palabra era: " + palabraSecreta);
                    }

                    Console.Write("\n¿Quieres jugar de nuevo? (s/n): ");
                } while (Console.ReadLine().ToLower()[0] == 's');
            }






        }
    }
}
