using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double _cantidad;
        private static double _cotzRespectoDolar;

        static Dolar()
        {
            _cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            _cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return _cantidad;
        }

        public static double GetCotizacion()
        {
            return _cotzRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            return Euro.GetCotizacion() * d._cantidad;
        }

        public static explicit operator Pesos(Dolar d)
        {
            return Pesos.GetCotizacion() * d._cantidad;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d._cantidad == e.GetCantidad();
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return d._cantidad == p.GetCantidad();
        }

        public static bool operator ==(Dolar x, Dolar y)
        {
            return x._cantidad == y._cantidad;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator !=(Dolar x, Dolar y)
        {
            return !(x == y);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return d._cantidad + ((Dolar)e)._cantidad;
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return d._cantidad + ((Dolar)p)._cantidad;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return d._cantidad - ((Dolar)e)._cantidad;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return d._cantidad - ((Dolar)p)._cantidad;
        }
    }
}
