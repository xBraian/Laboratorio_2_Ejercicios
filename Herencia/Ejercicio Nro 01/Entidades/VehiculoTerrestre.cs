using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoTerrestre
    {
        protected short _cantidadRuedas;
        protected short _cantidadPuertas;
        protected EColores _color;

        protected VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColores color)
        {
            _cantidadRuedas = cantidadRuedas;
            _cantidadPuertas = cantidadPuertas;
            _color = color;
        }

        public short Ruedas { get => _cantidadRuedas; set => _cantidadRuedas = value; }

        public short Puertas { get => _cantidadPuertas; set => _cantidadPuertas = value; }

        public EColores Color { get => _color; set => _color = value; }

        public string Tipo { get => GetType().Name; }
    }
}
