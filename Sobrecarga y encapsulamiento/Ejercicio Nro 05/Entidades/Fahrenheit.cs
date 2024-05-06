using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fahrenheit
    {
        private float _grados;

        private Fahrenheit(float grados)
        {
            _grados = grados;
        }

        public float Grados { get => _grados; }

        public static explicit operator Celsius(Fahrenheit f)
        {
            Celsius c = (f._grados - 32) * 5 / 9;
            return c;
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            Kelvin k = (f._grados + 459.67F) * 5 / 9;
            return k;
        }

        public static implicit operator Fahrenheit(float grados)
        {
            return new Fahrenheit(grados);
        }
    }
}
