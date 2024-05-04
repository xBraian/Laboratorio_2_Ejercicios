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
            Console.Title = "Pitágoras estaría orgulloso";

            double catetoUno;
            double catetoDos;
            double hipotenusa;

            Console.Write("Ingrese la altura del triangulo: ");
            catetoUno = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la base del triangulo: ");
            catetoDos = double.Parse(Console.ReadLine());
            hipotenusa = Math.Sqrt(Math.Pow(catetoUno, 2) + Math.Pow(catetoDos, 2));
            Console.WriteLine($"Hipotenusa = {hipotenusa:#,###.00}");

            Console.ReadKey();
        }
    }
}
