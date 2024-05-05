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
            Console.Title = "Prueba de geometría";

            Rectangulo rectangulo = new Rectangulo(new Punto(2, 4), new Punto(8, 12));

            Console.WriteLine("Datos del rectangulo\n" +
                $"{rectangulo.Mostrar()}");

            Console.ReadKey();
        }
    }
}
