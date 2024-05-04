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
            Console.Title = "La calculadora";

            decimal primerOperando;
            decimal segundoOperando;
            char operacion;

            do
            {
                Console.Write("Ingrese primer numero: ");
                primerOperando = decimal.Parse(Console.ReadLine());
                Console.Write("Ingrese segundo numero: ");
                segundoOperando = decimal.Parse(Console.ReadLine());
                Console.Write("Ingrese la operacion (+, -, *, /): ");
                operacion = char.Parse(Console.ReadLine());

                Console.WriteLine($"Operacion: {primerOperando} {operacion} {segundoOperando} = " +
                    $"{Calculadora.Calcular(primerOperando, segundoOperando, operacion)}");

                Console.Write("¿Continuar? S / N: ");
            } while (char.ToLower(char.Parse(Console.ReadLine())) == 's');
        }
    }

    public static class Calculadora
    {
        public static decimal Calcular(decimal primerOperando, decimal segundoOperando, char operacion)
        {
            decimal retorno = -1;
            switch (operacion)
            {
                case '+':
                    retorno = primerOperando + segundoOperando;
                    break;
                case '-':
                    retorno = primerOperando - segundoOperando;
                    break;
                case '*':
                    retorno = primerOperando * segundoOperando;
                    break;
                case '/':
                    if (Validar(segundoOperando))
                    {
                        retorno = primerOperando / segundoOperando;
                    }
                    break;
            }
            return retorno;
        }

        private static bool Validar(decimal divisor)
        {
            return divisor != 0;
        }
    }
}
