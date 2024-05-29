using System;

namespace Entidades
{
    public static class Calculador
    {
        public static double Dividir(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)x / y;
        }
    }
}
