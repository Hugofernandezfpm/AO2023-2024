using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclefor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bucle For
            //Mostrar numeros entre 1 y 20 por pantalla
            for(int i = 1; i <=20; i = i + 1 )
            {
                Console.WriteLine(i + " ");
            }

            //Calcular la summa de todos los numeros entre n y m
            int n = 15;
            int m = 30;
            int suma = 0; //n + n +1 +n+2 + n+3 + n+4 .......
       
            for( int i = n; i <= m; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("La suma es " + suma);

            //Calcula la suma de los numeros impares entre n y m

            int sumaImpares = 0;
            for (int i= n; i <= m; i++)
            {
                if ( i % 2 !=0)
                {
                    sumaImpares = sumaImpares + i;
                }
            }
            Console.WriteLine("La suma es " + sumaImpares);


            Console.ReadLine();
        }
    } 
}
