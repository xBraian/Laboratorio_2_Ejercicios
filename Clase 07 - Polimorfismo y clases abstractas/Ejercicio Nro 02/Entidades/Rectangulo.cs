using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {
        private float _longitudAltura;
        private float _longitudBase;

        public Rectangulo(float longitudAltura, float longitudBase)
        {
            _longitudAltura = longitudAltura;
            _longitudBase = longitudBase;
        }

        public override string Dibujar()
        {
            return "Dibujando rectangulo.";
        }

        public override double CalcularPerimetro()
        {
            return (2 * _longitudAltura) + (2 * _longitudBase);
        }

        public override double CalcularSuperficie()
        {
            return _longitudAltura * _longitudBase;
        }

    }
}
