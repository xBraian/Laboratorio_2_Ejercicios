using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fahrenheit 451";

            Celsius c = 30;
            Fahrenheit f = 105;
            Kelvin k = 500;

            Console.WriteLine($"C°: {c.Grados}\n" +
                $"C° -> F°: {((Fahrenheit)c).Grados:#,###.00}\n" +
                $"C° -> K°: {((Kelvin)c).Grados:#,###.00}\n");

            Console.WriteLine($"F°: {f.Grados}\n" +
                $"F° -> C°: {((Celsius)f).Grados:#,###.00}\n" +
                $"F° -> K°: {((Kelvin)f).Grados:#,###.00}\n");

            Console.WriteLine($"K°: {k.Grados}\n" +
                $"K° -> C°: {((Celsius)k).Grados:#,###.00}\n" +
                $"K° -> F°: {((Fahrenheit)k).Grados:#,###.00}");

            Console.ReadKey();
        }
    }
}
