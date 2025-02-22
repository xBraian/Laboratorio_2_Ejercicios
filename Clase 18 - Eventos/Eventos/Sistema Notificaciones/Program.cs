using System;
using Entidades.Clases;
using Entidades.Interfaces;

namespace Sistema_Notificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear servicios de notificación
            INotificacionService servicioEmail = new EmailNotificationService();
            INotificacionService servicioSms = new SmsNotificationService();

            // Crear gestores de notificación
            NotificationManager gestorEmail = new NotificationManager(servicioEmail);
            NotificationManager gestorSms = new NotificationManager(servicioSms);

            // Enviar notificaciones
            gestorEmail.EnviarNotificacion("¡Tienes un nuevo correo electrónico!");
            gestorSms.EnviarNotificacion("¡Tienes un nuevo SMS!");

            // Suscribirse a eventos adicionales usando lambdas
            servicioEmail.NotificacionRecibida += (sender, e) =>
            {
                Console.WriteLine($"Manejo adicional para correo electrónico - {e.Mensaje}");
            };
            servicioSms.NotificacionRecibida += (sender, e) =>
            {
                Console.WriteLine($"Manejo adicional para SMS - {e.Mensaje}");
            };

            // Enviar más notificaciones
            gestorEmail.EnviarNotificacion("¡Otra notificación de correo electrónico!");
            gestorSms.EnviarNotificacion("¡Otra notificación de SMS!");
            Console.ReadKey();
        }
    }
}
