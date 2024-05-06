using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroDecimal
    {
        private double _numero;

        private NumeroDecimal(double numero)
        {
            _numero = numero;
        }

        public double Numero { get => _numero; }

        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            double auxiliar = Conversor.BinarioADecimal(b.Numero);
            return d._numero + auxiliar;
        }

        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            double auxiliar = Conversor.BinarioADecimal(b.Numero);
            return d._numero - auxiliar;
        }

        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            double auxiliar = Conversor.BinarioADecimal(b.Numero);
            return d.Numero == auxiliar;
        }

        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return !(d == b);
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator double(NumeroDecimal d)
        {
            return d.Numero;
        }
    }
}
