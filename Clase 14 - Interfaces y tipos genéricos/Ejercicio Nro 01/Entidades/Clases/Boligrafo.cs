using Entidades.Interfaces;
using System;
using System.Text;

namespace Entidades.Clases
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor _colorTinta;
        private float _tinta;

        public ConsoleColor Color
        {
            get
            {
                return _colorTinta;
            }
            set
            {
                _colorTinta = value;
            }
        } 

        public float UnidadesDeEscritura
        {
            get
            {
                return _tinta;
            }
            set
            {
                _tinta = value;
            }
        }

        public Boligrafo(int unidades, ConsoleColor color) 
        { 
            _tinta = unidades;
            _colorTinta = color;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return null;
            }
            float aux = _tinta;
            aux -= texto.Length * 0.3F;
            if (aux < 0)
            {
                return null;
            }
            _tinta = aux;
            return new EscrituraWrapper(texto, _colorTinta);
        }

        public bool Recargar(int unidades)
        {
            if (unidades < 0)
            {
                return false;
            }
            _tinta += unidades;
            if (_tinta > 100)
            {
                _tinta = 100;
            }
            return true;    
        }

        public override string ToString()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine(GetType().Name);
            informacion.AppendLine($"Color: {_colorTinta}");
            informacion.AppendLine($"Nivel de tinta: {_tinta}");
            return informacion.ToString(); 
        }
    }
}
