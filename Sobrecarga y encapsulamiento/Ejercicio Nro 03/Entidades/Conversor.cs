using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conversor
    {
        public static string DecimalABinario(double numero)
        {
            int cociente;
            string resto = string.Empty;
            do
            {
                cociente = (int)numero / 2;
                resto = (numero % 2).ToString() + resto;
                numero = cociente;
            } while (cociente != 0);
            return resto;
        }

        public static int BinarioADecimal(string numero)
        {
            int potencia = 0;
            int numeroDecimal = 0;
            string numeroBinario = numero.ToString();
            for (int i = numeroBinario.Length - 1; i >= 0; i--)
            {
                int numeroElevado = 1;
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
