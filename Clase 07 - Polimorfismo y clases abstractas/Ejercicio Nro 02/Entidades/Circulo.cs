using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Circulo : Figura
    {
        private float _radio;

        public Circulo(float radio)
        {
            _radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando circulo.";
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * _radio;
        }

        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(_radio, 2);
        }
    }
}
