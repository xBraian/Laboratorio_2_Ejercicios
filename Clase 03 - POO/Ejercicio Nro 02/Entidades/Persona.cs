using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string _nombre;
        private DateTime _fechaNacimiento;
        private int _dni;

        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            _nombre = nombre;
            _fechaNacimiento = fechaNacimiento;
            _dni = dni;
        }

        private int CalcularEdad()
        {
            int edad = DateTime.Now.Year - _fechaNacimiento.Year;
            if (DateTime.Now.Month < _fechaNacimiento.Month ||
                (DateTime.Now.Month == _fechaNacimiento.Month && DateTime.Now.Day < _fechaNacimiento.Day))
            {
                edad--;
            }
            return edad;
        }

        public string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Nombre: {_nombre}");
            informacion.AppendLine($"DNI: {_dni}");
            informacion.AppendLine($"Fecha de nacimiento: {_fechaNacimiento:dd/MM/yyyy}");
            informacion.AppendLine($"Edad: {this.CalcularEdad()}");
            return informacion.ToString();
        }

        public string EsMayor()
        {
            if (this.CalcularEdad() >= 18)
            {
                return "Mayor de edad.";
            }
            return "Menor de edad.";
        }
    }
}
