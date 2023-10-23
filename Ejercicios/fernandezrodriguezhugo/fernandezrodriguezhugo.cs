using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fernandezrodriguezhugo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las horas trabajadas en un mes: ");
            double horasTrabajadas = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tasa por hora: ");
            double tasaPorHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje de IRPF: ");
            double irpf = double.Parse(Console.ReadLine());

            double salarioBruto = horasTrabajadas * tasaPorHora;

            double impuesto = (irpf / 100) * salarioBruto;

            double salarioNeto = salarioBruto - impuesto;

            Console.WriteLine("Salario bruto:" + salarioBruto);
            Console.WriteLine("Impuesto (IRPF):" + impuesto);
            Console.WriteLine("Salario neto:" + salarioNeto);

            Console.ReadLine();
        }
    }
}
