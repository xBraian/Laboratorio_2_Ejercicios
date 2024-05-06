using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        private short _cantidadCombustible;
        private bool _enCompetencia;
        private string _escuderia;
        private short _numero;
        private short _vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            _numero = numero;
            _escuderia = escuderia;
            _enCompetencia = false;
            _cantidadCombustible = 0;
            _vueltasRestantes = 0;
        }

        public short Combustible { get => _cantidadCombustible; set => _cantidadCombustible = value; }

        public bool EnCompetencia { get => _enCompetencia; set => _enCompetencia = value; }

        public short Vueltas { get => _vueltasRestantes; set => _vueltasRestantes = value; }

        public string MostrarDatos()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Numero: {_numero}");
            informacion.AppendLine($"Escuderia: {_escuderia}");
            informacion.AppendLine($"Cantidad combustible: {_cantidadCombustible}");
            informacion.AppendLine($"Vueltas Restantes: {_vueltasRestantes}");
            return informacion.ToString();
        }

        public static bool operator ==(AutoF1 x, AutoF1 y)
        {
            return x._numero == y._numero && x._escuderia == y._escuderia;
        }

        public static bool operator !=(AutoF1 x, AutoF1 y)
        {
            return !(x == y);
        }
    }
}
