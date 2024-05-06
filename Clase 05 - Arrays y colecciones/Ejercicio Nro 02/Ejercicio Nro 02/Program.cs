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
            Console.Title = "Números locos II";

            const int cantidad = 20;
            List<int> lista = GenerarListaEnteros(cantidad, -100, 100);
            Stack<int> stack = GenerarStackEnteros(cantidad, -1000, 1000);
            Queue<int> queue = GenerarQueueEnteros(cantidad, -10000, 10000);

            Console.WriteLine("LISTA DE ENTEROS\n" +
                "------------------------------\n" +
                MostrarEnteros(lista));

            Console.WriteLine("LISTA ORDENADA\n" +
                "\nPOSITIVOS\n" +
                "------------------------------\n" +
                $"{MostrarEnteros(OrdenarPositivos(lista))}" +
                "\nNEGATIVOS\n" +
                "------------------------------\n" +
                $"{MostrarEnteros(OrdenarNegativos(lista))}");

            Console.ReadKey();

            Console.WriteLine("STACK DE ENTEROS\n" +
                "------------------------------\n" +
                MostrarEnteros(stack));

            Console.WriteLine("STACK ORDENADA\n" +
                "\nPOSITIVOS\n" +
                "------------------------------\n" +
                $"{MostrarEnteros(OrdenarPositivos(stack))}" +
                "\nNEGATIVOS\n" +
                "------------------------------\n" +
                $"{MostrarEnteros(OrdenarNegativos(stack))}");

            Console.ReadKey();

            Console.WriteLine("QUEUE DE ENTEROS\n" +
                "------------------------------\n" +
                MostrarEnteros(queue));

            Console.WriteLine("QUEUE ORDENADA\n" +
                "\nPOSITIVOS\n" +
                "------------------------------\n" +
                $"{MostrarEnteros(OrdenarPositivos(queue))}" +
                "\nNEGATIVOS\n" +
                "------------------------------\n" +
                $"{MostrarEnteros(OrdenarNegativos(queue))}");

            Console.ReadKey();
        }

        static List<int> GenerarListaEnteros(int cantidad, int minimo, int maximo)
        {
            List<int> enteros = new List<int>();
            Random random = new Random();
            int auxiliar;
            for (int i = 0; i < cantidad; i++)
            {
                auxiliar = random.Next(minimo, maximo);
                if (auxiliar == 0)
                {
                    i--;
                }
                else
                {
                    enteros.Add(auxiliar);
                }
            }
            return enteros;
        }

        static Stack<int> GenerarStackEnteros(int cantidad, int minimo, int maximo)
        {
            Stack<int> enteros = new Stack<int>();
            Random random = new Random();
            int auxiliar;
            for (int i = 0; i < cantidad; i++)
            {
                auxiliar = random.Next(minimo, maximo);
                if (auxiliar == 0)
                {
                    i--;
                }
                else
                {
                    enteros.Push(auxiliar);
                }
            }
            return enteros;
        }

        static Queue<int> GenerarQueueEnteros(int cantidad, int minimo, int maximo)
        {
            Queue<int> enteros = new Queue<int>();
            Random random = new Random();
            int auxiliar;
            for (int i = 0; i < cantidad; i++)
            {
                auxiliar = random.Next(minimo, maximo);
                if (auxiliar == 0)
                {
                    i--;
                }
                else
                {
                    enteros.Enqueue(auxiliar);
                }
            }
            return enteros;
        }

        static string MostrarEnteros<T>(T coleccion) where T : IEnumerable<int>
        {
            StringBuilder informacion = new StringBuilder();
            foreach (int numero in coleccion)
            {
                informacion.AppendLine(numero.ToString());
            }
            return informacion.ToString();
        }

        static List<int> ObtenerPositivos<T>(T coleccion) where T : IEnumerable<int>
        {
            List<int> auxiliar = new List<int>();
            foreach (int numero in coleccion)
            {
                if (numero > 0)
                {
                    auxiliar.Add(numero);
                }
            }
            return auxiliar;
        }

        static List<int> OrdenarPositivos<T>(T coleccion) where T : IEnumerable<int>
        {
            List<int> auxiliar = ObtenerPositivos(coleccion);
            auxiliar.Sort();
            auxiliar.Reverse();
            return auxiliar;
        }

        static List<int> ObtenerNegativos<T>(T coleccion) where T : IEnumerable<int>
        {
            List<int> auxiliar = new List<int>();
            foreach (int numero in coleccion)
            {
                if (numero < 0)
                {
                    auxiliar.Add(numero);
                }
            }
            return auxiliar;
        }

        static List<int> OrdenarNegativos<T>(T coleccion) where T : IEnumerable<int>
        {
            List<int> auxiliar = ObtenerNegativos(coleccion);
            auxiliar.Sort();
            return auxiliar;
        }
    }
}
