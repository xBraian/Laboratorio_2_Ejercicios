using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dibujando un triángulo equilátero";

            int cantidad = 1;
            Console.Write("Ingrese la altura del triangulo: ");
            int altura = int.Parse(Console.ReadLine());
            int espacios = altura - 1;

            for (int i = 0; i < altura; i++)
            {
                Console.Write(new string(' ', espacios));
                Console.WriteLine(new string('*', cantidad));
                cantidad += 2;
                espacios--;
            }

            Console.ReadKey();
        }
    }
}
