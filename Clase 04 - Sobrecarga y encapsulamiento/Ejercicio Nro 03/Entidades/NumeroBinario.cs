using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroBinario
    {
        private string _numero;

        private NumeroBinario(string numero)
        {
            _numero = numero;
        }

        public string Numero { get => _numero; }

        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            double auxiliar = Conversor.BinarioADecimal(b._numero);
            return Conversor.DecimalABinario(auxiliar + d.Numero);
        }

        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            double auxiliar = Conversor.BinarioADecimal(b._numero);
            return Conversor.DecimalABinario(auxiliar - d.Numero);
        }

        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            double auxiliar = Conversor.BinarioADecimal(b._numero);
            return auxiliar == d.Numero;
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b == d);
        }

        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator string(NumeroBinario b)
        {
            return b.Numero;
        }
    }
}
