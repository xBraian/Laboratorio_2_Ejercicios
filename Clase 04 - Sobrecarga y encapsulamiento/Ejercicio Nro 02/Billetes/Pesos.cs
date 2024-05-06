using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double _cantidad;
        private static double _cotzRespectoDolar;

        static Pesos()
        {
            _cotzRespectoDolar = 102.65;
        }

        public Pesos(double cantidad)
        {
            _cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) 
            : this(cantidad)
        {
            _cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return _cantidad;
        }

        public static double GetCotizacion()
        {
            return _cotzRespectoDolar;
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p._cantidad / GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p);
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p._cantidad == d.GetCantidad();
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return p._cantidad == e.GetCantidad();
        }

        public static bool operator ==(Pesos x, Pesos y)
        {
            return x._cantidad == y._cantidad;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator !=(Pesos x, Pesos y)
        {
            return !(x == y);
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p._cantidad + ((Pesos)d)._cantidad);
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p._cantidad + ((Pesos)e)._cantidad);
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p._cantidad - ((Pesos)d)._cantidad);
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p._cantidad - ((Pesos)e)._cantidad);
        }
    }
}
