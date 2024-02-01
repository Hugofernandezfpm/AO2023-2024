using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinMatrices2d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double continuar;

            do
            {
                int ejercicio = 0;

                Console.WriteLine("Introducir ejercicio: 44-56");
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio >= 44 && ejercicio <= 56)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Este ejercicio no existe");
                }

                if (ejercicio == 44)
                {
                    // Declarar una matriz 3x3 y darle valores en la declaración
                    int[,] matriz = {
                         {1, 2, 3},
                         {4, 5, 6},
                         {7, 8, 9}
                                    };

                    // Mostrar la matriz original
                    Console.WriteLine("Matriz original:");
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            Console.Write(matriz[i, j] + " ");
                        }
                    }

                    Console.WriteLine();

                    // Solicitar al usuario que escoja una fila y mostrarle los valores de esa fila
                    Console.Write("Ingrese el número de fila (0, 1, o 2): ");
                    int filaEscogida = int.Parse(Console.ReadLine());
                    Console.Write("Valores en la fila " + filaEscogida + ": ");
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write(matriz[filaEscogida, j] + " ");
                    }

                    Console.WriteLine();

                    // Guardar un cero en las últimas posiciones de cada fila
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        matriz[i, matriz.GetLength(1) - 2] = 0;
                        matriz[i, matriz.GetLength(1) - 1] = 0;
                    }


                    // Mostrar la matriz con ceros en las últimas posiciones de cada fila
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            Console.Write(matriz[i, j] + " ");
                        }

                        Console.WriteLine();
                    }

                    // Sumar todos los valores de la primera fila
                    int sumaPrimeraFila = 0;
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        sumaPrimeraFila += matriz[0, j];
                    }
                    Console.WriteLine("Suma de la primera fila: " + sumaPrimeraFila);

                    // Contar cuántos ceros hay en la segunda columna
                    int cerosSegundaColumna = 0;
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        if (matriz[i, 1] == 0)
                        {
                            cerosSegundaColumna++;
                        }
                    }
                    Console.WriteLine("Número de ceros en la segunda columna: " + cerosSegundaColumna);

                    // Calcular la media de la matriz 3x3
                    int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);
                    int sumaTotal = 0;
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            sumaTotal += matriz[i, j];
                        }
                    }
                    double mediaMatriz = (double)sumaTotal / totalElementos;
                    Console.WriteLine("Media de la matriz: " + mediaMatriz);
                }

                if (ejercicio == 46)
                {
                    // Definir la matriz original
                    int[,] matrizOriginal = {
                             {0, 1, 2},
                             {3, 4, 5},
                             {6, 7, 8}
                                            };

                    // Mostrar la matriz original
                    Console.WriteLine("Matriz Original:");
                    for (int i = 0; i < matrizOriginal.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrizOriginal.GetLength(1); j++)
                        {
                            Console.Write(matrizOriginal[i, j]);
                            if (j < matrizOriginal.GetLength(1) - 1)
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }

                    // Obtener la matriz traspuesta
                    int filas = matrizOriginal.GetLength(0);
                    int columnas = matrizOriginal.GetLength(1);
                    int[,] matrizTraspuesta = new int[columnas, filas];

                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            matrizTraspuesta[j, i] = matrizOriginal[i, j];
                        }
                    }

                    // Mostrar la matriz traspuesta
                    Console.WriteLine("Matriz Traspuesta:");
                    for (int i = 0; i < matrizTraspuesta.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrizTraspuesta.GetLength(1); j++)
                        {
                            Console.Write(matrizTraspuesta[i, j]);
                            if (j < matrizTraspuesta.GetLength(1) - 1)
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }

                    // Calcular el porcentaje de ceros
                    int totalElementos = filas * columnas;
                    double ceros = 0;

                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            if (matrizOriginal[i, j] == 0)
                                ceros++;
                        }
                    }

                    double porcentajeCeros = (ceros / totalElementos) * 100;
                    Console.WriteLine($"Porcentaje de ceros: {porcentajeCeros}%");

                    // Comprobar simetría
                    bool esSimetrica = true;

                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            if (matrizOriginal[i, j] != matrizTraspuesta[i, j])
                            {
                                esSimetrica = false;
                                break;
                            }
                        }

                        if (!esSimetrica)
                            break;
                    }

                    Console.WriteLine($"La matriz es simétrica: {esSimetrica}");

                    // Calcular la suma de la primera fila
                    int sumaPrimeraFila = 0;

                    for (int j = 0; j < columnas; j++)
                    {
                        sumaPrimeraFila += matrizOriginal[0, j];
                    }

                    Console.WriteLine($"Suma de la primera fila: {sumaPrimeraFila}");

                    // Calcular la suma de la última columna
                    int sumaUltimaColumna = 0;

                    for (int i = 0; i < filas; i++)
                    {
                        sumaUltimaColumna += matrizOriginal[i, columnas - 1];
                    }

                    Console.WriteLine($"Suma de la última columna: {sumaUltimaColumna}");
                }

                if (ejercicio == 55)
                {
                    // Crear matriz 5x5
                    int[,] matriz = new int[5, 5];

                    // Llenar matriz con números aleatorios
                    Random random = new Random();

                    // Colocar 3 ceros en posiciones aleatorias
                    for (int i = 0; i < 3; i++)
                    {
                        int fila, columna;
                        do
                        {
                            fila = random.Next(5);
                            columna = random.Next(5);
                        } while (matriz[fila, columna] != 0);

                        matriz[fila, columna] = 1; // Usamos 1 para indicar que hay un cero en esta posición
                    }

                    // Inicializar vidas del usuario
                    int vidas = 6;
                    int cerosEncontrados = 0;

                    // Bucle principal
                    while (cerosEncontrados < 3 && vidas > 0)
                    {
                        // Mostrar la matriz (con ceros ocultos)
                        Console.WriteLine("Matriz:");
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (matriz[i, j] == 0)
                                    Console.Write("  -  ");
                                else
                                    Console.Write("  0  ");
                            }
                            Console.WriteLine();
                        }

                        // Solicitar coordenadas al usuario
                        Console.Write("Introduce la fila (0-4): ");
                        int filaUsuario = int.Parse(Console.ReadLine());

                        Console.Write("Introduce la columna (0-4): ");
                        int columnaUsuario = int.Parse(Console.ReadLine());

                        // Verificar si el usuario ha encontrado un cero
                        if (matriz[filaUsuario, columnaUsuario] == 1)
                        {
                            Console.WriteLine("¡Correcto! Has encontrado un cero.");
                            matriz[filaUsuario, columnaUsuario] = 2; // Marcamos como encontrado
                            cerosEncontrados++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrecto. Pierdes una vida.");
                            vidas--;
                            Console.WriteLine($"Vidas restantes: {vidas}");
                        }
                    }

                    // Mostrar resultado final
                    if (vidas == 0)
                        Console.WriteLine("Te has quedado sin vidas. Fin del juego.");
                    else
                        Console.WriteLine("¡Felicidades! Has encontrado todos los ceros.");
                }

                if (ejercicio == 56)
                {
                    int[,] tablero = new int[10, 10];

                    // Inicializar tablero con agua 
                    for (int i = 0; i < 10; i++)
                        for (int j = 0; j < 10; j++)
                            tablero[i, j] = 0;

                    // Colocar barcos en el tablero en lugares random

                    Random random = new Random();

                    int valor1 = 0;
                    int valor2 = 0;

                    for (int i = 0; i < 3; i += 0)
                    {
                        valor1 = random.Next(0, 9);
                        valor2 = random.Next(0, 9);
                        if (tablero[valor1,valor2] == 0)
                        {
                            tablero[valor1,valor2] = 1;
                            i++;
                        }
                    }

                    Console.WriteLine("¡Bienvenido a Hundir la Flota!");

                    // Bucle principal del juego
                    while (true)
                    {
                        // Mostrar el tablero en la consola
                        Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(i + " ");
                            for (int j = 0; j < 10; j++)
                            {
                                if (tablero[i, j] == 0)
                                    Console.Write("~ ");  // Agua
                                else if (tablero[i, j] == 1)
                                    Console.Write("0 ");  // Barco no tocado
                                else if (tablero[i, j] == -1)
                                    Console.Write("X ");  // Barco hundido
                            }
                            Console.WriteLine();
                        }

                        // Obtener entrada del usuario para realizar un intento
                        Console.Write("Ingrese la fila (0-9): ");
                        int fila = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese la columna (0-9): ");
                        int columna = int.Parse(Console.ReadLine());

                        // Verificar el resultado del intento
                        if (tablero[fila, columna] == 1)
                        {
                            Console.WriteLine("¡Impacto! Hundiste un barco.");
                            tablero[fila, columna] = -1; // Marcar como hundido
                        }
                        else if (tablero[fila, columna] == 0)
                        {
                            Console.WriteLine("Agua. Intenta de nuevo.");
                        }
                        else if (tablero[fila, columna] == -1)
                        {
                            Console.WriteLine("Ya has hundido ese barco. Intenta de nuevo.");
                        }

                        // Verificar si todos los barcos han sido hundidos
                        bool todosHundidos = true;
                        for (int i = 0; i < 10; i++)
                            for (int j = 0; j < 10; j++)
                                if (tablero[i, j] == 1)
                                    todosHundidos = false;

                        if (todosHundidos)
                        {
                            // Mostrar el tablero final
                            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
                            for (int i = 0; i < 10; i++)
                            {
                                Console.Write(i + " ");
                                for (int j = 0; j < 10; j++)
                                {
                                    if (tablero[i, j] == 0)
                                        Console.Write("~ ");  // Agua
                                    else if (tablero[i, j] == 1)
                                        Console.Write("0 ");  // Barco no tocado
                                    else if (tablero[i, j] == -1)
                                        Console.Write("X ");  // Barco hundido
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine("¡Felicidades! Hundiste todos los barcos.");
                            break; // Salir del bucle principal
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
