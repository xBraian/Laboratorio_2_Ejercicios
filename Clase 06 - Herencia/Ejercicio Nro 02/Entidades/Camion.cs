using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : Vehiculo
    {
        protected float _tara;

        public Camion(string patente, byte cantidadRuedas, EMarcas marca, float tara)
            : base(patente, cantidadRuedas, marca)
        {
            _tara = tara;
        }

        public string MostrarCamion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.Append(base.Mostrar());
            informacion.AppendLine($"Tara: {_tara}Kg");
            return informacion.ToString();
        }
    }
}
