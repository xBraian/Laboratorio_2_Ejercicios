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
            Console.Title = "¿Desea continuar?";

            int suma = 0;

            do
            {
                Console.Write("Ingrese un numero: ");
                int numero = int.Parse(Console.ReadLine());
                suma += numero;
                Console.Write("¿Continuar? 'S' / 'N' : ");
            } while (Validar.Respuesta(char.Parse(Console.ReadLine())));

            Console.WriteLine($"Total: {suma}");

            Console.ReadKey();
        }
    }

    public static class Validar
    {
        public static bool Respuesta(char respuesta)
        {
            return char.ToUpper(respuesta) == 'S';
        }
    }
}
