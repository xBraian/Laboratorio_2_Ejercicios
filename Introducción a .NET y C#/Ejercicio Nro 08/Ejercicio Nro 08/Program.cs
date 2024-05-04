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
            Console.Title = "Dibujando un triángulo rectángulo";

            int altura;
            string dibujo = string.Empty;

            Console.Write("Ingrese altura del triangulo: ");
            altura = int.Parse(Console.ReadLine());

            for (int i = 0; i < altura; i++)
            {
                if (i == 0)
                {
                    dibujo = "*";
                }
                else
                {
                    dibujo += "**";
                }
                Console.WriteLine(dibujo);
            }

            Console.ReadKey();
        }
    }
}
