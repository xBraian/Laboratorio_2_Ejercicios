using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<AutoF1> _competidores;
        private Random _random;

        private Competencia()
        {
            _competidores = new List<AutoF1>();
            _random = new Random();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas) 
            : this()
        {
            _cantidadCompetidores = cantidadCompetidores;
            _cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder informacion = new StringBuilder();
            foreach (AutoF1 competidor in _competidores)
            {
                informacion.AppendLine(competidor.MostrarDatos());
            }
            return informacion.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c == a || c._cantidadCompetidores == c._competidores.Count)
            {
                return false;
            }
            a.EnCompetencia = true;
            a.Vueltas = c._cantidadVueltas;
            a.Combustible = (short)c._random.Next(15, 101);
            c._competidores.Add(a);
            return true;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 competidor in c._competidores)
            {
                if (competidor == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
