using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "El tiempo pasa...";

            Console.Write("Ingrese dia de nacimiento: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Ingrese mes de nacimiento: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ingrese anio de nacimiento: ");
            int anio = int.Parse(Console.ReadLine());
            DateTime fechaNacimiento = new DateTime(anio, mes, dia);

            Console.WriteLine($"Cantidad de dias: {ContarDias(fechaNacimiento):#,###.00}");

            Console.ReadKey();
        }

        public static double ContarDias(DateTime fechaNacimiento)
        {
            TimeSpan diferencia = DateTime.Now - fechaNacimiento;
            return diferencia.TotalDays;
        }
    }
}
