using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sobre-sobrescribiendo esas advertencias";

            Sobrescrito objetoSobrescrito = new SobreSobrescrito();

            Console.WriteLine(objetoSobrescrito.ToString());
            
            string objeto = "¡Este es mi método ToString sobrescrito!";
            
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));
            Console.WriteLine("----------------------------------------------");
            
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.WriteLine($"Mi propiedad: {objetoSobrescrito.MiPropiedad}");
            Console.WriteLine($"Mi metodo: {objetoSobrescrito.MiMetodo()}");

            Console.ReadKey();
        }
    }
}
