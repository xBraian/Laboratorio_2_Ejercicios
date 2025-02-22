using Entidades.Interfaces;
using System;

namespace Entidades.Clases
{
    public class SmsNotificationService : INotificacionService
    {
        public event EventHandler<NotificacionEventArgs> NotificacionRecibida;

        public void Notificar(string mensaje)
        {
            NotificacionRecibida.Invoke(this, new NotificacionEventArgs($"SMS: {mensaje}"));
        }
    }
}
