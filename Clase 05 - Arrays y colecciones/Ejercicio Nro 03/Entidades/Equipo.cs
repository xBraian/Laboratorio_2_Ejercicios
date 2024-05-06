using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short _cantidadDeJugadores;
        private List<Jugador> _jugadores;
        private string _nombre;

        private Equipo()
        {
            _jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) 
            : this()
        {
            _cantidadDeJugadores = cantidad;
            _nombre = nombre;
        }

        public string Nombre { get => _nombre; }

        public string MostrarDatos()
        {
            StringBuilder informacion = new StringBuilder();
            foreach (Jugador jugador in _jugadores)
            {
                informacion.AppendLine(jugador.MostrarDatos());
            }
            return informacion.ToString();
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            foreach (Jugador jugador in e._jugadores)
            {
                if (jugador == j || e._jugadores.Count == e._cantidadDeJugadores)
                {
                    return false;
                }
            }
            e._jugadores.Add(j);
            return true;
        }
    }
}
