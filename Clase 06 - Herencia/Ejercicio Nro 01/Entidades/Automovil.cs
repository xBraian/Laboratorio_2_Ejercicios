using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        private short _cantidadMarchas;
        private int _cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, int cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            _cantidadMarchas = cantidadMarchas;
            _cantidadPasajeros = cantidadPasajeros;
        }

        public short Marchas { get => _cantidadMarchas; set => _cantidadMarchas = value; }

        public int Pasajeros { get => _cantidadPasajeros; set => _cantidadPasajeros = value; }
    }
}
