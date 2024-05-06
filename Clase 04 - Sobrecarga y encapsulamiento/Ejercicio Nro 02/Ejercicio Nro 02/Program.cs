using Billetes;
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
            Console.Title = "Cotizador";

            Dolar dolar = 100;
            Pesos pesos = 1000;
            Euro euro = 50;
            Euro euroADolar = euro + dolar;
            Euro euroAPesos = euro + pesos;

            Console.WriteLine($"Cantidad de dolares: ${dolar.GetCantidad()}\n" +
                $"Cantidad de pesos: ${pesos.GetCantidad()}\n" +
                $"Cantidad de euros: ${euro.GetCantidad()}\n");
            Console.WriteLine($"Conversion {euro.GetCantidad()} {EBilletes.Euro} a {EBilletes.Dolar} -> {((Dolar)euro).GetCantidad()}\n" +
                $"Conversion {euro.GetCantidad()} {EBilletes.Euro} a {EBilletes.Pesos} -> {((Pesos)euro).GetCantidad()}\n");
            Console.WriteLine($"Suma de euros y pesos -> {euroAPesos.GetCantidad()}\n" +
                $"Suma de euros y dolares -> {euroADolar.GetCantidad()}\n");
            Console.WriteLine($"¿{dolar.GetCantidad()} {EBilletes.Dolar} es igual a {pesos.GetCantidad()} {EBilletes.Pesos}? {dolar == pesos}");

            Console.ReadKey();
        }
    }
}
