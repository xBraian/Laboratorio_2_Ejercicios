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
            Console.Title = "Validador de rangos";

            const int rangoMinimo = -100;
            const int rangoMaximo = 100;
            const int numeroIngresos = 10;
            int numeroMinimo = 0;
            int numeroMaximo = 0;
            int sumatoria = 0;
            bool valorInicial = true;

            for (int i = 0; i < numeroIngresos; i++)
            {
                Console.Write("Ingrese numero: ");
                int numero = int.Parse(Console.ReadLine());
                if (Validador.Validar(numero, rangoMinimo, rangoMaximo))
                {
                    if (valorInicial)
                    {
                        valorInicial = false;
                        numeroMinimo = numero;
                        numeroMaximo = numero;
                    }
                    else if (numero < numeroMinimo)
                    {
                        numeroMinimo = numero;
                    }
                    else if (numero > numeroMaximo)
                    {
                        numeroMaximo = numero;
                    }
                    sumatoria += numero;
                }
                else
                {
                    Console.WriteLine($"ERROR. Numero fuera de rango. Su numero: {numero}.");
                    i--;
                }
            }

            Console.WriteLine($"Minimo: {numeroMinimo}\nMaximo: {numeroMaximo}\nPromedio: {(Decimal)sumatoria / numeroIngresos}");

            Console.ReadKey();
        }
    }

    public static class Validador
    {
        public static bool Validar(int valor, int minimo, int maximo)
        {
            return minimo <= valor && valor <= maximo;
        }
    }
}
