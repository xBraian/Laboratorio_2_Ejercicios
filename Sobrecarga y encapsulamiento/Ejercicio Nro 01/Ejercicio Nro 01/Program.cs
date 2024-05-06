using Entidades;
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
            Console.Title = "Sumador";

            Sumador sumadorUno = new Sumador();
            Sumador sumadorDos = new Sumador(3);

            Console.WriteLine($"Test sumar: {sumadorUno.Sumar(2, 8)}\n" +
                $"Test concatenar: {sumadorUno.Sumar("!Hola ", "mundo¡")}\n");
            Console.WriteLine($"Cantidad sumas 'Sumador uno': {(int)(sumadorUno)}\n" +
                $"Cantidad sumas 'Sumador dos': {(int)(sumadorDos)}\n");
            Console.WriteLine($"Suma de cantidades: {sumadorUno + sumadorDos}\n");
            Console.WriteLine($"¿Tienen 'Sumador uno' y 'Sumador dos' la misma cantidad de sumas?: {sumadorUno | sumadorDos}");

            Console.ReadKey();
        }
    }
}
