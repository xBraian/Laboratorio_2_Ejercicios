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
            Console.Title = "Maximo, minimo y promedio";

            int numero;
            int minimo = 0;
            int maximo = 0;
            int suma = 0;
            float promedio;
            bool valorInicial = true;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                if (valorInicial)
                {
                    valorInicial = false;
                    minimo = numero;
                    maximo = numero;
                }
                else if (numero < minimo)
                {
                    minimo = numero;
                }
                else if (numero > maximo)
                {
                    maximo = numero;
                }
                suma += numero;
            }

            promedio = (float)suma / 5;

            Console.WriteLine($"Minimo: {minimo}\n" +
                $"Maximo: {maximo}\n" +
                $"Promedio: {promedio}");

            Console.ReadKey();
        }
    }
}
