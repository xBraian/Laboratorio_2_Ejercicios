using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int _dni;
        private string _nombre;
        private int _partidosJugados;
        private float _promedioGoles;
        private int _totalGoles;

        private Jugador()
        {
            _partidosJugados = 0;
            _promedioGoles = 0;
            _totalGoles = 0;
        }

        public Jugador(int dni, string nombre) 
            : this()
        {
            _dni = dni;
            _nombre = nombre;
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) 
            : this(dni, nombre)
        {
            _partidosJugados = partidosJugados;
            _totalGoles = totalGoles;
            _promedioGoles = GetPromedioGoles();
        }

        public float GetPromedioGoles()
        {
            return (float)_totalGoles / _partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Nombre: {_nombre}");
            informacion.AppendLine($"DNI: {_dni}");
            informacion.AppendLine($"Partidos jugados: {_partidosJugados}");
            informacion.AppendLine($"Total goles: {_totalGoles}");
            informacion.AppendLine($"Promedio goles: {_promedioGoles:0.00}");
            return informacion.ToString();
        }

        public static bool operator ==(Jugador x, Jugador y)
        {
            return x._dni == y._dni;
        }

        public static bool operator !=(Jugador x, Jugador y)
        {
            return !(x == y);
        }
    }
}
