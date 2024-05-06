using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Kelvin
    {
        private float _grados;

        private Kelvin(float grados)
        {
            _grados = grados;
        }

        public float Grados { get => _grados; }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            Fahrenheit f = k._grados * 9 / 5 - 459.67F;
            return f;
        }

        public static explicit operator Celsius(Kelvin k)
        {
            Fahrenheit f = (Fahrenheit)k;
            return (Celsius)f;
        }

        public static implicit operator Kelvin(float grados)
        {
            return new Kelvin(grados);
        }
    }
}
