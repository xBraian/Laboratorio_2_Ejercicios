using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> _equipos;
        private string _nombre;

        /*
            Agregue el atributo _rng (Random Number Generator), para evitar problemas de aleatoriedad.
        */
        private static Random _rng;

        public string JugarPartido
        {
            get
            {
                T equipoX;
                T equipoY;
                do
                {
                    equipoX = _equipos[_rng.Next(0, _equipos.Count)];
                    equipoY = _equipos[_rng.Next(0, _equipos.Count)];
                } while (equipoX.Equals(equipoY));
                return CalcularPartido(equipoX, equipoY);
            }
        }

        //Agregue el constructor estatico para inicializar el atributo _rng.
        static Torneo()
        {
            _rng = new Random();
        }

        private Torneo() 
        {
            _equipos = new List<T>();
        }

        public Torneo(string nombre) 
            : this()
        {
            _nombre = nombre;
        }

        public string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Nombre del torneo: {_nombre}");
            foreach (T equipo in _equipos)
            {
                informacion.AppendLine(equipo.Ficha());
            }
            return informacion.ToString();
        }

        private string CalcularPartido(T equipoX, T equipoY)
        {
            return $"{equipoX.Nombre} {_rng.Next(0, 10)} - {_rng.Next(0, 10)} {equipoY.Nombre}";
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo == equipo)
            {
                Console.WriteLine($"El equipo {equipo.Nombre} ya esta inscripto.");
            }
            else
            {
                torneo._equipos.Add(equipo);
            }
            return torneo;
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            return torneo._equipos.Contains(equipo);
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
    }
}
