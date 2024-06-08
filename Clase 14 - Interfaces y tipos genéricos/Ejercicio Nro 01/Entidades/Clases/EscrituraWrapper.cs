using System;

namespace Entidades
{
    public class EscrituraWrapper
    {
        public string texto;
        public ConsoleColor color;

        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.texto = texto;
            this.color = color;
        }
    }
}
