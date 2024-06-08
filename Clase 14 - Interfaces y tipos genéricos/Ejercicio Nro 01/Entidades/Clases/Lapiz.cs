using Entidades.Interfaces;
using System;
using System.Text;

namespace Entidades.Clases
{
    public class Lapiz : IAcciones
    {   
        private float _tamanioMina;

        ConsoleColor IAcciones.Color 
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException("No es posible modificar el color.");
            } 
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return _tamanioMina;
            }
            set
            {
                _tamanioMina = value;
            }
        }

        public Lapiz(float tamanioMina)
        {
            _tamanioMina = tamanioMina;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return null;
            }
            float aux = _tamanioMina;
            aux -= texto.Length * 0.1F;
            if (aux < 0)
            {
                return null;
            }
            _tamanioMina = aux;
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException("No es posible recargar.");
        }

        public override string ToString()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine(GetType().Name);
            informacion.AppendLine($"Color: {((IAcciones)this).Color}");
            informacion.AppendLine($"Tamaño de mina: {_tamanioMina}");
            return informacion.ToString();
        }
    }
}
