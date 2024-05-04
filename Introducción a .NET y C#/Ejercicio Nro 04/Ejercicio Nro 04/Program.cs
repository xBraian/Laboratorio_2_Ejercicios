using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Un número perfecto";

            int perfectosEncontrados = 0;
            
            Console.WriteLine("LISTADO DE NUMEROS PERFECTOS");
            
            for (int i = 1; ; i++)
            {
                if (EsPerfecto(i))
                {
                    Console.WriteLine(i);
                }
                if (perfectosEncontrados == 4)
                {
                    break;
                }
            }

            Console.ReadKey();
        }

        public static bool EsPerfecto(int numero)
        {
            int suma = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma += i;
                }
            }
            if (suma != numero)
            {
                return false;
            }
            return true;
        }
    }
}
