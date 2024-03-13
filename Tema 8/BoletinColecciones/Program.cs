using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BoletinColecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double continuar;

            do
            {
                int ejercicio = 0;

                Console.WriteLine("Introducir ejercicio: 1 al 6");
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio >= 1 && ejercicio <= 6)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Este ejercicio no existe");
                }

                if (ejercicio == 1)
                {
                    // Crear una lista y llenarla con valores aleatorios entre 1 y 25

                    Random ListaValores = new Random();
                    List<int> lista = new List<int>();
                    for (int i = 0; i < 10; i++)
                    {
                        lista.Add(ListaValores.Next(1, 26));
                    }

                    // Mostrar la lista generada
                    Console.WriteLine("Valores en la lista:");
                    foreach (int lista2 in lista)
                    {

                        Console.WriteLine(lista2);
                    }


                    // Encontrar la posición en la que se encuentra el valor 2
                    int posicion = lista.IndexOf(2);
                    if (lista.Contains(2))
                    {
                        Console.WriteLine($"Posición del valor 2: {posicion}");
                    }
                    else
                    {
                        Console.WriteLine("El valor 2 no se encuentra en la lista.");
                    }

                    // Calcular la suma de los valores generados
                    int suma = lista.Sum();
                    Console.WriteLine($"Suma de los valores: {suma}");

                    // Calcular la media de los valores generados
                    double media = lista.Average();
                    Console.WriteLine($"Media de los valores: {media}");

                    // Calcular el porcentaje de números superiores a 20 en la lista
                    double porcentaje = (double)lista.Count(num => num > 20) / lista.Count * 100;
                    Console.WriteLine($"Porcentaje de números superiores a 20: {porcentaje}%");

                    // Mostrar los valores únicos en la lista

                    SortedSet<int> set = new SortedSet<int>(lista);
                    Console.WriteLine("Valores únicos en la lista:");

                    foreach (int valores2 in set)
                    {
                        Console.WriteLine(valores2);
                    }
                }

                if (ejercicio == 2)
                {
                    List<string> tareas = new List<string>();
                    List<string> completadas = new List<string>();
                    
                    while (true)
                    {
                        Console.WriteLine("");
                        Console.Write("1. Introducir tarea");
                        Console.WriteLine("");
                        Console.Write("2. Completar tarea");
                        Console.WriteLine("");
                        Console.Write("3. Contar tareas pendientes");
                        Console.WriteLine("");
                        Console.Write("4. Mostrar tareas pendientes");
                        Console.WriteLine("");
                        Console.Write("5. Mostrar tareas completadas");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.Write("Seleccione una opción: ");
                        string opcion = Console.ReadLine();

                        switch (opcion)
                        {

                            case "1":
                                // Agregar tarea
                                
                                Console.Write("Introduce una tarea: ");
                                Console.WriteLine("");
                                string nuevaTarea = Console.ReadLine();
                                tareas.Add(nuevaTarea);
                                break;

                            case "2":
                                // Completar tarea
                              
                                
                                Console.Write("Indique la tarea a completar: ");
                                Console.WriteLine("");
                                string tareaCompleta = Console.ReadLine();
                                    if (tareas.Contains(tareaCompleta))
                                    {
                                        tareas.Remove(tareaCompleta);
                                        completadas.Add(tareaCompleta);
                                        Console.WriteLine("Tarea completada y movida a la lista de tareas completadas.");
                                    }
                                    else
                                    {
                                    Console.WriteLine("La tarea no existe"); 
                                    }
                                
                                break;

                            case "3":
                                // Contar tareas pendientes

                                Console.WriteLine("Tareas pendientes: " + tareas.Count);
                                break;

                            case "4":
                                // Mostrar tareas pendientes
                                Console.WriteLine("Lista de tareas pendientes:");
                                Console.WriteLine("");

                                foreach (string tareasPendientes in tareas)
                                {
                                    Console.WriteLine(tareasPendientes);
                                }
                               
                                break;

                            case "5":
                                // Mostrar tareas completadas

                                Console.WriteLine("Lista de tareas completadas: ");
                                Console.WriteLine("");
                                foreach (string tareasCompletadas in completadas)
                                {
                                    Console.WriteLine(tareasCompletadas);
                                }

                                break;

                            default:
                                Console.WriteLine("Opción no válida. Intente de nuevo.");
                                break;
                        }
                    }
                }

                if (ejercicio == 3)
                {

                   HashSet<string> dni = new HashSet<string>();

                    while (true)
                    {
                        Console.WriteLine("");
                        Console.Write("1. Guardar dni");
                        Console.WriteLine("");
                        Console.Write("2. Eliminar dni");
                        Console.WriteLine("");
                        Console.Write("3. Mostrar dnis");
                        Console.WriteLine("");
                        Console.Write("4. Buscar dni");
                        Console.WriteLine("");
                        Console.Write("5. Contar dnis");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.Write("Seleccione una opción: ");
                        string opcion = Console.ReadLine();

                        switch (opcion)
                        {

                            case "1":
                                Console.Write("Introduce el DNI ");
                                Console.WriteLine("");
                                
                                string nuevoDni = Console.ReadLine();
                                dni.Add(nuevoDni);
                                break;

                            case "2":
                                Console.Write("Introduce el DNI para eleminar ");
                                string eleminarDni = Console.ReadLine();
                                if(dni.Remove(eleminarDni))
                                {
                                    Console.WriteLine("El Dni a sido eliminado");  
                                }
                                else
                                {
                                    Console.WriteLine("El Dni no estaba en la lista");
                                }

                                break;

                            case "3":
                                Console.Write("Los DNI son: ");

                                foreach (string mostrarDNI in dni)
                                {
                                    Console.WriteLine(mostrarDNI);
                                }
                                        break;

                            case "4":
                                Console.WriteLine("Introduce el DNI para buscar");
                                string dniABuscar = Console.ReadLine();
                                if (dni.Contains(dniABuscar))
                                {
                                    Console.WriteLine("Se encontro el DNI buscado");
                                }
                                else
                                {
                                    Console.WriteLine("El DNI no esta en la lista");
                                }

                                break;

                            case "5":

                                Console.WriteLine("El numero de DNI es: " + dni.Count);
                                
                                break;

                                   

                            default:
                                Console.WriteLine("Opción no válida. Intente de nuevo.");
                                break;
                        }
                    }
                }

                if (ejercicio == 4)
                {
                    Dictionary<string, string> estadosYCapitales = new Dictionary<string, string>();
                   
                    // Agregar estados y sus capitales al diccionario
                    estadosYCapitales.Add("Alabama", "Montgomery");
                    estadosYCapitales.Add("Alaska", "Juneau");
                    estadosYCapitales.Add("Arizona", "Phoenix");
                    estadosYCapitales.Add("Arkansas", "Little Rock");
                    estadosYCapitales.Add("California", "Sacramento");
                    estadosYCapitales.Add("Colorado", "Denver");
                    estadosYCapitales.Add("Connecticut", "Hartford");
                    estadosYCapitales.Add("Delaware", "Dover");
                    estadosYCapitales.Add("Florida", "Tallahassee");
                    estadosYCapitales.Add("Georgia", "Atlanta");
                    foreach(KeyValuePair<string, string> estadosCapitales in estadosYCapitales)
                    {
                        Console.WriteLine($"{estadosCapitales.Key}, {estadosCapitales.Value}");
                    }
                    while (true)
                    {
                        Console.WriteLine("");
                        Console.Write("1. Buscar la capital de un estado en concreto");
                        Console.WriteLine("");
                        Console.Write("2. Mostrar el estado al que pertenece una determinada capital");
                        Console.WriteLine("");
                        Console.Write("3. Introducir un nuevo estado con su capital.");
                        Console.WriteLine("");
                        Console.Write("4.Mostrar los estados ordenados alfabéticamente");
                        Console.WriteLine("");
                        Console.Write("5. Eliminar un determinado estado junto con su capital");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.Write("Seleccione una opción: ");
                        string opcion = Console.ReadLine();

                        switch (opcion)
                        {
                            case "1":
                               
                                //Buscar la capital de un estado
                                String estado;
                                Console.WriteLine("Intro estado para saber su capital: ");
                                estado = Console.ReadLine();
                                try
                                {
                                    String capitalBuscada = estadosYCapitales[estado];
                                    Console.WriteLine("La capital es: " + capitalBuscada);

                                }catch (Exception e) { Console.WriteLine("El estado no existe"); }


                                break;

                            case "2":

                                String capital;
                                Console.WriteLine("Intro estado para saber su capital: ");
                                capital = Console.ReadLine();

                                String estadoBuscado = estadosYCapitales[capital];
                                Console.WriteLine("La capital es: " + estadoBuscado);

                                break;

                            case "3":

                                Console.WriteLine("Introduce un nuevo estado con su capital");
                                estadosYCapitales.Add(Console.ReadLine(), Console.ReadLine()) ;

                                break;
                          
                            case "4":

                                foreach (KeyValuePair<string, string> estadoCapital in estadosYCapitales.OrderBy(estadoCapital => estadoCapital.Key))
                                {
                                    Console.WriteLine($"{estadoCapital.Key}, {estadoCapital.Value}");
                                }

                                break; 
                           
                            case "5":

                                Console.Write("Introduce el estado para eliminar ");
                                string eleminarEstadoYCapital = Console.ReadLine();
                                if (estadosYCapitales.Remove(eleminarEstadoYCapital))
                                {
                                    Console.WriteLine("El estado y la capital fueron eliminados");
                                }
                                else
                                {
                                    Console.WriteLine("El estado y la capital no estan en la lista");
                                }

                                break;

                            default:
                                Console.WriteLine("Opción no válida. Intente de nuevo.");
                                break;
                        }
                    }
                }

                if (ejercicio == 5)
                {

                }

                if (ejercicio == 6)
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

