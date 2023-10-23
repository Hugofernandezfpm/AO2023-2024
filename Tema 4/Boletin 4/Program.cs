using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejercicio = 0;

            Console.WriteLine("Introducir ejercicio: 4-8");
            ejercicio = int.Parse(Console.ReadLine());

            if (ejercicio == 4)
            {
                //Pico ejercicio 4

                //Escribir un programa que lea tres números y muestre por pantalla la media aritmética.
                //Si la media es superior a 5 mandará un mensaje de  “Alumno aprobado”.
                //En cualquier otro caso el mensaje indica: “Alumno suspenso”. 

                int Alumnoaprobado = 3;

                if (Alumnoaprobado > 5)
                {
                    Console.WriteLine("Alumno aprobado");
                }
                else
                {
                    Console.WriteLine("alumno suspenso");
                }

               
            }


            else if (ejercicio == 5)
            {
                //Pico ejercicio 5

                //Diseñar un programa que lea
                //(es decir solicita al usuario que los introduzca por teclado)
                //dos números reales, los guarde en dos variables de tipo double
                //calcule su suma guardándola en una variable, SI ES POSITIVA
                //mostrar por pantalla la raíz cuadrada de la suma
                //(usar la clase Math.sqrt(variable)),  en cualquier otro caso
                //muestra un mensaje informando de que no se puede calcular la raíz.

                Console.WriteLine("Introduzca el primer numero: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduzca el segundo numero: ");
                double numero2 = double.Parse(Console.ReadLine());

                double suma = numero1 + numero2;


                if (suma > 0)
                {
                    double raiz = Math.Sqrt(suma);   //se mete aqui en vez de arriba por
                                                     //que dice que se calcule la raiz si numero es
                                                     //mayor a 0 osino no
                    Console.WriteLine("La raiz es " + raiz);
                }
                else
                {
                    Console.WriteLine("No se puede calcular la raiz");
                }
                
            }
            else if (ejercicio == 6)
            {
                //Pico ejercicio 6

                //Escribir un programa que solicite al usuario una contraseña
                //que se guardará en una variable de tipo String.
                //El programa debe tener almacenada la contraseña
                //previamente en otra variable. Si las dos contraseñas son iguales
                //manda un mensaje diciendo que la contraseña es correcta
                //en otro caso indica que no lo es.

                string contraseñaCorrecta = "patata"; //va entre comillas por que un string siempre se escribe entre comillas
                Console.WriteLine("Escribe la contraseña: ");
                string contraseña = Console.ReadLine(); //no se escribe con .Parse por que ya estamos usando una string

                if (contraseña == contraseñaCorrecta)
                {
                    Console.WriteLine("La contraseña es correcta");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta");

                }
            }
            else if (ejercicio == 7)
            {
                //Pico ejercicio 7

                //Diseñar un programa que lea dos números
                //y calcule el mayor elevado al más pequeño
                //(usar la clase Math.pow (base,exponente).

                Console.WriteLine("Introduzca el primer numero: ");
                int Primernumero = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduza el segudo numero: ");
                int Segundonumero = int.Parse(Console.ReadLine());
                int resultado = 0;

                if (Primernumero > Segundonumero)
                {
                    resultado = (int)Math.Pow(Primernumero, Segundonumero);
                    Console.WriteLine("El resultado es:" + resultado);
                }
                else if (Segundonumero > Primernumero)
                {
                    resultado = (int)Math.Pow(Segundonumero, Primernumero);

                    Console.WriteLine("El resultado es:" + resultado);
                   
                }
            }
            else if (ejercicio == 8)
            {
                //Pico ejercicio 8

                //Debido al sobrepeso Homer tiene que realizar su actividad laboral desde casa,
                //para ello la central necesita realizar un programa que lo ayude a gestionar
                //la seguridad de la central. Esta aplicación medirá la presión
                //y la temperatura del núcleo. Si la presión es superior a 2 atm debe mostrar
                //el mensaje “Abrir válvula de seguridad”.Si la temperatura supera los 500 Kelvin
                //el mensaje debe ser “Reducir la temperatura. Si suceden ambas situaciones
                //debe mostrar ambos mensajes. Si no debe aparecer “Todo en orden”.

                int presion, temperatura;
                Console.WriteLine("Introduzca la temperatura ");
                temperatura = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduca presion: ");
                presion = int.Parse(Console.ReadLine());

                if (presion < 2 && temperatura < 500)
                {
                    Console.WriteLine("Todo en orden");
                }
                else if (presion > 2)
                {
                    Console.WriteLine("Abrir valvula de seguridad");
                }
                else if (temperatura > 500)
                {
                    Console.WriteLine("Reducir la temperatura");
                }
                else
                {
                    Console.WriteLine("Este ejercicio no existe");
                    
                }
            }
            else if (ejercicio == 9)
            {
                //Pico ejercicio 9

                //Diseñar un programa que lea un número y si es múltiplo de 2 o de 3
                //mande un mensaje informando de tal situación,
                //en caso de que no lo sea no hará nada.

                Console.WriteLine("Introduzca el numero");
                int numero = int.Parse(Console.ReadLine());



               

            }
            else if (ejercicio == 10)
            {

                //Pico ejercicio 10
            }
            else if (ejercicio == 11)
            {

                //Pico ejercicio 11
            }
            else if (ejercicio == 12)
            {
                //Pico ejercicio 12

            }
            else if (ejercicio == 13)
            {
                //Pico ejercicio 13

            }
            else if (ejercicio == 14)
            {
                //Pico ejercicio 14

            }
            else if (ejercicio == 15)
            {
                //Pico ejercicio 15

            }
            else if (ejercicio == 16)
            {

            }
            else if (ejercicio == 17)
            {

            }
            else if (ejercicio == 18)
            {

            }
            else if (ejercicio == 19)
            {

            }
            else if (ejercicio == 20)
            {

            }
            else if (ejercicio == 21)
            {

            }
            else if (ejercicio == 22)
            {

            }
            else if (ejercicio == 23)
            {

            }
            Console.ReadLine() ;    
        }
    }
}

