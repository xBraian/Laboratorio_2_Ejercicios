using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Recibo de sueldo";

            int antiguedad;
            int horas;
            int cantidadEmpleados;
            float valorHora;
            float sueldoBruto;
            float sueldoNeto;
            string nombre;
            StringBuilder informacion = new StringBuilder();

            Console.Write("Ingrese la cantidad de empleados: ");
            cantidadEmpleados = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.Write("Ingrese nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese años de antiguedad: ");
                antiguedad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el valor/hora: $");
                valorHora = float.Parse(Console.ReadLine());
                Console.Write("Ingrese horas trabajadas: ");
                horas = int.Parse(Console.ReadLine());
                Console.WriteLine();

                sueldoBruto = (valorHora * horas) + (antiguedad * 150);
                sueldoNeto = sueldoBruto - (sueldoBruto * 13 / 100);

                informacion.AppendLine($"Nombre: {nombre}");
                informacion.AppendLine($"Años de antiguedad: {antiguedad}");
                informacion.AppendLine($"Valor/Hora: ${valorHora:#,###.00}");
                informacion.AppendLine($"Horas trabajadas: {horas}");
                informacion.AppendLine($"Sueldo bruto: ${sueldoBruto:#,###.00}");
                informacion.AppendLine($"Sueldo neto: ${sueldoNeto:#,###.00}");
                informacion.AppendLine();
            }

            Console.WriteLine(informacion.ToString());

            Console.ReadKey();
        }
    }
}
