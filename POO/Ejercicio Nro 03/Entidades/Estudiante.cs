using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        private string _apellido;
        private string _legajo;
        private string _nombre;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private Random _random;

        public Estudiante(string apellido, string legajo, string nombre, Random random)
        {
            _apellido = apellido;
            _legajo = legajo;
            _nombre = nombre;
            _random = random;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            _notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            _notaSegundoParcial = nota;
        }

        private double CalcularPromedio()
        {
            return (_notaPrimerParcial + _notaSegundoParcial) / (double)2;
        }

        public int CalcularNotaFinal()
        {
            if (CalcularPromedio() >= 4)
            {
                return _random.Next(6, 11);
            }
            return -1;
        }

        public string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Nombre: {_nombre}");
            informacion.AppendLine($"Apellido: {_apellido}");
            informacion.AppendLine($"Legajo: {_legajo}");
            informacion.AppendLine($"Nota primer parcial: {_notaPrimerParcial}");
            informacion.AppendLine($"Nota segundo parcial: {_notaSegundoParcial}");
            if (CalcularNotaFinal() == -1)
            {
                informacion.AppendLine($"Alumno desaprobado.");
            }
            else
            {
                informacion.AppendLine($"Nota final: {CalcularNotaFinal()}");
            }
            return informacion.ToString();
        }
    }
}
