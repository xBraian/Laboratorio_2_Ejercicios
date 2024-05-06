using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        protected readonly string _patente;
        protected Byte _cantidadRuedas;
        protected EMarcas _marca;

        public Vehiculo(string patente, byte cantidadRuedas, EMarcas marca)
        {
            _patente = patente;
            _cantidadRuedas = cantidadRuedas;
            _marca = marca;
        }

        public enum EMarcas
        {
            Honda,
            Ford,
            Zanella,
            Scania,
            Iveco,
            Fiat
        }

        public EMarcas Marca { get => _marca; }

        public string Patente { get => _patente; }

        protected string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Patente: {_patente}");
            informacion.AppendLine($"Cantidad ruedas: {_cantidadRuedas}");
            informacion.AppendLine($"Marca: {_marca}");
            return informacion.ToString();
        }

        public static bool operator ==(Vehiculo x, Vehiculo y)
        {
            return x._patente == y._patente && x._marca == y._marca;
        }

        public static bool operator !=(Vehiculo x, Vehiculo y)
        {
            return !(x == y);
        }
    }
}
