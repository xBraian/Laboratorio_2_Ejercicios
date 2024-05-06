using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {
        private string _nombre;
        private string _especie;
        private DateTime _fechaNacimiento;
        private string _vacuna;

        public Mascota(string nombre, string especie, DateTime fechaNacimiento)
        {
            _nombre = nombre;
            _especie = especie;
            _fechaNacimiento = fechaNacimiento;
            _vacuna = string.Empty;
        }

        private string Capitalizar()
        {
            return char.ToUpper(_nombre[0]) + _nombre.Substring(1).ToLower();
        }

        public void EstablecerVacuna(string vacuna)
        {
            _vacuna = vacuna;
        }

        public string VerInformacion()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Nombre mascota: {Capitalizar()}");
            informacion.AppendLine($"Especie: {_especie}");
            informacion.AppendLine($"Fecha de nacimiento: {_fechaNacimiento:dd/MMM/yyyy}");
            informacion.AppendLine($"Vacuna: {_vacuna}");
            return informacion.ToString();
        }
    }
}
