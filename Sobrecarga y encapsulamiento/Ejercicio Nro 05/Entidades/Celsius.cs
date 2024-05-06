using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celsius
    {
        private float _grados;

        private Celsius(float grados)
        {
            _grados = grados;
        }

        public float Grados { get => _grados; }

        public static explicit operator Fahrenheit(Celsius c)
        {
            Fahrenheit f = c._grados * 9 / 5 + 32;
            return f;
        }

        public static explicit operator Kelvin(Celsius c)
        {
            Fahrenheit f = (Fahrenheit)c;
            return (Kelvin)f;
        }

        public static implicit operator Celsius(float grados)
        {
            return new Celsius(grados);
        }
    }
}
