using Entidades;
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
            Console.Title = "Calculadora de formas";

            List<Figura> figuras = new List<Figura>();
            Figura circulo = new Circulo(7);
            Figura cuadrado = new Cuadrado(4);
            Figura rectangulo = new Rectangulo(10, 15);
            int contador = 1;

            figuras.Add(circulo);
            figuras.Add(cuadrado);
            figuras.Add(rectangulo);

            foreach (Figura f in figuras)
            {
                Console.WriteLine($"=============== FIGURA {contador:D2} ==================\n" +
                    $"Tipo: {f.GetType().Name}\n" +
                    $"{f.Dibujar()}\n" +
                    $"Area: {f.CalcularSuperficie():.##}\n" +
                    $"Perimetro: {f.CalcularPerimetro():.##}\n" +
                    $"============================================\n");
                contador++;
            }

            Console.ReadKey();
        }
    }
}
