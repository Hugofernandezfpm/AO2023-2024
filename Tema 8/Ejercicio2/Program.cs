using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            while (true)
            {
                Console.Write("Seleccione una opción: ");
                Console.WriteLine("");
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
               

                string opcion = Console.ReadLine();

                switch (opcion)
                {

                    case "1":

                        // Agregar tarea
                        List<string> Tareas = new List<string>();
                        Console.Write("Introduce una tarea: ");
                        string nuevaTarea = Console.ReadLine();
                        Tareas.Add(nuevaTarea);
                        break;

                    case "2":


                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

            }
        }  
    }
}
