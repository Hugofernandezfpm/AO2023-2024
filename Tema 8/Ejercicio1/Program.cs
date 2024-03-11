using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
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
            
            Console.ReadLine();

           
        }
    }
}
    

