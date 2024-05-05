using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private string _domicilio;
        private int _telefono;
        private Mascota _mascota;

        public Cliente(string nombre, string apellido, string domicilio, int telefono)
        {
            _nombre = nombre;
            _apellido = apellido;
            _domicilio = domicilio;
            _telefono = telefono;
            _mascota = null;
        }

        public void EstablecerMascota(Mascota mascota)
        {
            if (_mascota is null)
            {
                _mascota = mascota;
            }
        }

        public void AplicarVacuna(string vacuna)
        {
            _mascota.EstablecerVacuna(vacuna);
        }

        private string Capitalizar()
        {
            return char.ToUpper(_nombre[0]) + _nombre.Substring(1).ToLower();
        }

        public string VerInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine("DATOS CLIENTE");
            informacion.AppendLine($"Apellido: {_apellido.ToUpper()}");
            informacion.AppendLine($"Nombre: {Capitalizar()}");
            informacion.AppendLine($"Domicilio: {_domicilio}");
            informacion.AppendLine($"N° Telefono: {_telefono}");
            informacion.AppendLine("DATOS MASCOTA");
            informacion.AppendLine(_mascota.VerInformacion());
            return informacion.ToString();
        }
    }
}
