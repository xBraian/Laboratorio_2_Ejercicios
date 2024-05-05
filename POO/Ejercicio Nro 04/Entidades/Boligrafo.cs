using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        private const short _cantidadMaximaTinta = 100;
        private ConsoleColor _color;
        private short _tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            _color = color;
            _tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return _color;
        }

        public short GetTinta()
        {
            return _tinta;
        }

        private void SetTinta(short cantidad)
        {
            short auxiliar = _tinta;
            auxiliar = (short)(auxiliar + cantidad);
            if (auxiliar >= 0 && auxiliar <= _cantidadMaximaTinta)
            {
                _tinta = auxiliar;
            }
        }

        public void Recargar()
        {
            SetTinta((short)(_cantidadMaximaTinta - _tinta));
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            gasto = (short)(Math.Abs(gasto) * (-1));
            StringBuilder miDibujo = new StringBuilder();
            short auxiliar = _tinta;
            SetTinta(gasto);
            if (_tinta == auxiliar)
            {
                dibujo = string.Empty;
                return false;
            }
            for (int i = 0; i < Math.Abs(gasto); i++)
            {
                miDibujo.Append("*");
            }
            dibujo = miDibujo.ToString();
            return true;
        }
    }
}
