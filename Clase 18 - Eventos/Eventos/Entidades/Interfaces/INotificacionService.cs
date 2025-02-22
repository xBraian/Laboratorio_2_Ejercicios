using System;

namespace Entidades.Interfaces
{
    public interface INotificacionService
    {
        event EventHandler<NotificacionEventArgs> NotificacionRecibida;

        void Notificar(string mensaje);
    }
}
