using Entidades.Interfaces;
using System;

namespace Entidades.Clases
{
    public class NotificationManager
    {
        private readonly INotificacionService _notificationService;

        public NotificationManager(INotificacionService notificacionService)
        {
            _notificationService = notificacionService;
            _notificationService.NotificacionRecibida += ManejarNotificacion;
        }

        private void ManejarNotificacion(object sender, NotificacionEventArgs notificacion)
        {
            Console.WriteLine($"Notificacion recibida - {notificacion.Mensaje}");
        }

        public void EnviarNotificacion(string mensaje)
        {
            _notificationService.Notificar(mensaje);
        }
    }
}
