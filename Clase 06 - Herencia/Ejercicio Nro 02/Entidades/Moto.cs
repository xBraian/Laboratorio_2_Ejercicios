using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        public Moto(string patente, byte cantidadRuedas, EMarcas marca, float cilindrada)
            : base(patente, cantidadRuedas, marca)
        {
            _cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.Append(base.Mostrar());
            informacion.AppendLine($"Cilindrada: {_cilindrada}cc");
            return informacion.ToString();
        }
    }
}
