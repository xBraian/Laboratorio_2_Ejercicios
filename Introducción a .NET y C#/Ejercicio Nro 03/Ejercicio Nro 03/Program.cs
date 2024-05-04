using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Los primos";

            string primos = string.Empty;

            do
            {
                Console.Write("Ingrese un numero: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    if (EsPrimo(numero))
                    {
                        primos += numero.ToString() + '\n';
                    }
                }
                else
                {
                    Console.WriteLine("ERROR. Debe ingresar un valor numerico.");
                }
                Console.Write("¿Salir? SI - NO: ");
            } while (Console.ReadLine().ToLower() != "si");

            Console.WriteLine("LISTADO DE NUMEROS PRIMOS\n" +
                primos);

            Console.ReadKey();
        }

        public static bool EsPrimo(int numero)
        {
            int cantidadDivisores = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    cantidadDivisores++;
                }
                if (cantidadDivisores > 2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
