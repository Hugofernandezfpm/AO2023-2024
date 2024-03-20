using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenColeccionesTema8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crea una lista en la que se puedan guardar números enteros.


            List<int> numeros = new List<int>();     //Fernández Rodríguez Hugo

            // Guarda 20 números generados aleatoriamente dentro del rango [-10,10]
            Random lista = new Random();
            for (int i = 0; i < 20; i++)
            {
                numeros.Add(lista.Next(-10, 11));       //Fernández Rodríguez Hugo
            }

            // Obtén la capacidad de la lista y cuantas posiciones quedarían por llenar.
            int capacidad = numeros.Capacity;
            int posicionesPorLlenar = capacidad - numeros.Count;

            Console.WriteLine("Capacidad de la lista: " + capacidad);            //Fernández Rodríguez Hugo
            Console.WriteLine("Posiciones por llenar: " + posicionesPorLlenar);

            // Obtén la posición del primer cero, en caso de que no haya mostrar mensaje por pantalla.
            int posicionCero = numeros.IndexOf(0);
            if (posicionCero != -1)
            {
                Console.WriteLine("Posición del primer cero: " + posicionCero);
            }
            else                                                                       //Fernández Rodríguez Hugo
            {
                Console.WriteLine("No se encontró el número 0 en la lista.");
            }

            // Ajusta la capacidad de la lista al número de elementos que contiene.
            numeros.TrimExcess();                     //Fernández Rodríguez Hugo

            // Añade un número superior a 10 en la posición 2 de la lista.
            numeros.Insert(2, 15);                   //Fernández Rodríguez Hugo

            // Elimina el elemento situado en la posición 5
            numeros.RemoveAt(5);                      //Fernández Rodríguez Hugo

            // Elimina el primer número 3 que haya en la lista.
            numeros.Remove(3);                         //Fernández Rodríguez Hugo

            // Crea otra lista en la que se guardarán todos los elementos de la primera.
            List<int> copiaNumeros = new List<int>(numeros);     //Fernández Rodríguez Hugo

            // Muestra todos los valores sin duplicados.
            List<int> valoresSinDuplicados = numeros.Distinct().ToList();      //Fernández Rodríguez Hugo

            // Mostrar resultados
            Console.WriteLine("Lista original:");
            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Lista copiada:");
            foreach (int num in copiaNumeros)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            

            Console.WriteLine("Valores sin duplicados:");
            foreach (int num in valoresSinDuplicados)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
