using Entidades;
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
            Console.Title = "Invento argentino";

            Boligrafo azul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo rojo = new Boligrafo(ConsoleColor.Red, 50);
            string auxiliar;
            StringBuilder dibujoAzul = new StringBuilder();
            StringBuilder dibujoRojo = new StringBuilder();

            Console.WriteLine("Boligrafo 'Azul'\n" +
                $"Cantidad de tinta inicial: {azul.GetTinta()}.");
            azul.Pintar(-25, out auxiliar);
            Console.ForegroundColor = azul.GetColor();
            dibujoAzul.Append("Dibujo: ");
            dibujoAzul.Append(auxiliar);
            Console.WriteLine($"{dibujoAzul}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Cantidad de tinta actual: {azul.GetTinta()}.\n");

            Console.WriteLine("Boligrafo 'Rojo'\n" +
                $"Cantidad de tinta inicial: {rojo.GetTinta()}.");
            rojo.Recargar();
            Console.WriteLine($"Cantidad de tinta luego de recarga: {rojo.GetTinta()}.");
            rojo.Pintar(10, out auxiliar);
            Console.ForegroundColor = rojo.GetColor();
            dibujoRojo.Append("Dibujo: ");
            dibujoRojo.Append(auxiliar);
            Console.WriteLine($"{dibujoRojo}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Cantidad de tinta actual: {rojo.GetTinta()}.");

            Console.ReadKey();
        }
    }
}
