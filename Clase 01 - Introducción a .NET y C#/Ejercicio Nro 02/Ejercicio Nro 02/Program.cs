using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Error al cubo";

            int numero;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar numero!");
            }
            else 
            {
                Console.WriteLine($"Cuadrado de {numero} = {Math.Pow(numero, 2)}\n" +
                    $"Cubo de {numero} = {Math.Pow(numero, 3)}");
            }

            Console.ReadKey();
        }
    }
}
