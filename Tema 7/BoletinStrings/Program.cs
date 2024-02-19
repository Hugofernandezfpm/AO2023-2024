using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double continuar;

            do
            {
                int ejercicio = 0;

                Console.WriteLine("Introducir ejercicio: 1-26");
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio >= 1 && ejercicio <= 26)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Este ejercicio no existe");
                }

                if (ejercicio == 1)
                {
                    // Crear una matriz de strings con al menos 10 matrículas
                    string[] matriculas = { "1234-ABC", "5678-ZYZ", "9090-XYZ", "3434-ABC", "8765-XYZ", "1234-DEF", "5678-Z34", "9090-ABC", "3434-ZXY", "8765-UVW" };

                    // Variables para almacenar resultados
                    string matriculasConZ = "";
                    string matriculasContiene34 = "";
                    string parteNumericaMatriculas = "";
                    string parteLetrasMatriculas = "";

                    // Bucle for para realizar todas las operaciones
                    for (int i = 0; i < matriculas.Length; i++)
                    {
                        // Mostrar las matrículas que acaban por 'Z'
                        if (matriculas[i].EndsWith("Z")) //El .EndsWith se utiliza para verificar si una cadena
                                                         //termina con una subcadena específica. Retorna un valor
                                                         //booleano (true o false) dependiendo de si la cadena termina
                                                         //con la subcadena proporcionada.
                                                         //En este caso es para comprobar si acaba en Z
                        {
                            matriculasConZ += matriculas[i] + "\n";
                        }

                        // Mostrar las matrículas que contienen el número '34'
                        if (matriculas[i].Contains("34"))
                        {
                            matriculasContiene34 += matriculas[i] + "\n";
                        }

                        // Mostrar sólo la parte numérica de las matrículas
                        string parteNumerica = "";
                        foreach (char caracter in matriculas[i])
                        {
                            if (char.IsDigit(caracter))
                            {
                                parteNumerica += caracter;
                            }
                        }
                        parteNumericaMatriculas += parteNumerica + "\n";

                        // Mostrar sólo la parte de las letras de las matrículas
                        string parteLetras = "";
                        foreach (char caracter in matriculas[i])
                        {
                            if (char.IsLetter(caracter))
                            {
                                parteLetras += caracter;
                            }
                        }
                        parteLetrasMatriculas += parteLetras + "\n";
                    }

                    // Mostrar resultados
                    Console.WriteLine("Matrículas que acaban por 'Z':\n" + matriculasConZ);
                    Console.WriteLine("\nMatrículas que contienen el número '34':\n" + matriculasContiene34);
                    Console.WriteLine("\nParte numérica de las matrículas:\n" + parteNumericaMatriculas);
                    Console.WriteLine("\nParte de las letras de las matrículas:\n" + parteLetrasMatriculas);

                    // Volcar los datos de la matriz a un fichero
                    StreamWriter writer = null;
                    try
                    {
                        writer = new StreamWriter("matriculas.txt");
                        for (int i = 0; i < matriculas.Length; i++)
                        {
                            writer.WriteLine(matriculas[i]);
                        }
                        Console.WriteLine("\nDatos volcados en el fichero 'matriculas.txt'");
                    }catch (Exception e)
                    {
                        Console.Write("No se ha podido volcar los datos");
                    }
                    finally
                    {
                        if (writer != null)
                            writer.Close();
                    }
                }

                if (ejercicio == 2)
                {
                    string cadena = "Hol";
                    char caracter_a_contar = 'a';
                    int resultado = 0;

                    for (int i = 0; i < cadena.Length; i++)
                    {
                        if (cadena[i] == caracter_a_contar)
                        {
                            resultado++;
                        }
                    }

                    Console.WriteLine($"El carácter '{caracter_a_contar}' aparece {resultado} veces en la cadena.");
                }



                if (ejercicio == 3)
                {
                    bool dniValido = false;

                    while (!dniValido)
                    {
                        Console.WriteLine("Introduce el número de DNI seguido de la letra:");
                        string input = Console.ReadLine();

                        int numeroDNI;
                        char letraUsuario;

                        if (input.Length == 9 && char.IsDigit(input[0]) && char.IsDigit(input[1]) && char.IsDigit(input[2]) && char.IsDigit(input[3]) &&
                            char.IsDigit(input[4]) && char.IsDigit(input[5]) && char.IsDigit(input[6]) && char.IsDigit(input[7]) && char.IsLetter(input[8]))
                        {
                            numeroDNI = int.Parse(input.Substring(0, 8)); //El .substring se utiliza para obtener una subcadena de una cadena más grande.
                                                                          //Permite extraer una porción específica de caracteres de una cadena original.
                            letraUsuario = char.ToUpper(input[8]);

                            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
                            int resto = numeroDNI % 23;
                            char letraCalculada = letras[resto];

                            if (letraUsuario == letraCalculada)
                            {
                                Console.WriteLine("El número y la letra de DNI son correctos.");
                                dniValido = true;
                            }
                            else
                            {
                                Console.WriteLine($"La letra indicada ({letraUsuario}) no es correcta. Intenta nuevamente.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Formato de DNI no válido. Intenta nuevamente.");
                        }
                    }
                }

                if (ejercicio == 4)
                {
                    // Leer la cadena de texto desde el usuario
                    Console.Write("Ingresa una cadena de texto: ");
                    string cadena = Console.ReadLine();

                    // Dividir la cadena en palabras
                    string[] palabras = cadena.Split();

                    // Mostrar las palabras que empiezan por 'b' usando un bucle for
                    Console.WriteLine("Palabras que empiezan por 'b':");
                    for (int i = 0; i < palabras.Length; i++)
                    {
                        string palabra = palabras[i];
                        if (palabra.StartsWith("b", StringComparison.OrdinalIgnoreCase)) //el startswith se utiliza para verificar si una cadena
                                                                                         //comienza con una subcadena específica. Retorna un valor
                                                                                         //booleano (true o false) según si la cadena empieza con la
                                                                                         //subcadena especificada. 
                                                                                         //En este caso estamos comprobando si empieza con b
                        {
                            Console.WriteLine(palabra);
                        }
                    }
                }

                if (ejercicio == 5)
                {
                    string cadenaEjemplo = "alumno@gmail.com";
                    bool contieneArroba = false;

                    for (int i = 0; i < cadenaEjemplo.Length; i++)
                    {
                        if (cadenaEjemplo[i] == '@')
                        {
                            contieneArroba = true;
                            break;
                        }
                    }

                    Console.WriteLine(contieneArroba);
                }

                if (ejercicio == 6)
                {
                    // Ejemplo de uso
                    string cadenaEjemplo = "abacaba es una palabra que contiene aba. Otra palabra con aba es abacus.";

                    // Dividir la cadena en palabras
                    string[] palabras = cadenaEjemplo.Split(' ');

                    string substringBuscado = "aba";
                    int contador = 0;

                    // Contar el número de palabras que contienen el substring
                    for (int i = 0; i < palabras.Length; i++)
                    {
                        // Eliminar espacios en blanco alrededor de cada palabra
                        string palabra = palabras[i].Trim(); //El .trim se utiliza para eliminar
                                                             //los espacios en blanco (o caracteres específicos)
                                                             //al principio y al final de una cadena. 

                        if (palabra.Contains(substringBuscado))
                        {
                            contador++;
                        }
                    }

                    Console.WriteLine($"El número de palabras que contienen '{substringBuscado}' es: {contador}");
                }

                if (ejercicio == 7)
                {
                    string correoElectronico = "usuario@gmail.com";
                    int indiceArroba = -1;

                    // Buscar la posición de la '@' utilizando un bucle for
                    for (int i = 0; i < correoElectronico.Length; i++)
                    {
                        if (correoElectronico[i] == '@')
                        {
                            indiceArroba = i;
                            break;
                        }
                    }

                    // Verificar si se encontró la '@' y obtener el dominio
                    if (indiceArroba != -1 && indiceArroba < correoElectronico.Length - 1)
                    {
                        string dominio = correoElectronico.Substring(indiceArroba + 1);
                        Console.WriteLine($"El dominio del correo electrónico {correoElectronico} es: {dominio}");
                    }
                    else
                    {
                        Console.WriteLine("Formato de correo electrónico no válido.");
                    }
                }

                if (ejercicio == 8)
                {
                    // Ejemplos de códigos para probar la validación
                    string[] codigos = { "AB12", "XYZ99", "A1B2", "CD34", "1234" };

                    // Validar cada código en el bucle for
                    for (int i = 0; i < codigos.Length; i++)
                    {
                        string codigoActual = codigos[i];

                        // Verificar que la longitud del código sea 4
                        if (codigoActual.Length != 4)
                        {
                            Console.WriteLine($"Código: {codigoActual}, ¿Es válido?: False (Longitud incorrecta)");
                            continue;
                        }

                        // Validar que los primeros dos caracteres son letras y los últimos dos son dígitos
                        bool esValido = true;
                        for (int j = 0; j < 2; j++)
                        {
                            if (!char.IsLetter(codigoActual[j]) || !char.IsDigit(codigoActual[j + 2]))
                            {
                                esValido = false;
                                break;
                            }
                        }

                        Console.WriteLine($"Código: {codigoActual}, ¿Es válido?: {esValido}");
                    }
                }

                if (ejercicio == 9)
                {

                    string cadenaOriginal = "Esta es una cadena con espacios";
                    Console.WriteLine("Cadena original: " + cadenaOriginal);

                    for (int i = 0; i < cadenaOriginal.Length; i++)
                    {
                        // Si el carácter actual es un espacio, lo reemplazamos por '*'
                        if (cadenaOriginal[i] == ' ')
                        {
                            cadenaOriginal = cadenaOriginal.Substring(0, i) + '*' + cadenaOriginal.Substring(i + 1);
                        }
                    }

                    Console.WriteLine("Resultado: " + cadenaOriginal);
                }

                if (ejercicio == 10)
                {

                    string personaNumero1 = "Pedro Jimenez*14Julio1990?2500";

                    string personaNumero2 = "Maria Benitez*9070!06Agosto1998";

                    string[] persona1 = personaNumero1.Split('?');
                    string[] persona2 = personaNumero2.Split('*');
                    string[] persona3 = persona2[1].Split('!');

                    int salario = int.Parse(persona1[1]);
                    int salario2 = int.Parse(persona3[0]);

                    if (salario  > 1000)
                    {
                        Console.WriteLine(" Pedro Jimenez tiene un salario superior a 1000.");
                    }
                    else
                    {
                        Console.WriteLine(" Pedro Jimenez tiene un salario igual o inferior a 1000.");
                    }


                    if (salario2 > 1000)
                    {
                        Console.WriteLine(" Maria Benitez tiene un salario superior a 1000.");
                    }
                    else
                    {
                        Console.WriteLine(" Maria Benitez tiene un salario igual o inferior a 1000.");
                    }
                }

                if (ejercicio == 11)
                {
                    string[] palabras = { "clase", "programacion", "ahorcado", "juego", "codigo", "video", "ordenador" };

                    Console.WriteLine("¡Bienvenido al Juego del Ahorcado!");

                    do
                    {
                        string palabraSecreta = palabras[new Random().Next(palabras.Length)];
                        string palabraAdivinada = new string('_', palabraSecreta.Length);
                        int intentos = 0;

                        while (intentos < 6 && palabraAdivinada.Contains('_'))
                        {
                            Console.WriteLine("\nPalabra actual: " + palabraAdivinada);
                            Console.WriteLine("Intentos restantes: " + (6 - intentos));

                            Console.Write("Ingresa una letra: ");
                            char letra = Console.ReadLine().ToLower()[0];

                            if (palabraSecreta.Contains(letra))
                            {
                                for (int i = 0; i < palabraSecreta.Length; i++)
                                {
                                    if (palabraSecreta[i] == letra)
                                    {
                                        palabraAdivinada = palabraAdivinada.Remove(i, 1).Insert(i, letra.ToString()); //el .insert sirve para insertar el
                                                                                                                      //segundo valor en la posición que se indique
                                    }
                                }
                            }
                            else
                            {
                                intentos++;
                                Console.WriteLine($"Incorrecto. Te quedan {6 - intentos} intentos.");
                            }
                        }

                        if (!palabraAdivinada.Contains('_'))
                        {
                            Console.WriteLine("\n¡Felicidades! Has adivinado la palabra: " + palabraSecreta);
                        }
                        else
                        {
                            Console.WriteLine("\n¡Oh no! Has agotado tus intentos. La palabra era: " + palabraSecreta);
                        }

                        Console.Write("\n¿Quieres jugar de nuevo? (s/n): ");
                    } while (Console.ReadLine().ToLower()[0] == 's');
                }

                if (ejercicio == 26)
                {

                }

                Console.ReadLine();
                Console.WriteLine("quiere volver al menu : s-> si/ n-> no");
                continuar = Console.ReadKey().KeyChar;
            }
            while (continuar == 's');
        }
    }
}