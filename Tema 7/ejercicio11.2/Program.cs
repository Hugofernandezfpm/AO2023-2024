using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11._2
{
    internal class Program
    {
        static void Main(string[] args)
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
    }
}
