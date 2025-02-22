using System;

namespace Entidades
{
    public class NotificacionEventArgs : EventArgs
    {
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
            set => _mensaje = value;
        }

        public NotificacionEventArgs(string mensaje)
        {
                _mensaje = mensaje;
        }
    }
}
