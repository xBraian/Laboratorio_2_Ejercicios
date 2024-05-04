using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Años bisiestos";

            int anioMinimo;
            int anioMaximo;

            Console.Write("Ingrese un año minimo: ");
            anioMinimo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un año maximo: ");
            anioMaximo = int.Parse(Console.ReadLine());
            Console.WriteLine("LISTADO AÑOS BISIESTOS");

            for (int i = anioMinimo; i <= anioMaximo; i++)
            {
                if (EsBisiesto(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }

        public static bool EsBisiesto(int anio)
        {
            if ((anio % 4 == 0 && !(anio % 100 == 0)) || (anio % 100 == 0 && anio % 400 == 0))
            {
                return true;
            }
            return false;
        }
    }
}
