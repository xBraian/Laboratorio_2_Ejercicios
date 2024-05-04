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
            Console.Title = "Conversor binario";

            Console.WriteLine(Conversor.ConvertirDecimalABinario(7));
            Console.WriteLine(Conversor.ConvertirBinarioADecimal(1111));

            Console.ReadKey();
        }
    }

    public static class Conversor
    {
        public static string ConvertirDecimalABinario(int numero)
        {
            int cociente;
            string resto = "";
            do
            {
                cociente = numero / 2;
                resto = (numero % 2).ToString() + resto;
                numero = cociente;
            } while (cociente != 0);
            return resto;
        }

        public static int ConvertirBinarioADecimal(int numero)
        {
            int potencia = 0;
            int numeroDecimal = 0;
            int numeroElevado;
            string numeroBinario = numero.ToString();
            for (int i = numeroBinario.Length - 1; i >= 0; i--)
            {
                numeroElevado = 1;
                for (int j = 0; j < potencia; j++)
                {
                    numeroElevado *= 2;
                }
                potencia++;
                numeroDecimal += int.Parse(numeroBinario[i].ToString()) * numeroElevado;
            }
            return numeroDecimal;
        }
    }
}
