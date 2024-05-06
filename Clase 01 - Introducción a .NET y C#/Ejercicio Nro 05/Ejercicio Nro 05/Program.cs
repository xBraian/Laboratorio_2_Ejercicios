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
            Console.Title = "Tírame un centro";

            int numero;
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("LISTADO DE CENTROS NUMERICOS");

            for (int i = 1; i <= numero; i++)
            {
                if (EsCentroNumerico(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }

        public static bool EsCentroNumerico(int numero)
        {
            int primerGrupo = 0;
            int segundoGrupo = 0;
            for (int i = 0; i < numero; i++)
            {
                primerGrupo += i;
            }
            for (int i = numero + 1; ; i++)
            {
                segundoGrupo += i;
                if (primerGrupo == segundoGrupo)
                {
                    return true;
                }
                else if (primerGrupo < segundoGrupo)
                {
                    return false;
                }
            }
        }
    }
}
