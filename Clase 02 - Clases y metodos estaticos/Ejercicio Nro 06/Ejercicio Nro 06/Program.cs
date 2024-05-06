using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora de áreas";

            double longitudLado = 3;
            double baseTriangulo = 5;
            double altura = 3;
            double radio = 6;

            Console.WriteLine($"Area de cuadrado: {CalculadoraDeArea.CalcularAreaCuadrado(longitudLado):#,###.00}\n" +
                $"Area de triangulo: {CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, altura):#,###.00}\n" +
                $"Area de circulo: {CalculadoraDeArea.CalcularAreaCirculo(radio):#,###.00}");

            Console.ReadKey();
        }
    }

    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return longitudLado * longitudLado;
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            return baseTriangulo * altura / 2;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * (radio * radio);
        }
    }
}
