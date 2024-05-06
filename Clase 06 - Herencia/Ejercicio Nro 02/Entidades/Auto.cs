using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        protected int _cantidadAsientos;

        public Auto(string patente, byte cantidadRuedas, EMarcas marca, int cantidadAsientos)
            : base(patente, cantidadRuedas, marca)
        {
            _cantidadAsientos = cantidadAsientos;
        }

        public string MostrarAuto()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.Append(base.Mostrar());
            informacion.AppendLine($"Cantidad de asientos: {_cantidadAsientos}");
            return informacion.ToString();
        }
    }
}
