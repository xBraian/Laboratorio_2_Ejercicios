using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sumador
    {
        private int _cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            _cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {
        }

        public int Cantidad { get => _cantidadSumas; set => _cantidadSumas = value; }

        public long Sumar(long x, long y)
        {
            _cantidadSumas++;
            return x + y;
        }

        public string Sumar(string x, string y)
        {
            _cantidadSumas++;
            return x + y;
        }

        public static explicit operator int(Sumador s)
        {
            return s._cantidadSumas;
        }

        public static long operator +(Sumador x, Sumador y)
        {
            return x._cantidadSumas + y._cantidadSumas;
        }

        public static bool operator |(Sumador x, Sumador y)
        {
            return x._cantidadSumas == y._cantidadSumas;
        }
    }
}
