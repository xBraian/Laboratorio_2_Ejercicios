using System;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Division(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }
            return dividendo / divisor;
        }

        public static double RaizCuadrada(double radicando)
        {
            if (radicando < 0) 
            {
                throw new ArgumentException();
            }
            return Math.Sqrt(radicando);
        }
    }
}
