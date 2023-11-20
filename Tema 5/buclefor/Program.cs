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


            //Salir prematuramente de u bucle --> Sentencia break
            //Encontrar el primer número múltiplo de 3, 7 y 8 a la vez en un rango
            int limeteInferior = 1200;
            int limiteSuperior = 35000;

            for (int i = limeteInferior; i <= limiteSuperior; i++)
            {
                if (i % 3 == 0 && i % 7 == 0 && i % 8 == 0)
                {
                   Console.WriteLine("Primer múltiplo de 3 7 y 8 es " + i);
                    break;
                }
            }

            //Ignorar repetición --> continue //Esto no va a entrar
            //Sumar todos los números menos los que son multiplos de 3 y 7 a la vez en un
            int suma2 = 0;
            for (int i = limeteInferior; i <= limiteSuperior; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    continue;
                }
                suma2 = suma2 + i;
            }

            Console.ReadLine();
        }
    } 
}
