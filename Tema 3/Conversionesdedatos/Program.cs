﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversionesdedatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dos tipos de conversiones implicitas y explicitas:
            //Las implicitas: Pasamos un valor de una varible de menor capacidad a otra de mayor capacidad
            byte n1 = 9;
            short n1copia = n1;
            int n1copia2 = n1copia;


            float n2 = 4.5f;
            double n2copia = n2;


            //Explicitas: Pasamos un valor de una variable de mayor capacidad a otra de menor capacidad
            int numero1 = 240;
            short numero1Copia = (short)numero1;
            short numero1Copia2 = Convert.ToInt16(numero1);
            

            double numero2 = 5.678;
            float numero2Copia = (float)numero2;
            float numero2Copia2 = Convert.ToSingle(numero2);


            //Son inseguras: Dos tipos de problemas
            //            :( Overflow       
            short n3 = 30;
           // byte n3Copia = (byte)n3;
           byte n3Copia2 = Convert. ToByte(n3);

            Console.WriteLine("n3= " + n3);
            Console.WriteLine("n3Copia = " + n3Copia2);
           

            // :( perdida de precisión
            float r1 = 9.56f;
            int r1Copia = (int)r1;
            Console.WriteLine("r1 = " + r1);
            Console.WriteLine("r1Copia = " + r1Copia);    

            Console.ReadLine();

        }

    }
}
