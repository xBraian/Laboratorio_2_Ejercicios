using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades 
{
    public class Camion : VehiculoTerrestre
    {
        private int _pesoCarga;
        private short _cantidadMarchas;

        public Camion(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, int pesoCarga)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            _cantidadMarchas = cantidadMarchas;
            _pesoCarga = pesoCarga;
        }

        public short Marchas { get => _cantidadMarchas; set => _cantidadMarchas = value; }

        public int PesoCarga { get => _pesoCarga; set => _pesoCarga = value; }
    }
}
