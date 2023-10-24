using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO.Ports;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

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
                double Primernumero = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduza el segudo numero: ");
                double Segundonumero = double.Parse(Console.ReadLine());
                double resultado = 0;

                if (Primernumero > Segundonumero)
                {
                    resultado = Math.Pow(Primernumero, Segundonumero);
                    Console.WriteLine("El resultado es:" + resultado);
                }
                else 
                {
                    resultado = Math.Pow(Segundonumero, Primernumero);

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
                double numero = double.Parse(Console.ReadLine());

                if (numero %2 == 0 || numero %3 == 0)
                {
                    Console.WriteLine("Es multiplo de 2 o 3");
                }
                else
                {
                    Console.WriteLine();
                }
               

            }
            else if (ejercicio == 10)
            {

                //Pico ejercicio 10

                //Diseñar un programa que aplique un descuento del 10% si el precio de un producto es inferior a 100
                //y del 15% si es superior.

                Console.WriteLine("Introduzca el precio del producto");
                double precio = double.Parse(Console.ReadLine());

                if (precio < 100)
                {
                   double descuento = precio * 0.10;
                    descuento = precio - descuento;
                    Console.WriteLine("El precio seria: " + descuento);
                }
                else
                {
                    double descuento2 = precio * 0.15;
                    descuento2 = precio - descuento2;
                    Console.WriteLine("El precio seria: " + descuento2);
                }

            }
            else if (ejercicio == 11)
            {

                //Pico ejercicio 11

                //Realizar un programa que lea una calificación en una variable real y
                //decida qué nota tiene según el siguiente criterio :
                //menor que 0  o mayor que  10 = error de nota
                // 0 a < 5.0 = suspenso
                // 5.0 a < 6.5 = aprobado
                // 6.5 a <  8.5 = notable
                // 8.5 a 10 = sobresaliente

                Console.WriteLine("Introduzca la nota");
                double nota = double.Parse(Console.ReadLine());

                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("Error de nota");
                }
                else if (nota == 0 || nota < 5.0)
                {
                    Console.WriteLine("Suspenso");
                }
                else if (nota == 5 || nota < 6.5)
                {
                    Console.WriteLine("Aprobado");
                }
                else if (nota == 6.5 || nota < 8.5)
                {
                    Console.WriteLine("Notable");
                }
                else
                {
                    Console.WriteLine("Sobresaliente");
                }
            }
            else if (ejercicio == 12)
            {
                //Pico ejercicio 12

                //Escribir un programa que lea un número y si ese número es múltiplo de 4, entonces le suma 25,
                //sino si es múltiplo de 5 le suma 50 y en otro caso le suma 100. Debe mostrar el valor inicial
                //y final del número introducido.

                Console.WriteLine("Introduzca un numero");
                double numero = double.Parse(Console.ReadLine());

                if (numero % 4 == 0)
                {
                    double resultado = numero + 25;
                    Console.WriteLine("El valor inicial es " + numero);
                    Console.WriteLine("El valor final es: " + resultado);
                }
                else if (numero % 5 == 0)
                {
                    double resultado2 = numero + 50;
                    Console.WriteLine("El valor inicial es " + numero);
                    Console.WriteLine("El valor final es " + resultado2);
                }
                else
                {
                    double resultado3 = numero + 100;
                    Console.WriteLine("El valor inicial es " + numero);
                    Console.WriteLine("El valor final es " + resultado3);
                }

            }
            else if (ejercicio == 13)
            {
                //Pico ejercicio 13

                //Escribir un programa  que evalúe el valor de una variable decimal llamada “temp” , y escriba uno de los
                //siguientes mensajes dependiendo de su valor:	
                //SÓLIDO: Si el valor de temp es menor que cero.
                // LÍQUIDO: Si el valor de temp se encuentra entre cero y 100.
                // VAPOR: Si el valor de temp es superior a 100.
                // PLASMA: Si la temperatura superior 1000000

                Console.WriteLine("Introduzca la temperatura");
                double temperatura = double.Parse(Console.ReadLine());

                if ( temperatura < 0)
                {
                    Console.WriteLine("La temperatura esta en estado Solido");
                }
                else if (temperatura == 0 || temperatura <= 100)
                {
                    Console.WriteLine("La temperatura esta en estado Líquido");
                }
                else if (temperatura > 100 && temperatura <= 1000000)
                {
                    Console.WriteLine("La temperatura esta en estado de Vapor");
                }
                else
                {
                    Console.WriteLine("La temperatura esta en estado de Plasma");
                }
            }
            else if (ejercicio == 14)
            {
                //Pico ejercicio 14

                //Mostrar al usuario un menú con las opciones:
                //Sumar
                //Restar//Multiplicar
                //Dividir
                //Raiz de la suma
                //Una vez leida la opción , se le solicitan dos números y se realiza la operación indicada.

                /*char opcion 


                //Console.WriteLine("Introduzca el primer numero");
                double numero = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduzca el segudo numero");
                double numero2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (opcion)*/
            }
            else if (ejercicio == 15)
            {
                //Pico ejercicio 15
                //-Los primeros 50 litros son gratis:
                //Pago = 0
                //-Entre 50 y 200 litros se cobra el litro a 4,75 euros.
                // Pago = (Nº Litros – 50)*4,75
                //-A partir de 200 litros se cobra el litro a 20 euros
                // Pago = (Nº Litros - 200)*20 + 150 * 4,75
                //La cuota mínima es de 45 euros, es decir que si el dinero a
                //pagar resulta menor de 45  euros, entonces será de 45 euros.
                //Realice un programa que calcule el gasto de agua de una
                //familia en un mes dada la cantidad de litros gastada.

                Console.WriteLine("Introduzca el numero de litros gastados en el mes");
                double litros = double.Parse(Console.ReadLine());

                double pago = 0;

                if (litros <= 50)
                {
                    double pagofinal = pago;
                    Console.WriteLine("El pago seria de " + pagofinal);
                }
                else if (litros == 50 || litros <= 200)
                {
                    pago = (litros - 50) * 4.75;
                    double pagofinal2 = pago;
                    Console.WriteLine("El pago seria de " + pagofinal2);
                }
                else if (litros >= 200)
                {
                    pago = (litros - 200) * 20 + 150 * 4.75;
                    double pagofinal3 = pago;
                    Console.WriteLine("El pago seria de " + pagofinal3);
                }
                if (pago <= 45)
                {
                    pago = 45;
                    double pagofinal4 = pago;
                    Console.WriteLine("El pago final seria de " + pagofinal4);
                }
                     




            }
                else if (ejercicio == 16)
            {
                    //Pico ejercicio 16

                    //Desarrollar un programa que lea el precio  de 3 artículos, que muestre la suma total de los precios
                    //de dichos artículos e imprima la cantidad total a pagar que se debe calcular de acuerdo con la siguiente
                    //clasificación:
                    //a) Si la suma de los precios es menor de 500.00 no hay ningún descuento.
                    //b) Si la suma de los precios está entre 500.00 y 1,000.00 € se le descuenta el 3 % del total.
                    //c) Si la suma de los precios es mayor de 1,000.00 y menor de 2,000.00 se le descuenta el 5 % del total.
                    //d) Si la suma de los precios es mayor o igual a 2,000.00 y menor o igual a3,000.00 se le descuenta el 7 % del total.
                    //e) Si la suma de los precios es mayor de 3,000.00 se le descuenta el 10 % del total

                    

                  
            }
                else if (ejercicio == 17)
            {
                    //Pico ejercicio 17

                    //Se desea calcular el salario bruto y neto semanal de los trabajadores de una empresa
                    //de acuerdo a las siguientes normas. 
                    // Para el salario bruto:
                    //a.Si las horas semanales trabajadas son <= 38, el salario bruto será igual
                    //a las horas trabajadas por la tasa a la que se paga la hora.
                    //b.Horas extras(más de 38), a una tasa 50 por 100 superior a la ordinaria.

                    //Una vez calculado el salario bruto, el salario neto se calcula de la siguiente forma:
                    //a.Impuestos 0 por 100, si el salario bruto es menor o igual a 300 euros.
                    //b.Impuestos del 10 por ciento, si el salario bruto es mayor a 300 euros.

                    //Realizar un programa que solicite la tasa por hora y las horas trabajadas y calcule el
                    //salario neto y el bruto.Escribir primero el DFD y luego tratar de implementarlo en código.

            }
            else if (ejercicio == 18)
            {
                //Pico ejercicio 18

                //Escribe una instrucción switch que examine el valor de una variable entera llamada “indicador”  y escriba uno de los siguientes mensajes:
                //CALOR, si el indicador tiene valor 1
                //TEMPLADO, si tiene valor 2
                //FRIO, si tiene valor 3
                //FUERA DE RANGO, si tiene valor 4
                
            }
            else if (ejercicio == 19)
            {
                //Pico ejercicio 19

                //Escribe una instrucción Select que examine el valor de una variable de tipo Char llamada “color”  y escriba uno de los siguientes mensajes:
                //ROJO, si vale “r” ó “R”
                //VERDE, si vale “v” ó “V”
                //AZUL, si vale “a” ó “A”
                //NEGRO, si tiene asignado cualquier otro caracter.
               

            }
            else if (ejercicio == 20)
            {
                //Pico ejercicio 20

                //Realizar un programa que indique cuantas cifras tiene un número. Hasta 6 cifras.
                
            }
            else if (ejercicio == 21)
            {
                //Pico ejercicio 21

                //Realizar un programa que resuelva una ecuación de segundo grado.
                // ax2 + bx + c = 0

            }
            else if (ejercicio == 22)
            {
                //Pico ejercicio 22

                //Escribir un programa que determine si un año es bisiesto.
                //Un año es bisiesto si es múltiplo de 4 (por ejemplo 1984).
                //Sin embargo los años múltiplos de 100 (aunque sean múltiplos de 4)
                //sólo son bisiestos si a la vez son múltiplos de 400.(Por ejemplo 1800
                //no es bisiesto pero 2000 sí lo fue).

            }
            else if (ejercicio == 23)
            {
                //Pico ejercicio 23

                //Escribir un programa que ordene tres números de menor a mayor.







            }
            Console.ReadLine() ;    
        }
    }
}

