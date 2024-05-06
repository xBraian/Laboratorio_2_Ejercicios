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
            Console.Title = "Números locos";

            const int minimo = -1000;
            const int maximo = 1001;
            int[] numeros = GenerarEnteros(new int[20], minimo, maximo);
            int[] positivos = OrdenarPositivos(numeros);
            int[] negativos = OrdenarNegativos(numeros);

            Console.WriteLine($"LISTADO DE NUMEROS\n" +
                MostrarEnteros(numeros) +
                "\n");

            Console.WriteLine($"LISTADO DE POSITIVOS\n" +
                MostrarEnteros(positivos) +
                "\n");

            Console.WriteLine($"LISTADO DE NEGATIVOS\n" +
                MostrarEnteros(negativos));

            Console.ReadKey();
        }

        static int[] GenerarEnteros(int[] numeros, int minimo = int.MinValue, int maximo = int.MaxValue)
        {
            Random random = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(minimo, maximo);
                if (numeros[i] == 0)
                {
                    i--;
                }
            }
            return numeros;
        }

        static string MostrarEnteros(int[] numeros)
        {
            StringBuilder informacion = new StringBuilder();
            for (int i = 0; i < numeros.Length; i++)
            {
                informacion.AppendLine(numeros[i].ToString());
            }
            return informacion.ToString();
        }

        static int ContarPositivos(int[] numeros)
        {
            int contador = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    contador++;
                }
            }
            return contador;
        }

        static int[] ObtenerPositivos(int[] numeros)
        {
            int[] auxiliar = new int[ContarPositivos(numeros)];
            int indice = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    auxiliar[indice] = numeros[i];
                    indice++;
                }
            }
            return auxiliar;
        }

        static int[] OrdenarPositivos(int[] numeros)
        {
            int[] positivos = ObtenerPositivos(numeros);
            int auxiliar;
            bool ejecutar;
            do
            {
                ejecutar = false;
                for (int i = 0; i < positivos.Length - 1; i++)
                {
                    if (positivos[i] < positivos[i + 1])
                    {
                        auxiliar = positivos[i];
                        positivos[i] = positivos[i + 1];
                        positivos[i + 1] = auxiliar;
                        ejecutar = true;
                    }
                }
            } while (ejecutar);
            return positivos;
        }

        static int ContarNegativos(int[] numeros)
        {
            int contador = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    contador++;
                }
            }
            return contador;
        }

        static int[] ObtenerNegativos(int[] numeros)
        {
            int[] auxiliar = new int[ContarNegativos(numeros)];
            int indice = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    auxiliar[indice] = numeros[i];
                    indice++;
                }
            }
            return auxiliar;
        }

        static int[] OrdenarNegativos(int[] numeros)
        {
            int[] negativos = ObtenerNegativos(numeros);
            int auxiliar;
            bool ejecutar;
            do
            {
                ejecutar = false;
                for (int i = 0; i < negativos.Length - 1; i++)
                {
                    if (negativos[i] > negativos[i + 1])
                    {
                        auxiliar = negativos[i];
                        negativos[i] = negativos[i + 1];
                        negativos[i + 1] = auxiliar;
                        ejecutar = true;
                    }
                }
            } while (ejecutar);
            return negativos;
        }
    }
}
