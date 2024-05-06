using Entidades;
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
            Console.Title = "Conversor binario recargado";

            NumeroBinario numeroBinario = "1111";
            NumeroDecimal numeroDecimal = 15;
            NumeroBinario numeroBinarioDos = "111";
            NumeroDecimal numeroDecimalDos = 5;

            string sumaBinario = numeroBinario + numeroDecimal;
            double sumaDecimal = numeroDecimal + numeroBinario;
            string restaBinario = numeroBinarioDos - numeroDecimalDos;
            double restaDecimal = numeroDecimalDos - numeroBinarioDos;

            Console.WriteLine($"Numero binario: {numeroBinario.Numero}\n" +
                $"Numero decimal: {numeroDecimal.Numero}");
            Console.WriteLine($"¿{numeroBinario.Numero} Binario es igual a {numeroDecimal.Numero} Decimal? " +
                $"{numeroBinario == numeroDecimal}");
            Console.WriteLine($"Suma en binario: {sumaBinario}\n" +
                $"Suma en decimal: {sumaDecimal}\n");

            Console.WriteLine($"Numero binario: {numeroBinarioDos.Numero}\n" +
                $"Numero decimal: {numeroDecimalDos.Numero}");
            Console.WriteLine($"¿{numeroBinarioDos.Numero} Binario es igual a {numeroDecimalDos.Numero} Decimal? " +
                $"{numeroBinarioDos == numeroDecimalDos}");
            Console.WriteLine($"Resta en binario: {restaBinario}\n" +
                $"Resta en decimal: {restaDecimal}");

            Console.ReadKey();
        }
    }
}
