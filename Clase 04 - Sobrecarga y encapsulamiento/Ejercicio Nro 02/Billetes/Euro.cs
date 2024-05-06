using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double _cantidad;
        private static double _cotzRespectoDolar;

        static Euro()
        {
            _cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad)
        {
            _cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) 
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

        public static explicit operator Dolar(Euro e)
        {
            return e._cantidad / GetCotizacion();
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)((Dolar)e);
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e._cantidad == d.GetCantidad();
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return e._cantidad == p.GetCantidad();
        }

        public static bool operator ==(Euro x, Euro y)
        {
            return x._cantidad == y._cantidad;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator !=(Euro x, Euro y)
        {
            return !(x == y);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e._cantidad + ((Euro)d)._cantidad);
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e._cantidad + ((Euro)p)._cantidad);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e._cantidad - ((Euro)d)._cantidad);
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e._cantidad + ((Euro)p)._cantidad);
        }
    }
}
