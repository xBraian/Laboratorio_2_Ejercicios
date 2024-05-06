using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades 
{
    public class Moto : VehiculoTerrestre
    {
        private short _cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, EColores color, short cilindrada) : base(cantidadRuedas, cantidadPuertas, color)
        {
            _cilindrada = cilindrada;
        }

        public short Cilindrada { get => _cilindrada; set => _cilindrada = value; }
    }
}
